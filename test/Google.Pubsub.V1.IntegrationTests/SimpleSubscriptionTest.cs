// Copyright 2016 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

using static Google.Pubsub.V1.IntegrationTests.PubsubTestHelpers;

namespace Google.Pubsub.V1.IntegrationTests
{
    public class SimpleSubscriptionTest : IClassFixture<PubsubEmulatorFixture>
    {
        private readonly SimplePubsub _pubsub;

        public SimpleSubscriptionTest(PubsubEmulatorFixture fixture)
        {
            _pubsub = fixture.SimplePubsub;
        }

        [Fact]
        public void PullAndAcknowledge()
        {
            var topicId = CreateRandomTopic(_pubsub);
            var subscriptionId = CreateRandomSubscription(_pubsub, topicId, 10);

            var subscription = _pubsub.GetSubscription(subscriptionId);
            var topic = _pubsub.GetTopic(topicId);

            topic.Publish("first");
            topic.Publish("second");

            var received = subscription.PullAndAcknowledge();
            var textMessages = received.Select(m => m.Data.ToStringUtf8()).ToList();
            // Urgh... really want "assert set equality"...
            Assert.Equal(textMessages.OrderBy(x => x).ToArray(), new[] { "first", "second" });

            // Yes, this is ugly... but we want to make sure the messages really were acknowledged.
            // Pubsub has a minimum ack deadline of 10 seconds.
            Thread.Sleep(11000);
            // Give it something to return, just so it doesn't wait forever.
            topic.Publish("third");
            Assert.Equal(new[] { "third" }, subscription.PullAndAcknowledge().Select(x => x.Data.ToStringUtf8()).ToArray());            
        }

        [Fact]
        public async Task Poll()
        {
            var topicId = CreateRandomTopic(_pubsub);
            var subscriptionId = CreateRandomSubscription(_pubsub, topicId, 10);

            var subscription = _pubsub.GetSubscription(subscriptionId);
            var topic = _pubsub.GetTopic(topicId);

            topic.Publish("1");
            topic.Publish("2");

            var cts = new CancellationTokenSource();
            var textMessages = new List<string>();
            var publishTask = Task.Run(async () =>
            {
                // Let the first two messages get fetched, and check
                await Task.Delay(TimeSpan.FromSeconds(2));
                Assert.Equal(new[] { "1", "2" }, textMessages.OrderBy(x => x).ToArray());
                // Then publish two more
                topic.Publish("3");
                topic.Publish("4");
            });

            // Once Poll has completed, we should have all four messages, proving that Poll
            // has called Pull at least twice.
            var pollTask = subscription.PollAsync(message => textMessages.Add(message.Data.ToStringUtf8()), cts.Token);
            // Wait until we've finished publishing, then allow another couple of seconds for the poll to receive the messages.
            await publishTask;
            await Task.Delay(TimeSpan.FromSeconds(2));
            cts.Cancel();
            Assert.Equal(new[] { "1", "2", "3", "4" }, textMessages.OrderBy(x => x).ToArray());
            Assert.Equal(TaskStatus.RanToCompletion, publishTask.Status);
        }
    }
}
