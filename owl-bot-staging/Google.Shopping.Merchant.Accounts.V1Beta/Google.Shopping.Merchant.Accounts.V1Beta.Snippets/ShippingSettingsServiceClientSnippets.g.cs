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
    using Google.Shopping.Merchant.Accounts.V1Beta;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedShippingSettingsServiceClientSnippets
    {
        /// <summary>Snippet for GetShippingSettings</summary>
        public void GetShippingSettingsRequestObject()
        {
            // Snippet: GetShippingSettings(GetShippingSettingsRequest, CallSettings)
            // Create client
            ShippingSettingsServiceClient shippingSettingsServiceClient = ShippingSettingsServiceClient.Create();
            // Initialize request argument(s)
            GetShippingSettingsRequest request = new GetShippingSettingsRequest
            {
                ShippingSettingsName = ShippingSettingsName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            ShippingSettings response = shippingSettingsServiceClient.GetShippingSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetShippingSettingsAsync</summary>
        public async Task GetShippingSettingsRequestObjectAsync()
        {
            // Snippet: GetShippingSettingsAsync(GetShippingSettingsRequest, CallSettings)
            // Additional: GetShippingSettingsAsync(GetShippingSettingsRequest, CancellationToken)
            // Create client
            ShippingSettingsServiceClient shippingSettingsServiceClient = await ShippingSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetShippingSettingsRequest request = new GetShippingSettingsRequest
            {
                ShippingSettingsName = ShippingSettingsName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            ShippingSettings response = await shippingSettingsServiceClient.GetShippingSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetShippingSettings</summary>
        public void GetShippingSettings()
        {
            // Snippet: GetShippingSettings(string, CallSettings)
            // Create client
            ShippingSettingsServiceClient shippingSettingsServiceClient = ShippingSettingsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/shippingSettings";
            // Make the request
            ShippingSettings response = shippingSettingsServiceClient.GetShippingSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetShippingSettingsAsync</summary>
        public async Task GetShippingSettingsAsync()
        {
            // Snippet: GetShippingSettingsAsync(string, CallSettings)
            // Additional: GetShippingSettingsAsync(string, CancellationToken)
            // Create client
            ShippingSettingsServiceClient shippingSettingsServiceClient = await ShippingSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/shippingSettings";
            // Make the request
            ShippingSettings response = await shippingSettingsServiceClient.GetShippingSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetShippingSettings</summary>
        public void GetShippingSettingsResourceNames()
        {
            // Snippet: GetShippingSettings(ShippingSettingsName, CallSettings)
            // Create client
            ShippingSettingsServiceClient shippingSettingsServiceClient = ShippingSettingsServiceClient.Create();
            // Initialize request argument(s)
            ShippingSettingsName name = ShippingSettingsName.FromAccount("[ACCOUNT]");
            // Make the request
            ShippingSettings response = shippingSettingsServiceClient.GetShippingSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetShippingSettingsAsync</summary>
        public async Task GetShippingSettingsResourceNamesAsync()
        {
            // Snippet: GetShippingSettingsAsync(ShippingSettingsName, CallSettings)
            // Additional: GetShippingSettingsAsync(ShippingSettingsName, CancellationToken)
            // Create client
            ShippingSettingsServiceClient shippingSettingsServiceClient = await ShippingSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ShippingSettingsName name = ShippingSettingsName.FromAccount("[ACCOUNT]");
            // Make the request
            ShippingSettings response = await shippingSettingsServiceClient.GetShippingSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for InsertShippingSettings</summary>
        public void InsertShippingSettingsRequestObject()
        {
            // Snippet: InsertShippingSettings(InsertShippingSettingsRequest, CallSettings)
            // Create client
            ShippingSettingsServiceClient shippingSettingsServiceClient = ShippingSettingsServiceClient.Create();
            // Initialize request argument(s)
            InsertShippingSettingsRequest request = new InsertShippingSettingsRequest
            {
                Parent = "",
                ShippingSetting = new ShippingSettings(),
            };
            // Make the request
            ShippingSettings response = shippingSettingsServiceClient.InsertShippingSettings(request);
            // End snippet
        }

        /// <summary>Snippet for InsertShippingSettingsAsync</summary>
        public async Task InsertShippingSettingsRequestObjectAsync()
        {
            // Snippet: InsertShippingSettingsAsync(InsertShippingSettingsRequest, CallSettings)
            // Additional: InsertShippingSettingsAsync(InsertShippingSettingsRequest, CancellationToken)
            // Create client
            ShippingSettingsServiceClient shippingSettingsServiceClient = await ShippingSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            InsertShippingSettingsRequest request = new InsertShippingSettingsRequest
            {
                Parent = "",
                ShippingSetting = new ShippingSettings(),
            };
            // Make the request
            ShippingSettings response = await shippingSettingsServiceClient.InsertShippingSettingsAsync(request);
            // End snippet
        }
    }
}
