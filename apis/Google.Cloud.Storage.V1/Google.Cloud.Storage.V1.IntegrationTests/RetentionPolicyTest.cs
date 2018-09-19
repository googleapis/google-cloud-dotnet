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

using Google.Apis.Storage.v1.Data;
using System;
using System.IO;
using System.Text;
using System.Threading;
using Xunit;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class RetentionPolicyTest
    {
        private readonly StorageFixture _fixture;

        public RetentionPolicyTest(StorageFixture fixture) => _fixture = fixture;

        /// <summary>
        /// Define a retention policy with a retention period of 5 seconds and verify retention period is set.
        /// Insert a new object and verify retentionExpirationTime is not null.
        /// Attempts to delete object before 5 seconds have elapsed will fail.
        /// </summary>
        [Fact]
        public void SimpleRetentionPolicy()
        {
            var client = _fixture.Client;
            var bucketName = _fixture.GenerateBucketName();
            var bucket = _fixture.CreateBucket(bucketName, false);

            // Set the retention policy
            bucket.RetentionPolicy = new Bucket.RetentionPolicyData { RetentionPeriod = 5 };
            client.UpdateBucket(bucket);

            // Fetch the bucket again to check it was set.
            bucket = client.GetBucket(bucketName);
            Assert.Equal(5L, bucket.RetentionPolicy.RetentionPeriod);
            Assert.NotNull(bucket.RetentionPolicy.EffectiveTime);

            // Create an object, which should have a retention expiration.
            string objectName = "object.txt";
            CreateObject(bucketName, objectName);

            var obj = client.GetObject(bucketName, objectName);
            Assert.NotNull(obj.RetentionExpirationTime);

            Assert.Throws<GoogleApiException>(() => client.DeleteObject(bucketName, objectName));
        }

        /// <summary>
        /// Test the client is able to remove a retention policy when a retention policy is not locked.
        /// </summary>
        [Fact]
        public void RemoveRetentionPolicy()
        {
            var client = _fixture.Client;
            var bucketName = _fixture.GenerateBucketName();
            var bucket = _fixture.CreateBucket(bucketName, false);

            // Set the retention policy
            bucket.RetentionPolicy = new Bucket.RetentionPolicyData { RetentionPeriod = 5 };
            client.UpdateBucket(bucket);

            // Fetch the bucket again and check the policy was set.
            bucket = client.GetBucket(bucketName);
            Assert.NotNull(bucket.RetentionPolicy);

            // Remove the retention policy
            bucket.RetentionPolicy = null;
            client.UpdateBucket(bucket);

            // Fetch the bucket again and check the policy was removed.
            bucket = client.GetBucket(bucketName);
            Assert.Null(bucket.RetentionPolicy);
        }

        /// <summary>
        /// Test the lock of a retention policy and verify RetentionPolicy.IsLocked is true after locking the policy.
        /// </summary>
        [Fact]
        public void LockRetentionPolicy()
        {
            var client = _fixture.Client;
            var bucketName = _fixture.GenerateBucketName();
            var bucket = _fixture.CreateBucket(bucketName, false);

            // Set the retention policy
            bucket.RetentionPolicy = new Bucket.RetentionPolicyData { RetentionPeriod = 5 };
            var updated = client.UpdateBucket(bucket);

            // Lock it
            client.LockBucketRetentionPolicy(bucketName, updated.Metageneration.Value);

            // Check it's locked with the policy in place
            bucket = client.GetBucket(bucketName);
            Assert.Equal(5L, bucket.RetentionPolicy.RetentionPeriod);
            Assert.True(bucket.RetentionPolicy.IsLocked);
        }

        /// <summary>
        /// Test Set/Update temporary hold on an object and attempt to delete an object.
        /// It should fail until temporaryHold is set to false.
        /// </summary>
        [Fact]
        public void TemporaryHold()
        {
            var client = _fixture.Client;
            // This test doesn't modify the bucket, so we can use an existing one.
            var bucketName = _fixture.InitiallyEmptyBucket;

            string objectName = "temporary-hold.txt";
            var obj = CreateObject(bucketName, objectName);

            // Set a temporary hold. We should fail to delete the object.
            obj.TemporaryHold = true;
            client.UpdateObject(obj);
            Assert.Throws<GoogleApiException>(() => client.DeleteObject(bucketName, objectName));

            // Clear the temporary hold. We should be able to delete the object.
            obj.TemporaryHold = false;
            client.UpdateObject(obj);
            client.DeleteObject(bucketName, objectName);
        }

        /// <summary>
        /// Test Set/Update event-based hold on an object and attempt to delete an object.
        /// It should fail when event-based hold is true and for a short period after setting it to false per the retention policy period.
        /// </summary>
        [Fact]
        public void EventBasedHold()
        {
            var client = _fixture.Client;
            var bucketName = _fixture.GenerateBucketName();
            var bucket = _fixture.CreateBucket(bucketName, false);

            // Set an event-based hold. We should fail to delete the object.
            string objectName = "event-based-hold.txt";
            var obj = CreateObject(bucketName, objectName);
            Assert.Null(obj.EventBasedHold);
            obj.EventBasedHold = true;
            client.UpdateObject(obj);
            Assert.Throws<GoogleApiException>(() => client.DeleteObject(bucketName, objectName));

            // Set the retention policy for the bucket to 10s.
            bucket.RetentionPolicy = new Bucket.RetentionPolicyData { RetentionPeriod = 10L };
            client.UpdateBucket(bucket);

            // Clear the event-based hold.
            obj.EventBasedHold = false;
            client.UpdateObject(obj);

            // After 5 seconds, we should still not be able to delete the object: it is protected
            // by the retention policy.
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Assert.Throws<GoogleApiException>(() => client.DeleteObject(bucketName, objectName));

            // After another 10 seconds, we should be able to delete the object.
            Thread.Sleep(TimeSpan.FromSeconds(10));
            client.DeleteObject(bucketName, objectName);
        }

        /// <summary>
        /// Test Set/Update default event-based hold for a bucket.
        /// When a new object is inserted and the default event-based hold is set to true, the object event-based hold metadata should be true.
        /// </summary>
        [Fact]
        public void DefaultEventBasedHold()
        {
            var client = _fixture.Client;
            var bucketName = _fixture.GenerateBucketName();
            var bucket = _fixture.CreateBucket(bucketName, false);

            bucket.DefaultEventBasedHold = true;
            client.UpdateBucket(bucket);

            string objectName = "default-event-based-hold.txt";
            CreateObject(bucketName, objectName);

            var obj = client.GetObject(bucketName, objectName);
            Assert.True(obj.EventBasedHold);

            // Remove the event-based hold for the object and bucket so we'll be able to delete
            // the objects and bucket later.
            bucket.DefaultEventBasedHold = false;
            client.UpdateBucket(bucket);
            obj.EventBasedHold = false;
            client.UpdateObject(obj);
        }

        private Object CreateObject(string bucketName, string objectName)
        {
            string text = $"This is the content of {objectName}";
            var bytes = Encoding.UTF8.GetBytes(text);
            return _fixture.Client.UploadObject(bucketName, objectName, "text/plain", new MemoryStream(bytes));
        }
    }
}
