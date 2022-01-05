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
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.Cx.V3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSecuritySettingsServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateSecuritySettingsRequestObject()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            CreateSecuritySettingsRequest request = new CreateSecuritySettingsRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SecuritySettings = new SecuritySettings(),
            };
            SecuritySettings expectedResponse = new SecuritySettings
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                DisplayName = "display_name137f65c2",
                RedactionStrategy = SecuritySettings.Types.RedactionStrategy.Unspecified,
                RedactionScope = SecuritySettings.Types.RedactionScope.RedactDiskStorage,
                RetentionWindowDays = 677846917,
                PurgeDataTypes =
                {
                    SecuritySettings.Types.PurgeDataType.Unspecified,
                },
                InspectTemplateAsInspectTemplateName = InspectTemplateName.FromOrganizationLocationInspectTemplate("[ORGANIZATION]", "[LOCATION]", "[INSPECT_TEMPLATE]"),
                InsightsExportSettings = new SecuritySettings.Types.InsightsExportSettings(),
                DeidentifyTemplateAsDeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationLocationDeidentifyTemplate("[ORGANIZATION]", "[LOCATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            mockGrpcClient.Setup(x => x.CreateSecuritySettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            SecuritySettings response = client.CreateSecuritySettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSecuritySettingsRequestObjectAsync()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            CreateSecuritySettingsRequest request = new CreateSecuritySettingsRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SecuritySettings = new SecuritySettings(),
            };
            SecuritySettings expectedResponse = new SecuritySettings
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                DisplayName = "display_name137f65c2",
                RedactionStrategy = SecuritySettings.Types.RedactionStrategy.Unspecified,
                RedactionScope = SecuritySettings.Types.RedactionScope.RedactDiskStorage,
                RetentionWindowDays = 677846917,
                PurgeDataTypes =
                {
                    SecuritySettings.Types.PurgeDataType.Unspecified,
                },
                InspectTemplateAsInspectTemplateName = InspectTemplateName.FromOrganizationLocationInspectTemplate("[ORGANIZATION]", "[LOCATION]", "[INSPECT_TEMPLATE]"),
                InsightsExportSettings = new SecuritySettings.Types.InsightsExportSettings(),
                DeidentifyTemplateAsDeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationLocationDeidentifyTemplate("[ORGANIZATION]", "[LOCATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            mockGrpcClient.Setup(x => x.CreateSecuritySettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecuritySettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            SecuritySettings responseCallSettings = await client.CreateSecuritySettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecuritySettings responseCancellationToken = await client.CreateSecuritySettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSecuritySettings()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            CreateSecuritySettingsRequest request = new CreateSecuritySettingsRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SecuritySettings = new SecuritySettings(),
            };
            SecuritySettings expectedResponse = new SecuritySettings
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                DisplayName = "display_name137f65c2",
                RedactionStrategy = SecuritySettings.Types.RedactionStrategy.Unspecified,
                RedactionScope = SecuritySettings.Types.RedactionScope.RedactDiskStorage,
                RetentionWindowDays = 677846917,
                PurgeDataTypes =
                {
                    SecuritySettings.Types.PurgeDataType.Unspecified,
                },
                InspectTemplateAsInspectTemplateName = InspectTemplateName.FromOrganizationLocationInspectTemplate("[ORGANIZATION]", "[LOCATION]", "[INSPECT_TEMPLATE]"),
                InsightsExportSettings = new SecuritySettings.Types.InsightsExportSettings(),
                DeidentifyTemplateAsDeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationLocationDeidentifyTemplate("[ORGANIZATION]", "[LOCATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            mockGrpcClient.Setup(x => x.CreateSecuritySettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            SecuritySettings response = client.CreateSecuritySettings(request.Parent, request.SecuritySettings);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSecuritySettingsAsync()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            CreateSecuritySettingsRequest request = new CreateSecuritySettingsRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SecuritySettings = new SecuritySettings(),
            };
            SecuritySettings expectedResponse = new SecuritySettings
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                DisplayName = "display_name137f65c2",
                RedactionStrategy = SecuritySettings.Types.RedactionStrategy.Unspecified,
                RedactionScope = SecuritySettings.Types.RedactionScope.RedactDiskStorage,
                RetentionWindowDays = 677846917,
                PurgeDataTypes =
                {
                    SecuritySettings.Types.PurgeDataType.Unspecified,
                },
                InspectTemplateAsInspectTemplateName = InspectTemplateName.FromOrganizationLocationInspectTemplate("[ORGANIZATION]", "[LOCATION]", "[INSPECT_TEMPLATE]"),
                InsightsExportSettings = new SecuritySettings.Types.InsightsExportSettings(),
                DeidentifyTemplateAsDeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationLocationDeidentifyTemplate("[ORGANIZATION]", "[LOCATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            mockGrpcClient.Setup(x => x.CreateSecuritySettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecuritySettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            SecuritySettings responseCallSettings = await client.CreateSecuritySettingsAsync(request.Parent, request.SecuritySettings, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecuritySettings responseCancellationToken = await client.CreateSecuritySettingsAsync(request.Parent, request.SecuritySettings, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSecuritySettingsResourceNames()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            CreateSecuritySettingsRequest request = new CreateSecuritySettingsRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SecuritySettings = new SecuritySettings(),
            };
            SecuritySettings expectedResponse = new SecuritySettings
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                DisplayName = "display_name137f65c2",
                RedactionStrategy = SecuritySettings.Types.RedactionStrategy.Unspecified,
                RedactionScope = SecuritySettings.Types.RedactionScope.RedactDiskStorage,
                RetentionWindowDays = 677846917,
                PurgeDataTypes =
                {
                    SecuritySettings.Types.PurgeDataType.Unspecified,
                },
                InspectTemplateAsInspectTemplateName = InspectTemplateName.FromOrganizationLocationInspectTemplate("[ORGANIZATION]", "[LOCATION]", "[INSPECT_TEMPLATE]"),
                InsightsExportSettings = new SecuritySettings.Types.InsightsExportSettings(),
                DeidentifyTemplateAsDeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationLocationDeidentifyTemplate("[ORGANIZATION]", "[LOCATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            mockGrpcClient.Setup(x => x.CreateSecuritySettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            SecuritySettings response = client.CreateSecuritySettings(request.ParentAsLocationName, request.SecuritySettings);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSecuritySettingsResourceNamesAsync()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            CreateSecuritySettingsRequest request = new CreateSecuritySettingsRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SecuritySettings = new SecuritySettings(),
            };
            SecuritySettings expectedResponse = new SecuritySettings
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                DisplayName = "display_name137f65c2",
                RedactionStrategy = SecuritySettings.Types.RedactionStrategy.Unspecified,
                RedactionScope = SecuritySettings.Types.RedactionScope.RedactDiskStorage,
                RetentionWindowDays = 677846917,
                PurgeDataTypes =
                {
                    SecuritySettings.Types.PurgeDataType.Unspecified,
                },
                InspectTemplateAsInspectTemplateName = InspectTemplateName.FromOrganizationLocationInspectTemplate("[ORGANIZATION]", "[LOCATION]", "[INSPECT_TEMPLATE]"),
                InsightsExportSettings = new SecuritySettings.Types.InsightsExportSettings(),
                DeidentifyTemplateAsDeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationLocationDeidentifyTemplate("[ORGANIZATION]", "[LOCATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            mockGrpcClient.Setup(x => x.CreateSecuritySettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecuritySettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            SecuritySettings responseCallSettings = await client.CreateSecuritySettingsAsync(request.ParentAsLocationName, request.SecuritySettings, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecuritySettings responseCancellationToken = await client.CreateSecuritySettingsAsync(request.ParentAsLocationName, request.SecuritySettings, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSecuritySettingsRequestObject()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            GetSecuritySettingsRequest request = new GetSecuritySettingsRequest
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
            };
            SecuritySettings expectedResponse = new SecuritySettings
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                DisplayName = "display_name137f65c2",
                RedactionStrategy = SecuritySettings.Types.RedactionStrategy.Unspecified,
                RedactionScope = SecuritySettings.Types.RedactionScope.RedactDiskStorage,
                RetentionWindowDays = 677846917,
                PurgeDataTypes =
                {
                    SecuritySettings.Types.PurgeDataType.Unspecified,
                },
                InspectTemplateAsInspectTemplateName = InspectTemplateName.FromOrganizationLocationInspectTemplate("[ORGANIZATION]", "[LOCATION]", "[INSPECT_TEMPLATE]"),
                InsightsExportSettings = new SecuritySettings.Types.InsightsExportSettings(),
                DeidentifyTemplateAsDeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationLocationDeidentifyTemplate("[ORGANIZATION]", "[LOCATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            mockGrpcClient.Setup(x => x.GetSecuritySettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            SecuritySettings response = client.GetSecuritySettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSecuritySettingsRequestObjectAsync()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            GetSecuritySettingsRequest request = new GetSecuritySettingsRequest
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
            };
            SecuritySettings expectedResponse = new SecuritySettings
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                DisplayName = "display_name137f65c2",
                RedactionStrategy = SecuritySettings.Types.RedactionStrategy.Unspecified,
                RedactionScope = SecuritySettings.Types.RedactionScope.RedactDiskStorage,
                RetentionWindowDays = 677846917,
                PurgeDataTypes =
                {
                    SecuritySettings.Types.PurgeDataType.Unspecified,
                },
                InspectTemplateAsInspectTemplateName = InspectTemplateName.FromOrganizationLocationInspectTemplate("[ORGANIZATION]", "[LOCATION]", "[INSPECT_TEMPLATE]"),
                InsightsExportSettings = new SecuritySettings.Types.InsightsExportSettings(),
                DeidentifyTemplateAsDeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationLocationDeidentifyTemplate("[ORGANIZATION]", "[LOCATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            mockGrpcClient.Setup(x => x.GetSecuritySettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecuritySettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            SecuritySettings responseCallSettings = await client.GetSecuritySettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecuritySettings responseCancellationToken = await client.GetSecuritySettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSecuritySettings()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            GetSecuritySettingsRequest request = new GetSecuritySettingsRequest
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
            };
            SecuritySettings expectedResponse = new SecuritySettings
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                DisplayName = "display_name137f65c2",
                RedactionStrategy = SecuritySettings.Types.RedactionStrategy.Unspecified,
                RedactionScope = SecuritySettings.Types.RedactionScope.RedactDiskStorage,
                RetentionWindowDays = 677846917,
                PurgeDataTypes =
                {
                    SecuritySettings.Types.PurgeDataType.Unspecified,
                },
                InspectTemplateAsInspectTemplateName = InspectTemplateName.FromOrganizationLocationInspectTemplate("[ORGANIZATION]", "[LOCATION]", "[INSPECT_TEMPLATE]"),
                InsightsExportSettings = new SecuritySettings.Types.InsightsExportSettings(),
                DeidentifyTemplateAsDeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationLocationDeidentifyTemplate("[ORGANIZATION]", "[LOCATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            mockGrpcClient.Setup(x => x.GetSecuritySettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            SecuritySettings response = client.GetSecuritySettings(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSecuritySettingsAsync()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            GetSecuritySettingsRequest request = new GetSecuritySettingsRequest
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
            };
            SecuritySettings expectedResponse = new SecuritySettings
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                DisplayName = "display_name137f65c2",
                RedactionStrategy = SecuritySettings.Types.RedactionStrategy.Unspecified,
                RedactionScope = SecuritySettings.Types.RedactionScope.RedactDiskStorage,
                RetentionWindowDays = 677846917,
                PurgeDataTypes =
                {
                    SecuritySettings.Types.PurgeDataType.Unspecified,
                },
                InspectTemplateAsInspectTemplateName = InspectTemplateName.FromOrganizationLocationInspectTemplate("[ORGANIZATION]", "[LOCATION]", "[INSPECT_TEMPLATE]"),
                InsightsExportSettings = new SecuritySettings.Types.InsightsExportSettings(),
                DeidentifyTemplateAsDeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationLocationDeidentifyTemplate("[ORGANIZATION]", "[LOCATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            mockGrpcClient.Setup(x => x.GetSecuritySettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecuritySettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            SecuritySettings responseCallSettings = await client.GetSecuritySettingsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecuritySettings responseCancellationToken = await client.GetSecuritySettingsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSecuritySettingsResourceNames()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            GetSecuritySettingsRequest request = new GetSecuritySettingsRequest
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
            };
            SecuritySettings expectedResponse = new SecuritySettings
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                DisplayName = "display_name137f65c2",
                RedactionStrategy = SecuritySettings.Types.RedactionStrategy.Unspecified,
                RedactionScope = SecuritySettings.Types.RedactionScope.RedactDiskStorage,
                RetentionWindowDays = 677846917,
                PurgeDataTypes =
                {
                    SecuritySettings.Types.PurgeDataType.Unspecified,
                },
                InspectTemplateAsInspectTemplateName = InspectTemplateName.FromOrganizationLocationInspectTemplate("[ORGANIZATION]", "[LOCATION]", "[INSPECT_TEMPLATE]"),
                InsightsExportSettings = new SecuritySettings.Types.InsightsExportSettings(),
                DeidentifyTemplateAsDeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationLocationDeidentifyTemplate("[ORGANIZATION]", "[LOCATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            mockGrpcClient.Setup(x => x.GetSecuritySettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            SecuritySettings response = client.GetSecuritySettings(request.SecuritySettingsName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSecuritySettingsResourceNamesAsync()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            GetSecuritySettingsRequest request = new GetSecuritySettingsRequest
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
            };
            SecuritySettings expectedResponse = new SecuritySettings
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                DisplayName = "display_name137f65c2",
                RedactionStrategy = SecuritySettings.Types.RedactionStrategy.Unspecified,
                RedactionScope = SecuritySettings.Types.RedactionScope.RedactDiskStorage,
                RetentionWindowDays = 677846917,
                PurgeDataTypes =
                {
                    SecuritySettings.Types.PurgeDataType.Unspecified,
                },
                InspectTemplateAsInspectTemplateName = InspectTemplateName.FromOrganizationLocationInspectTemplate("[ORGANIZATION]", "[LOCATION]", "[INSPECT_TEMPLATE]"),
                InsightsExportSettings = new SecuritySettings.Types.InsightsExportSettings(),
                DeidentifyTemplateAsDeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationLocationDeidentifyTemplate("[ORGANIZATION]", "[LOCATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            mockGrpcClient.Setup(x => x.GetSecuritySettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecuritySettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            SecuritySettings responseCallSettings = await client.GetSecuritySettingsAsync(request.SecuritySettingsName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecuritySettings responseCancellationToken = await client.GetSecuritySettingsAsync(request.SecuritySettingsName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSecuritySettingsRequestObject()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            UpdateSecuritySettingsRequest request = new UpdateSecuritySettingsRequest
            {
                SecuritySettings = new SecuritySettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            SecuritySettings expectedResponse = new SecuritySettings
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                DisplayName = "display_name137f65c2",
                RedactionStrategy = SecuritySettings.Types.RedactionStrategy.Unspecified,
                RedactionScope = SecuritySettings.Types.RedactionScope.RedactDiskStorage,
                RetentionWindowDays = 677846917,
                PurgeDataTypes =
                {
                    SecuritySettings.Types.PurgeDataType.Unspecified,
                },
                InspectTemplateAsInspectTemplateName = InspectTemplateName.FromOrganizationLocationInspectTemplate("[ORGANIZATION]", "[LOCATION]", "[INSPECT_TEMPLATE]"),
                InsightsExportSettings = new SecuritySettings.Types.InsightsExportSettings(),
                DeidentifyTemplateAsDeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationLocationDeidentifyTemplate("[ORGANIZATION]", "[LOCATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSecuritySettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            SecuritySettings response = client.UpdateSecuritySettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSecuritySettingsRequestObjectAsync()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            UpdateSecuritySettingsRequest request = new UpdateSecuritySettingsRequest
            {
                SecuritySettings = new SecuritySettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            SecuritySettings expectedResponse = new SecuritySettings
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                DisplayName = "display_name137f65c2",
                RedactionStrategy = SecuritySettings.Types.RedactionStrategy.Unspecified,
                RedactionScope = SecuritySettings.Types.RedactionScope.RedactDiskStorage,
                RetentionWindowDays = 677846917,
                PurgeDataTypes =
                {
                    SecuritySettings.Types.PurgeDataType.Unspecified,
                },
                InspectTemplateAsInspectTemplateName = InspectTemplateName.FromOrganizationLocationInspectTemplate("[ORGANIZATION]", "[LOCATION]", "[INSPECT_TEMPLATE]"),
                InsightsExportSettings = new SecuritySettings.Types.InsightsExportSettings(),
                DeidentifyTemplateAsDeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationLocationDeidentifyTemplate("[ORGANIZATION]", "[LOCATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSecuritySettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecuritySettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            SecuritySettings responseCallSettings = await client.UpdateSecuritySettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecuritySettings responseCancellationToken = await client.UpdateSecuritySettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSecuritySettings()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            UpdateSecuritySettingsRequest request = new UpdateSecuritySettingsRequest
            {
                SecuritySettings = new SecuritySettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            SecuritySettings expectedResponse = new SecuritySettings
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                DisplayName = "display_name137f65c2",
                RedactionStrategy = SecuritySettings.Types.RedactionStrategy.Unspecified,
                RedactionScope = SecuritySettings.Types.RedactionScope.RedactDiskStorage,
                RetentionWindowDays = 677846917,
                PurgeDataTypes =
                {
                    SecuritySettings.Types.PurgeDataType.Unspecified,
                },
                InspectTemplateAsInspectTemplateName = InspectTemplateName.FromOrganizationLocationInspectTemplate("[ORGANIZATION]", "[LOCATION]", "[INSPECT_TEMPLATE]"),
                InsightsExportSettings = new SecuritySettings.Types.InsightsExportSettings(),
                DeidentifyTemplateAsDeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationLocationDeidentifyTemplate("[ORGANIZATION]", "[LOCATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSecuritySettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            SecuritySettings response = client.UpdateSecuritySettings(request.SecuritySettings, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSecuritySettingsAsync()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            UpdateSecuritySettingsRequest request = new UpdateSecuritySettingsRequest
            {
                SecuritySettings = new SecuritySettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            SecuritySettings expectedResponse = new SecuritySettings
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                DisplayName = "display_name137f65c2",
                RedactionStrategy = SecuritySettings.Types.RedactionStrategy.Unspecified,
                RedactionScope = SecuritySettings.Types.RedactionScope.RedactDiskStorage,
                RetentionWindowDays = 677846917,
                PurgeDataTypes =
                {
                    SecuritySettings.Types.PurgeDataType.Unspecified,
                },
                InspectTemplateAsInspectTemplateName = InspectTemplateName.FromOrganizationLocationInspectTemplate("[ORGANIZATION]", "[LOCATION]", "[INSPECT_TEMPLATE]"),
                InsightsExportSettings = new SecuritySettings.Types.InsightsExportSettings(),
                DeidentifyTemplateAsDeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationLocationDeidentifyTemplate("[ORGANIZATION]", "[LOCATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSecuritySettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecuritySettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            SecuritySettings responseCallSettings = await client.UpdateSecuritySettingsAsync(request.SecuritySettings, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecuritySettings responseCancellationToken = await client.UpdateSecuritySettingsAsync(request.SecuritySettings, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSecuritySettingsRequestObject()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            DeleteSecuritySettingsRequest request = new DeleteSecuritySettingsRequest
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSecuritySettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteSecuritySettings(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSecuritySettingsRequestObjectAsync()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            DeleteSecuritySettingsRequest request = new DeleteSecuritySettingsRequest
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSecuritySettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSecuritySettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSecuritySettingsAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSecuritySettings()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            DeleteSecuritySettingsRequest request = new DeleteSecuritySettingsRequest
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSecuritySettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteSecuritySettings(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSecuritySettingsAsync()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            DeleteSecuritySettingsRequest request = new DeleteSecuritySettingsRequest
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSecuritySettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSecuritySettingsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSecuritySettingsAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSecuritySettingsResourceNames()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            DeleteSecuritySettingsRequest request = new DeleteSecuritySettingsRequest
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSecuritySettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteSecuritySettings(request.SecuritySettingsName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSecuritySettingsResourceNamesAsync()
        {
            moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient> mockGrpcClient = new moq::Mock<SecuritySettingsService.SecuritySettingsServiceClient>(moq::MockBehavior.Strict);
            DeleteSecuritySettingsRequest request = new DeleteSecuritySettingsRequest
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSecuritySettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecuritySettingsServiceClient client = new SecuritySettingsServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSecuritySettingsAsync(request.SecuritySettingsName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSecuritySettingsAsync(request.SecuritySettingsName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
