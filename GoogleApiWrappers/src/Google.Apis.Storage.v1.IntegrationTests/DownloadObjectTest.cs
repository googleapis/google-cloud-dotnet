// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Apis.Download;
using Google.Apis.Storage.v1.ClientWrapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Storage.v1.IntegrationTests
{
    // Preconditions:
    // - Logged in locally with gcloud auth
    // - Environment variable TEST_PROJECT identifies an existing project
    // - One bucket called "integrationtests-1" containing a "large" file (more than 10K)
    //   folder/sampledata.txt beginning with "START" and ending with "END".
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
    }
}
