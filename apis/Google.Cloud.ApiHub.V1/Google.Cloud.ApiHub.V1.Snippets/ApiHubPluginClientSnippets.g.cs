// Copyright 2024 Google LLC
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
    using Google.Cloud.ApiHub.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedApiHubPluginClientSnippets
    {
        /// <summary>Snippet for GetPlugin</summary>
        public void GetPluginRequestObject()
        {
            // Snippet: GetPlugin(GetPluginRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            GetPluginRequest request = new GetPluginRequest
            {
                PluginName = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
            };
            // Make the request
            Plugin response = apiHubPluginClient.GetPlugin(request);
            // End snippet
        }

        /// <summary>Snippet for GetPluginAsync</summary>
        public async Task GetPluginRequestObjectAsync()
        {
            // Snippet: GetPluginAsync(GetPluginRequest, CallSettings)
            // Additional: GetPluginAsync(GetPluginRequest, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            GetPluginRequest request = new GetPluginRequest
            {
                PluginName = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
            };
            // Make the request
            Plugin response = await apiHubPluginClient.GetPluginAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPlugin</summary>
        public void GetPlugin()
        {
            // Snippet: GetPlugin(string, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]";
            // Make the request
            Plugin response = apiHubPluginClient.GetPlugin(name);
            // End snippet
        }

        /// <summary>Snippet for GetPluginAsync</summary>
        public async Task GetPluginAsync()
        {
            // Snippet: GetPluginAsync(string, CallSettings)
            // Additional: GetPluginAsync(string, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]";
            // Make the request
            Plugin response = await apiHubPluginClient.GetPluginAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPlugin</summary>
        public void GetPluginResourceNames()
        {
            // Snippet: GetPlugin(PluginName, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            PluginName name = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            Plugin response = apiHubPluginClient.GetPlugin(name);
            // End snippet
        }

        /// <summary>Snippet for GetPluginAsync</summary>
        public async Task GetPluginResourceNamesAsync()
        {
            // Snippet: GetPluginAsync(PluginName, CallSettings)
            // Additional: GetPluginAsync(PluginName, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            PluginName name = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            Plugin response = await apiHubPluginClient.GetPluginAsync(name);
            // End snippet
        }

        /// <summary>Snippet for EnablePlugin</summary>
        public void EnablePluginRequestObject()
        {
            // Snippet: EnablePlugin(EnablePluginRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            EnablePluginRequest request = new EnablePluginRequest
            {
                PluginName = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
            };
            // Make the request
            Plugin response = apiHubPluginClient.EnablePlugin(request);
            // End snippet
        }

        /// <summary>Snippet for EnablePluginAsync</summary>
        public async Task EnablePluginRequestObjectAsync()
        {
            // Snippet: EnablePluginAsync(EnablePluginRequest, CallSettings)
            // Additional: EnablePluginAsync(EnablePluginRequest, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            EnablePluginRequest request = new EnablePluginRequest
            {
                PluginName = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
            };
            // Make the request
            Plugin response = await apiHubPluginClient.EnablePluginAsync(request);
            // End snippet
        }

        /// <summary>Snippet for EnablePlugin</summary>
        public void EnablePlugin()
        {
            // Snippet: EnablePlugin(string, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]";
            // Make the request
            Plugin response = apiHubPluginClient.EnablePlugin(name);
            // End snippet
        }

        /// <summary>Snippet for EnablePluginAsync</summary>
        public async Task EnablePluginAsync()
        {
            // Snippet: EnablePluginAsync(string, CallSettings)
            // Additional: EnablePluginAsync(string, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]";
            // Make the request
            Plugin response = await apiHubPluginClient.EnablePluginAsync(name);
            // End snippet
        }

        /// <summary>Snippet for EnablePlugin</summary>
        public void EnablePluginResourceNames()
        {
            // Snippet: EnablePlugin(PluginName, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            PluginName name = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            Plugin response = apiHubPluginClient.EnablePlugin(name);
            // End snippet
        }

        /// <summary>Snippet for EnablePluginAsync</summary>
        public async Task EnablePluginResourceNamesAsync()
        {
            // Snippet: EnablePluginAsync(PluginName, CallSettings)
            // Additional: EnablePluginAsync(PluginName, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            PluginName name = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            Plugin response = await apiHubPluginClient.EnablePluginAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DisablePlugin</summary>
        public void DisablePluginRequestObject()
        {
            // Snippet: DisablePlugin(DisablePluginRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            DisablePluginRequest request = new DisablePluginRequest
            {
                PluginName = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
            };
            // Make the request
            Plugin response = apiHubPluginClient.DisablePlugin(request);
            // End snippet
        }

        /// <summary>Snippet for DisablePluginAsync</summary>
        public async Task DisablePluginRequestObjectAsync()
        {
            // Snippet: DisablePluginAsync(DisablePluginRequest, CallSettings)
            // Additional: DisablePluginAsync(DisablePluginRequest, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            DisablePluginRequest request = new DisablePluginRequest
            {
                PluginName = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
            };
            // Make the request
            Plugin response = await apiHubPluginClient.DisablePluginAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DisablePlugin</summary>
        public void DisablePlugin()
        {
            // Snippet: DisablePlugin(string, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]";
            // Make the request
            Plugin response = apiHubPluginClient.DisablePlugin(name);
            // End snippet
        }

        /// <summary>Snippet for DisablePluginAsync</summary>
        public async Task DisablePluginAsync()
        {
            // Snippet: DisablePluginAsync(string, CallSettings)
            // Additional: DisablePluginAsync(string, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]";
            // Make the request
            Plugin response = await apiHubPluginClient.DisablePluginAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DisablePlugin</summary>
        public void DisablePluginResourceNames()
        {
            // Snippet: DisablePlugin(PluginName, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            PluginName name = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            Plugin response = apiHubPluginClient.DisablePlugin(name);
            // End snippet
        }

        /// <summary>Snippet for DisablePluginAsync</summary>
        public async Task DisablePluginResourceNamesAsync()
        {
            // Snippet: DisablePluginAsync(PluginName, CallSettings)
            // Additional: DisablePluginAsync(PluginName, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            PluginName name = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            Plugin response = await apiHubPluginClient.DisablePluginAsync(name);
            // End snippet
        }
    }
}
