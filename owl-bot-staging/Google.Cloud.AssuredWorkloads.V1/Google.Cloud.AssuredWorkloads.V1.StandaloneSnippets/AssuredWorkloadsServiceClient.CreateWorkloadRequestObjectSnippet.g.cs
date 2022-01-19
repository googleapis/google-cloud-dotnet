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

namespace Google.Cloud.AssuredWorkloads.V1.Snippets
{
    using Google.Cloud.AssuredWorkloads.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedAssuredWorkloadsServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateWorkload</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateWorkloadRequestObject()
        {
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            CreateWorkloadRequest request = new CreateWorkloadRequest
            {
                ParentAsLocationName = LocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Workload = new Workload(),
                ExternalId = "",
            };
            // Make the request
            Operation<Workload, CreateWorkloadOperationMetadata> response = assuredWorkloadsServiceClient.CreateWorkload(request);

            // Poll until the returned long-running operation is complete
            Operation<Workload, CreateWorkloadOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workload result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workload, CreateWorkloadOperationMetadata> retrievedResponse = assuredWorkloadsServiceClient.PollOnceCreateWorkload(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workload retrievedResult = retrievedResponse.Result;
            }
        }
    }
}
