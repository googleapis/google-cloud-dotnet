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
    using Google.Cloud.CloudQuotas.V1Beta;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedQuotaAdjusterSettingsManagerClientSnippets
    {
        /// <summary>Snippet for UpdateQuotaAdjusterSettings</summary>
        public void UpdateQuotaAdjusterSettingsRequestObject()
        {
            // Snippet: UpdateQuotaAdjusterSettings(UpdateQuotaAdjusterSettingsRequest, CallSettings)
            // Create client
            QuotaAdjusterSettingsManagerClient quotaAdjusterSettingsManagerClient = QuotaAdjusterSettingsManagerClient.Create();
            // Initialize request argument(s)
            UpdateQuotaAdjusterSettingsRequest request = new UpdateQuotaAdjusterSettingsRequest
            {
                QuotaAdjusterSettings = new QuotaAdjusterSettings(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            QuotaAdjusterSettings response = quotaAdjusterSettingsManagerClient.UpdateQuotaAdjusterSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateQuotaAdjusterSettingsAsync</summary>
        public async Task UpdateQuotaAdjusterSettingsRequestObjectAsync()
        {
            // Snippet: UpdateQuotaAdjusterSettingsAsync(UpdateQuotaAdjusterSettingsRequest, CallSettings)
            // Additional: UpdateQuotaAdjusterSettingsAsync(UpdateQuotaAdjusterSettingsRequest, CancellationToken)
            // Create client
            QuotaAdjusterSettingsManagerClient quotaAdjusterSettingsManagerClient = await QuotaAdjusterSettingsManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateQuotaAdjusterSettingsRequest request = new UpdateQuotaAdjusterSettingsRequest
            {
                QuotaAdjusterSettings = new QuotaAdjusterSettings(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            QuotaAdjusterSettings response = await quotaAdjusterSettingsManagerClient.UpdateQuotaAdjusterSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateQuotaAdjusterSettings</summary>
        public void UpdateQuotaAdjusterSettings()
        {
            // Snippet: UpdateQuotaAdjusterSettings(QuotaAdjusterSettings, FieldMask, CallSettings)
            // Create client
            QuotaAdjusterSettingsManagerClient quotaAdjusterSettingsManagerClient = QuotaAdjusterSettingsManagerClient.Create();
            // Initialize request argument(s)
            QuotaAdjusterSettings quotaAdjusterSettings = new QuotaAdjusterSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            QuotaAdjusterSettings response = quotaAdjusterSettingsManagerClient.UpdateQuotaAdjusterSettings(quotaAdjusterSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateQuotaAdjusterSettingsAsync</summary>
        public async Task UpdateQuotaAdjusterSettingsAsync()
        {
            // Snippet: UpdateQuotaAdjusterSettingsAsync(QuotaAdjusterSettings, FieldMask, CallSettings)
            // Additional: UpdateQuotaAdjusterSettingsAsync(QuotaAdjusterSettings, FieldMask, CancellationToken)
            // Create client
            QuotaAdjusterSettingsManagerClient quotaAdjusterSettingsManagerClient = await QuotaAdjusterSettingsManagerClient.CreateAsync();
            // Initialize request argument(s)
            QuotaAdjusterSettings quotaAdjusterSettings = new QuotaAdjusterSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            QuotaAdjusterSettings response = await quotaAdjusterSettingsManagerClient.UpdateQuotaAdjusterSettingsAsync(quotaAdjusterSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetQuotaAdjusterSettings</summary>
        public void GetQuotaAdjusterSettingsRequestObject()
        {
            // Snippet: GetQuotaAdjusterSettings(GetQuotaAdjusterSettingsRequest, CallSettings)
            // Create client
            QuotaAdjusterSettingsManagerClient quotaAdjusterSettingsManagerClient = QuotaAdjusterSettingsManagerClient.Create();
            // Initialize request argument(s)
            GetQuotaAdjusterSettingsRequest request = new GetQuotaAdjusterSettingsRequest
            {
                QuotaAdjusterSettingsName = QuotaAdjusterSettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            QuotaAdjusterSettings response = quotaAdjusterSettingsManagerClient.GetQuotaAdjusterSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetQuotaAdjusterSettingsAsync</summary>
        public async Task GetQuotaAdjusterSettingsRequestObjectAsync()
        {
            // Snippet: GetQuotaAdjusterSettingsAsync(GetQuotaAdjusterSettingsRequest, CallSettings)
            // Additional: GetQuotaAdjusterSettingsAsync(GetQuotaAdjusterSettingsRequest, CancellationToken)
            // Create client
            QuotaAdjusterSettingsManagerClient quotaAdjusterSettingsManagerClient = await QuotaAdjusterSettingsManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetQuotaAdjusterSettingsRequest request = new GetQuotaAdjusterSettingsRequest
            {
                QuotaAdjusterSettingsName = QuotaAdjusterSettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            QuotaAdjusterSettings response = await quotaAdjusterSettingsManagerClient.GetQuotaAdjusterSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetQuotaAdjusterSettings</summary>
        public void GetQuotaAdjusterSettings()
        {
            // Snippet: GetQuotaAdjusterSettings(string, CallSettings)
            // Create client
            QuotaAdjusterSettingsManagerClient quotaAdjusterSettingsManagerClient = QuotaAdjusterSettingsManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/quotaAdjusterSettings";
            // Make the request
            QuotaAdjusterSettings response = quotaAdjusterSettingsManagerClient.GetQuotaAdjusterSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetQuotaAdjusterSettingsAsync</summary>
        public async Task GetQuotaAdjusterSettingsAsync()
        {
            // Snippet: GetQuotaAdjusterSettingsAsync(string, CallSettings)
            // Additional: GetQuotaAdjusterSettingsAsync(string, CancellationToken)
            // Create client
            QuotaAdjusterSettingsManagerClient quotaAdjusterSettingsManagerClient = await QuotaAdjusterSettingsManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/quotaAdjusterSettings";
            // Make the request
            QuotaAdjusterSettings response = await quotaAdjusterSettingsManagerClient.GetQuotaAdjusterSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetQuotaAdjusterSettings</summary>
        public void GetQuotaAdjusterSettingsResourceNames()
        {
            // Snippet: GetQuotaAdjusterSettings(QuotaAdjusterSettingsName, CallSettings)
            // Create client
            QuotaAdjusterSettingsManagerClient quotaAdjusterSettingsManagerClient = QuotaAdjusterSettingsManagerClient.Create();
            // Initialize request argument(s)
            QuotaAdjusterSettingsName name = QuotaAdjusterSettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            QuotaAdjusterSettings response = quotaAdjusterSettingsManagerClient.GetQuotaAdjusterSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetQuotaAdjusterSettingsAsync</summary>
        public async Task GetQuotaAdjusterSettingsResourceNamesAsync()
        {
            // Snippet: GetQuotaAdjusterSettingsAsync(QuotaAdjusterSettingsName, CallSettings)
            // Additional: GetQuotaAdjusterSettingsAsync(QuotaAdjusterSettingsName, CancellationToken)
            // Create client
            QuotaAdjusterSettingsManagerClient quotaAdjusterSettingsManagerClient = await QuotaAdjusterSettingsManagerClient.CreateAsync();
            // Initialize request argument(s)
            QuotaAdjusterSettingsName name = QuotaAdjusterSettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            QuotaAdjusterSettings response = await quotaAdjusterSettingsManagerClient.GetQuotaAdjusterSettingsAsync(name);
            // End snippet
        }
    }
}
