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
    public sealed class StorageSnippetFixture : IDisposable, ICollectionFixture<StorageSnippetFixture>
    {
        private const string ProjectEnvironmentVariable = "TEST_PROJECT";
        private const string NotificationUrlEnvironmentVariable = "TEST_PROJECT_NOTIFICATION_URL";

        public string HelloStorageObjectName { get; } = "greetings/hello.txt";
        public string WorldLocalFileName { get; } = "world.txt";
        public string HelloWorldContent { get; } = "hello, world";
        public string ProjectId { get; }
        public string BucketName { get; }
        public string NotificationUrl { get; }

        private readonly List<string> bucketsToDelete = new List<string>();
        private readonly List<string> localFilesToDelete = new List<string>();

        public StorageSnippetFixture()
        {
            ProjectId = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(ProjectId))
            {
                throw new InvalidOperationException(
                    $"Please set the {ProjectEnvironmentVariable} environment variable before running tests");
            }
            NotificationUrl = Environment.GetEnvironmentVariable(NotificationUrlEnvironmentVariable);
            BucketName = "snippets-" + Guid.NewGuid().ToString().ToLowerInvariant();
            CreateAndPopulateBucket();
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

        internal void RegisterBucketToDelete(string bucket)
        {
            bucketsToDelete.Add(bucket);
        }

        internal void RegisterLocalFileToDelete(string path)
        {
            localFilesToDelete.Add(path);
        }

        public void Dispose()
        {
            var client = StorageClient.Create();
            foreach (var bucket in bucketsToDelete)
            {
                var objects = client.ListObjects(bucket, null, new ListObjectsOptions { Versions = true }).ToList();
                foreach (var obj in objects)
                {
                    client.DeleteObject(obj, new DeleteObjectOptions { Generation = obj.Generation });
                }
                client.DeleteBucket(bucket);
            }
            foreach (var file in localFilesToDelete)
            {
                File.Delete(file);
            }
        }
    }
}
