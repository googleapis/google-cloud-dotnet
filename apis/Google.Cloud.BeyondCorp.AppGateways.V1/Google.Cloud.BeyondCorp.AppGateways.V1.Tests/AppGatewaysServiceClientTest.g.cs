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

namespace Google.Cloud.BeyondCorp.AppGateways.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAppGatewaysServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetAppGatewayRequestObject()
        {
            moq::Mock<AppGatewaysService.AppGatewaysServiceClient> mockGrpcClient = new moq::Mock<AppGatewaysService.AppGatewaysServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetAppGatewayRequest request = new GetAppGatewayRequest
            {
                AppGatewayName = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]"),
            };
            AppGateway expectedResponse = new AppGateway
            {
                AppGatewayName = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
                Type = AppGateway.Types.Type.TcpProxy,
                State = AppGateway.Types.State.Unspecified,
                Uri = "uri3db70593",
                AllocatedConnections =
                {
                    new AppGateway.Types.AllocatedConnection(),
                },
                HostType = AppGateway.Types.HostType.GcpRegionalMig,
            };
            mockGrpcClient.Setup(x => x.GetAppGateway(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AppGatewaysServiceClient client = new AppGatewaysServiceClientImpl(mockGrpcClient.Object, null, null);
            AppGateway response = client.GetAppGateway(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAppGatewayRequestObjectAsync()
        {
            moq::Mock<AppGatewaysService.AppGatewaysServiceClient> mockGrpcClient = new moq::Mock<AppGatewaysService.AppGatewaysServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetAppGatewayRequest request = new GetAppGatewayRequest
            {
                AppGatewayName = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]"),
            };
            AppGateway expectedResponse = new AppGateway
            {
                AppGatewayName = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
                Type = AppGateway.Types.Type.TcpProxy,
                State = AppGateway.Types.State.Unspecified,
                Uri = "uri3db70593",
                AllocatedConnections =
                {
                    new AppGateway.Types.AllocatedConnection(),
                },
                HostType = AppGateway.Types.HostType.GcpRegionalMig,
            };
            mockGrpcClient.Setup(x => x.GetAppGatewayAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AppGateway>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AppGatewaysServiceClient client = new AppGatewaysServiceClientImpl(mockGrpcClient.Object, null, null);
            AppGateway responseCallSettings = await client.GetAppGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AppGateway responseCancellationToken = await client.GetAppGatewayAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAppGateway()
        {
            moq::Mock<AppGatewaysService.AppGatewaysServiceClient> mockGrpcClient = new moq::Mock<AppGatewaysService.AppGatewaysServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetAppGatewayRequest request = new GetAppGatewayRequest
            {
                AppGatewayName = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]"),
            };
            AppGateway expectedResponse = new AppGateway
            {
                AppGatewayName = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
                Type = AppGateway.Types.Type.TcpProxy,
                State = AppGateway.Types.State.Unspecified,
                Uri = "uri3db70593",
                AllocatedConnections =
                {
                    new AppGateway.Types.AllocatedConnection(),
                },
                HostType = AppGateway.Types.HostType.GcpRegionalMig,
            };
            mockGrpcClient.Setup(x => x.GetAppGateway(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AppGatewaysServiceClient client = new AppGatewaysServiceClientImpl(mockGrpcClient.Object, null, null);
            AppGateway response = client.GetAppGateway(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAppGatewayAsync()
        {
            moq::Mock<AppGatewaysService.AppGatewaysServiceClient> mockGrpcClient = new moq::Mock<AppGatewaysService.AppGatewaysServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetAppGatewayRequest request = new GetAppGatewayRequest
            {
                AppGatewayName = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]"),
            };
            AppGateway expectedResponse = new AppGateway
            {
                AppGatewayName = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
                Type = AppGateway.Types.Type.TcpProxy,
                State = AppGateway.Types.State.Unspecified,
                Uri = "uri3db70593",
                AllocatedConnections =
                {
                    new AppGateway.Types.AllocatedConnection(),
                },
                HostType = AppGateway.Types.HostType.GcpRegionalMig,
            };
            mockGrpcClient.Setup(x => x.GetAppGatewayAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AppGateway>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AppGatewaysServiceClient client = new AppGatewaysServiceClientImpl(mockGrpcClient.Object, null, null);
            AppGateway responseCallSettings = await client.GetAppGatewayAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AppGateway responseCancellationToken = await client.GetAppGatewayAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAppGatewayResourceNames()
        {
            moq::Mock<AppGatewaysService.AppGatewaysServiceClient> mockGrpcClient = new moq::Mock<AppGatewaysService.AppGatewaysServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetAppGatewayRequest request = new GetAppGatewayRequest
            {
                AppGatewayName = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]"),
            };
            AppGateway expectedResponse = new AppGateway
            {
                AppGatewayName = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
                Type = AppGateway.Types.Type.TcpProxy,
                State = AppGateway.Types.State.Unspecified,
                Uri = "uri3db70593",
                AllocatedConnections =
                {
                    new AppGateway.Types.AllocatedConnection(),
                },
                HostType = AppGateway.Types.HostType.GcpRegionalMig,
            };
            mockGrpcClient.Setup(x => x.GetAppGateway(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AppGatewaysServiceClient client = new AppGatewaysServiceClientImpl(mockGrpcClient.Object, null, null);
            AppGateway response = client.GetAppGateway(request.AppGatewayName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAppGatewayResourceNamesAsync()
        {
            moq::Mock<AppGatewaysService.AppGatewaysServiceClient> mockGrpcClient = new moq::Mock<AppGatewaysService.AppGatewaysServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetAppGatewayRequest request = new GetAppGatewayRequest
            {
                AppGatewayName = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]"),
            };
            AppGateway expectedResponse = new AppGateway
            {
                AppGatewayName = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
                Type = AppGateway.Types.Type.TcpProxy,
                State = AppGateway.Types.State.Unspecified,
                Uri = "uri3db70593",
                AllocatedConnections =
                {
                    new AppGateway.Types.AllocatedConnection(),
                },
                HostType = AppGateway.Types.HostType.GcpRegionalMig,
            };
            mockGrpcClient.Setup(x => x.GetAppGatewayAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AppGateway>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AppGatewaysServiceClient client = new AppGatewaysServiceClientImpl(mockGrpcClient.Object, null, null);
            AppGateway responseCallSettings = await client.GetAppGatewayAsync(request.AppGatewayName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AppGateway responseCancellationToken = await client.GetAppGatewayAsync(request.AppGatewayName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
