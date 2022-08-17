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

namespace Google.Cloud.BeyondCorp.ClientGateways.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedClientGatewaysServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetClientGatewayRequestObject()
        {
            moq::Mock<ClientGatewaysService.ClientGatewaysServiceClient> mockGrpcClient = new moq::Mock<ClientGatewaysService.ClientGatewaysServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetClientGatewayRequest request = new GetClientGatewayRequest
            {
                ClientGatewayName = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]"),
            };
            ClientGateway expectedResponse = new ClientGateway
            {
                ClientGatewayName = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = ClientGateway.Types.State.Error,
                Id = "id74b70bb8",
                ClientConnectorService = "client_connector_servicea0476da6",
            };
            mockGrpcClient.Setup(x => x.GetClientGateway(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClientGatewaysServiceClient client = new ClientGatewaysServiceClientImpl(mockGrpcClient.Object, null, null);
            ClientGateway response = client.GetClientGateway(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClientGatewayRequestObjectAsync()
        {
            moq::Mock<ClientGatewaysService.ClientGatewaysServiceClient> mockGrpcClient = new moq::Mock<ClientGatewaysService.ClientGatewaysServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetClientGatewayRequest request = new GetClientGatewayRequest
            {
                ClientGatewayName = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]"),
            };
            ClientGateway expectedResponse = new ClientGateway
            {
                ClientGatewayName = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = ClientGateway.Types.State.Error,
                Id = "id74b70bb8",
                ClientConnectorService = "client_connector_servicea0476da6",
            };
            mockGrpcClient.Setup(x => x.GetClientGatewayAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ClientGateway>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClientGatewaysServiceClient client = new ClientGatewaysServiceClientImpl(mockGrpcClient.Object, null, null);
            ClientGateway responseCallSettings = await client.GetClientGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ClientGateway responseCancellationToken = await client.GetClientGatewayAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetClientGateway()
        {
            moq::Mock<ClientGatewaysService.ClientGatewaysServiceClient> mockGrpcClient = new moq::Mock<ClientGatewaysService.ClientGatewaysServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetClientGatewayRequest request = new GetClientGatewayRequest
            {
                ClientGatewayName = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]"),
            };
            ClientGateway expectedResponse = new ClientGateway
            {
                ClientGatewayName = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = ClientGateway.Types.State.Error,
                Id = "id74b70bb8",
                ClientConnectorService = "client_connector_servicea0476da6",
            };
            mockGrpcClient.Setup(x => x.GetClientGateway(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClientGatewaysServiceClient client = new ClientGatewaysServiceClientImpl(mockGrpcClient.Object, null, null);
            ClientGateway response = client.GetClientGateway(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClientGatewayAsync()
        {
            moq::Mock<ClientGatewaysService.ClientGatewaysServiceClient> mockGrpcClient = new moq::Mock<ClientGatewaysService.ClientGatewaysServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetClientGatewayRequest request = new GetClientGatewayRequest
            {
                ClientGatewayName = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]"),
            };
            ClientGateway expectedResponse = new ClientGateway
            {
                ClientGatewayName = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = ClientGateway.Types.State.Error,
                Id = "id74b70bb8",
                ClientConnectorService = "client_connector_servicea0476da6",
            };
            mockGrpcClient.Setup(x => x.GetClientGatewayAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ClientGateway>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClientGatewaysServiceClient client = new ClientGatewaysServiceClientImpl(mockGrpcClient.Object, null, null);
            ClientGateway responseCallSettings = await client.GetClientGatewayAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ClientGateway responseCancellationToken = await client.GetClientGatewayAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetClientGatewayResourceNames()
        {
            moq::Mock<ClientGatewaysService.ClientGatewaysServiceClient> mockGrpcClient = new moq::Mock<ClientGatewaysService.ClientGatewaysServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetClientGatewayRequest request = new GetClientGatewayRequest
            {
                ClientGatewayName = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]"),
            };
            ClientGateway expectedResponse = new ClientGateway
            {
                ClientGatewayName = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = ClientGateway.Types.State.Error,
                Id = "id74b70bb8",
                ClientConnectorService = "client_connector_servicea0476da6",
            };
            mockGrpcClient.Setup(x => x.GetClientGateway(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClientGatewaysServiceClient client = new ClientGatewaysServiceClientImpl(mockGrpcClient.Object, null, null);
            ClientGateway response = client.GetClientGateway(request.ClientGatewayName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClientGatewayResourceNamesAsync()
        {
            moq::Mock<ClientGatewaysService.ClientGatewaysServiceClient> mockGrpcClient = new moq::Mock<ClientGatewaysService.ClientGatewaysServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetClientGatewayRequest request = new GetClientGatewayRequest
            {
                ClientGatewayName = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]"),
            };
            ClientGateway expectedResponse = new ClientGateway
            {
                ClientGatewayName = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = ClientGateway.Types.State.Error,
                Id = "id74b70bb8",
                ClientConnectorService = "client_connector_servicea0476da6",
            };
            mockGrpcClient.Setup(x => x.GetClientGatewayAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ClientGateway>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClientGatewaysServiceClient client = new ClientGatewaysServiceClientImpl(mockGrpcClient.Object, null, null);
            ClientGateway responseCallSettings = await client.GetClientGatewayAsync(request.ClientGatewayName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ClientGateway responseCancellationToken = await client.GetClientGatewayAsync(request.ClientGatewayName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
