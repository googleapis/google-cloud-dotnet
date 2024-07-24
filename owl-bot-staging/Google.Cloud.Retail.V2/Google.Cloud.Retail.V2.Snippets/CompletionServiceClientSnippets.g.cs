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
    using Google.Cloud.Retail.V2;
    using Google.LongRunning;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCompletionServiceClientSnippets
    {
        /// <summary>Snippet for CompleteQuery</summary>
        public void CompleteQueryRequestObject()
        {
            // Snippet: CompleteQuery(CompleteQueryRequest, CallSettings)
            // Create client
            CompletionServiceClient completionServiceClient = CompletionServiceClient.Create();
            // Initialize request argument(s)
            CompleteQueryRequest request = new CompleteQueryRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Query = "",
                LanguageCodes = { "", },
                DeviceType = "",
                MaxSuggestions = 0,
                Dataset = "",
                VisitorId = "",
                EnableAttributeSuggestions = false,
                Entity = "",
            };
            // Make the request
            CompleteQueryResponse response = completionServiceClient.CompleteQuery(request);
            // End snippet
        }

        /// <summary>Snippet for CompleteQueryAsync</summary>
        public async Task CompleteQueryRequestObjectAsync()
        {
            // Snippet: CompleteQueryAsync(CompleteQueryRequest, CallSettings)
            // Additional: CompleteQueryAsync(CompleteQueryRequest, CancellationToken)
            // Create client
            CompletionServiceClient completionServiceClient = await CompletionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CompleteQueryRequest request = new CompleteQueryRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Query = "",
                LanguageCodes = { "", },
                DeviceType = "",
                MaxSuggestions = 0,
                Dataset = "",
                VisitorId = "",
                EnableAttributeSuggestions = false,
                Entity = "",
            };
            // Make the request
            CompleteQueryResponse response = await completionServiceClient.CompleteQueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportCompletionData</summary>
        public void ImportCompletionDataRequestObject()
        {
            // Snippet: ImportCompletionData(ImportCompletionDataRequest, CallSettings)
            // Create client
            CompletionServiceClient completionServiceClient = CompletionServiceClient.Create();
            // Initialize request argument(s)
            ImportCompletionDataRequest request = new ImportCompletionDataRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                InputConfig = new CompletionDataInputConfig(),
                NotificationPubsubTopic = "",
            };
            // Make the request
            Operation<ImportCompletionDataResponse, ImportMetadata> response = completionServiceClient.ImportCompletionData(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportCompletionDataResponse, ImportMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportCompletionDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportCompletionDataResponse, ImportMetadata> retrievedResponse = completionServiceClient.PollOnceImportCompletionData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportCompletionDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportCompletionDataAsync</summary>
        public async Task ImportCompletionDataRequestObjectAsync()
        {
            // Snippet: ImportCompletionDataAsync(ImportCompletionDataRequest, CallSettings)
            // Additional: ImportCompletionDataAsync(ImportCompletionDataRequest, CancellationToken)
            // Create client
            CompletionServiceClient completionServiceClient = await CompletionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportCompletionDataRequest request = new ImportCompletionDataRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                InputConfig = new CompletionDataInputConfig(),
                NotificationPubsubTopic = "",
            };
            // Make the request
            Operation<ImportCompletionDataResponse, ImportMetadata> response = await completionServiceClient.ImportCompletionDataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportCompletionDataResponse, ImportMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportCompletionDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportCompletionDataResponse, ImportMetadata> retrievedResponse = await completionServiceClient.PollOnceImportCompletionDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportCompletionDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
