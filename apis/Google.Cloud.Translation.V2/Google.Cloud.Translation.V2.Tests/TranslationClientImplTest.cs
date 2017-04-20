// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Apis.Services;
using TranslateService = Google.Apis.Translate.v2.TranslateService;
using Google.Apis.Translate.v2.Data;
using Google.Apis.Util;
using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using static Google.Apis.Translate.v2.TranslationsResource.ListRequest;

namespace Google.Cloud.Translation.V2.Tests
{
    public class TranslationClientImplTest
    {
        private static readonly TranslationClient ThrowingServiceClient =
            new TranslationClientImpl(new TranslateService(new BaseClientService.Initializer
            {
                HttpClientFactory = FakeHttpClientFactory.Throwing
            }));

        [Fact]
        public void NullArgumentChecks()
        {
            Assert.Throws<ArgumentNullException>(() => ThrowingServiceClient.DetectLanguage(null));
            Assert.Throws<ArgumentNullException>(() => ThrowingServiceClient.DetectLanguages(null));
            Assert.Throws<ArgumentNullException>(() => ThrowingServiceClient.TranslateText((string) null, "en"));
            Assert.Throws<ArgumentNullException>(() => ThrowingServiceClient.TranslateText((IEnumerable<string>) null, "en"));
            Assert.Throws<ArgumentNullException>(() => ThrowingServiceClient.TranslateHtml((string)null, "en"));
            Assert.Throws<ArgumentNullException>(() => ThrowingServiceClient.TranslateHtml((IEnumerable<string>)null, "en"));
            Assert.Throws<ArgumentNullException>(() => ThrowingServiceClient.TranslateText("text", null));
            Assert.Throws<ArgumentNullException>(() => ThrowingServiceClient.TranslateText(new[] { "text" }, null));
            Assert.Throws<ArgumentNullException>(() => ThrowingServiceClient.TranslateHtml("html", null));
            Assert.Throws<ArgumentNullException>(() => ThrowingServiceClient.TranslateHtml(new[] { "html" }, null));
        }

        [Fact]
        public async Task NullArgumentAsyncChecks()
        {
            await Assert.ThrowsAsync<ArgumentNullException>(() => ThrowingServiceClient.DetectLanguageAsync(null));
            await Assert.ThrowsAsync<ArgumentNullException>(() => ThrowingServiceClient.DetectLanguagesAsync(null));
            await Assert.ThrowsAsync<ArgumentNullException>(() => ThrowingServiceClient.TranslateTextAsync((string)null, "en"));
            await Assert.ThrowsAsync<ArgumentNullException>(() => ThrowingServiceClient.TranslateTextAsync((IEnumerable<string>)null, "en"));
            await Assert.ThrowsAsync<ArgumentNullException>(() => ThrowingServiceClient.TranslateHtmlAsync((string)null, "en"));
            await Assert.ThrowsAsync<ArgumentNullException>(() => ThrowingServiceClient.TranslateHtmlAsync((IEnumerable<string>)null, "en"));
            await Assert.ThrowsAsync<ArgumentNullException>(() => ThrowingServiceClient.TranslateTextAsync("text", null));
            await Assert.ThrowsAsync<ArgumentNullException>(() => ThrowingServiceClient.TranslateTextAsync(new[] { "text" }, null));
            await Assert.ThrowsAsync<ArgumentNullException>(() => ThrowingServiceClient.TranslateHtmlAsync("html", null));
            await Assert.ThrowsAsync<ArgumentNullException>(() => ThrowingServiceClient.TranslateHtmlAsync(new[] { "html" }, null));
        }

        [Fact]
        public void NullElementSyncChecks()
        {
            Assert.Throws<ArgumentException>(() => ThrowingServiceClient.DetectLanguages(new[] { "text", null, "text" }));
            Assert.Throws<ArgumentException>(() => ThrowingServiceClient.TranslateText(new[] { "text", null, "text" }, "en"));
            Assert.Throws<ArgumentException>(() => ThrowingServiceClient.TranslateHtml(new[] { "html", null, "html" }, "en"));
        }

        [Fact]
        public async Task NullElementAsyncChecks()
        {
            await Assert.ThrowsAsync<ArgumentException>(() => ThrowingServiceClient.DetectLanguagesAsync(new[] { "text", null, "text" }));
            await Assert.ThrowsAsync<ArgumentException>(() => ThrowingServiceClient.TranslateTextAsync(new[] { "text", null, "text" }, "en"));
            await Assert.ThrowsAsync<ArgumentException>(() => ThrowingServiceClient.TranslateHtmlAsync(new[] { "html", null, "html" }, "en"));
        }

        [Fact]
        public void NonMatchingTranslateResultCount()
        {
            var service = new FakeTranslateService();
            var client = new TranslationClientImpl(service);
            var inputs = new string[] { "a", "b" };
            var request = service.Translations.List(new Repeatable<string>(inputs), "en");
            request.Format = FormatEnum.Text;
            var response = new TranslationsListResponse
            {
                // Content is irrelevant; we shouldn't get that far
                Translations = new List<TranslationsResource> { new TranslationsResource() }
            };

            service.ExpectRequest(request, response);
            Assert.Throws<InvalidOperationException>(() => client.TranslateText(inputs, "en"));
        }

        [Fact]
        public void NonMatchingDetectionResultCount()
        {
            var service = new FakeTranslateService();
            var client = new TranslationClientImpl(service);
            var inputs = new string[] { "a", "b" };
            var request = service.Detections.List(new Repeatable<string>(inputs));
            var response = new DetectionsListResponse
            {
                // Content is irrelevant; we shouldn't get that far
                Detections = new List<IList<DetectionsResourceItems>>
                {
                    new List<DetectionsResourceItems> { new DetectionsResourceItems { Language = "en" } }
                }
            };

            service.ExpectRequest(request, response);
            Assert.Throws<InvalidOperationException>(() => client.DetectLanguages(inputs));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(2)]
        public void DetectionResultHasNonSingleList(int count)
        {
            var service = new FakeTranslateService();
            var client = new TranslationClientImpl(service);
            var inputs = new string[] { "a", "b" };
            var request = service.Detections.List(new Repeatable<string>(inputs));
            var response = new DetectionsListResponse
            {
                // This time we have the right number of top-level results, but the second
                // result doesn't have a single entry
                Detections = new List<IList<DetectionsResourceItems>>
                {
                    new List<DetectionsResourceItems> { new DetectionsResourceItems { Language = "en" } },
                    Enumerable.Repeat(new DetectionsResourceItems { Language = "en" }, count).ToList()
                }
            };

            service.ExpectRequest(request, response);
            Assert.Throws<InvalidOperationException>(() => client.DetectLanguages(inputs));
        }

        [Fact]
        public void DetectionValid()
        {
            var service = new FakeTranslateService();
            var client = new TranslationClientImpl(service);
            var inputs = new string[] { "a", "b" };
            var request = service.Detections.List(new Repeatable<string>(inputs));
            var response = new DetectionsListResponse
            {
                Detections = new List<IList<DetectionsResourceItems>>
                {
                    new List<DetectionsResourceItems> { new DetectionsResourceItems { Language = "en", Confidence = 0.5f, IsReliable = true } },
                    new List<DetectionsResourceItems> { new DetectionsResourceItems { Language = "fr", Confidence = 0.8f, IsReliable = true } },
                }
            };

            service.ExpectRequest(request, response);
            var result = client.DetectLanguages(inputs);
            // Just check the original text and language.
            Assert.Equal("a", result[0].Text);
            Assert.Equal("en", result[0].Language);

            Assert.Equal("b", result[1].Text);
            Assert.Equal("fr", result[1].Language);
        }
    }
}
