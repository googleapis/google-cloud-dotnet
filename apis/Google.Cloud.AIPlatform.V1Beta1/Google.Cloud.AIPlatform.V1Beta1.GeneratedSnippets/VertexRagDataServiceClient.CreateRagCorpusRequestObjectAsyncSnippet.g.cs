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
    // [START aiplatform_v1beta1_generated_VertexRagDataService_CreateRagCorpus_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedVertexRagDataServiceClientSnippets
    {
        /// <summary>Snippet for CreateRagCorpusAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateRagCorpusRequestObjectAsync()
        {
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateRagCorpusRequest request = new CreateRagCorpusRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                RagCorpus = new RagCorpus(),
            };
            // Make the request
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> response = await vertexRagDataServiceClient.CreateRagCorpusAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RagCorpus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceCreateRagCorpusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RagCorpus retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1beta1_generated_VertexRagDataService_CreateRagCorpus_async]
}
