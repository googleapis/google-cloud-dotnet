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

namespace Google.Cloud.Run.V2.Snippets
{
    // [START run_v2_generated_Revisions_DeleteRevision_async]
    using Google.Cloud.Run.V2;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedRevisionsClientSnippets
    {
        /// <summary>Snippet for DeleteRevisionAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task DeleteRevisionRequestObjectAsync()
        {
            // Create client
            RevisionsClient revisionsClient = await RevisionsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRevisionRequest request = new DeleteRevisionRequest
            {
                RevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Revision, Revision> response = await revisionsClient.DeleteRevisionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Revision, Revision> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Revision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Revision, Revision> retrievedResponse = await revisionsClient.PollOnceDeleteRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Revision retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END run_v2_generated_Revisions_DeleteRevision_async]
}
