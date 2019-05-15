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

namespace Google.Cloud.PubSub.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Iam.V1;
    using apis = Google.Cloud.PubSub.V1;
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
    public class GeneratedSubscriberServiceApiClientTest
    {
        [Fact]
        public void CreateSubscription()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            Subscription expectedRequest = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = 2135351438,
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
                AckDeadlineSeconds = 921632575,
                RetainAckedMessages = false,
                EnableMessageOrdering = true,
            };
            mockGrpcClient.Setup(x => x.CreateSubscription(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName name = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            PushConfig pushConfig = new PushConfig();
            int ackDeadlineSeconds = 2135351438;
            Subscription response = client.CreateSubscription(name, topic, pushConfig, ackDeadlineSeconds);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSubscriptionAsync()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            Subscription expectedRequest = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = 2135351438,
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
                AckDeadlineSeconds = 921632575,
                RetainAckedMessages = false,
                EnableMessageOrdering = true,
            };
            mockGrpcClient.Setup(x => x.CreateSubscriptionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Subscription>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName name = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            PushConfig pushConfig = new PushConfig();
            int ackDeadlineSeconds = 2135351438;
            Subscription response = await client.CreateSubscriptionAsync(name, topic, pushConfig, ackDeadlineSeconds);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSubscription2()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            Subscription request = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
                AckDeadlineSeconds = 2135351438,
                RetainAckedMessages = false,
                EnableMessageOrdering = true,
            };
            mockGrpcClient.Setup(x => x.CreateSubscription(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.CreateSubscription(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSubscriptionAsync2()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            Subscription request = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
                AckDeadlineSeconds = 2135351438,
                RetainAckedMessages = false,
                EnableMessageOrdering = true,
            };
            mockGrpcClient.Setup(x => x.CreateSubscriptionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Subscription>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            Subscription response = await client.CreateSubscriptionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSubscription()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetSubscriptionRequest expectedRequest = new GetSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
                AckDeadlineSeconds = 2135351438,
                RetainAckedMessages = false,
                EnableMessageOrdering = true,
            };
            mockGrpcClient.Setup(x => x.GetSubscription(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            Subscription response = client.GetSubscription(subscription);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSubscriptionAsync()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetSubscriptionRequest expectedRequest = new GetSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
                AckDeadlineSeconds = 2135351438,
                RetainAckedMessages = false,
                EnableMessageOrdering = true,
            };
            mockGrpcClient.Setup(x => x.GetSubscriptionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Subscription>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            Subscription response = await client.GetSubscriptionAsync(subscription);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSubscription2()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
                AckDeadlineSeconds = 2135351438,
                RetainAckedMessages = false,
                EnableMessageOrdering = true,
            };
            mockGrpcClient.Setup(x => x.GetSubscription(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.GetSubscription(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSubscriptionAsync2()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
                AckDeadlineSeconds = 2135351438,
                RetainAckedMessages = false,
                EnableMessageOrdering = true,
            };
            mockGrpcClient.Setup(x => x.GetSubscriptionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Subscription>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            Subscription response = await client.GetSubscriptionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSubscription()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription
                {
                    AckDeadlineSeconds = 42,
                },
                UpdateMask = new FieldMask
                {
                    Paths = {
                                "ack_deadline_seconds",
                            },
                },
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
                AckDeadlineSeconds = 921632575,
                RetainAckedMessages = false,
                EnableMessageOrdering = true,
            };
            mockGrpcClient.Setup(x => x.UpdateSubscription(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.UpdateSubscription(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSubscriptionAsync()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription
                {
                    AckDeadlineSeconds = 42,
                },
                UpdateMask = new FieldMask
                {
                    Paths = {
                                "ack_deadline_seconds",
                            },
                },
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
                AckDeadlineSeconds = 921632575,
                RetainAckedMessages = false,
                EnableMessageOrdering = true,
            };
            mockGrpcClient.Setup(x => x.UpdateSubscriptionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Subscription>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            Subscription response = await client.UpdateSubscriptionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSubscription()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DeleteSubscriptionRequest expectedRequest = new DeleteSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSubscription(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            client.DeleteSubscription(subscription);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSubscriptionAsync()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DeleteSubscriptionRequest expectedRequest = new DeleteSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSubscriptionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            await client.DeleteSubscriptionAsync(subscription);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSubscription2()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSubscription(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            client.DeleteSubscription(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSubscriptionAsync2()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSubscriptionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSubscriptionAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ModifyAckDeadline()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            ModifyAckDeadlineRequest expectedRequest = new ModifyAckDeadlineRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { },
                AckDeadlineSeconds = 2135351438,
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.ModifyAckDeadline(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            int ackDeadlineSeconds = 2135351438;
            client.ModifyAckDeadline(subscription, ackIds, ackDeadlineSeconds);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ModifyAckDeadlineAsync()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            ModifyAckDeadlineRequest expectedRequest = new ModifyAckDeadlineRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { },
                AckDeadlineSeconds = 2135351438,
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.ModifyAckDeadlineAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            int ackDeadlineSeconds = 2135351438;
            await client.ModifyAckDeadlineAsync(subscription, ackIds, ackDeadlineSeconds);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ModifyAckDeadline2()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            ModifyAckDeadlineRequest request = new ModifyAckDeadlineRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { },
                AckDeadlineSeconds = 2135351438,
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.ModifyAckDeadline(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            client.ModifyAckDeadline(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ModifyAckDeadlineAsync2()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            ModifyAckDeadlineRequest request = new ModifyAckDeadlineRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { },
                AckDeadlineSeconds = 2135351438,
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.ModifyAckDeadlineAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            await client.ModifyAckDeadlineAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Acknowledge()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            AcknowledgeRequest expectedRequest = new AcknowledgeRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { },
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.Acknowledge(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            client.Acknowledge(subscription, ackIds);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AcknowledgeAsync()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            AcknowledgeRequest expectedRequest = new AcknowledgeRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { },
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.AcknowledgeAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            await client.AcknowledgeAsync(subscription, ackIds);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Acknowledge2()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            AcknowledgeRequest request = new AcknowledgeRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { },
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.Acknowledge(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            client.Acknowledge(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AcknowledgeAsync2()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            AcknowledgeRequest request = new AcknowledgeRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { },
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.AcknowledgeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            await client.AcknowledgeAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Pull()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            PullRequest expectedRequest = new PullRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                ReturnImmediately = false,
                MaxMessages = 496131527,
            };
            PullResponse expectedResponse = new PullResponse();
            mockGrpcClient.Setup(x => x.Pull(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            bool returnImmediately = false;
            int maxMessages = 496131527;
            PullResponse response = client.Pull(subscription, returnImmediately, maxMessages);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task PullAsync()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            PullRequest expectedRequest = new PullRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                ReturnImmediately = false,
                MaxMessages = 496131527,
            };
            PullResponse expectedResponse = new PullResponse();
            mockGrpcClient.Setup(x => x.PullAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<PullResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            bool returnImmediately = false;
            int maxMessages = 496131527;
            PullResponse response = await client.PullAsync(subscription, returnImmediately, maxMessages);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Pull2()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            PullRequest request = new PullRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                MaxMessages = 496131527,
            };
            PullResponse expectedResponse = new PullResponse();
            mockGrpcClient.Setup(x => x.Pull(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            PullResponse response = client.Pull(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task PullAsync2()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            PullRequest request = new PullRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                MaxMessages = 496131527,
            };
            PullResponse expectedResponse = new PullResponse();
            mockGrpcClient.Setup(x => x.PullAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<PullResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            PullResponse response = await client.PullAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ModifyPushConfig()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            ModifyPushConfigRequest expectedRequest = new ModifyPushConfigRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                PushConfig = new PushConfig(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.ModifyPushConfig(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            PushConfig pushConfig = new PushConfig();
            client.ModifyPushConfig(subscription, pushConfig);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ModifyPushConfigAsync()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            ModifyPushConfigRequest expectedRequest = new ModifyPushConfigRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                PushConfig = new PushConfig(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.ModifyPushConfigAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            PushConfig pushConfig = new PushConfig();
            await client.ModifyPushConfigAsync(subscription, pushConfig);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ModifyPushConfig2()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            ModifyPushConfigRequest request = new ModifyPushConfigRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                PushConfig = new PushConfig(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.ModifyPushConfig(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            client.ModifyPushConfig(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ModifyPushConfigAsync2()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            ModifyPushConfigRequest request = new ModifyPushConfigRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                PushConfig = new PushConfig(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.ModifyPushConfigAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            await client.ModifyPushConfigAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSnapshot()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateSnapshotRequest expectedRequest = new CreateSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            mockGrpcClient.Setup(x => x.CreateSnapshot(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SnapshotName name = new SnapshotName("[PROJECT]", "[SNAPSHOT]");
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            Snapshot response = client.CreateSnapshot(name, subscription);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSnapshotAsync()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateSnapshotRequest expectedRequest = new CreateSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            mockGrpcClient.Setup(x => x.CreateSnapshotAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Snapshot>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SnapshotName name = new SnapshotName("[PROJECT]", "[SNAPSHOT]");
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            Snapshot response = await client.CreateSnapshotAsync(name, subscription);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSnapshot2()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateSnapshotRequest request = new CreateSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            mockGrpcClient.Setup(x => x.CreateSnapshot(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            Snapshot response = client.CreateSnapshot(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSnapshotAsync2()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateSnapshotRequest request = new CreateSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            mockGrpcClient.Setup(x => x.CreateSnapshotAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Snapshot>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            Snapshot response = await client.CreateSnapshotAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSnapshot()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            UpdateSnapshotRequest request = new UpdateSnapshotRequest
            {
                Snapshot = new Snapshot
                {
                    ExpireTime = new Timestamp
                                 {
                                     Seconds = 123456L,
                                 },
                },
                UpdateMask = new FieldMask
                {
                    Paths = {
                                "expire_time",
                            },
                },
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSnapshot(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            Snapshot response = client.UpdateSnapshot(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSnapshotAsync()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            UpdateSnapshotRequest request = new UpdateSnapshotRequest
            {
                Snapshot = new Snapshot
                {
                    ExpireTime = new Timestamp
                                 {
                                     Seconds = 123456L,
                                 },
                },
                UpdateMask = new FieldMask
                {
                    Paths = {
                                "expire_time",
                            },
                },
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSnapshotAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Snapshot>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            Snapshot response = await client.UpdateSnapshotAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSnapshot()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DeleteSnapshotRequest expectedRequest = new DeleteSnapshotRequest
            {
                SnapshotAsSnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSnapshot(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SnapshotName snapshot = new SnapshotName("[PROJECT]", "[SNAPSHOT]");
            client.DeleteSnapshot(snapshot);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSnapshotAsync()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DeleteSnapshotRequest expectedRequest = new DeleteSnapshotRequest
            {
                SnapshotAsSnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSnapshotAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SnapshotName snapshot = new SnapshotName("[PROJECT]", "[SNAPSHOT]");
            await client.DeleteSnapshotAsync(snapshot);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSnapshot2()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotAsSnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSnapshot(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            client.DeleteSnapshot(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSnapshotAsync2()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotAsSnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSnapshotAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSnapshotAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Seek()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            SeekRequest request = new SeekRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            SeekResponse expectedResponse = new SeekResponse();
            mockGrpcClient.Setup(x => x.Seek(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SeekResponse response = client.Seek(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SeekAsync()
        {
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            SeekRequest request = new SeekRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            SeekResponse expectedResponse = new SeekResponse();
            mockGrpcClient.Setup(x => x.SeekAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SeekResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SeekResponse response = await client.SeekAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
