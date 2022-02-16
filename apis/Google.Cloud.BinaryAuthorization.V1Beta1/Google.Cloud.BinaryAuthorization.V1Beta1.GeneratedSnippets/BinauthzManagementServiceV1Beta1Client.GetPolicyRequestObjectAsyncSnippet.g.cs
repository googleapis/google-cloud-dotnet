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

namespace Google.Cloud.BinaryAuthorization.V1Beta1.Snippets
{
    // [START binaryauthorization_v1beta1_generated_BinauthzManagementServiceV1Beta1_GetPolicy_async]
    using Google.Cloud.BinaryAuthorization.V1Beta1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedBinauthzManagementServiceV1Beta1ClientSnippets
    {
        /// <summary>Snippet for GetPolicyAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetPolicyRequestObjectAsync()
        {
            // Create client
            BinauthzManagementServiceV1Beta1Client binauthzManagementServiceV1Beta1Client = await BinauthzManagementServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            GetPolicyRequest request = new GetPolicyRequest
            {
                PolicyName = PolicyName.FromProject("[PROJECT]"),
            };
            // Make the request
            Policy response = await binauthzManagementServiceV1Beta1Client.GetPolicyAsync(request);
        }
    }
    // [END binaryauthorization_v1beta1_generated_BinauthzManagementServiceV1Beta1_GetPolicy_async]
}
