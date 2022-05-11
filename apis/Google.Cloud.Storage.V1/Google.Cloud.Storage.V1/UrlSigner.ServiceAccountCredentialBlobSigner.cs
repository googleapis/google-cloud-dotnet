// Copyright 2018 Google LLC
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

using Google.Apis.Auth.OAuth2;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class UrlSigner
    {
        /// <summary>
        /// Implementation of <see cref="IBlobSigner"/> to sign a blob from a service account credential.
        /// We already have the private key, so don't need to perform any IO.
        /// </summary>
        private sealed class ServiceAccountCredentialBlobSigner : IBlobSigner
        {
            private readonly ServiceAccountCredential _credential;

            internal ServiceAccountCredentialBlobSigner(ServiceAccountCredential credential) =>
                _credential = credential;

            public string Id => _credential.Id;

            public string Algorithm => "GOOG4-RSA-SHA256";

            public string CreateSignature(byte[] data, BlobSignerParameters _) => _credential.CreateSignature(data);

            public Task<string> CreateSignatureAsync(byte[] data, BlobSignerParameters signerParameters, CancellationToken cancellationToken) =>
                Task.FromResult(CreateSignature(data, signerParameters));
        }
    }
}
