// Copyright 2020 Google Inc. All Rights Reserved.
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

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using Xunit;
using static Google.Cloud.Storage.V1.UrlSigner;

namespace Google.Cloud.Storage.V1.Tests
{
    public partial class UrlSignerTest
    {
        public class RequestTemplateTest
        {
            [Fact]
            public void BucketNameValidation()
            {
                // Bucket names cannot be null or contain uppercase letters (among other rules).
                Assert.Throws<ArgumentNullException>(() => RequestTemplate.FromBucket(null));
                Assert.Throws<ArgumentException>(() => RequestTemplate.FromBucket("BUCKETNAME"));
            }

            [Fact]
            public void FromBucket()
            {
                var requestTemplate = RequestTemplate.FromBucket("bucket-name");

                Assert.Equal("bucket-name", requestTemplate.Bucket);
                Assert.Null(requestTemplate.ObjectName);
                Assert.Empty(requestTemplate.RequestHeaders);
                Assert.Empty(requestTemplate.ContentHeaders);
                Assert.Empty(requestTemplate.QueryParameters);
                Assert.Equal(HttpMethod.Get, requestTemplate.HttpMethod);
            }

            [Fact]
            public void WithBucket()
            {
                var requestTemplate = RequestTemplate.FromBucket("bucket-name");

                var newRequestTemplate = requestTemplate.WithBucket("another-bucket");

                Assert.NotSame(requestTemplate, newRequestTemplate);
                Assert.Equal("another-bucket", newRequestTemplate.Bucket);
            }

            [Fact]
            public void WithObjectName()
            {
                var requestTemplate = RequestTemplate.FromBucket("bucket-name");

                var newRequestTemplate = requestTemplate.WithObjectName("object-name");

                Assert.NotSame(requestTemplate, newRequestTemplate);
                Assert.Equal("object-name", newRequestTemplate.ObjectName);
            }

            [Fact]
            public void WithHttpMethod()
            {
                var requestTemplate = RequestTemplate.FromBucket("bucket-name");

                var newRequestTemplate = requestTemplate.WithHttpMethod(HttpMethod.Post);

                Assert.NotSame(requestTemplate, newRequestTemplate);
                Assert.Equal(HttpMethod.Post, newRequestTemplate.HttpMethod);
            }

            [Fact]
            public void WithRequesHeaders()
            {
                var requestTemplate = RequestTemplate.FromBucket("bucket-name");

                var headers = new Dictionary<string, IEnumerable<string>>
                {
                    { "header1", new List<string> { "value1", "value2"} },
                    { "header2", new List<string> {"value3"} }
                };

                var newRequestTemplate = requestTemplate.WithRequestHeaders(headers);

                var expectedHeaders = ToExpectedEntries(headers);
                Assert.NotSame(requestTemplate, newRequestTemplate);
                AssertDictionariesEqual(expectedHeaders, newRequestTemplate.RequestHeaders);
            }

            [Fact]
            public void WithContentHeaders()
            {
                var requestTemplate = RequestTemplate.FromBucket("bucket-name");

                var headers = new Dictionary<string, IEnumerable<string>>
                {
                    { "header1", new List<string> { "value1", "value2"} },
                    { "header2", new List<string> {"value3"} }
                };
                var newRequestTemplate = requestTemplate.WithContentHeaders(headers);

                var expectedHeaders = ToExpectedEntries(headers);
                Assert.NotSame(requestTemplate, newRequestTemplate);
                AssertDictionariesEqual(expectedHeaders, newRequestTemplate.ContentHeaders);
            }

            [Fact]
            public void WithQueryParameters()
            {
                var requestTemplate = RequestTemplate.FromBucket("bucket-name");

                var queryParameters = new Dictionary<string, IEnumerable<string>>
                {
                    { "query1", new List<string> { "value1", "value2" } },
                    { "query2", new List<string> {"value3" } }
                };
                var newRequestTemplate = requestTemplate.WithQueryParameters(queryParameters);

                var expectedParameters = ToExpectedEntries(queryParameters);
                Assert.NotSame(requestTemplate, newRequestTemplate);
                AssertDictionariesEqual(expectedParameters, newRequestTemplate.QueryParameters);
            }

            private void AssertDictionariesEqual(
                IReadOnlyDictionary<string, IReadOnlyCollection<string>> expected,
                IReadOnlyDictionary<string, IReadOnlyCollection<string>> actual)
            {
                // xUnit 2.5.0 changed the behavior of Assert.Equal; previously we could just use
                // Assert.Equal(expected, actual) for this.
                Assert.Equal(
                    expected.Keys.OrderBy(key => key, StringComparer.Ordinal),
                    actual.Keys.OrderBy(key => key, StringComparer.Ordinal));
                foreach (var key in expected.Keys)
                {
                    Assert.Equal(expected[key], actual[key]);
                }
            }

            private IReadOnlyDictionary<string, IReadOnlyCollection<string>> ToExpectedEntries(
                IDictionary<string, IEnumerable<string>> headers) =>
                new ReadOnlyDictionary<string, IReadOnlyCollection<string>>(
                    headers.ToDictionary(
                        pair => pair.Key,
                        pair => (IReadOnlyCollection<string>)pair.Value.ToList().AsReadOnly()));

            [Fact]
            public void WithHttpRequestMessage()
            {
                var requestTemplate = RequestTemplate.FromBucket("bucket-name");

                var message = new HttpRequestMessage(HttpMethod.Post, "http://will.be.ignored.com?param1=value1&param2=value2&param1=value3");
                message.Headers.Add("requestHeader", "value1");
                using (MemoryStream stream = new MemoryStream())
                {
                    message.Content = new StreamContent(stream);
                    message.Content.Headers.Add("contentHeader", "value2");
                }
                var newRequestTemplate = requestTemplate.WithHttpRequestMessage(message);

                Assert.NotSame(requestTemplate, newRequestTemplate);
                Assert.Equal(HttpMethod.Post, newRequestTemplate.HttpMethod);
                Assert.Collection(newRequestTemplate.RequestHeaders, pair => AssertHeader(pair, "requestHeader", "value1"));
                Assert.Collection(newRequestTemplate.ContentHeaders, pair => AssertHeader(pair, "contentHeader", "value2"));
                Assert.Equal(2, newRequestTemplate.QueryParameters.Count);
                Assert.Equal(2, newRequestTemplate.QueryParameters["param1"].Count);
                Assert.Equal(1, newRequestTemplate.QueryParameters["param2"].Count);
                Assert.Equal("value2", newRequestTemplate.QueryParameters["param2"].First());

                void AssertHeader(KeyValuePair<string, IReadOnlyCollection<string>> pair, string header, string value)
                {
                    Assert.Equal(header, pair.Key);
                    Assert.Equal(value, pair.Value.Single());
                }
            }
        }
    }
}
