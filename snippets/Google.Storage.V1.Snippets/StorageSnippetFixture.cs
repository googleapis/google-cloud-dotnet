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
using System.IO;
using System.Text;
using Xunit;

namespace Google.Storage.V1.Snippets
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

        public string HelloWorldName { get; } = "greetings/hello.txt";
        public string HelloWorldContent { get; } = "hello, world";
        public string ProjectId { get; }
        public string BucketName { get; }

        public StorageSnippetFixture()
        {
            ProjectId = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(ProjectId))
            {
                throw new InvalidOperationException(
                    $"Please set the {ProjectEnvironmentVariable} environment variable before running tests");
            }
            BucketName = "snippets-" + Guid.NewGuid().ToString().ToLowerInvariant();
            CreateAndPopulateBucket();
        }

        /// <summary>
        /// Creates a new bucket with the ID <see cref="BucketName"/>, and populates it with files needed in
        /// the tests.
        /// </summary>
        private void CreateAndPopulateBucket()
        {
            var client = StorageClient.Create();
            client.Service.Buckets.Insert(new Apis.Storage.v1.Data.Bucket { Name = BucketName }, ProjectId).Execute();
            byte[] content = Encoding.UTF8.GetBytes(HelloWorldContent);
            client.UploadObject(BucketName, HelloWorldName, "text/plain", new MemoryStream(content));
        }

        public void Dispose()
        {
            var client = StorageClient.Create();
            foreach (var obj in client.ListObjects(BucketName, null))
            {
                client.DeleteObject(obj);
            }
            client.Service.Buckets.Delete(BucketName).Execute();
        }
    }
}
