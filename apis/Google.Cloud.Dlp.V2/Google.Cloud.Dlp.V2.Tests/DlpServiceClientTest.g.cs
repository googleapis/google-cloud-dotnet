// Copyright 2019 Google LLC
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

namespace Google.Cloud.Dlp.V2.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using apis = Google.Cloud.Dlp.V2;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Generated unit tests</summary>
    public class GeneratedDlpServiceClientTest
    {
        [Fact]
        public void InspectContent()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            InspectContentRequest request = new InspectContentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            InspectContentResponse expectedResponse = new InspectContentResponse();
            mockGrpcClient.Setup(x => x.InspectContent(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            InspectContentResponse response = client.InspectContent(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task InspectContentAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            InspectContentRequest request = new InspectContentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            InspectContentResponse expectedResponse = new InspectContentResponse();
            mockGrpcClient.Setup(x => x.InspectContentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<InspectContentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            InspectContentResponse response = await client.InspectContentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RedactImage()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            RedactImageRequest request = new RedactImageRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            RedactImageResponse expectedResponse = new RedactImageResponse
            {
                RedactedImage = ByteString.CopyFromUtf8("28"),
                ExtractedText = "extractedText998260012",
            };
            mockGrpcClient.Setup(x => x.RedactImage(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            RedactImageResponse response = client.RedactImage(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RedactImageAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            RedactImageRequest request = new RedactImageRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            RedactImageResponse expectedResponse = new RedactImageResponse
            {
                RedactedImage = ByteString.CopyFromUtf8("28"),
                ExtractedText = "extractedText998260012",
            };
            mockGrpcClient.Setup(x => x.RedactImageAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<RedactImageResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            RedactImageResponse response = await client.RedactImageAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeidentifyContent()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            DeidentifyContentRequest request = new DeidentifyContentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            DeidentifyContentResponse expectedResponse = new DeidentifyContentResponse();
            mockGrpcClient.Setup(x => x.DeidentifyContent(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            DeidentifyContentResponse response = client.DeidentifyContent(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeidentifyContentAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            DeidentifyContentRequest request = new DeidentifyContentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            DeidentifyContentResponse expectedResponse = new DeidentifyContentResponse();
            mockGrpcClient.Setup(x => x.DeidentifyContentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DeidentifyContentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            DeidentifyContentResponse response = await client.DeidentifyContentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ReidentifyContent()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            ReidentifyContentRequest request = new ReidentifyContentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            ReidentifyContentResponse expectedResponse = new ReidentifyContentResponse();
            mockGrpcClient.Setup(x => x.ReidentifyContent(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            ReidentifyContentResponse response = client.ReidentifyContent(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ReidentifyContentAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            ReidentifyContentRequest request = new ReidentifyContentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            ReidentifyContentResponse expectedResponse = new ReidentifyContentResponse();
            mockGrpcClient.Setup(x => x.ReidentifyContentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ReidentifyContentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            ReidentifyContentResponse response = await client.ReidentifyContentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListInfoTypes()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            ListInfoTypesRequest request = new ListInfoTypesRequest();
            ListInfoTypesResponse expectedResponse = new ListInfoTypesResponse();
            mockGrpcClient.Setup(x => x.ListInfoTypes(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            ListInfoTypesResponse response = client.ListInfoTypes(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListInfoTypesAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            ListInfoTypesRequest request = new ListInfoTypesRequest();
            ListInfoTypesResponse expectedResponse = new ListInfoTypesResponse();
            mockGrpcClient.Setup(x => x.ListInfoTypesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListInfoTypesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            ListInfoTypesResponse response = await client.ListInfoTypesAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateInspectTemplate()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            CreateInspectTemplateRequest request = new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.CreateInspectTemplate(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            InspectTemplate response = client.CreateInspectTemplate(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateInspectTemplateAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            CreateInspectTemplateRequest request = new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.CreateInspectTemplateAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<InspectTemplate>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            InspectTemplate response = await client.CreateInspectTemplateAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateInspectTemplate()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            UpdateInspectTemplateRequest request = new UpdateInspectTemplateRequest
            {
                InspectTemplateNameOneof = InspectTemplateNameOneof.From(new OrganizationInspectTemplateName("[ORGANIZATION]", "[INSPECT_TEMPLATE]")),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.UpdateInspectTemplate(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            InspectTemplate response = client.UpdateInspectTemplate(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateInspectTemplateAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            UpdateInspectTemplateRequest request = new UpdateInspectTemplateRequest
            {
                InspectTemplateNameOneof = InspectTemplateNameOneof.From(new OrganizationInspectTemplateName("[ORGANIZATION]", "[INSPECT_TEMPLATE]")),
            };
            InspectTemplate expectedResponse = new InspectTemplate
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.UpdateInspectTemplateAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<InspectTemplate>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            InspectTemplate response = await client.UpdateInspectTemplateAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetInspectTemplate()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            GetInspectTemplateRequest request = new GetInspectTemplateRequest();
            InspectTemplate expectedResponse = new InspectTemplate
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetInspectTemplate(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            InspectTemplate response = client.GetInspectTemplate(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetInspectTemplateAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            GetInspectTemplateRequest request = new GetInspectTemplateRequest();
            InspectTemplate expectedResponse = new InspectTemplate
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetInspectTemplateAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<InspectTemplate>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            InspectTemplate response = await client.GetInspectTemplateAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteInspectTemplate()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            DeleteInspectTemplateRequest request = new DeleteInspectTemplateRequest
            {
                InspectTemplateNameOneof = InspectTemplateNameOneof.From(new OrganizationInspectTemplateName("[ORGANIZATION]", "[INSPECT_TEMPLATE]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteInspectTemplate(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteInspectTemplate(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteInspectTemplateAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            DeleteInspectTemplateRequest request = new DeleteInspectTemplateRequest
            {
                InspectTemplateNameOneof = InspectTemplateNameOneof.From(new OrganizationInspectTemplateName("[ORGANIZATION]", "[INSPECT_TEMPLATE]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteInspectTemplateAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteInspectTemplateAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateDeidentifyTemplate()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            CreateDeidentifyTemplateRequest request = new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.CreateDeidentifyTemplate(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            DeidentifyTemplate response = client.CreateDeidentifyTemplate(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateDeidentifyTemplateAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            CreateDeidentifyTemplateRequest request = new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.CreateDeidentifyTemplateAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DeidentifyTemplate>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            DeidentifyTemplate response = await client.CreateDeidentifyTemplateAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateDeidentifyTemplate()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            UpdateDeidentifyTemplateRequest request = new UpdateDeidentifyTemplateRequest
            {
                DeidentifyTemplateNameOneof = DeidentifyTemplateNameOneof.From(new OrganizationDeidentifyTemplateName("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]")),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.UpdateDeidentifyTemplate(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            DeidentifyTemplate response = client.UpdateDeidentifyTemplate(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateDeidentifyTemplateAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            UpdateDeidentifyTemplateRequest request = new UpdateDeidentifyTemplateRequest
            {
                DeidentifyTemplateNameOneof = DeidentifyTemplateNameOneof.From(new OrganizationDeidentifyTemplateName("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]")),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.UpdateDeidentifyTemplateAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DeidentifyTemplate>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            DeidentifyTemplate response = await client.UpdateDeidentifyTemplateAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetDeidentifyTemplate()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            GetDeidentifyTemplateRequest request = new GetDeidentifyTemplateRequest
            {
                DeidentifyTemplateNameOneof = DeidentifyTemplateNameOneof.From(new OrganizationDeidentifyTemplateName("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]")),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetDeidentifyTemplate(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            DeidentifyTemplate response = client.GetDeidentifyTemplate(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetDeidentifyTemplateAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            GetDeidentifyTemplateRequest request = new GetDeidentifyTemplateRequest
            {
                DeidentifyTemplateNameOneof = DeidentifyTemplateNameOneof.From(new OrganizationDeidentifyTemplateName("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]")),
            };
            DeidentifyTemplate expectedResponse = new DeidentifyTemplate
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetDeidentifyTemplateAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DeidentifyTemplate>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            DeidentifyTemplate response = await client.GetDeidentifyTemplateAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteDeidentifyTemplate()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            DeleteDeidentifyTemplateRequest request = new DeleteDeidentifyTemplateRequest
            {
                DeidentifyTemplateNameOneof = DeidentifyTemplateNameOneof.From(new OrganizationDeidentifyTemplateName("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteDeidentifyTemplate(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteDeidentifyTemplate(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteDeidentifyTemplateAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            DeleteDeidentifyTemplateRequest request = new DeleteDeidentifyTemplateRequest
            {
                DeidentifyTemplateNameOneof = DeidentifyTemplateNameOneof.From(new OrganizationDeidentifyTemplateName("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteDeidentifyTemplateAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteDeidentifyTemplateAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateDlpJob()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            DlpJob expectedResponse = new DlpJob
            {
                Name = "name3373707",
                JobTriggerName = "jobTriggerName1819490804",
            };
            mockGrpcClient.Setup(x => x.CreateDlpJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            DlpJob response = client.CreateDlpJob(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateDlpJobAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            DlpJob expectedResponse = new DlpJob
            {
                Name = "name3373707",
                JobTriggerName = "jobTriggerName1819490804",
            };
            mockGrpcClient.Setup(x => x.CreateDlpJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DlpJob>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            DlpJob response = await client.CreateDlpJobAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetDlpJob()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            GetDlpJobRequest request = new GetDlpJobRequest
            {
                DlpJobName = new DlpJobName("[PROJECT]", "[DLP_JOB]"),
            };
            DlpJob expectedResponse = new DlpJob
            {
                Name = "name2-1052831874",
                JobTriggerName = "jobTriggerName1819490804",
            };
            mockGrpcClient.Setup(x => x.GetDlpJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            DlpJob response = client.GetDlpJob(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetDlpJobAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            GetDlpJobRequest request = new GetDlpJobRequest
            {
                DlpJobName = new DlpJobName("[PROJECT]", "[DLP_JOB]"),
            };
            DlpJob expectedResponse = new DlpJob
            {
                Name = "name2-1052831874",
                JobTriggerName = "jobTriggerName1819490804",
            };
            mockGrpcClient.Setup(x => x.GetDlpJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DlpJob>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            DlpJob response = await client.GetDlpJobAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteDlpJob()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            DeleteDlpJobRequest request = new DeleteDlpJobRequest
            {
                DlpJobName = new DlpJobName("[PROJECT]", "[DLP_JOB]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteDlpJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteDlpJob(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteDlpJobAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            DeleteDlpJobRequest request = new DeleteDlpJobRequest
            {
                DlpJobName = new DlpJobName("[PROJECT]", "[DLP_JOB]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteDlpJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteDlpJobAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CancelDlpJob()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            CancelDlpJobRequest request = new CancelDlpJobRequest
            {
                DlpJobName = new DlpJobName("[PROJECT]", "[DLP_JOB]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.CancelDlpJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            client.CancelDlpJob(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CancelDlpJobAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            CancelDlpJobRequest request = new CancelDlpJobRequest
            {
                DlpJobName = new DlpJobName("[PROJECT]", "[DLP_JOB]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.CancelDlpJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            await client.CancelDlpJobAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetJobTrigger()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            GetJobTriggerRequest request = new GetJobTriggerRequest
            {
                ProjectJobTriggerName = new ProjectJobTriggerName("[PROJECT]", "[JOB_TRIGGER]"),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetJobTrigger(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            JobTrigger response = client.GetJobTrigger(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetJobTriggerAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            GetJobTriggerRequest request = new GetJobTriggerRequest
            {
                ProjectJobTriggerName = new ProjectJobTriggerName("[PROJECT]", "[JOB_TRIGGER]"),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetJobTriggerAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<JobTrigger>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            JobTrigger response = await client.GetJobTriggerAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteJobTrigger()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            DeleteJobTriggerRequest request = new DeleteJobTriggerRequest
            {
                ProjectJobTriggerName = new ProjectJobTriggerName("[PROJECT]", "[JOB_TRIGGER]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteJobTrigger(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJobTrigger(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteJobTriggerAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            DeleteJobTriggerRequest request = new DeleteJobTriggerRequest
            {
                ProjectJobTriggerName = new ProjectJobTriggerName("[PROJECT]", "[JOB_TRIGGER]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteJobTriggerAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobTriggerAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateJobTrigger()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            UpdateJobTriggerRequest request = new UpdateJobTriggerRequest
            {
                ProjectJobTriggerName = new ProjectJobTriggerName("[PROJECT]", "[JOB_TRIGGER]"),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.UpdateJobTrigger(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            JobTrigger response = client.UpdateJobTrigger(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateJobTriggerAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            UpdateJobTriggerRequest request = new UpdateJobTriggerRequest
            {
                ProjectJobTriggerName = new ProjectJobTriggerName("[PROJECT]", "[JOB_TRIGGER]"),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.UpdateJobTriggerAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<JobTrigger>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            JobTrigger response = await client.UpdateJobTriggerAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateJobTrigger()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            CreateJobTriggerRequest request = new CreateJobTriggerRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.CreateJobTrigger(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            JobTrigger response = client.CreateJobTrigger(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateJobTriggerAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            CreateJobTriggerRequest request = new CreateJobTriggerRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            JobTrigger expectedResponse = new JobTrigger
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.CreateJobTriggerAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<JobTrigger>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            JobTrigger response = await client.CreateJobTriggerAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateStoredInfoType()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            CreateStoredInfoTypeRequest request = new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.CreateStoredInfoType(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            StoredInfoType response = client.CreateStoredInfoType(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateStoredInfoTypeAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            CreateStoredInfoTypeRequest request = new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.CreateStoredInfoTypeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<StoredInfoType>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            StoredInfoType response = await client.CreateStoredInfoTypeAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateStoredInfoType()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            UpdateStoredInfoTypeRequest request = new UpdateStoredInfoTypeRequest
            {
                StoredInfoTypeNameOneof = StoredInfoTypeNameOneof.From(new OrganizationStoredInfoTypeName("[ORGANIZATION]", "[STORED_INFO_TYPE]")),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.UpdateStoredInfoType(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            StoredInfoType response = client.UpdateStoredInfoType(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateStoredInfoTypeAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            UpdateStoredInfoTypeRequest request = new UpdateStoredInfoTypeRequest
            {
                StoredInfoTypeNameOneof = StoredInfoTypeNameOneof.From(new OrganizationStoredInfoTypeName("[ORGANIZATION]", "[STORED_INFO_TYPE]")),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.UpdateStoredInfoTypeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<StoredInfoType>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            StoredInfoType response = await client.UpdateStoredInfoTypeAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetStoredInfoType()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            GetStoredInfoTypeRequest request = new GetStoredInfoTypeRequest
            {
                StoredInfoTypeNameOneof = StoredInfoTypeNameOneof.From(new OrganizationStoredInfoTypeName("[ORGANIZATION]", "[STORED_INFO_TYPE]")),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetStoredInfoType(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            StoredInfoType response = client.GetStoredInfoType(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetStoredInfoTypeAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            GetStoredInfoTypeRequest request = new GetStoredInfoTypeRequest
            {
                StoredInfoTypeNameOneof = StoredInfoTypeNameOneof.From(new OrganizationStoredInfoTypeName("[ORGANIZATION]", "[STORED_INFO_TYPE]")),
            };
            StoredInfoType expectedResponse = new StoredInfoType
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetStoredInfoTypeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<StoredInfoType>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            StoredInfoType response = await client.GetStoredInfoTypeAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteStoredInfoType()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            DeleteStoredInfoTypeRequest request = new DeleteStoredInfoTypeRequest
            {
                StoredInfoTypeNameOneof = StoredInfoTypeNameOneof.From(new OrganizationStoredInfoTypeName("[ORGANIZATION]", "[STORED_INFO_TYPE]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteStoredInfoType(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteStoredInfoType(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteStoredInfoTypeAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            DeleteStoredInfoTypeRequest request = new DeleteStoredInfoTypeRequest
            {
                StoredInfoTypeNameOneof = StoredInfoTypeNameOneof.From(new OrganizationStoredInfoTypeName("[ORGANIZATION]", "[STORED_INFO_TYPE]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteStoredInfoTypeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteStoredInfoTypeAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
