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
    using Google.Cloud.DiscoveryEngine.V1Beta;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAclConfigServiceClientSnippets
    {
        /// <summary>Snippet for UpdateAclConfig</summary>
        public void UpdateAclConfigRequestObject()
        {
            // Snippet: UpdateAclConfig(UpdateAclConfigRequest, CallSettings)
            // Create client
            AclConfigServiceClient aclConfigServiceClient = AclConfigServiceClient.Create();
            // Initialize request argument(s)
            UpdateAclConfigRequest request = new UpdateAclConfigRequest
            {
                AclConfig = new AclConfig(),
            };
            // Make the request
            AclConfig response = aclConfigServiceClient.UpdateAclConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAclConfigAsync</summary>
        public async Task UpdateAclConfigRequestObjectAsync()
        {
            // Snippet: UpdateAclConfigAsync(UpdateAclConfigRequest, CallSettings)
            // Additional: UpdateAclConfigAsync(UpdateAclConfigRequest, CancellationToken)
            // Create client
            AclConfigServiceClient aclConfigServiceClient = await AclConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAclConfigRequest request = new UpdateAclConfigRequest
            {
                AclConfig = new AclConfig(),
            };
            // Make the request
            AclConfig response = await aclConfigServiceClient.UpdateAclConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAclConfig</summary>
        public void GetAclConfigRequestObject()
        {
            // Snippet: GetAclConfig(GetAclConfigRequest, CallSettings)
            // Create client
            AclConfigServiceClient aclConfigServiceClient = AclConfigServiceClient.Create();
            // Initialize request argument(s)
            GetAclConfigRequest request = new GetAclConfigRequest
            {
                AclConfigName = AclConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            AclConfig response = aclConfigServiceClient.GetAclConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetAclConfigAsync</summary>
        public async Task GetAclConfigRequestObjectAsync()
        {
            // Snippet: GetAclConfigAsync(GetAclConfigRequest, CallSettings)
            // Additional: GetAclConfigAsync(GetAclConfigRequest, CancellationToken)
            // Create client
            AclConfigServiceClient aclConfigServiceClient = await AclConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAclConfigRequest request = new GetAclConfigRequest
            {
                AclConfigName = AclConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            AclConfig response = await aclConfigServiceClient.GetAclConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAclConfig</summary>
        public void GetAclConfig()
        {
            // Snippet: GetAclConfig(string, CallSettings)
            // Create client
            AclConfigServiceClient aclConfigServiceClient = AclConfigServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/aclConfig";
            // Make the request
            AclConfig response = aclConfigServiceClient.GetAclConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetAclConfigAsync</summary>
        public async Task GetAclConfigAsync()
        {
            // Snippet: GetAclConfigAsync(string, CallSettings)
            // Additional: GetAclConfigAsync(string, CancellationToken)
            // Create client
            AclConfigServiceClient aclConfigServiceClient = await AclConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/aclConfig";
            // Make the request
            AclConfig response = await aclConfigServiceClient.GetAclConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAclConfig</summary>
        public void GetAclConfigResourceNames()
        {
            // Snippet: GetAclConfig(AclConfigName, CallSettings)
            // Create client
            AclConfigServiceClient aclConfigServiceClient = AclConfigServiceClient.Create();
            // Initialize request argument(s)
            AclConfigName name = AclConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            AclConfig response = aclConfigServiceClient.GetAclConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetAclConfigAsync</summary>
        public async Task GetAclConfigResourceNamesAsync()
        {
            // Snippet: GetAclConfigAsync(AclConfigName, CallSettings)
            // Additional: GetAclConfigAsync(AclConfigName, CancellationToken)
            // Create client
            AclConfigServiceClient aclConfigServiceClient = await AclConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            AclConfigName name = AclConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            AclConfig response = await aclConfigServiceClient.GetAclConfigAsync(name);
            // End snippet
        }
    }
}
