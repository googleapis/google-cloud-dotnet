// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
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

namespace Google.Cloud.PubSub.V1.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedSubscriberServiceApiClientTest
    {
        [Fact]
        public void CreateSubscriptionTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient> { DefaultValue = DefaultValue.Mock };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
                AckDeadlineSeconds = 921632575,
                RetainAckedMessages = false,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CreateSubscription(It.IsAny<Subscription>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName name = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            PushConfig pushConfig = new PushConfig();
            int ackDeadlineSeconds = 2135351438;
            Subscription response = client.CreateSubscription(name, topic, pushConfig, ackDeadlineSeconds);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSubscriptionTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient> { DefaultValue = DefaultValue.Mock };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
                AckDeadlineSeconds = 2135351438,
                RetainAckedMessages = false,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetSubscription(It.IsAny<GetSubscriptionRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            Subscription response = client.GetSubscription(subscription);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSubscriptionTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteSubscription(It.IsAny<DeleteSubscriptionRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            client.DeleteSubscription(subscription);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ModifyAckDeadlineTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ModifyAckDeadline(It.IsAny<ModifyAckDeadlineRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            int ackDeadlineSeconds = 2135351438;
            client.ModifyAckDeadline(subscription, ackIds, ackDeadlineSeconds);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AcknowledgeTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.Acknowledge(It.IsAny<AcknowledgeRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            client.Acknowledge(subscription, ackIds);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void PullTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient> { DefaultValue = DefaultValue.Mock };
            PullResponse expectedResponse = new PullResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.Pull(It.IsAny<PullRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            bool returnImmediately = false;
            int maxMessages = 496131527;
            PullResponse response = client.Pull(subscription, returnImmediately, maxMessages);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ModifyPushConfigTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ModifyPushConfig(It.IsAny<ModifyPushConfigRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            PushConfig pushConfig = new PushConfig();
            client.ModifyPushConfig(subscription, pushConfig);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSnapshotTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient> { DefaultValue = DefaultValue.Mock };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CreateSnapshot(It.IsAny<CreateSnapshotRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SnapshotName name = new SnapshotName("[PROJECT]", "[SNAPSHOT]");
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            Snapshot response = client.CreateSnapshot(name, subscription);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSnapshotTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Subscriber.SubscriberClient> mockGrpcClient = new Mock<Subscriber.SubscriberClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteSnapshot(It.IsAny<DeleteSnapshotRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            SubscriberServiceApiClient client = new SubscriberServiceApiClientImpl(mockGrpcClient.Object, null);
            SnapshotName snapshot = new SnapshotName("[PROJECT]", "[SNAPSHOT]");
            client.DeleteSnapshot(snapshot);
            mockGrpcClient.VerifyAll();
        }

    }
}
