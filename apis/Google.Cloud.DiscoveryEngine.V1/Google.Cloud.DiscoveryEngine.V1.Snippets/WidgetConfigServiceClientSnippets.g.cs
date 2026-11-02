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
    using Google.Cloud.DiscoveryEngine.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedWidgetConfigServiceClientSnippets
    {
        /// <summary>Snippet for GetWidgetConfig</summary>
        public void GetWidgetConfigRequestObject()
        {
            // Snippet: GetWidgetConfig(GetWidgetConfigRequest, CallSettings)
            // Create client
            WidgetConfigServiceClient widgetConfigServiceClient = WidgetConfigServiceClient.Create();
            // Initialize request argument(s)
            GetWidgetConfigRequest request = new GetWidgetConfigRequest
            {
                WidgetConfigName = WidgetConfigName.FromProjectLocationDataStoreWidgetConfig("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[WIDGET_CONFIG]"),
                AcceptCache = false,
                GetWidgetConfigRequestOption = new GetWidgetConfigRequest.Types.GetWidgetConfigRequestOption(),
                LanguageCode = "",
                ModelInfoView = ModelInfoView.Unspecified,
            };
            // Make the request
            WidgetConfig response = widgetConfigServiceClient.GetWidgetConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetWidgetConfigAsync</summary>
        public async Task GetWidgetConfigRequestObjectAsync()
        {
            // Snippet: GetWidgetConfigAsync(GetWidgetConfigRequest, CallSettings)
            // Additional: GetWidgetConfigAsync(GetWidgetConfigRequest, CancellationToken)
            // Create client
            WidgetConfigServiceClient widgetConfigServiceClient = await WidgetConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetWidgetConfigRequest request = new GetWidgetConfigRequest
            {
                WidgetConfigName = WidgetConfigName.FromProjectLocationDataStoreWidgetConfig("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[WIDGET_CONFIG]"),
                AcceptCache = false,
                GetWidgetConfigRequestOption = new GetWidgetConfigRequest.Types.GetWidgetConfigRequestOption(),
                LanguageCode = "",
                ModelInfoView = ModelInfoView.Unspecified,
            };
            // Make the request
            WidgetConfig response = await widgetConfigServiceClient.GetWidgetConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWidgetConfig</summary>
        public void GetWidgetConfig()
        {
            // Snippet: GetWidgetConfig(string, CallSettings)
            // Create client
            WidgetConfigServiceClient widgetConfigServiceClient = WidgetConfigServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/widgetConfigs/[WIDGET_CONFIG]";
            // Make the request
            WidgetConfig response = widgetConfigServiceClient.GetWidgetConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetWidgetConfigAsync</summary>
        public async Task GetWidgetConfigAsync()
        {
            // Snippet: GetWidgetConfigAsync(string, CallSettings)
            // Additional: GetWidgetConfigAsync(string, CancellationToken)
            // Create client
            WidgetConfigServiceClient widgetConfigServiceClient = await WidgetConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/widgetConfigs/[WIDGET_CONFIG]";
            // Make the request
            WidgetConfig response = await widgetConfigServiceClient.GetWidgetConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWidgetConfig</summary>
        public void GetWidgetConfigResourceNames()
        {
            // Snippet: GetWidgetConfig(WidgetConfigName, CallSettings)
            // Create client
            WidgetConfigServiceClient widgetConfigServiceClient = WidgetConfigServiceClient.Create();
            // Initialize request argument(s)
            WidgetConfigName name = WidgetConfigName.FromProjectLocationDataStoreWidgetConfig("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[WIDGET_CONFIG]");
            // Make the request
            WidgetConfig response = widgetConfigServiceClient.GetWidgetConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetWidgetConfigAsync</summary>
        public async Task GetWidgetConfigResourceNamesAsync()
        {
            // Snippet: GetWidgetConfigAsync(WidgetConfigName, CallSettings)
            // Additional: GetWidgetConfigAsync(WidgetConfigName, CancellationToken)
            // Create client
            WidgetConfigServiceClient widgetConfigServiceClient = await WidgetConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            WidgetConfigName name = WidgetConfigName.FromProjectLocationDataStoreWidgetConfig("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[WIDGET_CONFIG]");
            // Make the request
            WidgetConfig response = await widgetConfigServiceClient.GetWidgetConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateWidgetConfig</summary>
        public void UpdateWidgetConfigRequestObject()
        {
            // Snippet: UpdateWidgetConfig(UpdateWidgetConfigRequest, CallSettings)
            // Create client
            WidgetConfigServiceClient widgetConfigServiceClient = WidgetConfigServiceClient.Create();
            // Initialize request argument(s)
            UpdateWidgetConfigRequest request = new UpdateWidgetConfigRequest
            {
                WidgetConfig = new WidgetConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            WidgetConfig response = widgetConfigServiceClient.UpdateWidgetConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateWidgetConfigAsync</summary>
        public async Task UpdateWidgetConfigRequestObjectAsync()
        {
            // Snippet: UpdateWidgetConfigAsync(UpdateWidgetConfigRequest, CallSettings)
            // Additional: UpdateWidgetConfigAsync(UpdateWidgetConfigRequest, CancellationToken)
            // Create client
            WidgetConfigServiceClient widgetConfigServiceClient = await WidgetConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateWidgetConfigRequest request = new UpdateWidgetConfigRequest
            {
                WidgetConfig = new WidgetConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            WidgetConfig response = await widgetConfigServiceClient.UpdateWidgetConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateWidgetConfig</summary>
        public void UpdateWidgetConfig()
        {
            // Snippet: UpdateWidgetConfig(WidgetConfig, FieldMask, CallSettings)
            // Create client
            WidgetConfigServiceClient widgetConfigServiceClient = WidgetConfigServiceClient.Create();
            // Initialize request argument(s)
            WidgetConfig widgetConfig = new WidgetConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            WidgetConfig response = widgetConfigServiceClient.UpdateWidgetConfig(widgetConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateWidgetConfigAsync</summary>
        public async Task UpdateWidgetConfigAsync()
        {
            // Snippet: UpdateWidgetConfigAsync(WidgetConfig, FieldMask, CallSettings)
            // Additional: UpdateWidgetConfigAsync(WidgetConfig, FieldMask, CancellationToken)
            // Create client
            WidgetConfigServiceClient widgetConfigServiceClient = await WidgetConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            WidgetConfig widgetConfig = new WidgetConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            WidgetConfig response = await widgetConfigServiceClient.UpdateWidgetConfigAsync(widgetConfig, updateMask);
            // End snippet
        }
    }
}
