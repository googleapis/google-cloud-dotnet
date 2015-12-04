// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Apis.Download;
using Google.Apis.Storage.v1.ClientWrapper;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Storage.v1.IntegrationTests
{
    public class DownloadObjectTest
    {
        private static readonly CloudConfiguration s_config = CloudConfiguration.Instance;

        private static readonly string s_bucket = s_config.TempBucketPrefix + "1";
        private const string s_name = "folder/sampledata.txt";

        [Fact]
        public async Task SimpleDownload()
        {
            using (var stream = new MemoryStream())
            {
                await s_config.Client.DownloadObjectAsync(s_bucket, s_name, stream);
                var text = Encoding.UTF8.GetString(stream.ToArray());
                Assert.StartsWith("START", text);
                Assert.EndsWith("END", text);
            }
        }

        [Fact(Skip = "Waiting for change in MediaDownloader to land in NuGet")]
        public async Task WrongName()
        {
            using (var stream = new MemoryStream())
            {
                await Assert.ThrowsAnyAsync<Exception>(() => s_config.Client.DownloadObjectAsync(s_bucket, s_name + "doesntexist", stream));
            }
        }

        [Fact]
        public async Task ChunkSize()
        {
            int chunks = 0;
            var progress = new Progress<IDownloadProgress> (p => chunks++);
            using (var stream = new MemoryStream())
            {
                await s_config.Client.DownloadObjectAsync(s_bucket, s_name, stream,
                    new DownloadObjectOptions { ChunkSize = 2 * 1024 },
                    CancellationToken.None,
                    progress);
                var text = Encoding.UTF8.GetString(stream.ToArray());
                Assert.StartsWith("START", text);
                Assert.EndsWith("END", text);
                Assert.True(chunks >= 5);
            }
        }

        [Fact]
        public async Task Cancellation()
        {
            var cts = new CancellationTokenSource();
            var progress = new Progress<IDownloadProgress>(p =>
            {
                if (p.BytesDownloaded > 5000)
                {
                    cts.Cancel();
                }
            });
            using (var stream = new MemoryStream())
            {
                await Assert.ThrowsAnyAsync<OperationCanceledException>(() => s_config.Client.DownloadObjectAsync(s_bucket, s_name, stream,
                    new DownloadObjectOptions { ChunkSize = 2 * 1024 },
                    cts.Token,
                    progress));
            }
        }

        [Fact]
        public void DownloadObjectFromInvalidBucket()
        {
            Assert.Throws<ArgumentException>(() => s_config.Client.DownloadObject("!!!", s_name, new MemoryStream()));
        }

        [Fact(Skip = "Waiting for change in MediaDownloader to land in NuGet")]
        public void DownloadObjectWrongGeneration()
        {
            var existing = GetExistingObject();
            var stream = new MemoryStream();
            Assert.Throws<ArgumentException>(() => s_config.Client.DownloadObject(existing, stream,
                new DownloadObjectOptions { Generation = existing.Generation + 1 }, null));
            Assert.Equal(0, stream.Length);
        }

        [Fact]
        public void DownloadDifferentGenerations()
        {
            var bucket = s_config.TempBucketPrefix + "0";
            var name = "multiversion.txt";
            var objects = s_config.Client.ListObjects(bucket, name, new ListObjectsOptions { Versions = true }).ToList();
            Assert.Equal(2, objects.Count);

            // Fetch them by generation and check size matches
            foreach (var obj in objects)
            {
                var stream = new MemoryStream();
                s_config.Client.DownloadObject(bucket, name, stream, new DownloadObjectOptions { Generation = obj.Generation }, null);
                Assert.Equal((long) obj.Size, stream.Length);
            }
        }

        [Fact]
        public void SpecifyingObjectSourceIgnoredGeneration()
        {
            var bucket = s_config.TempBucketPrefix + "0";
            var name = "multiversion.txt";
            var objects = s_config.Client.ListObjects(bucket, name, new ListObjectsOptions { Versions = true }).OrderBy(x => x.Generation).ToList();
            Assert.Equal(2, objects.Count);
            Assert.NotEqual(objects[0].Size, objects[1].Size);

            var stream = new MemoryStream();
            s_config.Client.DownloadObject(objects[0], stream);
            Assert.Equal((long) objects[1].Size, stream.Length);
        }

        [Fact]
        public void DownloadObjectRightGeneration()
        {
            var existing = GetExistingObject();
            var stream = new MemoryStream();
            s_config.Client.DownloadObject(existing, stream,
                new DownloadObjectOptions { Generation = existing.Generation }, null);
            Assert.NotEqual(0, stream.Length);
        }

        private Data.Object GetExistingObject()
        {
            var service = s_config.Client.Service;
            return service.Objects.Get(s_bucket, s_name).Execute();
        }
    }
}
