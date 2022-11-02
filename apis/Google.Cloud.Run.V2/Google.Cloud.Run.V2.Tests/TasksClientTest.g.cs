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
using gcl = Google.Cloud.Location;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Run.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTasksClientTest
    {
        [xunit::FactAttribute]
        public void GetTaskRequestObject()
        {
            moq::Mock<Tasks.TasksClient> mockGrpcClient = new moq::Mock<Tasks.TasksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationJobExecutionTask("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationJobExecutionTask("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]", "[TASK]"),
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
                JobAsJobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
                Containers = { new Container(), },
                Volumes = { new Volume(), },
                MaxRetries = -2066036349,
                Timeout = new wkt::Duration(),
                ServiceAccount = "service_accounta3c1b923",
                ExecutionEnvironment = ExecutionEnvironment.Unspecified,
                Reconciling = false,
                Conditions = { new Condition(), },
                ObservedGeneration = -4521268473882310455L,
                Index = 1429051754,
                Retried = 508292519,
                LastAttemptResult = new TaskAttemptResult(),
                StartTime = new wkt::Timestamp(),
                EncryptionKeyAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                VpcAccess = new VpcAccess(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TasksClient client = new TasksClientImpl(mockGrpcClient.Object, null, null);
            Task response = client.GetTask(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTaskRequestObjectAsync()
        {
            moq::Mock<Tasks.TasksClient> mockGrpcClient = new moq::Mock<Tasks.TasksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationJobExecutionTask("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationJobExecutionTask("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]", "[TASK]"),
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
                JobAsJobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
                Containers = { new Container(), },
                Volumes = { new Volume(), },
                MaxRetries = -2066036349,
                Timeout = new wkt::Duration(),
                ServiceAccount = "service_accounta3c1b923",
                ExecutionEnvironment = ExecutionEnvironment.Unspecified,
                Reconciling = false,
                Conditions = { new Condition(), },
                ObservedGeneration = -4521268473882310455L,
                Index = 1429051754,
                Retried = 508292519,
                LastAttemptResult = new TaskAttemptResult(),
                StartTime = new wkt::Timestamp(),
                EncryptionKeyAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                VpcAccess = new VpcAccess(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TasksClient client = new TasksClientImpl(mockGrpcClient.Object, null, null);
            Task responseCallSettings = await client.GetTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.GetTaskAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTask()
        {
            moq::Mock<Tasks.TasksClient> mockGrpcClient = new moq::Mock<Tasks.TasksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationJobExecutionTask("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationJobExecutionTask("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]", "[TASK]"),
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
                JobAsJobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
                Containers = { new Container(), },
                Volumes = { new Volume(), },
                MaxRetries = -2066036349,
                Timeout = new wkt::Duration(),
                ServiceAccount = "service_accounta3c1b923",
                ExecutionEnvironment = ExecutionEnvironment.Unspecified,
                Reconciling = false,
                Conditions = { new Condition(), },
                ObservedGeneration = -4521268473882310455L,
                Index = 1429051754,
                Retried = 508292519,
                LastAttemptResult = new TaskAttemptResult(),
                StartTime = new wkt::Timestamp(),
                EncryptionKeyAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                VpcAccess = new VpcAccess(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TasksClient client = new TasksClientImpl(mockGrpcClient.Object, null, null);
            Task response = client.GetTask(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTaskAsync()
        {
            moq::Mock<Tasks.TasksClient> mockGrpcClient = new moq::Mock<Tasks.TasksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationJobExecutionTask("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationJobExecutionTask("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]", "[TASK]"),
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
                JobAsJobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
                Containers = { new Container(), },
                Volumes = { new Volume(), },
                MaxRetries = -2066036349,
                Timeout = new wkt::Duration(),
                ServiceAccount = "service_accounta3c1b923",
                ExecutionEnvironment = ExecutionEnvironment.Unspecified,
                Reconciling = false,
                Conditions = { new Condition(), },
                ObservedGeneration = -4521268473882310455L,
                Index = 1429051754,
                Retried = 508292519,
                LastAttemptResult = new TaskAttemptResult(),
                StartTime = new wkt::Timestamp(),
                EncryptionKeyAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                VpcAccess = new VpcAccess(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TasksClient client = new TasksClientImpl(mockGrpcClient.Object, null, null);
            Task responseCallSettings = await client.GetTaskAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.GetTaskAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTaskResourceNames()
        {
            moq::Mock<Tasks.TasksClient> mockGrpcClient = new moq::Mock<Tasks.TasksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationJobExecutionTask("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationJobExecutionTask("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]", "[TASK]"),
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
                JobAsJobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
                Containers = { new Container(), },
                Volumes = { new Volume(), },
                MaxRetries = -2066036349,
                Timeout = new wkt::Duration(),
                ServiceAccount = "service_accounta3c1b923",
                ExecutionEnvironment = ExecutionEnvironment.Unspecified,
                Reconciling = false,
                Conditions = { new Condition(), },
                ObservedGeneration = -4521268473882310455L,
                Index = 1429051754,
                Retried = 508292519,
                LastAttemptResult = new TaskAttemptResult(),
                StartTime = new wkt::Timestamp(),
                EncryptionKeyAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                VpcAccess = new VpcAccess(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TasksClient client = new TasksClientImpl(mockGrpcClient.Object, null, null);
            Task response = client.GetTask(request.TaskName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTaskResourceNamesAsync()
        {
            moq::Mock<Tasks.TasksClient> mockGrpcClient = new moq::Mock<Tasks.TasksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationJobExecutionTask("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationJobExecutionTask("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]", "[TASK]"),
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
                JobAsJobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
                Containers = { new Container(), },
                Volumes = { new Volume(), },
                MaxRetries = -2066036349,
                Timeout = new wkt::Duration(),
                ServiceAccount = "service_accounta3c1b923",
                ExecutionEnvironment = ExecutionEnvironment.Unspecified,
                Reconciling = false,
                Conditions = { new Condition(), },
                ObservedGeneration = -4521268473882310455L,
                Index = 1429051754,
                Retried = 508292519,
                LastAttemptResult = new TaskAttemptResult(),
                StartTime = new wkt::Timestamp(),
                EncryptionKeyAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                VpcAccess = new VpcAccess(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TasksClient client = new TasksClientImpl(mockGrpcClient.Object, null, null);
            Task responseCallSettings = await client.GetTaskAsync(request.TaskName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.GetTaskAsync(request.TaskName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
