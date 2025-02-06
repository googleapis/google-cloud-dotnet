// Copyright 2025 Google LLC
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

namespace GoogleCSharpSnippets
{
    using Google.Cloud.Language.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLanguageServiceClientSnippets
    {
        /// <summary>Snippet for AnalyzeSentiment</summary>
        public void AnalyzeSentimentRequestObject()
        {
            // Snippet: AnalyzeSentiment(AnalyzeSentimentRequest, CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            AnalyzeSentimentRequest request = new AnalyzeSentimentRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            // Make the request
            AnalyzeSentimentResponse response = languageServiceClient.AnalyzeSentiment(request);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeSentimentAsync</summary>
        public async Task AnalyzeSentimentRequestObjectAsync()
        {
            // Snippet: AnalyzeSentimentAsync(AnalyzeSentimentRequest, CallSettings)
            // Additional: AnalyzeSentimentAsync(AnalyzeSentimentRequest, CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeSentimentRequest request = new AnalyzeSentimentRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            // Make the request
            AnalyzeSentimentResponse response = await languageServiceClient.AnalyzeSentimentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeSentiment</summary>
        public void AnalyzeSentiment1()
        {
            // Snippet: AnalyzeSentiment(Document, EncodingType, CallSettings)
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
        public async Task AnalyzeSentiment1Async()
        {
            // Snippet: AnalyzeSentimentAsync(Document, EncodingType, CallSettings)
            // Additional: AnalyzeSentimentAsync(Document, EncodingType, CancellationToken)
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
        public void AnalyzeSentiment2()
        {
            // Snippet: AnalyzeSentiment(Document, CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            AnalyzeSentimentResponse response = languageServiceClient.AnalyzeSentiment(document);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeSentimentAsync</summary>
        public async Task AnalyzeSentiment2Async()
        {
            // Snippet: AnalyzeSentimentAsync(Document, CallSettings)
            // Additional: AnalyzeSentimentAsync(Document, CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            AnalyzeSentimentResponse response = await languageServiceClient.AnalyzeSentimentAsync(document);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeEntities</summary>
        public void AnalyzeEntitiesRequestObject()
        {
            // Snippet: AnalyzeEntities(AnalyzeEntitiesRequest, CallSettings)
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

        /// <summary>Snippet for AnalyzeEntitiesAsync</summary>
        public async Task AnalyzeEntitiesRequestObjectAsync()
        {
            // Snippet: AnalyzeEntitiesAsync(AnalyzeEntitiesRequest, CallSettings)
            // Additional: AnalyzeEntitiesAsync(AnalyzeEntitiesRequest, CancellationToken)
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

        /// <summary>Snippet for AnalyzeEntities</summary>
        public void AnalyzeEntities1()
        {
            // Snippet: AnalyzeEntities(Document, EncodingType, CallSettings)
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
        public async Task AnalyzeEntities1Async()
        {
            // Snippet: AnalyzeEntitiesAsync(Document, EncodingType, CallSettings)
            // Additional: AnalyzeEntitiesAsync(Document, EncodingType, CancellationToken)
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
        public void AnalyzeEntities2()
        {
            // Snippet: AnalyzeEntities(Document, CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            AnalyzeEntitiesResponse response = languageServiceClient.AnalyzeEntities(document);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeEntitiesAsync</summary>
        public async Task AnalyzeEntities2Async()
        {
            // Snippet: AnalyzeEntitiesAsync(Document, CallSettings)
            // Additional: AnalyzeEntitiesAsync(Document, CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            AnalyzeEntitiesResponse response = await languageServiceClient.AnalyzeEntitiesAsync(document);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeEntitySentiment</summary>
        public void AnalyzeEntitySentimentRequestObject()
        {
            // Snippet: AnalyzeEntitySentiment(AnalyzeEntitySentimentRequest, CallSettings)
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

        /// <summary>Snippet for AnalyzeEntitySentimentAsync</summary>
        public async Task AnalyzeEntitySentimentRequestObjectAsync()
        {
            // Snippet: AnalyzeEntitySentimentAsync(AnalyzeEntitySentimentRequest, CallSettings)
            // Additional: AnalyzeEntitySentimentAsync(AnalyzeEntitySentimentRequest, CancellationToken)
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

        /// <summary>Snippet for AnalyzeEntitySentiment</summary>
        public void AnalyzeEntitySentiment1()
        {
            // Snippet: AnalyzeEntitySentiment(Document, EncodingType, CallSettings)
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
        public async Task AnalyzeEntitySentiment1Async()
        {
            // Snippet: AnalyzeEntitySentimentAsync(Document, EncodingType, CallSettings)
            // Additional: AnalyzeEntitySentimentAsync(Document, EncodingType, CancellationToken)
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
        public void AnalyzeEntitySentiment2()
        {
            // Snippet: AnalyzeEntitySentiment(Document, CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            AnalyzeEntitySentimentResponse response = languageServiceClient.AnalyzeEntitySentiment(document);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeEntitySentimentAsync</summary>
        public async Task AnalyzeEntitySentiment2Async()
        {
            // Snippet: AnalyzeEntitySentimentAsync(Document, CallSettings)
            // Additional: AnalyzeEntitySentimentAsync(Document, CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            AnalyzeEntitySentimentResponse response = await languageServiceClient.AnalyzeEntitySentimentAsync(document);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeSyntax</summary>
        public void AnalyzeSyntaxRequestObject()
        {
            // Snippet: AnalyzeSyntax(AnalyzeSyntaxRequest, CallSettings)
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

        /// <summary>Snippet for AnalyzeSyntaxAsync</summary>
        public async Task AnalyzeSyntaxRequestObjectAsync()
        {
            // Snippet: AnalyzeSyntaxAsync(AnalyzeSyntaxRequest, CallSettings)
            // Additional: AnalyzeSyntaxAsync(AnalyzeSyntaxRequest, CancellationToken)
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

        /// <summary>Snippet for AnalyzeSyntax</summary>
        public void AnalyzeSyntax1()
        {
            // Snippet: AnalyzeSyntax(Document, EncodingType, CallSettings)
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
        public async Task AnalyzeSyntax1Async()
        {
            // Snippet: AnalyzeSyntaxAsync(Document, EncodingType, CallSettings)
            // Additional: AnalyzeSyntaxAsync(Document, EncodingType, CancellationToken)
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
        public void AnalyzeSyntax2()
        {
            // Snippet: AnalyzeSyntax(Document, CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            AnalyzeSyntaxResponse response = languageServiceClient.AnalyzeSyntax(document);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeSyntaxAsync</summary>
        public async Task AnalyzeSyntax2Async()
        {
            // Snippet: AnalyzeSyntaxAsync(Document, CallSettings)
            // Additional: AnalyzeSyntaxAsync(Document, CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            AnalyzeSyntaxResponse response = await languageServiceClient.AnalyzeSyntaxAsync(document);
            // End snippet
        }

        /// <summary>Snippet for ClassifyText</summary>
        public void ClassifyTextRequestObject()
        {
            // Snippet: ClassifyText(ClassifyTextRequest, CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            ClassifyTextRequest request = new ClassifyTextRequest
            {
                Document = new Document(),
                ClassificationModelOptions = new ClassificationModelOptions(),
            };
            // Make the request
            ClassifyTextResponse response = languageServiceClient.ClassifyText(request);
            // End snippet
        }

        /// <summary>Snippet for ClassifyTextAsync</summary>
        public async Task ClassifyTextRequestObjectAsync()
        {
            // Snippet: ClassifyTextAsync(ClassifyTextRequest, CallSettings)
            // Additional: ClassifyTextAsync(ClassifyTextRequest, CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClassifyTextRequest request = new ClassifyTextRequest
            {
                Document = new Document(),
                ClassificationModelOptions = new ClassificationModelOptions(),
            };
            // Make the request
            ClassifyTextResponse response = await languageServiceClient.ClassifyTextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ClassifyText</summary>
        public void ClassifyText()
        {
            // Snippet: ClassifyText(Document, CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            ClassifyTextResponse response = languageServiceClient.ClassifyText(document);
            // End snippet
        }

        /// <summary>Snippet for ClassifyTextAsync</summary>
        public async Task ClassifyTextAsync()
        {
            // Snippet: ClassifyTextAsync(Document, CallSettings)
            // Additional: ClassifyTextAsync(Document, CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            ClassifyTextResponse response = await languageServiceClient.ClassifyTextAsync(document);
            // End snippet
        }

        /// <summary>Snippet for ModerateText</summary>
        public void ModerateTextRequestObject()
        {
            // Snippet: ModerateText(ModerateTextRequest, CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            ModerateTextRequest request = new ModerateTextRequest
            {
                Document = new Document(),
            };
            // Make the request
            ModerateTextResponse response = languageServiceClient.ModerateText(request);
            // End snippet
        }

        /// <summary>Snippet for ModerateTextAsync</summary>
        public async Task ModerateTextRequestObjectAsync()
        {
            // Snippet: ModerateTextAsync(ModerateTextRequest, CallSettings)
            // Additional: ModerateTextAsync(ModerateTextRequest, CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModerateTextRequest request = new ModerateTextRequest
            {
                Document = new Document(),
            };
            // Make the request
            ModerateTextResponse response = await languageServiceClient.ModerateTextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ModerateText</summary>
        public void ModerateText()
        {
            // Snippet: ModerateText(Document, CallSettings)
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            ModerateTextResponse response = languageServiceClient.ModerateText(document);
            // End snippet
        }

        /// <summary>Snippet for ModerateTextAsync</summary>
        public async Task ModerateTextAsync()
        {
            // Snippet: ModerateTextAsync(Document, CallSettings)
            // Additional: ModerateTextAsync(Document, CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            ModerateTextResponse response = await languageServiceClient.ModerateTextAsync(document);
            // End snippet
        }

        /// <summary>Snippet for AnnotateText</summary>
        public void AnnotateTextRequestObject()
        {
            // Snippet: AnnotateText(AnnotateTextRequest, CallSettings)
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

        /// <summary>Snippet for AnnotateTextAsync</summary>
        public async Task AnnotateTextRequestObjectAsync()
        {
            // Snippet: AnnotateTextAsync(AnnotateTextRequest, CallSettings)
            // Additional: AnnotateTextAsync(AnnotateTextRequest, CancellationToken)
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

        /// <summary>Snippet for AnnotateText</summary>
        public void AnnotateText1()
        {
            // Snippet: AnnotateText(Document, AnnotateTextRequest.Types.Features, EncodingType, CallSettings)
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
        public async Task AnnotateText1Async()
        {
            // Snippet: AnnotateTextAsync(Document, AnnotateTextRequest.Types.Features, EncodingType, CallSettings)
            // Additional: AnnotateTextAsync(Document, AnnotateTextRequest.Types.Features, EncodingType, CancellationToken)
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
        public void AnnotateText2()
        {
            // Snippet: AnnotateText(Document, AnnotateTextRequest.Types.Features, CallSettings)
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
        public async Task AnnotateText2Async()
        {
            // Snippet: AnnotateTextAsync(Document, AnnotateTextRequest.Types.Features, CallSettings)
            // Additional: AnnotateTextAsync(Document, AnnotateTextRequest.Types.Features, CancellationToken)
            // Create client
            LanguageServiceClient languageServiceClient = await LanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            AnnotateTextRequest.Types.Features features = new AnnotateTextRequest.Types.Features();
            // Make the request
            AnnotateTextResponse response = await languageServiceClient.AnnotateTextAsync(document, features);
            // End snippet
        }
    }
}
