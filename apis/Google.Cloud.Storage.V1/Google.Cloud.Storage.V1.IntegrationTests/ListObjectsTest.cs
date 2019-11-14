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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class ListObjectsTest
    {
        private readonly StorageFixture _fixture;

        public ListObjectsTest(StorageFixture fixture)
        {
            _fixture = fixture;
        }

        [Theory]
        [InlineData(null)]
        [InlineData(4)]
        public async Task AllObjects(int? pageSize)
        {
            var options = new ListObjectsOptions { PageSize = pageSize };
            await AssertObjects(null, options, _fixture.ReadBucketObjects.ToArray());
        }

        [Fact]
        public void ResumeWithPageToken()
        {
            string bucket = _fixture.ReadBucket;
            var client = _fixture.Client;
            var totalCount = _fixture.ReadBucketObjects.Count();
            // We want to check that when reading the remained, we still need to paginate.
            // (If we had a bug that always used the original page token, we'd end up in an infinite loop.)
            Assert.True(totalCount > 4, "Must have more than 4 objects for pagination test");
            var firstPage = client.ListObjects(bucket).ReadPage(2);
            Assert.NotNull(firstPage.NextPageToken);

            var options = new ListObjectsOptions { PageSize = 2, PageToken = firstPage.NextPageToken };
            var remainder = client.ListObjects(bucket, prefix: null, options).ToList();
            Assert.Equal(totalCount - 2, remainder.Count);
        }

        // Note: this test unfortunately relies on the test data, but in a way which is hard to make "safe"
        // using the fixture.
        [Theory]
        [InlineData(null, "small.txt,large.txt,small_then_large.txt")]
        [InlineData("la", "large.txt")]
        [InlineData("a/", "a/o1.txt,a/o2.txt")]
        [InlineData("a/x/", "a/x/o3.txt,a/x/o4.txt")]
        [InlineData("missing/", "")]
        public async Task PrefixAndDelimiter(string prefix, string expectedNames)
        {
            var options = new ListObjectsOptions { Delimiter = "/" };
            await AssertObjects(prefix, options, expectedNames.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
        }

        [Fact]
        public async Task CancellationTokenRespected()
        {
            var cts = new CancellationTokenSource();
            var task = _fixture.Client.ListObjectsAsync(_fixture.ReadBucket, null).ToListAsync(cts.Token);
            cts.Cancel();
            await Assert.ThrowsAnyAsync<OperationCanceledException>(async () => await task);            
        }

        [Fact]
        public async Task MultipleVersions()
        {
            var name = _fixture.SmallThenLargeObject;

            // List the versions separately
            await AssertObjects(name, new ListObjectsOptions { Versions = true }, name, name);
            // Explicitly don't list the versions separately
            await AssertObjects(name, new ListObjectsOptions { Versions = false }, name);
            // Implicitly don't list the versions separately (the API default)
            await AssertObjects(name, null, name);
        }

        private async Task AssertObjects(string prefix, ListObjectsOptions options, params string[] expectedNames)
        {
            IEnumerable<Object> actual = _fixture.Client.ListObjects(_fixture.ReadBucket, prefix, options);
            AssertObjectNames(actual, expectedNames);
            actual = await _fixture.Client.ListObjectsAsync(_fixture.ReadBucket, prefix, options).ToListAsync();
            AssertObjectNames(actual, expectedNames);
        }

        private void AssertObjectNames(IEnumerable<Object> actualObjects, string[] expectedNames)
        {
            var actualNames = actualObjects.Select(x => x.Name).OrderBy(x => x).ToList();
            Assert.Equal(expectedNames.OrderBy(x => x), actualNames);
        }
    }
}
