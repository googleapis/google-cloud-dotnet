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
    using Google.Cloud.DiscoveryEngine.V1Beta;
    using Google.LongRunning;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedProjectServiceClientSnippets
    {
        /// <summary>Snippet for ProvisionProject</summary>
        public void ProvisionProjectRequestObject()
        {
            // Snippet: ProvisionProject(ProvisionProjectRequest, CallSettings)
            // Create client
            ProjectServiceClient projectServiceClient = ProjectServiceClient.Create();
            // Initialize request argument(s)
            ProvisionProjectRequest request = new ProvisionProjectRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
                AcceptDataUseTerms = false,
                DataUseTermsVersion = "",
            };
            // Make the request
            Operation<Project, ProvisionProjectMetadata> response = projectServiceClient.ProvisionProject(request);

            // Poll until the returned long-running operation is complete
            Operation<Project, ProvisionProjectMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, ProvisionProjectMetadata> retrievedResponse = projectServiceClient.PollOnceProvisionProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ProvisionProjectAsync</summary>
        public async Task ProvisionProjectRequestObjectAsync()
        {
            // Snippet: ProvisionProjectAsync(ProvisionProjectRequest, CallSettings)
            // Additional: ProvisionProjectAsync(ProvisionProjectRequest, CancellationToken)
            // Create client
            ProjectServiceClient projectServiceClient = await ProjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProvisionProjectRequest request = new ProvisionProjectRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
                AcceptDataUseTerms = false,
                DataUseTermsVersion = "",
            };
            // Make the request
            Operation<Project, ProvisionProjectMetadata> response = await projectServiceClient.ProvisionProjectAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Project, ProvisionProjectMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, ProvisionProjectMetadata> retrievedResponse = await projectServiceClient.PollOnceProvisionProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ProvisionProject</summary>
        public void ProvisionProject()
        {
            // Snippet: ProvisionProject(string, CallSettings)
            // Create client
            ProjectServiceClient projectServiceClient = ProjectServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            Operation<Project, ProvisionProjectMetadata> response = projectServiceClient.ProvisionProject(name);

            // Poll until the returned long-running operation is complete
            Operation<Project, ProvisionProjectMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, ProvisionProjectMetadata> retrievedResponse = projectServiceClient.PollOnceProvisionProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ProvisionProjectAsync</summary>
        public async Task ProvisionProjectAsync()
        {
            // Snippet: ProvisionProjectAsync(string, CallSettings)
            // Additional: ProvisionProjectAsync(string, CancellationToken)
            // Create client
            ProjectServiceClient projectServiceClient = await ProjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            Operation<Project, ProvisionProjectMetadata> response = await projectServiceClient.ProvisionProjectAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Project, ProvisionProjectMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, ProvisionProjectMetadata> retrievedResponse = await projectServiceClient.PollOnceProvisionProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ProvisionProject</summary>
        public void ProvisionProjectResourceNames()
        {
            // Snippet: ProvisionProject(ProjectName, CallSettings)
            // Create client
            ProjectServiceClient projectServiceClient = ProjectServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            Operation<Project, ProvisionProjectMetadata> response = projectServiceClient.ProvisionProject(name);

            // Poll until the returned long-running operation is complete
            Operation<Project, ProvisionProjectMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, ProvisionProjectMetadata> retrievedResponse = projectServiceClient.PollOnceProvisionProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ProvisionProjectAsync</summary>
        public async Task ProvisionProjectResourceNamesAsync()
        {
            // Snippet: ProvisionProjectAsync(ProjectName, CallSettings)
            // Additional: ProvisionProjectAsync(ProjectName, CancellationToken)
            // Create client
            ProjectServiceClient projectServiceClient = await ProjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            Operation<Project, ProvisionProjectMetadata> response = await projectServiceClient.ProvisionProjectAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Project, ProvisionProjectMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, ProvisionProjectMetadata> retrievedResponse = await projectServiceClient.PollOnceProvisionProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
