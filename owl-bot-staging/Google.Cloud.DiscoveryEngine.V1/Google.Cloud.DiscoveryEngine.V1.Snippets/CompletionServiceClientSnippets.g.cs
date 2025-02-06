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
    using Google.Cloud.DiscoveryEngine.V1;
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
                DataStoreAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Query = "",
                QueryModel = "",
                UserPseudoId = "",
                IncludeTailSuggestions = false,
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
                DataStoreAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Query = "",
                QueryModel = "",
                UserPseudoId = "",
                IncludeTailSuggestions = false,
            };
            // Make the request
            CompleteQueryResponse response = await completionServiceClient.CompleteQueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportSuggestionDenyListEntries</summary>
        public void ImportSuggestionDenyListEntriesRequestObject()
        {
            // Snippet: ImportSuggestionDenyListEntries(ImportSuggestionDenyListEntriesRequest, CallSettings)
            // Create client
            CompletionServiceClient completionServiceClient = CompletionServiceClient.Create();
            // Initialize request argument(s)
            ImportSuggestionDenyListEntriesRequest request = new ImportSuggestionDenyListEntriesRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                InlineSource = new ImportSuggestionDenyListEntriesRequest.Types.InlineSource(),
            };
            // Make the request
            Operation<ImportSuggestionDenyListEntriesResponse, ImportSuggestionDenyListEntriesMetadata> response = completionServiceClient.ImportSuggestionDenyListEntries(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportSuggestionDenyListEntriesResponse, ImportSuggestionDenyListEntriesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportSuggestionDenyListEntriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportSuggestionDenyListEntriesResponse, ImportSuggestionDenyListEntriesMetadata> retrievedResponse = completionServiceClient.PollOnceImportSuggestionDenyListEntries(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportSuggestionDenyListEntriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportSuggestionDenyListEntriesAsync</summary>
        public async Task ImportSuggestionDenyListEntriesRequestObjectAsync()
        {
            // Snippet: ImportSuggestionDenyListEntriesAsync(ImportSuggestionDenyListEntriesRequest, CallSettings)
            // Additional: ImportSuggestionDenyListEntriesAsync(ImportSuggestionDenyListEntriesRequest, CancellationToken)
            // Create client
            CompletionServiceClient completionServiceClient = await CompletionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportSuggestionDenyListEntriesRequest request = new ImportSuggestionDenyListEntriesRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                InlineSource = new ImportSuggestionDenyListEntriesRequest.Types.InlineSource(),
            };
            // Make the request
            Operation<ImportSuggestionDenyListEntriesResponse, ImportSuggestionDenyListEntriesMetadata> response = await completionServiceClient.ImportSuggestionDenyListEntriesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportSuggestionDenyListEntriesResponse, ImportSuggestionDenyListEntriesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportSuggestionDenyListEntriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportSuggestionDenyListEntriesResponse, ImportSuggestionDenyListEntriesMetadata> retrievedResponse = await completionServiceClient.PollOnceImportSuggestionDenyListEntriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportSuggestionDenyListEntriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeSuggestionDenyListEntries</summary>
        public void PurgeSuggestionDenyListEntriesRequestObject()
        {
            // Snippet: PurgeSuggestionDenyListEntries(PurgeSuggestionDenyListEntriesRequest, CallSettings)
            // Create client
            CompletionServiceClient completionServiceClient = CompletionServiceClient.Create();
            // Initialize request argument(s)
            PurgeSuggestionDenyListEntriesRequest request = new PurgeSuggestionDenyListEntriesRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            Operation<PurgeSuggestionDenyListEntriesResponse, PurgeSuggestionDenyListEntriesMetadata> response = completionServiceClient.PurgeSuggestionDenyListEntries(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeSuggestionDenyListEntriesResponse, PurgeSuggestionDenyListEntriesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeSuggestionDenyListEntriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeSuggestionDenyListEntriesResponse, PurgeSuggestionDenyListEntriesMetadata> retrievedResponse = completionServiceClient.PollOncePurgeSuggestionDenyListEntries(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeSuggestionDenyListEntriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeSuggestionDenyListEntriesAsync</summary>
        public async Task PurgeSuggestionDenyListEntriesRequestObjectAsync()
        {
            // Snippet: PurgeSuggestionDenyListEntriesAsync(PurgeSuggestionDenyListEntriesRequest, CallSettings)
            // Additional: PurgeSuggestionDenyListEntriesAsync(PurgeSuggestionDenyListEntriesRequest, CancellationToken)
            // Create client
            CompletionServiceClient completionServiceClient = await CompletionServiceClient.CreateAsync();
            // Initialize request argument(s)
            PurgeSuggestionDenyListEntriesRequest request = new PurgeSuggestionDenyListEntriesRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            Operation<PurgeSuggestionDenyListEntriesResponse, PurgeSuggestionDenyListEntriesMetadata> response = await completionServiceClient.PurgeSuggestionDenyListEntriesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeSuggestionDenyListEntriesResponse, PurgeSuggestionDenyListEntriesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeSuggestionDenyListEntriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeSuggestionDenyListEntriesResponse, PurgeSuggestionDenyListEntriesMetadata> retrievedResponse = await completionServiceClient.PollOncePurgeSuggestionDenyListEntriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeSuggestionDenyListEntriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportCompletionSuggestions</summary>
        public void ImportCompletionSuggestionsRequestObject()
        {
            // Snippet: ImportCompletionSuggestions(ImportCompletionSuggestionsRequest, CallSettings)
            // Create client
            CompletionServiceClient completionServiceClient = CompletionServiceClient.Create();
            // Initialize request argument(s)
            ImportCompletionSuggestionsRequest request = new ImportCompletionSuggestionsRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                InlineSource = new ImportCompletionSuggestionsRequest.Types.InlineSource(),
                ErrorConfig = new ImportErrorConfig(),
            };
            // Make the request
            Operation<ImportCompletionSuggestionsResponse, ImportCompletionSuggestionsMetadata> response = completionServiceClient.ImportCompletionSuggestions(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportCompletionSuggestionsResponse, ImportCompletionSuggestionsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportCompletionSuggestionsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportCompletionSuggestionsResponse, ImportCompletionSuggestionsMetadata> retrievedResponse = completionServiceClient.PollOnceImportCompletionSuggestions(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportCompletionSuggestionsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportCompletionSuggestionsAsync</summary>
        public async Task ImportCompletionSuggestionsRequestObjectAsync()
        {
            // Snippet: ImportCompletionSuggestionsAsync(ImportCompletionSuggestionsRequest, CallSettings)
            // Additional: ImportCompletionSuggestionsAsync(ImportCompletionSuggestionsRequest, CancellationToken)
            // Create client
            CompletionServiceClient completionServiceClient = await CompletionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportCompletionSuggestionsRequest request = new ImportCompletionSuggestionsRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                InlineSource = new ImportCompletionSuggestionsRequest.Types.InlineSource(),
                ErrorConfig = new ImportErrorConfig(),
            };
            // Make the request
            Operation<ImportCompletionSuggestionsResponse, ImportCompletionSuggestionsMetadata> response = await completionServiceClient.ImportCompletionSuggestionsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportCompletionSuggestionsResponse, ImportCompletionSuggestionsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportCompletionSuggestionsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportCompletionSuggestionsResponse, ImportCompletionSuggestionsMetadata> retrievedResponse = await completionServiceClient.PollOnceImportCompletionSuggestionsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportCompletionSuggestionsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeCompletionSuggestions</summary>
        public void PurgeCompletionSuggestionsRequestObject()
        {
            // Snippet: PurgeCompletionSuggestions(PurgeCompletionSuggestionsRequest, CallSettings)
            // Create client
            CompletionServiceClient completionServiceClient = CompletionServiceClient.Create();
            // Initialize request argument(s)
            PurgeCompletionSuggestionsRequest request = new PurgeCompletionSuggestionsRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            Operation<PurgeCompletionSuggestionsResponse, PurgeCompletionSuggestionsMetadata> response = completionServiceClient.PurgeCompletionSuggestions(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeCompletionSuggestionsResponse, PurgeCompletionSuggestionsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeCompletionSuggestionsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeCompletionSuggestionsResponse, PurgeCompletionSuggestionsMetadata> retrievedResponse = completionServiceClient.PollOncePurgeCompletionSuggestions(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeCompletionSuggestionsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeCompletionSuggestionsAsync</summary>
        public async Task PurgeCompletionSuggestionsRequestObjectAsync()
        {
            // Snippet: PurgeCompletionSuggestionsAsync(PurgeCompletionSuggestionsRequest, CallSettings)
            // Additional: PurgeCompletionSuggestionsAsync(PurgeCompletionSuggestionsRequest, CancellationToken)
            // Create client
            CompletionServiceClient completionServiceClient = await CompletionServiceClient.CreateAsync();
            // Initialize request argument(s)
            PurgeCompletionSuggestionsRequest request = new PurgeCompletionSuggestionsRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            Operation<PurgeCompletionSuggestionsResponse, PurgeCompletionSuggestionsMetadata> response = await completionServiceClient.PurgeCompletionSuggestionsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeCompletionSuggestionsResponse, PurgeCompletionSuggestionsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeCompletionSuggestionsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeCompletionSuggestionsResponse, PurgeCompletionSuggestionsMetadata> retrievedResponse = await completionServiceClient.PollOncePurgeCompletionSuggestionsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeCompletionSuggestionsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
