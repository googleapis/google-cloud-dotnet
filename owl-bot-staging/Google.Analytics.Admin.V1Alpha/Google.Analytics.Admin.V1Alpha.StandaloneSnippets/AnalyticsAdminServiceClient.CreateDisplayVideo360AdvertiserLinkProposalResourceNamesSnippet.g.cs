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
        /// <summary>Snippet for CreateDisplayVideo360AdvertiserLinkProposal</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateDisplayVideo360AdvertiserLinkProposalResourceNames()
        {
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            DisplayVideo360AdvertiserLinkProposal displayVideo360AdvertiserLinkProposal = new DisplayVideo360AdvertiserLinkProposal();
            // Make the request
            DisplayVideo360AdvertiserLinkProposal response = analyticsAdminServiceClient.CreateDisplayVideo360AdvertiserLinkProposal(parent, displayVideo360AdvertiserLinkProposal);
        }
    }
}
