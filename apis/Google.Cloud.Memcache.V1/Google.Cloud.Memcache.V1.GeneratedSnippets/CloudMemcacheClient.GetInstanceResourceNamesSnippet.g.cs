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

namespace Google.Cloud.Memcache.V1.Snippets
{
    // [START memcache_v1_generated_CloudMemcache_GetInstance_sync_flattened_resourceNames]
    using Google.Cloud.Memcache.V1;

    public sealed partial class GeneratedCloudMemcacheClientSnippets
    {
        /// <summary>Snippet for GetInstance</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetInstanceResourceNames()
        {
            // Create client
            CloudMemcacheClient cloudMemcacheClient = CloudMemcacheClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Instance response = cloudMemcacheClient.GetInstance(name);
        }
    }
    // [END memcache_v1_generated_CloudMemcache_GetInstance_sync_flattened_resourceNames]
}
