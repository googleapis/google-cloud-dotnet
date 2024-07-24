// Copyright 2024 Google LLC
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
    // [START analyticsadmin_v1alpha_generated_AnalyticsAdminService_AcknowledgeUserDataCollection_sync]
    using Google.Analytics.Admin.V1Alpha;

    public sealed partial class GeneratedAnalyticsAdminServiceClientSnippets
    {
        /// <summary>Snippet for AcknowledgeUserDataCollection</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void AcknowledgeUserDataCollectionRequestObject()
        {
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AcknowledgeUserDataCollectionRequest request = new AcknowledgeUserDataCollectionRequest
            {
                PropertyAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Acknowledgement = "",
            };
            // Make the request
            AcknowledgeUserDataCollectionResponse response = analyticsAdminServiceClient.AcknowledgeUserDataCollection(request);
        }
    }
    // [END analyticsadmin_v1alpha_generated_AnalyticsAdminService_AcknowledgeUserDataCollection_sync]
}
