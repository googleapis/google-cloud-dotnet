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
    public sealed class GeneratedGameServerConfigsServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetGameServerConfigRequestObject()
        {
            moq::Mock<GameServerConfigsService.GameServerConfigsServiceClient> mockGrpcClient = new moq::Mock<GameServerConfigsService.GameServerConfigsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerConfigRequest request = new GetGameServerConfigRequest
            {
                GameServerConfigName = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]"),
            };
            GameServerConfig expectedResponse = new GameServerConfig
            {
                GameServerConfigName = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                FleetConfigs = { new FleetConfig(), },
                ScalingConfigs =
                {
                    new ScalingConfig(),
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetGameServerConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GameServerConfigsServiceClient client = new GameServerConfigsServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerConfig response = client.GetGameServerConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGameServerConfigRequestObjectAsync()
        {
            moq::Mock<GameServerConfigsService.GameServerConfigsServiceClient> mockGrpcClient = new moq::Mock<GameServerConfigsService.GameServerConfigsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerConfigRequest request = new GetGameServerConfigRequest
            {
                GameServerConfigName = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]"),
            };
            GameServerConfig expectedResponse = new GameServerConfig
            {
                GameServerConfigName = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                FleetConfigs = { new FleetConfig(), },
                ScalingConfigs =
                {
                    new ScalingConfig(),
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetGameServerConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GameServerConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GameServerConfigsServiceClient client = new GameServerConfigsServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerConfig responseCallSettings = await client.GetGameServerConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GameServerConfig responseCancellationToken = await client.GetGameServerConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGameServerConfig()
        {
            moq::Mock<GameServerConfigsService.GameServerConfigsServiceClient> mockGrpcClient = new moq::Mock<GameServerConfigsService.GameServerConfigsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerConfigRequest request = new GetGameServerConfigRequest
            {
                GameServerConfigName = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]"),
            };
            GameServerConfig expectedResponse = new GameServerConfig
            {
                GameServerConfigName = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                FleetConfigs = { new FleetConfig(), },
                ScalingConfigs =
                {
                    new ScalingConfig(),
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetGameServerConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GameServerConfigsServiceClient client = new GameServerConfigsServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerConfig response = client.GetGameServerConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGameServerConfigAsync()
        {
            moq::Mock<GameServerConfigsService.GameServerConfigsServiceClient> mockGrpcClient = new moq::Mock<GameServerConfigsService.GameServerConfigsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerConfigRequest request = new GetGameServerConfigRequest
            {
                GameServerConfigName = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]"),
            };
            GameServerConfig expectedResponse = new GameServerConfig
            {
                GameServerConfigName = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                FleetConfigs = { new FleetConfig(), },
                ScalingConfigs =
                {
                    new ScalingConfig(),
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetGameServerConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GameServerConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GameServerConfigsServiceClient client = new GameServerConfigsServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerConfig responseCallSettings = await client.GetGameServerConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GameServerConfig responseCancellationToken = await client.GetGameServerConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGameServerConfigResourceNames()
        {
            moq::Mock<GameServerConfigsService.GameServerConfigsServiceClient> mockGrpcClient = new moq::Mock<GameServerConfigsService.GameServerConfigsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerConfigRequest request = new GetGameServerConfigRequest
            {
                GameServerConfigName = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]"),
            };
            GameServerConfig expectedResponse = new GameServerConfig
            {
                GameServerConfigName = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                FleetConfigs = { new FleetConfig(), },
                ScalingConfigs =
                {
                    new ScalingConfig(),
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetGameServerConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GameServerConfigsServiceClient client = new GameServerConfigsServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerConfig response = client.GetGameServerConfig(request.GameServerConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGameServerConfigResourceNamesAsync()
        {
            moq::Mock<GameServerConfigsService.GameServerConfigsServiceClient> mockGrpcClient = new moq::Mock<GameServerConfigsService.GameServerConfigsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGameServerConfigRequest request = new GetGameServerConfigRequest
            {
                GameServerConfigName = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]"),
            };
            GameServerConfig expectedResponse = new GameServerConfig
            {
                GameServerConfigName = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                FleetConfigs = { new FleetConfig(), },
                ScalingConfigs =
                {
                    new ScalingConfig(),
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetGameServerConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GameServerConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GameServerConfigsServiceClient client = new GameServerConfigsServiceClientImpl(mockGrpcClient.Object, null, null);
            GameServerConfig responseCallSettings = await client.GetGameServerConfigAsync(request.GameServerConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GameServerConfig responseCancellationToken = await client.GetGameServerConfigAsync(request.GameServerConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
