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
using System;
using System.Net;
using Xunit;
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

        // Tests:
        // - No retry applied
        // - Retry then success (sometimes with conditions)
        // - Retry with eventual failure?

        [Fact]
        public void GetBucket_NoRetry() =>
            NoRetryHelper(service => service.Buckets.Get("bucket"), client => client.GetBucket("bucket"));

        [Fact]
        public void GetBucket_NoRetry_ForInternalServerError() =>
            NoRetryHelper(service => service.Buckets.Get("bucket"), client => client.GetBucket("bucket"), HttpStatusCode.InternalServerError);

        [Fact]
        public void GetObject_NoRetry() =>
            NoRetryHelper(service => service.Objects.Get("bucket", "object"), client => client.GetObject("bucket", "object"));

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

        [Fact]
        public void GetBucket_RetryOnce() =>
            RetryOnceHelper(service => service.Buckets.Get("bucket"), client => client.GetBucket("bucket"));

        [Fact]
        public void GetObject_RetryOnce() =>
            RetryOnceHelper(service => service.Buckets.Get("bucket"), client => client.GetBucket("bucket"));

        [Fact]
        public void GetObject_RetryThenFail() =>
            RetryThenFailHelper(service => service.Buckets.Get("bucket"), client => client.GetBucket("bucket"));

        [Fact]
        public void GetHmacKey() =>
            RetryOnceHelper(service => service.Projects.HmacKeys.Get("project", "access"), client => client.GetHmacKey("project", "access"));

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

        private static void RetryOnceHelper<T>(Func<StorageService, ClientServiceRequest<T>> requestProvider, Action<StorageClient> clientAction,
            HttpStatusCode firstStatusCode = HttpStatusCode.BadGateway)
            where T : new()
        {
            var service = new FakeStorageService();
            var client = new StorageClientImpl(service);
            var request = requestProvider(service);

            service.ExpectRequest(request, firstStatusCode);
            service.ExpectRequest(request, new T());
            clientAction(client);
            service.Verify();
        }

        private static void RetryThenFailHelper<T>(Func<StorageService, ClientServiceRequest<T>> requestProvider, Action<StorageClient> clientAction,
            HttpStatusCode errorCode = HttpStatusCode.BadGateway)
            where T : new()
        {
            var service = new FakeStorageService();
            var client = new StorageClientImpl(service);
            var request = requestProvider(service);

            // TODO: put this in a loop and parameterize the expected number?
            service.ExpectRequest(request, errorCode);
            service.ExpectRequest(request, errorCode);
            service.ExpectRequest(request, errorCode);
            Assert.Throws<GoogleApiException>(() => clientAction(client));
            service.Verify();
        }

        [Fact]
        public void GetBucket_FailThenRetry()
        {
            var bucketId = "bucket";
            var service = new FakeStorageService();
            var client = new StorageClientImpl(service);
            var request = new BucketsResource.GetRequest(service, bucketId);

            service.ExpectRequest(request, HttpStatusCode.BadGateway);
            service.ExpectRequest(request, new Bucket() { Id = bucketId });
            var result = client.GetBucket(bucketId);
            Assert.Equal(bucketId, result.Id);
            service.Verify();
        }

        [Fact]
        public void GetBucket_NonRetriableFailure()
        {
            var bucketId = "bucket";
            var service = new FakeStorageService();
            var client = new StorageClientImpl(service);
            var request = new BucketsResource.GetRequest(service, bucketId);

            service.ExpectRequest(request, HttpStatusCode.NotFound);
            Assert.Throws<GoogleApiException>(() => client.GetBucket(bucketId));
        }

        [Fact]
        public void GetObject_FailThenRetry()
        {
            var bucketId = "bucket";
            var objectName = "objectName";
            var service = new FakeStorageService();
            var client = new StorageClientImpl(service);
            var obj = new Object() { Name = objectName, Bucket = bucketId };
            var request = service.Objects.Get(bucketId, objectName);

            service.ExpectRequest(request, HttpStatusCode.BadGateway);
            service.ExpectRequest(request, new Object() { Name = objectName });
            var result = client.GetObject(bucketId, objectName);
            Assert.Equal(objectName, result.Name);

        }

        [Fact]
        public void GetObject_NonRetriableFailure()
        {
            var bucketId = "bucket";
            var objectName = "objectName";
            var service = new FakeStorageService();
            var client = new StorageClientImpl(service);
            var obj = new Object() { Name = objectName, Bucket = bucketId };
            var request = service.Objects.Get(bucketId, objectName);

            service.ExpectRequest(request, HttpStatusCode.NotFound);
            Assert.Throws<GoogleApiException>(() => client.GetObject(bucketId, objectName));
        }

        [Fact]
        public void UpdateObject_NoRetryIfOptionsAbsent()
        {
            var bucketId = "bucket";
            var objectName = "objectName";
            var service = new FakeStorageService();
            var client = new StorageClientImpl(service);
            var obj = new Object() { Name = objectName, Bucket = bucketId };
            var request = service.Objects.Update(obj, obj.Bucket, obj.Name);

            service.ExpectRequest(request, HttpStatusCode.BadGateway);
            var exception = Assert.Throws<GoogleApiException>(() => client.UpdateObject(obj, new UpdateObjectOptions()));
            service.Verify();
        }

        [Fact]
        public void UpdateObject_RetryIfOptionsPresent()
        {
            var bucketId = "bucket";
            var objectName = "objectName";
            var service = new FakeStorageService();
            var client = new StorageClientImpl(service);
            var obj = new Object() { Name = objectName, Bucket = bucketId };
            var request = service.Objects.Update(obj, obj.Bucket, obj.Name);

            request.IfMetagenerationMatch = 70;
            service.ExpectRequest(request, HttpStatusCode.BadGateway);
            service.ExpectRequest(request, new Object() { Name = objectName });
            var result = client.UpdateObject(obj, new UpdateObjectOptions() { IfMetagenerationMatch = 70 });
            Assert.Equal(objectName, result.Name);
            service.Verify();
        }

        [Fact]
        public void UpdateObject_NonRetriableFailure()
        {
            var bucketId = "bucket";
            var objectName = "objectName";
            var service = new FakeStorageService();
            var client = new StorageClientImpl(service);
            var obj = new Object() { Name = objectName, Bucket = bucketId };
            var request = service.Objects.Update(obj, obj.Bucket, obj.Name);

            request.IfMetagenerationMatch = 70;
            service.ExpectRequest(request, HttpStatusCode.NotFound);
            Assert.Throws<GoogleApiException>(() => client.UpdateObject(obj, new UpdateObjectOptions() { IfMetagenerationMatch = 70 }));
            service.Verify();
        }

        [Fact]
        public void GetNotifications_FailThenRetry()
        {
            var bucketId = "bucket";
            var notificationId = "notification";
            var service = new FakeStorageService();
            var client = new StorageClientImpl(service);
            var request = new NotificationsResource.GetRequest(service, bucketId, notificationId);

            service.ExpectRequest(request, HttpStatusCode.BadGateway);
            service.ExpectRequest(request, new Notification() { Id = notificationId });
            var result = client.GetNotification(bucketId, notificationId);
            Assert.Equal(notificationId, result.Id);
            service.Verify();
        }

        [Fact]
        public void GetNotifications_NonRetriableFailure()
        {
            var bucketId = "bucket";
            var notificationId = "notification";
            var service = new FakeStorageService();
            var client = new StorageClientImpl(service);
            var request = new NotificationsResource.GetRequest(service, bucketId, notificationId);

            service.ExpectRequest(request, HttpStatusCode.NotFound);
            Assert.Throws<GoogleApiException>(() => client.GetNotification(bucketId, notificationId));
            service.Verify();
        }
    }
}
