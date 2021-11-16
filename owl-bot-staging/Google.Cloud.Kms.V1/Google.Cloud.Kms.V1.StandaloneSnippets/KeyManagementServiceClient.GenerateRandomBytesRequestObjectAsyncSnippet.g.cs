// Copyright 2021 Google LLC
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

namespace Google.Cloud.Kms.V1.Snippets
{
    using Google.Cloud.Kms.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedKeyManagementServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GenerateRandomBytesAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GenerateRandomBytesRequestObjectAsync()
        {
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateRandomBytesRequest request = new GenerateRandomBytesRequest
            {
                Location = "",
                LengthBytes = 0,
                ProtectionLevel = ProtectionLevel.Unspecified,
            };
            // Make the request
            GenerateRandomBytesResponse response = await keyManagementServiceClient.GenerateRandomBytesAsync(request);
        }
    }
}
