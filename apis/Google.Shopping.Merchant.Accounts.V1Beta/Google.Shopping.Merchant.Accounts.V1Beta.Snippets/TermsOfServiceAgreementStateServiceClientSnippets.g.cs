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
    public sealed class AllGeneratedTermsOfServiceAgreementStateServiceClientSnippets
    {
        /// <summary>Snippet for GetTermsOfServiceAgreementState</summary>
        public void GetTermsOfServiceAgreementStateRequestObject()
        {
            // Snippet: GetTermsOfServiceAgreementState(GetTermsOfServiceAgreementStateRequest, CallSettings)
            // Create client
            TermsOfServiceAgreementStateServiceClient termsOfServiceAgreementStateServiceClient = TermsOfServiceAgreementStateServiceClient.Create();
            // Initialize request argument(s)
            GetTermsOfServiceAgreementStateRequest request = new GetTermsOfServiceAgreementStateRequest
            {
                TermsOfServiceAgreementStateName = TermsOfServiceAgreementStateName.FromAccountIdentifier("[ACCOUNT]", "[IDENTIFIER]"),
            };
            // Make the request
            TermsOfServiceAgreementState response = termsOfServiceAgreementStateServiceClient.GetTermsOfServiceAgreementState(request);
            // End snippet
        }

        /// <summary>Snippet for GetTermsOfServiceAgreementStateAsync</summary>
        public async Task GetTermsOfServiceAgreementStateRequestObjectAsync()
        {
            // Snippet: GetTermsOfServiceAgreementStateAsync(GetTermsOfServiceAgreementStateRequest, CallSettings)
            // Additional: GetTermsOfServiceAgreementStateAsync(GetTermsOfServiceAgreementStateRequest, CancellationToken)
            // Create client
            TermsOfServiceAgreementStateServiceClient termsOfServiceAgreementStateServiceClient = await TermsOfServiceAgreementStateServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTermsOfServiceAgreementStateRequest request = new GetTermsOfServiceAgreementStateRequest
            {
                TermsOfServiceAgreementStateName = TermsOfServiceAgreementStateName.FromAccountIdentifier("[ACCOUNT]", "[IDENTIFIER]"),
            };
            // Make the request
            TermsOfServiceAgreementState response = await termsOfServiceAgreementStateServiceClient.GetTermsOfServiceAgreementStateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTermsOfServiceAgreementState</summary>
        public void GetTermsOfServiceAgreementState()
        {
            // Snippet: GetTermsOfServiceAgreementState(string, CallSettings)
            // Create client
            TermsOfServiceAgreementStateServiceClient termsOfServiceAgreementStateServiceClient = TermsOfServiceAgreementStateServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/termsOfServiceAgreementStates/[IDENTIFIER]";
            // Make the request
            TermsOfServiceAgreementState response = termsOfServiceAgreementStateServiceClient.GetTermsOfServiceAgreementState(name);
            // End snippet
        }

        /// <summary>Snippet for GetTermsOfServiceAgreementStateAsync</summary>
        public async Task GetTermsOfServiceAgreementStateAsync()
        {
            // Snippet: GetTermsOfServiceAgreementStateAsync(string, CallSettings)
            // Additional: GetTermsOfServiceAgreementStateAsync(string, CancellationToken)
            // Create client
            TermsOfServiceAgreementStateServiceClient termsOfServiceAgreementStateServiceClient = await TermsOfServiceAgreementStateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/termsOfServiceAgreementStates/[IDENTIFIER]";
            // Make the request
            TermsOfServiceAgreementState response = await termsOfServiceAgreementStateServiceClient.GetTermsOfServiceAgreementStateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTermsOfServiceAgreementState</summary>
        public void GetTermsOfServiceAgreementStateResourceNames()
        {
            // Snippet: GetTermsOfServiceAgreementState(TermsOfServiceAgreementStateName, CallSettings)
            // Create client
            TermsOfServiceAgreementStateServiceClient termsOfServiceAgreementStateServiceClient = TermsOfServiceAgreementStateServiceClient.Create();
            // Initialize request argument(s)
            TermsOfServiceAgreementStateName name = TermsOfServiceAgreementStateName.FromAccountIdentifier("[ACCOUNT]", "[IDENTIFIER]");
            // Make the request
            TermsOfServiceAgreementState response = termsOfServiceAgreementStateServiceClient.GetTermsOfServiceAgreementState(name);
            // End snippet
        }

        /// <summary>Snippet for GetTermsOfServiceAgreementStateAsync</summary>
        public async Task GetTermsOfServiceAgreementStateResourceNamesAsync()
        {
            // Snippet: GetTermsOfServiceAgreementStateAsync(TermsOfServiceAgreementStateName, CallSettings)
            // Additional: GetTermsOfServiceAgreementStateAsync(TermsOfServiceAgreementStateName, CancellationToken)
            // Create client
            TermsOfServiceAgreementStateServiceClient termsOfServiceAgreementStateServiceClient = await TermsOfServiceAgreementStateServiceClient.CreateAsync();
            // Initialize request argument(s)
            TermsOfServiceAgreementStateName name = TermsOfServiceAgreementStateName.FromAccountIdentifier("[ACCOUNT]", "[IDENTIFIER]");
            // Make the request
            TermsOfServiceAgreementState response = await termsOfServiceAgreementStateServiceClient.GetTermsOfServiceAgreementStateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RetrieveForApplicationTermsOfServiceAgreementState</summary>
        public void RetrieveForApplicationTermsOfServiceAgreementStateRequestObject()
        {
            // Snippet: RetrieveForApplicationTermsOfServiceAgreementState(RetrieveForApplicationTermsOfServiceAgreementStateRequest, CallSettings)
            // Create client
            TermsOfServiceAgreementStateServiceClient termsOfServiceAgreementStateServiceClient = TermsOfServiceAgreementStateServiceClient.Create();
            // Initialize request argument(s)
            RetrieveForApplicationTermsOfServiceAgreementStateRequest request = new RetrieveForApplicationTermsOfServiceAgreementStateRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            TermsOfServiceAgreementState response = termsOfServiceAgreementStateServiceClient.RetrieveForApplicationTermsOfServiceAgreementState(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveForApplicationTermsOfServiceAgreementStateAsync</summary>
        public async Task RetrieveForApplicationTermsOfServiceAgreementStateRequestObjectAsync()
        {
            // Snippet: RetrieveForApplicationTermsOfServiceAgreementStateAsync(RetrieveForApplicationTermsOfServiceAgreementStateRequest, CallSettings)
            // Additional: RetrieveForApplicationTermsOfServiceAgreementStateAsync(RetrieveForApplicationTermsOfServiceAgreementStateRequest, CancellationToken)
            // Create client
            TermsOfServiceAgreementStateServiceClient termsOfServiceAgreementStateServiceClient = await TermsOfServiceAgreementStateServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveForApplicationTermsOfServiceAgreementStateRequest request = new RetrieveForApplicationTermsOfServiceAgreementStateRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            TermsOfServiceAgreementState response = await termsOfServiceAgreementStateServiceClient.RetrieveForApplicationTermsOfServiceAgreementStateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveForApplicationTermsOfServiceAgreementState</summary>
        public void RetrieveForApplicationTermsOfServiceAgreementState()
        {
            // Snippet: RetrieveForApplicationTermsOfServiceAgreementState(string, CallSettings)
            // Create client
            TermsOfServiceAgreementStateServiceClient termsOfServiceAgreementStateServiceClient = TermsOfServiceAgreementStateServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            TermsOfServiceAgreementState response = termsOfServiceAgreementStateServiceClient.RetrieveForApplicationTermsOfServiceAgreementState(parent);
            // End snippet
        }

        /// <summary>Snippet for RetrieveForApplicationTermsOfServiceAgreementStateAsync</summary>
        public async Task RetrieveForApplicationTermsOfServiceAgreementStateAsync()
        {
            // Snippet: RetrieveForApplicationTermsOfServiceAgreementStateAsync(string, CallSettings)
            // Additional: RetrieveForApplicationTermsOfServiceAgreementStateAsync(string, CancellationToken)
            // Create client
            TermsOfServiceAgreementStateServiceClient termsOfServiceAgreementStateServiceClient = await TermsOfServiceAgreementStateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            TermsOfServiceAgreementState response = await termsOfServiceAgreementStateServiceClient.RetrieveForApplicationTermsOfServiceAgreementStateAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for RetrieveForApplicationTermsOfServiceAgreementState</summary>
        public void RetrieveForApplicationTermsOfServiceAgreementStateResourceNames()
        {
            // Snippet: RetrieveForApplicationTermsOfServiceAgreementState(AccountName, CallSettings)
            // Create client
            TermsOfServiceAgreementStateServiceClient termsOfServiceAgreementStateServiceClient = TermsOfServiceAgreementStateServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            TermsOfServiceAgreementState response = termsOfServiceAgreementStateServiceClient.RetrieveForApplicationTermsOfServiceAgreementState(parent);
            // End snippet
        }

        /// <summary>Snippet for RetrieveForApplicationTermsOfServiceAgreementStateAsync</summary>
        public async Task RetrieveForApplicationTermsOfServiceAgreementStateResourceNamesAsync()
        {
            // Snippet: RetrieveForApplicationTermsOfServiceAgreementStateAsync(AccountName, CallSettings)
            // Additional: RetrieveForApplicationTermsOfServiceAgreementStateAsync(AccountName, CancellationToken)
            // Create client
            TermsOfServiceAgreementStateServiceClient termsOfServiceAgreementStateServiceClient = await TermsOfServiceAgreementStateServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            TermsOfServiceAgreementState response = await termsOfServiceAgreementStateServiceClient.RetrieveForApplicationTermsOfServiceAgreementStateAsync(parent);
            // End snippet
        }
    }
}
