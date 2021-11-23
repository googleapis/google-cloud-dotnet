// Copyright 2021 Google LLC
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

using Google.Api.Gax;
using Google.Cloud.PubSub.V1;
using Grpc.Core;
using System;

namespace Google.Cloud.Docs.Snippets
{
    public class EmulatorSnippets
    {
        public void ClientBuilderSupport()
        {
            // Sample: ClientBuilderSupport
            SubscriberServiceApiClient client = new SubscriberServiceApiClientBuilder
            {
                EmulatorDetection = EmulatorDetection.EmulatorOrProduction
            }.Build();
            // End sample
        }

        public void SubscriberClientSupport()
        {
            // Sample: SubscriberClient
            SubscriptionName subscription = SubscriptionName.FromProjectSubscription("projectId", "subscriptionId");
            SubscriberClient.ClientCreationSettings clientCreationSettings = new SubscriberClient.ClientCreationSettings()
                .WithEmulatorDetection(EmulatorDetection.EmulatorOrProduction);
            SubscriberClient client = SubscriberClient.Create(subscription, clientCreationSettings);
            // End sample
        }

        public void ManualConnection()
        {
            // Sample: ManualConnection
            // For example, "localhost:8615"
            string emulatorHostAndPort = Environment.GetEnvironmentVariable("PUBSUB_EMULATOR_HOST");

            PublisherServiceApiClient client = new PublisherServiceApiClientBuilder
            {
                Endpoint = emulatorHostAndPort,
                ChannelCredentials = ChannelCredentials.Insecure
            }.Build();
            // End sample
        }
    }
}
