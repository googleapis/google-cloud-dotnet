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
using System.Linq;
using System.Text;
using Xunit;

namespace Google.Cloud.Storage.V1.Snippets
{
    /// <summary>
    /// Fixture which is set up at the start of the test run, and torn down at the end.
    /// This creates a new bucket which can be used in all snippets. The bucket is deleted
    /// at the end of the test. The Google Cloud Project name is fetched from the TEST_PROJECT
    /// environment variable.
    /// </summary>
    [CollectionDefinition(nameof(StorageSnippetFixture))]
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
            BucketName = "snippets-" + Guid.NewGuid().ToString().ToLowerInvariant();
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
            byte[] content = Encoding.UTF8.GetBytes(HelloWorldContent);
            client.UploadObject(BucketName, HelloStorageObjectName, "text/plain", new MemoryStream(content));
            File.WriteAllText(WorldLocalFileName, HelloWorldContent);
            RegisterBucketToDelete(BucketName);
            RegisterLocalFileToDelete(WorldLocalFileName);
        }

        private void CreateNotificationsBucket()
        {
            string bucket = "snippets-notifications-" + Guid.NewGuid().ToString().ToLowerInvariant();
            var topicName = new TopicName(ProjectId, bucket);
            var storageClient = StorageClient.Create();
            storageClient.CreateBucket(ProjectId, bucket);
        }

        internal Notification CreateNotification(string prefix)
        {
            var publisherClient = PublisherClient.Create();
            var topicName = new TopicName(ProjectId, "topic-" + Guid.NewGuid().ToString().ToLowerInvariant());
            publisherClient.CreateTopic(topicName);
            RegisterTopicToDelete(topicName);
            var storageClient = StorageClient.Create();
            string storageServiceAccount = $"serviceAccount:{storageClient.GetStorageServiceAccountEmail(ProjectId)}";

            // TODO: Simplify this when we have IAM convenience methods.
            var policy = publisherClient.GetIamPolicy(topicName.ToString()) ?? new Iam.V1.Policy();
            var role = "roles/pubsub.publisher";

            var publisherBinding = policy.Bindings.FirstOrDefault(binding => binding.Role == role);
            if (publisherBinding == null)
            {
                publisherBinding = new Binding { Role = role };
                policy.Bindings.Add(publisherBinding);
            }
            if (!publisherBinding.Members.Contains(storageServiceAccount))
            {
                publisherBinding.Members.Add(storageServiceAccount);
                publisherClient.SetIamPolicy(topicName.ToString(), policy);
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
                var objects = client.ListObjects(bucket, null, new ListObjectsOptions { Versions = true }).ToList();
                foreach (var obj in objects)
                {
                    client.DeleteObject(obj, new DeleteObjectOptions { Generation = obj.Generation });
                }
                client.DeleteBucket(bucket);
            }
            foreach (var file in _localFilesToDelete)
            {
                File.Delete(file);
            }
            var publisherClient = PublisherClient.Create();
            _topicsToDelete.ForEach(topicName => publisherClient.DeleteTopic(topicName));
        }
    }
}
