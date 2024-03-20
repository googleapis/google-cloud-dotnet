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
    // [START migrationcenter_v1_generated_MigrationCenter_BatchUpdateAssets_sync_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.MigrationCenter.V1;
    using System.Collections.Generic;

    public sealed partial class GeneratedMigrationCenterClientSnippets
    {
        /// <summary>Snippet for BatchUpdateAssets</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void BatchUpdateAssetsResourceNames()
        {
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<UpdateAssetRequest> requests = new UpdateAssetRequest[]
            {
                new UpdateAssetRequest(),
            };
            // Make the request
            BatchUpdateAssetsResponse response = migrationCenterClient.BatchUpdateAssets(parent, requests);
        }
    }
    // [END migrationcenter_v1_generated_MigrationCenter_BatchUpdateAssets_sync_flattened_resourceNames]
}
