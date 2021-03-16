// Copyright 2021 Google LLC
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
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.GkeHub.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedGkeHubMembershipServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetMembershipRequestObject()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMembershipRequest request = new GetMembershipRequest
            {
                Name = "name1c9368b0",
            };
            Membership expectedResponse = new Membership
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Endpoint = new MembershipEndpoint
                {
                    GkeCluster = new GkeCluster
                    {
                        ResourceLink = "resource_link182528d9",
                    },
                    KubernetesMetadata = new KubernetesMetadata
                    {
                        KubernetesApiServerVersion = "kubernetes_api_server_version716eda33",
                        NodeProviderId = "node_provider_idc532164a",
                        NodeCount = -1659500730,
                        VcpuCount = -1702761793,
                        MemoryMb = -1241574521,
                        UpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    KubernetesResource = new KubernetesResource
                    {
                        MembershipCrManifest = "membership_cr_manifestec6be4f1",
                        MembershipResources =
                        {
                            new ResourceManifest
                            {
                                Manifest = "manifest4ab75c7f",
                                ClusterScoped = false,
                            },
                        },
                        ConnectResources =
                        {
                            new ResourceManifest
                            {
                                Manifest = "manifest4ab75c7f",
                                ClusterScoped = false,
                            },
                        },
                        ResourceOptions = new ResourceOptions
                        {
                            ConnectVersion = "connect_version76940d70",
                            V1Beta1Crd = false,
                        },
                    },
                },
                State = new MembershipState
                {
                    Code = MembershipState.Types.Code.Creating,
#pragma warning disable CS0612
                    Description = "description2cf9da67",
                    UpdateTime = new wkt::Timestamp
#pragma warning restore CS0612
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DeleteTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Authority = new Authority
                {
                    Issuer = "issuerc12b6c3e",
                    WorkloadIdentityPool = "workload_identity_pool63099a52",
                    IdentityProvider = "identity_provider43fd87ee",
                    OidcJwks = proto::ByteString.CopyFromUtf8("oidc_jwksbaa1cfd3"),
                },
                ExternalId = "external_id9442680e",
                LastConnectionTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UniqueId = "unique_idee0c0869",
                InfrastructureType = Membership.Types.InfrastructureType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMembership(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            Membership response = client.GetMembership(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMembershipRequestObjectAsync()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMembershipRequest request = new GetMembershipRequest
            {
                Name = "name1c9368b0",
            };
            Membership expectedResponse = new Membership
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Endpoint = new MembershipEndpoint
                {
                    GkeCluster = new GkeCluster
                    {
                        ResourceLink = "resource_link182528d9",
                    },
                    KubernetesMetadata = new KubernetesMetadata
                    {
                        KubernetesApiServerVersion = "kubernetes_api_server_version716eda33",
                        NodeProviderId = "node_provider_idc532164a",
                        NodeCount = -1659500730,
                        VcpuCount = -1702761793,
                        MemoryMb = -1241574521,
                        UpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    KubernetesResource = new KubernetesResource
                    {
                        MembershipCrManifest = "membership_cr_manifestec6be4f1",
                        MembershipResources =
                        {
                            new ResourceManifest
                            {
                                Manifest = "manifest4ab75c7f",
                                ClusterScoped = false,
                            },
                        },
                        ConnectResources =
                        {
                            new ResourceManifest
                            {
                                Manifest = "manifest4ab75c7f",
                                ClusterScoped = false,
                            },
                        },
                        ResourceOptions = new ResourceOptions
                        {
                            ConnectVersion = "connect_version76940d70",
                            V1Beta1Crd = false,
                        },
                    },
                },
                State = new MembershipState
                {
                    Code = MembershipState.Types.Code.Creating,
#pragma warning disable CS0612
                    Description = "description2cf9da67",
                    UpdateTime = new wkt::Timestamp
#pragma warning restore CS0612
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DeleteTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Authority = new Authority
                {
                    Issuer = "issuerc12b6c3e",
                    WorkloadIdentityPool = "workload_identity_pool63099a52",
                    IdentityProvider = "identity_provider43fd87ee",
                    OidcJwks = proto::ByteString.CopyFromUtf8("oidc_jwksbaa1cfd3"),
                },
                ExternalId = "external_id9442680e",
                LastConnectionTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UniqueId = "unique_idee0c0869",
                InfrastructureType = Membership.Types.InfrastructureType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMembershipAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Membership>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            Membership responseCallSettings = await client.GetMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Membership responseCancellationToken = await client.GetMembershipAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMembership()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMembershipRequest request = new GetMembershipRequest
            {
                Name = "name1c9368b0",
            };
            Membership expectedResponse = new Membership
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Endpoint = new MembershipEndpoint
                {
                    GkeCluster = new GkeCluster
                    {
                        ResourceLink = "resource_link182528d9",
                    },
                    KubernetesMetadata = new KubernetesMetadata
                    {
                        KubernetesApiServerVersion = "kubernetes_api_server_version716eda33",
                        NodeProviderId = "node_provider_idc532164a",
                        NodeCount = -1659500730,
                        VcpuCount = -1702761793,
                        MemoryMb = -1241574521,
                        UpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    KubernetesResource = new KubernetesResource
                    {
                        MembershipCrManifest = "membership_cr_manifestec6be4f1",
                        MembershipResources =
                        {
                            new ResourceManifest
                            {
                                Manifest = "manifest4ab75c7f",
                                ClusterScoped = false,
                            },
                        },
                        ConnectResources =
                        {
                            new ResourceManifest
                            {
                                Manifest = "manifest4ab75c7f",
                                ClusterScoped = false,
                            },
                        },
                        ResourceOptions = new ResourceOptions
                        {
                            ConnectVersion = "connect_version76940d70",
                            V1Beta1Crd = false,
                        },
                    },
                },
                State = new MembershipState
                {
                    Code = MembershipState.Types.Code.Creating,
#pragma warning disable CS0612
                    Description = "description2cf9da67",
                    UpdateTime = new wkt::Timestamp
#pragma warning restore CS0612
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DeleteTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Authority = new Authority
                {
                    Issuer = "issuerc12b6c3e",
                    WorkloadIdentityPool = "workload_identity_pool63099a52",
                    IdentityProvider = "identity_provider43fd87ee",
                    OidcJwks = proto::ByteString.CopyFromUtf8("oidc_jwksbaa1cfd3"),
                },
                ExternalId = "external_id9442680e",
                LastConnectionTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UniqueId = "unique_idee0c0869",
                InfrastructureType = Membership.Types.InfrastructureType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMembership(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            Membership response = client.GetMembership(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMembershipAsync()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMembershipRequest request = new GetMembershipRequest
            {
                Name = "name1c9368b0",
            };
            Membership expectedResponse = new Membership
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Endpoint = new MembershipEndpoint
                {
                    GkeCluster = new GkeCluster
                    {
                        ResourceLink = "resource_link182528d9",
                    },
                    KubernetesMetadata = new KubernetesMetadata
                    {
                        KubernetesApiServerVersion = "kubernetes_api_server_version716eda33",
                        NodeProviderId = "node_provider_idc532164a",
                        NodeCount = -1659500730,
                        VcpuCount = -1702761793,
                        MemoryMb = -1241574521,
                        UpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    KubernetesResource = new KubernetesResource
                    {
                        MembershipCrManifest = "membership_cr_manifestec6be4f1",
                        MembershipResources =
                        {
                            new ResourceManifest
                            {
                                Manifest = "manifest4ab75c7f",
                                ClusterScoped = false,
                            },
                        },
                        ConnectResources =
                        {
                            new ResourceManifest
                            {
                                Manifest = "manifest4ab75c7f",
                                ClusterScoped = false,
                            },
                        },
                        ResourceOptions = new ResourceOptions
                        {
                            ConnectVersion = "connect_version76940d70",
                            V1Beta1Crd = false,
                        },
                    },
                },
                State = new MembershipState
                {
                    Code = MembershipState.Types.Code.Creating,
#pragma warning disable CS0612
                    Description = "description2cf9da67",
                    UpdateTime = new wkt::Timestamp
#pragma warning restore CS0612
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DeleteTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Authority = new Authority
                {
                    Issuer = "issuerc12b6c3e",
                    WorkloadIdentityPool = "workload_identity_pool63099a52",
                    IdentityProvider = "identity_provider43fd87ee",
                    OidcJwks = proto::ByteString.CopyFromUtf8("oidc_jwksbaa1cfd3"),
                },
                ExternalId = "external_id9442680e",
                LastConnectionTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UniqueId = "unique_idee0c0869",
                InfrastructureType = Membership.Types.InfrastructureType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMembershipAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Membership>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            Membership responseCallSettings = await client.GetMembershipAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Membership responseCancellationToken = await client.GetMembershipAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateConnectManifestRequestObject()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateConnectManifestRequest request = new GenerateConnectManifestRequest
            {
                Name = "name1c9368b0",
                ConnectAgent = new ConnectAgent
                {
#pragma warning disable CS0612
                    Name = "name1c9368b0",
#pragma warning restore CS0612
                    Proxy = proto::ByteString.CopyFromUtf8("proxyeb871343"),
                    Namespace = "namespace9e1e8089",
                },
                Version = "version102ff72a",
                IsUpgrade = false,
                Registry = "registrycf5d20a9",
                ImagePullSecretContent = proto::ByteString.CopyFromUtf8("image_pull_secret_content89fc8e49"),
            };
            GenerateConnectManifestResponse expectedResponse = new GenerateConnectManifestResponse
            {
                Manifest =
                {
                    new ConnectAgentResource
                    {
                        Type = new TypeMeta
                        {
                            Kind = "kindf7aa39d9",
                            ApiVersion = "api_versioncfc3cf41",
                        },
                        Manifest = "manifest4ab75c7f",
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GenerateConnectManifest(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            GenerateConnectManifestResponse response = client.GenerateConnectManifest(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateConnectManifestRequestObjectAsync()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateConnectManifestRequest request = new GenerateConnectManifestRequest
            {
                Name = "name1c9368b0",
                ConnectAgent = new ConnectAgent
                {
#pragma warning disable CS0612
                    Name = "name1c9368b0",
#pragma warning restore CS0612
                    Proxy = proto::ByteString.CopyFromUtf8("proxyeb871343"),
                    Namespace = "namespace9e1e8089",
                },
                Version = "version102ff72a",
                IsUpgrade = false,
                Registry = "registrycf5d20a9",
                ImagePullSecretContent = proto::ByteString.CopyFromUtf8("image_pull_secret_content89fc8e49"),
            };
            GenerateConnectManifestResponse expectedResponse = new GenerateConnectManifestResponse
            {
                Manifest =
                {
                    new ConnectAgentResource
                    {
                        Type = new TypeMeta
                        {
                            Kind = "kindf7aa39d9",
                            ApiVersion = "api_versioncfc3cf41",
                        },
                        Manifest = "manifest4ab75c7f",
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GenerateConnectManifestAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateConnectManifestResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            GenerateConnectManifestResponse responseCallSettings = await client.GenerateConnectManifestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateConnectManifestResponse responseCancellationToken = await client.GenerateConnectManifestAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ValidateExclusivityRequestObject()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ValidateExclusivityRequest request = new ValidateExclusivityRequest
            {
                Parent = "parent7858e4d0",
                CrManifest = "cr_manifestdf1378ad",
                IntendedMembership = "intended_membership4a00bbcb",
            };
            ValidateExclusivityResponse expectedResponse = new ValidateExclusivityResponse
            {
                Status = new gr::Status
                {
                    Code = -1805175871,
                    Message = "message0231e778",
                    Details =
                    {
                        new wkt::Any
                        {
                            TypeUrl = "type_urlfde5623b",
                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.ValidateExclusivity(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            ValidateExclusivityResponse response = client.ValidateExclusivity(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ValidateExclusivityRequestObjectAsync()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ValidateExclusivityRequest request = new ValidateExclusivityRequest
            {
                Parent = "parent7858e4d0",
                CrManifest = "cr_manifestdf1378ad",
                IntendedMembership = "intended_membership4a00bbcb",
            };
            ValidateExclusivityResponse expectedResponse = new ValidateExclusivityResponse
            {
                Status = new gr::Status
                {
                    Code = -1805175871,
                    Message = "message0231e778",
                    Details =
                    {
                        new wkt::Any
                        {
                            TypeUrl = "type_urlfde5623b",
                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.ValidateExclusivityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ValidateExclusivityResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            ValidateExclusivityResponse responseCallSettings = await client.ValidateExclusivityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ValidateExclusivityResponse responseCancellationToken = await client.ValidateExclusivityAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateExclusivityManifestRequestObject()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateExclusivityManifestRequest request = new GenerateExclusivityManifestRequest
            {
                Name = "name1c9368b0",
                CrdManifest = "crd_manifest09dc10bb",
                CrManifest = "cr_manifestdf1378ad",
            };
            GenerateExclusivityManifestResponse expectedResponse = new GenerateExclusivityManifestResponse
            {
                CrdManifest = "crd_manifest09dc10bb",
                CrManifest = "cr_manifestdf1378ad",
            };
            mockGrpcClient.Setup(x => x.GenerateExclusivityManifest(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            GenerateExclusivityManifestResponse response = client.GenerateExclusivityManifest(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateExclusivityManifestRequestObjectAsync()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateExclusivityManifestRequest request = new GenerateExclusivityManifestRequest
            {
                Name = "name1c9368b0",
                CrdManifest = "crd_manifest09dc10bb",
                CrManifest = "cr_manifestdf1378ad",
            };
            GenerateExclusivityManifestResponse expectedResponse = new GenerateExclusivityManifestResponse
            {
                CrdManifest = "crd_manifest09dc10bb",
                CrManifest = "cr_manifestdf1378ad",
            };
            mockGrpcClient.Setup(x => x.GenerateExclusivityManifestAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateExclusivityManifestResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            GenerateExclusivityManifestResponse responseCallSettings = await client.GenerateExclusivityManifestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateExclusivityManifestResponse responseCancellationToken = await client.GenerateExclusivityManifestAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
