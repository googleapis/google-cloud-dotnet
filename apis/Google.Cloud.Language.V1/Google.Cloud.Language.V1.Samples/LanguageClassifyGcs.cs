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

// This is a generated sample ("Request", "language_classify_gcs")

// sample-metadata
//   title: Classify Content (GCS)
//   description: Classifying Content in text file stored in Cloud Storage
//   usage: dotnet run [--gcs_content_uri "gs://cloud-samples-data/language/classify-entertainment.txt"]

using CommandLine;

namespace Google.Cloud.Language.V1.Samples
{
    // [START language_classify_gcs]
    using Google.Cloud.Language.V1;
    using System;

    public class LanguageClassifyGcs
    {
        /// <summary>
        /// Classifying Content in text file stored in Cloud Storage
        /// </summary>
        /// <param name="gcsContentUri">Google Cloud Storage URI where the file content is located.
        /// e.g. gs://[Your Bucket]/[Path to File]
        /// The text file must include at least 20 words.
        /// </param>
        public static void SampleClassifyText(string gcsContentUri)
        {
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // string gcsContentUri = "gs://cloud-samples-data/language/classify-entertainment.txt"
            ClassifyTextRequest request = new ClassifyTextRequest
            {
                Document = new Document
                {
                    // Google Cloud Storage URI where the file content is located.
                    // e.g. gs://[Your Bucket]/[Path to File]
                    // The text file must include at least 20 words.
                    GcsContentUri = "gs://cloud-samples-data/language/classify-entertainment.txt",
                    // Available types: PLAIN_TEXT, HTML
                    Type = Document.Types.Type.PlainText,
                    // Optional. If not specified, the language is automatically detected.
                    // For list of supported languages:
                    // https://cloud.google.com/natural-language/docs/languages
                    Language = "en",
                },
            };
            ClassifyTextResponse response = languageServiceClient.ClassifyText(request);
            // Loop through classified categories returned from the API
            foreach (ClassificationCategory category in response.Categories) {
                // Get the name of the category representing the document.
                // See the predefined taxonomy of categories:
                // https://cloud.google.com/natural-language/docs/categories
                Console.WriteLine($"Category name: {category.Name}");
                // Get the confidence. Number representing how certain the classifier
                // is that this category represents the provided text.
                Console.WriteLine($"Confidence: {category.Confidence}");
            }
        }
    }

    // [END language_classify_gcs]

    public class LanguageClassifyGcsMain {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    LanguageClassifyGcs.SampleClassifyText(opts.GcsContentUri));
        }

        public class Options
        {
            [Option("gcs_content_uri", Default = "gs://cloud-samples-data/language/classify-entertainment.txt")]
            public string GcsContentUri { get; set; }
        }
    }
}