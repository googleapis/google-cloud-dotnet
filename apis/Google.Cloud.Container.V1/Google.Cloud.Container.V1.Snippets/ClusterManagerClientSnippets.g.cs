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

// Ignore obsolete members within this file.
// This is currently a hand-written addition to the generated file, until the
// generator includes it automatically.
#pragma warning disable CS0612 // Type or member is obsolete

namespace Google.Cloud.Container.V1.Snippets
{
    using Google.Api.Gax;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedClusterManagerClientSnippets
    {
        /// <summary>Snippet for ListClusters</summary>
        public void ListClusters_RequestObject()
        {
            // Snippet: ListClusters(ListClustersRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest
            {
                ProjectId = "",
                Zone = "",
                Parent = "",
            };
            // Make the request
            ListClustersResponse response = clusterManagerClient.ListClusters(request);
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersAsync_RequestObject()
        {
            // Snippet: ListClustersAsync(ListClustersRequest, CallSettings)
            // Additional: ListClustersAsync(ListClustersRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest
            {
                ProjectId = "",
                Zone = "",
                Parent = "",
            };
            // Make the request
            ListClustersResponse response = await clusterManagerClient.ListClustersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListClusters</summary>
        public void ListClusters()
        {
            // Snippet: ListClusters(string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            // Make the request
            ListClustersResponse response = clusterManagerClient.ListClusters(projectId, zone);
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersAsync()
        {
            // Snippet: ListClustersAsync(string, string, CallSettings)
            // Additional: ListClustersAsync(string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            // Make the request
            ListClustersResponse response = await clusterManagerClient.ListClustersAsync(projectId, zone);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetCluster_RequestObject()
        {
            // Snippet: GetCluster(GetClusterRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                Name = "",
            };
            // Make the request
            Cluster response = clusterManagerClient.GetCluster(request);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterAsync_RequestObject()
        {
            // Snippet: GetClusterAsync(GetClusterRequest, CallSettings)
            // Additional: GetClusterAsync(GetClusterRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                Name = "",
            };
            // Make the request
            Cluster response = await clusterManagerClient.GetClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetCluster()
        {
            // Snippet: GetCluster(string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
            Cluster response = clusterManagerClient.GetCluster(projectId, zone, clusterId);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterAsync()
        {
            // Snippet: GetClusterAsync(string, string, string, CallSettings)
            // Additional: GetClusterAsync(string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
            Cluster response = await clusterManagerClient.GetClusterAsync(projectId, zone, clusterId);
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateCluster_RequestObject()
        {
            // Snippet: CreateCluster(CreateClusterRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                ProjectId = "",
                Zone = "",
                Cluster = new Cluster(),
                Parent = "",
            };
            // Make the request
            Operation response = clusterManagerClient.CreateCluster(request);
            // End snippet
        }

        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateClusterAsync_RequestObject()
        {
            // Snippet: CreateClusterAsync(CreateClusterRequest, CallSettings)
            // Additional: CreateClusterAsync(CreateClusterRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                ProjectId = "",
                Zone = "",
                Cluster = new Cluster(),
                Parent = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.CreateClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateCluster()
        {
            // Snippet: CreateCluster(string, string, Cluster, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            Cluster cluster = new Cluster();
            // Make the request
            Operation response = clusterManagerClient.CreateCluster(projectId, zone, cluster);
            // End snippet
        }

        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateClusterAsync()
        {
            // Snippet: CreateClusterAsync(string, string, Cluster, CallSettings)
            // Additional: CreateClusterAsync(string, string, Cluster, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            Cluster cluster = new Cluster();
            // Make the request
            Operation response = await clusterManagerClient.CreateClusterAsync(projectId, zone, cluster);
            // End snippet
        }

        /// <summary>Snippet for UpdateCluster</summary>
        public void UpdateCluster_RequestObject()
        {
            // Snippet: UpdateCluster(UpdateClusterRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                Update = new ClusterUpdate(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.UpdateCluster(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateClusterAsync</summary>
        public async Task UpdateClusterAsync_RequestObject()
        {
            // Snippet: UpdateClusterAsync(UpdateClusterRequest, CallSettings)
            // Additional: UpdateClusterAsync(UpdateClusterRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                Update = new ClusterUpdate(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.UpdateClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCluster</summary>
        public void UpdateCluster()
        {
            // Snippet: UpdateCluster(string, string, string, ClusterUpdate, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            ClusterUpdate update = new ClusterUpdate();
            // Make the request
            Operation response = clusterManagerClient.UpdateCluster(projectId, zone, clusterId, update);
            // End snippet
        }

        /// <summary>Snippet for UpdateClusterAsync</summary>
        public async Task UpdateClusterAsync()
        {
            // Snippet: UpdateClusterAsync(string, string, string, ClusterUpdate, CallSettings)
            // Additional: UpdateClusterAsync(string, string, string, ClusterUpdate, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            ClusterUpdate update = new ClusterUpdate();
            // Make the request
            Operation response = await clusterManagerClient.UpdateClusterAsync(projectId, zone, clusterId, update);
            // End snippet
        }

        /// <summary>Snippet for UpdateNodePool</summary>
        public void UpdateNodePool_RequestObject()
        {
            // Snippet: UpdateNodePool(UpdateNodePoolRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            UpdateNodePoolRequest request = new UpdateNodePoolRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                NodePoolId = "",
                NodeVersion = "",
                ImageType = "",
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.UpdateNodePool(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNodePoolAsync</summary>
        public async Task UpdateNodePoolAsync_RequestObject()
        {
            // Snippet: UpdateNodePoolAsync(UpdateNodePoolRequest, CallSettings)
            // Additional: UpdateNodePoolAsync(UpdateNodePoolRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateNodePoolRequest request = new UpdateNodePoolRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                NodePoolId = "",
                NodeVersion = "",
                ImageType = "",
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.UpdateNodePoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolAutoscaling</summary>
        public void SetNodePoolAutoscaling_RequestObject()
        {
            // Snippet: SetNodePoolAutoscaling(SetNodePoolAutoscalingRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetNodePoolAutoscalingRequest request = new SetNodePoolAutoscalingRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                NodePoolId = "",
                Autoscaling = new NodePoolAutoscaling(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetNodePoolAutoscaling(request);
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolAutoscalingAsync</summary>
        public async Task SetNodePoolAutoscalingAsync_RequestObject()
        {
            // Snippet: SetNodePoolAutoscalingAsync(SetNodePoolAutoscalingRequest, CallSettings)
            // Additional: SetNodePoolAutoscalingAsync(SetNodePoolAutoscalingRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetNodePoolAutoscalingRequest request = new SetNodePoolAutoscalingRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                NodePoolId = "",
                Autoscaling = new NodePoolAutoscaling(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetNodePoolAutoscalingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLoggingService</summary>
        public void SetLoggingService_RequestObject()
        {
            // Snippet: SetLoggingService(SetLoggingServiceRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetLoggingServiceRequest request = new SetLoggingServiceRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                LoggingService = "",
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetLoggingService(request);
            // End snippet
        }

        /// <summary>Snippet for SetLoggingServiceAsync</summary>
        public async Task SetLoggingServiceAsync_RequestObject()
        {
            // Snippet: SetLoggingServiceAsync(SetLoggingServiceRequest, CallSettings)
            // Additional: SetLoggingServiceAsync(SetLoggingServiceRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetLoggingServiceRequest request = new SetLoggingServiceRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                LoggingService = "",
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetLoggingServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLoggingService</summary>
        public void SetLoggingService()
        {
            // Snippet: SetLoggingService(string, string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string loggingService = "";
            // Make the request
            Operation response = clusterManagerClient.SetLoggingService(projectId, zone, clusterId, loggingService);
            // End snippet
        }

        /// <summary>Snippet for SetLoggingServiceAsync</summary>
        public async Task SetLoggingServiceAsync()
        {
            // Snippet: SetLoggingServiceAsync(string, string, string, string, CallSettings)
            // Additional: SetLoggingServiceAsync(string, string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string loggingService = "";
            // Make the request
            Operation response = await clusterManagerClient.SetLoggingServiceAsync(projectId, zone, clusterId, loggingService);
            // End snippet
        }

        /// <summary>Snippet for SetMonitoringService</summary>
        public void SetMonitoringService_RequestObject()
        {
            // Snippet: SetMonitoringService(SetMonitoringServiceRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetMonitoringServiceRequest request = new SetMonitoringServiceRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                MonitoringService = "",
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetMonitoringService(request);
            // End snippet
        }

        /// <summary>Snippet for SetMonitoringServiceAsync</summary>
        public async Task SetMonitoringServiceAsync_RequestObject()
        {
            // Snippet: SetMonitoringServiceAsync(SetMonitoringServiceRequest, CallSettings)
            // Additional: SetMonitoringServiceAsync(SetMonitoringServiceRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetMonitoringServiceRequest request = new SetMonitoringServiceRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                MonitoringService = "",
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetMonitoringServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetMonitoringService</summary>
        public void SetMonitoringService()
        {
            // Snippet: SetMonitoringService(string, string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string monitoringService = "";
            // Make the request
            Operation response = clusterManagerClient.SetMonitoringService(projectId, zone, clusterId, monitoringService);
            // End snippet
        }

        /// <summary>Snippet for SetMonitoringServiceAsync</summary>
        public async Task SetMonitoringServiceAsync()
        {
            // Snippet: SetMonitoringServiceAsync(string, string, string, string, CallSettings)
            // Additional: SetMonitoringServiceAsync(string, string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string monitoringService = "";
            // Make the request
            Operation response = await clusterManagerClient.SetMonitoringServiceAsync(projectId, zone, clusterId, monitoringService);
            // End snippet
        }

        /// <summary>Snippet for SetAddonsConfig</summary>
        public void SetAddonsConfig_RequestObject()
        {
            // Snippet: SetAddonsConfig(SetAddonsConfigRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetAddonsConfigRequest request = new SetAddonsConfigRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                AddonsConfig = new AddonsConfig(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetAddonsConfig(request);
            // End snippet
        }

        /// <summary>Snippet for SetAddonsConfigAsync</summary>
        public async Task SetAddonsConfigAsync_RequestObject()
        {
            // Snippet: SetAddonsConfigAsync(SetAddonsConfigRequest, CallSettings)
            // Additional: SetAddonsConfigAsync(SetAddonsConfigRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetAddonsConfigRequest request = new SetAddonsConfigRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                AddonsConfig = new AddonsConfig(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetAddonsConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetAddonsConfig</summary>
        public void SetAddonsConfig()
        {
            // Snippet: SetAddonsConfig(string, string, string, AddonsConfig, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            AddonsConfig addonsConfig = new AddonsConfig();
            // Make the request
            Operation response = clusterManagerClient.SetAddonsConfig(projectId, zone, clusterId, addonsConfig);
            // End snippet
        }

        /// <summary>Snippet for SetAddonsConfigAsync</summary>
        public async Task SetAddonsConfigAsync()
        {
            // Snippet: SetAddonsConfigAsync(string, string, string, AddonsConfig, CallSettings)
            // Additional: SetAddonsConfigAsync(string, string, string, AddonsConfig, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            AddonsConfig addonsConfig = new AddonsConfig();
            // Make the request
            Operation response = await clusterManagerClient.SetAddonsConfigAsync(projectId, zone, clusterId, addonsConfig);
            // End snippet
        }

        /// <summary>Snippet for SetLocations</summary>
        public void SetLocations_RequestObject()
        {
            // Snippet: SetLocations(SetLocationsRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetLocationsRequest request = new SetLocationsRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                Locations = { "", },
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetLocations(request);
            // End snippet
        }

        /// <summary>Snippet for SetLocationsAsync</summary>
        public async Task SetLocationsAsync_RequestObject()
        {
            // Snippet: SetLocationsAsync(SetLocationsRequest, CallSettings)
            // Additional: SetLocationsAsync(SetLocationsRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetLocationsRequest request = new SetLocationsRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                Locations = { "", },
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetLocationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLocations</summary>
        public void SetLocations()
        {
            // Snippet: SetLocations(string, string, string, IEnumerable<string>, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            IEnumerable<string> locations = new string[] { "", };
            // Make the request
            Operation response = clusterManagerClient.SetLocations(projectId, zone, clusterId, locations);
            // End snippet
        }

        /// <summary>Snippet for SetLocationsAsync</summary>
        public async Task SetLocationsAsync()
        {
            // Snippet: SetLocationsAsync(string, string, string, IEnumerable<string>, CallSettings)
            // Additional: SetLocationsAsync(string, string, string, IEnumerable<string>, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            IEnumerable<string> locations = new string[] { "", };
            // Make the request
            Operation response = await clusterManagerClient.SetLocationsAsync(projectId, zone, clusterId, locations);
            // End snippet
        }

        /// <summary>Snippet for UpdateMaster</summary>
        public void UpdateMaster_RequestObject()
        {
            // Snippet: UpdateMaster(UpdateMasterRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            UpdateMasterRequest request = new UpdateMasterRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                MasterVersion = "",
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.UpdateMaster(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateMasterAsync</summary>
        public async Task UpdateMasterAsync_RequestObject()
        {
            // Snippet: UpdateMasterAsync(UpdateMasterRequest, CallSettings)
            // Additional: UpdateMasterAsync(UpdateMasterRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMasterRequest request = new UpdateMasterRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                MasterVersion = "",
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.UpdateMasterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateMaster</summary>
        public void UpdateMaster()
        {
            // Snippet: UpdateMaster(string, string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string masterVersion = "";
            // Make the request
            Operation response = clusterManagerClient.UpdateMaster(projectId, zone, clusterId, masterVersion);
            // End snippet
        }

        /// <summary>Snippet for UpdateMasterAsync</summary>
        public async Task UpdateMasterAsync()
        {
            // Snippet: UpdateMasterAsync(string, string, string, string, CallSettings)
            // Additional: UpdateMasterAsync(string, string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string masterVersion = "";
            // Make the request
            Operation response = await clusterManagerClient.UpdateMasterAsync(projectId, zone, clusterId, masterVersion);
            // End snippet
        }

        /// <summary>Snippet for SetMasterAuth</summary>
        public void SetMasterAuth_RequestObject()
        {
            // Snippet: SetMasterAuth(SetMasterAuthRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetMasterAuthRequest request = new SetMasterAuthRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                Action = SetMasterAuthRequest.Types.Action.Unknown,
                Update = new MasterAuth(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetMasterAuth(request);
            // End snippet
        }

        /// <summary>Snippet for SetMasterAuthAsync</summary>
        public async Task SetMasterAuthAsync_RequestObject()
        {
            // Snippet: SetMasterAuthAsync(SetMasterAuthRequest, CallSettings)
            // Additional: SetMasterAuthAsync(SetMasterAuthRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetMasterAuthRequest request = new SetMasterAuthRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                Action = SetMasterAuthRequest.Types.Action.Unknown,
                Update = new MasterAuth(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetMasterAuthAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteCluster_RequestObject()
        {
            // Snippet: DeleteCluster(DeleteClusterRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.DeleteCluster(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteClusterAsync_RequestObject()
        {
            // Snippet: DeleteClusterAsync(DeleteClusterRequest, CallSettings)
            // Additional: DeleteClusterAsync(DeleteClusterRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.DeleteClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteCluster()
        {
            // Snippet: DeleteCluster(string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
            Operation response = clusterManagerClient.DeleteCluster(projectId, zone, clusterId);
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteClusterAsync()
        {
            // Snippet: DeleteClusterAsync(string, string, string, CallSettings)
            // Additional: DeleteClusterAsync(string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
            Operation response = await clusterManagerClient.DeleteClusterAsync(projectId, zone, clusterId);
            // End snippet
        }

        /// <summary>Snippet for ListOperations</summary>
        public void ListOperations_RequestObject()
        {
            // Snippet: ListOperations(ListOperationsRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            ListOperationsRequest request = new ListOperationsRequest
            {
                ProjectId = "",
                Zone = "",
                Parent = "",
            };
            // Make the request
            ListOperationsResponse response = clusterManagerClient.ListOperations(request);
            // End snippet
        }

        /// <summary>Snippet for ListOperationsAsync</summary>
        public async Task ListOperationsAsync_RequestObject()
        {
            // Snippet: ListOperationsAsync(ListOperationsRequest, CallSettings)
            // Additional: ListOperationsAsync(ListOperationsRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListOperationsRequest request = new ListOperationsRequest
            {
                ProjectId = "",
                Zone = "",
                Parent = "",
            };
            // Make the request
            ListOperationsResponse response = await clusterManagerClient.ListOperationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListOperations</summary>
        public void ListOperations()
        {
            // Snippet: ListOperations(string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            // Make the request
            ListOperationsResponse response = clusterManagerClient.ListOperations(projectId, zone);
            // End snippet
        }

        /// <summary>Snippet for ListOperationsAsync</summary>
        public async Task ListOperationsAsync()
        {
            // Snippet: ListOperationsAsync(string, string, CallSettings)
            // Additional: ListOperationsAsync(string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            // Make the request
            ListOperationsResponse response = await clusterManagerClient.ListOperationsAsync(projectId, zone);
            // End snippet
        }

        /// <summary>Snippet for GetOperation</summary>
        public void GetOperation_RequestObject()
        {
            // Snippet: GetOperation(GetOperationRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            GetOperationRequest request = new GetOperationRequest
            {
                ProjectId = "",
                Zone = "",
                OperationId = "",
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.GetOperation(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperationAsync</summary>
        public async Task GetOperationAsync_RequestObject()
        {
            // Snippet: GetOperationAsync(GetOperationRequest, CallSettings)
            // Additional: GetOperationAsync(GetOperationRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetOperationRequest request = new GetOperationRequest
            {
                ProjectId = "",
                Zone = "",
                OperationId = "",
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.GetOperationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperation</summary>
        public void GetOperation()
        {
            // Snippet: GetOperation(string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string operationId = "";
            // Make the request
            Operation response = clusterManagerClient.GetOperation(projectId, zone, operationId);
            // End snippet
        }

        /// <summary>Snippet for GetOperationAsync</summary>
        public async Task GetOperationAsync()
        {
            // Snippet: GetOperationAsync(string, string, string, CallSettings)
            // Additional: GetOperationAsync(string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string operationId = "";
            // Make the request
            Operation response = await clusterManagerClient.GetOperationAsync(projectId, zone, operationId);
            // End snippet
        }

        /// <summary>Snippet for CancelOperation</summary>
        public void CancelOperation_RequestObject()
        {
            // Snippet: CancelOperation(CancelOperationRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            CancelOperationRequest request = new CancelOperationRequest
            {
                ProjectId = "",
                Zone = "",
                OperationId = "",
                Name = "",
            };
            // Make the request
            clusterManagerClient.CancelOperation(request);
            // End snippet
        }

        /// <summary>Snippet for CancelOperationAsync</summary>
        public async Task CancelOperationAsync_RequestObject()
        {
            // Snippet: CancelOperationAsync(CancelOperationRequest, CallSettings)
            // Additional: CancelOperationAsync(CancelOperationRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            CancelOperationRequest request = new CancelOperationRequest
            {
                ProjectId = "",
                Zone = "",
                OperationId = "",
                Name = "",
            };
            // Make the request
            await clusterManagerClient.CancelOperationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelOperation</summary>
        public void CancelOperation()
        {
            // Snippet: CancelOperation(string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string operationId = "";
            // Make the request
            clusterManagerClient.CancelOperation(projectId, zone, operationId);
            // End snippet
        }

        /// <summary>Snippet for CancelOperationAsync</summary>
        public async Task CancelOperationAsync()
        {
            // Snippet: CancelOperationAsync(string, string, string, CallSettings)
            // Additional: CancelOperationAsync(string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string operationId = "";
            // Make the request
            await clusterManagerClient.CancelOperationAsync(projectId, zone, operationId);
            // End snippet
        }

        /// <summary>Snippet for GetServerConfig</summary>
        public void GetServerConfig_RequestObject()
        {
            // Snippet: GetServerConfig(GetServerConfigRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            GetServerConfigRequest request = new GetServerConfigRequest
            {
                ProjectId = "",
                Zone = "",
                Name = "",
            };
            // Make the request
            ServerConfig response = clusterManagerClient.GetServerConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetServerConfigAsync</summary>
        public async Task GetServerConfigAsync_RequestObject()
        {
            // Snippet: GetServerConfigAsync(GetServerConfigRequest, CallSettings)
            // Additional: GetServerConfigAsync(GetServerConfigRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetServerConfigRequest request = new GetServerConfigRequest
            {
                ProjectId = "",
                Zone = "",
                Name = "",
            };
            // Make the request
            ServerConfig response = await clusterManagerClient.GetServerConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServerConfig</summary>
        public void GetServerConfig()
        {
            // Snippet: GetServerConfig(string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            // Make the request
            ServerConfig response = clusterManagerClient.GetServerConfig(projectId, zone);
            // End snippet
        }

        /// <summary>Snippet for GetServerConfigAsync</summary>
        public async Task GetServerConfigAsync()
        {
            // Snippet: GetServerConfigAsync(string, string, CallSettings)
            // Additional: GetServerConfigAsync(string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            // Make the request
            ServerConfig response = await clusterManagerClient.GetServerConfigAsync(projectId, zone);
            // End snippet
        }

        /// <summary>Snippet for ListNodePools</summary>
        public void ListNodePools_RequestObject()
        {
            // Snippet: ListNodePools(ListNodePoolsRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            ListNodePoolsRequest request = new ListNodePoolsRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                Parent = "",
            };
            // Make the request
            ListNodePoolsResponse response = clusterManagerClient.ListNodePools(request);
            // End snippet
        }

        /// <summary>Snippet for ListNodePoolsAsync</summary>
        public async Task ListNodePoolsAsync_RequestObject()
        {
            // Snippet: ListNodePoolsAsync(ListNodePoolsRequest, CallSettings)
            // Additional: ListNodePoolsAsync(ListNodePoolsRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListNodePoolsRequest request = new ListNodePoolsRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                Parent = "",
            };
            // Make the request
            ListNodePoolsResponse response = await clusterManagerClient.ListNodePoolsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListNodePools</summary>
        public void ListNodePools()
        {
            // Snippet: ListNodePools(string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
            ListNodePoolsResponse response = clusterManagerClient.ListNodePools(projectId, zone, clusterId);
            // End snippet
        }

        /// <summary>Snippet for ListNodePoolsAsync</summary>
        public async Task ListNodePoolsAsync()
        {
            // Snippet: ListNodePoolsAsync(string, string, string, CallSettings)
            // Additional: ListNodePoolsAsync(string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
            ListNodePoolsResponse response = await clusterManagerClient.ListNodePoolsAsync(projectId, zone, clusterId);
            // End snippet
        }

        /// <summary>Snippet for GetNodePool</summary>
        public void GetNodePool_RequestObject()
        {
            // Snippet: GetNodePool(GetNodePoolRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            GetNodePoolRequest request = new GetNodePoolRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                NodePoolId = "",
                Name = "",
            };
            // Make the request
            NodePool response = clusterManagerClient.GetNodePool(request);
            // End snippet
        }

        /// <summary>Snippet for GetNodePoolAsync</summary>
        public async Task GetNodePoolAsync_RequestObject()
        {
            // Snippet: GetNodePoolAsync(GetNodePoolRequest, CallSettings)
            // Additional: GetNodePoolAsync(GetNodePoolRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetNodePoolRequest request = new GetNodePoolRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                NodePoolId = "",
                Name = "",
            };
            // Make the request
            NodePool response = await clusterManagerClient.GetNodePoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNodePool</summary>
        public void GetNodePool()
        {
            // Snippet: GetNodePool(string, string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string nodePoolId = "";
            // Make the request
            NodePool response = clusterManagerClient.GetNodePool(projectId, zone, clusterId, nodePoolId);
            // End snippet
        }

        /// <summary>Snippet for GetNodePoolAsync</summary>
        public async Task GetNodePoolAsync()
        {
            // Snippet: GetNodePoolAsync(string, string, string, string, CallSettings)
            // Additional: GetNodePoolAsync(string, string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string nodePoolId = "";
            // Make the request
            NodePool response = await clusterManagerClient.GetNodePoolAsync(projectId, zone, clusterId, nodePoolId);
            // End snippet
        }

        /// <summary>Snippet for CreateNodePool</summary>
        public void CreateNodePool_RequestObject()
        {
            // Snippet: CreateNodePool(CreateNodePoolRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            CreateNodePoolRequest request = new CreateNodePoolRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                NodePool = new NodePool(),
                Parent = "",
            };
            // Make the request
            Operation response = clusterManagerClient.CreateNodePool(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNodePoolAsync</summary>
        public async Task CreateNodePoolAsync_RequestObject()
        {
            // Snippet: CreateNodePoolAsync(CreateNodePoolRequest, CallSettings)
            // Additional: CreateNodePoolAsync(CreateNodePoolRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateNodePoolRequest request = new CreateNodePoolRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                NodePool = new NodePool(),
                Parent = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.CreateNodePoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNodePool</summary>
        public void CreateNodePool()
        {
            // Snippet: CreateNodePool(string, string, string, NodePool, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            NodePool nodePool = new NodePool();
            // Make the request
            Operation response = clusterManagerClient.CreateNodePool(projectId, zone, clusterId, nodePool);
            // End snippet
        }

        /// <summary>Snippet for CreateNodePoolAsync</summary>
        public async Task CreateNodePoolAsync()
        {
            // Snippet: CreateNodePoolAsync(string, string, string, NodePool, CallSettings)
            // Additional: CreateNodePoolAsync(string, string, string, NodePool, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            NodePool nodePool = new NodePool();
            // Make the request
            Operation response = await clusterManagerClient.CreateNodePoolAsync(projectId, zone, clusterId, nodePool);
            // End snippet
        }

        /// <summary>Snippet for DeleteNodePool</summary>
        public void DeleteNodePool_RequestObject()
        {
            // Snippet: DeleteNodePool(DeleteNodePoolRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            DeleteNodePoolRequest request = new DeleteNodePoolRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                NodePoolId = "",
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.DeleteNodePool(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNodePoolAsync</summary>
        public async Task DeleteNodePoolAsync_RequestObject()
        {
            // Snippet: DeleteNodePoolAsync(DeleteNodePoolRequest, CallSettings)
            // Additional: DeleteNodePoolAsync(DeleteNodePoolRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNodePoolRequest request = new DeleteNodePoolRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                NodePoolId = "",
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.DeleteNodePoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNodePool</summary>
        public void DeleteNodePool()
        {
            // Snippet: DeleteNodePool(string, string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string nodePoolId = "";
            // Make the request
            Operation response = clusterManagerClient.DeleteNodePool(projectId, zone, clusterId, nodePoolId);
            // End snippet
        }

        /// <summary>Snippet for DeleteNodePoolAsync</summary>
        public async Task DeleteNodePoolAsync()
        {
            // Snippet: DeleteNodePoolAsync(string, string, string, string, CallSettings)
            // Additional: DeleteNodePoolAsync(string, string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string nodePoolId = "";
            // Make the request
            Operation response = await clusterManagerClient.DeleteNodePoolAsync(projectId, zone, clusterId, nodePoolId);
            // End snippet
        }

        /// <summary>Snippet for RollbackNodePoolUpgrade</summary>
        public void RollbackNodePoolUpgrade_RequestObject()
        {
            // Snippet: RollbackNodePoolUpgrade(RollbackNodePoolUpgradeRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            RollbackNodePoolUpgradeRequest request = new RollbackNodePoolUpgradeRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                NodePoolId = "",
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.RollbackNodePoolUpgrade(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackNodePoolUpgradeAsync</summary>
        public async Task RollbackNodePoolUpgradeAsync_RequestObject()
        {
            // Snippet: RollbackNodePoolUpgradeAsync(RollbackNodePoolUpgradeRequest, CallSettings)
            // Additional: RollbackNodePoolUpgradeAsync(RollbackNodePoolUpgradeRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            RollbackNodePoolUpgradeRequest request = new RollbackNodePoolUpgradeRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                NodePoolId = "",
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.RollbackNodePoolUpgradeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackNodePoolUpgrade</summary>
        public void RollbackNodePoolUpgrade()
        {
            // Snippet: RollbackNodePoolUpgrade(string, string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string nodePoolId = "";
            // Make the request
            Operation response = clusterManagerClient.RollbackNodePoolUpgrade(projectId, zone, clusterId, nodePoolId);
            // End snippet
        }

        /// <summary>Snippet for RollbackNodePoolUpgradeAsync</summary>
        public async Task RollbackNodePoolUpgradeAsync()
        {
            // Snippet: RollbackNodePoolUpgradeAsync(string, string, string, string, CallSettings)
            // Additional: RollbackNodePoolUpgradeAsync(string, string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string nodePoolId = "";
            // Make the request
            Operation response = await clusterManagerClient.RollbackNodePoolUpgradeAsync(projectId, zone, clusterId, nodePoolId);
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolManagement</summary>
        public void SetNodePoolManagement_RequestObject()
        {
            // Snippet: SetNodePoolManagement(SetNodePoolManagementRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetNodePoolManagementRequest request = new SetNodePoolManagementRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                NodePoolId = "",
                Management = new NodeManagement(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetNodePoolManagement(request);
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolManagementAsync</summary>
        public async Task SetNodePoolManagementAsync_RequestObject()
        {
            // Snippet: SetNodePoolManagementAsync(SetNodePoolManagementRequest, CallSettings)
            // Additional: SetNodePoolManagementAsync(SetNodePoolManagementRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetNodePoolManagementRequest request = new SetNodePoolManagementRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                NodePoolId = "",
                Management = new NodeManagement(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetNodePoolManagementAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabels_RequestObject()
        {
            // Snippet: SetLabels(SetLabelsRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetLabelsRequest request = new SetLabelsRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                ResourceLabels = { { "", "" }, },
                LabelFingerprint = "",
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetLabels(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsAsync_RequestObject()
        {
            // Snippet: SetLabelsAsync(SetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsRequest request = new SetLabelsRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                ResourceLabels = { { "", "" }, },
                LabelFingerprint = "",
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLegacyAbac</summary>
        public void SetLegacyAbac_RequestObject()
        {
            // Snippet: SetLegacyAbac(SetLegacyAbacRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetLegacyAbacRequest request = new SetLegacyAbacRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                Enabled = false,
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetLegacyAbac(request);
            // End snippet
        }

        /// <summary>Snippet for SetLegacyAbacAsync</summary>
        public async Task SetLegacyAbacAsync_RequestObject()
        {
            // Snippet: SetLegacyAbacAsync(SetLegacyAbacRequest, CallSettings)
            // Additional: SetLegacyAbacAsync(SetLegacyAbacRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetLegacyAbacRequest request = new SetLegacyAbacRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                Enabled = false,
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetLegacyAbacAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLegacyAbac</summary>
        public void SetLegacyAbac()
        {
            // Snippet: SetLegacyAbac(string, string, string, bool, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            bool enabled = false;
            // Make the request
            Operation response = clusterManagerClient.SetLegacyAbac(projectId, zone, clusterId, enabled);
            // End snippet
        }

        /// <summary>Snippet for SetLegacyAbacAsync</summary>
        public async Task SetLegacyAbacAsync()
        {
            // Snippet: SetLegacyAbacAsync(string, string, string, bool, CallSettings)
            // Additional: SetLegacyAbacAsync(string, string, string, bool, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            bool enabled = false;
            // Make the request
            Operation response = await clusterManagerClient.SetLegacyAbacAsync(projectId, zone, clusterId, enabled);
            // End snippet
        }

        /// <summary>Snippet for StartIPRotation</summary>
        public void StartIPRotation_RequestObject()
        {
            // Snippet: StartIPRotation(StartIPRotationRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            StartIPRotationRequest request = new StartIPRotationRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                Name = "",
                RotateCredentials = false,
            };
            // Make the request
            Operation response = clusterManagerClient.StartIPRotation(request);
            // End snippet
        }

        /// <summary>Snippet for StartIPRotationAsync</summary>
        public async Task StartIPRotationAsync_RequestObject()
        {
            // Snippet: StartIPRotationAsync(StartIPRotationRequest, CallSettings)
            // Additional: StartIPRotationAsync(StartIPRotationRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            StartIPRotationRequest request = new StartIPRotationRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                Name = "",
                RotateCredentials = false,
            };
            // Make the request
            Operation response = await clusterManagerClient.StartIPRotationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartIPRotation</summary>
        public void StartIPRotation()
        {
            // Snippet: StartIPRotation(string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
            Operation response = clusterManagerClient.StartIPRotation(projectId, zone, clusterId);
            // End snippet
        }

        /// <summary>Snippet for StartIPRotationAsync</summary>
        public async Task StartIPRotationAsync()
        {
            // Snippet: StartIPRotationAsync(string, string, string, CallSettings)
            // Additional: StartIPRotationAsync(string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
            Operation response = await clusterManagerClient.StartIPRotationAsync(projectId, zone, clusterId);
            // End snippet
        }

        /// <summary>Snippet for CompleteIPRotation</summary>
        public void CompleteIPRotation_RequestObject()
        {
            // Snippet: CompleteIPRotation(CompleteIPRotationRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            CompleteIPRotationRequest request = new CompleteIPRotationRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.CompleteIPRotation(request);
            // End snippet
        }

        /// <summary>Snippet for CompleteIPRotationAsync</summary>
        public async Task CompleteIPRotationAsync_RequestObject()
        {
            // Snippet: CompleteIPRotationAsync(CompleteIPRotationRequest, CallSettings)
            // Additional: CompleteIPRotationAsync(CompleteIPRotationRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            CompleteIPRotationRequest request = new CompleteIPRotationRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.CompleteIPRotationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CompleteIPRotation</summary>
        public void CompleteIPRotation()
        {
            // Snippet: CompleteIPRotation(string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
            Operation response = clusterManagerClient.CompleteIPRotation(projectId, zone, clusterId);
            // End snippet
        }

        /// <summary>Snippet for CompleteIPRotationAsync</summary>
        public async Task CompleteIPRotationAsync()
        {
            // Snippet: CompleteIPRotationAsync(string, string, string, CallSettings)
            // Additional: CompleteIPRotationAsync(string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
            Operation response = await clusterManagerClient.CompleteIPRotationAsync(projectId, zone, clusterId);
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolSize</summary>
        public void SetNodePoolSize_RequestObject()
        {
            // Snippet: SetNodePoolSize(SetNodePoolSizeRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetNodePoolSizeRequest request = new SetNodePoolSizeRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                NodePoolId = "",
                NodeCount = 0,
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetNodePoolSize(request);
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolSizeAsync</summary>
        public async Task SetNodePoolSizeAsync_RequestObject()
        {
            // Snippet: SetNodePoolSizeAsync(SetNodePoolSizeRequest, CallSettings)
            // Additional: SetNodePoolSizeAsync(SetNodePoolSizeRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetNodePoolSizeRequest request = new SetNodePoolSizeRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                NodePoolId = "",
                NodeCount = 0,
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetNodePoolSizeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetNetworkPolicy</summary>
        public void SetNetworkPolicy_RequestObject()
        {
            // Snippet: SetNetworkPolicy(SetNetworkPolicyRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetNetworkPolicyRequest request = new SetNetworkPolicyRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                NetworkPolicy = new NetworkPolicy(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetNetworkPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetNetworkPolicyAsync</summary>
        public async Task SetNetworkPolicyAsync_RequestObject()
        {
            // Snippet: SetNetworkPolicyAsync(SetNetworkPolicyRequest, CallSettings)
            // Additional: SetNetworkPolicyAsync(SetNetworkPolicyRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetNetworkPolicyRequest request = new SetNetworkPolicyRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                NetworkPolicy = new NetworkPolicy(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetNetworkPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetNetworkPolicy</summary>
        public void SetNetworkPolicy()
        {
            // Snippet: SetNetworkPolicy(string, string, string, NetworkPolicy, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            NetworkPolicy networkPolicy = new NetworkPolicy();
            // Make the request
            Operation response = clusterManagerClient.SetNetworkPolicy(projectId, zone, clusterId, networkPolicy);
            // End snippet
        }

        /// <summary>Snippet for SetNetworkPolicyAsync</summary>
        public async Task SetNetworkPolicyAsync()
        {
            // Snippet: SetNetworkPolicyAsync(string, string, string, NetworkPolicy, CallSettings)
            // Additional: SetNetworkPolicyAsync(string, string, string, NetworkPolicy, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            NetworkPolicy networkPolicy = new NetworkPolicy();
            // Make the request
            Operation response = await clusterManagerClient.SetNetworkPolicyAsync(projectId, zone, clusterId, networkPolicy);
            // End snippet
        }

        /// <summary>Snippet for SetMaintenancePolicy</summary>
        public void SetMaintenancePolicy_RequestObject()
        {
            // Snippet: SetMaintenancePolicy(SetMaintenancePolicyRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetMaintenancePolicyRequest request = new SetMaintenancePolicyRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                MaintenancePolicy = new MaintenancePolicy(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetMaintenancePolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetMaintenancePolicyAsync</summary>
        public async Task SetMaintenancePolicyAsync_RequestObject()
        {
            // Snippet: SetMaintenancePolicyAsync(SetMaintenancePolicyRequest, CallSettings)
            // Additional: SetMaintenancePolicyAsync(SetMaintenancePolicyRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetMaintenancePolicyRequest request = new SetMaintenancePolicyRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                MaintenancePolicy = new MaintenancePolicy(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetMaintenancePolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetMaintenancePolicy</summary>
        public void SetMaintenancePolicy()
        {
            // Snippet: SetMaintenancePolicy(string, string, string, MaintenancePolicy, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            MaintenancePolicy maintenancePolicy = new MaintenancePolicy();
            // Make the request
            Operation response = clusterManagerClient.SetMaintenancePolicy(projectId, zone, clusterId, maintenancePolicy);
            // End snippet
        }

        /// <summary>Snippet for SetMaintenancePolicyAsync</summary>
        public async Task SetMaintenancePolicyAsync()
        {
            // Snippet: SetMaintenancePolicyAsync(string, string, string, MaintenancePolicy, CallSettings)
            // Additional: SetMaintenancePolicyAsync(string, string, string, MaintenancePolicy, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            MaintenancePolicy maintenancePolicy = new MaintenancePolicy();
            // Make the request
            Operation response = await clusterManagerClient.SetMaintenancePolicyAsync(projectId, zone, clusterId, maintenancePolicy);
            // End snippet
        }

        /// <summary>Snippet for ListUsableSubnetworks</summary>
        public void ListUsableSubnetworks_RequestObject()
        {
            // Snippet: ListUsableSubnetworks(ListUsableSubnetworksRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            ListUsableSubnetworksRequest request = new ListUsableSubnetworksRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListUsableSubnetworksResponse, UsableSubnetwork> response = clusterManagerClient.ListUsableSubnetworks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UsableSubnetwork item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUsableSubnetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UsableSubnetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UsableSubnetwork> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UsableSubnetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableSubnetworks</summary>
        public async Task ListUsableSubnetworksAsync_RequestObject()
        {
            // Snippet: ListUsableSubnetworksAsync(ListUsableSubnetworksRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListUsableSubnetworksRequest request = new ListUsableSubnetworksRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListUsableSubnetworksResponse, UsableSubnetwork> response = clusterManagerClient.ListUsableSubnetworksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UsableSubnetwork item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUsableSubnetworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UsableSubnetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UsableSubnetwork> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UsableSubnetwork item in singlePage)
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
