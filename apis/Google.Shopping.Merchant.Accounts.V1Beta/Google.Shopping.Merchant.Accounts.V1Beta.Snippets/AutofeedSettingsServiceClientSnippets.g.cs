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
    using Google.Protobuf.WellKnownTypes;
    using Google.Shopping.Merchant.Accounts.V1Beta;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAutofeedSettingsServiceClientSnippets
    {
        /// <summary>Snippet for GetAutofeedSettings</summary>
        public void GetAutofeedSettingsRequestObject()
        {
            // Snippet: GetAutofeedSettings(GetAutofeedSettingsRequest, CallSettings)
            // Create client
            AutofeedSettingsServiceClient autofeedSettingsServiceClient = AutofeedSettingsServiceClient.Create();
            // Initialize request argument(s)
            GetAutofeedSettingsRequest request = new GetAutofeedSettingsRequest
            {
                AutofeedSettingsName = AutofeedSettingsName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            AutofeedSettings response = autofeedSettingsServiceClient.GetAutofeedSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetAutofeedSettingsAsync</summary>
        public async Task GetAutofeedSettingsRequestObjectAsync()
        {
            // Snippet: GetAutofeedSettingsAsync(GetAutofeedSettingsRequest, CallSettings)
            // Additional: GetAutofeedSettingsAsync(GetAutofeedSettingsRequest, CancellationToken)
            // Create client
            AutofeedSettingsServiceClient autofeedSettingsServiceClient = await AutofeedSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAutofeedSettingsRequest request = new GetAutofeedSettingsRequest
            {
                AutofeedSettingsName = AutofeedSettingsName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            AutofeedSettings response = await autofeedSettingsServiceClient.GetAutofeedSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAutofeedSettings</summary>
        public void GetAutofeedSettings()
        {
            // Snippet: GetAutofeedSettings(string, CallSettings)
            // Create client
            AutofeedSettingsServiceClient autofeedSettingsServiceClient = AutofeedSettingsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/autofeedSettings";
            // Make the request
            AutofeedSettings response = autofeedSettingsServiceClient.GetAutofeedSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutofeedSettingsAsync</summary>
        public async Task GetAutofeedSettingsAsync()
        {
            // Snippet: GetAutofeedSettingsAsync(string, CallSettings)
            // Additional: GetAutofeedSettingsAsync(string, CancellationToken)
            // Create client
            AutofeedSettingsServiceClient autofeedSettingsServiceClient = await AutofeedSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/autofeedSettings";
            // Make the request
            AutofeedSettings response = await autofeedSettingsServiceClient.GetAutofeedSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutofeedSettings</summary>
        public void GetAutofeedSettingsResourceNames()
        {
            // Snippet: GetAutofeedSettings(AutofeedSettingsName, CallSettings)
            // Create client
            AutofeedSettingsServiceClient autofeedSettingsServiceClient = AutofeedSettingsServiceClient.Create();
            // Initialize request argument(s)
            AutofeedSettingsName name = AutofeedSettingsName.FromAccount("[ACCOUNT]");
            // Make the request
            AutofeedSettings response = autofeedSettingsServiceClient.GetAutofeedSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutofeedSettingsAsync</summary>
        public async Task GetAutofeedSettingsResourceNamesAsync()
        {
            // Snippet: GetAutofeedSettingsAsync(AutofeedSettingsName, CallSettings)
            // Additional: GetAutofeedSettingsAsync(AutofeedSettingsName, CancellationToken)
            // Create client
            AutofeedSettingsServiceClient autofeedSettingsServiceClient = await AutofeedSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AutofeedSettingsName name = AutofeedSettingsName.FromAccount("[ACCOUNT]");
            // Make the request
            AutofeedSettings response = await autofeedSettingsServiceClient.GetAutofeedSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateAutofeedSettings</summary>
        public void UpdateAutofeedSettingsRequestObject()
        {
            // Snippet: UpdateAutofeedSettings(UpdateAutofeedSettingsRequest, CallSettings)
            // Create client
            AutofeedSettingsServiceClient autofeedSettingsServiceClient = AutofeedSettingsServiceClient.Create();
            // Initialize request argument(s)
            UpdateAutofeedSettingsRequest request = new UpdateAutofeedSettingsRequest
            {
                AutofeedSettings = new AutofeedSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AutofeedSettings response = autofeedSettingsServiceClient.UpdateAutofeedSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAutofeedSettingsAsync</summary>
        public async Task UpdateAutofeedSettingsRequestObjectAsync()
        {
            // Snippet: UpdateAutofeedSettingsAsync(UpdateAutofeedSettingsRequest, CallSettings)
            // Additional: UpdateAutofeedSettingsAsync(UpdateAutofeedSettingsRequest, CancellationToken)
            // Create client
            AutofeedSettingsServiceClient autofeedSettingsServiceClient = await AutofeedSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAutofeedSettingsRequest request = new UpdateAutofeedSettingsRequest
            {
                AutofeedSettings = new AutofeedSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AutofeedSettings response = await autofeedSettingsServiceClient.UpdateAutofeedSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAutofeedSettings</summary>
        public void UpdateAutofeedSettings()
        {
            // Snippet: UpdateAutofeedSettings(AutofeedSettings, FieldMask, CallSettings)
            // Create client
            AutofeedSettingsServiceClient autofeedSettingsServiceClient = AutofeedSettingsServiceClient.Create();
            // Initialize request argument(s)
            AutofeedSettings autofeedSettings = new AutofeedSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AutofeedSettings response = autofeedSettingsServiceClient.UpdateAutofeedSettings(autofeedSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAutofeedSettingsAsync</summary>
        public async Task UpdateAutofeedSettingsAsync()
        {
            // Snippet: UpdateAutofeedSettingsAsync(AutofeedSettings, FieldMask, CallSettings)
            // Additional: UpdateAutofeedSettingsAsync(AutofeedSettings, FieldMask, CancellationToken)
            // Create client
            AutofeedSettingsServiceClient autofeedSettingsServiceClient = await AutofeedSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AutofeedSettings autofeedSettings = new AutofeedSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AutofeedSettings response = await autofeedSettingsServiceClient.UpdateAutofeedSettingsAsync(autofeedSettings, updateMask);
            // End snippet
        }
    }
}
