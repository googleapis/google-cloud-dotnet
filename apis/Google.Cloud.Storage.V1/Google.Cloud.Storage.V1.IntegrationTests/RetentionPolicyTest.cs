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
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class RetentionPolicyTest
    {
        private readonly StorageFixture _fixture;

        public RetentionPolicyTest(StorageFixture fixture) => _fixture = fixture;

        // This is a single test, but it checks a fairly long scenario. See comments for details.
        [Fact]
        public void RetentionPolicy()
        {
            var client = _fixture.Client;
            var bucketName = _fixture.GenerateBucketName();
            _fixture.CreateBucket(bucketName, false);

            // Create an object and delete it, to prove that we can.
            CreateObject("deletable");
            client.DeleteObject(bucketName, "deletable");

            // Set the retention period, create an object then fail to delete it.
            SetRetentionPolicy(20);
            CreateObject("retained");
            Assert.Throws<GoogleApiException>(() => client.DeleteObject(bucketName, "retained"));

            // Shorten the retention period - that's valid.
            SetRetentionPolicy(15);

            // Remove the retention period - that's valid too
            SetRetentionPolicy(null);

            // Set it back to 15 seconds, try (and fail) to lock it with the wrong metageneration,
            // then lock it with the right metageneration.
            var readyToLock = SetRetentionPolicy(15);
            Assert.Throws<GoogleApiException>(() => client.LockBucketRetentionPolicy(bucketName, readyToLock.Metageneration.Value - 1));
            client.LockBucketRetentionPolicy(bucketName, readyToLock.Metageneration.Value);

            // We now can't delete the object, shorten the retention period or remove it.
            Assert.Throws<GoogleApiException>(() => client.DeleteObject(bucketName, "retained"));
            Assert.Throws<GoogleApiException>(() => SetRetentionPolicy(10));
            Assert.Throws<GoogleApiException>(() => SetRetentionPolicy(null));

            // We can extend it though
            SetRetentionPolicy(20);

            // If we wait long enough, we can delete the object, too... and then the bucket.
            Thread.Sleep(TimeSpan.FromSeconds(25));
            client.DeleteObject(bucketName, "retained");
            client.DeleteBucket(bucketName);

            // If the DeleteBucket call succeeded, we don't want the fixture to try to delete it again.
            _fixture.UnregisterBucket(bucketName);

            StorageFixture.SleepAfterBucketCreateDelete();

            void CreateObject(string objectName)
            {
                string text = $"This is the content of {objectName}";
                var bytes = Encoding.UTF8.GetBytes(text);
                _fixture.Client.UploadObject(bucketName, objectName, "text/plain", new MemoryStream(bytes));
            }

            Bucket SetRetentionPolicy(int? seconds)
            {
                Bucket bucket = client.GetBucket(bucketName);
                if (seconds == null)
                {
                    bucket.RetentionPolicy = null;
                }
                else
                {
                    // Create a new policy if necessary, or just overwrite the retention period of the current one.
                    if (bucket.RetentionPolicy == null)
                    {
                        bucket.RetentionPolicy = new Bucket.RetentionPolicyData();
                    }
                    bucket.RetentionPolicy.RetentionPeriod = seconds.Value;
                }
                return client.UpdateBucket(bucket);
            }
        }
    }
}
