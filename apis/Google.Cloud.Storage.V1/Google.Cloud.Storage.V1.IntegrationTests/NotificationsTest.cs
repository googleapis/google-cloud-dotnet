// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Apis.Storage.v1.Data;
using Google.Cloud.ClientTesting;
using Google.Cloud.PubSub.V1;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Object = Google.Apis.Storage.v1.Data.Object;
using Encoding = System.Text.Encoding;
using Google.Cloud.Iam.V1;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class NotificationsTest
    {
        private readonly StorageFixture _fixture;

        public NotificationsTest(StorageFixture fixture) => _fixture = fixture;

        [Fact]
        public void GetServiceAccountEmail()
        {
            var projectId = _fixture.ProjectId;
            var email = _fixture.Client.GetStorageServiceAccountEmail(projectId);
            int orgSeparatorIndex = projectId.IndexOf(':');
            if (orgSeparatorIndex >= 0)
            {
                projectId = projectId.Substring(orgSeparatorIndex + 1);
            }
            Assert.EndsWith("@gs-project-accounts.iam.gserviceaccount.com", email);
        }

        /// <summary>
        /// A single test for all notifications operations, given that they're somewhat intertwined.
        /// </summary>
        [Fact]
        public async Task NotificationsLifeCycle()
        {
            var storageClient = _fixture.Client;

            // First create a bucket, a topic and a subscription
            var publisherClient = PublisherServiceApiClient.Create();
            var subscriberClient = SubscriberServiceApiClient.Create();
            var bucket = _fixture.BucketPrefix + "notifications";
            var topicName = new TopicName(_fixture.ProjectId, IdGenerator.FromGuid(prefix: "storage-topic-"));
            var subscriptionName = new SubscriptionName(_fixture.ProjectId, IdGenerator.FromGuid(prefix: "storage-sub-"));
            publisherClient.CreateTopic(topicName);

            // Make sure the Storage service account has permission to publish to the topic.
            var policy = publisherClient.IAMPolicyClient.GetIamPolicy(new GetIamPolicyRequest { ResourceAsResourceName = topicName });
            var role = "roles/pubsub.publisher";
            string storageServiceAccount = $"serviceAccount:{storageClient.GetStorageServiceAccountEmail(_fixture.ProjectId)}";
            if (policy.AddRoleMember(role, storageServiceAccount))
            {
                publisherClient.IAMPolicyClient.SetIamPolicy(new SetIamPolicyRequest { ResourceAsResourceName = topicName, Policy = policy });
            }

            try
            {
                subscriberClient.CreateSubscription(subscriptionName, topicName, new PushConfig(), 10);

                _fixture.CreateBucket(bucket, false);

                // Create the configuration
                var config = new Notification { Topic = $"//pubsub.googleapis.com/{topicName}", PayloadFormat = "JSON_API_V1" };
                var created = storageClient.CreateNotification(bucket, config);
                string notificationId = created.Id;
                Assert.NotNull(notificationId);

                // Wait 30 seconds to let the notification become active reliably.
                await Task.Delay(TimeSpan.FromSeconds(30));

                // Check we can fetch it, and that it looks the same as the resource we received on creation.
                var fetched = storageClient.GetNotification(bucket, notificationId);

                Assert.Equal(
                    storageClient.Service.SerializeObject(created),
                    storageClient.Service.SerializeObject(fetched));

                // Check it appears in the list
                Assert.Contains(notificationId, storageClient.ListNotifications(bucket).Select(n => n.Id));

                // Create an object in the bucket and check we get a notification.
                storageClient.UploadObject(bucket, "file.txt", "application/text", new MemoryStream(Encoding.UTF8.GetBytes("hello")));

                // This is the only place we use async in this test, because it makes it easy to cancel the request after 10 seconds.
                var token = new CancellationTokenSource(TimeSpan.FromSeconds(10)).Token;
                var pullRequest = new PullRequest { SubscriptionAsSubscriptionName = subscriptionName, MaxMessages = 10 };
                var pullResponse = await subscriberClient.PullAsync(pullRequest);

                var messages = pullResponse.ReceivedMessages;
                subscriberClient.Acknowledge(subscriptionName, messages.Select(m => m.AckId));

                // Each ReceivedMessage.Message is a JSON representation of the Object that has changed.
                // We just check that at least one notification was for the object we've just created.
                var objectIds = messages
                    .Select(m => m.Message.Data.ToStringUtf8())
                    .Select(json => (Object) storageClient.Service.Serializer.Deserialize(json, typeof(Object)))
                    // Object.Id is the notification ID; Object.Name is the object name
                    .Select(obj => obj.Name)
                    .ToList();

                Assert.Contains("file.txt", objectIds);

                // Delete the notification configuration
                storageClient.DeleteNotification(bucket, notificationId);

                // Check it's no longer in the list
                Assert.DoesNotContain(notificationId, storageClient.ListNotifications(bucket).Select(n => n.Id));

                // TODO: Delete the subscription? (Seems to fail - maybe we need to wait? Put this in the fixture disposal?)
            }
            finally
            {
                publisherClient.DeleteTopic(topicName);
            }
        }
    }
}
