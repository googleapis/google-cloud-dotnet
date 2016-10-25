// Copyright 2016 Google Inc. All Rights Reserved.
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

// Generated code. DO NOT EDIT!

using AnnotateTextRequest.Types;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Language.V1Beta1.Snippets
{
    public class GeneratedLanguageServiceClientSnippets
    {
        public async Task AnalyzeSentimentAsync()
        {
            // Snippet: AnalyzeSentimentAsync(Document,CallSettings)
            // Additional: AnalyzeSentimentAsync(Document,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            AnalyzeSentimentResponse response = await languageServiceClient.AnalyzeSentimentAsync(document);
            // End snippet
        }

        public void AnalyzeSentiment()
        {
            // Snippet: AnalyzeSentiment(Document,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            AnalyzeSentimentResponse response = languageServiceClient.AnalyzeSentiment(document);
            // End snippet
        }

        public async Task AnalyzeEntitiesAsync()
        {
            // Snippet: AnalyzeEntitiesAsync(Document,EncodingType,CallSettings)
            // Additional: AnalyzeEntitiesAsync(Document,EncodingType,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnalyzeEntitiesResponse response = await languageServiceClient.AnalyzeEntitiesAsync(document, encodingType);
            // End snippet
        }

        public void AnalyzeEntities()
        {
            // Snippet: AnalyzeEntities(Document,EncodingType,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnalyzeEntitiesResponse response = languageServiceClient.AnalyzeEntities(document, encodingType);
            // End snippet
        }

        public async Task AnnotateTextAsync()
        {
            // Snippet: AnnotateTextAsync(Document,Features,EncodingType,CallSettings)
            // Additional: AnnotateTextAsync(Document,Features,EncodingType,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            Features features = new Features();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnnotateTextResponse response = await languageServiceClient.AnnotateTextAsync(document, features, encodingType);
            // End snippet
        }

        public void AnnotateText()
        {
            // Snippet: AnnotateText(Document,Features,EncodingType,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            Features features = new Features();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnnotateTextResponse response = languageServiceClient.AnnotateText(document, features, encodingType);
            // End snippet
        }

    }
}
