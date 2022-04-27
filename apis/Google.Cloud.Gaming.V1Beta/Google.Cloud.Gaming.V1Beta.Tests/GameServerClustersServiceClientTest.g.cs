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

namespace Google.Cloud.Gaming.V1Beta.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedGameServerClustersServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetGameServerClusterRequestObject()
        {
            moq::Mock<GameServerClustersService.GameServerClustersServiceClient> mockGrpcClient = new moq::Mock<GameServerClustersService.GameServerClustersServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerClusterRequest request = new GetGameServerClusterRequest
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
            };
            GameServerCluster expectedResponse = new GameServerCluster
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ConnectionInfo = new GameServerClusterConnectionInfo(),
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetGameServerCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GameServerClustersServiceClient client = new GameServerClustersServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerCluster response = client.GetGameServerCluster(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGameServerClusterRequestObjectAsync()
        {
            moq::Mock<GameServerClustersService.GameServerClustersServiceClient> mockGrpcClient = new moq::Mock<GameServerClustersService.GameServerClustersServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerClusterRequest request = new GetGameServerClusterRequest
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
            };
            GameServerCluster expectedResponse = new GameServerCluster
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ConnectionInfo = new GameServerClusterConnectionInfo(),
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetGameServerClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GameServerCluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GameServerClustersServiceClient client = new GameServerClustersServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerCluster responseCallSettings = await client.GetGameServerClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GameServerCluster responseCancellationToken = await client.GetGameServerClusterAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGameServerCluster()
        {
            moq::Mock<GameServerClustersService.GameServerClustersServiceClient> mockGrpcClient = new moq::Mock<GameServerClustersService.GameServerClustersServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerClusterRequest request = new GetGameServerClusterRequest
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
            };
            GameServerCluster expectedResponse = new GameServerCluster
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ConnectionInfo = new GameServerClusterConnectionInfo(),
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetGameServerCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GameServerClustersServiceClient client = new GameServerClustersServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerCluster response = client.GetGameServerCluster(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGameServerClusterAsync()
        {
            moq::Mock<GameServerClustersService.GameServerClustersServiceClient> mockGrpcClient = new moq::Mock<GameServerClustersService.GameServerClustersServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerClusterRequest request = new GetGameServerClusterRequest
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
            };
            GameServerCluster expectedResponse = new GameServerCluster
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ConnectionInfo = new GameServerClusterConnectionInfo(),
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetGameServerClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GameServerCluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GameServerClustersServiceClient client = new GameServerClustersServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerCluster responseCallSettings = await client.GetGameServerClusterAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GameServerCluster responseCancellationToken = await client.GetGameServerClusterAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGameServerClusterResourceNames()
        {
            moq::Mock<GameServerClustersService.GameServerClustersServiceClient> mockGrpcClient = new moq::Mock<GameServerClustersService.GameServerClustersServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerClusterRequest request = new GetGameServerClusterRequest
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
            };
            GameServerCluster expectedResponse = new GameServerCluster
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ConnectionInfo = new GameServerClusterConnectionInfo(),
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetGameServerCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GameServerClustersServiceClient client = new GameServerClustersServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerCluster response = client.GetGameServerCluster(request.GameServerClusterName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGameServerClusterResourceNamesAsync()
        {
            moq::Mock<GameServerClustersService.GameServerClustersServiceClient> mockGrpcClient = new moq::Mock<GameServerClustersService.GameServerClustersServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerClusterRequest request = new GetGameServerClusterRequest
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
            };
            GameServerCluster expectedResponse = new GameServerCluster
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ConnectionInfo = new GameServerClusterConnectionInfo(),
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetGameServerClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GameServerCluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GameServerClustersServiceClient client = new GameServerClustersServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerCluster responseCallSettings = await client.GetGameServerClusterAsync(request.GameServerClusterName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GameServerCluster responseCancellationToken = await client.GetGameServerClusterAsync(request.GameServerClusterName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PreviewCreateGameServerClusterRequestObject()
        {
            moq::Mock<GameServerClustersService.GameServerClustersServiceClient> mockGrpcClient = new moq::Mock<GameServerClustersService.GameServerClustersServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PreviewCreateGameServerClusterRequest request = new PreviewCreateGameServerClusterRequest
            {
                ParentAsRealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
                GameServerClusterId = "game_server_cluster_ida2310829",
                GameServerCluster = new GameServerCluster(),
                PreviewTime = new wkt::Timestamp(),
            };
            PreviewCreateGameServerClusterResponse expectedResponse = new PreviewCreateGameServerClusterResponse
            {
                Etag = "etage8ad7218",
                TargetState = new TargetState(),
            };
            mockGrpcClient.Setup(x => x.PreviewCreateGameServerCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GameServerClustersServiceClient client = new GameServerClustersServiceClientImpl(mockGrpcClient.Object, null, null);
            PreviewCreateGameServerClusterResponse response = client.PreviewCreateGameServerCluster(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PreviewCreateGameServerClusterRequestObjectAsync()
        {
            moq::Mock<GameServerClustersService.GameServerClustersServiceClient> mockGrpcClient = new moq::Mock<GameServerClustersService.GameServerClustersServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PreviewCreateGameServerClusterRequest request = new PreviewCreateGameServerClusterRequest
            {
                ParentAsRealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
                GameServerClusterId = "game_server_cluster_ida2310829",
                GameServerCluster = new GameServerCluster(),
                PreviewTime = new wkt::Timestamp(),
            };
            PreviewCreateGameServerClusterResponse expectedResponse = new PreviewCreateGameServerClusterResponse
            {
                Etag = "etage8ad7218",
                TargetState = new TargetState(),
            };
            mockGrpcClient.Setup(x => x.PreviewCreateGameServerClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PreviewCreateGameServerClusterResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GameServerClustersServiceClient client = new GameServerClustersServiceClientImpl(mockGrpcClient.Object, null, null);
            PreviewCreateGameServerClusterResponse responseCallSettings = await client.PreviewCreateGameServerClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PreviewCreateGameServerClusterResponse responseCancellationToken = await client.PreviewCreateGameServerClusterAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PreviewDeleteGameServerClusterRequestObject()
        {
            moq::Mock<GameServerClustersService.GameServerClustersServiceClient> mockGrpcClient = new moq::Mock<GameServerClustersService.GameServerClustersServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PreviewDeleteGameServerClusterRequest request = new PreviewDeleteGameServerClusterRequest
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
                PreviewTime = new wkt::Timestamp(),
            };
            PreviewDeleteGameServerClusterResponse expectedResponse = new PreviewDeleteGameServerClusterResponse
            {
                Etag = "etage8ad7218",
                TargetState = new TargetState(),
            };
            mockGrpcClient.Setup(x => x.PreviewDeleteGameServerCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GameServerClustersServiceClient client = new GameServerClustersServiceClientImpl(mockGrpcClient.Object, null, null);
            PreviewDeleteGameServerClusterResponse response = client.PreviewDeleteGameServerCluster(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PreviewDeleteGameServerClusterRequestObjectAsync()
        {
            moq::Mock<GameServerClustersService.GameServerClustersServiceClient> mockGrpcClient = new moq::Mock<GameServerClustersService.GameServerClustersServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PreviewDeleteGameServerClusterRequest request = new PreviewDeleteGameServerClusterRequest
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
                PreviewTime = new wkt::Timestamp(),
            };
            PreviewDeleteGameServerClusterResponse expectedResponse = new PreviewDeleteGameServerClusterResponse
            {
                Etag = "etage8ad7218",
                TargetState = new TargetState(),
            };
            mockGrpcClient.Setup(x => x.PreviewDeleteGameServerClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PreviewDeleteGameServerClusterResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GameServerClustersServiceClient client = new GameServerClustersServiceClientImpl(mockGrpcClient.Object, null, null);
            PreviewDeleteGameServerClusterResponse responseCallSettings = await client.PreviewDeleteGameServerClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PreviewDeleteGameServerClusterResponse responseCancellationToken = await client.PreviewDeleteGameServerClusterAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PreviewUpdateGameServerClusterRequestObject()
        {
            moq::Mock<GameServerClustersService.GameServerClustersServiceClient> mockGrpcClient = new moq::Mock<GameServerClustersService.GameServerClustersServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PreviewUpdateGameServerClusterRequest request = new PreviewUpdateGameServerClusterRequest
            {
                GameServerCluster = new GameServerCluster(),
                UpdateMask = new wkt::FieldMask(),
                PreviewTime = new wkt::Timestamp(),
            };
            PreviewUpdateGameServerClusterResponse expectedResponse = new PreviewUpdateGameServerClusterResponse
            {
                Etag = "etage8ad7218",
                TargetState = new TargetState(),
            };
            mockGrpcClient.Setup(x => x.PreviewUpdateGameServerCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GameServerClustersServiceClient client = new GameServerClustersServiceClientImpl(mockGrpcClient.Object, null, null);
            PreviewUpdateGameServerClusterResponse response = client.PreviewUpdateGameServerCluster(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PreviewUpdateGameServerClusterRequestObjectAsync()
        {
            moq::Mock<GameServerClustersService.GameServerClustersServiceClient> mockGrpcClient = new moq::Mock<GameServerClustersService.GameServerClustersServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PreviewUpdateGameServerClusterRequest request = new PreviewUpdateGameServerClusterRequest
            {
                GameServerCluster = new GameServerCluster(),
                UpdateMask = new wkt::FieldMask(),
                PreviewTime = new wkt::Timestamp(),
            };
            PreviewUpdateGameServerClusterResponse expectedResponse = new PreviewUpdateGameServerClusterResponse
            {
                Etag = "etage8ad7218",
                TargetState = new TargetState(),
            };
            mockGrpcClient.Setup(x => x.PreviewUpdateGameServerClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PreviewUpdateGameServerClusterResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GameServerClustersServiceClient client = new GameServerClustersServiceClientImpl(mockGrpcClient.Object, null, null);
            PreviewUpdateGameServerClusterResponse responseCallSettings = await client.PreviewUpdateGameServerClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PreviewUpdateGameServerClusterResponse responseCancellationToken = await client.PreviewUpdateGameServerClusterAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
