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
using Google.Apis.Download;
using Google.Apis.Requests;
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Wrapper around <see cref="StorageService"/> to provide simpler operations.
    /// </summary>
    /// <remarks>
    /// This is the "default" implementation of <see cref="StorageClient"/>. Most client code
    /// should refer to <see cref="StorageClient"/>, creating instances with
    /// <see cref="StorageClient.Create(Apis.Auth.OAuth2.GoogleCredential, EncryptionKey)"/> and
    /// <see cref="StorageClient.CreateAsync(Apis.Auth.OAuth2.GoogleCredential, EncryptionKey)"/>. The constructor
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
                GaxPreconditions.CheckNotNull(value, nameof(value));
                lock (_applicationNameLock)
                {
                    _applicationName = value;
                }
            }
        }

        /// <inheritdoc />
        public override StorageService Service { get; }

        /// <inheritdoc />
        public override EncryptionKey EncryptionKey { get; }

        /// <summary>
        /// Scheduler used for retry delays, avoiding the use of Task.Delay
        /// in a way which is slow and hard to test thoroughly.
        /// </summary>
        private readonly IScheduler _scheduler;

        internal StorageClientImpl(StorageService service, EncryptionKey encryptionKey, IScheduler scheduler)
        {
            Service = GaxPreconditions.CheckNotNull(service, nameof(service));
            EncryptionKey = encryptionKey ?? EncryptionKey.None;
            _scheduler = scheduler ?? SystemScheduler.Instance;
        }

        /// <summary>
        /// Constructs a new client wrapping the given <see cref="StorageService"/>.
        /// </summary>
        /// <param name="service">The service to wrap. Must not be null.</param>
        /// <param name="encryptionKey">Optional <see cref="EncryptionKey"/> to use for object-based operations by default. May be null,
        /// in which case <see cref="EncryptionKey.None"/> will be used.</param>
        public StorageClientImpl(StorageService service, EncryptionKey encryptionKey = null) : this(service, encryptionKey, null)
        {
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
        /// <returns>The input, to allow inline validation</returns>
        internal static string ValidateBucketName(string bucket)
        {
            GaxPreconditions.CheckNotNull(bucket, nameof(bucket));
            if (!ValidBucketName.IsMatch(bucket))
            {
                throw new ArgumentException($"Invalid bucket name '{bucket}' - see https://cloud.google.com/storage/docs/bucket-naming", nameof(bucket));
            }
            return bucket;
        }

        /// <summary>
        /// Validates that the given Bucket has a "somewhat valid" (no URI encoding required) bucket name.
        /// </summary>
        /// <param name="bucket">Bucket to validate</param>
        /// <param name="paramName">The parameter name in the calling method</param>
        /// <returns>The validated bucket name</returns>
        private string ValidateBucket(Bucket bucket, string paramName)
        {
            GaxPreconditions.CheckNotNull(bucket, paramName);
            string name = bucket.Name;
            GaxPreconditions.CheckArgument(name != null, paramName, "Bucket must have a name");
            GaxPreconditions.CheckArgument(ValidBucketName.IsMatch(name),
                paramName,
                "Invalid bucket name '{0}' - see https://cloud.google.com/storage/docs/bucket-naming", bucket.Name);
            return name;
        }

        /// <summary>
        /// Validates that the given Object has a "somewhat valid" (no URI encoding required) bucket name and an object name.
        /// </summary>
        /// <param name="obj">Object to validate</param>
        /// <param name="paramName">The parameter name in the calling method</param>
        private void ValidateObject(Object obj, string paramName)
        {
            GaxPreconditions.CheckNotNull(obj, paramName);
            GaxPreconditions.CheckArgument(
                obj.Name != null && obj.Bucket != null,
                paramName,
                "Object must have a name and bucket");
            GaxPreconditions.CheckArgument(ValidBucketName.IsMatch(obj.Bucket),
                paramName,
                "Object bucket '{0}' is invalid", obj.Bucket);
        }

        /// <summary>
        /// Applies an encryption key to a request. Note that there is no overload without a kmsNameFromOptions, even though most
        /// requests don't have one, just to avoid missing one accidentally.
        /// </summary>
        /// <param name="keyFromOptions">The encryption key specified in the operation-specific options, or null.</param>
        /// <param name="kmsNameFromOptions">The KMS key name specified in the operation-specific options, or null.</param>
        /// <param name="request">The request to apply this to.</param>
        private void ApplyEncryptionKey<TRequest>(EncryptionKey keyFromOptions, string kmsNameFromOptions, ClientServiceRequest<TRequest> request)
        {
            var effectiveKey = GetEffectiveEncryptionKey(keyFromOptions, kmsNameFromOptions);
            request.ModifyRequest += effectiveKey.ModifyRequest;
        }

        private void ApplyEncryptionKey(EncryptionKey keyFromOptions, string kmsNameFromOptions, CustomMediaUpload upload)
        {
            var effectiveKey = GetEffectiveEncryptionKey(keyFromOptions, kmsNameFromOptions);
            upload.Options.ModifySessionInitiationRequest += effectiveKey.ModifyRequest;
        }

        // Downloaders don't have a KMS key name.
        private void ApplyEncryptionKey(EncryptionKey keyFromOptions, MediaDownloader download)
        {
            var effectiveKey = keyFromOptions ?? EncryptionKey;
            download.ModifyRequest += effectiveKey.ModifyRequest;
        }

        // Work out which EncryptionKey to use for a request, based on values from options. We mustn't end up
        // with both a CSEK and a CMEK; if the client has a default CSEK, it has to be explictly disabled in the options
        // in order to use a CMEK.
        // Only visible for test purposes.
        internal EncryptionKey GetEffectiveEncryptionKey(EncryptionKey keyFromOptions, string kmsNameFromOptions)
        {
            var effectiveKeyIgnoringKms = keyFromOptions ?? EncryptionKey;
            // It's valid to have *either* a CMEK or a CSEK, but not both.
            if (kmsNameFromOptions == null || effectiveKeyIgnoringKms == EncryptionKey.None)
            {
                return effectiveKeyIgnoringKms;
            }
            // We're definitely going to fail now, but we want to give clear details in the message.
            string message = keyFromOptions == null
                ? "This client has a default EncryptionKey. To specify a KmsKeyName for an operation, you must also set the EncryptionKey to EncryptionKey.None in the options for the operation."
                : "Can't specify both an EncryptionKey (other than EncryptionKey.None) and KmsKeyName in options for a single operation.";
            throw new ArgumentException(message, "options");
        }

        /// <inheritdoc />
        public override void Dispose() => Service.Dispose();

        private void MarkAsRetriable<TResponse>(StorageBaseServiceRequest<TResponse> request, RetryOptions options) =>
            RetryHandler.MarkAsRetriable(request, options, _scheduler);
    }
}
