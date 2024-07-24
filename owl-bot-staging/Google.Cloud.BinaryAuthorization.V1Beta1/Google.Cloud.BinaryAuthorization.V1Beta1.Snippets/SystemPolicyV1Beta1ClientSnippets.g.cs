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
    using Google.Cloud.BinaryAuthorization.V1Beta1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSystemPolicyV1Beta1ClientSnippets
    {
        /// <summary>Snippet for GetSystemPolicy</summary>
        public void GetSystemPolicyRequestObject()
        {
            // Snippet: GetSystemPolicy(GetSystemPolicyRequest, CallSettings)
            // Create client
            SystemPolicyV1Beta1Client systemPolicyV1Beta1Client = SystemPolicyV1Beta1Client.Create();
            // Initialize request argument(s)
            GetSystemPolicyRequest request = new GetSystemPolicyRequest
            {
                PolicyName = PolicyName.FromProject("[PROJECT]"),
            };
            // Make the request
            Policy response = systemPolicyV1Beta1Client.GetSystemPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetSystemPolicyAsync</summary>
        public async Task GetSystemPolicyRequestObjectAsync()
        {
            // Snippet: GetSystemPolicyAsync(GetSystemPolicyRequest, CallSettings)
            // Additional: GetSystemPolicyAsync(GetSystemPolicyRequest, CancellationToken)
            // Create client
            SystemPolicyV1Beta1Client systemPolicyV1Beta1Client = await SystemPolicyV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            GetSystemPolicyRequest request = new GetSystemPolicyRequest
            {
                PolicyName = PolicyName.FromProject("[PROJECT]"),
            };
            // Make the request
            Policy response = await systemPolicyV1Beta1Client.GetSystemPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSystemPolicy</summary>
        public void GetSystemPolicy()
        {
            // Snippet: GetSystemPolicy(string, CallSettings)
            // Create client
            SystemPolicyV1Beta1Client systemPolicyV1Beta1Client = SystemPolicyV1Beta1Client.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/policy";
            // Make the request
            Policy response = systemPolicyV1Beta1Client.GetSystemPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetSystemPolicyAsync</summary>
        public async Task GetSystemPolicyAsync()
        {
            // Snippet: GetSystemPolicyAsync(string, CallSettings)
            // Additional: GetSystemPolicyAsync(string, CancellationToken)
            // Create client
            SystemPolicyV1Beta1Client systemPolicyV1Beta1Client = await SystemPolicyV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/policy";
            // Make the request
            Policy response = await systemPolicyV1Beta1Client.GetSystemPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSystemPolicy</summary>
        public void GetSystemPolicyResourceNames()
        {
            // Snippet: GetSystemPolicy(PolicyName, CallSettings)
            // Create client
            SystemPolicyV1Beta1Client systemPolicyV1Beta1Client = SystemPolicyV1Beta1Client.Create();
            // Initialize request argument(s)
            PolicyName name = PolicyName.FromProject("[PROJECT]");
            // Make the request
            Policy response = systemPolicyV1Beta1Client.GetSystemPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetSystemPolicyAsync</summary>
        public async Task GetSystemPolicyResourceNamesAsync()
        {
            // Snippet: GetSystemPolicyAsync(PolicyName, CallSettings)
            // Additional: GetSystemPolicyAsync(PolicyName, CancellationToken)
            // Create client
            SystemPolicyV1Beta1Client systemPolicyV1Beta1Client = await SystemPolicyV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            PolicyName name = PolicyName.FromProject("[PROJECT]");
            // Make the request
            Policy response = await systemPolicyV1Beta1Client.GetSystemPolicyAsync(name);
            // End snippet
        }
    }
}
