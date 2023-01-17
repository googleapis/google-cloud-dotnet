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
                var signer = UrlSigner.FromCredential(CreateFakeServiceAccountCredential());
                var baseRequestTemplate = RequestTemplate.FromBucket("bucket-name").WithObjectName("object-name");
                var options = Options
                    .FromExpiration(DateTimeOffset.UtcNow + TimeSpan.FromDays(1))
                    .WithSigningVersion(SigningVersion.V2);

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
                var signer = UrlSigner.FromCredential(CreateFakeServiceAccountCredential());
                var baseRequestTemplate = RequestTemplate.FromBucket("bucket-name").WithObjectName("object-name");
                var options = Options
                    .FromExpiration(DateTimeOffset.UtcNow + TimeSpan.FromDays(1))
                    .WithSigningVersion(SigningVersion.V2);

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
                var signer = UrlSigner.FromBlobSigner(new FakeBlobSigner());
                var baseRequestTemplate = RequestTemplate.FromBucket("bucket-name").WithObjectName("object-name");
                var options = Options
                    .FromExpiration(new DateTime(1970, 1, 1, 0, 0, 30, DateTimeKind.Utc))
                    .WithSigningVersion(SigningVersion.V2);

                var url = signer.Sign(baseRequestTemplate, options);
                Assert.Equal("https://storage.googleapis.com/bucket-name/object-name?GoogleAccessId=FakeId&Expires=30&Signature=AAA%3D", url);
            }

            [Fact]
            public async Task BlobSignerAsync()
            {
                var signer = UrlSigner.FromBlobSigner(new FakeBlobSigner());
                var baseRequestTemplate = RequestTemplate.FromBucket("bucket-name").WithObjectName("object-name");
                var options = Options
                    .FromExpiration(new DateTime(1970, 1, 1, 0, 0, 30, DateTimeKind.Utc))
                    .WithSigningVersion(SigningVersion.V2);

                var url = await signer.SignAsync(baseRequestTemplate, options);
                Assert.Equal("https://storage.googleapis.com/bucket-name/object-name?GoogleAccessId=FakeId&Expires=30&Signature=BBB%3D", url);
            }

            [Fact]
            public async Task ThrowsIfQueryParametersSpecified()
            {
                var signer = UrlSigner.FromCredential(CreateFakeServiceAccountCredential());
                var requestTemplate = RequestTemplate
                    .FromBucket("bucket-name")
                    .WithObjectName("object-name")
                    .WithQueryParameters(
                    new Dictionary<string, IEnumerable<string>>
                    {
                        { "param1", new string[] { "value1" } }
                    });
                var options = Options
                    .FromExpiration(DateTimeOffset.UtcNow + TimeSpan.FromDays(1))
                    .WithSigningVersion(SigningVersion.V2);

                Assert.Throws<ArgumentException>(() => signer.Sign(requestTemplate, options));
                await Assert.ThrowsAsync<ArgumentException>(() => signer.SignAsync(requestTemplate, options));
            }

            [Fact]
            public void WithHttpScheme()
            {
                var signer = UrlSigner.FromBlobSigner(new FakeBlobSigner());
                var baseRequestTemplate = RequestTemplate.FromBucket("bucket-name").WithObjectName("object-name");
                var options = Options
                    .FromExpiration(new DateTime(1970, 1, 1, 0, 0, 30, DateTimeKind.Utc))
                    .WithSigningVersion(SigningVersion.V2)
                    .WithScheme("http");

                var url = signer.Sign(baseRequestTemplate, options);
                Assert.Equal("http://storage.googleapis.com/bucket-name/object-name?GoogleAccessId=FakeId&Expires=30&Signature=AAA%3D", url);
            }

            [Fact]
            public void WithVirtualHostedStyle()
            {
                var signer = UrlSigner.FromBlobSigner(new FakeBlobSigner());
                var requestTemplate = RequestTemplate.FromBucket("bucket-name").WithObjectName("object-name");
                var options = Options
                    .FromExpiration(new DateTime(1970, 1, 1, 0, 0, 30, DateTimeKind.Utc))
                    .WithSigningVersion(SigningVersion.V2)
                    .WithUrlStyle(UrlStyle.VirtualHostedStyle);

                var url = signer.Sign(requestTemplate, options);
                Assert.Equal("https://bucket-name.storage.googleapis.com/object-name?GoogleAccessId=FakeId&Expires=30&Signature=AAA%3D", url);
            }

            [Fact]
            public async Task ThrowsIfBucketBoundHostSpecified()
            {
                var signer = UrlSigner.FromCredential(CreateFakeServiceAccountCredential());
                var requestTemplate = RequestTemplate
                    .FromBucket("bucket-name")
                    .WithObjectName("object-name");
                var options = Options
                    .FromExpiration(DateTimeOffset.UtcNow + TimeSpan.FromDays(1))
                    .WithSigningVersion(SigningVersion.V2)
                    .WithBucketBoundHostname("my.bucket.domain");

                Assert.Throws<ArgumentOutOfRangeException>(() => signer.Sign(requestTemplate, options));
                await Assert.ThrowsAsync<ArgumentOutOfRangeException>(() => signer.SignAsync(requestTemplate, options));
            }

            [Fact]
            public async void Unsupported_SignPostPolicy()
            {
                var signer = UrlSigner.FromCredential(CreateFakeServiceAccountCredential());
                var options = Options
                    .FromExpiration(DateTimeOffset.UtcNow + TimeSpan.FromDays(1))
                    .WithSigningVersion(SigningVersion.V2);
                var postPolicy = PostPolicy.ForBucketAndKey("my-bucket", "my-test-object");
                Assert.Throws<NotSupportedException>(() => signer.Sign(postPolicy, options));
                await Assert.ThrowsAsync<NotSupportedException>(() => signer.SignAsync(postPolicy, options));
            }
        }
    }
}
