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

using Google.Apis.Download;
using Google.Apis.Services;
using Google.Apis.Storage.v1;
using Google.Cloud.ClientTesting;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class DownloadObjectTest
    {
        private readonly StorageFixture _fixture;

        public DownloadObjectTest(StorageFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task SimpleDownload()
        {
            using (var stream = new MemoryStream())
            {
                await _fixture.Client.DownloadObjectAsync(_fixture.ReadBucket, _fixture.SmallObject, stream);
                Assert.Equal(_fixture.SmallContent, stream.ToArray());
            }
        }

        [Fact]
        public async Task MetadataReturned_Simple()
        {
            var expected = await _fixture.Client.GetObjectAsync(_fixture.ReadBucket, _fixture.SmallObject);
            var actual = await _fixture.Client.DownloadObjectAsync(_fixture.ReadBucket, _fixture.SmallObject, Stream.Null);

            // Just test the values we expect to be populated
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.Bucket, actual.Bucket);
            Assert.Equal(expected.Generation, actual.Generation);
            Assert.Equal(expected.Metageneration, actual.Metageneration);
            Assert.Equal(expected.ETag, actual.ETag);
            Assert.Equal(expected.Crc32c, actual.Crc32c);
            Assert.Equal(expected.Md5Hash, actual.Md5Hash);
            Assert.Equal(expected.ContentType, actual.ContentType);
        }

        [Fact]
        public void MetadataReturned_WithRange()
        {
            var expected = _fixture.Client.GetObject(_fixture.ReadBucket, _fixture.SmallObject);
            var options = new DownloadObjectOptions { Range = new RangeHeaderValue(0, 3) };
            var actual = _fixture.Client.DownloadObject(_fixture.ReadBucket, _fixture.SmallObject, Stream.Null, options);

            // The CRC32C hash will be just for the range downloaded
            Assert.NotEqual(expected.Crc32c, actual.Crc32c);
            // The MD5 won't be populated at all
            Assert.Null(actual.Md5Hash);

            // Simple values are still populated.
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.Bucket, actual.Bucket);
            Assert.Equal(expected.Generation, actual.Generation);
            Assert.Equal(expected.Metageneration, actual.Metageneration);
            Assert.Equal(expected.ETag, actual.ETag);
            Assert.Equal(expected.ContentType, actual.ContentType);
        }

        [Fact]
        public void WrongObjectName() => ValidateNotFound(_fixture.ReadBucket, "doesntexist");

        [Fact]
        public Task WrongObjectName_Async() => ValidateNotFoundAsync(_fixture.ReadBucket, "doesntexist");

        [Fact]
        public void WrongBucketName() => ValidateNotFound(_fixture.BucketPrefix + "doesntexist", "doesntexist");

        [Fact]
        public Task WrongBucketName_Async() => ValidateNotFoundAsync(_fixture.BucketPrefix + "doesntexist", "doesntexist");

        private void ValidateNotFound(string bucket, string objectName)
        {
            var stream = new MemoryStream();
            var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.DownloadObject(bucket, objectName, stream));
            Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
        }

        private async Task ValidateNotFoundAsync(string bucket, string objectName)
        {
            var stream = new MemoryStream();
            var exception = await Assert.ThrowsAsync<GoogleApiException>(() => _fixture.Client.DownloadObjectAsync(bucket, objectName, stream));
            Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
        }

        [Fact]
        public async Task ChunkSize()
        {
            int chunks = 0;
            var progress = new Progress<IDownloadProgress> (p => chunks++);
            using (var stream = new MemoryStream())
            {
                await _fixture.Client.DownloadObjectAsync(
                    _fixture.ReadBucket, _fixture.LargeObject, stream,
                    new DownloadObjectOptions { ChunkSize = 2 * 1024 },
                    CancellationToken.None,
                    progress);
                Assert.Equal(_fixture.LargeContent, stream.ToArray());
                Assert.True(chunks >= 5);
            }
        }

        [Fact]
        public void DownloadObjectFromInvalidBucket()
        {
            Assert.Throws<ArgumentException>(() => _fixture.Client.DownloadObject("!!!", _fixture.LargeObject, new MemoryStream()));
        }

        [Fact]
        public void DownloadObjectWrongGeneration()
        {
            var existing = GetLatestVersionOfMultiversionObject();
            var stream = new MemoryStream();
            var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.DownloadObject(existing, stream,
                new DownloadObjectOptions { Generation = existing.Generation + 1 }, null));
            Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
            Assert.Equal(0, stream.Length);
        }

        [Fact]
        public void DownloadDifferentGenerations()
        {
            var bucket = _fixture.ReadBucket;
            var name = _fixture.SmallThenLargeObject;
            var objects = _fixture.Client.ListObjects(bucket, name, new ListObjectsOptions { Versions = true }).ToList();
            Assert.Equal(2, objects.Count);

            // Fetch them by generation and check size matches
            foreach (var obj in objects)
            {
                var stream = new MemoryStream();
                _fixture.Client.DownloadObject(bucket, name, stream, new DownloadObjectOptions { Generation = obj.Generation }, null);
                Assert.Equal((long) obj.Size, stream.Length);
            }
        }

        [Fact]
        public void SpecifyingObjectSourceIgnoredGeneration()
        {
            var bucket = _fixture.ReadBucket;
            var name = _fixture.SmallThenLargeObject;
            var objects = _fixture.Client.ListObjects(bucket, name, new ListObjectsOptions { Versions = true })
                .OrderBy(x => x.Generation)
                .ToList();
            Assert.Equal(2, objects.Count);
            Assert.NotEqual(objects[0].Size, objects[1].Size);

            var stream = new MemoryStream();
            _fixture.Client.DownloadObject(objects[0], stream);
            Assert.Equal((long) objects[1].Size, stream.Length);
        }

        [Fact]
        public void DownloadObjectIfGenerationMatch_Matching()
        {
            var existing = GetLatestVersionOfMultiversionObject();
            var stream = new MemoryStream();
            _fixture.Client.DownloadObject(existing, stream,
                new DownloadObjectOptions { IfGenerationMatch = existing.Generation}, null);
            Assert.NotEqual(0, stream.Length);
        }

        [Fact]
        public void DownloadObjectIfGenerationMatch_NotMatching()
        {
            var existing = GetLatestVersionOfMultiversionObject();
            var stream = new MemoryStream();
            var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.DownloadObject(existing, stream,
                new DownloadObjectOptions { IfGenerationMatch = existing.Generation + 1 }, null));
            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
            Assert.Equal(0, stream.Length);
        }

        [Fact]
        public void DownloadObjectIfGenerationNotMatch_Matching()
        {
            var existing = GetLatestVersionOfMultiversionObject();
            var stream = new MemoryStream();
            var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.DownloadObject(existing, stream,
                new DownloadObjectOptions { IfGenerationNotMatch = existing.Generation }, null));
            Assert.Equal(HttpStatusCode.NotModified, exception.HttpStatusCode);
            Assert.Equal(0, stream.Length);
        }

        [Fact]
        public void DownloadObjectIfGenerationNotMatch_NotMatching()
        {
            var existing = GetLatestVersionOfMultiversionObject();
            var stream = new MemoryStream();
            _fixture.Client.DownloadObject(existing, stream,
                new DownloadObjectOptions { IfGenerationNotMatch = existing.Generation + 1 }, null);
            Assert.NotEqual(0, stream.Length);
        }

        [Fact]
        public void DownloadObject_IfGenerationMatchAndNotMatch()
        {
            Assert.Throws<ArgumentException>(() => _fixture.Client.DownloadObject(
                _fixture.ReadBucket, _fixture.SmallThenLargeObject, new MemoryStream(),
                new DownloadObjectOptions { IfGenerationMatch = 1, IfGenerationNotMatch = 2 },
                null));
        }

        [Fact]
        public void DownloadObjectIfMetagenerationMatch_Matching()
        {
            var existing = GetLatestVersionOfMultiversionObject();
            var stream = new MemoryStream();
            _fixture.Client.DownloadObject(existing, stream,
                new DownloadObjectOptions { IfMetagenerationMatch = existing.Metageneration}, null);
            Assert.NotEqual(0, stream.Length);
        }

        [Fact]
        public void DownloadObjectIfMetagenerationMatch_NotMatching()
        {
            var existing = GetLatestVersionOfMultiversionObject();
            var stream = new MemoryStream();
            var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.DownloadObject(existing, stream,
                new DownloadObjectOptions { IfMetagenerationMatch = existing.Metageneration + 1 }, null));
            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
            Assert.Equal(0, stream.Length);
        }

        [Fact]
        public void DownloadObjectIfMetagenerationNotMatch_Matching()
        {
            var existing = GetLatestVersionOfMultiversionObject();
            var stream = new MemoryStream();
            var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.DownloadObject(existing, stream,
                new DownloadObjectOptions { IfMetagenerationNotMatch = existing.Metageneration }, null));
            Assert.Equal(HttpStatusCode.NotModified, exception.HttpStatusCode);
            Assert.Equal(0, stream.Length);
        }

        [Fact]
        public void DownloadObjectIfMetagenerationNotMatch_NotMatching()
        {
            var existing = GetLatestVersionOfMultiversionObject();
            var stream = new MemoryStream();
            _fixture.Client.DownloadObject(existing, stream,
                new DownloadObjectOptions { IfMetagenerationNotMatch = existing.Metageneration + 1 }, null);
            Assert.NotEqual(0, stream.Length);
        }

        [Fact]
        public void DownloadObject_IfMetagenerationMatchAndNotMatch()
        {
            Assert.Throws<ArgumentException>(() => _fixture.Client.DownloadObject(
                _fixture.ReadBucket, _fixture.SmallThenLargeObject, new MemoryStream(),
                new DownloadObjectOptions { IfMetagenerationMatch = 1, IfMetagenerationNotMatch = 2 },
                null));
        }

        [Fact]
        public void DownloadObject_Range()
        {
            var stream = new MemoryStream();
            _fixture.Client.DownloadObject(_fixture.ReadBucket, _fixture.LargeObject, stream,
                new DownloadObjectOptions { Range = new RangeHeaderValue(2000, 2999) });
            var expected = _fixture.LargeContent.Skip(2000).Take(1000).ToArray();
            var actual = stream.ToArray();
            Assert.Equal(expected, actual);
        }

        [SkippableFact]
        public void DownloadGzippedFile()
        {
            TestEnvironment.SkipIfVpcSc();

            // The file has a Content-Encoding of gzip, and it's stored compressed.
            // We should still be able to download it, and the result should be the original plain text.
            var stream = new MemoryStream();
            _fixture.Client.DownloadObject(StorageFixture.TestBucket, "gzipped-text.txt", stream);
            var expected = Encoding.UTF8.GetBytes("hello world");
            var actual = stream.ToArray();
            Assert.Equal(expected, actual);
        }

        // See https://github.com/googleapis/google-cloud-dotnet/issues/1784 for the background to
        // the following two tests.
        [SkippableFact(Skip = "https://github.com/googleapis/google-cloud-dotnet/issues/1784")]
        public void DownloadGzippedFile_NoClientDecompression()
        {
            TestEnvironment.SkipIfVpcSc();

            var service = new StorageService(new BaseClientService.Initializer
            {
                HttpClientInitializer = _fixture.Client.Service.HttpClientInitializer,
                GZipEnabled = false
            });
            var client = new StorageClientImpl(service);
            var stream = new MemoryStream();
            client.DownloadObject(StorageFixture.TestBucket, "gzipped-text.txt", stream);
            var expected = Encoding.UTF8.GetBytes("hello world");
            var actual = stream.ToArray();
            Assert.Equal(expected, actual);
        }

        [SkippableFact]
        public void DownloadGzippedFile_NoClientDecompression_IgnoreHash()
        {
            TestEnvironment.SkipIfVpcSc();

            var service = new StorageService(new BaseClientService.Initializer
            {
                HttpClientInitializer = _fixture.Client.Service.HttpClientInitializer,
                GZipEnabled = false
            });
            var client = new StorageClientImpl(service);
            var stream = new MemoryStream();
            client.DownloadObject(StorageFixture.TestBucket, "gzipped-text.txt", stream,
                new DownloadObjectOptions { DownloadValidationMode = DownloadValidationMode.Never });
            var expected = Encoding.UTF8.GetBytes("hello world");
            var actual = stream.ToArray();
            Assert.Equal(expected, actual);
        }

        [SkippableFact]
        public void DownloadGzippedFile_NoClientDecompression_AutomaticValidationMode()
        {
            TestEnvironment.SkipIfVpcSc();

            var service = new StorageService(new BaseClientService.Initializer
            {
                HttpClientInitializer = _fixture.Client.Service.HttpClientInitializer,
                GZipEnabled = false
            });
            var client = new StorageClientImpl(service);
            var stream = new MemoryStream();
            var obj = client.DownloadObject(StorageFixture.TestBucket, "gzipped-text.txt", stream,
                new DownloadObjectOptions { DownloadValidationMode = DownloadValidationMode.Automatic });
            var expected = Encoding.UTF8.GetBytes("hello world");
            var actual = stream.ToArray();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InvalidDownloadValidationMode()
        {
            var options = new DownloadObjectOptions { DownloadValidationMode = (DownloadValidationMode) 12345 };
            Assert.Throws<ArgumentException>(() => _fixture.Client.DownloadObject(_fixture.ReadBucket, "irrelevant.txt", new MemoryStream(), options));
        }

        private Object GetLatestVersionOfMultiversionObject()
        {
            var service = _fixture.Client.Service;
            return service.Objects.Get(_fixture.ReadBucket, _fixture.SmallThenLargeObject).Execute();
        }
    }
}
