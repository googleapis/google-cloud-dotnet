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

namespace Google.Cloud.Translate.V3.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Translate.V3;
    using Google.LongRunning;
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
    public class GeneratedTranslationServiceClientSnippets
    {
        /// <summary>Snippet for TranslateTextAsync</summary>
        public async Task TranslateTextAsync_RequestObject()
        {
            // Snippet: TranslateTextAsync(TranslateTextRequest,CallSettings)
            // Additional: TranslateTextAsync(TranslateTextRequest,CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            TranslateTextRequest request = new TranslateTextRequest
            {
                Contents = { },
                TargetLanguageCode = "",
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            // Make the request
            TranslateTextResponse response = await translationServiceClient.TranslateTextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TranslateText</summary>
        public void TranslateText_RequestObject()
        {
            // Snippet: TranslateText(TranslateTextRequest,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            TranslateTextRequest request = new TranslateTextRequest
            {
                Contents = { },
                TargetLanguageCode = "",
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            // Make the request
            TranslateTextResponse response = translationServiceClient.TranslateText(request);
            // End snippet
        }

        /// <summary>Snippet for DetectLanguageAsync</summary>
        public async Task DetectLanguageAsync()
        {
            // Snippet: DetectLanguageAsync(string,string,string,IDictionary<string, string>,CallSettings)
            // Additional: DetectLanguageAsync(string,string,string,IDictionary<string, string>,CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            string model = "";
            string mimeType = "";
            IDictionary<string, string> labels = new Dictionary<string, string>();
            // Make the request
            DetectLanguageResponse response = await translationServiceClient.DetectLanguageAsync(formattedParent, model, mimeType, labels);
            // End snippet
        }

        /// <summary>Snippet for DetectLanguage</summary>
        public void DetectLanguage()
        {
            // Snippet: DetectLanguage(string,string,string,IDictionary<string, string>,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            string model = "";
            string mimeType = "";
            IDictionary<string, string> labels = new Dictionary<string, string>();
            // Make the request
            DetectLanguageResponse response = translationServiceClient.DetectLanguage(formattedParent, model, mimeType, labels);
            // End snippet
        }

        /// <summary>Snippet for DetectLanguageAsync</summary>
        public async Task DetectLanguageAsync_RequestObject()
        {
            // Snippet: DetectLanguageAsync(DetectLanguageRequest,CallSettings)
            // Additional: DetectLanguageAsync(DetectLanguageRequest,CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DetectLanguageRequest request = new DetectLanguageRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            // Make the request
            DetectLanguageResponse response = await translationServiceClient.DetectLanguageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DetectLanguage</summary>
        public void DetectLanguage_RequestObject()
        {
            // Snippet: DetectLanguage(DetectLanguageRequest,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            DetectLanguageRequest request = new DetectLanguageRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            // Make the request
            DetectLanguageResponse response = translationServiceClient.DetectLanguage(request);
            // End snippet
        }

        /// <summary>Snippet for GetSupportedLanguagesAsync</summary>
        public async Task GetSupportedLanguagesAsync()
        {
            // Snippet: GetSupportedLanguagesAsync(string,string,string,CallSettings)
            // Additional: GetSupportedLanguagesAsync(string,string,string,CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            string displayLanguageCode = "";
            string model = "";
            // Make the request
            SupportedLanguages response = await translationServiceClient.GetSupportedLanguagesAsync(formattedParent, displayLanguageCode, model);
            // End snippet
        }

        /// <summary>Snippet for GetSupportedLanguages</summary>
        public void GetSupportedLanguages()
        {
            // Snippet: GetSupportedLanguages(string,string,string,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            string displayLanguageCode = "";
            string model = "";
            // Make the request
            SupportedLanguages response = translationServiceClient.GetSupportedLanguages(formattedParent, displayLanguageCode, model);
            // End snippet
        }

        /// <summary>Snippet for GetSupportedLanguagesAsync</summary>
        public async Task GetSupportedLanguagesAsync_RequestObject()
        {
            // Snippet: GetSupportedLanguagesAsync(GetSupportedLanguagesRequest,CallSettings)
            // Additional: GetSupportedLanguagesAsync(GetSupportedLanguagesRequest,CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSupportedLanguagesRequest request = new GetSupportedLanguagesRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            // Make the request
            SupportedLanguages response = await translationServiceClient.GetSupportedLanguagesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSupportedLanguages</summary>
        public void GetSupportedLanguages_RequestObject()
        {
            // Snippet: GetSupportedLanguages(GetSupportedLanguagesRequest,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            GetSupportedLanguagesRequest request = new GetSupportedLanguagesRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            // Make the request
            SupportedLanguages response = translationServiceClient.GetSupportedLanguages(request);
            // End snippet
        }

        /// <summary>Snippet for BatchTranslateTextAsync</summary>
        public async Task BatchTranslateTextAsync_RequestObject()
        {
            // Snippet: BatchTranslateTextAsync(BatchTranslateTextRequest,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchTranslateTextRequest request = new BatchTranslateTextRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                SourceLanguageCode = "",
                TargetLanguageCodes = { },
                InputConfigs = { },
                OutputConfig = new OutputConfig(),
            };
            // Make the request
            Operation<BatchTranslateResponse, BatchTranslateMetadata> response =
                await translationServiceClient.BatchTranslateTextAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchTranslateResponse, BatchTranslateMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchTranslateResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchTranslateResponse, BatchTranslateMetadata> retrievedResponse =
                await translationServiceClient.PollOnceBatchTranslateTextAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchTranslateResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchTranslateText</summary>
        public void BatchTranslateText_RequestObject()
        {
            // Snippet: BatchTranslateText(BatchTranslateTextRequest,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            BatchTranslateTextRequest request = new BatchTranslateTextRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                SourceLanguageCode = "",
                TargetLanguageCodes = { },
                InputConfigs = { },
                OutputConfig = new OutputConfig(),
            };
            // Make the request
            Operation<BatchTranslateResponse, BatchTranslateMetadata> response =
                translationServiceClient.BatchTranslateText(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchTranslateResponse, BatchTranslateMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            BatchTranslateResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchTranslateResponse, BatchTranslateMetadata> retrievedResponse =
                translationServiceClient.PollOnceBatchTranslateText(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchTranslateResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryAsync</summary>
        public async Task CreateGlossaryAsync()
        {
            // Snippet: CreateGlossaryAsync(string,Glossary,CallSettings)
            // Additional: CreateGlossaryAsync(string,Glossary,CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            Glossary glossary = new Glossary();
            // Make the request
            Operation<Glossary, CreateGlossaryMetadata> response =
                await translationServiceClient.CreateGlossaryAsync(formattedParent, glossary);

            // Poll until the returned long-running operation is complete
            Operation<Glossary, CreateGlossaryMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Glossary, CreateGlossaryMetadata> retrievedResponse =
                await translationServiceClient.PollOnceCreateGlossaryAsync(operationName);
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
            // Snippet: CreateGlossary(string,Glossary,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            Glossary glossary = new Glossary();
            // Make the request
            Operation<Glossary, CreateGlossaryMetadata> response =
                translationServiceClient.CreateGlossary(formattedParent, glossary);

            // Poll until the returned long-running operation is complete
            Operation<Glossary, CreateGlossaryMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Glossary, CreateGlossaryMetadata> retrievedResponse =
                translationServiceClient.PollOnceCreateGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryAsync</summary>
        public async Task CreateGlossaryAsync_RequestObject()
        {
            // Snippet: CreateGlossaryAsync(CreateGlossaryRequest,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateGlossaryRequest request = new CreateGlossaryRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                Glossary = new Glossary(),
            };
            // Make the request
            Operation<Glossary, CreateGlossaryMetadata> response =
                await translationServiceClient.CreateGlossaryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Glossary, CreateGlossaryMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Glossary, CreateGlossaryMetadata> retrievedResponse =
                await translationServiceClient.PollOnceCreateGlossaryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGlossary</summary>
        public void CreateGlossary_RequestObject()
        {
            // Snippet: CreateGlossary(CreateGlossaryRequest,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            CreateGlossaryRequest request = new CreateGlossaryRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                Glossary = new Glossary(),
            };
            // Make the request
            Operation<Glossary, CreateGlossaryMetadata> response =
                translationServiceClient.CreateGlossary(request);

            // Poll until the returned long-running operation is complete
            Operation<Glossary, CreateGlossaryMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Glossary, CreateGlossaryMetadata> retrievedResponse =
                translationServiceClient.PollOnceCreateGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListGlossariesAsync</summary>
        public async Task ListGlossariesAsync()
        {
            // Snippet: ListGlossariesAsync(string,string,string,int?,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListGlossariesResponse, Glossary> response =
                translationServiceClient.ListGlossariesAsync(formattedParent, filter);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaries</summary>
        public void ListGlossaries()
        {
            // Snippet: ListGlossaries(string,string,string,int?,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            string filter = "";
            // Make the request
            PagedEnumerable<ListGlossariesResponse, Glossary> response =
                translationServiceClient.ListGlossaries(formattedParent, filter);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossariesAsync</summary>
        public async Task ListGlossariesAsync_RequestObject()
        {
            // Snippet: ListGlossariesAsync(ListGlossariesRequest,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListGlossariesRequest request = new ListGlossariesRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            // Make the request
            PagedAsyncEnumerable<ListGlossariesResponse, Glossary> response =
                translationServiceClient.ListGlossariesAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaries</summary>
        public void ListGlossaries_RequestObject()
        {
            // Snippet: ListGlossaries(ListGlossariesRequest,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            ListGlossariesRequest request = new ListGlossariesRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            // Make the request
            PagedEnumerable<ListGlossariesResponse, Glossary> response =
                translationServiceClient.ListGlossaries(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryAsync</summary>
        public async Task GetGlossaryAsync()
        {
            // Snippet: GetGlossaryAsync(string,CallSettings)
            // Additional: GetGlossaryAsync(string,CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]").ToString();
            // Make the request
            Glossary response = await translationServiceClient.GetGlossaryAsync(formattedName);
            // End snippet
        }

        /// <summary>Snippet for GetGlossary</summary>
        public void GetGlossary()
        {
            // Snippet: GetGlossary(string,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]").ToString();
            // Make the request
            Glossary response = translationServiceClient.GetGlossary(formattedName);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryAsync</summary>
        public async Task GetGlossaryAsync_RequestObject()
        {
            // Snippet: GetGlossaryAsync(GetGlossaryRequest,CallSettings)
            // Additional: GetGlossaryAsync(GetGlossaryRequest,CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGlossaryRequest request = new GetGlossaryRequest
            {
                Name = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]").ToString(),
            };
            // Make the request
            Glossary response = await translationServiceClient.GetGlossaryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGlossary</summary>
        public void GetGlossary_RequestObject()
        {
            // Snippet: GetGlossary(GetGlossaryRequest,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            GetGlossaryRequest request = new GetGlossaryRequest
            {
                Name = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]").ToString(),
            };
            // Make the request
            Glossary response = translationServiceClient.GetGlossary(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryAsync</summary>
        public async Task DeleteGlossaryAsync()
        {
            // Snippet: DeleteGlossaryAsync(string,CallSettings)
            // Additional: DeleteGlossaryAsync(string,CancellationToken)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]").ToString();
            // Make the request
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> response =
                await translationServiceClient.DeleteGlossaryAsync(formattedName);

            // Poll until the returned long-running operation is complete
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeleteGlossaryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> retrievedResponse =
                await translationServiceClient.PollOnceDeleteGlossaryAsync(operationName);
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
            // Snippet: DeleteGlossary(string,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]").ToString();
            // Make the request
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> response =
                translationServiceClient.DeleteGlossary(formattedName);

            // Poll until the returned long-running operation is complete
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            DeleteGlossaryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> retrievedResponse =
                translationServiceClient.PollOnceDeleteGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeleteGlossaryResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryAsync</summary>
        public async Task DeleteGlossaryAsync_RequestObject()
        {
            // Snippet: DeleteGlossaryAsync(DeleteGlossaryRequest,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGlossaryRequest request = new DeleteGlossaryRequest
            {
                Name = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]").ToString(),
            };
            // Make the request
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> response =
                await translationServiceClient.DeleteGlossaryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeleteGlossaryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> retrievedResponse =
                await translationServiceClient.PollOnceDeleteGlossaryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeleteGlossaryResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossary</summary>
        public void DeleteGlossary_RequestObject()
        {
            // Snippet: DeleteGlossary(DeleteGlossaryRequest,CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            DeleteGlossaryRequest request = new DeleteGlossaryRequest
            {
                Name = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]").ToString(),
            };
            // Make the request
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> response =
                translationServiceClient.DeleteGlossary(request);

            // Poll until the returned long-running operation is complete
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            DeleteGlossaryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> retrievedResponse =
                translationServiceClient.PollOnceDeleteGlossary(operationName);
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
