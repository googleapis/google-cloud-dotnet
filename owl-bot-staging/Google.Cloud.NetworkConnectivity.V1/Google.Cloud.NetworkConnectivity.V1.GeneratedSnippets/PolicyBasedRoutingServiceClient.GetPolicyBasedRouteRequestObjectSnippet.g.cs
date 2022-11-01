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

namespace Google.Cloud.NetworkConnectivity.V1.Snippets
{
    // [START networkconnectivity_v1_generated_PolicyBasedRoutingService_GetPolicyBasedRoute_sync]
    using Google.Cloud.NetworkConnectivity.V1;

    public sealed partial class GeneratedPolicyBasedRoutingServiceClientSnippets
    {
        /// <summary>Snippet for GetPolicyBasedRoute</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetPolicyBasedRouteRequestObject()
        {
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = PolicyBasedRoutingServiceClient.Create();
            // Initialize request argument(s)
            GetPolicyBasedRouteRequest request = new GetPolicyBasedRouteRequest
            {
                PolicyBasedRouteName = PolicyBasedRouteName.FromProjectLocationPolicyBasedRoute("[PROJECT]", "[LOCATION]", "[POLICY_BASED_ROUTE]"),
            };
            // Make the request
            PolicyBasedRoute response = policyBasedRoutingServiceClient.GetPolicyBasedRoute(request);
        }
    }
    // [END networkconnectivity_v1_generated_PolicyBasedRoutingService_GetPolicyBasedRoute_sync]
}
