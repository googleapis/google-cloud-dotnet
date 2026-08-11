// Copyright 2026 Google LLC
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
    // [START admanager_v1_generated_ViewabilityProviderService_BatchCreateViewabilityProviders_sync]
    using Google.Ads.AdManager.V1;

    public sealed partial class GeneratedViewabilityProviderServiceClientSnippets
    {
        /// <summary>Snippet for BatchCreateViewabilityProviders</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void BatchCreateViewabilityProvidersRequestObject()
        {
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = ViewabilityProviderServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateViewabilityProvidersRequest request = new BatchCreateViewabilityProvidersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateViewabilityProviderRequest(),
                },
            };
            // Make the request
            BatchCreateViewabilityProvidersResponse response = viewabilityProviderServiceClient.BatchCreateViewabilityProviders(request);
        }
    }
    // [END admanager_v1_generated_ViewabilityProviderService_BatchCreateViewabilityProviders_sync]
}
