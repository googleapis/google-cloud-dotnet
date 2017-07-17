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

using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Google.Cloud.Translation.V2.Snippets
{
    public class TranslationClientSnippets
    {
        [Fact]
        public void TranslateTextBaseDefaultModel()
        {
            // Sample: TranslateTextBaseDefaultModel
            TranslationClient client = TranslationClient.Create(model: TranslationModel.Base);
            TranslationResult result = client.TranslateText("It is raining.", LanguageCodes.French);
            Console.WriteLine($"Result: {result.TranslatedText}; detected language {result.DetectedSourceLanguage}");
            // End sample

            Assert.Equal("Il pleut.", result.TranslatedText);
            Assert.Equal("en", result.DetectedSourceLanguage);
        }

        [Fact]
        public void TranslateTextBaseOverrideModel()
        {
            // Sample: TranslateTextBaseOverrideModel
            TranslationClient client = TranslationClient.Create();
            TranslationResult result = client.TranslateText("It is raining.", LanguageCodes.French,
                model: TranslationModel.Base);
            Console.WriteLine($"Result: {result.TranslatedText}; detected language {result.DetectedSourceLanguage}");
            // End sample

            Assert.Equal("Il pleut.", result.TranslatedText);
            Assert.Equal("en", result.DetectedSourceLanguage);
        }

        [Fact]
        public void TranslateText()
        {
            // Sample: TranslateText
            // Additional: TranslateText(string, string, string, *)
            TranslationClient client = TranslationClient.Create();
            TranslationResult result = client.TranslateText("It is raining.", LanguageCodes.French);
            Console.WriteLine($"Result: {result.TranslatedText}; detected language {result.DetectedSourceLanguage}");
            // End sample

            Assert.Equal("Il pleut.", result.TranslatedText);
            Assert.Equal("en", result.DetectedSourceLanguage);
        }

        [Fact]
        public void TranslateHtml()
        {
            // Sample: TranslateHtml
            // Additional: TranslateHtml(string, string, string, *)
            TranslationClient client = TranslationClient.Create();
            TranslationResult result = client.TranslateHtml("<p><strong>It is raining.</strong></p>", LanguageCodes.French);
            Console.WriteLine($"Result: {result.TranslatedText}; detected language {result.DetectedSourceLanguage}");
            // End sample

            Assert.Equal("<p> <strong>Il pleut.</strong> </p>", result.TranslatedText);
            Assert.Equal("en", result.DetectedSourceLanguage);
        }

        [Fact]
        public void TranslateText_Multiple()
        {
            // Sample: TranslateTextMultiple
            // Additional: TranslateText(IEnumerable<string>, string, string, *)
            TranslationClient client = TranslationClient.Create();
            IList<TranslationResult> results = client.TranslateText(
                new[] { "It is raining.", "It is sunny." },
                LanguageCodes.French);
            foreach (TranslationResult result in results)
            {
                Console.WriteLine($"Result: {result.TranslatedText}; detected language {result.DetectedSourceLanguage}");
            }
            // End sample

            Assert.Equal("Il pleut.", results[0].TranslatedText);
            Assert.Equal("en", results[0].DetectedSourceLanguage);
            Assert.Equal("C'est ensoleillé.", results[1].TranslatedText);
            Assert.Equal("en", results[1].DetectedSourceLanguage);
        }

        [Fact]
        public void TranslateHtml_Multiple()
        {
            // Sample: TranslateHtmlMultiple
            // Additional: TranslateHtml(IEnumerable<string>, string, string, *)
            TranslationClient client = TranslationClient.Create();
            IList<TranslationResult> results = client.TranslateHtml(
                new[] { "<p><strong>It is raining.</strong></p>", "<p><strong>It is sunny.</strong></p>" },
                LanguageCodes.French);
            foreach (TranslationResult result in results)
            {
                Console.WriteLine($"Result: {result.TranslatedText}; detected language {result.DetectedSourceLanguage}");
            }
            // End sample

            Assert.Equal("<p> <strong>Il pleut.</strong> </p>", results[0].TranslatedText);
            Assert.Equal("en", results[0].DetectedSourceLanguage);
            Assert.Equal("<p> <strong>C&#39;est ensoleillé.</strong> </p>", results[1].TranslatedText);
            Assert.Equal("en", results[1].DetectedSourceLanguage);
        }

        // See-also: TranslateText(string, string, string, *)
        // Member: TranslateTextAsync(string, string, string, *, CancellationToken)
        // Member: TranslateTextAsync(IEnumerable<string>, string, string, *, CancellationToken)
        // See [TranslateText](ref) for a synchronous example.
        // End see-also

        // See-also: TranslateHtml(string, string, string, *)
        // Member: TranslateHtmlAsync(string, string, string, *, CancellationToken)
        // Member: TranslateHtmlAsync(IEnumerable<string>, string, string, *, CancellationToken)
        // See [TranslateHtml](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void DetectLanguage()
        {
            // Sample: DetectLanguage
            // Additional: DetectLanguage(string)
            TranslationClient client = TranslationClient.Create();
            Detection result = client.DetectLanguage("It is raining.");
            Console.WriteLine($"Language: {result.Language}; confidence {result.Confidence}");
            // End sample

            Assert.Equal("en", result.Language);
            Assert.Equal("It is raining.", result.Text);
        }

        // See-also: DetectLanguage(string)
        // Member: DetectLanguageAsync(string, CancellationToken)
        // See [DetectLanguage](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void DetectLanguages()
        {
            // Sample: DetectLanguages
            // Additional: DetectLanguages(IEnumerable<string>)
            TranslationClient client = TranslationClient.Create();
            IList<Detection> results = client.DetectLanguages(new[] { "It is raining.", "Il pleut." });
            foreach (var result in results)
            {
                Console.WriteLine($"Text: {result.Text}; language: {result.Language}; confidence {result.Confidence}");
            }
            // End sample

            Assert.Equal("en", results[0].Language);
            Assert.Equal("It is raining.", results[0].Text);
            Assert.Equal("fr", results[1].Language);
            Assert.Equal("Il pleut.", results[1].Text);
        }

        // See-also: DetectLanguages(IEnumerable<string>)
        // Member: DetectLanguagesAsync(IEnumerable<string>, CancellationToken)
        // See [DetectLanguages](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void ListLanguages()
        {
            // Snippet: ListLanguages(string, TranslationModel?)
            TranslationClient client = TranslationClient.Create();
            IList<Language> languages = client.ListLanguages(LanguageCodes.English);
            // Display just the first 10 languages for brevity
            foreach (Language language in languages.Take(10))
            {
                Console.WriteLine($"Language: {language.Name}; code {language.Code}");
            }
            // End snippet
        }

        // See-also: ListLanguages(string, TranslationModel?)
        // Member: ListLanguagesAsync(string, TranslationModel?, CancellationToken)
        // See [ListLanguages](ref) for a synchronous example.
        // End see-also
    }
}
