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

namespace Google.Cloud.BeyondCorp.AppConnections.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAppConnectionsServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetAppConnectionRequestObject()
        {
            moq::Mock<AppConnectionsService.AppConnectionsServiceClient> mockGrpcClient = new moq::Mock<AppConnectionsService.AppConnectionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetAppConnectionRequest request = new GetAppConnectionRequest
            {
                AppConnectionName = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]"),
            };
            AppConnection expectedResponse = new AppConnection
            {
                AppConnectionName = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]"),
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
                Type = AppConnection.Types.Type.TcpProxy,
                ApplicationEndpoint = new AppConnection.Types.ApplicationEndpoint(),
                Connectors =
                {
                    "connectors146cacfa",
                },
                State = AppConnection.Types.State.Unspecified,
                Gateway = new AppConnection.Types.Gateway(),
            };
            mockGrpcClient.Setup(x => x.GetAppConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AppConnectionsServiceClient client = new AppConnectionsServiceClientImpl(mockGrpcClient.Object, null, null);
            AppConnection response = client.GetAppConnection(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAppConnectionRequestObjectAsync()
        {
            moq::Mock<AppConnectionsService.AppConnectionsServiceClient> mockGrpcClient = new moq::Mock<AppConnectionsService.AppConnectionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetAppConnectionRequest request = new GetAppConnectionRequest
            {
                AppConnectionName = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]"),
            };
            AppConnection expectedResponse = new AppConnection
            {
                AppConnectionName = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]"),
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
                Type = AppConnection.Types.Type.TcpProxy,
                ApplicationEndpoint = new AppConnection.Types.ApplicationEndpoint(),
                Connectors =
                {
                    "connectors146cacfa",
                },
                State = AppConnection.Types.State.Unspecified,
                Gateway = new AppConnection.Types.Gateway(),
            };
            mockGrpcClient.Setup(x => x.GetAppConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AppConnection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AppConnectionsServiceClient client = new AppConnectionsServiceClientImpl(mockGrpcClient.Object, null, null);
            AppConnection responseCallSettings = await client.GetAppConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AppConnection responseCancellationToken = await client.GetAppConnectionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAppConnection()
        {
            moq::Mock<AppConnectionsService.AppConnectionsServiceClient> mockGrpcClient = new moq::Mock<AppConnectionsService.AppConnectionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetAppConnectionRequest request = new GetAppConnectionRequest
            {
                AppConnectionName = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]"),
            };
            AppConnection expectedResponse = new AppConnection
            {
                AppConnectionName = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]"),
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
                Type = AppConnection.Types.Type.TcpProxy,
                ApplicationEndpoint = new AppConnection.Types.ApplicationEndpoint(),
                Connectors =
                {
                    "connectors146cacfa",
                },
                State = AppConnection.Types.State.Unspecified,
                Gateway = new AppConnection.Types.Gateway(),
            };
            mockGrpcClient.Setup(x => x.GetAppConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AppConnectionsServiceClient client = new AppConnectionsServiceClientImpl(mockGrpcClient.Object, null, null);
            AppConnection response = client.GetAppConnection(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAppConnectionAsync()
        {
            moq::Mock<AppConnectionsService.AppConnectionsServiceClient> mockGrpcClient = new moq::Mock<AppConnectionsService.AppConnectionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetAppConnectionRequest request = new GetAppConnectionRequest
            {
                AppConnectionName = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]"),
            };
            AppConnection expectedResponse = new AppConnection
            {
                AppConnectionName = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]"),
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
                Type = AppConnection.Types.Type.TcpProxy,
                ApplicationEndpoint = new AppConnection.Types.ApplicationEndpoint(),
                Connectors =
                {
                    "connectors146cacfa",
                },
                State = AppConnection.Types.State.Unspecified,
                Gateway = new AppConnection.Types.Gateway(),
            };
            mockGrpcClient.Setup(x => x.GetAppConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AppConnection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AppConnectionsServiceClient client = new AppConnectionsServiceClientImpl(mockGrpcClient.Object, null, null);
            AppConnection responseCallSettings = await client.GetAppConnectionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AppConnection responseCancellationToken = await client.GetAppConnectionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAppConnectionResourceNames()
        {
            moq::Mock<AppConnectionsService.AppConnectionsServiceClient> mockGrpcClient = new moq::Mock<AppConnectionsService.AppConnectionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetAppConnectionRequest request = new GetAppConnectionRequest
            {
                AppConnectionName = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]"),
            };
            AppConnection expectedResponse = new AppConnection
            {
                AppConnectionName = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]"),
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
                Type = AppConnection.Types.Type.TcpProxy,
                ApplicationEndpoint = new AppConnection.Types.ApplicationEndpoint(),
                Connectors =
                {
                    "connectors146cacfa",
                },
                State = AppConnection.Types.State.Unspecified,
                Gateway = new AppConnection.Types.Gateway(),
            };
            mockGrpcClient.Setup(x => x.GetAppConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AppConnectionsServiceClient client = new AppConnectionsServiceClientImpl(mockGrpcClient.Object, null, null);
            AppConnection response = client.GetAppConnection(request.AppConnectionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAppConnectionResourceNamesAsync()
        {
            moq::Mock<AppConnectionsService.AppConnectionsServiceClient> mockGrpcClient = new moq::Mock<AppConnectionsService.AppConnectionsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetAppConnectionRequest request = new GetAppConnectionRequest
            {
                AppConnectionName = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]"),
            };
            AppConnection expectedResponse = new AppConnection
            {
                AppConnectionName = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]"),
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
                Type = AppConnection.Types.Type.TcpProxy,
                ApplicationEndpoint = new AppConnection.Types.ApplicationEndpoint(),
                Connectors =
                {
                    "connectors146cacfa",
                },
                State = AppConnection.Types.State.Unspecified,
                Gateway = new AppConnection.Types.Gateway(),
            };
            mockGrpcClient.Setup(x => x.GetAppConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AppConnection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AppConnectionsServiceClient client = new AppConnectionsServiceClientImpl(mockGrpcClient.Object, null, null);
            AppConnection responseCallSettings = await client.GetAppConnectionAsync(request.AppConnectionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AppConnection responseCancellationToken = await client.GetAppConnectionAsync(request.AppConnectionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
