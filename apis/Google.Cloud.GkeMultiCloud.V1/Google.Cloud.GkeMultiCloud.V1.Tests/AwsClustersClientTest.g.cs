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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.GkeMultiCloud.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAwsClustersClientTest
    {
        [xunit::FactAttribute]
        public void GetAwsClusterRequestObject()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAwsClusterRequest request = new GetAwsClusterRequest
            {
                AwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
            };
            AwsCluster expectedResponse = new AwsCluster
            {
                AwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
                Description = "description2cf9da67",
                Networking = new AwsClusterNetworking(),
                AwsRegion = "aws_region7ffec06c",
                ControlPlane = new AwsControlPlane(),
                State = AwsCluster.Types.State.Degraded,
                Endpoint = "endpoint1bd965ad",
                Uid = "uida2d37198",
                Reconciling = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Authorization = new AwsAuthorization(),
                WorkloadIdentityConfig = new WorkloadIdentityConfig(),
                ClusterCaCertificate = "cluster_ca_certificate21fa2421",
                Fleet = new Fleet(),
                LoggingConfig = new LoggingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAwsCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            AwsCluster response = client.GetAwsCluster(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAwsClusterRequestObjectAsync()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAwsClusterRequest request = new GetAwsClusterRequest
            {
                AwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
            };
            AwsCluster expectedResponse = new AwsCluster
            {
                AwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
                Description = "description2cf9da67",
                Networking = new AwsClusterNetworking(),
                AwsRegion = "aws_region7ffec06c",
                ControlPlane = new AwsControlPlane(),
                State = AwsCluster.Types.State.Degraded,
                Endpoint = "endpoint1bd965ad",
                Uid = "uida2d37198",
                Reconciling = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Authorization = new AwsAuthorization(),
                WorkloadIdentityConfig = new WorkloadIdentityConfig(),
                ClusterCaCertificate = "cluster_ca_certificate21fa2421",
                Fleet = new Fleet(),
                LoggingConfig = new LoggingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAwsClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AwsCluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            AwsCluster responseCallSettings = await client.GetAwsClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AwsCluster responseCancellationToken = await client.GetAwsClusterAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAwsCluster()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAwsClusterRequest request = new GetAwsClusterRequest
            {
                AwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
            };
            AwsCluster expectedResponse = new AwsCluster
            {
                AwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
                Description = "description2cf9da67",
                Networking = new AwsClusterNetworking(),
                AwsRegion = "aws_region7ffec06c",
                ControlPlane = new AwsControlPlane(),
                State = AwsCluster.Types.State.Degraded,
                Endpoint = "endpoint1bd965ad",
                Uid = "uida2d37198",
                Reconciling = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Authorization = new AwsAuthorization(),
                WorkloadIdentityConfig = new WorkloadIdentityConfig(),
                ClusterCaCertificate = "cluster_ca_certificate21fa2421",
                Fleet = new Fleet(),
                LoggingConfig = new LoggingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAwsCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            AwsCluster response = client.GetAwsCluster(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAwsClusterAsync()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAwsClusterRequest request = new GetAwsClusterRequest
            {
                AwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
            };
            AwsCluster expectedResponse = new AwsCluster
            {
                AwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
                Description = "description2cf9da67",
                Networking = new AwsClusterNetworking(),
                AwsRegion = "aws_region7ffec06c",
                ControlPlane = new AwsControlPlane(),
                State = AwsCluster.Types.State.Degraded,
                Endpoint = "endpoint1bd965ad",
                Uid = "uida2d37198",
                Reconciling = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Authorization = new AwsAuthorization(),
                WorkloadIdentityConfig = new WorkloadIdentityConfig(),
                ClusterCaCertificate = "cluster_ca_certificate21fa2421",
                Fleet = new Fleet(),
                LoggingConfig = new LoggingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAwsClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AwsCluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            AwsCluster responseCallSettings = await client.GetAwsClusterAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AwsCluster responseCancellationToken = await client.GetAwsClusterAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAwsClusterResourceNames()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAwsClusterRequest request = new GetAwsClusterRequest
            {
                AwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
            };
            AwsCluster expectedResponse = new AwsCluster
            {
                AwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
                Description = "description2cf9da67",
                Networking = new AwsClusterNetworking(),
                AwsRegion = "aws_region7ffec06c",
                ControlPlane = new AwsControlPlane(),
                State = AwsCluster.Types.State.Degraded,
                Endpoint = "endpoint1bd965ad",
                Uid = "uida2d37198",
                Reconciling = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Authorization = new AwsAuthorization(),
                WorkloadIdentityConfig = new WorkloadIdentityConfig(),
                ClusterCaCertificate = "cluster_ca_certificate21fa2421",
                Fleet = new Fleet(),
                LoggingConfig = new LoggingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAwsCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            AwsCluster response = client.GetAwsCluster(request.AwsClusterName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAwsClusterResourceNamesAsync()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAwsClusterRequest request = new GetAwsClusterRequest
            {
                AwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
            };
            AwsCluster expectedResponse = new AwsCluster
            {
                AwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
                Description = "description2cf9da67",
                Networking = new AwsClusterNetworking(),
                AwsRegion = "aws_region7ffec06c",
                ControlPlane = new AwsControlPlane(),
                State = AwsCluster.Types.State.Degraded,
                Endpoint = "endpoint1bd965ad",
                Uid = "uida2d37198",
                Reconciling = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Authorization = new AwsAuthorization(),
                WorkloadIdentityConfig = new WorkloadIdentityConfig(),
                ClusterCaCertificate = "cluster_ca_certificate21fa2421",
                Fleet = new Fleet(),
                LoggingConfig = new LoggingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAwsClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AwsCluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            AwsCluster responseCallSettings = await client.GetAwsClusterAsync(request.AwsClusterName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AwsCluster responseCancellationToken = await client.GetAwsClusterAsync(request.AwsClusterName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateAwsAccessTokenRequestObject()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateAwsAccessTokenRequest request = new GenerateAwsAccessTokenRequest
            {
                AwsClusterAsAwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
            };
            GenerateAwsAccessTokenResponse expectedResponse = new GenerateAwsAccessTokenResponse
            {
                AccessToken = "access_token85826cd8",
                ExpirationTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GenerateAwsAccessToken(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            GenerateAwsAccessTokenResponse response = client.GenerateAwsAccessToken(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateAwsAccessTokenRequestObjectAsync()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateAwsAccessTokenRequest request = new GenerateAwsAccessTokenRequest
            {
                AwsClusterAsAwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
            };
            GenerateAwsAccessTokenResponse expectedResponse = new GenerateAwsAccessTokenResponse
            {
                AccessToken = "access_token85826cd8",
                ExpirationTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GenerateAwsAccessTokenAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateAwsAccessTokenResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            GenerateAwsAccessTokenResponse responseCallSettings = await client.GenerateAwsAccessTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateAwsAccessTokenResponse responseCancellationToken = await client.GenerateAwsAccessTokenAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAwsNodePoolRequestObject()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAwsNodePoolRequest request = new GetAwsNodePoolRequest
            {
                AwsNodePoolName = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]"),
            };
            AwsNodePool expectedResponse = new AwsNodePool
            {
                AwsNodePoolName = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]"),
                Version = "version102ff72a",
                SubnetId = "subnet_idcb6f86fe",
                State = AwsNodePool.Types.State.Degraded,
                Uid = "uida2d37198",
                Reconciling = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Autoscaling = new AwsNodePoolAutoscaling(),
                MaxPodsConstraint = new MaxPodsConstraint(),
                Config = new AwsNodeConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAwsNodePool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            AwsNodePool response = client.GetAwsNodePool(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAwsNodePoolRequestObjectAsync()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAwsNodePoolRequest request = new GetAwsNodePoolRequest
            {
                AwsNodePoolName = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]"),
            };
            AwsNodePool expectedResponse = new AwsNodePool
            {
                AwsNodePoolName = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]"),
                Version = "version102ff72a",
                SubnetId = "subnet_idcb6f86fe",
                State = AwsNodePool.Types.State.Degraded,
                Uid = "uida2d37198",
                Reconciling = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Autoscaling = new AwsNodePoolAutoscaling(),
                MaxPodsConstraint = new MaxPodsConstraint(),
                Config = new AwsNodeConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAwsNodePoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AwsNodePool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            AwsNodePool responseCallSettings = await client.GetAwsNodePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AwsNodePool responseCancellationToken = await client.GetAwsNodePoolAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAwsNodePool()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAwsNodePoolRequest request = new GetAwsNodePoolRequest
            {
                AwsNodePoolName = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]"),
            };
            AwsNodePool expectedResponse = new AwsNodePool
            {
                AwsNodePoolName = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]"),
                Version = "version102ff72a",
                SubnetId = "subnet_idcb6f86fe",
                State = AwsNodePool.Types.State.Degraded,
                Uid = "uida2d37198",
                Reconciling = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Autoscaling = new AwsNodePoolAutoscaling(),
                MaxPodsConstraint = new MaxPodsConstraint(),
                Config = new AwsNodeConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAwsNodePool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            AwsNodePool response = client.GetAwsNodePool(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAwsNodePoolAsync()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAwsNodePoolRequest request = new GetAwsNodePoolRequest
            {
                AwsNodePoolName = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]"),
            };
            AwsNodePool expectedResponse = new AwsNodePool
            {
                AwsNodePoolName = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]"),
                Version = "version102ff72a",
                SubnetId = "subnet_idcb6f86fe",
                State = AwsNodePool.Types.State.Degraded,
                Uid = "uida2d37198",
                Reconciling = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Autoscaling = new AwsNodePoolAutoscaling(),
                MaxPodsConstraint = new MaxPodsConstraint(),
                Config = new AwsNodeConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAwsNodePoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AwsNodePool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            AwsNodePool responseCallSettings = await client.GetAwsNodePoolAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AwsNodePool responseCancellationToken = await client.GetAwsNodePoolAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAwsNodePoolResourceNames()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAwsNodePoolRequest request = new GetAwsNodePoolRequest
            {
                AwsNodePoolName = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]"),
            };
            AwsNodePool expectedResponse = new AwsNodePool
            {
                AwsNodePoolName = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]"),
                Version = "version102ff72a",
                SubnetId = "subnet_idcb6f86fe",
                State = AwsNodePool.Types.State.Degraded,
                Uid = "uida2d37198",
                Reconciling = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Autoscaling = new AwsNodePoolAutoscaling(),
                MaxPodsConstraint = new MaxPodsConstraint(),
                Config = new AwsNodeConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAwsNodePool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            AwsNodePool response = client.GetAwsNodePool(request.AwsNodePoolName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAwsNodePoolResourceNamesAsync()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAwsNodePoolRequest request = new GetAwsNodePoolRequest
            {
                AwsNodePoolName = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]"),
            };
            AwsNodePool expectedResponse = new AwsNodePool
            {
                AwsNodePoolName = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]"),
                Version = "version102ff72a",
                SubnetId = "subnet_idcb6f86fe",
                State = AwsNodePool.Types.State.Degraded,
                Uid = "uida2d37198",
                Reconciling = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Autoscaling = new AwsNodePoolAutoscaling(),
                MaxPodsConstraint = new MaxPodsConstraint(),
                Config = new AwsNodeConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAwsNodePoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AwsNodePool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            AwsNodePool responseCallSettings = await client.GetAwsNodePoolAsync(request.AwsNodePoolName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AwsNodePool responseCancellationToken = await client.GetAwsNodePoolAsync(request.AwsNodePoolName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAwsServerConfigRequestObject()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAwsServerConfigRequest request = new GetAwsServerConfigRequest
            {
                AwsServerConfigName = AwsServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            AwsServerConfig expectedResponse = new AwsServerConfig
            {
                AwsServerConfigName = AwsServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidVersions =
                {
                    new AwsK8sVersionInfo(),
                },
                SupportedAwsRegions =
                {
                    "supported_aws_regionse3b61192",
                },
            };
            mockGrpcClient.Setup(x => x.GetAwsServerConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            AwsServerConfig response = client.GetAwsServerConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAwsServerConfigRequestObjectAsync()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAwsServerConfigRequest request = new GetAwsServerConfigRequest
            {
                AwsServerConfigName = AwsServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            AwsServerConfig expectedResponse = new AwsServerConfig
            {
                AwsServerConfigName = AwsServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidVersions =
                {
                    new AwsK8sVersionInfo(),
                },
                SupportedAwsRegions =
                {
                    "supported_aws_regionse3b61192",
                },
            };
            mockGrpcClient.Setup(x => x.GetAwsServerConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AwsServerConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            AwsServerConfig responseCallSettings = await client.GetAwsServerConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AwsServerConfig responseCancellationToken = await client.GetAwsServerConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAwsServerConfig()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAwsServerConfigRequest request = new GetAwsServerConfigRequest
            {
                AwsServerConfigName = AwsServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            AwsServerConfig expectedResponse = new AwsServerConfig
            {
                AwsServerConfigName = AwsServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidVersions =
                {
                    new AwsK8sVersionInfo(),
                },
                SupportedAwsRegions =
                {
                    "supported_aws_regionse3b61192",
                },
            };
            mockGrpcClient.Setup(x => x.GetAwsServerConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            AwsServerConfig response = client.GetAwsServerConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAwsServerConfigAsync()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAwsServerConfigRequest request = new GetAwsServerConfigRequest
            {
                AwsServerConfigName = AwsServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            AwsServerConfig expectedResponse = new AwsServerConfig
            {
                AwsServerConfigName = AwsServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidVersions =
                {
                    new AwsK8sVersionInfo(),
                },
                SupportedAwsRegions =
                {
                    "supported_aws_regionse3b61192",
                },
            };
            mockGrpcClient.Setup(x => x.GetAwsServerConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AwsServerConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            AwsServerConfig responseCallSettings = await client.GetAwsServerConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AwsServerConfig responseCancellationToken = await client.GetAwsServerConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAwsServerConfigResourceNames()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAwsServerConfigRequest request = new GetAwsServerConfigRequest
            {
                AwsServerConfigName = AwsServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            AwsServerConfig expectedResponse = new AwsServerConfig
            {
                AwsServerConfigName = AwsServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidVersions =
                {
                    new AwsK8sVersionInfo(),
                },
                SupportedAwsRegions =
                {
                    "supported_aws_regionse3b61192",
                },
            };
            mockGrpcClient.Setup(x => x.GetAwsServerConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            AwsServerConfig response = client.GetAwsServerConfig(request.AwsServerConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAwsServerConfigResourceNamesAsync()
        {
            moq::Mock<AwsClusters.AwsClustersClient> mockGrpcClient = new moq::Mock<AwsClusters.AwsClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAwsServerConfigRequest request = new GetAwsServerConfigRequest
            {
                AwsServerConfigName = AwsServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            AwsServerConfig expectedResponse = new AwsServerConfig
            {
                AwsServerConfigName = AwsServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidVersions =
                {
                    new AwsK8sVersionInfo(),
                },
                SupportedAwsRegions =
                {
                    "supported_aws_regionse3b61192",
                },
            };
            mockGrpcClient.Setup(x => x.GetAwsServerConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AwsServerConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AwsClustersClient client = new AwsClustersClientImpl(mockGrpcClient.Object, null, null);
            AwsServerConfig responseCallSettings = await client.GetAwsServerConfigAsync(request.AwsServerConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AwsServerConfig responseCancellationToken = await client.GetAwsServerConfigAsync(request.AwsServerConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
