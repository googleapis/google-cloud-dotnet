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
    // [START dialogflow_v2beta1_generated_Documents_ReloadDocument_sync_flattened_resourceNames]
    using Google.Cloud.Dialogflow.V2Beta1;
    using Google.LongRunning;

    public sealed partial class GeneratedDocumentsClientSnippets
    {
        /// <summary>Snippet for ReloadDocument</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void ReloadDocumentResourceNames()
        {
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            DocumentName name = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]");
            GcsSource gcsSource = new GcsSource();
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = documentsClient.ReloadDocument(name, gcsSource);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = documentsClient.PollOnceReloadDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dialogflow_v2beta1_generated_Documents_ReloadDocument_sync_flattened_resourceNames]
}
