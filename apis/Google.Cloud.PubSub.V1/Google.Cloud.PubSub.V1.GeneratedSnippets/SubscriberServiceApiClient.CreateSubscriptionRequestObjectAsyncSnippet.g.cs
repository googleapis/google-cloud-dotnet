// Copyright 2024 Google LLC
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

namespace GoogleCSharpSnippets
{
    // [START pubsub_v1_generated_Subscriber_CreateSubscription_async]
    using Google.Cloud.PubSub.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSubscriberServiceApiClientSnippets
    {
        /// <summary>Snippet for CreateSubscriptionAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateSubscriptionRequestObjectAsync()
        {
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            Subscription request = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = 0,
                RetainAckedMessages = false,
                MessageRetentionDuration = new Duration(),
                Labels = { { "", "" }, },
                EnableMessageOrdering = false,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new Duration(),
                BigqueryConfig = new BigQueryConfig(),
                State = Subscription.Types.State.Unspecified,
                CloudStorageConfig = new CloudStorageConfig(),
                AnalyticsHubSubscriptionInfo = new Subscription.Types.AnalyticsHubSubscriptionInfo(),
            };
            // Make the request
            Subscription response = await subscriberServiceApiClient.CreateSubscriptionAsync(request);
        }
    }
    // [END pubsub_v1_generated_Subscriber_CreateSubscription_async]
}
