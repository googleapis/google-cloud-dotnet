// Copyright 2022 Google LLC
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

namespace Google.Cloud.Translate.V3.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
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
    }
}
