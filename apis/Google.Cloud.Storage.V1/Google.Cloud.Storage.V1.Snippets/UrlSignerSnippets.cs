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
using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(StorageSnippetFixture))]
    public class UrlSignerSnippets
    {
        // https://cloud.google.com/storage/docs/authentication/hmackeys#restrictions
        private static readonly TimeSpan s_hmacKeyCreationConsistencyDelay = TimeSpan.FromSeconds(30);

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
            var credential = await GoogleCredential.GetApplicationDefaultAsync();
            using var httpClient = new HttpClient();

            // Sample: SignedURLGet
            // Additional: Sign(string,string,TimeSpan,*,*)
            // Create a signed URL which can be used to get a specific object for one hour.
            UrlSigner urlSigner = UrlSigner.FromCredential(credential);
            string url = await urlSigner.SignAsync(bucketName, objectName, TimeSpan.FromHours(1));

            // Get the content at the created URL.
            HttpResponseMessage response = await httpClient.GetAsync(url);
            string content = await response.Content.ReadAsStringAsync();
            // End sample

            Assert.Equal(_fixture.HelloWorldContent, content);
        }

        [SkippableFact]
        public async Task ComputeSignedURLGet()
        {
            _fixture.SkipIf(!await ComputeCredential.IsRunningOnComputeEngine());

            var bucketName = _fixture.BucketName;
            var objectName = _fixture.HelloStorageObjectName;
            using var httpClient = new HttpClient();

            // Sample: ComputeSignedURLGet
            // Additional: Sign(string,string,TimeSpan,*,*)
            // Create a signed URL which can be used to get a specific object for one hour.
            var computeCredential = new ComputeCredential();
            UrlSigner urlSigner = UrlSigner.FromCredential(computeCredential);
            string url = await urlSigner.SignAsync(bucketName, objectName, TimeSpan.FromHours(1));

            // Get the content at the created URL.
            HttpResponseMessage response = await httpClient.GetAsync(url);
            string content = await response.Content.ReadAsStringAsync();
            // End sample

            Assert.Equal(_fixture.HelloWorldContent, content);
        }

        [Fact]
        public async Task HmacSignedURLGet()
        {
            var bucketName = _fixture.BucketName;
            var objectName = _fixture.HelloStorageObjectName;
            var actualCredential = (await GoogleCredential.GetApplicationDefaultAsync()).UnderlyingCredential;
            string serviceAccountEmail = actualCredential switch
            {
                ServiceAccountCredential sa => sa.Id,
                ComputeCredential comp => await comp.GetDefaultServiceAccountEmailAsync(),
                _ => throw new InvalidOperationException($"Credential type not supported for HMAC creation: {actualCredential.GetType().FullName}")
            };
            using var httpClient = new HttpClient();

            using var storageClient = await StorageClient.CreateAsync();
            var hmacKey = await storageClient.CreateHmacKeyAsync(_fixture.ProjectId, serviceAccountEmail);
            var hmacKeyId = hmacKey.Metadata.AccessId;
            var hmacKeySecret = hmacKey.Secret;
            // Let's wait for the HMAC key to be ready for use.
            await Task.Delay(s_hmacKeyCreationConsistencyDelay);

            try
            {

                // Sample: HmacSignedURLGet
                // Additional: Sign(string,string,TimeSpan,*,*)
                // Create an HmacBlobSigner from an HMAC Key ID and Secret.
                UrlSigner.IBlobSigner blobSigner = UrlSigner.HmacBlobSigner.Create(hmacKeyId, hmacKeySecret);
                // Create a URL signer from the HmacBlobSigner.
                UrlSigner urlSigner = UrlSigner.FromBlobSigner(blobSigner);
                // Create an HMAC signed URL which can be used to get a specific object for one hour.
                string url = urlSigner.Sign(bucketName, objectName, TimeSpan.FromHours(1));

                // Get the content at the created URL.
                HttpResponseMessage response = await httpClient.GetAsync(url);
                string content = await response.Content.ReadAsStringAsync();
                // End sample

                Assert.Equal(_fixture.HelloWorldContent, content);
            }
            finally
            {
                // We need to deactivate key before we can delete it.
                hmacKey.Metadata.State = HmacKeyStates.Inactive;
                await storageClient.UpdateHmacKeyAsync(hmacKey.Metadata);
                await storageClient.DeleteHmacKeyAsync(_fixture.ProjectId, hmacKey.Metadata.AccessId);
            }
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
            var credential = await GoogleCredential.GetApplicationDefaultAsync();
            using var httpClient = new HttpClient();

            // Sample: WithSigningVersion
            // Create a signed URL which can be used to get a specific object for one hour,
            // using the V4 signing process.
            UrlSigner urlSigner = UrlSigner.FromCredential(credential);
            string url = await urlSigner.SignAsync(bucketName, objectName, TimeSpan.FromHours(1), signingVersion: SigningVersion.V4);

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
            var credential = await GoogleCredential.GetApplicationDefaultAsync();
            using var httpClient = new HttpClient();

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
            UrlSigner urlSigner = UrlSigner.FromCredential(credential);
            string url = await urlSigner.SignAsync(requestTemplate, options);

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

        [Fact]
        public async Task PostPolicySimple()
        {
            var bucketName = _fixture.BucketName;
            var objectName = "places/world.txt";
            var credential = await GoogleCredential.GetApplicationDefaultAsync();

            // Sample: PostPolicySimple
            // [START storage_generate_signed_post_policy_v4]
            // Create a signed post policy which can be used to upload a specific object and
            // expires in 1 hour after creation.
            UrlSigner urlSigner = UrlSigner.FromCredential(credential);
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
            var credential = await GoogleCredential.GetApplicationDefaultAsync();

            // Sample: PostPolicyCacheControl
            // Create a signed post policy which can be used to upload a specific object with a
            // specific cache-control value and expires in 1 hour after creation.
            UrlSigner urlSigner = UrlSigner.FromCredential(credential);
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
            var credential = await GoogleCredential.GetApplicationDefaultAsync();

            // Sample: PostPolicyAcl
            // Create a signed post policy which can be used to upload a specific object and
            // expires in 10 seconds after creation.
            // It also sets a starts-with condition on the acl form element, that should be met
            // by the actual form used for posting.
            UrlSigner urlSigner = UrlSigner.FromCredential(credential);
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
            var credential = await GoogleCredential.GetApplicationDefaultAsync();

            // Sample: PostPolicySuccessStatus
            // Create a signed post policy which can be used to upload a specific object and
            // expires in 1 hour after creation.
            // It also sets a specific HTTP success satus code that should be returned.
            // Only 200, 201 and 204 are allowed.
            UrlSigner urlSigner = UrlSigner.FromCredential(credential);
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
