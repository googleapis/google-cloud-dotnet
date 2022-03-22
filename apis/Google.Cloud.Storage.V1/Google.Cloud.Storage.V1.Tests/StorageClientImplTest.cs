// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Requests;
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using Google.Apis.Util;
using System;
using System.Linq;
using System.Net;
using Xunit;
using static Google.Apis.Storage.v1.ProjectsResource;
using static Google.Cloud.Storage.V1.EncryptionKey; // For None and Generate()
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.Tests
{
    public class StorageClientImplTest
    {
        private static readonly EncryptionKey EncryptionKey1 = Generate();
        private static readonly EncryptionKey EncryptionKey2 = Generate();

        // Between this and GetEffectiveEncryptionKey_Invalid we should have all 12 combinations of:
        // - Client encryption key: None or EncryptionKey1
        // - Operation encryption key: null, None, EncryptionKey2
        // - KMS key: null or "key"
        public static TheoryData<EncryptionKey, EncryptionKey, string, EncryptionKey> GetEffectiveEncryptionKey_Valid_Data =>
            new TheoryData<EncryptionKey, EncryptionKey, string, EncryptionKey>
            {
                { None, null, null, None },
                { None, null, "key", None },
                { None, None, null, None },
                { None, None, "key", None },
                { None, EncryptionKey2, null, EncryptionKey2 },
                { EncryptionKey1, null, null, EncryptionKey1 },
                { EncryptionKey1, None, null, None },
                { EncryptionKey1, None, "key", None },
                { EncryptionKey1, EncryptionKey2, null, EncryptionKey2 },
            };

        [Theory, MemberData(nameof(GetEffectiveEncryptionKey_Valid_Data))]
        public void GetEffectiveEncryptionKey_Valid(EncryptionKey clientkey, EncryptionKey operationKey, string kmsKey, EncryptionKey expected)
        {
            var service = new StorageService();
            var client = new StorageClientImpl(service, clientkey);
            var actual = client.GetEffectiveEncryptionKey(operationKey, kmsKey);
            Assert.Same(expected, actual);
        }

        public static TheoryData<EncryptionKey, EncryptionKey, string, string> GetEffectiveEncryptionKey_Invalid_Data =>
            new TheoryData<EncryptionKey, EncryptionKey, string, string>
            {
                // The final string is expected to be a substring in the exception message.
                // This is brittle, but makes sure we give the right message.
                { None, EncryptionKey2, "key", "Can't specify both" },
                { EncryptionKey1, null, "key", "default" },
                { EncryptionKey1, EncryptionKey2, "key", "Can't specify both" }
            };

        [Theory, MemberData(nameof(GetEffectiveEncryptionKey_Invalid_Data))]
        public void GetEffectiveEncryptionKey_Invalid(EncryptionKey clientkey, EncryptionKey operationKey, string kmsKey, string expectedMessageSubstring)
        {
            var service = new StorageService();
            var client = new StorageClientImpl(service, clientkey);
            var exception = Assert.Throws<ArgumentException>(() => client.GetEffectiveEncryptionKey(operationKey, kmsKey));
            Assert.Contains(expectedMessageSubstring, exception.Message);
        }

        // Tests for GCS Retry :
        // - No retry applied
        // - Retry then success (sometimes with conditions)
        // - Retry with eventual failure


        private static void NoRetryHelper<T>(
            Func<StorageService, ClientServiceRequest<T>> requestProvider,
            Action<StorageClient> clientAction,
            HttpStatusCode statusCode = HttpStatusCode.NotFound)
        {
            var service = new FakeStorageService();
            var client = new StorageClientImpl(service);

            service.ExpectRequest(requestProvider(service), statusCode);
            Assert.Throws<GoogleApiException>(() => clientAction(client));
            service.Verify();
        }

        private static void RetryOnce<T>(Func<StorageService, ClientServiceRequest<T>> requestProvider, Action<StorageClient> clientAction, T response, 
            HttpStatusCode firstStatusCode = HttpStatusCode.BadGateway)
        {
            var service = new FakeStorageService();
            var client = new StorageClientImpl(service);
            var request = requestProvider(service);

            service.ExpectRequest(request, firstStatusCode);
            service.ExpectRequest(request, response);
            clientAction(client);
            service.Verify();
        }

        private static void RetryOnceHelper<T>(Func<StorageService, ClientServiceRequest<T>> requestProvider, Action<StorageClient> clientAction,
           HttpStatusCode firstStatusCode = HttpStatusCode.BadGateway)
           where T : new() => RetryOnce(requestProvider, clientAction, new T(), firstStatusCode);

        private static void RetryThenFail<T>(Func<StorageService, ClientServiceRequest<T>> requestProvider, Action<StorageClient> clientAction, T response, 
            HttpStatusCode errorCode = HttpStatusCode.BadGateway, int retryCount = 3)
        {
            var service = new FakeStorageService();
            var client = new StorageClientImpl(service);
            var request = requestProvider(service);

            for (int i = 1; i <= retryCount; i++)
            {
                service.ExpectRequest(request, errorCode);
            }
            Assert.Throws<GoogleApiException>(() => clientAction(client));
            service.Verify();
        }

        private static void RetryThenFailHelper<T>(Func<StorageService, ClientServiceRequest<T>> requestProvider, Action<StorageClient> clientAction,
            HttpStatusCode errorCode = HttpStatusCode.BadGateway, int retryCount = 3)
            where T : new() => RetryThenFail(requestProvider, clientAction, new T(), errorCode, retryCount);

        // Bucket test cases BEGIN

        [Fact]
        public void GetBucket_NoRetry() =>
            NoRetryHelper(service => service.Buckets.Get("bucket"), client => client.GetBucket("bucket"));

        [Fact]
        public void GetBucket_RetryOnce() =>
            RetryOnceHelper(service => service.Buckets.Get("bucket"), client => client.GetBucket("bucket"));

        [Fact]
        public void GetBucket_RetryThenFail() =>
            RetryThenFailHelper(service => service.Buckets.Get("bucket"), client => client.GetBucket("bucket"));

        [Fact]
        public void DeleteBucket_NoRetry() =>
            NoRetryHelper(service => service.Buckets.Delete("bucket"), client => client.DeleteBucket("bucket"));

        [Fact]
        public void DeleteBucket_RetryOnce() =>
            RetryOnce(service => service.Buckets.Delete("bucket"), client => client.DeleteBucket("bucket"), "check");

        [Fact]
        public void DeleteBucket_RetryThenFail() =>
            RetryThenFail(service => service.Buckets.Delete("bucket"), client => client.DeleteBucket("bucket"), "check");

        [Fact]
        public void ListBucket_NoRetry() =>
            NoRetryHelper(service => new BucketsResource.ListRequest(service, "project"), client => client.ListBuckets("project").Count());

        [Fact]
        public void ListBucket_RetryOnce() =>
            RetryOnceHelper(service => service.Buckets.List("project"), client => client.ListBuckets("project").Count());

        [Fact]
        public void ListBucket_RetryThenFail() =>
            RetryThenFailHelper(service => service.Buckets.List("project"), client => client.ListBuckets("project").Count());

        [Fact]
        public void InsertBucket_RetryOnce() =>
            RetryOnceHelper(service => service.Buckets.Insert(new Bucket { Name = "bucket" }, "project"), client => client.CreateBucket("project", "bucket"));

        [Fact]
        public void InsertBucket_RetryThenFail() =>
            RetryThenFailHelper(service => service.Buckets.Insert(new Bucket { Name = "bucket" }, "project"), client => client.CreateBucket("project", "bucket"));

        [Fact]
        public void InsertBucket_NoRetry() =>
            NoRetryHelper(service => service.Buckets.Insert(new Bucket { Name = "bucket" }, "project"), client => client.CreateBucket("project", "bucket"));

        [Fact]
        public void UpdateBucket_WithMetageneration_RetryOnce() =>
            RetryOnceHelper(service => new BucketsResource.UpdateRequest(service, new Bucket { Name = "bucket" }, "bucket") { IfMetagenerationMatch = 70 }, 
                client => client.UpdateBucket(new Bucket { Name = "bucket" }, new UpdateBucketOptions() { IfMetagenerationMatch = 70 }));

        [Fact]
        public void UpdateBucket_withoutMetgeneration_NoRetry() =>
            NoRetryHelper(service => new BucketsResource.UpdateRequest(service, new Bucket { Name = "bucket" }, "bucket") { IfMetagenerationMatch = 70 }, 
                client => client.UpdateBucket(new Bucket { Name = "bucket" }, new UpdateBucketOptions() { IfMetagenerationMatch = 70 }));

        [Fact]
        public void UpdateBucket_RetryThenFail() =>
            RetryThenFailHelper(service => new BucketsResource.UpdateRequest(service, new Bucket { Name = "bucket" }, "bucket") { IfMetagenerationMatch = 70 }, 
                client => client.UpdateBucket(new Bucket { Name = "bucket" }, new UpdateBucketOptions() { IfMetagenerationMatch = 70 }));

        [Fact]
        public void PatchBucket_WithMetageneration_RetryOnce() =>
            RetryOnceHelper(service => new BucketsResource.PatchRequest(service, new Bucket { Name = "bucket" }, "bucket") { IfMetagenerationMatch = 70 }, 
                client => client.PatchBucket(new Bucket { Name = "bucket" }, new PatchBucketOptions() { IfMetagenerationMatch = 70 }));

        [Fact]
        public void PatchBucket_withoutMetgeneration_NoRetry() =>
            NoRetryHelper(service => new BucketsResource.PatchRequest(service, new Bucket { Name = "bucket" }, "bucket") { IfMetagenerationMatch = 70 }, 
                client => client.PatchBucket(new Bucket { Name = "bucket" }, new PatchBucketOptions() { IfMetagenerationMatch = 70 }));

        [Fact]
        public void PatchBucket_RetryThenFail() =>
            RetryThenFailHelper(service => new BucketsResource.PatchRequest(service, new Bucket { Name = "bucket" }, "bucket") { IfMetagenerationMatch = 70 }, 
                client => client.PatchBucket(new Bucket { Name = "bucket" }, new PatchBucketOptions() { IfMetagenerationMatch = 70 }));

        // Bucket test cases END

        // IAM test cases BEGIN

        [Fact]
        public void GetBucketIamPolicy_NoRetry() =>
            NoRetryHelper(service => service.Buckets.GetIamPolicy("bucket"), client => client.GetBucketIamPolicy("bucket"));

        [Fact]
        public void GetBucketIamPolicy_RetryOnce() =>
            RetryOnceHelper(service => service.Buckets.GetIamPolicy("bucket"), client => client.GetBucketIamPolicy("bucket"));

        [Fact]
        public void GetBucketIamPolicy_RetryThenFail() =>
            RetryThenFailHelper(service => service.Buckets.GetIamPolicy("bucket"), client => client.GetBucketIamPolicy("bucket"));

        [Fact]
        public void SetBucketIamPolicy_NoRetry() =>
           NoRetryHelper(service => service.Buckets.SetIamPolicy(new Policy(), "bucket"), client => client.SetBucketIamPolicy("bucket", new Policy()));

        [Fact]
        public void SetBucketIamPolicy_RetryOnce() =>
            RetryOnceHelper(service => service.Buckets.SetIamPolicy(new Policy(), "bucket"), client => client.SetBucketIamPolicy("bucket", new Policy()));

        [Fact]
        public void SetBucketIamPolicy_RetryThenFail() =>
            RetryThenFailHelper(service => service.Buckets.SetIamPolicy(new Policy(), "bucket"), client => client.SetBucketIamPolicy("bucket", new Policy()));

        [Fact]
        public void TestBucketIamPolicy_NoRetry() =>
            NoRetryHelper(service => service.Buckets.TestIamPermissions("bucket", new Repeatable<string>(new[] { "permission" })), 
                client => client.TestBucketIamPermissions("bucket", new Repeatable<string>(new[] { "permission" })));

        [Fact]
        public void TestBucketIamPolicy_RetryOnce() =>
            RetryOnceHelper(service => service.Buckets.TestIamPermissions("bucket", new Repeatable<string>(new[] { "permission" })), 
                client => client.TestBucketIamPermissions("bucket", new Repeatable<string>(new[] { "permission" })));

        [Fact]
        public void TestBucketIamPolicy_RetryThenFail() =>
            RetryThenFailHelper(service => service.Buckets.TestIamPermissions("bucket", new Repeatable<string>(new[] { "permission" })), 
                client => client.TestBucketIamPermissions("bucket", new Repeatable<string>(new[] { "permission" })));

        [Fact]
        public void LockRetentionPolicy_NoRetry() =>
            NoRetryHelper(service => service.Buckets.LockRetentionPolicy("bucket", 70), client => client.LockBucketRetentionPolicy("bucket", 70));

        [Fact]
        public void LockRetentionPolicy_RetryOnce() =>
            RetryOnceHelper(service => service.Buckets.LockRetentionPolicy("bucket", 70), client => client.LockBucketRetentionPolicy("bucket", 70));

        [Fact]
        public void LockRetentionPolicy_RetryThenFail() =>
            RetryThenFailHelper(service => service.Buckets.LockRetentionPolicy("bucket", 70), client => client.LockBucketRetentionPolicy("bucket", 70));

        // IAM test cases END

        // Object test cases BEGIN

        [Fact]
        public void GetObject_NoRetry() =>
            NoRetryHelper(service => service.Objects.Get("bucket", "object"), client => client.GetObject("bucket", "object"));

        [Fact]
        public void GetObject_RetryOnce() =>
            RetryOnceHelper(service => service.Objects.Get("bucket", "object"), client => client.GetObject("bucket", "object"));

        [Fact]
        public void GetObject_RetryThenFail() =>
            RetryThenFailHelper(service => service.Objects.Get("bucket", "object"), client => client.GetObject("bucket", "object"));

        [Fact]
        public void CopyObject_NoRetry() =>
            NoRetryHelper(service => service.Objects.Rewrite(new Object(), "sourceBucket", "sourceObject", "destinationBucket", "destinationObject"), client => client.CopyObject("sourceBucket", "sourceObject", "destinationBucket", "destinationObject"));

        [Fact]
        public void CopyObject_RetryOnce() =>
            RetryOnceHelper(service => new ObjectsResource.RewriteRequest(service, new Object(), "sourceBucket", "sourceObject", "destinationBucket", "destinationObject") { IfGenerationMatch = 70 }, 
                client => client.CopyObject("sourceBucket", "sourceObject", "destinationBucket", "destinationObject", new CopyObjectOptions() { IfGenerationMatch = 70 }));

        [Fact]
        public void CopyObject_RetryThenFail() =>
            RetryThenFailHelper(service => new ObjectsResource.RewriteRequest(service, new Object(), "sourceBucket", "sourceObject", "destinationBucket", "destinationObject") { IfGenerationMatch = 70 }, 
                client => client.CopyObject("sourceBucket", "sourceObject", "destinationBucket", "destinationObject", new CopyObjectOptions() { IfGenerationMatch = 70 }));

        [Fact]
        public void ListObject_NoRetry() =>
            NoRetryHelper(service => service.Objects.List("bucket"), client => client.ListObjects("bucket").Count());

        [Fact]
        public void ListObject_RetryOnce() =>
            RetryOnceHelper(service => service.Objects.List("bucket"), client => client.ListObjects("bucket").Count());

        [Fact]
        public void ListObject_RetryThenFail() =>
            RetryThenFailHelper(service => service.Objects.List("bucket"), client => client.ListObjects("bucket").Count());

        [Fact]
        public void DeleteObject_NoRetry() =>
            NoRetryHelper(service => service.Objects.Delete("bucket", "objectName"), client => client.DeleteObject("bucket", "objectName"));

        [Fact]
        public void DeleteObject_RetryOnce() =>
            RetryOnce(service => new ObjectsResource.DeleteRequest(service, "bucket", "objectName") { Generation = 70 }, 
                client => client.DeleteObject("bucket", "objectName", new DeleteObjectOptions { Generation = 70 }), "check");

        [Fact]
        public void DeleteObject_RetryThenFail() =>
            RetryThenFail(service => new ObjectsResource.DeleteRequest(service, "bucket", "objectName") { Generation = 70 }, 
                client => client.DeleteObject("bucket", "objectName", new DeleteObjectOptions { Generation = 70 }), "check");

        [Fact]
        public void UpdateObject_WithMetageneration_RetryOnce() =>
           RetryOnceHelper(
               service => new ObjectsResource.UpdateRequest(service, new Object { Bucket = "bucket", Name = "object" }, "bucket", "object") { IfMetagenerationMatch = 70 },
               client => client.UpdateObject(new Object { Bucket = "bucket", Name = "object" }, new UpdateObjectOptions { IfMetagenerationMatch = 70 }));

        [Fact]
        public void UpdateObject_WithoutMetageneration_NoRetry() =>
            NoRetryHelper(
                service => new ObjectsResource.UpdateRequest(service, new Object { Bucket = "bucket", Name = "object" }, "bucket", "object"),
                client => client.UpdateObject(new Object { Bucket = "bucket", Name = "object" }, new UpdateObjectOptions()));

        [Fact]
        public void UpdateObject_WithoutOptions_NoRetry() =>
            NoRetryHelper(
                service => new ObjectsResource.UpdateRequest(service, new Object { Bucket = "bucket", Name = "object" }, "bucket", "object"),
                client => client.UpdateObject(new Object { Bucket = "bucket", Name = "object" }));

        [Fact]
        public void UpdateObject_RetryThenFail() =>
            RetryThenFailHelper(service => new ObjectsResource.UpdateRequest(service, new Object { Bucket = "bucket", Name = "object" }, "bucket", "object") { IfMetagenerationMatch = 70 },
                client => client.UpdateObject(new Object { Bucket = "bucket", Name = "object" }, new UpdateObjectOptions { IfMetagenerationMatch = 70 }));

        [Fact]
        public void PatchObject_WithMetageneration_RetryOnce() =>
            RetryOnceHelper(
              service => new ObjectsResource.PatchRequest(service, new Object { Bucket = "bucket", Name = "object" }, "bucket", "object") { IfMetagenerationMatch = 70 },
              client => client.PatchObject(new Object { Bucket = "bucket", Name = "object" }, new PatchObjectOptions { IfMetagenerationMatch = 70 }));

        [Fact]
        public void PatchObject_WithoutMetageneration_NoRetry() =>
            NoRetryHelper(
               service => new ObjectsResource.PatchRequest(service, new Object { Bucket = "bucket", Name = "object" }, "bucket", "object"),
               client => client.PatchObject(new Object { Bucket = "bucket", Name = "object" }, new PatchObjectOptions()));

        [Fact]
        public void PatchObject_RetryThenFail() =>
            RetryThenFailHelper(service => new ObjectsResource.PatchRequest(service, new Object { Bucket = "bucket", Name = "object" }, "bucket", "object") { IfMetagenerationMatch = 70 },
        client => client.PatchObject(new Object { Bucket = "bucket", Name = "object" }, new PatchObjectOptions { IfMetagenerationMatch = 70 }));

        // Object test cases END

        [Fact]
        public void GetStorageServiceAccountEmail_NoRetry() =>
            NoRetryHelper(service => new ServiceAccountResource.GetRequest(service, "project"), client => client.GetStorageServiceAccountEmail("project"));

        [Fact]
        public void GetStorageServiceAccountEmail_RetryOnce() =>
            RetryOnceHelper(service => new ServiceAccountResource.GetRequest(service, "project"), client => client.GetStorageServiceAccountEmail("project"));

        [Fact]
        public void GetStorageServiceAccountEmail_RetryThenFail() =>
            RetryThenFailHelper(service => new ServiceAccountResource.GetRequest(service, "project"), client => client.GetStorageServiceAccountEmail("project"));

        // HMAC Key test cases START

        [Fact]
        public void GetHmacKey_NoRetry() =>
            NoRetryHelper(service => service.Projects.HmacKeys.Get("project", "access"), client => client.GetHmacKey("project", "access"));

        [Fact]
        public void GetHmacKey_RetryOnce() =>
            RetryOnceHelper(service => service.Projects.HmacKeys.Get("project", "access"), client => client.GetHmacKey("project", "access"));

        [Fact]
        public void GetHmacKey_RetryThenFail() =>
            RetryThenFailHelper(service => service.Projects.HmacKeys.Get("project", "access"), client => client.GetHmacKey("project", "access"));

        [Fact]
        public void ListHmacKey_NoRetry() =>
            NoRetryHelper(service => service.Projects.HmacKeys.List("project"), client => client.ListHmacKeys("project").Count());

        [Fact]
        public void ListHmacKey_RetryOnce() =>
            RetryOnceHelper(service => service.Projects.HmacKeys.List("project"), client => client.ListHmacKeys("project").Count());

        [Fact]
        public void ListHmacKey_RetryThenFail() =>
            RetryThenFailHelper(service => service.Projects.HmacKeys.List("project"), client => client.ListHmacKeys("project").Count());

        [Fact]
        public void DeleteHmacKey_NoRetry() =>
            NoRetryHelper(service => service.Projects.HmacKeys.Delete("project", "access"), client => client.DeleteHmacKey("project", "access"));

        [Fact]
        public void DeleteHmacKey_RetryOnce() =>
            RetryOnce(service => service.Projects.HmacKeys.Delete("project", "access"), client => client.DeleteHmacKey("project", "access"), "check");

        [Fact]
        public void DeleteHmacKey_RetryThenFail() =>
            RetryThenFail(service => service.Projects.HmacKeys.Delete("project", "access"), client => client.DeleteHmacKey("project", "access"), "check");

        [Fact]
        public void UpdateHmacKey_NoRetry() =>
            NoRetryHelper(service => service.Projects.HmacKeys.Update(new HmacKeyMetadata { ProjectId = "project", AccessId = "access" }, "project", "access"), 
                client => client.UpdateHmacKey(new HmacKeyMetadata { ProjectId = "project", AccessId = "access" }));

        [Fact]
        public void UpdateHmacKey_RetryOnce() =>
            RetryOnceHelper(service => service.Projects.HmacKeys.Update(new HmacKeyMetadata { ProjectId = "project", AccessId = "access" }, "project", "access"), 
                client => client.UpdateHmacKey(new HmacKeyMetadata { ProjectId = "project", AccessId = "access" }));

        [Fact]
        public void UpdateHmacKey_RetryThenFail() =>
            RetryThenFailHelper(service => service.Projects.HmacKeys.Update(new HmacKeyMetadata { ProjectId = "project", AccessId = "access" }, "project", "access"), 
                client => client.UpdateHmacKey(new HmacKeyMetadata { ProjectId = "project", AccessId = "access" }));

        // HMAC Key test cases END

        // Notifications test cases START

        [Fact]
        public void ListNotifications_NoRetry() =>
            NoRetryHelper(service => service.Notifications.List("bucket"), client => client.ListNotifications("bucket").Count());

        [Fact]
        public void ListNotifications_RetryOnce() =>
            RetryOnceHelper(service => service.Notifications.List("bucket"), client => client.ListNotifications("bucket").Count());

        [Fact]
        public void ListNotifications_RetryThenFail() =>
            RetryThenFailHelper(service => service.Notifications.List("bucket"), client => client.ListNotifications("bucket").Count());

        [Fact]
        public void GetNotification_NoRetry() =>
            NoRetryHelper(service => service.Notifications.Get("bucket", "notification"), client => client.GetNotification("bucket", "notification"));

        [Fact]
        public void GetNotification_RetryOnce() =>
            RetryOnceHelper(service => service.Notifications.Get("bucket", "notification"), client => client.GetNotification("bucket", "notification"));

        [Fact]
        public void GetNotification_RetryThenFail() =>
            RetryThenFailHelper(service => service.Notifications.Get("bucket", "notification"), client => client.GetNotification("bucket", "notification"));

        [Fact]
        public void DeleteNotification_NoRetry() =>
            NoRetryHelper(service => service.Notifications.Delete("bucket", "notification"), client => client.DeleteNotification("bucket", "notification"));

        [Fact]
        public void DeleteNotification_RetryOnce() =>
            RetryOnce(service => service.Notifications.Delete("bucket", "notification"), client => client.DeleteNotification("bucket", "notification"), "check");

        [Fact]
        public void DeleteNotification_RetryThenFail() =>
            RetryThenFail(service => service.Notifications.Delete("bucket", "notification"), client => client.DeleteNotification("bucket", "notification"), "check");

        // Notification Test cases END

    }
}

