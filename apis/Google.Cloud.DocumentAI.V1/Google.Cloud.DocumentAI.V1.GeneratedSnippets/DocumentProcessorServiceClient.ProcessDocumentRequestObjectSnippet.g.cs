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

namespace Google.Cloud.DocumentAI.V1.Snippets
{
    // [START documentai_v1_generated_DocumentProcessorService_ProcessDocument_sync]
    using Google.Api.Gax;
    using Google.Cloud.DocumentAI.V1;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedDocumentProcessorServiceClientSnippets
    {
        /// <summary>Snippet for ProcessDocument</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void ProcessDocumentRequestObject()
        {
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ProcessRequest request = new ProcessRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
                SkipHumanReview = false,
                InlineDocument = new Document(),
                FieldMask = new FieldMask(),
            };
            // Make the request
            ProcessResponse response = documentProcessorServiceClient.ProcessDocument(request);
        }
    }
    // [END documentai_v1_generated_DocumentProcessorService_ProcessDocument_sync]
}
