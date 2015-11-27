// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.
using Google.Apis.Storage.v1.ClientWrapper;
using Google.Apis.Storage.v1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Storage.v1.IntegrationTests
{
    // Preconditions:
    // - Logged in locally with gcloud auth
    // - Environment variable TEST_PROJECT identifies an existing project
    // - Buckets exist called "integrationtests-0", "integrationtests-1" etc.
    // - One bucket called "integrationtests-extra"
    public class ListBucketsTest
    {
        // TODO:
        // - Automate creating the buckets etc

        private readonly CloudConfiguration config = CloudConfiguration.Instance;

        [Fact]
        public void AllBuckets_SyncList()
        {
            var buckets = config.Client.ListBuckets(config.Project);
            ValidateBuckets(buckets);
        }

        [Fact]
        public async Task AllBuckets_AsyncListAll()
        {
            var buckets = await config.Client.ListAllBucketsAsync(config.Project);
            ValidateBuckets(buckets);
        }

        [Fact]
        public void AllBuckets_PageSize4_SyncList()
        {
            var buckets = config.Client.ListBuckets(config.Project, new ListBucketsOptions { PageSize = 4 });
            ValidateBuckets(buckets);
        }

        [Fact]
        public async Task AllBuckets_PageSize4_AsyncListAll()
        {
            var buckets = await config.Client.ListAllBucketsAsync(
                config.Project, new ListBucketsOptions { PageSize = 4 }, CancellationToken.None);
            ValidateBuckets(buckets);
        }

        [Fact]
        public void Prefix_SyncList()
        {
            var buckets = config.Client.ListBuckets(config.Project,
                new ListBucketsOptions { Prefix = config.TempBucketPrefix + "e" }).ToList();
            Assert.Equal(1, buckets.Count);
            Assert.Equal(config.TempBucketPrefix + "extra", buckets[0].Name);
        }

        [Fact]
        public async Task Prefix_AsyncSyncList()
        {
            var buckets = await config.Client.ListBucketsAsync(config.Project,
                new ListBucketsOptions { Prefix = config.TempBucketPrefix + "e" }).ToList();
            Assert.Equal(1, buckets.Count);
            Assert.Equal(config.TempBucketPrefix + "extra", buckets[0].Name);
        }

        [Fact]
        public async Task CancellationTokenRespected()
        {
            var cts = new CancellationTokenSource();
            cts.Cancel();
            await Assert.ThrowsAnyAsync<OperationCanceledException>
                (async () => await config.Client.ListAllBucketsAsync(config.Project, null, cts.Token));
        }

        private void ValidateBuckets(IEnumerable<Bucket> buckets)
        {
            var names = buckets.Select(b => b.Name).ToList();
            for (int i = 0; i < 9; i++)
            {
                Assert.Contains(config.TempBucketPrefix + i, names);
            }
            Assert.Contains(config.TempBucketPrefix + "extra", names);
        }
    }
}
