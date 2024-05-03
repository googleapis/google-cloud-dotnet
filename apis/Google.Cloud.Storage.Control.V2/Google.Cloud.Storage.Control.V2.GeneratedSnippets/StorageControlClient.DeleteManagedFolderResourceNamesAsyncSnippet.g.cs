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
    // [START storage_v2_generated_StorageControl_DeleteManagedFolder_async_flattened_resourceNames]
    using Google.Cloud.Storage.Control.V2;
    using System.Threading.Tasks;

    public sealed partial class GeneratedStorageControlClientSnippets
    {
        /// <summary>Snippet for DeleteManagedFolderAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task DeleteManagedFolderResourceNamesAsync()
        {
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            ManagedFolderName name = ManagedFolderName.FromProjectBucketManagedFolder("[PROJECT]", "[BUCKET]", "[MANAGED_FOLDER]");
            // Make the request
            await storageControlClient.DeleteManagedFolderAsync(name);
        }
    }
    // [END storage_v2_generated_StorageControl_DeleteManagedFolder_async_flattened_resourceNames]
}
