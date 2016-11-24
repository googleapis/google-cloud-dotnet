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

using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    using static TestHelpers;

    [Collection(nameof(StorageFixture))]
    public class UrlSignerTest
    {
        private static readonly TimeSpan _duration = TimeSpan.FromSeconds(5);
        private readonly StorageFixture _fixture;

        public UrlSignerTest(StorageFixture fixture)
        {
            _fixture = fixture;
            _fixture.RegisterDelayTests(this);
        }

        private static string GetTestName([CallerMemberName] string methodName = null)
        {
            return $"{nameof(UrlSignerTest)}.{methodName}";
        }

        [Fact]
        public async Task DeleteTest() => await _fixture.FinishDelayTest(GetTestName());

        private void DeleteTest_InitDelayTest()
        {
            var bucket = _fixture.SingleVersionBucket;
            var name = GenerateName();
            string url = null;

            _fixture.RegisterDelayTest(_duration,
                beforeDelay: async duration =>
                {
                    url = _fixture.UrlSigner.Sign(bucket, name, duration, HttpMethod.Delete);

                    // Upload an object which can be deleted with the URL.
                    await _fixture.Client.UploadObjectAsync(bucket, name, "", new MemoryStream(_fixture.SmallContent));

                    // Verify that the URL works initially.
                    var response = await _fixture.HttpClient.DeleteAsync(url);
                    Assert.True(response.IsSuccessStatusCode);
                    var obj = await _fixture.Client.ListObjectsAsync(bucket, name).FirstOrDefault(o => o.Name == name);
                    Assert.Null(obj);

                    // Restore the object. 
                    await _fixture.Client.UploadObjectAsync(bucket, name, "", new MemoryStream(_fixture.SmallContent));
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    var response = await _fixture.HttpClient.DeleteAsync(url);
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
                    var obj = await _fixture.Client.ListObjectsAsync(bucket, name).FirstOrDefault(o => o.Name == name);
                    Assert.NotNull(obj);

                    // Cleanup
                    await _fixture.Client.DeleteObjectAsync(bucket, name);
                });
        }

        [Fact]
        public async Task GetTest() => await _fixture.FinishDelayTest(GetTestName());

        private void GetTest_InitDelayTest()
        {
            string url = null;

            _fixture.RegisterDelayTest(_duration,
                beforeDelay: async duration =>
                {
                    url = _fixture.UrlSigner.Sign(_fixture.ReadBucket, _fixture.SmallObject, duration);

                    // Verify that the URL works initially.
                    var response = await _fixture.HttpClient.GetAsync(url);
                    var result = await response.Content.ReadAsByteArrayAsync();
                    Assert.Equal(_fixture.SmallContent, result);
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    var response = await _fixture.HttpClient.GetAsync(url);
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
                });
        }

        [Fact]
        public async Task GetBucketTest() => await _fixture.FinishDelayTest(GetTestName());

        private void GetBucketTest_InitDelayTest()
        {
            var bucket = _fixture.ReadBucket;
            string url = null;

            _fixture.RegisterDelayTest(_duration,
                beforeDelay: async duration =>
                {
                    url = _fixture.UrlSigner.Sign(bucket, null, duration);

                    // Verify that the URL works initially.
                    var response = await _fixture.HttpClient.GetAsync(url);
                    var result = await response.Content.ReadAsStringAsync();
                    var document = XDocument.Parse(result);
                    var ns = document.Root.GetDefaultNamespace();
                    var keys = document.Root.Elements(ns + "Contents").Select(contents => contents.Element(ns + "Key").Value).ToList();
                    var objectNames = await _fixture.Client.ListObjectsAsync(bucket, null).Select(o => o.Name).ToList();
                    Assert.Equal(objectNames, keys);
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    var response = await _fixture.HttpClient.GetAsync(url);
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
                });
        }

        [Fact]
        public async Task GetWithCustomerSuppliedEncryptionKeysTest() => await _fixture.FinishDelayTest(GetTestName());

        private void GetWithCustomerSuppliedEncryptionKeysTest_InitDelayTest()
        {
            var bucket = _fixture.SingleVersionBucket;
            var name = GenerateName();
            var data = _fixture.SmallContent;
            string url = null;

            string key;
            string hash;
            using (var rand = RandomNumberGenerator.Create())
            using (var sha256 = SHA256.Create())
            {
                var keyBytes = new byte[32];
                rand.GetBytes(keyBytes);
                key = Convert.ToBase64String(keyBytes);
                hash = Convert.ToBase64String(sha256.ComputeHash(keyBytes));
            }
            
            Func<HttpRequestMessage> createGetRequest = () => new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                Headers = {
                    { "x-goog-encryption-algorithm", "AES256" },
                    { "x-goog-encryption-key", key },
                    { "x-goog-encryption-key-sha256", hash }
                }
            };

            _fixture.RegisterDelayTest(_duration,
                beforeDelay: async duration =>
                {
                    // TODO: Replace this with calls to the StorageClient if/when it supports customer-supplied encryption keys.
                    var putRequest = new HttpRequestMessage()
                    {
                        Content = new ByteArrayContent(data),
                        Method = HttpMethod.Put,
                        Headers = {
                            { "x-goog-encryption-algorithm", "AES256" },
                            { "x-goog-encryption-key", key },
                            { "x-goog-encryption-key-sha256", hash }
                        }
                    };

                    putRequest.RequestUri = new Uri(_fixture.UrlSigner.Sign(
                        bucket,
                        name,
                        expiration: null,
                        request: putRequest));
                    var response = await _fixture.HttpClient.SendAsync(putRequest);
                    Assert.True(response.IsSuccessStatusCode);

                    // Make sure the encryption succeeded.
                    await Assert.ThrowsAsync<GoogleApiException>(
                        () => _fixture.Client.DownloadObjectAsync(bucket, name, new MemoryStream()));

                    var request = createGetRequest();
                    url = _fixture.UrlSigner.Sign(bucket, name, duration, request);
                    request.RequestUri = new Uri(url);

                    // Verify that the URL works initially.
                    response = await _fixture.HttpClient.SendAsync(request);
                    var result = await response.Content.ReadAsByteArrayAsync();
                    Assert.Equal(data, result);
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    var request = createGetRequest();
                    request.RequestUri = new Uri(url);
                    var response = await _fixture.HttpClient.SendAsync(request);
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

                    // Cleanup
                    await _fixture.Client.DeleteObjectAsync(bucket, name);
                });
        }

        [Fact]
        public async Task GetNoExpirationTest()
        {
            var url = _fixture.UrlSigner.Sign(_fixture.ReadBucket, _fixture.SmallObject, expiration: null);

            // Verify that the URL works.
            var response = await _fixture.HttpClient.GetAsync(url);
            var result = await response.Content.ReadAsByteArrayAsync();
            Assert.Equal(_fixture.SmallContent, result);
        }

        [Fact]
        public async Task GetWithCustomHeadersTest() => await _fixture.FinishDelayTest(GetTestName());

        private void GetWithCustomHeadersTest_InitDelayTest()
        {
            string url = null;

            Func<HttpRequestMessage> createRequest = () => new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                Headers = {
                    { "x-goog-foo", "xy\r\n z" },
                    { "x-goog-bar", "  12345   " },
                    { "x-goog-foo", new [] { "A B  C", "def" } }
                }
            };

            _fixture.RegisterDelayTest(_duration,
                beforeDelay: async duration =>
                {
                    var request = createRequest();
                    url = _fixture.UrlSigner.Sign(
                        _fixture.ReadBucket,
                        _fixture.SmallObject,
                        duration,
                        request);
                    request.RequestUri = new Uri(url);

                    // Verify that the URL works initially.
                    var response = await _fixture.HttpClient.SendAsync(request);
                    var result = await response.Content.ReadAsByteArrayAsync();
                    Assert.Equal(_fixture.SmallContent, result);
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    var request = createRequest();
                    request.RequestUri = new Uri(url);
                    var response = await _fixture.HttpClient.SendAsync(request);
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
                });
        }

        [Fact]
        public async Task HeadTest() => await _fixture.FinishDelayTest(GetTestName());

        private void HeadTest_InitDelayTest()
        {
            Func<HttpRequestMessage> createRequest = null;
            string url = null;

            _fixture.RegisterDelayTest(_duration,
                beforeDelay: async duration =>
                {
                    url = _fixture.UrlSigner.Sign(
                        _fixture.ReadBucket,
                        _fixture.SmallObject,
                        duration,
                        HttpMethod.Head);
                    createRequest = () => new HttpRequestMessage(HttpMethod.Head, url);

                    // Verify that the URL works initially.
                    var response = await _fixture.HttpClient.SendAsync(createRequest());
                    Assert.True(response.IsSuccessStatusCode);
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    var response = await _fixture.HttpClient.SendAsync(createRequest());
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
                });
        }

        [Fact]
        public async Task HeadWithGetMethodSignedURLTest() => await _fixture.FinishDelayTest(GetTestName());

        private void HeadWithGetMethodSignedURLTest_InitDelayTest()
        {
            Func<HttpRequestMessage> createRequest = null;
            string url = null;

            _fixture.RegisterDelayTest(_duration,
                beforeDelay: async duration =>
                {
                    url = _fixture.UrlSigner.Sign(
                        _fixture.ReadBucket,
                        _fixture.SmallObject,
                        duration,
                        HttpMethod.Get);
                    createRequest = () => new HttpRequestMessage(HttpMethod.Head, url);

                    // Verify that the URL works initially.
                    var response = await _fixture.HttpClient.SendAsync(createRequest());
                    Assert.True(response.IsSuccessStatusCode);
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    var response = await _fixture.HttpClient.SendAsync(createRequest());
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
                });
        }

        [Fact]
        public async Task PutTest() => await _fixture.FinishDelayTest(GetTestName());

        private void PutTest_InitDelayTest()
        {
            Func<Task> expireAction1 = null;
            Func<Task> expireAction2 = null;
            Func<Task> expireAction3 = null;
            Func<Task> expireAction4 = null;

            _fixture.RegisterDelayTest(_duration,
                beforeDelay: async duration =>
                {
                    expireAction1 = await PutTestHelper(duration, useContentMD5: false, useContentType: false);
                    expireAction2 = await PutTestHelper(duration, useContentMD5: true, useContentType: false);
                    expireAction3 = await PutTestHelper(duration, useContentMD5: false, useContentType: true);
                    expireAction4 = await PutTestHelper(duration, useContentMD5: true, useContentType: true);
                },
                afterDelay: async () =>
                {
                    await expireAction1();
                    await expireAction2();
                    await expireAction3();
                    await expireAction4();
                });
        }

        private async Task<Func<Task>> PutTestHelper(TimeSpan duration, bool useContentMD5, bool useContentType)
        {
            var bucket = _fixture.SingleVersionBucket;
            var name = GenerateName();
            var data = _fixture.SmallContent;

            Func<ByteArrayContent> createPutContent = () =>
            {
                var putContent = new ByteArrayContent(data);
                if (useContentMD5)
                {
                    using (var md5 = MD5.Create())
                    {
                        putContent.Headers.ContentMD5 = md5.ComputeHash(data);
                    }
                }
                if (useContentType)
                {
                    putContent.Headers.ContentType = new MediaTypeHeaderValue("text/plain");
                }
                return putContent;
            };
            var content = createPutContent();
            var url = _fixture.UrlSigner.Sign(
                bucket,
                name,
                duration,
                HttpMethod.Put,
                contentHeaders: content.Headers.ToDictionary(h => h.Key, h => h.Value));

            // Verify that the URL works initially.
            var response = await _fixture.HttpClient.PutAsync(url, content);
            Assert.True(response.IsSuccessStatusCode);
            var result = new MemoryStream();
            await _fixture.Client.DownloadObjectAsync(bucket, name, result);
            Assert.Equal(result.ToArray(), _fixture.SmallContent);

            // Reset the state and wait until the URL expires.
            await _fixture.Client.DeleteObjectAsync(bucket, name);

            return async () =>
            {
                // Verify that the URL no longer works.
                content = createPutContent();
                response = await _fixture.HttpClient.PutAsync(url, content);
                Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
                var obj = await _fixture.Client.ListObjectsAsync(bucket, name).FirstOrDefault(o => o.Name == name);
                Assert.Null(obj);
            };
        }

        [Fact]
        public async Task PutWithCustomHeadersTest() => await _fixture.FinishDelayTest(GetTestName());

        private void PutWithCustomHeadersTest_InitDelayTest()
        {
            var bucket = _fixture.SingleVersionBucket;
            var name = GenerateName();
            var data = _fixture.SmallContent;
            string url = null;

            Func<HttpRequestMessage> createRequest = () =>
            {
                using (var md5 = MD5.Create())
                {
                    return new HttpRequestMessage()
                    {
                        Content = new ByteArrayContent(data)
                        {
                            Headers = {
                                { "Content-MD5", Convert.ToBase64String(md5.ComputeHash(data)) },
                                { "Content-Type", "text/plain" },
                                { "x-goog-z-content-foo", "val1" },
                                { "x-goog-a-content-bar", "val2" },
                                { "x-goog-foo", new [] { "val3", "val4" } }
                            }
                        },
                        Method = HttpMethod.Put,
                        Headers = {
                            { "x-goog-foo", "xy\r\n z" },
                            { "x-goog-bar", "  12345   " },
                            { "x-goog-foo", new [] { "A B  C", "def" } }
                        }
                    };
                }
            };

            _fixture.RegisterDelayTest(_duration,
                beforeDelay: async duration =>
                {
                    var request = createRequest();
                    url = _fixture.UrlSigner.Sign(bucket, name, duration, request);
                    request.RequestUri = new Uri(url);

                    // Verify that the URL works initially.
                    var response = await _fixture.HttpClient.SendAsync(request);
                    Assert.True(response.IsSuccessStatusCode);
                    var result = new MemoryStream();
                    await _fixture.Client.DownloadObjectAsync(bucket, name, result);
                    Assert.Equal(result.ToArray(), _fixture.SmallContent);

                    // Reset the state.
                    await _fixture.Client.DeleteObjectAsync(bucket, name);
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    var request = createRequest();
                    request.RequestUri = new Uri(url);
                    var response = await _fixture.HttpClient.SendAsync(request);
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
                    var obj = await _fixture.Client.ListObjectsAsync(bucket, name).FirstOrDefault(o => o.Name == name);
                    Assert.Null(obj);
                });
        }
    }
}
