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
using Google.Apis.Download;
using Google.Apis.Http;
using Google.Apis.Services;
using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using Xunit;

namespace Google.Cloud.Storage.V1.Tests
{
    public class HashValidatingDownloaderTest
    {
        private static readonly byte[] s_data = Enumerable.Range(0, 200000).Select(i => (byte) i).ToArray();
        private const string Md5Value = "md5=PL4+tNeevS58x7PmIPW6YA==";
        private const string Crc32Value = "crc32c=WfO2Ug==";

        [Theory]
        [InlineData(null)]
        [InlineData(Md5Value)]
        [InlineData(Md5Value + "," + Crc32Value)]
        [InlineData(Crc32Value + "," + Md5Value)]
        [InlineData(Crc32Value)]
        public void Valid_ModeAlways(string headerValue)
        {
            HashValidatingDownloader downloader = CreateDownloader(request => CreateResponse(request, headerValue), DownloadValidationMode.Always);
            AssertDownloadSucceeds(downloader);
        }

        [Theory]
        [InlineData("gzip", "gzip")]
        [InlineData(null, "gzip")]
        [InlineData("plain", null)]
        [InlineData("plain", "gzip")]
        [InlineData("gzip", "plain")]
        [InlineData("gzip", null)]
        [InlineData(null, null)]
        [InlineData("plain", "plain")]
        public void Valid_ModeAutomatic(string storedContentEncoding, string contentEncoding)
        {
            // This test doesn't try different hashes exhaustively; the way it treats the header
            // is the same as with Always.
            string headerValue = Md5Value + "," + Crc32Value;
            HashValidatingDownloader downloader = CreateDownloader(
                request => CreateResponse(request, headerValue, storedContentEncoding, contentEncoding),
                DownloadValidationMode.Automatic);
            AssertDownloadSucceeds(downloader);
        }

        [Fact]
        public void Invalid_ModeAlways()
        {
            HashValidatingDownloader downloader = CreateDownloader(request => CreateResponse(request, "crc32c=Bogus1=="), DownloadValidationMode.Always);
            AssertDownloadFails(downloader);
        }

        // - Mode is DownloadValidationMode.Automatic
        // - Data is incorrect
        // - And we're validating (so will throw)
        [Theory]
        [InlineData("gzip", "gzip")]
        [InlineData(null, "gzip")]
        [InlineData("plain", null)]
        [InlineData("plain", "gzip")]
        [InlineData(null, null)]
        [InlineData("plain", "plain")]
        public void InvalidData_ModeAutomatic_Validated(string storedContentEncoding, string contentEncoding)
        {
            HashValidatingDownloader downloader = CreateDownloader(
                request => CreateResponse(request, "crc32c=Bogus1==", storedContentEncoding, contentEncoding),
                DownloadValidationMode.Automatic);
            AssertDownloadFails(downloader);
        }

        // - Mode is DownloadValidationMode.Automatic
        // - Data is incorrect
        // - We're not validating because of the stored content encoding / content encoding (so will "succeed")
        [Theory]
        [InlineData("gzip", "plain")]
        [InlineData("gzip", null)]
        public void InvalidData_ModeAutomatic_NotValidated(string storedContentEncoding, string contentEncoding)
        {
            HashValidatingDownloader downloader = CreateDownloader(
                request => CreateResponse(request, "crc32c=Bogus1==", storedContentEncoding, contentEncoding),
                DownloadValidationMode.Automatic);
            AssertDownloadSucceeds(downloader);
        }

        [Fact]
        public void Invalid_ModeNever()
        {
            HashValidatingDownloader downloader = CreateDownloader(request => CreateResponse(request, "crc32c=Bogus1=="), DownloadValidationMode.Never);
            AssertDownloadSucceeds(downloader);
        }

        private static void AssertDownloadSucceeds(HashValidatingDownloader downloader)
        {
            for (int chunks = 1; chunks < 5; chunks++)
            {
                // Make sure it definitely fits...
                downloader.ChunkSize = (s_data.Length + 100) / chunks;
                var stream = new MemoryStream();
                var status = downloader.Download("http://pretend.google.com/", stream);
                if (status.Exception != null)
                {
                    throw status.Exception;
                }
                Assert.Equal(DownloadStatus.Completed, status.Status);
                Assert.Equal(s_data, stream.ToArray());
            }
        }

        private static void AssertDownloadFails(HashValidatingDownloader downloader)
        {
            for (int chunks = 1; chunks < 5; chunks++)
            {
                // Make sure it definitely fits...
                downloader.ChunkSize = (s_data.Length + 100) / chunks;
                var stream = new MemoryStream();
                var status = downloader.Download("http://pretend.google.com/", stream);
                Assert.Equal(DownloadStatus.Failed, status.Status);
                Assert.Contains("Incorrect hash", status.Exception.Message);
            }
        }

        private static HashValidatingDownloader CreateDownloader(Func<HttpRequestMessage, HttpResponseMessage> handler, DownloadValidationMode mode)
        {
            var service = new MockableService(handler);
            var metadata = new Apis.Storage.v1.Data.Object();
            return new HashValidatingDownloader(metadata, service, mode);
        }

        internal class MockableService : BaseClientService
        {
            internal MockableService(Func<HttpRequestMessage, HttpResponseMessage> handler)
                : base(GetInitializer(handler))
            {
            }

            public override string BasePath => "";
            public override string BaseUri => "";
            public override IList<string> Features => new List<string>();
            public override string Name => "Mockable";

            private static Initializer GetInitializer(Func<HttpRequestMessage, HttpResponseMessage> handler)
            {
                var httpMessageHandler = new MockableMessageHandler(handler);
                var configurableHandler = new ConfigurableMessageHandler(httpMessageHandler);
                var clientFactory = new FakeHttpClientFactory(configurableHandler);
                return new Initializer { HttpClientFactory = clientFactory };
            }
        }

        private static HttpResponseMessage CreateResponse(
            HttpRequestMessage request, string hashHeaderValue,
            string storedContentEncoding = null, string contentEncoding = null)
        {
            HttpResponseMessage response = new HttpResponseMessage { Content = new ByteArrayContent(s_data) };
            if (hashHeaderValue != null)
            {
                response.Headers.Add(Crc32c.HashHeaderName, hashHeaderValue);
            }
            if (storedContentEncoding != null)
            {
                response.Headers.Add(HashValidatingDownloader.StoredContentEncodingHeaderName, storedContentEncoding);
            }
            if (contentEncoding != null)
            {
                response.Content.Headers.ContentEncoding.Add(contentEncoding);
            }
            MaybeIntercept(request, response);
            return response;
        }

        // This is ugly - it's effectively mimicing the code in the REST support library for response stream
        // interception. We basically want to use Google.Apis.Http.StreamInterceptionHandler, but that's (understandably)
        // internal. Fake it for now. An alternative might be to use reflection, but that's brittle too.
        private static void MaybeIntercept(HttpRequestMessage request, HttpResponseMessage response)
        {
            var provider = request.Properties[ConfigurableMessageHandler.ResponseStreamInterceptorProviderKey] as Func<HttpResponseMessage, StreamInterceptor>;
            if (provider == null)
            {
                return;
            }
            var interceptor = provider(response);
            if (interceptor == null)
            {
                return;
            }
            interceptor(s_data, 0, s_data.Length);
            return;
        }
    }
}
