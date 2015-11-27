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
    // - Bucket called "integrationtests-0" containing the objects listed in s_expectedObjects.
    public class ListObjectsTest
    {
        private static readonly string[] s_expectedObjectNames =
            { "foo.txt", "bar.txt", "a/", "a/o1.txt", "a/o2.txt", "a/x/", "a/x/o3.txt", "a/x/o4.txt", "b/", "b/o5.txt" };

        private readonly CloudConfiguration config = CloudConfiguration.Instance;
        private readonly string bucket;

        public ListObjectsTest()
        {
            bucket = config.TempBucketPrefix + "0";
        }

        [Fact]
        public void AllObjects_SyncList()
        {
            var objects = config.Client.ListObjects(bucket);
            ValidateObjects(objects, s_expectedObjectNames);
        }

        [Fact]
        public async Task AllObjects_AsyncListAll()
        {
            var objects = await config.Client.ListAllObjectsAsync(bucket);
            ValidateObjects(objects, s_expectedObjectNames);
        }

        [Fact]
        public void AllObjects_PageSize4_SyncList()
        {
            var objects = config.Client.ListObjects(bucket, new ListObjectsOptions { PageSize = 4 });
            ValidateObjects(objects, s_expectedObjectNames);
        }

        [Fact]
        public async Task AllObjects_PageSize4_AsyncListAll()
        {
            var objects = await config.Client.ListAllObjectsAsync(
                bucket, new ListObjectsOptions { PageSize = 4 }, CancellationToken.None);
            ValidateObjects(objects, s_expectedObjectNames);
        }

        [Fact]
        public void Prefix_SyncList()
        {
            var objects = config.Client.ListObjects(bucket,
                new ListObjectsOptions { Prefix = "fo" }).ToList();
            ValidateObjects(objects, new[] { "foo.txt" });
        }

        [Fact]
        public async Task Prefix_AsyncList()
        {
            var objects = await config.Client.ListObjectsAsync(bucket,
                new ListObjectsOptions { Prefix = "fo" }).ToList();
            ValidateObjects(objects, new[] { "foo.txt" });
        }

        [Theory]
        [InlineData(null, "foo.txt,bar.txt")]
        [InlineData("a/", "a/,a/o1.txt,a/o2.txt")]
        [InlineData("a/x/", "a/x/,a/x/o3.txt,a/x/o4.txt")]
        [InlineData("missing/", "")]
        public void PrefixAndDelimiter_SyncList(string prefix, string expectedNames)
        {
            var objects = config.Client.ListObjects(bucket,
                new ListObjectsOptions { Prefix = prefix, Delimiter = "/" }).ToList();
            ValidateObjects(objects, expectedNames.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
        }

        [Theory]
        [InlineData(null, "foo.txt,bar.txt")]
        [InlineData("a/", "a/,a/o1.txt,a/o2.txt")]
        [InlineData("a/x/", "a/x/,a/x/o3.txt,a/x/o4.txt")]
        [InlineData("missing/", "")]
        public async Task PrefixAndDelimiter_AsyncList(string prefix, string expectedNames)
        {
            var objects = await config.Client.ListObjectsAsync(bucket,
                new ListObjectsOptions { Prefix = prefix, Delimiter = "/" }).ToList();
            ValidateObjects(objects, expectedNames.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
        }

        [Fact]
        public async Task CancellationTokenRespected()
        {
            var cts = new CancellationTokenSource();
            cts.Cancel();
            await Assert.ThrowsAnyAsync<OperationCanceledException>
                (async () => await config.Client.ListAllObjectsAsync(bucket, null, cts.Token));
        }

        private void ValidateObjects(IEnumerable<Google.Apis.Storage.v1.Data.Object> objects, IEnumerable<string> expectedNames)
        {
            var names = objects.Select(b => b.Name).OrderBy(x => x).ToList();
            Assert.Equal(expectedNames.OrderBy(x => x), names);
        }
    }
}
