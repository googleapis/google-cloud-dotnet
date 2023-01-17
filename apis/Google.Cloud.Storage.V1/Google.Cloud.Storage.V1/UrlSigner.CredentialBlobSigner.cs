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

using Google.Api.Gax;
using System.Threading;
using System.Threading.Tasks;
using ISignerCredential = Google.Apis.Auth.OAuth2.IBlobSigner;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class UrlSigner
    {
        /// <summary>
        /// Implementation of <see cref="IBlobSigner"/> to sign a blob from a supported credential.
        /// </summary>
        private sealed class CredentialBlobSigner : IBlobSigner
        {
            private readonly ISignerCredential _credential;

            internal CredentialBlobSigner(ISignerCredential credential, string id, string algorithm) =>
                (_credential, Id, Algorithm) = (credential, id, algorithm);

            public string Id { get; }

            public string Algorithm { get; }

            public string CreateSignature(byte[] data, BlobSignerParameters signerParameters) =>
                CreateSignatureAsync(data, signerParameters, default).ResultWithUnwrappedExceptions();

            public async Task<string> CreateSignatureAsync(byte[] data, BlobSignerParameters _, CancellationToken cancellationToken) =>
                await _credential.SignBlobAsync(data, cancellationToken).ConfigureAwait(false);
        }
    }
}
