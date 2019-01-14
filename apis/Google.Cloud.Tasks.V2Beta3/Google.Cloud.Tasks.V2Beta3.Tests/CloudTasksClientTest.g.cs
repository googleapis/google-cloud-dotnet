// Copyright 2019 Google LLC
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

namespace Google.Cloud.Tasks.V2Beta3.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Iam.V1;
    using apis = Google.Cloud.Tasks.V2Beta3;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Generated unit tests</summary>
    public class GeneratedCloudTasksClientTest
    {
        [Fact]
        public void GetQueue()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            GetQueueRequest expectedRequest = new GetQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.GetQueue(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            apis::Queue response = client.GetQueue(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetQueueAsync()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            GetQueueRequest expectedRequest = new GetQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.GetQueueAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Queue>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            apis::Queue response = await client.GetQueueAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetQueue2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.GetQueue(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Queue response = client.GetQueue(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetQueueAsync2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.GetQueueAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Queue>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Queue response = await client.GetQueueAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateQueue()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            CreateQueueRequest expectedRequest = new CreateQueueRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Queue = new apis::Queue(),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.CreateQueue(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            apis::Queue queue = new apis::Queue();
            apis::Queue response = client.CreateQueue(parent, queue);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateQueueAsync()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            CreateQueueRequest expectedRequest = new CreateQueueRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Queue = new apis::Queue(),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.CreateQueueAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Queue>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            apis::Queue queue = new apis::Queue();
            apis::Queue response = await client.CreateQueueAsync(parent, queue);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateQueue2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Queue = new apis::Queue(),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.CreateQueue(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Queue response = client.CreateQueue(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateQueueAsync2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Queue = new apis::Queue(),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.CreateQueueAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Queue>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Queue response = await client.CreateQueueAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateQueue()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            UpdateQueueRequest expectedRequest = new UpdateQueueRequest
            {
                Queue = new apis::Queue(),
                UpdateMask = new FieldMask(),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.UpdateQueue(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Queue queue = new apis::Queue();
            FieldMask updateMask = new FieldMask();
            apis::Queue response = client.UpdateQueue(queue, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateQueueAsync()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            UpdateQueueRequest expectedRequest = new UpdateQueueRequest
            {
                Queue = new apis::Queue(),
                UpdateMask = new FieldMask(),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.UpdateQueueAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Queue>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Queue queue = new apis::Queue();
            FieldMask updateMask = new FieldMask();
            apis::Queue response = await client.UpdateQueueAsync(queue, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateQueue2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            UpdateQueueRequest request = new UpdateQueueRequest
            {
                Queue = new apis::Queue(),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.UpdateQueue(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Queue response = client.UpdateQueue(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateQueueAsync2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            UpdateQueueRequest request = new UpdateQueueRequest
            {
                Queue = new apis::Queue(),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.UpdateQueueAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Queue>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Queue response = await client.UpdateQueueAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteQueue()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            DeleteQueueRequest expectedRequest = new DeleteQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteQueue(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            client.DeleteQueue(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteQueueAsync()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            DeleteQueueRequest expectedRequest = new DeleteQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteQueueAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            await client.DeleteQueueAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteQueue2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteQueue(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            client.DeleteQueue(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteQueueAsync2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteQueueAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            await client.DeleteQueueAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void PurgeQueue()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            PurgeQueueRequest expectedRequest = new PurgeQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.PurgeQueue(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            apis::Queue response = client.PurgeQueue(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task PurgeQueueAsync()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            PurgeQueueRequest expectedRequest = new PurgeQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.PurgeQueueAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Queue>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            apis::Queue response = await client.PurgeQueueAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void PurgeQueue2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.PurgeQueue(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Queue response = client.PurgeQueue(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task PurgeQueueAsync2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.PurgeQueueAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Queue>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Queue response = await client.PurgeQueueAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void PauseQueue()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            PauseQueueRequest expectedRequest = new PauseQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.PauseQueue(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            apis::Queue response = client.PauseQueue(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task PauseQueueAsync()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            PauseQueueRequest expectedRequest = new PauseQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.PauseQueueAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Queue>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            apis::Queue response = await client.PauseQueueAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void PauseQueue2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.PauseQueue(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Queue response = client.PauseQueue(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task PauseQueueAsync2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.PauseQueueAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Queue>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Queue response = await client.PauseQueueAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ResumeQueue()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            ResumeQueueRequest expectedRequest = new ResumeQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.ResumeQueue(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            apis::Queue response = client.ResumeQueue(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ResumeQueueAsync()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            ResumeQueueRequest expectedRequest = new ResumeQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.ResumeQueueAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Queue>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            apis::Queue response = await client.ResumeQueueAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ResumeQueue2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.ResumeQueue(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Queue response = client.ResumeQueue(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ResumeQueueAsync2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            apis::Queue expectedResponse = new apis::Queue
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            mockGrpcClient.Setup(x => x.ResumeQueueAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Queue>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Queue response = await client.ResumeQueueAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIamPolicy()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            GetIamPolicyRequest expectedRequest = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            QueueName resource = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            Policy response = client.GetIamPolicy(resource);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIamPolicyAsync()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            GetIamPolicyRequest expectedRequest = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            QueueName resource = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            Policy response = await client.GetIamPolicyAsync(resource);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIamPolicy2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIamPolicyAsync2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Policy response = await client.GetIamPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetIamPolicy()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            SetIamPolicyRequest expectedRequest = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            QueueName resource = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            Policy policy = new Policy();
            Policy response = client.SetIamPolicy(resource, policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetIamPolicyAsync()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            SetIamPolicyRequest expectedRequest = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            QueueName resource = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            Policy policy = new Policy();
            Policy response = await client.SetIamPolicyAsync(resource, policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetIamPolicy2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetIamPolicyAsync2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Policy response = await client.SetIamPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissions()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            TestIamPermissionsRequest expectedRequest = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissions(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            QueueName resource = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = client.TestIamPermissions(resource, permissions);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task TestIamPermissionsAsync()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            TestIamPermissionsRequest expectedRequest = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TestIamPermissionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            QueueName resource = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = await client.TestIamPermissionsAsync(resource, permissions);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissions2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            TestIamPermissionsResponse response = client.TestIamPermissions(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task TestIamPermissionsAsync2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TestIamPermissionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            TestIamPermissionsResponse response = await client.TestIamPermissionsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTask()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            GetTaskRequest expectedRequest = new GetTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            apis::Task expectedResponse = new apis::Task
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                DispatchCount = 1217252086,
                ResponseCount = 424727441,
            };
            mockGrpcClient.Setup(x => x.GetTask(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            apis::Task response = client.GetTask(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetTaskAsync()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            GetTaskRequest expectedRequest = new GetTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            apis::Task expectedResponse = new apis::Task
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                DispatchCount = 1217252086,
                ResponseCount = 424727441,
            };
            mockGrpcClient.Setup(x => x.GetTaskAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Task>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            apis::Task response = await client.GetTaskAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTask2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            apis::Task expectedResponse = new apis::Task
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                DispatchCount = 1217252086,
                ResponseCount = 424727441,
            };
            mockGrpcClient.Setup(x => x.GetTask(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Task response = client.GetTask(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetTaskAsync2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            apis::Task expectedResponse = new apis::Task
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                DispatchCount = 1217252086,
                ResponseCount = 424727441,
            };
            mockGrpcClient.Setup(x => x.GetTaskAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Task>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Task response = await client.GetTaskAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateTask()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            CreateTaskRequest expectedRequest = new CreateTaskRequest
            {
                ParentAsQueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new apis::Task(),
            };
            apis::Task expectedResponse = new apis::Task
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                DispatchCount = 1217252086,
                ResponseCount = 424727441,
            };
            mockGrpcClient.Setup(x => x.CreateTask(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            QueueName parent = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            apis::Task task = new apis::Task();
            apis::Task response = client.CreateTask(parent, task);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateTaskAsync()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            CreateTaskRequest expectedRequest = new CreateTaskRequest
            {
                ParentAsQueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new apis::Task(),
            };
            apis::Task expectedResponse = new apis::Task
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                DispatchCount = 1217252086,
                ResponseCount = 424727441,
            };
            mockGrpcClient.Setup(x => x.CreateTaskAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Task>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            QueueName parent = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            apis::Task task = new apis::Task();
            apis::Task response = await client.CreateTaskAsync(parent, task);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateTask2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new apis::Task(),
            };
            apis::Task expectedResponse = new apis::Task
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                DispatchCount = 1217252086,
                ResponseCount = 424727441,
            };
            mockGrpcClient.Setup(x => x.CreateTask(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Task response = client.CreateTask(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateTaskAsync2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new apis::Task(),
            };
            apis::Task expectedResponse = new apis::Task
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                DispatchCount = 1217252086,
                ResponseCount = 424727441,
            };
            mockGrpcClient.Setup(x => x.CreateTaskAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Task>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Task response = await client.CreateTaskAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTask()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            DeleteTaskRequest expectedRequest = new DeleteTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTask(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            client.DeleteTask(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteTaskAsync()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            DeleteTaskRequest expectedRequest = new DeleteTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTaskAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            await client.DeleteTaskAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTask2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTask(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            client.DeleteTask(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteTaskAsync2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTaskAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTaskAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RunTask()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            RunTaskRequest expectedRequest = new RunTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            apis::Task expectedResponse = new apis::Task
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                DispatchCount = 1217252086,
                ResponseCount = 424727441,
            };
            mockGrpcClient.Setup(x => x.RunTask(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            apis::Task response = client.RunTask(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RunTaskAsync()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            RunTaskRequest expectedRequest = new RunTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            apis::Task expectedResponse = new apis::Task
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                DispatchCount = 1217252086,
                ResponseCount = 424727441,
            };
            mockGrpcClient.Setup(x => x.RunTaskAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Task>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            apis::Task response = await client.RunTaskAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RunTask2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            apis::Task expectedResponse = new apis::Task
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                DispatchCount = 1217252086,
                ResponseCount = 424727441,
            };
            mockGrpcClient.Setup(x => x.RunTask(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Task response = client.RunTask(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RunTaskAsync2()
        {
            Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new Mock<CloudTasks.CloudTasksClient>(MockBehavior.Strict);
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            apis::Task expectedResponse = new apis::Task
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                DispatchCount = 1217252086,
                ResponseCount = 424727441,
            };
            mockGrpcClient.Setup(x => x.RunTaskAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Task>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            apis::Task response = await client.RunTaskAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
