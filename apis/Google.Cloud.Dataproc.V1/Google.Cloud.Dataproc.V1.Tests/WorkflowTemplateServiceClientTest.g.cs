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

namespace Google.Cloud.Dataproc.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Dataproc.V1;
    using Google.LongRunning;
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
    public class GeneratedWorkflowTemplateServiceClientTest
    {
        [Fact]
        public void CreateWorkflowTemplate()
        {
            Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest expectedRequest = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = new RegionName("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                Id = "id3355",
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 351608024,
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplate(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            RegionName parent = new RegionName("[PROJECT]", "[REGION]");
            WorkflowTemplate template = new WorkflowTemplate();
            WorkflowTemplate response = client.CreateWorkflowTemplate(parent, template);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateWorkflowTemplateAsync()
        {
            Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest expectedRequest = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = new RegionName("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                Id = "id3355",
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 351608024,
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplateAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<WorkflowTemplate>(Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            RegionName parent = new RegionName("[PROJECT]", "[REGION]");
            WorkflowTemplate template = new WorkflowTemplate();
            WorkflowTemplate response = await client.CreateWorkflowTemplateAsync(parent, template);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateWorkflowTemplate2()
        {
            Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = new RegionName("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                Id = "id3355",
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 351608024,
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplate(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.CreateWorkflowTemplate(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateWorkflowTemplateAsync2()
        {
            Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = new RegionName("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                Id = "id3355",
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 351608024,
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplateAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<WorkflowTemplate>(Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = await client.CreateWorkflowTemplateAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetWorkflowTemplate()
        {
            Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetWorkflowTemplateRequest expectedRequest = new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                Id = "id3355",
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 351608024,
            };
            mockGrpcClient.Setup(x => x.GetWorkflowTemplate(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplateName name = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]");
            WorkflowTemplate response = client.GetWorkflowTemplate(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetWorkflowTemplateAsync()
        {
            Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetWorkflowTemplateRequest expectedRequest = new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                Id = "id3355",
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 351608024,
            };
            mockGrpcClient.Setup(x => x.GetWorkflowTemplateAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<WorkflowTemplate>(Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplateName name = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]");
            WorkflowTemplate response = await client.GetWorkflowTemplateAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetWorkflowTemplate2()
        {
            Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetWorkflowTemplateRequest request = new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                Id = "id3355",
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 351608024,
            };
            mockGrpcClient.Setup(x => x.GetWorkflowTemplate(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.GetWorkflowTemplate(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetWorkflowTemplateAsync2()
        {
            Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetWorkflowTemplateRequest request = new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                Id = "id3355",
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 351608024,
            };
            mockGrpcClient.Setup(x => x.GetWorkflowTemplateAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<WorkflowTemplate>(Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = await client.GetWorkflowTemplateAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateWorkflowTemplate()
        {
            Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateWorkflowTemplateRequest expectedRequest = new UpdateWorkflowTemplateRequest
            {
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                Id = "id3355",
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 351608024,
            };
            mockGrpcClient.Setup(x => x.UpdateWorkflowTemplate(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate template = new WorkflowTemplate();
            WorkflowTemplate response = client.UpdateWorkflowTemplate(template);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateWorkflowTemplateAsync()
        {
            Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateWorkflowTemplateRequest expectedRequest = new UpdateWorkflowTemplateRequest
            {
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                Id = "id3355",
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 351608024,
            };
            mockGrpcClient.Setup(x => x.UpdateWorkflowTemplateAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<WorkflowTemplate>(Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate template = new WorkflowTemplate();
            WorkflowTemplate response = await client.UpdateWorkflowTemplateAsync(template);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateWorkflowTemplate2()
        {
            Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateWorkflowTemplateRequest request = new UpdateWorkflowTemplateRequest
            {
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                Id = "id3355",
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 351608024,
            };
            mockGrpcClient.Setup(x => x.UpdateWorkflowTemplate(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.UpdateWorkflowTemplate(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateWorkflowTemplateAsync2()
        {
            Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateWorkflowTemplateRequest request = new UpdateWorkflowTemplateRequest
            {
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                Id = "id3355",
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 351608024,
            };
            mockGrpcClient.Setup(x => x.UpdateWorkflowTemplateAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<WorkflowTemplate>(Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = await client.UpdateWorkflowTemplateAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteWorkflowTemplate()
        {
            Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteWorkflowTemplateRequest expectedRequest = new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteWorkflowTemplate(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplateName name = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]");
            client.DeleteWorkflowTemplate(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteWorkflowTemplateAsync()
        {
            Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteWorkflowTemplateRequest expectedRequest = new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteWorkflowTemplateAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplateName name = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]");
            await client.DeleteWorkflowTemplateAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteWorkflowTemplate2()
        {
            Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteWorkflowTemplateRequest request = new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteWorkflowTemplate(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteWorkflowTemplate(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteWorkflowTemplateAsync2()
        {
            Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteWorkflowTemplateRequest request = new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteWorkflowTemplateAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteWorkflowTemplateAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
