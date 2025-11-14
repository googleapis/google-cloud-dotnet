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
    using Google.Shopping.Merchant.IssueResolution.V1Beta;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedIssueResolutionServiceClientSnippets
    {
        /// <summary>Snippet for RenderAccountIssues</summary>
        public void RenderAccountIssuesRequestObject()
        {
            // Snippet: RenderAccountIssues(RenderAccountIssuesRequest, CallSettings)
            // Create client
            IssueResolutionServiceClient issueResolutionServiceClient = IssueResolutionServiceClient.Create();
            // Initialize request argument(s)
            RenderAccountIssuesRequest request = new RenderAccountIssuesRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
                LanguageCode = "",
                TimeZone = "",
                Payload = new RenderIssuesRequestPayload(),
            };
            // Make the request
            RenderAccountIssuesResponse response = issueResolutionServiceClient.RenderAccountIssues(request);
            // End snippet
        }

        /// <summary>Snippet for RenderAccountIssuesAsync</summary>
        public async Task RenderAccountIssuesRequestObjectAsync()
        {
            // Snippet: RenderAccountIssuesAsync(RenderAccountIssuesRequest, CallSettings)
            // Additional: RenderAccountIssuesAsync(RenderAccountIssuesRequest, CancellationToken)
            // Create client
            IssueResolutionServiceClient issueResolutionServiceClient = await IssueResolutionServiceClient.CreateAsync();
            // Initialize request argument(s)
            RenderAccountIssuesRequest request = new RenderAccountIssuesRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
                LanguageCode = "",
                TimeZone = "",
                Payload = new RenderIssuesRequestPayload(),
            };
            // Make the request
            RenderAccountIssuesResponse response = await issueResolutionServiceClient.RenderAccountIssuesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RenderAccountIssues</summary>
        public void RenderAccountIssues()
        {
            // Snippet: RenderAccountIssues(string, CallSettings)
            // Create client
            IssueResolutionServiceClient issueResolutionServiceClient = IssueResolutionServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]";
            // Make the request
            RenderAccountIssuesResponse response = issueResolutionServiceClient.RenderAccountIssues(name);
            // End snippet
        }

        /// <summary>Snippet for RenderAccountIssuesAsync</summary>
        public async Task RenderAccountIssuesAsync()
        {
            // Snippet: RenderAccountIssuesAsync(string, CallSettings)
            // Additional: RenderAccountIssuesAsync(string, CancellationToken)
            // Create client
            IssueResolutionServiceClient issueResolutionServiceClient = await IssueResolutionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]";
            // Make the request
            RenderAccountIssuesResponse response = await issueResolutionServiceClient.RenderAccountIssuesAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RenderAccountIssues</summary>
        public void RenderAccountIssuesResourceNames()
        {
            // Snippet: RenderAccountIssues(AccountName, CallSettings)
            // Create client
            IssueResolutionServiceClient issueResolutionServiceClient = IssueResolutionServiceClient.Create();
            // Initialize request argument(s)
            AccountName name = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            RenderAccountIssuesResponse response = issueResolutionServiceClient.RenderAccountIssues(name);
            // End snippet
        }

        /// <summary>Snippet for RenderAccountIssuesAsync</summary>
        public async Task RenderAccountIssuesResourceNamesAsync()
        {
            // Snippet: RenderAccountIssuesAsync(AccountName, CallSettings)
            // Additional: RenderAccountIssuesAsync(AccountName, CancellationToken)
            // Create client
            IssueResolutionServiceClient issueResolutionServiceClient = await IssueResolutionServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName name = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            RenderAccountIssuesResponse response = await issueResolutionServiceClient.RenderAccountIssuesAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RenderProductIssues</summary>
        public void RenderProductIssuesRequestObject()
        {
            // Snippet: RenderProductIssues(RenderProductIssuesRequest, CallSettings)
            // Create client
            IssueResolutionServiceClient issueResolutionServiceClient = IssueResolutionServiceClient.Create();
            // Initialize request argument(s)
            RenderProductIssuesRequest request = new RenderProductIssuesRequest
            {
                ProductName = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]"),
                LanguageCode = "",
                TimeZone = "",
                Payload = new RenderIssuesRequestPayload(),
            };
            // Make the request
            RenderProductIssuesResponse response = issueResolutionServiceClient.RenderProductIssues(request);
            // End snippet
        }

        /// <summary>Snippet for RenderProductIssuesAsync</summary>
        public async Task RenderProductIssuesRequestObjectAsync()
        {
            // Snippet: RenderProductIssuesAsync(RenderProductIssuesRequest, CallSettings)
            // Additional: RenderProductIssuesAsync(RenderProductIssuesRequest, CancellationToken)
            // Create client
            IssueResolutionServiceClient issueResolutionServiceClient = await IssueResolutionServiceClient.CreateAsync();
            // Initialize request argument(s)
            RenderProductIssuesRequest request = new RenderProductIssuesRequest
            {
                ProductName = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]"),
                LanguageCode = "",
                TimeZone = "",
                Payload = new RenderIssuesRequestPayload(),
            };
            // Make the request
            RenderProductIssuesResponse response = await issueResolutionServiceClient.RenderProductIssuesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RenderProductIssues</summary>
        public void RenderProductIssues()
        {
            // Snippet: RenderProductIssues(string, CallSettings)
            // Create client
            IssueResolutionServiceClient issueResolutionServiceClient = IssueResolutionServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/products/[PRODUCT]";
            // Make the request
            RenderProductIssuesResponse response = issueResolutionServiceClient.RenderProductIssues(name);
            // End snippet
        }

        /// <summary>Snippet for RenderProductIssuesAsync</summary>
        public async Task RenderProductIssuesAsync()
        {
            // Snippet: RenderProductIssuesAsync(string, CallSettings)
            // Additional: RenderProductIssuesAsync(string, CancellationToken)
            // Create client
            IssueResolutionServiceClient issueResolutionServiceClient = await IssueResolutionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/products/[PRODUCT]";
            // Make the request
            RenderProductIssuesResponse response = await issueResolutionServiceClient.RenderProductIssuesAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RenderProductIssues</summary>
        public void RenderProductIssuesResourceNames()
        {
            // Snippet: RenderProductIssues(ProductName, CallSettings)
            // Create client
            IssueResolutionServiceClient issueResolutionServiceClient = IssueResolutionServiceClient.Create();
            // Initialize request argument(s)
            ProductName name = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]");
            // Make the request
            RenderProductIssuesResponse response = issueResolutionServiceClient.RenderProductIssues(name);
            // End snippet
        }

        /// <summary>Snippet for RenderProductIssuesAsync</summary>
        public async Task RenderProductIssuesResourceNamesAsync()
        {
            // Snippet: RenderProductIssuesAsync(ProductName, CallSettings)
            // Additional: RenderProductIssuesAsync(ProductName, CancellationToken)
            // Create client
            IssueResolutionServiceClient issueResolutionServiceClient = await IssueResolutionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProductName name = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]");
            // Make the request
            RenderProductIssuesResponse response = await issueResolutionServiceClient.RenderProductIssuesAsync(name);
            // End snippet
        }

        /// <summary>Snippet for TriggerAction</summary>
        public void TriggerActionRequestObject()
        {
            // Snippet: TriggerAction(TriggerActionRequest, CallSettings)
            // Create client
            IssueResolutionServiceClient issueResolutionServiceClient = IssueResolutionServiceClient.Create();
            // Initialize request argument(s)
            TriggerActionRequest request = new TriggerActionRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
                Payload = new TriggerActionPayload(),
                LanguageCode = "",
            };
            // Make the request
            TriggerActionResponse response = issueResolutionServiceClient.TriggerAction(request);
            // End snippet
        }

        /// <summary>Snippet for TriggerActionAsync</summary>
        public async Task TriggerActionRequestObjectAsync()
        {
            // Snippet: TriggerActionAsync(TriggerActionRequest, CallSettings)
            // Additional: TriggerActionAsync(TriggerActionRequest, CancellationToken)
            // Create client
            IssueResolutionServiceClient issueResolutionServiceClient = await IssueResolutionServiceClient.CreateAsync();
            // Initialize request argument(s)
            TriggerActionRequest request = new TriggerActionRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
                Payload = new TriggerActionPayload(),
                LanguageCode = "",
            };
            // Make the request
            TriggerActionResponse response = await issueResolutionServiceClient.TriggerActionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TriggerAction</summary>
        public void TriggerAction()
        {
            // Snippet: TriggerAction(string, CallSettings)
            // Create client
            IssueResolutionServiceClient issueResolutionServiceClient = IssueResolutionServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]";
            // Make the request
            TriggerActionResponse response = issueResolutionServiceClient.TriggerAction(name);
            // End snippet
        }

        /// <summary>Snippet for TriggerActionAsync</summary>
        public async Task TriggerActionAsync()
        {
            // Snippet: TriggerActionAsync(string, CallSettings)
            // Additional: TriggerActionAsync(string, CancellationToken)
            // Create client
            IssueResolutionServiceClient issueResolutionServiceClient = await IssueResolutionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]";
            // Make the request
            TriggerActionResponse response = await issueResolutionServiceClient.TriggerActionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for TriggerAction</summary>
        public void TriggerActionResourceNames()
        {
            // Snippet: TriggerAction(AccountName, CallSettings)
            // Create client
            IssueResolutionServiceClient issueResolutionServiceClient = IssueResolutionServiceClient.Create();
            // Initialize request argument(s)
            AccountName name = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            TriggerActionResponse response = issueResolutionServiceClient.TriggerAction(name);
            // End snippet
        }

        /// <summary>Snippet for TriggerActionAsync</summary>
        public async Task TriggerActionResourceNamesAsync()
        {
            // Snippet: TriggerActionAsync(AccountName, CallSettings)
            // Additional: TriggerActionAsync(AccountName, CancellationToken)
            // Create client
            IssueResolutionServiceClient issueResolutionServiceClient = await IssueResolutionServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName name = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            TriggerActionResponse response = await issueResolutionServiceClient.TriggerActionAsync(name);
            // End snippet
        }
    }
}
