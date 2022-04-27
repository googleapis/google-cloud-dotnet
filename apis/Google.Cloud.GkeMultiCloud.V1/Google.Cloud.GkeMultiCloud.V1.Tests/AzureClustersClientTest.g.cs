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
    public sealed class GeneratedAzureClustersClientTest
    {
        [xunit::FactAttribute]
        public void GetAzureClientRequestObject()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureClientRequest request = new GetAzureClientRequest
            {
                AzureClientName = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]"),
            };
            AzureClient expectedResponse = new AzureClient
            {
                AzureClientName = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]"),
                TenantId = "tenant_id14365438",
                ApplicationId = "application_ideba4c06b",
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                PemCertificate = "pem_certificate5c1b61ff",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAzureClient(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureClient response = client.GetAzureClient(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAzureClientRequestObjectAsync()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureClientRequest request = new GetAzureClientRequest
            {
                AzureClientName = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]"),
            };
            AzureClient expectedResponse = new AzureClient
            {
                AzureClientName = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]"),
                TenantId = "tenant_id14365438",
                ApplicationId = "application_ideba4c06b",
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                PemCertificate = "pem_certificate5c1b61ff",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAzureClientAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AzureClient>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureClient responseCallSettings = await client.GetAzureClientAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AzureClient responseCancellationToken = await client.GetAzureClientAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAzureClient()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureClientRequest request = new GetAzureClientRequest
            {
                AzureClientName = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]"),
            };
            AzureClient expectedResponse = new AzureClient
            {
                AzureClientName = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]"),
                TenantId = "tenant_id14365438",
                ApplicationId = "application_ideba4c06b",
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                PemCertificate = "pem_certificate5c1b61ff",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAzureClient(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureClient response = client.GetAzureClient(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAzureClientAsync()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureClientRequest request = new GetAzureClientRequest
            {
                AzureClientName = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]"),
            };
            AzureClient expectedResponse = new AzureClient
            {
                AzureClientName = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]"),
                TenantId = "tenant_id14365438",
                ApplicationId = "application_ideba4c06b",
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                PemCertificate = "pem_certificate5c1b61ff",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAzureClientAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AzureClient>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureClient responseCallSettings = await client.GetAzureClientAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AzureClient responseCancellationToken = await client.GetAzureClientAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAzureClientResourceNames()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureClientRequest request = new GetAzureClientRequest
            {
                AzureClientName = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]"),
            };
            AzureClient expectedResponse = new AzureClient
            {
                AzureClientName = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]"),
                TenantId = "tenant_id14365438",
                ApplicationId = "application_ideba4c06b",
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                PemCertificate = "pem_certificate5c1b61ff",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAzureClient(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureClient response = client.GetAzureClient(request.AzureClientName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAzureClientResourceNamesAsync()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureClientRequest request = new GetAzureClientRequest
            {
                AzureClientName = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]"),
            };
            AzureClient expectedResponse = new AzureClient
            {
                AzureClientName = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]"),
                TenantId = "tenant_id14365438",
                ApplicationId = "application_ideba4c06b",
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                PemCertificate = "pem_certificate5c1b61ff",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAzureClientAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AzureClient>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureClient responseCallSettings = await client.GetAzureClientAsync(request.AzureClientName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AzureClient responseCancellationToken = await client.GetAzureClientAsync(request.AzureClientName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAzureClusterRequestObject()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureClusterRequest request = new GetAzureClusterRequest
            {
                AzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
            };
            AzureCluster expectedResponse = new AzureCluster
            {
                AzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
                Description = "description2cf9da67",
                AzureRegion = "azure_region31cd0c8d",
                Networking = new AzureClusterNetworking(),
                ControlPlane = new AzureControlPlane(),
                Authorization = new AzureAuthorization(),
                State = AzureCluster.Types.State.Degraded,
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
                AzureClient = "azure_clientad1e381f",
                ResourceGroupId = "resource_group_iddd336ae4",
                WorkloadIdentityConfig = new WorkloadIdentityConfig(),
                ClusterCaCertificate = "cluster_ca_certificate21fa2421",
                Fleet = new Fleet(),
                ManagedResources = new AzureClusterResources(),
                LoggingConfig = new LoggingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAzureCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureCluster response = client.GetAzureCluster(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAzureClusterRequestObjectAsync()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureClusterRequest request = new GetAzureClusterRequest
            {
                AzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
            };
            AzureCluster expectedResponse = new AzureCluster
            {
                AzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
                Description = "description2cf9da67",
                AzureRegion = "azure_region31cd0c8d",
                Networking = new AzureClusterNetworking(),
                ControlPlane = new AzureControlPlane(),
                Authorization = new AzureAuthorization(),
                State = AzureCluster.Types.State.Degraded,
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
                AzureClient = "azure_clientad1e381f",
                ResourceGroupId = "resource_group_iddd336ae4",
                WorkloadIdentityConfig = new WorkloadIdentityConfig(),
                ClusterCaCertificate = "cluster_ca_certificate21fa2421",
                Fleet = new Fleet(),
                ManagedResources = new AzureClusterResources(),
                LoggingConfig = new LoggingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAzureClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AzureCluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureCluster responseCallSettings = await client.GetAzureClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AzureCluster responseCancellationToken = await client.GetAzureClusterAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAzureCluster()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureClusterRequest request = new GetAzureClusterRequest
            {
                AzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
            };
            AzureCluster expectedResponse = new AzureCluster
            {
                AzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
                Description = "description2cf9da67",
                AzureRegion = "azure_region31cd0c8d",
                Networking = new AzureClusterNetworking(),
                ControlPlane = new AzureControlPlane(),
                Authorization = new AzureAuthorization(),
                State = AzureCluster.Types.State.Degraded,
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
                AzureClient = "azure_clientad1e381f",
                ResourceGroupId = "resource_group_iddd336ae4",
                WorkloadIdentityConfig = new WorkloadIdentityConfig(),
                ClusterCaCertificate = "cluster_ca_certificate21fa2421",
                Fleet = new Fleet(),
                ManagedResources = new AzureClusterResources(),
                LoggingConfig = new LoggingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAzureCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureCluster response = client.GetAzureCluster(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAzureClusterAsync()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureClusterRequest request = new GetAzureClusterRequest
            {
                AzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
            };
            AzureCluster expectedResponse = new AzureCluster
            {
                AzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
                Description = "description2cf9da67",
                AzureRegion = "azure_region31cd0c8d",
                Networking = new AzureClusterNetworking(),
                ControlPlane = new AzureControlPlane(),
                Authorization = new AzureAuthorization(),
                State = AzureCluster.Types.State.Degraded,
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
                AzureClient = "azure_clientad1e381f",
                ResourceGroupId = "resource_group_iddd336ae4",
                WorkloadIdentityConfig = new WorkloadIdentityConfig(),
                ClusterCaCertificate = "cluster_ca_certificate21fa2421",
                Fleet = new Fleet(),
                ManagedResources = new AzureClusterResources(),
                LoggingConfig = new LoggingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAzureClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AzureCluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureCluster responseCallSettings = await client.GetAzureClusterAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AzureCluster responseCancellationToken = await client.GetAzureClusterAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAzureClusterResourceNames()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureClusterRequest request = new GetAzureClusterRequest
            {
                AzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
            };
            AzureCluster expectedResponse = new AzureCluster
            {
                AzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
                Description = "description2cf9da67",
                AzureRegion = "azure_region31cd0c8d",
                Networking = new AzureClusterNetworking(),
                ControlPlane = new AzureControlPlane(),
                Authorization = new AzureAuthorization(),
                State = AzureCluster.Types.State.Degraded,
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
                AzureClient = "azure_clientad1e381f",
                ResourceGroupId = "resource_group_iddd336ae4",
                WorkloadIdentityConfig = new WorkloadIdentityConfig(),
                ClusterCaCertificate = "cluster_ca_certificate21fa2421",
                Fleet = new Fleet(),
                ManagedResources = new AzureClusterResources(),
                LoggingConfig = new LoggingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAzureCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureCluster response = client.GetAzureCluster(request.AzureClusterName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAzureClusterResourceNamesAsync()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureClusterRequest request = new GetAzureClusterRequest
            {
                AzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
            };
            AzureCluster expectedResponse = new AzureCluster
            {
                AzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
                Description = "description2cf9da67",
                AzureRegion = "azure_region31cd0c8d",
                Networking = new AzureClusterNetworking(),
                ControlPlane = new AzureControlPlane(),
                Authorization = new AzureAuthorization(),
                State = AzureCluster.Types.State.Degraded,
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
                AzureClient = "azure_clientad1e381f",
                ResourceGroupId = "resource_group_iddd336ae4",
                WorkloadIdentityConfig = new WorkloadIdentityConfig(),
                ClusterCaCertificate = "cluster_ca_certificate21fa2421",
                Fleet = new Fleet(),
                ManagedResources = new AzureClusterResources(),
                LoggingConfig = new LoggingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAzureClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AzureCluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureCluster responseCallSettings = await client.GetAzureClusterAsync(request.AzureClusterName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AzureCluster responseCancellationToken = await client.GetAzureClusterAsync(request.AzureClusterName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateAzureAccessTokenRequestObject()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateAzureAccessTokenRequest request = new GenerateAzureAccessTokenRequest
            {
                AzureClusterAsAzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
            };
            GenerateAzureAccessTokenResponse expectedResponse = new GenerateAzureAccessTokenResponse
            {
                AccessToken = "access_token85826cd8",
                ExpirationTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GenerateAzureAccessToken(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            GenerateAzureAccessTokenResponse response = client.GenerateAzureAccessToken(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateAzureAccessTokenRequestObjectAsync()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateAzureAccessTokenRequest request = new GenerateAzureAccessTokenRequest
            {
                AzureClusterAsAzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
            };
            GenerateAzureAccessTokenResponse expectedResponse = new GenerateAzureAccessTokenResponse
            {
                AccessToken = "access_token85826cd8",
                ExpirationTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GenerateAzureAccessTokenAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateAzureAccessTokenResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            GenerateAzureAccessTokenResponse responseCallSettings = await client.GenerateAzureAccessTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateAzureAccessTokenResponse responseCancellationToken = await client.GenerateAzureAccessTokenAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAzureNodePoolRequestObject()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureNodePoolRequest request = new GetAzureNodePoolRequest
            {
                AzureNodePoolName = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]"),
            };
            AzureNodePool expectedResponse = new AzureNodePool
            {
                AzureNodePoolName = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]"),
                Version = "version102ff72a",
                SubnetId = "subnet_idcb6f86fe",
                Autoscaling = new AzureNodePoolAutoscaling(),
                State = AzureNodePool.Types.State.Degraded,
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
                MaxPodsConstraint = new MaxPodsConstraint(),
                Config = new AzureNodeConfig(),
                AzureAvailabilityZone = "azure_availability_zone993dc71f",
            };
            mockGrpcClient.Setup(x => x.GetAzureNodePool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureNodePool response = client.GetAzureNodePool(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAzureNodePoolRequestObjectAsync()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureNodePoolRequest request = new GetAzureNodePoolRequest
            {
                AzureNodePoolName = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]"),
            };
            AzureNodePool expectedResponse = new AzureNodePool
            {
                AzureNodePoolName = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]"),
                Version = "version102ff72a",
                SubnetId = "subnet_idcb6f86fe",
                Autoscaling = new AzureNodePoolAutoscaling(),
                State = AzureNodePool.Types.State.Degraded,
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
                MaxPodsConstraint = new MaxPodsConstraint(),
                Config = new AzureNodeConfig(),
                AzureAvailabilityZone = "azure_availability_zone993dc71f",
            };
            mockGrpcClient.Setup(x => x.GetAzureNodePoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AzureNodePool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureNodePool responseCallSettings = await client.GetAzureNodePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AzureNodePool responseCancellationToken = await client.GetAzureNodePoolAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAzureNodePool()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureNodePoolRequest request = new GetAzureNodePoolRequest
            {
                AzureNodePoolName = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]"),
            };
            AzureNodePool expectedResponse = new AzureNodePool
            {
                AzureNodePoolName = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]"),
                Version = "version102ff72a",
                SubnetId = "subnet_idcb6f86fe",
                Autoscaling = new AzureNodePoolAutoscaling(),
                State = AzureNodePool.Types.State.Degraded,
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
                MaxPodsConstraint = new MaxPodsConstraint(),
                Config = new AzureNodeConfig(),
                AzureAvailabilityZone = "azure_availability_zone993dc71f",
            };
            mockGrpcClient.Setup(x => x.GetAzureNodePool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureNodePool response = client.GetAzureNodePool(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAzureNodePoolAsync()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureNodePoolRequest request = new GetAzureNodePoolRequest
            {
                AzureNodePoolName = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]"),
            };
            AzureNodePool expectedResponse = new AzureNodePool
            {
                AzureNodePoolName = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]"),
                Version = "version102ff72a",
                SubnetId = "subnet_idcb6f86fe",
                Autoscaling = new AzureNodePoolAutoscaling(),
                State = AzureNodePool.Types.State.Degraded,
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
                MaxPodsConstraint = new MaxPodsConstraint(),
                Config = new AzureNodeConfig(),
                AzureAvailabilityZone = "azure_availability_zone993dc71f",
            };
            mockGrpcClient.Setup(x => x.GetAzureNodePoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AzureNodePool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureNodePool responseCallSettings = await client.GetAzureNodePoolAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AzureNodePool responseCancellationToken = await client.GetAzureNodePoolAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAzureNodePoolResourceNames()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureNodePoolRequest request = new GetAzureNodePoolRequest
            {
                AzureNodePoolName = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]"),
            };
            AzureNodePool expectedResponse = new AzureNodePool
            {
                AzureNodePoolName = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]"),
                Version = "version102ff72a",
                SubnetId = "subnet_idcb6f86fe",
                Autoscaling = new AzureNodePoolAutoscaling(),
                State = AzureNodePool.Types.State.Degraded,
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
                MaxPodsConstraint = new MaxPodsConstraint(),
                Config = new AzureNodeConfig(),
                AzureAvailabilityZone = "azure_availability_zone993dc71f",
            };
            mockGrpcClient.Setup(x => x.GetAzureNodePool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureNodePool response = client.GetAzureNodePool(request.AzureNodePoolName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAzureNodePoolResourceNamesAsync()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureNodePoolRequest request = new GetAzureNodePoolRequest
            {
                AzureNodePoolName = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]"),
            };
            AzureNodePool expectedResponse = new AzureNodePool
            {
                AzureNodePoolName = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]"),
                Version = "version102ff72a",
                SubnetId = "subnet_idcb6f86fe",
                Autoscaling = new AzureNodePoolAutoscaling(),
                State = AzureNodePool.Types.State.Degraded,
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
                MaxPodsConstraint = new MaxPodsConstraint(),
                Config = new AzureNodeConfig(),
                AzureAvailabilityZone = "azure_availability_zone993dc71f",
            };
            mockGrpcClient.Setup(x => x.GetAzureNodePoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AzureNodePool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureNodePool responseCallSettings = await client.GetAzureNodePoolAsync(request.AzureNodePoolName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AzureNodePool responseCancellationToken = await client.GetAzureNodePoolAsync(request.AzureNodePoolName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAzureServerConfigRequestObject()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureServerConfigRequest request = new GetAzureServerConfigRequest
            {
                AzureServerConfigName = AzureServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            AzureServerConfig expectedResponse = new AzureServerConfig
            {
                AzureServerConfigName = AzureServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidVersions =
                {
                    new AzureK8sVersionInfo(),
                },
                SupportedAzureRegions =
                {
                    "supported_azure_regions99c2638f",
                },
            };
            mockGrpcClient.Setup(x => x.GetAzureServerConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureServerConfig response = client.GetAzureServerConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAzureServerConfigRequestObjectAsync()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureServerConfigRequest request = new GetAzureServerConfigRequest
            {
                AzureServerConfigName = AzureServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            AzureServerConfig expectedResponse = new AzureServerConfig
            {
                AzureServerConfigName = AzureServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidVersions =
                {
                    new AzureK8sVersionInfo(),
                },
                SupportedAzureRegions =
                {
                    "supported_azure_regions99c2638f",
                },
            };
            mockGrpcClient.Setup(x => x.GetAzureServerConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AzureServerConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureServerConfig responseCallSettings = await client.GetAzureServerConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AzureServerConfig responseCancellationToken = await client.GetAzureServerConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAzureServerConfig()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureServerConfigRequest request = new GetAzureServerConfigRequest
            {
                AzureServerConfigName = AzureServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            AzureServerConfig expectedResponse = new AzureServerConfig
            {
                AzureServerConfigName = AzureServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidVersions =
                {
                    new AzureK8sVersionInfo(),
                },
                SupportedAzureRegions =
                {
                    "supported_azure_regions99c2638f",
                },
            };
            mockGrpcClient.Setup(x => x.GetAzureServerConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureServerConfig response = client.GetAzureServerConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAzureServerConfigAsync()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureServerConfigRequest request = new GetAzureServerConfigRequest
            {
                AzureServerConfigName = AzureServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            AzureServerConfig expectedResponse = new AzureServerConfig
            {
                AzureServerConfigName = AzureServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidVersions =
                {
                    new AzureK8sVersionInfo(),
                },
                SupportedAzureRegions =
                {
                    "supported_azure_regions99c2638f",
                },
            };
            mockGrpcClient.Setup(x => x.GetAzureServerConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AzureServerConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureServerConfig responseCallSettings = await client.GetAzureServerConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AzureServerConfig responseCancellationToken = await client.GetAzureServerConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAzureServerConfigResourceNames()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureServerConfigRequest request = new GetAzureServerConfigRequest
            {
                AzureServerConfigName = AzureServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            AzureServerConfig expectedResponse = new AzureServerConfig
            {
                AzureServerConfigName = AzureServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidVersions =
                {
                    new AzureK8sVersionInfo(),
                },
                SupportedAzureRegions =
                {
                    "supported_azure_regions99c2638f",
                },
            };
            mockGrpcClient.Setup(x => x.GetAzureServerConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureServerConfig response = client.GetAzureServerConfig(request.AzureServerConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAzureServerConfigResourceNamesAsync()
        {
            moq::Mock<AzureClusters.AzureClustersClient> mockGrpcClient = new moq::Mock<AzureClusters.AzureClustersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAzureServerConfigRequest request = new GetAzureServerConfigRequest
            {
                AzureServerConfigName = AzureServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            AzureServerConfig expectedResponse = new AzureServerConfig
            {
                AzureServerConfigName = AzureServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidVersions =
                {
                    new AzureK8sVersionInfo(),
                },
                SupportedAzureRegions =
                {
                    "supported_azure_regions99c2638f",
                },
            };
            mockGrpcClient.Setup(x => x.GetAzureServerConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AzureServerConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AzureClustersClient client = new AzureClustersClientImpl(mockGrpcClient.Object, null, null);
            AzureServerConfig responseCallSettings = await client.GetAzureServerConfigAsync(request.AzureServerConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AzureServerConfig responseCancellationToken = await client.GetAzureServerConfigAsync(request.AzureServerConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
