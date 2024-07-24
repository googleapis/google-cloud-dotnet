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
    // [START cloudkms_v1_generated_KeyManagementService_AsymmetricSign_async]
    using Google.Cloud.Kms.V1;
    using Google.Protobuf;
    using System.Threading.Tasks;

    public sealed partial class GeneratedKeyManagementServiceClientSnippets
    {
        /// <summary>Snippet for AsymmetricSignAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task AsymmetricSignRequestObjectAsync()
        {
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            AsymmetricSignRequest request = new AsymmetricSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Digest = new Digest(),
                DigestCrc32C = 0L,
                Data = ByteString.Empty,
                DataCrc32C = 0L,
            };
            // Make the request
            AsymmetricSignResponse response = await keyManagementServiceClient.AsymmetricSignAsync(request);
        }
    }
    // [END cloudkms_v1_generated_KeyManagementService_AsymmetricSign_async]
}
