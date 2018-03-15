// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Container.V1.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedClusterManagerClientTest
    {
        [Fact]
        public void ListClustersTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            ListClustersResponse expectedResponse = new ListClustersResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ListClusters(It.IsAny<ListClustersRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            ListClustersResponse response = client.ListClusters(projectId, zone);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetClusterTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Cluster expectedResponse = new Cluster
            {
                Name = "name3373707",
                Description = "description-1724546052",
                InitialNodeCount = 1682564205,
                LoggingService = "loggingService-1700501035",
                MonitoringService = "monitoringService1469270462",
                Network = "network1843485230",
                ClusterIpv4Cidr = "clusterIpv4Cidr-141875831",
                Subnetwork = "subnetwork-1302785042",
                EnableKubernetesAlpha = false,
                LabelFingerprint = "labelFingerprint714995737",
                SelfLink = "selfLink-1691268851",
                Zone = "zone2-696322977",
                Endpoint = "endpoint1741102485",
                InitialClusterVersion = "initialClusterVersion-276373352",
                CurrentMasterVersion = "currentMasterVersion-920953983",
                CurrentNodeVersion = "currentNodeVersion-407476063",
                CreateTime = "createTime-493574096",
                StatusMessage = "statusMessage-239442758",
                NodeIpv4CidrSize = 1181176815,
                ServicesIpv4Cidr = "servicesIpv4Cidr1966438125",
                CurrentNodeCount = 178977560,
                ExpireTime = "expireTime-96179731",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetCluster(It.IsAny<GetClusterRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            Cluster response = client.GetCluster(projectId, zone, clusterId);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateClusterTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CreateCluster(It.IsAny<CreateClusterRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            Cluster cluster = new Cluster();
            Operation response = client.CreateCluster(projectId, zone, cluster);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateClusterTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.UpdateCluster(It.IsAny<UpdateClusterRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            ClusterUpdate update = new ClusterUpdate();
            Operation response = client.UpdateCluster(projectId, zone, clusterId, update);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetLoggingServiceTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.SetLoggingService(It.IsAny<SetLoggingServiceRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            string loggingService = "loggingService-1700501035";
            Operation response = client.SetLoggingService(projectId, zone, clusterId, loggingService);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetMonitoringServiceTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.SetMonitoringService(It.IsAny<SetMonitoringServiceRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            string monitoringService = "monitoringService1469270462";
            Operation response = client.SetMonitoringService(projectId, zone, clusterId, monitoringService);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetAddonsConfigTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.SetAddonsConfig(It.IsAny<SetAddonsConfigRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            AddonsConfig addonsConfig = new AddonsConfig();
            Operation response = client.SetAddonsConfig(projectId, zone, clusterId, addonsConfig);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetLocationsTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.SetLocations(It.IsAny<SetLocationsRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            IEnumerable<string> locations = new List<string>();
            Operation response = client.SetLocations(projectId, zone, clusterId, locations);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateMasterTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.UpdateMaster(It.IsAny<UpdateMasterRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            string masterVersion = "masterVersion-2139460613";
            Operation response = client.UpdateMaster(projectId, zone, clusterId, masterVersion);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteClusterTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteCluster(It.IsAny<DeleteClusterRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            Operation response = client.DeleteCluster(projectId, zone, clusterId);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListOperationsTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            ListOperationsResponse expectedResponse = new ListOperationsResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ListOperations(It.IsAny<ListOperationsRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            ListOperationsResponse response = client.ListOperations(projectId, zone);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetOperationTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetOperation(It.IsAny<GetOperationRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string operationId = "operationId-274116877";
            Operation response = client.GetOperation(projectId, zone, operationId);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CancelOperationTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CancelOperation(It.IsAny<CancelOperationRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string operationId = "operationId-274116877";
            client.CancelOperation(projectId, zone, operationId);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetServerConfigTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            ServerConfig expectedResponse = new ServerConfig
            {
                DefaultClusterVersion = "defaultClusterVersion111003029",
                DefaultImageType = "defaultImageType-918225828",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetServerConfig(It.IsAny<GetServerConfigRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            ServerConfig response = client.GetServerConfig(projectId, zone);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListNodePoolsTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            ListNodePoolsResponse expectedResponse = new ListNodePoolsResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ListNodePools(It.IsAny<ListNodePoolsRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            ListNodePoolsResponse response = client.ListNodePools(projectId, zone, clusterId);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetNodePoolTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            NodePool expectedResponse = new NodePool
            {
                Name = "name3373707",
                InitialNodeCount = 1682564205,
                SelfLink = "selfLink-1691268851",
                Version = "version351608024",
                StatusMessage = "statusMessage-239442758",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetNodePool(It.IsAny<GetNodePoolRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            string nodePoolId = "nodePoolId1043384033";
            NodePool response = client.GetNodePool(projectId, zone, clusterId, nodePoolId);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateNodePoolTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CreateNodePool(It.IsAny<CreateNodePoolRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            NodePool nodePool = new NodePool();
            Operation response = client.CreateNodePool(projectId, zone, clusterId, nodePool);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteNodePoolTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteNodePool(It.IsAny<DeleteNodePoolRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            string nodePoolId = "nodePoolId1043384033";
            Operation response = client.DeleteNodePool(projectId, zone, clusterId, nodePoolId);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RollbackNodePoolUpgradeTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.RollbackNodePoolUpgrade(It.IsAny<RollbackNodePoolUpgradeRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            string nodePoolId = "nodePoolId1043384033";
            Operation response = client.RollbackNodePoolUpgrade(projectId, zone, clusterId, nodePoolId);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetLegacyAbacTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.SetLegacyAbac(It.IsAny<SetLegacyAbacRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            bool enabled = false;
            Operation response = client.SetLegacyAbac(projectId, zone, clusterId, enabled);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void StartIPRotationTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.StartIPRotation(It.IsAny<StartIPRotationRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            Operation response = client.StartIPRotation(projectId, zone, clusterId);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CompleteIPRotationTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CompleteIPRotation(It.IsAny<CompleteIPRotationRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            Operation response = client.CompleteIPRotation(projectId, zone, clusterId);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetNetworkPolicyTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.SetNetworkPolicy(It.IsAny<SetNetworkPolicyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            NetworkPolicy networkPolicy = new NetworkPolicy();
            Operation response = client.SetNetworkPolicy(projectId, zone, clusterId, networkPolicy);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetMaintenancePolicyTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient> { DefaultValue = DefaultValue.Mock };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.SetMaintenancePolicy(It.IsAny<SetMaintenancePolicyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            MaintenancePolicy maintenancePolicy = new MaintenancePolicy();
            Operation response = client.SetMaintenancePolicy(projectId, zone, clusterId, maintenancePolicy);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
