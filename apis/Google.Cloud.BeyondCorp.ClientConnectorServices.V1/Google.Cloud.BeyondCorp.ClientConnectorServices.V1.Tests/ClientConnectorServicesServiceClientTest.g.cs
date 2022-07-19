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

namespace Google.Cloud.BeyondCorp.ClientConnectorServices.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedClientConnectorServicesServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetClientConnectorServiceRequestObject()
        {
            moq::Mock<ClientConnectorServicesService.ClientConnectorServicesServiceClient> mockGrpcClient = new moq::Mock<ClientConnectorServicesService.ClientConnectorServicesServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetClientConnectorServiceRequest request = new GetClientConnectorServiceRequest
            {
                ClientConnectorServiceName = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]"),
            };
            ClientConnectorService expectedResponse = new ClientConnectorService
            {
                ClientConnectorServiceName = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Ingress = new ClientConnectorService.Types.Ingress(),
                Egress = new ClientConnectorService.Types.Egress(),
                State = ClientConnectorService.Types.State.Error,
            };
            mockGrpcClient.Setup(x => x.GetClientConnectorService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClientConnectorServicesServiceClient client = new ClientConnectorServicesServiceClientImpl(mockGrpcClient.Object, null, null);
            ClientConnectorService response = client.GetClientConnectorService(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClientConnectorServiceRequestObjectAsync()
        {
            moq::Mock<ClientConnectorServicesService.ClientConnectorServicesServiceClient> mockGrpcClient = new moq::Mock<ClientConnectorServicesService.ClientConnectorServicesServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetClientConnectorServiceRequest request = new GetClientConnectorServiceRequest
            {
                ClientConnectorServiceName = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]"),
            };
            ClientConnectorService expectedResponse = new ClientConnectorService
            {
                ClientConnectorServiceName = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Ingress = new ClientConnectorService.Types.Ingress(),
                Egress = new ClientConnectorService.Types.Egress(),
                State = ClientConnectorService.Types.State.Error,
            };
            mockGrpcClient.Setup(x => x.GetClientConnectorServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ClientConnectorService>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClientConnectorServicesServiceClient client = new ClientConnectorServicesServiceClientImpl(mockGrpcClient.Object, null, null);
            ClientConnectorService responseCallSettings = await client.GetClientConnectorServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ClientConnectorService responseCancellationToken = await client.GetClientConnectorServiceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetClientConnectorService()
        {
            moq::Mock<ClientConnectorServicesService.ClientConnectorServicesServiceClient> mockGrpcClient = new moq::Mock<ClientConnectorServicesService.ClientConnectorServicesServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetClientConnectorServiceRequest request = new GetClientConnectorServiceRequest
            {
                ClientConnectorServiceName = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]"),
            };
            ClientConnectorService expectedResponse = new ClientConnectorService
            {
                ClientConnectorServiceName = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Ingress = new ClientConnectorService.Types.Ingress(),
                Egress = new ClientConnectorService.Types.Egress(),
                State = ClientConnectorService.Types.State.Error,
            };
            mockGrpcClient.Setup(x => x.GetClientConnectorService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClientConnectorServicesServiceClient client = new ClientConnectorServicesServiceClientImpl(mockGrpcClient.Object, null, null);
            ClientConnectorService response = client.GetClientConnectorService(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClientConnectorServiceAsync()
        {
            moq::Mock<ClientConnectorServicesService.ClientConnectorServicesServiceClient> mockGrpcClient = new moq::Mock<ClientConnectorServicesService.ClientConnectorServicesServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetClientConnectorServiceRequest request = new GetClientConnectorServiceRequest
            {
                ClientConnectorServiceName = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]"),
            };
            ClientConnectorService expectedResponse = new ClientConnectorService
            {
                ClientConnectorServiceName = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Ingress = new ClientConnectorService.Types.Ingress(),
                Egress = new ClientConnectorService.Types.Egress(),
                State = ClientConnectorService.Types.State.Error,
            };
            mockGrpcClient.Setup(x => x.GetClientConnectorServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ClientConnectorService>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClientConnectorServicesServiceClient client = new ClientConnectorServicesServiceClientImpl(mockGrpcClient.Object, null, null);
            ClientConnectorService responseCallSettings = await client.GetClientConnectorServiceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ClientConnectorService responseCancellationToken = await client.GetClientConnectorServiceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetClientConnectorServiceResourceNames()
        {
            moq::Mock<ClientConnectorServicesService.ClientConnectorServicesServiceClient> mockGrpcClient = new moq::Mock<ClientConnectorServicesService.ClientConnectorServicesServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetClientConnectorServiceRequest request = new GetClientConnectorServiceRequest
            {
                ClientConnectorServiceName = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]"),
            };
            ClientConnectorService expectedResponse = new ClientConnectorService
            {
                ClientConnectorServiceName = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Ingress = new ClientConnectorService.Types.Ingress(),
                Egress = new ClientConnectorService.Types.Egress(),
                State = ClientConnectorService.Types.State.Error,
            };
            mockGrpcClient.Setup(x => x.GetClientConnectorService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClientConnectorServicesServiceClient client = new ClientConnectorServicesServiceClientImpl(mockGrpcClient.Object, null, null);
            ClientConnectorService response = client.GetClientConnectorService(request.ClientConnectorServiceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClientConnectorServiceResourceNamesAsync()
        {
            moq::Mock<ClientConnectorServicesService.ClientConnectorServicesServiceClient> mockGrpcClient = new moq::Mock<ClientConnectorServicesService.ClientConnectorServicesServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetClientConnectorServiceRequest request = new GetClientConnectorServiceRequest
            {
                ClientConnectorServiceName = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]"),
            };
            ClientConnectorService expectedResponse = new ClientConnectorService
            {
                ClientConnectorServiceName = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Ingress = new ClientConnectorService.Types.Ingress(),
                Egress = new ClientConnectorService.Types.Egress(),
                State = ClientConnectorService.Types.State.Error,
            };
            mockGrpcClient.Setup(x => x.GetClientConnectorServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ClientConnectorService>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClientConnectorServicesServiceClient client = new ClientConnectorServicesServiceClientImpl(mockGrpcClient.Object, null, null);
            ClientConnectorService responseCallSettings = await client.GetClientConnectorServiceAsync(request.ClientConnectorServiceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ClientConnectorService responseCancellationToken = await client.GetClientConnectorServiceAsync(request.ClientConnectorServiceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
