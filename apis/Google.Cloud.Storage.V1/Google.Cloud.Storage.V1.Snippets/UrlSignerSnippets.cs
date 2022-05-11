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
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
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
            // Additional: Sign(string,string,TimeSpan,*,*)
            // Create a signed URL which can be used to get a specific object for one hour.
            UrlSigner urlSigner = UrlSigner.FromServiceAccountCredential(credential);
            string url = urlSigner.Sign(bucketName, objectName, TimeSpan.FromHours(1));

            // Get the content at the created URL.
            HttpResponseMessage response = await httpClient.GetAsync(url);
            string content = await response.Content.ReadAsStringAsync();
            // End sample

            Assert.Equal(_fixture.HelloWorldContent, content);
        }

        // See-also: Sign(string,string,TimeSpan,*,*)
        // Member: Sign(UrlSigner.RequestTemplate, UrlSigner.Options)
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
            // Create a signed URL which can be used to get a specific object for one hour,
            // using the V4 signing process.
            UrlSigner urlSigner = UrlSigner
                .FromServiceAccountCredential(credential);
            string url = urlSigner.Sign(bucketName, objectName, TimeSpan.FromHours(1), signingVersion: SigningVersion.V4);

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
            // Create a request template that will be used to create the signed URL.
            var destination = "places/world.txt";
            UrlSigner.RequestTemplate requestTemplate = UrlSigner.RequestTemplate
                .FromBucket(bucketName)
                .WithObjectName(destination)
                .WithHttpMethod(HttpMethod.Put)
                .WithContentHeaders(new Dictionary<string, IEnumerable<string>> 
                {
                    { "Content-Type", new[] { "text/plain" } }
                });
            // Create options specifying for how long the signer URL will be valid.
            UrlSigner.Options options = UrlSigner.Options.FromDuration(TimeSpan.FromHours(1));
            // Create a signed URL which allows the requester to PUT data with the text/plain content-type.
            UrlSigner urlSigner = UrlSigner.FromServiceAccountCredential(credential);
            string url = urlSigner.Sign(requestTemplate, options);

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

            public string Algorithm => "GOOG4-RSA-SHA256";

            internal IamServiceBlobSigner(IamService service, string id)
            {
                _iamService = service;
                Id = id;
            }

            public string CreateSignature(byte[] data, UrlSigner.BlobSignerParameters _) =>
                CreateRequest(data).Execute().Signature;

            public async Task<string> CreateSignatureAsync(byte[] data, UrlSigner.BlobSignerParameters _, CancellationToken cancellationToken)
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

            // Create a request template that will be used to create the signed URL.
            UrlSigner.RequestTemplate requestTemplate = UrlSigner.RequestTemplate
                .FromBucket(bucketName)
                .WithObjectName(objectName)
                .WithHttpMethod(HttpMethod.Get);
            // Create options specifying for how long the signer URL will be valid.
            UrlSigner.Options options = UrlSigner.Options.FromDuration(TimeSpan.FromHours(1));

            // Create a URL signer that will use the IAM service for signing. This signer is thread-safe,
            // and would typically occur as a dependency, e.g. in an ASP.NET Core controller, where the
            // same instance can be reused for each request.
            IamServiceBlobSigner blobSigner = new IamServiceBlobSigner(iamService, serviceAccountId);
            UrlSigner urlSigner = UrlSigner.FromBlobSigner(blobSigner);

            // Use the URL signer to sign a request for the test object for the next hour.
            string url = await urlSigner.SignAsync(requestTemplate, options);

            // Prove we can fetch the content of the test object with a simple unauthenticated GET request.
            HttpResponseMessage response = await httpClient.GetAsync(url);
            string content = await response.Content.ReadAsStringAsync();
            // End sample

            Assert.Equal(_fixture.HelloWorldContent, content);
        }

        [Fact]
        public async Task PostPolicySimple()
        {
            var bucketName = _fixture.BucketName;
            var objectName = "places/world.txt";
            var credential = (await GoogleCredential.GetApplicationDefaultAsync()).UnderlyingCredential as ServiceAccountCredential;

            // Sample: PostPolicySimple
            // [START storage_generate_signed_post_policy_v4]
            // Create a signed post policy which can be used to upload a specific object and
            // expires in 1 hour after creation.
            UrlSigner urlSigner = UrlSigner
                .FromServiceAccountCredential(credential);
            UrlSigner.Options options = UrlSigner.Options
                .FromDuration(TimeSpan.FromHours(1))
                .WithSigningVersion(SigningVersion.V4)
                .WithScheme("https");
            UrlSigner.PostPolicy postPolicy = UrlSigner.PostPolicy.ForBucketAndKey(bucketName, objectName);
            postPolicy.SetCustomField(UrlSigner.PostPolicyCustomElement.GoogleMetadata, "x-goog-meta-test", "data");

            UrlSigner.SignedPostPolicy signedPostPolicy = await urlSigner.SignAsync(postPolicy, options);

            // Create an HTML form including all the fields in the signed post policy.
            StringBuilder form = new StringBuilder();
            form.AppendLine($"<form action=\"{signedPostPolicy.PostUrl}\" method=\"post\" enctype=\"multipart/form-data\">");
            foreach (var field in signedPostPolicy.Fields)
            {
                form.AppendLine($"<input type=\"hidden\" name=\"{field.Key}\" value=\"{field.Value}\">");
            }
            // Include the file element. It should always be the last element in the form.
            form.AppendLine("<input name=\"file\" type=\"file\">");
            form.AppendLine("<input type=\"submit\" value=\"Upload\">");
            form.AppendLine("</form>");

            // You can now save the form to file and serve it as static content
            // or send it as the response to a request made to your application.
            File.WriteAllText("PostPolicySimple.html", form.ToString());
            // [END storage_generate_signed_post_policy_v4]
            //// End sample

            Assert.Contains(signedPostPolicy.PostUrl.ToString(), form.ToString());
            File.Delete("PostPolicySimple.html");
        }

        [Fact]
        public async Task PostPolicyCacheControl()
        {
            var bucketName = _fixture.BucketName;
            var objectName = "places/world.txt";
            var credential = (await GoogleCredential.GetApplicationDefaultAsync()).UnderlyingCredential as ServiceAccountCredential;

            // Sample: PostPolicyCacheControl
            // Create a signed post policy which can be used to upload a specific object with a
            // specific cache-control value and expires in 1 hour after creation.
            UrlSigner urlSigner = UrlSigner
                .FromServiceAccountCredential(credential);
            UrlSigner.Options options = UrlSigner.Options
                .FromDuration(TimeSpan.FromHours(1))
                .WithSigningVersion(SigningVersion.V4)
                .WithScheme("https");
            UrlSigner.PostPolicy postPolicy = UrlSigner.PostPolicy.ForBucketAndKey(bucketName, objectName);
            postPolicy.SetField(UrlSigner.PostPolicyStandardElement.Acl, "public-read");
            postPolicy.SetField(UrlSigner.PostPolicyStandardElement.CacheControl, "public,max-age=86400");

            UrlSigner.SignedPostPolicy signedPostPolicy = await urlSigner.SignAsync(postPolicy, options);

            // Create an HTML form including all the fields in the signed post policy.
            StringBuilder form = new StringBuilder();
            form.AppendLine($"<form action=\"{signedPostPolicy.PostUrl}\" method=\"post\" enctype=\"multipart/form-data\">");
            foreach (var field in signedPostPolicy.Fields)
            {
                form.AppendLine($"<input type=\"hidden\" name=\"{field.Key}\" value=\"{field.Value}\">");
            }
            // Include the file element. It should always be the last element in the form.
            form.AppendLine("<input name=\"file\" type=\"file\">");
            form.AppendLine("<input type=\"submit\" value=\"Upload\">");
            form.AppendLine("</form>");

            // You can now save the form to file and serve it as static content
            // or send it as the response to a request made to your application.
            File.WriteAllText("PostPolicyCacheControl.html", form.ToString());
            //// End sample

            Assert.Contains(signedPostPolicy.PostUrl.ToString(), form.ToString());
            File.Delete("PostPolicyCacheControl.html");
        }

        [Fact]
        public async Task PostPolicyAcl()
        {
            var bucketName = _fixture.BucketName;
            var objectName = "places/world.txt";
            var credential = (await GoogleCredential.GetApplicationDefaultAsync()).UnderlyingCredential as ServiceAccountCredential;

            // Sample: PostPolicyAcl
            // Create a signed post policy which can be used to upload a specific object and
            // expires in 10 seconds after creation.
            // It also sets a starts-with condition on the acl form element, that should be met
            // by the actual form used for posting.
            UrlSigner urlSigner = UrlSigner
                .FromServiceAccountCredential(credential);
            UrlSigner.Options options = UrlSigner.Options
                .FromDuration(TimeSpan.FromHours(1))
                .WithSigningVersion(SigningVersion.V4)
                .WithScheme("https");
            UrlSigner.PostPolicy postPolicy = UrlSigner.PostPolicy.ForBucketAndKey(bucketName, objectName);
            postPolicy.SetStartsWith(UrlSigner.PostPolicyStandardElement.Acl, "public");

            UrlSigner.SignedPostPolicy signedPostPolicy = await urlSigner.SignAsync(postPolicy, options);

            // Create an HTML form including all the fields in the signed post policy.
            StringBuilder form = new StringBuilder();
            form.AppendLine($"<form action=\"{signedPostPolicy.PostUrl}\" method=\"post\" enctype=\"multipart/form-data\">");
            foreach (var field in signedPostPolicy.Fields)
            {
                form.AppendLine($"<input type=\"hidden\" name=\"{field.Key}\" value=\"{field.Value}\">");
            }
            // Include also an acl element with a value that meets the condition set in the policy.
            form.AppendLine("<input type=\"hidden\" name=\"acl\" value=\"public-read\">");
            // Include the file element. It should always be the last element in the form.
            form.AppendLine("<input name=\"file\" type=\"file\">");
            form.AppendLine("<input type=\"submit\" value=\"Upload\">");
            form.AppendLine("</form>");

            // You can now save the form to file and serve it as static content
            // or send it as the response to a request made to your application.
            File.WriteAllText("PostPolicyAcl.html", form.ToString());
            //// End sample

            Assert.Contains(signedPostPolicy.PostUrl.ToString(), form.ToString());
            File.Delete("PostPolicyAcl.html");
        }

        [Fact]
        public async Task PostPolicySuccessStatus()
        {
            var bucketName = _fixture.BucketName;
            var objectName = "places/world.txt";
            var credential = (await GoogleCredential.GetApplicationDefaultAsync()).UnderlyingCredential as ServiceAccountCredential;

            // Sample: PostPolicySuccessStatus
            // Create a signed post policy which can be used to upload a specific object and
            // expires in 1 hour after creation.
            // It also sets a specific HTTP success satus code that should be returned.
            // Only 200, 201 and 204 are allowed.
            UrlSigner urlSigner = UrlSigner
                .FromServiceAccountCredential(credential);
            UrlSigner.Options options = UrlSigner.Options
                .FromDuration(TimeSpan.FromHours(1))
                .WithSigningVersion(SigningVersion.V4)
                .WithScheme("https");
            UrlSigner.PostPolicy postPolicy = UrlSigner.PostPolicy.ForBucketAndKey(bucketName, objectName);
            postPolicy.SetField(UrlSigner.PostPolicyStandardElement.SuccessActionStatus, HttpStatusCode.OK);

            UrlSigner.SignedPostPolicy signedPostPolicy = await urlSigner.SignAsync(postPolicy, options);

            // Create an HTML form including all the fields in the signed post policy.
            StringBuilder form = new StringBuilder();
            form.AppendLine($"<form action=\"{signedPostPolicy.PostUrl}\" method=\"post\" enctype=\"multipart/form-data\">");
            foreach (var field in signedPostPolicy.Fields)
            {
                form.AppendLine($"<input type=\"hidden\" name=\"{field.Key}\" value=\"{field.Value}\">");
            }
            // Include the file element. It should always be the last element in the form.
            form.AppendLine("<input name=\"file\" type=\"file\">");
            form.AppendLine("<input type=\"submit\" value=\"Upload\">");
            form.AppendLine("</form>");

            // You can now save the form to file and serve it as static content
            // or send it as the response to a request made to your application.
            File.WriteAllText("PostPolicySuccessStatus.html", form.ToString());
            //// End sample

            Assert.Contains(signedPostPolicy.PostUrl.ToString(), form.ToString());
            File.Delete("PostPolicySuccessStatus.html");
        }
    }
}
