// Copyright 2018 Google Inc. All Rights Reserved.
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
using System.Net;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Storage.V1.IntegrationTests.TestHelpers;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class DeleteBucketTest
    {
        // Only overloads accepting Bucket are tested, but the overloads accepting string go
        // through almost all the same code.

        private readonly StorageFixture _fixture;

        public DeleteBucketTest(StorageFixture fixture) => _fixture = fixture;

        [Fact]
        public void DeleteBucket_NonExistent()
        {
            string name = _fixture.GenerateBucketName();
            var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.DeleteBucket(name));
        }


        [Fact]
        public void DeleteBucket_Empty_NoPrecondition()
        {
            var bucket = CreateBucket();
            DeleteBucket(bucket);
            AssertBucketDeleted(bucket);
        }

        [Fact]
        public void DeleteBucket_Empty_IncorrectPrecondition()
        {
            var bucket = CreateBucket();
            var options = new DeleteBucketOptions { IfMetagenerationMatch = bucket.Metageneration + 1 };
            var exception = Assert.Throws<GoogleApiException>(() => DeleteBucket(bucket, options));
            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
            AssertBucketNotDeleted(bucket);
        }

        [Fact]
        public void DeleteBucket_Empty_CorrectPrecondition()
        {
            var bucket = CreateBucket();
            var options = new DeleteBucketOptions { IfMetagenerationMatch = bucket.Metageneration };
            DeleteBucket(bucket, options);
            AssertBucketDeleted(bucket);
        }

        [Fact]
        public void DeleteBucket_WithObject_Fails()
        {
            var bucket = CreateBucket();
            _fixture.Client.UploadObject(bucket.Name, "file", null, GenerateData(128));
            var exception = Assert.Throws<GoogleApiException>(() => DeleteBucket(bucket));
            Assert.Equal(HttpStatusCode.Conflict, exception.HttpStatusCode);
            AssertBucketNotDeleted(bucket);
        }

        [Fact]
        public void DeleteBucket_DeleteObjects_NoPrecondition()
        {
            var bucket = CreateBucket();
            _fixture.Client.UploadObject(bucket.Name, "file", null, GenerateData(128));
            var options = new DeleteBucketOptions { DeleteObjects = true };
            DeleteBucket(bucket, options);
            AssertBucketDeleted(bucket);
        }

        [Fact]
        public void DeleteBucket_DeleteObjects_IncorrectPrecondition()
        {
            var bucket = CreateBucket();
            _fixture.Client.UploadObject(bucket.Name, "file", null, GenerateData(128));
            var options = new DeleteBucketOptions { DeleteObjects = true, IfMetagenerationMatch = bucket.Metageneration + 1 };
            var exception = Assert.Throws<GoogleApiException>(() => DeleteBucket(bucket, options));
            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
            // The file should still exist if the precondition wasn't met.
            _fixture.Client.GetObject(bucket.Name, "file");
            AssertBucketNotDeleted(bucket);
        }

        [Fact]
        public void DeleteBucket_DeleteObjects_CorrectPrecondition()
        {
            var bucket = CreateBucket();
            _fixture.Client.UploadObject(bucket.Name, "file", null, GenerateData(128));
            var options = new DeleteBucketOptions { DeleteObjects = true, IfMetagenerationMatch = bucket.Metageneration };
            DeleteBucket(bucket, options);
            AssertBucketDeleted(bucket);
        }

        [Fact]
        public void DeleteBucketAsync_NonExistent()
        {
            string name = _fixture.GenerateBucketName();
            var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.DeleteBucket(name));
        }


        [Fact]
        public async Task DeleteBucketAsync_Empty_NoPrecondition()
        {
            var bucket = CreateBucket();
            await DeleteBucketAsync(bucket);
            AssertBucketDeleted(bucket);
        }

        [Fact]
        public async Task DeleteBucketAsync_Empty_IncorrectPrecondition()
        {
            var bucket = CreateBucket();
            var options = new DeleteBucketOptions { IfMetagenerationMatch = bucket.Metageneration + 1 };
            var exception = await Assert.ThrowsAsync<GoogleApiException>(() => DeleteBucketAsync(bucket, options));
            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
            AssertBucketNotDeleted(bucket);
        }

        [Fact]
        public async Task DeleteBucketAsync_Empty_CorrectPrecondition()
        {
            var bucket = CreateBucket();
            var options = new DeleteBucketOptions { IfMetagenerationMatch = bucket.Metageneration };
            await DeleteBucketAsync(bucket, options);
            AssertBucketDeleted(bucket);
        }

        [Fact]
        public async Task DeleteBucketAsync_WithObject_Fails()
        {
            var bucket = CreateBucket();
            _fixture.Client.UploadObject(bucket.Name, "file", null, GenerateData(128));
            var exception = await Assert.ThrowsAsync<GoogleApiException>(() => DeleteBucketAsync(bucket));
            Assert.Equal(HttpStatusCode.Conflict, exception.HttpStatusCode);
            AssertBucketNotDeleted(bucket);
        }

        [Fact]
        public async Task DeleteBucketAsync_DeleteObjects_NoPrecondition()
        {
            var bucket = CreateBucket();
            _fixture.Client.UploadObject(bucket.Name, "file", null, GenerateData(128));
            var options = new DeleteBucketOptions { DeleteObjects = true };
            await DeleteBucketAsync(bucket, options);
            AssertBucketDeleted(bucket);
        }

        [Fact]
        public async Task DeleteBucketAsync_DeleteObjects_IncorrectPrecondition()
        {
            var bucket = CreateBucket();
            _fixture.Client.UploadObject(bucket.Name, "file", null, GenerateData(128));
            var options = new DeleteBucketOptions { DeleteObjects = true, IfMetagenerationMatch = bucket.Metageneration + 1 };
            var exception = await Assert.ThrowsAsync<GoogleApiException>(() => DeleteBucketAsync(bucket, options));
            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
            // The file should still exist if the precondition wasn't met.
            _fixture.Client.GetObject(bucket.Name, "file");
            AssertBucketNotDeleted(bucket);
        }

        [Fact]
        public async Task DeleteBucketAsync_DeleteObjects_CorrectPrecondition()
        {
            var bucket = CreateBucket();
            _fixture.Client.UploadObject(bucket.Name, "file", null, GenerateData(128));
            var options = new DeleteBucketOptions { DeleteObjects = true, IfMetagenerationMatch = bucket.Metageneration };
            await DeleteBucketAsync(bucket, options);
            AssertBucketDeleted(bucket);
        }

        private void DeleteBucket(Bucket bucket, DeleteBucketOptions options = null)
        {
            try
            {
                _fixture.Client.DeleteBucket(bucket, options);
                _fixture.UnregisterBucket(bucket.Name);
            }
            finally
            {
                StorageFixture.SleepAfterBucketCreateDelete();
            }
        }

        private async Task DeleteBucketAsync(Bucket bucket, DeleteBucketOptions options = null)
        {
            try
            {
                await _fixture.Client.DeleteBucketAsync(bucket, options);
                _fixture.UnregisterBucket(bucket.Name);
            }
            finally
            {
                StorageFixture.SleepAfterBucketCreateDelete();
            }
        }

        private void AssertBucketDeleted(Bucket bucket)
        {
            var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.GetBucket(bucket.Name));
            Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
        }

        private void AssertBucketNotDeleted(Bucket bucket) => _fixture.Client.GetBucket(bucket.Name);

        private Bucket CreateBucket()
        {
            var name = _fixture.GenerateBucketName();
            return _fixture.CreateBucket(name, false);
        }
    }
}
