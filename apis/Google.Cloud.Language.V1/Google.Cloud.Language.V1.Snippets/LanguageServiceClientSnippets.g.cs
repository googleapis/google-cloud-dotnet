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

namespace Google.Cloud.Language.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Language.V1;
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

    /// <summary>Generated snippets</summary>
    public class GeneratedLanguageServiceClientSnippets
    {
        /// <summary>Snippet for AnalyzeSentimentAsync</summary>
        public async Task AnalyzeSentimentAsync1()
        {
            // Snippet: AnalyzeSentimentAsync(Document,EncodingType?,CallSettings)
            // Additional: AnalyzeSentimentAsync(Document,EncodingType?,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnalyzeSentimentResponse response = await languageServiceClient.AnalyzeSentimentAsync(document, encodingType);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeSentiment</summary>
        public void AnalyzeSentiment1()
        {
            // Snippet: AnalyzeSentiment(Document,EncodingType?,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnalyzeSentimentResponse response = languageServiceClient.AnalyzeSentiment(document, encodingType);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeSentimentAsync</summary>
        public async Task AnalyzeSentimentAsync2()
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

        /// <summary>Snippet for AnalyzeSentiment</summary>
        public void AnalyzeSentiment2()
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

        /// <summary>Snippet for AnalyzeSentimentAsync</summary>
        public async Task AnalyzeSentimentAsync_RequestObject()
        {
            // Snippet: AnalyzeSentimentAsync(AnalyzeSentimentRequest,CallSettings)
            // Additional: AnalyzeSentimentAsync(AnalyzeSentimentRequest,CancellationToken)
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

        /// <summary>Snippet for AnalyzeSentiment</summary>
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

        /// <summary>Snippet for AnalyzeEntitiesAsync</summary>
        public async Task AnalyzeEntitiesAsync1()
        {
            // Snippet: AnalyzeEntitiesAsync(Document,EncodingType?,CallSettings)
            // Additional: AnalyzeEntitiesAsync(Document,EncodingType?,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnalyzeEntitiesResponse response = await languageServiceClient.AnalyzeEntitiesAsync(document, encodingType);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeEntities</summary>
        public void AnalyzeEntities1()
        {
            // Snippet: AnalyzeEntities(Document,EncodingType?,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnalyzeEntitiesResponse response = languageServiceClient.AnalyzeEntities(document, encodingType);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeEntitiesAsync</summary>
        public async Task AnalyzeEntitiesAsync2()
        {
            // Snippet: AnalyzeEntitiesAsync(Document,CallSettings)
            // Additional: AnalyzeEntitiesAsync(Document,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            AnalyzeEntitiesResponse response = await languageServiceClient.AnalyzeEntitiesAsync(document);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeEntities</summary>
        public void AnalyzeEntities2()
        {
            // Snippet: AnalyzeEntities(Document,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            AnalyzeEntitiesResponse response = languageServiceClient.AnalyzeEntities(document);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeEntitiesAsync</summary>
        public async Task AnalyzeEntitiesAsync_RequestObject()
        {
            // Snippet: AnalyzeEntitiesAsync(AnalyzeEntitiesRequest,CallSettings)
            // Additional: AnalyzeEntitiesAsync(AnalyzeEntitiesRequest,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeEntitiesRequest request = new AnalyzeEntitiesRequest
            {
                Document = new Document(),
            };
            // Make the request
            AnalyzeEntitiesResponse response = await languageServiceClient.AnalyzeEntitiesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeEntities</summary>
        public void AnalyzeEntities_RequestObject()
        {
            // Snippet: AnalyzeEntities(AnalyzeEntitiesRequest,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            AnalyzeEntitiesRequest request = new AnalyzeEntitiesRequest
            {
                Document = new Document(),
            };
            // Make the request
            AnalyzeEntitiesResponse response = languageServiceClient.AnalyzeEntities(request);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeEntitySentimentAsync</summary>
        public async Task AnalyzeEntitySentimentAsync1()
        {
            // Snippet: AnalyzeEntitySentimentAsync(Document,EncodingType?,CallSettings)
            // Additional: AnalyzeEntitySentimentAsync(Document,EncodingType?,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnalyzeEntitySentimentResponse response = await languageServiceClient.AnalyzeEntitySentimentAsync(document, encodingType);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeEntitySentiment</summary>
        public void AnalyzeEntitySentiment1()
        {
            // Snippet: AnalyzeEntitySentiment(Document,EncodingType?,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnalyzeEntitySentimentResponse response = languageServiceClient.AnalyzeEntitySentiment(document, encodingType);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeEntitySentimentAsync</summary>
        public async Task AnalyzeEntitySentimentAsync2()
        {
            // Snippet: AnalyzeEntitySentimentAsync(Document,CallSettings)
            // Additional: AnalyzeEntitySentimentAsync(Document,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            AnalyzeEntitySentimentResponse response = await languageServiceClient.AnalyzeEntitySentimentAsync(document);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeEntitySentiment</summary>
        public void AnalyzeEntitySentiment2()
        {
            // Snippet: AnalyzeEntitySentiment(Document,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            AnalyzeEntitySentimentResponse response = languageServiceClient.AnalyzeEntitySentiment(document);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeEntitySentimentAsync</summary>
        public async Task AnalyzeEntitySentimentAsync_RequestObject()
        {
            // Snippet: AnalyzeEntitySentimentAsync(AnalyzeEntitySentimentRequest,CallSettings)
            // Additional: AnalyzeEntitySentimentAsync(AnalyzeEntitySentimentRequest,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeEntitySentimentRequest request = new AnalyzeEntitySentimentRequest
            {
                Document = new Document(),
            };
            // Make the request
            AnalyzeEntitySentimentResponse response = await languageServiceClient.AnalyzeEntitySentimentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeEntitySentiment</summary>
        public void AnalyzeEntitySentiment_RequestObject()
        {
            // Snippet: AnalyzeEntitySentiment(AnalyzeEntitySentimentRequest,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            AnalyzeEntitySentimentRequest request = new AnalyzeEntitySentimentRequest
            {
                Document = new Document(),
            };
            // Make the request
            AnalyzeEntitySentimentResponse response = languageServiceClient.AnalyzeEntitySentiment(request);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeSyntaxAsync</summary>
        public async Task AnalyzeSyntaxAsync1()
        {
            // Snippet: AnalyzeSyntaxAsync(Document,EncodingType?,CallSettings)
            // Additional: AnalyzeSyntaxAsync(Document,EncodingType?,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnalyzeSyntaxResponse response = await languageServiceClient.AnalyzeSyntaxAsync(document, encodingType);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeSyntax</summary>
        public void AnalyzeSyntax1()
        {
            // Snippet: AnalyzeSyntax(Document,EncodingType?,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnalyzeSyntaxResponse response = languageServiceClient.AnalyzeSyntax(document, encodingType);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeSyntaxAsync</summary>
        public async Task AnalyzeSyntaxAsync2()
        {
            // Snippet: AnalyzeSyntaxAsync(Document,CallSettings)
            // Additional: AnalyzeSyntaxAsync(Document,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            AnalyzeSyntaxResponse response = await languageServiceClient.AnalyzeSyntaxAsync(document);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeSyntax</summary>
        public void AnalyzeSyntax2()
        {
            // Snippet: AnalyzeSyntax(Document,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            AnalyzeSyntaxResponse response = languageServiceClient.AnalyzeSyntax(document);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeSyntaxAsync</summary>
        public async Task AnalyzeSyntaxAsync_RequestObject()
        {
            // Snippet: AnalyzeSyntaxAsync(AnalyzeSyntaxRequest,CallSettings)
            // Additional: AnalyzeSyntaxAsync(AnalyzeSyntaxRequest,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeSyntaxRequest request = new AnalyzeSyntaxRequest
            {
                Document = new Document(),
            };
            // Make the request
            AnalyzeSyntaxResponse response = await languageServiceClient.AnalyzeSyntaxAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeSyntax</summary>
        public void AnalyzeSyntax_RequestObject()
        {
            // Snippet: AnalyzeSyntax(AnalyzeSyntaxRequest,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            AnalyzeSyntaxRequest request = new AnalyzeSyntaxRequest
            {
                Document = new Document(),
            };
            // Make the request
            AnalyzeSyntaxResponse response = languageServiceClient.AnalyzeSyntax(request);
            // End snippet
        }

        /// <summary>Snippet for ClassifyTextAsync</summary>
        public async Task ClassifyTextAsync()
        {
            // Snippet: ClassifyTextAsync(Document,CallSettings)
            // Additional: ClassifyTextAsync(Document,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            ClassifyTextResponse response = await languageServiceClient.ClassifyTextAsync(document);
            // End snippet
        }

        /// <summary>Snippet for ClassifyText</summary>
        public void ClassifyText()
        {
            // Snippet: ClassifyText(Document,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            ClassifyTextResponse response = languageServiceClient.ClassifyText(document);
            // End snippet
        }

        /// <summary>Snippet for ClassifyTextAsync</summary>
        public async Task ClassifyTextAsync_RequestObject()
        {
            // Snippet: ClassifyTextAsync(ClassifyTextRequest,CallSettings)
            // Additional: ClassifyTextAsync(ClassifyTextRequest,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClassifyTextRequest request = new ClassifyTextRequest
            {
                Document = new Document(),
            };
            // Make the request
            ClassifyTextResponse response = await languageServiceClient.ClassifyTextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ClassifyText</summary>
        public void ClassifyText_RequestObject()
        {
            // Snippet: ClassifyText(ClassifyTextRequest,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            ClassifyTextRequest request = new ClassifyTextRequest
            {
                Document = new Document(),
            };
            // Make the request
            ClassifyTextResponse response = languageServiceClient.ClassifyText(request);
            // End snippet
        }

        /// <summary>Snippet for AnnotateTextAsync</summary>
        public async Task AnnotateTextAsync1()
        {
            // Snippet: AnnotateTextAsync(Document,AnnotateTextRequest.Types.Features,EncodingType?,CallSettings)
            // Additional: AnnotateTextAsync(Document,AnnotateTextRequest.Types.Features,EncodingType?,CancellationToken)
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

        /// <summary>Snippet for AnnotateText</summary>
        public void AnnotateText1()
        {
            // Snippet: AnnotateText(Document,AnnotateTextRequest.Types.Features,EncodingType?,CallSettings)
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

        /// <summary>Snippet for AnnotateTextAsync</summary>
        public async Task AnnotateTextAsync2()
        {
            // Snippet: AnnotateTextAsync(Document,AnnotateTextRequest.Types.Features,CallSettings)
            // Additional: AnnotateTextAsync(Document,AnnotateTextRequest.Types.Features,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            AnnotateTextRequest.Types.Features features = new AnnotateTextRequest.Types.Features();
            // Make the request
            AnnotateTextResponse response = await languageServiceClient.AnnotateTextAsync(document, features);
            // End snippet
        }

        /// <summary>Snippet for AnnotateText</summary>
        public void AnnotateText2()
        {
            // Snippet: AnnotateText(Document,AnnotateTextRequest.Types.Features,CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            AnnotateTextRequest.Types.Features features = new AnnotateTextRequest.Types.Features();
            // Make the request
            AnnotateTextResponse response = languageServiceClient.AnnotateText(document, features);
            // End snippet
        }

        /// <summary>Snippet for AnnotateTextAsync</summary>
        public async Task AnnotateTextAsync_RequestObject()
        {
            // Snippet: AnnotateTextAsync(AnnotateTextRequest,CallSettings)
            // Additional: AnnotateTextAsync(AnnotateTextRequest,CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnnotateTextRequest request = new AnnotateTextRequest
            {
                Document = new Document(),
                Features = new AnnotateTextRequest.Types.Features(),
            };
            // Make the request
            AnnotateTextResponse response = await languageServiceClient.AnnotateTextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AnnotateText</summary>
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
            };
            // Make the request
            AnnotateTextResponse response = languageServiceClient.AnnotateText(request);
            // End snippet
        }

    }
}
