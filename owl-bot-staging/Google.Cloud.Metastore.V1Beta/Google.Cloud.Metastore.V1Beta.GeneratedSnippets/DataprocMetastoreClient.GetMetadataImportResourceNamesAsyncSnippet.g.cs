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

namespace Google.Cloud.Metastore.V1Beta.Snippets
{
    // [START metastore_v1beta_generated_DataprocMetastore_GetMetadataImport_async_flattened_resourceNames]
    using Google.Cloud.Metastore.V1Beta;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDataprocMetastoreClientSnippets
    {
        /// <summary>Snippet for GetMetadataImportAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetMetadataImportResourceNamesAsync()
        {
            // Create client
            DataprocMetastoreClient dataprocMetastoreClient = await DataprocMetastoreClient.CreateAsync();
            // Initialize request argument(s)
            MetadataImportName name = MetadataImportName.FromProjectLocationServiceMetadataImport("[PROJECT]", "[LOCATION]", "[SERVICE]", "[METADATA_IMPORT]");
            // Make the request
            MetadataImport response = await dataprocMetastoreClient.GetMetadataImportAsync(name);
        }
    }
    // [END metastore_v1beta_generated_DataprocMetastore_GetMetadataImport_async_flattened_resourceNames]
}
