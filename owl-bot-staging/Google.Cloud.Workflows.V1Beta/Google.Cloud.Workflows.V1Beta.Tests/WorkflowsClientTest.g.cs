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

namespace Google.Cloud.Workflows.V1Beta.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedWorkflowsClientTest
    {
        [xunit::FactAttribute]
        public void GetWorkflowRequestObject()
        {
            moq::Mock<Workflows.WorkflowsClient> mockGrpcClient = new moq::Mock<Workflows.WorkflowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkflowRequest request = new GetWorkflowRequest
            {
                WorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            Workflow expectedResponse = new Workflow
            {
                WorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Description = "description2cf9da67",
                State = Workflow.Types.State.Unspecified,
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ServiceAccount = "service_accounta3c1b923",
                SourceContents = "source_contentscf4464d3",
            };
            mockGrpcClient.Setup(x => x.GetWorkflow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowsClient client = new WorkflowsClientImpl(mockGrpcClient.Object, null);
            Workflow response = client.GetWorkflow(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkflowRequestObjectAsync()
        {
            moq::Mock<Workflows.WorkflowsClient> mockGrpcClient = new moq::Mock<Workflows.WorkflowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkflowRequest request = new GetWorkflowRequest
            {
                WorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            Workflow expectedResponse = new Workflow
            {
                WorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Description = "description2cf9da67",
                State = Workflow.Types.State.Unspecified,
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ServiceAccount = "service_accounta3c1b923",
                SourceContents = "source_contentscf4464d3",
            };
            mockGrpcClient.Setup(x => x.GetWorkflowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Workflow>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowsClient client = new WorkflowsClientImpl(mockGrpcClient.Object, null);
            Workflow responseCallSettings = await client.GetWorkflowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Workflow responseCancellationToken = await client.GetWorkflowAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkflow()
        {
            moq::Mock<Workflows.WorkflowsClient> mockGrpcClient = new moq::Mock<Workflows.WorkflowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkflowRequest request = new GetWorkflowRequest
            {
                WorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            Workflow expectedResponse = new Workflow
            {
                WorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Description = "description2cf9da67",
                State = Workflow.Types.State.Unspecified,
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ServiceAccount = "service_accounta3c1b923",
                SourceContents = "source_contentscf4464d3",
            };
            mockGrpcClient.Setup(x => x.GetWorkflow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowsClient client = new WorkflowsClientImpl(mockGrpcClient.Object, null);
            Workflow response = client.GetWorkflow(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkflowAsync()
        {
            moq::Mock<Workflows.WorkflowsClient> mockGrpcClient = new moq::Mock<Workflows.WorkflowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkflowRequest request = new GetWorkflowRequest
            {
                WorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            Workflow expectedResponse = new Workflow
            {
                WorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Description = "description2cf9da67",
                State = Workflow.Types.State.Unspecified,
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ServiceAccount = "service_accounta3c1b923",
                SourceContents = "source_contentscf4464d3",
            };
            mockGrpcClient.Setup(x => x.GetWorkflowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Workflow>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowsClient client = new WorkflowsClientImpl(mockGrpcClient.Object, null);
            Workflow responseCallSettings = await client.GetWorkflowAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Workflow responseCancellationToken = await client.GetWorkflowAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkflowResourceNames()
        {
            moq::Mock<Workflows.WorkflowsClient> mockGrpcClient = new moq::Mock<Workflows.WorkflowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkflowRequest request = new GetWorkflowRequest
            {
                WorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            Workflow expectedResponse = new Workflow
            {
                WorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Description = "description2cf9da67",
                State = Workflow.Types.State.Unspecified,
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ServiceAccount = "service_accounta3c1b923",
                SourceContents = "source_contentscf4464d3",
            };
            mockGrpcClient.Setup(x => x.GetWorkflow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowsClient client = new WorkflowsClientImpl(mockGrpcClient.Object, null);
            Workflow response = client.GetWorkflow(request.WorkflowName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkflowResourceNamesAsync()
        {
            moq::Mock<Workflows.WorkflowsClient> mockGrpcClient = new moq::Mock<Workflows.WorkflowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkflowRequest request = new GetWorkflowRequest
            {
                WorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            Workflow expectedResponse = new Workflow
            {
                WorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Description = "description2cf9da67",
                State = Workflow.Types.State.Unspecified,
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ServiceAccount = "service_accounta3c1b923",
                SourceContents = "source_contentscf4464d3",
            };
            mockGrpcClient.Setup(x => x.GetWorkflowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Workflow>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowsClient client = new WorkflowsClientImpl(mockGrpcClient.Object, null);
            Workflow responseCallSettings = await client.GetWorkflowAsync(request.WorkflowName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Workflow responseCancellationToken = await client.GetWorkflowAsync(request.WorkflowName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
