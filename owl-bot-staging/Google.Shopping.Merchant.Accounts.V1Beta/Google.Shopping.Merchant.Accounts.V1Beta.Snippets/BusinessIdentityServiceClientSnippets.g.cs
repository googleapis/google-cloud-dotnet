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
    public sealed class AllGeneratedBusinessIdentityServiceClientSnippets
    {
        /// <summary>Snippet for GetBusinessIdentity</summary>
        public void GetBusinessIdentityRequestObject()
        {
            // Snippet: GetBusinessIdentity(GetBusinessIdentityRequest, CallSettings)
            // Create client
            BusinessIdentityServiceClient businessIdentityServiceClient = BusinessIdentityServiceClient.Create();
            // Initialize request argument(s)
            GetBusinessIdentityRequest request = new GetBusinessIdentityRequest
            {
                BusinessIdentityName = BusinessIdentityName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            BusinessIdentity response = businessIdentityServiceClient.GetBusinessIdentity(request);
            // End snippet
        }

        /// <summary>Snippet for GetBusinessIdentityAsync</summary>
        public async Task GetBusinessIdentityRequestObjectAsync()
        {
            // Snippet: GetBusinessIdentityAsync(GetBusinessIdentityRequest, CallSettings)
            // Additional: GetBusinessIdentityAsync(GetBusinessIdentityRequest, CancellationToken)
            // Create client
            BusinessIdentityServiceClient businessIdentityServiceClient = await BusinessIdentityServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBusinessIdentityRequest request = new GetBusinessIdentityRequest
            {
                BusinessIdentityName = BusinessIdentityName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            BusinessIdentity response = await businessIdentityServiceClient.GetBusinessIdentityAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBusinessIdentity</summary>
        public void GetBusinessIdentity()
        {
            // Snippet: GetBusinessIdentity(string, CallSettings)
            // Create client
            BusinessIdentityServiceClient businessIdentityServiceClient = BusinessIdentityServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/businessIdentity";
            // Make the request
            BusinessIdentity response = businessIdentityServiceClient.GetBusinessIdentity(name);
            // End snippet
        }

        /// <summary>Snippet for GetBusinessIdentityAsync</summary>
        public async Task GetBusinessIdentityAsync()
        {
            // Snippet: GetBusinessIdentityAsync(string, CallSettings)
            // Additional: GetBusinessIdentityAsync(string, CancellationToken)
            // Create client
            BusinessIdentityServiceClient businessIdentityServiceClient = await BusinessIdentityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/businessIdentity";
            // Make the request
            BusinessIdentity response = await businessIdentityServiceClient.GetBusinessIdentityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBusinessIdentity</summary>
        public void GetBusinessIdentityResourceNames()
        {
            // Snippet: GetBusinessIdentity(BusinessIdentityName, CallSettings)
            // Create client
            BusinessIdentityServiceClient businessIdentityServiceClient = BusinessIdentityServiceClient.Create();
            // Initialize request argument(s)
            BusinessIdentityName name = BusinessIdentityName.FromAccount("[ACCOUNT]");
            // Make the request
            BusinessIdentity response = businessIdentityServiceClient.GetBusinessIdentity(name);
            // End snippet
        }

        /// <summary>Snippet for GetBusinessIdentityAsync</summary>
        public async Task GetBusinessIdentityResourceNamesAsync()
        {
            // Snippet: GetBusinessIdentityAsync(BusinessIdentityName, CallSettings)
            // Additional: GetBusinessIdentityAsync(BusinessIdentityName, CancellationToken)
            // Create client
            BusinessIdentityServiceClient businessIdentityServiceClient = await BusinessIdentityServiceClient.CreateAsync();
            // Initialize request argument(s)
            BusinessIdentityName name = BusinessIdentityName.FromAccount("[ACCOUNT]");
            // Make the request
            BusinessIdentity response = await businessIdentityServiceClient.GetBusinessIdentityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateBusinessIdentity</summary>
        public void UpdateBusinessIdentityRequestObject()
        {
            // Snippet: UpdateBusinessIdentity(UpdateBusinessIdentityRequest, CallSettings)
            // Create client
            BusinessIdentityServiceClient businessIdentityServiceClient = BusinessIdentityServiceClient.Create();
            // Initialize request argument(s)
            UpdateBusinessIdentityRequest request = new UpdateBusinessIdentityRequest
            {
                BusinessIdentity = new BusinessIdentity(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            BusinessIdentity response = businessIdentityServiceClient.UpdateBusinessIdentity(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBusinessIdentityAsync</summary>
        public async Task UpdateBusinessIdentityRequestObjectAsync()
        {
            // Snippet: UpdateBusinessIdentityAsync(UpdateBusinessIdentityRequest, CallSettings)
            // Additional: UpdateBusinessIdentityAsync(UpdateBusinessIdentityRequest, CancellationToken)
            // Create client
            BusinessIdentityServiceClient businessIdentityServiceClient = await BusinessIdentityServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBusinessIdentityRequest request = new UpdateBusinessIdentityRequest
            {
                BusinessIdentity = new BusinessIdentity(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            BusinessIdentity response = await businessIdentityServiceClient.UpdateBusinessIdentityAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBusinessIdentity</summary>
        public void UpdateBusinessIdentity()
        {
            // Snippet: UpdateBusinessIdentity(BusinessIdentity, FieldMask, CallSettings)
            // Create client
            BusinessIdentityServiceClient businessIdentityServiceClient = BusinessIdentityServiceClient.Create();
            // Initialize request argument(s)
            BusinessIdentity businessIdentity = new BusinessIdentity();
            FieldMask updateMask = new FieldMask();
            // Make the request
            BusinessIdentity response = businessIdentityServiceClient.UpdateBusinessIdentity(businessIdentity, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateBusinessIdentityAsync</summary>
        public async Task UpdateBusinessIdentityAsync()
        {
            // Snippet: UpdateBusinessIdentityAsync(BusinessIdentity, FieldMask, CallSettings)
            // Additional: UpdateBusinessIdentityAsync(BusinessIdentity, FieldMask, CancellationToken)
            // Create client
            BusinessIdentityServiceClient businessIdentityServiceClient = await BusinessIdentityServiceClient.CreateAsync();
            // Initialize request argument(s)
            BusinessIdentity businessIdentity = new BusinessIdentity();
            FieldMask updateMask = new FieldMask();
            // Make the request
            BusinessIdentity response = await businessIdentityServiceClient.UpdateBusinessIdentityAsync(businessIdentity, updateMask);
            // End snippet
        }
    }
}
