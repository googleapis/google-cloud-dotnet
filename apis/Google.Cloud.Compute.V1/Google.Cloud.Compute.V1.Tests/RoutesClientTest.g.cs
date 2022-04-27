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
    public sealed class GeneratedRoutesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<Routes.RoutesClient> mockGrpcClient = new moq::Mock<Routes.RoutesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRouteRequest request = new GetRouteRequest
            {
                Route = "route8a40469c",
                Project = "projectaa6ff846",
            };
            Route expectedResponse = new Route
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Tags = { "tags52c47ad5", },
                CreationTimestamp = "creation_timestamp235e59a1",
                NextHopIp = "next_hop_ipa30be6cf",
                AsPaths = { new RouteAsPath(), },
                NextHopIlb = "next_hop_ilbbb4605ad",
                Network = "networkd22ce091",
                NextHopNetwork = "next_hop_networkec878a41",
                RouteType = "route_typea84cf3b2",
                NextHopGateway = "next_hop_gateway86a0bbe5",
                DestRange = "dest_range56ada943",
                NextHopInstance = "next_hop_instance57e80635",
                NextHopPeering = "next_hop_peering2cca5109",
                RouteStatus = "route_status48e2b140",
                Description = "description2cf9da67",
                Priority = 1546225849U,
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
                NextHopVpnTunnel = "next_hop_vpn_tunnela5f8e0c5",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RoutesClient client = new RoutesClientImpl(mockGrpcClient.Object, null, null);
            Route response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<Routes.RoutesClient> mockGrpcClient = new moq::Mock<Routes.RoutesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRouteRequest request = new GetRouteRequest
            {
                Route = "route8a40469c",
                Project = "projectaa6ff846",
            };
            Route expectedResponse = new Route
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Tags = { "tags52c47ad5", },
                CreationTimestamp = "creation_timestamp235e59a1",
                NextHopIp = "next_hop_ipa30be6cf",
                AsPaths = { new RouteAsPath(), },
                NextHopIlb = "next_hop_ilbbb4605ad",
                Network = "networkd22ce091",
                NextHopNetwork = "next_hop_networkec878a41",
                RouteType = "route_typea84cf3b2",
                NextHopGateway = "next_hop_gateway86a0bbe5",
                DestRange = "dest_range56ada943",
                NextHopInstance = "next_hop_instance57e80635",
                NextHopPeering = "next_hop_peering2cca5109",
                RouteStatus = "route_status48e2b140",
                Description = "description2cf9da67",
                Priority = 1546225849U,
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
                NextHopVpnTunnel = "next_hop_vpn_tunnela5f8e0c5",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Route>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RoutesClient client = new RoutesClientImpl(mockGrpcClient.Object, null, null);
            Route responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Route responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<Routes.RoutesClient> mockGrpcClient = new moq::Mock<Routes.RoutesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRouteRequest request = new GetRouteRequest
            {
                Route = "route8a40469c",
                Project = "projectaa6ff846",
            };
            Route expectedResponse = new Route
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Tags = { "tags52c47ad5", },
                CreationTimestamp = "creation_timestamp235e59a1",
                NextHopIp = "next_hop_ipa30be6cf",
                AsPaths = { new RouteAsPath(), },
                NextHopIlb = "next_hop_ilbbb4605ad",
                Network = "networkd22ce091",
                NextHopNetwork = "next_hop_networkec878a41",
                RouteType = "route_typea84cf3b2",
                NextHopGateway = "next_hop_gateway86a0bbe5",
                DestRange = "dest_range56ada943",
                NextHopInstance = "next_hop_instance57e80635",
                NextHopPeering = "next_hop_peering2cca5109",
                RouteStatus = "route_status48e2b140",
                Description = "description2cf9da67",
                Priority = 1546225849U,
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
                NextHopVpnTunnel = "next_hop_vpn_tunnela5f8e0c5",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RoutesClient client = new RoutesClientImpl(mockGrpcClient.Object, null, null);
            Route response = client.Get(request.Project, request.Route);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<Routes.RoutesClient> mockGrpcClient = new moq::Mock<Routes.RoutesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRouteRequest request = new GetRouteRequest
            {
                Route = "route8a40469c",
                Project = "projectaa6ff846",
            };
            Route expectedResponse = new Route
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Tags = { "tags52c47ad5", },
                CreationTimestamp = "creation_timestamp235e59a1",
                NextHopIp = "next_hop_ipa30be6cf",
                AsPaths = { new RouteAsPath(), },
                NextHopIlb = "next_hop_ilbbb4605ad",
                Network = "networkd22ce091",
                NextHopNetwork = "next_hop_networkec878a41",
                RouteType = "route_typea84cf3b2",
                NextHopGateway = "next_hop_gateway86a0bbe5",
                DestRange = "dest_range56ada943",
                NextHopInstance = "next_hop_instance57e80635",
                NextHopPeering = "next_hop_peering2cca5109",
                RouteStatus = "route_status48e2b140",
                Description = "description2cf9da67",
                Priority = 1546225849U,
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
                NextHopVpnTunnel = "next_hop_vpn_tunnela5f8e0c5",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Route>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RoutesClient client = new RoutesClientImpl(mockGrpcClient.Object, null, null);
            Route responseCallSettings = await client.GetAsync(request.Project, request.Route, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Route responseCancellationToken = await client.GetAsync(request.Project, request.Route, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
