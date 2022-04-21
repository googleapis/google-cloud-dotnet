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
    public sealed class GeneratedNetworksClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNetworkRequest request = new GetNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Network expectedResponse = new Network
            {
                Id = 11672635353343658936UL,
                Mtu = 1280318054,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                NetworkFirewallPolicyEnforcementOrder = "network_firewall_policy_enforcement_order54f14f22",
                CreationTimestamp = "creation_timestamp235e59a1",
                SelfLinkWithId = "self_link_with_id6d1e3896",
                IPv4Range = "I_pv4_range613b129f",
                Peerings =
                {
                    new NetworkPeering(),
                },
                GatewayIPv4 = "gateway_i_pv47f9ce361",
                AutoCreateSubnetworks = false,
                InternalIpv6Range = "internal_ipv6_range9d13ac25",
                Subnetworks =
                {
                    "subnetworks81f34af0",
                },
                Description = "description2cf9da67",
                EnableUlaInternalIpv6 = false,
                SelfLink = "self_link7e87f12d",
                RoutingConfig = new NetworkRoutingConfig(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null, null);
            Network response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNetworkRequest request = new GetNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Network expectedResponse = new Network
            {
                Id = 11672635353343658936UL,
                Mtu = 1280318054,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                NetworkFirewallPolicyEnforcementOrder = "network_firewall_policy_enforcement_order54f14f22",
                CreationTimestamp = "creation_timestamp235e59a1",
                SelfLinkWithId = "self_link_with_id6d1e3896",
                IPv4Range = "I_pv4_range613b129f",
                Peerings =
                {
                    new NetworkPeering(),
                },
                GatewayIPv4 = "gateway_i_pv47f9ce361",
                AutoCreateSubnetworks = false,
                InternalIpv6Range = "internal_ipv6_range9d13ac25",
                Subnetworks =
                {
                    "subnetworks81f34af0",
                },
                Description = "description2cf9da67",
                EnableUlaInternalIpv6 = false,
                SelfLink = "self_link7e87f12d",
                RoutingConfig = new NetworkRoutingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Network>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null, null);
            Network responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Network responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNetworkRequest request = new GetNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Network expectedResponse = new Network
            {
                Id = 11672635353343658936UL,
                Mtu = 1280318054,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                NetworkFirewallPolicyEnforcementOrder = "network_firewall_policy_enforcement_order54f14f22",
                CreationTimestamp = "creation_timestamp235e59a1",
                SelfLinkWithId = "self_link_with_id6d1e3896",
                IPv4Range = "I_pv4_range613b129f",
                Peerings =
                {
                    new NetworkPeering(),
                },
                GatewayIPv4 = "gateway_i_pv47f9ce361",
                AutoCreateSubnetworks = false,
                InternalIpv6Range = "internal_ipv6_range9d13ac25",
                Subnetworks =
                {
                    "subnetworks81f34af0",
                },
                Description = "description2cf9da67",
                EnableUlaInternalIpv6 = false,
                SelfLink = "self_link7e87f12d",
                RoutingConfig = new NetworkRoutingConfig(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null, null);
            Network response = client.Get(request.Project, request.Network);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNetworkRequest request = new GetNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Network expectedResponse = new Network
            {
                Id = 11672635353343658936UL,
                Mtu = 1280318054,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                NetworkFirewallPolicyEnforcementOrder = "network_firewall_policy_enforcement_order54f14f22",
                CreationTimestamp = "creation_timestamp235e59a1",
                SelfLinkWithId = "self_link_with_id6d1e3896",
                IPv4Range = "I_pv4_range613b129f",
                Peerings =
                {
                    new NetworkPeering(),
                },
                GatewayIPv4 = "gateway_i_pv47f9ce361",
                AutoCreateSubnetworks = false,
                InternalIpv6Range = "internal_ipv6_range9d13ac25",
                Subnetworks =
                {
                    "subnetworks81f34af0",
                },
                Description = "description2cf9da67",
                EnableUlaInternalIpv6 = false,
                SelfLink = "self_link7e87f12d",
                RoutingConfig = new NetworkRoutingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Network>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null, null);
            Network responseCallSettings = await client.GetAsync(request.Project, request.Network, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Network responseCancellationToken = await client.GetAsync(request.Project, request.Network, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEffectiveFirewallsRequestObject()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEffectiveFirewallsNetworkRequest request = new GetEffectiveFirewallsNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            NetworksGetEffectiveFirewallsResponse expectedResponse = new NetworksGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewalls(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null, null);
            NetworksGetEffectiveFirewallsResponse response = client.GetEffectiveFirewalls(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEffectiveFirewallsRequestObjectAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEffectiveFirewallsNetworkRequest request = new GetEffectiveFirewallsNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            NetworksGetEffectiveFirewallsResponse expectedResponse = new NetworksGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewallsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NetworksGetEffectiveFirewallsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null, null);
            NetworksGetEffectiveFirewallsResponse responseCallSettings = await client.GetEffectiveFirewallsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworksGetEffectiveFirewallsResponse responseCancellationToken = await client.GetEffectiveFirewallsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEffectiveFirewalls()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEffectiveFirewallsNetworkRequest request = new GetEffectiveFirewallsNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            NetworksGetEffectiveFirewallsResponse expectedResponse = new NetworksGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewalls(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null, null);
            NetworksGetEffectiveFirewallsResponse response = client.GetEffectiveFirewalls(request.Project, request.Network);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEffectiveFirewallsAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEffectiveFirewallsNetworkRequest request = new GetEffectiveFirewallsNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            NetworksGetEffectiveFirewallsResponse expectedResponse = new NetworksGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewallsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NetworksGetEffectiveFirewallsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null, null);
            NetworksGetEffectiveFirewallsResponse responseCallSettings = await client.GetEffectiveFirewallsAsync(request.Project, request.Network, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworksGetEffectiveFirewallsResponse responseCancellationToken = await client.GetEffectiveFirewallsAsync(request.Project, request.Network, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
