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
    public sealed class AllGeneratedGlobalFrontendSettingsServiceClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetGlobalFrontendSettingRequest, CallSettings)
            // Create client
            GlobalFrontendSettingsServiceClient globalFrontendSettingsServiceClient = GlobalFrontendSettingsServiceClient.Create();
            // Initialize request argument(s)
            GetGlobalFrontendSettingRequest request = new GetGlobalFrontendSettingRequest { Project = "", };
            // Make the request
            GlobalFrontendSettings response = globalFrontendSettingsServiceClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetGlobalFrontendSettingRequest, CallSettings)
            // Additional: GetAsync(GetGlobalFrontendSettingRequest, CancellationToken)
            // Create client
            GlobalFrontendSettingsServiceClient globalFrontendSettingsServiceClient = await GlobalFrontendSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGlobalFrontendSettingRequest request = new GetGlobalFrontendSettingRequest { Project = "", };
            // Make the request
            GlobalFrontendSettings response = await globalFrontendSettingsServiceClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, CallSettings)
            // Create client
            GlobalFrontendSettingsServiceClient globalFrontendSettingsServiceClient = GlobalFrontendSettingsServiceClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            GlobalFrontendSettings response = globalFrontendSettingsServiceClient.Get(project);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, CallSettings)
            // Additional: GetAsync(string, CancellationToken)
            // Create client
            GlobalFrontendSettingsServiceClient globalFrontendSettingsServiceClient = await GlobalFrontendSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            GlobalFrontendSettings response = await globalFrontendSettingsServiceClient.GetAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchGlobalFrontendSettingRequest, CallSettings)
            // Create client
            GlobalFrontendSettingsServiceClient globalFrontendSettingsServiceClient = GlobalFrontendSettingsServiceClient.Create();
            // Initialize request argument(s)
            PatchGlobalFrontendSettingRequest request = new PatchGlobalFrontendSettingRequest
            {
                RequestId = "",
                Project = "",
                GlobalFrontendSettingsResource = new GlobalFrontendSettings(),
                UpdateMask = "",
            };
            // Make the request
            GlobalFrontendSettingsPatchResponse response = globalFrontendSettingsServiceClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchGlobalFrontendSettingRequest, CallSettings)
            // Additional: PatchAsync(PatchGlobalFrontendSettingRequest, CancellationToken)
            // Create client
            GlobalFrontendSettingsServiceClient globalFrontendSettingsServiceClient = await GlobalFrontendSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            PatchGlobalFrontendSettingRequest request = new PatchGlobalFrontendSettingRequest
            {
                RequestId = "",
                Project = "",
                GlobalFrontendSettingsResource = new GlobalFrontendSettings(),
                UpdateMask = "",
            };
            // Make the request
            GlobalFrontendSettingsPatchResponse response = await globalFrontendSettingsServiceClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, GlobalFrontendSettings, CallSettings)
            // Create client
            GlobalFrontendSettingsServiceClient globalFrontendSettingsServiceClient = GlobalFrontendSettingsServiceClient.Create();
            // Initialize request argument(s)
            string project = "";
            GlobalFrontendSettings globalFrontendSettingsResource = new GlobalFrontendSettings();
            // Make the request
            GlobalFrontendSettingsPatchResponse response = globalFrontendSettingsServiceClient.Patch(project, globalFrontendSettingsResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, GlobalFrontendSettings, CallSettings)
            // Additional: PatchAsync(string, GlobalFrontendSettings, CancellationToken)
            // Create client
            GlobalFrontendSettingsServiceClient globalFrontendSettingsServiceClient = await GlobalFrontendSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            GlobalFrontendSettings globalFrontendSettingsResource = new GlobalFrontendSettings();
            // Make the request
            GlobalFrontendSettingsPatchResponse response = await globalFrontendSettingsServiceClient.PatchAsync(project, globalFrontendSettingsResource);
            // End snippet
        }
    }
}
