// Copyright 2021 Google LLC
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

namespace Google.Cloud.Dialogflow.Cx.V3.Snippets
{
    using Google.Cloud.Dialogflow.Cx.V3;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedTestCasesClientStandaloneSnippets
    {
        /// <summary>Snippet for ExportTestCasesAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task ExportTestCasesRequestObjectAsync()
        {
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            ExportTestCasesRequest request = new ExportTestCasesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                GcsUri = "",
                DataFormat = ExportTestCasesRequest.Types.DataFormat.Unspecified,
                Filter = "",
            };
            // Make the request
            Operation<ExportTestCasesResponse, ExportTestCasesMetadata> response = await testCasesClient.ExportTestCasesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportTestCasesResponse, ExportTestCasesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportTestCasesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportTestCasesResponse, ExportTestCasesMetadata> retrievedResponse = await testCasesClient.PollOnceExportTestCasesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportTestCasesResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
}
