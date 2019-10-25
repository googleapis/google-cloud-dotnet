// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Apis.Download;
using Google.Apis.Requests;
using Google.Apis.Util;
using System;
using Xunit;

namespace Google.Cloud.Storage.V1.Tests
{
    public class DownloadObjectOptionsTest
    {
        [Fact]
        public void ModifyDownloader_DefaultOptions()
        {
            var downloader = new MediaDownloader(null);
            var options = new DownloadObjectOptions();
            options.ModifyDownloader(downloader);
            Assert.Equal(MediaDownloader.MaximumChunkSize, downloader.ChunkSize);
        }

        [Fact]
        public void ModifyDownloader_WithChunkSize()
        {
            var downloader = new MediaDownloader(null);
            var options = new DownloadObjectOptions { ChunkSize = 2048 };
            options.ModifyDownloader(downloader);
            Assert.Equal(2048, downloader.ChunkSize);
        }

        [Fact]
        public void GetUri_PositiveMatchOptions()
        {
            var options = new DownloadObjectOptions
            {
                IfGenerationMatch = 1L,
                IfMetagenerationMatch = 2L,
                Generation = 3L,
                UserProject = "my proj"
            };
            var builder = new RequestBuilder { BaseUri = new Uri("http://url/"), Path = "foo" };
            options.ModifyRequestBuilder(builder);
            // The replacement here simplifies the tests, to avoid needing to care which query parameter was first.
            var uri = builder.BuildUri().AbsoluteUri.Replace('?', '&');
            Assert.Contains("&ifGenerationMatch=1", uri);
            Assert.Contains("&ifMetagenerationMatch=2", uri);
            Assert.Contains("&generation=3", uri);
            // I don't expect project IDs to actually need escaping, but let's check that it works.
            Assert.Contains("&userProject=my%20proj", uri);
        }

        [Fact]
        public void ModifyDownloader_NegativeMatchOptions()
        {
            var options = new DownloadObjectOptions
            {
                IfGenerationNotMatch = 1L,
                IfMetagenerationNotMatch = 2L,
                Generation = 3L
            };
            var builder = new RequestBuilder { BaseUri = new Uri("http://url/"), Path = "foo" };
            options.ModifyRequestBuilder(builder);
            // The replacement here simplifies the tests, to avoid needing to care which query parameter was first.
            var uri = builder.BuildUri().AbsoluteUri.Replace('?', '&');
            Assert.Contains("&ifGenerationNotMatch=1", uri);
            Assert.Contains("&ifMetagenerationNotMatch=2", uri);
            Assert.Contains("&generation=3", uri);
        }

        [Fact]
        public void GetUri_MatchNotMatchConflicts()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var options = new DownloadObjectOptions { IfGenerationMatch = 1L, IfGenerationNotMatch = 2L };
                var builder = new RequestBuilder { BaseUri = new Uri("http://url/"), Path = "foo" };
                options.ModifyRequestBuilder(builder);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                var options = new DownloadObjectOptions { IfMetagenerationMatch = 1L, IfMetagenerationNotMatch = 2L };
                var builder = new RequestBuilder { BaseUri = new Uri("http://url/"), Path = "foo" };
                options.ModifyRequestBuilder(builder);
            });
        }
    }
}
