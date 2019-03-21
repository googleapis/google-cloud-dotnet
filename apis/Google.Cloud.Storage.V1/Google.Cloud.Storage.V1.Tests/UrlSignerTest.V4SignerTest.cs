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
using Google.Apis.Auth.OAuth2;
using Google.Cloud.ClientTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
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
            private static readonly ServiceAccountCredential s_testCredential =
                (ServiceAccountCredential) GoogleCredential.FromJson(ReadTextResource("UrlSignerV4TestAccount.json")).UnderlyingCredential;
            private static readonly Dictionary<string, HttpMethod> s_methods = new Dictionary<string, HttpMethod>
            {
                { "GET", HttpMethod.Get },
                { "POST", HttpMethod.Post },
                { "PUT", HttpMethod.Put }
            };

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

            public static IEnumerable<object[]> JsonTestData = JsonConvert.DeserializeObject<List<JsonTest>>(ReadTextResource("UrlSignerV4TestData.json"))
                .Select(test => new object[] { test })
                .ToList();

            [Theory]
            [InlineData(-1)]
            [InlineData(0)]
            [InlineData(7 * 24 * 60 * 60 + 1 /* One week + 1 second */)]
            public void ExpiryValidation_Invalid(int seconds)
            {
                var signer = UrlSigner
                    .FromServiceAccountCredential(s_testCredential)
                    .WithSigningVersion(SigningVersion.V4)
                    .WithClock(new FakeClock());

                Assert.Throws<ArgumentOutOfRangeException>(() => signer.Sign("bucket", "object", TimeSpan.FromSeconds(seconds), HttpMethod.Get));
            }

            [Fact]
            public void ExpiryValidation_Exactly1Week()
            {
                var signer = UrlSigner
                    .FromServiceAccountCredential(s_testCredential)
                    .WithSigningVersion(SigningVersion.V4)
                    .WithClock(new FakeClock());

                // Just testing that no exception is thrown.
                signer.Sign("bucket", "object", TimeSpan.FromDays(7), HttpMethod.Get);
            }

            [Theory, MemberData(nameof(JsonTestData))]
            public void JsonSourceTest(JsonTest test)
            {
                var timestamp = DateTime.ParseExact(
                    test.Timestamp,
                    "yyyyMMdd'T'HHmmss'Z'",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
                var clock = new FakeClock(timestamp);
                var signer = UrlSigner
                    .FromServiceAccountCredential(s_testCredential)
                    .WithSigningVersion(SigningVersion.V4)
                    .WithClock(clock);

                var actualUrl = signer.Sign(test.Bucket, test.Object,
                    duration: TimeSpan.FromSeconds(test.Expiration),
                    requestMethod: s_methods[test.Method],
                    requestHeaders: test.Headers?.ToDictionary(kvp => kvp.Key, kvp => (IEnumerable<string>) kvp.Value),
                    contentHeaders: null);

                // We almost always want the complete URL afterwards, which xUnit doesn't give us.
                if (test.ExpectedUrl != actualUrl)
                {
                    FileLogger.Log($"{test.Description} failure");
                    FileLogger.Log($"Expected: {test.ExpectedUrl}");
                    FileLogger.Log($"Actual: {actualUrl}");
                }
                Assert.Equal(test.ExpectedUrl, actualUrl);
            }

            private static string ReadTextResource(string name)
            {
                var typeInfo = typeof(UrlSignerTest).GetTypeInfo();

                using (var reader = new StreamReader(typeInfo.Assembly.GetManifestResourceStream($"{typeInfo.Namespace}.{name}")))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        public class JsonTest
        {
            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("bucket")]
            public string Bucket { get; set; }

            [JsonProperty("object")]
            public string Object { get; set; }

            [JsonProperty("method")]
            public string Method { get; set; }

            [JsonProperty("expiration")]
            public int Expiration { get; set; }

            [JsonProperty("headers")]
            public Dictionary<string, string[]> Headers { get; set; }

            [JsonProperty("timestamp")]
            public string Timestamp { get; set; }

            [JsonProperty("expectedUrl")]
            public string ExpectedUrl { get; set; }

            public override string ToString() => Description;
        }
    }
}
