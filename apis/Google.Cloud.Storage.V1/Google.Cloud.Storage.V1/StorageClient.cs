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
    /// additional operations to be added in the future. See <see cref="Create(GoogleCredential)"/>
    /// and <see cref="CreateAsync(GoogleCredential)"/> to construct instances; alternatively, you can
    /// construct a <see cref="StorageClientImpl"/> directly from a <see cref="StorageService"/>.
    /// </para>
    /// <para>
    /// All instance methods declared in this class are virtual, with an implementation which simply
    /// throws <see cref="NotImplementedException"/>. All these methods are overridden in <see cref="StorageClientImpl"/>.
    /// </para>
    /// </remarks>
    public abstract partial class StorageClient
    {
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
        /// Asynchronously creates a <see cref="StorageClient"/>, using application default credentials if
        /// no credentials are specified.
        /// </summary>
        /// <remarks>
        /// The credentials are scoped as necessary.
        /// </remarks>
        /// <param name="credential">Optional <see cref="GoogleCredential"/>.</param>
        /// <returns>The task representing the created <see cref="StorageClient"/>.</returns>
        public static async Task<StorageClient> CreateAsync(GoogleCredential credential = null)
            // If no credentials have been specified, we fetch them "properly asynchronously"
            // to avoid the Task.Run in the synchronous call
            => Create(credential ?? await GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false));

        /// <summary>
        /// Synchronously creates a <see cref="StorageClient"/>, using application default credentials if
        /// no credentials are specified.
        /// </summary>
        /// <remarks>
        /// The credentials are scoped as necessary.
        /// </remarks>
        /// <param name="credential">Optional <see cref="GoogleCredential"/>.</param>
        /// <returns>The created <see cref="StorageClient"/>.</returns>
        public static StorageClient Create(GoogleCredential credential = null)
        {
            try
            {
                credential = credential ?? Task.Run(() => GoogleCredential.GetApplicationDefaultAsync()).Result;
            }
            catch (AggregateException e)
            {
                // Unwrap the first exception, a bit like await would.
                // It's very unlikely that we'd ever see an AggregateException without an inner exceptions,
                // but let's handle it relatively gracefully.
                throw e.InnerExceptions.FirstOrDefault() ?? e;
            }
            if (credential.IsCreateScopedRequired)
            {
                credential = credential.CreateScoped(StorageService.Scope.DevstorageFullControl);
            }
            var service = new StorageService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = StorageClientImpl.ApplicationName,
            });

            return new StorageClientImpl(service);
        }
    }
}
