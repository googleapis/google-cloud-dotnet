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

namespace Google.Identity.AccessContextManager.V1.Snippets
{
    // [START accesscontextmanager_v1_generated_AccessContextManager_GetAccessPolicy_async]
    using Google.Identity.AccessContextManager.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAccessContextManagerClientSnippets
    {
        /// <summary>Snippet for GetAccessPolicyAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetAccessPolicyRequestObjectAsync()
        {
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetAccessPolicyRequest request = new GetAccessPolicyRequest
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
            };
            // Make the request
            AccessPolicy response = await accessContextManagerClient.GetAccessPolicyAsync(request);
        }
    }
    // [END accesscontextmanager_v1_generated_AccessContextManager_GetAccessPolicy_async]
}
