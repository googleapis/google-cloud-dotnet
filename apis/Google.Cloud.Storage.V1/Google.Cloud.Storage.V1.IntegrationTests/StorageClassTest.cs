﻿// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Apis.Storage.v1.Data;
using Google.Cloud.ClientTesting;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class StorageClassTest
    {
        private readonly StorageFixture _fixture;

        public StorageClassTest(StorageFixture fixture)
        {
            _fixture = fixture;
        }

        [Theory]
        [InlineData(StorageClasses.Archive)]
        [InlineData(StorageClasses.Coldline)]
        [InlineData(StorageClasses.DurableReducedAvailability)]
        [InlineData(StorageClasses.MultiRegional)]
        [InlineData(StorageClasses.Nearline)]
        [InlineData(StorageClasses.Regional, "US-EAST1")]
        [InlineData(StorageClasses.Standard)]
        public void CreateBucketWithStorageClass(string storageClass, string location = null)
        {
            string bucketName = $"{_fixture.BucketPrefix}-class-{storageClass.ToLowerInvariant()}";
            var client = _fixture.Client;

            var bucket = client.CreateBucket(_fixture.ProjectId,
                new Bucket { Name = bucketName, StorageClass = storageClass, Location = location });
            StorageFixture.SleepAfterBucketCreateDelete();
            _fixture.RegisterBucketToDelete(bucketName);

            Assert.Equal(storageClass, bucket.StorageClass);
            bucket = client.GetBucket(bucketName);
            Assert.Equal(storageClass, bucket.StorageClass);
        }

        // Multi-step test to check:
        // - Create a bucket with a storage class of "standard"
        // - That storage class is used when creating a new object
        // - If we rewrite the object to a different storage class ("coldline"), that change sticks
        // - If we update the bucket's default storage class to "nearline", creating a new object uses that new class
        [Fact]
        public void CreateBucketAndObjects()
        {
            // Note: this test may fail if the project location prevents multi-regional storage.
            string initialBucketStorageClass = StorageClasses.Standard;
            string updatedObjectStorageClass = StorageClasses.Coldline;
            string updatedBucketStorageClass = StorageClasses.Nearline;

            string bucketName = _fixture.BucketPrefix + "storage-classes";
            string objectName = IdGenerator.FromGuid();
            var client = _fixture.Client;

            client.CreateBucket(_fixture.ProjectId, new Bucket { Name = bucketName, StorageClass = initialBucketStorageClass });
            StorageFixture.SleepAfterBucketCreateDelete();
            _fixture.RegisterBucketToDelete(bucketName);

            var bucket = client.GetBucket(bucketName);
            Assert.Equal(initialBucketStorageClass, bucket.StorageClass);

            var obj = client.UploadObject(bucketName, objectName, "application/octet-stream", TestHelpers.GenerateData(100));
            Assert.Equal(initialBucketStorageClass, obj.StorageClass);

            // Change storage class via a rewrite
            var options = new CopyObjectOptions
            {
                ExtraMetadata = new Object { StorageClass = updatedObjectStorageClass }
            };
            client.CopyObject(bucketName, objectName, bucketName, objectName, options);

            // Fetch separately rather than trusting the return value of CopyObject...
            obj = client.GetObject(bucketName, objectName);
            Assert.Equal(updatedObjectStorageClass, obj.StorageClass);

            bucket.StorageClass = updatedBucketStorageClass;
            client.UpdateBucket(bucket);
            // Wait for 10 seconds to allow the bucket changes to take effect. While a lot of the time
            // the change is effective immediately, this pause just makes things more reliably - and is pretty reasonable
            // given the distributed nature of the system.
            Thread.Sleep(TimeSpan.FromSeconds(10));

            string objectName2 = IdGenerator.FromGuid();

            var obj2 = client.UploadObject(bucketName, objectName2, "application/octet-stream", TestHelpers.GenerateData(100));
            Assert.Equal(updatedBucketStorageClass, obj2.StorageClass);
        }
    }
}
