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
using Google.Apis.Storage.v1.Data;
using Google.Cloud.ClientTesting;
using Google.Cloud.Iam.V1;
using Google.Cloud.PubSub.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Xunit;
using Encoding = System.Text.Encoding;

namespace Google.Cloud.Storage.V1.Snippets
{
    /// <summary>
    /// Fixture which is set up at the start of the test run, and torn down at the end.
    /// This creates a new bucket which can be used in all snippets. The bucket is deleted
    /// at the end of the test. The Google Cloud Project name is fetched from the TEST_PROJECT
    /// environment variable.
    /// </summary>
    [CollectionDefinition(nameof(StorageSnippetFixture))]
    [FileLoggerBeforeAfterTest]
    public sealed class StorageSnippetFixture : CloudProjectFixtureBase, ICollectionFixture<StorageSnippetFixture>
    {
        private const string NotificationUrlEnvironmentVariable = "TEST_PROJECT_NOTIFICATION_URL";

        public string HelloStorageObjectName { get; } = "greetings/hello.txt";
        public string WorldLocalFileName { get; } = "world.txt";
        public string HelloWorldContent { get; } = "hello, world";
        public string BucketName { get; }
        public string NotificationUrl { get; }

        private readonly List<string> _bucketsToDelete = new List<string>();
        private readonly List<string> _localFilesToDelete = new List<string>();
        private readonly List<TopicName> _topicsToDelete = new List<TopicName>();

        public StorageSnippetFixture()
        {
            NotificationUrl = Environment.GetEnvironmentVariable(NotificationUrlEnvironmentVariable);
            BucketName = IdGenerator.FromDateTime(prefix: "snippets-");
            CreateAndPopulateBucket();
            CreateNotificationsBucket();
        }

        /// <summary>
        /// Creates a new bucket with the name <see cref="BucketName"/>, and populates it with files needed in
        /// the tests.
        /// </summary>
        private void CreateAndPopulateBucket()
        {
            var client = StorageClient.Create();
            client.CreateBucket(ProjectId, BucketName);
            SleepAfterBucketCreateDelete();
            byte[] content = Encoding.UTF8.GetBytes(HelloWorldContent);
            client.UploadObject(BucketName, HelloStorageObjectName, "text/plain", new MemoryStream(content));
            File.WriteAllText(WorldLocalFileName, HelloWorldContent);
            RegisterBucketToDelete(BucketName);
            RegisterLocalFileToDelete(WorldLocalFileName);
        }

        private void CreateNotificationsBucket()
        {
            string bucket = IdGenerator.FromDateTime(prefix: "snippets-notifications-");
            var topicName = new TopicName(ProjectId, bucket);
            var storageClient = StorageClient.Create();
            storageClient.CreateBucket(ProjectId, bucket);
            SleepAfterBucketCreateDelete();
        }

        /// <summary>
        /// Bucket creation/deletion is rate-limited. To avoid making the tests flaky, we sleep after each operation.
        /// </summary>
        internal static void SleepAfterBucketCreateDelete() => Thread.Sleep(2000);

        internal Notification CreateNotification(string prefix)
        {
            var publisherClient = PublisherServiceApiClient.Create();
            var topicName = new TopicName(ProjectId, IdGenerator.FromGuid(prefix: "topic-"));
            publisherClient.CreateTopic(topicName);
            RegisterTopicToDelete(topicName);
            var storageClient = StorageClient.Create();
            string storageServiceAccount = $"serviceAccount:{storageClient.GetStorageServiceAccountEmail(ProjectId)}";

            var policy = publisherClient.IAMPolicyClient.GetIamPolicy(new GetIamPolicyRequest { ResourceAsResourceName = topicName });
            var role = "roles/pubsub.publisher";
            if (policy.AddRoleMember(role, storageServiceAccount))
            {
                publisherClient.IAMPolicyClient.SetIamPolicy(new SetIamPolicyRequest { ResourceAsResourceName = topicName, Policy = policy });
            }

            return storageClient.CreateNotification(BucketName,
                new Notification { Topic = $"//pubsub.googleapis.com/{topicName}", PayloadFormat = "JSON_API_V1" });
        }

        internal void RegisterBucketToDelete(string bucket)
        {
            _bucketsToDelete.Add(bucket);
        }

        internal void RegisterLocalFileToDelete(string path)
        {
            _localFilesToDelete.Add(path);
        }

        internal void RegisterTopicToDelete(TopicName topicName)
        {
            _topicsToDelete.Add(topicName);
        }

        public override void Dispose()
        {
            var client = StorageClient.Create();
            foreach (var bucket in _bucketsToDelete)
            {
                client.DeleteBucket(bucket, new DeleteBucketOptions { DeleteObjects = true });
                SleepAfterBucketCreateDelete();
            }
            foreach (var file in _localFilesToDelete)
            {
                File.Delete(file);
            }
            var publisherClient = PublisherServiceApiClient.Create();
            _topicsToDelete.ForEach(topicName => publisherClient.DeleteTopic(topicName));
        }
    }
}
