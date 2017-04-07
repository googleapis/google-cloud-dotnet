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
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.Snippets
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

            // Sample: Overview
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
            // End sample

            _fixture.RegisterLocalFileToDelete("file1.txt");
            _fixture.RegisterBucketToDelete(bucketName);

            Assert.Equal(content, File.ReadAllBytes("file1.txt"));
            var objects = client.ListObjects(bucketName, "").ToList();
            Assert.Contains(objects, o => o.Name == "file1.txt");
            Assert.Contains(objects, o => o.Name == "folder1/file2.txt");
            Assert.Contains(client.ListBuckets(projectId), b => b.Name == bucketName);
        }

        [Fact]
        public void CustomerSuppliedEncryptionKeys()
        {
            var bucketName = _fixture.BucketName;

            // Sample: CustomerSuppliedEncryptionKeys
            // Use EncryptionKey.Create if you already have a key.
            EncryptionKey key = EncryptionKey.Generate();
            
            // This will affect all relevant object-based operations by default.
            var client = StorageClient.Create(encryptionKey: key);
            var content = Encoding.UTF8.GetBytes("hello, world");
            client.UploadObject(bucketName, "encrypted.txt", "text/plain", new MemoryStream(content));

            // When downloading, either use a client with the same key...
            client.DownloadObject(bucketName, "encrypted.txt", new MemoryStream());

            // Or specify a key just for that operation.
            var client2 = StorageClient.Create();
            client2.DownloadObject(bucketName, "encrypted.txt", new MemoryStream(),
                new DownloadObjectOptions { EncryptionKey = key });
            // End sample
        }

        [Fact]
        public void ListBuckets()
        {
            var projectId = _fixture.ProjectId;

            // Snippet: ListBuckets
            var client = StorageClient.Create();

            // List all buckets associated with a project
            var buckets = client.ListBuckets(projectId);
            // End snippet

            Assert.Contains(buckets, b => _fixture.BucketName == b.Name);
        }

        // See-also: ListBuckets
        // Member: ListBucketsAsync
        // See [ListBuckets](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void CreateBucket()
        {
            var projectId = _fixture.ProjectId;

            // Snippet: CreateBucket(string,string,*)
            var client = StorageClient.Create();

            // GCS bucket names must be globally unique
            var bucketName = Guid.NewGuid().ToString();

            // Bucket defined in Google.Apis.Storage.v1.Data namespace
            var bucket = client.CreateBucket(projectId, bucketName);
            // End snippet

            _fixture.RegisterBucketToDelete(bucketName);

            Assert.Equal(bucketName, bucket.Name);
            Assert.True(!string.IsNullOrWhiteSpace(bucket.Id));
        }

        // See-also: CreateBucket(string,string,*)
        // Member: CreateBucket(string,Bucket,*)
        // See [CreateBucket](ref) for an example using an alternative overload.
        // End see-also

        // See-also: CreateBucket(string,string,*)
        // Member: CreateBucketAsync(string,Bucket,*,*)
        // Member: CreateBucketAsync(string,string,*,*)
        // See [CreateBucket](ref) for a synchronous example.
        // End see-also


        [Fact]
        public void UpdateBucket()
        {
            var projectId = _fixture.ProjectId;
            var setupClient = StorageClient.Create();

            // GCS bucket names must be globally unique
            var bucketName = Guid.NewGuid().ToString();
            setupClient.CreateBucket(projectId, bucketName);
            _fixture.RegisterBucketToDelete(bucketName);

            // Snippet: UpdateBucket
            var client = StorageClient.Create();
            var bucket = client.GetBucket(bucketName);
            bucket.Website = new Bucket.WebsiteData
            {
                MainPageSuffix = "index.html",
                NotFoundPage = "404.html"
            };
            client.UpdateBucket(bucket);
            // End snippet

            // Fetch the bucket again to check that the change "stuck"
            var fetchedBucket = client.GetBucket(bucketName);
            Assert.Equal(bucketName, fetchedBucket.Name);
            Assert.Equal(bucket.Website.MainPageSuffix, fetchedBucket.Website.MainPageSuffix);
        }

        // See-also: UpdateBucket
        // Member: UpdateBucketAsync
        // See [UpdateBucket](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void PatchBucket()
        {
            var projectId = _fixture.ProjectId;
            var setupClient = StorageClient.Create();

            // GCS bucket names must be globally unique
            var bucketName = Guid.NewGuid().ToString();
            setupClient.CreateBucket(projectId, bucketName);
            _fixture.RegisterBucketToDelete(bucketName);

            // Snippet: PatchBucket
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
            // End snippet

            // Fetch the bucket to check that the change "stuck"
            var fetchedBucket = client.GetBucket(bucketName);
            Assert.Equal(bucketName, fetchedBucket.Name);
            Assert.Equal(bucket.Website.MainPageSuffix, fetchedBucket.Website.MainPageSuffix);
        }

        // See-also: PatchBucket
        // Member: PatchBucketAsync
        // See [PatchBucket](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void ListObjects()
        {
            var bucketName = _fixture.BucketName;

            // Snippet: ListObjects
            var client = StorageClient.Create();

            // List only objects with a name starting with "greet"
            var objects = client.ListObjects(bucketName, "greet");
            // End snippet

            Assert.Contains(objects, o => _fixture.HelloStorageObjectName == o.Name);
        }

        // See-also: ListObjects
        // Member: ListObjectsAsync
        // See [ListObjects](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void DownloadObject()
        {
            var bucketName = _fixture.BucketName;
            var projectId = _fixture.ProjectId;

            // Snippet: DownloadObject(string,string,*,*,*)
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
            // End snippet

            _fixture.RegisterLocalFileToDelete(destination);

            // want to show the source in the snippet, but also
            // want to make sure it matches the one in the fixture
            Assert.Equal(source, _fixture.HelloStorageObjectName);

            Assert.Equal(_fixture.HelloWorldContent, File.ReadAllText(destination));
        }

        // See-also: DownloadObject(string,string,*,*,*)
        // Member: DownloadObject(Object,*,*,*)
        // See [DownloadObject](ref) for an example using an alternative overload.
        // End see-also

        // See-also: DownloadObject(string,string,*,*,*)
        // Member: DownloadObjectAsync(string,string,*,*,*,*)
        // Member: DownloadObjectAsync(Object,*,*,*,*)
        // See [DownloadObject](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void UploadObject()
        {
            var bucketName = _fixture.BucketName;

            // Snippet: UploadObject(string,string,*,*,*,*)
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
            // End snippet

            // want to show the source in the snippet, but also
            // want to make sure it matches the one in the fixture
            Assert.Equal(source, _fixture.WorldLocalFileName);
        }

        // See-also: UploadObject(string,string,*,*,*,*)
        // Member: UploadObject(Object,*,*,*)
        // See [UploadObject](ref) for an example using an alternative overload.
        // End see-also

        // See-also: UploadObject(string,string,*,*,*,*)
        // Member: UploadObjectAsync(string,string,*,*,*,*,*)
        // Member: UploadObjectAsync(Object,*,*,*,*)
        // See [UploadObject](ref) for a synchronous example.
        // End see-also

        [Fact]
        public async Task UploadObjectWithSessionUri()
        {
            var bucketName = _fixture.BucketName;

            // Sample: UploadObjectWithSessionUri
            var client = StorageClient.Create();
            var source = "world.txt";
            var destination = "places/world.txt";
            var contentType = "text/plain";

            // var acl = PredefinedAcl.PublicRead // public
            var acl = PredefinedObjectAcl.AuthenticatedRead; // private
            var options = new UploadObjectOptions { PredefinedAcl = acl };
            // Create a temporary uploader so the upload session can be manually initiated without actually uploading.
            var tempUploader = client.CreateObjectUploader(bucketName, destination, contentType, new MemoryStream(), options);
            var uploadUri = await tempUploader.InitiateSessionAsync();

            // Send uploadUri to (unauthenticated) client application, so it can perform the upload:
            using (var stream = File.OpenRead(source))
            {
                // IUploadProgress defined in Google.Apis.Upload namespace
                IProgress<IUploadProgress> progress = new Progress<IUploadProgress>(
                  p => Console.WriteLine($"bytes: {p.BytesSent}, status: {p.Status}")
                );

                var actualUploader = ResumableUpload.CreateFromUploadUri(uploadUri, stream);
                actualUploader.ProgressChanged += progress.Report;
                await actualUploader.UploadAsync();
            }
            // End sample

            // want to show the source in the snippet, but also
            // want to make sure it matches the one in the fixture
            Assert.Equal(source, _fixture.WorldLocalFileName);
        }

        [Fact]
        public void GetObject()
        {
            var bucketName = _fixture.BucketName;

            // Snippet: GetObject
            var client = StorageClient.Create();
            var name = "greetings/hello.txt";

            var obj = client.GetObject(bucketName, name);
            Console.WriteLine($"Name: {obj.Name}");
            Console.WriteLine($"Size: {obj.Size}");
            Console.WriteLine($"ContentType: {obj.ContentType}");
            Console.WriteLine($"TimeCreated: {obj.TimeCreated}");
            // End snippet
        }

        // See-also: GetObject
        // Member: GetObjectAsync
        // See [GetObject](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void UpdateObject()
        {
            var bucketName = _fixture.BucketName;

            // Snippet: UpdateObject
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
            obj = client.UploadObject(obj, new MemoryStream(content));
            obj.Metadata.Remove("key1");
            obj.Metadata["key2"] = "updated-value2";
            obj.Metadata["key3"] = "value3";
            obj.ContentType = "text/plain";
            client.UpdateObject(obj);
            // End snippet

            var fetchedObject = client.GetObject(bucketName, name);
            Assert.Equal(name, fetchedObject.Name);
            Assert.False(fetchedObject.Metadata.ContainsKey("key1"));
            Assert.Equal("text/plain", fetchedObject.ContentType);
            Assert.Equal("updated-value2", fetchedObject.Metadata["key2"]);
            Assert.Equal("value3", fetchedObject.Metadata["key3"]);
        }

        // See-also: UpdateObject
        // Member: UpdateObjectAsync
        // See [UpdateObject](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void PatchObject()
        {
            var bucketName = _fixture.BucketName;

            // Snippet: PatchObject
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
            // End snippet

            var fetchedObject = client.GetObject(bucketName, name);
            Assert.Equal(name, fetchedObject.Name);
            Assert.Equal("text/plain", fetchedObject.ContentType);
            // key1=value1 still exists, because the patch didn't remove it
            Assert.Equal("value1", fetchedObject.Metadata["key1"]);
            Assert.Equal("updated-value2", fetchedObject.Metadata["key2"]);
            Assert.Equal("value3", fetchedObject.Metadata["key3"]);
        }

        // See-also: PatchObject
        // Member: PatchObjectAsync
        // See [PatchObject](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void CopyObject()
        {
            var projectId = _fixture.ProjectId;
            var sourceBucket = _fixture.BucketName;
            var destinationBucket = Guid.NewGuid().ToString();
            StorageClient.Create().CreateBucket(projectId, destinationBucket);
            _fixture.RegisterBucketToDelete(destinationBucket);

            // Snippet: CopyObject
            var client = StorageClient.Create();
            var sourceName = "greetings/hello.txt";
            var destinationName = "copy.txt";

            // This method actually uses the "rewrite" API operation, for added reliability
            // when copying large objects across locations, storage classes or encryption keys.
            client.CopyObject(sourceBucket, sourceName, destinationBucket, destinationName);
            // End snippet

            var obj = client.GetObject(destinationBucket, destinationName);
            Assert.Equal((ulong)Encoding.UTF8.GetByteCount(_fixture.HelloWorldContent), obj.Size.Value);
        }

        // See-also: CopyObject
        // Member: CopyObjectAsync
        // See [CopyObject](ref) for a synchronous example.
        // End see-also

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

            // Snippet: GetBucket
            var client = StorageClient.Create();

            var bucket = client.GetBucket(bucketName);
            Console.WriteLine($"Name: {bucket.Name}");
            Console.WriteLine($"TimeCreated: {bucket.TimeCreated}");
            // End snippet
        }

        // See-also: GetBucket
        // Member: GetBucketAsync
        // See [GetBucket](ref) for a synchronous example.
        // End see-also

        // TODO: Flag to delete all versions of an object?

        [Fact]
        public void DeleteObject()
        {
            // create a temp object to delete in the test
            var bucketName = _fixture.BucketName;
            var tempObjectName = "places/deleteme.txt";
            StorageClient.Create().UploadObject(bucketName, tempObjectName, "", Stream.Null);

            // Snippet: DeleteObject(string,string,*)
            var client = StorageClient.Create();
            var objectName = "places/deleteme.txt";

            client.DeleteObject(bucketName, objectName);
            // End snippet

            // want to show the name in the snippet, but also
            // want to make sure it matches the one in the test
            Assert.Equal(objectName, tempObjectName);

            Assert.DoesNotContain(client.ListObjects(bucketName, ""), o => o.Name == objectName);
        }

        // See-also: DeleteObject(string,string,*)
        // Member: DeleteObject(Object,*)
        // See [DeleteObject](ref) for an example using an alternative overload.
        // End see-also

        // See-also: DeleteObject(string,string,*)
        // Member: DeleteObjectAsync(Object,*,*)
        // Member: DeleteObjectAsync(string,string,*,*)
        // See [DeleteObject](ref) for a synchronous example.
        // End see-also


        [Fact]
        public void DeleteBucket()
        {
            var bucketName = Guid.NewGuid().ToString();
            StorageClient.Create().CreateBucket(_fixture.ProjectId, bucketName);

            // Snippet: DeleteBucket(string,*)
            var client = StorageClient.Create();

            client.DeleteBucket(bucketName);
            // End snippet

            Assert.DoesNotContain(client.ListBuckets(_fixture.ProjectId), b => b.Name == bucketName);
        }

        // See-also: DeleteBucket(string,*)
        // Member: DeleteBucket(Bucket,*)
        // See [DeleteBucket](ref) for an example using an alternative overload.
        // End see-also

        // See-also: DeleteBucket(string,*)
        // Member: DeleteBucketAsync(Bucket,*,*)
        // Member: DeleteBucketAsync(string,*,*)
        // See [DeleteBucket](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void GetBucketIamPolicy()
        {
            var bucketName = _fixture.BucketName;
            // Snippet: GetBucketIamPolicy(string,*)
            StorageClient client = StorageClient.Create();

            Policy policy = client.GetBucketIamPolicy(bucketName);
            foreach (Policy.BindingsData binding in policy.Bindings)
            {
                Console.WriteLine($"Role: {binding.Role}");
                foreach (var permission in binding.Members)
                {
                    Console.WriteLine($"  {permission}");
                }
            }
            // End snippet
        }

        // See-also: GetBucketIamPolicy(string,*)
        // Member: GetBucketIamPolicyAsync(string,*,*)
        // See [GetBucketIamPolicy](ref) for a synchronous example.
        // End see-also

        [Fact]
        public async Task SetBucketIamPolicy()
        {
            var projectId = _fixture.ProjectId;
            var bucketName = Guid.NewGuid().ToString();
            _fixture.RegisterBucketToDelete(bucketName);

            // Snippet: SetBucketIamPolicy(string, *, *)
            // Create a new bucket and an empty file within it
            StorageClient client = StorageClient.Create();
            Bucket bucket = client.CreateBucket(projectId, bucketName);
            var obj = client.UploadObject(bucketName, "empty.txt", "text/plain", new MemoryStream());

            // Demonstrate that without authentication, we can't download the object
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response1 = await httpClient.GetAsync(obj.MediaLink);
            Console.WriteLine($"Response code before setting policy: {response1.StatusCode}");

            // Fetch the current IAM policy, and modify it in memory to allow all users
            // to view objects.
            Policy policy = client.GetBucketIamPolicy(bucketName);
            string role = "roles/storage.objectViewer";
            Policy.BindingsData binding = policy.Bindings
                .Where(b => b.Role == role)
                .FirstOrDefault();
            if (binding == null)
            {
                binding = new Policy.BindingsData { Role = role, Members = new List<string>() };
                policy.Bindings.Add(binding);
            }
            binding.Members.Add("allUsers");

            // Update the IAM policy on the bucket.
            client.SetBucketIamPolicy(bucketName, policy);

            // Download the object again: this time the response should be OK
            HttpResponseMessage response2 = await httpClient.GetAsync(obj.MediaLink);
            Console.WriteLine($"Response code after setting policy: {response2.StatusCode}");

            // End snippet

            Assert.Equal(HttpStatusCode.Unauthorized, response1.StatusCode);
            Assert.Equal(HttpStatusCode.OK, response2.StatusCode);
        }

        // See-also: SetBucketIamPolicy(string, *, *)
        // Member: SetBucketIamPolicyAsync(string,*,*,*)
        // See [SetBucketIamPolicy](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void TestBucketIamPermissions()
        {
            var bucketName = _fixture.BucketName;
            // Snippet: TestBucketIamPermissions(string,*,*)
            StorageClient client = StorageClient.Create();
            
            IList<string> permissions = client.TestBucketIamPermissions(bucketName,
                new[] { "storage.buckets.get", "storage.objects.list" });
            Console.WriteLine("Permissions held:");
            foreach (string permission in permissions)
            {
                Console.WriteLine($"  {permission}");
            }
            // End snippet
        }

        // See-also: TestBucketIamPermissions(string,*,*)
        // Member: TestBucketIamPermissionsAsync(string,*,*,*)
        // See [TestBucketIamPermissions](ref) for a synchronous example.
        // End see-also
    }
}
