// Copyright 2015 Google Inc. All Rights Reserved.
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
using Google.Api.Gax.Rest;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Storage.v1;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Abstract class providing operations for Google Cloud Storage.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This abstract class is provided to enable testability while permitting
    /// additional operations to be added in the future. See <see cref="Create(GoogleCredential, EncryptionKey)"/>
    /// and <see cref="CreateAsync(GoogleCredential, EncryptionKey)"/> to construct instances; alternatively, you can
    /// construct a <see cref="StorageClientImpl"/> directly from a <see cref="StorageService"/>.
    /// </para>
    /// <para>
    /// All instance methods declared in this class are virtual, with an implementation which simply
    /// throws <see cref="NotImplementedException"/>. All these methods are overridden in <see cref="StorageClientImpl"/>.
    /// </para>
    /// </remarks>
    public abstract partial class StorageClient
    {
        private static readonly ScopedCredentialProvider _credentialProvider = new ScopedCredentialProvider(
            new[] { StorageService.Scope.DevstorageFullControl });

        /// <summary>
        /// The underlying storage service object used by this client.
        /// </summary>
        /// <remarks>
        /// The <see cref="StorageClient"/> class only provides convenience operations built on top of
        /// an existing service object. Any more complex operations which are not supported by this wrapper may wish
        /// to use the same service object as the wrapper, in order to take advantage of its configuration (for authentication,
        /// application naming etc).
        /// </remarks>
        public virtual StorageService Service { get { throw new NotImplementedException(); } }

        /// <summary>
        /// The encryption key used by default for all relevant object-based operations. This can be overridden in call-specific options.
        /// This will never return null in the built-in implementation; if no encryption key is specified,
        /// <see cref="EncryptionKey.None"/> is returned.
        /// </summary>
        public virtual EncryptionKey EncryptionKey { get { throw new NotImplementedException(); } }

        /// <summary>
        /// Asynchronously creates a <see cref="StorageClient"/>, using application default credentials if
        /// no credentials are specified.
        /// </summary>
        /// <remarks>
        /// The credentials are scoped as necessary.
        /// </remarks>
        /// <param name="credential">Optional <see cref="GoogleCredential"/>.</param>
        /// <param name="encryptionKey">Optional <see cref="EncryptionKey"/> to use for all relevant object-based operations by default. May be null.</param>
        /// <returns>The task representing the created <see cref="StorageClient"/>.</returns>
        public static async Task<StorageClient> CreateAsync(GoogleCredential credential = null, EncryptionKey encryptionKey = null)
        {
            var scopedCredentials = await _credentialProvider.GetCredentialsAsync(credential).ConfigureAwait(false);
            return CreateImpl(scopedCredentials, encryptionKey);
        }

        /// <summary>
        /// Synchronously creates a <see cref="StorageClient"/>, using application default credentials if
        /// no credentials are specified.
        /// </summary>
        /// <remarks>
        /// The credentials are scoped as necessary.
        /// </remarks>
        /// <param name="credential">Optional <see cref="GoogleCredential"/>.</param>
        /// <param name="encryptionKey">Optional <see cref="EncryptionKey"/> to use for all relevant object-based operations by default. May be null.</param>
        /// <returns>The created <see cref="StorageClient"/>.</returns>
        public static StorageClient Create(GoogleCredential credential = null, EncryptionKey encryptionKey = null)
        {
            var scopedCredentials = _credentialProvider.GetCredentials(credential);
            return CreateImpl(scopedCredentials, encryptionKey);
        }


        private static StorageClient CreateImpl(GoogleCredential scopedCredentials, EncryptionKey encryptionKey)
        {
            var service = new StorageService(new BaseClientService.Initializer
            {
                HttpClientInitializer = scopedCredentials,
                ApplicationName = StorageClientImpl.ApplicationName,
            });

            return new StorageClientImpl(service, encryptionKey);
        }
    }
}
