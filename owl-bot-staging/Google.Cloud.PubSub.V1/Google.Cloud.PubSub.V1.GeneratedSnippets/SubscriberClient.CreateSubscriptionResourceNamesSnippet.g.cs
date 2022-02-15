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

namespace Google.Cloud.PubSub.V1.Snippets
{
    // [START pubsub_v1_generated_Subscriber_CreateSubscription_sync_flattened_resourceNames]
    using Google.Cloud.PubSub.V1;

    public sealed partial class GeneratedSubscriberClientSnippets
    {
        /// <summary>Snippet for CreateSubscription</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateSubscriptionResourceNames()
        {
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName name = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            TopicName topic = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]");
            PushConfig pushConfig = new PushConfig();
            int ackDeadlineSeconds = 0;
            // Make the request
            Subscription response = subscriberClient.CreateSubscription(name, topic, pushConfig, ackDeadlineSeconds);
        }
    }
    // [END pubsub_v1_generated_Subscriber_CreateSubscription_sync_flattened_resourceNames]
}
