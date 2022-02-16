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

namespace Google.Cloud.Talent.V4Beta1.Snippets
{
    // [START jobs_v4beta1_generated_ProfileService_SearchProfiles_sync]
    using Google.Cloud.Talent.V4Beta1;

    public sealed partial class GeneratedProfileServiceClientSnippets
    {
        /// <summary>Snippet for SearchProfiles</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void SearchProfilesRequestObject()
        {
            // Create client
            ProfileServiceClient profileServiceClient = ProfileServiceClient.Create();
            // Initialize request argument(s)
            SearchProfilesRequest request = new SearchProfilesRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                RequestMetadata = new RequestMetadata(),
                ProfileQuery = new ProfileQuery(),
                PageSize = 0,
                PageToken = "",
                Offset = 0,
                DisableSpellCheck = false,
                OrderBy = "",
                CaseSensitiveSort = false,
                HistogramQueries =
                {
                    new HistogramQuery(),
                },
                ResultSetId = "",
                StrictKeywordsSearch = false,
            };
            // Make the request
            SearchProfilesResponse response = profileServiceClient.SearchProfiles(request);
        }
    }
    // [END jobs_v4beta1_generated_ProfileService_SearchProfiles_sync]
}
