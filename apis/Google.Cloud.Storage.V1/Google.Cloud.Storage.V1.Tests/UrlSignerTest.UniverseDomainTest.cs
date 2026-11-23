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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Http;
using System;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Storage.V1.UrlSigner;

namespace Google.Cloud.Storage.V1.Tests
{
    public partial class UrlSignerTest
    {
        public class UniverseDomainTest
        {
            [Theory]
            [InlineData(null, SigningVersion.V4, "storage.googleapis.com")]
            [InlineData("googleapis.com", SigningVersion.V4, "storage.googleapis.com")]
            [InlineData("custom-universe.com", SigningVersion.V4, "storage.custom-universe.com")]
            [InlineData("custom-universe.com", SigningVersion.V2, "storage.custom-universe.com")]
            public void ServiceAccountCredential_Sign_UsesCredentialUniverseDomain(
                string universeDomain, SigningVersion signingVersion, string expectedHost)
            {
                var credential = CreateServiceAccountCredential(universeDomain);
                var signer = UrlSigner.FromCredential(credential);

                var url = signer.Sign("bucket", "object", TimeSpan.FromMinutes(1), signingVersion: signingVersion);

                Assert.Equal(expectedHost, new Uri(url).Host);
            }

            [Theory]
            [InlineData(null, SigningVersion.V4, "storage.googleapis.com")]
            [InlineData("googleapis.com", SigningVersion.V4, "storage.googleapis.com")]
            [InlineData("custom-universe.com", SigningVersion.V4, "storage.custom-universe.com")]
            [InlineData("custom-universe.com", SigningVersion.V2, "storage.custom-universe.com")]
            public async Task ServiceAccountCredential_SignAsync_UsesCredentialUniverseDomain(
                string universeDomain, SigningVersion signingVersion, string expectedHost)
            {
                var credential = CreateServiceAccountCredential(universeDomain);
                var signer = UrlSigner.FromCredential(credential);

                var url = await signer.SignAsync("bucket", "object", TimeSpan.FromMinutes(1), signingVersion: signingVersion);

                Assert.Equal(expectedHost, new Uri(url).Host);
            }

            [Theory]
            [InlineData(null, "storage.googleapis.com")]
            [InlineData("custom-universe.com", "storage.custom-universe.com")]
            public void ServiceAccountCredential_SignPostPolicy_UsesCredentialUniverseDomain(
                string universeDomain, string expectedHost)
            {
                var credential = CreateServiceAccountCredential(universeDomain);
                var signer = UrlSigner.FromCredential(credential);
                var policy = PostPolicy.ForBucketAndKey("bucket", "object");
                var options = Options.FromDuration(TimeSpan.FromMinutes(1));

                var signedPolicy = signer.Sign(policy, options);

                Assert.Equal(expectedHost, signedPolicy.PostUrl.Host);
            }

            [Theory]
            [InlineData(null, "storage.googleapis.com")]
            [InlineData("custom-universe.com", "storage.custom-universe.com")]
            public async Task ServiceAccountCredential_SignPostPolicyAsync_UsesCredentialUniverseDomain(
                string universeDomain, string expectedHost)
            {
                var credential = CreateServiceAccountCredential(universeDomain);
                var signer = UrlSigner.FromCredential(credential);
                var policy = PostPolicy.ForBucketAndKey("bucket", "object");
                var options = Options.FromDuration(TimeSpan.FromMinutes(1));

                var signedPolicy = await signer.SignAsync(policy, options);

                Assert.Equal(expectedHost, signedPolicy.PostUrl.Host);
            }

            [Fact]
            public void GoogleCredential_UsesUnderlyingUniverseDomain()
            {
                var credential = CreateServiceAccountCredential("custom-universe.com").ToGoogleCredential();
                var signer = UrlSigner.FromCredential(credential);

                var url = signer.Sign("bucket", "object", TimeSpan.FromMinutes(1));

                Assert.Equal("storage.custom-universe.com", new Uri(url).Host);
            }

            [Fact]
            public void ImpersonatedCredential_Sign_UsesSourceUniverseDomain()
            {
                var credential = CreateImpersonatedCredential("custom-universe.com");
                var signer = UrlSigner.FromCredential(credential);

                var url = signer.Sign("bucket", "object", TimeSpan.FromMinutes(1));

                Assert.Equal("storage.custom-universe.com", new Uri(url).Host);
            }

            [Fact]
            public async Task ImpersonatedCredential_SignAsync_UsesSourceUniverseDomain()
            {
                var credential = CreateImpersonatedCredential("custom-universe.com");
                var signer = UrlSigner.FromCredential(credential);

                var url = await signer.SignAsync("bucket", "object", TimeSpan.FromMinutes(1));

                Assert.Equal("storage.custom-universe.com", new Uri(url).Host);
            }

            [Fact]
            public void ComputeCredential_Sign_UsesCredentialUniverseDomain()
            {
                var credential = CreateComputeCredential("custom-universe.com");
                var signer = UrlSigner.FromCredential(credential);

                var url = signer.Sign("bucket", "object", TimeSpan.FromMinutes(1));

                Assert.Equal("storage.custom-universe.com", new Uri(url).Host);
            }

            [Fact]
            public async Task ComputeCredential_SignAsync_UsesCredentialUniverseDomain()
            {
                var credential = CreateComputeCredential("custom-universe.com");
                var signer = UrlSigner.FromCredential(credential);

                var url = await signer.SignAsync("bucket", "object", TimeSpan.FromMinutes(1));

                Assert.Equal("storage.custom-universe.com", new Uri(url).Host);
            }

            [Fact]
            public void FromBlobSigner_Sign_UsesDefaultUniverseDomain()
            {
                string expectedHost = "storage.googleapis.com";
                var signer = UrlSigner.FromBlobSigner(new FakeBlobSigner());

                var url = signer.Sign("bucket", "object", TimeSpan.FromMinutes(1));

                Assert.Equal(expectedHost, new Uri(url).Host);
            }

            [Fact]
            public async Task FromBlobSigner_SignAsync_UsesUniverseDomainEnvironmentVariable()
            {
                string expectedHost = "storage.googleapis.com";
                var signer = UrlSigner.FromBlobSigner(new FakeBlobSigner());

                var url = await signer.SignAsync("bucket", "object", TimeSpan.FromMinutes(1));

                Assert.Equal(expectedHost, new Uri(url).Host);
            }

            [Fact]
            public void ExplicitOptionsHost_OverridesCredentialUniverseDomain()
            {
                var credential = CreateServiceAccountCredential("custom-universe.com");
                var signer = UrlSigner.FromCredential(credential);
                var template = RequestTemplate.FromBucket("bucket").WithObjectName("object");
                var options = Options.FromDuration(TimeSpan.FromMinutes(1)).WithHost("explicit.host.example");

                var url = signer.Sign(template, options);

                Assert.Equal("explicit.host.example", new Uri(url).Host);
            }

            [Fact]
            public void WithDefaultOptionsOverride_OverridesCredentialUniverseDomain()
            {
                var credential = CreateServiceAccountCredential("custom-universe.com");
                var signer = UrlSigner.FromCredential(credential)
                    .WithDefaultOptionsOverride(new DefaultOptionsOverrides("http", "emulator.host.example", 4443));

                var url = signer.Sign("bucket", "object", TimeSpan.FromMinutes(1));
                var uri = new Uri(url);

                Assert.Equal("http", uri.Scheme);
                Assert.Equal("emulator.host.example", uri.Host);
                Assert.Equal(4443, uri.Port);
            }

            private static ServiceAccountCredential CreateServiceAccountCredential(string universeDomain) =>
                new ServiceAccountCredential(new ServiceAccountCredential.Initializer("test@example.com")
                {
                    Key = RSA.Create(),
                    UseJwtAccessWithScopes = true,
                    UniverseDomain = universeDomain
                });

            private static ImpersonatedCredential CreateImpersonatedCredential(string universeDomain)
            {
                var sourceCredential = CreateServiceAccountCredential(universeDomain).ToGoogleCredential();
                var impersonated = sourceCredential.Impersonate(new ImpersonatedCredential.Initializer("target@example.com")
                {
                    HttpClientFactory = new FakeSigningHttpClientFactory()
                });
                return (ImpersonatedCredential) impersonated.UnderlyingCredential;
            }

            private static ComputeCredential CreateComputeCredential(string universeDomain) =>
                (ComputeCredential) new ComputeCredential(new ComputeCredential.Initializer
                {
                    HttpClientFactory = new FakeSigningHttpClientFactory()
                }).ToGoogleCredential().CreateWithUniverseDomain(universeDomain).UnderlyingCredential;

            private sealed class FakeSigningHttpClientFactory : HttpClientFactory
            {
                protected override HttpMessageHandler CreateHandler(CreateHttpClientArgs args) =>
                    new FakeSigningMessageHandler();
            }

            private sealed class FakeSigningMessageHandler : HttpMessageHandler
            {
                protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
                {
                    var uri = request.RequestUri.AbsoluteUri;
                    if (uri.EndsWith(":signBlob", StringComparison.Ordinal))
                    {
                        return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
                        {
                            Content = new StringContent("{\"signedBlob\":\"QUFB\"}", Encoding.UTF8, "application/json")
                        });
                    }
                    if (uri.Contains("/token"))
                    {
                        return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
                        {
                            Content = new StringContent("{\"access_token\":\"fake-token\",\"expires_in\":3600,\"token_type\":\"Bearer\"}", Encoding.UTF8, "application/json")
                        });
                    }
                    if (uri.EndsWith("/email", StringComparison.Ordinal))
                    {
                        return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
                        {
                            Content = new StringContent("compute@example.com", Encoding.UTF8, "text/plain")
                        });
                    }
                    return Task.FromResult(new HttpResponseMessage(HttpStatusCode.NotFound));
                }
            }
        }
    }
}
