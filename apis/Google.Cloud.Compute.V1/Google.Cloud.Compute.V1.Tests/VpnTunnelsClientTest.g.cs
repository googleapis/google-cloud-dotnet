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

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedVpnTunnelsClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<VpnTunnels.VpnTunnelsClient> mockGrpcClient = new moq::Mock<VpnTunnels.VpnTunnelsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVpnTunnelRequest request = new GetVpnTunnelRequest
            {
                Region = "regionedb20d96",
                VpnTunnel = "vpn_tunnelfa4123fd",
                Project = "projectaa6ff846",
            };
            VpnTunnel expectedResponse = new VpnTunnel
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                VpnGatewayInterface = 1166485993,
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Status = "status5444cb9a",
                IkeVersion = 485306612,
                PeerGcpGateway = "peer_gcp_gateway613039db",
                LocalTrafficSelector =
                {
                    "local_traffic_selector09bfbb68",
                },
                DetailedStatus = "detailed_status4e3163c7",
                RemoteTrafficSelector =
                {
                    "remote_traffic_selector8463a07f",
                },
                SharedSecret = "shared_secret3a48b317",
                PeerIp = "peer_ip5b148b8e",
                PeerExternalGateway = "peer_external_gatewaye60baaef",
                SharedSecretHash = "shared_secret_hash3ba18c3b",
                VpnGateway = "vpn_gatewayaa15de14",
                Description = "description2cf9da67",
                PeerExternalGatewayInterface = -994715857,
                SelfLink = "self_link7e87f12d",
                TargetVpnGateway = "target_vpn_gateway6c481371",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnTunnelsClient client = new VpnTunnelsClientImpl(mockGrpcClient.Object, null, null);
            VpnTunnel response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<VpnTunnels.VpnTunnelsClient> mockGrpcClient = new moq::Mock<VpnTunnels.VpnTunnelsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVpnTunnelRequest request = new GetVpnTunnelRequest
            {
                Region = "regionedb20d96",
                VpnTunnel = "vpn_tunnelfa4123fd",
                Project = "projectaa6ff846",
            };
            VpnTunnel expectedResponse = new VpnTunnel
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                VpnGatewayInterface = 1166485993,
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Status = "status5444cb9a",
                IkeVersion = 485306612,
                PeerGcpGateway = "peer_gcp_gateway613039db",
                LocalTrafficSelector =
                {
                    "local_traffic_selector09bfbb68",
                },
                DetailedStatus = "detailed_status4e3163c7",
                RemoteTrafficSelector =
                {
                    "remote_traffic_selector8463a07f",
                },
                SharedSecret = "shared_secret3a48b317",
                PeerIp = "peer_ip5b148b8e",
                PeerExternalGateway = "peer_external_gatewaye60baaef",
                SharedSecretHash = "shared_secret_hash3ba18c3b",
                VpnGateway = "vpn_gatewayaa15de14",
                Description = "description2cf9da67",
                PeerExternalGatewayInterface = -994715857,
                SelfLink = "self_link7e87f12d",
                TargetVpnGateway = "target_vpn_gateway6c481371",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VpnTunnel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnTunnelsClient client = new VpnTunnelsClientImpl(mockGrpcClient.Object, null, null);
            VpnTunnel responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VpnTunnel responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<VpnTunnels.VpnTunnelsClient> mockGrpcClient = new moq::Mock<VpnTunnels.VpnTunnelsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVpnTunnelRequest request = new GetVpnTunnelRequest
            {
                Region = "regionedb20d96",
                VpnTunnel = "vpn_tunnelfa4123fd",
                Project = "projectaa6ff846",
            };
            VpnTunnel expectedResponse = new VpnTunnel
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                VpnGatewayInterface = 1166485993,
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Status = "status5444cb9a",
                IkeVersion = 485306612,
                PeerGcpGateway = "peer_gcp_gateway613039db",
                LocalTrafficSelector =
                {
                    "local_traffic_selector09bfbb68",
                },
                DetailedStatus = "detailed_status4e3163c7",
                RemoteTrafficSelector =
                {
                    "remote_traffic_selector8463a07f",
                },
                SharedSecret = "shared_secret3a48b317",
                PeerIp = "peer_ip5b148b8e",
                PeerExternalGateway = "peer_external_gatewaye60baaef",
                SharedSecretHash = "shared_secret_hash3ba18c3b",
                VpnGateway = "vpn_gatewayaa15de14",
                Description = "description2cf9da67",
                PeerExternalGatewayInterface = -994715857,
                SelfLink = "self_link7e87f12d",
                TargetVpnGateway = "target_vpn_gateway6c481371",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnTunnelsClient client = new VpnTunnelsClientImpl(mockGrpcClient.Object, null, null);
            VpnTunnel response = client.Get(request.Project, request.Region, request.VpnTunnel);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<VpnTunnels.VpnTunnelsClient> mockGrpcClient = new moq::Mock<VpnTunnels.VpnTunnelsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVpnTunnelRequest request = new GetVpnTunnelRequest
            {
                Region = "regionedb20d96",
                VpnTunnel = "vpn_tunnelfa4123fd",
                Project = "projectaa6ff846",
            };
            VpnTunnel expectedResponse = new VpnTunnel
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                VpnGatewayInterface = 1166485993,
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Status = "status5444cb9a",
                IkeVersion = 485306612,
                PeerGcpGateway = "peer_gcp_gateway613039db",
                LocalTrafficSelector =
                {
                    "local_traffic_selector09bfbb68",
                },
                DetailedStatus = "detailed_status4e3163c7",
                RemoteTrafficSelector =
                {
                    "remote_traffic_selector8463a07f",
                },
                SharedSecret = "shared_secret3a48b317",
                PeerIp = "peer_ip5b148b8e",
                PeerExternalGateway = "peer_external_gatewaye60baaef",
                SharedSecretHash = "shared_secret_hash3ba18c3b",
                VpnGateway = "vpn_gatewayaa15de14",
                Description = "description2cf9da67",
                PeerExternalGatewayInterface = -994715857,
                SelfLink = "self_link7e87f12d",
                TargetVpnGateway = "target_vpn_gateway6c481371",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VpnTunnel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnTunnelsClient client = new VpnTunnelsClientImpl(mockGrpcClient.Object, null, null);
            VpnTunnel responseCallSettings = await client.GetAsync(request.Project, request.Region, request.VpnTunnel, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VpnTunnel responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.VpnTunnel, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
