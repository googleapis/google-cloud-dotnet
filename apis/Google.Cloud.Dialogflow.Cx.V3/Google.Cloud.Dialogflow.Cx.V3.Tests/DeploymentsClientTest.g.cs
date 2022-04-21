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

namespace Google.Cloud.Dialogflow.Cx.V3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDeploymentsClientTest
    {
        [xunit::FactAttribute]
        public void GetDeploymentRequestObject()
        {
            moq::Mock<Deployments.DeploymentsClient> mockGrpcClient = new moq::Mock<Deployments.DeploymentsClient>(moq::MockBehavior.Strict);
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationAgentEnvironmentDeployment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[DEPLOYMENT]"),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectLocationAgentEnvironmentDeployment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[DEPLOYMENT]"),
                FlowVersionAsVersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                State = Deployment.Types.State.Succeeded,
                Result = new Deployment.Types.Result(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeploymentsClient client = new DeploymentsClientImpl(mockGrpcClient.Object, null, null);
            Deployment response = client.GetDeployment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeploymentRequestObjectAsync()
        {
            moq::Mock<Deployments.DeploymentsClient> mockGrpcClient = new moq::Mock<Deployments.DeploymentsClient>(moq::MockBehavior.Strict);
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationAgentEnvironmentDeployment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[DEPLOYMENT]"),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectLocationAgentEnvironmentDeployment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[DEPLOYMENT]"),
                FlowVersionAsVersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                State = Deployment.Types.State.Succeeded,
                Result = new Deployment.Types.Result(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Deployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeploymentsClient client = new DeploymentsClientImpl(mockGrpcClient.Object, null, null);
            Deployment responseCallSettings = await client.GetDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Deployment responseCancellationToken = await client.GetDeploymentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDeployment()
        {
            moq::Mock<Deployments.DeploymentsClient> mockGrpcClient = new moq::Mock<Deployments.DeploymentsClient>(moq::MockBehavior.Strict);
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationAgentEnvironmentDeployment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[DEPLOYMENT]"),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectLocationAgentEnvironmentDeployment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[DEPLOYMENT]"),
                FlowVersionAsVersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                State = Deployment.Types.State.Succeeded,
                Result = new Deployment.Types.Result(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeploymentsClient client = new DeploymentsClientImpl(mockGrpcClient.Object, null, null);
            Deployment response = client.GetDeployment(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeploymentAsync()
        {
            moq::Mock<Deployments.DeploymentsClient> mockGrpcClient = new moq::Mock<Deployments.DeploymentsClient>(moq::MockBehavior.Strict);
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationAgentEnvironmentDeployment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[DEPLOYMENT]"),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectLocationAgentEnvironmentDeployment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[DEPLOYMENT]"),
                FlowVersionAsVersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                State = Deployment.Types.State.Succeeded,
                Result = new Deployment.Types.Result(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Deployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeploymentsClient client = new DeploymentsClientImpl(mockGrpcClient.Object, null, null);
            Deployment responseCallSettings = await client.GetDeploymentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Deployment responseCancellationToken = await client.GetDeploymentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDeploymentResourceNames()
        {
            moq::Mock<Deployments.DeploymentsClient> mockGrpcClient = new moq::Mock<Deployments.DeploymentsClient>(moq::MockBehavior.Strict);
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationAgentEnvironmentDeployment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[DEPLOYMENT]"),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectLocationAgentEnvironmentDeployment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[DEPLOYMENT]"),
                FlowVersionAsVersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                State = Deployment.Types.State.Succeeded,
                Result = new Deployment.Types.Result(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DeploymentsClient client = new DeploymentsClientImpl(mockGrpcClient.Object, null, null);
            Deployment response = client.GetDeployment(request.DeploymentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeploymentResourceNamesAsync()
        {
            moq::Mock<Deployments.DeploymentsClient> mockGrpcClient = new moq::Mock<Deployments.DeploymentsClient>(moq::MockBehavior.Strict);
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationAgentEnvironmentDeployment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[DEPLOYMENT]"),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectLocationAgentEnvironmentDeployment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[DEPLOYMENT]"),
                FlowVersionAsVersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                State = Deployment.Types.State.Succeeded,
                Result = new Deployment.Types.Result(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Deployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DeploymentsClient client = new DeploymentsClientImpl(mockGrpcClient.Object, null, null);
            Deployment responseCallSettings = await client.GetDeploymentAsync(request.DeploymentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Deployment responseCancellationToken = await client.GetDeploymentAsync(request.DeploymentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
