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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Kms.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAutokeyAdminClientSnippets
    {
        /// <summary>Snippet for UpdateAutokeyConfig</summary>
        public void UpdateAutokeyConfigRequestObject()
        {
            // Snippet: UpdateAutokeyConfig(UpdateAutokeyConfigRequest, CallSettings)
            // Create client
            AutokeyAdminClient autokeyAdminClient = AutokeyAdminClient.Create();
            // Initialize request argument(s)
            UpdateAutokeyConfigRequest request = new UpdateAutokeyConfigRequest
            {
                AutokeyConfig = new AutokeyConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AutokeyConfig response = autokeyAdminClient.UpdateAutokeyConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAutokeyConfigAsync</summary>
        public async Task UpdateAutokeyConfigRequestObjectAsync()
        {
            // Snippet: UpdateAutokeyConfigAsync(UpdateAutokeyConfigRequest, CallSettings)
            // Additional: UpdateAutokeyConfigAsync(UpdateAutokeyConfigRequest, CancellationToken)
            // Create client
            AutokeyAdminClient autokeyAdminClient = await AutokeyAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAutokeyConfigRequest request = new UpdateAutokeyConfigRequest
            {
                AutokeyConfig = new AutokeyConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AutokeyConfig response = await autokeyAdminClient.UpdateAutokeyConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAutokeyConfig</summary>
        public void UpdateAutokeyConfig()
        {
            // Snippet: UpdateAutokeyConfig(AutokeyConfig, FieldMask, CallSettings)
            // Create client
            AutokeyAdminClient autokeyAdminClient = AutokeyAdminClient.Create();
            // Initialize request argument(s)
            AutokeyConfig autokeyConfig = new AutokeyConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AutokeyConfig response = autokeyAdminClient.UpdateAutokeyConfig(autokeyConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAutokeyConfigAsync</summary>
        public async Task UpdateAutokeyConfigAsync()
        {
            // Snippet: UpdateAutokeyConfigAsync(AutokeyConfig, FieldMask, CallSettings)
            // Additional: UpdateAutokeyConfigAsync(AutokeyConfig, FieldMask, CancellationToken)
            // Create client
            AutokeyAdminClient autokeyAdminClient = await AutokeyAdminClient.CreateAsync();
            // Initialize request argument(s)
            AutokeyConfig autokeyConfig = new AutokeyConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AutokeyConfig response = await autokeyAdminClient.UpdateAutokeyConfigAsync(autokeyConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetAutokeyConfig</summary>
        public void GetAutokeyConfigRequestObject()
        {
            // Snippet: GetAutokeyConfig(GetAutokeyConfigRequest, CallSettings)
            // Create client
            AutokeyAdminClient autokeyAdminClient = AutokeyAdminClient.Create();
            // Initialize request argument(s)
            GetAutokeyConfigRequest request = new GetAutokeyConfigRequest
            {
                AutokeyConfigName = AutokeyConfigName.FromFolder("[FOLDER]"),
            };
            // Make the request
            AutokeyConfig response = autokeyAdminClient.GetAutokeyConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetAutokeyConfigAsync</summary>
        public async Task GetAutokeyConfigRequestObjectAsync()
        {
            // Snippet: GetAutokeyConfigAsync(GetAutokeyConfigRequest, CallSettings)
            // Additional: GetAutokeyConfigAsync(GetAutokeyConfigRequest, CancellationToken)
            // Create client
            AutokeyAdminClient autokeyAdminClient = await AutokeyAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetAutokeyConfigRequest request = new GetAutokeyConfigRequest
            {
                AutokeyConfigName = AutokeyConfigName.FromFolder("[FOLDER]"),
            };
            // Make the request
            AutokeyConfig response = await autokeyAdminClient.GetAutokeyConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAutokeyConfig</summary>
        public void GetAutokeyConfig()
        {
            // Snippet: GetAutokeyConfig(string, CallSettings)
            // Create client
            AutokeyAdminClient autokeyAdminClient = AutokeyAdminClient.Create();
            // Initialize request argument(s)
            string name = "folders/[FOLDER]/autokeyConfig";
            // Make the request
            AutokeyConfig response = autokeyAdminClient.GetAutokeyConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutokeyConfigAsync</summary>
        public async Task GetAutokeyConfigAsync()
        {
            // Snippet: GetAutokeyConfigAsync(string, CallSettings)
            // Additional: GetAutokeyConfigAsync(string, CancellationToken)
            // Create client
            AutokeyAdminClient autokeyAdminClient = await AutokeyAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "folders/[FOLDER]/autokeyConfig";
            // Make the request
            AutokeyConfig response = await autokeyAdminClient.GetAutokeyConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutokeyConfig</summary>
        public void GetAutokeyConfigResourceNames()
        {
            // Snippet: GetAutokeyConfig(AutokeyConfigName, CallSettings)
            // Create client
            AutokeyAdminClient autokeyAdminClient = AutokeyAdminClient.Create();
            // Initialize request argument(s)
            AutokeyConfigName name = AutokeyConfigName.FromFolder("[FOLDER]");
            // Make the request
            AutokeyConfig response = autokeyAdminClient.GetAutokeyConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutokeyConfigAsync</summary>
        public async Task GetAutokeyConfigResourceNamesAsync()
        {
            // Snippet: GetAutokeyConfigAsync(AutokeyConfigName, CallSettings)
            // Additional: GetAutokeyConfigAsync(AutokeyConfigName, CancellationToken)
            // Create client
            AutokeyAdminClient autokeyAdminClient = await AutokeyAdminClient.CreateAsync();
            // Initialize request argument(s)
            AutokeyConfigName name = AutokeyConfigName.FromFolder("[FOLDER]");
            // Make the request
            AutokeyConfig response = await autokeyAdminClient.GetAutokeyConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ShowEffectiveAutokeyConfig</summary>
        public void ShowEffectiveAutokeyConfigRequestObject()
        {
            // Snippet: ShowEffectiveAutokeyConfig(ShowEffectiveAutokeyConfigRequest, CallSettings)
            // Create client
            AutokeyAdminClient autokeyAdminClient = AutokeyAdminClient.Create();
            // Initialize request argument(s)
            ShowEffectiveAutokeyConfigRequest request = new ShowEffectiveAutokeyConfigRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            ShowEffectiveAutokeyConfigResponse response = autokeyAdminClient.ShowEffectiveAutokeyConfig(request);
            // End snippet
        }

        /// <summary>Snippet for ShowEffectiveAutokeyConfigAsync</summary>
        public async Task ShowEffectiveAutokeyConfigRequestObjectAsync()
        {
            // Snippet: ShowEffectiveAutokeyConfigAsync(ShowEffectiveAutokeyConfigRequest, CallSettings)
            // Additional: ShowEffectiveAutokeyConfigAsync(ShowEffectiveAutokeyConfigRequest, CancellationToken)
            // Create client
            AutokeyAdminClient autokeyAdminClient = await AutokeyAdminClient.CreateAsync();
            // Initialize request argument(s)
            ShowEffectiveAutokeyConfigRequest request = new ShowEffectiveAutokeyConfigRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            ShowEffectiveAutokeyConfigResponse response = await autokeyAdminClient.ShowEffectiveAutokeyConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ShowEffectiveAutokeyConfig</summary>
        public void ShowEffectiveAutokeyConfig()
        {
            // Snippet: ShowEffectiveAutokeyConfig(string, CallSettings)
            // Create client
            AutokeyAdminClient autokeyAdminClient = AutokeyAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            ShowEffectiveAutokeyConfigResponse response = autokeyAdminClient.ShowEffectiveAutokeyConfig(parent);
            // End snippet
        }

        /// <summary>Snippet for ShowEffectiveAutokeyConfigAsync</summary>
        public async Task ShowEffectiveAutokeyConfigAsync()
        {
            // Snippet: ShowEffectiveAutokeyConfigAsync(string, CallSettings)
            // Additional: ShowEffectiveAutokeyConfigAsync(string, CancellationToken)
            // Create client
            AutokeyAdminClient autokeyAdminClient = await AutokeyAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            ShowEffectiveAutokeyConfigResponse response = await autokeyAdminClient.ShowEffectiveAutokeyConfigAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ShowEffectiveAutokeyConfig</summary>
        public void ShowEffectiveAutokeyConfigResourceNames()
        {
            // Snippet: ShowEffectiveAutokeyConfig(ProjectName, CallSettings)
            // Create client
            AutokeyAdminClient autokeyAdminClient = AutokeyAdminClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            ShowEffectiveAutokeyConfigResponse response = autokeyAdminClient.ShowEffectiveAutokeyConfig(parent);
            // End snippet
        }

        /// <summary>Snippet for ShowEffectiveAutokeyConfigAsync</summary>
        public async Task ShowEffectiveAutokeyConfigResourceNamesAsync()
        {
            // Snippet: ShowEffectiveAutokeyConfigAsync(ProjectName, CallSettings)
            // Additional: ShowEffectiveAutokeyConfigAsync(ProjectName, CancellationToken)
            // Create client
            AutokeyAdminClient autokeyAdminClient = await AutokeyAdminClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            ShowEffectiveAutokeyConfigResponse response = await autokeyAdminClient.ShowEffectiveAutokeyConfigAsync(parent);
            // End snippet
        }
    }
}
