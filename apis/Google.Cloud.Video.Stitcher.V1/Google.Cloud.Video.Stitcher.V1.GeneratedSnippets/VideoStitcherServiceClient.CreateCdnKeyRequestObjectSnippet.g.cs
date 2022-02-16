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

namespace Google.Cloud.Video.Stitcher.V1.Snippets
{
    // [START videostitcher_v1_generated_VideoStitcherService_CreateCdnKey_sync]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Video.Stitcher.V1;

    public sealed partial class GeneratedVideoStitcherServiceClientSnippets
    {
        /// <summary>Snippet for CreateCdnKey</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateCdnKeyRequestObject()
        {
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            CreateCdnKeyRequest request = new CreateCdnKeyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CdnKey = new CdnKey(),
                CdnKeyId = "",
            };
            // Make the request
            CdnKey response = videoStitcherServiceClient.CreateCdnKey(request);
        }
    }
    // [END videostitcher_v1_generated_VideoStitcherService_CreateCdnKey_sync]
}
