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

namespace Google.Cloud.Dataproc.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedWorkflowTemplateServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateWorkflowTemplateRequestObject()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = RegionName.FromProjectRegion("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement(),
                Jobs = { new OrderedJob(), },
                Parameters =
                {
                    new TemplateParameter(),
                },
                DagTimeout = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.CreateWorkflowTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWorkflowTemplateRequestObjectAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = RegionName.FromProjectRegion("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement(),
                Jobs = { new OrderedJob(), },
                Parameters =
                {
                    new TemplateParameter(),
                },
                DagTimeout = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate responseCallSettings = await client.CreateWorkflowTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowTemplate responseCancellationToken = await client.CreateWorkflowTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWorkflowTemplate()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = RegionName.FromProjectRegion("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement(),
                Jobs = { new OrderedJob(), },
                Parameters =
                {
                    new TemplateParameter(),
                },
                DagTimeout = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.CreateWorkflowTemplate(request.Parent, request.Template);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWorkflowTemplateAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = RegionName.FromProjectRegion("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement(),
                Jobs = { new OrderedJob(), },
                Parameters =
                {
                    new TemplateParameter(),
                },
                DagTimeout = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate responseCallSettings = await client.CreateWorkflowTemplateAsync(request.Parent, request.Template, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowTemplate responseCancellationToken = await client.CreateWorkflowTemplateAsync(request.Parent, request.Template, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWorkflowTemplateResourceNames1()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = RegionName.FromProjectRegion("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement(),
                Jobs = { new OrderedJob(), },
                Parameters =
                {
                    new TemplateParameter(),
                },
                DagTimeout = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.CreateWorkflowTemplate(request.ParentAsRegionName, request.Template);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWorkflowTemplateResourceNames1Async()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = RegionName.FromProjectRegion("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement(),
                Jobs = { new OrderedJob(), },
                Parameters =
                {
                    new TemplateParameter(),
                },
                DagTimeout = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate responseCallSettings = await client.CreateWorkflowTemplateAsync(request.ParentAsRegionName, request.Template, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowTemplate responseCancellationToken = await client.CreateWorkflowTemplateAsync(request.ParentAsRegionName, request.Template, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWorkflowTemplateResourceNames2()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = RegionName.FromProjectRegion("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement(),
                Jobs = { new OrderedJob(), },
                Parameters =
                {
                    new TemplateParameter(),
                },
                DagTimeout = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.CreateWorkflowTemplate(request.ParentAsLocationName, request.Template);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWorkflowTemplateResourceNames2Async()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = RegionName.FromProjectRegion("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement(),
                Jobs = { new OrderedJob(), },
                Parameters =
                {
                    new TemplateParameter(),
                },
                DagTimeout = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate responseCallSettings = await client.CreateWorkflowTemplateAsync(request.ParentAsLocationName, request.Template, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowTemplate responseCancellationToken = await client.CreateWorkflowTemplateAsync(request.ParentAsLocationName, request.Template, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkflowTemplateRequestObject()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkflowTemplateRequest request = new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 271578922,
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement(),
                Jobs = { new OrderedJob(), },
                Parameters =
                {
                    new TemplateParameter(),
                },
                DagTimeout = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.GetWorkflowTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkflowTemplateRequestObjectAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkflowTemplateRequest request = new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 271578922,
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement(),
                Jobs = { new OrderedJob(), },
                Parameters =
                {
                    new TemplateParameter(),
                },
                DagTimeout = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate responseCallSettings = await client.GetWorkflowTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowTemplate responseCancellationToken = await client.GetWorkflowTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkflowTemplate()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkflowTemplateRequest request = new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement(),
                Jobs = { new OrderedJob(), },
                Parameters =
                {
                    new TemplateParameter(),
                },
                DagTimeout = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.GetWorkflowTemplate(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkflowTemplateAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkflowTemplateRequest request = new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement(),
                Jobs = { new OrderedJob(), },
                Parameters =
                {
                    new TemplateParameter(),
                },
                DagTimeout = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate responseCallSettings = await client.GetWorkflowTemplateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowTemplate responseCancellationToken = await client.GetWorkflowTemplateAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkflowTemplateResourceNames()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkflowTemplateRequest request = new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement(),
                Jobs = { new OrderedJob(), },
                Parameters =
                {
                    new TemplateParameter(),
                },
                DagTimeout = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.GetWorkflowTemplate(request.WorkflowTemplateName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkflowTemplateResourceNamesAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkflowTemplateRequest request = new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement(),
                Jobs = { new OrderedJob(), },
                Parameters =
                {
                    new TemplateParameter(),
                },
                DagTimeout = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate responseCallSettings = await client.GetWorkflowTemplateAsync(request.WorkflowTemplateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowTemplate responseCancellationToken = await client.GetWorkflowTemplateAsync(request.WorkflowTemplateName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateWorkflowTemplateRequestObject()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateWorkflowTemplateRequest request = new UpdateWorkflowTemplateRequest
            {
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement(),
                Jobs = { new OrderedJob(), },
                Parameters =
                {
                    new TemplateParameter(),
                },
                DagTimeout = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.UpdateWorkflowTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateWorkflowTemplateRequestObjectAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateWorkflowTemplateRequest request = new UpdateWorkflowTemplateRequest
            {
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement(),
                Jobs = { new OrderedJob(), },
                Parameters =
                {
                    new TemplateParameter(),
                },
                DagTimeout = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate responseCallSettings = await client.UpdateWorkflowTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowTemplate responseCancellationToken = await client.UpdateWorkflowTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateWorkflowTemplate()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateWorkflowTemplateRequest request = new UpdateWorkflowTemplateRequest
            {
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement(),
                Jobs = { new OrderedJob(), },
                Parameters =
                {
                    new TemplateParameter(),
                },
                DagTimeout = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.UpdateWorkflowTemplate(request.Template);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateWorkflowTemplateAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateWorkflowTemplateRequest request = new UpdateWorkflowTemplateRequest
            {
                Template = new WorkflowTemplate(),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement(),
                Jobs = { new OrderedJob(), },
                Parameters =
                {
                    new TemplateParameter(),
                },
                DagTimeout = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate responseCallSettings = await client.UpdateWorkflowTemplateAsync(request.Template, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowTemplate responseCancellationToken = await client.UpdateWorkflowTemplateAsync(request.Template, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWorkflowTemplateRequestObject()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkflowTemplateRequest request = new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 271578922,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteWorkflowTemplate(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWorkflowTemplateRequestObjectAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkflowTemplateRequest request = new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 271578922,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteWorkflowTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWorkflowTemplateAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWorkflowTemplate()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkflowTemplateRequest request = new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteWorkflowTemplate(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWorkflowTemplateAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkflowTemplateRequest request = new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteWorkflowTemplateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWorkflowTemplateAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWorkflowTemplateResourceNames()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkflowTemplateRequest request = new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteWorkflowTemplate(request.WorkflowTemplateName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWorkflowTemplateResourceNamesAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkflowTemplateRequest request = new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteWorkflowTemplateAsync(request.WorkflowTemplateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWorkflowTemplateAsync(request.WorkflowTemplateName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
