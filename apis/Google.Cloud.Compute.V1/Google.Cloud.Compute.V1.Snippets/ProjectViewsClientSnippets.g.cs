// Copyright 2026 Google LLC
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
    using Google.Cloud.Compute.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedProjectViewsClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetProjectViewRequest, CallSettings)
            // Create client
            ProjectViewsClient projectViewsClient = ProjectViewsClient.Create();
            // Initialize request argument(s)
            GetProjectViewRequest request = new GetProjectViewRequest
            {
                Region = "",
                Project = "",
            };
            // Make the request
            ProjectView response = projectViewsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetProjectViewRequest, CallSettings)
            // Additional: GetAsync(GetProjectViewRequest, CancellationToken)
            // Create client
            ProjectViewsClient projectViewsClient = await ProjectViewsClient.CreateAsync();
            // Initialize request argument(s)
            GetProjectViewRequest request = new GetProjectViewRequest
            {
                Region = "",
                Project = "",
            };
            // Make the request
            ProjectView response = await projectViewsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            ProjectViewsClient projectViewsClient = ProjectViewsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            ProjectView response = projectViewsClient.Get(project, region);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            ProjectViewsClient projectViewsClient = await ProjectViewsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            ProjectView response = await projectViewsClient.GetAsync(project, region);
            // End snippet
        }
    }
}
