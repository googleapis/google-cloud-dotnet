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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.Snippets
{
    [Collection(nameof(StorageSnippetFixture))]
    public class UrlSignerSnippets
    {
        private readonly StorageSnippetFixture _fixture;

        public UrlSignerSnippets(StorageSnippetFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task SignedURLGet()
        {
            var bucketName = _fixture.BucketName;
            var objectName = _fixture.HelloStorageObjectName;
            var credential = (await GoogleCredential.GetApplicationDefaultAsync()).UnderlyingCredential as ServiceAccountCredential;
            var httpClient = new HttpClient();

            // Sample: SignedURLGet
            // Additional: Sign(string,string,TimeSpan,*,*,*)
            // Create a signed URL which can be used to get a specific object for one hour.
            UrlSigner urlSigner = UrlSigner.FromServiceAccountCredential(credential);
            string url = urlSigner.Sign(
                bucketName,
                objectName,
                TimeSpan.FromHours(1),
                HttpMethod.Get);

            // Get the content at the created URL.
            HttpResponseMessage response = await httpClient.GetAsync(url);
            string content = await response.Content.ReadAsStringAsync();
            // End sample

            Assert.Equal(_fixture.HelloWorldContent, content);
        }

        // See-also: Sign(string,string,TimeSpan,*,*,*)
        // Member: Sign(string,string,TimeSpan,*)
        // Member: Sign(string,string,DateTimeOffset?,*)
        // Member: Sign(string,string,DateTimeOffset?,*,*,*)
        // See [Sign](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public async Task SignedURLPut()
        {
            var bucketName = _fixture.BucketName;
            var credential = (await GoogleCredential.GetApplicationDefaultAsync()).UnderlyingCredential as ServiceAccountCredential;
            var httpClient = new HttpClient();

            // Sample: SignedURLPut
            // Create a signed URL which allows the requester to PUT data with the text/plain content-type.
            UrlSigner urlSigner = UrlSigner.FromServiceAccountCredential(credential);
            var destination = "places/world.txt";
            string url = urlSigner.Sign(
                bucketName,
                destination,
                TimeSpan.FromHours(1),
                HttpMethod.Put,
                contentHeaders: new Dictionary<string, IEnumerable<string>> {
                    { "Content-Type", new[] { "text/plain" } }
                });

            // Upload the content into the bucket using the signed URL.
            string source = "world.txt";

            ByteArrayContent content;
            using (FileStream stream = File.OpenRead(source))
            {
                byte[] data = new byte[stream.Length];
                stream.Read(data, 0, data.Length);
                content = new ByteArrayContent(data)
                {
                    Headers = { ContentType = new MediaTypeHeaderValue("text/plain") }
                };
            }

            HttpResponseMessage response = await httpClient.PutAsync(url, content);
            // End sample

            Assert.True(response.IsSuccessStatusCode);

            var client = StorageClient.Create();
            var result = new MemoryStream();
            await client.DownloadObjectAsync(bucketName, destination, result);
            using (var stream = File.OpenRead(source))
            {
                var data = new byte[stream.Length];
                stream.Read(data, 0, data.Length);
                Assert.Equal(result.ToArray(), data);
            }

            await client.DeleteObjectAsync(bucketName, destination);
        }
    }
}
