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

namespace Google.Cloud.Talent.V4.Snippets
{
    // [START jobs_v4_generated_CompanyService_DeleteCompany_sync_flattened_resourceNames]
    using Google.Cloud.Talent.V4;

    public sealed partial class GeneratedCompanyServiceClientSnippets
    {
        /// <summary>Snippet for DeleteCompany</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void DeleteCompanyResourceNames()
        {
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            CompanyName name = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]");
            // Make the request
            companyServiceClient.DeleteCompany(name);
        }
    }
    // [END jobs_v4_generated_CompanyService_DeleteCompany_sync_flattened_resourceNames]
}
