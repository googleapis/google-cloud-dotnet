// Copyright 2019 Google LLC
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

using Google.Api.Gax.Testing;
using Google.Cloud.ClientTesting;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Xunit;
using static Google.Cloud.Storage.V1.UrlSigner;

namespace Google.Cloud.Storage.V1.Tests.Conformance
{
    public class V4SignerConformanceTest
    {
        public static TheoryData<SigningV4Test> V4SigningTestData { get; } = StorageConformanceTestData.TestData.GetTheoryData(f => f.SigningV4Tests);
        public static TheoryData<PostPolicyV4Test> V4PostPolicyTestData { get; } = StorageConformanceTestData.TestData.GetTheoryData(f => f.PostPolicyV4Tests);

        private static readonly Dictionary<string, HttpMethod> s_methods = new Dictionary<string, HttpMethod>
            {
                { "GET", HttpMethod.Get },
                { "POST", HttpMethod.Post },
                { "PUT", HttpMethod.Put }
            };

        [Theory, MemberData(nameof(V4SigningTestData))]
        public void SigningTest(SigningV4Test test)
        {
            var timestamp = test.Timestamp.ToDateTime();
            var clock = new FakeClock(timestamp);
            var signer = UrlSigner
                .FromServiceAccountCredential(StorageConformanceTestData.TestCredential)
                .WithClock(clock);

            var requestTemplate = RequestTemplate
                .FromBucket(test.Bucket)
                .WithObjectName(test.Object)
                .WithHttpMethod(s_methods[test.Method])
                .WithRequestHeaders(test.Headers.ToDictionary(kvp => kvp.Key, kvp => Enumerable.Repeat(kvp.Value, 1)))
                .WithQueryParameters(test.QueryParameters.ToDictionary(kvp => kvp.Key, kvp => Enumerable.Repeat(kvp.Value, 1)));
            var options = Options
                .FromDuration(TimeSpan.FromSeconds(test.Expiration))
                .WithSigningVersion(SigningVersion.V4)
                .WithScheme(test.Scheme);

            switch (test.UrlStyle)
            {
                case UrlStyle.VirtualHostedStyle:
                    options = options.WithUrlStyle(UrlSigner.UrlStyle.VirtualHostedStyle);
                    break;
                case UrlStyle.BucketBoundHostname:
                    options = options.WithBucketBoundHostname(test.BucketBoundHostname);
                    break;
                default:
                    break;
            }

            var actualUrl = signer.Sign(requestTemplate, options);

            // We almost always want the complete URL afterwards, which xUnit doesn't give us.
            if (test.ExpectedUrl != actualUrl)
            {
                FileLogger.Log($"{test.Description} failure");
                FileLogger.Log($"Expected: {test.ExpectedUrl}");
                FileLogger.Log($"Actual: {actualUrl}");
            }
            Assert.Equal(test.ExpectedUrl, actualUrl);
        }

        [Theory, MemberData(nameof(V4PostPolicyTestData))]
        public void PostPolicyTest(PostPolicyV4Test test)
        {
            var timestamp = test.PolicyInput.Timestamp.ToDateTime();
            var clock = new FakeClock(timestamp);
            var signer = UrlSigner
                .FromServiceAccountCredential(StorageConformanceTestData.TestCredential)
                .WithClock(clock);

            var options = Options
                .FromDuration(TimeSpan.FromSeconds(test.PolicyInput.Expiration))
                .WithSigningVersion(SigningVersion.V4)
                .WithScheme(test.PolicyInput.Scheme);
            switch (test.PolicyInput.UrlStyle)
            {
                case UrlStyle.VirtualHostedStyle:
                    options = options.WithUrlStyle(UrlSigner.UrlStyle.VirtualHostedStyle);
                    break;
                case UrlStyle.BucketBoundHostname:
                    options = options.WithBucketBoundHostname(test.PolicyInput.BucketBoundHostname);
                    break;
                default:
                    break;
            }

            var postPolicy = PostPolicy.ForBucketAndKey(test.PolicyInput.Bucket, test.PolicyInput.Object, new PostPolicyElementTestComparer());

            foreach (var field in test.PolicyInput.Fields)
            {
                if (field.Key.StartsWith("x-goog-meta-"))
                {
                    postPolicy.SetCustomField(PostPolicyCustomElement.GoogleMetadata, field.Key, field.Value);
                }
                else
                {
                    var element = GetStandardElement(field.Key);
                    if (element == PostPolicyStandardElement.SuccessActionStatus)
                    {
                        postPolicy.SetField(element, (HttpStatusCode)int.Parse(field.Value));
                    }
                    else
                    {
                        postPolicy.SetField(element, field.Value);
                    }
                }
            }

            for (int i = 0; i < test.PolicyInput.Conditions?.StartsWith?.Count; i+=2)
            {
                postPolicy.SetStartsWith(
                    GetStandardElement(test.PolicyInput.Conditions.StartsWith[i]),
                    test.PolicyInput.Conditions.StartsWith[i + 1]);
            }

            if (test.PolicyInput.Conditions?.ContentLengthRange?.Count > 0)
            {
                postPolicy.SetRange(PostPolicyStandardElement.ContentLength, test.PolicyInput.Conditions.ContentLengthRange[0], test.PolicyInput.Conditions.ContentLengthRange[1]);
            }

            var signedPostPolicy = signer.Sign(postPolicy, options);

            Assert.Equal(test.PolicyOutput.Url, signedPostPolicy.PostUrl.ToString());

            Assert.Equal(test.PolicyOutput.Fields.Count, signedPostPolicy.Fields.Count);
            foreach (var field in test.PolicyOutput.Fields)
            {
                Assert.True(signedPostPolicy.Fields.TryGetValue(field.Key, out object value));
                Assert.Equal(field.Value, value.ToString());
            }

            PostPolicyStandardElement GetStandardElement(string name) =>
                name switch
                {
                    "acl" => PostPolicyStandardElement.Acl,
                    "$acl" => PostPolicyStandardElement.Acl,
                    "cache-control" => PostPolicyStandardElement.CacheControl,
                    "$cache-control" => PostPolicyStandardElement.CacheControl,
                    "success_action_status" => PostPolicyStandardElement.SuccessActionStatus,
                    "$success_action_status" => PostPolicyStandardElement.SuccessActionStatus,
                    "success_action_redirect" => PostPolicyStandardElement.SuccessActionRedirect,
                    "$success_action_redirect" => PostPolicyStandardElement.SuccessActionRedirect,
                    _ => throw new NotImplementedException($"{name} missing from {nameof(GetStandardElement)}.")
                };
        }

        private class PostPolicyElementTestComparer : IComparer<IPostPolicyElement>
        {
            private static readonly IDictionary<string, int> s_elementOrder = new Dictionary<string, int>
            {
                { "acl", 0 },
                { "content-length", 1 },
                { "cache-control", 2 },
                { "success_action_status", 3 },
                { "success_action_redirect", 4 },
                { "x-goog-meta-custom-1", 5},
                { "bucket", 6 },
                { "key", 7 },
                { "x-goog-date", 8 },
                { "x-goog-credential", 9 },
                { "x-goog-algorithm", 10 },
            };

            public int Compare(IPostPolicyElement x, IPostPolicyElement y) =>
                s_elementOrder[x.ElementName].CompareTo(s_elementOrder[y.ElementName]);
        }
    }

    public partial class SigningV4Test : ICustomDiagnosticMessage
    {
        public string ToDiagnosticString() => Description;
    }

    public partial class PostPolicyV4Test : ICustomDiagnosticMessage
    {
        public string ToDiagnosticString() => Description;
    }
}
