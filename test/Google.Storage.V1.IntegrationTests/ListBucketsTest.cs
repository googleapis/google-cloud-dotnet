// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Storage.V1;
using Google.Apis.Storage.v1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Storage.V1.IntegrationTests
{
    public class ListBucketsTest
    {
        private static readonly CloudConfiguration s_config = CloudConfiguration.Instance;

        private static readonly string s_extraBucket = s_config.TempBucketPrefix + "extra";
        private static readonly string[] s_allKnownBuckets = Enumerable
                .Range(0, 10)
                .Select(x => s_config.TempBucketPrefix + x)
                .Concat(new[] { s_extraBucket })
                .ToArray();

        [Theory]
        [InlineData(null, null)]
        [InlineData(null, "_integ")]
        [InlineData(4, null)]
        public async Task AllBuckets(int? pageSize, string prefix)
        {
            var options = new ListBucketsOptions { PageSize = pageSize, Prefix = s_config.Project + prefix };
            await AssertBuckets(options, s_allKnownBuckets);
        }

        [Fact]
        public async Task Prefix()
        {
            var options = new ListBucketsOptions { Prefix = s_config.TempBucketPrefix + "e" };
            await AssertBuckets(options, s_extraBucket);
        }

        [Fact]
        public async Task CancellationTokenRespected()
        {
            var cts = new CancellationTokenSource();
            var task = s_config.Client.ListAllBucketsAsync(s_config.Project, cancellationToken: cts.Token);
            cts.Cancel();
            await Assert.ThrowsAnyAsync<OperationCanceledException>(async () => await task);
        }

        // Fetches buckets using the given options in each possible way, validating that the expected bucket names are returned.
        private async Task AssertBuckets(ListBucketsOptions options, params string[] expectedBucketNames)
        {
            IEnumerable<Bucket> actual = s_config.Client.ListBuckets(s_config.Project, options);
            AssertBucketNames(actual, expectedBucketNames);
            actual = await s_config.Client.ListAllBucketsAsync(s_config.Project, options, CancellationToken.None);
            AssertBucketNames(actual, expectedBucketNames);
        }

        private void AssertBucketNames(IEnumerable<Bucket> actualBuckets, string[] expectedNames)
        {
            // Intersection with known buckets to avoid non-test buckets causing issues.
            var actualNames = actualBuckets.Select(b => b.Name).Intersect(s_allKnownBuckets).OrderBy(x => x).ToList();
            Assert.Equal(expectedNames.OrderBy(x => x), actualNames);
        }
    }
}
