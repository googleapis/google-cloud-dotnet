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
using gciv = Google.Cloud.Iam.V1;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.PubSub.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSubscriberClientTest
    {
        [xunit::FactAttribute]
        public void CreateSubscriptionRequestObject()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            Subscription request = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
                RetainAckedMessages = false,
                MessageRetentionDuration = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EnableMessageOrdering = true,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "filtere47ac9b2",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new wkt::Duration(),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
                RetainAckedMessages = false,
                MessageRetentionDuration = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EnableMessageOrdering = true,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "filtere47ac9b2",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.CreateSubscription(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSubscriptionRequestObjectAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            Subscription request = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
                RetainAckedMessages = false,
                MessageRetentionDuration = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EnableMessageOrdering = true,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "filtere47ac9b2",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new wkt::Duration(),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
                RetainAckedMessages = false,
                MessageRetentionDuration = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EnableMessageOrdering = true,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "filtere47ac9b2",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subscription>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Subscription responseCallSettings = await client.CreateSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subscription responseCancellationToken = await client.CreateSubscriptionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSubscription()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            Subscription request = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
                RetainAckedMessages = false,
                MessageRetentionDuration = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EnableMessageOrdering = true,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "filtere47ac9b2",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.CreateSubscription(request.Name, request.Topic, request.PushConfig, request.AckDeadlineSeconds);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSubscriptionAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            Subscription request = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
                RetainAckedMessages = false,
                MessageRetentionDuration = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EnableMessageOrdering = true,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "filtere47ac9b2",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subscription>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Subscription responseCallSettings = await client.CreateSubscriptionAsync(request.Name, request.Topic, request.PushConfig, request.AckDeadlineSeconds, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subscription responseCancellationToken = await client.CreateSubscriptionAsync(request.Name, request.Topic, request.PushConfig, request.AckDeadlineSeconds, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSubscriptionResourceNames()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            Subscription request = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
                RetainAckedMessages = false,
                MessageRetentionDuration = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EnableMessageOrdering = true,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "filtere47ac9b2",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.CreateSubscription(request.SubscriptionName, request.TopicAsTopicName, request.PushConfig, request.AckDeadlineSeconds);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSubscriptionResourceNamesAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            Subscription request = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
                RetainAckedMessages = false,
                MessageRetentionDuration = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EnableMessageOrdering = true,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "filtere47ac9b2",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subscription>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Subscription responseCallSettings = await client.CreateSubscriptionAsync(request.SubscriptionName, request.TopicAsTopicName, request.PushConfig, request.AckDeadlineSeconds, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subscription responseCancellationToken = await client.CreateSubscriptionAsync(request.SubscriptionName, request.TopicAsTopicName, request.PushConfig, request.AckDeadlineSeconds, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSubscriptionRequestObject()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
                RetainAckedMessages = false,
                MessageRetentionDuration = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EnableMessageOrdering = true,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "filtere47ac9b2",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.GetSubscription(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSubscriptionRequestObjectAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
                RetainAckedMessages = false,
                MessageRetentionDuration = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EnableMessageOrdering = true,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "filtere47ac9b2",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subscription>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Subscription responseCallSettings = await client.GetSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subscription responseCancellationToken = await client.GetSubscriptionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSubscription()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
                RetainAckedMessages = false,
                MessageRetentionDuration = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EnableMessageOrdering = true,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "filtere47ac9b2",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.GetSubscription(request.Subscription);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSubscriptionAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
                RetainAckedMessages = false,
                MessageRetentionDuration = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EnableMessageOrdering = true,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "filtere47ac9b2",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subscription>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Subscription responseCallSettings = await client.GetSubscriptionAsync(request.Subscription, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subscription responseCancellationToken = await client.GetSubscriptionAsync(request.Subscription, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSubscriptionResourceNames()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
                RetainAckedMessages = false,
                MessageRetentionDuration = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EnableMessageOrdering = true,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "filtere47ac9b2",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.GetSubscription(request.SubscriptionAsSubscriptionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSubscriptionResourceNamesAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
                RetainAckedMessages = false,
                MessageRetentionDuration = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EnableMessageOrdering = true,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "filtere47ac9b2",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subscription>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Subscription responseCallSettings = await client.GetSubscriptionAsync(request.SubscriptionAsSubscriptionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subscription responseCancellationToken = await client.GetSubscriptionAsync(request.SubscriptionAsSubscriptionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSubscriptionRequestObject()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
                UpdateMask = new wkt::FieldMask(),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
                RetainAckedMessages = false,
                MessageRetentionDuration = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EnableMessageOrdering = true,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "filtere47ac9b2",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.UpdateSubscription(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSubscriptionRequestObjectAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
                UpdateMask = new wkt::FieldMask(),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = -1594362342,
                RetainAckedMessages = false,
                MessageRetentionDuration = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EnableMessageOrdering = true,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "filtere47ac9b2",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subscription>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Subscription responseCallSettings = await client.UpdateSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subscription responseCancellationToken = await client.UpdateSubscriptionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSubscriptionRequestObject()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            client.DeleteSubscription(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSubscriptionRequestObjectAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSubscriptionAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSubscription()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            client.DeleteSubscription(request.Subscription);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSubscriptionAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSubscriptionAsync(request.Subscription, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSubscriptionAsync(request.Subscription, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSubscriptionResourceNames()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            client.DeleteSubscription(request.SubscriptionAsSubscriptionName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSubscriptionResourceNamesAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSubscriptionAsync(request.SubscriptionAsSubscriptionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSubscriptionAsync(request.SubscriptionAsSubscriptionName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ModifyAckDeadlineRequestObject()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ModifyAckDeadlineRequest request = new ModifyAckDeadlineRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                AckDeadlineSeconds = -1594362342,
                AckIds = { "ack_ids67b2de9b", },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ModifyAckDeadline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            client.ModifyAckDeadline(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ModifyAckDeadlineRequestObjectAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ModifyAckDeadlineRequest request = new ModifyAckDeadlineRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                AckDeadlineSeconds = -1594362342,
                AckIds = { "ack_ids67b2de9b", },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ModifyAckDeadlineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            await client.ModifyAckDeadlineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ModifyAckDeadlineAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ModifyAckDeadline()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ModifyAckDeadlineRequest request = new ModifyAckDeadlineRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                AckDeadlineSeconds = -1594362342,
                AckIds = { "ack_ids67b2de9b", },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ModifyAckDeadline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            client.ModifyAckDeadline(request.Subscription, request.AckIds, request.AckDeadlineSeconds);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ModifyAckDeadlineAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ModifyAckDeadlineRequest request = new ModifyAckDeadlineRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                AckDeadlineSeconds = -1594362342,
                AckIds = { "ack_ids67b2de9b", },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ModifyAckDeadlineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            await client.ModifyAckDeadlineAsync(request.Subscription, request.AckIds, request.AckDeadlineSeconds, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ModifyAckDeadlineAsync(request.Subscription, request.AckIds, request.AckDeadlineSeconds, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ModifyAckDeadlineResourceNames()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ModifyAckDeadlineRequest request = new ModifyAckDeadlineRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                AckDeadlineSeconds = -1594362342,
                AckIds = { "ack_ids67b2de9b", },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ModifyAckDeadline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            client.ModifyAckDeadline(request.SubscriptionAsSubscriptionName, request.AckIds, request.AckDeadlineSeconds);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ModifyAckDeadlineResourceNamesAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ModifyAckDeadlineRequest request = new ModifyAckDeadlineRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                AckDeadlineSeconds = -1594362342,
                AckIds = { "ack_ids67b2de9b", },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ModifyAckDeadlineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            await client.ModifyAckDeadlineAsync(request.SubscriptionAsSubscriptionName, request.AckIds, request.AckDeadlineSeconds, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ModifyAckDeadlineAsync(request.SubscriptionAsSubscriptionName, request.AckIds, request.AckDeadlineSeconds, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AcknowledgeRequestObject()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            AcknowledgeRequest request = new AcknowledgeRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { "ack_ids67b2de9b", },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.Acknowledge(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            client.Acknowledge(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AcknowledgeRequestObjectAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            AcknowledgeRequest request = new AcknowledgeRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { "ack_ids67b2de9b", },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.AcknowledgeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            await client.AcknowledgeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.AcknowledgeAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Acknowledge()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            AcknowledgeRequest request = new AcknowledgeRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { "ack_ids67b2de9b", },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.Acknowledge(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            client.Acknowledge(request.Subscription, request.AckIds);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AcknowledgeAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            AcknowledgeRequest request = new AcknowledgeRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { "ack_ids67b2de9b", },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.AcknowledgeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            await client.AcknowledgeAsync(request.Subscription, request.AckIds, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.AcknowledgeAsync(request.Subscription, request.AckIds, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AcknowledgeResourceNames()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            AcknowledgeRequest request = new AcknowledgeRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { "ack_ids67b2de9b", },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.Acknowledge(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            client.Acknowledge(request.SubscriptionAsSubscriptionName, request.AckIds);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AcknowledgeResourceNamesAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            AcknowledgeRequest request = new AcknowledgeRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { "ack_ids67b2de9b", },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.AcknowledgeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            await client.AcknowledgeAsync(request.SubscriptionAsSubscriptionName, request.AckIds, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.AcknowledgeAsync(request.SubscriptionAsSubscriptionName, request.AckIds, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PullRequestObject()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PullRequest request = new PullRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
#pragma warning disable CS0612
                ReturnImmediately = false,
#pragma warning restore CS0612
                MaxMessages = 453182879,
            };
            PullResponse expectedResponse = new PullResponse
            {
                ReceivedMessages =
                {
                    new ReceivedMessage(),
                },
            };
            mockGrpcClient.Setup(x => x.Pull(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            PullResponse response = client.Pull(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PullRequestObjectAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PullRequest request = new PullRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
#pragma warning disable CS0612
                ReturnImmediately = false,
#pragma warning restore CS0612
                MaxMessages = 453182879,
            };
            PullResponse expectedResponse = new PullResponse
            {
                ReceivedMessages =
                {
                    new ReceivedMessage(),
                },
            };
            mockGrpcClient.Setup(x => x.PullAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PullResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            PullResponse responseCallSettings = await client.PullAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PullResponse responseCancellationToken = await client.PullAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Pull1()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PullRequest request = new PullRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
#pragma warning disable CS0612
                ReturnImmediately = false,
#pragma warning restore CS0612
                MaxMessages = 453182879,
            };
            PullResponse expectedResponse = new PullResponse
            {
                ReceivedMessages =
                {
                    new ReceivedMessage(),
                },
            };
            mockGrpcClient.Setup(x => x.Pull(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            PullResponse response = client.Pull(request.Subscription, request.ReturnImmediately, request.MaxMessages);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task Pull1Async()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PullRequest request = new PullRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
#pragma warning disable CS0612
                ReturnImmediately = false,
#pragma warning restore CS0612
                MaxMessages = 453182879,
            };
            PullResponse expectedResponse = new PullResponse
            {
                ReceivedMessages =
                {
                    new ReceivedMessage(),
                },
            };
            mockGrpcClient.Setup(x => x.PullAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PullResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            PullResponse responseCallSettings = await client.PullAsync(request.Subscription, request.ReturnImmediately, request.MaxMessages, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCallSettings);
#pragma warning disable CS0612
            PullResponse responseCancellationToken = await client.PullAsync(request.Subscription, request.ReturnImmediately, request.MaxMessages, st::CancellationToken.None);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Pull1ResourceNames()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PullRequest request = new PullRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
#pragma warning disable CS0612
                ReturnImmediately = false,
#pragma warning restore CS0612
                MaxMessages = 453182879,
            };
            PullResponse expectedResponse = new PullResponse
            {
                ReceivedMessages =
                {
                    new ReceivedMessage(),
                },
            };
            mockGrpcClient.Setup(x => x.Pull(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            PullResponse response = client.Pull(request.SubscriptionAsSubscriptionName, request.ReturnImmediately, request.MaxMessages);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task Pull1ResourceNamesAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PullRequest request = new PullRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
#pragma warning disable CS0612
                ReturnImmediately = false,
#pragma warning restore CS0612
                MaxMessages = 453182879,
            };
            PullResponse expectedResponse = new PullResponse
            {
                ReceivedMessages =
                {
                    new ReceivedMessage(),
                },
            };
            mockGrpcClient.Setup(x => x.PullAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PullResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            PullResponse responseCallSettings = await client.PullAsync(request.SubscriptionAsSubscriptionName, request.ReturnImmediately, request.MaxMessages, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCallSettings);
#pragma warning disable CS0612
            PullResponse responseCancellationToken = await client.PullAsync(request.SubscriptionAsSubscriptionName, request.ReturnImmediately, request.MaxMessages, st::CancellationToken.None);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Pull2()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PullRequest request = new PullRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                MaxMessages = 453182879,
            };
            PullResponse expectedResponse = new PullResponse
            {
                ReceivedMessages =
                {
                    new ReceivedMessage(),
                },
            };
            mockGrpcClient.Setup(x => x.Pull(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            PullResponse response = client.Pull(request.Subscription, request.MaxMessages);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task Pull2Async()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PullRequest request = new PullRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                MaxMessages = 453182879,
            };
            PullResponse expectedResponse = new PullResponse
            {
                ReceivedMessages =
                {
                    new ReceivedMessage(),
                },
            };
            mockGrpcClient.Setup(x => x.PullAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PullResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            PullResponse responseCallSettings = await client.PullAsync(request.Subscription, request.MaxMessages, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PullResponse responseCancellationToken = await client.PullAsync(request.Subscription, request.MaxMessages, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Pull2ResourceNames()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PullRequest request = new PullRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                MaxMessages = 453182879,
            };
            PullResponse expectedResponse = new PullResponse
            {
                ReceivedMessages =
                {
                    new ReceivedMessage(),
                },
            };
            mockGrpcClient.Setup(x => x.Pull(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            PullResponse response = client.Pull(request.SubscriptionAsSubscriptionName, request.MaxMessages);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task Pull2ResourceNamesAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PullRequest request = new PullRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                MaxMessages = 453182879,
            };
            PullResponse expectedResponse = new PullResponse
            {
                ReceivedMessages =
                {
                    new ReceivedMessage(),
                },
            };
            mockGrpcClient.Setup(x => x.PullAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PullResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            PullResponse responseCallSettings = await client.PullAsync(request.SubscriptionAsSubscriptionName, request.MaxMessages, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PullResponse responseCancellationToken = await client.PullAsync(request.SubscriptionAsSubscriptionName, request.MaxMessages, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ModifyPushConfigRequestObject()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ModifyPushConfigRequest request = new ModifyPushConfigRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                PushConfig = new PushConfig(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ModifyPushConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            client.ModifyPushConfig(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ModifyPushConfigRequestObjectAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ModifyPushConfigRequest request = new ModifyPushConfigRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                PushConfig = new PushConfig(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ModifyPushConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            await client.ModifyPushConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ModifyPushConfigAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ModifyPushConfig()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ModifyPushConfigRequest request = new ModifyPushConfigRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                PushConfig = new PushConfig(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ModifyPushConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            client.ModifyPushConfig(request.Subscription, request.PushConfig);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ModifyPushConfigAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ModifyPushConfigRequest request = new ModifyPushConfigRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                PushConfig = new PushConfig(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ModifyPushConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            await client.ModifyPushConfigAsync(request.Subscription, request.PushConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ModifyPushConfigAsync(request.Subscription, request.PushConfig, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ModifyPushConfigResourceNames()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ModifyPushConfigRequest request = new ModifyPushConfigRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                PushConfig = new PushConfig(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ModifyPushConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            client.ModifyPushConfig(request.SubscriptionAsSubscriptionName, request.PushConfig);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ModifyPushConfigResourceNamesAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ModifyPushConfigRequest request = new ModifyPushConfigRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                PushConfig = new PushConfig(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ModifyPushConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            await client.ModifyPushConfigAsync(request.SubscriptionAsSubscriptionName, request.PushConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ModifyPushConfigAsync(request.SubscriptionAsSubscriptionName, request.PushConfig, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSnapshotRequestObject()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotAsSnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Snapshot response = client.GetSnapshot(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSnapshotRequestObjectAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotAsSnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Snapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Snapshot responseCallSettings = await client.GetSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Snapshot responseCancellationToken = await client.GetSnapshotAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSnapshot()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotAsSnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Snapshot response = client.GetSnapshot(request.Snapshot);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSnapshotAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotAsSnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Snapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Snapshot responseCallSettings = await client.GetSnapshotAsync(request.Snapshot, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Snapshot responseCancellationToken = await client.GetSnapshotAsync(request.Snapshot, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSnapshotResourceNames()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotAsSnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Snapshot response = client.GetSnapshot(request.SnapshotAsSnapshotName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSnapshotResourceNamesAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotAsSnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Snapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Snapshot responseCallSettings = await client.GetSnapshotAsync(request.SnapshotAsSnapshotName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Snapshot responseCancellationToken = await client.GetSnapshotAsync(request.SnapshotAsSnapshotName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSnapshotRequestObject()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateSnapshotRequest request = new CreateSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Snapshot response = client.CreateSnapshot(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSnapshotRequestObjectAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateSnapshotRequest request = new CreateSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Snapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Snapshot responseCallSettings = await client.CreateSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Snapshot responseCancellationToken = await client.CreateSnapshotAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSnapshot()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateSnapshotRequest request = new CreateSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Snapshot response = client.CreateSnapshot(request.Name, request.Subscription);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSnapshotAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateSnapshotRequest request = new CreateSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Snapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Snapshot responseCallSettings = await client.CreateSnapshotAsync(request.Name, request.Subscription, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Snapshot responseCancellationToken = await client.CreateSnapshotAsync(request.Name, request.Subscription, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSnapshotResourceNames()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateSnapshotRequest request = new CreateSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Snapshot response = client.CreateSnapshot(request.SnapshotName, request.SubscriptionAsSubscriptionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSnapshotResourceNamesAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateSnapshotRequest request = new CreateSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Snapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Snapshot responseCallSettings = await client.CreateSnapshotAsync(request.SnapshotName, request.SubscriptionAsSubscriptionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Snapshot responseCancellationToken = await client.CreateSnapshotAsync(request.SnapshotName, request.SubscriptionAsSubscriptionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSnapshotRequestObject()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateSnapshotRequest request = new UpdateSnapshotRequest
            {
                Snapshot = new Snapshot(),
                UpdateMask = new wkt::FieldMask(),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Snapshot response = client.UpdateSnapshot(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSnapshotRequestObjectAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateSnapshotRequest request = new UpdateSnapshotRequest
            {
                Snapshot = new Snapshot(),
                UpdateMask = new wkt::FieldMask(),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Snapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            Snapshot responseCallSettings = await client.UpdateSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Snapshot responseCancellationToken = await client.UpdateSnapshotAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSnapshotRequestObject()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotAsSnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            client.DeleteSnapshot(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSnapshotRequestObjectAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotAsSnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSnapshotAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSnapshot()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotAsSnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            client.DeleteSnapshot(request.Snapshot);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSnapshotAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotAsSnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSnapshotAsync(request.Snapshot, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSnapshotAsync(request.Snapshot, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSnapshotResourceNames()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotAsSnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            client.DeleteSnapshot(request.SnapshotAsSnapshotName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSnapshotResourceNamesAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotAsSnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSnapshotAsync(request.SnapshotAsSnapshotName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSnapshotAsync(request.SnapshotAsSnapshotName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SeekRequestObject()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            SeekRequest request = new SeekRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                Time = new wkt::Timestamp(),
                SnapshotAsSnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
            };
            SeekResponse expectedResponse = new SeekResponse { };
            mockGrpcClient.Setup(x => x.Seek(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            SeekResponse response = client.Seek(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SeekRequestObjectAsync()
        {
            moq::Mock<Subscriber.SubscriberClient> mockGrpcClient = new moq::Mock<Subscriber.SubscriberClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            SeekRequest request = new SeekRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                Time = new wkt::Timestamp(),
                SnapshotAsSnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
            };
            SeekResponse expectedResponse = new SeekResponse { };
            mockGrpcClient.Setup(x => x.SeekAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SeekResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubscriberClient client = new SubscriberClientImpl(mockGrpcClient.Object, null);
            SeekResponse responseCallSettings = await client.SeekAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SeekResponse responseCancellationToken = await client.SeekAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
