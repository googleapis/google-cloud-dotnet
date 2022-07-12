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

namespace Google.Cloud.Asset.V1.Snippets
{
    // [START cloudasset_v1_generated_AssetService_UpdateFeed_sync_flattened]
    using Google.Cloud.Asset.V1;

    public sealed partial class GeneratedAssetServiceClientSnippets
    {
        /// <summary>Snippet for UpdateFeed</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void UpdateFeed()
        {
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            Feed feed = new Feed();
            // Make the request
            Feed response = assetServiceClient.UpdateFeed(feed);
        }
    }
    // [END cloudasset_v1_generated_AssetService_UpdateFeed_sync_flattened]
}
