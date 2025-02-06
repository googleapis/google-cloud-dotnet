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
    // [START webrisk_v1beta1_generated_WebRiskServiceV1Beta1_SearchUris_sync]
    using Google.Cloud.WebRisk.V1Beta1;

    public sealed partial class GeneratedWebRiskServiceV1Beta1ClientSnippets
    {
        /// <summary>Snippet for SearchUris</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void SearchUrisRequestObject()
        {
            // Create client
            WebRiskServiceV1Beta1Client webRiskServiceV1Beta1Client = WebRiskServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            SearchUrisRequest request = new SearchUrisRequest
            {
                Uri = "",
                ThreatTypes =
                {
                    ThreatType.Unspecified,
                },
            };
            // Make the request
            SearchUrisResponse response = webRiskServiceV1Beta1Client.SearchUris(request);
        }
    }
    // [END webrisk_v1beta1_generated_WebRiskServiceV1Beta1_SearchUris_sync]
}
