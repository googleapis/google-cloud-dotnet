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
    // [START apikeys_v2_generated_ApiKeys_LookupKey_sync]
    using Google.Cloud.ApiKeys.V2;

    public sealed partial class GeneratedApiKeysClientSnippets
    {
        /// <summary>Snippet for LookupKey</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void LookupKeyRequestObject()
        {
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            LookupKeyRequest request = new LookupKeyRequest { KeyString = "", };
            // Make the request
            LookupKeyResponse response = apiKeysClient.LookupKey(request);
        }
    }
    // [END apikeys_v2_generated_ApiKeys_LookupKey_sync]
}
