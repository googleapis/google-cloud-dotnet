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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Tasks.V2Beta3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCloudTasksClientTest
    {
        [xunit::FactAttribute]
        public void GetQueueRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                ReadMask = new wkt::FieldMask(),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.GetQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue response = client.GetQueue(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetQueueRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                ReadMask = new wkt::FieldMask(),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.GetQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue responseCallSettings = await client.GetQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.GetQueueAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetQueue()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.GetQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue response = client.GetQueue(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetQueueAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.GetQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue responseCallSettings = await client.GetQueueAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.GetQueueAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetQueueResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.GetQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue response = client.GetQueue(request.QueueName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetQueueResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.GetQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue responseCallSettings = await client.GetQueueAsync(request.QueueName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.GetQueueAsync(request.QueueName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateQueueRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queue = new Queue(),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.CreateQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue response = client.CreateQueue(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateQueueRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queue = new Queue(),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.CreateQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue responseCallSettings = await client.CreateQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.CreateQueueAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateQueue()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queue = new Queue(),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.CreateQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue response = client.CreateQueue(request.Parent, request.Queue);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateQueueAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queue = new Queue(),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.CreateQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue responseCallSettings = await client.CreateQueueAsync(request.Parent, request.Queue, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.CreateQueueAsync(request.Parent, request.Queue, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateQueueResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queue = new Queue(),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.CreateQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue response = client.CreateQueue(request.ParentAsLocationName, request.Queue);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateQueueResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queue = new Queue(),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.CreateQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue responseCallSettings = await client.CreateQueueAsync(request.ParentAsLocationName, request.Queue, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.CreateQueueAsync(request.ParentAsLocationName, request.Queue, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateQueueRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            UpdateQueueRequest request = new UpdateQueueRequest
            {
                Queue = new Queue(),
                UpdateMask = new wkt::FieldMask(),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.UpdateQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue response = client.UpdateQueue(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateQueueRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            UpdateQueueRequest request = new UpdateQueueRequest
            {
                Queue = new Queue(),
                UpdateMask = new wkt::FieldMask(),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.UpdateQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue responseCallSettings = await client.UpdateQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.UpdateQueueAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateQueue()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            UpdateQueueRequest request = new UpdateQueueRequest
            {
                Queue = new Queue(),
                UpdateMask = new wkt::FieldMask(),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.UpdateQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue response = client.UpdateQueue(request.Queue, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateQueueAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            UpdateQueueRequest request = new UpdateQueueRequest
            {
                Queue = new Queue(),
                UpdateMask = new wkt::FieldMask(),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.UpdateQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue responseCallSettings = await client.UpdateQueueAsync(request.Queue, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.UpdateQueueAsync(request.Queue, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteQueueRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteQueue(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteQueueRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteQueueAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteQueue()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteQueue(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteQueueAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteQueueAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteQueueAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteQueueResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteQueue(request.QueueName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteQueueResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteQueueAsync(request.QueueName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteQueueAsync(request.QueueName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PurgeQueueRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.PurgeQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue response = client.PurgeQueue(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PurgeQueueRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.PurgeQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue responseCallSettings = await client.PurgeQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.PurgeQueueAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PurgeQueue()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.PurgeQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue response = client.PurgeQueue(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PurgeQueueAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.PurgeQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue responseCallSettings = await client.PurgeQueueAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.PurgeQueueAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PurgeQueueResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.PurgeQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue response = client.PurgeQueue(request.QueueName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PurgeQueueResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.PurgeQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue responseCallSettings = await client.PurgeQueueAsync(request.QueueName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.PurgeQueueAsync(request.QueueName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PauseQueueRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.PauseQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue response = client.PauseQueue(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PauseQueueRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.PauseQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue responseCallSettings = await client.PauseQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.PauseQueueAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PauseQueue()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.PauseQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue response = client.PauseQueue(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PauseQueueAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.PauseQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue responseCallSettings = await client.PauseQueueAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.PauseQueueAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PauseQueueResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.PauseQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue response = client.PauseQueue(request.QueueName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PauseQueueResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.PauseQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue responseCallSettings = await client.PauseQueueAsync(request.QueueName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.PauseQueueAsync(request.QueueName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumeQueueRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.ResumeQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue response = client.ResumeQueue(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumeQueueRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.ResumeQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue responseCallSettings = await client.ResumeQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.ResumeQueueAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumeQueue()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.ResumeQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue response = client.ResumeQueue(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumeQueueAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.ResumeQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue responseCallSettings = await client.ResumeQueueAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.ResumeQueueAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumeQueueResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.ResumeQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue response = client.ResumeQueue(request.QueueName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumeQueueResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue(),
                RateLimits = new RateLimits(),
                RetryConfig = new RetryConfig(),
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp(),
                TaskTtl = new wkt::Duration(),
                TombstoneTtl = new wkt::Duration(),
                StackdriverLoggingConfig = new StackdriverLoggingConfig(),
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats(),
            };
            mockGrpcClient.Setup(x => x.ResumeQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Queue responseCallSettings = await client.ResumeQueueAsync(request.QueueName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.ResumeQueueAsync(request.QueueName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.GetIamPolicy(request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.GetIamPolicy(request.ResourceAsResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.ResourceAsResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.ResourceAsResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.SetIamPolicy(request.Resource, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.Resource, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Resource, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.SetIamPolicy(request.ResourceAsResourceName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.Resource, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.ResourceAsResourceName, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTaskRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = Task.Types.View.Basic,
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest(),
                ScheduleTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt(),
                LastAttempt = new Attempt(),
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest(),
                DispatchDeadline = new wkt::Duration(),
                PullMessage = new PullMessage(),
            };
            mockGrpcClient.Setup(x => x.GetTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Task response = client.GetTask(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTaskRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = Task.Types.View.Basic,
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest(),
                ScheduleTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt(),
                LastAttempt = new Attempt(),
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest(),
                DispatchDeadline = new wkt::Duration(),
                PullMessage = new PullMessage(),
            };
            mockGrpcClient.Setup(x => x.GetTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Task responseCallSettings = await client.GetTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.GetTaskAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTask()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest(),
                ScheduleTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt(),
                LastAttempt = new Attempt(),
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest(),
                DispatchDeadline = new wkt::Duration(),
                PullMessage = new PullMessage(),
            };
            mockGrpcClient.Setup(x => x.GetTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Task response = client.GetTask(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTaskAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest(),
                ScheduleTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt(),
                LastAttempt = new Attempt(),
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest(),
                DispatchDeadline = new wkt::Duration(),
                PullMessage = new PullMessage(),
            };
            mockGrpcClient.Setup(x => x.GetTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Task responseCallSettings = await client.GetTaskAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.GetTaskAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTaskResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest(),
                ScheduleTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt(),
                LastAttempt = new Attempt(),
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest(),
                DispatchDeadline = new wkt::Duration(),
                PullMessage = new PullMessage(),
            };
            mockGrpcClient.Setup(x => x.GetTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Task response = client.GetTask(request.TaskName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTaskResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest(),
                ScheduleTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt(),
                LastAttempt = new Attempt(),
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest(),
                DispatchDeadline = new wkt::Duration(),
                PullMessage = new PullMessage(),
            };
            mockGrpcClient.Setup(x => x.GetTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Task responseCallSettings = await client.GetTaskAsync(request.TaskName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.GetTaskAsync(request.TaskName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTaskRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new Task(),
                ResponseView = Task.Types.View.Basic,
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest(),
                ScheduleTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt(),
                LastAttempt = new Attempt(),
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest(),
                DispatchDeadline = new wkt::Duration(),
                PullMessage = new PullMessage(),
            };
            mockGrpcClient.Setup(x => x.CreateTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Task response = client.CreateTask(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTaskRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new Task(),
                ResponseView = Task.Types.View.Basic,
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest(),
                ScheduleTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt(),
                LastAttempt = new Attempt(),
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest(),
                DispatchDeadline = new wkt::Duration(),
                PullMessage = new PullMessage(),
            };
            mockGrpcClient.Setup(x => x.CreateTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Task responseCallSettings = await client.CreateTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.CreateTaskAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTask()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new Task(),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest(),
                ScheduleTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt(),
                LastAttempt = new Attempt(),
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest(),
                DispatchDeadline = new wkt::Duration(),
                PullMessage = new PullMessage(),
            };
            mockGrpcClient.Setup(x => x.CreateTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Task response = client.CreateTask(request.Parent, request.Task);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTaskAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new Task(),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest(),
                ScheduleTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt(),
                LastAttempt = new Attempt(),
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest(),
                DispatchDeadline = new wkt::Duration(),
                PullMessage = new PullMessage(),
            };
            mockGrpcClient.Setup(x => x.CreateTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Task responseCallSettings = await client.CreateTaskAsync(request.Parent, request.Task, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.CreateTaskAsync(request.Parent, request.Task, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTaskResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new Task(),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest(),
                ScheduleTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt(),
                LastAttempt = new Attempt(),
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest(),
                DispatchDeadline = new wkt::Duration(),
                PullMessage = new PullMessage(),
            };
            mockGrpcClient.Setup(x => x.CreateTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Task response = client.CreateTask(request.ParentAsQueueName, request.Task);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTaskResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new Task(),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest(),
                ScheduleTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt(),
                LastAttempt = new Attempt(),
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest(),
                DispatchDeadline = new wkt::Duration(),
                PullMessage = new PullMessage(),
            };
            mockGrpcClient.Setup(x => x.CreateTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Task responseCallSettings = await client.CreateTaskAsync(request.ParentAsQueueName, request.Task, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.CreateTaskAsync(request.ParentAsQueueName, request.Task, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTaskRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteTask(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTaskRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTaskAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTask()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteTask(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTaskAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteTaskAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTaskAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTaskResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteTask(request.TaskName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTaskResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteTaskAsync(request.TaskName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTaskAsync(request.TaskName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RunTaskRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = Task.Types.View.Basic,
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest(),
                ScheduleTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt(),
                LastAttempt = new Attempt(),
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest(),
                DispatchDeadline = new wkt::Duration(),
                PullMessage = new PullMessage(),
            };
            mockGrpcClient.Setup(x => x.RunTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Task response = client.RunTask(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RunTaskRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = Task.Types.View.Basic,
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest(),
                ScheduleTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt(),
                LastAttempt = new Attempt(),
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest(),
                DispatchDeadline = new wkt::Duration(),
                PullMessage = new PullMessage(),
            };
            mockGrpcClient.Setup(x => x.RunTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Task responseCallSettings = await client.RunTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.RunTaskAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RunTask()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest(),
                ScheduleTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt(),
                LastAttempt = new Attempt(),
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest(),
                DispatchDeadline = new wkt::Duration(),
                PullMessage = new PullMessage(),
            };
            mockGrpcClient.Setup(x => x.RunTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Task response = client.RunTask(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RunTaskAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest(),
                ScheduleTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt(),
                LastAttempt = new Attempt(),
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest(),
                DispatchDeadline = new wkt::Duration(),
                PullMessage = new PullMessage(),
            };
            mockGrpcClient.Setup(x => x.RunTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Task responseCallSettings = await client.RunTaskAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.RunTaskAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RunTaskResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest(),
                ScheduleTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt(),
                LastAttempt = new Attempt(),
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest(),
                DispatchDeadline = new wkt::Duration(),
                PullMessage = new PullMessage(),
            };
            mockGrpcClient.Setup(x => x.RunTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Task response = client.RunTask(request.TaskName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RunTaskResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest(),
                ScheduleTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt(),
                LastAttempt = new Attempt(),
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest(),
                DispatchDeadline = new wkt::Duration(),
                PullMessage = new PullMessage(),
            };
            mockGrpcClient.Setup(x => x.RunTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null, null);
            Task responseCallSettings = await client.RunTaskAsync(request.TaskName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.RunTaskAsync(request.TaskName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
