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

namespace Google.Cloud.BeyondCorp.AppConnectors.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAppConnectorsServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetAppConnectorRequestObject()
        {
            moq::Mock<AppConnectorsService.AppConnectorsServiceClient> mockGrpcClient = new moq::Mock<AppConnectorsService.AppConnectorsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetAppConnectorRequest request = new GetAppConnectorRequest
            {
                AppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
            };
            AppConnector expectedResponse = new AppConnector
            {
                AppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
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
                State = AppConnector.Types.State.Unspecified,
                PrincipalInfo = new AppConnector.Types.PrincipalInfo(),
                ResourceInfo = new ResourceInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAppConnector(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AppConnectorsServiceClient client = new AppConnectorsServiceClientImpl(mockGrpcClient.Object, null, null);
            AppConnector response = client.GetAppConnector(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAppConnectorRequestObjectAsync()
        {
            moq::Mock<AppConnectorsService.AppConnectorsServiceClient> mockGrpcClient = new moq::Mock<AppConnectorsService.AppConnectorsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetAppConnectorRequest request = new GetAppConnectorRequest
            {
                AppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
            };
            AppConnector expectedResponse = new AppConnector
            {
                AppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
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
                State = AppConnector.Types.State.Unspecified,
                PrincipalInfo = new AppConnector.Types.PrincipalInfo(),
                ResourceInfo = new ResourceInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAppConnectorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AppConnector>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AppConnectorsServiceClient client = new AppConnectorsServiceClientImpl(mockGrpcClient.Object, null, null);
            AppConnector responseCallSettings = await client.GetAppConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AppConnector responseCancellationToken = await client.GetAppConnectorAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAppConnector()
        {
            moq::Mock<AppConnectorsService.AppConnectorsServiceClient> mockGrpcClient = new moq::Mock<AppConnectorsService.AppConnectorsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetAppConnectorRequest request = new GetAppConnectorRequest
            {
                AppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
            };
            AppConnector expectedResponse = new AppConnector
            {
                AppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
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
                State = AppConnector.Types.State.Unspecified,
                PrincipalInfo = new AppConnector.Types.PrincipalInfo(),
                ResourceInfo = new ResourceInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAppConnector(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AppConnectorsServiceClient client = new AppConnectorsServiceClientImpl(mockGrpcClient.Object, null, null);
            AppConnector response = client.GetAppConnector(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAppConnectorAsync()
        {
            moq::Mock<AppConnectorsService.AppConnectorsServiceClient> mockGrpcClient = new moq::Mock<AppConnectorsService.AppConnectorsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetAppConnectorRequest request = new GetAppConnectorRequest
            {
                AppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
            };
            AppConnector expectedResponse = new AppConnector
            {
                AppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
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
                State = AppConnector.Types.State.Unspecified,
                PrincipalInfo = new AppConnector.Types.PrincipalInfo(),
                ResourceInfo = new ResourceInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAppConnectorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AppConnector>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AppConnectorsServiceClient client = new AppConnectorsServiceClientImpl(mockGrpcClient.Object, null, null);
            AppConnector responseCallSettings = await client.GetAppConnectorAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AppConnector responseCancellationToken = await client.GetAppConnectorAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAppConnectorResourceNames()
        {
            moq::Mock<AppConnectorsService.AppConnectorsServiceClient> mockGrpcClient = new moq::Mock<AppConnectorsService.AppConnectorsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetAppConnectorRequest request = new GetAppConnectorRequest
            {
                AppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
            };
            AppConnector expectedResponse = new AppConnector
            {
                AppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
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
                State = AppConnector.Types.State.Unspecified,
                PrincipalInfo = new AppConnector.Types.PrincipalInfo(),
                ResourceInfo = new ResourceInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAppConnector(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AppConnectorsServiceClient client = new AppConnectorsServiceClientImpl(mockGrpcClient.Object, null, null);
            AppConnector response = client.GetAppConnector(request.AppConnectorName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAppConnectorResourceNamesAsync()
        {
            moq::Mock<AppConnectorsService.AppConnectorsServiceClient> mockGrpcClient = new moq::Mock<AppConnectorsService.AppConnectorsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetAppConnectorRequest request = new GetAppConnectorRequest
            {
                AppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
            };
            AppConnector expectedResponse = new AppConnector
            {
                AppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
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
                State = AppConnector.Types.State.Unspecified,
                PrincipalInfo = new AppConnector.Types.PrincipalInfo(),
                ResourceInfo = new ResourceInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAppConnectorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AppConnector>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AppConnectorsServiceClient client = new AppConnectorsServiceClientImpl(mockGrpcClient.Object, null, null);
            AppConnector responseCallSettings = await client.GetAppConnectorAsync(request.AppConnectorName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AppConnector responseCancellationToken = await client.GetAppConnectorAsync(request.AppConnectorName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
