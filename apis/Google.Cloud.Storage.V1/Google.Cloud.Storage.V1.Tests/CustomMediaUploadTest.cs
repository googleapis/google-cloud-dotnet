// Copyright 2026 Google LLC
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

using Google.Apis.Http;
using Google.Apis.Services;
using Google.Apis.Storage.v1;
using Google.Apis.Upload;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.Tests;

    public class CustomMediaUploadTest
    {
        [Fact]
        public void HashingStream_ShouldHandleRetries_WhenRestartedFromBeginning()
        {
            var data = Encoding.UTF8.GetBytes("The quick brown fox jumps over the lazy dog");
            var baseStream = new MemoryStream(data);
            var hashingStream = new CustomMediaUpload.HashingStream(baseStream);
            var buffer = new byte[data.Length];

            hashingStream.Read(buffer, 0, 10);

            // Simulate the Retry logic: Seek back to the beginning
            hashingStream.Position = 0;

            hashingStream.Read(buffer, 0, data.Length);
            var finalHash = hashingStream.GetBase64Hash();

            var expectedHasher = new Crc32c();
            expectedHasher.UpdateHash(data, 0, data.Length);
            var expectedHash = Convert.ToBase64String(expectedHasher.GetHash());
            Assert.Equal(expectedHash, finalHash);
        }

        [Fact]
        public void HashingStream_ShouldHandleRetries_WhenSeekingBackwardsToIntermediatePoint()
        {
            var data = Encoding.UTF8.GetBytes("The quick brown fox jumps over the lazy dog");
            var baseStream = new MemoryStream(data);
            var hashingStream = new CustomMediaUpload.HashingStream(baseStream);
            var buffer = new byte[data.Length];

            hashingStream.Read(buffer, 0, 10);

            // Simulate the Retry logic: Seek back to the intermediate point.
            hashingStream.Position = 5;

            hashingStream.Read(buffer, 0, data.Length);
            var finalHash = hashingStream.GetBase64Hash();

            var expectedHasher = new Crc32c();
            expectedHasher.UpdateHash(data, 0, data.Length);
            var expectedHash = Convert.ToBase64String(expectedHasher.GetHash());
            Assert.Equal(expectedHash, finalHash);
        }

        [Fact]
        public void HashingStream_ShouldDetectGaps_WhenResumingFromIntermediateOffset()
        {
            var data = Encoding.UTF8.GetBytes("The quick brown fox jumps over the lazy dog");
            var baseStream = new MemoryStream(data);

            // Simulate resuming an upload from a new process starting at intermediate offset 10
            baseStream.Position = 10;
            var hashingStream = new CustomMediaUpload.HashingStream(baseStream);
            var buffer = new byte[data.Length];

            var exception = Assert.Throws<ArgumentException>(() => hashingStream.Read(buffer, 0, data.Length - 10));
            Assert.Contains("Cannot perform hash validation when resuming", exception.Message);
            Assert.Equal("stream", exception.ParamName);
            Assert.True(hashingStream.HasGaps);
            Assert.False(hashingStream.IsHashComplete);
        }

        [Fact]
        public async Task CustomMediaUpload_ShouldContainHashHeaderAndCorrectHash_WhenRetriedFromIntermediateOffset()
        {
            var data = Encoding.UTF8.GetBytes("The quick brown fox jumps over the lazy dog");
            var expectedHasher = new Crc32c();
            expectedHasher.UpdateHash(data, 0, data.Length);
            var expectedHash = Convert.ToBase64String(expectedHasher.GetHash());

            var handler = new FakeUploadHandler();
            var service = new StorageService(new BaseClientService.Initializer
            {
                HttpClientFactory = new FakeHttpClientFactory(handler),
                GZipEnabled = false
            });

            var baseStream = new MemoryStream(data);
            var options = new UploadObjectOptions { UploadValidationMode = UploadValidationMode.RejectAndThrow };
            var wrappedStream = UploadObjectOptions.GetWrappedSourceStream(baseStream, options);
            var obj = new Object { Bucket = "test-bucket", Name = "test-object" };

            var uploader = new CustomMediaUpload(service, obj, "test-bucket", wrappedStream, "text/plain");

            // Simulate an upload where the stream is read, seeked backwards to an intermediate point, and then uploaded
            var buffer = new byte[10];
            wrappedStream.Read(buffer, 0, 10);
            wrappedStream.Position = 5;
            wrappedStream.Position = 0;

            var progress = await uploader.UploadAsync();
            Assert.Equal(UploadStatus.Completed, progress.Status);

            Assert.NotNull(handler.LastPutRequest);
            Assert.True(handler.LastPutRequest.Headers.TryGetValues("x-goog-hash", out var values));
            Assert.Contains($"crc32c={expectedHash}", values);
        }

        private class FakeHttpClientFactory : IHttpClientFactory
        {
            private readonly HttpMessageHandler _handler;
            public FakeHttpClientFactory(HttpMessageHandler handler) => _handler = handler;
            public ConfigurableHttpClient CreateHttpClient(CreateHttpClientArgs args) =>
                new ConfigurableHttpClient(new ConfigurableMessageHandler(_handler));
        }

        private class FakeUploadHandler : HttpMessageHandler
        {
            public HttpRequestMessage LastPutRequest { get; private set; }
            public int? ResumeRangeEnd { get; set; }

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                if (request.Method == HttpMethod.Post)
                {
                    var response = new HttpResponseMessage(HttpStatusCode.OK);
                    response.Headers.Location = new Uri("https://storage.googleapis.com/upload/storage/v1/b/test-bucket/o?uploadType=resumable&upload_id=fake-session");
                    return Task.FromResult(response);
                }

                if (request.Method == HttpMethod.Put)
                {
                    if (ResumeRangeEnd.HasValue && request.Content?.Headers.ContentLength == 0)
                    {
                        var resumeResponse = new HttpResponseMessage((HttpStatusCode) 308);
                        resumeResponse.Headers.Add("Range", $"bytes=0-{ResumeRangeEnd.Value}");
                        return Task.FromResult(resumeResponse);
                    }

                    LastPutRequest = request;
                    var response = new HttpResponseMessage(HttpStatusCode.OK)
                    {
                        Content = new StringContent("{\"bucket\":\"test-bucket\",\"name\":\"test-object\"}", Encoding.UTF8, "application/json")
                    };
                    return Task.FromResult(response);
                }

                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.BadRequest));
            }
        }
    }
