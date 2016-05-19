// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Pubsub.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class SubscriberClientSnippets
{
    public void ListSubscriptions()
    {
        // Snippet: ListSubscriptions
        SubscriberClient client = SubscriberClient.Create();

        // Alternative: use a known project resource name:
        // projects/{PROJECT_ID}
        string projectName = SubscriberClient.GetProjectName("PROJECT_ID");
        foreach (Subscription subscription in client.ListSubscriptionsPageStream(projectName).Flatten())
        {
            Console.WriteLine($"{subscription.Name} subscribed to {subscription.Topic}");
        }
        // End snippet
    }

    public async Task ListSubscriptionsAsync()
    {
        // Snippet: ListSubscriptionsAsync
        SubscriberClient client = SubscriberClient.Create();

        // Alternative: use a known project resource name:
        // projects/{PROJECT_ID}
        string projectName = SubscriberClient.GetProjectName("{PROJECT_ID}");
        IAsyncEnumerable<Subscription> subscriptions = client.ListSubscriptionsPageStreamAsync(projectName).Flatten();
        await subscriptions.ForEachAsync(subscription =>
        {
            Console.WriteLine($"{subscription.Name} subscribed to {subscription.Topic}");
        });
        // End snippet
    }

    public void CreateSubscription()
    {
        // Snippet: CreateSubscription
        SubscriberClient client = SubscriberClient.Create();

        // Alternative: use an existing subscription resource name:
        // projects/{PROJECT_ID}/subscriptions/{SUBSCRIPTION_ID}
        // Similarly for the topic name:
        // projects/{PROJECT_ID}/topics/{TOPIC_ID}
        string subscriptionName = SubscriberClient.GetSubscriptionName("{PROJECT_ID}", "{SUBSCRIPTION_ID}");
        string topicName = PublisherClient.GetTopicName("{PROJECT_ID}", "{TOPIC_ID}");
        Subscription subscription = client.CreateSubscription(
            subscriptionName, topicName, pushConfig: null, ackDeadlineSeconds: 30);
        Console.WriteLine($"Created {subscription.Name} subscribed to {subscription.Topic}");
        // End snippet
    }

    public async Task CreateSubscriptionAsync()
    {
        // Snippet: CreateSubscriptionAsync(string,string,*,*,CallSettings)
        SubscriberClient client = SubscriberClient.Create();

        // Alternative: use an existing subscription resource name:
        // projects/{PROJECT_ID}/subscriptions/{SUBSCRIPTION_ID}
        // Similarly for the topic name:
        // projects/{PROJECT_ID}/topics/{TOPIC_ID}
        string subscriptionName = SubscriberClient.GetSubscriptionName("{PROJECT_ID}", "{SUBSCRIPTION_ID}");
        string topicName = PublisherClient.GetTopicName("{PROJECT_ID}", "{TOPIC_ID}");
        Subscription subscription = await client.CreateSubscriptionAsync(
            subscriptionName, topicName, pushConfig: null, ackDeadlineSeconds: 30);
        Console.WriteLine($"Created {subscription.Name} subscribed to {subscription.Topic}");
        // End snippet
    }

    public void Pull()
    {
        // Snippet: Pull
        SubscriberClient client = SubscriberClient.Create();

        // Alternative: use an existing subscription resource name:
        // projects/{PROJECT_ID}/subscriptions/{SUBSCRIPTION_ID}
        string subscriptionName = SubscriberClient.GetSubscriptionName("{PROJECT_ID}", "{SUBSCRIPTION_ID}");

        PullResponse pullResponse = client.Pull(subscriptionName, returnImmediately: false, maxMessages: 100);
        foreach (ReceivedMessage message in pullResponse.ReceivedMessages)
        {
            // Messages can contain any data. We'll assume that we know this
            // topic publishes UTF-8-encoded text.
            Console.WriteLine($"Message text: {message.Message.Data.ToStringUtf8()}");
        }

        // Acknowledge the messages after pulling them, so we don't pull them
        // a second time later. The ackDeadlineSeconds parameter specified when
        // the subscription is created determines how quickly you need to acknowledge
        // successfully-pulled messages before they will be redelivered.
        var ackIds = pullResponse.ReceivedMessages.Select(rm => rm.AckId);
        client.Acknowledge(subscriptionName, ackIds);
        // End snippet
    }

    public async Task PullAsync()
    {
        // Snippet: PullAsync(string,*,*,CallSettings)
        SubscriberClient client = SubscriberClient.Create();

        // Alternative: use an existing subscription resource name:
        // projects/{PROJECT_ID}/subscriptions/{SUBSCRIPTION_ID}
        string subscriptionName = SubscriberClient.GetSubscriptionName("{PROJECT_ID}", "{SUBSCRIPTION_ID}");

        PullResponse pullResponse = await client.PullAsync(subscriptionName, returnImmediately: false, maxMessages: 100);
        foreach (ReceivedMessage message in pullResponse.ReceivedMessages)
        {
            // Messages can contain any data. We'll assume that we know this
            // topic publishes UTF-8-encoded text.
            Console.WriteLine($"Message text: {message.Message.Data.ToStringUtf8()}");
        }

        // Acknowledge the messages after pulling them, so we don't pull them
        // a second time later. The ackDeadlineSeconds parameter specified when
        // the subscription is created determines how quickly you need to acknowledge
        // successfully-pulled messages before they will be redelivered.
        var ackIds = pullResponse.ReceivedMessages.Select(rm => rm.AckId);
        await client.AcknowledgeAsync(subscriptionName, ackIds);
        // End snippet
    }
}