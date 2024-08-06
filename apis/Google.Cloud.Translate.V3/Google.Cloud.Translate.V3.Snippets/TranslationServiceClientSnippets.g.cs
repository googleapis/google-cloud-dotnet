// Copyright 2024 Google LLC
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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Translate.V3;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedTranslationServiceClientSnippets
    {
        /// <summary>Snippet for TranslateText</summary>
        public void TranslateTextRequestObject()
        {
            // Snippet: TranslateText(TranslateTextRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            TranslateTextRequest request = new TranslateTextRequest
            {
                Contents = { "", },
                MimeType = "",
                SourceLanguageCode = "",
                TargetLanguageCode = "",
                Model = "",
                GlossaryConfig = new TranslateTextGlossaryConfig(),
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Labels = { { "", "" }, },
                TransliterationConfig = new TransliterationConfig(),
            };
            // Make the request
            TranslateTextResponse response = translationServiceClient.TranslateText(request);
            // End snippet
        }

        /// <summary>Snippet for TranslateTextAsync</summary>
        public async Task TranslateTextRequestObjectAsync()
        {
            // Snippet: TranslateTextAsync(TranslateTextRequest, CallSettings)
            // Additional: TranslateTextAsync(TranslateTextRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            TranslateTextRequest request = new TranslateTextRequest
            {
                Contents = { "", },
                MimeType = "",
                SourceLanguageCode = "",
                TargetLanguageCode = "",
                Model = "",
                GlossaryConfig = new TranslateTextGlossaryConfig(),
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Labels = { { "", "" }, },
                TransliterationConfig = new TransliterationConfig(),
            };
            // Make the request
            TranslateTextResponse response = await translationServiceClient.TranslateTextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TranslateText</summary>
        public void TranslateText1()
        {
            // Snippet: TranslateText(string, string, IEnumerable<string>, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string targetLanguageCode = "";
            IEnumerable<string> contents = new string[] { "", };
            // Make the request
            TranslateTextResponse response = translationServiceClient.TranslateText(parent, targetLanguageCode, contents);
            // End snippet
        }

        /// <summary>Snippet for TranslateTextAsync</summary>
        public async Task TranslateText1Async()
        {
            // Snippet: TranslateTextAsync(string, string, IEnumerable<string>, CallSettings)
            // Additional: TranslateTextAsync(string, string, IEnumerable<string>, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string targetLanguageCode = "";
            IEnumerable<string> contents = new string[] { "", };
            // Make the request
            TranslateTextResponse response = await translationServiceClient.TranslateTextAsync(parent, targetLanguageCode, contents);
            // End snippet
        }

        /// <summary>Snippet for TranslateText</summary>
        public void TranslateText1ResourceNames()
        {
            // Snippet: TranslateText(LocationName, string, IEnumerable<string>, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string targetLanguageCode = "";
            IEnumerable<string> contents = new string[] { "", };
            // Make the request
            TranslateTextResponse response = translationServiceClient.TranslateText(parent, targetLanguageCode, contents);
            // End snippet
        }

        /// <summary>Snippet for TranslateTextAsync</summary>
        public async Task TranslateText1ResourceNamesAsync()
        {
            // Snippet: TranslateTextAsync(LocationName, string, IEnumerable<string>, CallSettings)
            // Additional: TranslateTextAsync(LocationName, string, IEnumerable<string>, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string targetLanguageCode = "";
            IEnumerable<string> contents = new string[] { "", };
            // Make the request
            TranslateTextResponse response = await translationServiceClient.TranslateTextAsync(parent, targetLanguageCode, contents);
            // End snippet
        }

        /// <summary>Snippet for TranslateText</summary>
        public void TranslateText2()
        {
            // Snippet: TranslateText(string, string, string, string, string, IEnumerable<string>, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string model = "";
            string mimeType = "";
            string sourceLanguageCode = "";
            string targetLanguageCode = "";
            IEnumerable<string> contents = new string[] { "", };
            // Make the request
            TranslateTextResponse response = translationServiceClient.TranslateText(parent, model, mimeType, sourceLanguageCode, targetLanguageCode, contents);
            // End snippet
        }

        /// <summary>Snippet for TranslateTextAsync</summary>
        public async Task TranslateText2Async()
        {
            // Snippet: TranslateTextAsync(string, string, string, string, string, IEnumerable<string>, CallSettings)
            // Additional: TranslateTextAsync(string, string, string, string, string, IEnumerable<string>, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string model = "";
            string mimeType = "";
            string sourceLanguageCode = "";
            string targetLanguageCode = "";
            IEnumerable<string> contents = new string[] { "", };
            // Make the request
            TranslateTextResponse response = await translationServiceClient.TranslateTextAsync(parent, model, mimeType, sourceLanguageCode, targetLanguageCode, contents);
            // End snippet
        }

        /// <summary>Snippet for TranslateText</summary>
        public void TranslateText2ResourceNames()
        {
            // Snippet: TranslateText(LocationName, string, string, string, string, IEnumerable<string>, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string model = "";
            string mimeType = "";
            string sourceLanguageCode = "";
            string targetLanguageCode = "";
            IEnumerable<string> contents = new string[] { "", };
            // Make the request
            TranslateTextResponse response = translationServiceClient.TranslateText(parent, model, mimeType, sourceLanguageCode, targetLanguageCode, contents);
            // End snippet
        }

        /// <summary>Snippet for TranslateTextAsync</summary>
        public async Task TranslateText2ResourceNamesAsync()
        {
            // Snippet: TranslateTextAsync(LocationName, string, string, string, string, IEnumerable<string>, CallSettings)
            // Additional: TranslateTextAsync(LocationName, string, string, string, string, IEnumerable<string>, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string model = "";
            string mimeType = "";
            string sourceLanguageCode = "";
            string targetLanguageCode = "";
            IEnumerable<string> contents = new string[] { "", };
            // Make the request
            TranslateTextResponse response = await translationServiceClient.TranslateTextAsync(parent, model, mimeType, sourceLanguageCode, targetLanguageCode, contents);
            // End snippet
        }

        /// <summary>Snippet for RomanizeText</summary>
        public void RomanizeTextRequestObject()
        {
            // Snippet: RomanizeText(RomanizeTextRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            RomanizeTextRequest request = new RomanizeTextRequest
            {
                Contents = { "", },
                SourceLanguageCode = "",
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            RomanizeTextResponse response = translationServiceClient.RomanizeText(request);
            // End snippet
        }

        /// <summary>Snippet for RomanizeTextAsync</summary>
        public async Task RomanizeTextRequestObjectAsync()
        {
            // Snippet: RomanizeTextAsync(RomanizeTextRequest, CallSettings)
            // Additional: RomanizeTextAsync(RomanizeTextRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            RomanizeTextRequest request = new RomanizeTextRequest
            {
                Contents = { "", },
                SourceLanguageCode = "",
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            RomanizeTextResponse response = await translationServiceClient.RomanizeTextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RomanizeText</summary>
        public void RomanizeText()
        {
            // Snippet: RomanizeText(string, IEnumerable<string>, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<string> contents = new string[] { "", };
            // Make the request
            RomanizeTextResponse response = translationServiceClient.RomanizeText(parent, contents);
            // End snippet
        }

        /// <summary>Snippet for RomanizeTextAsync</summary>
        public async Task RomanizeTextAsync()
        {
            // Snippet: RomanizeTextAsync(string, IEnumerable<string>, CallSettings)
            // Additional: RomanizeTextAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<string> contents = new string[] { "", };
            // Make the request
            RomanizeTextResponse response = await translationServiceClient.RomanizeTextAsync(parent, contents);
            // End snippet
        }

        /// <summary>Snippet for RomanizeText</summary>
        public void RomanizeTextResourceNames()
        {
            // Snippet: RomanizeText(LocationName, IEnumerable<string>, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<string> contents = new string[] { "", };
            // Make the request
            RomanizeTextResponse response = translationServiceClient.RomanizeText(parent, contents);
            // End snippet
        }

        /// <summary>Snippet for RomanizeTextAsync</summary>
        public async Task RomanizeTextResourceNamesAsync()
        {
            // Snippet: RomanizeTextAsync(LocationName, IEnumerable<string>, CallSettings)
            // Additional: RomanizeTextAsync(LocationName, IEnumerable<string>, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<string> contents = new string[] { "", };
            // Make the request
            RomanizeTextResponse response = await translationServiceClient.RomanizeTextAsync(parent, contents);
            // End snippet
        }

        /// <summary>Snippet for DetectLanguage</summary>
        public void DetectLanguageRequestObject()
        {
            // Snippet: DetectLanguage(DetectLanguageRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            DetectLanguageRequest request = new DetectLanguageRequest
            {
                Content = "",
                MimeType = "",
                Model = "",
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Labels = { { "", "" }, },
            };
            // Make the request
            DetectLanguageResponse response = translationServiceClient.DetectLanguage(request);
            // End snippet
        }

        /// <summary>Snippet for DetectLanguageAsync</summary>
        public async Task DetectLanguageRequestObjectAsync()
        {
            // Snippet: DetectLanguageAsync(DetectLanguageRequest, CallSettings)
            // Additional: DetectLanguageAsync(DetectLanguageRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DetectLanguageRequest request = new DetectLanguageRequest
            {
                Content = "",
                MimeType = "",
                Model = "",
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Labels = { { "", "" }, },
            };
            // Make the request
            DetectLanguageResponse response = await translationServiceClient.DetectLanguageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DetectLanguage</summary>
        public void DetectLanguage()
        {
            // Snippet: DetectLanguage(string, string, string, string, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string model = "";
            string mimeType = "";
            string content = "";
            // Make the request
            DetectLanguageResponse response = translationServiceClient.DetectLanguage(parent, model, mimeType, content);
            // End snippet
        }

        /// <summary>Snippet for DetectLanguageAsync</summary>
        public async Task DetectLanguageAsync()
        {
            // Snippet: DetectLanguageAsync(string, string, string, string, CallSettings)
            // Additional: DetectLanguageAsync(string, string, string, string, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string model = "";
            string mimeType = "";
            string content = "";
            // Make the request
            DetectLanguageResponse response = await translationServiceClient.DetectLanguageAsync(parent, model, mimeType, content);
            // End snippet
        }

        /// <summary>Snippet for DetectLanguage</summary>
        public void DetectLanguageResourceNames()
        {
            // Snippet: DetectLanguage(LocationName, string, string, string, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string model = "";
            string mimeType = "";
            string content = "";
            // Make the request
            DetectLanguageResponse response = translationServiceClient.DetectLanguage(parent, model, mimeType, content);
            // End snippet
        }

        /// <summary>Snippet for DetectLanguageAsync</summary>
        public async Task DetectLanguageResourceNamesAsync()
        {
            // Snippet: DetectLanguageAsync(LocationName, string, string, string, CallSettings)
            // Additional: DetectLanguageAsync(LocationName, string, string, string, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string model = "";
            string mimeType = "";
            string content = "";
            // Make the request
            DetectLanguageResponse response = await translationServiceClient.DetectLanguageAsync(parent, model, mimeType, content);
            // End snippet
        }

        /// <summary>Snippet for GetSupportedLanguages</summary>
        public void GetSupportedLanguagesRequestObject()
        {
            // Snippet: GetSupportedLanguages(GetSupportedLanguagesRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            GetSupportedLanguagesRequest request = new GetSupportedLanguagesRequest
            {
                DisplayLanguageCode = "",
                Model = "",
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            SupportedLanguages response = translationServiceClient.GetSupportedLanguages(request);
            // End snippet
        }

        /// <summary>Snippet for GetSupportedLanguagesAsync</summary>
        public async Task GetSupportedLanguagesRequestObjectAsync()
        {
            // Snippet: GetSupportedLanguagesAsync(GetSupportedLanguagesRequest, CallSettings)
            // Additional: GetSupportedLanguagesAsync(GetSupportedLanguagesRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSupportedLanguagesRequest request = new GetSupportedLanguagesRequest
            {
                DisplayLanguageCode = "",
                Model = "",
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            SupportedLanguages response = await translationServiceClient.GetSupportedLanguagesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSupportedLanguages</summary>
        public void GetSupportedLanguages()
        {
            // Snippet: GetSupportedLanguages(string, string, string, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string model = "";
            string displayLanguageCode = "";
            // Make the request
            SupportedLanguages response = translationServiceClient.GetSupportedLanguages(parent, model, displayLanguageCode);
            // End snippet
        }

        /// <summary>Snippet for GetSupportedLanguagesAsync</summary>
        public async Task GetSupportedLanguagesAsync()
        {
            // Snippet: GetSupportedLanguagesAsync(string, string, string, CallSettings)
            // Additional: GetSupportedLanguagesAsync(string, string, string, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string model = "";
            string displayLanguageCode = "";
            // Make the request
            SupportedLanguages response = await translationServiceClient.GetSupportedLanguagesAsync(parent, model, displayLanguageCode);
            // End snippet
        }

        /// <summary>Snippet for GetSupportedLanguages</summary>
        public void GetSupportedLanguagesResourceNames()
        {
            // Snippet: GetSupportedLanguages(LocationName, string, string, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string model = "";
            string displayLanguageCode = "";
            // Make the request
            SupportedLanguages response = translationServiceClient.GetSupportedLanguages(parent, model, displayLanguageCode);
            // End snippet
        }

        /// <summary>Snippet for GetSupportedLanguagesAsync</summary>
        public async Task GetSupportedLanguagesResourceNamesAsync()
        {
            // Snippet: GetSupportedLanguagesAsync(LocationName, string, string, CallSettings)
            // Additional: GetSupportedLanguagesAsync(LocationName, string, string, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string model = "";
            string displayLanguageCode = "";
            // Make the request
            SupportedLanguages response = await translationServiceClient.GetSupportedLanguagesAsync(parent, model, displayLanguageCode);
            // End snippet
        }

        /// <summary>Snippet for TranslateDocument</summary>
        public void TranslateDocumentRequestObject()
        {
            // Snippet: TranslateDocument(TranslateDocumentRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            TranslateDocumentRequest request = new TranslateDocumentRequest
            {
                Parent = "",
                SourceLanguageCode = "",
                TargetLanguageCode = "",
                DocumentInputConfig = new DocumentInputConfig(),
                DocumentOutputConfig = new DocumentOutputConfig(),
                Model = "",
                GlossaryConfig = new TranslateTextGlossaryConfig(),
                Labels = { { "", "" }, },
                CustomizedAttribution = "",
                IsTranslateNativePdfOnly = false,
                EnableShadowRemovalNativePdf = false,
                EnableRotationCorrection = false,
            };
            // Make the request
            TranslateDocumentResponse response = translationServiceClient.TranslateDocument(request);
            // End snippet
        }

        /// <summary>Snippet for TranslateDocumentAsync</summary>
        public async Task TranslateDocumentRequestObjectAsync()
        {
            // Snippet: TranslateDocumentAsync(TranslateDocumentRequest, CallSettings)
            // Additional: TranslateDocumentAsync(TranslateDocumentRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            TranslateDocumentRequest request = new TranslateDocumentRequest
            {
                Parent = "",
                SourceLanguageCode = "",
                TargetLanguageCode = "",
                DocumentInputConfig = new DocumentInputConfig(),
                DocumentOutputConfig = new DocumentOutputConfig(),
                Model = "",
                GlossaryConfig = new TranslateTextGlossaryConfig(),
                Labels = { { "", "" }, },
                CustomizedAttribution = "",
                IsTranslateNativePdfOnly = false,
                EnableShadowRemovalNativePdf = false,
                EnableRotationCorrection = false,
            };
            // Make the request
            TranslateDocumentResponse response = await translationServiceClient.TranslateDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchTranslateText</summary>
        public void BatchTranslateTextRequestObject()
        {
            // Snippet: BatchTranslateText(BatchTranslateTextRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            BatchTranslateTextRequest request = new BatchTranslateTextRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SourceLanguageCode = "",
                TargetLanguageCodes = { "", },
                Models = { { "", "" }, },
                InputConfigs = { new InputConfig(), },
                OutputConfig = new OutputConfig(),
                Glossaries =
                {
                    {
                        "",
                        new TranslateTextGlossaryConfig()
                    },
                },
                Labels = { { "", "" }, },
            };
            // Make the request
            Operation<BatchTranslateResponse, BatchTranslateMetadata> response = translationServiceClient.BatchTranslateText(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchTranslateResponse, BatchTranslateMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchTranslateResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchTranslateResponse, BatchTranslateMetadata> retrievedResponse = translationServiceClient.PollOnceBatchTranslateText(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchTranslateResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchTranslateTextAsync</summary>
        public async Task BatchTranslateTextRequestObjectAsync()
        {
            // Snippet: BatchTranslateTextAsync(BatchTranslateTextRequest, CallSettings)
            // Additional: BatchTranslateTextAsync(BatchTranslateTextRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchTranslateTextRequest request = new BatchTranslateTextRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SourceLanguageCode = "",
                TargetLanguageCodes = { "", },
                Models = { { "", "" }, },
                InputConfigs = { new InputConfig(), },
                OutputConfig = new OutputConfig(),
                Glossaries =
                {
                    {
                        "",
                        new TranslateTextGlossaryConfig()
                    },
                },
                Labels = { { "", "" }, },
            };
            // Make the request
            Operation<BatchTranslateResponse, BatchTranslateMetadata> response = await translationServiceClient.BatchTranslateTextAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchTranslateResponse, BatchTranslateMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchTranslateResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchTranslateResponse, BatchTranslateMetadata> retrievedResponse = await translationServiceClient.PollOnceBatchTranslateTextAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchTranslateResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchTranslateDocument</summary>
        public void BatchTranslateDocumentRequestObject()
        {
            // Snippet: BatchTranslateDocument(BatchTranslateDocumentRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            BatchTranslateDocumentRequest request = new BatchTranslateDocumentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SourceLanguageCode = "",
                TargetLanguageCodes = { "", },
                InputConfigs =
                {
                    new BatchDocumentInputConfig(),
                },
                OutputConfig = new BatchDocumentOutputConfig(),
                Models = { { "", "" }, },
                Glossaries =
                {
                    {
                        "",
                        new TranslateTextGlossaryConfig()
                    },
                },
                FormatConversions = { { "", "" }, },
                CustomizedAttribution = "",
                EnableShadowRemovalNativePdf = false,
                EnableRotationCorrection = false,
            };
            // Make the request
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> response = translationServiceClient.BatchTranslateDocument(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchTranslateDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> retrievedResponse = translationServiceClient.PollOnceBatchTranslateDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchTranslateDocumentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchTranslateDocumentAsync</summary>
        public async Task BatchTranslateDocumentRequestObjectAsync()
        {
            // Snippet: BatchTranslateDocumentAsync(BatchTranslateDocumentRequest, CallSettings)
            // Additional: BatchTranslateDocumentAsync(BatchTranslateDocumentRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchTranslateDocumentRequest request = new BatchTranslateDocumentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SourceLanguageCode = "",
                TargetLanguageCodes = { "", },
                InputConfigs =
                {
                    new BatchDocumentInputConfig(),
                },
                OutputConfig = new BatchDocumentOutputConfig(),
                Models = { { "", "" }, },
                Glossaries =
                {
                    {
                        "",
                        new TranslateTextGlossaryConfig()
                    },
                },
                FormatConversions = { { "", "" }, },
                CustomizedAttribution = "",
                EnableShadowRemovalNativePdf = false,
                EnableRotationCorrection = false,
            };
            // Make the request
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> response = await translationServiceClient.BatchTranslateDocumentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchTranslateDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> retrievedResponse = await translationServiceClient.PollOnceBatchTranslateDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchTranslateDocumentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchTranslateDocument</summary>
        public void BatchTranslateDocument()
        {
            // Snippet: BatchTranslateDocument(string, string, IEnumerable<string>, IEnumerable<BatchDocumentInputConfig>, BatchDocumentOutputConfig, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string sourceLanguageCode = "";
            IEnumerable<string> targetLanguageCodes = new string[] { "", };
            IEnumerable<BatchDocumentInputConfig> inputConfigs = new BatchDocumentInputConfig[]
            {
                new BatchDocumentInputConfig(),
            };
            BatchDocumentOutputConfig outputConfig = new BatchDocumentOutputConfig();
            // Make the request
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> response = translationServiceClient.BatchTranslateDocument(parent, sourceLanguageCode, targetLanguageCodes, inputConfigs, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchTranslateDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> retrievedResponse = translationServiceClient.PollOnceBatchTranslateDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchTranslateDocumentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchTranslateDocumentAsync</summary>
        public async Task BatchTranslateDocumentAsync()
        {
            // Snippet: BatchTranslateDocumentAsync(string, string, IEnumerable<string>, IEnumerable<BatchDocumentInputConfig>, BatchDocumentOutputConfig, CallSettings)
            // Additional: BatchTranslateDocumentAsync(string, string, IEnumerable<string>, IEnumerable<BatchDocumentInputConfig>, BatchDocumentOutputConfig, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string sourceLanguageCode = "";
            IEnumerable<string> targetLanguageCodes = new string[] { "", };
            IEnumerable<BatchDocumentInputConfig> inputConfigs = new BatchDocumentInputConfig[]
            {
                new BatchDocumentInputConfig(),
            };
            BatchDocumentOutputConfig outputConfig = new BatchDocumentOutputConfig();
            // Make the request
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> response = await translationServiceClient.BatchTranslateDocumentAsync(parent, sourceLanguageCode, targetLanguageCodes, inputConfigs, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchTranslateDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> retrievedResponse = await translationServiceClient.PollOnceBatchTranslateDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchTranslateDocumentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchTranslateDocument</summary>
        public void BatchTranslateDocumentResourceNames()
        {
            // Snippet: BatchTranslateDocument(LocationName, string, IEnumerable<string>, IEnumerable<BatchDocumentInputConfig>, BatchDocumentOutputConfig, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string sourceLanguageCode = "";
            IEnumerable<string> targetLanguageCodes = new string[] { "", };
            IEnumerable<BatchDocumentInputConfig> inputConfigs = new BatchDocumentInputConfig[]
            {
                new BatchDocumentInputConfig(),
            };
            BatchDocumentOutputConfig outputConfig = new BatchDocumentOutputConfig();
            // Make the request
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> response = translationServiceClient.BatchTranslateDocument(parent, sourceLanguageCode, targetLanguageCodes, inputConfigs, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchTranslateDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> retrievedResponse = translationServiceClient.PollOnceBatchTranslateDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchTranslateDocumentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchTranslateDocumentAsync</summary>
        public async Task BatchTranslateDocumentResourceNamesAsync()
        {
            // Snippet: BatchTranslateDocumentAsync(LocationName, string, IEnumerable<string>, IEnumerable<BatchDocumentInputConfig>, BatchDocumentOutputConfig, CallSettings)
            // Additional: BatchTranslateDocumentAsync(LocationName, string, IEnumerable<string>, IEnumerable<BatchDocumentInputConfig>, BatchDocumentOutputConfig, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string sourceLanguageCode = "";
            IEnumerable<string> targetLanguageCodes = new string[] { "", };
            IEnumerable<BatchDocumentInputConfig> inputConfigs = new BatchDocumentInputConfig[]
            {
                new BatchDocumentInputConfig(),
            };
            BatchDocumentOutputConfig outputConfig = new BatchDocumentOutputConfig();
            // Make the request
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> response = await translationServiceClient.BatchTranslateDocumentAsync(parent, sourceLanguageCode, targetLanguageCodes, inputConfigs, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchTranslateDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> retrievedResponse = await translationServiceClient.PollOnceBatchTranslateDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchTranslateDocumentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGlossary</summary>
        public void CreateGlossaryRequestObject()
        {
            // Snippet: CreateGlossary(CreateGlossaryRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            CreateGlossaryRequest request = new CreateGlossaryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Glossary = new Glossary(),
            };
            // Make the request
            Operation<Glossary, CreateGlossaryMetadata> response = translationServiceClient.CreateGlossary(request);

            // Poll until the returned long-running operation is complete
            Operation<Glossary, CreateGlossaryMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Glossary, CreateGlossaryMetadata> retrievedResponse = translationServiceClient.PollOnceCreateGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryAsync</summary>
        public async Task CreateGlossaryRequestObjectAsync()
        {
            // Snippet: CreateGlossaryAsync(CreateGlossaryRequest, CallSettings)
            // Additional: CreateGlossaryAsync(CreateGlossaryRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateGlossaryRequest request = new CreateGlossaryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Glossary = new Glossary(),
            };
            // Make the request
            Operation<Glossary, CreateGlossaryMetadata> response = await translationServiceClient.CreateGlossaryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Glossary, CreateGlossaryMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Glossary, CreateGlossaryMetadata> retrievedResponse = await translationServiceClient.PollOnceCreateGlossaryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGlossary</summary>
        public void CreateGlossary()
        {
            // Snippet: CreateGlossary(string, Glossary, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Glossary glossary = new Glossary();
            // Make the request
            Operation<Glossary, CreateGlossaryMetadata> response = translationServiceClient.CreateGlossary(parent, glossary);

            // Poll until the returned long-running operation is complete
            Operation<Glossary, CreateGlossaryMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Glossary, CreateGlossaryMetadata> retrievedResponse = translationServiceClient.PollOnceCreateGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryAsync</summary>
        public async Task CreateGlossaryAsync()
        {
            // Snippet: CreateGlossaryAsync(string, Glossary, CallSettings)
            // Additional: CreateGlossaryAsync(string, Glossary, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Glossary glossary = new Glossary();
            // Make the request
            Operation<Glossary, CreateGlossaryMetadata> response = await translationServiceClient.CreateGlossaryAsync(parent, glossary);

            // Poll until the returned long-running operation is complete
            Operation<Glossary, CreateGlossaryMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Glossary, CreateGlossaryMetadata> retrievedResponse = await translationServiceClient.PollOnceCreateGlossaryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGlossary</summary>
        public void CreateGlossaryResourceNames()
        {
            // Snippet: CreateGlossary(LocationName, Glossary, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Glossary glossary = new Glossary();
            // Make the request
            Operation<Glossary, CreateGlossaryMetadata> response = translationServiceClient.CreateGlossary(parent, glossary);

            // Poll until the returned long-running operation is complete
            Operation<Glossary, CreateGlossaryMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Glossary, CreateGlossaryMetadata> retrievedResponse = translationServiceClient.PollOnceCreateGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryAsync</summary>
        public async Task CreateGlossaryResourceNamesAsync()
        {
            // Snippet: CreateGlossaryAsync(LocationName, Glossary, CallSettings)
            // Additional: CreateGlossaryAsync(LocationName, Glossary, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Glossary glossary = new Glossary();
            // Make the request
            Operation<Glossary, CreateGlossaryMetadata> response = await translationServiceClient.CreateGlossaryAsync(parent, glossary);

            // Poll until the returned long-running operation is complete
            Operation<Glossary, CreateGlossaryMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Glossary, CreateGlossaryMetadata> retrievedResponse = await translationServiceClient.PollOnceCreateGlossaryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossary</summary>
        public void UpdateGlossaryRequestObject()
        {
            // Snippet: UpdateGlossary(UpdateGlossaryRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            UpdateGlossaryRequest request = new UpdateGlossaryRequest
            {
                Glossary = new Glossary(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Glossary, UpdateGlossaryMetadata> response = translationServiceClient.UpdateGlossary(request);

            // Poll until the returned long-running operation is complete
            Operation<Glossary, UpdateGlossaryMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Glossary, UpdateGlossaryMetadata> retrievedResponse = translationServiceClient.PollOnceUpdateGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossaryAsync</summary>
        public async Task UpdateGlossaryRequestObjectAsync()
        {
            // Snippet: UpdateGlossaryAsync(UpdateGlossaryRequest, CallSettings)
            // Additional: UpdateGlossaryAsync(UpdateGlossaryRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGlossaryRequest request = new UpdateGlossaryRequest
            {
                Glossary = new Glossary(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Glossary, UpdateGlossaryMetadata> response = await translationServiceClient.UpdateGlossaryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Glossary, UpdateGlossaryMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Glossary, UpdateGlossaryMetadata> retrievedResponse = await translationServiceClient.PollOnceUpdateGlossaryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossary</summary>
        public void UpdateGlossary()
        {
            // Snippet: UpdateGlossary(Glossary, FieldMask, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            Glossary glossary = new Glossary();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Glossary, UpdateGlossaryMetadata> response = translationServiceClient.UpdateGlossary(glossary, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Glossary, UpdateGlossaryMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Glossary, UpdateGlossaryMetadata> retrievedResponse = translationServiceClient.PollOnceUpdateGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossaryAsync</summary>
        public async Task UpdateGlossaryAsync()
        {
            // Snippet: UpdateGlossaryAsync(Glossary, FieldMask, CallSettings)
            // Additional: UpdateGlossaryAsync(Glossary, FieldMask, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            Glossary glossary = new Glossary();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Glossary, UpdateGlossaryMetadata> response = await translationServiceClient.UpdateGlossaryAsync(glossary, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Glossary, UpdateGlossaryMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Glossary, UpdateGlossaryMetadata> retrievedResponse = await translationServiceClient.PollOnceUpdateGlossaryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListGlossaries</summary>
        public void ListGlossariesRequestObject()
        {
            // Snippet: ListGlossaries(ListGlossariesRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            ListGlossariesRequest request = new ListGlossariesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListGlossariesResponse, Glossary> response = translationServiceClient.ListGlossaries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Glossary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGlossariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Glossary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Glossary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Glossary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossariesAsync</summary>
        public async Task ListGlossariesRequestObjectAsync()
        {
            // Snippet: ListGlossariesAsync(ListGlossariesRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListGlossariesRequest request = new ListGlossariesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListGlossariesResponse, Glossary> response = translationServiceClient.ListGlossariesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Glossary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGlossariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Glossary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Glossary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Glossary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaries</summary>
        public void ListGlossaries()
        {
            // Snippet: ListGlossaries(string, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListGlossariesResponse, Glossary> response = translationServiceClient.ListGlossaries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Glossary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGlossariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Glossary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Glossary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Glossary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossariesAsync</summary>
        public async Task ListGlossariesAsync()
        {
            // Snippet: ListGlossariesAsync(string, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListGlossariesResponse, Glossary> response = translationServiceClient.ListGlossariesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Glossary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGlossariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Glossary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Glossary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Glossary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaries</summary>
        public void ListGlossariesResourceNames()
        {
            // Snippet: ListGlossaries(LocationName, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListGlossariesResponse, Glossary> response = translationServiceClient.ListGlossaries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Glossary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGlossariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Glossary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Glossary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Glossary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossariesAsync</summary>
        public async Task ListGlossariesResourceNamesAsync()
        {
            // Snippet: ListGlossariesAsync(LocationName, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListGlossariesResponse, Glossary> response = translationServiceClient.ListGlossariesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Glossary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGlossariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Glossary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Glossary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Glossary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGlossary</summary>
        public void GetGlossaryRequestObject()
        {
            // Snippet: GetGlossary(GetGlossaryRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            GetGlossaryRequest request = new GetGlossaryRequest
            {
                GlossaryName = GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
            };
            // Make the request
            Glossary response = translationServiceClient.GetGlossary(request);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryAsync</summary>
        public async Task GetGlossaryRequestObjectAsync()
        {
            // Snippet: GetGlossaryAsync(GetGlossaryRequest, CallSettings)
            // Additional: GetGlossaryAsync(GetGlossaryRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGlossaryRequest request = new GetGlossaryRequest
            {
                GlossaryName = GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
            };
            // Make the request
            Glossary response = await translationServiceClient.GetGlossaryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGlossary</summary>
        public void GetGlossary()
        {
            // Snippet: GetGlossary(string, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            // Make the request
            Glossary response = translationServiceClient.GetGlossary(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryAsync</summary>
        public async Task GetGlossaryAsync()
        {
            // Snippet: GetGlossaryAsync(string, CallSettings)
            // Additional: GetGlossaryAsync(string, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            // Make the request
            Glossary response = await translationServiceClient.GetGlossaryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlossary</summary>
        public void GetGlossaryResourceNames()
        {
            // Snippet: GetGlossary(GlossaryName, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            GlossaryName name = GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            // Make the request
            Glossary response = translationServiceClient.GetGlossary(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryAsync</summary>
        public async Task GetGlossaryResourceNamesAsync()
        {
            // Snippet: GetGlossaryAsync(GlossaryName, CallSettings)
            // Additional: GetGlossaryAsync(GlossaryName, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GlossaryName name = GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            // Make the request
            Glossary response = await translationServiceClient.GetGlossaryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossary</summary>
        public void DeleteGlossaryRequestObject()
        {
            // Snippet: DeleteGlossary(DeleteGlossaryRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            DeleteGlossaryRequest request = new DeleteGlossaryRequest
            {
                GlossaryName = GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
            };
            // Make the request
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> response = translationServiceClient.DeleteGlossary(request);

            // Poll until the returned long-running operation is complete
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeleteGlossaryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> retrievedResponse = translationServiceClient.PollOnceDeleteGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeleteGlossaryResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryAsync</summary>
        public async Task DeleteGlossaryRequestObjectAsync()
        {
            // Snippet: DeleteGlossaryAsync(DeleteGlossaryRequest, CallSettings)
            // Additional: DeleteGlossaryAsync(DeleteGlossaryRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGlossaryRequest request = new DeleteGlossaryRequest
            {
                GlossaryName = GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
            };
            // Make the request
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> response = await translationServiceClient.DeleteGlossaryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeleteGlossaryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> retrievedResponse = await translationServiceClient.PollOnceDeleteGlossaryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeleteGlossaryResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossary</summary>
        public void DeleteGlossary()
        {
            // Snippet: DeleteGlossary(string, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            // Make the request
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> response = translationServiceClient.DeleteGlossary(name);

            // Poll until the returned long-running operation is complete
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeleteGlossaryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> retrievedResponse = translationServiceClient.PollOnceDeleteGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeleteGlossaryResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryAsync</summary>
        public async Task DeleteGlossaryAsync()
        {
            // Snippet: DeleteGlossaryAsync(string, CallSettings)
            // Additional: DeleteGlossaryAsync(string, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            // Make the request
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> response = await translationServiceClient.DeleteGlossaryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeleteGlossaryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> retrievedResponse = await translationServiceClient.PollOnceDeleteGlossaryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeleteGlossaryResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossary</summary>
        public void DeleteGlossaryResourceNames()
        {
            // Snippet: DeleteGlossary(GlossaryName, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            GlossaryName name = GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            // Make the request
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> response = translationServiceClient.DeleteGlossary(name);

            // Poll until the returned long-running operation is complete
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeleteGlossaryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> retrievedResponse = translationServiceClient.PollOnceDeleteGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeleteGlossaryResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryAsync</summary>
        public async Task DeleteGlossaryResourceNamesAsync()
        {
            // Snippet: DeleteGlossaryAsync(GlossaryName, CallSettings)
            // Additional: DeleteGlossaryAsync(GlossaryName, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GlossaryName name = GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            // Make the request
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> response = await translationServiceClient.DeleteGlossaryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeleteGlossaryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> retrievedResponse = await translationServiceClient.PollOnceDeleteGlossaryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeleteGlossaryResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryEntry</summary>
        public void GetGlossaryEntryRequestObject()
        {
            // Snippet: GetGlossaryEntry(GetGlossaryEntryRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            GetGlossaryEntryRequest request = new GetGlossaryEntryRequest
            {
                GlossaryEntryName = GlossaryEntryName.FromProjectLocationGlossaryGlossaryEntry("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_ENTRY]"),
            };
            // Make the request
            GlossaryEntry response = translationServiceClient.GetGlossaryEntry(request);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryEntryAsync</summary>
        public async Task GetGlossaryEntryRequestObjectAsync()
        {
            // Snippet: GetGlossaryEntryAsync(GetGlossaryEntryRequest, CallSettings)
            // Additional: GetGlossaryEntryAsync(GetGlossaryEntryRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGlossaryEntryRequest request = new GetGlossaryEntryRequest
            {
                GlossaryEntryName = GlossaryEntryName.FromProjectLocationGlossaryGlossaryEntry("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_ENTRY]"),
            };
            // Make the request
            GlossaryEntry response = await translationServiceClient.GetGlossaryEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryEntry</summary>
        public void GetGlossaryEntry()
        {
            // Snippet: GetGlossaryEntry(string, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]/glossaryEntries/[GLOSSARY_ENTRY]";
            // Make the request
            GlossaryEntry response = translationServiceClient.GetGlossaryEntry(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryEntryAsync</summary>
        public async Task GetGlossaryEntryAsync()
        {
            // Snippet: GetGlossaryEntryAsync(string, CallSettings)
            // Additional: GetGlossaryEntryAsync(string, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]/glossaryEntries/[GLOSSARY_ENTRY]";
            // Make the request
            GlossaryEntry response = await translationServiceClient.GetGlossaryEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryEntry</summary>
        public void GetGlossaryEntryResourceNames()
        {
            // Snippet: GetGlossaryEntry(GlossaryEntryName, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            GlossaryEntryName name = GlossaryEntryName.FromProjectLocationGlossaryGlossaryEntry("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_ENTRY]");
            // Make the request
            GlossaryEntry response = translationServiceClient.GetGlossaryEntry(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryEntryAsync</summary>
        public async Task GetGlossaryEntryResourceNamesAsync()
        {
            // Snippet: GetGlossaryEntryAsync(GlossaryEntryName, CallSettings)
            // Additional: GetGlossaryEntryAsync(GlossaryEntryName, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GlossaryEntryName name = GlossaryEntryName.FromProjectLocationGlossaryGlossaryEntry("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_ENTRY]");
            // Make the request
            GlossaryEntry response = await translationServiceClient.GetGlossaryEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListGlossaryEntries</summary>
        public void ListGlossaryEntriesRequestObject()
        {
            // Snippet: ListGlossaryEntries(ListGlossaryEntriesRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            ListGlossaryEntriesRequest request = new ListGlossaryEntriesRequest
            {
                ParentAsGlossaryName = GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
            };
            // Make the request
            PagedEnumerable<ListGlossaryEntriesResponse, GlossaryEntry> response = translationServiceClient.ListGlossaryEntries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GlossaryEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGlossaryEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GlossaryEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GlossaryEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GlossaryEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaryEntriesAsync</summary>
        public async Task ListGlossaryEntriesRequestObjectAsync()
        {
            // Snippet: ListGlossaryEntriesAsync(ListGlossaryEntriesRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListGlossaryEntriesRequest request = new ListGlossaryEntriesRequest
            {
                ParentAsGlossaryName = GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListGlossaryEntriesResponse, GlossaryEntry> response = translationServiceClient.ListGlossaryEntriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GlossaryEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGlossaryEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GlossaryEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GlossaryEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GlossaryEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaryEntries</summary>
        public void ListGlossaryEntries()
        {
            // Snippet: ListGlossaryEntries(string, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            // Make the request
            PagedEnumerable<ListGlossaryEntriesResponse, GlossaryEntry> response = translationServiceClient.ListGlossaryEntries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GlossaryEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGlossaryEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GlossaryEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GlossaryEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GlossaryEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaryEntriesAsync</summary>
        public async Task ListGlossaryEntriesAsync()
        {
            // Snippet: ListGlossaryEntriesAsync(string, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            // Make the request
            PagedAsyncEnumerable<ListGlossaryEntriesResponse, GlossaryEntry> response = translationServiceClient.ListGlossaryEntriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GlossaryEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGlossaryEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GlossaryEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GlossaryEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GlossaryEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaryEntries</summary>
        public void ListGlossaryEntriesResourceNames()
        {
            // Snippet: ListGlossaryEntries(GlossaryName, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            GlossaryName parent = GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            // Make the request
            PagedEnumerable<ListGlossaryEntriesResponse, GlossaryEntry> response = translationServiceClient.ListGlossaryEntries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GlossaryEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGlossaryEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GlossaryEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GlossaryEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GlossaryEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaryEntriesAsync</summary>
        public async Task ListGlossaryEntriesResourceNamesAsync()
        {
            // Snippet: ListGlossaryEntriesAsync(GlossaryName, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GlossaryName parent = GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            // Make the request
            PagedAsyncEnumerable<ListGlossaryEntriesResponse, GlossaryEntry> response = translationServiceClient.ListGlossaryEntriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GlossaryEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGlossaryEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GlossaryEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GlossaryEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GlossaryEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryEntry</summary>
        public void CreateGlossaryEntryRequestObject()
        {
            // Snippet: CreateGlossaryEntry(CreateGlossaryEntryRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            CreateGlossaryEntryRequest request = new CreateGlossaryEntryRequest
            {
                ParentAsGlossaryName = GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
                GlossaryEntry = new GlossaryEntry(),
            };
            // Make the request
            GlossaryEntry response = translationServiceClient.CreateGlossaryEntry(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryEntryAsync</summary>
        public async Task CreateGlossaryEntryRequestObjectAsync()
        {
            // Snippet: CreateGlossaryEntryAsync(CreateGlossaryEntryRequest, CallSettings)
            // Additional: CreateGlossaryEntryAsync(CreateGlossaryEntryRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateGlossaryEntryRequest request = new CreateGlossaryEntryRequest
            {
                ParentAsGlossaryName = GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
                GlossaryEntry = new GlossaryEntry(),
            };
            // Make the request
            GlossaryEntry response = await translationServiceClient.CreateGlossaryEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryEntry</summary>
        public void CreateGlossaryEntry()
        {
            // Snippet: CreateGlossaryEntry(string, GlossaryEntry, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            GlossaryEntry glossaryEntry = new GlossaryEntry();
            // Make the request
            GlossaryEntry response = translationServiceClient.CreateGlossaryEntry(parent, glossaryEntry);
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryEntryAsync</summary>
        public async Task CreateGlossaryEntryAsync()
        {
            // Snippet: CreateGlossaryEntryAsync(string, GlossaryEntry, CallSettings)
            // Additional: CreateGlossaryEntryAsync(string, GlossaryEntry, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            GlossaryEntry glossaryEntry = new GlossaryEntry();
            // Make the request
            GlossaryEntry response = await translationServiceClient.CreateGlossaryEntryAsync(parent, glossaryEntry);
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryEntry</summary>
        public void CreateGlossaryEntryResourceNames()
        {
            // Snippet: CreateGlossaryEntry(GlossaryName, GlossaryEntry, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            GlossaryName parent = GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            GlossaryEntry glossaryEntry = new GlossaryEntry();
            // Make the request
            GlossaryEntry response = translationServiceClient.CreateGlossaryEntry(parent, glossaryEntry);
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryEntryAsync</summary>
        public async Task CreateGlossaryEntryResourceNamesAsync()
        {
            // Snippet: CreateGlossaryEntryAsync(GlossaryName, GlossaryEntry, CallSettings)
            // Additional: CreateGlossaryEntryAsync(GlossaryName, GlossaryEntry, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GlossaryName parent = GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            GlossaryEntry glossaryEntry = new GlossaryEntry();
            // Make the request
            GlossaryEntry response = await translationServiceClient.CreateGlossaryEntryAsync(parent, glossaryEntry);
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossaryEntry</summary>
        public void UpdateGlossaryEntryRequestObject()
        {
            // Snippet: UpdateGlossaryEntry(UpdateGlossaryEntryRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            UpdateGlossaryEntryRequest request = new UpdateGlossaryEntryRequest
            {
                GlossaryEntry = new GlossaryEntry(),
            };
            // Make the request
            GlossaryEntry response = translationServiceClient.UpdateGlossaryEntry(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossaryEntryAsync</summary>
        public async Task UpdateGlossaryEntryRequestObjectAsync()
        {
            // Snippet: UpdateGlossaryEntryAsync(UpdateGlossaryEntryRequest, CallSettings)
            // Additional: UpdateGlossaryEntryAsync(UpdateGlossaryEntryRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGlossaryEntryRequest request = new UpdateGlossaryEntryRequest
            {
                GlossaryEntry = new GlossaryEntry(),
            };
            // Make the request
            GlossaryEntry response = await translationServiceClient.UpdateGlossaryEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossaryEntry</summary>
        public void UpdateGlossaryEntry()
        {
            // Snippet: UpdateGlossaryEntry(GlossaryEntry, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            GlossaryEntry glossaryEntry = new GlossaryEntry();
            // Make the request
            GlossaryEntry response = translationServiceClient.UpdateGlossaryEntry(glossaryEntry);
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossaryEntryAsync</summary>
        public async Task UpdateGlossaryEntryAsync()
        {
            // Snippet: UpdateGlossaryEntryAsync(GlossaryEntry, CallSettings)
            // Additional: UpdateGlossaryEntryAsync(GlossaryEntry, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GlossaryEntry glossaryEntry = new GlossaryEntry();
            // Make the request
            GlossaryEntry response = await translationServiceClient.UpdateGlossaryEntryAsync(glossaryEntry);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryEntry</summary>
        public void DeleteGlossaryEntryRequestObject()
        {
            // Snippet: DeleteGlossaryEntry(DeleteGlossaryEntryRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            DeleteGlossaryEntryRequest request = new DeleteGlossaryEntryRequest
            {
                GlossaryEntryName = GlossaryEntryName.FromProjectLocationGlossaryGlossaryEntry("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_ENTRY]"),
            };
            // Make the request
            translationServiceClient.DeleteGlossaryEntry(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryEntryAsync</summary>
        public async Task DeleteGlossaryEntryRequestObjectAsync()
        {
            // Snippet: DeleteGlossaryEntryAsync(DeleteGlossaryEntryRequest, CallSettings)
            // Additional: DeleteGlossaryEntryAsync(DeleteGlossaryEntryRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGlossaryEntryRequest request = new DeleteGlossaryEntryRequest
            {
                GlossaryEntryName = GlossaryEntryName.FromProjectLocationGlossaryGlossaryEntry("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_ENTRY]"),
            };
            // Make the request
            await translationServiceClient.DeleteGlossaryEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryEntry</summary>
        public void DeleteGlossaryEntry()
        {
            // Snippet: DeleteGlossaryEntry(string, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]/glossaryEntries/[GLOSSARY_ENTRY]";
            // Make the request
            translationServiceClient.DeleteGlossaryEntry(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryEntryAsync</summary>
        public async Task DeleteGlossaryEntryAsync()
        {
            // Snippet: DeleteGlossaryEntryAsync(string, CallSettings)
            // Additional: DeleteGlossaryEntryAsync(string, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]/glossaryEntries/[GLOSSARY_ENTRY]";
            // Make the request
            await translationServiceClient.DeleteGlossaryEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryEntry</summary>
        public void DeleteGlossaryEntryResourceNames()
        {
            // Snippet: DeleteGlossaryEntry(GlossaryEntryName, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            GlossaryEntryName name = GlossaryEntryName.FromProjectLocationGlossaryGlossaryEntry("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_ENTRY]");
            // Make the request
            translationServiceClient.DeleteGlossaryEntry(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryEntryAsync</summary>
        public async Task DeleteGlossaryEntryResourceNamesAsync()
        {
            // Snippet: DeleteGlossaryEntryAsync(GlossaryEntryName, CallSettings)
            // Additional: DeleteGlossaryEntryAsync(GlossaryEntryName, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GlossaryEntryName name = GlossaryEntryName.FromProjectLocationGlossaryGlossaryEntry("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_ENTRY]");
            // Make the request
            await translationServiceClient.DeleteGlossaryEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDatasetRequestObject()
        {
            // Snippet: CreateDataset(CreateDatasetRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Dataset = new Dataset(),
            };
            // Make the request
            Operation<Dataset, CreateDatasetMetadata> response = translationServiceClient.CreateDataset(request);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, CreateDatasetMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, CreateDatasetMetadata> retrievedResponse = translationServiceClient.PollOnceCreateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetRequestObjectAsync()
        {
            // Snippet: CreateDatasetAsync(CreateDatasetRequest, CallSettings)
            // Additional: CreateDatasetAsync(CreateDatasetRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Dataset = new Dataset(),
            };
            // Make the request
            Operation<Dataset, CreateDatasetMetadata> response = await translationServiceClient.CreateDatasetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, CreateDatasetMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, CreateDatasetMetadata> retrievedResponse = await translationServiceClient.PollOnceCreateDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDataset()
        {
            // Snippet: CreateDataset(string, Dataset, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Dataset dataset = new Dataset();
            // Make the request
            Operation<Dataset, CreateDatasetMetadata> response = translationServiceClient.CreateDataset(parent, dataset);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, CreateDatasetMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, CreateDatasetMetadata> retrievedResponse = translationServiceClient.PollOnceCreateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetAsync()
        {
            // Snippet: CreateDatasetAsync(string, Dataset, CallSettings)
            // Additional: CreateDatasetAsync(string, Dataset, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Dataset dataset = new Dataset();
            // Make the request
            Operation<Dataset, CreateDatasetMetadata> response = await translationServiceClient.CreateDatasetAsync(parent, dataset);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, CreateDatasetMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, CreateDatasetMetadata> retrievedResponse = await translationServiceClient.PollOnceCreateDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDatasetResourceNames()
        {
            // Snippet: CreateDataset(LocationName, Dataset, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Dataset dataset = new Dataset();
            // Make the request
            Operation<Dataset, CreateDatasetMetadata> response = translationServiceClient.CreateDataset(parent, dataset);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, CreateDatasetMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, CreateDatasetMetadata> retrievedResponse = translationServiceClient.PollOnceCreateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetResourceNamesAsync()
        {
            // Snippet: CreateDatasetAsync(LocationName, Dataset, CallSettings)
            // Additional: CreateDatasetAsync(LocationName, Dataset, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Dataset dataset = new Dataset();
            // Make the request
            Operation<Dataset, CreateDatasetMetadata> response = await translationServiceClient.CreateDatasetAsync(parent, dataset);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, CreateDatasetMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, CreateDatasetMetadata> retrievedResponse = await translationServiceClient.PollOnceCreateDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDatasetRequestObject()
        {
            // Snippet: GetDataset(GetDatasetRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            // Make the request
            Dataset response = translationServiceClient.GetDataset(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetRequestObjectAsync()
        {
            // Snippet: GetDatasetAsync(GetDatasetRequest, CallSettings)
            // Additional: GetDatasetAsync(GetDatasetRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            // Make the request
            Dataset response = await translationServiceClient.GetDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDataset()
        {
            // Snippet: GetDataset(string, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            // Make the request
            Dataset response = translationServiceClient.GetDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetAsync()
        {
            // Snippet: GetDatasetAsync(string, CallSettings)
            // Additional: GetDatasetAsync(string, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            // Make the request
            Dataset response = await translationServiceClient.GetDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDatasetResourceNames()
        {
            // Snippet: GetDataset(DatasetName, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            Dataset response = translationServiceClient.GetDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetResourceNamesAsync()
        {
            // Snippet: GetDatasetAsync(DatasetName, CallSettings)
            // Additional: GetDatasetAsync(DatasetName, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            Dataset response = await translationServiceClient.GetDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDatasets</summary>
        public void ListDatasetsRequestObject()
        {
            // Snippet: ListDatasets(ListDatasetsRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            ListDatasetsRequest request = new ListDatasetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = translationServiceClient.ListDatasets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetsAsync</summary>
        public async Task ListDatasetsRequestObjectAsync()
        {
            // Snippet: ListDatasetsAsync(ListDatasetsRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDatasetsRequest request = new ListDatasetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = translationServiceClient.ListDatasetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Dataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatasetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasets</summary>
        public void ListDatasets()
        {
            // Snippet: ListDatasets(string, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = translationServiceClient.ListDatasets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetsAsync</summary>
        public async Task ListDatasetsAsync()
        {
            // Snippet: ListDatasetsAsync(string, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = translationServiceClient.ListDatasetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Dataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatasetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasets</summary>
        public void ListDatasetsResourceNames()
        {
            // Snippet: ListDatasets(LocationName, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = translationServiceClient.ListDatasets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetsAsync</summary>
        public async Task ListDatasetsResourceNamesAsync()
        {
            // Snippet: ListDatasetsAsync(LocationName, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = translationServiceClient.ListDatasetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Dataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatasetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteDataset</summary>
        public void DeleteDatasetRequestObject()
        {
            // Snippet: DeleteDataset(DeleteDatasetRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            // Make the request
            Operation<Empty, DeleteDatasetMetadata> response = translationServiceClient.DeleteDataset(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteDatasetMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteDatasetMetadata> retrievedResponse = translationServiceClient.PollOnceDeleteDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetRequestObjectAsync()
        {
            // Snippet: DeleteDatasetAsync(DeleteDatasetRequest, CallSettings)
            // Additional: DeleteDatasetAsync(DeleteDatasetRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            // Make the request
            Operation<Empty, DeleteDatasetMetadata> response = await translationServiceClient.DeleteDatasetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteDatasetMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteDatasetMetadata> retrievedResponse = await translationServiceClient.PollOnceDeleteDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataset</summary>
        public void DeleteDataset()
        {
            // Snippet: DeleteDataset(string, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            // Make the request
            Operation<Empty, DeleteDatasetMetadata> response = translationServiceClient.DeleteDataset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteDatasetMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteDatasetMetadata> retrievedResponse = translationServiceClient.PollOnceDeleteDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetAsync()
        {
            // Snippet: DeleteDatasetAsync(string, CallSettings)
            // Additional: DeleteDatasetAsync(string, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            // Make the request
            Operation<Empty, DeleteDatasetMetadata> response = await translationServiceClient.DeleteDatasetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteDatasetMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteDatasetMetadata> retrievedResponse = await translationServiceClient.PollOnceDeleteDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataset</summary>
        public void DeleteDatasetResourceNames()
        {
            // Snippet: DeleteDataset(DatasetName, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            Operation<Empty, DeleteDatasetMetadata> response = translationServiceClient.DeleteDataset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteDatasetMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteDatasetMetadata> retrievedResponse = translationServiceClient.PollOnceDeleteDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetResourceNamesAsync()
        {
            // Snippet: DeleteDatasetAsync(DatasetName, CallSettings)
            // Additional: DeleteDatasetAsync(DatasetName, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            Operation<Empty, DeleteDatasetMetadata> response = await translationServiceClient.DeleteDatasetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteDatasetMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteDatasetMetadata> retrievedResponse = await translationServiceClient.PollOnceDeleteDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAdaptiveMtDataset</summary>
        public void CreateAdaptiveMtDatasetRequestObject()
        {
            // Snippet: CreateAdaptiveMtDataset(CreateAdaptiveMtDatasetRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            CreateAdaptiveMtDatasetRequest request = new CreateAdaptiveMtDatasetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AdaptiveMtDataset = new AdaptiveMtDataset(),
            };
            // Make the request
            AdaptiveMtDataset response = translationServiceClient.CreateAdaptiveMtDataset(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAdaptiveMtDatasetAsync</summary>
        public async Task CreateAdaptiveMtDatasetRequestObjectAsync()
        {
            // Snippet: CreateAdaptiveMtDatasetAsync(CreateAdaptiveMtDatasetRequest, CallSettings)
            // Additional: CreateAdaptiveMtDatasetAsync(CreateAdaptiveMtDatasetRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAdaptiveMtDatasetRequest request = new CreateAdaptiveMtDatasetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AdaptiveMtDataset = new AdaptiveMtDataset(),
            };
            // Make the request
            AdaptiveMtDataset response = await translationServiceClient.CreateAdaptiveMtDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAdaptiveMtDataset</summary>
        public void CreateAdaptiveMtDataset()
        {
            // Snippet: CreateAdaptiveMtDataset(string, AdaptiveMtDataset, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AdaptiveMtDataset adaptiveMtDataset = new AdaptiveMtDataset();
            // Make the request
            AdaptiveMtDataset response = translationServiceClient.CreateAdaptiveMtDataset(parent, adaptiveMtDataset);
            // End snippet
        }

        /// <summary>Snippet for CreateAdaptiveMtDatasetAsync</summary>
        public async Task CreateAdaptiveMtDatasetAsync()
        {
            // Snippet: CreateAdaptiveMtDatasetAsync(string, AdaptiveMtDataset, CallSettings)
            // Additional: CreateAdaptiveMtDatasetAsync(string, AdaptiveMtDataset, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AdaptiveMtDataset adaptiveMtDataset = new AdaptiveMtDataset();
            // Make the request
            AdaptiveMtDataset response = await translationServiceClient.CreateAdaptiveMtDatasetAsync(parent, adaptiveMtDataset);
            // End snippet
        }

        /// <summary>Snippet for CreateAdaptiveMtDataset</summary>
        public void CreateAdaptiveMtDatasetResourceNames()
        {
            // Snippet: CreateAdaptiveMtDataset(LocationName, AdaptiveMtDataset, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AdaptiveMtDataset adaptiveMtDataset = new AdaptiveMtDataset();
            // Make the request
            AdaptiveMtDataset response = translationServiceClient.CreateAdaptiveMtDataset(parent, adaptiveMtDataset);
            // End snippet
        }

        /// <summary>Snippet for CreateAdaptiveMtDatasetAsync</summary>
        public async Task CreateAdaptiveMtDatasetResourceNamesAsync()
        {
            // Snippet: CreateAdaptiveMtDatasetAsync(LocationName, AdaptiveMtDataset, CallSettings)
            // Additional: CreateAdaptiveMtDatasetAsync(LocationName, AdaptiveMtDataset, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AdaptiveMtDataset adaptiveMtDataset = new AdaptiveMtDataset();
            // Make the request
            AdaptiveMtDataset response = await translationServiceClient.CreateAdaptiveMtDatasetAsync(parent, adaptiveMtDataset);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdaptiveMtDataset</summary>
        public void DeleteAdaptiveMtDatasetRequestObject()
        {
            // Snippet: DeleteAdaptiveMtDataset(DeleteAdaptiveMtDatasetRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            DeleteAdaptiveMtDatasetRequest request = new DeleteAdaptiveMtDatasetRequest
            {
                AdaptiveMtDatasetName = AdaptiveMtDatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            // Make the request
            translationServiceClient.DeleteAdaptiveMtDataset(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdaptiveMtDatasetAsync</summary>
        public async Task DeleteAdaptiveMtDatasetRequestObjectAsync()
        {
            // Snippet: DeleteAdaptiveMtDatasetAsync(DeleteAdaptiveMtDatasetRequest, CallSettings)
            // Additional: DeleteAdaptiveMtDatasetAsync(DeleteAdaptiveMtDatasetRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAdaptiveMtDatasetRequest request = new DeleteAdaptiveMtDatasetRequest
            {
                AdaptiveMtDatasetName = AdaptiveMtDatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            // Make the request
            await translationServiceClient.DeleteAdaptiveMtDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdaptiveMtDataset</summary>
        public void DeleteAdaptiveMtDataset()
        {
            // Snippet: DeleteAdaptiveMtDataset(string, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/adaptiveMtDatasets/[DATASET]";
            // Make the request
            translationServiceClient.DeleteAdaptiveMtDataset(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdaptiveMtDatasetAsync</summary>
        public async Task DeleteAdaptiveMtDatasetAsync()
        {
            // Snippet: DeleteAdaptiveMtDatasetAsync(string, CallSettings)
            // Additional: DeleteAdaptiveMtDatasetAsync(string, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/adaptiveMtDatasets/[DATASET]";
            // Make the request
            await translationServiceClient.DeleteAdaptiveMtDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdaptiveMtDataset</summary>
        public void DeleteAdaptiveMtDatasetResourceNames()
        {
            // Snippet: DeleteAdaptiveMtDataset(AdaptiveMtDatasetName, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            AdaptiveMtDatasetName name = AdaptiveMtDatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            translationServiceClient.DeleteAdaptiveMtDataset(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdaptiveMtDatasetAsync</summary>
        public async Task DeleteAdaptiveMtDatasetResourceNamesAsync()
        {
            // Snippet: DeleteAdaptiveMtDatasetAsync(AdaptiveMtDatasetName, CallSettings)
            // Additional: DeleteAdaptiveMtDatasetAsync(AdaptiveMtDatasetName, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdaptiveMtDatasetName name = AdaptiveMtDatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            await translationServiceClient.DeleteAdaptiveMtDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdaptiveMtDataset</summary>
        public void GetAdaptiveMtDatasetRequestObject()
        {
            // Snippet: GetAdaptiveMtDataset(GetAdaptiveMtDatasetRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            GetAdaptiveMtDatasetRequest request = new GetAdaptiveMtDatasetRequest
            {
                AdaptiveMtDatasetName = AdaptiveMtDatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            // Make the request
            AdaptiveMtDataset response = translationServiceClient.GetAdaptiveMtDataset(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdaptiveMtDatasetAsync</summary>
        public async Task GetAdaptiveMtDatasetRequestObjectAsync()
        {
            // Snippet: GetAdaptiveMtDatasetAsync(GetAdaptiveMtDatasetRequest, CallSettings)
            // Additional: GetAdaptiveMtDatasetAsync(GetAdaptiveMtDatasetRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdaptiveMtDatasetRequest request = new GetAdaptiveMtDatasetRequest
            {
                AdaptiveMtDatasetName = AdaptiveMtDatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            // Make the request
            AdaptiveMtDataset response = await translationServiceClient.GetAdaptiveMtDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdaptiveMtDataset</summary>
        public void GetAdaptiveMtDataset()
        {
            // Snippet: GetAdaptiveMtDataset(string, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/adaptiveMtDatasets/[DATASET]";
            // Make the request
            AdaptiveMtDataset response = translationServiceClient.GetAdaptiveMtDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdaptiveMtDatasetAsync</summary>
        public async Task GetAdaptiveMtDatasetAsync()
        {
            // Snippet: GetAdaptiveMtDatasetAsync(string, CallSettings)
            // Additional: GetAdaptiveMtDatasetAsync(string, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/adaptiveMtDatasets/[DATASET]";
            // Make the request
            AdaptiveMtDataset response = await translationServiceClient.GetAdaptiveMtDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdaptiveMtDataset</summary>
        public void GetAdaptiveMtDatasetResourceNames()
        {
            // Snippet: GetAdaptiveMtDataset(AdaptiveMtDatasetName, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            AdaptiveMtDatasetName name = AdaptiveMtDatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            AdaptiveMtDataset response = translationServiceClient.GetAdaptiveMtDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdaptiveMtDatasetAsync</summary>
        public async Task GetAdaptiveMtDatasetResourceNamesAsync()
        {
            // Snippet: GetAdaptiveMtDatasetAsync(AdaptiveMtDatasetName, CallSettings)
            // Additional: GetAdaptiveMtDatasetAsync(AdaptiveMtDatasetName, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdaptiveMtDatasetName name = AdaptiveMtDatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            AdaptiveMtDataset response = await translationServiceClient.GetAdaptiveMtDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAdaptiveMtDatasets</summary>
        public void ListAdaptiveMtDatasetsRequestObject()
        {
            // Snippet: ListAdaptiveMtDatasets(ListAdaptiveMtDatasetsRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            ListAdaptiveMtDatasetsRequest request = new ListAdaptiveMtDatasetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListAdaptiveMtDatasetsResponse, AdaptiveMtDataset> response = translationServiceClient.ListAdaptiveMtDatasets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdaptiveMtDataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdaptiveMtDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdaptiveMtDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdaptiveMtDataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdaptiveMtDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdaptiveMtDatasetsAsync</summary>
        public async Task ListAdaptiveMtDatasetsRequestObjectAsync()
        {
            // Snippet: ListAdaptiveMtDatasetsAsync(ListAdaptiveMtDatasetsRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAdaptiveMtDatasetsRequest request = new ListAdaptiveMtDatasetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAdaptiveMtDatasetsResponse, AdaptiveMtDataset> response = translationServiceClient.ListAdaptiveMtDatasetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdaptiveMtDataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdaptiveMtDatasetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdaptiveMtDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdaptiveMtDataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdaptiveMtDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdaptiveMtDatasets</summary>
        public void ListAdaptiveMtDatasets()
        {
            // Snippet: ListAdaptiveMtDatasets(string, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAdaptiveMtDatasetsResponse, AdaptiveMtDataset> response = translationServiceClient.ListAdaptiveMtDatasets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdaptiveMtDataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdaptiveMtDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdaptiveMtDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdaptiveMtDataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdaptiveMtDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdaptiveMtDatasetsAsync</summary>
        public async Task ListAdaptiveMtDatasetsAsync()
        {
            // Snippet: ListAdaptiveMtDatasetsAsync(string, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAdaptiveMtDatasetsResponse, AdaptiveMtDataset> response = translationServiceClient.ListAdaptiveMtDatasetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdaptiveMtDataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdaptiveMtDatasetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdaptiveMtDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdaptiveMtDataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdaptiveMtDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdaptiveMtDatasets</summary>
        public void ListAdaptiveMtDatasetsResourceNames()
        {
            // Snippet: ListAdaptiveMtDatasets(LocationName, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAdaptiveMtDatasetsResponse, AdaptiveMtDataset> response = translationServiceClient.ListAdaptiveMtDatasets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdaptiveMtDataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdaptiveMtDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdaptiveMtDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdaptiveMtDataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdaptiveMtDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdaptiveMtDatasetsAsync</summary>
        public async Task ListAdaptiveMtDatasetsResourceNamesAsync()
        {
            // Snippet: ListAdaptiveMtDatasetsAsync(LocationName, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAdaptiveMtDatasetsResponse, AdaptiveMtDataset> response = translationServiceClient.ListAdaptiveMtDatasetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdaptiveMtDataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdaptiveMtDatasetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdaptiveMtDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdaptiveMtDataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdaptiveMtDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AdaptiveMtTranslate</summary>
        public void AdaptiveMtTranslateRequestObject()
        {
            // Snippet: AdaptiveMtTranslate(AdaptiveMtTranslateRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            AdaptiveMtTranslateRequest request = new AdaptiveMtTranslateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DatasetAsAdaptiveMtDatasetName = AdaptiveMtDatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                Content = { "", },
                ReferenceSentenceConfig = new AdaptiveMtTranslateRequest.Types.ReferenceSentenceConfig(),
                GlossaryConfig = new AdaptiveMtTranslateRequest.Types.GlossaryConfig(),
            };
            // Make the request
            AdaptiveMtTranslateResponse response = translationServiceClient.AdaptiveMtTranslate(request);
            // End snippet
        }

        /// <summary>Snippet for AdaptiveMtTranslateAsync</summary>
        public async Task AdaptiveMtTranslateRequestObjectAsync()
        {
            // Snippet: AdaptiveMtTranslateAsync(AdaptiveMtTranslateRequest, CallSettings)
            // Additional: AdaptiveMtTranslateAsync(AdaptiveMtTranslateRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdaptiveMtTranslateRequest request = new AdaptiveMtTranslateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DatasetAsAdaptiveMtDatasetName = AdaptiveMtDatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                Content = { "", },
                ReferenceSentenceConfig = new AdaptiveMtTranslateRequest.Types.ReferenceSentenceConfig(),
                GlossaryConfig = new AdaptiveMtTranslateRequest.Types.GlossaryConfig(),
            };
            // Make the request
            AdaptiveMtTranslateResponse response = await translationServiceClient.AdaptiveMtTranslateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AdaptiveMtTranslate</summary>
        public void AdaptiveMtTranslate()
        {
            // Snippet: AdaptiveMtTranslate(string, IEnumerable<string>, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<string> content = new string[] { "", };
            // Make the request
            AdaptiveMtTranslateResponse response = translationServiceClient.AdaptiveMtTranslate(parent, content);
            // End snippet
        }

        /// <summary>Snippet for AdaptiveMtTranslateAsync</summary>
        public async Task AdaptiveMtTranslateAsync()
        {
            // Snippet: AdaptiveMtTranslateAsync(string, IEnumerable<string>, CallSettings)
            // Additional: AdaptiveMtTranslateAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<string> content = new string[] { "", };
            // Make the request
            AdaptiveMtTranslateResponse response = await translationServiceClient.AdaptiveMtTranslateAsync(parent, content);
            // End snippet
        }

        /// <summary>Snippet for AdaptiveMtTranslate</summary>
        public void AdaptiveMtTranslateResourceNames()
        {
            // Snippet: AdaptiveMtTranslate(LocationName, IEnumerable<string>, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<string> content = new string[] { "", };
            // Make the request
            AdaptiveMtTranslateResponse response = translationServiceClient.AdaptiveMtTranslate(parent, content);
            // End snippet
        }

        /// <summary>Snippet for AdaptiveMtTranslateAsync</summary>
        public async Task AdaptiveMtTranslateResourceNamesAsync()
        {
            // Snippet: AdaptiveMtTranslateAsync(LocationName, IEnumerable<string>, CallSettings)
            // Additional: AdaptiveMtTranslateAsync(LocationName, IEnumerable<string>, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<string> content = new string[] { "", };
            // Make the request
            AdaptiveMtTranslateResponse response = await translationServiceClient.AdaptiveMtTranslateAsync(parent, content);
            // End snippet
        }

        /// <summary>Snippet for GetAdaptiveMtFile</summary>
        public void GetAdaptiveMtFileRequestObject()
        {
            // Snippet: GetAdaptiveMtFile(GetAdaptiveMtFileRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            GetAdaptiveMtFileRequest request = new GetAdaptiveMtFileRequest
            {
                AdaptiveMtFileName = AdaptiveMtFileName.FromProjectLocationDatasetFile("[PROJECT]", "[LOCATION]", "[DATASET]", "[FILE]"),
            };
            // Make the request
            AdaptiveMtFile response = translationServiceClient.GetAdaptiveMtFile(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdaptiveMtFileAsync</summary>
        public async Task GetAdaptiveMtFileRequestObjectAsync()
        {
            // Snippet: GetAdaptiveMtFileAsync(GetAdaptiveMtFileRequest, CallSettings)
            // Additional: GetAdaptiveMtFileAsync(GetAdaptiveMtFileRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdaptiveMtFileRequest request = new GetAdaptiveMtFileRequest
            {
                AdaptiveMtFileName = AdaptiveMtFileName.FromProjectLocationDatasetFile("[PROJECT]", "[LOCATION]", "[DATASET]", "[FILE]"),
            };
            // Make the request
            AdaptiveMtFile response = await translationServiceClient.GetAdaptiveMtFileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdaptiveMtFile</summary>
        public void GetAdaptiveMtFile()
        {
            // Snippet: GetAdaptiveMtFile(string, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/adaptiveMtDatasets/[DATASET]/adaptiveMtFiles/[FILE]";
            // Make the request
            AdaptiveMtFile response = translationServiceClient.GetAdaptiveMtFile(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdaptiveMtFileAsync</summary>
        public async Task GetAdaptiveMtFileAsync()
        {
            // Snippet: GetAdaptiveMtFileAsync(string, CallSettings)
            // Additional: GetAdaptiveMtFileAsync(string, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/adaptiveMtDatasets/[DATASET]/adaptiveMtFiles/[FILE]";
            // Make the request
            AdaptiveMtFile response = await translationServiceClient.GetAdaptiveMtFileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdaptiveMtFile</summary>
        public void GetAdaptiveMtFileResourceNames()
        {
            // Snippet: GetAdaptiveMtFile(AdaptiveMtFileName, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            AdaptiveMtFileName name = AdaptiveMtFileName.FromProjectLocationDatasetFile("[PROJECT]", "[LOCATION]", "[DATASET]", "[FILE]");
            // Make the request
            AdaptiveMtFile response = translationServiceClient.GetAdaptiveMtFile(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdaptiveMtFileAsync</summary>
        public async Task GetAdaptiveMtFileResourceNamesAsync()
        {
            // Snippet: GetAdaptiveMtFileAsync(AdaptiveMtFileName, CallSettings)
            // Additional: GetAdaptiveMtFileAsync(AdaptiveMtFileName, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdaptiveMtFileName name = AdaptiveMtFileName.FromProjectLocationDatasetFile("[PROJECT]", "[LOCATION]", "[DATASET]", "[FILE]");
            // Make the request
            AdaptiveMtFile response = await translationServiceClient.GetAdaptiveMtFileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdaptiveMtFile</summary>
        public void DeleteAdaptiveMtFileRequestObject()
        {
            // Snippet: DeleteAdaptiveMtFile(DeleteAdaptiveMtFileRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            DeleteAdaptiveMtFileRequest request = new DeleteAdaptiveMtFileRequest
            {
                AdaptiveMtFileName = AdaptiveMtFileName.FromProjectLocationDatasetFile("[PROJECT]", "[LOCATION]", "[DATASET]", "[FILE]"),
            };
            // Make the request
            translationServiceClient.DeleteAdaptiveMtFile(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdaptiveMtFileAsync</summary>
        public async Task DeleteAdaptiveMtFileRequestObjectAsync()
        {
            // Snippet: DeleteAdaptiveMtFileAsync(DeleteAdaptiveMtFileRequest, CallSettings)
            // Additional: DeleteAdaptiveMtFileAsync(DeleteAdaptiveMtFileRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAdaptiveMtFileRequest request = new DeleteAdaptiveMtFileRequest
            {
                AdaptiveMtFileName = AdaptiveMtFileName.FromProjectLocationDatasetFile("[PROJECT]", "[LOCATION]", "[DATASET]", "[FILE]"),
            };
            // Make the request
            await translationServiceClient.DeleteAdaptiveMtFileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdaptiveMtFile</summary>
        public void DeleteAdaptiveMtFile()
        {
            // Snippet: DeleteAdaptiveMtFile(string, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/adaptiveMtDatasets/[DATASET]/adaptiveMtFiles/[FILE]";
            // Make the request
            translationServiceClient.DeleteAdaptiveMtFile(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdaptiveMtFileAsync</summary>
        public async Task DeleteAdaptiveMtFileAsync()
        {
            // Snippet: DeleteAdaptiveMtFileAsync(string, CallSettings)
            // Additional: DeleteAdaptiveMtFileAsync(string, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/adaptiveMtDatasets/[DATASET]/adaptiveMtFiles/[FILE]";
            // Make the request
            await translationServiceClient.DeleteAdaptiveMtFileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdaptiveMtFile</summary>
        public void DeleteAdaptiveMtFileResourceNames()
        {
            // Snippet: DeleteAdaptiveMtFile(AdaptiveMtFileName, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            AdaptiveMtFileName name = AdaptiveMtFileName.FromProjectLocationDatasetFile("[PROJECT]", "[LOCATION]", "[DATASET]", "[FILE]");
            // Make the request
            translationServiceClient.DeleteAdaptiveMtFile(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdaptiveMtFileAsync</summary>
        public async Task DeleteAdaptiveMtFileResourceNamesAsync()
        {
            // Snippet: DeleteAdaptiveMtFileAsync(AdaptiveMtFileName, CallSettings)
            // Additional: DeleteAdaptiveMtFileAsync(AdaptiveMtFileName, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdaptiveMtFileName name = AdaptiveMtFileName.FromProjectLocationDatasetFile("[PROJECT]", "[LOCATION]", "[DATASET]", "[FILE]");
            // Make the request
            await translationServiceClient.DeleteAdaptiveMtFileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ImportAdaptiveMtFile</summary>
        public void ImportAdaptiveMtFileRequestObject()
        {
            // Snippet: ImportAdaptiveMtFile(ImportAdaptiveMtFileRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            ImportAdaptiveMtFileRequest request = new ImportAdaptiveMtFileRequest
            {
                ParentAsAdaptiveMtDatasetName = AdaptiveMtDatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                FileInputSource = new FileInputSource(),
            };
            // Make the request
            ImportAdaptiveMtFileResponse response = translationServiceClient.ImportAdaptiveMtFile(request);
            // End snippet
        }

        /// <summary>Snippet for ImportAdaptiveMtFileAsync</summary>
        public async Task ImportAdaptiveMtFileRequestObjectAsync()
        {
            // Snippet: ImportAdaptiveMtFileAsync(ImportAdaptiveMtFileRequest, CallSettings)
            // Additional: ImportAdaptiveMtFileAsync(ImportAdaptiveMtFileRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportAdaptiveMtFileRequest request = new ImportAdaptiveMtFileRequest
            {
                ParentAsAdaptiveMtDatasetName = AdaptiveMtDatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                FileInputSource = new FileInputSource(),
            };
            // Make the request
            ImportAdaptiveMtFileResponse response = await translationServiceClient.ImportAdaptiveMtFileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportAdaptiveMtFile</summary>
        public void ImportAdaptiveMtFile()
        {
            // Snippet: ImportAdaptiveMtFile(string, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/adaptiveMtDatasets/[DATASET]";
            // Make the request
            ImportAdaptiveMtFileResponse response = translationServiceClient.ImportAdaptiveMtFile(parent);
            // End snippet
        }

        /// <summary>Snippet for ImportAdaptiveMtFileAsync</summary>
        public async Task ImportAdaptiveMtFileAsync()
        {
            // Snippet: ImportAdaptiveMtFileAsync(string, CallSettings)
            // Additional: ImportAdaptiveMtFileAsync(string, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/adaptiveMtDatasets/[DATASET]";
            // Make the request
            ImportAdaptiveMtFileResponse response = await translationServiceClient.ImportAdaptiveMtFileAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ImportAdaptiveMtFile</summary>
        public void ImportAdaptiveMtFileResourceNames()
        {
            // Snippet: ImportAdaptiveMtFile(AdaptiveMtDatasetName, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            AdaptiveMtDatasetName parent = AdaptiveMtDatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            ImportAdaptiveMtFileResponse response = translationServiceClient.ImportAdaptiveMtFile(parent);
            // End snippet
        }

        /// <summary>Snippet for ImportAdaptiveMtFileAsync</summary>
        public async Task ImportAdaptiveMtFileResourceNamesAsync()
        {
            // Snippet: ImportAdaptiveMtFileAsync(AdaptiveMtDatasetName, CallSettings)
            // Additional: ImportAdaptiveMtFileAsync(AdaptiveMtDatasetName, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdaptiveMtDatasetName parent = AdaptiveMtDatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            ImportAdaptiveMtFileResponse response = await translationServiceClient.ImportAdaptiveMtFileAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListAdaptiveMtFiles</summary>
        public void ListAdaptiveMtFilesRequestObject()
        {
            // Snippet: ListAdaptiveMtFiles(ListAdaptiveMtFilesRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            ListAdaptiveMtFilesRequest request = new ListAdaptiveMtFilesRequest
            {
                ParentAsAdaptiveMtDatasetName = AdaptiveMtDatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            // Make the request
            PagedEnumerable<ListAdaptiveMtFilesResponse, AdaptiveMtFile> response = translationServiceClient.ListAdaptiveMtFiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdaptiveMtFile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdaptiveMtFilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdaptiveMtFile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdaptiveMtFile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdaptiveMtFile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdaptiveMtFilesAsync</summary>
        public async Task ListAdaptiveMtFilesRequestObjectAsync()
        {
            // Snippet: ListAdaptiveMtFilesAsync(ListAdaptiveMtFilesRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAdaptiveMtFilesRequest request = new ListAdaptiveMtFilesRequest
            {
                ParentAsAdaptiveMtDatasetName = AdaptiveMtDatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAdaptiveMtFilesResponse, AdaptiveMtFile> response = translationServiceClient.ListAdaptiveMtFilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdaptiveMtFile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdaptiveMtFilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdaptiveMtFile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdaptiveMtFile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdaptiveMtFile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdaptiveMtFiles</summary>
        public void ListAdaptiveMtFiles()
        {
            // Snippet: ListAdaptiveMtFiles(string, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/adaptiveMtDatasets/[DATASET]";
            // Make the request
            PagedEnumerable<ListAdaptiveMtFilesResponse, AdaptiveMtFile> response = translationServiceClient.ListAdaptiveMtFiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdaptiveMtFile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdaptiveMtFilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdaptiveMtFile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdaptiveMtFile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdaptiveMtFile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdaptiveMtFilesAsync</summary>
        public async Task ListAdaptiveMtFilesAsync()
        {
            // Snippet: ListAdaptiveMtFilesAsync(string, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/adaptiveMtDatasets/[DATASET]";
            // Make the request
            PagedAsyncEnumerable<ListAdaptiveMtFilesResponse, AdaptiveMtFile> response = translationServiceClient.ListAdaptiveMtFilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdaptiveMtFile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdaptiveMtFilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdaptiveMtFile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdaptiveMtFile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdaptiveMtFile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdaptiveMtFiles</summary>
        public void ListAdaptiveMtFilesResourceNames()
        {
            // Snippet: ListAdaptiveMtFiles(AdaptiveMtDatasetName, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            AdaptiveMtDatasetName parent = AdaptiveMtDatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            PagedEnumerable<ListAdaptiveMtFilesResponse, AdaptiveMtFile> response = translationServiceClient.ListAdaptiveMtFiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdaptiveMtFile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdaptiveMtFilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdaptiveMtFile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdaptiveMtFile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdaptiveMtFile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdaptiveMtFilesAsync</summary>
        public async Task ListAdaptiveMtFilesResourceNamesAsync()
        {
            // Snippet: ListAdaptiveMtFilesAsync(AdaptiveMtDatasetName, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdaptiveMtDatasetName parent = AdaptiveMtDatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            PagedAsyncEnumerable<ListAdaptiveMtFilesResponse, AdaptiveMtFile> response = translationServiceClient.ListAdaptiveMtFilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdaptiveMtFile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdaptiveMtFilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdaptiveMtFile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdaptiveMtFile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdaptiveMtFile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdaptiveMtSentences</summary>
        public void ListAdaptiveMtSentencesRequestObject()
        {
            // Snippet: ListAdaptiveMtSentences(ListAdaptiveMtSentencesRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            ListAdaptiveMtSentencesRequest request = new ListAdaptiveMtSentencesRequest
            {
                ParentAsAdaptiveMtFileName = AdaptiveMtFileName.FromProjectLocationDatasetFile("[PROJECT]", "[LOCATION]", "[DATASET]", "[FILE]"),
            };
            // Make the request
            PagedEnumerable<ListAdaptiveMtSentencesResponse, AdaptiveMtSentence> response = translationServiceClient.ListAdaptiveMtSentences(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdaptiveMtSentence item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdaptiveMtSentencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdaptiveMtSentence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdaptiveMtSentence> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdaptiveMtSentence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdaptiveMtSentencesAsync</summary>
        public async Task ListAdaptiveMtSentencesRequestObjectAsync()
        {
            // Snippet: ListAdaptiveMtSentencesAsync(ListAdaptiveMtSentencesRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAdaptiveMtSentencesRequest request = new ListAdaptiveMtSentencesRequest
            {
                ParentAsAdaptiveMtFileName = AdaptiveMtFileName.FromProjectLocationDatasetFile("[PROJECT]", "[LOCATION]", "[DATASET]", "[FILE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAdaptiveMtSentencesResponse, AdaptiveMtSentence> response = translationServiceClient.ListAdaptiveMtSentencesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdaptiveMtSentence item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdaptiveMtSentencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdaptiveMtSentence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdaptiveMtSentence> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdaptiveMtSentence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdaptiveMtSentences</summary>
        public void ListAdaptiveMtSentences()
        {
            // Snippet: ListAdaptiveMtSentences(string, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/adaptiveMtDatasets/[DATASET]/adaptiveMtFiles/[FILE]";
            // Make the request
            PagedEnumerable<ListAdaptiveMtSentencesResponse, AdaptiveMtSentence> response = translationServiceClient.ListAdaptiveMtSentences(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdaptiveMtSentence item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdaptiveMtSentencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdaptiveMtSentence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdaptiveMtSentence> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdaptiveMtSentence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdaptiveMtSentencesAsync</summary>
        public async Task ListAdaptiveMtSentencesAsync()
        {
            // Snippet: ListAdaptiveMtSentencesAsync(string, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/adaptiveMtDatasets/[DATASET]/adaptiveMtFiles/[FILE]";
            // Make the request
            PagedAsyncEnumerable<ListAdaptiveMtSentencesResponse, AdaptiveMtSentence> response = translationServiceClient.ListAdaptiveMtSentencesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdaptiveMtSentence item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdaptiveMtSentencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdaptiveMtSentence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdaptiveMtSentence> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdaptiveMtSentence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdaptiveMtSentences</summary>
        public void ListAdaptiveMtSentencesResourceNames()
        {
            // Snippet: ListAdaptiveMtSentences(AdaptiveMtFileName, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            AdaptiveMtFileName parent = AdaptiveMtFileName.FromProjectLocationDatasetFile("[PROJECT]", "[LOCATION]", "[DATASET]", "[FILE]");
            // Make the request
            PagedEnumerable<ListAdaptiveMtSentencesResponse, AdaptiveMtSentence> response = translationServiceClient.ListAdaptiveMtSentences(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdaptiveMtSentence item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdaptiveMtSentencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdaptiveMtSentence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdaptiveMtSentence> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdaptiveMtSentence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdaptiveMtSentencesAsync</summary>
        public async Task ListAdaptiveMtSentencesResourceNamesAsync()
        {
            // Snippet: ListAdaptiveMtSentencesAsync(AdaptiveMtFileName, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdaptiveMtFileName parent = AdaptiveMtFileName.FromProjectLocationDatasetFile("[PROJECT]", "[LOCATION]", "[DATASET]", "[FILE]");
            // Make the request
            PagedAsyncEnumerable<ListAdaptiveMtSentencesResponse, AdaptiveMtSentence> response = translationServiceClient.ListAdaptiveMtSentencesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdaptiveMtSentence item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdaptiveMtSentencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdaptiveMtSentence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdaptiveMtSentence> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdaptiveMtSentence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ImportData</summary>
        public void ImportDataRequestObject()
        {
            // Snippet: ImportData(ImportDataRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            ImportDataRequest request = new ImportDataRequest
            {
                Dataset = "",
                InputConfig = new DatasetInputConfig(),
            };
            // Make the request
            Operation<Empty, ImportDataMetadata> response = translationServiceClient.ImportData(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ImportDataMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ImportDataMetadata> retrievedResponse = translationServiceClient.PollOnceImportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDataAsync</summary>
        public async Task ImportDataRequestObjectAsync()
        {
            // Snippet: ImportDataAsync(ImportDataRequest, CallSettings)
            // Additional: ImportDataAsync(ImportDataRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportDataRequest request = new ImportDataRequest
            {
                Dataset = "",
                InputConfig = new DatasetInputConfig(),
            };
            // Make the request
            Operation<Empty, ImportDataMetadata> response = await translationServiceClient.ImportDataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ImportDataMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ImportDataMetadata> retrievedResponse = await translationServiceClient.PollOnceImportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportData</summary>
        public void ImportData()
        {
            // Snippet: ImportData(string, DatasetInputConfig, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string dataset = "";
            DatasetInputConfig inputConfig = new DatasetInputConfig();
            // Make the request
            Operation<Empty, ImportDataMetadata> response = translationServiceClient.ImportData(dataset, inputConfig);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ImportDataMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ImportDataMetadata> retrievedResponse = translationServiceClient.PollOnceImportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDataAsync</summary>
        public async Task ImportDataAsync()
        {
            // Snippet: ImportDataAsync(string, DatasetInputConfig, CallSettings)
            // Additional: ImportDataAsync(string, DatasetInputConfig, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string dataset = "";
            DatasetInputConfig inputConfig = new DatasetInputConfig();
            // Make the request
            Operation<Empty, ImportDataMetadata> response = await translationServiceClient.ImportDataAsync(dataset, inputConfig);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ImportDataMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ImportDataMetadata> retrievedResponse = await translationServiceClient.PollOnceImportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportData</summary>
        public void ExportDataRequestObject()
        {
            // Snippet: ExportData(ExportDataRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            ExportDataRequest request = new ExportDataRequest
            {
                Dataset = "",
                OutputConfig = new DatasetOutputConfig(),
            };
            // Make the request
            Operation<Empty, ExportDataMetadata> response = translationServiceClient.ExportData(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ExportDataMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ExportDataMetadata> retrievedResponse = translationServiceClient.PollOnceExportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportDataAsync</summary>
        public async Task ExportDataRequestObjectAsync()
        {
            // Snippet: ExportDataAsync(ExportDataRequest, CallSettings)
            // Additional: ExportDataAsync(ExportDataRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExportDataRequest request = new ExportDataRequest
            {
                Dataset = "",
                OutputConfig = new DatasetOutputConfig(),
            };
            // Make the request
            Operation<Empty, ExportDataMetadata> response = await translationServiceClient.ExportDataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ExportDataMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ExportDataMetadata> retrievedResponse = await translationServiceClient.PollOnceExportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportData</summary>
        public void ExportData()
        {
            // Snippet: ExportData(string, DatasetOutputConfig, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string dataset = "";
            DatasetOutputConfig outputConfig = new DatasetOutputConfig();
            // Make the request
            Operation<Empty, ExportDataMetadata> response = translationServiceClient.ExportData(dataset, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ExportDataMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ExportDataMetadata> retrievedResponse = translationServiceClient.PollOnceExportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportDataAsync</summary>
        public async Task ExportDataAsync()
        {
            // Snippet: ExportDataAsync(string, DatasetOutputConfig, CallSettings)
            // Additional: ExportDataAsync(string, DatasetOutputConfig, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string dataset = "";
            DatasetOutputConfig outputConfig = new DatasetOutputConfig();
            // Make the request
            Operation<Empty, ExportDataMetadata> response = await translationServiceClient.ExportDataAsync(dataset, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ExportDataMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ExportDataMetadata> retrievedResponse = await translationServiceClient.PollOnceExportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListExamples</summary>
        public void ListExamplesRequestObject()
        {
            // Snippet: ListExamples(ListExamplesRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            ListExamplesRequest request = new ListExamplesRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListExamplesResponse, Example> response = translationServiceClient.ListExamples(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamplesAsync</summary>
        public async Task ListExamplesRequestObjectAsync()
        {
            // Snippet: ListExamplesAsync(ListExamplesRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListExamplesRequest request = new ListExamplesRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListExamplesResponse, Example> response = translationServiceClient.ListExamplesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Example item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExamplesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamples</summary>
        public void ListExamples()
        {
            // Snippet: ListExamples(string, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            // Make the request
            PagedEnumerable<ListExamplesResponse, Example> response = translationServiceClient.ListExamples(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamplesAsync</summary>
        public async Task ListExamplesAsync()
        {
            // Snippet: ListExamplesAsync(string, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            // Make the request
            PagedAsyncEnumerable<ListExamplesResponse, Example> response = translationServiceClient.ListExamplesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Example item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExamplesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamples</summary>
        public void ListExamplesResourceNames()
        {
            // Snippet: ListExamples(DatasetName, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            PagedEnumerable<ListExamplesResponse, Example> response = translationServiceClient.ListExamples(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamplesAsync</summary>
        public async Task ListExamplesResourceNamesAsync()
        {
            // Snippet: ListExamplesAsync(DatasetName, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            PagedAsyncEnumerable<ListExamplesResponse, Example> response = translationServiceClient.ListExamplesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Example item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExamplesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateModel</summary>
        public void CreateModelRequestObject()
        {
            // Snippet: CreateModel(CreateModelRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            CreateModelRequest request = new CreateModelRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Model = new Model(),
            };
            // Make the request
            Operation<Model, CreateModelMetadata> response = translationServiceClient.CreateModel(request);

            // Poll until the returned long-running operation is complete
            Operation<Model, CreateModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, CreateModelMetadata> retrievedResponse = translationServiceClient.PollOnceCreateModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModelAsync</summary>
        public async Task CreateModelRequestObjectAsync()
        {
            // Snippet: CreateModelAsync(CreateModelRequest, CallSettings)
            // Additional: CreateModelAsync(CreateModelRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateModelRequest request = new CreateModelRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Model = new Model(),
            };
            // Make the request
            Operation<Model, CreateModelMetadata> response = await translationServiceClient.CreateModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Model, CreateModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, CreateModelMetadata> retrievedResponse = await translationServiceClient.PollOnceCreateModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModel</summary>
        public void CreateModel()
        {
            // Snippet: CreateModel(string, Model, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Model model = new Model();
            // Make the request
            Operation<Model, CreateModelMetadata> response = translationServiceClient.CreateModel(parent, model);

            // Poll until the returned long-running operation is complete
            Operation<Model, CreateModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, CreateModelMetadata> retrievedResponse = translationServiceClient.PollOnceCreateModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModelAsync</summary>
        public async Task CreateModelAsync()
        {
            // Snippet: CreateModelAsync(string, Model, CallSettings)
            // Additional: CreateModelAsync(string, Model, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Model model = new Model();
            // Make the request
            Operation<Model, CreateModelMetadata> response = await translationServiceClient.CreateModelAsync(parent, model);

            // Poll until the returned long-running operation is complete
            Operation<Model, CreateModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, CreateModelMetadata> retrievedResponse = await translationServiceClient.PollOnceCreateModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModel</summary>
        public void CreateModelResourceNames()
        {
            // Snippet: CreateModel(LocationName, Model, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Model model = new Model();
            // Make the request
            Operation<Model, CreateModelMetadata> response = translationServiceClient.CreateModel(parent, model);

            // Poll until the returned long-running operation is complete
            Operation<Model, CreateModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, CreateModelMetadata> retrievedResponse = translationServiceClient.PollOnceCreateModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModelAsync</summary>
        public async Task CreateModelResourceNamesAsync()
        {
            // Snippet: CreateModelAsync(LocationName, Model, CallSettings)
            // Additional: CreateModelAsync(LocationName, Model, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Model model = new Model();
            // Make the request
            Operation<Model, CreateModelMetadata> response = await translationServiceClient.CreateModelAsync(parent, model);

            // Poll until the returned long-running operation is complete
            Operation<Model, CreateModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, CreateModelMetadata> retrievedResponse = await translationServiceClient.PollOnceCreateModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListModels</summary>
        public void ListModelsRequestObject()
        {
            // Snippet: ListModels(ListModelsRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            ListModelsRequest request = new ListModelsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListModelsResponse, Model> response = translationServiceClient.ListModels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Model item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelsAsync</summary>
        public async Task ListModelsRequestObjectAsync()
        {
            // Snippet: ListModelsAsync(ListModelsRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListModelsRequest request = new ListModelsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListModelsResponse, Model> response = translationServiceClient.ListModelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Model item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModels</summary>
        public void ListModels()
        {
            // Snippet: ListModels(string, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListModelsResponse, Model> response = translationServiceClient.ListModels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Model item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelsAsync</summary>
        public async Task ListModelsAsync()
        {
            // Snippet: ListModelsAsync(string, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListModelsResponse, Model> response = translationServiceClient.ListModelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Model item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModels</summary>
        public void ListModelsResourceNames()
        {
            // Snippet: ListModels(LocationName, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListModelsResponse, Model> response = translationServiceClient.ListModels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Model item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelsAsync</summary>
        public async Task ListModelsResourceNamesAsync()
        {
            // Snippet: ListModelsAsync(LocationName, string, int?, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListModelsResponse, Model> response = translationServiceClient.ListModelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Model item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetModel</summary>
        public void GetModelRequestObject()
        {
            // Snippet: GetModel(GetModelRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            GetModelRequest request = new GetModelRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            // Make the request
            Model response = translationServiceClient.GetModel(request);
            // End snippet
        }

        /// <summary>Snippet for GetModelAsync</summary>
        public async Task GetModelRequestObjectAsync()
        {
            // Snippet: GetModelAsync(GetModelRequest, CallSettings)
            // Additional: GetModelAsync(GetModelRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetModelRequest request = new GetModelRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            // Make the request
            Model response = await translationServiceClient.GetModelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetModel</summary>
        public void GetModel()
        {
            // Snippet: GetModel(string, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]";
            // Make the request
            Model response = translationServiceClient.GetModel(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelAsync</summary>
        public async Task GetModelAsync()
        {
            // Snippet: GetModelAsync(string, CallSettings)
            // Additional: GetModelAsync(string, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]";
            // Make the request
            Model response = await translationServiceClient.GetModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetModel</summary>
        public void GetModelResourceNames()
        {
            // Snippet: GetModel(ModelName, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]");
            // Make the request
            Model response = translationServiceClient.GetModel(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelAsync</summary>
        public async Task GetModelResourceNamesAsync()
        {
            // Snippet: GetModelAsync(ModelName, CallSettings)
            // Additional: GetModelAsync(ModelName, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]");
            // Make the request
            Model response = await translationServiceClient.GetModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteModel</summary>
        public void DeleteModelRequestObject()
        {
            // Snippet: DeleteModel(DeleteModelRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            DeleteModelRequest request = new DeleteModelRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            // Make the request
            Operation<Empty, DeleteModelMetadata> response = translationServiceClient.DeleteModel(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteModelMetadata> retrievedResponse = translationServiceClient.PollOnceDeleteModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelAsync</summary>
        public async Task DeleteModelRequestObjectAsync()
        {
            // Snippet: DeleteModelAsync(DeleteModelRequest, CallSettings)
            // Additional: DeleteModelAsync(DeleteModelRequest, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteModelRequest request = new DeleteModelRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            // Make the request
            Operation<Empty, DeleteModelMetadata> response = await translationServiceClient.DeleteModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteModelMetadata> retrievedResponse = await translationServiceClient.PollOnceDeleteModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModel</summary>
        public void DeleteModel()
        {
            // Snippet: DeleteModel(string, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]";
            // Make the request
            Operation<Empty, DeleteModelMetadata> response = translationServiceClient.DeleteModel(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteModelMetadata> retrievedResponse = translationServiceClient.PollOnceDeleteModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelAsync</summary>
        public async Task DeleteModelAsync()
        {
            // Snippet: DeleteModelAsync(string, CallSettings)
            // Additional: DeleteModelAsync(string, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]";
            // Make the request
            Operation<Empty, DeleteModelMetadata> response = await translationServiceClient.DeleteModelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteModelMetadata> retrievedResponse = await translationServiceClient.PollOnceDeleteModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModel</summary>
        public void DeleteModelResourceNames()
        {
            // Snippet: DeleteModel(ModelName, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]");
            // Make the request
            Operation<Empty, DeleteModelMetadata> response = translationServiceClient.DeleteModel(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteModelMetadata> retrievedResponse = translationServiceClient.PollOnceDeleteModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelAsync</summary>
        public async Task DeleteModelResourceNamesAsync()
        {
            // Snippet: DeleteModelAsync(ModelName, CallSettings)
            // Additional: DeleteModelAsync(ModelName, CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]");
            // Make the request
            Operation<Empty, DeleteModelMetadata> response = await translationServiceClient.DeleteModelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteModelMetadata> retrievedResponse = await translationServiceClient.PollOnceDeleteModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
