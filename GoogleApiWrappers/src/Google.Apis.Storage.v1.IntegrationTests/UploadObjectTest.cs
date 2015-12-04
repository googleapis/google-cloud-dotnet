// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Apis.Storage.v1.ClientWrapper;
using Google.Apis.Upload;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Apis.Storage.v1.IntegrationTests.TestHelpers;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Apis.Storage.v1.IntegrationTests
{
    public class UploadObjectTest
    {
        private static readonly CloudConfiguration s_config = CloudConfiguration.Instance;

        private static readonly string s_bucket = s_config.TempBucketPrefix + "2";

        [Fact]
        public void SimpleUpload()
        {
            var name = GenerateName();
            var contentType = "application/octet-stream";
            var source = GenerateData(100);
            var result = s_config.Client.UploadObject(s_bucket, name, contentType, source);
            Assert.Equal(s_bucket, result.Bucket);
            Assert.Equal(name, result.Name);
            Assert.Equal(contentType, result.ContentType);
            ValidateData(source, name);            
        }

        [Fact]
        public void UploadWithObject()
        {
            var destination = new Object
            {
                Bucket = s_bucket,
                Name = GenerateName(),
                ContentType = "test/type",
                ContentDisposition = "attachment",
                Metadata = new Dictionary<string, string> { { "x", "y" } }
            };
            var source = GenerateData(100);
            var result = s_config.Client.UploadObject(destination, source);
            Assert.NotSame(destination, result);
            Assert.Equal(destination.Name, result.Name);
            Assert.Equal(destination.Bucket, result.Bucket);
            Assert.Equal(destination.ContentType, result.ContentType);
            Assert.Equal(destination.ContentDisposition, result.ContentDisposition);
            Assert.Equal(destination.Metadata, result.Metadata);
            ValidateData(source, destination.Name);
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
            var result = await s_config.Client.UploadObjectAsync(s_bucket, name, contentType, source,
                new UploadObjectOptions { ChunkSize = UploadObjectOptions.MinimumChunkSize },
                CancellationToken.None, progress);
            Assert.Equal(chunks + 1, progressCount); // Should start with a 0 progress
            Assert.Equal(name, result.Name); // Assume the rest of the properties are okay...
            ValidateData(source, name);
        }

        [Fact]
        public void ReplaceObject()
        {
            // This test relies on versioning being enabled for bucket {project_name}_integrationtests-2
            var name = GenerateName();
            var contentType = "application/octet-stream";
            var source1 = GenerateData(100);
            var firstVersion = s_config.Client.UploadObject(s_bucket, name, contentType, source1);
            ValidateData(source1, name);
            var source2 = GenerateData(50);
            firstVersion.ContentType = "application/x-replaced";

            // Clear hash and cache information, as we're changing the data.
            firstVersion.Crc32c = null;
            firstVersion.ETag = null;
            firstVersion.Md5Hash = null;
            var secondVersion = s_config.Client.UploadObject(firstVersion, source2);
            ValidateData(source2, name);
            Assert.NotEqual(firstVersion.Generation, secondVersion.Generation);
            Assert.Equal(firstVersion.ContentType, secondVersion.ContentType); // The modified content type should stick

            // When we ask for the first generation, we get the original data back.
            var firstGenerationData = new MemoryStream();
            s_config.Client.DownloadObject(firstVersion, firstGenerationData, new DownloadObjectOptions { Generation = firstVersion.Generation }, null);
            Assert.Equal(source1.ToArray(), firstGenerationData.ToArray());
        }

        private static void ValidateData(MemoryStream original, string objectName)
        {
            var downloaded = new MemoryStream();
            s_config.Client.DownloadObject(s_bucket, objectName, downloaded);
            Assert.Equal(original.ToArray(), downloaded.ToArray());
        }
    }
}
