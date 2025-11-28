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
using Google.Cloud.ClientTesting;
using Google.Cloud.Iam.V1;
using Google.Cloud.PubSub.V1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Encoding = System.Text.Encoding;
using Policy = Google.Apis.Storage.v1.Data.Policy;

namespace Google.Cloud.Storage.V1.Snippets
{
    [SnippetOutputCollector]
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

            // Create a bucket with a globally unique name
            var bucketName = Guid.NewGuid().ToString();
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

            StorageSnippetFixture.SleepAfterBucketCreateDelete();

            _fixture.RegisterLocalFileToDelete("file1.txt");
            _fixture.RegisterBucketToDelete(bucketName);
            StorageSnippetFixture.SleepAfterBucketCreateDelete();

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
            StorageSnippetFixture.SleepAfterBucketCreateDelete();

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
            var bucketName = IdGenerator.FromGuid();
            setupClient.CreateBucket(projectId, bucketName);
            StorageSnippetFixture.SleepAfterBucketCreateDelete();
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
            var bucketName = IdGenerator.FromGuid();
            setupClient.CreateBucket(projectId, bucketName);
            StorageSnippetFixture.SleepAfterBucketCreateDelete();
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

                var obj = client.UploadObject(bucketName, destination, contentType, stream, progress: progress);
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
            var uploadUri = await client.InitiateUploadSessionAsync(bucketName, destination, contentType, contentLength: null, options);

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
            Console.WriteLine($"TimeCreated: {obj.TimeCreatedDateTimeOffset}");
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
            var destinationBucket = IdGenerator.FromGuid();
            StorageClient.Create().CreateBucket(projectId, destinationBucket);
            StorageSnippetFixture.SleepAfterBucketCreateDelete();
            _fixture.RegisterBucketToDelete(destinationBucket);

            // Snippet: CopyObject
            StorageClient client = StorageClient.Create();
            string sourceName = "greetings/hello.txt";
            string destinationName = "copy.txt";

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
            Console.WriteLine($"TimeCreated: {bucket.TimeCreatedDateTimeOffset}");
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
            var bucketName = IdGenerator.FromGuid();
            StorageClient.Create().CreateBucket(_fixture.ProjectId, bucketName);
            StorageSnippetFixture.SleepAfterBucketCreateDelete();

            // Snippet: DeleteBucket(string,*)
            var client = StorageClient.Create();

            client.DeleteBucket(bucketName);
            // End snippet

            StorageSnippetFixture.SleepAfterBucketCreateDelete();

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
            var bucketName = IdGenerator.FromGuid();
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
            // of a certain domain to view objects.
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
            binding.Members.Add("domain:google.com");

            // Update the IAM policy on the bucket.
            client.SetBucketIamPolicy(bucketName, policy);

            // Wait 10 seconds to allow the policy to be applied.
            // (Normally the policy change is visible pretty much immediately, but
            // 10 seconds makes this very reliable.)
            await Task.Delay(TimeSpan.FromSeconds(10));

            // Download the object again: this time the response should be OK
            HttpResponseMessage response2 = await httpClient.GetAsync(obj.MediaLink);
            Console.WriteLine($"Response code after setting policy: {response2.StatusCode}");

            // End snippet

            StorageSnippetFixture.SleepAfterBucketCreateDelete();
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

        [Fact]
        public void SetBucketLabel()
        {
            var bucketName = _fixture.BucketName;
            // Snippet: SetBucketLabel(string, string, string, *)
            StorageClient client = StorageClient.Create();

            string now = DateTime.UtcNow.ToString("yyyy-MM-dd_HH-mm-ss", CultureInfo.InvariantCulture);
            string newValue = "new_value_" + now;
            string oldValue = client.SetBucketLabel(bucketName, "label", newValue);
            Console.WriteLine($"Old value: {oldValue}");
            // Verify the label is now correct...
            Bucket bucket = client.GetBucket(bucketName);
            string fetchedValue = bucket.Labels?["label"];
            Console.WriteLine($"Fetched value: {fetchedValue}");
            // End snippet

            Assert.Equal(newValue, fetchedValue);
        }

        // See-also: SetBucketLabel(string, string, string, *)
        // Member: SetBucketLabelAsync(string, string, string, *, *)
        // See [SetBucketLabel](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void RemoveBucketLabel()
        {
            var bucketName = _fixture.BucketName;
            // Snippet: RemoveBucketLabel(string, string, *)
            StorageClient client = StorageClient.Create();

            string oldValue = client.RemoveBucketLabel(bucketName, "label");
            Console.WriteLine($"Old value: {oldValue}");
            // Verify the label is now gone...
            Bucket bucket = client.GetBucket(bucketName);
            string fetchedValue = null;
            bucket.Labels?.TryGetValue("label", out fetchedValue);
            Console.WriteLine($"Fetched value: {fetchedValue}");
            // End snippet

            Assert.Null(fetchedValue);
        }

        // See-also: RemoveBucketLabel(string, string, *)
        // Member: RemoveBucketLabelAsync(string, string, *, *)
        // See [RemoveBucketLabel](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void ClearBucketLabels()
        {
            var bucketName = _fixture.BucketName;
            // Snippet: ClearBucketLabels(string, *)
            StorageClient client = StorageClient.Create();

            IDictionary<string, string> oldLabels = client.ClearBucketLabels(bucketName);
            Console.WriteLine($"Number of labels before clearing: {oldLabels.Count}");
            // End snippet

            Assert.Null(client.GetBucket(bucketName).Labels);
        }

        // See-also: ClearBucketLabels(string, *)
        // Member: ClearBucketLabelsAsync(string, *, *)
        // See [ClearBucketLabels](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void ModifyBucketLabels()
        {
            var bucketName = _fixture.BucketName;

            // Snippet: ModifyBucketLabels(string, *, *)
            StorageClient client = StorageClient.Create();

            string now = DateTime.UtcNow.ToString("yyyy-MM-dd_HH-mm-ss", CultureInfo.InvariantCulture);
            IDictionary<string, string> labelChanges = new Dictionary<string, string>
            {
                { "label1", "new_value_1_" + now },
                { "label2", "new_value_2_" + now },
            };

            IDictionary<string, string> oldValues = client.ModifyBucketLabels(bucketName, labelChanges);
            Console.WriteLine("Old values for changed labels:");
            foreach (KeyValuePair<string, string> entry in oldValues)
            {
                Console.WriteLine($"  {entry.Key}: {entry.Value}");
            }
            Console.WriteLine("All labels:");
            IDictionary<string, string> allLabels = client.GetBucket(bucketName).Labels ?? new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> entry in allLabels)
            {
                Console.WriteLine($"  {entry.Key}: {entry.Value}");
            }
            // End snippet
        }

        // See-also: ModifyBucketLabels(string, *, *)
        // Member: ModifyBucketLabelsAsync(string, *, *, *)
        // See [ModifyBucketLabels](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void GetStorageServiceAccountEmail()
        {
            var projectId = _fixture.ProjectId;

            // Snippet: GetStorageServiceAccountEmail(string, *)
            StorageClient client = StorageClient.Create();
            string serviceAccountEmail = client.GetStorageServiceAccountEmail(projectId);
            Console.WriteLine(serviceAccountEmail);
            // End snippet
        }

        // See-also: GetStorageServiceAccountEmail(string, *)
        // Member: GetStorageServiceAccountEmailAsync(string, *, *)
        // See [GetStorageServiceAccountEmail](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void GetNotification()
        {
            var projectId = _fixture.ProjectId;

            string bucket = _fixture.BucketName;
            var created = _fixture.CreateNotification("prefix1");
            string notificationId = created.Id;

            // Snippet: GetNotification(string, string, *)
            StorageClient client = StorageClient.Create();
            Notification notification = client.GetNotification(bucket, notificationId);
            Console.WriteLine($"ID: {notification.Id}");
            Console.WriteLine($"Payload format: {notification.PayloadFormat}");
            Console.WriteLine($"Topic: {notification.Topic}");
            Console.WriteLine($"Prefix: {notification.ObjectNamePrefix}");
            Console.WriteLine($"Event types: {string.Join(",", notification.EventTypes ?? new string[0])}");
            // End snippet
        }

        // See-also: GetNotification(string, string, *)
        // Member: GetNotificationAsync(string, string, *, *)
        // See [GetNotification](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void CreateNotification()
        {
            var projectId = _fixture.ProjectId;

            string bucket = _fixture.BucketName;
            // This creates the topic, which is most of the work...
            var created = _fixture.CreateNotification("prefix2");
            var topicId = created.Topic.Split('/').Last();

            // Snippet: CreateNotification(string, Notification, *)
            TopicName topicName = new TopicName(projectId, topicId);
            StorageClient client = StorageClient.Create();
            Notification notification = new Notification
            {
                Topic = $"//pubsub.googleapis.com/{topicName}",
                PayloadFormat = "JSON_API_V1"
            };
            notification = client.CreateNotification(bucket, notification);
            Console.WriteLine($"Created notification ID: {notification.Id}");
            // End snippet
        }

        // See-also: CreateNotification(string, Notification, *)
        // Member: CreateNotificationAsync(string, Notification, *, *)
        // See [CreateNotification](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void DeleteNotification()
        {
            var projectId = _fixture.ProjectId;

            string bucket = _fixture.BucketName;
            var notificationId = _fixture.CreateNotification("prefix3").Id;

            // Snippet: DeleteNotification(string, string, *)
            StorageClient client = StorageClient.Create();
            client.DeleteNotification(bucket, notificationId);
            // End snippet
        }

        // See-also: DeleteNotification(string, string, *)
        // Member: DeleteNotificationAsync(string, string, *, *)
        // See [DeleteNotification](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void ListNotifications()
        {
            var projectId = _fixture.ProjectId;

            string bucket = _fixture.BucketName;

            // Snippet: ListNotifications(string, *)
            StorageClient client = StorageClient.Create();
            IReadOnlyList<Notification> notifications = client.ListNotifications(bucket);
            foreach (Notification notification in notifications)
            {
                Console.WriteLine($"{notification.Id}: Topic={notification.Topic}; Prefix={notification.ObjectNamePrefix}");
            }
            // End snippet
        }

        // See-also: ListNotifications(string, *)
        // Member: ListNotificationsAsync(string, *, *)
        // See [ListNotifications](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void NotificationsOverview()
        {
            string projectId = _fixture.ProjectId;
            string bucket = _fixture.BucketName;
            string topicId = IdGenerator.FromGuid(prefix: "topic-");

            // Sample: NotificationsOverview
            // First create a Pub/Sub topic.
            PublisherServiceApiClient publisherClient = PublisherServiceApiClient.Create();
            TopicName topicName = new TopicName(projectId, topicId);
            publisherClient.CreateTopic(topicName);

            // Prepare the topic for Storage notifications. The Storage Service Account must have Publish permission
            // for the topic. The code below adds the service account into the "roles/pubsub.publisher" role for the topic.

            // Determine the Storage Service Account name to use in IAM operations.
            StorageClient storageClient = StorageClient.Create();
            string storageServiceAccount = $"serviceAccount:{storageClient.GetStorageServiceAccountEmail(projectId)}";

            // Fetch the IAM policy for the topic.
            GetIamPolicyRequest getPolicyRequest = new GetIamPolicyRequest { ResourceAsResourceName = topicName };
            Iam.V1.Policy policy = publisherClient.IAMPolicyClient.GetIamPolicy(getPolicyRequest);
            var role = "roles/pubsub.publisher";

            // Ensure the Storage Service Account is in the publisher role, setting the IAM policy for the topic
            // on the server if necessary.
            if (policy.AddRoleMember(role, storageServiceAccount))
            {
                SetIamPolicyRequest setPolicyRequest = new SetIamPolicyRequest
                {
                    ResourceAsResourceName = topicName,
                    Policy = policy
                };
                publisherClient.IAMPolicyClient.SetIamPolicy(setPolicyRequest);
            }

            // Now that the topic is ready, we can create a notification configuration for Storage
            Notification notification = new Notification
            {
                Topic = $"//pubsub.googleapis.com/{topicName}",
                PayloadFormat = "JSON_API_V1"
            };
            notification = storageClient.CreateNotification(bucket, notification);
            Console.WriteLine($"Created notification ID: {notification.Id}");

            // End sample

            _fixture.RegisterTopicToDelete(topicName);
        }

        [Fact]
        public void LockBucketRetentionPolicy()
        {
            var projectId = _fixture.ProjectId;

            // Snippet: LockBucketRetentionPolicy(string, long, *)
            var client = StorageClient.Create();
            var bucketName = Guid.NewGuid().ToString();

            // Create a bucket and set its retention policy
            Bucket bucket = client.CreateBucket(projectId, bucketName);
            // Retention period is specified in seconds.
            bucket.RetentionPolicy = new Bucket.RetentionPolicyData { RetentionPeriod = 60 };
            bucket = client.UpdateBucket(bucket);

            // Once the retention policy is locked, it can't be shortened, removed or unlocked.
            // It will be locked until the bucket is deleted.
            client.LockBucketRetentionPolicy(bucketName, bucket.Metageneration.Value);
            // End snippet

            _fixture.RegisterBucketToDelete(bucketName);
            StorageSnippetFixture.SleepAfterBucketCreateDelete();
        }

        // See-also: LockBucketRetentionPolicy(string, long, *)
        // Member: LockBucketRetentionPolicyAsync(string, long, *, *)
        // See [LockBucketRetentionPolicy](ref) for a synchronous example.
        // End see-also
    }
}
