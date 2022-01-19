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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Iot.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDeviceManagerClientTest
    {
        [xunit::FactAttribute]
        public void CreateDeviceRegistryRequestObject()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            CreateDeviceRegistryRequest request = new CreateDeviceRegistryRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeviceRegistry = new DeviceRegistry(),
            };
            DeviceRegistry expectedResponse = new DeviceRegistry
            {
                Id = "id74b70bb8",
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                MqttConfig = new MqttConfig(),
                StateNotificationConfig = new StateNotificationConfig(),
                Credentials =
                {
                    new RegistryCredential(),
                },
                HttpConfig = new HttpConfig(),
                EventNotificationConfigs =
                {
                    new EventNotificationConfig(),
                },
                LogLevel = LogLevel.Info,
            };
            mockGrpcClient.Setup(x => x.CreateDeviceRegistry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceRegistry response = client.CreateDeviceRegistry(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDeviceRegistryRequestObjectAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            CreateDeviceRegistryRequest request = new CreateDeviceRegistryRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeviceRegistry = new DeviceRegistry(),
            };
            DeviceRegistry expectedResponse = new DeviceRegistry
            {
                Id = "id74b70bb8",
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                MqttConfig = new MqttConfig(),
                StateNotificationConfig = new StateNotificationConfig(),
                Credentials =
                {
                    new RegistryCredential(),
                },
                HttpConfig = new HttpConfig(),
                EventNotificationConfigs =
                {
                    new EventNotificationConfig(),
                },
                LogLevel = LogLevel.Info,
            };
            mockGrpcClient.Setup(x => x.CreateDeviceRegistryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeviceRegistry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceRegistry responseCallSettings = await client.CreateDeviceRegistryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeviceRegistry responseCancellationToken = await client.CreateDeviceRegistryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDeviceRegistry()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            CreateDeviceRegistryRequest request = new CreateDeviceRegistryRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeviceRegistry = new DeviceRegistry(),
            };
            DeviceRegistry expectedResponse = new DeviceRegistry
            {
                Id = "id74b70bb8",
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                MqttConfig = new MqttConfig(),
                StateNotificationConfig = new StateNotificationConfig(),
                Credentials =
                {
                    new RegistryCredential(),
                },
                HttpConfig = new HttpConfig(),
                EventNotificationConfigs =
                {
                    new EventNotificationConfig(),
                },
                LogLevel = LogLevel.Info,
            };
            mockGrpcClient.Setup(x => x.CreateDeviceRegistry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceRegistry response = client.CreateDeviceRegistry(request.Parent, request.DeviceRegistry);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDeviceRegistryAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            CreateDeviceRegistryRequest request = new CreateDeviceRegistryRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeviceRegistry = new DeviceRegistry(),
            };
            DeviceRegistry expectedResponse = new DeviceRegistry
            {
                Id = "id74b70bb8",
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                MqttConfig = new MqttConfig(),
                StateNotificationConfig = new StateNotificationConfig(),
                Credentials =
                {
                    new RegistryCredential(),
                },
                HttpConfig = new HttpConfig(),
                EventNotificationConfigs =
                {
                    new EventNotificationConfig(),
                },
                LogLevel = LogLevel.Info,
            };
            mockGrpcClient.Setup(x => x.CreateDeviceRegistryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeviceRegistry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceRegistry responseCallSettings = await client.CreateDeviceRegistryAsync(request.Parent, request.DeviceRegistry, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeviceRegistry responseCancellationToken = await client.CreateDeviceRegistryAsync(request.Parent, request.DeviceRegistry, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDeviceRegistryResourceNames()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            CreateDeviceRegistryRequest request = new CreateDeviceRegistryRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeviceRegistry = new DeviceRegistry(),
            };
            DeviceRegistry expectedResponse = new DeviceRegistry
            {
                Id = "id74b70bb8",
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                MqttConfig = new MqttConfig(),
                StateNotificationConfig = new StateNotificationConfig(),
                Credentials =
                {
                    new RegistryCredential(),
                },
                HttpConfig = new HttpConfig(),
                EventNotificationConfigs =
                {
                    new EventNotificationConfig(),
                },
                LogLevel = LogLevel.Info,
            };
            mockGrpcClient.Setup(x => x.CreateDeviceRegistry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceRegistry response = client.CreateDeviceRegistry(request.ParentAsLocationName, request.DeviceRegistry);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDeviceRegistryResourceNamesAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            CreateDeviceRegistryRequest request = new CreateDeviceRegistryRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeviceRegistry = new DeviceRegistry(),
            };
            DeviceRegistry expectedResponse = new DeviceRegistry
            {
                Id = "id74b70bb8",
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                MqttConfig = new MqttConfig(),
                StateNotificationConfig = new StateNotificationConfig(),
                Credentials =
                {
                    new RegistryCredential(),
                },
                HttpConfig = new HttpConfig(),
                EventNotificationConfigs =
                {
                    new EventNotificationConfig(),
                },
                LogLevel = LogLevel.Info,
            };
            mockGrpcClient.Setup(x => x.CreateDeviceRegistryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeviceRegistry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceRegistry responseCallSettings = await client.CreateDeviceRegistryAsync(request.ParentAsLocationName, request.DeviceRegistry, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeviceRegistry responseCancellationToken = await client.CreateDeviceRegistryAsync(request.ParentAsLocationName, request.DeviceRegistry, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDeviceRegistryRequestObject()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            GetDeviceRegistryRequest request = new GetDeviceRegistryRequest
            {
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
            };
            DeviceRegistry expectedResponse = new DeviceRegistry
            {
                Id = "id74b70bb8",
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                MqttConfig = new MqttConfig(),
                StateNotificationConfig = new StateNotificationConfig(),
                Credentials =
                {
                    new RegistryCredential(),
                },
                HttpConfig = new HttpConfig(),
                EventNotificationConfigs =
                {
                    new EventNotificationConfig(),
                },
                LogLevel = LogLevel.Info,
            };
            mockGrpcClient.Setup(x => x.GetDeviceRegistry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceRegistry response = client.GetDeviceRegistry(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeviceRegistryRequestObjectAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            GetDeviceRegistryRequest request = new GetDeviceRegistryRequest
            {
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
            };
            DeviceRegistry expectedResponse = new DeviceRegistry
            {
                Id = "id74b70bb8",
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                MqttConfig = new MqttConfig(),
                StateNotificationConfig = new StateNotificationConfig(),
                Credentials =
                {
                    new RegistryCredential(),
                },
                HttpConfig = new HttpConfig(),
                EventNotificationConfigs =
                {
                    new EventNotificationConfig(),
                },
                LogLevel = LogLevel.Info,
            };
            mockGrpcClient.Setup(x => x.GetDeviceRegistryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeviceRegistry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceRegistry responseCallSettings = await client.GetDeviceRegistryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeviceRegistry responseCancellationToken = await client.GetDeviceRegistryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDeviceRegistry()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            GetDeviceRegistryRequest request = new GetDeviceRegistryRequest
            {
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
            };
            DeviceRegistry expectedResponse = new DeviceRegistry
            {
                Id = "id74b70bb8",
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                MqttConfig = new MqttConfig(),
                StateNotificationConfig = new StateNotificationConfig(),
                Credentials =
                {
                    new RegistryCredential(),
                },
                HttpConfig = new HttpConfig(),
                EventNotificationConfigs =
                {
                    new EventNotificationConfig(),
                },
                LogLevel = LogLevel.Info,
            };
            mockGrpcClient.Setup(x => x.GetDeviceRegistry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceRegistry response = client.GetDeviceRegistry(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeviceRegistryAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            GetDeviceRegistryRequest request = new GetDeviceRegistryRequest
            {
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
            };
            DeviceRegistry expectedResponse = new DeviceRegistry
            {
                Id = "id74b70bb8",
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                MqttConfig = new MqttConfig(),
                StateNotificationConfig = new StateNotificationConfig(),
                Credentials =
                {
                    new RegistryCredential(),
                },
                HttpConfig = new HttpConfig(),
                EventNotificationConfigs =
                {
                    new EventNotificationConfig(),
                },
                LogLevel = LogLevel.Info,
            };
            mockGrpcClient.Setup(x => x.GetDeviceRegistryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeviceRegistry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceRegistry responseCallSettings = await client.GetDeviceRegistryAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeviceRegistry responseCancellationToken = await client.GetDeviceRegistryAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDeviceRegistryResourceNames()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            GetDeviceRegistryRequest request = new GetDeviceRegistryRequest
            {
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
            };
            DeviceRegistry expectedResponse = new DeviceRegistry
            {
                Id = "id74b70bb8",
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                MqttConfig = new MqttConfig(),
                StateNotificationConfig = new StateNotificationConfig(),
                Credentials =
                {
                    new RegistryCredential(),
                },
                HttpConfig = new HttpConfig(),
                EventNotificationConfigs =
                {
                    new EventNotificationConfig(),
                },
                LogLevel = LogLevel.Info,
            };
            mockGrpcClient.Setup(x => x.GetDeviceRegistry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceRegistry response = client.GetDeviceRegistry(request.RegistryName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeviceRegistryResourceNamesAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            GetDeviceRegistryRequest request = new GetDeviceRegistryRequest
            {
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
            };
            DeviceRegistry expectedResponse = new DeviceRegistry
            {
                Id = "id74b70bb8",
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                MqttConfig = new MqttConfig(),
                StateNotificationConfig = new StateNotificationConfig(),
                Credentials =
                {
                    new RegistryCredential(),
                },
                HttpConfig = new HttpConfig(),
                EventNotificationConfigs =
                {
                    new EventNotificationConfig(),
                },
                LogLevel = LogLevel.Info,
            };
            mockGrpcClient.Setup(x => x.GetDeviceRegistryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeviceRegistry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceRegistry responseCallSettings = await client.GetDeviceRegistryAsync(request.RegistryName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeviceRegistry responseCancellationToken = await client.GetDeviceRegistryAsync(request.RegistryName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDeviceRegistryRequestObject()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            UpdateDeviceRegistryRequest request = new UpdateDeviceRegistryRequest
            {
                DeviceRegistry = new DeviceRegistry(),
                UpdateMask = new wkt::FieldMask(),
            };
            DeviceRegistry expectedResponse = new DeviceRegistry
            {
                Id = "id74b70bb8",
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                MqttConfig = new MqttConfig(),
                StateNotificationConfig = new StateNotificationConfig(),
                Credentials =
                {
                    new RegistryCredential(),
                },
                HttpConfig = new HttpConfig(),
                EventNotificationConfigs =
                {
                    new EventNotificationConfig(),
                },
                LogLevel = LogLevel.Info,
            };
            mockGrpcClient.Setup(x => x.UpdateDeviceRegistry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceRegistry response = client.UpdateDeviceRegistry(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDeviceRegistryRequestObjectAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            UpdateDeviceRegistryRequest request = new UpdateDeviceRegistryRequest
            {
                DeviceRegistry = new DeviceRegistry(),
                UpdateMask = new wkt::FieldMask(),
            };
            DeviceRegistry expectedResponse = new DeviceRegistry
            {
                Id = "id74b70bb8",
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                MqttConfig = new MqttConfig(),
                StateNotificationConfig = new StateNotificationConfig(),
                Credentials =
                {
                    new RegistryCredential(),
                },
                HttpConfig = new HttpConfig(),
                EventNotificationConfigs =
                {
                    new EventNotificationConfig(),
                },
                LogLevel = LogLevel.Info,
            };
            mockGrpcClient.Setup(x => x.UpdateDeviceRegistryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeviceRegistry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceRegistry responseCallSettings = await client.UpdateDeviceRegistryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeviceRegistry responseCancellationToken = await client.UpdateDeviceRegistryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDeviceRegistry()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            UpdateDeviceRegistryRequest request = new UpdateDeviceRegistryRequest
            {
                DeviceRegistry = new DeviceRegistry(),
                UpdateMask = new wkt::FieldMask(),
            };
            DeviceRegistry expectedResponse = new DeviceRegistry
            {
                Id = "id74b70bb8",
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                MqttConfig = new MqttConfig(),
                StateNotificationConfig = new StateNotificationConfig(),
                Credentials =
                {
                    new RegistryCredential(),
                },
                HttpConfig = new HttpConfig(),
                EventNotificationConfigs =
                {
                    new EventNotificationConfig(),
                },
                LogLevel = LogLevel.Info,
            };
            mockGrpcClient.Setup(x => x.UpdateDeviceRegistry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceRegistry response = client.UpdateDeviceRegistry(request.DeviceRegistry, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDeviceRegistryAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            UpdateDeviceRegistryRequest request = new UpdateDeviceRegistryRequest
            {
                DeviceRegistry = new DeviceRegistry(),
                UpdateMask = new wkt::FieldMask(),
            };
            DeviceRegistry expectedResponse = new DeviceRegistry
            {
                Id = "id74b70bb8",
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                MqttConfig = new MqttConfig(),
                StateNotificationConfig = new StateNotificationConfig(),
                Credentials =
                {
                    new RegistryCredential(),
                },
                HttpConfig = new HttpConfig(),
                EventNotificationConfigs =
                {
                    new EventNotificationConfig(),
                },
                LogLevel = LogLevel.Info,
            };
            mockGrpcClient.Setup(x => x.UpdateDeviceRegistryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeviceRegistry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceRegistry responseCallSettings = await client.UpdateDeviceRegistryAsync(request.DeviceRegistry, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeviceRegistry responseCancellationToken = await client.UpdateDeviceRegistryAsync(request.DeviceRegistry, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDeviceRegistryRequestObject()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            DeleteDeviceRegistryRequest request = new DeleteDeviceRegistryRequest
            {
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeviceRegistry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            client.DeleteDeviceRegistry(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDeviceRegistryRequestObjectAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            DeleteDeviceRegistryRequest request = new DeleteDeviceRegistryRequest
            {
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeviceRegistryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteDeviceRegistryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDeviceRegistryAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDeviceRegistry()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            DeleteDeviceRegistryRequest request = new DeleteDeviceRegistryRequest
            {
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeviceRegistry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            client.DeleteDeviceRegistry(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDeviceRegistryAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            DeleteDeviceRegistryRequest request = new DeleteDeviceRegistryRequest
            {
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeviceRegistryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteDeviceRegistryAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDeviceRegistryAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDeviceRegistryResourceNames()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            DeleteDeviceRegistryRequest request = new DeleteDeviceRegistryRequest
            {
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeviceRegistry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            client.DeleteDeviceRegistry(request.RegistryName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDeviceRegistryResourceNamesAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            DeleteDeviceRegistryRequest request = new DeleteDeviceRegistryRequest
            {
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeviceRegistryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteDeviceRegistryAsync(request.RegistryName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDeviceRegistryAsync(request.RegistryName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDeviceRequestObject()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            CreateDeviceRequest request = new CreateDeviceRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                Device = new Device(),
            };
            Device expectedResponse = new Device
            {
                Id = "id74b70bb8",
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumId = 15493549572921294156UL,
                LastHeartbeatTime = new wkt::Timestamp(),
                LastEventTime = new wkt::Timestamp(),
                LastErrorTime = new wkt::Timestamp(),
                LastErrorStatus = new gr::Status(),
                Credentials =
                {
                    new DeviceCredential(),
                },
                Config = new DeviceConfig(),
                LastConfigAckTime = new wkt::Timestamp(),
                State = new DeviceState(),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LastConfigSendTime = new wkt::Timestamp(),
                Blocked = true,
                LastStateTime = new wkt::Timestamp(),
                LogLevel = LogLevel.Info,
                GatewayConfig = new GatewayConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            Device response = client.CreateDevice(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDeviceRequestObjectAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            CreateDeviceRequest request = new CreateDeviceRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                Device = new Device(),
            };
            Device expectedResponse = new Device
            {
                Id = "id74b70bb8",
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumId = 15493549572921294156UL,
                LastHeartbeatTime = new wkt::Timestamp(),
                LastEventTime = new wkt::Timestamp(),
                LastErrorTime = new wkt::Timestamp(),
                LastErrorStatus = new gr::Status(),
                Credentials =
                {
                    new DeviceCredential(),
                },
                Config = new DeviceConfig(),
                LastConfigAckTime = new wkt::Timestamp(),
                State = new DeviceState(),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LastConfigSendTime = new wkt::Timestamp(),
                Blocked = true,
                LastStateTime = new wkt::Timestamp(),
                LogLevel = LogLevel.Info,
                GatewayConfig = new GatewayConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Device>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            Device responseCallSettings = await client.CreateDeviceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Device responseCancellationToken = await client.CreateDeviceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDevice()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            CreateDeviceRequest request = new CreateDeviceRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                Device = new Device(),
            };
            Device expectedResponse = new Device
            {
                Id = "id74b70bb8",
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumId = 15493549572921294156UL,
                LastHeartbeatTime = new wkt::Timestamp(),
                LastEventTime = new wkt::Timestamp(),
                LastErrorTime = new wkt::Timestamp(),
                LastErrorStatus = new gr::Status(),
                Credentials =
                {
                    new DeviceCredential(),
                },
                Config = new DeviceConfig(),
                LastConfigAckTime = new wkt::Timestamp(),
                State = new DeviceState(),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LastConfigSendTime = new wkt::Timestamp(),
                Blocked = true,
                LastStateTime = new wkt::Timestamp(),
                LogLevel = LogLevel.Info,
                GatewayConfig = new GatewayConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            Device response = client.CreateDevice(request.Parent, request.Device);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDeviceAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            CreateDeviceRequest request = new CreateDeviceRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                Device = new Device(),
            };
            Device expectedResponse = new Device
            {
                Id = "id74b70bb8",
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumId = 15493549572921294156UL,
                LastHeartbeatTime = new wkt::Timestamp(),
                LastEventTime = new wkt::Timestamp(),
                LastErrorTime = new wkt::Timestamp(),
                LastErrorStatus = new gr::Status(),
                Credentials =
                {
                    new DeviceCredential(),
                },
                Config = new DeviceConfig(),
                LastConfigAckTime = new wkt::Timestamp(),
                State = new DeviceState(),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LastConfigSendTime = new wkt::Timestamp(),
                Blocked = true,
                LastStateTime = new wkt::Timestamp(),
                LogLevel = LogLevel.Info,
                GatewayConfig = new GatewayConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Device>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            Device responseCallSettings = await client.CreateDeviceAsync(request.Parent, request.Device, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Device responseCancellationToken = await client.CreateDeviceAsync(request.Parent, request.Device, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDeviceResourceNames()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            CreateDeviceRequest request = new CreateDeviceRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                Device = new Device(),
            };
            Device expectedResponse = new Device
            {
                Id = "id74b70bb8",
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumId = 15493549572921294156UL,
                LastHeartbeatTime = new wkt::Timestamp(),
                LastEventTime = new wkt::Timestamp(),
                LastErrorTime = new wkt::Timestamp(),
                LastErrorStatus = new gr::Status(),
                Credentials =
                {
                    new DeviceCredential(),
                },
                Config = new DeviceConfig(),
                LastConfigAckTime = new wkt::Timestamp(),
                State = new DeviceState(),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LastConfigSendTime = new wkt::Timestamp(),
                Blocked = true,
                LastStateTime = new wkt::Timestamp(),
                LogLevel = LogLevel.Info,
                GatewayConfig = new GatewayConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            Device response = client.CreateDevice(request.ParentAsRegistryName, request.Device);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDeviceResourceNamesAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            CreateDeviceRequest request = new CreateDeviceRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                Device = new Device(),
            };
            Device expectedResponse = new Device
            {
                Id = "id74b70bb8",
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumId = 15493549572921294156UL,
                LastHeartbeatTime = new wkt::Timestamp(),
                LastEventTime = new wkt::Timestamp(),
                LastErrorTime = new wkt::Timestamp(),
                LastErrorStatus = new gr::Status(),
                Credentials =
                {
                    new DeviceCredential(),
                },
                Config = new DeviceConfig(),
                LastConfigAckTime = new wkt::Timestamp(),
                State = new DeviceState(),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LastConfigSendTime = new wkt::Timestamp(),
                Blocked = true,
                LastStateTime = new wkt::Timestamp(),
                LogLevel = LogLevel.Info,
                GatewayConfig = new GatewayConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Device>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            Device responseCallSettings = await client.CreateDeviceAsync(request.ParentAsRegistryName, request.Device, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Device responseCancellationToken = await client.CreateDeviceAsync(request.ParentAsRegistryName, request.Device, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDeviceRequestObject()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            GetDeviceRequest request = new GetDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                FieldMask = new wkt::FieldMask(),
            };
            Device expectedResponse = new Device
            {
                Id = "id74b70bb8",
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumId = 15493549572921294156UL,
                LastHeartbeatTime = new wkt::Timestamp(),
                LastEventTime = new wkt::Timestamp(),
                LastErrorTime = new wkt::Timestamp(),
                LastErrorStatus = new gr::Status(),
                Credentials =
                {
                    new DeviceCredential(),
                },
                Config = new DeviceConfig(),
                LastConfigAckTime = new wkt::Timestamp(),
                State = new DeviceState(),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LastConfigSendTime = new wkt::Timestamp(),
                Blocked = true,
                LastStateTime = new wkt::Timestamp(),
                LogLevel = LogLevel.Info,
                GatewayConfig = new GatewayConfig(),
            };
            mockGrpcClient.Setup(x => x.GetDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            Device response = client.GetDevice(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeviceRequestObjectAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            GetDeviceRequest request = new GetDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                FieldMask = new wkt::FieldMask(),
            };
            Device expectedResponse = new Device
            {
                Id = "id74b70bb8",
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumId = 15493549572921294156UL,
                LastHeartbeatTime = new wkt::Timestamp(),
                LastEventTime = new wkt::Timestamp(),
                LastErrorTime = new wkt::Timestamp(),
                LastErrorStatus = new gr::Status(),
                Credentials =
                {
                    new DeviceCredential(),
                },
                Config = new DeviceConfig(),
                LastConfigAckTime = new wkt::Timestamp(),
                State = new DeviceState(),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LastConfigSendTime = new wkt::Timestamp(),
                Blocked = true,
                LastStateTime = new wkt::Timestamp(),
                LogLevel = LogLevel.Info,
                GatewayConfig = new GatewayConfig(),
            };
            mockGrpcClient.Setup(x => x.GetDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Device>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            Device responseCallSettings = await client.GetDeviceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Device responseCancellationToken = await client.GetDeviceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDevice()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            GetDeviceRequest request = new GetDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            Device expectedResponse = new Device
            {
                Id = "id74b70bb8",
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumId = 15493549572921294156UL,
                LastHeartbeatTime = new wkt::Timestamp(),
                LastEventTime = new wkt::Timestamp(),
                LastErrorTime = new wkt::Timestamp(),
                LastErrorStatus = new gr::Status(),
                Credentials =
                {
                    new DeviceCredential(),
                },
                Config = new DeviceConfig(),
                LastConfigAckTime = new wkt::Timestamp(),
                State = new DeviceState(),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LastConfigSendTime = new wkt::Timestamp(),
                Blocked = true,
                LastStateTime = new wkt::Timestamp(),
                LogLevel = LogLevel.Info,
                GatewayConfig = new GatewayConfig(),
            };
            mockGrpcClient.Setup(x => x.GetDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            Device response = client.GetDevice(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeviceAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            GetDeviceRequest request = new GetDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            Device expectedResponse = new Device
            {
                Id = "id74b70bb8",
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumId = 15493549572921294156UL,
                LastHeartbeatTime = new wkt::Timestamp(),
                LastEventTime = new wkt::Timestamp(),
                LastErrorTime = new wkt::Timestamp(),
                LastErrorStatus = new gr::Status(),
                Credentials =
                {
                    new DeviceCredential(),
                },
                Config = new DeviceConfig(),
                LastConfigAckTime = new wkt::Timestamp(),
                State = new DeviceState(),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LastConfigSendTime = new wkt::Timestamp(),
                Blocked = true,
                LastStateTime = new wkt::Timestamp(),
                LogLevel = LogLevel.Info,
                GatewayConfig = new GatewayConfig(),
            };
            mockGrpcClient.Setup(x => x.GetDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Device>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            Device responseCallSettings = await client.GetDeviceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Device responseCancellationToken = await client.GetDeviceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDeviceResourceNames()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            GetDeviceRequest request = new GetDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            Device expectedResponse = new Device
            {
                Id = "id74b70bb8",
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumId = 15493549572921294156UL,
                LastHeartbeatTime = new wkt::Timestamp(),
                LastEventTime = new wkt::Timestamp(),
                LastErrorTime = new wkt::Timestamp(),
                LastErrorStatus = new gr::Status(),
                Credentials =
                {
                    new DeviceCredential(),
                },
                Config = new DeviceConfig(),
                LastConfigAckTime = new wkt::Timestamp(),
                State = new DeviceState(),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LastConfigSendTime = new wkt::Timestamp(),
                Blocked = true,
                LastStateTime = new wkt::Timestamp(),
                LogLevel = LogLevel.Info,
                GatewayConfig = new GatewayConfig(),
            };
            mockGrpcClient.Setup(x => x.GetDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            Device response = client.GetDevice(request.DeviceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeviceResourceNamesAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            GetDeviceRequest request = new GetDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            Device expectedResponse = new Device
            {
                Id = "id74b70bb8",
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumId = 15493549572921294156UL,
                LastHeartbeatTime = new wkt::Timestamp(),
                LastEventTime = new wkt::Timestamp(),
                LastErrorTime = new wkt::Timestamp(),
                LastErrorStatus = new gr::Status(),
                Credentials =
                {
                    new DeviceCredential(),
                },
                Config = new DeviceConfig(),
                LastConfigAckTime = new wkt::Timestamp(),
                State = new DeviceState(),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LastConfigSendTime = new wkt::Timestamp(),
                Blocked = true,
                LastStateTime = new wkt::Timestamp(),
                LogLevel = LogLevel.Info,
                GatewayConfig = new GatewayConfig(),
            };
            mockGrpcClient.Setup(x => x.GetDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Device>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            Device responseCallSettings = await client.GetDeviceAsync(request.DeviceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Device responseCancellationToken = await client.GetDeviceAsync(request.DeviceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDeviceRequestObject()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            UpdateDeviceRequest request = new UpdateDeviceRequest
            {
                Device = new Device(),
                UpdateMask = new wkt::FieldMask(),
            };
            Device expectedResponse = new Device
            {
                Id = "id74b70bb8",
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumId = 15493549572921294156UL,
                LastHeartbeatTime = new wkt::Timestamp(),
                LastEventTime = new wkt::Timestamp(),
                LastErrorTime = new wkt::Timestamp(),
                LastErrorStatus = new gr::Status(),
                Credentials =
                {
                    new DeviceCredential(),
                },
                Config = new DeviceConfig(),
                LastConfigAckTime = new wkt::Timestamp(),
                State = new DeviceState(),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LastConfigSendTime = new wkt::Timestamp(),
                Blocked = true,
                LastStateTime = new wkt::Timestamp(),
                LogLevel = LogLevel.Info,
                GatewayConfig = new GatewayConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            Device response = client.UpdateDevice(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDeviceRequestObjectAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            UpdateDeviceRequest request = new UpdateDeviceRequest
            {
                Device = new Device(),
                UpdateMask = new wkt::FieldMask(),
            };
            Device expectedResponse = new Device
            {
                Id = "id74b70bb8",
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumId = 15493549572921294156UL,
                LastHeartbeatTime = new wkt::Timestamp(),
                LastEventTime = new wkt::Timestamp(),
                LastErrorTime = new wkt::Timestamp(),
                LastErrorStatus = new gr::Status(),
                Credentials =
                {
                    new DeviceCredential(),
                },
                Config = new DeviceConfig(),
                LastConfigAckTime = new wkt::Timestamp(),
                State = new DeviceState(),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LastConfigSendTime = new wkt::Timestamp(),
                Blocked = true,
                LastStateTime = new wkt::Timestamp(),
                LogLevel = LogLevel.Info,
                GatewayConfig = new GatewayConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Device>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            Device responseCallSettings = await client.UpdateDeviceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Device responseCancellationToken = await client.UpdateDeviceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDevice()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            UpdateDeviceRequest request = new UpdateDeviceRequest
            {
                Device = new Device(),
                UpdateMask = new wkt::FieldMask(),
            };
            Device expectedResponse = new Device
            {
                Id = "id74b70bb8",
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumId = 15493549572921294156UL,
                LastHeartbeatTime = new wkt::Timestamp(),
                LastEventTime = new wkt::Timestamp(),
                LastErrorTime = new wkt::Timestamp(),
                LastErrorStatus = new gr::Status(),
                Credentials =
                {
                    new DeviceCredential(),
                },
                Config = new DeviceConfig(),
                LastConfigAckTime = new wkt::Timestamp(),
                State = new DeviceState(),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LastConfigSendTime = new wkt::Timestamp(),
                Blocked = true,
                LastStateTime = new wkt::Timestamp(),
                LogLevel = LogLevel.Info,
                GatewayConfig = new GatewayConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            Device response = client.UpdateDevice(request.Device, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDeviceAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            UpdateDeviceRequest request = new UpdateDeviceRequest
            {
                Device = new Device(),
                UpdateMask = new wkt::FieldMask(),
            };
            Device expectedResponse = new Device
            {
                Id = "id74b70bb8",
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumId = 15493549572921294156UL,
                LastHeartbeatTime = new wkt::Timestamp(),
                LastEventTime = new wkt::Timestamp(),
                LastErrorTime = new wkt::Timestamp(),
                LastErrorStatus = new gr::Status(),
                Credentials =
                {
                    new DeviceCredential(),
                },
                Config = new DeviceConfig(),
                LastConfigAckTime = new wkt::Timestamp(),
                State = new DeviceState(),
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                LastConfigSendTime = new wkt::Timestamp(),
                Blocked = true,
                LastStateTime = new wkt::Timestamp(),
                LogLevel = LogLevel.Info,
                GatewayConfig = new GatewayConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Device>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            Device responseCallSettings = await client.UpdateDeviceAsync(request.Device, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Device responseCancellationToken = await client.UpdateDeviceAsync(request.Device, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDeviceRequestObject()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            DeleteDeviceRequest request = new DeleteDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            client.DeleteDevice(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDeviceRequestObjectAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            DeleteDeviceRequest request = new DeleteDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteDeviceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDeviceAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDevice()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            DeleteDeviceRequest request = new DeleteDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            client.DeleteDevice(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDeviceAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            DeleteDeviceRequest request = new DeleteDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteDeviceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDeviceAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDeviceResourceNames()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            DeleteDeviceRequest request = new DeleteDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            client.DeleteDevice(request.DeviceName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDeviceResourceNamesAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            DeleteDeviceRequest request = new DeleteDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteDeviceAsync(request.DeviceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDeviceAsync(request.DeviceName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ModifyCloudToDeviceConfigRequestObject()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            ModifyCloudToDeviceConfigRequest request = new ModifyCloudToDeviceConfigRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                VersionToUpdate = 577383381333078340L,
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
            };
            DeviceConfig expectedResponse = new DeviceConfig
            {
                Version = 8314266188006815530L,
                CloudUpdateTime = new wkt::Timestamp(),
                DeviceAckTime = new wkt::Timestamp(),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
            };
            mockGrpcClient.Setup(x => x.ModifyCloudToDeviceConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceConfig response = client.ModifyCloudToDeviceConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ModifyCloudToDeviceConfigRequestObjectAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            ModifyCloudToDeviceConfigRequest request = new ModifyCloudToDeviceConfigRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                VersionToUpdate = 577383381333078340L,
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
            };
            DeviceConfig expectedResponse = new DeviceConfig
            {
                Version = 8314266188006815530L,
                CloudUpdateTime = new wkt::Timestamp(),
                DeviceAckTime = new wkt::Timestamp(),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
            };
            mockGrpcClient.Setup(x => x.ModifyCloudToDeviceConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeviceConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceConfig responseCallSettings = await client.ModifyCloudToDeviceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeviceConfig responseCancellationToken = await client.ModifyCloudToDeviceConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ModifyCloudToDeviceConfig()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            ModifyCloudToDeviceConfigRequest request = new ModifyCloudToDeviceConfigRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
            };
            DeviceConfig expectedResponse = new DeviceConfig
            {
                Version = 8314266188006815530L,
                CloudUpdateTime = new wkt::Timestamp(),
                DeviceAckTime = new wkt::Timestamp(),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
            };
            mockGrpcClient.Setup(x => x.ModifyCloudToDeviceConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceConfig response = client.ModifyCloudToDeviceConfig(request.Name, request.BinaryData);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ModifyCloudToDeviceConfigAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            ModifyCloudToDeviceConfigRequest request = new ModifyCloudToDeviceConfigRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
            };
            DeviceConfig expectedResponse = new DeviceConfig
            {
                Version = 8314266188006815530L,
                CloudUpdateTime = new wkt::Timestamp(),
                DeviceAckTime = new wkt::Timestamp(),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
            };
            mockGrpcClient.Setup(x => x.ModifyCloudToDeviceConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeviceConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceConfig responseCallSettings = await client.ModifyCloudToDeviceConfigAsync(request.Name, request.BinaryData, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeviceConfig responseCancellationToken = await client.ModifyCloudToDeviceConfigAsync(request.Name, request.BinaryData, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ModifyCloudToDeviceConfigResourceNames()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            ModifyCloudToDeviceConfigRequest request = new ModifyCloudToDeviceConfigRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
            };
            DeviceConfig expectedResponse = new DeviceConfig
            {
                Version = 8314266188006815530L,
                CloudUpdateTime = new wkt::Timestamp(),
                DeviceAckTime = new wkt::Timestamp(),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
            };
            mockGrpcClient.Setup(x => x.ModifyCloudToDeviceConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceConfig response = client.ModifyCloudToDeviceConfig(request.DeviceName, request.BinaryData);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ModifyCloudToDeviceConfigResourceNamesAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            ModifyCloudToDeviceConfigRequest request = new ModifyCloudToDeviceConfigRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
            };
            DeviceConfig expectedResponse = new DeviceConfig
            {
                Version = 8314266188006815530L,
                CloudUpdateTime = new wkt::Timestamp(),
                DeviceAckTime = new wkt::Timestamp(),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
            };
            mockGrpcClient.Setup(x => x.ModifyCloudToDeviceConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeviceConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            DeviceConfig responseCallSettings = await client.ModifyCloudToDeviceConfigAsync(request.DeviceName, request.BinaryData, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeviceConfig responseCancellationToken = await client.ModifyCloudToDeviceConfigAsync(request.DeviceName, request.BinaryData, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListDeviceConfigVersionsRequestObject()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            ListDeviceConfigVersionsRequest request = new ListDeviceConfigVersionsRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumVersions = -1550316745,
            };
            ListDeviceConfigVersionsResponse expectedResponse = new ListDeviceConfigVersionsResponse
            {
                DeviceConfigs = { new DeviceConfig(), },
            };
            mockGrpcClient.Setup(x => x.ListDeviceConfigVersions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            ListDeviceConfigVersionsResponse response = client.ListDeviceConfigVersions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListDeviceConfigVersionsRequestObjectAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            ListDeviceConfigVersionsRequest request = new ListDeviceConfigVersionsRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumVersions = -1550316745,
            };
            ListDeviceConfigVersionsResponse expectedResponse = new ListDeviceConfigVersionsResponse
            {
                DeviceConfigs = { new DeviceConfig(), },
            };
            mockGrpcClient.Setup(x => x.ListDeviceConfigVersionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListDeviceConfigVersionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            ListDeviceConfigVersionsResponse responseCallSettings = await client.ListDeviceConfigVersionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListDeviceConfigVersionsResponse responseCancellationToken = await client.ListDeviceConfigVersionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListDeviceConfigVersions()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            ListDeviceConfigVersionsRequest request = new ListDeviceConfigVersionsRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            ListDeviceConfigVersionsResponse expectedResponse = new ListDeviceConfigVersionsResponse
            {
                DeviceConfigs = { new DeviceConfig(), },
            };
            mockGrpcClient.Setup(x => x.ListDeviceConfigVersions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            ListDeviceConfigVersionsResponse response = client.ListDeviceConfigVersions(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListDeviceConfigVersionsAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            ListDeviceConfigVersionsRequest request = new ListDeviceConfigVersionsRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            ListDeviceConfigVersionsResponse expectedResponse = new ListDeviceConfigVersionsResponse
            {
                DeviceConfigs = { new DeviceConfig(), },
            };
            mockGrpcClient.Setup(x => x.ListDeviceConfigVersionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListDeviceConfigVersionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            ListDeviceConfigVersionsResponse responseCallSettings = await client.ListDeviceConfigVersionsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListDeviceConfigVersionsResponse responseCancellationToken = await client.ListDeviceConfigVersionsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListDeviceConfigVersionsResourceNames()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            ListDeviceConfigVersionsRequest request = new ListDeviceConfigVersionsRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            ListDeviceConfigVersionsResponse expectedResponse = new ListDeviceConfigVersionsResponse
            {
                DeviceConfigs = { new DeviceConfig(), },
            };
            mockGrpcClient.Setup(x => x.ListDeviceConfigVersions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            ListDeviceConfigVersionsResponse response = client.ListDeviceConfigVersions(request.DeviceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListDeviceConfigVersionsResourceNamesAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            ListDeviceConfigVersionsRequest request = new ListDeviceConfigVersionsRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            ListDeviceConfigVersionsResponse expectedResponse = new ListDeviceConfigVersionsResponse
            {
                DeviceConfigs = { new DeviceConfig(), },
            };
            mockGrpcClient.Setup(x => x.ListDeviceConfigVersionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListDeviceConfigVersionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            ListDeviceConfigVersionsResponse responseCallSettings = await client.ListDeviceConfigVersionsAsync(request.DeviceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListDeviceConfigVersionsResponse responseCancellationToken = await client.ListDeviceConfigVersionsAsync(request.DeviceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListDeviceStatesRequestObject()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            ListDeviceStatesRequest request = new ListDeviceStatesRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumStates = 132159067,
            };
            ListDeviceStatesResponse expectedResponse = new ListDeviceStatesResponse
            {
                DeviceStates = { new DeviceState(), },
            };
            mockGrpcClient.Setup(x => x.ListDeviceStates(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            ListDeviceStatesResponse response = client.ListDeviceStates(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListDeviceStatesRequestObjectAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            ListDeviceStatesRequest request = new ListDeviceStatesRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumStates = 132159067,
            };
            ListDeviceStatesResponse expectedResponse = new ListDeviceStatesResponse
            {
                DeviceStates = { new DeviceState(), },
            };
            mockGrpcClient.Setup(x => x.ListDeviceStatesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListDeviceStatesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            ListDeviceStatesResponse responseCallSettings = await client.ListDeviceStatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListDeviceStatesResponse responseCancellationToken = await client.ListDeviceStatesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListDeviceStates()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            ListDeviceStatesRequest request = new ListDeviceStatesRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            ListDeviceStatesResponse expectedResponse = new ListDeviceStatesResponse
            {
                DeviceStates = { new DeviceState(), },
            };
            mockGrpcClient.Setup(x => x.ListDeviceStates(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            ListDeviceStatesResponse response = client.ListDeviceStates(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListDeviceStatesAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            ListDeviceStatesRequest request = new ListDeviceStatesRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            ListDeviceStatesResponse expectedResponse = new ListDeviceStatesResponse
            {
                DeviceStates = { new DeviceState(), },
            };
            mockGrpcClient.Setup(x => x.ListDeviceStatesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListDeviceStatesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            ListDeviceStatesResponse responseCallSettings = await client.ListDeviceStatesAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListDeviceStatesResponse responseCancellationToken = await client.ListDeviceStatesAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListDeviceStatesResourceNames()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            ListDeviceStatesRequest request = new ListDeviceStatesRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            ListDeviceStatesResponse expectedResponse = new ListDeviceStatesResponse
            {
                DeviceStates = { new DeviceState(), },
            };
            mockGrpcClient.Setup(x => x.ListDeviceStates(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            ListDeviceStatesResponse response = client.ListDeviceStates(request.DeviceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListDeviceStatesResourceNamesAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            ListDeviceStatesRequest request = new ListDeviceStatesRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            ListDeviceStatesResponse expectedResponse = new ListDeviceStatesResponse
            {
                DeviceStates = { new DeviceState(), },
            };
            mockGrpcClient.Setup(x => x.ListDeviceStatesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListDeviceStatesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            ListDeviceStatesResponse responseCallSettings = await client.ListDeviceStatesAsync(request.DeviceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListDeviceStatesResponse responseCancellationToken = await client.ListDeviceStatesAsync(request.DeviceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.Resource, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.Resource, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Resource, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyResourceNames()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.ResourceAsResourceName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyResourceNamesAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyResourceNames()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.ResourceAsResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyResourceNamesAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.ResourceAsResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.ResourceAsResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.Resource, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsResourceNames()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.ResourceAsResourceName, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsResourceNamesAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SendCommandToDeviceRequestObject()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            SendCommandToDeviceRequest request = new SendCommandToDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
                Subfolder = "subfolder6390761f",
            };
            SendCommandToDeviceResponse expectedResponse = new SendCommandToDeviceResponse { };
            mockGrpcClient.Setup(x => x.SendCommandToDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            SendCommandToDeviceResponse response = client.SendCommandToDevice(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SendCommandToDeviceRequestObjectAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            SendCommandToDeviceRequest request = new SendCommandToDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
                Subfolder = "subfolder6390761f",
            };
            SendCommandToDeviceResponse expectedResponse = new SendCommandToDeviceResponse { };
            mockGrpcClient.Setup(x => x.SendCommandToDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SendCommandToDeviceResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            SendCommandToDeviceResponse responseCallSettings = await client.SendCommandToDeviceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SendCommandToDeviceResponse responseCancellationToken = await client.SendCommandToDeviceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SendCommandToDevice1()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            SendCommandToDeviceRequest request = new SendCommandToDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
            };
            SendCommandToDeviceResponse expectedResponse = new SendCommandToDeviceResponse { };
            mockGrpcClient.Setup(x => x.SendCommandToDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            SendCommandToDeviceResponse response = client.SendCommandToDevice(request.Name, request.BinaryData);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SendCommandToDevice1Async()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            SendCommandToDeviceRequest request = new SendCommandToDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
            };
            SendCommandToDeviceResponse expectedResponse = new SendCommandToDeviceResponse { };
            mockGrpcClient.Setup(x => x.SendCommandToDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SendCommandToDeviceResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            SendCommandToDeviceResponse responseCallSettings = await client.SendCommandToDeviceAsync(request.Name, request.BinaryData, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SendCommandToDeviceResponse responseCancellationToken = await client.SendCommandToDeviceAsync(request.Name, request.BinaryData, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SendCommandToDevice1ResourceNames()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            SendCommandToDeviceRequest request = new SendCommandToDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
            };
            SendCommandToDeviceResponse expectedResponse = new SendCommandToDeviceResponse { };
            mockGrpcClient.Setup(x => x.SendCommandToDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            SendCommandToDeviceResponse response = client.SendCommandToDevice(request.DeviceName, request.BinaryData);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SendCommandToDevice1ResourceNamesAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            SendCommandToDeviceRequest request = new SendCommandToDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
            };
            SendCommandToDeviceResponse expectedResponse = new SendCommandToDeviceResponse { };
            mockGrpcClient.Setup(x => x.SendCommandToDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SendCommandToDeviceResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            SendCommandToDeviceResponse responseCallSettings = await client.SendCommandToDeviceAsync(request.DeviceName, request.BinaryData, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SendCommandToDeviceResponse responseCancellationToken = await client.SendCommandToDeviceAsync(request.DeviceName, request.BinaryData, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SendCommandToDevice2()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            SendCommandToDeviceRequest request = new SendCommandToDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
                Subfolder = "subfolder6390761f",
            };
            SendCommandToDeviceResponse expectedResponse = new SendCommandToDeviceResponse { };
            mockGrpcClient.Setup(x => x.SendCommandToDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            SendCommandToDeviceResponse response = client.SendCommandToDevice(request.Name, request.BinaryData, request.Subfolder);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SendCommandToDevice2Async()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            SendCommandToDeviceRequest request = new SendCommandToDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
                Subfolder = "subfolder6390761f",
            };
            SendCommandToDeviceResponse expectedResponse = new SendCommandToDeviceResponse { };
            mockGrpcClient.Setup(x => x.SendCommandToDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SendCommandToDeviceResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            SendCommandToDeviceResponse responseCallSettings = await client.SendCommandToDeviceAsync(request.Name, request.BinaryData, request.Subfolder, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SendCommandToDeviceResponse responseCancellationToken = await client.SendCommandToDeviceAsync(request.Name, request.BinaryData, request.Subfolder, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SendCommandToDevice2ResourceNames()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            SendCommandToDeviceRequest request = new SendCommandToDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
                Subfolder = "subfolder6390761f",
            };
            SendCommandToDeviceResponse expectedResponse = new SendCommandToDeviceResponse { };
            mockGrpcClient.Setup(x => x.SendCommandToDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            SendCommandToDeviceResponse response = client.SendCommandToDevice(request.DeviceName, request.BinaryData, request.Subfolder);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SendCommandToDevice2ResourceNamesAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            SendCommandToDeviceRequest request = new SendCommandToDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                BinaryData = proto::ByteString.CopyFromUtf8("binary_data7b16906c"),
                Subfolder = "subfolder6390761f",
            };
            SendCommandToDeviceResponse expectedResponse = new SendCommandToDeviceResponse { };
            mockGrpcClient.Setup(x => x.SendCommandToDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SendCommandToDeviceResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            SendCommandToDeviceResponse responseCallSettings = await client.SendCommandToDeviceAsync(request.DeviceName, request.BinaryData, request.Subfolder, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SendCommandToDeviceResponse responseCancellationToken = await client.SendCommandToDeviceAsync(request.DeviceName, request.BinaryData, request.Subfolder, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BindDeviceToGatewayRequestObject()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            BindDeviceToGatewayRequest request = new BindDeviceToGatewayRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                GatewayId = "gateway_idd4d89c1e",
                DeviceId = "device_id6c347993",
            };
            BindDeviceToGatewayResponse expectedResponse = new BindDeviceToGatewayResponse { };
            mockGrpcClient.Setup(x => x.BindDeviceToGateway(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            BindDeviceToGatewayResponse response = client.BindDeviceToGateway(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BindDeviceToGatewayRequestObjectAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            BindDeviceToGatewayRequest request = new BindDeviceToGatewayRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                GatewayId = "gateway_idd4d89c1e",
                DeviceId = "device_id6c347993",
            };
            BindDeviceToGatewayResponse expectedResponse = new BindDeviceToGatewayResponse { };
            mockGrpcClient.Setup(x => x.BindDeviceToGatewayAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BindDeviceToGatewayResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            BindDeviceToGatewayResponse responseCallSettings = await client.BindDeviceToGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BindDeviceToGatewayResponse responseCancellationToken = await client.BindDeviceToGatewayAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BindDeviceToGateway()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            BindDeviceToGatewayRequest request = new BindDeviceToGatewayRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                GatewayId = "gateway_idd4d89c1e",
                DeviceId = "device_id6c347993",
            };
            BindDeviceToGatewayResponse expectedResponse = new BindDeviceToGatewayResponse { };
            mockGrpcClient.Setup(x => x.BindDeviceToGateway(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            BindDeviceToGatewayResponse response = client.BindDeviceToGateway(request.Parent, request.GatewayId, request.DeviceId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BindDeviceToGatewayAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            BindDeviceToGatewayRequest request = new BindDeviceToGatewayRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                GatewayId = "gateway_idd4d89c1e",
                DeviceId = "device_id6c347993",
            };
            BindDeviceToGatewayResponse expectedResponse = new BindDeviceToGatewayResponse { };
            mockGrpcClient.Setup(x => x.BindDeviceToGatewayAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BindDeviceToGatewayResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            BindDeviceToGatewayResponse responseCallSettings = await client.BindDeviceToGatewayAsync(request.Parent, request.GatewayId, request.DeviceId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BindDeviceToGatewayResponse responseCancellationToken = await client.BindDeviceToGatewayAsync(request.Parent, request.GatewayId, request.DeviceId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BindDeviceToGatewayResourceNames()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            BindDeviceToGatewayRequest request = new BindDeviceToGatewayRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                GatewayId = "gateway_idd4d89c1e",
                DeviceId = "device_id6c347993",
            };
            BindDeviceToGatewayResponse expectedResponse = new BindDeviceToGatewayResponse { };
            mockGrpcClient.Setup(x => x.BindDeviceToGateway(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            BindDeviceToGatewayResponse response = client.BindDeviceToGateway(request.ParentAsRegistryName, request.GatewayId, request.DeviceId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BindDeviceToGatewayResourceNamesAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            BindDeviceToGatewayRequest request = new BindDeviceToGatewayRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                GatewayId = "gateway_idd4d89c1e",
                DeviceId = "device_id6c347993",
            };
            BindDeviceToGatewayResponse expectedResponse = new BindDeviceToGatewayResponse { };
            mockGrpcClient.Setup(x => x.BindDeviceToGatewayAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BindDeviceToGatewayResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            BindDeviceToGatewayResponse responseCallSettings = await client.BindDeviceToGatewayAsync(request.ParentAsRegistryName, request.GatewayId, request.DeviceId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BindDeviceToGatewayResponse responseCancellationToken = await client.BindDeviceToGatewayAsync(request.ParentAsRegistryName, request.GatewayId, request.DeviceId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UnbindDeviceFromGatewayRequestObject()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            UnbindDeviceFromGatewayRequest request = new UnbindDeviceFromGatewayRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                GatewayId = "gateway_idd4d89c1e",
                DeviceId = "device_id6c347993",
            };
            UnbindDeviceFromGatewayResponse expectedResponse = new UnbindDeviceFromGatewayResponse { };
            mockGrpcClient.Setup(x => x.UnbindDeviceFromGateway(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            UnbindDeviceFromGatewayResponse response = client.UnbindDeviceFromGateway(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UnbindDeviceFromGatewayRequestObjectAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            UnbindDeviceFromGatewayRequest request = new UnbindDeviceFromGatewayRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                GatewayId = "gateway_idd4d89c1e",
                DeviceId = "device_id6c347993",
            };
            UnbindDeviceFromGatewayResponse expectedResponse = new UnbindDeviceFromGatewayResponse { };
            mockGrpcClient.Setup(x => x.UnbindDeviceFromGatewayAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UnbindDeviceFromGatewayResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            UnbindDeviceFromGatewayResponse responseCallSettings = await client.UnbindDeviceFromGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UnbindDeviceFromGatewayResponse responseCancellationToken = await client.UnbindDeviceFromGatewayAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UnbindDeviceFromGateway()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            UnbindDeviceFromGatewayRequest request = new UnbindDeviceFromGatewayRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                GatewayId = "gateway_idd4d89c1e",
                DeviceId = "device_id6c347993",
            };
            UnbindDeviceFromGatewayResponse expectedResponse = new UnbindDeviceFromGatewayResponse { };
            mockGrpcClient.Setup(x => x.UnbindDeviceFromGateway(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            UnbindDeviceFromGatewayResponse response = client.UnbindDeviceFromGateway(request.Parent, request.GatewayId, request.DeviceId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UnbindDeviceFromGatewayAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            UnbindDeviceFromGatewayRequest request = new UnbindDeviceFromGatewayRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                GatewayId = "gateway_idd4d89c1e",
                DeviceId = "device_id6c347993",
            };
            UnbindDeviceFromGatewayResponse expectedResponse = new UnbindDeviceFromGatewayResponse { };
            mockGrpcClient.Setup(x => x.UnbindDeviceFromGatewayAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UnbindDeviceFromGatewayResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            UnbindDeviceFromGatewayResponse responseCallSettings = await client.UnbindDeviceFromGatewayAsync(request.Parent, request.GatewayId, request.DeviceId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UnbindDeviceFromGatewayResponse responseCancellationToken = await client.UnbindDeviceFromGatewayAsync(request.Parent, request.GatewayId, request.DeviceId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UnbindDeviceFromGatewayResourceNames()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            UnbindDeviceFromGatewayRequest request = new UnbindDeviceFromGatewayRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                GatewayId = "gateway_idd4d89c1e",
                DeviceId = "device_id6c347993",
            };
            UnbindDeviceFromGatewayResponse expectedResponse = new UnbindDeviceFromGatewayResponse { };
            mockGrpcClient.Setup(x => x.UnbindDeviceFromGateway(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            UnbindDeviceFromGatewayResponse response = client.UnbindDeviceFromGateway(request.ParentAsRegistryName, request.GatewayId, request.DeviceId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UnbindDeviceFromGatewayResourceNamesAsync()
        {
            moq::Mock<DeviceManager.DeviceManagerClient> mockGrpcClient = new moq::Mock<DeviceManager.DeviceManagerClient>(moq::MockBehavior.Strict);
            UnbindDeviceFromGatewayRequest request = new UnbindDeviceFromGatewayRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                GatewayId = "gateway_idd4d89c1e",
                DeviceId = "device_id6c347993",
            };
            UnbindDeviceFromGatewayResponse expectedResponse = new UnbindDeviceFromGatewayResponse { };
            mockGrpcClient.Setup(x => x.UnbindDeviceFromGatewayAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UnbindDeviceFromGatewayResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeviceManagerClient client = new DeviceManagerClientImpl(mockGrpcClient.Object, null);
            UnbindDeviceFromGatewayResponse responseCallSettings = await client.UnbindDeviceFromGatewayAsync(request.ParentAsRegistryName, request.GatewayId, request.DeviceId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UnbindDeviceFromGatewayResponse responseCancellationToken = await client.UnbindDeviceFromGatewayAsync(request.ParentAsRegistryName, request.GatewayId, request.DeviceId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
