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

using Google.Pubsub.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class SubscriberClientSnippets
{
    public void ListSubscriptions()
    {
        // <ListSubscriptions>
        SubscriberClient client = SubscriberClient.Create();
        // Alternative: use a known project resource name:
        // projects/{PROJECT_ID}
        string projectName = SubscriberClient.GetProjectName("PROJECT_ID");
        foreach (Subscription subscription in client.ListSubscriptions(projectName))
        {
            Console.WriteLine($"{subscription.Name} subscribed to {subscription.Topic}");
        }
        // </ListSubscriptions>
    }

    public async Task ListSubscriptionsAsync()
    {
        // <ListSubscriptionsAsync>
        SubscriberClient client = SubscriberClient.Create();
        // Alternative: use a known project resource name:
        // projects/{PROJECT_ID}
        string projectName = SubscriberClient.GetProjectName("{PROJECT_ID}");
        IAsyncEnumerable<Subscription> subscriptions = client.ListSubscriptionsAsync(projectName);
        await subscriptions.ForEachAsync(subscription =>
        {
            Console.WriteLine($"{subscription.Name} subscribed to {subscription.Topic}");
        });
        // </ListSubscriptionsAsync>
    }

    public void CreateSubscription()
    {
        // <CreateSubscription>
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
        // </CreateSubscription>
    }

    public async Task CreateSubscriptionAsync()
    {
        // <CreateSubscriptionAsync>
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
        // </CreateSubscriptionAsync>
    }
}