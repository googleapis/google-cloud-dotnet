// Copyright 2017, Google Inc. All rights reserved.
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
using Google.Api.Gax.ResourceNames;
using Google.Apis.Auth.OAuth2;
using Google.Apis.CloudResourceManager.v1;
using Google.Apis.Services;
using Google.Cloud.ClientTesting;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.PubSub.V1.IntegrationTests
{
    [CollectionDefinition(nameof(PubsubFixture))]
    public sealed class PubsubFixture : CloudProjectFixtureBase, ICollectionFixture<PubsubFixture>
    {
        private const string TopicPrefix = "integration-topic-";
        private const string SubscriptionPrefix = "integration-sub-";

        public PubsubFixture()
        {
            _projectNumber = new Lazy<Task<string>>(async () =>
            {
                var cred = await GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false);
                cred = cred.CreateScoped(CloudResourceManagerService.Scope.CloudPlatformReadOnly);
                var crm = new CloudResourceManagerService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = cred,
                    ApplicationName = "pubsub integration test",
                });
                var project = await crm.Projects.Get(ProjectId).ExecuteAsync().ConfigureAwait(false);
                return project.ProjectNumber.ToString();
            });
        }

        private Lazy<Task<string>> _projectNumber;
        internal Task<string> GetProjectNumberAsync() => _projectNumber.Value;

        internal string CreateTopicId() => IdGenerator.FromGuid(prefix: TopicPrefix);

        internal string CreateSubscriptionId() => IdGenerator.FromGuid(prefix: SubscriptionPrefix);

        public override void Dispose()
        {
            var subscriber = new SubscriberServiceApiClientBuilder { EmulatorDetection = EmulatorDetection.EmulatorOrProduction }.Build();
            var subscriptions = subscriber.ListSubscriptions(new ProjectName(ProjectId))
                .Where(sub => sub.SubscriptionName.SubscriptionId.StartsWith(SubscriptionPrefix))
                .ToList();
            foreach (var sub in subscriptions)
            {
                subscriber.DeleteSubscription(sub.SubscriptionName);
            }

            var publisher = new PublisherServiceApiClientBuilder { EmulatorDetection = EmulatorDetection.EmulatorOrProduction }.Build();
            var topics = publisher.ListTopics(new ProjectName(ProjectId))
                .Where(topic => topic.TopicName.TopicId.StartsWith(TopicPrefix))
                .ToList();
            foreach (var topic in topics)
            {
                publisher.DeleteTopic(topic.TopicName);
            }
        }
    }
}
