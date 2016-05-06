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

using Google.Apis.Download;
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using Google.Apis.Upload;
using System;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace Google.Storage.V1.Snippets
{
    [Collection(nameof(StorageSnippetFixture))]
    public class StorageClientSnippets
    {
        private readonly StorageSnippetFixture fixture;

        public StorageClientSnippets(StorageSnippetFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        void ListBuckets()
        {
            var projectId = fixture.ProjectId;

            // <ListBuckets>
            var client = StorageClient.Create();

            // List all buckets associated with a project
            var buckets = client.ListBuckets(projectId);
            // </ListBuckets>
        }

        [Fact]
        void CreateBucket()
        {
            var projectId = fixture.ProjectId;

            // <Buckets.Insert>
            var client = StorageClient.Create();

            // GCS bucket names must be globally unique
            var bucketName = Guid.NewGuid().ToString();

            // Bucket defined in Google.Apis.Storage.v1.Data namespace
            var bucket = client.Service.Buckets.Insert(new Bucket { Name = bucketName }, projectId).Execute();
            // </Buckets.Insert>

            Assert.Equal(bucketName, bucket.Name);
            Assert.True(!string.IsNullOrWhiteSpace(bucket.Id));
            client.Service.Buckets.Delete(bucketName).Execute();
        }

        [Fact]
        void ListObjects()
        {
            var bucketName = fixture.BucketName;

            // <ListObjects>
            var client = StorageClient.Create();

            // List only objects with a name starting with "greet"
            var objects = client.ListObjects(bucketName, "greet");
            // </ListObjects>

            var names = objects.Select(obj => obj.Name).ToList();
            Assert.Contains(fixture.HelloWorldName, names);
        }

        [Fact]
        void DownloadFile()
        {
            var bucketName = fixture.BucketName;
            var projectId = fixture.ProjectId;

            // <DownloadObject>
            var client = StorageClient.Create();
            var source = "greetings/hello.txt";
            var destination = @".\hello.txt";

            using (var stream = File.Create(destination))
            {
                // IDownloadProgress defined in Google.Apis.Download namespace
                var progress = new Progress<IDownloadProgress>(
                    p => Console.WriteLine($"bytes: {p.BytesDownloaded}, status: {p.Status}")
                );

                // Download source object from bucket to local file system
                client.DownloadObject(bucketName, source, stream, null, progress);
            }
            // </DownloadObject>

            // want to show the source path in the snippet to give an idea
            // of nested paths, but want to make sure that the pre-uploaded file
            // is at the same path as the source since it is duplicated data
            Assert.Equal(fixture.HelloWorldName, source);

            Assert.Equal(fixture.HelloWorldContent, File.ReadAllText(destination));
            File.Delete(destination);
        }

        [Fact]
        void UploadFile()
        {
            // need to write this at test run instead of fixture creation
            // as the DownloadFile test creates and deletes the same file
            var local = @".\hello.txt";
            File.WriteAllText(local, fixture.HelloWorldContent);
            var bucketName = fixture.BucketName;

            // <UploadObject>
            var client = StorageClient.Create();
            var source = @".\hello.txt";
            var destination = "greetings/hello.txt";
            var contentType = "text/plain";

            using (var stream = File.OpenRead(source))
            {
                // IUploadProgress defined in Google.Apis.Upload namespace
                var progress = new Progress<IUploadProgress>(
                  p => Console.WriteLine($"bytes: {p.BytesSent}, status: {p.Status}")
                );

                // ObjectsResource defined in Google.Apis.Storage.v1 namespace
                // var acl = ObjectsResource.InsertMediaUpload.PredefinedAclEnum.PublicRead // public
                var acl = ObjectsResource.InsertMediaUpload.PredefinedAclEnum.AuthenticatedRead; // private
                var options = new UploadObjectOptions { PredefinedAcl = acl };
                var obj = client.UploadObject(bucketName, destination, contentType, stream, options, progress);
            }
            // </UploadObject>

            // want to show the source and destinations in the snippet, but also
            // want to make sure it matches the one in the fixture
            Assert.Equal(local, source);
            Assert.Equal(destination, fixture.HelloWorldName);

            // No need to delete the storage object, as it'll be taken down by the fixture cleanup
            File.Delete(local);
        }

        [Fact]
        void GetObject()
        {
            var bucketName = fixture.BucketName;

            // <GetObject>
            var client = StorageClient.Create();
            var name = "greetings/hello.txt";

            var obj = client.GetObject(bucketName, name);
            Console.WriteLine($"Name: {obj.Name}");
            Console.WriteLine($"Size: {obj.Size}");
            Console.WriteLine($"ContentType: {obj.ContentType}");
            Console.WriteLine($"TimeCreated: {obj.TimeCreated}");
            // </GetObject>
        }

        [Fact]
        void GetBucket()
        {
            var bucketName = fixture.BucketName;

            // <Buckets.Get>
            var client = StorageClient.Create();

            var bucket = client.Service.Buckets.Get(bucketName).Execute();
            Console.WriteLine($"Name: {bucket.Name}");
            Console.WriteLine($"TimeCreated: {bucket.TimeCreated}");
            // </Bucket.Get>
        }

        [Fact]
        void DeleteObject()
        {
            var bucketName = fixture.BucketName;

            // <DeleteObject>
            var client = StorageClient.Create();
            var objectName = "greetings/hello.txt";

            client.DeleteObject(bucketName, objectName);
            // </DeleteObject>

            // want to show the name in the snippet, but also
            // want to make sure it matches the ones in the fixture
            Assert.Equal(fixture.HelloWorldName, objectName);

            // need to put the object back as it's used elsewhere
            byte[] content = Encoding.UTF8.GetBytes(fixture.HelloWorldContent);
            client.UploadObject(fixture.BucketName, fixture.HelloWorldName, "text/plain", new MemoryStream(content));
        }

        [Fact]
        void DeleteBucket()
        {
            var bucketName = Guid.NewGuid().ToString();
            StorageClient.Create().Service.Buckets.Insert(new Bucket { Name = bucketName }, fixture.ProjectId).Execute();

            // <DeleteBucket>
            var client = StorageClient.Create();

            client.Service.Buckets.Delete(bucketName).Execute();
            // </DeleteBucket>
        }

    }
}
