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
    using Google.Analytics.Admin.V1Alpha;

    public sealed partial class GeneratedAnalyticsAdminServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetDisplayVideo360AdvertiserLinkProposal</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetDisplayVideo360AdvertiserLinkProposalRequestObject()
        {
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetDisplayVideo360AdvertiserLinkProposalRequest request = new GetDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            // Make the request
            DisplayVideo360AdvertiserLinkProposal response = analyticsAdminServiceClient.GetDisplayVideo360AdvertiserLinkProposal(request);
        }
    }
}
