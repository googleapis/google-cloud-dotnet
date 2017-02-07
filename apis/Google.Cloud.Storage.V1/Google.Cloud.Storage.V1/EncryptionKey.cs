// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Apis.Requests;
using System;
using System.Net.Http;
using System.Security.Cryptography;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// An AES-256 key passed to the Google Cloud Storage servers via headers to allow objects to be encrypted at
    /// rest using a client-supplied key rather than a server-supplied default key.
    /// </summary>
    public sealed class EncryptionKey : IEquatable<EncryptionKey>
    {
        internal const string AlgorithmHeader = "x-goog-encryption-algorithm";
        internal const string KeyHeader = "x-goog-encryption-key";
        internal const string KeyHashHeader = "x-goog-encryption-key-sha256";
        internal const string AlgorithmValue = "AES256";
        internal const string CopySourceAlgorithmHeader = "x-goog-copy-source-encryption-algorithm";
        internal const string CopySourceKeyHeader = "x-goog-copy-source-encryption-key";
        internal const string CopySourceKeyHashHeader = "x-goog-copy-source-encryption-key-sha256";

        /// <summary>
        /// A "don't encrypt" key, used in call-specific options to indicate that a particular request should
        /// not use encryption even if the client has a default encryption key.
        /// </summary>
        public static EncryptionKey None { get; } = new EncryptionKey();

        /// <summary>
        /// The base64 representation of the key. This will always be 45 characters long,
        /// or <c>null</c> for <see cref="None"/>.
        /// </summary>
        public string Base64Key { get; }

        /// <summary>
        /// The base64 representation of the SHA-256 hash of the key. This will always be 45 characters long,
        /// or <c>null</c> for <see cref="None"/>.
        /// </summary>
        public string Base64Hash { get; }

        // Only used for "None" - leaves properties null
        private EncryptionKey()
        {
        }

        private EncryptionKey(byte[] key)
        {
            using (var hasher = SHA256.Create())
            {
                Base64Key = Convert.ToBase64String(key);
                Base64Hash = Convert.ToBase64String(hasher.ComputeHash(key));
            }
        }

        /// <summary>
        /// Creates an encryption key from the specified raw bytes.
        /// </summary>
        /// <param name="key">The raw key data; must be non-null and 32 bytes long.</param>
        /// <returns>An <see cref="EncryptionKey"/> based on <paramref name="key"/>.</returns>
        public static EncryptionKey Create(byte[] key)
        {
            GaxPreconditions.CheckNotNull(key, nameof(key));
            GaxPreconditions.CheckArgument(key.Length == 32, nameof(key), "Key must be 32 bytes long");
            return new EncryptionKey(key);
        }

        /// <summary>
        /// Generates a random encryption key using <see cref="RandomNumberGenerator"/>.
        /// </summary>
        /// <returns>A generated encryption key.</returns>
        public static EncryptionKey Generate()
        {
            using (var rng = RandomNumberGenerator.Create())
            {
                byte[] key = new byte[32];
                rng.GetBytes(key);
                return Create(key);
            }
        }

        /// <inheritdoc />
        public bool Equals(EncryptionKey other) => other != null && other.Base64Key == Base64Key;

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as EncryptionKey);

        /// <inheritdoc />
        public override int GetHashCode() => Base64Key?.GetHashCode() ?? 0;

        /// <summary>
        /// Adds encryption headers to the specified request, unless this key is <see cref="EncryptionKey.None"/>, 
        /// </summary>
        /// <param name="request">The request to modify. Must not be null.</param>
        public void ModifyRequest(HttpRequestMessage request)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            if (Base64Key != null)
            {
                request.Headers.Add(AlgorithmHeader, AlgorithmValue);
                request.Headers.Add(KeyHeader, Base64Key);
                request.Headers.Add(KeyHashHeader, Base64Hash);
            }
        }

        internal void ModifyRequestForRewriteSource(HttpRequestMessage request)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            if (Base64Key != null)
            {
                request.Headers.Add(CopySourceAlgorithmHeader, AlgorithmValue);
                request.Headers.Add(CopySourceKeyHeader, Base64Key);
                request.Headers.Add(CopySourceKeyHashHeader, Base64Hash);
            }
        }
    }
}
