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
    // [START phishingprotection_v1beta1_generated_PhishingProtectionServiceV1Beta1_ReportPhishing_async_flattened]
    using Google.Cloud.PhishingProtection.V1Beta1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedPhishingProtectionServiceV1Beta1ClientSnippets
    {
        /// <summary>Snippet for ReportPhishingAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task ReportPhishingAsync()
        {
            // Create client
            PhishingProtectionServiceV1Beta1Client phishingProtectionServiceV1Beta1Client = await PhishingProtectionServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string uri = "";
            // Make the request
            ReportPhishingResponse response = await phishingProtectionServiceV1Beta1Client.ReportPhishingAsync(parent, uri);
        }
    }
    // [END phishingprotection_v1beta1_generated_PhishingProtectionServiceV1Beta1_ReportPhishing_async_flattened]
}
