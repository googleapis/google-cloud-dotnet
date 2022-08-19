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

namespace Google.Cloud.ApigeeRegistry.V1.Snippets
{
    // [START apigeeregistry_v1_generated_Registry_DeleteApiVersion_async]
    using Google.Cloud.ApigeeRegistry.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedRegistryClientSnippets
    {
        /// <summary>Snippet for DeleteApiVersionAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task DeleteApiVersionRequestObjectAsync()
        {
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteApiVersionRequest request = new DeleteApiVersionRequest
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                Force = false,
            };
            // Make the request
            await registryClient.DeleteApiVersionAsync(request);
        }
    }
    // [END apigeeregistry_v1_generated_Registry_DeleteApiVersion_async]
}
