// Copyright 2018 Google LLC
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
using Google.Cloud.Storage.V1.Tests.Conformance;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Google.Cloud.Storage.V1.UrlSigner;

namespace Google.Cloud.Storage.V1.Tests
{
    public partial class UrlSignerTest
    {
        /// <summary>
        /// UrlSigner unit tests that are specific to the V4 signing scheme
        /// </summary>
        public class V4SignerTest
        {
            // The data in this test is from an example in the Ruby implementation.
            [Fact]
            public void SampleRequest()
            {
                var clock = new FakeClock(new DateTime(2018, 11, 19, 5, 56, 54, DateTimeKind.Utc));
                var requestTemplate = RequestTemplate.FromBucket("jessefrank2").WithObjectName("kitten.png");
                var options = Options.FromDuration(TimeSpan.FromHours(1)).WithSigningVersion(SigningVersion.V4);
                var serviceAccount = CreateFakeServiceAccountCredential("test-account@spec-test-ruby-samples.iam.gserviceaccount.com");
                var signer = UrlSigner.FromCredential(serviceAccount).WithClock(clock);

                var uriString = signer.Sign(requestTemplate, options);
                var parameters = ExtractQueryParameters(uriString);

                Assert.Equal("GOOG4-RSA-SHA256", parameters["X-Goog-Algorithm"]);
                Assert.Equal("test-account%40spec-test-ruby-samples.iam.gserviceaccount.com%2F20181119%2Fauto%2Fstorage%2Fgoog4_request", parameters["X-Goog-Credential"]);
                Assert.Equal("20181119T055654Z", parameters["X-Goog-Date"]);
                Assert.Equal("3600", parameters["X-Goog-Expires"]);
                Assert.Equal("host", parameters["X-Goog-SignedHeaders"]);

                // No check for the exact signature.
            }

            // The data in this test is from an example in the Ruby implementation.
            [Fact]
            public void SampleRequest_ExplicitParams()
            {
                var clock = new FakeClock(new DateTime(2018, 11, 19, 5, 56, 54, DateTimeKind.Utc));
                var serviceAccount = CreateFakeServiceAccountCredential("test-account@spec-test-ruby-samples.iam.gserviceaccount.com");
                var signer = UrlSigner.FromCredential(serviceAccount).WithClock(clock);

                var uriString = signer.Sign("jessefrank2", "kitten.png", TimeSpan.FromHours(1), signingVersion: SigningVersion.V4);
                var parameters = ExtractQueryParameters(uriString);

                Assert.Equal("GOOG4-RSA-SHA256", parameters["X-Goog-Algorithm"]);
                Assert.Equal("test-account%40spec-test-ruby-samples.iam.gserviceaccount.com%2F20181119%2Fauto%2Fstorage%2Fgoog4_request", parameters["X-Goog-Credential"]);
                Assert.Equal("20181119T055654Z", parameters["X-Goog-Date"]);
                Assert.Equal("3600", parameters["X-Goog-Expires"]);
                Assert.Equal("host", parameters["X-Goog-SignedHeaders"]);

                // No check for the exact signature.
            }

            /// <summary>
            /// Extracts query parameters from a URI string *without* unescaping etc. (So this can be used to check for proper escaping.)
            /// </summary>
            private static Dictionary<string, string> ExtractQueryParameters(string uriString)
            {
                var uri = new Uri(uriString);
                return uri.Query.TrimStart('?').Split('&')
                    .Select(kvp => kvp.Split(new[] { '=' }, 2))
                    .ToDictionary(bits => bits[0], bits => bits[1]);
            }

            [Theory]
            [InlineData(-1)]
            [InlineData(0)]
            [InlineData(7 * 24 * 60 * 60 + 1 /* One week + 1 second */)]
            public void ExpiryValidation_Invalid(int seconds)
            {
                var signer = UrlSigner.FromCredential(StorageConformanceTestData.TestCredential)
                    .WithClock(new FakeClock());
                var requestTemplate = RequestTemplate.FromBucket("bucket").WithObjectName("object");
                var options = Options.FromDuration(TimeSpan.FromSeconds(seconds)).WithSigningVersion(SigningVersion.V4);

                Assert.Throws<ArgumentOutOfRangeException>(() => signer.Sign(requestTemplate, options));
            }

            [Fact]
            public void ExpiryValidation_Exactly1Week()
            {
                var signer = UrlSigner.FromCredential(StorageConformanceTestData.TestCredential).WithClock(new FakeClock());

                var requestTemplate = RequestTemplate.FromBucket("bucket").WithObjectName("object");
                var options = Options.FromDuration(TimeSpan.FromDays(7)).WithSigningVersion(SigningVersion.V4);

                // Just testing that no exception is thrown.
                signer.Sign(requestTemplate, options);
            }
        }
    }
}
