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

// Generated code. DO NOT EDIT!

// This is a generated sample ("Request", "language_sentiment_text")

// sample-metadata
//   title: Analyzing Sentiment
//   description: Analyzing Sentiment in a String
//   usage: dotnet run [--text_content "I am so happy and joyful."]

using CommandLine;

namespace Google.Cloud.Language.V1.Samples
{
    // [START language_sentiment_text]
    using Google.Cloud.Language.V1;
    using System;

    public class LanguageSentimentText
    {
        /// <summary>
        /// Analyzing Sentiment in a String
        /// </summary>
        /// <param name="textContent">The text content to analyze</param>
        public static void SampleAnalyzeSentiment(string textContent)
        {
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // string textContent = "I am so happy and joyful."
            AnalyzeSentimentRequest request = new AnalyzeSentimentRequest
            {
                Document = new Document
                {
                    // The text content to analyze
                    Content = "I am so happy and joyful.",
                    // Available types: PLAIN_TEXT, HTML
                    Type = Document.Types.Type.PlainText,
                    // Optional. If not specified, the language is automatically detected.
                    // For list of supported languages:
                    // https://cloud.google.com/natural-language/docs/languages
                    Language = "en",
                },
                EncodingType = EncodingType.Utf8,
            };
            AnalyzeSentimentResponse response = languageServiceClient.AnalyzeSentiment(request);
            // Get overall sentiment of the input document
            Console.WriteLine($"Document sentiment score: {response.DocumentSentiment.Score}");
            Console.WriteLine($"Document sentiment magnitude: {response.DocumentSentiment.Magnitude}");
            // Get sentiment for all sentences in the document
            foreach (Sentence sentence in response.Sentences) {
                Console.WriteLine($"Sentence text: {sentence.Text.Content}");
                Console.WriteLine($"Sentence sentiment score: {sentence.Sentiment.Score}");
                Console.WriteLine($"Sentence sentiment magnitude: {sentence.Sentiment.Magnitude}");
            }
            // Get the language of the text, which will be the same as
            // the language specified in the request or, if not specified,
            // the automatically-detected language.
            Console.WriteLine($"Language of the text: {response.Language}");
        }
    }

    // [END language_sentiment_text]

    public class LanguageSentimentTextMain {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    LanguageSentimentText.SampleAnalyzeSentiment(opts.TextContent));
        }

        public class Options
        {
            [Option("text_content", Default = "I am so happy and joyful.")]
            public string TextContent { get; set; }
        }
    }
}