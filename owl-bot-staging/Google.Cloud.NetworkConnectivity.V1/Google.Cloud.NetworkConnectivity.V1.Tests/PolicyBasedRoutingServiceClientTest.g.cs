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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
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
    public sealed class GeneratedPolicyBasedRoutingServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetPolicyBasedRouteRequestObject()
        {
            moq::Mock<PolicyBasedRoutingService.PolicyBasedRoutingServiceClient> mockGrpcClient = new moq::Mock<PolicyBasedRoutingService.PolicyBasedRoutingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetPolicyBasedRouteRequest request = new GetPolicyBasedRouteRequest
            {
                PolicyBasedRouteName = PolicyBasedRouteName.FromProjectLocationPolicyBasedRoute("[PROJECT]", "[LOCATION]", "[POLICY_BASED_ROUTE]"),
            };
            PolicyBasedRoute expectedResponse = new PolicyBasedRoute
            {
                PolicyBasedRouteName = PolicyBasedRouteName.FromProjectLocationPolicyBasedRoute("[PROJECT]", "[LOCATION]", "[POLICY_BASED_ROUTE]"),
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
                NetworkAsNetworkName = NetworkName.FromProjectResource("[PROJECT]", "[RESOURCE_ID]"),
                InterconnectAttachment = new PolicyBasedRoute.Types.InterconnectAttachment(),
                Filter = new PolicyBasedRoute.Types.Filter(),
                Priority = 1546225849,
                NextHopIlbIp = "next_hop_ilb_ip033e9d34",
                Warnings =
                {
                    new PolicyBasedRoute.Types.Warnings(),
                },
                SelfLink = "self_link7e87f12d",
                Kind = "kindf7aa39d9",
                VirtualMachine = new PolicyBasedRoute.Types.VirtualMachine(),
            };
            mockGrpcClient.Setup(x => x.GetPolicyBasedRoute(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyBasedRoutingServiceClient client = new PolicyBasedRoutingServiceClientImpl(mockGrpcClient.Object, null, null);
            PolicyBasedRoute response = client.GetPolicyBasedRoute(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPolicyBasedRouteRequestObjectAsync()
        {
            moq::Mock<PolicyBasedRoutingService.PolicyBasedRoutingServiceClient> mockGrpcClient = new moq::Mock<PolicyBasedRoutingService.PolicyBasedRoutingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetPolicyBasedRouteRequest request = new GetPolicyBasedRouteRequest
            {
                PolicyBasedRouteName = PolicyBasedRouteName.FromProjectLocationPolicyBasedRoute("[PROJECT]", "[LOCATION]", "[POLICY_BASED_ROUTE]"),
            };
            PolicyBasedRoute expectedResponse = new PolicyBasedRoute
            {
                PolicyBasedRouteName = PolicyBasedRouteName.FromProjectLocationPolicyBasedRoute("[PROJECT]", "[LOCATION]", "[POLICY_BASED_ROUTE]"),
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
                NetworkAsNetworkName = NetworkName.FromProjectResource("[PROJECT]", "[RESOURCE_ID]"),
                InterconnectAttachment = new PolicyBasedRoute.Types.InterconnectAttachment(),
                Filter = new PolicyBasedRoute.Types.Filter(),
                Priority = 1546225849,
                NextHopIlbIp = "next_hop_ilb_ip033e9d34",
                Warnings =
                {
                    new PolicyBasedRoute.Types.Warnings(),
                },
                SelfLink = "self_link7e87f12d",
                Kind = "kindf7aa39d9",
                VirtualMachine = new PolicyBasedRoute.Types.VirtualMachine(),
            };
            mockGrpcClient.Setup(x => x.GetPolicyBasedRouteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PolicyBasedRoute>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyBasedRoutingServiceClient client = new PolicyBasedRoutingServiceClientImpl(mockGrpcClient.Object, null, null);
            PolicyBasedRoute responseCallSettings = await client.GetPolicyBasedRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PolicyBasedRoute responseCancellationToken = await client.GetPolicyBasedRouteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPolicyBasedRoute()
        {
            moq::Mock<PolicyBasedRoutingService.PolicyBasedRoutingServiceClient> mockGrpcClient = new moq::Mock<PolicyBasedRoutingService.PolicyBasedRoutingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetPolicyBasedRouteRequest request = new GetPolicyBasedRouteRequest
            {
                PolicyBasedRouteName = PolicyBasedRouteName.FromProjectLocationPolicyBasedRoute("[PROJECT]", "[LOCATION]", "[POLICY_BASED_ROUTE]"),
            };
            PolicyBasedRoute expectedResponse = new PolicyBasedRoute
            {
                PolicyBasedRouteName = PolicyBasedRouteName.FromProjectLocationPolicyBasedRoute("[PROJECT]", "[LOCATION]", "[POLICY_BASED_ROUTE]"),
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
                NetworkAsNetworkName = NetworkName.FromProjectResource("[PROJECT]", "[RESOURCE_ID]"),
                InterconnectAttachment = new PolicyBasedRoute.Types.InterconnectAttachment(),
                Filter = new PolicyBasedRoute.Types.Filter(),
                Priority = 1546225849,
                NextHopIlbIp = "next_hop_ilb_ip033e9d34",
                Warnings =
                {
                    new PolicyBasedRoute.Types.Warnings(),
                },
                SelfLink = "self_link7e87f12d",
                Kind = "kindf7aa39d9",
                VirtualMachine = new PolicyBasedRoute.Types.VirtualMachine(),
            };
            mockGrpcClient.Setup(x => x.GetPolicyBasedRoute(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyBasedRoutingServiceClient client = new PolicyBasedRoutingServiceClientImpl(mockGrpcClient.Object, null, null);
            PolicyBasedRoute response = client.GetPolicyBasedRoute(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPolicyBasedRouteAsync()
        {
            moq::Mock<PolicyBasedRoutingService.PolicyBasedRoutingServiceClient> mockGrpcClient = new moq::Mock<PolicyBasedRoutingService.PolicyBasedRoutingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetPolicyBasedRouteRequest request = new GetPolicyBasedRouteRequest
            {
                PolicyBasedRouteName = PolicyBasedRouteName.FromProjectLocationPolicyBasedRoute("[PROJECT]", "[LOCATION]", "[POLICY_BASED_ROUTE]"),
            };
            PolicyBasedRoute expectedResponse = new PolicyBasedRoute
            {
                PolicyBasedRouteName = PolicyBasedRouteName.FromProjectLocationPolicyBasedRoute("[PROJECT]", "[LOCATION]", "[POLICY_BASED_ROUTE]"),
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
                NetworkAsNetworkName = NetworkName.FromProjectResource("[PROJECT]", "[RESOURCE_ID]"),
                InterconnectAttachment = new PolicyBasedRoute.Types.InterconnectAttachment(),
                Filter = new PolicyBasedRoute.Types.Filter(),
                Priority = 1546225849,
                NextHopIlbIp = "next_hop_ilb_ip033e9d34",
                Warnings =
                {
                    new PolicyBasedRoute.Types.Warnings(),
                },
                SelfLink = "self_link7e87f12d",
                Kind = "kindf7aa39d9",
                VirtualMachine = new PolicyBasedRoute.Types.VirtualMachine(),
            };
            mockGrpcClient.Setup(x => x.GetPolicyBasedRouteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PolicyBasedRoute>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyBasedRoutingServiceClient client = new PolicyBasedRoutingServiceClientImpl(mockGrpcClient.Object, null, null);
            PolicyBasedRoute responseCallSettings = await client.GetPolicyBasedRouteAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PolicyBasedRoute responseCancellationToken = await client.GetPolicyBasedRouteAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPolicyBasedRouteResourceNames()
        {
            moq::Mock<PolicyBasedRoutingService.PolicyBasedRoutingServiceClient> mockGrpcClient = new moq::Mock<PolicyBasedRoutingService.PolicyBasedRoutingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetPolicyBasedRouteRequest request = new GetPolicyBasedRouteRequest
            {
                PolicyBasedRouteName = PolicyBasedRouteName.FromProjectLocationPolicyBasedRoute("[PROJECT]", "[LOCATION]", "[POLICY_BASED_ROUTE]"),
            };
            PolicyBasedRoute expectedResponse = new PolicyBasedRoute
            {
                PolicyBasedRouteName = PolicyBasedRouteName.FromProjectLocationPolicyBasedRoute("[PROJECT]", "[LOCATION]", "[POLICY_BASED_ROUTE]"),
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
                NetworkAsNetworkName = NetworkName.FromProjectResource("[PROJECT]", "[RESOURCE_ID]"),
                InterconnectAttachment = new PolicyBasedRoute.Types.InterconnectAttachment(),
                Filter = new PolicyBasedRoute.Types.Filter(),
                Priority = 1546225849,
                NextHopIlbIp = "next_hop_ilb_ip033e9d34",
                Warnings =
                {
                    new PolicyBasedRoute.Types.Warnings(),
                },
                SelfLink = "self_link7e87f12d",
                Kind = "kindf7aa39d9",
                VirtualMachine = new PolicyBasedRoute.Types.VirtualMachine(),
            };
            mockGrpcClient.Setup(x => x.GetPolicyBasedRoute(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyBasedRoutingServiceClient client = new PolicyBasedRoutingServiceClientImpl(mockGrpcClient.Object, null, null);
            PolicyBasedRoute response = client.GetPolicyBasedRoute(request.PolicyBasedRouteName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPolicyBasedRouteResourceNamesAsync()
        {
            moq::Mock<PolicyBasedRoutingService.PolicyBasedRoutingServiceClient> mockGrpcClient = new moq::Mock<PolicyBasedRoutingService.PolicyBasedRoutingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetPolicyBasedRouteRequest request = new GetPolicyBasedRouteRequest
            {
                PolicyBasedRouteName = PolicyBasedRouteName.FromProjectLocationPolicyBasedRoute("[PROJECT]", "[LOCATION]", "[POLICY_BASED_ROUTE]"),
            };
            PolicyBasedRoute expectedResponse = new PolicyBasedRoute
            {
                PolicyBasedRouteName = PolicyBasedRouteName.FromProjectLocationPolicyBasedRoute("[PROJECT]", "[LOCATION]", "[POLICY_BASED_ROUTE]"),
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
                NetworkAsNetworkName = NetworkName.FromProjectResource("[PROJECT]", "[RESOURCE_ID]"),
                InterconnectAttachment = new PolicyBasedRoute.Types.InterconnectAttachment(),
                Filter = new PolicyBasedRoute.Types.Filter(),
                Priority = 1546225849,
                NextHopIlbIp = "next_hop_ilb_ip033e9d34",
                Warnings =
                {
                    new PolicyBasedRoute.Types.Warnings(),
                },
                SelfLink = "self_link7e87f12d",
                Kind = "kindf7aa39d9",
                VirtualMachine = new PolicyBasedRoute.Types.VirtualMachine(),
            };
            mockGrpcClient.Setup(x => x.GetPolicyBasedRouteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PolicyBasedRoute>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyBasedRoutingServiceClient client = new PolicyBasedRoutingServiceClientImpl(mockGrpcClient.Object, null, null);
            PolicyBasedRoute responseCallSettings = await client.GetPolicyBasedRouteAsync(request.PolicyBasedRouteName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PolicyBasedRoute responseCancellationToken = await client.GetPolicyBasedRouteAsync(request.PolicyBasedRouteName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
