// Copyright 2017, Google Inc. All rights reserved.
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Language.V1;
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

namespace Google.Cloud.Language.V1.Snippets
{
    public class GeneratedLanguageServiceClientSnippets
    {
        public async Task AnalyzeSentimentAsync()
        {
            // Snippet: AnalyzeSentimentAsync(Document,CallSettings)
            // Additional: AnalyzeSentimentAsync(Document,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
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

        public async Task AnalyzeSentimentAsync_RequestObject()
        {
            // Snippet: AnalyzeSentimentAsync(AnalyzeSentimentRequest,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeSentimentRequest request = new AnalyzeSentimentRequest
            {
                Document = new Document(),
            };
            // Make the request
            AnalyzeSentimentResponse response = await languageServiceClient.AnalyzeSentimentAsync(request);
            // End snippet
        }

        public void AnalyzeSentiment_RequestObject()
        {
            // Snippet: AnalyzeSentiment(AnalyzeSentimentRequest,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            AnalyzeSentimentRequest request = new AnalyzeSentimentRequest
            {
                Document = new Document(),
            };
            // Make the request
            AnalyzeSentimentResponse response = languageServiceClient.AnalyzeSentiment(request);
            // End snippet
        }

        public async Task AnalyzeEntitiesAsync()
        {
            // Snippet: AnalyzeEntitiesAsync(Document,EncodingType,CallSettings)
            // Additional: AnalyzeEntitiesAsync(Document,EncodingType,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
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

        public async Task AnalyzeEntitiesAsync_RequestObject()
        {
            // Snippet: AnalyzeEntitiesAsync(AnalyzeEntitiesRequest,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeEntitiesRequest request = new AnalyzeEntitiesRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            // Make the request
            AnalyzeEntitiesResponse response = await languageServiceClient.AnalyzeEntitiesAsync(request);
            // End snippet
        }

        public void AnalyzeEntities_RequestObject()
        {
            // Snippet: AnalyzeEntities(AnalyzeEntitiesRequest,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            AnalyzeEntitiesRequest request = new AnalyzeEntitiesRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            // Make the request
            AnalyzeEntitiesResponse response = languageServiceClient.AnalyzeEntities(request);
            // End snippet
        }

        public async Task AnalyzeEntitySentimentAsync()
        {
            // Snippet: AnalyzeEntitySentimentAsync(Document,EncodingType,CallSettings)
            // Additional: AnalyzeEntitySentimentAsync(Document,EncodingType,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnalyzeEntitySentimentResponse response = await languageServiceClient.AnalyzeEntitySentimentAsync(document, encodingType);
            // End snippet
        }

        public void AnalyzeEntitySentiment()
        {
            // Snippet: AnalyzeEntitySentiment(Document,EncodingType,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnalyzeEntitySentimentResponse response = languageServiceClient.AnalyzeEntitySentiment(document, encodingType);
            // End snippet
        }

        public async Task AnalyzeEntitySentimentAsync_RequestObject()
        {
            // Snippet: AnalyzeEntitySentimentAsync(AnalyzeEntitySentimentRequest,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeEntitySentimentRequest request = new AnalyzeEntitySentimentRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            // Make the request
            AnalyzeEntitySentimentResponse response = await languageServiceClient.AnalyzeEntitySentimentAsync(request);
            // End snippet
        }

        public void AnalyzeEntitySentiment_RequestObject()
        {
            // Snippet: AnalyzeEntitySentiment(AnalyzeEntitySentimentRequest,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            AnalyzeEntitySentimentRequest request = new AnalyzeEntitySentimentRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            // Make the request
            AnalyzeEntitySentimentResponse response = languageServiceClient.AnalyzeEntitySentiment(request);
            // End snippet
        }

        public async Task AnalyzeSyntaxAsync()
        {
            // Snippet: AnalyzeSyntaxAsync(Document,EncodingType,CallSettings)
            // Additional: AnalyzeSyntaxAsync(Document,EncodingType,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnalyzeSyntaxResponse response = await languageServiceClient.AnalyzeSyntaxAsync(document, encodingType);
            // End snippet
        }

        public void AnalyzeSyntax()
        {
            // Snippet: AnalyzeSyntax(Document,EncodingType,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnalyzeSyntaxResponse response = languageServiceClient.AnalyzeSyntax(document, encodingType);
            // End snippet
        }

        public async Task AnalyzeSyntaxAsync_RequestObject()
        {
            // Snippet: AnalyzeSyntaxAsync(AnalyzeSyntaxRequest,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeSyntaxRequest request = new AnalyzeSyntaxRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            // Make the request
            AnalyzeSyntaxResponse response = await languageServiceClient.AnalyzeSyntaxAsync(request);
            // End snippet
        }

        public void AnalyzeSyntax_RequestObject()
        {
            // Snippet: AnalyzeSyntax(AnalyzeSyntaxRequest,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            AnalyzeSyntaxRequest request = new AnalyzeSyntaxRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            // Make the request
            AnalyzeSyntaxResponse response = languageServiceClient.AnalyzeSyntax(request);
            // End snippet
        }

        public async Task AnnotateTextAsync()
        {
            // Snippet: AnnotateTextAsync(Document,AnnotateTextRequest.Types.Features,EncodingType,CallSettings)
            // Additional: AnnotateTextAsync(Document,AnnotateTextRequest.Types.Features,EncodingType,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            AnnotateTextRequest.Types.Features features = new AnnotateTextRequest.Types.Features();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnnotateTextResponse response = await languageServiceClient.AnnotateTextAsync(document, features, encodingType);
            // End snippet
        }

        public void AnnotateText()
        {
            // Snippet: AnnotateText(Document,AnnotateTextRequest.Types.Features,EncodingType,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            AnnotateTextRequest.Types.Features features = new AnnotateTextRequest.Types.Features();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnnotateTextResponse response = languageServiceClient.AnnotateText(document, features, encodingType);
            // End snippet
        }

        public async Task AnnotateTextAsync_RequestObject()
        {
            // Snippet: AnnotateTextAsync(AnnotateTextRequest,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnnotateTextRequest request = new AnnotateTextRequest
            {
                Document = new Document(),
                Features = new AnnotateTextRequest.Types.Features(),
                EncodingType = EncodingType.None,
            };
            // Make the request
            AnnotateTextResponse response = await languageServiceClient.AnnotateTextAsync(request);
            // End snippet
        }

        public void AnnotateText_RequestObject()
        {
            // Snippet: AnnotateText(AnnotateTextRequest,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            AnnotateTextRequest request = new AnnotateTextRequest
            {
                Document = new Document(),
                Features = new AnnotateTextRequest.Types.Features(),
                EncodingType = EncodingType.None,
            };
            // Make the request
            AnnotateTextResponse response = languageServiceClient.AnnotateText(request);
            // End snippet
        }

    }
}
