// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.
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
    public class ListBucketsTest
    {
        // TODO:
        // - Test actual pagination when we can set the page size
        // - Test searching likewise
        // - Test async lazy listing when we have that
        // - Automate creating the buckets etc

        private readonly CloudConfiguration config = CloudConfiguration.Instance;

        [Fact]
        public void ExpectedBucketsAreListed_SyncList()
        {
            var buckets = config.Client.ListBuckets(config.Project);
            ValidateBuckets(buckets);
        }

        [Fact]
        public async Task ExpectedBucketsAreListed_AsyncListAll()
        {
            var buckets = await config.Client.ListAllBucketsAsync(config.Project);
            ValidateBuckets(buckets);
        }

        [Fact]
        public async Task CancellationTokenRespected()
        {
            var cts = new CancellationTokenSource();
            cts.Cancel();
            await Assert.ThrowsAnyAsync<OperationCanceledException>(async () => await config.Client.ListAllBucketsAsync(config.Project, cts.Token));
        }

        private void ValidateBuckets(IEnumerable<Bucket> buckets)
        {
            var names = buckets.Select(b => b.Name).ToList();
            for (int i = 0; i < 9; i++)
            {
                Assert.Contains(config.TempBucketPrefix + i, names);
            }
        }
    }
}
