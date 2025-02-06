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
    using Google.Cloud.Talent.V4Beta1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCompletionClientSnippets
    {
        /// <summary>Snippet for CompleteQuery</summary>
        public void CompleteQueryRequestObject()
        {
            // Snippet: CompleteQuery(CompleteQueryRequest, CallSettings)
            // Create client
            CompletionClient completionClient = CompletionClient.Create();
            // Initialize request argument(s)
            CompleteQueryRequest request = new CompleteQueryRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Query = "",
                LanguageCodes = { "", },
                PageSize = 0,
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                Scope = CompleteQueryRequest.Types.CompletionScope.Unspecified,
                Type = CompleteQueryRequest.Types.CompletionType.Unspecified,
            };
            // Make the request
            CompleteQueryResponse response = completionClient.CompleteQuery(request);
            // End snippet
        }

        /// <summary>Snippet for CompleteQueryAsync</summary>
        public async Task CompleteQueryRequestObjectAsync()
        {
            // Snippet: CompleteQueryAsync(CompleteQueryRequest, CallSettings)
            // Additional: CompleteQueryAsync(CompleteQueryRequest, CancellationToken)
            // Create client
            CompletionClient completionClient = await CompletionClient.CreateAsync();
            // Initialize request argument(s)
            CompleteQueryRequest request = new CompleteQueryRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Query = "",
                LanguageCodes = { "", },
                PageSize = 0,
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                Scope = CompleteQueryRequest.Types.CompletionScope.Unspecified,
                Type = CompleteQueryRequest.Types.CompletionType.Unspecified,
            };
            // Make the request
            CompleteQueryResponse response = await completionClient.CompleteQueryAsync(request);
            // End snippet
        }
    }
}
