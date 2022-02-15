// Copyright 2022 Google LLC
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

using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dataproc.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedClusterControllerClientTest
    {
        [xunit::FactAttribute]
        public void GetClusterRequestObject()
        {
            moq::Mock<ClusterController.ClusterControllerClient> mockGrpcClient = new moq::Mock<ClusterController.ClusterControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                ClusterName = "cluster_name88432a5e",
                Region = "regionedb20d96",
            };
            Cluster expectedResponse = new Cluster
            {
                ProjectId = "project_id43ad98b0",
                ClusterName = "cluster_name88432a5e",
                Config = new ClusterConfig(),
                Status = new ClusterStatus(),
                ClusterUuid = "cluster_uuid256bc378",
                StatusHistory =
                {
                    new ClusterStatus(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metrics = new ClusterMetrics(),
            };
            mockGrpcClient.Setup(x => x.GetCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterControllerClient client = new ClusterControllerClientImpl(mockGrpcClient.Object, null);
            Cluster response = client.GetCluster(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClusterRequestObjectAsync()
        {
            moq::Mock<ClusterController.ClusterControllerClient> mockGrpcClient = new moq::Mock<ClusterController.ClusterControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                ClusterName = "cluster_name88432a5e",
                Region = "regionedb20d96",
            };
            Cluster expectedResponse = new Cluster
            {
                ProjectId = "project_id43ad98b0",
                ClusterName = "cluster_name88432a5e",
                Config = new ClusterConfig(),
                Status = new ClusterStatus(),
                ClusterUuid = "cluster_uuid256bc378",
                StatusHistory =
                {
                    new ClusterStatus(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metrics = new ClusterMetrics(),
            };
            mockGrpcClient.Setup(x => x.GetClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Cluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterControllerClient client = new ClusterControllerClientImpl(mockGrpcClient.Object, null);
            Cluster responseCallSettings = await client.GetClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Cluster responseCancellationToken = await client.GetClusterAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCluster()
        {
            moq::Mock<ClusterController.ClusterControllerClient> mockGrpcClient = new moq::Mock<ClusterController.ClusterControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                ClusterName = "cluster_name88432a5e",
                Region = "regionedb20d96",
            };
            Cluster expectedResponse = new Cluster
            {
                ProjectId = "project_id43ad98b0",
                ClusterName = "cluster_name88432a5e",
                Config = new ClusterConfig(),
                Status = new ClusterStatus(),
                ClusterUuid = "cluster_uuid256bc378",
                StatusHistory =
                {
                    new ClusterStatus(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metrics = new ClusterMetrics(),
            };
            mockGrpcClient.Setup(x => x.GetCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterControllerClient client = new ClusterControllerClientImpl(mockGrpcClient.Object, null);
            Cluster response = client.GetCluster(request.ProjectId, request.Region, request.ClusterName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClusterAsync()
        {
            moq::Mock<ClusterController.ClusterControllerClient> mockGrpcClient = new moq::Mock<ClusterController.ClusterControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                ClusterName = "cluster_name88432a5e",
                Region = "regionedb20d96",
            };
            Cluster expectedResponse = new Cluster
            {
                ProjectId = "project_id43ad98b0",
                ClusterName = "cluster_name88432a5e",
                Config = new ClusterConfig(),
                Status = new ClusterStatus(),
                ClusterUuid = "cluster_uuid256bc378",
                StatusHistory =
                {
                    new ClusterStatus(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metrics = new ClusterMetrics(),
            };
            mockGrpcClient.Setup(x => x.GetClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Cluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterControllerClient client = new ClusterControllerClientImpl(mockGrpcClient.Object, null);
            Cluster responseCallSettings = await client.GetClusterAsync(request.ProjectId, request.Region, request.ClusterName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Cluster responseCancellationToken = await client.GetClusterAsync(request.ProjectId, request.Region, request.ClusterName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
