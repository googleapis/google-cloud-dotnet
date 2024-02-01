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
    // [START recommendationengine_v1beta1_generated_UserEventService_CollectUserEvent_async_flattened]
    using Google.Api;
    using Google.Cloud.RecommendationEngine.V1Beta1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedUserEventServiceClientSnippets
    {
        /// <summary>Snippet for CollectUserEventAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CollectUserEventAsync()
        {
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/eventStores/[EVENT_STORE]";
            string userEvent = "";
            string uri = "";
            long ets = 0L;
            // Make the request
            HttpBody response = await userEventServiceClient.CollectUserEventAsync(parent, userEvent, uri, ets);
        }
    }
    // [END recommendationengine_v1beta1_generated_UserEventService_CollectUserEvent_async_flattened]
}
