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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Pubsub.V1.Snippets
{
    public class GeneratedSubscriberClientSnippets
    {
        public async Task CreateSubscriptionAsync()
        {
            // Snippet: CreateSubscriptionAsync(string,string,PushConfig,int,CallSettings)
            // Additional: CreateSubscriptionAsync(string,string,PushConfig,int,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedName = SubscriberClient.FormatSubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            string formattedTopic = SubscriberClient.FormatTopicName("[PROJECT]", "[TOPIC]");
            PushConfig pushConfig = new PushConfig();
            int ackDeadlineSeconds = 0;
            // Make the request
            Subscription response = await subscriberClient.CreateSubscriptionAsync(formattedName, formattedTopic, pushConfig, ackDeadlineSeconds);
            // End snippet
        }

        public void CreateSubscription()
        {
            // Snippet: CreateSubscription(string,string,PushConfig,int,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedName = SubscriberClient.FormatSubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            string formattedTopic = SubscriberClient.FormatTopicName("[PROJECT]", "[TOPIC]");
            PushConfig pushConfig = new PushConfig();
            int ackDeadlineSeconds = 0;
            // Make the request
            Subscription response = subscriberClient.CreateSubscription(formattedName, formattedTopic, pushConfig, ackDeadlineSeconds);
            // End snippet
        }

        public async Task GetSubscriptionAsync()
        {
            // Snippet: GetSubscriptionAsync(string,CallSettings)
            // Additional: GetSubscriptionAsync(string,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedSubscription = SubscriberClient.FormatSubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            Subscription response = await subscriberClient.GetSubscriptionAsync(formattedSubscription);
            // End snippet
        }

        public void GetSubscription()
        {
            // Snippet: GetSubscription(string,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedSubscription = SubscriberClient.FormatSubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            Subscription response = subscriberClient.GetSubscription(formattedSubscription);
            // End snippet
        }

        public async Task ListSubscriptionsAsync()
        {
            // Snippet: ListSubscriptionsAsync(string,string,int?,CallSettings)
            // Additional: ListSubscriptionsAsync(string,string,int?,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedProject = SubscriberClient.FormatProjectName("[PROJECT]");
            // Make the request
            IPagedAsyncEnumerable<ListSubscriptionsResponse,Subscription> response =
                subscriberClient.ListSubscriptionsAsync(formattedProject);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subscription item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over fixed-sized pages, lazily performing RPCs as required
            int pageSize = 10;
            IAsyncEnumerable<FixedSizePage<Subscription>> fixedSizePages = response.AsPages().WithFixedSize(pageSize);
            await fixedSizePages.ForEachAsync((FixedSizePage<Subscription> page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    Console.WriteLine(item);
                }
            });
            // End snippet
        }

        public void ListSubscriptions()
        {
            // Snippet: ListSubscriptions(string,string,int?,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedProject = SubscriberClient.FormatProjectName("[PROJECT]");
            // Make the request
            IPagedEnumerable<ListSubscriptionsResponse,Subscription> response =
                subscriberClient.ListSubscriptions(formattedProject);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over fixed-sized pages, lazily performing RPCs as required
            int pageSize = 10;
            foreach (FixedSizePage<Subscription> page in response.AsPages().WithFixedSize(pageSize))
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    Console.WriteLine(item);
                }
            }
            // End snippet
        }

        public async Task DeleteSubscriptionAsync()
        {
            // Snippet: DeleteSubscriptionAsync(string,CallSettings)
            // Additional: DeleteSubscriptionAsync(string,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedSubscription = SubscriberClient.FormatSubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            await subscriberClient.DeleteSubscriptionAsync(formattedSubscription);
            // End snippet
        }

        public void DeleteSubscription()
        {
            // Snippet: DeleteSubscription(string,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedSubscription = SubscriberClient.FormatSubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            subscriberClient.DeleteSubscription(formattedSubscription);
            // End snippet
        }

        public async Task ModifyAckDeadlineAsync()
        {
            // Snippet: ModifyAckDeadlineAsync(string,IEnumerable<string>,int,CallSettings)
            // Additional: ModifyAckDeadlineAsync(string,IEnumerable<string>,int,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedSubscription = SubscriberClient.FormatSubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            int ackDeadlineSeconds = 0;
            // Make the request
            await subscriberClient.ModifyAckDeadlineAsync(formattedSubscription, ackIds, ackDeadlineSeconds);
            // End snippet
        }

        public void ModifyAckDeadline()
        {
            // Snippet: ModifyAckDeadline(string,IEnumerable<string>,int,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedSubscription = SubscriberClient.FormatSubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            int ackDeadlineSeconds = 0;
            // Make the request
            subscriberClient.ModifyAckDeadline(formattedSubscription, ackIds, ackDeadlineSeconds);
            // End snippet
        }

        public async Task AcknowledgeAsync()
        {
            // Snippet: AcknowledgeAsync(string,IEnumerable<string>,CallSettings)
            // Additional: AcknowledgeAsync(string,IEnumerable<string>,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedSubscription = SubscriberClient.FormatSubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            // Make the request
            await subscriberClient.AcknowledgeAsync(formattedSubscription, ackIds);
            // End snippet
        }

        public void Acknowledge()
        {
            // Snippet: Acknowledge(string,IEnumerable<string>,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedSubscription = SubscriberClient.FormatSubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            // Make the request
            subscriberClient.Acknowledge(formattedSubscription, ackIds);
            // End snippet
        }

        public async Task PullAsync()
        {
            // Snippet: PullAsync(string,bool,int,CallSettings)
            // Additional: PullAsync(string,bool,int,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedSubscription = SubscriberClient.FormatSubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            bool returnImmediately = false;
            int maxMessages = 0;
            // Make the request
            PullResponse response = await subscriberClient.PullAsync(formattedSubscription, returnImmediately, maxMessages);
            // End snippet
        }

        public void Pull()
        {
            // Snippet: Pull(string,bool,int,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedSubscription = SubscriberClient.FormatSubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            bool returnImmediately = false;
            int maxMessages = 0;
            // Make the request
            PullResponse response = subscriberClient.Pull(formattedSubscription, returnImmediately, maxMessages);
            // End snippet
        }

        public async Task ModifyPushConfigAsync()
        {
            // Snippet: ModifyPushConfigAsync(string,PushConfig,CallSettings)
            // Additional: ModifyPushConfigAsync(string,PushConfig,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedSubscription = SubscriberClient.FormatSubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            PushConfig pushConfig = new PushConfig();
            // Make the request
            await subscriberClient.ModifyPushConfigAsync(formattedSubscription, pushConfig);
            // End snippet
        }

        public void ModifyPushConfig()
        {
            // Snippet: ModifyPushConfig(string,PushConfig,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedSubscription = SubscriberClient.FormatSubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            PushConfig pushConfig = new PushConfig();
            // Make the request
            subscriberClient.ModifyPushConfig(formattedSubscription, pushConfig);
            // End snippet
        }

    }
}
