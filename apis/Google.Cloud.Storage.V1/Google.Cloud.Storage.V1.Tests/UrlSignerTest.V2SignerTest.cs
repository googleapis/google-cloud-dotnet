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
using static Google.Cloud.Storage.V1.UrlSigner;

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
            public void EncryptionKeyAndHashAreIgnored()
            {
                var signer = UrlSigner
                    .FromServiceAccountCredential(CreateFakeServiceAccountCredential())
                    .WithSigningVersion(SigningVersion.V2);
                var baseRequestTemplate = RequestTemplate.FromBucket("bucket-name").WithObjectName("object-name");
                var options = Options.FromExpiration(DateTimeOffset.UtcNow + TimeSpan.FromDays(1));

                var algorithmTemplate = baseRequestTemplate.WithRequestHeaders(
                    new Dictionary<string, IEnumerable<string>>
                    {
                        { EncryptionKey.AlgorithmHeader, new [] { EncryptionKey.AlgorithmValue }}
                    });

                var keyAndHashTemplate = baseRequestTemplate.WithRequestHeaders(
                    new Dictionary<string, IEnumerable<string>>
                    {
                        { EncryptionKey.AlgorithmHeader, new [] { EncryptionKey.AlgorithmValue }},
                        { EncryptionKey.KeyHeader, new [] { "abc" } },
                        { EncryptionKey.KeyHashHeader, new [] { "def" } }
                    });

                var url1 = signer.Sign(algorithmTemplate, options);
                var url2 = signer.Sign(keyAndHashTemplate, options);
                Assert.Equal(url1, url2);

                // However, make sure the encryption algorithm is not ignored.
                var url3 = signer.Sign(baseRequestTemplate, options);
                Assert.NotEqual(url1, url3);
            }

            [Fact]
            public void ResumableEquivalentToPostWithStartHeader()
            {
                var signer = UrlSigner
                    .FromServiceAccountCredential(CreateFakeServiceAccountCredential())
                    .WithSigningVersion(SigningVersion.V2);
                var baseRequestTemplate = RequestTemplate.FromBucket("bucket-name").WithObjectName("object-name");
                var options = Options.FromExpiration(DateTimeOffset.UtcNow + TimeSpan.FromDays(1));

                var resumableTemplate = baseRequestTemplate.WithHttpMethod(ResumableHttpMethod);
                var startHeaderTemplate = baseRequestTemplate
                    .WithHttpMethod(HttpMethod.Post)
                    .WithRequestHeaders(
                    new Dictionary<string, IEnumerable<string>>
                    {
                        { "x-goog-resumable", new[] { "start" } }
                    });

                var url1 = signer.Sign(resumableTemplate, options);
                var url2 = signer.Sign(startHeaderTemplate, options);
                Assert.Equal(url1, url2);
            }

            [Fact]
            public void BlobSignerSync()
            {
                var signer = UrlSigner.FromBlobSigner(new FakeBlobSigner()).WithSigningVersion(SigningVersion.V2);
                var baseRequestTemplate = RequestTemplate.FromBucket("bucket-name").WithObjectName("object-name");
                var options = Options.FromExpiration(new DateTime(1970, 1, 1, 0, 0, 30, DateTimeKind.Utc));

                var url = signer.Sign(baseRequestTemplate, options);
                Assert.Equal("https://storage.googleapis.com/bucket-name/object-name?GoogleAccessId=FakeId&Expires=30&Signature=AAA%3D", url);
            }

            [Fact]
            public async Task BlobSignerAsync()
            {
                var signer = UrlSigner.FromBlobSigner(new FakeBlobSigner()).WithSigningVersion(SigningVersion.V2);
                var baseRequestTemplate = RequestTemplate.FromBucket("bucket-name").WithObjectName("object-name");
                var options = Options.FromExpiration(new DateTime(1970, 1, 1, 0, 0, 30, DateTimeKind.Utc));

                var url = await signer.SignAsync(baseRequestTemplate, options);
                Assert.Equal("https://storage.googleapis.com/bucket-name/object-name?GoogleAccessId=FakeId&Expires=30&Signature=BBB%3D", url);
            }
        }
    }
}
