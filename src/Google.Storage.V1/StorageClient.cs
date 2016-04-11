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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Storage.V1
{
    /// <summary>
    /// Wrapper around <see cref="StorageService"/> to provide simpler operations.
    /// </summary>
    public partial class StorageClient
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
        public StorageService Service { get; }

        /// <summary>
        /// Constructs a new client wrapping the given <see cref="StorageService"/>.
        /// </summary>
        /// <param name="service">The service to wrap. Must not be null.</param>
        public StorageClient(StorageService service)
        {
            Preconditions.CheckNotNull(service, nameof(service));
            Service = service;
        }

        /// <summary>
        /// Constructs a new client by creating a <see cref="StorageService"/> which uses the
        /// given <see cref="BaseClientService.Initializer"/> for request initialization.
        /// </summary>
        /// <param name="initializer">The initializer to use in the service. Must not be null.</param>
        public StorageClient(BaseClientService.Initializer initializer)
            : this(new StorageService(Preconditions.CheckNotNull(initializer, nameof(initializer))))
        {
        }

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
            credential = credential ?? Task.Run(() => GoogleCredential.GetApplicationDefaultAsync()).Result;
            if (credential.IsCreateScopedRequired)
            {
                credential = credential.CreateScoped(StorageService.Scope.DevstorageFullControl);
            }
            var initializer = new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "google-dotnet",
            };
            return new StorageClient(initializer);
        }

        /// <summary>
        /// Regular expression to be used for bucket validation when <see cref="ValidateBucket"/>
        /// would throw the wrong exception.
        /// </summary>
        private static readonly Regex ValidBucketName = new Regex(@"^[0-9a-z.\-_]{1,222}$");

        /// <summary>
        /// Validates that a bucket only contains valid characters, and is not too long. This is far from
        /// complete validation, but is all that's required to ensure that it's safe to include in a URL.
        /// This method also checks for nullity, so callers don't need to do that first.
        /// This method is internal rather than private for testing purposes.
        /// </summary>
        internal static void ValidateBucket(string bucket)
        {
            Preconditions.CheckNotNull(bucket, nameof(bucket));
            if (!ValidBucketName.IsMatch(bucket))
            {
                throw new ArgumentException($"Invalid bucket name '{bucket}' - see https://cloud.google.com/storage/docs/bucket-naming", nameof(bucket));
            }
        }


        /// <summary>
        /// Validates that the given Object has a "somewhat valid" (no URI encoding required) bucket name and an object name.
        /// </summary>
        /// <param name="obj">Object to validate</param>
        /// <param name="paramName">The parameter name in the calling method</param>
        private void ValidateObject(Object obj, string paramName)
        {
            Preconditions.CheckNotNull(obj, paramName);
            Preconditions.CheckArgument(
                obj.Name != null && obj.Bucket != null,
                paramName,
                "Object must have a name and bucket");
            Preconditions.CheckArgument(ValidBucketName.IsMatch(obj.Bucket),
                paramName,
                "Object bucket '{0}' is invalid", obj.Bucket);
        }
    }
}
