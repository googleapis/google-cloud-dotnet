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
    using Google.Cloud.Compute.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedImageFamilyViewsClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetImageFamilyViewRequest, CallSettings)
            // Create client
            ImageFamilyViewsClient imageFamilyViewsClient = ImageFamilyViewsClient.Create();
            // Initialize request argument(s)
            GetImageFamilyViewRequest request = new GetImageFamilyViewRequest
            {
                Zone = "",
                Project = "",
                Family = "",
            };
            // Make the request
            ImageFamilyView response = imageFamilyViewsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetImageFamilyViewRequest, CallSettings)
            // Additional: GetAsync(GetImageFamilyViewRequest, CancellationToken)
            // Create client
            ImageFamilyViewsClient imageFamilyViewsClient = await ImageFamilyViewsClient.CreateAsync();
            // Initialize request argument(s)
            GetImageFamilyViewRequest request = new GetImageFamilyViewRequest
            {
                Zone = "",
                Project = "",
                Family = "",
            };
            // Make the request
            ImageFamilyView response = await imageFamilyViewsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            ImageFamilyViewsClient imageFamilyViewsClient = ImageFamilyViewsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string family = "";
            // Make the request
            ImageFamilyView response = imageFamilyViewsClient.Get(project, zone, family);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            ImageFamilyViewsClient imageFamilyViewsClient = await ImageFamilyViewsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string family = "";
            // Make the request
            ImageFamilyView response = await imageFamilyViewsClient.GetAsync(project, zone, family);
            // End snippet
        }
    }
}
