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

namespace Google.Cloud.NetworkSecurity.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedNetworkSecurityClientTest
    {
        [xunit::FactAttribute]
        public void GetAuthorizationPolicyRequestObject()
        {
            moq::Mock<NetworkSecurity.NetworkSecurityClient> mockGrpcClient = new moq::Mock<NetworkSecurity.NetworkSecurityClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAuthorizationPolicyRequest request = new GetAuthorizationPolicyRequest
            {
                AuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
            };
            AuthorizationPolicy expectedResponse = new AuthorizationPolicy
            {
                AuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Action = AuthorizationPolicy.Types.Action.Deny,
                Rules =
                {
                    new AuthorizationPolicy.Types.Rule(),
                },
            };
            mockGrpcClient.Setup(x => x.GetAuthorizationPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworkSecurityClient client = new NetworkSecurityClientImpl(mockGrpcClient.Object, null, null);
            AuthorizationPolicy response = client.GetAuthorizationPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAuthorizationPolicyRequestObjectAsync()
        {
            moq::Mock<NetworkSecurity.NetworkSecurityClient> mockGrpcClient = new moq::Mock<NetworkSecurity.NetworkSecurityClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAuthorizationPolicyRequest request = new GetAuthorizationPolicyRequest
            {
                AuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
            };
            AuthorizationPolicy expectedResponse = new AuthorizationPolicy
            {
                AuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Action = AuthorizationPolicy.Types.Action.Deny,
                Rules =
                {
                    new AuthorizationPolicy.Types.Rule(),
                },
            };
            mockGrpcClient.Setup(x => x.GetAuthorizationPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AuthorizationPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworkSecurityClient client = new NetworkSecurityClientImpl(mockGrpcClient.Object, null, null);
            AuthorizationPolicy responseCallSettings = await client.GetAuthorizationPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AuthorizationPolicy responseCancellationToken = await client.GetAuthorizationPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAuthorizationPolicy()
        {
            moq::Mock<NetworkSecurity.NetworkSecurityClient> mockGrpcClient = new moq::Mock<NetworkSecurity.NetworkSecurityClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAuthorizationPolicyRequest request = new GetAuthorizationPolicyRequest
            {
                AuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
            };
            AuthorizationPolicy expectedResponse = new AuthorizationPolicy
            {
                AuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Action = AuthorizationPolicy.Types.Action.Deny,
                Rules =
                {
                    new AuthorizationPolicy.Types.Rule(),
                },
            };
            mockGrpcClient.Setup(x => x.GetAuthorizationPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworkSecurityClient client = new NetworkSecurityClientImpl(mockGrpcClient.Object, null, null);
            AuthorizationPolicy response = client.GetAuthorizationPolicy(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAuthorizationPolicyAsync()
        {
            moq::Mock<NetworkSecurity.NetworkSecurityClient> mockGrpcClient = new moq::Mock<NetworkSecurity.NetworkSecurityClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAuthorizationPolicyRequest request = new GetAuthorizationPolicyRequest
            {
                AuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
            };
            AuthorizationPolicy expectedResponse = new AuthorizationPolicy
            {
                AuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Action = AuthorizationPolicy.Types.Action.Deny,
                Rules =
                {
                    new AuthorizationPolicy.Types.Rule(),
                },
            };
            mockGrpcClient.Setup(x => x.GetAuthorizationPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AuthorizationPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworkSecurityClient client = new NetworkSecurityClientImpl(mockGrpcClient.Object, null, null);
            AuthorizationPolicy responseCallSettings = await client.GetAuthorizationPolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AuthorizationPolicy responseCancellationToken = await client.GetAuthorizationPolicyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAuthorizationPolicyResourceNames()
        {
            moq::Mock<NetworkSecurity.NetworkSecurityClient> mockGrpcClient = new moq::Mock<NetworkSecurity.NetworkSecurityClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAuthorizationPolicyRequest request = new GetAuthorizationPolicyRequest
            {
                AuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
            };
            AuthorizationPolicy expectedResponse = new AuthorizationPolicy
            {
                AuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Action = AuthorizationPolicy.Types.Action.Deny,
                Rules =
                {
                    new AuthorizationPolicy.Types.Rule(),
                },
            };
            mockGrpcClient.Setup(x => x.GetAuthorizationPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworkSecurityClient client = new NetworkSecurityClientImpl(mockGrpcClient.Object, null, null);
            AuthorizationPolicy response = client.GetAuthorizationPolicy(request.AuthorizationPolicyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAuthorizationPolicyResourceNamesAsync()
        {
            moq::Mock<NetworkSecurity.NetworkSecurityClient> mockGrpcClient = new moq::Mock<NetworkSecurity.NetworkSecurityClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAuthorizationPolicyRequest request = new GetAuthorizationPolicyRequest
            {
                AuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
            };
            AuthorizationPolicy expectedResponse = new AuthorizationPolicy
            {
                AuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Action = AuthorizationPolicy.Types.Action.Deny,
                Rules =
                {
                    new AuthorizationPolicy.Types.Rule(),
                },
            };
            mockGrpcClient.Setup(x => x.GetAuthorizationPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AuthorizationPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworkSecurityClient client = new NetworkSecurityClientImpl(mockGrpcClient.Object, null, null);
            AuthorizationPolicy responseCallSettings = await client.GetAuthorizationPolicyAsync(request.AuthorizationPolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AuthorizationPolicy responseCancellationToken = await client.GetAuthorizationPolicyAsync(request.AuthorizationPolicyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServerTlsPolicyRequestObject()
        {
            moq::Mock<NetworkSecurity.NetworkSecurityClient> mockGrpcClient = new moq::Mock<NetworkSecurity.NetworkSecurityClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServerTlsPolicyRequest request = new GetServerTlsPolicyRequest
            {
                ServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
            };
            ServerTlsPolicy expectedResponse = new ServerTlsPolicy
            {
                ServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AllowOpen = false,
                ServerCertificate = new CertificateProvider(),
                MtlsPolicy = new ServerTlsPolicy.Types.MTLSPolicy(),
            };
            mockGrpcClient.Setup(x => x.GetServerTlsPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworkSecurityClient client = new NetworkSecurityClientImpl(mockGrpcClient.Object, null, null);
            ServerTlsPolicy response = client.GetServerTlsPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServerTlsPolicyRequestObjectAsync()
        {
            moq::Mock<NetworkSecurity.NetworkSecurityClient> mockGrpcClient = new moq::Mock<NetworkSecurity.NetworkSecurityClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServerTlsPolicyRequest request = new GetServerTlsPolicyRequest
            {
                ServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
            };
            ServerTlsPolicy expectedResponse = new ServerTlsPolicy
            {
                ServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AllowOpen = false,
                ServerCertificate = new CertificateProvider(),
                MtlsPolicy = new ServerTlsPolicy.Types.MTLSPolicy(),
            };
            mockGrpcClient.Setup(x => x.GetServerTlsPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServerTlsPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworkSecurityClient client = new NetworkSecurityClientImpl(mockGrpcClient.Object, null, null);
            ServerTlsPolicy responseCallSettings = await client.GetServerTlsPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServerTlsPolicy responseCancellationToken = await client.GetServerTlsPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServerTlsPolicy()
        {
            moq::Mock<NetworkSecurity.NetworkSecurityClient> mockGrpcClient = new moq::Mock<NetworkSecurity.NetworkSecurityClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServerTlsPolicyRequest request = new GetServerTlsPolicyRequest
            {
                ServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
            };
            ServerTlsPolicy expectedResponse = new ServerTlsPolicy
            {
                ServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AllowOpen = false,
                ServerCertificate = new CertificateProvider(),
                MtlsPolicy = new ServerTlsPolicy.Types.MTLSPolicy(),
            };
            mockGrpcClient.Setup(x => x.GetServerTlsPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworkSecurityClient client = new NetworkSecurityClientImpl(mockGrpcClient.Object, null, null);
            ServerTlsPolicy response = client.GetServerTlsPolicy(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServerTlsPolicyAsync()
        {
            moq::Mock<NetworkSecurity.NetworkSecurityClient> mockGrpcClient = new moq::Mock<NetworkSecurity.NetworkSecurityClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServerTlsPolicyRequest request = new GetServerTlsPolicyRequest
            {
                ServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
            };
            ServerTlsPolicy expectedResponse = new ServerTlsPolicy
            {
                ServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AllowOpen = false,
                ServerCertificate = new CertificateProvider(),
                MtlsPolicy = new ServerTlsPolicy.Types.MTLSPolicy(),
            };
            mockGrpcClient.Setup(x => x.GetServerTlsPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServerTlsPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworkSecurityClient client = new NetworkSecurityClientImpl(mockGrpcClient.Object, null, null);
            ServerTlsPolicy responseCallSettings = await client.GetServerTlsPolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServerTlsPolicy responseCancellationToken = await client.GetServerTlsPolicyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServerTlsPolicyResourceNames()
        {
            moq::Mock<NetworkSecurity.NetworkSecurityClient> mockGrpcClient = new moq::Mock<NetworkSecurity.NetworkSecurityClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServerTlsPolicyRequest request = new GetServerTlsPolicyRequest
            {
                ServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
            };
            ServerTlsPolicy expectedResponse = new ServerTlsPolicy
            {
                ServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AllowOpen = false,
                ServerCertificate = new CertificateProvider(),
                MtlsPolicy = new ServerTlsPolicy.Types.MTLSPolicy(),
            };
            mockGrpcClient.Setup(x => x.GetServerTlsPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworkSecurityClient client = new NetworkSecurityClientImpl(mockGrpcClient.Object, null, null);
            ServerTlsPolicy response = client.GetServerTlsPolicy(request.ServerTlsPolicyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServerTlsPolicyResourceNamesAsync()
        {
            moq::Mock<NetworkSecurity.NetworkSecurityClient> mockGrpcClient = new moq::Mock<NetworkSecurity.NetworkSecurityClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServerTlsPolicyRequest request = new GetServerTlsPolicyRequest
            {
                ServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
            };
            ServerTlsPolicy expectedResponse = new ServerTlsPolicy
            {
                ServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AllowOpen = false,
                ServerCertificate = new CertificateProvider(),
                MtlsPolicy = new ServerTlsPolicy.Types.MTLSPolicy(),
            };
            mockGrpcClient.Setup(x => x.GetServerTlsPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServerTlsPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworkSecurityClient client = new NetworkSecurityClientImpl(mockGrpcClient.Object, null, null);
            ServerTlsPolicy responseCallSettings = await client.GetServerTlsPolicyAsync(request.ServerTlsPolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServerTlsPolicy responseCancellationToken = await client.GetServerTlsPolicyAsync(request.ServerTlsPolicyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetClientTlsPolicyRequestObject()
        {
            moq::Mock<NetworkSecurity.NetworkSecurityClient> mockGrpcClient = new moq::Mock<NetworkSecurity.NetworkSecurityClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClientTlsPolicyRequest request = new GetClientTlsPolicyRequest
            {
                ClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
            };
            ClientTlsPolicy expectedResponse = new ClientTlsPolicy
            {
                ClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Sni = "snif6a20ff7",
                ClientCertificate = new CertificateProvider(),
                ServerValidationCa = { new ValidationCA(), },
            };
            mockGrpcClient.Setup(x => x.GetClientTlsPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworkSecurityClient client = new NetworkSecurityClientImpl(mockGrpcClient.Object, null, null);
            ClientTlsPolicy response = client.GetClientTlsPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClientTlsPolicyRequestObjectAsync()
        {
            moq::Mock<NetworkSecurity.NetworkSecurityClient> mockGrpcClient = new moq::Mock<NetworkSecurity.NetworkSecurityClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClientTlsPolicyRequest request = new GetClientTlsPolicyRequest
            {
                ClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
            };
            ClientTlsPolicy expectedResponse = new ClientTlsPolicy
            {
                ClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Sni = "snif6a20ff7",
                ClientCertificate = new CertificateProvider(),
                ServerValidationCa = { new ValidationCA(), },
            };
            mockGrpcClient.Setup(x => x.GetClientTlsPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ClientTlsPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworkSecurityClient client = new NetworkSecurityClientImpl(mockGrpcClient.Object, null, null);
            ClientTlsPolicy responseCallSettings = await client.GetClientTlsPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ClientTlsPolicy responseCancellationToken = await client.GetClientTlsPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetClientTlsPolicy()
        {
            moq::Mock<NetworkSecurity.NetworkSecurityClient> mockGrpcClient = new moq::Mock<NetworkSecurity.NetworkSecurityClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClientTlsPolicyRequest request = new GetClientTlsPolicyRequest
            {
                ClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
            };
            ClientTlsPolicy expectedResponse = new ClientTlsPolicy
            {
                ClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Sni = "snif6a20ff7",
                ClientCertificate = new CertificateProvider(),
                ServerValidationCa = { new ValidationCA(), },
            };
            mockGrpcClient.Setup(x => x.GetClientTlsPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworkSecurityClient client = new NetworkSecurityClientImpl(mockGrpcClient.Object, null, null);
            ClientTlsPolicy response = client.GetClientTlsPolicy(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClientTlsPolicyAsync()
        {
            moq::Mock<NetworkSecurity.NetworkSecurityClient> mockGrpcClient = new moq::Mock<NetworkSecurity.NetworkSecurityClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClientTlsPolicyRequest request = new GetClientTlsPolicyRequest
            {
                ClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
            };
            ClientTlsPolicy expectedResponse = new ClientTlsPolicy
            {
                ClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Sni = "snif6a20ff7",
                ClientCertificate = new CertificateProvider(),
                ServerValidationCa = { new ValidationCA(), },
            };
            mockGrpcClient.Setup(x => x.GetClientTlsPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ClientTlsPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworkSecurityClient client = new NetworkSecurityClientImpl(mockGrpcClient.Object, null, null);
            ClientTlsPolicy responseCallSettings = await client.GetClientTlsPolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ClientTlsPolicy responseCancellationToken = await client.GetClientTlsPolicyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetClientTlsPolicyResourceNames()
        {
            moq::Mock<NetworkSecurity.NetworkSecurityClient> mockGrpcClient = new moq::Mock<NetworkSecurity.NetworkSecurityClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClientTlsPolicyRequest request = new GetClientTlsPolicyRequest
            {
                ClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
            };
            ClientTlsPolicy expectedResponse = new ClientTlsPolicy
            {
                ClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Sni = "snif6a20ff7",
                ClientCertificate = new CertificateProvider(),
                ServerValidationCa = { new ValidationCA(), },
            };
            mockGrpcClient.Setup(x => x.GetClientTlsPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworkSecurityClient client = new NetworkSecurityClientImpl(mockGrpcClient.Object, null, null);
            ClientTlsPolicy response = client.GetClientTlsPolicy(request.ClientTlsPolicyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClientTlsPolicyResourceNamesAsync()
        {
            moq::Mock<NetworkSecurity.NetworkSecurityClient> mockGrpcClient = new moq::Mock<NetworkSecurity.NetworkSecurityClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClientTlsPolicyRequest request = new GetClientTlsPolicyRequest
            {
                ClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
            };
            ClientTlsPolicy expectedResponse = new ClientTlsPolicy
            {
                ClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Sni = "snif6a20ff7",
                ClientCertificate = new CertificateProvider(),
                ServerValidationCa = { new ValidationCA(), },
            };
            mockGrpcClient.Setup(x => x.GetClientTlsPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ClientTlsPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworkSecurityClient client = new NetworkSecurityClientImpl(mockGrpcClient.Object, null, null);
            ClientTlsPolicy responseCallSettings = await client.GetClientTlsPolicyAsync(request.ClientTlsPolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ClientTlsPolicy responseCancellationToken = await client.GetClientTlsPolicyAsync(request.ClientTlsPolicyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
