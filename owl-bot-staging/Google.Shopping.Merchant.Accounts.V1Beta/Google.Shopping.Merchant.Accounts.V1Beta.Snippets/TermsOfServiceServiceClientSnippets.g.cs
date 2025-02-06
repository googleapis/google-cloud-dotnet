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
    public sealed class AllGeneratedTermsOfServiceServiceClientSnippets
    {
        /// <summary>Snippet for GetTermsOfService</summary>
        public void GetTermsOfServiceRequestObject()
        {
            // Snippet: GetTermsOfService(GetTermsOfServiceRequest, CallSettings)
            // Create client
            TermsOfServiceServiceClient termsOfServiceServiceClient = TermsOfServiceServiceClient.Create();
            // Initialize request argument(s)
            GetTermsOfServiceRequest request = new GetTermsOfServiceRequest
            {
                TermsOfServiceName = TermsOfServiceName.FromVersion("[VERSION]"),
            };
            // Make the request
            TermsOfService response = termsOfServiceServiceClient.GetTermsOfService(request);
            // End snippet
        }

        /// <summary>Snippet for GetTermsOfServiceAsync</summary>
        public async Task GetTermsOfServiceRequestObjectAsync()
        {
            // Snippet: GetTermsOfServiceAsync(GetTermsOfServiceRequest, CallSettings)
            // Additional: GetTermsOfServiceAsync(GetTermsOfServiceRequest, CancellationToken)
            // Create client
            TermsOfServiceServiceClient termsOfServiceServiceClient = await TermsOfServiceServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTermsOfServiceRequest request = new GetTermsOfServiceRequest
            {
                TermsOfServiceName = TermsOfServiceName.FromVersion("[VERSION]"),
            };
            // Make the request
            TermsOfService response = await termsOfServiceServiceClient.GetTermsOfServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTermsOfService</summary>
        public void GetTermsOfService()
        {
            // Snippet: GetTermsOfService(string, CallSettings)
            // Create client
            TermsOfServiceServiceClient termsOfServiceServiceClient = TermsOfServiceServiceClient.Create();
            // Initialize request argument(s)
            string name = "termsOfService/[VERSION]";
            // Make the request
            TermsOfService response = termsOfServiceServiceClient.GetTermsOfService(name);
            // End snippet
        }

        /// <summary>Snippet for GetTermsOfServiceAsync</summary>
        public async Task GetTermsOfServiceAsync()
        {
            // Snippet: GetTermsOfServiceAsync(string, CallSettings)
            // Additional: GetTermsOfServiceAsync(string, CancellationToken)
            // Create client
            TermsOfServiceServiceClient termsOfServiceServiceClient = await TermsOfServiceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "termsOfService/[VERSION]";
            // Make the request
            TermsOfService response = await termsOfServiceServiceClient.GetTermsOfServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTermsOfService</summary>
        public void GetTermsOfServiceResourceNames()
        {
            // Snippet: GetTermsOfService(TermsOfServiceName, CallSettings)
            // Create client
            TermsOfServiceServiceClient termsOfServiceServiceClient = TermsOfServiceServiceClient.Create();
            // Initialize request argument(s)
            TermsOfServiceName name = TermsOfServiceName.FromVersion("[VERSION]");
            // Make the request
            TermsOfService response = termsOfServiceServiceClient.GetTermsOfService(name);
            // End snippet
        }

        /// <summary>Snippet for GetTermsOfServiceAsync</summary>
        public async Task GetTermsOfServiceResourceNamesAsync()
        {
            // Snippet: GetTermsOfServiceAsync(TermsOfServiceName, CallSettings)
            // Additional: GetTermsOfServiceAsync(TermsOfServiceName, CancellationToken)
            // Create client
            TermsOfServiceServiceClient termsOfServiceServiceClient = await TermsOfServiceServiceClient.CreateAsync();
            // Initialize request argument(s)
            TermsOfServiceName name = TermsOfServiceName.FromVersion("[VERSION]");
            // Make the request
            TermsOfService response = await termsOfServiceServiceClient.GetTermsOfServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RetrieveLatestTermsOfService</summary>
        public void RetrieveLatestTermsOfServiceRequestObject()
        {
            // Snippet: RetrieveLatestTermsOfService(RetrieveLatestTermsOfServiceRequest, CallSettings)
            // Create client
            TermsOfServiceServiceClient termsOfServiceServiceClient = TermsOfServiceServiceClient.Create();
            // Initialize request argument(s)
            RetrieveLatestTermsOfServiceRequest request = new RetrieveLatestTermsOfServiceRequest
            {
                RegionCode = "",
                Kind = TermsOfServiceKind.Unspecified,
            };
            // Make the request
            TermsOfService response = termsOfServiceServiceClient.RetrieveLatestTermsOfService(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveLatestTermsOfServiceAsync</summary>
        public async Task RetrieveLatestTermsOfServiceRequestObjectAsync()
        {
            // Snippet: RetrieveLatestTermsOfServiceAsync(RetrieveLatestTermsOfServiceRequest, CallSettings)
            // Additional: RetrieveLatestTermsOfServiceAsync(RetrieveLatestTermsOfServiceRequest, CancellationToken)
            // Create client
            TermsOfServiceServiceClient termsOfServiceServiceClient = await TermsOfServiceServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveLatestTermsOfServiceRequest request = new RetrieveLatestTermsOfServiceRequest
            {
                RegionCode = "",
                Kind = TermsOfServiceKind.Unspecified,
            };
            // Make the request
            TermsOfService response = await termsOfServiceServiceClient.RetrieveLatestTermsOfServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AcceptTermsOfService</summary>
        public void AcceptTermsOfServiceRequestObject()
        {
            // Snippet: AcceptTermsOfService(AcceptTermsOfServiceRequest, CallSettings)
            // Create client
            TermsOfServiceServiceClient termsOfServiceServiceClient = TermsOfServiceServiceClient.Create();
            // Initialize request argument(s)
            AcceptTermsOfServiceRequest request = new AcceptTermsOfServiceRequest
            {
                TermsOfServiceName = TermsOfServiceName.FromVersion("[VERSION]"),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                RegionCode = "",
            };
            // Make the request
            termsOfServiceServiceClient.AcceptTermsOfService(request);
            // End snippet
        }

        /// <summary>Snippet for AcceptTermsOfServiceAsync</summary>
        public async Task AcceptTermsOfServiceRequestObjectAsync()
        {
            // Snippet: AcceptTermsOfServiceAsync(AcceptTermsOfServiceRequest, CallSettings)
            // Additional: AcceptTermsOfServiceAsync(AcceptTermsOfServiceRequest, CancellationToken)
            // Create client
            TermsOfServiceServiceClient termsOfServiceServiceClient = await TermsOfServiceServiceClient.CreateAsync();
            // Initialize request argument(s)
            AcceptTermsOfServiceRequest request = new AcceptTermsOfServiceRequest
            {
                TermsOfServiceName = TermsOfServiceName.FromVersion("[VERSION]"),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                RegionCode = "",
            };
            // Make the request
            await termsOfServiceServiceClient.AcceptTermsOfServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AcceptTermsOfService</summary>
        public void AcceptTermsOfService()
        {
            // Snippet: AcceptTermsOfService(string, CallSettings)
            // Create client
            TermsOfServiceServiceClient termsOfServiceServiceClient = TermsOfServiceServiceClient.Create();
            // Initialize request argument(s)
            string name = "termsOfService/[VERSION]";
            // Make the request
            termsOfServiceServiceClient.AcceptTermsOfService(name);
            // End snippet
        }

        /// <summary>Snippet for AcceptTermsOfServiceAsync</summary>
        public async Task AcceptTermsOfServiceAsync()
        {
            // Snippet: AcceptTermsOfServiceAsync(string, CallSettings)
            // Additional: AcceptTermsOfServiceAsync(string, CancellationToken)
            // Create client
            TermsOfServiceServiceClient termsOfServiceServiceClient = await TermsOfServiceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "termsOfService/[VERSION]";
            // Make the request
            await termsOfServiceServiceClient.AcceptTermsOfServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for AcceptTermsOfService</summary>
        public void AcceptTermsOfServiceResourceNames()
        {
            // Snippet: AcceptTermsOfService(TermsOfServiceName, CallSettings)
            // Create client
            TermsOfServiceServiceClient termsOfServiceServiceClient = TermsOfServiceServiceClient.Create();
            // Initialize request argument(s)
            TermsOfServiceName name = TermsOfServiceName.FromVersion("[VERSION]");
            // Make the request
            termsOfServiceServiceClient.AcceptTermsOfService(name);
            // End snippet
        }

        /// <summary>Snippet for AcceptTermsOfServiceAsync</summary>
        public async Task AcceptTermsOfServiceResourceNamesAsync()
        {
            // Snippet: AcceptTermsOfServiceAsync(TermsOfServiceName, CallSettings)
            // Additional: AcceptTermsOfServiceAsync(TermsOfServiceName, CancellationToken)
            // Create client
            TermsOfServiceServiceClient termsOfServiceServiceClient = await TermsOfServiceServiceClient.CreateAsync();
            // Initialize request argument(s)
            TermsOfServiceName name = TermsOfServiceName.FromVersion("[VERSION]");
            // Make the request
            await termsOfServiceServiceClient.AcceptTermsOfServiceAsync(name);
            // End snippet
        }
    }
}
