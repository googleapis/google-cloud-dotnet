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
    using Google.Cloud.Dataflow.V1Beta3;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedTemplatesServiceClientSnippets
    {
        /// <summary>Snippet for CreateJobFromTemplate</summary>
        public void CreateJobFromTemplateRequestObject()
        {
            // Snippet: CreateJobFromTemplate(CreateJobFromTemplateRequest, CallSettings)
            // Create client
            TemplatesServiceClient templatesServiceClient = TemplatesServiceClient.Create();
            // Initialize request argument(s)
            CreateJobFromTemplateRequest request = new CreateJobFromTemplateRequest
            {
                ProjectId = "",
                GcsPath = "",
                Parameters = { { "", "" }, },
                JobName = "",
                Environment = new RuntimeEnvironment(),
                Location = "",
            };
            // Make the request
            Job response = templatesServiceClient.CreateJobFromTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJobFromTemplateAsync</summary>
        public async Task CreateJobFromTemplateRequestObjectAsync()
        {
            // Snippet: CreateJobFromTemplateAsync(CreateJobFromTemplateRequest, CallSettings)
            // Additional: CreateJobFromTemplateAsync(CreateJobFromTemplateRequest, CancellationToken)
            // Create client
            TemplatesServiceClient templatesServiceClient = await TemplatesServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateJobFromTemplateRequest request = new CreateJobFromTemplateRequest
            {
                ProjectId = "",
                GcsPath = "",
                Parameters = { { "", "" }, },
                JobName = "",
                Environment = new RuntimeEnvironment(),
                Location = "",
            };
            // Make the request
            Job response = await templatesServiceClient.CreateJobFromTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LaunchTemplate</summary>
        public void LaunchTemplateRequestObject()
        {
            // Snippet: LaunchTemplate(LaunchTemplateRequest, CallSettings)
            // Create client
            TemplatesServiceClient templatesServiceClient = TemplatesServiceClient.Create();
            // Initialize request argument(s)
            LaunchTemplateRequest request = new LaunchTemplateRequest
            {
                ProjectId = "",
                ValidateOnly = false,
                GcsPath = "",
                LaunchParameters = new LaunchTemplateParameters(),
                Location = "",
            };
            // Make the request
            LaunchTemplateResponse response = templatesServiceClient.LaunchTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for LaunchTemplateAsync</summary>
        public async Task LaunchTemplateRequestObjectAsync()
        {
            // Snippet: LaunchTemplateAsync(LaunchTemplateRequest, CallSettings)
            // Additional: LaunchTemplateAsync(LaunchTemplateRequest, CancellationToken)
            // Create client
            TemplatesServiceClient templatesServiceClient = await TemplatesServiceClient.CreateAsync();
            // Initialize request argument(s)
            LaunchTemplateRequest request = new LaunchTemplateRequest
            {
                ProjectId = "",
                ValidateOnly = false,
                GcsPath = "",
                LaunchParameters = new LaunchTemplateParameters(),
                Location = "",
            };
            // Make the request
            LaunchTemplateResponse response = await templatesServiceClient.LaunchTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTemplate</summary>
        public void GetTemplateRequestObject()
        {
            // Snippet: GetTemplate(GetTemplateRequest, CallSettings)
            // Create client
            TemplatesServiceClient templatesServiceClient = TemplatesServiceClient.Create();
            // Initialize request argument(s)
            GetTemplateRequest request = new GetTemplateRequest
            {
                ProjectId = "",
                GcsPath = "",
                View = GetTemplateRequest.Types.TemplateView.MetadataOnly,
                Location = "",
            };
            // Make the request
            GetTemplateResponse response = templatesServiceClient.GetTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetTemplateAsync</summary>
        public async Task GetTemplateRequestObjectAsync()
        {
            // Snippet: GetTemplateAsync(GetTemplateRequest, CallSettings)
            // Additional: GetTemplateAsync(GetTemplateRequest, CancellationToken)
            // Create client
            TemplatesServiceClient templatesServiceClient = await TemplatesServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTemplateRequest request = new GetTemplateRequest
            {
                ProjectId = "",
                GcsPath = "",
                View = GetTemplateRequest.Types.TemplateView.MetadataOnly,
                Location = "",
            };
            // Make the request
            GetTemplateResponse response = await templatesServiceClient.GetTemplateAsync(request);
            // End snippet
        }
    }
}
