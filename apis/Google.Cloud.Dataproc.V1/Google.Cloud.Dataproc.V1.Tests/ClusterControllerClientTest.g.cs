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

namespace Google.Cloud.Dataproc.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Dataproc.V1;
    using Google.LongRunning;
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

    /// <summary>Generated unit tests</summary>
    public class GeneratedClusterControllerClientTest
    {
        [Fact]
        public void GetCluster()
        {
            Mock<ClusterController.ClusterControllerClient> mockGrpcClient = new Mock<ClusterController.ClusterControllerClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetClusterRequest expectedRequest = new GetClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                ClusterName = "clusterName-1018081872",
            };
            Cluster expectedResponse = new Cluster
            {
                ProjectId = "projectId2939242356",
                ClusterName = "clusterName2875867491",
                ClusterUuid = "clusterUuid-1017854240",
            };
            mockGrpcClient.Setup(x => x.GetCluster(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterControllerClient client = new ClusterControllerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string region = "region-934795532";
            string clusterName = "clusterName-1018081872";
            Cluster response = client.GetCluster(projectId, region, clusterName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetClusterAsync()
        {
            Mock<ClusterController.ClusterControllerClient> mockGrpcClient = new Mock<ClusterController.ClusterControllerClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetClusterRequest expectedRequest = new GetClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                ClusterName = "clusterName-1018081872",
            };
            Cluster expectedResponse = new Cluster
            {
                ProjectId = "projectId2939242356",
                ClusterName = "clusterName2875867491",
                ClusterUuid = "clusterUuid-1017854240",
            };
            mockGrpcClient.Setup(x => x.GetClusterAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Cluster>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterControllerClient client = new ClusterControllerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string region = "region-934795532";
            string clusterName = "clusterName-1018081872";
            Cluster response = await client.GetClusterAsync(projectId, region, clusterName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetCluster2()
        {
            Mock<ClusterController.ClusterControllerClient> mockGrpcClient = new Mock<ClusterController.ClusterControllerClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                ClusterName = "clusterName-1018081872",
            };
            Cluster expectedResponse = new Cluster
            {
                ProjectId = "projectId2939242356",
                ClusterName = "clusterName2875867491",
                ClusterUuid = "clusterUuid-1017854240",
            };
            mockGrpcClient.Setup(x => x.GetCluster(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterControllerClient client = new ClusterControllerClientImpl(mockGrpcClient.Object, null);
            Cluster response = client.GetCluster(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetClusterAsync2()
        {
            Mock<ClusterController.ClusterControllerClient> mockGrpcClient = new Mock<ClusterController.ClusterControllerClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                ClusterName = "clusterName-1018081872",
            };
            Cluster expectedResponse = new Cluster
            {
                ProjectId = "projectId2939242356",
                ClusterName = "clusterName2875867491",
                ClusterUuid = "clusterUuid-1017854240",
            };
            mockGrpcClient.Setup(x => x.GetClusterAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Cluster>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterControllerClient client = new ClusterControllerClientImpl(mockGrpcClient.Object, null);
            Cluster response = await client.GetClusterAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
