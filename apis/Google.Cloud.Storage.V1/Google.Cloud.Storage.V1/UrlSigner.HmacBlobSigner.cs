// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Api.Gax;
using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1;

public sealed partial class UrlSigner
{
    /// <summary>
    /// Blob signer to implement signing using an HMAC secret.
    /// </summary>
    public sealed class HmacBlobSigner : IBlobSigner
    {
        private const string DefaultPrefix = "GOOG4";

        private readonly string _secret;
        private readonly string _prefix;

        /// <inheritdoc/>
        public string Id { get; }

        /// <inheritdoc/>
        public string Algorithm => "GOOG4-HMAC-SHA256";

        /// <summary>
        /// Creates a new HMAC Blob Signer from an HMAC Key ID and Secret.
        /// </summary>
        /// <param name="keyId">The HMAC key ID. Must not be null or empty.</param>
        /// <param name="secret">The HMAC key secret. Must not be null or empty.</param>
        private HmacBlobSigner(string keyId, string secret) =>
            (Id, _secret, _prefix) = (GaxPreconditions.CheckNotNullOrEmpty(keyId, nameof(keyId)), GaxPreconditions.CheckNotNullOrEmpty(secret, nameof(secret)), DefaultPrefix);

        /// <summary>
        /// Creates a new HMAC Blob Signer from an HMAC Key ID and Secret.
        /// </summary>
        /// <param name="keyId">The HMAC key ID. Must not be null or empty.</param>
        /// <param name="secret">The HMAC key secret. Must not be null or empty.</param>
        public static HmacBlobSigner Create(string keyId, string secret) => new HmacBlobSigner(keyId, secret);

        /// <inheritdoc/>
        public string CreateSignature(byte[] data, BlobSignerParameters parameters)
        {
            GaxPreconditions.CheckNotNull(data, nameof(data));
            GaxPreconditions.CheckNotNull(parameters, nameof(parameters));

            string date = parameters.SignatureTimestamp.ToString("yyyyMMdd", CultureInfo.InvariantCulture);

            // Implements the steps in https://cloud.google.com/storage/docs/authentication/signatures#derive-key
            var utf8 = Encoding.UTF8;
            byte[] initialKey = utf8.GetBytes(_prefix + _secret);
            byte[] keyDate = Hash(initialKey, utf8.GetBytes(date));
            byte[] keyRegion = Hash(keyDate, utf8.GetBytes(parameters.Region));
            byte[] keyService = Hash(keyRegion, utf8.GetBytes(parameters.Service));
            byte[] signingKey = Hash(keyService, utf8.GetBytes(parameters.RequestType));
            byte[] signature = Hash(signingKey, data);
            return Convert.ToBase64String(signature);

            static byte[] Hash(byte[] key, byte[] data)
            {
                using (HMACSHA256 hmac = new HMACSHA256(key))
                {
                    return hmac.ComputeHash(data);
                }
            }
        }

        /// <inheritdoc/>
        public Task<string> CreateSignatureAsync(byte[] data, BlobSignerParameters parameters, CancellationToken cancellationToken) =>
            Task.FromResult(CreateSignature(data, parameters));
    }
}
