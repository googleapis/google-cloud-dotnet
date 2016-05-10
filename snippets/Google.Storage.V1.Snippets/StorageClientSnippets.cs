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
        private readonly StorageSnippetFixture _fixture;

        public StorageClientSnippets(StorageSnippetFixture fixture)
        {
            this._fixture = fixture;
        }

        [Fact]
        public void Overview()
        {
            var projectId = _fixture.ProjectId;

            // <Overview>
            var client = StorageClient.Create();

            // Create a bucket
            var bucketName = Guid.NewGuid().ToString(); // must be globally unique
            var bucket = client.Service.Buckets.Insert(new Bucket { Name = bucketName }, projectId).Execute();

            // Upload some files
            var content = Encoding.UTF8.GetBytes("hello, world");
            var obj1 = client.UploadObject(bucketName, "file1.txt", "text/plain", new MemoryStream(content));
            var obj2 = client.UploadObject(bucketName, "folder1/file2.txt", "text/plain", new MemoryStream(content));

            // List objects
            foreach (var obj in client.ListObjects(bucketName, ""))
            {
                Console.WriteLine(obj.Name);
            }

            // Download file
            using (var stream = File.OpenWrite("file1.txt"))
            {
                client.DownloadObject(bucketName, "file1.txt", stream);
            }
            // </Overview>

            _fixture.RegisterLocalFileToDelete("file1.txt");
            _fixture.RegisterBucketToDelete(bucketName);

            Assert.Equal(content, File.ReadAllBytes("file1.txt"));
            Assert.Contains(client.ListObjects(bucketName, ""), o => o.Name == "file1.txt");
            Assert.Contains(client.ListObjects(bucketName, ""), o => o.Name == "folder1/file2.txt");
            Assert.Contains(client.ListBuckets(projectId), b => b.Name == bucketName);
        }

        [Fact]
        public void ListBuckets()
        {
            var projectId = _fixture.ProjectId;

            // <ListBuckets>
            var client = StorageClient.Create();

            // List all buckets associated with a project
            var buckets = client.ListBuckets(projectId);
            // </ListBuckets>

            Assert.Contains(buckets, b => _fixture.BucketName == b.Name);
        }

        [Fact]
        public void CreateBucket()
        {
            var projectId = _fixture.ProjectId;

            // <Service.Buckets.Insert>
            var client = StorageClient.Create();

            // GCS bucket names must be globally unique
            var bucketName = Guid.NewGuid().ToString();

            // Bucket defined in Google.Apis.Storage.v1.Data namespace
            var bucket = client.Service.Buckets.Insert(new Bucket { Name = bucketName }, projectId).Execute();
            // </Service.Buckets.Insert>

            _fixture.RegisterBucketToDelete(bucketName);

            Assert.Equal(bucketName, bucket.Name);
            Assert.True(!string.IsNullOrWhiteSpace(bucket.Id));
        }

        [Fact]
        public void ListObjects()
        {
            var bucketName = _fixture.BucketName;

            // <ListObjects>
            var client = StorageClient.Create();

            // List only objects with a name starting with "greet"
            var objects = client.ListObjects(bucketName, "greet");
            // </ListObjects>

            Assert.Contains(objects, o => _fixture.HelloStorageObjectName == o.Name);
        }

        [Fact]
        public void DownloadObject()
        {
            var bucketName = _fixture.BucketName;
            var projectId = _fixture.ProjectId;

            // <DownloadObject_System.String>
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
            // </DownloadObject_System.String>

            _fixture.RegisterLocalFileToDelete(destination);

            // want to show the source in the snippet, but also
            // want to make sure it matches the one in the fixture
            Assert.Equal(source, _fixture.HelloStorageObjectName);

            Assert.Equal(_fixture.HelloWorldContent, File.ReadAllText(destination));
        }

        [Fact]
        public void UploadObject()
        {
            var bucketName = _fixture.BucketName;

            // <UploadObject_System.String>
            var client = StorageClient.Create();
            var source = @".\world.txt";
            var destination = "places/world.txt";
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
            // </UploadObject_System.String>

            // want to show the source in the snippet, but also
            // want to make sure it matches the one in the fixture
            Assert.Equal(source, _fixture.WorldLocalFileName);
        }

        [Fact]
        public void GetObject()
        {
            var bucketName = _fixture.BucketName;

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
        public void GetBucket()
        {
            var bucketName = _fixture.BucketName;

            // <Service.Buckets.Get>
            var client = StorageClient.Create();

            var bucket = client.Service.Buckets.Get(bucketName).Execute();
            Console.WriteLine($"Name: {bucket.Name}");
            Console.WriteLine($"TimeCreated: {bucket.TimeCreated}");
            // </Service.Bucket.Get>
        }

        [Fact]
        public void DeleteObject()
        {
            // create a temp object to delete in the test
            var bucketName = _fixture.BucketName;
            var tempObjectName = "places/deleteme.txt";
            StorageClient.Create().UploadObject(bucketName, tempObjectName, "", Stream.Null);

            // <DeleteObject_System.String>
            var client = StorageClient.Create();
            var objectName = "places/deleteme.txt";

            client.DeleteObject(bucketName, objectName);
            // </DeleteObject_System.String>

            // want to show the name in the snippet, but also
            // want to make sure it matches the one in the test
            Assert.Equal(objectName, tempObjectName);

            Assert.DoesNotContain(client.ListObjects(bucketName, ""), o => o.Name == objectName);
        }

        [Fact]
        public void DeleteBucket()
        {
            var bucketName = Guid.NewGuid().ToString();
            StorageClient.Create().Service.Buckets.Insert(new Bucket { Name = bucketName }, _fixture.ProjectId).Execute();

            // <Service.Buckets.Delete>
            var client = StorageClient.Create();

            client.Service.Buckets.Delete(bucketName).Execute();
            // </Service.Buckets.Delete>

            Assert.DoesNotContain(client.ListBuckets(_fixture.ProjectId), b => b.Name == bucketName);
        }
    }
}
