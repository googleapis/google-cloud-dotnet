// Copyright 2022 Google LLC
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

namespace Google.Cloud.Iap.V1.Snippets
{
    // [START iap_v1_generated_IdentityAwareProxyAdminService_UpdateTunnelDestGroup_async]
    using Google.Cloud.Iap.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedIdentityAwareProxyAdminServiceClientSnippets
    {
        /// <summary>Snippet for UpdateTunnelDestGroupAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task UpdateTunnelDestGroupRequestObjectAsync()
        {
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTunnelDestGroupRequest request = new UpdateTunnelDestGroupRequest
            {
                TunnelDestGroup = new TunnelDestGroup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            TunnelDestGroup response = await identityAwareProxyAdminServiceClient.UpdateTunnelDestGroupAsync(request);
        }
    }
    // [END iap_v1_generated_IdentityAwareProxyAdminService_UpdateTunnelDestGroup_async]
}
