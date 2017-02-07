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

using Google.Apis.Upload;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    using static TestHelpers;

    [Collection(nameof(StorageFixture))]
    public class UploadObjectTest
    {
        private readonly StorageFixture _fixture;

        public UploadObjectTest(StorageFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void SimpleUpload()
        {
            var name = GenerateName();
            var contentType = "application/octet-stream";
            var source = GenerateData(100);
            var result = _fixture.Client.UploadObject(_fixture.MultiVersionBucket, name, contentType, source);
            Assert.Equal(_fixture.MultiVersionBucket, result.Bucket);
            Assert.Equal(name, result.Name);
            Assert.Equal(contentType, result.ContentType);
            ValidateData(_fixture.MultiVersionBucket, name, source);
        }

        [Fact]
        public void UploadWithObject()
        {
            var destination = new Object
            {
                Bucket = _fixture.MultiVersionBucket,
                Name = GenerateName(),
                ContentType = "test/type",
                ContentDisposition = "attachment",
                Metadata = new Dictionary<string, string> { { "x", "y" } }
            };
            var source = GenerateData(100);
            var result = _fixture.Client.UploadObject(destination, source);
            Assert.NotSame(destination, result);
            Assert.Equal(destination.Name, result.Name);
            Assert.Equal(destination.Bucket, result.Bucket);
            Assert.Equal(destination.ContentType, result.ContentType);
            Assert.Equal(destination.ContentDisposition, result.ContentDisposition);
            Assert.Equal(destination.Metadata, result.Metadata);
            ValidateData(_fixture.MultiVersionBucket, destination.Name, source);
        }

        [Fact]
        public async Task UploadAsyncWithProgress()
        {
            var chunks = 2;
            var name = GenerateName();
            var contentType = "application/octet-stream";
            var source = GenerateData(UploadObjectOptions.MinimumChunkSize * chunks);
            int progressCount = 0;
            var progress = new Progress<IUploadProgress>(p => progressCount++);
            var result = await _fixture.Client.UploadObjectAsync(_fixture.MultiVersionBucket, name, contentType, source,
                new UploadObjectOptions { ChunkSize = UploadObjectOptions.MinimumChunkSize },
                CancellationToken.None, progress);
            Assert.Equal(chunks + 1, progressCount); // Should start with a 0 progress
            Assert.Equal(name, result.Name); // Assume the rest of the properties are okay...
            ValidateData(_fixture.MultiVersionBucket, name, source);
        }

        [Fact]
        public void ReplaceObject()
        {
            var client = _fixture.Client;
            var bucket = _fixture.MultiVersionBucket;
            var name = GenerateName();
            var contentType = "application/octet-stream";
            var source1 = GenerateData(100);
            var firstVersion = client.UploadObject(bucket, name, contentType, source1);
            ValidateData(_fixture.MultiVersionBucket, name, source1);
            var source2 = GenerateData(50);
            firstVersion.ContentType = "application/x-replaced";

            // Clear hash and cache information, as we're changing the data.
            firstVersion.Crc32c = null;
            firstVersion.ETag = null;
            firstVersion.Md5Hash = null;
            var secondVersion = client.UploadObject(firstVersion, source2);
            ValidateData(_fixture.MultiVersionBucket, name, source2);
            Assert.NotEqual(firstVersion.Generation, secondVersion.Generation);
            Assert.Equal(firstVersion.ContentType, secondVersion.ContentType); // The modified content type should stick

            // When we ask for the first generation, we get the original data back.
            var firstGenerationData = new MemoryStream();
            client.DownloadObject(firstVersion, firstGenerationData, new DownloadObjectOptions { Generation = firstVersion.Generation }, null);
            Assert.Equal(source1.ToArray(), firstGenerationData.ToArray());
        }

        [Fact]
        public void UploadObjectIfGenerationMatch_NewFile()
        {
            var stream = GenerateData(50);
            var name = GenerateName();
            var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.UploadObject(
                _fixture.MultiVersionBucket, name, "", stream,
                new UploadObjectOptions { IfGenerationMatch = 100 }, null));
        }

        [Fact]
        public void UploadObjectIfGenerationMatch_Matching()
        {
            var existing = GetExistingObject();
            var stream = GenerateData(50);
            _fixture.Client.UploadObject(existing, stream,
                new UploadObjectOptions { IfGenerationMatch = existing.Generation }, null);
        }

        [Fact]
        public void UploadObjectIfGenerationMatch_NotMatching()
        {
            var existing = GetExistingObject();
            var stream = GenerateData(50);
            var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.UploadObject(existing, stream,
                new UploadObjectOptions { IfGenerationMatch = existing.Generation + 1 }, null));
            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
        }

        [Fact]
        public void UploadObjectIfGenerationNotMatch_Matching()
        {
            var existing = GetExistingObject();
            var stream = GenerateData(50);
            var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.UploadObject(existing, stream,
                new UploadObjectOptions { IfGenerationNotMatch = existing.Generation }, null));
            Assert.Equal(HttpStatusCode.NotModified, exception.HttpStatusCode);
        }

        [Fact]
        public void UploadObjectIfGenerationNotMatch_NotMatching()
        {
            var existing = GetExistingObject();
            var stream = GenerateData(50);
            _fixture.Client.UploadObject(existing, stream,
                new UploadObjectOptions { IfGenerationNotMatch = existing.Generation + 1 }, null);
        }

        [Fact]
        public void UploadObject_IfGenerationMatchAndNotMatch()
        {
            Assert.Throws<ArgumentException>(() => _fixture.Client.UploadObject(_fixture.MultiVersionBucket, GenerateName(), "", new MemoryStream(),
                new UploadObjectOptions { IfGenerationMatch = 1, IfGenerationNotMatch = 2 },
                null));
        }

        [Fact]
        public void UploadObjectIfMetagenerationMatch_Matching()
        {
            var existing = GetExistingObject();
            var stream = GenerateData(50);
            _fixture.Client.UploadObject(existing, stream,
                new UploadObjectOptions { IfMetagenerationMatch = existing.Metageneration }, null);
        }

        [Fact]
        public void UploadObjectIfMetagenerationMatch_NotMatching()
        {
            var existing = GetExistingObject();
            var stream = GenerateData(50);
            var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.UploadObject(existing, stream,
                new UploadObjectOptions { IfMetagenerationMatch = existing.Metageneration + 1 }, null));
            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
        }

        [Fact]
        public void UploadObjectIfMetagenerationNotMatch_Matching()
        {
            var existing = GetExistingObject();
            var stream = GenerateData(50);
            var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.UploadObject(existing, stream,
                new UploadObjectOptions { IfMetagenerationNotMatch = existing.Metageneration }, null));
            Assert.Equal(HttpStatusCode.NotModified, exception.HttpStatusCode);
        }

        [Fact]
        public void UploadObjectIfMetagenerationNotMatch_NotMatching()
        {
            var existing = GetExistingObject();
            var stream = GenerateData(50);
            _fixture.Client.UploadObject(existing, stream,
                new UploadObjectOptions { IfMetagenerationNotMatch = existing.Metageneration + 1 }, null);
        }

        [Fact]
        public void UploadObject_IfMetagenerationMatchAndNotMatch()
        {
            Assert.Throws<ArgumentException>(() => _fixture.Client.UploadObject(_fixture.MultiVersionBucket, GenerateName(), "", new MemoryStream(),
                new UploadObjectOptions { IfMetagenerationMatch = 1, IfMetagenerationNotMatch = 2 },
                null));
        }

        [Fact]
        public void UploadObject_NullContentType()
        {
            _fixture.Client.UploadObject(_fixture.MultiVersionBucket, GenerateName(), null, new MemoryStream());
        }

        private Object GetExistingObject()
        {
            var obj = _fixture.Client.UploadObject(_fixture.MultiVersionBucket, GenerateName(), "application/octet-stream", GenerateData(100));
            // Clear hash and cache information, ready for a new version.
            obj.Crc32c = null;
            obj.ETag = null;
            obj.Md5Hash = null;
            return obj;
        }
    }
}
