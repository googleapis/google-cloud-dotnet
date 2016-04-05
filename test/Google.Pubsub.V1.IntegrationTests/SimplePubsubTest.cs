// Copyright 2016 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Api.Gax;
using Grpc.Core;
using System;
using Xunit;

using static Google.Pubsub.V1.IntegrationTests.PubsubTestHelpers;

namespace Google.Pubsub.V1.IntegrationTests
{
    public class SimplePubsubTest : IClassFixture<PubsubEmulatorFixture>
    {
        private readonly SimplePubsub _pubsub;

        public SimplePubsubTest(PubsubEmulatorFixture fixture)
        {
            _pubsub = fixture.SimplePubsub;
        }

        [Fact]
        public void GetSubscription_Exists()
        {
            var topicId = CreateRandomTopic(_pubsub);
            var subscriptionId = CreateRandomSubscription(_pubsub, topicId);
            var subscription = _pubsub.GetSubscription(subscriptionId);
            Assert.Equal(topicId, subscription.TopicId);
            Assert.Equal(subscriptionId, subscription.SubscriptionId);
        }

        [Fact]
        public void GetSubscription_DoesNotExist()
        {
            var exception = Assert.Throws<RpcException>(() => _pubsub.GetSubscription(CreateRandomId()));
            Assert.Equal(StatusCode.NotFound, exception.Status.StatusCode);
        }

        [Fact]
        public void GetOrCreateSubscription_Exists_CorrectTopic()
        {
            var topicId = CreateRandomTopic(_pubsub);
            var subscriptionId = CreateRandomSubscription(_pubsub, topicId);

            var subscription = _pubsub.GetOrCreateSubscription(subscriptionId, topicId);
            Assert.Equal(topicId, subscription.TopicId);
            Assert.Equal(subscriptionId, subscription.SubscriptionId);
        }

        [Fact]
        public void GetOrCreateSubscription_Exists_WrongTopic()
        {
            var topicId = CreateRandomTopic(_pubsub);
            var subscriptionId = CreateRandomSubscription(_pubsub, topicId);

            Assert.Throws<ResourceMismatchException>(() => _pubsub.GetOrCreateSubscription(subscriptionId, topicId + "wrong"));
        }

        [Fact]
        public void GetOrCreateSubscription_CreatesNew()
        {
            var topicId = CreateRandomTopic(_pubsub);
            var subscriptionId = CreateRandomId();
            // Subscription doesn't exist
            Assert.Throws<RpcException>(() => _pubsub.GetSubscription(subscriptionId));
            // Creating it succeeds
            _pubsub.GetOrCreateSubscription(subscriptionId, topicId);
            // Fetching it then succeeds too
            Assert.Equal(topicId, _pubsub.GetSubscription(subscriptionId).TopicId);
        }
        
        [Fact]
        public void GetOrCreateSubscription_CreationFailsAsTopicDoesNotExist()
        {
            var topicId = CreateRandomId();
            var subscriptionId = CreateRandomId();
            Assert.Throws<RpcException>(() => _pubsub.GetSubscription(subscriptionId));
            Assert.Throws<RpcException>(() => _pubsub.GetOrCreateSubscription(subscriptionId, topicId));
            Assert.Throws<RpcException>(() => _pubsub.GetSubscription(subscriptionId));
        }

        [Fact]
        public void GetTopic_Exists()
        {
            var topicId = CreateRandomTopic(_pubsub);
            var topic = _pubsub.GetTopic(topicId);
            Assert.Equal(topicId, topic.TopicId);
        }

        [Fact]
        public void GetTopic_DoesNotExist()
        {
            var topicId = CreateRandomTopic(_pubsub);
            var exception = Assert.Throws<RpcException>(() => _pubsub.GetTopic(CreateRandomId()));
            Assert.Equal(StatusCode.NotFound, exception.Status.StatusCode);
        }

        [Fact]
        public void GetOrCreateTopic_Exists()
        {
            var topicId = CreateRandomTopic(_pubsub);
            var topic = _pubsub.GetOrCreateTopic(topicId);
            Assert.Equal(topicId, topic.TopicId);
        }

        [Fact]
        public void GetOrCreateTopic_CreatesNew()
        {
            var topicId = CreateRandomId();
            // Subscription doesn't exist
            Assert.Throws<RpcException>(() => _pubsub.GetTopic(topicId));
            // Creating it succeeds
            _pubsub.GetOrCreateTopic(topicId);
            // Fetching it then succeeds too
            Assert.Equal(topicId, _pubsub.GetTopic(topicId).TopicId);
        }
    }
}
