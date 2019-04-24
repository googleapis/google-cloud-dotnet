// Copyright 2019 Google LLC
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
using Google.Apis.Storage.v1.Data;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    public partial class StorageClient
    {
        /// <summary>
        /// Synchronously creates a new HMAC key associated with a service account.
        /// </summary>
        /// <param name="projectId">The project ID in which to create the HMAC key. Must not be null.</param>
        /// <param name="serviceAccountEmail">The service account to associate with the HMAC key. Must not be null.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate defaults will be used.</param>
        /// <returns>The new HMAC key, including the secret information in <see cref="HmacKey.Secret"/>. This secret is only ever returned when creating a key.</returns>
        public virtual HmacKey CreateHmacKey(string projectId, string serviceAccountEmail, CreateHmacKeyOptions options = null) =>
            throw new NotImplementedException();

        /// <summary>
        /// Asynchronously creates a new HMAC key associated with a service account.
        /// </summary>
        /// <param name="projectId">The project ID in which to create the HMAC key. Must not be null.</param>
        /// <param name="serviceAccountEmail">The service account to associate with the HMAC key. Must not be null.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// the new HMAC key, including the secret information in <see cref="HmacKey.Secret"/>. This secret is only ever returned when creating a key.</returns>
        public virtual Task<HmacKey> CreateHmacKeyAsync(string projectId, string serviceAccountEmail, CreateHmacKeyOptions options = null, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        /// <summary>
        /// Synchronously fetches metadata for the specified HMAC key.
        /// </summary>
        /// <param name="projectId">The project containing the HMAC key. Must not be null.</param>
        /// <param name="accessId">The ID of the HMAC key. Must not be null.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate defaults will be used.</param>
        /// <returns>The HMAC key metadata</returns>
        public virtual HmacKeyMetadata GetHmacKey(string projectId, string accessId, GetHmacKeyOptions options = null) =>
            throw new NotImplementedException();

        /// <summary>
        /// Asynchronously fetches metadata for the specified HMAC key.
        /// </summary>
        /// <param name="projectId">The project containing the HMAC key. Must not be null.</param>
        /// <param name="accessId">The ID of the HMAC key. Must not be null.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the HMAC key metadata.</returns>
        public virtual Task<HmacKeyMetadata> GetHmacKeyAsync(string projectId, string accessId, GetHmacKeyOptions options = null, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        /// <summary>
        /// Lists the HMAC keys in a given project, synchronously but lazily, optionally filtering by service account email address.
        /// </summary>
        /// <remarks>
        /// This method fetches the buckets lazily, making requests to the underlying service
        /// for a page of results at a time, as required. No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </remarks>
        /// <param name="projectId">The project containing the HMAC keys. Must not be null.</param>
        /// <param name="serviceAccountEmail">The service account email address to list keys for. May be null, in which case all HMAC keys associated with the project are returned.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate defaults will be used.</param>
        /// <returns>A sequence of HMAC keys within the project.</returns>
        public virtual PagedEnumerable<HmacKeysMetadata, HmacKeyMetadata> ListHmacKeys(string projectId, string serviceAccountEmail = null, ListHmacKeysOptions options = null) =>
            throw new NotImplementedException();

        /// <summary>
        /// Lists the HMAC keys in a given project, asynchronously and lazily, optionally filtering by service account email address.
        /// </summary>
        /// <remarks>
        /// This method fetches the buckets lazily, making requests to the underlying service
        /// for a page of results at a time, as required. No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </remarks>
        /// <param name="projectId">The project containing the HMAC keys. Must not be null.</param>
        /// <param name="serviceAccountEmail">The service account email address to list keys for. May be null, in which case all HMAC keys associated with the project are returned.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate defaults will be used.</param>
        /// <returns>An asynchronous sequence of HMAC keys within the project.</returns>
        public virtual PagedAsyncEnumerable<HmacKeysMetadata, HmacKeyMetadata> ListHmacKeysAsync(string projectId, string serviceAccountEmail = null, ListHmacKeysOptions options = null) =>
            throw new NotImplementedException();

        /// <summary>
        /// Synchronously updates an HMAC key's metadata.
        /// </summary>
        /// <param name="key">The key to update. Must not be null, and the <see cref="HmacKeyMetadata.ProjectId"/> and <see cref="HmacKeyMetadata.AccessId"/> properties must be set.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate defaults will be used.</param>
        /// <returns>The updated key metadata.</returns>
        public virtual HmacKeyMetadata UpdateHmacKey(HmacKeyMetadata key, UpdateHmacKeyOptions options = null) =>
            throw new NotImplementedException();

        /// <summary>
        /// Asynchronously updates an HMAC key's metadata.
        /// </summary>
        /// <param name="key">The key to update. Must not be null, and the <see cref="HmacKeyMetadata.ProjectId"/> and <see cref="HmacKeyMetadata.AccessId"/> properties must be set.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the updated key metadata.</returns>
        public virtual Task<HmacKeyMetadata> UpdateHmacKeyAsync(HmacKeyMetadata key, UpdateHmacKeyOptions options = null, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        /// <summary>
        /// Synchronously deletes an HMAC key, which must already have been deactivated.
        /// </summary>
        /// <param name="projectId">The ID of the project containing the HMAC key to delete. </param>
        /// <param name="accessId">The ID of the HMAC key to delete. Must not be null.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate defaults will be used.</param>
        public virtual void DeleteHmacKey(string projectId, string accessId, DeleteHmacKeyOptions options = null) =>
            throw new NotImplementedException();

        /// <summary>
        /// Asynchronously deletes an HMAC key, which must already have been deactivated.
        /// </summary>
        /// <param name="projectId">The ID of the project containing the HMAC key to delete. </param>
        /// <param name="accessId">The ID of the HMAC key to delete. Must not be null.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task DeleteHmacKeyAsync(string projectId, string accessId, DeleteHmacKeyOptions options = null, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();
    }
}
