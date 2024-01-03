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
    // [START cloudkms_v1_generated_KeyManagementService_Encrypt_sync]
    using Google.Api.Gax;
    using Google.Cloud.Kms.V1;
    using Google.Protobuf;

    public sealed partial class GeneratedKeyManagementServiceClientSnippets
    {
        /// <summary>Snippet for Encrypt</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void EncryptRequestObject()
        {
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            EncryptRequest request = new EncryptRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Plaintext = ByteString.Empty,
                AdditionalAuthenticatedData = ByteString.Empty,
                PlaintextCrc32C = 0L,
                AdditionalAuthenticatedDataCrc32C = 0L,
            };
            // Make the request
            EncryptResponse response = keyManagementServiceClient.Encrypt(request);
        }
    }
    // [END cloudkms_v1_generated_KeyManagementService_Encrypt_sync]
}
