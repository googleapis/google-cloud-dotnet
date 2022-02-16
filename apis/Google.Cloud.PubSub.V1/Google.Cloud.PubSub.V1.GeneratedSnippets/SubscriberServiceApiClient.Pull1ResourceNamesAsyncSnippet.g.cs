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
    // [START pubsub_v1_generated_SubscriberServiceApi_Pull_async_flattened1_resourceNames]
    using Google.Cloud.PubSub.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSubscriberServiceApiClientSnippets
    {
        /// <summary>Snippet for PullAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task Pull1ResourceNamesAsync()
        {
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            bool returnImmediately = false;
            int maxMessages = 0;
            // Make the request
#pragma warning disable CS0612
            PullResponse response = await subscriberServiceApiClient.PullAsync(subscription, returnImmediately, maxMessages);
#pragma warning restore CS0612
        }
    }
    // [END pubsub_v1_generated_SubscriberServiceApi_Pull_async_flattened1_resourceNames]
}
