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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Shell.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCloudShellServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetEnvironmentRequestObject()
        {
            moq::Mock<CloudShellService.CloudShellServiceClient> mockGrpcClient = new moq::Mock<CloudShellService.CloudShellServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromUserEnvironment("[USER]", "[ENVIRONMENT]"),
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromUserEnvironment("[USER]", "[ENVIRONMENT]"),
                Id = "id74b70bb8",
                DockerImage = "docker_image790036d7",
                State = Environment.Types.State.Running,
                SshUsername = "ssh_usernamef089694d",
                SshHost = "ssh_hostf6f9047e",
                SshPort = 385289463,
                PublicKeys =
                {
                    "public_keys8ff48db4",
                },
                WebHost = "web_hosta5049b32",
            };
            mockGrpcClient.Setup(x => x.GetEnvironment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudShellServiceClient client = new CloudShellServiceClientImpl(mockGrpcClient.Object, null);
            Environment response = client.GetEnvironment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEnvironmentRequestObjectAsync()
        {
            moq::Mock<CloudShellService.CloudShellServiceClient> mockGrpcClient = new moq::Mock<CloudShellService.CloudShellServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromUserEnvironment("[USER]", "[ENVIRONMENT]"),
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromUserEnvironment("[USER]", "[ENVIRONMENT]"),
                Id = "id74b70bb8",
                DockerImage = "docker_image790036d7",
                State = Environment.Types.State.Running,
                SshUsername = "ssh_usernamef089694d",
                SshHost = "ssh_hostf6f9047e",
                SshPort = 385289463,
                PublicKeys =
                {
                    "public_keys8ff48db4",
                },
                WebHost = "web_hosta5049b32",
            };
            mockGrpcClient.Setup(x => x.GetEnvironmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Environment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudShellServiceClient client = new CloudShellServiceClientImpl(mockGrpcClient.Object, null);
            Environment responseCallSettings = await client.GetEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Environment responseCancellationToken = await client.GetEnvironmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEnvironment()
        {
            moq::Mock<CloudShellService.CloudShellServiceClient> mockGrpcClient = new moq::Mock<CloudShellService.CloudShellServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromUserEnvironment("[USER]", "[ENVIRONMENT]"),
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromUserEnvironment("[USER]", "[ENVIRONMENT]"),
                Id = "id74b70bb8",
                DockerImage = "docker_image790036d7",
                State = Environment.Types.State.Running,
                SshUsername = "ssh_usernamef089694d",
                SshHost = "ssh_hostf6f9047e",
                SshPort = 385289463,
                PublicKeys =
                {
                    "public_keys8ff48db4",
                },
                WebHost = "web_hosta5049b32",
            };
            mockGrpcClient.Setup(x => x.GetEnvironment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudShellServiceClient client = new CloudShellServiceClientImpl(mockGrpcClient.Object, null);
            Environment response = client.GetEnvironment(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEnvironmentAsync()
        {
            moq::Mock<CloudShellService.CloudShellServiceClient> mockGrpcClient = new moq::Mock<CloudShellService.CloudShellServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromUserEnvironment("[USER]", "[ENVIRONMENT]"),
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromUserEnvironment("[USER]", "[ENVIRONMENT]"),
                Id = "id74b70bb8",
                DockerImage = "docker_image790036d7",
                State = Environment.Types.State.Running,
                SshUsername = "ssh_usernamef089694d",
                SshHost = "ssh_hostf6f9047e",
                SshPort = 385289463,
                PublicKeys =
                {
                    "public_keys8ff48db4",
                },
                WebHost = "web_hosta5049b32",
            };
            mockGrpcClient.Setup(x => x.GetEnvironmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Environment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudShellServiceClient client = new CloudShellServiceClientImpl(mockGrpcClient.Object, null);
            Environment responseCallSettings = await client.GetEnvironmentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Environment responseCancellationToken = await client.GetEnvironmentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEnvironmentResourceNames()
        {
            moq::Mock<CloudShellService.CloudShellServiceClient> mockGrpcClient = new moq::Mock<CloudShellService.CloudShellServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromUserEnvironment("[USER]", "[ENVIRONMENT]"),
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromUserEnvironment("[USER]", "[ENVIRONMENT]"),
                Id = "id74b70bb8",
                DockerImage = "docker_image790036d7",
                State = Environment.Types.State.Running,
                SshUsername = "ssh_usernamef089694d",
                SshHost = "ssh_hostf6f9047e",
                SshPort = 385289463,
                PublicKeys =
                {
                    "public_keys8ff48db4",
                },
                WebHost = "web_hosta5049b32",
            };
            mockGrpcClient.Setup(x => x.GetEnvironment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudShellServiceClient client = new CloudShellServiceClientImpl(mockGrpcClient.Object, null);
            Environment response = client.GetEnvironment(request.EnvironmentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEnvironmentResourceNamesAsync()
        {
            moq::Mock<CloudShellService.CloudShellServiceClient> mockGrpcClient = new moq::Mock<CloudShellService.CloudShellServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromUserEnvironment("[USER]", "[ENVIRONMENT]"),
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromUserEnvironment("[USER]", "[ENVIRONMENT]"),
                Id = "id74b70bb8",
                DockerImage = "docker_image790036d7",
                State = Environment.Types.State.Running,
                SshUsername = "ssh_usernamef089694d",
                SshHost = "ssh_hostf6f9047e",
                SshPort = 385289463,
                PublicKeys =
                {
                    "public_keys8ff48db4",
                },
                WebHost = "web_hosta5049b32",
            };
            mockGrpcClient.Setup(x => x.GetEnvironmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Environment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudShellServiceClient client = new CloudShellServiceClientImpl(mockGrpcClient.Object, null);
            Environment responseCallSettings = await client.GetEnvironmentAsync(request.EnvironmentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Environment responseCancellationToken = await client.GetEnvironmentAsync(request.EnvironmentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
