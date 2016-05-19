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
using Google.Apis.Storage.v1.Data;
using Google.Apis.Upload;
using System;
using System.Collections.Generic;
using System.IO;
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
            _fixture = fixture;
        }

        [Fact]
        public void Overview()
        {
            var projectId = _fixture.ProjectId;

            // <Overview>
            var client = StorageClient.Create();

            // Create a bucket
            var bucketName = Guid.NewGuid().ToString(); // must be globally unique
            var bucket = client.CreateBucket(projectId, bucketName);

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

            // <CreateBucket>
            var client = StorageClient.Create();

            // GCS bucket names must be globally unique
            var bucketName = Guid.NewGuid().ToString();

            // Bucket defined in Google.Apis.Storage.v1.Data namespace
            var bucket = client.CreateBucket(projectId, bucketName);
            // </CreateBucket>

            _fixture.RegisterBucketToDelete(bucketName);

            Assert.Equal(bucketName, bucket.Name);
            Assert.True(!string.IsNullOrWhiteSpace(bucket.Id));
        }

        [Fact]
        public void UpdateBucket()
        {
            var projectId = _fixture.ProjectId;
            var setupClient = StorageClient.Create();

            // GCS bucket names must be globally unique
            var bucketName = Guid.NewGuid().ToString();
            setupClient.CreateBucket(projectId, bucketName);
            _fixture.RegisterBucketToDelete(bucketName);

            // <UpdateBucket>
            var client = StorageClient.Create();
            var bucket = client.GetBucket(bucketName, new GetBucketOptions { Projection = Projection.Full });
            bucket.Website = new Bucket.WebsiteData
            {
                MainPageSuffix = "index.html",
                NotFoundPage = "404.html"
            };
            client.UpdateBucket(bucket);
            // </UpdateBucket>

            // Fetch the bucket again to check that the change "stuck"
            var fetchedBucket = client.GetBucket(bucketName);
            Assert.Equal(bucketName, fetchedBucket.Name);
            Assert.Equal(bucket.Website.MainPageSuffix, fetchedBucket.Website.MainPageSuffix);
        }

        [Fact]
        public void PatchBucket()
        {
            var projectId = _fixture.ProjectId;
            var setupClient = StorageClient.Create();

            // GCS bucket names must be globally unique
            var bucketName = Guid.NewGuid().ToString();
            setupClient.CreateBucket(projectId, bucketName);
            _fixture.RegisterBucketToDelete(bucketName);

            // <PatchBucket>
            var client = StorageClient.Create();
            // Note: no fetching of the bucket beforehand. We only specify the values we want
            // to change.
            var bucket = new Bucket
            {
                Name = bucketName,
                Website = new Bucket.WebsiteData
                {
                    MainPageSuffix = "index.html",
                    NotFoundPage = "404.html"
                }
            };
            client.PatchBucket(bucket);
            // </PatchBucket>

            // Fetch the bucket to check that the change "stuck"
            var fetchedBucket = client.GetBucket(bucketName);
            Assert.Equal(bucketName, fetchedBucket.Name);
            Assert.Equal(bucket.Website.MainPageSuffix, fetchedBucket.Website.MainPageSuffix);
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
            var destination = "hello.txt";

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
            var source = "world.txt";
            var destination = "places/world.txt";
            var contentType = "text/plain";

            using (var stream = File.OpenRead(source))
            {
                // IUploadProgress defined in Google.Apis.Upload namespace
                var progress = new Progress<IUploadProgress>(
                  p => Console.WriteLine($"bytes: {p.BytesSent}, status: {p.Status}")
                );

                // var acl = PredefinedAcl.PublicRead // public
                var acl = PredefinedObjectAcl.AuthenticatedRead; // private
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
        public void UpdateObject()
        {
            var bucketName = _fixture.BucketName;

            // <UpdateObject>
            var client = StorageClient.Create();
            var name = "update-example.txt";
            var content = Encoding.UTF8.GetBytes("hello, world");
            var obj = new Apis.Storage.v1.Data.Object
            {
                Bucket = bucketName,
                Name = name,
                ContentType = "text/json",
                Metadata = new Dictionary<string, string>
                {
                    { "key1", "value1" },
                    { "key2", "value2" }
                }
            };
            // The update call requires full object information, so we set the projection to "full" here.
            // An alternative would be to upload the object and then separately fetch it, again with
            // a full projection.
            obj = client.UploadObject(obj, new MemoryStream(content), new UploadObjectOptions { Projection = Projection.Full });
            obj.Metadata.Remove("key1");
            obj.Metadata["key2"] = "updated-value2";
            obj.Metadata["key3"] = "value3";
            obj.ContentType = "text/plain";
            client.UpdateObject(obj);
            // </UpdateObject>

            var fetchedObject = client.GetObject(bucketName, name);
            Assert.Equal(name, fetchedObject.Name);
            Assert.False(fetchedObject.Metadata.ContainsKey("key1"));
            Assert.Equal("text/plain", fetchedObject.ContentType);
            Assert.Equal("updated-value2", fetchedObject.Metadata["key2"]);
            Assert.Equal("value3", fetchedObject.Metadata["key3"]);
        }

        [Fact]
        public void PatchObject()
        {
            var bucketName = _fixture.BucketName;

            // <PatchObject>
            var client = StorageClient.Create();
            var name = "patch-example.txt";
            var content = Encoding.UTF8.GetBytes("hello, world");
            var obj = new Apis.Storage.v1.Data.Object
            {
                Bucket = bucketName,
                Name = name,
                ContentType = "text/json", // Deliberately incorrect
                Metadata = new Dictionary<string, string>
                {
                    { "key1", "value1" },
                    { "key2", "value2" }
                }
            };
            client.UploadObject(obj, new MemoryStream(content));

            var patchObject = new Apis.Storage.v1.Data.Object
            {
                // The bucket and name are required; everything else is optional.
                // Only specified properties will be updated.
                Bucket = bucketName,
                Name = name,
                ContentType = "text/plain",
                Metadata = new Dictionary<string, string>
                {
                    { "key2", "updated-value2" },
                    { "key3", "value3" }
                }
            };
            client.PatchObject(patchObject);
            // </PatchObject>

            var fetchedObject = client.GetObject(bucketName, name);
            Assert.Equal(name, fetchedObject.Name);
            Assert.Equal("text/plain", fetchedObject.ContentType);
            // key1=value1 still exists, because the patch didn't remove it
            Assert.Equal("value1", fetchedObject.Metadata["key1"]);
            Assert.Equal("updated-value2", fetchedObject.Metadata["key2"]);
            Assert.Equal("value3", fetchedObject.Metadata["key3"]);
        }

        [Fact]
        public void CopyObject()
        {
            var projectId = _fixture.ProjectId;
            var sourceBucket = _fixture.BucketName;
            var destinationBucket = Guid.NewGuid().ToString();
            StorageClient.Create().CreateBucket(projectId, destinationBucket);
            _fixture.RegisterBucketToDelete(destinationBucket);

            // <CopyObject>
            var client = StorageClient.Create();
            var sourceName = "greetings/hello.txt";
            var destinationName = "copy.txt";

            // This method actually uses the "rewrite" API operation, for added reliability
            // when copying large objects across locations, storage classes or encryption keys.
            client.CopyObject(sourceBucket, sourceName, destinationBucket, destinationName);
            // </CopyObject>

            var obj = client.GetObject(destinationBucket, destinationName);
            Assert.Equal((ulong)Encoding.UTF8.GetByteCount(_fixture.HelloWorldContent), obj.Size.Value);
        }

        // TODO:
        // - ComposeObject? (or ConcatenateObjects?)
        // - MoveObject? (Copy then delete, as per node)
        // - DeleteFiles (on a bucket) - or an option on DeleteBucket?
        // - ACLs?
        // - WatchAll and stop watching? (Need an HTTPS site for testing.)

        [Fact]
        public void GetBucket()
        {
            var bucketName = _fixture.BucketName;

            // <GetBucket>
            var client = StorageClient.Create();

            var bucket = client.GetBucket(bucketName);
            Console.WriteLine($"Name: {bucket.Name}");
            Console.WriteLine($"TimeCreated: {bucket.TimeCreated}");
            // </GetBucket>
        }

        // TODO: Flag to delete all versions of an object?

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
            StorageClient.Create().CreateBucket(_fixture.ProjectId, bucketName);

            // <DeleteBucket>
            var client = StorageClient.Create();

            client.DeleteBucket(bucketName);
            // </DeleteBucket>

            Assert.DoesNotContain(client.ListBuckets(_fixture.ProjectId), b => b.Name == bucketName);
        }
    }
}
