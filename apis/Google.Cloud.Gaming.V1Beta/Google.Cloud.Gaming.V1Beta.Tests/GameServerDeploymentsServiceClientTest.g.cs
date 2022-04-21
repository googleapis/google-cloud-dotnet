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
    public sealed class GeneratedGameServerDeploymentsServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetGameServerDeploymentRequestObject()
        {
            moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient> mockGrpcClient = new moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerDeploymentRequest request = new GetGameServerDeploymentRequest
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            GameServerDeployment expectedResponse = new GameServerDeployment
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetGameServerDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GameServerDeploymentsServiceClient client = new GameServerDeploymentsServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerDeployment response = client.GetGameServerDeployment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGameServerDeploymentRequestObjectAsync()
        {
            moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient> mockGrpcClient = new moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerDeploymentRequest request = new GetGameServerDeploymentRequest
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            GameServerDeployment expectedResponse = new GameServerDeployment
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetGameServerDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GameServerDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GameServerDeploymentsServiceClient client = new GameServerDeploymentsServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerDeployment responseCallSettings = await client.GetGameServerDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GameServerDeployment responseCancellationToken = await client.GetGameServerDeploymentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGameServerDeployment()
        {
            moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient> mockGrpcClient = new moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerDeploymentRequest request = new GetGameServerDeploymentRequest
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            GameServerDeployment expectedResponse = new GameServerDeployment
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetGameServerDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GameServerDeploymentsServiceClient client = new GameServerDeploymentsServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerDeployment response = client.GetGameServerDeployment(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGameServerDeploymentAsync()
        {
            moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient> mockGrpcClient = new moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerDeploymentRequest request = new GetGameServerDeploymentRequest
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            GameServerDeployment expectedResponse = new GameServerDeployment
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetGameServerDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GameServerDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GameServerDeploymentsServiceClient client = new GameServerDeploymentsServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerDeployment responseCallSettings = await client.GetGameServerDeploymentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GameServerDeployment responseCancellationToken = await client.GetGameServerDeploymentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGameServerDeploymentResourceNames()
        {
            moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient> mockGrpcClient = new moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerDeploymentRequest request = new GetGameServerDeploymentRequest
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            GameServerDeployment expectedResponse = new GameServerDeployment
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetGameServerDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GameServerDeploymentsServiceClient client = new GameServerDeploymentsServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerDeployment response = client.GetGameServerDeployment(request.GameServerDeploymentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGameServerDeploymentResourceNamesAsync()
        {
            moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient> mockGrpcClient = new moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerDeploymentRequest request = new GetGameServerDeploymentRequest
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            GameServerDeployment expectedResponse = new GameServerDeployment
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetGameServerDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GameServerDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GameServerDeploymentsServiceClient client = new GameServerDeploymentsServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerDeployment responseCallSettings = await client.GetGameServerDeploymentAsync(request.GameServerDeploymentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GameServerDeployment responseCancellationToken = await client.GetGameServerDeploymentAsync(request.GameServerDeploymentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGameServerDeploymentRolloutRequestObject()
        {
            moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient> mockGrpcClient = new moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerDeploymentRolloutRequest request = new GetGameServerDeploymentRolloutRequest
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            GameServerDeploymentRollout expectedResponse = new GameServerDeploymentRollout
            {
                GameServerDeploymentRolloutName = GameServerDeploymentRolloutName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultGameServerConfig = "default_game_server_config2214de2f",
                GameServerConfigOverrides =
                {
                    new GameServerConfigOverride(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetGameServerDeploymentRollout(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GameServerDeploymentsServiceClient client = new GameServerDeploymentsServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerDeploymentRollout response = client.GetGameServerDeploymentRollout(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGameServerDeploymentRolloutRequestObjectAsync()
        {
            moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient> mockGrpcClient = new moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerDeploymentRolloutRequest request = new GetGameServerDeploymentRolloutRequest
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            GameServerDeploymentRollout expectedResponse = new GameServerDeploymentRollout
            {
                GameServerDeploymentRolloutName = GameServerDeploymentRolloutName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultGameServerConfig = "default_game_server_config2214de2f",
                GameServerConfigOverrides =
                {
                    new GameServerConfigOverride(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetGameServerDeploymentRolloutAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GameServerDeploymentRollout>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GameServerDeploymentsServiceClient client = new GameServerDeploymentsServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerDeploymentRollout responseCallSettings = await client.GetGameServerDeploymentRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GameServerDeploymentRollout responseCancellationToken = await client.GetGameServerDeploymentRolloutAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGameServerDeploymentRollout()
        {
            moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient> mockGrpcClient = new moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerDeploymentRolloutRequest request = new GetGameServerDeploymentRolloutRequest
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            GameServerDeploymentRollout expectedResponse = new GameServerDeploymentRollout
            {
                GameServerDeploymentRolloutName = GameServerDeploymentRolloutName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultGameServerConfig = "default_game_server_config2214de2f",
                GameServerConfigOverrides =
                {
                    new GameServerConfigOverride(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetGameServerDeploymentRollout(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GameServerDeploymentsServiceClient client = new GameServerDeploymentsServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerDeploymentRollout response = client.GetGameServerDeploymentRollout(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGameServerDeploymentRolloutAsync()
        {
            moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient> mockGrpcClient = new moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerDeploymentRolloutRequest request = new GetGameServerDeploymentRolloutRequest
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            GameServerDeploymentRollout expectedResponse = new GameServerDeploymentRollout
            {
                GameServerDeploymentRolloutName = GameServerDeploymentRolloutName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultGameServerConfig = "default_game_server_config2214de2f",
                GameServerConfigOverrides =
                {
                    new GameServerConfigOverride(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetGameServerDeploymentRolloutAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GameServerDeploymentRollout>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GameServerDeploymentsServiceClient client = new GameServerDeploymentsServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerDeploymentRollout responseCallSettings = await client.GetGameServerDeploymentRolloutAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GameServerDeploymentRollout responseCancellationToken = await client.GetGameServerDeploymentRolloutAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGameServerDeploymentRolloutResourceNames()
        {
            moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient> mockGrpcClient = new moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerDeploymentRolloutRequest request = new GetGameServerDeploymentRolloutRequest
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            GameServerDeploymentRollout expectedResponse = new GameServerDeploymentRollout
            {
                GameServerDeploymentRolloutName = GameServerDeploymentRolloutName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultGameServerConfig = "default_game_server_config2214de2f",
                GameServerConfigOverrides =
                {
                    new GameServerConfigOverride(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetGameServerDeploymentRollout(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GameServerDeploymentsServiceClient client = new GameServerDeploymentsServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerDeploymentRollout response = client.GetGameServerDeploymentRollout(request.GameServerDeploymentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGameServerDeploymentRolloutResourceNamesAsync()
        {
            moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient> mockGrpcClient = new moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerDeploymentRolloutRequest request = new GetGameServerDeploymentRolloutRequest
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            GameServerDeploymentRollout expectedResponse = new GameServerDeploymentRollout
            {
                GameServerDeploymentRolloutName = GameServerDeploymentRolloutName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultGameServerConfig = "default_game_server_config2214de2f",
                GameServerConfigOverrides =
                {
                    new GameServerConfigOverride(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetGameServerDeploymentRolloutAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GameServerDeploymentRollout>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GameServerDeploymentsServiceClient client = new GameServerDeploymentsServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerDeploymentRollout responseCallSettings = await client.GetGameServerDeploymentRolloutAsync(request.GameServerDeploymentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GameServerDeploymentRollout responseCancellationToken = await client.GetGameServerDeploymentRolloutAsync(request.GameServerDeploymentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PreviewGameServerDeploymentRolloutRequestObject()
        {
            moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient> mockGrpcClient = new moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PreviewGameServerDeploymentRolloutRequest request = new PreviewGameServerDeploymentRolloutRequest
            {
                Rollout = new GameServerDeploymentRollout(),
                UpdateMask = new wkt::FieldMask(),
                PreviewTime = new wkt::Timestamp(),
            };
            PreviewGameServerDeploymentRolloutResponse expectedResponse = new PreviewGameServerDeploymentRolloutResponse
            {
                Unavailable =
                {
                    "unavailable48e06070",
                },
                Etag = "etage8ad7218",
                TargetState = new TargetState(),
            };
            mockGrpcClient.Setup(x => x.PreviewGameServerDeploymentRollout(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GameServerDeploymentsServiceClient client = new GameServerDeploymentsServiceClientImpl(mockGrpcClient.Object, null, null);
            PreviewGameServerDeploymentRolloutResponse response = client.PreviewGameServerDeploymentRollout(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PreviewGameServerDeploymentRolloutRequestObjectAsync()
        {
            moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient> mockGrpcClient = new moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PreviewGameServerDeploymentRolloutRequest request = new PreviewGameServerDeploymentRolloutRequest
            {
                Rollout = new GameServerDeploymentRollout(),
                UpdateMask = new wkt::FieldMask(),
                PreviewTime = new wkt::Timestamp(),
            };
            PreviewGameServerDeploymentRolloutResponse expectedResponse = new PreviewGameServerDeploymentRolloutResponse
            {
                Unavailable =
                {
                    "unavailable48e06070",
                },
                Etag = "etage8ad7218",
                TargetState = new TargetState(),
            };
            mockGrpcClient.Setup(x => x.PreviewGameServerDeploymentRolloutAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PreviewGameServerDeploymentRolloutResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GameServerDeploymentsServiceClient client = new GameServerDeploymentsServiceClientImpl(mockGrpcClient.Object, null, null);
            PreviewGameServerDeploymentRolloutResponse responseCallSettings = await client.PreviewGameServerDeploymentRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PreviewGameServerDeploymentRolloutResponse responseCancellationToken = await client.PreviewGameServerDeploymentRolloutAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchDeploymentStateRequestObject()
        {
            moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient> mockGrpcClient = new moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchDeploymentStateRequest request = new FetchDeploymentStateRequest
            {
                Name = "name1c9368b0",
            };
            FetchDeploymentStateResponse expectedResponse = new FetchDeploymentStateResponse
            {
                ClusterState =
                {
                    new FetchDeploymentStateResponse.Types.DeployedClusterState(),
                },
                Unavailable =
                {
                    "unavailable48e06070",
                },
            };
            mockGrpcClient.Setup(x => x.FetchDeploymentState(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GameServerDeploymentsServiceClient client = new GameServerDeploymentsServiceClientImpl(mockGrpcClient.Object, null, null);
            FetchDeploymentStateResponse response = client.FetchDeploymentState(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchDeploymentStateRequestObjectAsync()
        {
            moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient> mockGrpcClient = new moq::Mock<GameServerDeploymentsService.GameServerDeploymentsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchDeploymentStateRequest request = new FetchDeploymentStateRequest
            {
                Name = "name1c9368b0",
            };
            FetchDeploymentStateResponse expectedResponse = new FetchDeploymentStateResponse
            {
                ClusterState =
                {
                    new FetchDeploymentStateResponse.Types.DeployedClusterState(),
                },
                Unavailable =
                {
                    "unavailable48e06070",
                },
            };
            mockGrpcClient.Setup(x => x.FetchDeploymentStateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchDeploymentStateResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GameServerDeploymentsServiceClient client = new GameServerDeploymentsServiceClientImpl(mockGrpcClient.Object, null, null);
            FetchDeploymentStateResponse responseCallSettings = await client.FetchDeploymentStateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchDeploymentStateResponse responseCancellationToken = await client.FetchDeploymentStateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
