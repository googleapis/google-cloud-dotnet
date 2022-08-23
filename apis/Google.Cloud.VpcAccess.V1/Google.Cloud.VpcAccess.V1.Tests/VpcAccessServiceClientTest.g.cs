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
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.VpcAccess.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedVpcAccessServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetConnectorRequestObject()
        {
            moq::Mock<VpcAccessService.VpcAccessServiceClient> mockGrpcClient = new moq::Mock<VpcAccessService.VpcAccessServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetConnectorRequest request = new GetConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]"),
            };
            Connector expectedResponse = new Connector
            {
                ConnectorName = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]"),
                Network = "networkd22ce091",
                IpCidrRange = "ip_cidr_range745a04d3",
                State = Connector.Types.State.Unspecified,
                MinThroughput = -1306078102,
                MaxThroughput = 1609945563,
                ConnectedProjects =
                {
                    "connected_projects7e2fb014",
                },
                Subnet = new Connector.Types.Subnet(),
                MachineType = "machine_type68ce40fa",
                MinInstances = 445814344,
                MaxInstances = -1449803711,
            };
            mockGrpcClient.Setup(x => x.GetConnector(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpcAccessServiceClient client = new VpcAccessServiceClientImpl(mockGrpcClient.Object, null, null);
            Connector response = client.GetConnector(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConnectorRequestObjectAsync()
        {
            moq::Mock<VpcAccessService.VpcAccessServiceClient> mockGrpcClient = new moq::Mock<VpcAccessService.VpcAccessServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetConnectorRequest request = new GetConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]"),
            };
            Connector expectedResponse = new Connector
            {
                ConnectorName = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]"),
                Network = "networkd22ce091",
                IpCidrRange = "ip_cidr_range745a04d3",
                State = Connector.Types.State.Unspecified,
                MinThroughput = -1306078102,
                MaxThroughput = 1609945563,
                ConnectedProjects =
                {
                    "connected_projects7e2fb014",
                },
                Subnet = new Connector.Types.Subnet(),
                MachineType = "machine_type68ce40fa",
                MinInstances = 445814344,
                MaxInstances = -1449803711,
            };
            mockGrpcClient.Setup(x => x.GetConnectorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Connector>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpcAccessServiceClient client = new VpcAccessServiceClientImpl(mockGrpcClient.Object, null, null);
            Connector responseCallSettings = await client.GetConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Connector responseCancellationToken = await client.GetConnectorAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConnector()
        {
            moq::Mock<VpcAccessService.VpcAccessServiceClient> mockGrpcClient = new moq::Mock<VpcAccessService.VpcAccessServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetConnectorRequest request = new GetConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]"),
            };
            Connector expectedResponse = new Connector
            {
                ConnectorName = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]"),
                Network = "networkd22ce091",
                IpCidrRange = "ip_cidr_range745a04d3",
                State = Connector.Types.State.Unspecified,
                MinThroughput = -1306078102,
                MaxThroughput = 1609945563,
                ConnectedProjects =
                {
                    "connected_projects7e2fb014",
                },
                Subnet = new Connector.Types.Subnet(),
                MachineType = "machine_type68ce40fa",
                MinInstances = 445814344,
                MaxInstances = -1449803711,
            };
            mockGrpcClient.Setup(x => x.GetConnector(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpcAccessServiceClient client = new VpcAccessServiceClientImpl(mockGrpcClient.Object, null, null);
            Connector response = client.GetConnector(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConnectorAsync()
        {
            moq::Mock<VpcAccessService.VpcAccessServiceClient> mockGrpcClient = new moq::Mock<VpcAccessService.VpcAccessServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetConnectorRequest request = new GetConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]"),
            };
            Connector expectedResponse = new Connector
            {
                ConnectorName = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]"),
                Network = "networkd22ce091",
                IpCidrRange = "ip_cidr_range745a04d3",
                State = Connector.Types.State.Unspecified,
                MinThroughput = -1306078102,
                MaxThroughput = 1609945563,
                ConnectedProjects =
                {
                    "connected_projects7e2fb014",
                },
                Subnet = new Connector.Types.Subnet(),
                MachineType = "machine_type68ce40fa",
                MinInstances = 445814344,
                MaxInstances = -1449803711,
            };
            mockGrpcClient.Setup(x => x.GetConnectorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Connector>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpcAccessServiceClient client = new VpcAccessServiceClientImpl(mockGrpcClient.Object, null, null);
            Connector responseCallSettings = await client.GetConnectorAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Connector responseCancellationToken = await client.GetConnectorAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConnectorResourceNames()
        {
            moq::Mock<VpcAccessService.VpcAccessServiceClient> mockGrpcClient = new moq::Mock<VpcAccessService.VpcAccessServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetConnectorRequest request = new GetConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]"),
            };
            Connector expectedResponse = new Connector
            {
                ConnectorName = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]"),
                Network = "networkd22ce091",
                IpCidrRange = "ip_cidr_range745a04d3",
                State = Connector.Types.State.Unspecified,
                MinThroughput = -1306078102,
                MaxThroughput = 1609945563,
                ConnectedProjects =
                {
                    "connected_projects7e2fb014",
                },
                Subnet = new Connector.Types.Subnet(),
                MachineType = "machine_type68ce40fa",
                MinInstances = 445814344,
                MaxInstances = -1449803711,
            };
            mockGrpcClient.Setup(x => x.GetConnector(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpcAccessServiceClient client = new VpcAccessServiceClientImpl(mockGrpcClient.Object, null, null);
            Connector response = client.GetConnector(request.ConnectorName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConnectorResourceNamesAsync()
        {
            moq::Mock<VpcAccessService.VpcAccessServiceClient> mockGrpcClient = new moq::Mock<VpcAccessService.VpcAccessServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetConnectorRequest request = new GetConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]"),
            };
            Connector expectedResponse = new Connector
            {
                ConnectorName = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]"),
                Network = "networkd22ce091",
                IpCidrRange = "ip_cidr_range745a04d3",
                State = Connector.Types.State.Unspecified,
                MinThroughput = -1306078102,
                MaxThroughput = 1609945563,
                ConnectedProjects =
                {
                    "connected_projects7e2fb014",
                },
                Subnet = new Connector.Types.Subnet(),
                MachineType = "machine_type68ce40fa",
                MinInstances = 445814344,
                MaxInstances = -1449803711,
            };
            mockGrpcClient.Setup(x => x.GetConnectorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Connector>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpcAccessServiceClient client = new VpcAccessServiceClientImpl(mockGrpcClient.Object, null, null);
            Connector responseCallSettings = await client.GetConnectorAsync(request.ConnectorName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Connector responseCancellationToken = await client.GetConnectorAsync(request.ConnectorName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
