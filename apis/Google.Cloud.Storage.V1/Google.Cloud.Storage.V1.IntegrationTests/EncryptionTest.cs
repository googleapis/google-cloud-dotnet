// Copyright 2017 Google Inc. All Rights Reserved.
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

using System;
using System.IO;
using Xunit;

using static Google.Cloud.Storage.V1.IntegrationTests.TestHelpers;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class EncryptionTest
    {
        private readonly StorageFixture _fixture;

        public EncryptionTest(StorageFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void DownloadWithKey()
        {
            var bucket = _fixture.SingleVersionBucket;
            var data = GenerateData(100);
            var key = EncryptionKey.Generate();
            var contentType = "application/octet-stream";
            var client = StorageClient.Create(encryptionKey: key);

            var name = GenerateName();
            client.UploadObject(bucket, name, contentType, data);
            // Client default key
            ValidateData(bucket, name, data, client);

            // Overridden
            ValidateData(bucket, name, data, null, new DownloadObjectOptions { EncryptionKey = key });
        }

        [Fact]
        public void DownloadWithoutKey()
        {
            var bucket = _fixture.SingleVersionBucket;
            var data = GenerateData(100);
            var key = EncryptionKey.Generate();
            var contentType = "application/octet-stream";
            var client = StorageClient.Create();

            var name = GenerateName();
            client.UploadObject(bucket, name, contentType, data, new UploadObjectOptions { EncryptionKey = key });
            Assert.Throws<GoogleApiException>(() => client.DownloadObject(bucket, name, new MemoryStream()));
        }

        [Fact]
        public void RotateKeys()
        {
            var bucket = _fixture.SingleVersionBucket;
            var data = GenerateData(100);
            var key1 = EncryptionKey.Generate();
            var key2 = EncryptionKey.Generate();
            var contentType = "application/octet-stream";

            var name = GenerateName();

            var client1 = StorageClient.Create(encryptionKey: key1);
            client1.UploadObject(_fixture.SingleVersionBucket, name, contentType, data);

            var client2 = StorageClient.Create(encryptionKey: key2);

            // We're copying over the top of the original object. We don't have to, but that's
            // probably typical for key rotation.
            client2.CopyObject(bucket, name, bucket, name, new CopyObjectOptions { SourceEncryptionKey = key1 });
            ValidateData(bucket, name, data, client2);
        }

        [Fact]
        public void GetMetadata()
        {
            var bucket = _fixture.SingleVersionBucket;
            var data = GenerateData(100);
            var key = EncryptionKey.Generate();
            var contentType = "application/octet-stream";
            var client = StorageClient.Create();
            var name = GenerateName();

            var uploaded = client.UploadObject(bucket, name, contentType, data, new UploadObjectOptions { EncryptionKey = key });
            var fetchedWithoutKey = client.GetObject(bucket, name);
            Assert.Null(fetchedWithoutKey.Md5Hash);
            var fetchedWithKey = client.GetObject(bucket, name, new GetObjectOptions { EncryptionKey = key });
            Assert.NotNull(fetchedWithKey.Md5Hash);
            Assert.Equal(uploaded.Md5Hash, fetchedWithKey.Md5Hash);
        }

        [Fact]
        public void NoneEquality()
        {
            var key = EncryptionKey.None;
            Assert.True(EncryptionKey.None.Equals(key));
            Assert.True(EncryptionKey.None.Equals((object) key));
            Assert.Equal(0, key.GetHashCode());

            Assert.False(key.Equals(null));
            Assert.False(key.Equals((object) null));
        }

        [Fact]
        public void NotNoneEquality()
        {
            var key1a = EncryptionKey.Generate();
            var key1b = EncryptionKey.Create(Convert.FromBase64String(key1a.Base64Key));
            var key2 = EncryptionKey.Generate();
            Assert.True(key1a.Equals(key1b));
            Assert.True(key1a.Equals((object) key1b));
            Assert.Equal(key1a.GetHashCode(), key1b.GetHashCode());

            Assert.False(key1a.Equals(key2));
            Assert.False(key1a.Equals((object) key2));
            Assert.NotEqual(key1a.GetHashCode(), key2.GetHashCode());

            Assert.False(key1a.Equals(null));
            Assert.False(key1a.Equals((object) null));
        }
    }
}
