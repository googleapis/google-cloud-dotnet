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

using Google.Apis.Upload;
using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    /// <summary>
    /// The outer class contains common private methods called by nested classes. This reduces duplication between different signing version tests.
    /// There's still a certain amount of boilerplate due to the way delay tests are executed, but it's not *too* bad.
    /// (You'd expect inheritance with a base class containing the tests to work, but that would require considerable rework of the delay
    /// testing infrastructure.)
    /// </summary>
    public partial class UrlSignerTest
    {
        private static readonly TimeSpan s_duration = TimeSpan.FromSeconds(5);

        private static void DeleteTest_Common(StorageFixture fixture, UrlSigner signer, [CallerMemberName] string caller = null)
        {
            var bucket = fixture.SingleVersionBucket;
            var name = IdGenerator.FromGuid();
            string url = null;

            fixture.RegisterDelayTest(
                s_duration,
                beforeDelay: async duration =>
                {
                    url = signer.Sign(bucket, name, duration, HttpMethod.Delete);

                    // Upload an object which can be deleted with the URL.
                    await fixture.Client.UploadObjectAsync(bucket, name, "", new MemoryStream(fixture.SmallContent));

                    // Verify that the URL works initially.
                    var response = await fixture.HttpClient.DeleteAsync(url);
                    await VerifyResponseAsync(response);
                    var obj = await fixture.Client.ListObjectsAsync(bucket, name).FirstOrDefaultAsync(o => o.Name == name);
                    Assert.Null(obj);

                    // Restore the object. 
                    await fixture.Client.UploadObjectAsync(bucket, name, "", new MemoryStream(fixture.SmallContent));
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    var response = await fixture.HttpClient.DeleteAsync(url);
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
                    var obj = await fixture.Client.ListObjectsAsync(bucket, name).FirstOrDefaultAsync(o => o.Name == name);
                    Assert.NotNull(obj);

                    // Cleanup
                    await fixture.Client.DeleteObjectAsync(bucket, name);
                },
                caller);
        }

        private static void GetTest_Common(StorageFixture fixture, UrlSigner signer, [CallerMemberName] string caller = null)
        {
            string url = null;

            fixture.RegisterDelayTest(
                s_duration,
                beforeDelay: async duration =>
                {
                    url = signer.Sign(fixture.ReadBucket, fixture.SmallObject, duration);

                    // Verify that the URL works initially.
                    var response = await fixture.HttpClient.GetAsync(url);
                    var result = await response.Content.ReadAsByteArrayAsync();
                    AssertContentEqual(fixture.SmallContent, result);
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    var response = await fixture.HttpClient.GetAsync(url);
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
                },
                caller);
        }

        private static void GetBucketTest_Common(StorageFixture fixture, UrlSigner signer, [CallerMemberName] string caller = null)
        {
            var bucket = fixture.ReadBucket;
            string url = null;

            fixture.RegisterDelayTest(
                s_duration,
                beforeDelay: async duration =>
                {
                    url = signer.Sign(bucket, null, duration);

                    // Verify that the URL works initially.
                    var response = await fixture.HttpClient.GetAsync(url);
                    var result = await response.Content.ReadAsStringAsync();
                    Assert.True(response.IsSuccessStatusCode, result.ToString());
                    var document = XDocument.Parse(result);
                    var ns = document.Root.GetDefaultNamespace();
                    var keys = document.Root.Elements(ns + "Contents").Select(contents => contents.Element(ns + "Key").Value).ToList();
                    var objectNames = await fixture.Client.ListObjectsAsync(bucket, null).Select(o => o.Name).ToListAsync();
                    Assert.Equal(objectNames, keys);
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    var response = await fixture.HttpClient.GetAsync(url);
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
                },
                caller);
        }

        private static void GetObjectWithSpacesTest_Common(StorageFixture fixture, UrlSigner signer, [CallerMemberName] string caller = null)
        {
            var bucket = fixture.SingleVersionBucket;
            var name = IdGenerator.FromGuid() + " with spaces";
            var content = fixture.SmallContent;
            string url = null;

            fixture.RegisterDelayTest(
                s_duration,
                beforeDelay: async duration =>
                {
                    fixture.Client.UploadObject(bucket, name, null, new MemoryStream(content));
                    url = signer.Sign(bucket, name, duration);

                    // Verify that the URL works initially.
                    var response = await fixture.HttpClient.GetAsync(url);
                    await VerifyResponseAsync(response);
                    var result = await response.Content.ReadAsByteArrayAsync();
                    AssertContentEqual(content, result);
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    var response = await fixture.HttpClient.GetAsync(url);
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
                },
                caller);
        }

        private static void GetWithCustomerSuppliedEncryptionKeysTest_Common(StorageFixture fixture, UrlSigner signer, [CallerMemberName] string caller = null)
        {
            var bucket = fixture.SingleVersionBucket;
            var name = IdGenerator.FromGuid();
            var content = fixture.SmallContent;
            string url = null;

            EncryptionKey key = EncryptionKey.Generate();

            Func<HttpRequestMessage> createGetRequest = () =>
            {
                var request = new HttpRequestMessage { Method = HttpMethod.Get };
                key.ModifyRequest(request);
                return request;
            };

            fixture.RegisterDelayTest(
                s_duration,
                beforeDelay: async duration =>
                {
                    var encryptingClient = StorageClient.Create(encryptionKey: key);
                    encryptingClient.UploadObject(bucket, name, "application/octet-stream", new MemoryStream(content));

                    var request = createGetRequest();
                    url = signer.Sign(bucket, name, duration, request);
                    request.RequestUri = new Uri(url);

                    // Verify that the URL works initially.
                    var response = await fixture.HttpClient.SendAsync(request);
                    var result = await response.Content.ReadAsByteArrayAsync();
                    AssertContentEqual(content, result);
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    var request = createGetRequest();
                    request.RequestUri = new Uri(url);
                    var response = await fixture.HttpClient.SendAsync(request);
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

                    // Cleanup
                    await fixture.Client.DeleteObjectAsync(bucket, name);
                },
                caller);
        }

        private static void GetWithCustomHeadersTest_Common(StorageFixture fixture, UrlSigner signer, [CallerMemberName] string caller = null)
        {
            string url = null;

            Func<HttpRequestMessage> createRequest = () => new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                Headers =
                {
                    { "x-goog-foo", "xy\r\n z" },
                    { "x-goog-bar", "  12345   " },
                    { "x-goog-foo", new [] { "A B  C", "def" } }
                }
            };

            fixture.RegisterDelayTest(
                s_duration,
                beforeDelay: async duration =>
                {
                    var request = createRequest();
                    url = signer.Sign(
                        fixture.ReadBucket,
                        fixture.SmallObject,
                        duration,
                        request);
                    request.RequestUri = new Uri(url);

                    // Verify that the URL works initially.
                    var response = await fixture.HttpClient.SendAsync(request);
                    var result = await response.Content.ReadAsByteArrayAsync();
                    AssertContentEqual(fixture.SmallContent, result);
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    var request = createRequest();
                    request.RequestUri = new Uri(url);
                    var response = await fixture.HttpClient.SendAsync(request);
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
                },
                caller);
        }

        private static void HeadTest_Common(StorageFixture fixture, UrlSigner signer, [CallerMemberName] string caller = null)
        {
            Func<HttpRequestMessage> createRequest = null;
            string url = null;

            fixture.RegisterDelayTest(
                s_duration,
                beforeDelay: async duration =>
                {
                    url = signer.Sign(
                        fixture.ReadBucket,
                        fixture.SmallObject,
                        duration,
                        HttpMethod.Head);
                    createRequest = () => new HttpRequestMessage(HttpMethod.Head, url);

                    // Verify that the URL works initially.
                    var response = await fixture.HttpClient.SendAsync(createRequest());
                    await VerifyResponseAsync(response);
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    var response = await fixture.HttpClient.SendAsync(createRequest());
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
                },
                caller);
        }

        private static void HeadWithGetMethodSignedURLTest_Common(StorageFixture fixture, UrlSigner signer, [CallerMemberName] string caller = null)
        {
            Func<HttpRequestMessage> createRequest = null;
            string url = null;

            fixture.RegisterDelayTest(
                s_duration,
                beforeDelay: async duration =>
                {
                    url = signer.Sign(
                        fixture.ReadBucket,
                        fixture.SmallObject,
                        duration,
                        HttpMethod.Get);
                    createRequest = () => new HttpRequestMessage(HttpMethod.Head, url);

                    // Verify that the URL works initially.
                    var response = await fixture.HttpClient.SendAsync(createRequest());
                    await VerifyResponseAsync(response);
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    var response = await fixture.HttpClient.SendAsync(createRequest());
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
                },
                caller);
        }

        private static void PutTest_Common(StorageFixture fixture, UrlSigner signer, [CallerMemberName] string caller = null)
        {
            Func<Task> expireAction1 = null;
            Func<Task> expireAction2 = null;
            Func<Task> expireAction3 = null;
            Func<Task> expireAction4 = null;

            fixture.RegisterDelayTest(
                s_duration,
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
                },
                caller);

            async Task<Func<Task>> PutTestHelper(TimeSpan duration, bool useContentMD5, bool useContentType)
            {
                var bucket = fixture.SingleVersionBucket;
                var name = IdGenerator.FromGuid();
                var data = fixture.SmallContent;

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
                var url = signer.Sign(
                    bucket,
                    name,
                    duration,
                    HttpMethod.Put,
                    contentHeaders: content.Headers.ToDictionary(h => h.Key, h => h.Value));

                // Verify that the URL works initially.
                var response = await fixture.HttpClient.PutAsync(url, content);
                await VerifyResponseAsync(response);
                var result = new MemoryStream();
                await fixture.Client.DownloadObjectAsync(bucket, name, result);
                AssertContentEqual(data, result.ToArray());

                // Reset the state and wait until the URL expires.
                await fixture.Client.DeleteObjectAsync(bucket, name);

                return async () =>
                {
                    // Verify that the URL no longer works.
                    content = createPutContent();
                    response = await fixture.HttpClient.PutAsync(url, content);
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
                    var obj = await fixture.Client.ListObjectsAsync(bucket, name).FirstOrDefaultAsync(o => o.Name == name);
                    Assert.Null(obj);
                };
            }
        }

        private static void PutWithCustomerSuppliedEncryptionKeysTest_Common(StorageFixture fixture, UrlSigner signer, [CallerMemberName] string caller = null)
        {
            var bucket = fixture.SingleVersionBucket;
            var name = IdGenerator.FromGuid();
            var content = fixture.SmallContent;
            string url = null;

            EncryptionKey key = EncryptionKey.Generate();

            Func<HttpRequestMessage> createPutRequest = () =>
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Put,
                    Content = new ByteArrayContent(content)
                };
                key.ModifyRequest(request);
                return request;
            };

            fixture.RegisterDelayTest(
                s_duration,
                beforeDelay: async duration =>
                {
                    var request = createPutRequest();
                    url = signer.Sign(bucket, name, duration, request);

                    // Verify that the URL works initially.
                    request.RequestUri = new Uri(url);
                    var response = await fixture.HttpClient.SendAsync(request);
                    await VerifyResponseAsync(response);

                    // Make sure the encryption succeeded.
                    var downloadedContent = new MemoryStream();
                    await Assert.ThrowsAsync<GoogleApiException>(
                        () => fixture.Client.DownloadObjectAsync(bucket, name, downloadedContent));

                    await fixture.Client.DownloadObjectAsync(bucket, name, downloadedContent, new DownloadObjectOptions { EncryptionKey = key });
                    AssertContentEqual(content, downloadedContent.ToArray());
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    var request = createPutRequest();
                    request.RequestUri = new Uri(url);
                    var response = await fixture.HttpClient.SendAsync(request);
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

                    // Cleanup
                    await fixture.Client.DeleteObjectAsync(bucket, name);
                },
                caller);
        }

        private static void PutWithCustomHeadersTest_Common(StorageFixture fixture, UrlSigner signer, [CallerMemberName] string caller = null)
        {
            var bucket = fixture.SingleVersionBucket;
            var name = IdGenerator.FromGuid();
            var content = fixture.SmallContent;
            string url = null;

            Func<HttpRequestMessage> createRequest = () =>
            {
                using (var md5 = MD5.Create())
                {
                    return new HttpRequestMessage()
                    {
                        Content = new ByteArrayContent(content)
                        {
                            Headers =
                            {
                                { "Content-MD5", Convert.ToBase64String(md5.ComputeHash(content)) },
                                { "Content-Type", "text/plain" },
                                { "x-goog-z-content-foo", "val1" },
                                { "x-goog-a-content-bar", "val2" },
                                { "x-goog-foo", new [] { "val3", "val4" } }
                            }
                        },
                        Method = HttpMethod.Put,
                        Headers =
                        {
                            { "x-goog-foo2", "xy\r\n z" },
                            { "x-goog-bar", "  12345   " },
                            { "x-goog-foo2", new [] { "A B  C", "def" } }
                        }
                    };
                }
            };

            fixture.RegisterDelayTest(
                s_duration,
                beforeDelay: async duration =>
                {
                    var request = createRequest();
                    url = signer.Sign(bucket, name, duration, request);
                    request.RequestUri = new Uri(url);

                    // Verify that the URL works initially.
                    var response = await fixture.HttpClient.SendAsync(request);
                    await VerifyResponseAsync(response);
                    var result = new MemoryStream();
                    await fixture.Client.DownloadObjectAsync(bucket, name, result);
                    AssertContentEqual(fixture.SmallContent, result.ToArray());

                    // Reset the state.
                    await fixture.Client.DeleteObjectAsync(bucket, name);
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    var request = createRequest();
                    request.RequestUri = new Uri(url);
                    var response = await fixture.HttpClient.SendAsync(request);
                    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
                    var obj = await fixture.Client.ListObjectsAsync(bucket, name).FirstOrDefaultAsync(o => o.Name == name);
                    Assert.Null(obj);
                },
                caller);
        }

        private static void ResumableUploadTest_Common(StorageFixture fixture, UrlSigner signer, [CallerMemberName] string caller = null)
        {
            var bucket = fixture.SingleVersionBucket;
            var name = IdGenerator.FromGuid();
            var content = fixture.SmallContent;
            string url = null;

            fixture.RegisterDelayTest(
                s_duration,
                beforeDelay: async duration =>
                {
                    url = signer.Sign(bucket, name, duration, UrlSigner.ResumableHttpMethod);

                    // Verify that the URL works initially.
                    var uploader = SignedUrlResumableUpload.Create(url, new MemoryStream(content));
                    var progress = await uploader.UploadAsync();
                    Assert.Equal(UploadStatus.Completed, progress.Status);

                    var result = new MemoryStream();
                    await fixture.Client.DownloadObjectAsync(bucket, name, result);
                    AssertContentEqual(content, result.ToArray());

                    // Reset the state.
                    await fixture.Client.DeleteObjectAsync(bucket, name);
                },
                afterDelay: async () =>
                {
                    var uploader = SignedUrlResumableUpload.Create(url, new MemoryStream(content));

                    // Verify that the URL no longer works.
                    var progress = await uploader.UploadAsync();
                    Assert.Equal(UploadStatus.Failed, progress.Status);
                    Assert.IsType<GoogleApiException>(progress.Exception);

                    var obj = await fixture.Client.ListObjectsAsync(bucket, name).FirstOrDefaultAsync(o => o.Name == name);
                    Assert.Null(obj);
                },
                caller);
        }

        private static void ResumableUploadResumeTest_Common(StorageFixture fixture, UrlSigner signer, [CallerMemberName] string caller = null)
        {
            var bucket = fixture.SingleVersionBucket;
            var name = IdGenerator.FromGuid();
            var content = fixture.SmallContent;
            string url = null;

            fixture.RegisterDelayTest(
                s_duration,
                beforeDelay: async duration =>
                {
                    url = signer.Sign(bucket, name, duration, UrlSigner.ResumableHttpMethod);
                    var sessionUri = await SignedUrlResumableUpload.InitiateSessionAsync(url);

                    // Verify that the URL works initially.
                    var uploader = ResumableUpload.CreateFromUploadUri(sessionUri, new MemoryStream(content));
                    var progress = await uploader.ResumeAsync(sessionUri);
                    Assert.Null(progress.Exception);
                    Assert.Equal(UploadStatus.Completed, progress.Status);

                    var result = new MemoryStream();
                    await fixture.Client.DownloadObjectAsync(bucket, name, result);
                    AssertContentEqual(content, result.ToArray());

                    // Reset the state.
                    await fixture.Client.DeleteObjectAsync(bucket, name);
                },
                afterDelay: async () =>
                {
                    // Verify that the URL no longer works.
                    await Assert.ThrowsAsync<GoogleApiException>(() => SignedUrlResumableUpload.InitiateSessionAsync(url));

                    var obj = await fixture.Client.ListObjectsAsync(bucket, name).FirstOrDefaultAsync(o => o.Name == name);
                    Assert.Null(obj);
                },
                caller);
        }

        private static void ResumableUploadWithCustomerSuppliedEncryptionKeysTest_Common(StorageFixture fixture, UrlSigner signer, [CallerMemberName] string caller = null)
        {
            var bucket = fixture.SingleVersionBucket;
            var name = IdGenerator.FromGuid();
            var content = fixture.SmallContent;
            string url = null;

            EncryptionKey key = EncryptionKey.Generate();

            fixture.RegisterDelayTest(
                s_duration,
                beforeDelay: async duration =>
                {
                    url = signer.Sign(
                        bucket,
                        name,
                        duration,
                        UrlSigner.ResumableHttpMethod,
                        requestHeaders: new Dictionary<string, IEnumerable<string>> {
                    { "x-goog-encryption-algorithm", new [] { "AES256" }
}
                        });

                // Verify that the URL works initially.
                var uploader = SignedUrlResumableUpload.Create(
                            url,
                            new MemoryStream(content),
                            new ResumableUploadOptions { ModifySessionInitiationRequest = key.ModifyRequest });
                    var progress = await uploader.UploadAsync();
                    Assert.Null(progress.Exception);
                    Assert.Equal(UploadStatus.Completed, progress.Status);

                // Make sure the encryption succeeded.
                var downloadedData = new MemoryStream();
                    await Assert.ThrowsAsync<GoogleApiException>(
                        () => fixture.Client.DownloadObjectAsync(bucket, name, downloadedData));

                    await fixture.Client.DownloadObjectAsync(bucket, name, downloadedData, new DownloadObjectOptions { EncryptionKey = key });
                    AssertContentEqual(content, downloadedData.ToArray());
                },
                afterDelay: async () =>
                {
                    var uploader = SignedUrlResumableUpload.Create(
                        url,
                        new MemoryStream(content),
                        new ResumableUploadOptions { ModifySessionInitiationRequest = key.ModifyRequest });

                // Verify that the URL no longer works.
                var progress = await uploader.UploadAsync();
                    Assert.Equal(UploadStatus.Failed, progress.Status);
                    Assert.IsType<GoogleApiException>(progress.Exception);
                },
                caller);
        }


        private static async Task VerifyResponseAsync(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                // This will automatically fail, but gives more information about the failure cause than
                // simply asserting that IsSuccessStatusCode is true.
                Assert.Null(await response.Content.ReadAsStringAsync());
            }
        }

        private static void AssertContentEqual(byte[] expected, byte[] actual)
        {
            Assert.NotNull(actual);

            // Use the actual content string as the failure message so mis-matches are not truncated to 5 bytes in the build logs.
            Assert.True(expected.SequenceEqual(actual),
                $"Content did not match at {DateTimeOffset.UtcNow:s}. Actual content:\n{Encoding.UTF8.GetString(actual)}");
        }
    }
}
