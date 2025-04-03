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
    using Google.Maps.AerialView.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAerialViewClientSnippets
    {
        /// <summary>Snippet for RenderVideo</summary>
        public void RenderVideoRequestObject()
        {
            // Snippet: RenderVideo(RenderVideoRequest, CallSettings)
            // Create client
            AerialViewClient aerialViewClient = AerialViewClient.Create();
            // Initialize request argument(s)
            RenderVideoRequest request = new RenderVideoRequest { Address = "", };
            // Make the request
            RenderVideoResponse response = aerialViewClient.RenderVideo(request);
            // End snippet
        }

        /// <summary>Snippet for RenderVideoAsync</summary>
        public async Task RenderVideoRequestObjectAsync()
        {
            // Snippet: RenderVideoAsync(RenderVideoRequest, CallSettings)
            // Additional: RenderVideoAsync(RenderVideoRequest, CancellationToken)
            // Create client
            AerialViewClient aerialViewClient = await AerialViewClient.CreateAsync();
            // Initialize request argument(s)
            RenderVideoRequest request = new RenderVideoRequest { Address = "", };
            // Make the request
            RenderVideoResponse response = await aerialViewClient.RenderVideoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RenderVideo</summary>
        public void RenderVideo()
        {
            // Snippet: RenderVideo(string, CallSettings)
            // Create client
            AerialViewClient aerialViewClient = AerialViewClient.Create();
            // Initialize request argument(s)
            string address = "";
            // Make the request
            RenderVideoResponse response = aerialViewClient.RenderVideo(address);
            // End snippet
        }

        /// <summary>Snippet for RenderVideoAsync</summary>
        public async Task RenderVideoAsync()
        {
            // Snippet: RenderVideoAsync(string, CallSettings)
            // Additional: RenderVideoAsync(string, CancellationToken)
            // Create client
            AerialViewClient aerialViewClient = await AerialViewClient.CreateAsync();
            // Initialize request argument(s)
            string address = "";
            // Make the request
            RenderVideoResponse response = await aerialViewClient.RenderVideoAsync(address);
            // End snippet
        }

        /// <summary>Snippet for LookupVideo</summary>
        public void LookupVideoRequestObject()
        {
            // Snippet: LookupVideo(LookupVideoRequest, CallSettings)
            // Create client
            AerialViewClient aerialViewClient = AerialViewClient.Create();
            // Initialize request argument(s)
            LookupVideoRequest request = new LookupVideoRequest { VideoId = "", };
            // Make the request
            Video response = aerialViewClient.LookupVideo(request);
            // End snippet
        }

        /// <summary>Snippet for LookupVideoAsync</summary>
        public async Task LookupVideoRequestObjectAsync()
        {
            // Snippet: LookupVideoAsync(LookupVideoRequest, CallSettings)
            // Additional: LookupVideoAsync(LookupVideoRequest, CancellationToken)
            // Create client
            AerialViewClient aerialViewClient = await AerialViewClient.CreateAsync();
            // Initialize request argument(s)
            LookupVideoRequest request = new LookupVideoRequest { VideoId = "", };
            // Make the request
            Video response = await aerialViewClient.LookupVideoAsync(request);
            // End snippet
        }
    }
}
