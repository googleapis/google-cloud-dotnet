// Copyright 2016, Google Inc. All rights reserved.
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
using Google.Cloud.Iam.V1;
using Google.Cloud.PubSub.V1;
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

namespace Google.Cloud.PubSub.V1.Snippets
{
    public class GeneratedSubscriberClientSnippets
    {
        public async Task CreateSubscriptionAsync()
        {
            // Snippet: CreateSubscriptionAsync(SubscriptionName,TopicName,PushConfig,int,CallSettings)
            // Additional: CreateSubscriptionAsync(SubscriptionName,TopicName,PushConfig,int,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName name = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            PushConfig pushConfig = new PushConfig();
            int ackDeadlineSeconds = 0;
            // Make the request
            Subscription response = await subscriberClient.CreateSubscriptionAsync(name, topic, pushConfig, ackDeadlineSeconds);
            // End snippet
        }

        public void CreateSubscription()
        {
            // Snippet: CreateSubscription(SubscriptionName,TopicName,PushConfig,int,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName name = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            PushConfig pushConfig = new PushConfig();
            int ackDeadlineSeconds = 0;
            // Make the request
            Subscription response = subscriberClient.CreateSubscription(name, topic, pushConfig, ackDeadlineSeconds);
            // End snippet
        }

        public async Task GetSubscriptionAsync()
        {
            // Snippet: GetSubscriptionAsync(SubscriptionName,CallSettings)
            // Additional: GetSubscriptionAsync(SubscriptionName,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            Subscription response = await subscriberClient.GetSubscriptionAsync(subscription);
            // End snippet
        }

        public void GetSubscription()
        {
            // Snippet: GetSubscription(SubscriptionName,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            Subscription response = subscriberClient.GetSubscription(subscription);
            // End snippet
        }

        public async Task ListSubscriptionsAsync()
        {
            // Snippet: ListSubscriptionsAsync(ProjectName,string,int?,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            ProjectName project = new ProjectName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListSubscriptionsResponse,Subscription> response =
                subscriberClient.ListSubscriptionsAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subscription item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListSubscriptions()
        {
            // Snippet: ListSubscriptions(ProjectName,string,int?,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            ProjectName project = new ProjectName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListSubscriptionsResponse,Subscription> response =
                subscriberClient.ListSubscriptions(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task DeleteSubscriptionAsync()
        {
            // Snippet: DeleteSubscriptionAsync(SubscriptionName,CallSettings)
            // Additional: DeleteSubscriptionAsync(SubscriptionName,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            await subscriberClient.DeleteSubscriptionAsync(subscription);
            // End snippet
        }

        public void DeleteSubscription()
        {
            // Snippet: DeleteSubscription(SubscriptionName,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            subscriberClient.DeleteSubscription(subscription);
            // End snippet
        }

        public async Task ModifyAckDeadlineAsync()
        {
            // Snippet: ModifyAckDeadlineAsync(SubscriptionName,IEnumerable<string>,int,CallSettings)
            // Additional: ModifyAckDeadlineAsync(SubscriptionName,IEnumerable<string>,int,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            int ackDeadlineSeconds = 0;
            // Make the request
            await subscriberClient.ModifyAckDeadlineAsync(subscription, ackIds, ackDeadlineSeconds);
            // End snippet
        }

        public void ModifyAckDeadline()
        {
            // Snippet: ModifyAckDeadline(SubscriptionName,IEnumerable<string>,int,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            int ackDeadlineSeconds = 0;
            // Make the request
            subscriberClient.ModifyAckDeadline(subscription, ackIds, ackDeadlineSeconds);
            // End snippet
        }

        public async Task AcknowledgeAsync()
        {
            // Snippet: AcknowledgeAsync(SubscriptionName,IEnumerable<string>,CallSettings)
            // Additional: AcknowledgeAsync(SubscriptionName,IEnumerable<string>,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            // Make the request
            await subscriberClient.AcknowledgeAsync(subscription, ackIds);
            // End snippet
        }

        public void Acknowledge()
        {
            // Snippet: Acknowledge(SubscriptionName,IEnumerable<string>,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            // Make the request
            subscriberClient.Acknowledge(subscription, ackIds);
            // End snippet
        }

        public async Task PullAsync()
        {
            // Snippet: PullAsync(SubscriptionName,bool,int,CallSettings)
            // Additional: PullAsync(SubscriptionName,bool,int,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            bool returnImmediately = false;
            int maxMessages = 0;
            // Make the request
            PullResponse response = await subscriberClient.PullAsync(subscription, returnImmediately, maxMessages);
            // End snippet
        }

        public void Pull()
        {
            // Snippet: Pull(SubscriptionName,bool,int,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            bool returnImmediately = false;
            int maxMessages = 0;
            // Make the request
            PullResponse response = subscriberClient.Pull(subscription, returnImmediately, maxMessages);
            // End snippet
        }

        public async Task ModifyPushConfigAsync()
        {
            // Snippet: ModifyPushConfigAsync(SubscriptionName,PushConfig,CallSettings)
            // Additional: ModifyPushConfigAsync(SubscriptionName,PushConfig,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            PushConfig pushConfig = new PushConfig();
            // Make the request
            await subscriberClient.ModifyPushConfigAsync(subscription, pushConfig);
            // End snippet
        }

        public void ModifyPushConfig()
        {
            // Snippet: ModifyPushConfig(SubscriptionName,PushConfig,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            PushConfig pushConfig = new PushConfig();
            // Make the request
            subscriberClient.ModifyPushConfig(subscription, pushConfig);
            // End snippet
        }

        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string,Policy,CallSettings)
            // Additional: SetIamPolicyAsync(string,Policy,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedResource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString();
            Policy policy = new Policy();
            // Make the request
            Policy response = await subscriberClient.SetIamPolicyAsync(formattedResource, policy);
            // End snippet
        }

        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string,Policy,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedResource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString();
            Policy policy = new Policy();
            // Make the request
            Policy response = subscriberClient.SetIamPolicy(formattedResource, policy);
            // End snippet
        }

        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string,CallSettings)
            // Additional: GetIamPolicyAsync(string,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedResource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString();
            // Make the request
            Policy response = await subscriberClient.GetIamPolicyAsync(formattedResource);
            // End snippet
        }

        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedResource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString();
            // Make the request
            Policy response = subscriberClient.GetIamPolicy(formattedResource);
            // End snippet
        }

        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string,IEnumerable<string>,CallSettings)
            // Additional: TestIamPermissionsAsync(string,IEnumerable<string>,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedResource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString();
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = await subscriberClient.TestIamPermissionsAsync(formattedResource, permissions);
            // End snippet
        }

        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string,IEnumerable<string>,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedResource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString();
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = subscriberClient.TestIamPermissions(formattedResource, permissions);
            // End snippet
        }

    }
}
