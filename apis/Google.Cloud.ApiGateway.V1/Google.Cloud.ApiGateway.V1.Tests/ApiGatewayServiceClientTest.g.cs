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

namespace Google.Cloud.ApiGateway.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedApiGatewayServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetGatewayRequestObject()
        {
            moq::Mock<ApiGatewayService.ApiGatewayServiceClient> mockGrpcClient = new moq::Mock<ApiGatewayService.ApiGatewayServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGatewayRequest request = new GetGatewayRequest
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
            };
            Gateway expectedResponse = new Gateway
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
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
                ApiConfigAsApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
                State = Gateway.Types.State.Unspecified,
                DefaultHostname = "default_hostname0ebd0627",
            };
            mockGrpcClient.Setup(x => x.GetGateway(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApiGatewayServiceClient client = new ApiGatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            Gateway response = client.GetGateway(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGatewayRequestObjectAsync()
        {
            moq::Mock<ApiGatewayService.ApiGatewayServiceClient> mockGrpcClient = new moq::Mock<ApiGatewayService.ApiGatewayServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGatewayRequest request = new GetGatewayRequest
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
            };
            Gateway expectedResponse = new Gateway
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
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
                ApiConfigAsApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
                State = Gateway.Types.State.Unspecified,
                DefaultHostname = "default_hostname0ebd0627",
            };
            mockGrpcClient.Setup(x => x.GetGatewayAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Gateway>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApiGatewayServiceClient client = new ApiGatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            Gateway responseCallSettings = await client.GetGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Gateway responseCancellationToken = await client.GetGatewayAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGateway()
        {
            moq::Mock<ApiGatewayService.ApiGatewayServiceClient> mockGrpcClient = new moq::Mock<ApiGatewayService.ApiGatewayServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGatewayRequest request = new GetGatewayRequest
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
            };
            Gateway expectedResponse = new Gateway
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
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
                ApiConfigAsApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
                State = Gateway.Types.State.Unspecified,
                DefaultHostname = "default_hostname0ebd0627",
            };
            mockGrpcClient.Setup(x => x.GetGateway(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApiGatewayServiceClient client = new ApiGatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            Gateway response = client.GetGateway(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGatewayAsync()
        {
            moq::Mock<ApiGatewayService.ApiGatewayServiceClient> mockGrpcClient = new moq::Mock<ApiGatewayService.ApiGatewayServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGatewayRequest request = new GetGatewayRequest
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
            };
            Gateway expectedResponse = new Gateway
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
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
                ApiConfigAsApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
                State = Gateway.Types.State.Unspecified,
                DefaultHostname = "default_hostname0ebd0627",
            };
            mockGrpcClient.Setup(x => x.GetGatewayAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Gateway>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApiGatewayServiceClient client = new ApiGatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            Gateway responseCallSettings = await client.GetGatewayAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Gateway responseCancellationToken = await client.GetGatewayAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGatewayResourceNames()
        {
            moq::Mock<ApiGatewayService.ApiGatewayServiceClient> mockGrpcClient = new moq::Mock<ApiGatewayService.ApiGatewayServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGatewayRequest request = new GetGatewayRequest
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
            };
            Gateway expectedResponse = new Gateway
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
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
                ApiConfigAsApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
                State = Gateway.Types.State.Unspecified,
                DefaultHostname = "default_hostname0ebd0627",
            };
            mockGrpcClient.Setup(x => x.GetGateway(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApiGatewayServiceClient client = new ApiGatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            Gateway response = client.GetGateway(request.GatewayName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGatewayResourceNamesAsync()
        {
            moq::Mock<ApiGatewayService.ApiGatewayServiceClient> mockGrpcClient = new moq::Mock<ApiGatewayService.ApiGatewayServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGatewayRequest request = new GetGatewayRequest
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
            };
            Gateway expectedResponse = new Gateway
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
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
                ApiConfigAsApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
                State = Gateway.Types.State.Unspecified,
                DefaultHostname = "default_hostname0ebd0627",
            };
            mockGrpcClient.Setup(x => x.GetGatewayAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Gateway>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApiGatewayServiceClient client = new ApiGatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            Gateway responseCallSettings = await client.GetGatewayAsync(request.GatewayName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Gateway responseCancellationToken = await client.GetGatewayAsync(request.GatewayName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApiRequestObject()
        {
            moq::Mock<ApiGatewayService.ApiGatewayServiceClient> mockGrpcClient = new moq::Mock<ApiGatewayService.ApiGatewayServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetApiRequest request = new GetApiRequest
            {
                ApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
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
                ManagedServiceAsManagedServiceName = ManagedServiceName.FromService("[SERVICE]"),
                State = Api.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetApi(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApiGatewayServiceClient client = new ApiGatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            Api response = client.GetApi(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiRequestObjectAsync()
        {
            moq::Mock<ApiGatewayService.ApiGatewayServiceClient> mockGrpcClient = new moq::Mock<ApiGatewayService.ApiGatewayServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetApiRequest request = new GetApiRequest
            {
                ApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
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
                ManagedServiceAsManagedServiceName = ManagedServiceName.FromService("[SERVICE]"),
                State = Api.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetApiAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Api>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApiGatewayServiceClient client = new ApiGatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            Api responseCallSettings = await client.GetApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Api responseCancellationToken = await client.GetApiAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApi()
        {
            moq::Mock<ApiGatewayService.ApiGatewayServiceClient> mockGrpcClient = new moq::Mock<ApiGatewayService.ApiGatewayServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetApiRequest request = new GetApiRequest
            {
                ApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
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
                ManagedServiceAsManagedServiceName = ManagedServiceName.FromService("[SERVICE]"),
                State = Api.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetApi(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApiGatewayServiceClient client = new ApiGatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            Api response = client.GetApi(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiAsync()
        {
            moq::Mock<ApiGatewayService.ApiGatewayServiceClient> mockGrpcClient = new moq::Mock<ApiGatewayService.ApiGatewayServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetApiRequest request = new GetApiRequest
            {
                ApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
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
                ManagedServiceAsManagedServiceName = ManagedServiceName.FromService("[SERVICE]"),
                State = Api.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetApiAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Api>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApiGatewayServiceClient client = new ApiGatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            Api responseCallSettings = await client.GetApiAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Api responseCancellationToken = await client.GetApiAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApiResourceNames()
        {
            moq::Mock<ApiGatewayService.ApiGatewayServiceClient> mockGrpcClient = new moq::Mock<ApiGatewayService.ApiGatewayServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetApiRequest request = new GetApiRequest
            {
                ApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
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
                ManagedServiceAsManagedServiceName = ManagedServiceName.FromService("[SERVICE]"),
                State = Api.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetApi(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApiGatewayServiceClient client = new ApiGatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            Api response = client.GetApi(request.ApiName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiResourceNamesAsync()
        {
            moq::Mock<ApiGatewayService.ApiGatewayServiceClient> mockGrpcClient = new moq::Mock<ApiGatewayService.ApiGatewayServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetApiRequest request = new GetApiRequest
            {
                ApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
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
                ManagedServiceAsManagedServiceName = ManagedServiceName.FromService("[SERVICE]"),
                State = Api.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetApiAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Api>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApiGatewayServiceClient client = new ApiGatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            Api responseCallSettings = await client.GetApiAsync(request.ApiName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Api responseCancellationToken = await client.GetApiAsync(request.ApiName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApiConfigRequestObject()
        {
            moq::Mock<ApiGatewayService.ApiGatewayServiceClient> mockGrpcClient = new moq::Mock<ApiGatewayService.ApiGatewayServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetApiConfigRequest request = new GetApiConfigRequest
            {
                ApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
                View = GetApiConfigRequest.Types.ConfigView.Basic,
            };
            ApiConfig expectedResponse = new ApiConfig
            {
                ApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
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
                State = ApiConfig.Types.State.Activating,
                OpenapiDocuments =
                {
                    new ApiConfig.Types.OpenApiDocument(),
                },
                GrpcServices =
                {
                    new ApiConfig.Types.GrpcServiceDefinition(),
                },
                ManagedServiceConfigs =
                {
                    new ApiConfig.Types.File(),
                },
                ServiceConfigIdAsServiceName = ServiceName.FromServiceConfig("[SERVICE]", "[CONFIG]"),
                GatewayServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.GetApiConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApiGatewayServiceClient client = new ApiGatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            ApiConfig response = client.GetApiConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiConfigRequestObjectAsync()
        {
            moq::Mock<ApiGatewayService.ApiGatewayServiceClient> mockGrpcClient = new moq::Mock<ApiGatewayService.ApiGatewayServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetApiConfigRequest request = new GetApiConfigRequest
            {
                ApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
                View = GetApiConfigRequest.Types.ConfigView.Basic,
            };
            ApiConfig expectedResponse = new ApiConfig
            {
                ApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
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
                State = ApiConfig.Types.State.Activating,
                OpenapiDocuments =
                {
                    new ApiConfig.Types.OpenApiDocument(),
                },
                GrpcServices =
                {
                    new ApiConfig.Types.GrpcServiceDefinition(),
                },
                ManagedServiceConfigs =
                {
                    new ApiConfig.Types.File(),
                },
                ServiceConfigIdAsServiceName = ServiceName.FromServiceConfig("[SERVICE]", "[CONFIG]"),
                GatewayServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.GetApiConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApiGatewayServiceClient client = new ApiGatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            ApiConfig responseCallSettings = await client.GetApiConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiConfig responseCancellationToken = await client.GetApiConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApiConfig()
        {
            moq::Mock<ApiGatewayService.ApiGatewayServiceClient> mockGrpcClient = new moq::Mock<ApiGatewayService.ApiGatewayServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetApiConfigRequest request = new GetApiConfigRequest
            {
                ApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
            };
            ApiConfig expectedResponse = new ApiConfig
            {
                ApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
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
                State = ApiConfig.Types.State.Activating,
                OpenapiDocuments =
                {
                    new ApiConfig.Types.OpenApiDocument(),
                },
                GrpcServices =
                {
                    new ApiConfig.Types.GrpcServiceDefinition(),
                },
                ManagedServiceConfigs =
                {
                    new ApiConfig.Types.File(),
                },
                ServiceConfigIdAsServiceName = ServiceName.FromServiceConfig("[SERVICE]", "[CONFIG]"),
                GatewayServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.GetApiConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApiGatewayServiceClient client = new ApiGatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            ApiConfig response = client.GetApiConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiConfigAsync()
        {
            moq::Mock<ApiGatewayService.ApiGatewayServiceClient> mockGrpcClient = new moq::Mock<ApiGatewayService.ApiGatewayServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetApiConfigRequest request = new GetApiConfigRequest
            {
                ApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
            };
            ApiConfig expectedResponse = new ApiConfig
            {
                ApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
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
                State = ApiConfig.Types.State.Activating,
                OpenapiDocuments =
                {
                    new ApiConfig.Types.OpenApiDocument(),
                },
                GrpcServices =
                {
                    new ApiConfig.Types.GrpcServiceDefinition(),
                },
                ManagedServiceConfigs =
                {
                    new ApiConfig.Types.File(),
                },
                ServiceConfigIdAsServiceName = ServiceName.FromServiceConfig("[SERVICE]", "[CONFIG]"),
                GatewayServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.GetApiConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApiGatewayServiceClient client = new ApiGatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            ApiConfig responseCallSettings = await client.GetApiConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiConfig responseCancellationToken = await client.GetApiConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApiConfigResourceNames()
        {
            moq::Mock<ApiGatewayService.ApiGatewayServiceClient> mockGrpcClient = new moq::Mock<ApiGatewayService.ApiGatewayServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetApiConfigRequest request = new GetApiConfigRequest
            {
                ApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
            };
            ApiConfig expectedResponse = new ApiConfig
            {
                ApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
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
                State = ApiConfig.Types.State.Activating,
                OpenapiDocuments =
                {
                    new ApiConfig.Types.OpenApiDocument(),
                },
                GrpcServices =
                {
                    new ApiConfig.Types.GrpcServiceDefinition(),
                },
                ManagedServiceConfigs =
                {
                    new ApiConfig.Types.File(),
                },
                ServiceConfigIdAsServiceName = ServiceName.FromServiceConfig("[SERVICE]", "[CONFIG]"),
                GatewayServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.GetApiConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApiGatewayServiceClient client = new ApiGatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            ApiConfig response = client.GetApiConfig(request.ApiConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiConfigResourceNamesAsync()
        {
            moq::Mock<ApiGatewayService.ApiGatewayServiceClient> mockGrpcClient = new moq::Mock<ApiGatewayService.ApiGatewayServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetApiConfigRequest request = new GetApiConfigRequest
            {
                ApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
            };
            ApiConfig expectedResponse = new ApiConfig
            {
                ApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
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
                State = ApiConfig.Types.State.Activating,
                OpenapiDocuments =
                {
                    new ApiConfig.Types.OpenApiDocument(),
                },
                GrpcServices =
                {
                    new ApiConfig.Types.GrpcServiceDefinition(),
                },
                ManagedServiceConfigs =
                {
                    new ApiConfig.Types.File(),
                },
                ServiceConfigIdAsServiceName = ServiceName.FromServiceConfig("[SERVICE]", "[CONFIG]"),
                GatewayServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.GetApiConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApiGatewayServiceClient client = new ApiGatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            ApiConfig responseCallSettings = await client.GetApiConfigAsync(request.ApiConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiConfig responseCancellationToken = await client.GetApiConfigAsync(request.ApiConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
