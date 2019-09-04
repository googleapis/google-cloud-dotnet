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

// This is a generated sample ("Request", "language_entity_sentiment_gcs")

// sample-metadata
//   title: Analyzing Entity Sentiment (GCS)
//   description: Analyzing Entity Sentiment in text file stored in Cloud Storage
//   usage: dotnet run [--gcs_content_uri "gs://cloud-samples-data/language/entity-sentiment.txt"]

using CommandLine;

namespace Google.Cloud.Language.V1.Samples
{
    // [START language_entity_sentiment_gcs]
    using Google.Cloud.Language.V1;
    using System;
    using System.Collections.Generic;

    public class LanguageEntitySentimentGcs
    {
        /// <summary>
        /// Analyzing Entity Sentiment in text file stored in Cloud Storage
        /// </summary>
        /// <param name="gcsContentUri">Google Cloud Storage URI where the file content is located.
        /// e.g. gs://[Your Bucket]/[Path to File]
        /// </param>
        public static void SampleAnalyzeEntitySentiment(string gcsContentUri)
        {
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // string gcsContentUri = "gs://cloud-samples-data/language/entity-sentiment.txt"
            AnalyzeEntitySentimentRequest request = new AnalyzeEntitySentimentRequest
            {
                Document = new Document
                {
                    // Google Cloud Storage URI where the file content is located.
                    // e.g. gs://[Your Bucket]/[Path to File]
                    GcsContentUri = "gs://cloud-samples-data/language/entity-sentiment.txt",
                    // Available types: PLAIN_TEXT, HTML
                    Type = Document.Types.Type.PlainText,
                    // Optional. If not specified, the language is automatically detected.
                    // For list of supported languages:
                    // https://cloud.google.com/natural-language/docs/languages
                    Language = "en",
                },
                EncodingType = EncodingType.Utf8,
            };
            AnalyzeEntitySentimentResponse response = languageServiceClient.AnalyzeEntitySentiment(request);
            // Loop through entitites returned from the API
            foreach (Entity entity in response.Entities) {
                Console.WriteLine($"Representative name for the entity: {entity.Name}");
                // Get entity type, e.g. PERSON, LOCATION, ADDRESS, NUMBER, et al
                Console.WriteLine($"Entity type: {entity.Type}");
                // Get the salience score associated with the entity in the [0, 1.0] range
                Console.WriteLine($"Salience score: {entity.Salience}");
                // Get the aggregate sentiment expressed for this entity in the provided document.
                Sentiment sentiment = entity.Sentiment;
                Console.WriteLine($"Entity sentiment score: {sentiment.Score}");
                Console.WriteLine($"Entity sentiment magnitude: {sentiment.Magnitude}");
                // Loop over the metadata associated with entity. For many known entities,
                // the metadata is a Wikipedia URL (wikipedia_url) and Knowledge Graph MID (mid).
                // Some entity types may have additional metadata, e.g. ADDRESS entities
                // may have metadata for the address street_name, postal_code, et al.
                foreach (KeyValuePair<string, string> entry in entity.Metadata) {
                    string metadataName = entry.Key;
                    string metadataValue = entry.Value;
                    Console.WriteLine($"{metadataName} = {metadataValue}");
                }
                // Loop over the mentions of this entity in the input document.
                // The API currently supports proper noun mentions.
                foreach (EntityMention mention in entity.Mentions) {
                    Console.WriteLine($"Mention text: {mention.Text.Content}");
                    // Get the mention type, e.g. PROPER for proper noun
                    Console.WriteLine($"Mention type: {mention.Type}");
                }
            }
            // Get the language of the text, which will be the same as
            // the language specified in the request or, if not specified,
            // the automatically-detected language.
            Console.WriteLine($"Language of the text: {response.Language}");
        }
    }

    // [END language_entity_sentiment_gcs]

    public class LanguageEntitySentimentGcsMain {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    LanguageEntitySentimentGcs.SampleAnalyzeEntitySentiment(opts.GcsContentUri));
        }

        public class Options
        {
            [Option("gcs_content_uri", Default = "gs://cloud-samples-data/language/entity-sentiment.txt")]
            public string GcsContentUri { get; set; }
        }
    }
}