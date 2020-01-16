// Copyright 2020 Google LLC
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

namespace Google.Cloud.PubSub.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Iam.V1;
    using apis = Google.Cloud.PubSub.V1;
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
    public class GeneratedPublisherServiceApiClientTest
    {
        [Fact]
        public void CreateTopic()
        {
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            Topic expectedRequest = new Topic
            {
                TopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = new TopicName("[PROJECT]", "[TOPIC]"),
                KmsKeyName = "kmsKeyName2094986649",
            };
            mockGrpcClient.Setup(x => x.CreateTopic(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            TopicName name = new TopicName("[PROJECT]", "[TOPIC]");
            Topic response = client.CreateTopic(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateTopicAsync()
        {
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            Topic expectedRequest = new Topic
            {
                TopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = new TopicName("[PROJECT]", "[TOPIC]"),
                KmsKeyName = "kmsKeyName2094986649",
            };
            mockGrpcClient.Setup(x => x.CreateTopicAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Topic>(Task.FromResult(expectedResponse), null, null, null, null));
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            TopicName name = new TopicName("[PROJECT]", "[TOPIC]");
            Topic response = await client.CreateTopicAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateTopic2()
        {
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            Topic request = new Topic
            {
                TopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = new TopicName("[PROJECT]", "[TOPIC]"),
                KmsKeyName = "kmsKeyName2094986649",
            };
            mockGrpcClient.Setup(x => x.CreateTopic(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            Topic response = client.CreateTopic(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateTopicAsync2()
        {
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            Topic request = new Topic
            {
                TopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = new TopicName("[PROJECT]", "[TOPIC]"),
                KmsKeyName = "kmsKeyName2094986649",
            };
            mockGrpcClient.Setup(x => x.CreateTopicAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Topic>(Task.FromResult(expectedResponse), null, null, null, null));
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            Topic response = await client.CreateTopicAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateTopic()
        {
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            UpdateTopicRequest request = new UpdateTopicRequest
            {
                Topic = new Topic(),
                UpdateMask = new FieldMask(),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = new TopicName("[PROJECT]", "[TOPIC]"),
                KmsKeyName = "kmsKeyName2094986649",
            };
            mockGrpcClient.Setup(x => x.UpdateTopic(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            Topic response = client.UpdateTopic(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateTopicAsync()
        {
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            UpdateTopicRequest request = new UpdateTopicRequest
            {
                Topic = new Topic(),
                UpdateMask = new FieldMask(),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = new TopicName("[PROJECT]", "[TOPIC]"),
                KmsKeyName = "kmsKeyName2094986649",
            };
            mockGrpcClient.Setup(x => x.UpdateTopicAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Topic>(Task.FromResult(expectedResponse), null, null, null, null));
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            Topic response = await client.UpdateTopicAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Publish()
        {
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            PublishRequest expectedRequest = new PublishRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
                Messages =
                {
                    new PubsubMessage
                    {
                        Data = ByteString.CopyFromUtf8("-86"),
                    },
                },
            };
            PublishResponse expectedResponse = new PublishResponse
            {
                MessageIds =
                {
                    "messageIdsElement-744837059",
                },
            };
            mockGrpcClient.Setup(x => x.Publish(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            IEnumerable<PubsubMessage> messages = new[]
            {
                new PubsubMessage
                {
                    Data = ByteString.CopyFromUtf8("-86"),
                },
            };
            PublishResponse response = client.Publish(topic, messages);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task PublishAsync()
        {
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            PublishRequest expectedRequest = new PublishRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
                Messages =
                {
                    new PubsubMessage
                    {
                        Data = ByteString.CopyFromUtf8("-86"),
                    },
                },
            };
            PublishResponse expectedResponse = new PublishResponse
            {
                MessageIds =
                {
                    "messageIdsElement-744837059",
                },
            };
            mockGrpcClient.Setup(x => x.PublishAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<PublishResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            IEnumerable<PubsubMessage> messages = new[]
            {
                new PubsubMessage
                {
                    Data = ByteString.CopyFromUtf8("-86"),
                },
            };
            PublishResponse response = await client.PublishAsync(topic, messages);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Publish2()
        {
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            PublishRequest request = new PublishRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
                Messages =
                {
                    new PubsubMessage
                    {
                        Data = ByteString.CopyFromUtf8("-86"),
                    },
                },
            };
            PublishResponse expectedResponse = new PublishResponse
            {
                MessageIds =
                {
                    "messageIdsElement-744837059",
                },
            };
            mockGrpcClient.Setup(x => x.Publish(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            PublishResponse response = client.Publish(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task PublishAsync2()
        {
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            PublishRequest request = new PublishRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
                Messages =
                {
                    new PubsubMessage
                    {
                        Data = ByteString.CopyFromUtf8("-86"),
                    },
                },
            };
            PublishResponse expectedResponse = new PublishResponse
            {
                MessageIds =
                {
                    "messageIdsElement-744837059",
                },
            };
            mockGrpcClient.Setup(x => x.PublishAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<PublishResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            PublishResponse response = await client.PublishAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTopic()
        {
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetTopicRequest expectedRequest = new GetTopicRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = new TopicName("[PROJECT]", "[TOPIC]"),
                KmsKeyName = "kmsKeyName2094986649",
            };
            mockGrpcClient.Setup(x => x.GetTopic(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            Topic response = client.GetTopic(topic);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetTopicAsync()
        {
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetTopicRequest expectedRequest = new GetTopicRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = new TopicName("[PROJECT]", "[TOPIC]"),
                KmsKeyName = "kmsKeyName2094986649",
            };
            mockGrpcClient.Setup(x => x.GetTopicAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Topic>(Task.FromResult(expectedResponse), null, null, null, null));
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            Topic response = await client.GetTopicAsync(topic);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTopic2()
        {
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetTopicRequest request = new GetTopicRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = new TopicName("[PROJECT]", "[TOPIC]"),
                KmsKeyName = "kmsKeyName2094986649",
            };
            mockGrpcClient.Setup(x => x.GetTopic(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            Topic response = client.GetTopic(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetTopicAsync2()
        {
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetTopicRequest request = new GetTopicRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = new TopicName("[PROJECT]", "[TOPIC]"),
                KmsKeyName = "kmsKeyName2094986649",
            };
            mockGrpcClient.Setup(x => x.GetTopicAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Topic>(Task.FromResult(expectedResponse), null, null, null, null));
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            Topic response = await client.GetTopicAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTopic()
        {
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DeleteTopicRequest expectedRequest = new DeleteTopicRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTopic(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            client.DeleteTopic(topic);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteTopicAsync()
        {
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DeleteTopicRequest expectedRequest = new DeleteTopicRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTopicAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            await client.DeleteTopicAsync(topic);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTopic2()
        {
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTopic(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            client.DeleteTopic(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteTopicAsync2()
        {
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTopicAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTopicAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
