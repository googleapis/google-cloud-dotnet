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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Json;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;

namespace Google.Storage.V1.IntegrationTests
{
    using static TestHelpers;

    [Collection(nameof(StorageFixture))]
    public class SignedUrlUtilsTest
    {
        private readonly string _credentialsFilePath = GetCredentialsFilePath();
        private readonly TimeSpan _duration = TimeSpan.FromSeconds(5);
        private readonly StorageFixture _fixture;
        private readonly HttpClient _httpClient = new HttpClient();

        public SignedUrlUtilsTest(StorageFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async void DeleteTest()
        {
            var bucket = _fixture.SingleVersionBucket;
            var name = GenerateName();

            var url = SignedUrlUtils.Create(
                bucket,
                name,
                _credentialsFilePath,
                _duration,
                HttpMethod.Delete);

            // Upload an object which can be deleted with the URL.
            await _fixture.Client.UploadObjectAsync(bucket, name, "", new MemoryStream(_fixture.SmallContent));

            // Verify that the URL works initially.
            var response = await _httpClient.DeleteAsync(url);
            Assert.True(response.IsSuccessStatusCode);
            var obj = await _fixture.Client.ListObjectsAsync(bucket, name).FirstOrDefault(o => o.Name == name);
            Assert.Null(obj);

            // Restore the object and wait until the URL expires. 
            await _fixture.Client.UploadObjectAsync(bucket, name, "", new MemoryStream(_fixture.SmallContent));
            await Task.Delay(_duration);

            // Verify that the URL no longer works.
            response = await _httpClient.DeleteAsync(url);
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            obj = await _fixture.Client.ListObjectsAsync(bucket, name).FirstOrDefault(o => o.Name == name);
            Assert.NotNull(obj);

            // Cleanup
            await _fixture.Client.DeleteObjectAsync(bucket, name);
        }

        [Fact]
        public async void GetTest()
        {
            var url = SignedUrlUtils.Create(
                _fixture.ReadBucket,
                _fixture.SmallObject,
                _credentialsFilePath,
                _duration);

            // Verify that the URL works initially.
            var response = await _httpClient.GetAsync(url);
            var result = await response.Content.ReadAsByteArrayAsync();
            Assert.Equal(_fixture.SmallContent, result);

            // Wait until the URL expires.
            await Task.Delay(_duration);

            // Verify that the URL no longer works.
            response = await _httpClient.GetAsync(url);
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async void GetBucketTest()
        {
            var bucket = _fixture.ReadBucket;

            var url = SignedUrlUtils.Create(
                bucket,
                null,
                _credentialsFilePath,
                _duration);

            // Verify that the URL works initially.
            var response = await _httpClient.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();
            var document = XDocument.Parse(result);
            var ns = document.Root.GetDefaultNamespace();
            var keys = document.Root.Elements(ns + "Contents").Select(contents => contents.Element(ns + "Key").Value).ToList();
            var objectNames = await _fixture.Client.ListObjectsAsync(bucket, null).Select(o => o.Name).ToList();
            Assert.Equal(objectNames, keys);

            // Wait until the URL expires.
            await Task.Delay(_duration);

            // Verify that the URL no longer works.
            response = await _httpClient.GetAsync(url);
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async void GetWithCustomerSuppliedEncryptionKeysTest()
        {
            var bucket = _fixture.SingleVersionBucket;
            var name = GenerateName();
            var data = _fixture.SmallContent;

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
            putRequest.RequestUri = new Uri(SignedUrlUtils.Create(
                bucket,
                name,
                _credentialsFilePath,
                expiration: null,
                request: putRequest));
            var response = await _httpClient.SendAsync(putRequest);
            Assert.True(response.IsSuccessStatusCode);

            // Make sure the encryption succeeded.
            await Assert.ThrowsAsync<GoogleApiException>(
                () => _fixture.Client.DownloadObjectAsync(bucket, name, new MemoryStream()));
            
            Func<HttpRequestMessage> createGetRequest = () => new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                Headers = {
                    { "x-goog-encryption-algorithm", "AES256" },
                    { "x-goog-encryption-key", key },
                    { "x-goog-encryption-key-sha256", hash }
                }
            };
            var request = createGetRequest();
            var url = SignedUrlUtils.Create(
                bucket,
                name,
                _credentialsFilePath,
                _duration,
                request);
            request.RequestUri = new Uri(url);

            // Verify that the URL works initially.
            response = await _httpClient.SendAsync(request);
            var result = await response.Content.ReadAsByteArrayAsync();
            Assert.Equal(data, result);

            // Wait until the URL expires.
            await Task.Delay(_duration);

            // Verify that the URL no longer works.
            request = createGetRequest();
            request.RequestUri = new Uri(url);
            response = await _httpClient.SendAsync(request);
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

            // Cleanup
            await _fixture.Client.DeleteObjectAsync(bucket, name);
        }

        [Fact]
        public async void GetNoExpirationTest()
        {
            var url = SignedUrlUtils.Create(
                _fixture.ReadBucket,
                _fixture.SmallObject,
                _credentialsFilePath,
                expiration: null);

            // Verify that the URL works.
            var response = await _httpClient.GetAsync(url);
            var result = await response.Content.ReadAsByteArrayAsync();
            Assert.Equal(_fixture.SmallContent, result);
        }

        [Fact]
        public async void GetWithCustomHeadersTest()
        {
            Func<HttpRequestMessage> createRequest = () => new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                Headers = {
                    { "x-goog-foo", "xy\r\n z" },
                    { "x-goog-bar", "  12345   " },
                    { "x-goog-foo", new [] { "A B  C", "def" } }
                }
            };
            var request = createRequest();
            var url = SignedUrlUtils.Create(
                _fixture.ReadBucket,
                _fixture.SmallObject,
                _credentialsFilePath,
                _duration,
                request);
            request.RequestUri = new Uri(url);

            // Verify that the URL works initially.
            var response = await _httpClient.SendAsync(request);
            var result = await response.Content.ReadAsByteArrayAsync();
            Assert.Equal(_fixture.SmallContent, result);

            // Wait until the URL expires.
            await Task.Delay(_duration);

            // Verify that the URL no longer works.
            request = createRequest();
            request.RequestUri = new Uri(url);
            response = await _httpClient.SendAsync(request);
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async void HeadTest()
        {
            var url = SignedUrlUtils.Create(
                _fixture.ReadBucket,
                _fixture.SmallObject,
                _credentialsFilePath,
                _duration,
                HttpMethod.Head);
            Func<HttpRequestMessage> createRequest = () => new HttpRequestMessage(HttpMethod.Head, url);

            // Verify that the URL works initially.
            var response = await _httpClient.SendAsync(createRequest());
            Assert.True(response.IsSuccessStatusCode);

            // Wait until the URL expires.
            await Task.Delay(_duration);

            // Verify that the URL no longer works.
            response = await _httpClient.SendAsync(createRequest());
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async void HeadWithGetMethodSignedURLTest()
        {
            var url = SignedUrlUtils.Create(
                _fixture.ReadBucket,
                _fixture.SmallObject,
                _credentialsFilePath,
                _duration,
                HttpMethod.Get);
            Func<HttpRequestMessage> createRequest = () => new HttpRequestMessage(HttpMethod.Head, url);

            // Verify that the URL works initially.
            var response = await _httpClient.SendAsync(createRequest());
            Assert.True(response.IsSuccessStatusCode);

            // Wait until the URL expires.
            await Task.Delay(_duration);

            // Verify that the URL no longer works.
            response = await _httpClient.SendAsync(createRequest());
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async void PutTest()
        {
            var expireAction1 = await PutTestHelper(useContentMD5: false, useContentType: false);
            var expireAction2 = await PutTestHelper(useContentMD5: true, useContentType: false);
            var expireAction3 = await PutTestHelper(useContentMD5: false, useContentType: true);
            var expireAction4 = await PutTestHelper(useContentMD5: true, useContentType: true);

            // Wait for all URLs to expire.
            await Task.Delay(_duration);

            await expireAction1();
            await expireAction2();
            await expireAction3();
            await expireAction4();
        }

        private async Task<Func<Task>> PutTestHelper(bool useContentMD5, bool useContentType)
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
            var url = SignedUrlUtils.Create(
                bucket,
                name,
                _credentialsFilePath,
                _duration,
                HttpMethod.Put,
                contentHeaders: content.Headers.ToDictionary(h => h.Key, h => h.Value));

            // Verify that the URL works initially.
            var response = await _httpClient.PutAsync(url, content);
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
                response = await _httpClient.PutAsync(url, content);
                Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
                var obj = await _fixture.Client.ListObjectsAsync(bucket, name).FirstOrDefault(o => o.Name == name);
                Assert.Null(obj);
            };
        }

        [Fact]
        public async void PutWithCustomHeadersTest()
        {
            var bucket = _fixture.SingleVersionBucket;
            var name = GenerateName();
            var data = _fixture.SmallContent;

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
            var request = createRequest();
            var url = SignedUrlUtils.Create(
                bucket,
                name,
                _credentialsFilePath,
                _duration,
                request);
            request.RequestUri = new Uri(url);

            // Verify that the URL works initially.
            var response = await _httpClient.SendAsync(request);
            Assert.True(response.IsSuccessStatusCode);
            var result = new MemoryStream();
            await _fixture.Client.DownloadObjectAsync(bucket, name, result);
            Assert.Equal(result.ToArray(), _fixture.SmallContent);

            // Reset the state and wait until the URL expires.
            await _fixture.Client.DeleteObjectAsync(bucket, name);
            await Task.Delay(_duration);

            // Verify that the URL no longer works.
            request = createRequest();
            request.RequestUri = new Uri(url);
            response = await _httpClient.SendAsync(request);
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            var obj = await _fixture.Client.ListObjectsAsync(bucket, name).FirstOrDefault(o => o.Name == name);
            Assert.Null(obj);
        }

        private static string GetCredentialsFilePath()
        {
            // TODO: This is taken and changed slightly from DefaultCredentialProvider. Expose the pieces necessary so we don't need to duplicate logic.
            var credentialFilePath = Environment.GetEnvironmentVariable(CredentialEnvironmentVariable) ?? GetWellKnownCredentialFilePath();
            if (!string.IsNullOrEmpty(credentialFilePath) && File.Exists(credentialFilePath))
            {
                try
                {
                    using (var credentialStream = File.OpenRead(credentialFilePath))
                    {
                        var credentialParameters = NewtonsoftJsonSerializer.Instance.Deserialize<JsonCredentialParameters>(credentialStream);
                        if (credentialParameters.Type == JsonCredentialParameters.ServiceAccountCredentialType)
                        {
                            return credentialFilePath;
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new InvalidOperationException("Error deserializing JSON credential data.", e);
                }
            }

            throw new InvalidOperationException($"Set the {CredentialEnvironmentVariable} environment variable to a service account credentials JSON file");
        }

        // TODO: Everything below is taking from DefaultCredentialProvider. Try to expose it somehow to we don't need to duplicate logic.

        /// <summary>
        /// Environment variable override which stores the default application credentials file path.
        /// </summary>
        private const string CredentialEnvironmentVariable = "GOOGLE_APPLICATION_CREDENTIALS";

        /// <summary>Well known file which stores the default application credentials.</summary>
        private const string WellKnownCredentialsFile = "application_default_credentials.json";

        /// <summary>Environment variable which contains the Application Data settings.</summary>
        private const string AppdataEnvironmentVariable = "APPDATA";

        /// <summary>Environment variable which contains the location of home directory on UNIX systems.</summary>
        private const string HomeEnvironmentVariable = "HOME";

        /// <summary>GCloud configuration directory in Windows, relative to %APPDATA%.</summary>
        private const string CloudSDKConfigDirectoryWindows = "gcloud";

        /// <summary>GCloud configuration directory on Linux/Mac, relative to $HOME.</summary>
        private static readonly string CloudSDKConfigDirectoryUnix = Path.Combine(".config", "gcloud");

        private static string GetWellKnownCredentialFilePath()
        {
            var appData = Environment.GetEnvironmentVariable(AppdataEnvironmentVariable);
            if (appData != null)
            {
                return Path.Combine(appData, CloudSDKConfigDirectoryWindows, WellKnownCredentialsFile);
            }
            var unixHome = Environment.GetEnvironmentVariable(HomeEnvironmentVariable);
            if (unixHome != null)
            {
                return Path.Combine(unixHome, CloudSDKConfigDirectoryUnix, WellKnownCredentialsFile);
            }
            return Path.Combine(CloudSDKConfigDirectoryWindows, WellKnownCredentialsFile);
        }
    }
}
