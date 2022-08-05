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

namespace Google.Analytics.Admin.V1Alpha.Snippets
{
    // [START analyticsadmin_v1alpha_generated_AnalyticsAdminService_CreateAudience_async_flattened_resourceNames]
    using Google.Analytics.Admin.V1Alpha;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAnalyticsAdminServiceClientSnippets
    {
        /// <summary>Snippet for CreateAudienceAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateAudienceResourceNamesAsync()
        {
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            Audience audience = new Audience();
            // Make the request
            Audience response = await analyticsAdminServiceClient.CreateAudienceAsync(parent, audience);
        }
    }
    // [END analyticsadmin_v1alpha_generated_AnalyticsAdminService_CreateAudience_async_flattened_resourceNames]
}
