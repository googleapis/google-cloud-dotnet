// Copyright 2015 Google Inc. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class ListBucketsTest
    {
        private readonly StorageFixture _fixture;

        public ListBucketsTest(StorageFixture fixture)
        {
            _fixture = fixture;
        }

        [Theory]
        [InlineData(null, false)]
        [InlineData(null, true)]
        [InlineData(4, false)]
        [InlineData(4, true)]
        public async Task AllBuckets(int? pageSize, bool specifyPrefix)
        {
            var options = new ListBucketsOptions { PageSize = pageSize, Prefix = specifyPrefix ? null : _fixture.BucketPrefix };
            await AssertBuckets(options, _fixture.AllBuckets.ToArray());
        }

        [Fact]
        public async Task Prefix()
        {
            var options = new ListBucketsOptions { Prefix = _fixture.BucketPrefix + "z" };
            await AssertBuckets(options, _fixture.BucketBeginningWithZ);
        }

        [Fact]
        public async Task CancellationTokenRespected()
        {
            var cts = new CancellationTokenSource();
            var task = _fixture.Client.ListBucketsAsync(_fixture.ProjectId).ToListAsync(cts.Token);
            cts.Cancel();
            await Assert.ThrowsAnyAsync<OperationCanceledException>(task.AsTask);
        }

        [Fact]
        public void PartialResponses()
        {
            var options = new ListBucketsOptions { Fields = "items(name,location),nextPageToken" };
            var buckets = _fixture.Client.ListBuckets(_fixture.ProjectId, options).ToList();
            foreach (var bucket in buckets)
            {
                // These fields are requested
                Assert.NotNull(bucket.Name);
                Assert.NotNull(bucket.Location);
                // These are not
                Assert.Null(bucket.LocationType);
                Assert.Null(bucket.ETag);
            }
        }

        [Fact]
        public async Task SoftDeletedOnly()
        {
            var bucketName = _fixture.GenerateBucketName();
            var softDeleteBucket = _fixture.CreateBucket(bucketName, false, true);
            await _fixture.Client.DeleteBucketAsync(softDeleteBucket.Name, new DeleteBucketOptions { DeleteObjects = true });
            var actualBuckets = await _fixture.Client.ListBucketsAsync(_fixture.ProjectId, new ListBucketsOptions { SoftDeletedOnly = true }).ToListAsync();

            foreach (var bucket in actualBuckets)
            {   // Verify if the bucket is soft-deleted only 
                Assert.NotNull(bucket.Generation);
                Assert.NotNull(bucket.SoftDeleteTimeDateTimeOffset);
                Assert.NotNull(bucket.HardDeleteTimeDateTimeOffset);

                if (bucket.Name == softDeleteBucket.Name)
                {   // Compare the generation number
                    Assert.Equal(bucket.Generation, softDeleteBucket.Generation);
                }
            }
        }

        // Fetches buckets using the given options in each possible way, validating that the expected bucket names are returned.
        private async Task AssertBuckets(ListBucketsOptions options, params string[] expectedBucketNames)
        {
            IEnumerable<Bucket> actual = _fixture.Client.ListBuckets(_fixture.ProjectId, options);
            AssertBucketNames(actual, expectedBucketNames);
            actual = await _fixture.Client.ListBucketsAsync(_fixture.ProjectId, options).ToListAsync();
            AssertBucketNames(actual, expectedBucketNames);
        }

        private void AssertBucketNames(IEnumerable<Bucket> actualBuckets, string[] expectedNames)
        {
            // Intersection with known buckets to avoid non-test buckets causing issues.
            var actualNames = actualBuckets.Select(b => b.Name).Where(name => name.StartsWith(_fixture.BucketPrefix)).OrderBy(x => x).ToList();
            Assert.Equal(expectedNames.OrderBy(x => x), actualNames);
        }
    }
}
