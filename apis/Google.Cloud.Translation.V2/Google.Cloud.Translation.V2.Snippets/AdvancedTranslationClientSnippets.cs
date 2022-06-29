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

using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Translation.V2.Snippets
{
    using static TranslationClientSnippets;

    [SnippetOutputCollector]
    public class AdvancedTranslationClientSnippets
    {
        [Fact]
        public void TranslateTextBaseDefaultModel()
        {
            // Sample: TranslateTextBaseDefaultModel
            AdvancedTranslationClient client = AdvancedTranslationClient.Create(model: "base");
            TranslationResult result = client.TranslateText("It is raining.", LanguageCodes.French);
            Console.WriteLine($"Result: {result.TranslatedText}; detected language {result.DetectedSourceLanguage}");
            // End sample

            Assert.Equal(RainingTranslation, result.TranslatedText);
            Assert.Equal("en", result.DetectedSourceLanguage);
        }

        [Fact]
        public void TranslateTextBaseOverrideModel()
        {
            // Sample: TranslateTextBaseOverrideModel
            AdvancedTranslationClient client = AdvancedTranslationClient.Create();
            TranslationResult result = client.TranslateText("It is raining.", LanguageCodes.French, model: "base");
            Console.WriteLine($"Result: {result.TranslatedText}; detected language {result.DetectedSourceLanguage}");
            // End sample

            Assert.Equal(RainingTranslation, result.TranslatedText);
            Assert.Equal("en", result.DetectedSourceLanguage);
        }

        [Fact]
        public void TranslateText()
        {
            // Sample: TranslateText
            // Additional: TranslateText(string, string, string, *)
            AdvancedTranslationClient client = AdvancedTranslationClient.Create();
            TranslationResult result = client.TranslateText("It is raining.", LanguageCodes.French);
            Console.WriteLine($"Result: {result.TranslatedText}; detected language {result.DetectedSourceLanguage}");
            // End sample

            Assert.Equal(RainingTranslation, result.TranslatedText);
            Assert.Equal("en", result.DetectedSourceLanguage);
        }

        [Fact]
        public async Task TranslateTextAsync()
        {
            // Snippet: TranslateTextAsync(string, string, string, *, *)
            AdvancedTranslationClient client = await AdvancedTranslationClient.CreateAsync();
            TranslationResult result = await client.TranslateTextAsync("It is raining.", LanguageCodes.French);
            Console.WriteLine($"Result: {result.TranslatedText}; detected language {result.DetectedSourceLanguage}");
            // End snippet

            Assert.Equal(RainingTranslation, result.TranslatedText);
            Assert.Equal("en", result.DetectedSourceLanguage);
        }

        // See-also: TranslateTextAsync(string, string, string, *, CancellationToken)
        // Member: TranslateTextAsync(IEnumerable<string>, string, string, *, CancellationToken)
        // See [TranslateTextAsync](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void TranslateHtml()
        {
            // Sample: TranslateHtml
            // Additional: TranslateHtml(string, string, string, *)
            AdvancedTranslationClient client = AdvancedTranslationClient.Create();
            TranslationResult result = client.TranslateHtml("<p><strong>It is raining.</strong></p>", LanguageCodes.French);
            Console.WriteLine($"Result: {result.TranslatedText}; detected language {result.DetectedSourceLanguage}");
            // End sample

            // We skip the <p> element in the check, because sometimes there is a space
            // separating it from the <strong> element, sometimes there isn't.
            // https://github.com/googleapis/google-cloud-dotnet/issues/5366
            Assert.Contains($"<strong>{RainingTranslation}</strong>", result.TranslatedText);
            Assert.Equal("en", result.DetectedSourceLanguage);
        }

        [Fact]
        public async Task TranslateHtmlAsync()
        {
            // Snippet: TranslateHtmlAsync(string, string, string, *, *)
            AdvancedTranslationClient client = await AdvancedTranslationClient.CreateAsync();
            TranslationResult result = await client.TranslateHtmlAsync("<p><strong>It is raining.</strong></p>", LanguageCodes.French);
            Console.WriteLine($"Result: {result.TranslatedText}; detected language {result.DetectedSourceLanguage}");
            // End snippet

            // We skip the <p> element in the check, because sometimes there is a space
            // separating it from the <strong> element, sometimes there isn't.
            // https://github.com/googleapis/google-cloud-dotnet/issues/5366
            Assert.Contains($"<strong>{RainingTranslation}</strong>", result.TranslatedText);
            Assert.Equal("en", result.DetectedSourceLanguage);
        }

        // See-also: TranslateHtmlAsync(string, string, string, *, CancellationToken)
        // Member: TranslateHtmlAsync(IEnumerable<string>, string, string, *, CancellationToken)
        // See [TranslateHtmlAsync](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void TranslateText_Multiple()
        {
            // Sample: TranslateTextMultiple
            // Additional: TranslateText(IEnumerable<string>, string, string, *)
            AdvancedTranslationClient client = AdvancedTranslationClient.Create();
            IList<TranslationResult> results = client.TranslateText(
                new[] { "It is raining.", "It is sunny." },
                LanguageCodes.French);
            foreach (TranslationResult result in results)
            {
                Console.WriteLine($"Result: {result.TranslatedText}; detected language {result.DetectedSourceLanguage}");
            }
            // End sample

            Assert.Equal(RainingTranslation, results[0].TranslatedText);
            Assert.Equal("en", results[0].DetectedSourceLanguage);
            Assert.Equal(SunnyTranslation, results[1].TranslatedText);
            Assert.Equal("en", results[1].DetectedSourceLanguage);
        }

        [Fact]
        public void TranslateHtml_Multiple()
        {
            // Sample: TranslateHtmlMultiple
            // Additional: TranslateHtml(IEnumerable<string>, string, string, *)
            AdvancedTranslationClient client = AdvancedTranslationClient.Create();
            IList<TranslationResult> results = client.TranslateHtml(
                new[] { "<p><strong>It is raining.</strong></p>", "<p><strong>It is sunny.</strong></p>" },
                LanguageCodes.French);
            foreach (TranslationResult result in results)
            {
                Console.WriteLine($"Result: {result.TranslatedText}; detected language {result.DetectedSourceLanguage}");
            }
            // End sample

            // We skip the <p> element in the check, because sometimes there is a space
            // separating it from the <strong> element, sometimes there isn't.
            // https://github.com/googleapis/google-cloud-dotnet/issues/5366
            Assert.Contains($"<strong>{RainingTranslation}</strong>", results[0].TranslatedText);
            Assert.Equal("en", results[0].DetectedSourceLanguage);
            Assert.Contains($"<strong>{SunnyTranslation}</strong>", results[1].TranslatedText);
            Assert.Equal("en", results[1].DetectedSourceLanguage);
        }

        [Fact]
        public void DetectLanguage()
        {
            // Sample: DetectLanguage
            // Additional: DetectLanguage(string)
            AdvancedTranslationClient client = AdvancedTranslationClient.Create();
            Detection result = client.DetectLanguage("It is raining.");
            Console.WriteLine($"Language: {result.Language}; confidence {result.Confidence}");
            // End sample

            Assert.Equal("en", result.Language);
            Assert.Equal("It is raining.", result.Text);
        }

        [Fact]
        public async Task DetectLanguageAsync()
        {
            // Snippet: DetectLanguageAsync(string, CancellationToken)
            AdvancedTranslationClient client = AdvancedTranslationClient.Create();
            Detection result = await client.DetectLanguageAsync("It is raining.");
            Console.WriteLine($"Language: {result.Language}; confidence {result.Confidence}");
            // End snippet

            Assert.Equal("en", result.Language);
            Assert.Equal("It is raining.", result.Text);
        }

        [Fact]
        public void DetectLanguages()
        {
            // Sample: DetectLanguages
            // Additional: DetectLanguages(IEnumerable<string>)
            AdvancedTranslationClient client = AdvancedTranslationClient.Create();
            IList<Detection> results = client.DetectLanguages(new[] { "It is raining.", RainingTranslation });
            foreach (var result in results)
            {
                Console.WriteLine($"Text: {result.Text}; language: {result.Language}; confidence {result.Confidence}");
            }
            // End sample

            Assert.Equal("en", results[0].Language);
            Assert.Equal("It is raining.", results[0].Text);
            Assert.Equal("fr", results[1].Language);
            Assert.Equal(RainingTranslation, results[1].Text);
        }

        [Fact]
        public async Task DetectLanguagesAsync()
        {
            // Sample: DetectLanguages
            // Additional: DetectLanguagesAsync(IEnumerable<string>, CancellationToken)
            AdvancedTranslationClient client = AdvancedTranslationClient.Create();
            IList<Detection> results = await client.DetectLanguagesAsync(new[] { "It is raining.", RainingTranslation });
            foreach (var result in results)
            {
                Console.WriteLine($"Text: {result.Text}; language: {result.Language}; confidence {result.Confidence}");
            }
            // End sample

            Assert.Equal("en", results[0].Language);
            Assert.Equal("It is raining.", results[0].Text);
            Assert.Equal("fr", results[1].Language);
            Assert.Equal(RainingTranslation, results[1].Text);
        }

        [Fact]
        public void ListLanguages()
        {
            // Snippet: ListLanguages(string, string)
            AdvancedTranslationClient client = AdvancedTranslationClient.Create();
            IList<Language> languages = client.ListLanguages(LanguageCodes.English);
            // Display just the first 10 languages for brevity
            foreach (Language language in languages.Take(10))
            {
                Console.WriteLine($"Language: {language.Name}; code {language.Code}");
            }
            // End snippet
        }

        [Fact]
        public async Task ListLanguagesAsync()
        {
            // Snippet: ListLanguagesAsync(string, string, CancellationToken)
            AdvancedTranslationClient client = await AdvancedTranslationClient.CreateAsync();
            IList<Language> languages = await client.ListLanguagesAsync(LanguageCodes.English);
            // Display just the first 10 languages for brevity
            foreach (Language language in languages.Take(10))
            {
                Console.WriteLine($"Language: {language.Name}; code {language.Code}");
            }
            // End snippet
        }
    }
}
