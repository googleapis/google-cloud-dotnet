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

namespace Google.Cloud.ArtifactRegistry.V1Beta2.Snippets
{
    // [START artifactregistry_v1beta2_generated_ArtifactRegistry_GetTag_sync]
    using Google.Cloud.ArtifactRegistry.V1Beta2;

    public sealed partial class GeneratedArtifactRegistryClientSnippets
    {
        /// <summary>Snippet for GetTag</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetTagRequestObject()
        {
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            GetTagRequest request = new GetTagRequest { Name = "", };
            // Make the request
            Tag response = artifactRegistryClient.GetTag(request);
        }
    }
    // [END artifactregistry_v1beta2_generated_ArtifactRegistry_GetTag_sync]
}
