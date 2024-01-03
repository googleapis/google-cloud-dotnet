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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    // [START dataplex_v1_generated_MetadataService_CreateEntity_async_flattened_resourceNames]
    using System.Threading.Tasks;
    using gcdv = Google.Cloud.Dataplex.V1;

    public sealed partial class GeneratedMetadataServiceClientSnippets
    {
        /// <summary>Snippet for CreateEntityAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateEntityResourceNamesAsync()
        {
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ZoneName parent = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            gcdv::Entity entity = new gcdv::Entity();
            // Make the request
            gcdv::Entity response = await metadataServiceClient.CreateEntityAsync(parent, entity);
        }
    }
    // [END dataplex_v1_generated_MetadataService_CreateEntity_async_flattened_resourceNames]
}
