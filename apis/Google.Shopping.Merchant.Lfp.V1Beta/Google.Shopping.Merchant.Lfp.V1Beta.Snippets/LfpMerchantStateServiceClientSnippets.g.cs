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
    using Google.Shopping.Merchant.Lfp.V1Beta;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLfpMerchantStateServiceClientSnippets
    {
        /// <summary>Snippet for GetLfpMerchantState</summary>
        public void GetLfpMerchantStateRequestObject()
        {
            // Snippet: GetLfpMerchantState(GetLfpMerchantStateRequest, CallSettings)
            // Create client
            LfpMerchantStateServiceClient lfpMerchantStateServiceClient = LfpMerchantStateServiceClient.Create();
            // Initialize request argument(s)
            GetLfpMerchantStateRequest request = new GetLfpMerchantStateRequest
            {
                LfpMerchantStateName = LfpMerchantStateName.FromAccountLfpMerchantState("[ACCOUNT]", "[LFP_MERCHANT_STATE]"),
            };
            // Make the request
            LfpMerchantState response = lfpMerchantStateServiceClient.GetLfpMerchantState(request);
            // End snippet
        }

        /// <summary>Snippet for GetLfpMerchantStateAsync</summary>
        public async Task GetLfpMerchantStateRequestObjectAsync()
        {
            // Snippet: GetLfpMerchantStateAsync(GetLfpMerchantStateRequest, CallSettings)
            // Additional: GetLfpMerchantStateAsync(GetLfpMerchantStateRequest, CancellationToken)
            // Create client
            LfpMerchantStateServiceClient lfpMerchantStateServiceClient = await LfpMerchantStateServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLfpMerchantStateRequest request = new GetLfpMerchantStateRequest
            {
                LfpMerchantStateName = LfpMerchantStateName.FromAccountLfpMerchantState("[ACCOUNT]", "[LFP_MERCHANT_STATE]"),
            };
            // Make the request
            LfpMerchantState response = await lfpMerchantStateServiceClient.GetLfpMerchantStateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLfpMerchantState</summary>
        public void GetLfpMerchantState()
        {
            // Snippet: GetLfpMerchantState(string, CallSettings)
            // Create client
            LfpMerchantStateServiceClient lfpMerchantStateServiceClient = LfpMerchantStateServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/lfpMerchantStates/[LFP_MERCHANT_STATE]";
            // Make the request
            LfpMerchantState response = lfpMerchantStateServiceClient.GetLfpMerchantState(name);
            // End snippet
        }

        /// <summary>Snippet for GetLfpMerchantStateAsync</summary>
        public async Task GetLfpMerchantStateAsync()
        {
            // Snippet: GetLfpMerchantStateAsync(string, CallSettings)
            // Additional: GetLfpMerchantStateAsync(string, CancellationToken)
            // Create client
            LfpMerchantStateServiceClient lfpMerchantStateServiceClient = await LfpMerchantStateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/lfpMerchantStates/[LFP_MERCHANT_STATE]";
            // Make the request
            LfpMerchantState response = await lfpMerchantStateServiceClient.GetLfpMerchantStateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLfpMerchantState</summary>
        public void GetLfpMerchantStateResourceNames()
        {
            // Snippet: GetLfpMerchantState(LfpMerchantStateName, CallSettings)
            // Create client
            LfpMerchantStateServiceClient lfpMerchantStateServiceClient = LfpMerchantStateServiceClient.Create();
            // Initialize request argument(s)
            LfpMerchantStateName name = LfpMerchantStateName.FromAccountLfpMerchantState("[ACCOUNT]", "[LFP_MERCHANT_STATE]");
            // Make the request
            LfpMerchantState response = lfpMerchantStateServiceClient.GetLfpMerchantState(name);
            // End snippet
        }

        /// <summary>Snippet for GetLfpMerchantStateAsync</summary>
        public async Task GetLfpMerchantStateResourceNamesAsync()
        {
            // Snippet: GetLfpMerchantStateAsync(LfpMerchantStateName, CallSettings)
            // Additional: GetLfpMerchantStateAsync(LfpMerchantStateName, CancellationToken)
            // Create client
            LfpMerchantStateServiceClient lfpMerchantStateServiceClient = await LfpMerchantStateServiceClient.CreateAsync();
            // Initialize request argument(s)
            LfpMerchantStateName name = LfpMerchantStateName.FromAccountLfpMerchantState("[ACCOUNT]", "[LFP_MERCHANT_STATE]");
            // Make the request
            LfpMerchantState response = await lfpMerchantStateServiceClient.GetLfpMerchantStateAsync(name);
            // End snippet
        }
    }
}
