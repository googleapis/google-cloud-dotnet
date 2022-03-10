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

        [Theory]
        [InlineData("FailThenRetry")]
        [InlineData("NonRetriableFailure")]
        public void GetBucketTest(string testType)
        {
            var bucketId = "bucket";
            var service = new FakeStorageService();
            var client = new StorageClientImpl(service);
            var request = new BucketsResource.GetRequest(service, bucketId);

            if (testType == "FailThenRetry")
            {
                service.ExpectRequest(request, HttpStatusCode.BadGateway);
                service.ExpectRequest(request, new Bucket() { Id = bucketId });
                var result = client.GetBucket(bucketId);
                Assert.Equal(bucketId, result.Id);
            }
            else if (testType == "NonRetriableFailure")
            {
                service.ExpectRequest(request, HttpStatusCode.NotFound);
                Assert.Throws<GoogleApiException>(() => client.GetBucket(bucketId));
            }
            service.Verify();
        }

        [Theory]
        [InlineData("FailThenRetry")]
        [InlineData("NonRetriableFailure")]
        public void GetObjectTest(string testType)
        {
            var bucketId = "bucket";
            var objectName = "objectName";
            var service = new FakeStorageService();
            var client = new StorageClientImpl(service);
            var obj = new Object() { Name = objectName, Bucket = bucketId };
            var request = service.Objects.Get(bucketId, objectName);

            if (testType == "FailThenRetry")
            {
                service.ExpectRequest(request, HttpStatusCode.BadGateway);
                service.ExpectRequest(request, new Object() { Name = objectName });
                var result = client.GetObject(bucketId, objectName);
                Assert.Equal(objectName, result.Name);
            }
            else if (testType == "NonRetriableFailure")
            {
                service.ExpectRequest(request, HttpStatusCode.NotFound);
                Assert.Throws<GoogleApiException>(() => client.GetObject(bucketId, objectName));
            }
        }

        [Theory]
        [InlineData("NoRetryIfOptionsAbsent")]
        [InlineData("RetryIfOptionsPresent")]
        [InlineData("NonRetriableFailure")]
        public void UpdateObjectTest(string testType)
        {
            var bucketId = "bucket";
            var objectName = "objectName";
            var service = new FakeStorageService();
            var client = new StorageClientImpl(service);
            var obj = new Object() { Name = objectName, Bucket = bucketId };
            var request = service.Objects.Update(obj, obj.Bucket, obj.Name);

            if (testType == "RetryIfOptionsPresent")
            {
                request.IfMetagenerationMatch = 70;
                service.ExpectRequest(request, HttpStatusCode.BadGateway);
                service.ExpectRequest(request, new Object() { Name = objectName });
                var result = client.UpdateObject(obj, new UpdateObjectOptions() { IfMetagenerationMatch = 70 });
                Assert.Equal(objectName, result.Name);
            }
            else if(testType == "NoRetryIfOptionsAbsent")
            {
                service.ExpectRequest(request, HttpStatusCode.BadGateway);
                var exception = Assert.Throws<GoogleApiException>(() => client.UpdateObject(obj, new UpdateObjectOptions()));
            }
            else if(testType == "NonRetriableFailure")
            {
                request.IfMetagenerationMatch = 70;
                service.ExpectRequest(request, HttpStatusCode.NotFound);
                Assert.Throws<GoogleApiException>(() => client.UpdateObject(obj, new UpdateObjectOptions() { IfMetagenerationMatch = 70 }));
            }
            service.Verify();
        }

        [Theory]
        [InlineData("FailThenRetry")]
        [InlineData("NonRetriableFailure")]
        public void GetNotificationsTest(string testType)
        {
            var bucketId = "bucket";
            var notificationId = "notification";
            var service = new FakeStorageService();
            var client = new StorageClientImpl(service);
            var request = new NotificationsResource.GetRequest(service, bucketId, notificationId);

            if (testType == "FailThenRetry")
            {
                service.ExpectRequest(request, HttpStatusCode.BadGateway);
                service.ExpectRequest(request, new Notification() { Id = notificationId });
                var result = client.GetNotification(bucketId,notificationId);
                Assert.Equal(notificationId, result.Id);
            }
            else if (testType == "NonRetriableFailure")
            {
                service.ExpectRequest(request, HttpStatusCode.NotFound);
                Assert.Throws<GoogleApiException>(() => client.GetNotification(bucketId, notificationId));
            }
            service.Verify();
        }
    }
}
