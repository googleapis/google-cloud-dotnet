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

using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Iam.v1;
using Google.Apis.Iam.v1.Data;
using Google.Apis.Services;
using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.Snippets
{
    [SnippetOutputCollector]
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
        public async Task WithSigningVersion()
        {
            var bucketName = _fixture.BucketName;
            var objectName = _fixture.HelloStorageObjectName;
            var credential = (await GoogleCredential.GetApplicationDefaultAsync()).UnderlyingCredential as ServiceAccountCredential;
            var httpClient = new HttpClient();

            // Sample: WithSigningVersion
            // Additional: WithSigningVersion(SigningVersion)
            // Create a signed URL which can be used to get a specific object for one hour,
            // using the V4 signing process.
            UrlSigner urlSigner = UrlSigner
                .FromServiceAccountCredential(credential)
                .WithSigningVersion(SigningVersion.V4);
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

        // Sample: IamServiceBlobSigner
        internal sealed class IamServiceBlobSigner : UrlSigner.IBlobSigner
        {
            private readonly IamService _iamService;
            public string Id { get; }

            internal IamServiceBlobSigner(IamService service, string id)
            {
                _iamService = service;
                Id = id;
            }

            public string CreateSignature(byte[] data) =>
                CreateRequest(data).Execute().Signature;

            public async Task<string> CreateSignatureAsync(byte[] data, CancellationToken cancellationToken)
            {
                ProjectsResource.ServiceAccountsResource.SignBlobRequest request = CreateRequest(data);
                SignBlobResponse response = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
                return response.Signature;
            }

            private ProjectsResource.ServiceAccountsResource.SignBlobRequest CreateRequest(byte[] data)
            {
                SignBlobRequest body = new SignBlobRequest { BytesToSign = Convert.ToBase64String(data) };
                string account = $"projects/-/serviceAccounts/{Id}";
                ProjectsResource.ServiceAccountsResource.SignBlobRequest request =
                    _iamService.Projects.ServiceAccounts.SignBlob(body, account);
                return request;
            }
        }
        // End sample

        [SkippableFact]
        public async Task SignedUrlWithIamServiceBlobSigner()
        {
            _fixture.SkipIf(Platform.Instance().Type == PlatformType.Unknown);

            var bucketName = _fixture.BucketName;
            var objectName = _fixture.HelloStorageObjectName;
            var credential = (await GoogleCredential.GetApplicationDefaultAsync()).UnderlyingCredential as ServiceAccountCredential;
            var httpClient = new HttpClient();

            // Sample: IamServiceBlobSignerUsage        
            // First obtain the email address of the default service account for this instance from the metadata server.
            HttpRequestMessage serviceAccountRequest = new HttpRequestMessage
            {
                // Note: you could use 169.254.169.254 as the address to avoid a DNS lookup.
                RequestUri = new Uri("http://metadata.google.internal/computeMetadata/v1/instance/service-accounts/default/email"),
                Headers = { { "Metadata-Flavor", "Google" } }
            };
            HttpResponseMessage serviceAccountResponse = await httpClient.SendAsync(serviceAccountRequest).ConfigureAwait(false);
            serviceAccountResponse.EnsureSuccessStatusCode();
            string serviceAccountId = await serviceAccountResponse.Content.ReadAsStringAsync();

            // Create an IAM service client object using the default application credentials.
            GoogleCredential iamCredential = await GoogleCredential.GetApplicationDefaultAsync();
            iamCredential = iamCredential.CreateScoped(IamService.Scope.CloudPlatform);
            IamService iamService = new IamService(new BaseClientService.Initializer
            {
                HttpClientInitializer = iamCredential
            });

            // Create a URL signer that will use the IAM service for signing. This signer is thread-safe,
            // and would typically occur as a dependency, e.g. in an ASP.NET Core controller, where the
            // same instance can be reused for each request.
            IamServiceBlobSigner blobSigner = new IamServiceBlobSigner(iamService, serviceAccountId);
            UrlSigner urlSigner = UrlSigner.FromBlobSigner(blobSigner);

            // Use the URL signer to sign a request for the test object for the next hour.
            string url = await urlSigner.SignAsync(
                bucketName,
                objectName,
                TimeSpan.FromHours(1),
                HttpMethod.Get);

            // Prove we can fetch the content of the test object with a simple unauthenticated GET request.
            HttpResponseMessage response = await httpClient.GetAsync(url);
            string content = await response.Content.ReadAsStringAsync();
            // End sample

            Assert.Equal(_fixture.HelloWorldContent, content);
        }
    }
}
