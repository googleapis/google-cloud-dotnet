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
    using Google.Protobuf.WellKnownTypes;
    using Google.Shopping.Merchant.Accounts.V1Beta;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBusinessInfoServiceClientSnippets
    {
        /// <summary>Snippet for GetBusinessInfo</summary>
        public void GetBusinessInfoRequestObject()
        {
            // Snippet: GetBusinessInfo(GetBusinessInfoRequest, CallSettings)
            // Create client
            BusinessInfoServiceClient businessInfoServiceClient = BusinessInfoServiceClient.Create();
            // Initialize request argument(s)
            GetBusinessInfoRequest request = new GetBusinessInfoRequest
            {
                BusinessInfoName = BusinessInfoName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            BusinessInfo response = businessInfoServiceClient.GetBusinessInfo(request);
            // End snippet
        }

        /// <summary>Snippet for GetBusinessInfoAsync</summary>
        public async Task GetBusinessInfoRequestObjectAsync()
        {
            // Snippet: GetBusinessInfoAsync(GetBusinessInfoRequest, CallSettings)
            // Additional: GetBusinessInfoAsync(GetBusinessInfoRequest, CancellationToken)
            // Create client
            BusinessInfoServiceClient businessInfoServiceClient = await BusinessInfoServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBusinessInfoRequest request = new GetBusinessInfoRequest
            {
                BusinessInfoName = BusinessInfoName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            BusinessInfo response = await businessInfoServiceClient.GetBusinessInfoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBusinessInfo</summary>
        public void GetBusinessInfo()
        {
            // Snippet: GetBusinessInfo(string, CallSettings)
            // Create client
            BusinessInfoServiceClient businessInfoServiceClient = BusinessInfoServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/businessInfo";
            // Make the request
            BusinessInfo response = businessInfoServiceClient.GetBusinessInfo(name);
            // End snippet
        }

        /// <summary>Snippet for GetBusinessInfoAsync</summary>
        public async Task GetBusinessInfoAsync()
        {
            // Snippet: GetBusinessInfoAsync(string, CallSettings)
            // Additional: GetBusinessInfoAsync(string, CancellationToken)
            // Create client
            BusinessInfoServiceClient businessInfoServiceClient = await BusinessInfoServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/businessInfo";
            // Make the request
            BusinessInfo response = await businessInfoServiceClient.GetBusinessInfoAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBusinessInfo</summary>
        public void GetBusinessInfoResourceNames()
        {
            // Snippet: GetBusinessInfo(BusinessInfoName, CallSettings)
            // Create client
            BusinessInfoServiceClient businessInfoServiceClient = BusinessInfoServiceClient.Create();
            // Initialize request argument(s)
            BusinessInfoName name = BusinessInfoName.FromAccount("[ACCOUNT]");
            // Make the request
            BusinessInfo response = businessInfoServiceClient.GetBusinessInfo(name);
            // End snippet
        }

        /// <summary>Snippet for GetBusinessInfoAsync</summary>
        public async Task GetBusinessInfoResourceNamesAsync()
        {
            // Snippet: GetBusinessInfoAsync(BusinessInfoName, CallSettings)
            // Additional: GetBusinessInfoAsync(BusinessInfoName, CancellationToken)
            // Create client
            BusinessInfoServiceClient businessInfoServiceClient = await BusinessInfoServiceClient.CreateAsync();
            // Initialize request argument(s)
            BusinessInfoName name = BusinessInfoName.FromAccount("[ACCOUNT]");
            // Make the request
            BusinessInfo response = await businessInfoServiceClient.GetBusinessInfoAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateBusinessInfo</summary>
        public void UpdateBusinessInfoRequestObject()
        {
            // Snippet: UpdateBusinessInfo(UpdateBusinessInfoRequest, CallSettings)
            // Create client
            BusinessInfoServiceClient businessInfoServiceClient = BusinessInfoServiceClient.Create();
            // Initialize request argument(s)
            UpdateBusinessInfoRequest request = new UpdateBusinessInfoRequest
            {
                BusinessInfo = new BusinessInfo(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            BusinessInfo response = businessInfoServiceClient.UpdateBusinessInfo(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBusinessInfoAsync</summary>
        public async Task UpdateBusinessInfoRequestObjectAsync()
        {
            // Snippet: UpdateBusinessInfoAsync(UpdateBusinessInfoRequest, CallSettings)
            // Additional: UpdateBusinessInfoAsync(UpdateBusinessInfoRequest, CancellationToken)
            // Create client
            BusinessInfoServiceClient businessInfoServiceClient = await BusinessInfoServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBusinessInfoRequest request = new UpdateBusinessInfoRequest
            {
                BusinessInfo = new BusinessInfo(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            BusinessInfo response = await businessInfoServiceClient.UpdateBusinessInfoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBusinessInfo</summary>
        public void UpdateBusinessInfo()
        {
            // Snippet: UpdateBusinessInfo(BusinessInfo, FieldMask, CallSettings)
            // Create client
            BusinessInfoServiceClient businessInfoServiceClient = BusinessInfoServiceClient.Create();
            // Initialize request argument(s)
            BusinessInfo businessInfo = new BusinessInfo();
            FieldMask updateMask = new FieldMask();
            // Make the request
            BusinessInfo response = businessInfoServiceClient.UpdateBusinessInfo(businessInfo, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateBusinessInfoAsync</summary>
        public async Task UpdateBusinessInfoAsync()
        {
            // Snippet: UpdateBusinessInfoAsync(BusinessInfo, FieldMask, CallSettings)
            // Additional: UpdateBusinessInfoAsync(BusinessInfo, FieldMask, CancellationToken)
            // Create client
            BusinessInfoServiceClient businessInfoServiceClient = await BusinessInfoServiceClient.CreateAsync();
            // Initialize request argument(s)
            BusinessInfo businessInfo = new BusinessInfo();
            FieldMask updateMask = new FieldMask();
            // Make the request
            BusinessInfo response = await businessInfoServiceClient.UpdateBusinessInfoAsync(businessInfo, updateMask);
            // End snippet
        }
    }
}
