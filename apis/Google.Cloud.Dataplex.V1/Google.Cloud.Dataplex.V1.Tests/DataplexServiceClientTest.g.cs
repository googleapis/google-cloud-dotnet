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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dataplex.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDataplexServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetLakeRequestObject()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetLakeRequest request = new GetLakeRequest
            {
                LakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
            };
            Lake expectedResponse = new Lake
            {
                LakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                ServiceAccount = "service_accounta3c1b923",
                Metastore = new Lake.Types.Metastore(),
                AssetStatus = new AssetStatus(),
                MetastoreStatus = new Lake.Types.MetastoreStatus(),
            };
            mockGrpcClient.Setup(x => x.GetLake(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Lake response = client.GetLake(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLakeRequestObjectAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetLakeRequest request = new GetLakeRequest
            {
                LakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
            };
            Lake expectedResponse = new Lake
            {
                LakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                ServiceAccount = "service_accounta3c1b923",
                Metastore = new Lake.Types.Metastore(),
                AssetStatus = new AssetStatus(),
                MetastoreStatus = new Lake.Types.MetastoreStatus(),
            };
            mockGrpcClient.Setup(x => x.GetLakeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Lake>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Lake responseCallSettings = await client.GetLakeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Lake responseCancellationToken = await client.GetLakeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLake()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetLakeRequest request = new GetLakeRequest
            {
                LakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
            };
            Lake expectedResponse = new Lake
            {
                LakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                ServiceAccount = "service_accounta3c1b923",
                Metastore = new Lake.Types.Metastore(),
                AssetStatus = new AssetStatus(),
                MetastoreStatus = new Lake.Types.MetastoreStatus(),
            };
            mockGrpcClient.Setup(x => x.GetLake(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Lake response = client.GetLake(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLakeAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetLakeRequest request = new GetLakeRequest
            {
                LakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
            };
            Lake expectedResponse = new Lake
            {
                LakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                ServiceAccount = "service_accounta3c1b923",
                Metastore = new Lake.Types.Metastore(),
                AssetStatus = new AssetStatus(),
                MetastoreStatus = new Lake.Types.MetastoreStatus(),
            };
            mockGrpcClient.Setup(x => x.GetLakeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Lake>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Lake responseCallSettings = await client.GetLakeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Lake responseCancellationToken = await client.GetLakeAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLakeResourceNames()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetLakeRequest request = new GetLakeRequest
            {
                LakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
            };
            Lake expectedResponse = new Lake
            {
                LakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                ServiceAccount = "service_accounta3c1b923",
                Metastore = new Lake.Types.Metastore(),
                AssetStatus = new AssetStatus(),
                MetastoreStatus = new Lake.Types.MetastoreStatus(),
            };
            mockGrpcClient.Setup(x => x.GetLake(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Lake response = client.GetLake(request.LakeName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLakeResourceNamesAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetLakeRequest request = new GetLakeRequest
            {
                LakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
            };
            Lake expectedResponse = new Lake
            {
                LakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                ServiceAccount = "service_accounta3c1b923",
                Metastore = new Lake.Types.Metastore(),
                AssetStatus = new AssetStatus(),
                MetastoreStatus = new Lake.Types.MetastoreStatus(),
            };
            mockGrpcClient.Setup(x => x.GetLakeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Lake>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Lake responseCallSettings = await client.GetLakeAsync(request.LakeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Lake responseCancellationToken = await client.GetLakeAsync(request.LakeName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetZoneRequestObject()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetZoneRequest request = new GetZoneRequest
            {
                ZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
            };
            Zone expectedResponse = new Zone
            {
                ZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                Type = Zone.Types.Type.Unspecified,
                DiscoverySpec = new Zone.Types.DiscoverySpec(),
                ResourceSpec = new Zone.Types.ResourceSpec(),
                AssetStatus = new AssetStatus(),
            };
            mockGrpcClient.Setup(x => x.GetZone(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Zone response = client.GetZone(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetZoneRequestObjectAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetZoneRequest request = new GetZoneRequest
            {
                ZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
            };
            Zone expectedResponse = new Zone
            {
                ZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                Type = Zone.Types.Type.Unspecified,
                DiscoverySpec = new Zone.Types.DiscoverySpec(),
                ResourceSpec = new Zone.Types.ResourceSpec(),
                AssetStatus = new AssetStatus(),
            };
            mockGrpcClient.Setup(x => x.GetZoneAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Zone>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Zone responseCallSettings = await client.GetZoneAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Zone responseCancellationToken = await client.GetZoneAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetZone()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetZoneRequest request = new GetZoneRequest
            {
                ZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
            };
            Zone expectedResponse = new Zone
            {
                ZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                Type = Zone.Types.Type.Unspecified,
                DiscoverySpec = new Zone.Types.DiscoverySpec(),
                ResourceSpec = new Zone.Types.ResourceSpec(),
                AssetStatus = new AssetStatus(),
            };
            mockGrpcClient.Setup(x => x.GetZone(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Zone response = client.GetZone(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetZoneAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetZoneRequest request = new GetZoneRequest
            {
                ZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
            };
            Zone expectedResponse = new Zone
            {
                ZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                Type = Zone.Types.Type.Unspecified,
                DiscoverySpec = new Zone.Types.DiscoverySpec(),
                ResourceSpec = new Zone.Types.ResourceSpec(),
                AssetStatus = new AssetStatus(),
            };
            mockGrpcClient.Setup(x => x.GetZoneAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Zone>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Zone responseCallSettings = await client.GetZoneAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Zone responseCancellationToken = await client.GetZoneAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetZoneResourceNames()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetZoneRequest request = new GetZoneRequest
            {
                ZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
            };
            Zone expectedResponse = new Zone
            {
                ZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                Type = Zone.Types.Type.Unspecified,
                DiscoverySpec = new Zone.Types.DiscoverySpec(),
                ResourceSpec = new Zone.Types.ResourceSpec(),
                AssetStatus = new AssetStatus(),
            };
            mockGrpcClient.Setup(x => x.GetZone(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Zone response = client.GetZone(request.ZoneName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetZoneResourceNamesAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetZoneRequest request = new GetZoneRequest
            {
                ZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
            };
            Zone expectedResponse = new Zone
            {
                ZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                Type = Zone.Types.Type.Unspecified,
                DiscoverySpec = new Zone.Types.DiscoverySpec(),
                ResourceSpec = new Zone.Types.ResourceSpec(),
                AssetStatus = new AssetStatus(),
            };
            mockGrpcClient.Setup(x => x.GetZoneAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Zone>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Zone responseCallSettings = await client.GetZoneAsync(request.ZoneName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Zone responseCancellationToken = await client.GetZoneAsync(request.ZoneName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAssetRequestObject()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAssetRequest request = new GetAssetRequest
            {
                AssetName = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
            };
            Asset expectedResponse = new Asset
            {
                AssetName = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                ResourceSpec = new Asset.Types.ResourceSpec(),
                ResourceStatus = new Asset.Types.ResourceStatus(),
                SecurityStatus = new Asset.Types.SecurityStatus(),
                DiscoverySpec = new Asset.Types.DiscoverySpec(),
                DiscoveryStatus = new Asset.Types.DiscoveryStatus(),
            };
            mockGrpcClient.Setup(x => x.GetAsset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Asset response = client.GetAsset(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAssetRequestObjectAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAssetRequest request = new GetAssetRequest
            {
                AssetName = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
            };
            Asset expectedResponse = new Asset
            {
                AssetName = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                ResourceSpec = new Asset.Types.ResourceSpec(),
                ResourceStatus = new Asset.Types.ResourceStatus(),
                SecurityStatus = new Asset.Types.SecurityStatus(),
                DiscoverySpec = new Asset.Types.DiscoverySpec(),
                DiscoveryStatus = new Asset.Types.DiscoveryStatus(),
            };
            mockGrpcClient.Setup(x => x.GetAssetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Asset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Asset responseCallSettings = await client.GetAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Asset responseCancellationToken = await client.GetAssetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAsset()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAssetRequest request = new GetAssetRequest
            {
                AssetName = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
            };
            Asset expectedResponse = new Asset
            {
                AssetName = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                ResourceSpec = new Asset.Types.ResourceSpec(),
                ResourceStatus = new Asset.Types.ResourceStatus(),
                SecurityStatus = new Asset.Types.SecurityStatus(),
                DiscoverySpec = new Asset.Types.DiscoverySpec(),
                DiscoveryStatus = new Asset.Types.DiscoveryStatus(),
            };
            mockGrpcClient.Setup(x => x.GetAsset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Asset response = client.GetAsset(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAssetAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAssetRequest request = new GetAssetRequest
            {
                AssetName = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
            };
            Asset expectedResponse = new Asset
            {
                AssetName = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                ResourceSpec = new Asset.Types.ResourceSpec(),
                ResourceStatus = new Asset.Types.ResourceStatus(),
                SecurityStatus = new Asset.Types.SecurityStatus(),
                DiscoverySpec = new Asset.Types.DiscoverySpec(),
                DiscoveryStatus = new Asset.Types.DiscoveryStatus(),
            };
            mockGrpcClient.Setup(x => x.GetAssetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Asset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Asset responseCallSettings = await client.GetAssetAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Asset responseCancellationToken = await client.GetAssetAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAssetResourceNames()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAssetRequest request = new GetAssetRequest
            {
                AssetName = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
            };
            Asset expectedResponse = new Asset
            {
                AssetName = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                ResourceSpec = new Asset.Types.ResourceSpec(),
                ResourceStatus = new Asset.Types.ResourceStatus(),
                SecurityStatus = new Asset.Types.SecurityStatus(),
                DiscoverySpec = new Asset.Types.DiscoverySpec(),
                DiscoveryStatus = new Asset.Types.DiscoveryStatus(),
            };
            mockGrpcClient.Setup(x => x.GetAsset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Asset response = client.GetAsset(request.AssetName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAssetResourceNamesAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAssetRequest request = new GetAssetRequest
            {
                AssetName = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
            };
            Asset expectedResponse = new Asset
            {
                AssetName = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                ResourceSpec = new Asset.Types.ResourceSpec(),
                ResourceStatus = new Asset.Types.ResourceStatus(),
                SecurityStatus = new Asset.Types.SecurityStatus(),
                DiscoverySpec = new Asset.Types.DiscoverySpec(),
                DiscoveryStatus = new Asset.Types.DiscoveryStatus(),
            };
            mockGrpcClient.Setup(x => x.GetAssetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Asset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Asset responseCallSettings = await client.GetAssetAsync(request.AssetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Asset responseCancellationToken = await client.GetAssetAsync(request.AssetName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTaskRequestObject()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                State = State.Deleting,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                TriggerSpec = new Task.Types.TriggerSpec(),
                ExecutionSpec = new Task.Types.ExecutionSpec(),
                Spark = new Task.Types.SparkTaskConfig(),
            };
            mockGrpcClient.Setup(x => x.GetTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Task response = client.GetTask(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTaskRequestObjectAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                State = State.Deleting,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                TriggerSpec = new Task.Types.TriggerSpec(),
                ExecutionSpec = new Task.Types.ExecutionSpec(),
                Spark = new Task.Types.SparkTaskConfig(),
            };
            mockGrpcClient.Setup(x => x.GetTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Task responseCallSettings = await client.GetTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.GetTaskAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTask()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                State = State.Deleting,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                TriggerSpec = new Task.Types.TriggerSpec(),
                ExecutionSpec = new Task.Types.ExecutionSpec(),
                Spark = new Task.Types.SparkTaskConfig(),
            };
            mockGrpcClient.Setup(x => x.GetTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Task response = client.GetTask(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTaskAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                State = State.Deleting,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                TriggerSpec = new Task.Types.TriggerSpec(),
                ExecutionSpec = new Task.Types.ExecutionSpec(),
                Spark = new Task.Types.SparkTaskConfig(),
            };
            mockGrpcClient.Setup(x => x.GetTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Task responseCallSettings = await client.GetTaskAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.GetTaskAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTaskResourceNames()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                State = State.Deleting,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                TriggerSpec = new Task.Types.TriggerSpec(),
                ExecutionSpec = new Task.Types.ExecutionSpec(),
                Spark = new Task.Types.SparkTaskConfig(),
            };
            mockGrpcClient.Setup(x => x.GetTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Task response = client.GetTask(request.TaskName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTaskResourceNamesAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                State = State.Deleting,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                TriggerSpec = new Task.Types.TriggerSpec(),
                ExecutionSpec = new Task.Types.ExecutionSpec(),
                Spark = new Task.Types.SparkTaskConfig(),
            };
            mockGrpcClient.Setup(x => x.GetTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Task responseCallSettings = await client.GetTaskAsync(request.TaskName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.GetTaskAsync(request.TaskName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobRequestObject()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
                Uid = "uida2d37198",
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Job.Types.State.Aborted,
                RetryCount = 1150497264U,
                Service = Job.Types.Service.Unspecified,
                ServiceJob = "service_job0a2e6488",
                Message = "message0231e778",
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Job response = client.GetJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobRequestObjectAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
                Uid = "uida2d37198",
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Job.Types.State.Aborted,
                RetryCount = 1150497264U,
                Service = Job.Types.Service.Unspecified,
                ServiceJob = "service_job0a2e6488",
                Message = "message0231e778",
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Job responseCallSettings = await client.GetJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJob()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
                Uid = "uida2d37198",
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Job.Types.State.Aborted,
                RetryCount = 1150497264U,
                Service = Job.Types.Service.Unspecified,
                ServiceJob = "service_job0a2e6488",
                Message = "message0231e778",
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Job response = client.GetJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
                Uid = "uida2d37198",
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Job.Types.State.Aborted,
                RetryCount = 1150497264U,
                Service = Job.Types.Service.Unspecified,
                ServiceJob = "service_job0a2e6488",
                Message = "message0231e778",
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Job responseCallSettings = await client.GetJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobResourceNames()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
                Uid = "uida2d37198",
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Job.Types.State.Aborted,
                RetryCount = 1150497264U,
                Service = Job.Types.Service.Unspecified,
                ServiceJob = "service_job0a2e6488",
                Message = "message0231e778",
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Job response = client.GetJob(request.JobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobResourceNamesAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
                Uid = "uida2d37198",
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Job.Types.State.Aborted,
                RetryCount = 1150497264U,
                Service = Job.Types.Service.Unspecified,
                ServiceJob = "service_job0a2e6488",
                Message = "message0231e778",
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Job responseCallSettings = await client.GetJobAsync(request.JobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request.JobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelJobRequestObject()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelJobRequest request = new CancelJobRequest
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            client.CancelJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelJobRequestObjectAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelJobRequest request = new CancelJobRequest
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.CancelJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelJob()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelJobRequest request = new CancelJobRequest
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            client.CancelJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelJobAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelJobRequest request = new CancelJobRequest
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.CancelJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelJobResourceNames()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelJobRequest request = new CancelJobRequest
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            client.CancelJob(request.JobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelJobResourceNamesAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelJobRequest request = new CancelJobRequest
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.CancelJobAsync(request.JobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelJobAsync(request.JobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEnvironmentRequestObject()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]"),
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                InfrastructureSpec = new Environment.Types.InfrastructureSpec(),
                SessionSpec = new Environment.Types.SessionSpec(),
                SessionStatus = new Environment.Types.SessionStatus(),
                Endpoints = new Environment.Types.Endpoints(),
            };
            mockGrpcClient.Setup(x => x.GetEnvironment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Environment response = client.GetEnvironment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEnvironmentRequestObjectAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]"),
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                InfrastructureSpec = new Environment.Types.InfrastructureSpec(),
                SessionSpec = new Environment.Types.SessionSpec(),
                SessionStatus = new Environment.Types.SessionStatus(),
                Endpoints = new Environment.Types.Endpoints(),
            };
            mockGrpcClient.Setup(x => x.GetEnvironmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Environment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Environment responseCallSettings = await client.GetEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Environment responseCancellationToken = await client.GetEnvironmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEnvironment()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]"),
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                InfrastructureSpec = new Environment.Types.InfrastructureSpec(),
                SessionSpec = new Environment.Types.SessionSpec(),
                SessionStatus = new Environment.Types.SessionStatus(),
                Endpoints = new Environment.Types.Endpoints(),
            };
            mockGrpcClient.Setup(x => x.GetEnvironment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Environment response = client.GetEnvironment(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEnvironmentAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]"),
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                InfrastructureSpec = new Environment.Types.InfrastructureSpec(),
                SessionSpec = new Environment.Types.SessionSpec(),
                SessionStatus = new Environment.Types.SessionStatus(),
                Endpoints = new Environment.Types.Endpoints(),
            };
            mockGrpcClient.Setup(x => x.GetEnvironmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Environment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Environment responseCallSettings = await client.GetEnvironmentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Environment responseCancellationToken = await client.GetEnvironmentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEnvironmentResourceNames()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]"),
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                InfrastructureSpec = new Environment.Types.InfrastructureSpec(),
                SessionSpec = new Environment.Types.SessionSpec(),
                SessionStatus = new Environment.Types.SessionStatus(),
                Endpoints = new Environment.Types.Endpoints(),
            };
            mockGrpcClient.Setup(x => x.GetEnvironment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Environment response = client.GetEnvironment(request.EnvironmentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEnvironmentResourceNamesAsync()
        {
            moq::Mock<DataplexService.DataplexServiceClient> mockGrpcClient = new moq::Mock<DataplexService.DataplexServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]"),
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]"),
                DisplayName = "display_name137f65c2",
                Uid = "uida2d37198",
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
                State = State.Deleting,
                InfrastructureSpec = new Environment.Types.InfrastructureSpec(),
                SessionSpec = new Environment.Types.SessionSpec(),
                SessionStatus = new Environment.Types.SessionStatus(),
                Endpoints = new Environment.Types.Endpoints(),
            };
            mockGrpcClient.Setup(x => x.GetEnvironmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Environment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataplexServiceClient client = new DataplexServiceClientImpl(mockGrpcClient.Object, null, null);
            Environment responseCallSettings = await client.GetEnvironmentAsync(request.EnvironmentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Environment responseCancellationToken = await client.GetEnvironmentAsync(request.EnvironmentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
