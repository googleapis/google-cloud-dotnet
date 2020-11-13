// Copyright 2020 Google LLC
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
        public void ListClustersRequestObject()
        {
            // Snippet: ListClusters(ListClustersRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest { Parent = "", };
            // Make the request
            ListClustersResponse response = clusterManagerClient.ListClusters(request);
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersRequestObjectAsync()
        {
            // Snippet: ListClustersAsync(ListClustersRequest, CallSettings)
            // Additional: ListClustersAsync(ListClustersRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest { Parent = "", };
            // Make the request
            ListClustersResponse response = await clusterManagerClient.ListClustersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListClusters</summary>
        public void ListClusters1()
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
        public async Task ListClusters1Async()
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

        /// <summary>Snippet for ListClusters</summary>
        public void ListClusters2()
        {
            // Snippet: ListClusters(string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            ListClustersResponse response = clusterManagerClient.ListClusters(parent);
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClusters2Async()
        {
            // Snippet: ListClustersAsync(string, CallSettings)
            // Additional: ListClustersAsync(string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            ListClustersResponse response = await clusterManagerClient.ListClustersAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetClusterRequestObject()
        {
            // Snippet: GetCluster(GetClusterRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest { Name = "", };
            // Make the request
            Cluster response = clusterManagerClient.GetCluster(request);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterRequestObjectAsync()
        {
            // Snippet: GetClusterAsync(GetClusterRequest, CallSettings)
            // Additional: GetClusterAsync(GetClusterRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest { Name = "", };
            // Make the request
            Cluster response = await clusterManagerClient.GetClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetCluster1()
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
        public async Task GetCluster1Async()
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

        /// <summary>Snippet for GetCluster</summary>
        public void GetCluster2()
        {
            // Snippet: GetCluster(string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Cluster response = clusterManagerClient.GetCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetCluster2Async()
        {
            // Snippet: GetClusterAsync(string, CallSettings)
            // Additional: GetClusterAsync(string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Cluster response = await clusterManagerClient.GetClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateClusterRequestObject()
        {
            // Snippet: CreateCluster(CreateClusterRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                Cluster = new Cluster(),
                Parent = "",
            };
            // Make the request
            Operation response = clusterManagerClient.CreateCluster(request);
            // End snippet
        }

        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateClusterRequestObjectAsync()
        {
            // Snippet: CreateClusterAsync(CreateClusterRequest, CallSettings)
            // Additional: CreateClusterAsync(CreateClusterRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                Cluster = new Cluster(),
                Parent = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.CreateClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateCluster1()
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
        public async Task CreateCluster1Async()
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

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateCluster2()
        {
            // Snippet: CreateCluster(string, Cluster, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string parent = "";
            Cluster cluster = new Cluster();
            // Make the request
            Operation response = clusterManagerClient.CreateCluster(parent, cluster);
            // End snippet
        }

        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateCluster2Async()
        {
            // Snippet: CreateClusterAsync(string, Cluster, CallSettings)
            // Additional: CreateClusterAsync(string, Cluster, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            Cluster cluster = new Cluster();
            // Make the request
            Operation response = await clusterManagerClient.CreateClusterAsync(parent, cluster);
            // End snippet
        }

        /// <summary>Snippet for UpdateCluster</summary>
        public void UpdateClusterRequestObject()
        {
            // Snippet: UpdateCluster(UpdateClusterRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                Update = new ClusterUpdate(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.UpdateCluster(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateClusterAsync</summary>
        public async Task UpdateClusterRequestObjectAsync()
        {
            // Snippet: UpdateClusterAsync(UpdateClusterRequest, CallSettings)
            // Additional: UpdateClusterAsync(UpdateClusterRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                Update = new ClusterUpdate(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.UpdateClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCluster</summary>
        public void UpdateCluster1()
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
        public async Task UpdateCluster1Async()
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

        /// <summary>Snippet for UpdateCluster</summary>
        public void UpdateCluster2()
        {
            // Snippet: UpdateCluster(string, ClusterUpdate, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            ClusterUpdate update = new ClusterUpdate();
            // Make the request
            Operation response = clusterManagerClient.UpdateCluster(name, update);
            // End snippet
        }

        /// <summary>Snippet for UpdateClusterAsync</summary>
        public async Task UpdateCluster2Async()
        {
            // Snippet: UpdateClusterAsync(string, ClusterUpdate, CallSettings)
            // Additional: UpdateClusterAsync(string, ClusterUpdate, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            ClusterUpdate update = new ClusterUpdate();
            // Make the request
            Operation response = await clusterManagerClient.UpdateClusterAsync(name, update);
            // End snippet
        }

        /// <summary>Snippet for UpdateNodePool</summary>
        public void UpdateNodePoolRequestObject()
        {
            // Snippet: UpdateNodePool(UpdateNodePoolRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            UpdateNodePoolRequest request = new UpdateNodePoolRequest
            {
                NodeVersion = "",
                ImageType = "",
                Name = "",
                Locations = { "", },
                WorkloadMetadataConfig = new WorkloadMetadataConfig(),
                UpgradeSettings = new NodePool.Types.UpgradeSettings(),
            };
            // Make the request
            Operation response = clusterManagerClient.UpdateNodePool(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNodePoolAsync</summary>
        public async Task UpdateNodePoolRequestObjectAsync()
        {
            // Snippet: UpdateNodePoolAsync(UpdateNodePoolRequest, CallSettings)
            // Additional: UpdateNodePoolAsync(UpdateNodePoolRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateNodePoolRequest request = new UpdateNodePoolRequest
            {
                NodeVersion = "",
                ImageType = "",
                Name = "",
                Locations = { "", },
                WorkloadMetadataConfig = new WorkloadMetadataConfig(),
                UpgradeSettings = new NodePool.Types.UpgradeSettings(),
            };
            // Make the request
            Operation response = await clusterManagerClient.UpdateNodePoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolAutoscaling</summary>
        public void SetNodePoolAutoscalingRequestObject()
        {
            // Snippet: SetNodePoolAutoscaling(SetNodePoolAutoscalingRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetNodePoolAutoscalingRequest request = new SetNodePoolAutoscalingRequest
            {
                Autoscaling = new NodePoolAutoscaling(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetNodePoolAutoscaling(request);
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolAutoscalingAsync</summary>
        public async Task SetNodePoolAutoscalingRequestObjectAsync()
        {
            // Snippet: SetNodePoolAutoscalingAsync(SetNodePoolAutoscalingRequest, CallSettings)
            // Additional: SetNodePoolAutoscalingAsync(SetNodePoolAutoscalingRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetNodePoolAutoscalingRequest request = new SetNodePoolAutoscalingRequest
            {
                Autoscaling = new NodePoolAutoscaling(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetNodePoolAutoscalingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLoggingService</summary>
        public void SetLoggingServiceRequestObject()
        {
            // Snippet: SetLoggingService(SetLoggingServiceRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetLoggingServiceRequest request = new SetLoggingServiceRequest
            {
                LoggingService = "",
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetLoggingService(request);
            // End snippet
        }

        /// <summary>Snippet for SetLoggingServiceAsync</summary>
        public async Task SetLoggingServiceRequestObjectAsync()
        {
            // Snippet: SetLoggingServiceAsync(SetLoggingServiceRequest, CallSettings)
            // Additional: SetLoggingServiceAsync(SetLoggingServiceRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetLoggingServiceRequest request = new SetLoggingServiceRequest
            {
                LoggingService = "",
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetLoggingServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLoggingService</summary>
        public void SetLoggingService1()
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
        public async Task SetLoggingService1Async()
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

        /// <summary>Snippet for SetLoggingService</summary>
        public void SetLoggingService2()
        {
            // Snippet: SetLoggingService(string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            string loggingService = "";
            // Make the request
            Operation response = clusterManagerClient.SetLoggingService(name, loggingService);
            // End snippet
        }

        /// <summary>Snippet for SetLoggingServiceAsync</summary>
        public async Task SetLoggingService2Async()
        {
            // Snippet: SetLoggingServiceAsync(string, string, CallSettings)
            // Additional: SetLoggingServiceAsync(string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            string loggingService = "";
            // Make the request
            Operation response = await clusterManagerClient.SetLoggingServiceAsync(name, loggingService);
            // End snippet
        }

        /// <summary>Snippet for SetMonitoringService</summary>
        public void SetMonitoringServiceRequestObject()
        {
            // Snippet: SetMonitoringService(SetMonitoringServiceRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetMonitoringServiceRequest request = new SetMonitoringServiceRequest
            {
                MonitoringService = "",
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetMonitoringService(request);
            // End snippet
        }

        /// <summary>Snippet for SetMonitoringServiceAsync</summary>
        public async Task SetMonitoringServiceRequestObjectAsync()
        {
            // Snippet: SetMonitoringServiceAsync(SetMonitoringServiceRequest, CallSettings)
            // Additional: SetMonitoringServiceAsync(SetMonitoringServiceRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetMonitoringServiceRequest request = new SetMonitoringServiceRequest
            {
                MonitoringService = "",
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetMonitoringServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetMonitoringService</summary>
        public void SetMonitoringService1()
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
        public async Task SetMonitoringService1Async()
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

        /// <summary>Snippet for SetMonitoringService</summary>
        public void SetMonitoringService2()
        {
            // Snippet: SetMonitoringService(string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            string monitoringService = "";
            // Make the request
            Operation response = clusterManagerClient.SetMonitoringService(name, monitoringService);
            // End snippet
        }

        /// <summary>Snippet for SetMonitoringServiceAsync</summary>
        public async Task SetMonitoringService2Async()
        {
            // Snippet: SetMonitoringServiceAsync(string, string, CallSettings)
            // Additional: SetMonitoringServiceAsync(string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            string monitoringService = "";
            // Make the request
            Operation response = await clusterManagerClient.SetMonitoringServiceAsync(name, monitoringService);
            // End snippet
        }

        /// <summary>Snippet for SetAddonsConfig</summary>
        public void SetAddonsConfigRequestObject()
        {
            // Snippet: SetAddonsConfig(SetAddonsConfigRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetAddonsConfigRequest request = new SetAddonsConfigRequest
            {
                AddonsConfig = new AddonsConfig(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetAddonsConfig(request);
            // End snippet
        }

        /// <summary>Snippet for SetAddonsConfigAsync</summary>
        public async Task SetAddonsConfigRequestObjectAsync()
        {
            // Snippet: SetAddonsConfigAsync(SetAddonsConfigRequest, CallSettings)
            // Additional: SetAddonsConfigAsync(SetAddonsConfigRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetAddonsConfigRequest request = new SetAddonsConfigRequest
            {
                AddonsConfig = new AddonsConfig(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetAddonsConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetAddonsConfig</summary>
        public void SetAddonsConfig1()
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
        public async Task SetAddonsConfig1Async()
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

        /// <summary>Snippet for SetAddonsConfig</summary>
        public void SetAddonsConfig2()
        {
            // Snippet: SetAddonsConfig(string, AddonsConfig, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            AddonsConfig addonsConfig = new AddonsConfig();
            // Make the request
            Operation response = clusterManagerClient.SetAddonsConfig(name, addonsConfig);
            // End snippet
        }

        /// <summary>Snippet for SetAddonsConfigAsync</summary>
        public async Task SetAddonsConfig2Async()
        {
            // Snippet: SetAddonsConfigAsync(string, AddonsConfig, CallSettings)
            // Additional: SetAddonsConfigAsync(string, AddonsConfig, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            AddonsConfig addonsConfig = new AddonsConfig();
            // Make the request
            Operation response = await clusterManagerClient.SetAddonsConfigAsync(name, addonsConfig);
            // End snippet
        }

        /// <summary>Snippet for SetLocations</summary>
        public void SetLocationsRequestObject()
        {
            // Snippet: SetLocations(SetLocationsRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetLocationsRequest request = new SetLocationsRequest
            {
                Locations = { "", },
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetLocations(request);
            // End snippet
        }

        /// <summary>Snippet for SetLocationsAsync</summary>
        public async Task SetLocationsRequestObjectAsync()
        {
            // Snippet: SetLocationsAsync(SetLocationsRequest, CallSettings)
            // Additional: SetLocationsAsync(SetLocationsRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetLocationsRequest request = new SetLocationsRequest
            {
                Locations = { "", },
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetLocationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLocations</summary>
        public void SetLocations1()
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
        public async Task SetLocations1Async()
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

        /// <summary>Snippet for SetLocations</summary>
        public void SetLocations2()
        {
            // Snippet: SetLocations(string, IEnumerable<string>, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            IEnumerable<string> locations = new string[] { "", };
            // Make the request
            Operation response = clusterManagerClient.SetLocations(name, locations);
            // End snippet
        }

        /// <summary>Snippet for SetLocationsAsync</summary>
        public async Task SetLocations2Async()
        {
            // Snippet: SetLocationsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: SetLocationsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            IEnumerable<string> locations = new string[] { "", };
            // Make the request
            Operation response = await clusterManagerClient.SetLocationsAsync(name, locations);
            // End snippet
        }

        /// <summary>Snippet for UpdateMaster</summary>
        public void UpdateMasterRequestObject()
        {
            // Snippet: UpdateMaster(UpdateMasterRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            UpdateMasterRequest request = new UpdateMasterRequest
            {
                MasterVersion = "",
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.UpdateMaster(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateMasterAsync</summary>
        public async Task UpdateMasterRequestObjectAsync()
        {
            // Snippet: UpdateMasterAsync(UpdateMasterRequest, CallSettings)
            // Additional: UpdateMasterAsync(UpdateMasterRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMasterRequest request = new UpdateMasterRequest
            {
                MasterVersion = "",
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.UpdateMasterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateMaster</summary>
        public void UpdateMaster1()
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
        public async Task UpdateMaster1Async()
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

        /// <summary>Snippet for UpdateMaster</summary>
        public void UpdateMaster2()
        {
            // Snippet: UpdateMaster(string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            string masterVersion = "";
            // Make the request
            Operation response = clusterManagerClient.UpdateMaster(name, masterVersion);
            // End snippet
        }

        /// <summary>Snippet for UpdateMasterAsync</summary>
        public async Task UpdateMaster2Async()
        {
            // Snippet: UpdateMasterAsync(string, string, CallSettings)
            // Additional: UpdateMasterAsync(string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            string masterVersion = "";
            // Make the request
            Operation response = await clusterManagerClient.UpdateMasterAsync(name, masterVersion);
            // End snippet
        }

        /// <summary>Snippet for SetMasterAuth</summary>
        public void SetMasterAuthRequestObject()
        {
            // Snippet: SetMasterAuth(SetMasterAuthRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetMasterAuthRequest request = new SetMasterAuthRequest
            {
                Action = SetMasterAuthRequest.Types.Action.Unknown,
                Update = new MasterAuth(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetMasterAuth(request);
            // End snippet
        }

        /// <summary>Snippet for SetMasterAuthAsync</summary>
        public async Task SetMasterAuthRequestObjectAsync()
        {
            // Snippet: SetMasterAuthAsync(SetMasterAuthRequest, CallSettings)
            // Additional: SetMasterAuthAsync(SetMasterAuthRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetMasterAuthRequest request = new SetMasterAuthRequest
            {
                Action = SetMasterAuthRequest.Types.Action.Unknown,
                Update = new MasterAuth(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetMasterAuthAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteClusterRequestObject()
        {
            // Snippet: DeleteCluster(DeleteClusterRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest { Name = "", };
            // Make the request
            Operation response = clusterManagerClient.DeleteCluster(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteClusterRequestObjectAsync()
        {
            // Snippet: DeleteClusterAsync(DeleteClusterRequest, CallSettings)
            // Additional: DeleteClusterAsync(DeleteClusterRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest { Name = "", };
            // Make the request
            Operation response = await clusterManagerClient.DeleteClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteCluster1()
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
        public async Task DeleteCluster1Async()
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

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteCluster2()
        {
            // Snippet: DeleteCluster(string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation response = clusterManagerClient.DeleteCluster(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteCluster2Async()
        {
            // Snippet: DeleteClusterAsync(string, CallSettings)
            // Additional: DeleteClusterAsync(string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation response = await clusterManagerClient.DeleteClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListOperations</summary>
        public void ListOperationsRequestObject()
        {
            // Snippet: ListOperations(ListOperationsRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            ListOperationsRequest request = new ListOperationsRequest { Parent = "", };
            // Make the request
            ListOperationsResponse response = clusterManagerClient.ListOperations(request);
            // End snippet
        }

        /// <summary>Snippet for ListOperationsAsync</summary>
        public async Task ListOperationsRequestObjectAsync()
        {
            // Snippet: ListOperationsAsync(ListOperationsRequest, CallSettings)
            // Additional: ListOperationsAsync(ListOperationsRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListOperationsRequest request = new ListOperationsRequest { Parent = "", };
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
        public void GetOperationRequestObject()
        {
            // Snippet: GetOperation(GetOperationRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            GetOperationRequest request = new GetOperationRequest { Name = "", };
            // Make the request
            Operation response = clusterManagerClient.GetOperation(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperationAsync</summary>
        public async Task GetOperationRequestObjectAsync()
        {
            // Snippet: GetOperationAsync(GetOperationRequest, CallSettings)
            // Additional: GetOperationAsync(GetOperationRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetOperationRequest request = new GetOperationRequest { Name = "", };
            // Make the request
            Operation response = await clusterManagerClient.GetOperationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperation</summary>
        public void GetOperation1()
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
        public async Task GetOperation1Async()
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

        /// <summary>Snippet for GetOperation</summary>
        public void GetOperation2()
        {
            // Snippet: GetOperation(string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation response = clusterManagerClient.GetOperation(name);
            // End snippet
        }

        /// <summary>Snippet for GetOperationAsync</summary>
        public async Task GetOperation2Async()
        {
            // Snippet: GetOperationAsync(string, CallSettings)
            // Additional: GetOperationAsync(string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation response = await clusterManagerClient.GetOperationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelOperation</summary>
        public void CancelOperationRequestObject()
        {
            // Snippet: CancelOperation(CancelOperationRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            CancelOperationRequest request = new CancelOperationRequest { Name = "", };
            // Make the request
            clusterManagerClient.CancelOperation(request);
            // End snippet
        }

        /// <summary>Snippet for CancelOperationAsync</summary>
        public async Task CancelOperationRequestObjectAsync()
        {
            // Snippet: CancelOperationAsync(CancelOperationRequest, CallSettings)
            // Additional: CancelOperationAsync(CancelOperationRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            CancelOperationRequest request = new CancelOperationRequest { Name = "", };
            // Make the request
            await clusterManagerClient.CancelOperationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelOperation</summary>
        public void CancelOperation1()
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
        public async Task CancelOperation1Async()
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

        /// <summary>Snippet for CancelOperation</summary>
        public void CancelOperation2()
        {
            // Snippet: CancelOperation(string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            clusterManagerClient.CancelOperation(name);
            // End snippet
        }

        /// <summary>Snippet for CancelOperationAsync</summary>
        public async Task CancelOperation2Async()
        {
            // Snippet: CancelOperationAsync(string, CallSettings)
            // Additional: CancelOperationAsync(string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            await clusterManagerClient.CancelOperationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetServerConfig</summary>
        public void GetServerConfigRequestObject()
        {
            // Snippet: GetServerConfig(GetServerConfigRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            GetServerConfigRequest request = new GetServerConfigRequest { Name = "", };
            // Make the request
            ServerConfig response = clusterManagerClient.GetServerConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetServerConfigAsync</summary>
        public async Task GetServerConfigRequestObjectAsync()
        {
            // Snippet: GetServerConfigAsync(GetServerConfigRequest, CallSettings)
            // Additional: GetServerConfigAsync(GetServerConfigRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetServerConfigRequest request = new GetServerConfigRequest { Name = "", };
            // Make the request
            ServerConfig response = await clusterManagerClient.GetServerConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServerConfig</summary>
        public void GetServerConfig1()
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
        public async Task GetServerConfig1Async()
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

        /// <summary>Snippet for GetServerConfig</summary>
        public void GetServerConfig2()
        {
            // Snippet: GetServerConfig(string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            ServerConfig response = clusterManagerClient.GetServerConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetServerConfigAsync</summary>
        public async Task GetServerConfig2Async()
        {
            // Snippet: GetServerConfigAsync(string, CallSettings)
            // Additional: GetServerConfigAsync(string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            ServerConfig response = await clusterManagerClient.GetServerConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetJSONWebKeys</summary>
        public void GetJSONWebKeysRequestObject()
        {
            // Snippet: GetJSONWebKeys(GetJSONWebKeysRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            GetJSONWebKeysRequest request = new GetJSONWebKeysRequest { Parent = "", };
            // Make the request
            GetJSONWebKeysResponse response = clusterManagerClient.GetJSONWebKeys(request);
            // End snippet
        }

        /// <summary>Snippet for GetJSONWebKeysAsync</summary>
        public async Task GetJSONWebKeysRequestObjectAsync()
        {
            // Snippet: GetJSONWebKeysAsync(GetJSONWebKeysRequest, CallSettings)
            // Additional: GetJSONWebKeysAsync(GetJSONWebKeysRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetJSONWebKeysRequest request = new GetJSONWebKeysRequest { Parent = "", };
            // Make the request
            GetJSONWebKeysResponse response = await clusterManagerClient.GetJSONWebKeysAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListNodePools</summary>
        public void ListNodePoolsRequestObject()
        {
            // Snippet: ListNodePools(ListNodePoolsRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            ListNodePoolsRequest request = new ListNodePoolsRequest { Parent = "", };
            // Make the request
            ListNodePoolsResponse response = clusterManagerClient.ListNodePools(request);
            // End snippet
        }

        /// <summary>Snippet for ListNodePoolsAsync</summary>
        public async Task ListNodePoolsRequestObjectAsync()
        {
            // Snippet: ListNodePoolsAsync(ListNodePoolsRequest, CallSettings)
            // Additional: ListNodePoolsAsync(ListNodePoolsRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListNodePoolsRequest request = new ListNodePoolsRequest { Parent = "", };
            // Make the request
            ListNodePoolsResponse response = await clusterManagerClient.ListNodePoolsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListNodePools</summary>
        public void ListNodePools1()
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
        public async Task ListNodePools1Async()
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

        /// <summary>Snippet for ListNodePools</summary>
        public void ListNodePools2()
        {
            // Snippet: ListNodePools(string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            ListNodePoolsResponse response = clusterManagerClient.ListNodePools(parent);
            // End snippet
        }

        /// <summary>Snippet for ListNodePoolsAsync</summary>
        public async Task ListNodePools2Async()
        {
            // Snippet: ListNodePoolsAsync(string, CallSettings)
            // Additional: ListNodePoolsAsync(string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            ListNodePoolsResponse response = await clusterManagerClient.ListNodePoolsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for GetNodePool</summary>
        public void GetNodePoolRequestObject()
        {
            // Snippet: GetNodePool(GetNodePoolRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            GetNodePoolRequest request = new GetNodePoolRequest { Name = "", };
            // Make the request
            NodePool response = clusterManagerClient.GetNodePool(request);
            // End snippet
        }

        /// <summary>Snippet for GetNodePoolAsync</summary>
        public async Task GetNodePoolRequestObjectAsync()
        {
            // Snippet: GetNodePoolAsync(GetNodePoolRequest, CallSettings)
            // Additional: GetNodePoolAsync(GetNodePoolRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetNodePoolRequest request = new GetNodePoolRequest { Name = "", };
            // Make the request
            NodePool response = await clusterManagerClient.GetNodePoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNodePool</summary>
        public void GetNodePool1()
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
        public async Task GetNodePool1Async()
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

        /// <summary>Snippet for GetNodePool</summary>
        public void GetNodePool2()
        {
            // Snippet: GetNodePool(string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            NodePool response = clusterManagerClient.GetNodePool(name);
            // End snippet
        }

        /// <summary>Snippet for GetNodePoolAsync</summary>
        public async Task GetNodePool2Async()
        {
            // Snippet: GetNodePoolAsync(string, CallSettings)
            // Additional: GetNodePoolAsync(string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            NodePool response = await clusterManagerClient.GetNodePoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateNodePool</summary>
        public void CreateNodePoolRequestObject()
        {
            // Snippet: CreateNodePool(CreateNodePoolRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            CreateNodePoolRequest request = new CreateNodePoolRequest
            {
                NodePool = new NodePool(),
                Parent = "",
            };
            // Make the request
            Operation response = clusterManagerClient.CreateNodePool(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNodePoolAsync</summary>
        public async Task CreateNodePoolRequestObjectAsync()
        {
            // Snippet: CreateNodePoolAsync(CreateNodePoolRequest, CallSettings)
            // Additional: CreateNodePoolAsync(CreateNodePoolRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateNodePoolRequest request = new CreateNodePoolRequest
            {
                NodePool = new NodePool(),
                Parent = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.CreateNodePoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNodePool</summary>
        public void CreateNodePool1()
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
        public async Task CreateNodePool1Async()
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

        /// <summary>Snippet for CreateNodePool</summary>
        public void CreateNodePool2()
        {
            // Snippet: CreateNodePool(string, NodePool, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string parent = "";
            NodePool nodePool = new NodePool();
            // Make the request
            Operation response = clusterManagerClient.CreateNodePool(parent, nodePool);
            // End snippet
        }

        /// <summary>Snippet for CreateNodePoolAsync</summary>
        public async Task CreateNodePool2Async()
        {
            // Snippet: CreateNodePoolAsync(string, NodePool, CallSettings)
            // Additional: CreateNodePoolAsync(string, NodePool, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            NodePool nodePool = new NodePool();
            // Make the request
            Operation response = await clusterManagerClient.CreateNodePoolAsync(parent, nodePool);
            // End snippet
        }

        /// <summary>Snippet for DeleteNodePool</summary>
        public void DeleteNodePoolRequestObject()
        {
            // Snippet: DeleteNodePool(DeleteNodePoolRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            DeleteNodePoolRequest request = new DeleteNodePoolRequest { Name = "", };
            // Make the request
            Operation response = clusterManagerClient.DeleteNodePool(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNodePoolAsync</summary>
        public async Task DeleteNodePoolRequestObjectAsync()
        {
            // Snippet: DeleteNodePoolAsync(DeleteNodePoolRequest, CallSettings)
            // Additional: DeleteNodePoolAsync(DeleteNodePoolRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNodePoolRequest request = new DeleteNodePoolRequest { Name = "", };
            // Make the request
            Operation response = await clusterManagerClient.DeleteNodePoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNodePool</summary>
        public void DeleteNodePool1()
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
        public async Task DeleteNodePool1Async()
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

        /// <summary>Snippet for DeleteNodePool</summary>
        public void DeleteNodePool2()
        {
            // Snippet: DeleteNodePool(string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation response = clusterManagerClient.DeleteNodePool(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNodePoolAsync</summary>
        public async Task DeleteNodePool2Async()
        {
            // Snippet: DeleteNodePoolAsync(string, CallSettings)
            // Additional: DeleteNodePoolAsync(string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation response = await clusterManagerClient.DeleteNodePoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RollbackNodePoolUpgrade</summary>
        public void RollbackNodePoolUpgradeRequestObject()
        {
            // Snippet: RollbackNodePoolUpgrade(RollbackNodePoolUpgradeRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            RollbackNodePoolUpgradeRequest request = new RollbackNodePoolUpgradeRequest { Name = "", };
            // Make the request
            Operation response = clusterManagerClient.RollbackNodePoolUpgrade(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackNodePoolUpgradeAsync</summary>
        public async Task RollbackNodePoolUpgradeRequestObjectAsync()
        {
            // Snippet: RollbackNodePoolUpgradeAsync(RollbackNodePoolUpgradeRequest, CallSettings)
            // Additional: RollbackNodePoolUpgradeAsync(RollbackNodePoolUpgradeRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            RollbackNodePoolUpgradeRequest request = new RollbackNodePoolUpgradeRequest { Name = "", };
            // Make the request
            Operation response = await clusterManagerClient.RollbackNodePoolUpgradeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackNodePoolUpgrade</summary>
        public void RollbackNodePoolUpgrade1()
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
        public async Task RollbackNodePoolUpgrade1Async()
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

        /// <summary>Snippet for RollbackNodePoolUpgrade</summary>
        public void RollbackNodePoolUpgrade2()
        {
            // Snippet: RollbackNodePoolUpgrade(string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation response = clusterManagerClient.RollbackNodePoolUpgrade(name);
            // End snippet
        }

        /// <summary>Snippet for RollbackNodePoolUpgradeAsync</summary>
        public async Task RollbackNodePoolUpgrade2Async()
        {
            // Snippet: RollbackNodePoolUpgradeAsync(string, CallSettings)
            // Additional: RollbackNodePoolUpgradeAsync(string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation response = await clusterManagerClient.RollbackNodePoolUpgradeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolManagement</summary>
        public void SetNodePoolManagementRequestObject()
        {
            // Snippet: SetNodePoolManagement(SetNodePoolManagementRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetNodePoolManagementRequest request = new SetNodePoolManagementRequest
            {
                Management = new NodeManagement(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetNodePoolManagement(request);
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolManagementAsync</summary>
        public async Task SetNodePoolManagementRequestObjectAsync()
        {
            // Snippet: SetNodePoolManagementAsync(SetNodePoolManagementRequest, CallSettings)
            // Additional: SetNodePoolManagementAsync(SetNodePoolManagementRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetNodePoolManagementRequest request = new SetNodePoolManagementRequest
            {
                Management = new NodeManagement(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetNodePoolManagementAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetLabelsRequest request = new SetLabelsRequest
            {
                ResourceLabels = { { "", "" }, },
                LabelFingerprint = "",
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetLabels(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsRequestObjectAsync()
        {
            // Snippet: SetLabelsAsync(SetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsRequest request = new SetLabelsRequest
            {
                ResourceLabels = { { "", "" }, },
                LabelFingerprint = "",
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLegacyAbac</summary>
        public void SetLegacyAbacRequestObject()
        {
            // Snippet: SetLegacyAbac(SetLegacyAbacRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetLegacyAbacRequest request = new SetLegacyAbacRequest
            {
                Enabled = false,
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetLegacyAbac(request);
            // End snippet
        }

        /// <summary>Snippet for SetLegacyAbacAsync</summary>
        public async Task SetLegacyAbacRequestObjectAsync()
        {
            // Snippet: SetLegacyAbacAsync(SetLegacyAbacRequest, CallSettings)
            // Additional: SetLegacyAbacAsync(SetLegacyAbacRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetLegacyAbacRequest request = new SetLegacyAbacRequest
            {
                Enabled = false,
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetLegacyAbacAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLegacyAbac</summary>
        public void SetLegacyAbac1()
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
        public async Task SetLegacyAbac1Async()
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

        /// <summary>Snippet for SetLegacyAbac</summary>
        public void SetLegacyAbac2()
        {
            // Snippet: SetLegacyAbac(string, bool, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            bool enabled = false;
            // Make the request
            Operation response = clusterManagerClient.SetLegacyAbac(name, enabled);
            // End snippet
        }

        /// <summary>Snippet for SetLegacyAbacAsync</summary>
        public async Task SetLegacyAbac2Async()
        {
            // Snippet: SetLegacyAbacAsync(string, bool, CallSettings)
            // Additional: SetLegacyAbacAsync(string, bool, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            bool enabled = false;
            // Make the request
            Operation response = await clusterManagerClient.SetLegacyAbacAsync(name, enabled);
            // End snippet
        }

        /// <summary>Snippet for StartIPRotation</summary>
        public void StartIPRotationRequestObject()
        {
            // Snippet: StartIPRotation(StartIPRotationRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            StartIPRotationRequest request = new StartIPRotationRequest
            {
                Name = "",
                RotateCredentials = false,
            };
            // Make the request
            Operation response = clusterManagerClient.StartIPRotation(request);
            // End snippet
        }

        /// <summary>Snippet for StartIPRotationAsync</summary>
        public async Task StartIPRotationRequestObjectAsync()
        {
            // Snippet: StartIPRotationAsync(StartIPRotationRequest, CallSettings)
            // Additional: StartIPRotationAsync(StartIPRotationRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            StartIPRotationRequest request = new StartIPRotationRequest
            {
                Name = "",
                RotateCredentials = false,
            };
            // Make the request
            Operation response = await clusterManagerClient.StartIPRotationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartIPRotation</summary>
        public void StartIPRotation1()
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
        public async Task StartIPRotation1Async()
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

        /// <summary>Snippet for StartIPRotation</summary>
        public void StartIPRotation2()
        {
            // Snippet: StartIPRotation(string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation response = clusterManagerClient.StartIPRotation(name);
            // End snippet
        }

        /// <summary>Snippet for StartIPRotationAsync</summary>
        public async Task StartIPRotation2Async()
        {
            // Snippet: StartIPRotationAsync(string, CallSettings)
            // Additional: StartIPRotationAsync(string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation response = await clusterManagerClient.StartIPRotationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CompleteIPRotation</summary>
        public void CompleteIPRotationRequestObject()
        {
            // Snippet: CompleteIPRotation(CompleteIPRotationRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            CompleteIPRotationRequest request = new CompleteIPRotationRequest { Name = "", };
            // Make the request
            Operation response = clusterManagerClient.CompleteIPRotation(request);
            // End snippet
        }

        /// <summary>Snippet for CompleteIPRotationAsync</summary>
        public async Task CompleteIPRotationRequestObjectAsync()
        {
            // Snippet: CompleteIPRotationAsync(CompleteIPRotationRequest, CallSettings)
            // Additional: CompleteIPRotationAsync(CompleteIPRotationRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            CompleteIPRotationRequest request = new CompleteIPRotationRequest { Name = "", };
            // Make the request
            Operation response = await clusterManagerClient.CompleteIPRotationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CompleteIPRotation</summary>
        public void CompleteIPRotation1()
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
        public async Task CompleteIPRotation1Async()
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

        /// <summary>Snippet for CompleteIPRotation</summary>
        public void CompleteIPRotation2()
        {
            // Snippet: CompleteIPRotation(string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation response = clusterManagerClient.CompleteIPRotation(name);
            // End snippet
        }

        /// <summary>Snippet for CompleteIPRotationAsync</summary>
        public async Task CompleteIPRotation2Async()
        {
            // Snippet: CompleteIPRotationAsync(string, CallSettings)
            // Additional: CompleteIPRotationAsync(string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation response = await clusterManagerClient.CompleteIPRotationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolSize</summary>
        public void SetNodePoolSizeRequestObject()
        {
            // Snippet: SetNodePoolSize(SetNodePoolSizeRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetNodePoolSizeRequest request = new SetNodePoolSizeRequest
            {
                NodeCount = 0,
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetNodePoolSize(request);
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolSizeAsync</summary>
        public async Task SetNodePoolSizeRequestObjectAsync()
        {
            // Snippet: SetNodePoolSizeAsync(SetNodePoolSizeRequest, CallSettings)
            // Additional: SetNodePoolSizeAsync(SetNodePoolSizeRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetNodePoolSizeRequest request = new SetNodePoolSizeRequest
            {
                NodeCount = 0,
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetNodePoolSizeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetNetworkPolicy</summary>
        public void SetNetworkPolicyRequestObject()
        {
            // Snippet: SetNetworkPolicy(SetNetworkPolicyRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetNetworkPolicyRequest request = new SetNetworkPolicyRequest
            {
                NetworkPolicy = new NetworkPolicy(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetNetworkPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetNetworkPolicyAsync</summary>
        public async Task SetNetworkPolicyRequestObjectAsync()
        {
            // Snippet: SetNetworkPolicyAsync(SetNetworkPolicyRequest, CallSettings)
            // Additional: SetNetworkPolicyAsync(SetNetworkPolicyRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetNetworkPolicyRequest request = new SetNetworkPolicyRequest
            {
                NetworkPolicy = new NetworkPolicy(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetNetworkPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetNetworkPolicy</summary>
        public void SetNetworkPolicy1()
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
        public async Task SetNetworkPolicy1Async()
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

        /// <summary>Snippet for SetNetworkPolicy</summary>
        public void SetNetworkPolicy2()
        {
            // Snippet: SetNetworkPolicy(string, NetworkPolicy, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            NetworkPolicy networkPolicy = new NetworkPolicy();
            // Make the request
            Operation response = clusterManagerClient.SetNetworkPolicy(name, networkPolicy);
            // End snippet
        }

        /// <summary>Snippet for SetNetworkPolicyAsync</summary>
        public async Task SetNetworkPolicy2Async()
        {
            // Snippet: SetNetworkPolicyAsync(string, NetworkPolicy, CallSettings)
            // Additional: SetNetworkPolicyAsync(string, NetworkPolicy, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            NetworkPolicy networkPolicy = new NetworkPolicy();
            // Make the request
            Operation response = await clusterManagerClient.SetNetworkPolicyAsync(name, networkPolicy);
            // End snippet
        }

        /// <summary>Snippet for SetMaintenancePolicy</summary>
        public void SetMaintenancePolicyRequestObject()
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
        public async Task SetMaintenancePolicyRequestObjectAsync()
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
        public void SetMaintenancePolicy1()
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
        public async Task SetMaintenancePolicy1Async()
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

        /// <summary>Snippet for SetMaintenancePolicy</summary>
        public void SetMaintenancePolicy2()
        {
            // Snippet: SetMaintenancePolicy(string, MaintenancePolicy, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string name = "";
            MaintenancePolicy maintenancePolicy = new MaintenancePolicy();
            // Make the request
            Operation response = clusterManagerClient.SetMaintenancePolicy(name, maintenancePolicy);
            // End snippet
        }

        /// <summary>Snippet for SetMaintenancePolicyAsync</summary>
        public async Task SetMaintenancePolicy2Async()
        {
            // Snippet: SetMaintenancePolicyAsync(string, MaintenancePolicy, CallSettings)
            // Additional: SetMaintenancePolicyAsync(string, MaintenancePolicy, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            MaintenancePolicy maintenancePolicy = new MaintenancePolicy();
            // Make the request
            Operation response = await clusterManagerClient.SetMaintenancePolicyAsync(name, maintenancePolicy);
            // End snippet
        }

        /// <summary>Snippet for ListUsableSubnetworks</summary>
        public void ListUsableSubnetworksRequestObject()
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
        public async Task ListUsableSubnetworksRequestObjectAsync()
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
