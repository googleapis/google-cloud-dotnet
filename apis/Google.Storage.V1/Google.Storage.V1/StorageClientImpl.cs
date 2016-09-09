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

using Google.Api.Gax.Rest;
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using System;
using System.Text.RegularExpressions;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Storage.V1
{
    /// <summary>
    /// Wrapper around <see cref="StorageService"/> to provide simpler operations.
    /// </summary>
    /// <remarks>
    /// This is the "default" implementation of <see cref="StorageClient"/>. Most client code
    /// should refer to <see cref="StorageClient"/>, creating instances with
    /// <see cref="StorageClient.Create(Apis.Auth.OAuth2.GoogleCredential)"/> and
    /// <see cref="StorageClient.CreateAsync(Apis.Auth.OAuth2.GoogleCredential)"/>. The constructor
    /// of this class is public for the sake of constructor-based dependency injection.
    /// </remarks>
    public sealed partial class StorageClientImpl : StorageClient
    {
        private static readonly object _applicationNameLock = new object();
        private static string _applicationName = UserAgentHelper.GetDefaultUserAgent(typeof(StorageClient));

        /// <summary>
        /// The default application name used when creating a <see cref="StorageService"/>.
        /// Defaults to "google-cloud-dotnet"; must not be null.
        /// </summary>
        /// <remarks>
        /// Most applications will never want to set this, which is why it's in this class rather than
        /// <see cref="StorageClient"/>.
        /// </remarks>
        public static string ApplicationName
        {
            get
            {
                lock (_applicationNameLock)
                {
                    return _applicationName;
                }
            }
            set
            {
                GaxRestPreconditions.CheckNotNull(value, nameof(value));
                lock (_applicationNameLock)
                {
                    _applicationName = value;
                }
            }
        }

        /// <inheritdoc />
        public override StorageService Service { get; }

        /// <summary>
        /// Constructs a new client wrapping the given <see cref="StorageService"/>.
        /// </summary>
        /// <param name="service">The service to wrap. Must not be null.</param>
        public StorageClientImpl(StorageService service)
        {            
            Service = GaxRestPreconditions.CheckNotNull(service, nameof(service));
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
        internal static void ValidateBucketName(string bucket)
        {
            GaxRestPreconditions.CheckNotNull(bucket, nameof(bucket));
            if (!ValidBucketName.IsMatch(bucket))
            {
                throw new ArgumentException($"Invalid bucket name '{bucket}' - see https://cloud.google.com/storage/docs/bucket-naming", nameof(bucket));
            }
        }

        /// <summary>
        /// Validates that the given Bucket has a "somewhat valid" (no URI encoding required) bucket name.
        /// </summary>
        /// <param name="bucket">Bucket to validate</param>
        /// <param name="paramName">The parameter name in the calling method</param>
        private void ValidateBucket(Bucket bucket, string paramName)
        {
            GaxRestPreconditions.CheckNotNull(bucket, paramName);
            GaxRestPreconditions.CheckArgument(bucket.Name != null, paramName, "Bucket must have a name");
            GaxRestPreconditions.CheckArgument(ValidBucketName.IsMatch(bucket.Name),
                paramName,
                "Invalid bucket name '{0}' - see https://cloud.google.com/storage/docs/bucket-naming", bucket.Name);
        }

        /// <summary>
        /// Validates that the given Object has a "somewhat valid" (no URI encoding required) bucket name and an object name.
        /// </summary>
        /// <param name="obj">Object to validate</param>
        /// <param name="paramName">The parameter name in the calling method</param>
        private void ValidateObject(Object obj, string paramName)
        {
            GaxRestPreconditions.CheckNotNull(obj, paramName);
            GaxRestPreconditions.CheckArgument(
                obj.Name != null && obj.Bucket != null,
                paramName,
                "Object must have a name and bucket");
            GaxRestPreconditions.CheckArgument(ValidBucketName.IsMatch(obj.Bucket),
                paramName,
                "Object bucket '{0}' is invalid", obj.Bucket);
        }
    }
}
