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

// This is a generated sample ("Request", "language_sentiment_gcs")

// sample-metadata
//   title: Analyzing Sentiment (GCS)
//   description: Analyzing Sentiment in text file stored in Cloud Storage
//   usage: dotnet run [--gcs_content_uri "gs://cloud-samples-data/language/sentiment-positive.txt"]

using CommandLine;

namespace Google.Cloud.Language.V1.Samples
{
    // [START language_sentiment_gcs]
    using Google.Cloud.Language.V1;
    using System;

    public class LanguageSentimentGcs
    {
        /// <summary>
        /// Analyzing Sentiment in text file stored in Cloud Storage
        /// </summary>
        /// <param name="gcsContentUri">Google Cloud Storage URI where the file content is located.
        /// e.g. gs://[Your Bucket]/[Path to File]
        /// </param>
        public static void SampleAnalyzeSentiment(string gcsContentUri)
        {
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // string gcsContentUri = "gs://cloud-samples-data/language/sentiment-positive.txt"
            AnalyzeSentimentRequest request = new AnalyzeSentimentRequest
            {
                Document = new Document
                {
                    // Google Cloud Storage URI where the file content is located.
                    // e.g. gs://[Your Bucket]/[Path to File]
                    GcsContentUri = "gs://cloud-samples-data/language/sentiment-positive.txt",
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

    // [END language_sentiment_gcs]

    public class LanguageSentimentGcsMain {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    LanguageSentimentGcs.SampleAnalyzeSentiment(opts.GcsContentUri));
        }

        public class Options
        {
            [Option("gcs_content_uri", Default = "gs://cloud-samples-data/language/sentiment-positive.txt")]
            public string GcsContentUri { get; set; }
        }
    }
}