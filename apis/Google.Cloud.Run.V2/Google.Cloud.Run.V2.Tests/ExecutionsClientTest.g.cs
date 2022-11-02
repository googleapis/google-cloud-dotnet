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
using ga = Google.Api;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Run.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedExecutionsClientTest
    {
        [xunit::FactAttribute]
        public void GetExecutionRequestObject()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
                Uid = "uida2d37198",
                Generation = -8788800127544411748L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                CompletionTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                LaunchStage = ga::LaunchStage.Unspecified,
                JobAsJobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Parallelism = 2126969836,
                TaskCount = -271415057,
                Template = new TaskTemplate(),
                Reconciling = false,
                Conditions = { new Condition(), },
                ObservedGeneration = -4521268473882310455L,
                RunningCount = 1345644984,
                SucceededCount = -221558037,
                FailedCount = -146527681,
                StartTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null, null);
            Execution response = client.GetExecution(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExecutionRequestObjectAsync()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
                Uid = "uida2d37198",
                Generation = -8788800127544411748L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                CompletionTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                LaunchStage = ga::LaunchStage.Unspecified,
                JobAsJobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Parallelism = 2126969836,
                TaskCount = -271415057,
                Template = new TaskTemplate(),
                Reconciling = false,
                Conditions = { new Condition(), },
                ObservedGeneration = -4521268473882310455L,
                RunningCount = 1345644984,
                SucceededCount = -221558037,
                FailedCount = -146527681,
                StartTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
                Uid = "uida2d37198",
                Generation = -8788800127544411748L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                CompletionTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                LaunchStage = ga::LaunchStage.Unspecified,
                JobAsJobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Parallelism = 2126969836,
                TaskCount = -271415057,
                Template = new TaskTemplate(),
                Reconciling = false,
                Conditions = { new Condition(), },
                ObservedGeneration = -4521268473882310455L,
                RunningCount = 1345644984,
                SucceededCount = -221558037,
                FailedCount = -146527681,
                StartTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null, null);
            Execution response = client.GetExecution(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExecutionAsync()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
                Uid = "uida2d37198",
                Generation = -8788800127544411748L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                CompletionTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                LaunchStage = ga::LaunchStage.Unspecified,
                JobAsJobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Parallelism = 2126969836,
                TaskCount = -271415057,
                Template = new TaskTemplate(),
                Reconciling = false,
                Conditions = { new Condition(), },
                ObservedGeneration = -4521268473882310455L,
                RunningCount = 1345644984,
                SucceededCount = -221558037,
                FailedCount = -146527681,
                StartTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
                Uid = "uida2d37198",
                Generation = -8788800127544411748L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                CompletionTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                LaunchStage = ga::LaunchStage.Unspecified,
                JobAsJobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Parallelism = 2126969836,
                TaskCount = -271415057,
                Template = new TaskTemplate(),
                Reconciling = false,
                Conditions = { new Condition(), },
                ObservedGeneration = -4521268473882310455L,
                RunningCount = 1345644984,
                SucceededCount = -221558037,
                FailedCount = -146527681,
                StartTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null, null);
            Execution response = client.GetExecution(request.ExecutionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExecutionResourceNamesAsync()
        {
            moq::Mock<Executions.ExecutionsClient> mockGrpcClient = new moq::Mock<Executions.ExecutionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionName = ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
                Uid = "uida2d37198",
                Generation = -8788800127544411748L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                CompletionTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                LaunchStage = ga::LaunchStage.Unspecified,
                JobAsJobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Parallelism = 2126969836,
                TaskCount = -271415057,
                Template = new TaskTemplate(),
                Reconciling = false,
                Conditions = { new Condition(), },
                ObservedGeneration = -4521268473882310455L,
                RunningCount = 1345644984,
                SucceededCount = -221558037,
                FailedCount = -146527681,
                StartTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExecutionsClient client = new ExecutionsClientImpl(mockGrpcClient.Object, null, null);
            Execution responseCallSettings = await client.GetExecutionAsync(request.ExecutionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.GetExecutionAsync(request.ExecutionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
