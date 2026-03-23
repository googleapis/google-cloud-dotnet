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
    using Google.Cloud.DataCatalog.Lineage.ConfigManagement.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedConfigManagementServiceClientSnippets
    {
        /// <summary>Snippet for GetConfig</summary>
        public void GetConfigRequestObject()
        {
            // Snippet: GetConfig(GetConfigRequest, CallSettings)
            // Create client
            ConfigManagementServiceClient configManagementServiceClient = ConfigManagementServiceClient.Create();
            // Initialize request argument(s)
            GetConfigRequest request = new GetConfigRequest
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Config response = configManagementServiceClient.GetConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetConfigAsync</summary>
        public async Task GetConfigRequestObjectAsync()
        {
            // Snippet: GetConfigAsync(GetConfigRequest, CallSettings)
            // Additional: GetConfigAsync(GetConfigRequest, CancellationToken)
            // Create client
            ConfigManagementServiceClient configManagementServiceClient = await ConfigManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetConfigRequest request = new GetConfigRequest
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Config response = await configManagementServiceClient.GetConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConfig</summary>
        public void GetConfig()
        {
            // Snippet: GetConfig(string, CallSettings)
            // Create client
            ConfigManagementServiceClient configManagementServiceClient = ConfigManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/config";
            // Make the request
            Config response = configManagementServiceClient.GetConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetConfigAsync</summary>
        public async Task GetConfigAsync()
        {
            // Snippet: GetConfigAsync(string, CallSettings)
            // Additional: GetConfigAsync(string, CancellationToken)
            // Create client
            ConfigManagementServiceClient configManagementServiceClient = await ConfigManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/config";
            // Make the request
            Config response = await configManagementServiceClient.GetConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConfig</summary>
        public void GetConfigResourceNames()
        {
            // Snippet: GetConfig(ConfigName, CallSettings)
            // Create client
            ConfigManagementServiceClient configManagementServiceClient = ConfigManagementServiceClient.Create();
            // Initialize request argument(s)
            ConfigName name = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Config response = configManagementServiceClient.GetConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetConfigAsync</summary>
        public async Task GetConfigResourceNamesAsync()
        {
            // Snippet: GetConfigAsync(ConfigName, CallSettings)
            // Additional: GetConfigAsync(ConfigName, CancellationToken)
            // Create client
            ConfigManagementServiceClient configManagementServiceClient = await ConfigManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConfigName name = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Config response = await configManagementServiceClient.GetConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateConfig</summary>
        public void UpdateConfigRequestObject()
        {
            // Snippet: UpdateConfig(UpdateConfigRequest, CallSettings)
            // Create client
            ConfigManagementServiceClient configManagementServiceClient = ConfigManagementServiceClient.Create();
            // Initialize request argument(s)
            UpdateConfigRequest request = new UpdateConfigRequest
            {
                Config = new Config(),
            };
            // Make the request
            Config response = configManagementServiceClient.UpdateConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConfigAsync</summary>
        public async Task UpdateConfigRequestObjectAsync()
        {
            // Snippet: UpdateConfigAsync(UpdateConfigRequest, CallSettings)
            // Additional: UpdateConfigAsync(UpdateConfigRequest, CancellationToken)
            // Create client
            ConfigManagementServiceClient configManagementServiceClient = await ConfigManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConfigRequest request = new UpdateConfigRequest
            {
                Config = new Config(),
            };
            // Make the request
            Config response = await configManagementServiceClient.UpdateConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConfig</summary>
        public void UpdateConfig()
        {
            // Snippet: UpdateConfig(Config, CallSettings)
            // Create client
            ConfigManagementServiceClient configManagementServiceClient = ConfigManagementServiceClient.Create();
            // Initialize request argument(s)
            Config config = new Config();
            // Make the request
            Config response = configManagementServiceClient.UpdateConfig(config);
            // End snippet
        }

        /// <summary>Snippet for UpdateConfigAsync</summary>
        public async Task UpdateConfigAsync()
        {
            // Snippet: UpdateConfigAsync(Config, CallSettings)
            // Additional: UpdateConfigAsync(Config, CancellationToken)
            // Create client
            ConfigManagementServiceClient configManagementServiceClient = await ConfigManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            Config config = new Config();
            // Make the request
            Config response = await configManagementServiceClient.UpdateConfigAsync(config);
            // End snippet
        }
    }
}
