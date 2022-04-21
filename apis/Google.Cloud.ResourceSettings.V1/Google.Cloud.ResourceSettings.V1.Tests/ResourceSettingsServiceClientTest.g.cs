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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.ResourceSettings.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedResourceSettingsServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetSettingRequestObject()
        {
            moq::Mock<ResourceSettingsService.ResourceSettingsServiceClient> mockGrpcClient = new moq::Mock<ResourceSettingsService.ResourceSettingsServiceClient>(moq::MockBehavior.Strict);
            GetSettingRequest request = new GetSettingRequest
            {
                SettingName = SettingName.FromProjectNumberSettingName("[PROJECT_NUMBER]", "[SETTING_NAME]"),
                View = SettingView.Basic,
            };
            Setting expectedResponse = new Setting
            {
                SettingName = SettingName.FromProjectNumberSettingName("[PROJECT_NUMBER]", "[SETTING_NAME]"),
                Metadata = new SettingMetadata(),
                LocalValue = new Value(),
                EffectiveValue = new Value(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ResourceSettingsServiceClient client = new ResourceSettingsServiceClientImpl(mockGrpcClient.Object, null, null);
            Setting response = client.GetSetting(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSettingRequestObjectAsync()
        {
            moq::Mock<ResourceSettingsService.ResourceSettingsServiceClient> mockGrpcClient = new moq::Mock<ResourceSettingsService.ResourceSettingsServiceClient>(moq::MockBehavior.Strict);
            GetSettingRequest request = new GetSettingRequest
            {
                SettingName = SettingName.FromProjectNumberSettingName("[PROJECT_NUMBER]", "[SETTING_NAME]"),
                View = SettingView.Basic,
            };
            Setting expectedResponse = new Setting
            {
                SettingName = SettingName.FromProjectNumberSettingName("[PROJECT_NUMBER]", "[SETTING_NAME]"),
                Metadata = new SettingMetadata(),
                LocalValue = new Value(),
                EffectiveValue = new Value(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Setting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ResourceSettingsServiceClient client = new ResourceSettingsServiceClientImpl(mockGrpcClient.Object, null, null);
            Setting responseCallSettings = await client.GetSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Setting responseCancellationToken = await client.GetSettingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSetting()
        {
            moq::Mock<ResourceSettingsService.ResourceSettingsServiceClient> mockGrpcClient = new moq::Mock<ResourceSettingsService.ResourceSettingsServiceClient>(moq::MockBehavior.Strict);
            GetSettingRequest request = new GetSettingRequest
            {
                SettingName = SettingName.FromProjectNumberSettingName("[PROJECT_NUMBER]", "[SETTING_NAME]"),
            };
            Setting expectedResponse = new Setting
            {
                SettingName = SettingName.FromProjectNumberSettingName("[PROJECT_NUMBER]", "[SETTING_NAME]"),
                Metadata = new SettingMetadata(),
                LocalValue = new Value(),
                EffectiveValue = new Value(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ResourceSettingsServiceClient client = new ResourceSettingsServiceClientImpl(mockGrpcClient.Object, null, null);
            Setting response = client.GetSetting(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSettingAsync()
        {
            moq::Mock<ResourceSettingsService.ResourceSettingsServiceClient> mockGrpcClient = new moq::Mock<ResourceSettingsService.ResourceSettingsServiceClient>(moq::MockBehavior.Strict);
            GetSettingRequest request = new GetSettingRequest
            {
                SettingName = SettingName.FromProjectNumberSettingName("[PROJECT_NUMBER]", "[SETTING_NAME]"),
            };
            Setting expectedResponse = new Setting
            {
                SettingName = SettingName.FromProjectNumberSettingName("[PROJECT_NUMBER]", "[SETTING_NAME]"),
                Metadata = new SettingMetadata(),
                LocalValue = new Value(),
                EffectiveValue = new Value(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Setting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ResourceSettingsServiceClient client = new ResourceSettingsServiceClientImpl(mockGrpcClient.Object, null, null);
            Setting responseCallSettings = await client.GetSettingAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Setting responseCancellationToken = await client.GetSettingAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSettingResourceNames()
        {
            moq::Mock<ResourceSettingsService.ResourceSettingsServiceClient> mockGrpcClient = new moq::Mock<ResourceSettingsService.ResourceSettingsServiceClient>(moq::MockBehavior.Strict);
            GetSettingRequest request = new GetSettingRequest
            {
                SettingName = SettingName.FromProjectNumberSettingName("[PROJECT_NUMBER]", "[SETTING_NAME]"),
            };
            Setting expectedResponse = new Setting
            {
                SettingName = SettingName.FromProjectNumberSettingName("[PROJECT_NUMBER]", "[SETTING_NAME]"),
                Metadata = new SettingMetadata(),
                LocalValue = new Value(),
                EffectiveValue = new Value(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ResourceSettingsServiceClient client = new ResourceSettingsServiceClientImpl(mockGrpcClient.Object, null, null);
            Setting response = client.GetSetting(request.SettingName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSettingResourceNamesAsync()
        {
            moq::Mock<ResourceSettingsService.ResourceSettingsServiceClient> mockGrpcClient = new moq::Mock<ResourceSettingsService.ResourceSettingsServiceClient>(moq::MockBehavior.Strict);
            GetSettingRequest request = new GetSettingRequest
            {
                SettingName = SettingName.FromProjectNumberSettingName("[PROJECT_NUMBER]", "[SETTING_NAME]"),
            };
            Setting expectedResponse = new Setting
            {
                SettingName = SettingName.FromProjectNumberSettingName("[PROJECT_NUMBER]", "[SETTING_NAME]"),
                Metadata = new SettingMetadata(),
                LocalValue = new Value(),
                EffectiveValue = new Value(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Setting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ResourceSettingsServiceClient client = new ResourceSettingsServiceClientImpl(mockGrpcClient.Object, null, null);
            Setting responseCallSettings = await client.GetSettingAsync(request.SettingName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Setting responseCancellationToken = await client.GetSettingAsync(request.SettingName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSettingRequestObject()
        {
            moq::Mock<ResourceSettingsService.ResourceSettingsServiceClient> mockGrpcClient = new moq::Mock<ResourceSettingsService.ResourceSettingsServiceClient>(moq::MockBehavior.Strict);
            UpdateSettingRequest request = new UpdateSettingRequest
            {
                Setting = new Setting(),
            };
            Setting expectedResponse = new Setting
            {
                SettingName = SettingName.FromProjectNumberSettingName("[PROJECT_NUMBER]", "[SETTING_NAME]"),
                Metadata = new SettingMetadata(),
                LocalValue = new Value(),
                EffectiveValue = new Value(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.UpdateSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ResourceSettingsServiceClient client = new ResourceSettingsServiceClientImpl(mockGrpcClient.Object, null, null);
            Setting response = client.UpdateSetting(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSettingRequestObjectAsync()
        {
            moq::Mock<ResourceSettingsService.ResourceSettingsServiceClient> mockGrpcClient = new moq::Mock<ResourceSettingsService.ResourceSettingsServiceClient>(moq::MockBehavior.Strict);
            UpdateSettingRequest request = new UpdateSettingRequest
            {
                Setting = new Setting(),
            };
            Setting expectedResponse = new Setting
            {
                SettingName = SettingName.FromProjectNumberSettingName("[PROJECT_NUMBER]", "[SETTING_NAME]"),
                Metadata = new SettingMetadata(),
                LocalValue = new Value(),
                EffectiveValue = new Value(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.UpdateSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Setting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ResourceSettingsServiceClient client = new ResourceSettingsServiceClientImpl(mockGrpcClient.Object, null, null);
            Setting responseCallSettings = await client.UpdateSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Setting responseCancellationToken = await client.UpdateSettingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
