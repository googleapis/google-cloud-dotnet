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

using gaxgrpc = Google.Api.Gax.Grpc;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Container.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedClusterManagerClientTest
    {
        [xunit::FactAttribute]
        public void ListClustersRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            ListClustersRequest request = new ListClustersRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                Parent = "parent7858e4d0",
            };
            ListClustersResponse expectedResponse = new ListClustersResponse
            {
                Clusters = { new Cluster(), },
                MissingZones =
                {
                    "missing_zonesc3271512",
                },
            };
            mockGrpcClient.Setup(x => x.ListClusters(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ListClustersResponse response = client.ListClusters(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListClustersRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            ListClustersRequest request = new ListClustersRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                Parent = "parent7858e4d0",
            };
            ListClustersResponse expectedResponse = new ListClustersResponse
            {
                Clusters = { new Cluster(), },
                MissingZones =
                {
                    "missing_zonesc3271512",
                },
            };
            mockGrpcClient.Setup(x => x.ListClustersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListClustersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ListClustersResponse responseCallSettings = await client.ListClustersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListClustersResponse responseCancellationToken = await client.ListClustersAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListClusters()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            ListClustersRequest request = new ListClustersRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
            };
            ListClustersResponse expectedResponse = new ListClustersResponse
            {
                Clusters = { new Cluster(), },
                MissingZones =
                {
                    "missing_zonesc3271512",
                },
            };
            mockGrpcClient.Setup(x => x.ListClusters(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ListClustersResponse response = client.ListClusters(request.ProjectId, request.Zone);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListClustersAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            ListClustersRequest request = new ListClustersRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
            };
            ListClustersResponse expectedResponse = new ListClustersResponse
            {
                Clusters = { new Cluster(), },
                MissingZones =
                {
                    "missing_zonesc3271512",
                },
            };
            mockGrpcClient.Setup(x => x.ListClustersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListClustersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ListClustersResponse responseCallSettings = await client.ListClustersAsync(request.ProjectId, request.Zone, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListClustersResponse responseCancellationToken = await client.ListClustersAsync(request.ProjectId, request.Zone, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetClusterRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Name = "name1c9368b0",
            };
            Cluster expectedResponse = new Cluster
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                InitialNodeCount = -1915714087,
                NodeConfig = new NodeConfig(),
                MasterAuth = new MasterAuth(),
                LoggingService = "logging_servicef4a99d37",
                MonitoringService = "monitoring_servicedbe039a3",
                Network = "networkd22ce091",
                ClusterIpv4Cidr = "cluster_ipv4_cidr15665f62",
                AddonsConfig = new AddonsConfig(),
                Subnetwork = "subnetworkf55bf572",
                NodePools = { new NodePool(), },
                Locations =
                {
                    "locationsc7b6c0b4",
                },
                EnableKubernetesAlpha = true,
                ResourceLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LabelFingerprint = "label_fingerprint06ccff3a",
                LegacyAbac = new LegacyAbac(),
                NetworkPolicy = new NetworkPolicy(),
                IpAllocationPolicy = new IPAllocationPolicy(),
                MasterAuthorizedNetworksConfig = new MasterAuthorizedNetworksConfig(),
                MaintenancePolicy = new MaintenancePolicy(),
                BinaryAuthorization = new BinaryAuthorization(),
                Autoscaling = new ClusterAutoscaling(),
                NetworkConfig = new NetworkConfig(),
                DefaultMaxPodsConstraint = new MaxPodsConstraint(),
                ResourceUsageExportConfig = new ResourceUsageExportConfig(),
                AuthenticatorGroupsConfig = new AuthenticatorGroupsConfig(),
                PrivateClusterConfig = new PrivateClusterConfig(),
                DatabaseEncryption = new DatabaseEncryption(),
                VerticalPodAutoscaling = new VerticalPodAutoscaling(),
                SelfLink = "self_link7e87f12d",
                Zone = "zone255f4ea8",
                Endpoint = "endpoint1bd965ad",
                InitialClusterVersion = "initial_cluster_version79eeef4e",
                CurrentMasterVersion = "current_master_version7d3048c2",
                CurrentNodeVersion = "current_node_versione23796e0",
                CreateTime = "create_time65626ab1",
                Status = Cluster.Types.Status.Reconciling,
                StatusMessage = "status_message2c618f86",
                NodeIpv4CidrSize = -278265782,
                ServicesIpv4Cidr = "services_ipv4_cidrbf6e6907",
                InstanceGroupUrls =
                {
                    "instance_group_urlsbc2a92b9",
                },
                CurrentNodeCount = -203923744,
                ExpireTime = "expire_timece1cc25c",
                Location = "locatione09d18d5",
                EnableTpu = true,
                TpuIpv4CidrBlock = "tpu_ipv4_cidr_block3e3ece05",
                Conditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Cluster response = client.GetCluster(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClusterRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Name = "name1c9368b0",
            };
            Cluster expectedResponse = new Cluster
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                InitialNodeCount = -1915714087,
                NodeConfig = new NodeConfig(),
                MasterAuth = new MasterAuth(),
                LoggingService = "logging_servicef4a99d37",
                MonitoringService = "monitoring_servicedbe039a3",
                Network = "networkd22ce091",
                ClusterIpv4Cidr = "cluster_ipv4_cidr15665f62",
                AddonsConfig = new AddonsConfig(),
                Subnetwork = "subnetworkf55bf572",
                NodePools = { new NodePool(), },
                Locations =
                {
                    "locationsc7b6c0b4",
                },
                EnableKubernetesAlpha = true,
                ResourceLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LabelFingerprint = "label_fingerprint06ccff3a",
                LegacyAbac = new LegacyAbac(),
                NetworkPolicy = new NetworkPolicy(),
                IpAllocationPolicy = new IPAllocationPolicy(),
                MasterAuthorizedNetworksConfig = new MasterAuthorizedNetworksConfig(),
                MaintenancePolicy = new MaintenancePolicy(),
                BinaryAuthorization = new BinaryAuthorization(),
                Autoscaling = new ClusterAutoscaling(),
                NetworkConfig = new NetworkConfig(),
                DefaultMaxPodsConstraint = new MaxPodsConstraint(),
                ResourceUsageExportConfig = new ResourceUsageExportConfig(),
                AuthenticatorGroupsConfig = new AuthenticatorGroupsConfig(),
                PrivateClusterConfig = new PrivateClusterConfig(),
                DatabaseEncryption = new DatabaseEncryption(),
                VerticalPodAutoscaling = new VerticalPodAutoscaling(),
                SelfLink = "self_link7e87f12d",
                Zone = "zone255f4ea8",
                Endpoint = "endpoint1bd965ad",
                InitialClusterVersion = "initial_cluster_version79eeef4e",
                CurrentMasterVersion = "current_master_version7d3048c2",
                CurrentNodeVersion = "current_node_versione23796e0",
                CreateTime = "create_time65626ab1",
                Status = Cluster.Types.Status.Reconciling,
                StatusMessage = "status_message2c618f86",
                NodeIpv4CidrSize = -278265782,
                ServicesIpv4Cidr = "services_ipv4_cidrbf6e6907",
                InstanceGroupUrls =
                {
                    "instance_group_urlsbc2a92b9",
                },
                CurrentNodeCount = -203923744,
                ExpireTime = "expire_timece1cc25c",
                Location = "locatione09d18d5",
                EnableTpu = true,
                TpuIpv4CidrBlock = "tpu_ipv4_cidr_block3e3ece05",
                Conditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.GetClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Cluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Cluster responseCallSettings = await client.GetClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Cluster responseCancellationToken = await client.GetClusterAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCluster()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
            };
            Cluster expectedResponse = new Cluster
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                InitialNodeCount = -1915714087,
                NodeConfig = new NodeConfig(),
                MasterAuth = new MasterAuth(),
                LoggingService = "logging_servicef4a99d37",
                MonitoringService = "monitoring_servicedbe039a3",
                Network = "networkd22ce091",
                ClusterIpv4Cidr = "cluster_ipv4_cidr15665f62",
                AddonsConfig = new AddonsConfig(),
                Subnetwork = "subnetworkf55bf572",
                NodePools = { new NodePool(), },
                Locations =
                {
                    "locationsc7b6c0b4",
                },
                EnableKubernetesAlpha = true,
                ResourceLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LabelFingerprint = "label_fingerprint06ccff3a",
                LegacyAbac = new LegacyAbac(),
                NetworkPolicy = new NetworkPolicy(),
                IpAllocationPolicy = new IPAllocationPolicy(),
                MasterAuthorizedNetworksConfig = new MasterAuthorizedNetworksConfig(),
                MaintenancePolicy = new MaintenancePolicy(),
                BinaryAuthorization = new BinaryAuthorization(),
                Autoscaling = new ClusterAutoscaling(),
                NetworkConfig = new NetworkConfig(),
                DefaultMaxPodsConstraint = new MaxPodsConstraint(),
                ResourceUsageExportConfig = new ResourceUsageExportConfig(),
                AuthenticatorGroupsConfig = new AuthenticatorGroupsConfig(),
                PrivateClusterConfig = new PrivateClusterConfig(),
                DatabaseEncryption = new DatabaseEncryption(),
                VerticalPodAutoscaling = new VerticalPodAutoscaling(),
                SelfLink = "self_link7e87f12d",
                Zone = "zone255f4ea8",
                Endpoint = "endpoint1bd965ad",
                InitialClusterVersion = "initial_cluster_version79eeef4e",
                CurrentMasterVersion = "current_master_version7d3048c2",
                CurrentNodeVersion = "current_node_versione23796e0",
                CreateTime = "create_time65626ab1",
                Status = Cluster.Types.Status.Reconciling,
                StatusMessage = "status_message2c618f86",
                NodeIpv4CidrSize = -278265782,
                ServicesIpv4Cidr = "services_ipv4_cidrbf6e6907",
                InstanceGroupUrls =
                {
                    "instance_group_urlsbc2a92b9",
                },
                CurrentNodeCount = -203923744,
                ExpireTime = "expire_timece1cc25c",
                Location = "locatione09d18d5",
                EnableTpu = true,
                TpuIpv4CidrBlock = "tpu_ipv4_cidr_block3e3ece05",
                Conditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Cluster response = client.GetCluster(request.ProjectId, request.Zone, request.ClusterId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClusterAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
            };
            Cluster expectedResponse = new Cluster
            {
                Name = "name1c9368b0",
                Description = "description2cf9da67",
                InitialNodeCount = -1915714087,
                NodeConfig = new NodeConfig(),
                MasterAuth = new MasterAuth(),
                LoggingService = "logging_servicef4a99d37",
                MonitoringService = "monitoring_servicedbe039a3",
                Network = "networkd22ce091",
                ClusterIpv4Cidr = "cluster_ipv4_cidr15665f62",
                AddonsConfig = new AddonsConfig(),
                Subnetwork = "subnetworkf55bf572",
                NodePools = { new NodePool(), },
                Locations =
                {
                    "locationsc7b6c0b4",
                },
                EnableKubernetesAlpha = true,
                ResourceLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LabelFingerprint = "label_fingerprint06ccff3a",
                LegacyAbac = new LegacyAbac(),
                NetworkPolicy = new NetworkPolicy(),
                IpAllocationPolicy = new IPAllocationPolicy(),
                MasterAuthorizedNetworksConfig = new MasterAuthorizedNetworksConfig(),
                MaintenancePolicy = new MaintenancePolicy(),
                BinaryAuthorization = new BinaryAuthorization(),
                Autoscaling = new ClusterAutoscaling(),
                NetworkConfig = new NetworkConfig(),
                DefaultMaxPodsConstraint = new MaxPodsConstraint(),
                ResourceUsageExportConfig = new ResourceUsageExportConfig(),
                AuthenticatorGroupsConfig = new AuthenticatorGroupsConfig(),
                PrivateClusterConfig = new PrivateClusterConfig(),
                DatabaseEncryption = new DatabaseEncryption(),
                VerticalPodAutoscaling = new VerticalPodAutoscaling(),
                SelfLink = "self_link7e87f12d",
                Zone = "zone255f4ea8",
                Endpoint = "endpoint1bd965ad",
                InitialClusterVersion = "initial_cluster_version79eeef4e",
                CurrentMasterVersion = "current_master_version7d3048c2",
                CurrentNodeVersion = "current_node_versione23796e0",
                CreateTime = "create_time65626ab1",
                Status = Cluster.Types.Status.Reconciling,
                StatusMessage = "status_message2c618f86",
                NodeIpv4CidrSize = -278265782,
                ServicesIpv4Cidr = "services_ipv4_cidrbf6e6907",
                InstanceGroupUrls =
                {
                    "instance_group_urlsbc2a92b9",
                },
                CurrentNodeCount = -203923744,
                ExpireTime = "expire_timece1cc25c",
                Location = "locatione09d18d5",
                EnableTpu = true,
                TpuIpv4CidrBlock = "tpu_ipv4_cidr_block3e3ece05",
                Conditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.GetClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Cluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Cluster responseCallSettings = await client.GetClusterAsync(request.ProjectId, request.Zone, request.ClusterId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Cluster responseCancellationToken = await client.GetClusterAsync(request.ProjectId, request.Zone, request.ClusterId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateClusterRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            CreateClusterRequest request = new CreateClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                Cluster = new Cluster(),
                Parent = "parent7858e4d0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.CreateCluster(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateClusterRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            CreateClusterRequest request = new CreateClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                Cluster = new Cluster(),
                Parent = "parent7858e4d0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.CreateClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.CreateClusterAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCluster()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            CreateClusterRequest request = new CreateClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                Cluster = new Cluster(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.CreateCluster(request.ProjectId, request.Zone, request.Cluster);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateClusterAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            CreateClusterRequest request = new CreateClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                Cluster = new Cluster(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.CreateClusterAsync(request.ProjectId, request.Zone, request.Cluster, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.CreateClusterAsync(request.ProjectId, request.Zone, request.Cluster, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateClusterRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Update = new ClusterUpdate(),
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdateCluster(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateClusterRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Update = new ClusterUpdate(),
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateClusterAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCluster()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Update = new ClusterUpdate(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdateCluster(request.ProjectId, request.Zone, request.ClusterId, request.Update);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateClusterAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Update = new ClusterUpdate(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateClusterAsync(request.ProjectId, request.Zone, request.ClusterId, request.Update, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateClusterAsync(request.ProjectId, request.Zone, request.ClusterId, request.Update, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateNodePoolRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            UpdateNodePoolRequest request = new UpdateNodePoolRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
                NodeVersion = "node_version322edae3",
                ImageType = "image_typef66746e9",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateNodePool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdateNodePool(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateNodePoolRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            UpdateNodePoolRequest request = new UpdateNodePoolRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
                NodeVersion = "node_version322edae3",
                ImageType = "image_typef66746e9",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateNodePoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateNodePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateNodePoolAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetNodePoolAutoscalingRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetNodePoolAutoscalingRequest request = new SetNodePoolAutoscalingRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
                Autoscaling = new NodePoolAutoscaling(),
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetNodePoolAutoscaling(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetNodePoolAutoscaling(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetNodePoolAutoscalingRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetNodePoolAutoscalingRequest request = new SetNodePoolAutoscalingRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
                Autoscaling = new NodePoolAutoscaling(),
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetNodePoolAutoscalingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetNodePoolAutoscalingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetNodePoolAutoscalingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetLoggingServiceRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetLoggingServiceRequest request = new SetLoggingServiceRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                LoggingService = "logging_servicef4a99d37",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetLoggingService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLoggingService(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetLoggingServiceRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetLoggingServiceRequest request = new SetLoggingServiceRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                LoggingService = "logging_servicef4a99d37",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetLoggingServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetLoggingServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetLoggingServiceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetLoggingService()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetLoggingServiceRequest request = new SetLoggingServiceRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                LoggingService = "logging_servicef4a99d37",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetLoggingService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLoggingService(request.ProjectId, request.Zone, request.ClusterId, request.LoggingService);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetLoggingServiceAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetLoggingServiceRequest request = new SetLoggingServiceRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                LoggingService = "logging_servicef4a99d37",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetLoggingServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetLoggingServiceAsync(request.ProjectId, request.Zone, request.ClusterId, request.LoggingService, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetLoggingServiceAsync(request.ProjectId, request.Zone, request.ClusterId, request.LoggingService, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetMonitoringServiceRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetMonitoringServiceRequest request = new SetMonitoringServiceRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                MonitoringService = "monitoring_servicedbe039a3",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetMonitoringService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetMonitoringService(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetMonitoringServiceRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetMonitoringServiceRequest request = new SetMonitoringServiceRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                MonitoringService = "monitoring_servicedbe039a3",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetMonitoringServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetMonitoringServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetMonitoringServiceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetMonitoringService()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetMonitoringServiceRequest request = new SetMonitoringServiceRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                MonitoringService = "monitoring_servicedbe039a3",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetMonitoringService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetMonitoringService(request.ProjectId, request.Zone, request.ClusterId, request.MonitoringService);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetMonitoringServiceAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetMonitoringServiceRequest request = new SetMonitoringServiceRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                MonitoringService = "monitoring_servicedbe039a3",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetMonitoringServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetMonitoringServiceAsync(request.ProjectId, request.Zone, request.ClusterId, request.MonitoringService, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetMonitoringServiceAsync(request.ProjectId, request.Zone, request.ClusterId, request.MonitoringService, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetAddonsConfigRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetAddonsConfigRequest request = new SetAddonsConfigRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                AddonsConfig = new AddonsConfig(),
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetAddonsConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetAddonsConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetAddonsConfigRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetAddonsConfigRequest request = new SetAddonsConfigRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                AddonsConfig = new AddonsConfig(),
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetAddonsConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetAddonsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetAddonsConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetAddonsConfig()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetAddonsConfigRequest request = new SetAddonsConfigRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                AddonsConfig = new AddonsConfig(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetAddonsConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetAddonsConfig(request.ProjectId, request.Zone, request.ClusterId, request.AddonsConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetAddonsConfigAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetAddonsConfigRequest request = new SetAddonsConfigRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                AddonsConfig = new AddonsConfig(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetAddonsConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetAddonsConfigAsync(request.ProjectId, request.Zone, request.ClusterId, request.AddonsConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetAddonsConfigAsync(request.ProjectId, request.Zone, request.ClusterId, request.AddonsConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetLocationsRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetLocationsRequest request = new SetLocationsRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Locations =
                {
                    "locationsc7b6c0b4",
                },
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetLocations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLocations(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetLocationsRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetLocationsRequest request = new SetLocationsRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Locations =
                {
                    "locationsc7b6c0b4",
                },
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetLocationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetLocationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetLocationsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetLocations()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetLocationsRequest request = new SetLocationsRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Locations =
                {
                    "locationsc7b6c0b4",
                },
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetLocations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLocations(request.ProjectId, request.Zone, request.ClusterId, request.Locations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetLocationsAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetLocationsRequest request = new SetLocationsRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Locations =
                {
                    "locationsc7b6c0b4",
                },
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetLocationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetLocationsAsync(request.ProjectId, request.Zone, request.ClusterId, request.Locations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetLocationsAsync(request.ProjectId, request.Zone, request.ClusterId, request.Locations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateMasterRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            UpdateMasterRequest request = new UpdateMasterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                MasterVersion = "master_versioned94d028",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateMaster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdateMaster(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateMasterRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            UpdateMasterRequest request = new UpdateMasterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                MasterVersion = "master_versioned94d028",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateMasterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateMasterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateMasterAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateMaster()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            UpdateMasterRequest request = new UpdateMasterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                MasterVersion = "master_versioned94d028",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateMaster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdateMaster(request.ProjectId, request.Zone, request.ClusterId, request.MasterVersion);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateMasterAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            UpdateMasterRequest request = new UpdateMasterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                MasterVersion = "master_versioned94d028",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateMasterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateMasterAsync(request.ProjectId, request.Zone, request.ClusterId, request.MasterVersion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateMasterAsync(request.ProjectId, request.Zone, request.ClusterId, request.MasterVersion, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetMasterAuthRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetMasterAuthRequest request = new SetMasterAuthRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Action = SetMasterAuthRequest.Types.Action.SetPassword,
                Update = new MasterAuth(),
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetMasterAuth(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetMasterAuth(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetMasterAuthRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetMasterAuthRequest request = new SetMasterAuthRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Action = SetMasterAuthRequest.Types.Action.SetPassword,
                Update = new MasterAuth(),
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetMasterAuthAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetMasterAuthAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetMasterAuthAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteClusterRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.DeleteCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DeleteCluster(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteClusterRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.DeleteClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteClusterAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCluster()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.DeleteCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DeleteCluster(request.ProjectId, request.Zone, request.ClusterId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteClusterAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.DeleteClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteClusterAsync(request.ProjectId, request.Zone, request.ClusterId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteClusterAsync(request.ProjectId, request.Zone, request.ClusterId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListOperationsRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            ListOperationsRequest request = new ListOperationsRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                Parent = "parent7858e4d0",
            };
            ListOperationsResponse expectedResponse = new ListOperationsResponse
            {
                Operations = { new Operation(), },
                MissingZones =
                {
                    "missing_zonesc3271512",
                },
            };
            mockGrpcClient.Setup(x => x.ListOperations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ListOperationsResponse response = client.ListOperations(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListOperationsRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            ListOperationsRequest request = new ListOperationsRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                Parent = "parent7858e4d0",
            };
            ListOperationsResponse expectedResponse = new ListOperationsResponse
            {
                Operations = { new Operation(), },
                MissingZones =
                {
                    "missing_zonesc3271512",
                },
            };
            mockGrpcClient.Setup(x => x.ListOperationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListOperationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ListOperationsResponse responseCallSettings = await client.ListOperationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListOperationsResponse responseCancellationToken = await client.ListOperationsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListOperations()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            ListOperationsRequest request = new ListOperationsRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
            };
            ListOperationsResponse expectedResponse = new ListOperationsResponse
            {
                Operations = { new Operation(), },
                MissingZones =
                {
                    "missing_zonesc3271512",
                },
            };
            mockGrpcClient.Setup(x => x.ListOperations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ListOperationsResponse response = client.ListOperations(request.ProjectId, request.Zone);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListOperationsAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            ListOperationsRequest request = new ListOperationsRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
            };
            ListOperationsResponse expectedResponse = new ListOperationsResponse
            {
                Operations = { new Operation(), },
                MissingZones =
                {
                    "missing_zonesc3271512",
                },
            };
            mockGrpcClient.Setup(x => x.ListOperationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListOperationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ListOperationsResponse responseCallSettings = await client.ListOperationsAsync(request.ProjectId, request.Zone, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListOperationsResponse responseCancellationToken = await client.ListOperationsAsync(request.ProjectId, request.Zone, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetOperationRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            GetOperationRequest request = new GetOperationRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                OperationId = "operation_id8a494117",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.GetOperation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.GetOperation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOperationRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            GetOperationRequest request = new GetOperationRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                OperationId = "operation_id8a494117",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.GetOperationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.GetOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.GetOperationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetOperation()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            GetOperationRequest request = new GetOperationRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                OperationId = "operation_id8a494117",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.GetOperation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.GetOperation(request.ProjectId, request.Zone, request.OperationId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOperationAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            GetOperationRequest request = new GetOperationRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                OperationId = "operation_id8a494117",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.GetOperationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.GetOperationAsync(request.ProjectId, request.Zone, request.OperationId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.GetOperationAsync(request.ProjectId, request.Zone, request.OperationId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelOperationRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            CancelOperationRequest request = new CancelOperationRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                OperationId = "operation_id8a494117",
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelOperation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            client.CancelOperation(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelOperationRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            CancelOperationRequest request = new CancelOperationRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                OperationId = "operation_id8a494117",
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelOperationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            await client.CancelOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelOperationAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelOperation()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            CancelOperationRequest request = new CancelOperationRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                OperationId = "operation_id8a494117",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelOperation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            client.CancelOperation(request.ProjectId, request.Zone, request.OperationId);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelOperationAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            CancelOperationRequest request = new CancelOperationRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                OperationId = "operation_id8a494117",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelOperationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            await client.CancelOperationAsync(request.ProjectId, request.Zone, request.OperationId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelOperationAsync(request.ProjectId, request.Zone, request.OperationId, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServerConfigRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            GetServerConfigRequest request = new GetServerConfigRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                Name = "name1c9368b0",
            };
            ServerConfig expectedResponse = new ServerConfig
            {
                DefaultClusterVersion = "default_cluster_version3fc51e3b",
                ValidNodeVersions =
                {
                    "valid_node_versions843ef273",
                },
                DefaultImageType = "default_image_typec14f9bb0",
                ValidImageTypes =
                {
                    "valid_image_typesf47060d3",
                },
                ValidMasterVersions =
                {
                    "valid_master_versionsb8edf3fb",
                },
            };
            mockGrpcClient.Setup(x => x.GetServerConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ServerConfig response = client.GetServerConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServerConfigRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            GetServerConfigRequest request = new GetServerConfigRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                Name = "name1c9368b0",
            };
            ServerConfig expectedResponse = new ServerConfig
            {
                DefaultClusterVersion = "default_cluster_version3fc51e3b",
                ValidNodeVersions =
                {
                    "valid_node_versions843ef273",
                },
                DefaultImageType = "default_image_typec14f9bb0",
                ValidImageTypes =
                {
                    "valid_image_typesf47060d3",
                },
                ValidMasterVersions =
                {
                    "valid_master_versionsb8edf3fb",
                },
            };
            mockGrpcClient.Setup(x => x.GetServerConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServerConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ServerConfig responseCallSettings = await client.GetServerConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServerConfig responseCancellationToken = await client.GetServerConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServerConfig()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            GetServerConfigRequest request = new GetServerConfigRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
            };
            ServerConfig expectedResponse = new ServerConfig
            {
                DefaultClusterVersion = "default_cluster_version3fc51e3b",
                ValidNodeVersions =
                {
                    "valid_node_versions843ef273",
                },
                DefaultImageType = "default_image_typec14f9bb0",
                ValidImageTypes =
                {
                    "valid_image_typesf47060d3",
                },
                ValidMasterVersions =
                {
                    "valid_master_versionsb8edf3fb",
                },
            };
            mockGrpcClient.Setup(x => x.GetServerConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ServerConfig response = client.GetServerConfig(request.ProjectId, request.Zone);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServerConfigAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            GetServerConfigRequest request = new GetServerConfigRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
            };
            ServerConfig expectedResponse = new ServerConfig
            {
                DefaultClusterVersion = "default_cluster_version3fc51e3b",
                ValidNodeVersions =
                {
                    "valid_node_versions843ef273",
                },
                DefaultImageType = "default_image_typec14f9bb0",
                ValidImageTypes =
                {
                    "valid_image_typesf47060d3",
                },
                ValidMasterVersions =
                {
                    "valid_master_versionsb8edf3fb",
                },
            };
            mockGrpcClient.Setup(x => x.GetServerConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServerConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ServerConfig responseCallSettings = await client.GetServerConfigAsync(request.ProjectId, request.Zone, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServerConfig responseCancellationToken = await client.GetServerConfigAsync(request.ProjectId, request.Zone, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListNodePoolsRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            ListNodePoolsRequest request = new ListNodePoolsRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Parent = "parent7858e4d0",
            };
            ListNodePoolsResponse expectedResponse = new ListNodePoolsResponse
            {
                NodePools = { new NodePool(), },
            };
            mockGrpcClient.Setup(x => x.ListNodePools(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ListNodePoolsResponse response = client.ListNodePools(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListNodePoolsRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            ListNodePoolsRequest request = new ListNodePoolsRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Parent = "parent7858e4d0",
            };
            ListNodePoolsResponse expectedResponse = new ListNodePoolsResponse
            {
                NodePools = { new NodePool(), },
            };
            mockGrpcClient.Setup(x => x.ListNodePoolsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListNodePoolsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ListNodePoolsResponse responseCallSettings = await client.ListNodePoolsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListNodePoolsResponse responseCancellationToken = await client.ListNodePoolsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListNodePools()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            ListNodePoolsRequest request = new ListNodePoolsRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
            };
            ListNodePoolsResponse expectedResponse = new ListNodePoolsResponse
            {
                NodePools = { new NodePool(), },
            };
            mockGrpcClient.Setup(x => x.ListNodePools(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ListNodePoolsResponse response = client.ListNodePools(request.ProjectId, request.Zone, request.ClusterId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListNodePoolsAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            ListNodePoolsRequest request = new ListNodePoolsRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
            };
            ListNodePoolsResponse expectedResponse = new ListNodePoolsResponse
            {
                NodePools = { new NodePool(), },
            };
            mockGrpcClient.Setup(x => x.ListNodePoolsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListNodePoolsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ListNodePoolsResponse responseCallSettings = await client.ListNodePoolsAsync(request.ProjectId, request.Zone, request.ClusterId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListNodePoolsResponse responseCancellationToken = await client.ListNodePoolsAsync(request.ProjectId, request.Zone, request.ClusterId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNodePoolRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            GetNodePoolRequest request = new GetNodePoolRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
                Name = "name1c9368b0",
            };
            NodePool expectedResponse = new NodePool
            {
                Name = "name1c9368b0",
                Config = new NodeConfig(),
                InitialNodeCount = -1915714087,
                Autoscaling = new NodePoolAutoscaling(),
                Management = new NodeManagement(),
                MaxPodsConstraint = new MaxPodsConstraint(),
                PodIpv4CidrSize = -551223211,
                SelfLink = "self_link7e87f12d",
                Version = "version102ff72a",
                InstanceGroupUrls =
                {
                    "instance_group_urlsbc2a92b9",
                },
                Status = NodePool.Types.Status.RunningWithError,
                StatusMessage = "status_message2c618f86",
                Conditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.GetNodePool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            NodePool response = client.GetNodePool(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNodePoolRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            GetNodePoolRequest request = new GetNodePoolRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
                Name = "name1c9368b0",
            };
            NodePool expectedResponse = new NodePool
            {
                Name = "name1c9368b0",
                Config = new NodeConfig(),
                InitialNodeCount = -1915714087,
                Autoscaling = new NodePoolAutoscaling(),
                Management = new NodeManagement(),
                MaxPodsConstraint = new MaxPodsConstraint(),
                PodIpv4CidrSize = -551223211,
                SelfLink = "self_link7e87f12d",
                Version = "version102ff72a",
                InstanceGroupUrls =
                {
                    "instance_group_urlsbc2a92b9",
                },
                Status = NodePool.Types.Status.RunningWithError,
                StatusMessage = "status_message2c618f86",
                Conditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.GetNodePoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NodePool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            NodePool responseCallSettings = await client.GetNodePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NodePool responseCancellationToken = await client.GetNodePoolAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNodePool()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            GetNodePoolRequest request = new GetNodePoolRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
            };
            NodePool expectedResponse = new NodePool
            {
                Name = "name1c9368b0",
                Config = new NodeConfig(),
                InitialNodeCount = -1915714087,
                Autoscaling = new NodePoolAutoscaling(),
                Management = new NodeManagement(),
                MaxPodsConstraint = new MaxPodsConstraint(),
                PodIpv4CidrSize = -551223211,
                SelfLink = "self_link7e87f12d",
                Version = "version102ff72a",
                InstanceGroupUrls =
                {
                    "instance_group_urlsbc2a92b9",
                },
                Status = NodePool.Types.Status.RunningWithError,
                StatusMessage = "status_message2c618f86",
                Conditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.GetNodePool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            NodePool response = client.GetNodePool(request.ProjectId, request.Zone, request.ClusterId, request.NodePoolId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNodePoolAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            GetNodePoolRequest request = new GetNodePoolRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
            };
            NodePool expectedResponse = new NodePool
            {
                Name = "name1c9368b0",
                Config = new NodeConfig(),
                InitialNodeCount = -1915714087,
                Autoscaling = new NodePoolAutoscaling(),
                Management = new NodeManagement(),
                MaxPodsConstraint = new MaxPodsConstraint(),
                PodIpv4CidrSize = -551223211,
                SelfLink = "self_link7e87f12d",
                Version = "version102ff72a",
                InstanceGroupUrls =
                {
                    "instance_group_urlsbc2a92b9",
                },
                Status = NodePool.Types.Status.RunningWithError,
                StatusMessage = "status_message2c618f86",
                Conditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.GetNodePoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NodePool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            NodePool responseCallSettings = await client.GetNodePoolAsync(request.ProjectId, request.Zone, request.ClusterId, request.NodePoolId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NodePool responseCancellationToken = await client.GetNodePoolAsync(request.ProjectId, request.Zone, request.ClusterId, request.NodePoolId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateNodePoolRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            CreateNodePoolRequest request = new CreateNodePoolRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePool = new NodePool(),
                Parent = "parent7858e4d0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateNodePool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.CreateNodePool(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNodePoolRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            CreateNodePoolRequest request = new CreateNodePoolRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePool = new NodePool(),
                Parent = "parent7858e4d0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateNodePoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.CreateNodePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.CreateNodePoolAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateNodePool()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            CreateNodePoolRequest request = new CreateNodePoolRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePool = new NodePool(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateNodePool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.CreateNodePool(request.ProjectId, request.Zone, request.ClusterId, request.NodePool);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNodePoolAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            CreateNodePoolRequest request = new CreateNodePoolRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePool = new NodePool(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateNodePoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.CreateNodePoolAsync(request.ProjectId, request.Zone, request.ClusterId, request.NodePool, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.CreateNodePoolAsync(request.ProjectId, request.Zone, request.ClusterId, request.NodePool, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteNodePoolRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            DeleteNodePoolRequest request = new DeleteNodePoolRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.DeleteNodePool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DeleteNodePool(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteNodePoolRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            DeleteNodePoolRequest request = new DeleteNodePoolRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.DeleteNodePoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteNodePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteNodePoolAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteNodePool()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            DeleteNodePoolRequest request = new DeleteNodePoolRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.DeleteNodePool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DeleteNodePool(request.ProjectId, request.Zone, request.ClusterId, request.NodePoolId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteNodePoolAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            DeleteNodePoolRequest request = new DeleteNodePoolRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.DeleteNodePoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteNodePoolAsync(request.ProjectId, request.Zone, request.ClusterId, request.NodePoolId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteNodePoolAsync(request.ProjectId, request.Zone, request.ClusterId, request.NodePoolId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RollbackNodePoolUpgradeRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            RollbackNodePoolUpgradeRequest request = new RollbackNodePoolUpgradeRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.RollbackNodePoolUpgrade(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RollbackNodePoolUpgrade(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RollbackNodePoolUpgradeRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            RollbackNodePoolUpgradeRequest request = new RollbackNodePoolUpgradeRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.RollbackNodePoolUpgradeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RollbackNodePoolUpgradeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RollbackNodePoolUpgradeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RollbackNodePoolUpgrade()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            RollbackNodePoolUpgradeRequest request = new RollbackNodePoolUpgradeRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.RollbackNodePoolUpgrade(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RollbackNodePoolUpgrade(request.ProjectId, request.Zone, request.ClusterId, request.NodePoolId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RollbackNodePoolUpgradeAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            RollbackNodePoolUpgradeRequest request = new RollbackNodePoolUpgradeRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.RollbackNodePoolUpgradeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RollbackNodePoolUpgradeAsync(request.ProjectId, request.Zone, request.ClusterId, request.NodePoolId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RollbackNodePoolUpgradeAsync(request.ProjectId, request.Zone, request.ClusterId, request.NodePoolId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetNodePoolManagementRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetNodePoolManagementRequest request = new SetNodePoolManagementRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
                Management = new NodeManagement(),
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetNodePoolManagement(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetNodePoolManagement(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetNodePoolManagementRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetNodePoolManagementRequest request = new SetNodePoolManagementRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
                Management = new NodeManagement(),
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetNodePoolManagementAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetNodePoolManagementAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetNodePoolManagementAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetLabelsRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetLabelsRequest request = new SetLabelsRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                ResourceLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LabelFingerprint = "label_fingerprint06ccff3a",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLabels(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetLabelsRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetLabelsRequest request = new SetLabelsRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                ResourceLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LabelFingerprint = "label_fingerprint06ccff3a",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetLabelsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetLegacyAbacRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetLegacyAbacRequest request = new SetLegacyAbacRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Enabled = true,
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetLegacyAbac(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLegacyAbac(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetLegacyAbacRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetLegacyAbacRequest request = new SetLegacyAbacRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Enabled = true,
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetLegacyAbacAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetLegacyAbacAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetLegacyAbacAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetLegacyAbac()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetLegacyAbacRequest request = new SetLegacyAbacRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Enabled = true,
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetLegacyAbac(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLegacyAbac(request.ProjectId, request.Zone, request.ClusterId, request.Enabled);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetLegacyAbacAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetLegacyAbacRequest request = new SetLegacyAbacRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Enabled = true,
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetLegacyAbacAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetLegacyAbacAsync(request.ProjectId, request.Zone, request.ClusterId, request.Enabled, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetLegacyAbacAsync(request.ProjectId, request.Zone, request.ClusterId, request.Enabled, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StartIPRotationRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            StartIPRotationRequest request = new StartIPRotationRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Name = "name1c9368b0",
                RotateCredentials = false,
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.StartIPRotation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.StartIPRotation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartIPRotationRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            StartIPRotationRequest request = new StartIPRotationRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Name = "name1c9368b0",
                RotateCredentials = false,
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.StartIPRotationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.StartIPRotationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.StartIPRotationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StartIPRotation()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            StartIPRotationRequest request = new StartIPRotationRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.StartIPRotation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.StartIPRotation(request.ProjectId, request.Zone, request.ClusterId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartIPRotationAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            StartIPRotationRequest request = new StartIPRotationRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.StartIPRotationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.StartIPRotationAsync(request.ProjectId, request.Zone, request.ClusterId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.StartIPRotationAsync(request.ProjectId, request.Zone, request.ClusterId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CompleteIPRotationRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            CompleteIPRotationRequest request = new CompleteIPRotationRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.CompleteIPRotation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.CompleteIPRotation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CompleteIPRotationRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            CompleteIPRotationRequest request = new CompleteIPRotationRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.CompleteIPRotationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.CompleteIPRotationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.CompleteIPRotationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CompleteIPRotation()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            CompleteIPRotationRequest request = new CompleteIPRotationRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.CompleteIPRotation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.CompleteIPRotation(request.ProjectId, request.Zone, request.ClusterId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CompleteIPRotationAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            CompleteIPRotationRequest request = new CompleteIPRotationRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.CompleteIPRotationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.CompleteIPRotationAsync(request.ProjectId, request.Zone, request.ClusterId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.CompleteIPRotationAsync(request.ProjectId, request.Zone, request.ClusterId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetNodePoolSizeRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetNodePoolSizeRequest request = new SetNodePoolSizeRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
                NodeCount = -1659500730,
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetNodePoolSize(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetNodePoolSize(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetNodePoolSizeRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetNodePoolSizeRequest request = new SetNodePoolSizeRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NodePoolId = "node_pool_id3121d6bc",
                NodeCount = -1659500730,
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetNodePoolSizeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetNodePoolSizeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetNodePoolSizeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetNetworkPolicyRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetNetworkPolicyRequest request = new SetNetworkPolicyRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NetworkPolicy = new NetworkPolicy(),
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetNetworkPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetNetworkPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetNetworkPolicyRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetNetworkPolicyRequest request = new SetNetworkPolicyRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NetworkPolicy = new NetworkPolicy(),
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetNetworkPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetNetworkPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetNetworkPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetNetworkPolicy()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetNetworkPolicyRequest request = new SetNetworkPolicyRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NetworkPolicy = new NetworkPolicy(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetNetworkPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetNetworkPolicy(request.ProjectId, request.Zone, request.ClusterId, request.NetworkPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetNetworkPolicyAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetNetworkPolicyRequest request = new SetNetworkPolicyRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                NetworkPolicy = new NetworkPolicy(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetNetworkPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetNetworkPolicyAsync(request.ProjectId, request.Zone, request.ClusterId, request.NetworkPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetNetworkPolicyAsync(request.ProjectId, request.Zone, request.ClusterId, request.NetworkPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetMaintenancePolicyRequestObject()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetMaintenancePolicyRequest request = new SetMaintenancePolicyRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                MaintenancePolicy = new MaintenancePolicy(),
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetMaintenancePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetMaintenancePolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetMaintenancePolicyRequestObjectAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetMaintenancePolicyRequest request = new SetMaintenancePolicyRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                MaintenancePolicy = new MaintenancePolicy(),
                Name = "name1c9368b0",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetMaintenancePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetMaintenancePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetMaintenancePolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetMaintenancePolicy()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetMaintenancePolicyRequest request = new SetMaintenancePolicyRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                MaintenancePolicy = new MaintenancePolicy(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetMaintenancePolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetMaintenancePolicy(request.ProjectId, request.Zone, request.ClusterId, request.MaintenancePolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetMaintenancePolicyAsync()
        {
            moq::Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new moq::Mock<ClusterManager.ClusterManagerClient>(moq::MockBehavior.Strict);
            SetMaintenancePolicyRequest request = new SetMaintenancePolicyRequest
            {
                ProjectId = "project_id43ad98b0",
                Zone = "zone255f4ea8",
                ClusterId = "cluster_id121c7ba9",
                MaintenancePolicy = new MaintenancePolicy(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                OperationType = Operation.Types.Type.UpdateCluster,
                Status = Operation.Types.Status.Aborting,
                StatusMessage = "status_message2c618f86",
                SelfLink = "self_link7e87f12d",
                TargetLink = "target_link9b435dc0",
                Detail = "detailb7a61d95",
                Location = "locatione09d18d5",
                StartTime = "start_timebd8dd9c4",
                EndTime = "end_time89285d30",
                ClusterConditions =
                {
                    new StatusCondition(),
                },
                NodepoolConditions =
                {
                    new StatusCondition(),
                },
            };
            mockGrpcClient.Setup(x => x.SetMaintenancePolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetMaintenancePolicyAsync(request.ProjectId, request.Zone, request.ClusterId, request.MaintenancePolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetMaintenancePolicyAsync(request.ProjectId, request.Zone, request.ClusterId, request.MaintenancePolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
