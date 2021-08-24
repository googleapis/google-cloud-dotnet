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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.NetworkConnectivity.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedHubServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetHubRequestObject()
        {
            moq::Mock<HubService.HubServiceClient> mockGrpcClient = new moq::Mock<HubService.HubServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHubRequest request = new GetHubRequest
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
            };
            Hub expectedResponse = new Hub
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                UniqueId = "unique_idee0c0869",
                State = State.Active,
                RoutingVpcs = { new RoutingVPC(), },
            };
            mockGrpcClient.Setup(x => x.GetHub(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HubServiceClient client = new HubServiceClientImpl(mockGrpcClient.Object, null);
            Hub response = client.GetHub(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetHubRequestObjectAsync()
        {
            moq::Mock<HubService.HubServiceClient> mockGrpcClient = new moq::Mock<HubService.HubServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHubRequest request = new GetHubRequest
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
            };
            Hub expectedResponse = new Hub
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                UniqueId = "unique_idee0c0869",
                State = State.Active,
                RoutingVpcs = { new RoutingVPC(), },
            };
            mockGrpcClient.Setup(x => x.GetHubAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Hub>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HubServiceClient client = new HubServiceClientImpl(mockGrpcClient.Object, null);
            Hub responseCallSettings = await client.GetHubAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Hub responseCancellationToken = await client.GetHubAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetHub()
        {
            moq::Mock<HubService.HubServiceClient> mockGrpcClient = new moq::Mock<HubService.HubServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHubRequest request = new GetHubRequest
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
            };
            Hub expectedResponse = new Hub
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                UniqueId = "unique_idee0c0869",
                State = State.Active,
                RoutingVpcs = { new RoutingVPC(), },
            };
            mockGrpcClient.Setup(x => x.GetHub(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HubServiceClient client = new HubServiceClientImpl(mockGrpcClient.Object, null);
            Hub response = client.GetHub(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetHubAsync()
        {
            moq::Mock<HubService.HubServiceClient> mockGrpcClient = new moq::Mock<HubService.HubServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHubRequest request = new GetHubRequest
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
            };
            Hub expectedResponse = new Hub
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                UniqueId = "unique_idee0c0869",
                State = State.Active,
                RoutingVpcs = { new RoutingVPC(), },
            };
            mockGrpcClient.Setup(x => x.GetHubAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Hub>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HubServiceClient client = new HubServiceClientImpl(mockGrpcClient.Object, null);
            Hub responseCallSettings = await client.GetHubAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Hub responseCancellationToken = await client.GetHubAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetHubResourceNames()
        {
            moq::Mock<HubService.HubServiceClient> mockGrpcClient = new moq::Mock<HubService.HubServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHubRequest request = new GetHubRequest
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
            };
            Hub expectedResponse = new Hub
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                UniqueId = "unique_idee0c0869",
                State = State.Active,
                RoutingVpcs = { new RoutingVPC(), },
            };
            mockGrpcClient.Setup(x => x.GetHub(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HubServiceClient client = new HubServiceClientImpl(mockGrpcClient.Object, null);
            Hub response = client.GetHub(request.HubName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetHubResourceNamesAsync()
        {
            moq::Mock<HubService.HubServiceClient> mockGrpcClient = new moq::Mock<HubService.HubServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHubRequest request = new GetHubRequest
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
            };
            Hub expectedResponse = new Hub
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                UniqueId = "unique_idee0c0869",
                State = State.Active,
                RoutingVpcs = { new RoutingVPC(), },
            };
            mockGrpcClient.Setup(x => x.GetHubAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Hub>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HubServiceClient client = new HubServiceClientImpl(mockGrpcClient.Object, null);
            Hub responseCallSettings = await client.GetHubAsync(request.HubName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Hub responseCancellationToken = await client.GetHubAsync(request.HubName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSpokeRequestObject()
        {
            moq::Mock<HubService.HubServiceClient> mockGrpcClient = new moq::Mock<HubService.HubServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSpokeRequest request = new GetSpokeRequest
            {
                SpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
            };
            Spoke expectedResponse = new Spoke
            {
                SpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                HubAsHubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                UniqueId = "unique_idee0c0869",
                State = State.Active,
                LinkedVpnTunnels = new LinkedVpnTunnels(),
                LinkedInterconnectAttachments = new LinkedInterconnectAttachments(),
                LinkedRouterApplianceInstances = new LinkedRouterApplianceInstances(),
            };
            mockGrpcClient.Setup(x => x.GetSpoke(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HubServiceClient client = new HubServiceClientImpl(mockGrpcClient.Object, null);
            Spoke response = client.GetSpoke(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSpokeRequestObjectAsync()
        {
            moq::Mock<HubService.HubServiceClient> mockGrpcClient = new moq::Mock<HubService.HubServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSpokeRequest request = new GetSpokeRequest
            {
                SpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
            };
            Spoke expectedResponse = new Spoke
            {
                SpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                HubAsHubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                UniqueId = "unique_idee0c0869",
                State = State.Active,
                LinkedVpnTunnels = new LinkedVpnTunnels(),
                LinkedInterconnectAttachments = new LinkedInterconnectAttachments(),
                LinkedRouterApplianceInstances = new LinkedRouterApplianceInstances(),
            };
            mockGrpcClient.Setup(x => x.GetSpokeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Spoke>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HubServiceClient client = new HubServiceClientImpl(mockGrpcClient.Object, null);
            Spoke responseCallSettings = await client.GetSpokeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Spoke responseCancellationToken = await client.GetSpokeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSpoke()
        {
            moq::Mock<HubService.HubServiceClient> mockGrpcClient = new moq::Mock<HubService.HubServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSpokeRequest request = new GetSpokeRequest
            {
                SpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
            };
            Spoke expectedResponse = new Spoke
            {
                SpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                HubAsHubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                UniqueId = "unique_idee0c0869",
                State = State.Active,
                LinkedVpnTunnels = new LinkedVpnTunnels(),
                LinkedInterconnectAttachments = new LinkedInterconnectAttachments(),
                LinkedRouterApplianceInstances = new LinkedRouterApplianceInstances(),
            };
            mockGrpcClient.Setup(x => x.GetSpoke(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HubServiceClient client = new HubServiceClientImpl(mockGrpcClient.Object, null);
            Spoke response = client.GetSpoke(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSpokeAsync()
        {
            moq::Mock<HubService.HubServiceClient> mockGrpcClient = new moq::Mock<HubService.HubServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSpokeRequest request = new GetSpokeRequest
            {
                SpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
            };
            Spoke expectedResponse = new Spoke
            {
                SpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                HubAsHubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                UniqueId = "unique_idee0c0869",
                State = State.Active,
                LinkedVpnTunnels = new LinkedVpnTunnels(),
                LinkedInterconnectAttachments = new LinkedInterconnectAttachments(),
                LinkedRouterApplianceInstances = new LinkedRouterApplianceInstances(),
            };
            mockGrpcClient.Setup(x => x.GetSpokeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Spoke>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HubServiceClient client = new HubServiceClientImpl(mockGrpcClient.Object, null);
            Spoke responseCallSettings = await client.GetSpokeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Spoke responseCancellationToken = await client.GetSpokeAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSpokeResourceNames()
        {
            moq::Mock<HubService.HubServiceClient> mockGrpcClient = new moq::Mock<HubService.HubServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSpokeRequest request = new GetSpokeRequest
            {
                SpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
            };
            Spoke expectedResponse = new Spoke
            {
                SpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                HubAsHubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                UniqueId = "unique_idee0c0869",
                State = State.Active,
                LinkedVpnTunnels = new LinkedVpnTunnels(),
                LinkedInterconnectAttachments = new LinkedInterconnectAttachments(),
                LinkedRouterApplianceInstances = new LinkedRouterApplianceInstances(),
            };
            mockGrpcClient.Setup(x => x.GetSpoke(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HubServiceClient client = new HubServiceClientImpl(mockGrpcClient.Object, null);
            Spoke response = client.GetSpoke(request.SpokeName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSpokeResourceNamesAsync()
        {
            moq::Mock<HubService.HubServiceClient> mockGrpcClient = new moq::Mock<HubService.HubServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSpokeRequest request = new GetSpokeRequest
            {
                SpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
            };
            Spoke expectedResponse = new Spoke
            {
                SpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                HubAsHubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                UniqueId = "unique_idee0c0869",
                State = State.Active,
                LinkedVpnTunnels = new LinkedVpnTunnels(),
                LinkedInterconnectAttachments = new LinkedInterconnectAttachments(),
                LinkedRouterApplianceInstances = new LinkedRouterApplianceInstances(),
            };
            mockGrpcClient.Setup(x => x.GetSpokeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Spoke>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HubServiceClient client = new HubServiceClientImpl(mockGrpcClient.Object, null);
            Spoke responseCallSettings = await client.GetSpokeAsync(request.SpokeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Spoke responseCancellationToken = await client.GetSpokeAsync(request.SpokeName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
