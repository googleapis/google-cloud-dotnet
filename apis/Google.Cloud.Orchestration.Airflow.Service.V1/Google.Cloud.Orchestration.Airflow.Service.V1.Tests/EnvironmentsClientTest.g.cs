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

namespace Google.Cloud.Orchestration.Airflow.Service.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedEnvironmentsClientTest
    {
        [xunit::FactAttribute]
        public void GetEnvironmentRequestObject()
        {
            moq::Mock<Environments.EnvironmentsClient> mockGrpcClient = new moq::Mock<Environments.EnvironmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                Name = "name1c9368b0",
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]"),
                Config = new EnvironmentConfig(),
                Uuid = "uuid6f877cef",
                State = Environment.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetEnvironment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EnvironmentsClient client = new EnvironmentsClientImpl(mockGrpcClient.Object, null, null);
            Environment response = client.GetEnvironment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEnvironmentRequestObjectAsync()
        {
            moq::Mock<Environments.EnvironmentsClient> mockGrpcClient = new moq::Mock<Environments.EnvironmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                Name = "name1c9368b0",
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]"),
                Config = new EnvironmentConfig(),
                Uuid = "uuid6f877cef",
                State = Environment.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetEnvironmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Environment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EnvironmentsClient client = new EnvironmentsClientImpl(mockGrpcClient.Object, null, null);
            Environment responseCallSettings = await client.GetEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Environment responseCancellationToken = await client.GetEnvironmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEnvironment()
        {
            moq::Mock<Environments.EnvironmentsClient> mockGrpcClient = new moq::Mock<Environments.EnvironmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                Name = "name1c9368b0",
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]"),
                Config = new EnvironmentConfig(),
                Uuid = "uuid6f877cef",
                State = Environment.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetEnvironment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EnvironmentsClient client = new EnvironmentsClientImpl(mockGrpcClient.Object, null, null);
            Environment response = client.GetEnvironment(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEnvironmentAsync()
        {
            moq::Mock<Environments.EnvironmentsClient> mockGrpcClient = new moq::Mock<Environments.EnvironmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                Name = "name1c9368b0",
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]"),
                Config = new EnvironmentConfig(),
                Uuid = "uuid6f877cef",
                State = Environment.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetEnvironmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Environment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EnvironmentsClient client = new EnvironmentsClientImpl(mockGrpcClient.Object, null, null);
            Environment responseCallSettings = await client.GetEnvironmentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Environment responseCancellationToken = await client.GetEnvironmentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
