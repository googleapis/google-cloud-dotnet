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
using gagr = Google.Api.Gax.ResourceNames;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dlp.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDlpServiceClientTest
    {
        [xunit::FactAttribute]
        public void InspectContentRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            InspectContentRequest request = new InspectContentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                InspectConfig = new InspectConfig(),
                Item = new ContentItem(),
                InspectTemplateName = "inspect_template_name5c2c4dc3",
                LocationId = "location_iddaa574e2",
            };
            InspectContentResponse expectedResponse = new InspectContentResponse
            {
                Result = new InspectResult(),
            };
            mockGrpcClient.Setup(x => x.InspectContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectContentResponse response = client.InspectContent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InspectContentRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            InspectContentRequest request = new InspectContentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                InspectConfig = new InspectConfig(),
                Item = new ContentItem(),
                InspectTemplateName = "inspect_template_name5c2c4dc3",
                LocationId = "location_iddaa574e2",
            };
            InspectContentResponse expectedResponse = new InspectContentResponse
            {
                Result = new InspectResult(),
            };
            mockGrpcClient.Setup(x => x.InspectContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InspectContentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectContentResponse responseCallSettings = await client.InspectContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InspectContentResponse responseCancellationToken = await client.InspectContentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RedactImageRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            RedactImageRequest request = new RedactImageRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                InspectConfig = new InspectConfig(),
                ImageRedactionConfigs =
                {
                    new RedactImageRequest.Types.ImageRedactionConfig(),
                },
                IncludeFindings = true,
                ByteItem = new ByteContentItem(),
                LocationId = "location_iddaa574e2",
            };
            RedactImageResponse expectedResponse = new RedactImageResponse
            {
                RedactedImage = proto::ByteString.CopyFromUtf8("redacted_imageee2812ab"),
                ExtractedText = "extracted_textfa8f04c5",
                InspectResult = new InspectResult(),
            };
            mockGrpcClient.Setup(x => x.RedactImage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            RedactImageResponse response = client.RedactImage(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RedactImageRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            RedactImageRequest request = new RedactImageRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                InspectConfig = new InspectConfig(),
                ImageRedactionConfigs =
                {
                    new RedactImageRequest.Types.ImageRedactionConfig(),
                },
                IncludeFindings = true,
                ByteItem = new ByteContentItem(),
                LocationId = "location_iddaa574e2",
            };
            RedactImageResponse expectedResponse = new RedactImageResponse
            {
                RedactedImage = proto::ByteString.CopyFromUtf8("redacted_imageee2812ab"),
                ExtractedText = "extracted_textfa8f04c5",
                InspectResult = new InspectResult(),
            };
            mockGrpcClient.Setup(x => x.RedactImageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RedactImageResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            RedactImageResponse responseCallSettings = await client.RedactImageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RedactImageResponse responseCancellationToken = await client.RedactImageAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeidentifyContentRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeidentifyContentRequest request = new DeidentifyContentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DeidentifyConfig = new DeidentifyConfig(),
                InspectConfig = new InspectConfig(),
                Item = new ContentItem(),
                InspectTemplateName = "inspect_template_name5c2c4dc3",
                DeidentifyTemplateName = "deidentify_template_namef148dd21",
                LocationId = "location_iddaa574e2",
            };
            DeidentifyContentResponse expectedResponse = new DeidentifyContentResponse
            {
                Item = new ContentItem(),
                Overview = new TransformationOverview(),
            };
            mockGrpcClient.Setup(x => x.DeidentifyContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyContentResponse response = client.DeidentifyContent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeidentifyContentRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeidentifyContentRequest request = new DeidentifyContentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DeidentifyConfig = new DeidentifyConfig(),
                InspectConfig = new InspectConfig(),
                Item = new ContentItem(),
                InspectTemplateName = "inspect_template_name5c2c4dc3",
                DeidentifyTemplateName = "deidentify_template_namef148dd21",
                LocationId = "location_iddaa574e2",
            };
            DeidentifyContentResponse expectedResponse = new DeidentifyContentResponse
            {
                Item = new ContentItem(),
                Overview = new TransformationOverview(),
            };
            mockGrpcClient.Setup(x => x.DeidentifyContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeidentifyContentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyContentResponse responseCallSettings = await client.DeidentifyContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeidentifyContentResponse responseCancellationToken = await client.DeidentifyContentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReidentifyContentRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            ReidentifyContentRequest request = new ReidentifyContentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                ReidentifyConfig = new DeidentifyConfig(),
                InspectConfig = new InspectConfig(),
                Item = new ContentItem(),
                InspectTemplateName = "inspect_template_name5c2c4dc3",
                ReidentifyTemplateName = "reidentify_template_name38eca8f4",
                LocationId = "location_iddaa574e2",
            };
            ReidentifyContentResponse expectedResponse = new ReidentifyContentResponse
            {
                Item = new ContentItem(),
                Overview = new TransformationOverview(),
            };
            mockGrpcClient.Setup(x => x.ReidentifyContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            ReidentifyContentResponse response = client.ReidentifyContent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReidentifyContentRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            ReidentifyContentRequest request = new ReidentifyContentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                ReidentifyConfig = new DeidentifyConfig(),
                InspectConfig = new InspectConfig(),
                Item = new ContentItem(),
                InspectTemplateName = "inspect_template_name5c2c4dc3",
                ReidentifyTemplateName = "reidentify_template_name38eca8f4",
                LocationId = "location_iddaa574e2",
            };
            ReidentifyContentResponse expectedResponse = new ReidentifyContentResponse
            {
                Item = new ContentItem(),
                Overview = new TransformationOverview(),
            };
            mockGrpcClient.Setup(x => x.ReidentifyContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReidentifyContentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            ReidentifyContentResponse responseCallSettings = await client.ReidentifyContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReidentifyContentResponse responseCancellationToken = await client.ReidentifyContentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListInfoTypesRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            ListInfoTypesRequest request = new ListInfoTypesRequest
            {
                LanguageCode = "language_code2f6c7160",
                Filter = "filtere47ac9b2",
                LocationId = "location_iddaa574e2",
                Parent = "parent7858e4d0",
            };
            ListInfoTypesResponse expectedResponse = new ListInfoTypesResponse
            {
                InfoTypes =
                {
                    new InfoTypeDescription(),
                },
            };
            mockGrpcClient.Setup(x => x.ListInfoTypes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            ListInfoTypesResponse response = client.ListInfoTypes(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListInfoTypesRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            ListInfoTypesRequest request = new ListInfoTypesRequest
            {
                LanguageCode = "language_code2f6c7160",
                Filter = "filtere47ac9b2",
                LocationId = "location_iddaa574e2",
                Parent = "parent7858e4d0",
            };
            ListInfoTypesResponse expectedResponse = new ListInfoTypesResponse
            {
                InfoTypes =
                {
                    new InfoTypeDescription(),
                },
            };
            mockGrpcClient.Setup(x => x.ListInfoTypesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListInfoTypesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            ListInfoTypesResponse responseCallSettings = await client.ListInfoTypesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListInfoTypesResponse responseCancellationToken = await client.ListInfoTypesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListInfoTypes()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            ListInfoTypesRequest request = new ListInfoTypesRequest
            {
                Parent = "parent7858e4d0",
            };
            ListInfoTypesResponse expectedResponse = new ListInfoTypesResponse
            {
                InfoTypes =
                {
                    new InfoTypeDescription(),
                },
            };
            mockGrpcClient.Setup(x => x.ListInfoTypes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            ListInfoTypesResponse response = client.ListInfoTypes(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListInfoTypesAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            ListInfoTypesRequest request = new ListInfoTypesRequest
            {
                Parent = "parent7858e4d0",
            };
            ListInfoTypesResponse expectedResponse = new ListInfoTypesResponse
            {
                InfoTypes =
                {
                    new InfoTypeDescription(),
                },
            };
            mockGrpcClient.Setup(x => x.ListInfoTypesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListInfoTypesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            ListInfoTypesResponse responseCallSettings = await client.ListInfoTypesAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListInfoTypesResponse responseCancellationToken = await client.ListInfoTypesAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateInspectTemplateRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateInspectTemplateRequest request = new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                InspectTemplate = new InspectTemplate(),
                TemplateId = "template_id6435f574",
                LocationId = "location_iddaa574e2",
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateInspectTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate response = client.CreateInspectTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateInspectTemplateRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateInspectTemplateRequest request = new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                InspectTemplate = new InspectTemplate(),
                TemplateId = "template_id6435f574",
                LocationId = "location_iddaa574e2",
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateInspectTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InspectTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate responseCallSettings = await client.CreateInspectTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InspectTemplate responseCancellationToken = await client.CreateInspectTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateInspectTemplate()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateInspectTemplateRequest request = new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                InspectTemplate = new InspectTemplate(),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateInspectTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate response = client.CreateInspectTemplate(request.Parent, request.InspectTemplate);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateInspectTemplateAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateInspectTemplateRequest request = new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                InspectTemplate = new InspectTemplate(),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateInspectTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InspectTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate responseCallSettings = await client.CreateInspectTemplateAsync(request.Parent, request.InspectTemplate, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InspectTemplate responseCancellationToken = await client.CreateInspectTemplateAsync(request.Parent, request.InspectTemplate, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateInspectTemplateResourceNames1()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateInspectTemplateRequest request = new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                InspectTemplate = new InspectTemplate(),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateInspectTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate response = client.CreateInspectTemplate(request.ParentAsOrganizationName, request.InspectTemplate);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateInspectTemplateResourceNames1Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateInspectTemplateRequest request = new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                InspectTemplate = new InspectTemplate(),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateInspectTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InspectTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate responseCallSettings = await client.CreateInspectTemplateAsync(request.ParentAsOrganizationName, request.InspectTemplate, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InspectTemplate responseCancellationToken = await client.CreateInspectTemplateAsync(request.ParentAsOrganizationName, request.InspectTemplate, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateInspectTemplateResourceNames2()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateInspectTemplateRequest request = new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                InspectTemplate = new InspectTemplate(),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateInspectTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate response = client.CreateInspectTemplate(request.ParentAsProjectName, request.InspectTemplate);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateInspectTemplateResourceNames2Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateInspectTemplateRequest request = new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                InspectTemplate = new InspectTemplate(),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateInspectTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InspectTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate responseCallSettings = await client.CreateInspectTemplateAsync(request.ParentAsProjectName, request.InspectTemplate, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InspectTemplate responseCancellationToken = await client.CreateInspectTemplateAsync(request.ParentAsProjectName, request.InspectTemplate, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateInspectTemplateResourceNames3()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateInspectTemplateRequest request = new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                InspectTemplate = new InspectTemplate(),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateInspectTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate response = client.CreateInspectTemplate(request.ParentAsOrganizationLocationName, request.InspectTemplate);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateInspectTemplateResourceNames3Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateInspectTemplateRequest request = new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                InspectTemplate = new InspectTemplate(),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateInspectTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InspectTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate responseCallSettings = await client.CreateInspectTemplateAsync(request.ParentAsOrganizationLocationName, request.InspectTemplate, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InspectTemplate responseCancellationToken = await client.CreateInspectTemplateAsync(request.ParentAsOrganizationLocationName, request.InspectTemplate, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateInspectTemplateResourceNames4()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateInspectTemplateRequest request = new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                InspectTemplate = new InspectTemplate(),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateInspectTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate response = client.CreateInspectTemplate(request.ParentAsLocationName, request.InspectTemplate);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateInspectTemplateResourceNames4Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateInspectTemplateRequest request = new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                InspectTemplate = new InspectTemplate(),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateInspectTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InspectTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate responseCallSettings = await client.CreateInspectTemplateAsync(request.ParentAsLocationName, request.InspectTemplate, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InspectTemplate responseCancellationToken = await client.CreateInspectTemplateAsync(request.ParentAsLocationName, request.InspectTemplate, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateInspectTemplateRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateInspectTemplateRequest request = new UpdateInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                InspectTemplate = new InspectTemplate(),
                UpdateMask = new wkt::FieldMask(),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateInspectTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate response = client.UpdateInspectTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateInspectTemplateRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateInspectTemplateRequest request = new UpdateInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                InspectTemplate = new InspectTemplate(),
                UpdateMask = new wkt::FieldMask(),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateInspectTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InspectTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate responseCallSettings = await client.UpdateInspectTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InspectTemplate responseCancellationToken = await client.UpdateInspectTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateInspectTemplate()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateInspectTemplateRequest request = new UpdateInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                InspectTemplate = new InspectTemplate(),
                UpdateMask = new wkt::FieldMask(),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateInspectTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate response = client.UpdateInspectTemplate(request.Name, request.InspectTemplate, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateInspectTemplateAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateInspectTemplateRequest request = new UpdateInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                InspectTemplate = new InspectTemplate(),
                UpdateMask = new wkt::FieldMask(),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateInspectTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InspectTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate responseCallSettings = await client.UpdateInspectTemplateAsync(request.Name, request.InspectTemplate, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InspectTemplate responseCancellationToken = await client.UpdateInspectTemplateAsync(request.Name, request.InspectTemplate, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateInspectTemplateResourceNames()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateInspectTemplateRequest request = new UpdateInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                InspectTemplate = new InspectTemplate(),
                UpdateMask = new wkt::FieldMask(),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateInspectTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate response = client.UpdateInspectTemplate(request.InspectTemplateName, request.InspectTemplate, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateInspectTemplateResourceNamesAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateInspectTemplateRequest request = new UpdateInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                InspectTemplate = new InspectTemplate(),
                UpdateMask = new wkt::FieldMask(),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateInspectTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InspectTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate responseCallSettings = await client.UpdateInspectTemplateAsync(request.InspectTemplateName, request.InspectTemplate, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InspectTemplate responseCancellationToken = await client.UpdateInspectTemplateAsync(request.InspectTemplateName, request.InspectTemplate, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInspectTemplateRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetInspectTemplateRequest request = new GetInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.GetInspectTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate response = client.GetInspectTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInspectTemplateRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetInspectTemplateRequest request = new GetInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.GetInspectTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InspectTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate responseCallSettings = await client.GetInspectTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InspectTemplate responseCancellationToken = await client.GetInspectTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInspectTemplate()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetInspectTemplateRequest request = new GetInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.GetInspectTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate response = client.GetInspectTemplate(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInspectTemplateAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetInspectTemplateRequest request = new GetInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.GetInspectTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InspectTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate responseCallSettings = await client.GetInspectTemplateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InspectTemplate responseCancellationToken = await client.GetInspectTemplateAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInspectTemplateResourceNames()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetInspectTemplateRequest request = new GetInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.GetInspectTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate response = client.GetInspectTemplate(request.InspectTemplateName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInspectTemplateResourceNamesAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetInspectTemplateRequest request = new GetInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                InspectConfig = new InspectConfig(),
            };
            mockGrpcClient.Setup(x => x.GetInspectTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InspectTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            InspectTemplate responseCallSettings = await client.GetInspectTemplateAsync(request.InspectTemplateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InspectTemplate responseCancellationToken = await client.GetInspectTemplateAsync(request.InspectTemplateName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteInspectTemplateRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteInspectTemplateRequest request = new DeleteInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInspectTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteInspectTemplate(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteInspectTemplateRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteInspectTemplateRequest request = new DeleteInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInspectTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteInspectTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteInspectTemplateAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteInspectTemplate()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteInspectTemplateRequest request = new DeleteInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInspectTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteInspectTemplate(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteInspectTemplateAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteInspectTemplateRequest request = new DeleteInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInspectTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteInspectTemplateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteInspectTemplateAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteInspectTemplateResourceNames()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteInspectTemplateRequest request = new DeleteInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInspectTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteInspectTemplate(request.InspectTemplateName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteInspectTemplateResourceNamesAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteInspectTemplateRequest request = new DeleteInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInspectTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteInspectTemplateAsync(request.InspectTemplateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteInspectTemplateAsync(request.InspectTemplateName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDeidentifyTemplateRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDeidentifyTemplateRequest request = new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
                TemplateId = "template_id6435f574",
                LocationId = "location_iddaa574e2",
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateDeidentifyTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate response = client.CreateDeidentifyTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDeidentifyTemplateRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDeidentifyTemplateRequest request = new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
                TemplateId = "template_id6435f574",
                LocationId = "location_iddaa574e2",
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateDeidentifyTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeidentifyTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate responseCallSettings = await client.CreateDeidentifyTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeidentifyTemplate responseCancellationToken = await client.CreateDeidentifyTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDeidentifyTemplate()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDeidentifyTemplateRequest request = new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateDeidentifyTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate response = client.CreateDeidentifyTemplate(request.Parent, request.DeidentifyTemplate);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDeidentifyTemplateAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDeidentifyTemplateRequest request = new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateDeidentifyTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeidentifyTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate responseCallSettings = await client.CreateDeidentifyTemplateAsync(request.Parent, request.DeidentifyTemplate, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeidentifyTemplate responseCancellationToken = await client.CreateDeidentifyTemplateAsync(request.Parent, request.DeidentifyTemplate, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDeidentifyTemplateResourceNames1()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDeidentifyTemplateRequest request = new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateDeidentifyTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate response = client.CreateDeidentifyTemplate(request.ParentAsOrganizationName, request.DeidentifyTemplate);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDeidentifyTemplateResourceNames1Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDeidentifyTemplateRequest request = new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateDeidentifyTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeidentifyTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate responseCallSettings = await client.CreateDeidentifyTemplateAsync(request.ParentAsOrganizationName, request.DeidentifyTemplate, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeidentifyTemplate responseCancellationToken = await client.CreateDeidentifyTemplateAsync(request.ParentAsOrganizationName, request.DeidentifyTemplate, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDeidentifyTemplateResourceNames2()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDeidentifyTemplateRequest request = new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateDeidentifyTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate response = client.CreateDeidentifyTemplate(request.ParentAsProjectName, request.DeidentifyTemplate);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDeidentifyTemplateResourceNames2Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDeidentifyTemplateRequest request = new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateDeidentifyTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeidentifyTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate responseCallSettings = await client.CreateDeidentifyTemplateAsync(request.ParentAsProjectName, request.DeidentifyTemplate, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeidentifyTemplate responseCancellationToken = await client.CreateDeidentifyTemplateAsync(request.ParentAsProjectName, request.DeidentifyTemplate, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDeidentifyTemplateResourceNames3()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDeidentifyTemplateRequest request = new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateDeidentifyTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate response = client.CreateDeidentifyTemplate(request.ParentAsOrganizationLocationName, request.DeidentifyTemplate);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDeidentifyTemplateResourceNames3Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDeidentifyTemplateRequest request = new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateDeidentifyTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeidentifyTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate responseCallSettings = await client.CreateDeidentifyTemplateAsync(request.ParentAsOrganizationLocationName, request.DeidentifyTemplate, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeidentifyTemplate responseCancellationToken = await client.CreateDeidentifyTemplateAsync(request.ParentAsOrganizationLocationName, request.DeidentifyTemplate, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDeidentifyTemplateResourceNames4()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDeidentifyTemplateRequest request = new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateDeidentifyTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate response = client.CreateDeidentifyTemplate(request.ParentAsLocationName, request.DeidentifyTemplate);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDeidentifyTemplateResourceNames4Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDeidentifyTemplateRequest request = new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateDeidentifyTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeidentifyTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate responseCallSettings = await client.CreateDeidentifyTemplateAsync(request.ParentAsLocationName, request.DeidentifyTemplate, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeidentifyTemplate responseCancellationToken = await client.CreateDeidentifyTemplateAsync(request.ParentAsLocationName, request.DeidentifyTemplate, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDeidentifyTemplateRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateDeidentifyTemplateRequest request = new UpdateDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
                UpdateMask = new wkt::FieldMask(),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateDeidentifyTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate response = client.UpdateDeidentifyTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDeidentifyTemplateRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateDeidentifyTemplateRequest request = new UpdateDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
                UpdateMask = new wkt::FieldMask(),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateDeidentifyTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeidentifyTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate responseCallSettings = await client.UpdateDeidentifyTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeidentifyTemplate responseCancellationToken = await client.UpdateDeidentifyTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDeidentifyTemplate()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateDeidentifyTemplateRequest request = new UpdateDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
                UpdateMask = new wkt::FieldMask(),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateDeidentifyTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate response = client.UpdateDeidentifyTemplate(request.Name, request.DeidentifyTemplate, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDeidentifyTemplateAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateDeidentifyTemplateRequest request = new UpdateDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
                UpdateMask = new wkt::FieldMask(),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateDeidentifyTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeidentifyTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate responseCallSettings = await client.UpdateDeidentifyTemplateAsync(request.Name, request.DeidentifyTemplate, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeidentifyTemplate responseCancellationToken = await client.UpdateDeidentifyTemplateAsync(request.Name, request.DeidentifyTemplate, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDeidentifyTemplateResourceNames()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateDeidentifyTemplateRequest request = new UpdateDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
                UpdateMask = new wkt::FieldMask(),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateDeidentifyTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate response = client.UpdateDeidentifyTemplate(request.DeidentifyTemplateName, request.DeidentifyTemplate, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDeidentifyTemplateResourceNamesAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateDeidentifyTemplateRequest request = new UpdateDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
                UpdateMask = new wkt::FieldMask(),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateDeidentifyTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeidentifyTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate responseCallSettings = await client.UpdateDeidentifyTemplateAsync(request.DeidentifyTemplateName, request.DeidentifyTemplate, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeidentifyTemplate responseCancellationToken = await client.UpdateDeidentifyTemplateAsync(request.DeidentifyTemplateName, request.DeidentifyTemplate, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDeidentifyTemplateRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetDeidentifyTemplateRequest request = new GetDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.GetDeidentifyTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate response = client.GetDeidentifyTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeidentifyTemplateRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetDeidentifyTemplateRequest request = new GetDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.GetDeidentifyTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeidentifyTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate responseCallSettings = await client.GetDeidentifyTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeidentifyTemplate responseCancellationToken = await client.GetDeidentifyTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDeidentifyTemplate()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetDeidentifyTemplateRequest request = new GetDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.GetDeidentifyTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate response = client.GetDeidentifyTemplate(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeidentifyTemplateAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetDeidentifyTemplateRequest request = new GetDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.GetDeidentifyTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeidentifyTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate responseCallSettings = await client.GetDeidentifyTemplateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeidentifyTemplate responseCancellationToken = await client.GetDeidentifyTemplateAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDeidentifyTemplateResourceNames()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetDeidentifyTemplateRequest request = new GetDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.GetDeidentifyTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate response = client.GetDeidentifyTemplate(request.DeidentifyTemplateName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeidentifyTemplateResourceNamesAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetDeidentifyTemplateRequest request = new GetDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeidentifyConfig = new DeidentifyConfig(),
            };
            mockGrpcClient.Setup(x => x.GetDeidentifyTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeidentifyTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DeidentifyTemplate responseCallSettings = await client.GetDeidentifyTemplateAsync(request.DeidentifyTemplateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeidentifyTemplate responseCancellationToken = await client.GetDeidentifyTemplateAsync(request.DeidentifyTemplateName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDeidentifyTemplateRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteDeidentifyTemplateRequest request = new DeleteDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeidentifyTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDeidentifyTemplate(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDeidentifyTemplateRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteDeidentifyTemplateRequest request = new DeleteDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeidentifyTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDeidentifyTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDeidentifyTemplateAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDeidentifyTemplate()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteDeidentifyTemplateRequest request = new DeleteDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeidentifyTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDeidentifyTemplate(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDeidentifyTemplateAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteDeidentifyTemplateRequest request = new DeleteDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeidentifyTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDeidentifyTemplateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDeidentifyTemplateAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDeidentifyTemplateResourceNames()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteDeidentifyTemplateRequest request = new DeleteDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeidentifyTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDeidentifyTemplate(request.DeidentifyTemplateName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDeidentifyTemplateResourceNamesAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteDeidentifyTemplateRequest request = new DeleteDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeidentifyTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDeidentifyTemplateAsync(request.DeidentifyTemplateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDeidentifyTemplateAsync(request.DeidentifyTemplateName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobTriggerRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateJobTriggerRequest request = new CreateJobTriggerRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                JobTrigger = new JobTrigger(),
                TriggerId = "trigger_id9f1f0bb1",
                LocationId = "location_iddaa574e2",
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.CreateJobTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger response = client.CreateJobTrigger(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobTriggerRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateJobTriggerRequest request = new CreateJobTriggerRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                JobTrigger = new JobTrigger(),
                TriggerId = "trigger_id9f1f0bb1",
                LocationId = "location_iddaa574e2",
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.CreateJobTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTrigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger responseCallSettings = await client.CreateJobTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTrigger responseCancellationToken = await client.CreateJobTriggerAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobTrigger()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateJobTriggerRequest request = new CreateJobTriggerRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                JobTrigger = new JobTrigger(),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.CreateJobTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger response = client.CreateJobTrigger(request.Parent, request.JobTrigger);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobTriggerAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateJobTriggerRequest request = new CreateJobTriggerRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                JobTrigger = new JobTrigger(),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.CreateJobTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTrigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger responseCallSettings = await client.CreateJobTriggerAsync(request.Parent, request.JobTrigger, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTrigger responseCancellationToken = await client.CreateJobTriggerAsync(request.Parent, request.JobTrigger, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobTriggerResourceNames1()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateJobTriggerRequest request = new CreateJobTriggerRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                JobTrigger = new JobTrigger(),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.CreateJobTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger response = client.CreateJobTrigger(request.ParentAsProjectName, request.JobTrigger);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobTriggerResourceNames1Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateJobTriggerRequest request = new CreateJobTriggerRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                JobTrigger = new JobTrigger(),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.CreateJobTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTrigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger responseCallSettings = await client.CreateJobTriggerAsync(request.ParentAsProjectName, request.JobTrigger, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTrigger responseCancellationToken = await client.CreateJobTriggerAsync(request.ParentAsProjectName, request.JobTrigger, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobTriggerResourceNames2()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateJobTriggerRequest request = new CreateJobTriggerRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                JobTrigger = new JobTrigger(),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.CreateJobTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger response = client.CreateJobTrigger(request.ParentAsLocationName, request.JobTrigger);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobTriggerResourceNames2Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateJobTriggerRequest request = new CreateJobTriggerRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                JobTrigger = new JobTrigger(),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.CreateJobTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTrigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger responseCallSettings = await client.CreateJobTriggerAsync(request.ParentAsLocationName, request.JobTrigger, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTrigger responseCancellationToken = await client.CreateJobTriggerAsync(request.ParentAsLocationName, request.JobTrigger, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateJobTriggerRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateJobTriggerRequest request = new UpdateJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                JobTrigger = new JobTrigger(),
                UpdateMask = new wkt::FieldMask(),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.UpdateJobTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger response = client.UpdateJobTrigger(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateJobTriggerRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateJobTriggerRequest request = new UpdateJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                JobTrigger = new JobTrigger(),
                UpdateMask = new wkt::FieldMask(),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.UpdateJobTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTrigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger responseCallSettings = await client.UpdateJobTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTrigger responseCancellationToken = await client.UpdateJobTriggerAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateJobTrigger()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateJobTriggerRequest request = new UpdateJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                JobTrigger = new JobTrigger(),
                UpdateMask = new wkt::FieldMask(),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.UpdateJobTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger response = client.UpdateJobTrigger(request.Name, request.JobTrigger, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateJobTriggerAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateJobTriggerRequest request = new UpdateJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                JobTrigger = new JobTrigger(),
                UpdateMask = new wkt::FieldMask(),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.UpdateJobTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTrigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger responseCallSettings = await client.UpdateJobTriggerAsync(request.Name, request.JobTrigger, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTrigger responseCancellationToken = await client.UpdateJobTriggerAsync(request.Name, request.JobTrigger, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateJobTriggerResourceNames()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateJobTriggerRequest request = new UpdateJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                JobTrigger = new JobTrigger(),
                UpdateMask = new wkt::FieldMask(),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.UpdateJobTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger response = client.UpdateJobTrigger(request.JobTriggerName, request.JobTrigger, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateJobTriggerResourceNamesAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateJobTriggerRequest request = new UpdateJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                JobTrigger = new JobTrigger(),
                UpdateMask = new wkt::FieldMask(),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.UpdateJobTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTrigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger responseCallSettings = await client.UpdateJobTriggerAsync(request.JobTriggerName, request.JobTrigger, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTrigger responseCancellationToken = await client.UpdateJobTriggerAsync(request.JobTriggerName, request.JobTrigger, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void HybridInspectJobTriggerRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            HybridInspectJobTriggerRequest request = new HybridInspectJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                HybridItem = new HybridContentItem(),
            };
            HybridInspectResponse expectedResponse = new HybridInspectResponse { };
            mockGrpcClient.Setup(x => x.HybridInspectJobTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            HybridInspectResponse response = client.HybridInspectJobTrigger(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task HybridInspectJobTriggerRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            HybridInspectJobTriggerRequest request = new HybridInspectJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                HybridItem = new HybridContentItem(),
            };
            HybridInspectResponse expectedResponse = new HybridInspectResponse { };
            mockGrpcClient.Setup(x => x.HybridInspectJobTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HybridInspectResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            HybridInspectResponse responseCallSettings = await client.HybridInspectJobTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HybridInspectResponse responseCancellationToken = await client.HybridInspectJobTriggerAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void HybridInspectJobTrigger()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            HybridInspectJobTriggerRequest request = new HybridInspectJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            HybridInspectResponse expectedResponse = new HybridInspectResponse { };
            mockGrpcClient.Setup(x => x.HybridInspectJobTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            HybridInspectResponse response = client.HybridInspectJobTrigger(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task HybridInspectJobTriggerAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            HybridInspectJobTriggerRequest request = new HybridInspectJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            HybridInspectResponse expectedResponse = new HybridInspectResponse { };
            mockGrpcClient.Setup(x => x.HybridInspectJobTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HybridInspectResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            HybridInspectResponse responseCallSettings = await client.HybridInspectJobTriggerAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HybridInspectResponse responseCancellationToken = await client.HybridInspectJobTriggerAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void HybridInspectJobTriggerResourceNames()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            HybridInspectJobTriggerRequest request = new HybridInspectJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            HybridInspectResponse expectedResponse = new HybridInspectResponse { };
            mockGrpcClient.Setup(x => x.HybridInspectJobTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            HybridInspectResponse response = client.HybridInspectJobTrigger(request.JobTriggerName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task HybridInspectJobTriggerResourceNamesAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            HybridInspectJobTriggerRequest request = new HybridInspectJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            HybridInspectResponse expectedResponse = new HybridInspectResponse { };
            mockGrpcClient.Setup(x => x.HybridInspectJobTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HybridInspectResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            HybridInspectResponse responseCallSettings = await client.HybridInspectJobTriggerAsync(request.JobTriggerName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HybridInspectResponse responseCancellationToken = await client.HybridInspectJobTriggerAsync(request.JobTriggerName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobTriggerRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetJobTriggerRequest request = new GetJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.GetJobTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger response = client.GetJobTrigger(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobTriggerRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetJobTriggerRequest request = new GetJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.GetJobTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTrigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger responseCallSettings = await client.GetJobTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTrigger responseCancellationToken = await client.GetJobTriggerAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobTrigger()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetJobTriggerRequest request = new GetJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.GetJobTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger response = client.GetJobTrigger(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobTriggerAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetJobTriggerRequest request = new GetJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.GetJobTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTrigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger responseCallSettings = await client.GetJobTriggerAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTrigger responseCancellationToken = await client.GetJobTriggerAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobTriggerResourceNames()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetJobTriggerRequest request = new GetJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.GetJobTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger response = client.GetJobTrigger(request.JobTriggerName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobTriggerResourceNamesAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetJobTriggerRequest request = new GetJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                InspectJob = new InspectJobConfig(),
                Triggers =
                {
                    new JobTrigger.Types.Trigger(),
                },
                Errors = { new Error(), },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastRunTime = new wkt::Timestamp(),
                Status = JobTrigger.Types.Status.Paused,
            };
            mockGrpcClient.Setup(x => x.GetJobTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTrigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            JobTrigger responseCallSettings = await client.GetJobTriggerAsync(request.JobTriggerName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTrigger responseCancellationToken = await client.GetJobTriggerAsync(request.JobTriggerName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobTriggerRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteJobTriggerRequest request = new DeleteJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteJobTrigger(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobTriggerRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteJobTriggerRequest request = new DeleteJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteJobTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobTriggerAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobTrigger()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteJobTriggerRequest request = new DeleteJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteJobTrigger(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobTriggerAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteJobTriggerRequest request = new DeleteJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteJobTriggerAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobTriggerAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobTriggerResourceNames()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteJobTriggerRequest request = new DeleteJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteJobTrigger(request.JobTriggerName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobTriggerResourceNamesAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteJobTriggerRequest request = new DeleteJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteJobTriggerAsync(request.JobTriggerName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobTriggerAsync(request.JobTriggerName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ActivateJobTriggerRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            ActivateJobTriggerRequest request = new ActivateJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.ActivateJobTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob response = client.ActivateJobTrigger(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ActivateJobTriggerRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            ActivateJobTriggerRequest request = new ActivateJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.ActivateJobTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DlpJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob responseCallSettings = await client.ActivateJobTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DlpJob responseCancellationToken = await client.ActivateJobTriggerAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDlpJobRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                InspectJob = new InspectJobConfig(),
                RiskJob = new RiskAnalysisJobConfig(),
                JobId = "job_id38ea97d6",
                LocationId = "location_iddaa574e2",
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.CreateDlpJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob response = client.CreateDlpJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDlpJobRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                InspectJob = new InspectJobConfig(),
                RiskJob = new RiskAnalysisJobConfig(),
                JobId = "job_id38ea97d6",
                LocationId = "location_iddaa574e2",
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.CreateDlpJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DlpJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob responseCallSettings = await client.CreateDlpJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DlpJob responseCancellationToken = await client.CreateDlpJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDlpJob1()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                InspectJob = new InspectJobConfig(),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.CreateDlpJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob response = client.CreateDlpJob(request.Parent, request.InspectJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDlpJob1Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                InspectJob = new InspectJobConfig(),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.CreateDlpJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DlpJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob responseCallSettings = await client.CreateDlpJobAsync(request.Parent, request.InspectJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DlpJob responseCancellationToken = await client.CreateDlpJobAsync(request.Parent, request.InspectJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDlpJob1ResourceNames1()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                InspectJob = new InspectJobConfig(),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.CreateDlpJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob response = client.CreateDlpJob(request.ParentAsProjectName, request.InspectJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDlpJob1ResourceNames1Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                InspectJob = new InspectJobConfig(),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.CreateDlpJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DlpJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob responseCallSettings = await client.CreateDlpJobAsync(request.ParentAsProjectName, request.InspectJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DlpJob responseCancellationToken = await client.CreateDlpJobAsync(request.ParentAsProjectName, request.InspectJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDlpJob1ResourceNames2()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                InspectJob = new InspectJobConfig(),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.CreateDlpJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob response = client.CreateDlpJob(request.ParentAsLocationName, request.InspectJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDlpJob1ResourceNames2Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                InspectJob = new InspectJobConfig(),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.CreateDlpJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DlpJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob responseCallSettings = await client.CreateDlpJobAsync(request.ParentAsLocationName, request.InspectJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DlpJob responseCancellationToken = await client.CreateDlpJobAsync(request.ParentAsLocationName, request.InspectJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDlpJob2()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                RiskJob = new RiskAnalysisJobConfig(),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.CreateDlpJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob response = client.CreateDlpJob(request.Parent, request.RiskJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDlpJob2Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                RiskJob = new RiskAnalysisJobConfig(),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.CreateDlpJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DlpJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob responseCallSettings = await client.CreateDlpJobAsync(request.Parent, request.RiskJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DlpJob responseCancellationToken = await client.CreateDlpJobAsync(request.Parent, request.RiskJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDlpJob2ResourceNames1()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                RiskJob = new RiskAnalysisJobConfig(),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.CreateDlpJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob response = client.CreateDlpJob(request.ParentAsProjectName, request.RiskJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDlpJob2ResourceNames1Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                RiskJob = new RiskAnalysisJobConfig(),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.CreateDlpJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DlpJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob responseCallSettings = await client.CreateDlpJobAsync(request.ParentAsProjectName, request.RiskJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DlpJob responseCancellationToken = await client.CreateDlpJobAsync(request.ParentAsProjectName, request.RiskJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDlpJob2ResourceNames2()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                RiskJob = new RiskAnalysisJobConfig(),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.CreateDlpJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob response = client.CreateDlpJob(request.ParentAsLocationName, request.RiskJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDlpJob2ResourceNames2Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                RiskJob = new RiskAnalysisJobConfig(),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.CreateDlpJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DlpJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob responseCallSettings = await client.CreateDlpJobAsync(request.ParentAsLocationName, request.RiskJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DlpJob responseCancellationToken = await client.CreateDlpJobAsync(request.ParentAsLocationName, request.RiskJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDlpJobRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetDlpJobRequest request = new GetDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.GetDlpJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob response = client.GetDlpJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDlpJobRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetDlpJobRequest request = new GetDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.GetDlpJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DlpJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob responseCallSettings = await client.GetDlpJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DlpJob responseCancellationToken = await client.GetDlpJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDlpJob()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetDlpJobRequest request = new GetDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.GetDlpJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob response = client.GetDlpJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDlpJobAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetDlpJobRequest request = new GetDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.GetDlpJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DlpJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob responseCallSettings = await client.GetDlpJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DlpJob responseCancellationToken = await client.GetDlpJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDlpJobResourceNames()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetDlpJobRequest request = new GetDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.GetDlpJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob response = client.GetDlpJob(request.DlpJobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDlpJobResourceNamesAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetDlpJobRequest request = new GetDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            DlpJob expectedResponse = new DlpJob
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                Type = DlpJobType.Unspecified,
                State = DlpJob.Types.JobState.Active,
                RiskDetails = new AnalyzeDataSourceRiskDetails(),
                InspectDetails = new InspectDataSourceDetails(),
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                JobTriggerName = "job_trigger_name66f423d1",
                Errors = { new Error(), },
            };
            mockGrpcClient.Setup(x => x.GetDlpJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DlpJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            DlpJob responseCallSettings = await client.GetDlpJobAsync(request.DlpJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DlpJob responseCancellationToken = await client.GetDlpJobAsync(request.DlpJobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDlpJobRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteDlpJobRequest request = new DeleteDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDlpJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDlpJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDlpJobRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteDlpJobRequest request = new DeleteDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDlpJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDlpJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDlpJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDlpJob()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteDlpJobRequest request = new DeleteDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDlpJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDlpJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDlpJobAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteDlpJobRequest request = new DeleteDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDlpJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDlpJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDlpJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDlpJobResourceNames()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteDlpJobRequest request = new DeleteDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDlpJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDlpJob(request.DlpJobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDlpJobResourceNamesAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteDlpJobRequest request = new DeleteDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDlpJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDlpJobAsync(request.DlpJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDlpJobAsync(request.DlpJobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelDlpJobRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CancelDlpJobRequest request = new CancelDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelDlpJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            client.CancelDlpJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelDlpJobRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CancelDlpJobRequest request = new CancelDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CancelDlpJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.CancelDlpJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CancelDlpJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateStoredInfoTypeRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateStoredInfoTypeRequest request = new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Config = new StoredInfoTypeConfig(),
                StoredInfoTypeId = "stored_info_type_id9f1b4864",
                LocationId = "location_iddaa574e2",
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateStoredInfoType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType response = client.CreateStoredInfoType(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateStoredInfoTypeRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateStoredInfoTypeRequest request = new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Config = new StoredInfoTypeConfig(),
                StoredInfoTypeId = "stored_info_type_id9f1b4864",
                LocationId = "location_iddaa574e2",
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateStoredInfoTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StoredInfoType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType responseCallSettings = await client.CreateStoredInfoTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StoredInfoType responseCancellationToken = await client.CreateStoredInfoTypeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateStoredInfoType()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateStoredInfoTypeRequest request = new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Config = new StoredInfoTypeConfig(),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateStoredInfoType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType response = client.CreateStoredInfoType(request.Parent, request.Config);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateStoredInfoTypeAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateStoredInfoTypeRequest request = new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Config = new StoredInfoTypeConfig(),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateStoredInfoTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StoredInfoType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType responseCallSettings = await client.CreateStoredInfoTypeAsync(request.Parent, request.Config, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StoredInfoType responseCancellationToken = await client.CreateStoredInfoTypeAsync(request.Parent, request.Config, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateStoredInfoTypeResourceNames1()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateStoredInfoTypeRequest request = new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Config = new StoredInfoTypeConfig(),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateStoredInfoType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType response = client.CreateStoredInfoType(request.ParentAsOrganizationName, request.Config);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateStoredInfoTypeResourceNames1Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateStoredInfoTypeRequest request = new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Config = new StoredInfoTypeConfig(),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateStoredInfoTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StoredInfoType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType responseCallSettings = await client.CreateStoredInfoTypeAsync(request.ParentAsOrganizationName, request.Config, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StoredInfoType responseCancellationToken = await client.CreateStoredInfoTypeAsync(request.ParentAsOrganizationName, request.Config, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateStoredInfoTypeResourceNames2()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateStoredInfoTypeRequest request = new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Config = new StoredInfoTypeConfig(),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateStoredInfoType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType response = client.CreateStoredInfoType(request.ParentAsProjectName, request.Config);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateStoredInfoTypeResourceNames2Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateStoredInfoTypeRequest request = new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Config = new StoredInfoTypeConfig(),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateStoredInfoTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StoredInfoType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType responseCallSettings = await client.CreateStoredInfoTypeAsync(request.ParentAsProjectName, request.Config, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StoredInfoType responseCancellationToken = await client.CreateStoredInfoTypeAsync(request.ParentAsProjectName, request.Config, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateStoredInfoTypeResourceNames3()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateStoredInfoTypeRequest request = new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Config = new StoredInfoTypeConfig(),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateStoredInfoType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType response = client.CreateStoredInfoType(request.ParentAsOrganizationLocationName, request.Config);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateStoredInfoTypeResourceNames3Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateStoredInfoTypeRequest request = new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Config = new StoredInfoTypeConfig(),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateStoredInfoTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StoredInfoType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType responseCallSettings = await client.CreateStoredInfoTypeAsync(request.ParentAsOrganizationLocationName, request.Config, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StoredInfoType responseCancellationToken = await client.CreateStoredInfoTypeAsync(request.ParentAsOrganizationLocationName, request.Config, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateStoredInfoTypeResourceNames4()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateStoredInfoTypeRequest request = new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Config = new StoredInfoTypeConfig(),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateStoredInfoType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType response = client.CreateStoredInfoType(request.ParentAsLocationName, request.Config);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateStoredInfoTypeResourceNames4Async()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            CreateStoredInfoTypeRequest request = new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Config = new StoredInfoTypeConfig(),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateStoredInfoTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StoredInfoType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType responseCallSettings = await client.CreateStoredInfoTypeAsync(request.ParentAsLocationName, request.Config, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StoredInfoType responseCancellationToken = await client.CreateStoredInfoTypeAsync(request.ParentAsLocationName, request.Config, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateStoredInfoTypeRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateStoredInfoTypeRequest request = new UpdateStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                Config = new StoredInfoTypeConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateStoredInfoType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType response = client.UpdateStoredInfoType(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateStoredInfoTypeRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateStoredInfoTypeRequest request = new UpdateStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                Config = new StoredInfoTypeConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateStoredInfoTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StoredInfoType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType responseCallSettings = await client.UpdateStoredInfoTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StoredInfoType responseCancellationToken = await client.UpdateStoredInfoTypeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateStoredInfoType()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateStoredInfoTypeRequest request = new UpdateStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                Config = new StoredInfoTypeConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateStoredInfoType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType response = client.UpdateStoredInfoType(request.Name, request.Config, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateStoredInfoTypeAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateStoredInfoTypeRequest request = new UpdateStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                Config = new StoredInfoTypeConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateStoredInfoTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StoredInfoType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType responseCallSettings = await client.UpdateStoredInfoTypeAsync(request.Name, request.Config, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StoredInfoType responseCancellationToken = await client.UpdateStoredInfoTypeAsync(request.Name, request.Config, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateStoredInfoTypeResourceNames()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateStoredInfoTypeRequest request = new UpdateStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                Config = new StoredInfoTypeConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateStoredInfoType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType response = client.UpdateStoredInfoType(request.StoredInfoTypeName, request.Config, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateStoredInfoTypeResourceNamesAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            UpdateStoredInfoTypeRequest request = new UpdateStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                Config = new StoredInfoTypeConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateStoredInfoTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StoredInfoType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType responseCallSettings = await client.UpdateStoredInfoTypeAsync(request.StoredInfoTypeName, request.Config, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StoredInfoType responseCancellationToken = await client.UpdateStoredInfoTypeAsync(request.StoredInfoTypeName, request.Config, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetStoredInfoTypeRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetStoredInfoTypeRequest request = new GetStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.GetStoredInfoType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType response = client.GetStoredInfoType(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetStoredInfoTypeRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetStoredInfoTypeRequest request = new GetStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.GetStoredInfoTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StoredInfoType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType responseCallSettings = await client.GetStoredInfoTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StoredInfoType responseCancellationToken = await client.GetStoredInfoTypeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetStoredInfoType()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetStoredInfoTypeRequest request = new GetStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.GetStoredInfoType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType response = client.GetStoredInfoType(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetStoredInfoTypeAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetStoredInfoTypeRequest request = new GetStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.GetStoredInfoTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StoredInfoType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType responseCallSettings = await client.GetStoredInfoTypeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StoredInfoType responseCancellationToken = await client.GetStoredInfoTypeAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetStoredInfoTypeResourceNames()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetStoredInfoTypeRequest request = new GetStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.GetStoredInfoType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType response = client.GetStoredInfoType(request.StoredInfoTypeName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetStoredInfoTypeResourceNamesAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            GetStoredInfoTypeRequest request = new GetStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                CurrentVersion = new StoredInfoTypeVersion(),
                PendingVersions =
                {
                    new StoredInfoTypeVersion(),
                },
            };
            mockGrpcClient.Setup(x => x.GetStoredInfoTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StoredInfoType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            StoredInfoType responseCallSettings = await client.GetStoredInfoTypeAsync(request.StoredInfoTypeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StoredInfoType responseCancellationToken = await client.GetStoredInfoTypeAsync(request.StoredInfoTypeName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteStoredInfoTypeRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteStoredInfoTypeRequest request = new DeleteStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteStoredInfoType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteStoredInfoType(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteStoredInfoTypeRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteStoredInfoTypeRequest request = new DeleteStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteStoredInfoTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteStoredInfoTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteStoredInfoTypeAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteStoredInfoType()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteStoredInfoTypeRequest request = new DeleteStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteStoredInfoType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteStoredInfoType(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteStoredInfoTypeAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteStoredInfoTypeRequest request = new DeleteStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteStoredInfoTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteStoredInfoTypeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteStoredInfoTypeAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteStoredInfoTypeResourceNames()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteStoredInfoTypeRequest request = new DeleteStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteStoredInfoType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteStoredInfoType(request.StoredInfoTypeName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteStoredInfoTypeResourceNamesAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            DeleteStoredInfoTypeRequest request = new DeleteStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteStoredInfoTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteStoredInfoTypeAsync(request.StoredInfoTypeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteStoredInfoTypeAsync(request.StoredInfoTypeName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void HybridInspectDlpJobRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            HybridInspectDlpJobRequest request = new HybridInspectDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                HybridItem = new HybridContentItem(),
            };
            HybridInspectResponse expectedResponse = new HybridInspectResponse { };
            mockGrpcClient.Setup(x => x.HybridInspectDlpJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            HybridInspectResponse response = client.HybridInspectDlpJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task HybridInspectDlpJobRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            HybridInspectDlpJobRequest request = new HybridInspectDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                HybridItem = new HybridContentItem(),
            };
            HybridInspectResponse expectedResponse = new HybridInspectResponse { };
            mockGrpcClient.Setup(x => x.HybridInspectDlpJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HybridInspectResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            HybridInspectResponse responseCallSettings = await client.HybridInspectDlpJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HybridInspectResponse responseCancellationToken = await client.HybridInspectDlpJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void HybridInspectDlpJob()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            HybridInspectDlpJobRequest request = new HybridInspectDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            HybridInspectResponse expectedResponse = new HybridInspectResponse { };
            mockGrpcClient.Setup(x => x.HybridInspectDlpJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            HybridInspectResponse response = client.HybridInspectDlpJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task HybridInspectDlpJobAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            HybridInspectDlpJobRequest request = new HybridInspectDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            HybridInspectResponse expectedResponse = new HybridInspectResponse { };
            mockGrpcClient.Setup(x => x.HybridInspectDlpJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HybridInspectResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            HybridInspectResponse responseCallSettings = await client.HybridInspectDlpJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HybridInspectResponse responseCancellationToken = await client.HybridInspectDlpJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void HybridInspectDlpJobResourceNames()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            HybridInspectDlpJobRequest request = new HybridInspectDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            HybridInspectResponse expectedResponse = new HybridInspectResponse { };
            mockGrpcClient.Setup(x => x.HybridInspectDlpJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            HybridInspectResponse response = client.HybridInspectDlpJob(request.DlpJobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task HybridInspectDlpJobResourceNamesAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            HybridInspectDlpJobRequest request = new HybridInspectDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            HybridInspectResponse expectedResponse = new HybridInspectResponse { };
            mockGrpcClient.Setup(x => x.HybridInspectDlpJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HybridInspectResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            HybridInspectResponse responseCallSettings = await client.HybridInspectDlpJobAsync(request.DlpJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HybridInspectResponse responseCancellationToken = await client.HybridInspectDlpJobAsync(request.DlpJobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FinishDlpJobRequestObject()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            FinishDlpJobRequest request = new FinishDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.FinishDlpJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            client.FinishDlpJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FinishDlpJobRequestObjectAsync()
        {
            moq::Mock<DlpService.DlpServiceClient> mockGrpcClient = new moq::Mock<DlpService.DlpServiceClient>(moq::MockBehavior.Strict);
            FinishDlpJobRequest request = new FinishDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.FinishDlpJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.FinishDlpJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.FinishDlpJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
