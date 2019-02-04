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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Xunit;

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
                var bucket = "jessefrank2";
                var obj = "kitten.png";
                var clock = new FakeClock(new DateTime(2018, 11, 19, 5, 56, 54, DateTimeKind.Utc));
                var expiry = TimeSpan.FromHours(1);
                var serviceAccount = CreateFakeServiceAccountCredential("test-account@spec-test-ruby-samples.iam.gserviceaccount.com");
                var signer = UrlSigner
                    .FromServiceAccountCredential(serviceAccount)
                    .WithSigningVersion(SigningVersion.V4)
                    .WithClock(clock);

                var uriString = signer.Sign(bucket, obj, expiry, HttpMethod.Get);
                var parameters = ExtractQueryParameters(uriString);

                Assert.Equal("GOOG4-RSA-SHA256", parameters["x-goog-algorithm"]);
                Assert.Equal("test-account%40spec-test-ruby-samples.iam.gserviceaccount.com%2F20181119%2Fauto%2Fgcs%2Fgoog4_request", parameters["x-goog-credential"]);
                Assert.Equal("20181119T055654Z", parameters["x-goog-date"]);
                Assert.Equal("3600", parameters["x-goog-expires"]);
                Assert.Equal("host", parameters["x-goog-signedheaders"]);
                
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
        }
    }
}
