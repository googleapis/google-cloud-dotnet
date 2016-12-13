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
        public void Valid(string headerValue)
        {
            HashValidatingDownloader downloader = CreateDownloader(request => CreateResponse(headerValue));
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

        [Fact]
        public void Invalid()
        {
            HashValidatingDownloader downloader = CreateDownloader(request => CreateResponse("crc32c=Bogus1=="));
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

        private static HashValidatingDownloader CreateDownloader(Func<HttpRequestMessage, HttpResponseMessage> handler)
        {
            var service = new MockableService(handler);
            return new HashValidatingDownloader(service);
        }

        class MockableService : BaseClientService
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

        private static HttpResponseMessage CreateResponse(string headerValue)
        {
            HttpResponseMessage response = new HttpResponseMessage { Content = new ByteArrayContent(s_data) };
            if (headerValue != null)
            {
                response.Headers.Add(Crc32c.HashHeaderName, headerValue);
            }
            return response;
        }
    }
}
