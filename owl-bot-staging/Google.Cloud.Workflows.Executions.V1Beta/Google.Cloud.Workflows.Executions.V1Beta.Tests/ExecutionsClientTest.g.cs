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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Workflows.Executions.V1Beta.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedExecutionsClientTest
    {
        [xunit::FactAttribute]
        public void CreateExecutionRequestObject()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            CreateExecutionRequest request = new CreateExecutionRequest
            {
                ParentAsWorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Execution = new Execution(),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Execution.Types.State.Failed,
                Argument = "argument60e0cd03",
                Result = "result1784a8b4",
                Error = new Execution.Types.Error(),
                WorkflowRevisionId = "workflow_revision_id3b9c4f02",
            };
            mockGrpcClient.Setup(x => x.CreateExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null);
            Execution response = client.CreateExecution(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExecutionRequestObjectAsync()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            CreateExecutionRequest request = new CreateExecutionRequest
            {
                ParentAsWorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Execution = new Execution(),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Execution.Types.State.Failed,
                Argument = "argument60e0cd03",
                Result = "result1784a8b4",
                Error = new Execution.Types.Error(),
                WorkflowRevisionId = "workflow_revision_id3b9c4f02",
            };
            mockGrpcClient.Setup(x => x.CreateExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null);
            Execution responseCallSettings = await client.CreateExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.CreateExecutionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExecution()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            CreateExecutionRequest request = new CreateExecutionRequest
            {
                ParentAsWorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Execution = new Execution(),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Execution.Types.State.Failed,
                Argument = "argument60e0cd03",
                Result = "result1784a8b4",
                Error = new Execution.Types.Error(),
                WorkflowRevisionId = "workflow_revision_id3b9c4f02",
            };
            mockGrpcClient.Setup(x => x.CreateExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null);
            Execution response = client.CreateExecution(request.Parent, request.Execution);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExecutionAsync()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            CreateExecutionRequest request = new CreateExecutionRequest
            {
                ParentAsWorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Execution = new Execution(),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Execution.Types.State.Failed,
                Argument = "argument60e0cd03",
                Result = "result1784a8b4",
                Error = new Execution.Types.Error(),
                WorkflowRevisionId = "workflow_revision_id3b9c4f02",
            };
            mockGrpcClient.Setup(x => x.CreateExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null);
            Execution responseCallSettings = await client.CreateExecutionAsync(request.Parent, request.Execution, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.CreateExecutionAsync(request.Parent, request.Execution, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExecutionResourceNames()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            CreateExecutionRequest request = new CreateExecutionRequest
            {
                ParentAsWorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Execution = new Execution(),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Execution.Types.State.Failed,
                Argument = "argument60e0cd03",
                Result = "result1784a8b4",
                Error = new Execution.Types.Error(),
                WorkflowRevisionId = "workflow_revision_id3b9c4f02",
            };
            mockGrpcClient.Setup(x => x.CreateExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null);
            Execution response = client.CreateExecution(request.ParentAsWorkflowName, request.Execution);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExecutionResourceNamesAsync()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            CreateExecutionRequest request = new CreateExecutionRequest
            {
                ParentAsWorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Execution = new Execution(),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Execution.Types.State.Failed,
                Argument = "argument60e0cd03",
                Result = "result1784a8b4",
                Error = new Execution.Types.Error(),
                WorkflowRevisionId = "workflow_revision_id3b9c4f02",
            };
            mockGrpcClient.Setup(x => x.CreateExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null);
            Execution responseCallSettings = await client.CreateExecutionAsync(request.ParentAsWorkflowName, request.Execution, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.CreateExecutionAsync(request.ParentAsWorkflowName, request.Execution, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExecutionRequestObject()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                View = ExecutionView.Basic,
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Execution.Types.State.Failed,
                Argument = "argument60e0cd03",
                Result = "result1784a8b4",
                Error = new Execution.Types.Error(),
                WorkflowRevisionId = "workflow_revision_id3b9c4f02",
            };
            mockGrpcClient.Setup(x => x.GetExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null);
            Execution response = client.GetExecution(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExecutionRequestObjectAsync()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                View = ExecutionView.Basic,
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Execution.Types.State.Failed,
                Argument = "argument60e0cd03",
                Result = "result1784a8b4",
                Error = new Execution.Types.Error(),
                WorkflowRevisionId = "workflow_revision_id3b9c4f02",
            };
            mockGrpcClient.Setup(x => x.GetExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null);
            Execution responseCallSettings = await client.GetExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.GetExecutionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExecution()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Execution.Types.State.Failed,
                Argument = "argument60e0cd03",
                Result = "result1784a8b4",
                Error = new Execution.Types.Error(),
                WorkflowRevisionId = "workflow_revision_id3b9c4f02",
            };
            mockGrpcClient.Setup(x => x.GetExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null);
            Execution response = client.GetExecution(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExecutionAsync()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Execution.Types.State.Failed,
                Argument = "argument60e0cd03",
                Result = "result1784a8b4",
                Error = new Execution.Types.Error(),
                WorkflowRevisionId = "workflow_revision_id3b9c4f02",
            };
            mockGrpcClient.Setup(x => x.GetExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null);
            Execution responseCallSettings = await client.GetExecutionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.GetExecutionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExecutionResourceNames()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Execution.Types.State.Failed,
                Argument = "argument60e0cd03",
                Result = "result1784a8b4",
                Error = new Execution.Types.Error(),
                WorkflowRevisionId = "workflow_revision_id3b9c4f02",
            };
            mockGrpcClient.Setup(x => x.GetExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null);
            Execution response = client.GetExecution(request.ExecutionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExecutionResourceNamesAsync()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Execution.Types.State.Failed,
                Argument = "argument60e0cd03",
                Result = "result1784a8b4",
                Error = new Execution.Types.Error(),
                WorkflowRevisionId = "workflow_revision_id3b9c4f02",
            };
            mockGrpcClient.Setup(x => x.GetExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null);
            Execution responseCallSettings = await client.GetExecutionAsync(request.ExecutionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.GetExecutionAsync(request.ExecutionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelExecutionRequestObject()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            CancelExecutionRequest request = new CancelExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Execution.Types.State.Failed,
                Argument = "argument60e0cd03",
                Result = "result1784a8b4",
                Error = new Execution.Types.Error(),
                WorkflowRevisionId = "workflow_revision_id3b9c4f02",
            };
            mockGrpcClient.Setup(x => x.CancelExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null);
            Execution response = client.CancelExecution(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelExecutionRequestObjectAsync()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            CancelExecutionRequest request = new CancelExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Execution.Types.State.Failed,
                Argument = "argument60e0cd03",
                Result = "result1784a8b4",
                Error = new Execution.Types.Error(),
                WorkflowRevisionId = "workflow_revision_id3b9c4f02",
            };
            mockGrpcClient.Setup(x => x.CancelExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null);
            Execution responseCallSettings = await client.CancelExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.CancelExecutionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelExecution()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            CancelExecutionRequest request = new CancelExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Execution.Types.State.Failed,
                Argument = "argument60e0cd03",
                Result = "result1784a8b4",
                Error = new Execution.Types.Error(),
                WorkflowRevisionId = "workflow_revision_id3b9c4f02",
            };
            mockGrpcClient.Setup(x => x.CancelExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null);
            Execution response = client.CancelExecution(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelExecutionAsync()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            CancelExecutionRequest request = new CancelExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Execution.Types.State.Failed,
                Argument = "argument60e0cd03",
                Result = "result1784a8b4",
                Error = new Execution.Types.Error(),
                WorkflowRevisionId = "workflow_revision_id3b9c4f02",
            };
            mockGrpcClient.Setup(x => x.CancelExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null);
            Execution responseCallSettings = await client.CancelExecutionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.CancelExecutionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelExecutionResourceNames()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            CancelExecutionRequest request = new CancelExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Execution.Types.State.Failed,
                Argument = "argument60e0cd03",
                Result = "result1784a8b4",
                Error = new Execution.Types.Error(),
                WorkflowRevisionId = "workflow_revision_id3b9c4f02",
            };
            mockGrpcClient.Setup(x => x.CancelExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null);
            Execution response = client.CancelExecution(request.ExecutionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelExecutionResourceNamesAsync()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            CancelExecutionRequest request = new CancelExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Execution.Types.State.Failed,
                Argument = "argument60e0cd03",
                Result = "result1784a8b4",
                Error = new Execution.Types.Error(),
                WorkflowRevisionId = "workflow_revision_id3b9c4f02",
            };
            mockGrpcClient.Setup(x => x.CancelExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null);
            Execution responseCallSettings = await client.CancelExecutionAsync(request.ExecutionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.CancelExecutionAsync(request.ExecutionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
