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

namespace Google.Cloud.ResourceManager.V3.Snippets
{
    using Google.Cloud.ResourceManager.V3;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedTagValuesClientStandaloneSnippets
    {
        /// <summary>Snippet for DeleteTagValueAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task DeleteTagValueRequestObjectAsync()
        {
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTagValueRequest request = new DeleteTagValueRequest
            {
                TagValueName = TagValueName.FromTagValue("[TAG_VALUE]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<TagValue, DeleteTagValueMetadata> response = await tagValuesClient.DeleteTagValueAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TagValue, DeleteTagValueMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagValue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagValue, DeleteTagValueMetadata> retrievedResponse = await tagValuesClient.PollOnceDeleteTagValueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagValue retrievedResult = retrievedResponse.Result;
            }
        }
    }
}
