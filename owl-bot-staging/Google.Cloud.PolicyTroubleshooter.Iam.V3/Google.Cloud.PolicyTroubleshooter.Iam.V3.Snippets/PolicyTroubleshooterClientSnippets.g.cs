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
    using Google.Cloud.PolicyTroubleshooter.Iam.V3;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPolicyTroubleshooterClientSnippets
    {
        /// <summary>Snippet for TroubleshootIamPolicy</summary>
        public void TroubleshootIamPolicyRequestObject()
        {
            // Snippet: TroubleshootIamPolicy(TroubleshootIamPolicyRequest, CallSettings)
            // Create client
            PolicyTroubleshooterClient policyTroubleshooterClient = PolicyTroubleshooterClient.Create();
            // Initialize request argument(s)
            TroubleshootIamPolicyRequest request = new TroubleshootIamPolicyRequest
            {
                AccessTuple = new AccessTuple(),
            };
            // Make the request
            TroubleshootIamPolicyResponse response = policyTroubleshooterClient.TroubleshootIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for TroubleshootIamPolicyAsync</summary>
        public async Task TroubleshootIamPolicyRequestObjectAsync()
        {
            // Snippet: TroubleshootIamPolicyAsync(TroubleshootIamPolicyRequest, CallSettings)
            // Additional: TroubleshootIamPolicyAsync(TroubleshootIamPolicyRequest, CancellationToken)
            // Create client
            PolicyTroubleshooterClient policyTroubleshooterClient = await PolicyTroubleshooterClient.CreateAsync();
            // Initialize request argument(s)
            TroubleshootIamPolicyRequest request = new TroubleshootIamPolicyRequest
            {
                AccessTuple = new AccessTuple(),
            };
            // Make the request
            TroubleshootIamPolicyResponse response = await policyTroubleshooterClient.TroubleshootIamPolicyAsync(request);
            // End snippet
        }
    }
}
