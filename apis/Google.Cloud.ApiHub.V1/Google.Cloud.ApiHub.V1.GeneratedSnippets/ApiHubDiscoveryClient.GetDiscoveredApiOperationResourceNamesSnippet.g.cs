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
    // [START apihub_v1_generated_ApiHubDiscovery_GetDiscoveredApiOperation_sync_flattened_resourceNames]
    using Google.Cloud.ApiHub.V1;

    public sealed partial class GeneratedApiHubDiscoveryClientSnippets
    {
        /// <summary>Snippet for GetDiscoveredApiOperation</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void GetDiscoveredApiOperationResourceNames()
        {
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = ApiHubDiscoveryClient.Create();
            // Initialize request argument(s)
            DiscoveredApiOperationName name = DiscoveredApiOperationName.FromProjectLocationDiscoveredApiObservationDiscoveredApiOperation("[PROJECT]", "[LOCATION]", "[DISCOVERED_API_OBSERVATION]", "[DISCOVERED_API_OPERATION]");
            // Make the request
            DiscoveredApiOperation response = apiHubDiscoveryClient.GetDiscoveredApiOperation(name);
        }
    }
    // [END apihub_v1_generated_ApiHubDiscovery_GetDiscoveredApiOperation_sync_flattened_resourceNames]
}
