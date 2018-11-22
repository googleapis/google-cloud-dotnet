// Copyright 2018 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.Tests
{
    public partial class UrlSignerTest
    {
        /// <summary>
        /// UrlSigner unit tests that are specific to the V2 signing scheme
        /// </summary>
        public class V2SignerTest
        {
            [Fact]
            public void DefaultHttpMethodIsGet()
            {
                var signer = UrlSigner
                    .FromServiceAccountCredential(CreateFakeServiceAccountCredential())
                    .WithSigningVersion(SigningVersion.V2);
                var bucketName = "bucket-name";
                var objectName = "object-name";
                var expiration = DateTimeOffset.UtcNow + TimeSpan.FromDays(1);
                var url1 = signer.Sign(bucketName, objectName, expiration, requestMethod: null);
                var url2 = signer.Sign(bucketName, objectName, expiration, requestMethod: HttpMethod.Get);
                Assert.Equal(url1, url2);
            }

            [Fact]
            public void EncryptionKeyAndHashAreIgnored()
            {
                var signer = UrlSigner
                    .FromServiceAccountCredential(CreateFakeServiceAccountCredential())
                    .WithSigningVersion(SigningVersion.V2);
                var bucketName = "bucket-name";
                var objectName = "object-name";
                var expiration = DateTimeOffset.UtcNow + TimeSpan.FromDays(1);
                var url1 = signer.Sign(bucketName, objectName, expiration, requestHeaders: new Dictionary<string, IEnumerable<string>> {
                    { EncryptionKey.AlgorithmHeader, new [] { EncryptionKey.AlgorithmValue } }
                });
                var url2 = signer.Sign(bucketName, objectName, expiration, requestHeaders: new Dictionary<string, IEnumerable<string>> {
                    { EncryptionKey.AlgorithmHeader, new [] { EncryptionKey.AlgorithmValue } },
                    { EncryptionKey.KeyHeader, new [] { "abc" } },
                    { EncryptionKey.KeyHashHeader, new [] { "def" } }
                });
                Assert.Equal(url1, url2);

                // However, make sure the encryption algorithm is not ignored.
                var url3 = signer.Sign(bucketName, objectName, expiration);
                Assert.NotEqual(url1, url3);
            }

            [Fact]
            public void ResumableEquivalentToPostWithStartHeader()
            {
                var signer = UrlSigner
                    .FromServiceAccountCredential(CreateFakeServiceAccountCredential())
                    .WithSigningVersion(SigningVersion.V2);
                var bucketName = "bucket-name";
                var objectName = "object-name";
                var expiration = DateTimeOffset.UtcNow + TimeSpan.FromDays(1);
                var url1 = signer.Sign(bucketName, objectName, expiration, UrlSigner.ResumableHttpMethod);
                var url2 = signer.Sign(bucketName, objectName, expiration, HttpMethod.Post,
                    new Dictionary<string, IEnumerable<string>> { { "x-goog-resumable", new[] { "start" } } });
                Assert.Equal(url1, url2);
            }

            [Fact]
            public void BlobSignerSync()
            {
                var signer = UrlSigner.FromBlobSigner(new FakeBlobSigner()).WithSigningVersion(SigningVersion.V2);
                var bucketName = "bucket-name";
                var objectName = "object-name";
                var expiration = new DateTime(1970, 1, 1, 0, 0, 30, DateTimeKind.Utc);
                var url = signer.Sign(bucketName, objectName, expiration);
                Assert.Equal("https://storage.googleapis.com/bucket-name/object-name?GoogleAccessId=FakeId&Expires=30&Signature=AAA%3D", url);
            }

            [Fact]
            public async Task BlobSignerAsync()
            {
                var signer = UrlSigner.FromBlobSigner(new FakeBlobSigner()).WithSigningVersion(SigningVersion.V2);
                var bucketName = "bucket-name";
                var objectName = "object-name";
                var expiration = new DateTime(1970, 1, 1, 0, 0, 30, DateTimeKind.Utc);
                var url = await signer.SignAsync(bucketName, objectName, expiration);
                Assert.Equal("https://storage.googleapis.com/bucket-name/object-name?GoogleAccessId=FakeId&Expires=30&Signature=BBB%3D", url);
            }
        }
    }
}
