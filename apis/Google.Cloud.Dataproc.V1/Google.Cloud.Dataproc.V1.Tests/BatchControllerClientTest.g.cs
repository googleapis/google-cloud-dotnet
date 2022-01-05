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
    public sealed class GeneratedBatchControllerClientTest
    {
        [xunit::FactAttribute]
        public void GetBatchRequestObject()
        {
            moq::Mock<BatchController.BatchControllerClient> mockGrpcClient = new moq::Mock<BatchController.BatchControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBatchRequest request = new GetBatchRequest
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
            };
            Batch expectedResponse = new Batch
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
                Uuid = "uuid6f877cef",
                CreateTime = new wkt::Timestamp(),
                PysparkBatch = new PySparkBatch(),
                SparkBatch = new SparkBatch(),
                SparkRBatch = new SparkRBatch(),
                SparkSqlBatch = new SparkSqlBatch(),
                RuntimeInfo = new RuntimeInfo(),
                State = Batch.Types.State.Failed,
                StateMessage = "state_message46cf28c0",
                StateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RuntimeConfig = new RuntimeConfig(),
                EnvironmentConfig = new EnvironmentConfig(),
                Operation = "operation615a23f7",
                StateHistory =
                {
                    new Batch.Types.StateHistory(),
                },
            };
            mockGrpcClient.Setup(x => x.GetBatch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchControllerClient client = new BatchControllerClientImpl(mockGrpcClient.Object, null);
            Batch response = client.GetBatch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBatchRequestObjectAsync()
        {
            moq::Mock<BatchController.BatchControllerClient> mockGrpcClient = new moq::Mock<BatchController.BatchControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBatchRequest request = new GetBatchRequest
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
            };
            Batch expectedResponse = new Batch
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
                Uuid = "uuid6f877cef",
                CreateTime = new wkt::Timestamp(),
                PysparkBatch = new PySparkBatch(),
                SparkBatch = new SparkBatch(),
                SparkRBatch = new SparkRBatch(),
                SparkSqlBatch = new SparkSqlBatch(),
                RuntimeInfo = new RuntimeInfo(),
                State = Batch.Types.State.Failed,
                StateMessage = "state_message46cf28c0",
                StateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RuntimeConfig = new RuntimeConfig(),
                EnvironmentConfig = new EnvironmentConfig(),
                Operation = "operation615a23f7",
                StateHistory =
                {
                    new Batch.Types.StateHistory(),
                },
            };
            mockGrpcClient.Setup(x => x.GetBatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Batch>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchControllerClient client = new BatchControllerClientImpl(mockGrpcClient.Object, null);
            Batch responseCallSettings = await client.GetBatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Batch responseCancellationToken = await client.GetBatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBatch()
        {
            moq::Mock<BatchController.BatchControllerClient> mockGrpcClient = new moq::Mock<BatchController.BatchControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBatchRequest request = new GetBatchRequest
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
            };
            Batch expectedResponse = new Batch
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
                Uuid = "uuid6f877cef",
                CreateTime = new wkt::Timestamp(),
                PysparkBatch = new PySparkBatch(),
                SparkBatch = new SparkBatch(),
                SparkRBatch = new SparkRBatch(),
                SparkSqlBatch = new SparkSqlBatch(),
                RuntimeInfo = new RuntimeInfo(),
                State = Batch.Types.State.Failed,
                StateMessage = "state_message46cf28c0",
                StateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RuntimeConfig = new RuntimeConfig(),
                EnvironmentConfig = new EnvironmentConfig(),
                Operation = "operation615a23f7",
                StateHistory =
                {
                    new Batch.Types.StateHistory(),
                },
            };
            mockGrpcClient.Setup(x => x.GetBatch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchControllerClient client = new BatchControllerClientImpl(mockGrpcClient.Object, null);
            Batch response = client.GetBatch(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBatchAsync()
        {
            moq::Mock<BatchController.BatchControllerClient> mockGrpcClient = new moq::Mock<BatchController.BatchControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBatchRequest request = new GetBatchRequest
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
            };
            Batch expectedResponse = new Batch
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
                Uuid = "uuid6f877cef",
                CreateTime = new wkt::Timestamp(),
                PysparkBatch = new PySparkBatch(),
                SparkBatch = new SparkBatch(),
                SparkRBatch = new SparkRBatch(),
                SparkSqlBatch = new SparkSqlBatch(),
                RuntimeInfo = new RuntimeInfo(),
                State = Batch.Types.State.Failed,
                StateMessage = "state_message46cf28c0",
                StateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RuntimeConfig = new RuntimeConfig(),
                EnvironmentConfig = new EnvironmentConfig(),
                Operation = "operation615a23f7",
                StateHistory =
                {
                    new Batch.Types.StateHistory(),
                },
            };
            mockGrpcClient.Setup(x => x.GetBatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Batch>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchControllerClient client = new BatchControllerClientImpl(mockGrpcClient.Object, null);
            Batch responseCallSettings = await client.GetBatchAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Batch responseCancellationToken = await client.GetBatchAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBatchResourceNames()
        {
            moq::Mock<BatchController.BatchControllerClient> mockGrpcClient = new moq::Mock<BatchController.BatchControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBatchRequest request = new GetBatchRequest
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
            };
            Batch expectedResponse = new Batch
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
                Uuid = "uuid6f877cef",
                CreateTime = new wkt::Timestamp(),
                PysparkBatch = new PySparkBatch(),
                SparkBatch = new SparkBatch(),
                SparkRBatch = new SparkRBatch(),
                SparkSqlBatch = new SparkSqlBatch(),
                RuntimeInfo = new RuntimeInfo(),
                State = Batch.Types.State.Failed,
                StateMessage = "state_message46cf28c0",
                StateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RuntimeConfig = new RuntimeConfig(),
                EnvironmentConfig = new EnvironmentConfig(),
                Operation = "operation615a23f7",
                StateHistory =
                {
                    new Batch.Types.StateHistory(),
                },
            };
            mockGrpcClient.Setup(x => x.GetBatch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchControllerClient client = new BatchControllerClientImpl(mockGrpcClient.Object, null);
            Batch response = client.GetBatch(request.BatchName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBatchResourceNamesAsync()
        {
            moq::Mock<BatchController.BatchControllerClient> mockGrpcClient = new moq::Mock<BatchController.BatchControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBatchRequest request = new GetBatchRequest
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
            };
            Batch expectedResponse = new Batch
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
                Uuid = "uuid6f877cef",
                CreateTime = new wkt::Timestamp(),
                PysparkBatch = new PySparkBatch(),
                SparkBatch = new SparkBatch(),
                SparkRBatch = new SparkRBatch(),
                SparkSqlBatch = new SparkSqlBatch(),
                RuntimeInfo = new RuntimeInfo(),
                State = Batch.Types.State.Failed,
                StateMessage = "state_message46cf28c0",
                StateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RuntimeConfig = new RuntimeConfig(),
                EnvironmentConfig = new EnvironmentConfig(),
                Operation = "operation615a23f7",
                StateHistory =
                {
                    new Batch.Types.StateHistory(),
                },
            };
            mockGrpcClient.Setup(x => x.GetBatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Batch>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchControllerClient client = new BatchControllerClientImpl(mockGrpcClient.Object, null);
            Batch responseCallSettings = await client.GetBatchAsync(request.BatchName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Batch responseCancellationToken = await client.GetBatchAsync(request.BatchName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteBatchRequestObject()
        {
            moq::Mock<BatchController.BatchControllerClient> mockGrpcClient = new moq::Mock<BatchController.BatchControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBatchRequest request = new DeleteBatchRequest
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBatch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchControllerClient client = new BatchControllerClientImpl(mockGrpcClient.Object, null);
            client.DeleteBatch(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteBatchRequestObjectAsync()
        {
            moq::Mock<BatchController.BatchControllerClient> mockGrpcClient = new moq::Mock<BatchController.BatchControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBatchRequest request = new DeleteBatchRequest
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchControllerClient client = new BatchControllerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteBatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteBatchAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteBatch()
        {
            moq::Mock<BatchController.BatchControllerClient> mockGrpcClient = new moq::Mock<BatchController.BatchControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBatchRequest request = new DeleteBatchRequest
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBatch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchControllerClient client = new BatchControllerClientImpl(mockGrpcClient.Object, null);
            client.DeleteBatch(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteBatchAsync()
        {
            moq::Mock<BatchController.BatchControllerClient> mockGrpcClient = new moq::Mock<BatchController.BatchControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBatchRequest request = new DeleteBatchRequest
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchControllerClient client = new BatchControllerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteBatchAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteBatchAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteBatchResourceNames()
        {
            moq::Mock<BatchController.BatchControllerClient> mockGrpcClient = new moq::Mock<BatchController.BatchControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBatchRequest request = new DeleteBatchRequest
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBatch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchControllerClient client = new BatchControllerClientImpl(mockGrpcClient.Object, null);
            client.DeleteBatch(request.BatchName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteBatchResourceNamesAsync()
        {
            moq::Mock<BatchController.BatchControllerClient> mockGrpcClient = new moq::Mock<BatchController.BatchControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBatchRequest request = new DeleteBatchRequest
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchControllerClient client = new BatchControllerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteBatchAsync(request.BatchName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteBatchAsync(request.BatchName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
