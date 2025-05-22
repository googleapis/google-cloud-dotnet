// Copyright 2025 Google LLC
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

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Storage.V2
{
    /// <summary>Settings for <see cref="StorageClient"/> instances.</summary>
    public sealed partial class StorageSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="StorageSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="StorageSettings"/>.</returns>
        public static StorageSettings GetDefault() => new StorageSettings();

        /// <summary>Constructs a new <see cref="StorageSettings"/> object with default settings.</summary>
        public StorageSettings()
        {
        }

        private StorageSettings(StorageSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteBucketSettings = existing.DeleteBucketSettings;
            GetBucketSettings = existing.GetBucketSettings;
            CreateBucketSettings = existing.CreateBucketSettings;
            ListBucketsSettings = existing.ListBucketsSettings;
            LockBucketRetentionPolicySettings = existing.LockBucketRetentionPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            UpdateBucketSettings = existing.UpdateBucketSettings;
            ComposeObjectSettings = existing.ComposeObjectSettings;
            DeleteObjectSettings = existing.DeleteObjectSettings;
            RestoreObjectSettings = existing.RestoreObjectSettings;
            CancelResumableWriteSettings = existing.CancelResumableWriteSettings;
            GetObjectSettings = existing.GetObjectSettings;
            ReadObjectSettings = existing.ReadObjectSettings;
            BidiReadObjectSettings = existing.BidiReadObjectSettings;
            BidiReadObjectStreamingSettings = existing.BidiReadObjectStreamingSettings;
            UpdateObjectSettings = existing.UpdateObjectSettings;
            WriteObjectSettings = existing.WriteObjectSettings;
            WriteObjectStreamingSettings = existing.WriteObjectStreamingSettings;
            BidiWriteObjectSettings = existing.BidiWriteObjectSettings;
            BidiWriteObjectStreamingSettings = existing.BidiWriteObjectStreamingSettings;
            ListObjectsSettings = existing.ListObjectsSettings;
            RewriteObjectSettings = existing.RewriteObjectSettings;
            StartResumableWriteSettings = existing.StartResumableWriteSettings;
            QueryWriteStatusSettings = existing.QueryWriteStatusSettings;
            MoveObjectSettings = existing.MoveObjectSettings;
            OnCopy(existing);
        }

        partial void OnCopy(StorageSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.DeleteBucket</c>
        ///  and <c>StorageClient.DeleteBucketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBucketSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.GetBucket</c>
        /// and <c>StorageClient.GetBucketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBucketSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.CreateBucket</c>
        ///  and <c>StorageClient.CreateBucketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBucketSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.ListBuckets</c>
        ///  and <c>StorageClient.ListBucketsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBucketsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageClient.LockBucketRetentionPolicy</c> and <c>StorageClient.LockBucketRetentionPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LockBucketRetentionPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.GetIamPolicy</c>
        ///  and <c>StorageClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.SetIamPolicy</c>
        ///  and <c>StorageClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageClient.TestIamPermissions</c> and <c>StorageClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.UpdateBucket</c>
        ///  and <c>StorageClient.UpdateBucketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBucketSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.ComposeObject</c>
        ///  and <c>StorageClient.ComposeObjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ComposeObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.DeleteObject</c>
        ///  and <c>StorageClient.DeleteObjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.RestoreObject</c>
        ///  and <c>StorageClient.RestoreObjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestoreObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageClient.CancelResumableWrite</c> and <c>StorageClient.CancelResumableWriteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelResumableWriteSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.GetObject</c>
        /// and <c>StorageClient.GetObjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.ReadObject</c>
        ///  and <c>StorageClient.ReadObjectAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 60 seconds.</remarks>
        public gaxgrpc::CallSettings ReadObjectSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageClient.BidiReadObject</c> and <c>StorageClient.BidiReadObjectAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 60 seconds.</remarks>
        public gaxgrpc::CallSettings BidiReadObjectSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>StorageClient.BidiReadObject</c> and
        /// <c>StorageClient.BidiReadObjectAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings BidiReadObjectStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.UpdateObject</c>
        ///  and <c>StorageClient.UpdateObjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.WriteObject</c>
        ///  and <c>StorageClient.WriteObjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings WriteObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::ClientStreamingSettings"/> for calls to <c>StorageClient.WriteObject</c> and
        /// <c>StorageClient.WriteObjectAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::ClientStreamingSettings WriteObjectStreamingSettings { get; set; } = new gaxgrpc::ClientStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageClient.BidiWriteObject</c> and <c>StorageClient.BidiWriteObjectAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 60 seconds.</remarks>
        public gaxgrpc::CallSettings BidiWriteObjectSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>StorageClient.BidiWriteObject</c> and
        /// <c>StorageClient.BidiWriteObjectAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings BidiWriteObjectStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.ListObjects</c>
        ///  and <c>StorageClient.ListObjectsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListObjectsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.RewriteObject</c>
        ///  and <c>StorageClient.RewriteObjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RewriteObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageClient.StartResumableWrite</c> and <c>StorageClient.StartResumableWriteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartResumableWriteSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageClient.QueryWriteStatus</c> and <c>StorageClient.QueryWriteStatusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryWriteStatusSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.MoveObject</c>
        ///  and <c>StorageClient.MoveObjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MoveObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="StorageSettings"/> object.</returns>
        public StorageSettings Clone() => new StorageSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="StorageClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class StorageClientBuilder : gaxgrpc::ClientBuilderBase<StorageClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public StorageSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public StorageClientBuilder() : base(StorageClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref StorageClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<StorageClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override StorageClient Build()
        {
            StorageClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<StorageClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<StorageClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private StorageClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return StorageClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<StorageClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return StorageClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => StorageClient.ChannelPool;
    }

    /// <summary>Storage client wrapper, for convenient use.</summary>
    /// <remarks>
    /// ## API Overview and Naming Syntax
    /// 
    /// The Cloud Storage gRPC API allows applications to read and write data through
    /// the abstractions of buckets and objects. For a description of these
    /// abstractions please see https://cloud.google.com/storage/docs.
    /// 
    /// Resources are named as follows:
    /// - Projects are referred to as they are defined by the Resource Manager API,
    /// using strings like `projects/123456` or `projects/my-string-id`.
    /// - Buckets are named using string names of the form:
    /// `projects/{project}/buckets/{bucket}`
    /// For globally unique buckets, `_` may be substituted for the project.
    /// - Objects are uniquely identified by their name along with the name of the
    /// bucket they belong to, as separate strings in this API. For example:
    /// 
    /// ReadObjectRequest {
    /// bucket: 'projects/_/buckets/my-bucket'
    /// object: 'my-object'
    /// }
    /// Note that object names can contain `/` characters, which are treated as
    /// any other character (no special directory semantics).
    /// </remarks>
    public abstract partial class StorageClient
    {
        /// <summary>
        /// The default endpoint for the Storage service, which is a host of "storage.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "storage.googleapis.com:443";

        /// <summary>The default Storage scopes.</summary>
        /// <remarks>
        /// The default Storage scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// <item><description>https://www.googleapis.com/auth/devstorage.full_control</description></item>
        /// <item><description>https://www.googleapis.com/auth/devstorage.read_only</description></item>
        /// <item><description>https://www.googleapis.com/auth/devstorage.read_write</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/devstorage.full_control",
            "https://www.googleapis.com/auth/devstorage.read_only",
            "https://www.googleapis.com/auth/devstorage.read_write",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Storage.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="StorageClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="StorageClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="StorageClient"/>.</returns>
        public static stt::Task<StorageClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new StorageClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="StorageClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="StorageClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="StorageClient"/>.</returns>
        public static StorageClient Create() => new StorageClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="StorageClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="StorageSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="StorageClient"/>.</returns>
        internal static StorageClient Create(grpccore::CallInvoker callInvoker, StorageSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Storage.StorageClient grpcClient = new Storage.StorageClient(callInvoker);
            return new StorageClientImpl(grpcClient, settings, logger);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC Storage client</summary>
        public virtual Storage.StorageClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBucket(DeleteBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBucketAsync(DeleteBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBucketAsync(DeleteBucketRequest request, st::CancellationToken cancellationToken) =>
            DeleteBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBucket(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBucket(new DeleteBucketRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBucketAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBucketAsync(new DeleteBucketRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBucketAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBucketAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBucket(BucketName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBucket(new DeleteBucketRequest
            {
                BucketName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBucketAsync(BucketName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBucketAsync(new DeleteBucketRequest
            {
                BucketName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBucketAsync(BucketName name, st::CancellationToken cancellationToken) =>
            DeleteBucketAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket GetBucket(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> GetBucketAsync(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> GetBucketAsync(GetBucketRequest request, st::CancellationToken cancellationToken) =>
            GetBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket GetBucket(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBucket(new GetBucketRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> GetBucketAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBucketAsync(new GetBucketRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> GetBucketAsync(string name, st::CancellationToken cancellationToken) =>
            GetBucketAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket GetBucket(BucketName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBucket(new GetBucketRequest
            {
                BucketName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> GetBucketAsync(BucketName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBucketAsync(new GetBucketRequest
            {
                BucketName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> GetBucketAsync(BucketName name, st::CancellationToken cancellationToken) =>
            GetBucketAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket CreateBucket(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> CreateBucketAsync(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> CreateBucketAsync(CreateBucketRequest request, st::CancellationToken cancellationToken) =>
            CreateBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to which this bucket will belong. This field must
        /// either be empty or `projects/_`. The project ID that owns this bucket
        /// should be specified in the `bucket.project` field.
        /// </param>
        /// <param name="bucket">
        /// Optional. Properties of the new bucket being inserted.
        /// The name of the bucket is specified in the `bucket_id` field. Populating
        /// `bucket.name` field will result in an error.
        /// The project of the bucket must be specified in the `bucket.project` field.
        /// This field must be in `projects/{projectIdentifier}` format,
        /// {projectIdentifier} can be the project ID or project number. The `parent`
        /// field must be either empty or `projects/_`.
        /// </param>
        /// <param name="bucketId">
        /// Required. The ID to use for this bucket, which will become the final
        /// component of the bucket's resource name. For example, the value `foo` might
        /// result in a bucket with the name `projects/123456/buckets/foo`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket CreateBucket(string parent, Bucket bucket, string bucketId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBucket(new CreateBucketRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Bucket = bucket,
                BucketId = gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)),
            }, callSettings);

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to which this bucket will belong. This field must
        /// either be empty or `projects/_`. The project ID that owns this bucket
        /// should be specified in the `bucket.project` field.
        /// </param>
        /// <param name="bucket">
        /// Optional. Properties of the new bucket being inserted.
        /// The name of the bucket is specified in the `bucket_id` field. Populating
        /// `bucket.name` field will result in an error.
        /// The project of the bucket must be specified in the `bucket.project` field.
        /// This field must be in `projects/{projectIdentifier}` format,
        /// {projectIdentifier} can be the project ID or project number. The `parent`
        /// field must be either empty or `projects/_`.
        /// </param>
        /// <param name="bucketId">
        /// Required. The ID to use for this bucket, which will become the final
        /// component of the bucket's resource name. For example, the value `foo` might
        /// result in a bucket with the name `projects/123456/buckets/foo`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> CreateBucketAsync(string parent, Bucket bucket, string bucketId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBucketAsync(new CreateBucketRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Bucket = bucket,
                BucketId = gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)),
            }, callSettings);

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to which this bucket will belong. This field must
        /// either be empty or `projects/_`. The project ID that owns this bucket
        /// should be specified in the `bucket.project` field.
        /// </param>
        /// <param name="bucket">
        /// Optional. Properties of the new bucket being inserted.
        /// The name of the bucket is specified in the `bucket_id` field. Populating
        /// `bucket.name` field will result in an error.
        /// The project of the bucket must be specified in the `bucket.project` field.
        /// This field must be in `projects/{projectIdentifier}` format,
        /// {projectIdentifier} can be the project ID or project number. The `parent`
        /// field must be either empty or `projects/_`.
        /// </param>
        /// <param name="bucketId">
        /// Required. The ID to use for this bucket, which will become the final
        /// component of the bucket's resource name. For example, the value `foo` might
        /// result in a bucket with the name `projects/123456/buckets/foo`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> CreateBucketAsync(string parent, Bucket bucket, string bucketId, st::CancellationToken cancellationToken) =>
            CreateBucketAsync(parent, bucket, bucketId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to which this bucket will belong. This field must
        /// either be empty or `projects/_`. The project ID that owns this bucket
        /// should be specified in the `bucket.project` field.
        /// </param>
        /// <param name="bucket">
        /// Optional. Properties of the new bucket being inserted.
        /// The name of the bucket is specified in the `bucket_id` field. Populating
        /// `bucket.name` field will result in an error.
        /// The project of the bucket must be specified in the `bucket.project` field.
        /// This field must be in `projects/{projectIdentifier}` format,
        /// {projectIdentifier} can be the project ID or project number. The `parent`
        /// field must be either empty or `projects/_`.
        /// </param>
        /// <param name="bucketId">
        /// Required. The ID to use for this bucket, which will become the final
        /// component of the bucket's resource name. For example, the value `foo` might
        /// result in a bucket with the name `projects/123456/buckets/foo`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket CreateBucket(gagr::ProjectName parent, Bucket bucket, string bucketId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBucket(new CreateBucketRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Bucket = bucket,
                BucketId = gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)),
            }, callSettings);

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to which this bucket will belong. This field must
        /// either be empty or `projects/_`. The project ID that owns this bucket
        /// should be specified in the `bucket.project` field.
        /// </param>
        /// <param name="bucket">
        /// Optional. Properties of the new bucket being inserted.
        /// The name of the bucket is specified in the `bucket_id` field. Populating
        /// `bucket.name` field will result in an error.
        /// The project of the bucket must be specified in the `bucket.project` field.
        /// This field must be in `projects/{projectIdentifier}` format,
        /// {projectIdentifier} can be the project ID or project number. The `parent`
        /// field must be either empty or `projects/_`.
        /// </param>
        /// <param name="bucketId">
        /// Required. The ID to use for this bucket, which will become the final
        /// component of the bucket's resource name. For example, the value `foo` might
        /// result in a bucket with the name `projects/123456/buckets/foo`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> CreateBucketAsync(gagr::ProjectName parent, Bucket bucket, string bucketId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBucketAsync(new CreateBucketRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Bucket = bucket,
                BucketId = gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)),
            }, callSettings);

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to which this bucket will belong. This field must
        /// either be empty or `projects/_`. The project ID that owns this bucket
        /// should be specified in the `bucket.project` field.
        /// </param>
        /// <param name="bucket">
        /// Optional. Properties of the new bucket being inserted.
        /// The name of the bucket is specified in the `bucket_id` field. Populating
        /// `bucket.name` field will result in an error.
        /// The project of the bucket must be specified in the `bucket.project` field.
        /// This field must be in `projects/{projectIdentifier}` format,
        /// {projectIdentifier} can be the project ID or project number. The `parent`
        /// field must be either empty or `projects/_`.
        /// </param>
        /// <param name="bucketId">
        /// Required. The ID to use for this bucket, which will become the final
        /// component of the bucket's resource name. For example, the value `foo` might
        /// result in a bucket with the name `projects/123456/buckets/foo`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> CreateBucketAsync(gagr::ProjectName parent, Bucket bucket, string bucketId, st::CancellationToken cancellationToken) =>
            CreateBucketAsync(parent, bucket, bucketId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of buckets for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Bucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, Bucket> ListBuckets(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of buckets for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Bucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, Bucket> ListBucketsAsync(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of buckets for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project whose buckets we are listing.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Bucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, Bucket> ListBuckets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBucketsRequest request = new ListBucketsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBuckets(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of buckets for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project whose buckets we are listing.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Bucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, Bucket> ListBucketsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBucketsRequest request = new ListBucketsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBucketsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of buckets for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project whose buckets we are listing.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Bucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, Bucket> ListBuckets(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBucketsRequest request = new ListBucketsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBuckets(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of buckets for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project whose buckets we are listing.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Bucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, Bucket> ListBucketsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBucketsRequest request = new ListBucketsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBucketsAsync(request, callSettings);
        }

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket LockBucketRetentionPolicy(LockBucketRetentionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> LockBucketRetentionPolicyAsync(LockBucketRetentionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> LockBucketRetentionPolicyAsync(LockBucketRetentionPolicyRequest request, st::CancellationToken cancellationToken) =>
            LockBucketRetentionPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket LockBucketRetentionPolicy(string bucket, gaxgrpc::CallSettings callSettings = null) =>
            LockBucketRetentionPolicy(new LockBucketRetentionPolicyRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
            }, callSettings);

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> LockBucketRetentionPolicyAsync(string bucket, gaxgrpc::CallSettings callSettings = null) =>
            LockBucketRetentionPolicyAsync(new LockBucketRetentionPolicyRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
            }, callSettings);

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> LockBucketRetentionPolicyAsync(string bucket, st::CancellationToken cancellationToken) =>
            LockBucketRetentionPolicyAsync(bucket, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket LockBucketRetentionPolicy(BucketName bucket, gaxgrpc::CallSettings callSettings = null) =>
            LockBucketRetentionPolicy(new LockBucketRetentionPolicyRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
            }, callSettings);

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> LockBucketRetentionPolicyAsync(BucketName bucket, gaxgrpc::CallSettings callSettings = null) =>
            LockBucketRetentionPolicyAsync(new LockBucketRetentionPolicyRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
            }, callSettings);

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> LockBucketRetentionPolicyAsync(BucketName bucket, st::CancellationToken cancellationToken) =>
            LockBucketRetentionPolicyAsync(bucket, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM policy for a specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM policy for a specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM policy for a specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM policy for a specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM policy for a specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM policy for a specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM policy for a specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM policy for a specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM policy for a specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an IAM policy for the specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an IAM policy for the specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an IAM policy for the specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an IAM policy for the specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Updates an IAM policy for the specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Updates an IAM policy for the specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an IAM policy for the specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Updates an IAM policy for the specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Updates an IAM policy for the specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tests a set of permissions on the given bucket, object, or managed folder
        /// to see which, if any, are held by the caller.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket,
        /// `projects/_/buckets/{bucket}/objects/{object}` for an object, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Tests a set of permissions on the given bucket, object, or managed folder
        /// to see which, if any, are held by the caller.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket,
        /// `projects/_/buckets/{bucket}/objects/{object}` for an object, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Tests a set of permissions on the given bucket, object, or managed folder
        /// to see which, if any, are held by the caller.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket,
        /// `projects/_/buckets/{bucket}/objects/{object}` for an object, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tests a set of permissions on the given bucket, object, or managed folder
        /// to see which, if any, are held by the caller.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket,
        /// `projects/_/buckets/{bucket}/objects/{object}` for an object, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Tests a set of permissions on the given bucket, object, or managed folder
        /// to see which, if any, are held by the caller.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket,
        /// `projects/_/buckets/{bucket}/objects/{object}` for an object, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Tests a set of permissions on the given bucket, object, or managed folder
        /// to see which, if any, are held by the caller.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket,
        /// `projects/_/buckets/{bucket}/objects/{object}` for an object, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tests a set of permissions on the given bucket, object, or managed folder
        /// to see which, if any, are held by the caller.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket,
        /// `projects/_/buckets/{bucket}/objects/{object}` for an object, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Tests a set of permissions on the given bucket, object, or managed folder
        /// to see which, if any, are held by the caller.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket,
        /// `projects/_/buckets/{bucket}/objects/{object}` for an object, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Tests a set of permissions on the given bucket, object, or managed folder
        /// to see which, if any, are held by the caller.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket,
        /// `projects/_/buckets/{bucket}/objects/{object}` for an object, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a bucket. Equivalent to JSON API's storage.buckets.patch method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket UpdateBucket(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a bucket. Equivalent to JSON API's storage.buckets.patch method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> UpdateBucketAsync(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a bucket. Equivalent to JSON API's storage.buckets.patch method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> UpdateBucketAsync(UpdateBucketRequest request, st::CancellationToken cancellationToken) =>
            UpdateBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a bucket. Equivalent to JSON API's storage.buckets.patch method.
        /// </summary>
        /// <param name="bucket">
        /// Required. The bucket to update.
        /// The bucket's `name` field will be used to identify the bucket.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated.
        /// 
        /// To specify ALL fields, equivalent to the JSON API's "update" function,
        /// specify a single field with the value `*`. Note: not recommended. If a new
        /// field is introduced at a later time, an older client updating with the `*`
        /// may accidentally reset the new field's value.
        /// 
        /// Not specifying any fields is an error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket UpdateBucket(Bucket bucket, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBucket(new UpdateBucketRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a bucket. Equivalent to JSON API's storage.buckets.patch method.
        /// </summary>
        /// <param name="bucket">
        /// Required. The bucket to update.
        /// The bucket's `name` field will be used to identify the bucket.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated.
        /// 
        /// To specify ALL fields, equivalent to the JSON API's "update" function,
        /// specify a single field with the value `*`. Note: not recommended. If a new
        /// field is introduced at a later time, an older client updating with the `*`
        /// may accidentally reset the new field's value.
        /// 
        /// Not specifying any fields is an error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> UpdateBucketAsync(Bucket bucket, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBucketAsync(new UpdateBucketRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a bucket. Equivalent to JSON API's storage.buckets.patch method.
        /// </summary>
        /// <param name="bucket">
        /// Required. The bucket to update.
        /// The bucket's `name` field will be used to identify the bucket.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated.
        /// 
        /// To specify ALL fields, equivalent to the JSON API's "update" function,
        /// specify a single field with the value `*`. Note: not recommended. If a new
        /// field is introduced at a later time, an older client updating with the `*`
        /// may accidentally reset the new field's value.
        /// 
        /// Not specifying any fields is an error.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> UpdateBucketAsync(Bucket bucket, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBucketAsync(bucket, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Concatenates a list of existing objects into a new object in the same
        /// bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object ComposeObject(ComposeObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Concatenates a list of existing objects into a new object in the same
        /// bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> ComposeObjectAsync(ComposeObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Concatenates a list of existing objects into a new object in the same
        /// bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> ComposeObjectAsync(ComposeObjectRequest request, st::CancellationToken cancellationToken) =>
            ComposeObjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning
        /// is not enabled for the bucket, or if the generation parameter is used, or
        /// if [soft delete](https://cloud.google.com/storage/docs/soft-delete) is not
        /// enabled for the bucket.
        /// When this API is used to delete an object from a bucket that has soft
        /// delete policy enabled, the object becomes soft deleted, and the
        /// `softDeleteTime` and `hardDeleteTime` properties are set on the object.
        /// This API cannot be used to permanently delete soft-deleted objects.
        /// Soft-deleted objects are permanently deleted according to their
        /// `hardDeleteTime`.
        /// 
        /// You can use the [`RestoreObject`][google.storage.v2.Storage.RestoreObject]
        /// API to restore soft-deleted objects until the soft delete retention period
        /// has passed.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.delete`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteObject(DeleteObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning
        /// is not enabled for the bucket, or if the generation parameter is used, or
        /// if [soft delete](https://cloud.google.com/storage/docs/soft-delete) is not
        /// enabled for the bucket.
        /// When this API is used to delete an object from a bucket that has soft
        /// delete policy enabled, the object becomes soft deleted, and the
        /// `softDeleteTime` and `hardDeleteTime` properties are set on the object.
        /// This API cannot be used to permanently delete soft-deleted objects.
        /// Soft-deleted objects are permanently deleted according to their
        /// `hardDeleteTime`.
        /// 
        /// You can use the [`RestoreObject`][google.storage.v2.Storage.RestoreObject]
        /// API to restore soft-deleted objects until the soft delete retention period
        /// has passed.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.delete`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(DeleteObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning
        /// is not enabled for the bucket, or if the generation parameter is used, or
        /// if [soft delete](https://cloud.google.com/storage/docs/soft-delete) is not
        /// enabled for the bucket.
        /// When this API is used to delete an object from a bucket that has soft
        /// delete policy enabled, the object becomes soft deleted, and the
        /// `softDeleteTime` and `hardDeleteTime` properties are set on the object.
        /// This API cannot be used to permanently delete soft-deleted objects.
        /// Soft-deleted objects are permanently deleted according to their
        /// `hardDeleteTime`.
        /// 
        /// You can use the [`RestoreObject`][google.storage.v2.Storage.RestoreObject]
        /// API to restore soft-deleted objects until the soft delete retention period
        /// has passed.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.delete`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(DeleteObjectRequest request, st::CancellationToken cancellationToken) =>
            DeleteObjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning
        /// is not enabled for the bucket, or if the generation parameter is used, or
        /// if [soft delete](https://cloud.google.com/storage/docs/soft-delete) is not
        /// enabled for the bucket.
        /// When this API is used to delete an object from a bucket that has soft
        /// delete policy enabled, the object becomes soft deleted, and the
        /// `softDeleteTime` and `hardDeleteTime` properties are set on the object.
        /// This API cannot be used to permanently delete soft-deleted objects.
        /// Soft-deleted objects are permanently deleted according to their
        /// `hardDeleteTime`.
        /// 
        /// You can use the [`RestoreObject`][google.storage.v2.Storage.RestoreObject]
        /// API to restore soft-deleted objects until the soft delete retention period
        /// has passed.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.delete`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteObject(string bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            DeleteObject(new DeleteObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning
        /// is not enabled for the bucket, or if the generation parameter is used, or
        /// if [soft delete](https://cloud.google.com/storage/docs/soft-delete) is not
        /// enabled for the bucket.
        /// When this API is used to delete an object from a bucket that has soft
        /// delete policy enabled, the object becomes soft deleted, and the
        /// `softDeleteTime` and `hardDeleteTime` properties are set on the object.
        /// This API cannot be used to permanently delete soft-deleted objects.
        /// Soft-deleted objects are permanently deleted according to their
        /// `hardDeleteTime`.
        /// 
        /// You can use the [`RestoreObject`][google.storage.v2.Storage.RestoreObject]
        /// API to restore soft-deleted objects until the soft delete retention period
        /// has passed.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.delete`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(string bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            DeleteObjectAsync(new DeleteObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning
        /// is not enabled for the bucket, or if the generation parameter is used, or
        /// if [soft delete](https://cloud.google.com/storage/docs/soft-delete) is not
        /// enabled for the bucket.
        /// When this API is used to delete an object from a bucket that has soft
        /// delete policy enabled, the object becomes soft deleted, and the
        /// `softDeleteTime` and `hardDeleteTime` properties are set on the object.
        /// This API cannot be used to permanently delete soft-deleted objects.
        /// Soft-deleted objects are permanently deleted according to their
        /// `hardDeleteTime`.
        /// 
        /// You can use the [`RestoreObject`][google.storage.v2.Storage.RestoreObject]
        /// API to restore soft-deleted objects until the soft delete retention period
        /// has passed.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.delete`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(string bucket, string @object, st::CancellationToken cancellationToken) =>
            DeleteObjectAsync(bucket, @object, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning
        /// is not enabled for the bucket, or if the generation parameter is used, or
        /// if [soft delete](https://cloud.google.com/storage/docs/soft-delete) is not
        /// enabled for the bucket.
        /// When this API is used to delete an object from a bucket that has soft
        /// delete policy enabled, the object becomes soft deleted, and the
        /// `softDeleteTime` and `hardDeleteTime` properties are set on the object.
        /// This API cannot be used to permanently delete soft-deleted objects.
        /// Soft-deleted objects are permanently deleted according to their
        /// `hardDeleteTime`.
        /// 
        /// You can use the [`RestoreObject`][google.storage.v2.Storage.RestoreObject]
        /// API to restore soft-deleted objects until the soft delete retention period
        /// has passed.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.delete`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteObject(BucketName bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            DeleteObject(new DeleteObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning
        /// is not enabled for the bucket, or if the generation parameter is used, or
        /// if [soft delete](https://cloud.google.com/storage/docs/soft-delete) is not
        /// enabled for the bucket.
        /// When this API is used to delete an object from a bucket that has soft
        /// delete policy enabled, the object becomes soft deleted, and the
        /// `softDeleteTime` and `hardDeleteTime` properties are set on the object.
        /// This API cannot be used to permanently delete soft-deleted objects.
        /// Soft-deleted objects are permanently deleted according to their
        /// `hardDeleteTime`.
        /// 
        /// You can use the [`RestoreObject`][google.storage.v2.Storage.RestoreObject]
        /// API to restore soft-deleted objects until the soft delete retention period
        /// has passed.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.delete`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(BucketName bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            DeleteObjectAsync(new DeleteObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning
        /// is not enabled for the bucket, or if the generation parameter is used, or
        /// if [soft delete](https://cloud.google.com/storage/docs/soft-delete) is not
        /// enabled for the bucket.
        /// When this API is used to delete an object from a bucket that has soft
        /// delete policy enabled, the object becomes soft deleted, and the
        /// `softDeleteTime` and `hardDeleteTime` properties are set on the object.
        /// This API cannot be used to permanently delete soft-deleted objects.
        /// Soft-deleted objects are permanently deleted according to their
        /// `hardDeleteTime`.
        /// 
        /// You can use the [`RestoreObject`][google.storage.v2.Storage.RestoreObject]
        /// API to restore soft-deleted objects until the soft delete retention period
        /// has passed.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.delete`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(BucketName bucket, string @object, st::CancellationToken cancellationToken) =>
            DeleteObjectAsync(bucket, @object, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning
        /// is not enabled for the bucket, or if the generation parameter is used, or
        /// if [soft delete](https://cloud.google.com/storage/docs/soft-delete) is not
        /// enabled for the bucket.
        /// When this API is used to delete an object from a bucket that has soft
        /// delete policy enabled, the object becomes soft deleted, and the
        /// `softDeleteTime` and `hardDeleteTime` properties are set on the object.
        /// This API cannot be used to permanently delete soft-deleted objects.
        /// Soft-deleted objects are permanently deleted according to their
        /// `hardDeleteTime`.
        /// 
        /// You can use the [`RestoreObject`][google.storage.v2.Storage.RestoreObject]
        /// API to restore soft-deleted objects until the soft delete retention period
        /// has passed.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.delete`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="generation">
        /// Optional. If present, permanently deletes a specific revision of this
        /// object (as opposed to the latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteObject(string bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            DeleteObject(new DeleteObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning
        /// is not enabled for the bucket, or if the generation parameter is used, or
        /// if [soft delete](https://cloud.google.com/storage/docs/soft-delete) is not
        /// enabled for the bucket.
        /// When this API is used to delete an object from a bucket that has soft
        /// delete policy enabled, the object becomes soft deleted, and the
        /// `softDeleteTime` and `hardDeleteTime` properties are set on the object.
        /// This API cannot be used to permanently delete soft-deleted objects.
        /// Soft-deleted objects are permanently deleted according to their
        /// `hardDeleteTime`.
        /// 
        /// You can use the [`RestoreObject`][google.storage.v2.Storage.RestoreObject]
        /// API to restore soft-deleted objects until the soft delete retention period
        /// has passed.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.delete`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="generation">
        /// Optional. If present, permanently deletes a specific revision of this
        /// object (as opposed to the latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(string bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            DeleteObjectAsync(new DeleteObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning
        /// is not enabled for the bucket, or if the generation parameter is used, or
        /// if [soft delete](https://cloud.google.com/storage/docs/soft-delete) is not
        /// enabled for the bucket.
        /// When this API is used to delete an object from a bucket that has soft
        /// delete policy enabled, the object becomes soft deleted, and the
        /// `softDeleteTime` and `hardDeleteTime` properties are set on the object.
        /// This API cannot be used to permanently delete soft-deleted objects.
        /// Soft-deleted objects are permanently deleted according to their
        /// `hardDeleteTime`.
        /// 
        /// You can use the [`RestoreObject`][google.storage.v2.Storage.RestoreObject]
        /// API to restore soft-deleted objects until the soft delete retention period
        /// has passed.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.delete`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="generation">
        /// Optional. If present, permanently deletes a specific revision of this
        /// object (as opposed to the latest version, the default).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(string bucket, string @object, long generation, st::CancellationToken cancellationToken) =>
            DeleteObjectAsync(bucket, @object, generation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning
        /// is not enabled for the bucket, or if the generation parameter is used, or
        /// if [soft delete](https://cloud.google.com/storage/docs/soft-delete) is not
        /// enabled for the bucket.
        /// When this API is used to delete an object from a bucket that has soft
        /// delete policy enabled, the object becomes soft deleted, and the
        /// `softDeleteTime` and `hardDeleteTime` properties are set on the object.
        /// This API cannot be used to permanently delete soft-deleted objects.
        /// Soft-deleted objects are permanently deleted according to their
        /// `hardDeleteTime`.
        /// 
        /// You can use the [`RestoreObject`][google.storage.v2.Storage.RestoreObject]
        /// API to restore soft-deleted objects until the soft delete retention period
        /// has passed.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.delete`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="generation">
        /// Optional. If present, permanently deletes a specific revision of this
        /// object (as opposed to the latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteObject(BucketName bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            DeleteObject(new DeleteObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning
        /// is not enabled for the bucket, or if the generation parameter is used, or
        /// if [soft delete](https://cloud.google.com/storage/docs/soft-delete) is not
        /// enabled for the bucket.
        /// When this API is used to delete an object from a bucket that has soft
        /// delete policy enabled, the object becomes soft deleted, and the
        /// `softDeleteTime` and `hardDeleteTime` properties are set on the object.
        /// This API cannot be used to permanently delete soft-deleted objects.
        /// Soft-deleted objects are permanently deleted according to their
        /// `hardDeleteTime`.
        /// 
        /// You can use the [`RestoreObject`][google.storage.v2.Storage.RestoreObject]
        /// API to restore soft-deleted objects until the soft delete retention period
        /// has passed.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.delete`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="generation">
        /// Optional. If present, permanently deletes a specific revision of this
        /// object (as opposed to the latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(BucketName bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            DeleteObjectAsync(new DeleteObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning
        /// is not enabled for the bucket, or if the generation parameter is used, or
        /// if [soft delete](https://cloud.google.com/storage/docs/soft-delete) is not
        /// enabled for the bucket.
        /// When this API is used to delete an object from a bucket that has soft
        /// delete policy enabled, the object becomes soft deleted, and the
        /// `softDeleteTime` and `hardDeleteTime` properties are set on the object.
        /// This API cannot be used to permanently delete soft-deleted objects.
        /// Soft-deleted objects are permanently deleted according to their
        /// `hardDeleteTime`.
        /// 
        /// You can use the [`RestoreObject`][google.storage.v2.Storage.RestoreObject]
        /// API to restore soft-deleted objects until the soft delete retention period
        /// has passed.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.delete`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="generation">
        /// Optional. If present, permanently deletes a specific revision of this
        /// object (as opposed to the latest version, the default).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(BucketName bucket, string @object, long generation, st::CancellationToken cancellationToken) =>
            DeleteObjectAsync(bucket, @object, generation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restores a soft-deleted object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object RestoreObject(RestoreObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores a soft-deleted object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> RestoreObjectAsync(RestoreObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores a soft-deleted object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> RestoreObjectAsync(RestoreObjectRequest request, st::CancellationToken cancellationToken) =>
            RestoreObjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restores a soft-deleted object.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the object to restore.
        /// </param>
        /// <param name="generation">
        /// Required. The specific revision of the object to restore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object RestoreObject(string bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            RestoreObject(new RestoreObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Restores a soft-deleted object.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the object to restore.
        /// </param>
        /// <param name="generation">
        /// Required. The specific revision of the object to restore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> RestoreObjectAsync(string bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            RestoreObjectAsync(new RestoreObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Restores a soft-deleted object.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the object to restore.
        /// </param>
        /// <param name="generation">
        /// Required. The specific revision of the object to restore.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> RestoreObjectAsync(string bucket, string @object, long generation, st::CancellationToken cancellationToken) =>
            RestoreObjectAsync(bucket, @object, generation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restores a soft-deleted object.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the object to restore.
        /// </param>
        /// <param name="generation">
        /// Required. The specific revision of the object to restore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object RestoreObject(BucketName bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            RestoreObject(new RestoreObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Restores a soft-deleted object.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the object to restore.
        /// </param>
        /// <param name="generation">
        /// Required. The specific revision of the object to restore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> RestoreObjectAsync(BucketName bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            RestoreObjectAsync(new RestoreObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Restores a soft-deleted object.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the object to restore.
        /// </param>
        /// <param name="generation">
        /// Required. The specific revision of the object to restore.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> RestoreObjectAsync(BucketName bucket, string @object, long generation, st::CancellationToken cancellationToken) =>
            RestoreObjectAsync(bucket, @object, generation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels an in-progress resumable upload.
        /// 
        /// Any attempts to write to the resumable upload after cancelling the upload
        /// will fail.
        /// 
        /// The behavior for currently in progress write operations is not guaranteed -
        /// they could either complete before the cancellation or fail if the
        /// cancellation completes first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CancelResumableWriteResponse CancelResumableWrite(CancelResumableWriteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels an in-progress resumable upload.
        /// 
        /// Any attempts to write to the resumable upload after cancelling the upload
        /// will fail.
        /// 
        /// The behavior for currently in progress write operations is not guaranteed -
        /// they could either complete before the cancellation or fail if the
        /// cancellation completes first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelResumableWriteResponse> CancelResumableWriteAsync(CancelResumableWriteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels an in-progress resumable upload.
        /// 
        /// Any attempts to write to the resumable upload after cancelling the upload
        /// will fail.
        /// 
        /// The behavior for currently in progress write operations is not guaranteed -
        /// they could either complete before the cancellation or fail if the
        /// cancellation completes first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelResumableWriteResponse> CancelResumableWriteAsync(CancelResumableWriteRequest request, st::CancellationToken cancellationToken) =>
            CancelResumableWriteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels an in-progress resumable upload.
        /// 
        /// Any attempts to write to the resumable upload after cancelling the upload
        /// will fail.
        /// 
        /// The behavior for currently in progress write operations is not guaranteed -
        /// they could either complete before the cancellation or fail if the
        /// cancellation completes first.
        /// </summary>
        /// <param name="uploadId">
        /// Required. The upload_id of the resumable upload to cancel. This should be
        /// copied from the `upload_id` field of `StartResumableWriteResponse`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CancelResumableWriteResponse CancelResumableWrite(string uploadId, gaxgrpc::CallSettings callSettings = null) =>
            CancelResumableWrite(new CancelResumableWriteRequest
            {
                UploadId = gax::GaxPreconditions.CheckNotNullOrEmpty(uploadId, nameof(uploadId)),
            }, callSettings);

        /// <summary>
        /// Cancels an in-progress resumable upload.
        /// 
        /// Any attempts to write to the resumable upload after cancelling the upload
        /// will fail.
        /// 
        /// The behavior for currently in progress write operations is not guaranteed -
        /// they could either complete before the cancellation or fail if the
        /// cancellation completes first.
        /// </summary>
        /// <param name="uploadId">
        /// Required. The upload_id of the resumable upload to cancel. This should be
        /// copied from the `upload_id` field of `StartResumableWriteResponse`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelResumableWriteResponse> CancelResumableWriteAsync(string uploadId, gaxgrpc::CallSettings callSettings = null) =>
            CancelResumableWriteAsync(new CancelResumableWriteRequest
            {
                UploadId = gax::GaxPreconditions.CheckNotNullOrEmpty(uploadId, nameof(uploadId)),
            }, callSettings);

        /// <summary>
        /// Cancels an in-progress resumable upload.
        /// 
        /// Any attempts to write to the resumable upload after cancelling the upload
        /// will fail.
        /// 
        /// The behavior for currently in progress write operations is not guaranteed -
        /// they could either complete before the cancellation or fail if the
        /// cancellation completes first.
        /// </summary>
        /// <param name="uploadId">
        /// Required. The upload_id of the resumable upload to cancel. This should be
        /// copied from the `upload_id` field of `StartResumableWriteResponse`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelResumableWriteResponse> CancelResumableWriteAsync(string uploadId, st::CancellationToken cancellationToken) =>
            CancelResumableWriteAsync(uploadId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves object metadata.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket. To return object ACLs, the authenticated user must also have
        /// the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object GetObject(GetObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves object metadata.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket. To return object ACLs, the authenticated user must also have
        /// the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(GetObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves object metadata.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket. To return object ACLs, the authenticated user must also have
        /// the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(GetObjectRequest request, st::CancellationToken cancellationToken) =>
            GetObjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves object metadata.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket. To return object ACLs, the authenticated user must also have
        /// the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object GetObject(string bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            GetObject(new GetObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Retrieves object metadata.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket. To return object ACLs, the authenticated user must also have
        /// the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(string bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            GetObjectAsync(new GetObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Retrieves object metadata.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket. To return object ACLs, the authenticated user must also have
        /// the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(string bucket, string @object, st::CancellationToken cancellationToken) =>
            GetObjectAsync(bucket, @object, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves object metadata.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket. To return object ACLs, the authenticated user must also have
        /// the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object GetObject(BucketName bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            GetObject(new GetObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Retrieves object metadata.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket. To return object ACLs, the authenticated user must also have
        /// the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(BucketName bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            GetObjectAsync(new GetObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Retrieves object metadata.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket. To return object ACLs, the authenticated user must also have
        /// the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(BucketName bucket, string @object, st::CancellationToken cancellationToken) =>
            GetObjectAsync(bucket, @object, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves object metadata.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket. To return object ACLs, the authenticated user must also have
        /// the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="generation">
        /// Optional. If present, selects a specific revision of this object (as
        /// opposed to the latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object GetObject(string bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            GetObject(new GetObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Retrieves object metadata.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket. To return object ACLs, the authenticated user must also have
        /// the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="generation">
        /// Optional. If present, selects a specific revision of this object (as
        /// opposed to the latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(string bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            GetObjectAsync(new GetObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Retrieves object metadata.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket. To return object ACLs, the authenticated user must also have
        /// the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="generation">
        /// Optional. If present, selects a specific revision of this object (as
        /// opposed to the latest version, the default).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(string bucket, string @object, long generation, st::CancellationToken cancellationToken) =>
            GetObjectAsync(bucket, @object, generation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves object metadata.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket. To return object ACLs, the authenticated user must also have
        /// the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="generation">
        /// Optional. If present, selects a specific revision of this object (as
        /// opposed to the latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object GetObject(BucketName bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            GetObject(new GetObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Retrieves object metadata.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket. To return object ACLs, the authenticated user must also have
        /// the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="generation">
        /// Optional. If present, selects a specific revision of this object (as
        /// opposed to the latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(BucketName bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            GetObjectAsync(new GetObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Retrieves object metadata.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket. To return object ACLs, the authenticated user must also have
        /// the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="generation">
        /// Optional. If present, selects a specific revision of this object (as
        /// opposed to the latest version, the default).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(BucketName bucket, string @object, long generation, st::CancellationToken cancellationToken) =>
            GetObjectAsync(bucket, @object, generation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for <see cref="ReadObject(ReadObjectRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class ReadObjectStream : gaxgrpc::ServerStreamingBase<ReadObjectResponse>
        {
        }

        /// <summary>
        /// Retrieves object data.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadObjectStream ReadObject(ReadObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves object data.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. The name of the bucket containing the object to read.
        /// </param>
        /// <param name="object">
        /// Required. The name of the object to read.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadObjectStream ReadObject(string bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            ReadObject(new ReadObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Retrieves object data.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. The name of the bucket containing the object to read.
        /// </param>
        /// <param name="object">
        /// Required. The name of the object to read.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadObjectStream ReadObject(BucketName bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            ReadObject(new ReadObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Retrieves object data.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. The name of the bucket containing the object to read.
        /// </param>
        /// <param name="object">
        /// Required. The name of the object to read.
        /// </param>
        /// <param name="generation">
        /// Optional. If present, selects a specific revision of this object (as
        /// opposed to the latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadObjectStream ReadObject(string bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            ReadObject(new ReadObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Retrieves object data.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. The name of the bucket containing the object to read.
        /// </param>
        /// <param name="object">
        /// Required. The name of the object to read.
        /// </param>
        /// <param name="generation">
        /// Optional. If present, selects a specific revision of this object (as
        /// opposed to the latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadObjectStream ReadObject(BucketName bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            ReadObject(new ReadObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="BidiReadObject(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class BidiReadObjectStream : gaxgrpc::BidirectionalStreamingBase<BidiReadObjectRequest, BidiReadObjectResponse>
        {
        }

        /// <summary>
        /// Reads an object's data.
        /// 
        /// This is a bi-directional API with the added support for reading multiple
        /// ranges within one stream both within and across multiple messages.
        /// If the server encountered an error for any of the inputs, the stream will
        /// be closed with the relevant error code.
        /// Because the API allows for multiple outstanding requests, when the stream
        /// is closed the error response will contain a BidiReadObjectRangesError proto
        /// in the error extension describing the error for each outstanding read_id.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// 
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// 
        /// This API is currently in preview and is not yet available for general
        /// use.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual BidiReadObjectStream BidiReadObject(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an object's metadata.
        /// Equivalent to JSON API's storage.objects.patch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object UpdateObject(UpdateObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an object's metadata.
        /// Equivalent to JSON API's storage.objects.patch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> UpdateObjectAsync(UpdateObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an object's metadata.
        /// Equivalent to JSON API's storage.objects.patch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> UpdateObjectAsync(UpdateObjectRequest request, st::CancellationToken cancellationToken) =>
            UpdateObjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an object's metadata.
        /// Equivalent to JSON API's storage.objects.patch.
        /// </summary>
        /// <param name="object">
        /// Required. The object to update.
        /// The object's bucket and name fields are used to identify the object to
        /// update. If present, the object's generation field selects a specific
        /// revision of this object whose metadata should be updated. Otherwise,
        /// assumes the live version of the object.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated.
        /// 
        /// To specify ALL fields, equivalent to the JSON API's "update" function,
        /// specify a single field with the value `*`. Note: not recommended. If a new
        /// field is introduced at a later time, an older client updating with the `*`
        /// may accidentally reset the new field's value.
        /// 
        /// Not specifying any fields is an error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object UpdateObject(Object @object, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateObject(new UpdateObjectRequest
            {
                Object = gax::GaxPreconditions.CheckNotNull(@object, nameof(@object)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an object's metadata.
        /// Equivalent to JSON API's storage.objects.patch.
        /// </summary>
        /// <param name="object">
        /// Required. The object to update.
        /// The object's bucket and name fields are used to identify the object to
        /// update. If present, the object's generation field selects a specific
        /// revision of this object whose metadata should be updated. Otherwise,
        /// assumes the live version of the object.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated.
        /// 
        /// To specify ALL fields, equivalent to the JSON API's "update" function,
        /// specify a single field with the value `*`. Note: not recommended. If a new
        /// field is introduced at a later time, an older client updating with the `*`
        /// may accidentally reset the new field's value.
        /// 
        /// Not specifying any fields is an error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> UpdateObjectAsync(Object @object, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateObjectAsync(new UpdateObjectRequest
            {
                Object = gax::GaxPreconditions.CheckNotNull(@object, nameof(@object)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an object's metadata.
        /// Equivalent to JSON API's storage.objects.patch.
        /// </summary>
        /// <param name="object">
        /// Required. The object to update.
        /// The object's bucket and name fields are used to identify the object to
        /// update. If present, the object's generation field selects a specific
        /// revision of this object whose metadata should be updated. Otherwise,
        /// assumes the live version of the object.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated.
        /// 
        /// To specify ALL fields, equivalent to the JSON API's "update" function,
        /// specify a single field with the value `*`. Note: not recommended. If a new
        /// field is introduced at a later time, an older client updating with the `*`
        /// may accidentally reset the new field's value.
        /// 
        /// Not specifying any fields is an error.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> UpdateObjectAsync(Object @object, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateObjectAsync(@object, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Client streaming methods for
        /// <see cref="WriteObject(gaxgrpc::CallSettings,gaxgrpc::ClientStreamingSettings)"/>.
        /// </summary>
        public abstract partial class WriteObjectStream : gaxgrpc::ClientStreamingBase<WriteObjectRequest, WriteObjectResponse>
        {
        }

        /// <summary>
        /// Stores a new object and metadata.
        /// 
        /// An object can be written either in a single message stream or in a
        /// resumable sequence of message streams. To write using a single stream,
        /// the client should include in the first message of the stream an
        /// `WriteObjectSpec` describing the destination bucket, object, and any
        /// preconditions. Additionally, the final message must set 'finish_write' to
        /// true, or else it is an error.
        /// 
        /// For a resumable write, the client should instead call
        /// `StartResumableWrite()`, populating a `WriteObjectSpec` into that request.
        /// They should then attach the returned `upload_id` to the first message of
        /// each following call to `WriteObject`. If the stream is closed before
        /// finishing the upload (either explicitly by the client or due to a network
        /// error or an error response from the server), the client should do as
        /// follows:
        /// - Check the result Status of the stream, to determine if writing can be
        /// resumed on this stream or must be restarted from scratch (by calling
        /// `StartResumableWrite()`). The resumable errors are DEADLINE_EXCEEDED,
        /// INTERNAL, and UNAVAILABLE. For each case, the client should use binary
        /// exponential backoff before retrying.  Additionally, writes can be
        /// resumed after RESOURCE_EXHAUSTED errors, but only after taking
        /// appropriate measures, which may include reducing aggregate send rate
        /// across clients and/or requesting a quota increase for your project.
        /// - If the call to `WriteObject` returns `ABORTED`, that indicates
        /// concurrent attempts to update the resumable write, caused either by
        /// multiple racing clients or by a single client where the previous
        /// request was timed out on the client side but nonetheless reached the
        /// server. In this case the client should take steps to prevent further
        /// concurrent writes (e.g., increase the timeouts, stop using more than
        /// one process to perform the upload, etc.), and then should follow the
        /// steps below for resuming the upload.
        /// - For resumable errors, the client should call `QueryWriteStatus()` and
        /// then continue writing from the returned `persisted_size`. This may be
        /// less than the amount of data the client previously sent. Note also that
        /// it is acceptable to send data starting at an offset earlier than the
        /// returned `persisted_size`; in this case, the service will skip data at
        /// offsets that were already persisted (without checking that it matches
        /// the previously written data), and write only the data starting from the
        /// persisted offset. Even though the data isn't written, it may still
        /// incur a performance cost over resuming at the correct write offset.
        /// This behavior can make client-side handling simpler in some cases.
        /// - Clients must only send data that is a multiple of 256 KiB per message,
        /// unless the object is being finished with `finish_write` set to `true`.
        /// 
        /// The service will not view the object as complete until the client has
        /// sent a `WriteObjectRequest` with `finish_write` set to `true`. Sending any
        /// requests on a stream after sending a request with `finish_write` set to
        /// `true` will cause an error. The client **should** check the response it
        /// receives to determine how much data the service was able to commit and
        /// whether the service views the object as complete.
        /// 
        /// Attempting to resume an already finalized object will result in an OK
        /// status, with a `WriteObjectResponse` containing the finalized object's
        /// metadata.
        /// 
        /// Alternatively, the BidiWriteObject operation may be used to write an
        /// object with controls over flushing and the ability to fetch the ability to
        /// determine the current persisted size.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.create`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client stream.</returns>
        public virtual WriteObjectStream WriteObject(gaxgrpc::CallSettings callSettings = null, gaxgrpc::ClientStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="BidiWriteObject(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class BidiWriteObjectStream : gaxgrpc::BidirectionalStreamingBase<BidiWriteObjectRequest, BidiWriteObjectResponse>
        {
        }

        /// <summary>
        /// Stores a new object and metadata.
        /// 
        /// This is similar to the WriteObject call with the added support for
        /// manual flushing of persisted state, and the ability to determine current
        /// persisted size without closing the stream.
        /// 
        /// The client may specify one or both of the `state_lookup` and `flush` fields
        /// in each BidiWriteObjectRequest. If `flush` is specified, the data written
        /// so far will be persisted to storage. If `state_lookup` is specified, the
        /// service will respond with a BidiWriteObjectResponse that contains the
        /// persisted size. If both `flush` and `state_lookup` are specified, the flush
        /// will always occur before a `state_lookup`, so that both may be set in the
        /// same request and the returned state will be the state of the object
        /// post-flush. When the stream is closed, a BidiWriteObjectResponse will
        /// always be sent to the client, regardless of the value of `state_lookup`.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual BidiWriteObjectStream BidiWriteObject(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of objects matching the criteria.
        /// 
        /// **IAM Permissions**:
        /// 
        /// The authenticated user requires `storage.objects.list`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions)
        /// to use this method. To return object ACLs, the authenticated user must also
        /// have the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Object"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListObjectsResponse, Object> ListObjects(ListObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of objects matching the criteria.
        /// 
        /// **IAM Permissions**:
        /// 
        /// The authenticated user requires `storage.objects.list`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions)
        /// to use this method. To return object ACLs, the authenticated user must also
        /// have the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Object"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListObjectsResponse, Object> ListObjectsAsync(ListObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of objects matching the criteria.
        /// 
        /// **IAM Permissions**:
        /// 
        /// The authenticated user requires `storage.objects.list`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions)
        /// to use this method. To return object ACLs, the authenticated user must also
        /// have the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which to look for objects.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Object"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListObjectsResponse, Object> ListObjects(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListObjectsRequest request = new ListObjectsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListObjects(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of objects matching the criteria.
        /// 
        /// **IAM Permissions**:
        /// 
        /// The authenticated user requires `storage.objects.list`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions)
        /// to use this method. To return object ACLs, the authenticated user must also
        /// have the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which to look for objects.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Object"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListObjectsResponse, Object> ListObjectsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListObjectsRequest request = new ListObjectsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListObjectsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of objects matching the criteria.
        /// 
        /// **IAM Permissions**:
        /// 
        /// The authenticated user requires `storage.objects.list`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions)
        /// to use this method. To return object ACLs, the authenticated user must also
        /// have the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which to look for objects.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Object"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListObjectsResponse, Object> ListObjects(BucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListObjectsRequest request = new ListObjectsRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListObjects(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of objects matching the criteria.
        /// 
        /// **IAM Permissions**:
        /// 
        /// The authenticated user requires `storage.objects.list`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions)
        /// to use this method. To return object ACLs, the authenticated user must also
        /// have the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which to look for objects.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Object"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListObjectsResponse, Object> ListObjectsAsync(BucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListObjectsRequest request = new ListObjectsRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListObjectsAsync(request, callSettings);
        }

        /// <summary>
        /// Rewrites a source object to a destination object. Optionally overrides
        /// metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RewriteResponse RewriteObject(RewriteObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rewrites a source object to a destination object. Optionally overrides
        /// metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RewriteResponse> RewriteObjectAsync(RewriteObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rewrites a source object to a destination object. Optionally overrides
        /// metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RewriteResponse> RewriteObjectAsync(RewriteObjectRequest request, st::CancellationToken cancellationToken) =>
            RewriteObjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a resumable write operation. This
        /// method is part of the [Resumable
        /// upload](https://cloud.google.com/storage/docs/resumable-uploads) feature.
        /// This allows you to upload large objects in multiple chunks, which is more
        /// resilient to network interruptions than a single upload. The validity
        /// duration of the write operation, and the consequences of it becoming
        /// invalid, are service-dependent.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.create`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StartResumableWriteResponse StartResumableWrite(StartResumableWriteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a resumable write operation. This
        /// method is part of the [Resumable
        /// upload](https://cloud.google.com/storage/docs/resumable-uploads) feature.
        /// This allows you to upload large objects in multiple chunks, which is more
        /// resilient to network interruptions than a single upload. The validity
        /// duration of the write operation, and the consequences of it becoming
        /// invalid, are service-dependent.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.create`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartResumableWriteResponse> StartResumableWriteAsync(StartResumableWriteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a resumable write operation. This
        /// method is part of the [Resumable
        /// upload](https://cloud.google.com/storage/docs/resumable-uploads) feature.
        /// This allows you to upload large objects in multiple chunks, which is more
        /// resilient to network interruptions than a single upload. The validity
        /// duration of the write operation, and the consequences of it becoming
        /// invalid, are service-dependent.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.create`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartResumableWriteResponse> StartResumableWriteAsync(StartResumableWriteRequest request, st::CancellationToken cancellationToken) =>
            StartResumableWriteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Determines the `persisted_size` of an object that is being written. This
        /// method is part of the [resumable
        /// upload](https://cloud.google.com/storage/docs/resumable-uploads) feature.
        /// The returned value is the size of the object that has been persisted so
        /// far. The value can be used as the `write_offset` for the next `Write()`
        /// call.
        /// 
        /// If the object does not exist, meaning if it was deleted, or the
        /// first `Write()` has not yet reached the service, this method returns the
        /// error `NOT_FOUND`.
        /// 
        /// This method is useful for clients that buffer data and need to know which
        /// data can be safely evicted. The client can call `QueryWriteStatus()` at any
        /// time to determine how much data has been logged for this object.
        /// For any sequence of `QueryWriteStatus()` calls for a given
        /// object name, the sequence of returned `persisted_size` values are
        /// non-decreasing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryWriteStatusResponse QueryWriteStatus(QueryWriteStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Determines the `persisted_size` of an object that is being written. This
        /// method is part of the [resumable
        /// upload](https://cloud.google.com/storage/docs/resumable-uploads) feature.
        /// The returned value is the size of the object that has been persisted so
        /// far. The value can be used as the `write_offset` for the next `Write()`
        /// call.
        /// 
        /// If the object does not exist, meaning if it was deleted, or the
        /// first `Write()` has not yet reached the service, this method returns the
        /// error `NOT_FOUND`.
        /// 
        /// This method is useful for clients that buffer data and need to know which
        /// data can be safely evicted. The client can call `QueryWriteStatus()` at any
        /// time to determine how much data has been logged for this object.
        /// For any sequence of `QueryWriteStatus()` calls for a given
        /// object name, the sequence of returned `persisted_size` values are
        /// non-decreasing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryWriteStatusResponse> QueryWriteStatusAsync(QueryWriteStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Determines the `persisted_size` of an object that is being written. This
        /// method is part of the [resumable
        /// upload](https://cloud.google.com/storage/docs/resumable-uploads) feature.
        /// The returned value is the size of the object that has been persisted so
        /// far. The value can be used as the `write_offset` for the next `Write()`
        /// call.
        /// 
        /// If the object does not exist, meaning if it was deleted, or the
        /// first `Write()` has not yet reached the service, this method returns the
        /// error `NOT_FOUND`.
        /// 
        /// This method is useful for clients that buffer data and need to know which
        /// data can be safely evicted. The client can call `QueryWriteStatus()` at any
        /// time to determine how much data has been logged for this object.
        /// For any sequence of `QueryWriteStatus()` calls for a given
        /// object name, the sequence of returned `persisted_size` values are
        /// non-decreasing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryWriteStatusResponse> QueryWriteStatusAsync(QueryWriteStatusRequest request, st::CancellationToken cancellationToken) =>
            QueryWriteStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Determines the `persisted_size` of an object that is being written. This
        /// method is part of the [resumable
        /// upload](https://cloud.google.com/storage/docs/resumable-uploads) feature.
        /// The returned value is the size of the object that has been persisted so
        /// far. The value can be used as the `write_offset` for the next `Write()`
        /// call.
        /// 
        /// If the object does not exist, meaning if it was deleted, or the
        /// first `Write()` has not yet reached the service, this method returns the
        /// error `NOT_FOUND`.
        /// 
        /// This method is useful for clients that buffer data and need to know which
        /// data can be safely evicted. The client can call `QueryWriteStatus()` at any
        /// time to determine how much data has been logged for this object.
        /// For any sequence of `QueryWriteStatus()` calls for a given
        /// object name, the sequence of returned `persisted_size` values are
        /// non-decreasing.
        /// </summary>
        /// <param name="uploadId">
        /// Required. The name of the resume token for the object whose write status is
        /// being requested.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryWriteStatusResponse QueryWriteStatus(string uploadId, gaxgrpc::CallSettings callSettings = null) =>
            QueryWriteStatus(new QueryWriteStatusRequest
            {
                UploadId = gax::GaxPreconditions.CheckNotNullOrEmpty(uploadId, nameof(uploadId)),
            }, callSettings);

        /// <summary>
        /// Determines the `persisted_size` of an object that is being written. This
        /// method is part of the [resumable
        /// upload](https://cloud.google.com/storage/docs/resumable-uploads) feature.
        /// The returned value is the size of the object that has been persisted so
        /// far. The value can be used as the `write_offset` for the next `Write()`
        /// call.
        /// 
        /// If the object does not exist, meaning if it was deleted, or the
        /// first `Write()` has not yet reached the service, this method returns the
        /// error `NOT_FOUND`.
        /// 
        /// This method is useful for clients that buffer data and need to know which
        /// data can be safely evicted. The client can call `QueryWriteStatus()` at any
        /// time to determine how much data has been logged for this object.
        /// For any sequence of `QueryWriteStatus()` calls for a given
        /// object name, the sequence of returned `persisted_size` values are
        /// non-decreasing.
        /// </summary>
        /// <param name="uploadId">
        /// Required. The name of the resume token for the object whose write status is
        /// being requested.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryWriteStatusResponse> QueryWriteStatusAsync(string uploadId, gaxgrpc::CallSettings callSettings = null) =>
            QueryWriteStatusAsync(new QueryWriteStatusRequest
            {
                UploadId = gax::GaxPreconditions.CheckNotNullOrEmpty(uploadId, nameof(uploadId)),
            }, callSettings);

        /// <summary>
        /// Determines the `persisted_size` of an object that is being written. This
        /// method is part of the [resumable
        /// upload](https://cloud.google.com/storage/docs/resumable-uploads) feature.
        /// The returned value is the size of the object that has been persisted so
        /// far. The value can be used as the `write_offset` for the next `Write()`
        /// call.
        /// 
        /// If the object does not exist, meaning if it was deleted, or the
        /// first `Write()` has not yet reached the service, this method returns the
        /// error `NOT_FOUND`.
        /// 
        /// This method is useful for clients that buffer data and need to know which
        /// data can be safely evicted. The client can call `QueryWriteStatus()` at any
        /// time to determine how much data has been logged for this object.
        /// For any sequence of `QueryWriteStatus()` calls for a given
        /// object name, the sequence of returned `persisted_size` values are
        /// non-decreasing.
        /// </summary>
        /// <param name="uploadId">
        /// Required. The name of the resume token for the object whose write status is
        /// being requested.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryWriteStatusResponse> QueryWriteStatusAsync(string uploadId, st::CancellationToken cancellationToken) =>
            QueryWriteStatusAsync(uploadId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves the source object to the destination object in the same bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object MoveObject(MoveObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves the source object to the destination object in the same bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> MoveObjectAsync(MoveObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves the source object to the destination object in the same bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> MoveObjectAsync(MoveObjectRequest request, st::CancellationToken cancellationToken) =>
            MoveObjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves the source object to the destination object in the same bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="sourceObject">
        /// Required. Name of the source object.
        /// </param>
        /// <param name="destinationObject">
        /// Required. Name of the destination object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object MoveObject(string bucket, string sourceObject, string destinationObject, gaxgrpc::CallSettings callSettings = null) =>
            MoveObject(new MoveObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                SourceObject = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceObject, nameof(sourceObject)),
                DestinationObject = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationObject, nameof(destinationObject)),
            }, callSettings);

        /// <summary>
        /// Moves the source object to the destination object in the same bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="sourceObject">
        /// Required. Name of the source object.
        /// </param>
        /// <param name="destinationObject">
        /// Required. Name of the destination object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> MoveObjectAsync(string bucket, string sourceObject, string destinationObject, gaxgrpc::CallSettings callSettings = null) =>
            MoveObjectAsync(new MoveObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                SourceObject = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceObject, nameof(sourceObject)),
                DestinationObject = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationObject, nameof(destinationObject)),
            }, callSettings);

        /// <summary>
        /// Moves the source object to the destination object in the same bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="sourceObject">
        /// Required. Name of the source object.
        /// </param>
        /// <param name="destinationObject">
        /// Required. Name of the destination object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> MoveObjectAsync(string bucket, string sourceObject, string destinationObject, st::CancellationToken cancellationToken) =>
            MoveObjectAsync(bucket, sourceObject, destinationObject, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves the source object to the destination object in the same bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="sourceObject">
        /// Required. Name of the source object.
        /// </param>
        /// <param name="destinationObject">
        /// Required. Name of the destination object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object MoveObject(BucketName bucket, string sourceObject, string destinationObject, gaxgrpc::CallSettings callSettings = null) =>
            MoveObject(new MoveObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                SourceObject = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceObject, nameof(sourceObject)),
                DestinationObject = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationObject, nameof(destinationObject)),
            }, callSettings);

        /// <summary>
        /// Moves the source object to the destination object in the same bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="sourceObject">
        /// Required. Name of the source object.
        /// </param>
        /// <param name="destinationObject">
        /// Required. Name of the destination object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> MoveObjectAsync(BucketName bucket, string sourceObject, string destinationObject, gaxgrpc::CallSettings callSettings = null) =>
            MoveObjectAsync(new MoveObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                SourceObject = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceObject, nameof(sourceObject)),
                DestinationObject = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationObject, nameof(destinationObject)),
            }, callSettings);

        /// <summary>
        /// Moves the source object to the destination object in the same bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="sourceObject">
        /// Required. Name of the source object.
        /// </param>
        /// <param name="destinationObject">
        /// Required. Name of the destination object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> MoveObjectAsync(BucketName bucket, string sourceObject, string destinationObject, st::CancellationToken cancellationToken) =>
            MoveObjectAsync(bucket, sourceObject, destinationObject, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Storage client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// ## API Overview and Naming Syntax
    /// 
    /// The Cloud Storage gRPC API allows applications to read and write data through
    /// the abstractions of buckets and objects. For a description of these
    /// abstractions please see https://cloud.google.com/storage/docs.
    /// 
    /// Resources are named as follows:
    /// - Projects are referred to as they are defined by the Resource Manager API,
    /// using strings like `projects/123456` or `projects/my-string-id`.
    /// - Buckets are named using string names of the form:
    /// `projects/{project}/buckets/{bucket}`
    /// For globally unique buckets, `_` may be substituted for the project.
    /// - Objects are uniquely identified by their name along with the name of the
    /// bucket they belong to, as separate strings in this API. For example:
    /// 
    /// ReadObjectRequest {
    /// bucket: 'projects/_/buckets/my-bucket'
    /// object: 'my-object'
    /// }
    /// Note that object names can contain `/` characters, which are treated as
    /// any other character (no special directory semantics).
    /// </remarks>
    public sealed partial class StorageClientImpl : StorageClient
    {
        private readonly gaxgrpc::ApiCall<DeleteBucketRequest, wkt::Empty> _callDeleteBucket;

        private readonly gaxgrpc::ApiCall<GetBucketRequest, Bucket> _callGetBucket;

        private readonly gaxgrpc::ApiCall<CreateBucketRequest, Bucket> _callCreateBucket;

        private readonly gaxgrpc::ApiCall<ListBucketsRequest, ListBucketsResponse> _callListBuckets;

        private readonly gaxgrpc::ApiCall<LockBucketRetentionPolicyRequest, Bucket> _callLockBucketRetentionPolicy;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        private readonly gaxgrpc::ApiCall<UpdateBucketRequest, Bucket> _callUpdateBucket;

        private readonly gaxgrpc::ApiCall<ComposeObjectRequest, Object> _callComposeObject;

        private readonly gaxgrpc::ApiCall<DeleteObjectRequest, wkt::Empty> _callDeleteObject;

        private readonly gaxgrpc::ApiCall<RestoreObjectRequest, Object> _callRestoreObject;

        private readonly gaxgrpc::ApiCall<CancelResumableWriteRequest, CancelResumableWriteResponse> _callCancelResumableWrite;

        private readonly gaxgrpc::ApiCall<GetObjectRequest, Object> _callGetObject;

        private readonly gaxgrpc::ApiServerStreamingCall<ReadObjectRequest, ReadObjectResponse> _callReadObject;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<BidiReadObjectRequest, BidiReadObjectResponse> _callBidiReadObject;

        private readonly gaxgrpc::ApiCall<UpdateObjectRequest, Object> _callUpdateObject;

        private readonly gaxgrpc::ApiClientStreamingCall<WriteObjectRequest, WriteObjectResponse> _callWriteObject;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<BidiWriteObjectRequest, BidiWriteObjectResponse> _callBidiWriteObject;

        private readonly gaxgrpc::ApiCall<ListObjectsRequest, ListObjectsResponse> _callListObjects;

        private readonly gaxgrpc::ApiCall<RewriteObjectRequest, RewriteResponse> _callRewriteObject;

        private readonly gaxgrpc::ApiCall<StartResumableWriteRequest, StartResumableWriteResponse> _callStartResumableWrite;

        private readonly gaxgrpc::ApiCall<QueryWriteStatusRequest, QueryWriteStatusResponse> _callQueryWriteStatus;

        private readonly gaxgrpc::ApiCall<MoveObjectRequest, Object> _callMoveObject;

        /// <summary>
        /// Constructs a client wrapper for the Storage service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="StorageSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public StorageClientImpl(Storage.StorageClient grpcClient, StorageSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            StorageSettings effectiveSettings = settings ?? StorageSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callDeleteBucket = clientHelper.BuildApiCall<DeleteBucketRequest, wkt::Empty>("DeleteBucket", grpcClient.DeleteBucketAsync, grpcClient.DeleteBucket, effectiveSettings.DeleteBucketSettings).WithGoogleRequestParam("bucket", request => request.Name);
            Modify_ApiCall(ref _callDeleteBucket);
            Modify_DeleteBucketApiCall(ref _callDeleteBucket);
            _callGetBucket = clientHelper.BuildApiCall<GetBucketRequest, Bucket>("GetBucket", grpcClient.GetBucketAsync, grpcClient.GetBucket, effectiveSettings.GetBucketSettings).WithGoogleRequestParam("bucket", request => request.Name);
            Modify_ApiCall(ref _callGetBucket);
            Modify_GetBucketApiCall(ref _callGetBucket);
            _callCreateBucket = clientHelper.BuildApiCall<CreateBucketRequest, Bucket>("CreateBucket", grpcClient.CreateBucketAsync, grpcClient.CreateBucket, effectiveSettings.CreateBucketSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<CreateBucketRequest>().WithExtractedParameter("project", "^(.+)$", request => request.Parent).WithExtractedParameter("project", "^(.+)$", request => request.Bucket?.Project));
            Modify_ApiCall(ref _callCreateBucket);
            Modify_CreateBucketApiCall(ref _callCreateBucket);
            _callListBuckets = clientHelper.BuildApiCall<ListBucketsRequest, ListBucketsResponse>("ListBuckets", grpcClient.ListBucketsAsync, grpcClient.ListBuckets, effectiveSettings.ListBucketsSettings).WithGoogleRequestParam("project", request => request.Parent);
            Modify_ApiCall(ref _callListBuckets);
            Modify_ListBucketsApiCall(ref _callListBuckets);
            _callLockBucketRetentionPolicy = clientHelper.BuildApiCall<LockBucketRetentionPolicyRequest, Bucket>("LockBucketRetentionPolicy", grpcClient.LockBucketRetentionPolicyAsync, grpcClient.LockBucketRetentionPolicy, effectiveSettings.LockBucketRetentionPolicySettings).WithGoogleRequestParam("bucket", request => request.Bucket);
            Modify_ApiCall(ref _callLockBucketRetentionPolicy);
            Modify_LockBucketRetentionPolicyApiCall(ref _callLockBucketRetentionPolicy);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<gciv::GetIamPolicyRequest>().WithExtractedParameter("bucket", "^(.+)$", request => request.Resource).WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Resource));
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<gciv::SetIamPolicyRequest>().WithExtractedParameter("bucket", "^(.+)$", request => request.Resource).WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Resource));
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<gciv::TestIamPermissionsRequest>().WithExtractedParameter("bucket", "^(.+)$", request => request.Resource).WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)/objects(?:/.*)?$", request => request.Resource).WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)/managedFolders(?:/.*)?$", request => request.Resource));
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            _callUpdateBucket = clientHelper.BuildApiCall<UpdateBucketRequest, Bucket>("UpdateBucket", grpcClient.UpdateBucketAsync, grpcClient.UpdateBucket, effectiveSettings.UpdateBucketSettings).WithGoogleRequestParam("bucket", request => request.Bucket?.Name);
            Modify_ApiCall(ref _callUpdateBucket);
            Modify_UpdateBucketApiCall(ref _callUpdateBucket);
            _callComposeObject = clientHelper.BuildApiCall<ComposeObjectRequest, Object>("ComposeObject", grpcClient.ComposeObjectAsync, grpcClient.ComposeObject, effectiveSettings.ComposeObjectSettings).WithGoogleRequestParam("bucket", request => request.Destination?.Bucket);
            Modify_ApiCall(ref _callComposeObject);
            Modify_ComposeObjectApiCall(ref _callComposeObject);
            _callDeleteObject = clientHelper.BuildApiCall<DeleteObjectRequest, wkt::Empty>("DeleteObject", grpcClient.DeleteObjectAsync, grpcClient.DeleteObject, effectiveSettings.DeleteObjectSettings).WithGoogleRequestParam("bucket", request => request.Bucket);
            Modify_ApiCall(ref _callDeleteObject);
            Modify_DeleteObjectApiCall(ref _callDeleteObject);
            _callRestoreObject = clientHelper.BuildApiCall<RestoreObjectRequest, Object>("RestoreObject", grpcClient.RestoreObjectAsync, grpcClient.RestoreObject, effectiveSettings.RestoreObjectSettings).WithGoogleRequestParam("bucket", request => request.Bucket);
            Modify_ApiCall(ref _callRestoreObject);
            Modify_RestoreObjectApiCall(ref _callRestoreObject);
            _callCancelResumableWrite = clientHelper.BuildApiCall<CancelResumableWriteRequest, CancelResumableWriteResponse>("CancelResumableWrite", grpcClient.CancelResumableWriteAsync, grpcClient.CancelResumableWrite, effectiveSettings.CancelResumableWriteSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<CancelResumableWriteRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.UploadId));
            Modify_ApiCall(ref _callCancelResumableWrite);
            Modify_CancelResumableWriteApiCall(ref _callCancelResumableWrite);
            _callGetObject = clientHelper.BuildApiCall<GetObjectRequest, Object>("GetObject", grpcClient.GetObjectAsync, grpcClient.GetObject, effectiveSettings.GetObjectSettings).WithGoogleRequestParam("bucket", request => request.Bucket);
            Modify_ApiCall(ref _callGetObject);
            Modify_GetObjectApiCall(ref _callGetObject);
            _callReadObject = clientHelper.BuildApiCall<ReadObjectRequest, ReadObjectResponse>("ReadObject", grpcClient.ReadObject, effectiveSettings.ReadObjectSettings).WithGoogleRequestParam("bucket", request => request.Bucket);
            Modify_ApiCall(ref _callReadObject);
            Modify_ReadObjectApiCall(ref _callReadObject);
            _callBidiReadObject = clientHelper.BuildApiCall<BidiReadObjectRequest, BidiReadObjectResponse>("BidiReadObject", grpcClient.BidiReadObject, effectiveSettings.BidiReadObjectSettings, effectiveSettings.BidiReadObjectStreamingSettings);
            Modify_ApiCall(ref _callBidiReadObject);
            Modify_BidiReadObjectApiCall(ref _callBidiReadObject);
            _callUpdateObject = clientHelper.BuildApiCall<UpdateObjectRequest, Object>("UpdateObject", grpcClient.UpdateObjectAsync, grpcClient.UpdateObject, effectiveSettings.UpdateObjectSettings).WithGoogleRequestParam("bucket", request => request.Object?.Bucket);
            Modify_ApiCall(ref _callUpdateObject);
            Modify_UpdateObjectApiCall(ref _callUpdateObject);
            _callWriteObject = clientHelper.BuildApiCall<WriteObjectRequest, WriteObjectResponse>("WriteObject", grpcClient.WriteObject, effectiveSettings.WriteObjectSettings, effectiveSettings.WriteObjectStreamingSettings);
            Modify_ApiCall(ref _callWriteObject);
            Modify_WriteObjectApiCall(ref _callWriteObject);
            _callBidiWriteObject = clientHelper.BuildApiCall<BidiWriteObjectRequest, BidiWriteObjectResponse>("BidiWriteObject", grpcClient.BidiWriteObject, effectiveSettings.BidiWriteObjectSettings, effectiveSettings.BidiWriteObjectStreamingSettings);
            Modify_ApiCall(ref _callBidiWriteObject);
            Modify_BidiWriteObjectApiCall(ref _callBidiWriteObject);
            _callListObjects = clientHelper.BuildApiCall<ListObjectsRequest, ListObjectsResponse>("ListObjects", grpcClient.ListObjectsAsync, grpcClient.ListObjects, effectiveSettings.ListObjectsSettings).WithGoogleRequestParam("bucket", request => request.Parent);
            Modify_ApiCall(ref _callListObjects);
            Modify_ListObjectsApiCall(ref _callListObjects);
            _callRewriteObject = clientHelper.BuildApiCall<RewriteObjectRequest, RewriteResponse>("RewriteObject", grpcClient.RewriteObjectAsync, grpcClient.RewriteObject, effectiveSettings.RewriteObjectSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<RewriteObjectRequest>().WithExtractedParameter("source_bucket", "^(.+)$", request => request.SourceBucket).WithExtractedParameter("bucket", "^(.+)$", request => request.DestinationBucket));
            Modify_ApiCall(ref _callRewriteObject);
            Modify_RewriteObjectApiCall(ref _callRewriteObject);
            _callStartResumableWrite = clientHelper.BuildApiCall<StartResumableWriteRequest, StartResumableWriteResponse>("StartResumableWrite", grpcClient.StartResumableWriteAsync, grpcClient.StartResumableWrite, effectiveSettings.StartResumableWriteSettings).WithGoogleRequestParam("bucket", request => request.WriteObjectSpec?.Resource?.Bucket);
            Modify_ApiCall(ref _callStartResumableWrite);
            Modify_StartResumableWriteApiCall(ref _callStartResumableWrite);
            _callQueryWriteStatus = clientHelper.BuildApiCall<QueryWriteStatusRequest, QueryWriteStatusResponse>("QueryWriteStatus", grpcClient.QueryWriteStatusAsync, grpcClient.QueryWriteStatus, effectiveSettings.QueryWriteStatusSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<QueryWriteStatusRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.UploadId));
            Modify_ApiCall(ref _callQueryWriteStatus);
            Modify_QueryWriteStatusApiCall(ref _callQueryWriteStatus);
            _callMoveObject = clientHelper.BuildApiCall<MoveObjectRequest, Object>("MoveObject", grpcClient.MoveObjectAsync, grpcClient.MoveObject, effectiveSettings.MoveObjectSettings).WithGoogleRequestParam("bucket", request => request.Bucket);
            Modify_ApiCall(ref _callMoveObject);
            Modify_MoveObjectApiCall(ref _callMoveObject);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiClientStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteBucketApiCall(ref gaxgrpc::ApiCall<DeleteBucketRequest, wkt::Empty> call);

        partial void Modify_GetBucketApiCall(ref gaxgrpc::ApiCall<GetBucketRequest, Bucket> call);

        partial void Modify_CreateBucketApiCall(ref gaxgrpc::ApiCall<CreateBucketRequest, Bucket> call);

        partial void Modify_ListBucketsApiCall(ref gaxgrpc::ApiCall<ListBucketsRequest, ListBucketsResponse> call);

        partial void Modify_LockBucketRetentionPolicyApiCall(ref gaxgrpc::ApiCall<LockBucketRetentionPolicyRequest, Bucket> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void Modify_UpdateBucketApiCall(ref gaxgrpc::ApiCall<UpdateBucketRequest, Bucket> call);

        partial void Modify_ComposeObjectApiCall(ref gaxgrpc::ApiCall<ComposeObjectRequest, Object> call);

        partial void Modify_DeleteObjectApiCall(ref gaxgrpc::ApiCall<DeleteObjectRequest, wkt::Empty> call);

        partial void Modify_RestoreObjectApiCall(ref gaxgrpc::ApiCall<RestoreObjectRequest, Object> call);

        partial void Modify_CancelResumableWriteApiCall(ref gaxgrpc::ApiCall<CancelResumableWriteRequest, CancelResumableWriteResponse> call);

        partial void Modify_GetObjectApiCall(ref gaxgrpc::ApiCall<GetObjectRequest, Object> call);

        partial void Modify_ReadObjectApiCall(ref gaxgrpc::ApiServerStreamingCall<ReadObjectRequest, ReadObjectResponse> call);

        partial void Modify_BidiReadObjectApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<BidiReadObjectRequest, BidiReadObjectResponse> call);

        partial void Modify_UpdateObjectApiCall(ref gaxgrpc::ApiCall<UpdateObjectRequest, Object> call);

        partial void Modify_WriteObjectApiCall(ref gaxgrpc::ApiClientStreamingCall<WriteObjectRequest, WriteObjectResponse> call);

        partial void Modify_BidiWriteObjectApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<BidiWriteObjectRequest, BidiWriteObjectResponse> call);

        partial void Modify_ListObjectsApiCall(ref gaxgrpc::ApiCall<ListObjectsRequest, ListObjectsResponse> call);

        partial void Modify_RewriteObjectApiCall(ref gaxgrpc::ApiCall<RewriteObjectRequest, RewriteResponse> call);

        partial void Modify_StartResumableWriteApiCall(ref gaxgrpc::ApiCall<StartResumableWriteRequest, StartResumableWriteResponse> call);

        partial void Modify_QueryWriteStatusApiCall(ref gaxgrpc::ApiCall<QueryWriteStatusRequest, QueryWriteStatusResponse> call);

        partial void Modify_MoveObjectApiCall(ref gaxgrpc::ApiCall<MoveObjectRequest, Object> call);

        partial void OnConstruction(Storage.StorageClient grpcClient, StorageSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Storage client</summary>
        public override Storage.StorageClient GrpcClient { get; }

        partial void Modify_DeleteBucketRequest(ref DeleteBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBucketRequest(ref GetBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBucketRequest(ref CreateBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBucketsRequest(ref ListBucketsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LockBucketRetentionPolicyRequest(ref LockBucketRetentionPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBucketRequest(ref UpdateBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ComposeObjectRequest(ref ComposeObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteObjectRequest(ref DeleteObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestoreObjectRequest(ref RestoreObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelResumableWriteRequest(ref CancelResumableWriteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetObjectRequest(ref GetObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReadObjectRequest(ref ReadObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BidiReadObjectRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_BidiReadObjectRequestRequest(ref BidiReadObjectRequest request);

        partial void Modify_UpdateObjectRequest(ref UpdateObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_WriteObjectRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_WriteObjectRequestRequest(ref WriteObjectRequest request);

        partial void Modify_BidiWriteObjectRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_BidiWriteObjectRequestRequest(ref BidiWriteObjectRequest request);

        partial void Modify_ListObjectsRequest(ref ListObjectsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RewriteObjectRequest(ref RewriteObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartResumableWriteRequest(ref StartResumableWriteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryWriteStatusRequest(ref QueryWriteStatusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MoveObjectRequest(ref MoveObjectRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteBucket(DeleteBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBucketRequest(ref request, ref callSettings);
            _callDeleteBucket.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteBucketAsync(DeleteBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBucketRequest(ref request, ref callSettings);
            return _callDeleteBucket.Async(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Bucket GetBucket(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBucketRequest(ref request, ref callSettings);
            return _callGetBucket.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Bucket> GetBucketAsync(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBucketRequest(ref request, ref callSettings);
            return _callGetBucket.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Bucket CreateBucket(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBucketRequest(ref request, ref callSettings);
            return _callCreateBucket.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Bucket> CreateBucketAsync(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBucketRequest(ref request, ref callSettings);
            return _callCreateBucket.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of buckets for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Bucket"/> resources.</returns>
        public override gax::PagedEnumerable<ListBucketsResponse, Bucket> ListBuckets(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBucketsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBucketsRequest, ListBucketsResponse, Bucket>(_callListBuckets, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of buckets for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Bucket"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBucketsResponse, Bucket> ListBucketsAsync(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBucketsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBucketsRequest, ListBucketsResponse, Bucket>(_callListBuckets, request, callSettings);
        }

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Bucket LockBucketRetentionPolicy(LockBucketRetentionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LockBucketRetentionPolicyRequest(ref request, ref callSettings);
            return _callLockBucketRetentionPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Bucket> LockBucketRetentionPolicyAsync(LockBucketRetentionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LockBucketRetentionPolicyRequest(ref request, ref callSettings);
            return _callLockBucketRetentionPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the IAM policy for a specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the IAM policy for a specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an IAM policy for the specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an IAM policy for the specified bucket.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Tests a set of permissions on the given bucket, object, or managed folder
        /// to see which, if any, are held by the caller.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket,
        /// `projects/_/buckets/{bucket}/objects/{object}` for an object, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Tests a set of permissions on the given bucket, object, or managed folder
        /// to see which, if any, are held by the caller.
        /// The `resource` field in the request should be
        /// `projects/_/buckets/{bucket}` for a bucket,
        /// `projects/_/buckets/{bucket}/objects/{object}` for an object, or
        /// `projects/_/buckets/{bucket}/managedFolders/{managedFolder}`
        /// for a managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a bucket. Equivalent to JSON API's storage.buckets.patch method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Bucket UpdateBucket(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBucketRequest(ref request, ref callSettings);
            return _callUpdateBucket.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a bucket. Equivalent to JSON API's storage.buckets.patch method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Bucket> UpdateBucketAsync(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBucketRequest(ref request, ref callSettings);
            return _callUpdateBucket.Async(request, callSettings);
        }

        /// <summary>
        /// Concatenates a list of existing objects into a new object in the same
        /// bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Object ComposeObject(ComposeObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComposeObjectRequest(ref request, ref callSettings);
            return _callComposeObject.Sync(request, callSettings);
        }

        /// <summary>
        /// Concatenates a list of existing objects into a new object in the same
        /// bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Object> ComposeObjectAsync(ComposeObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComposeObjectRequest(ref request, ref callSettings);
            return _callComposeObject.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning
        /// is not enabled for the bucket, or if the generation parameter is used, or
        /// if [soft delete](https://cloud.google.com/storage/docs/soft-delete) is not
        /// enabled for the bucket.
        /// When this API is used to delete an object from a bucket that has soft
        /// delete policy enabled, the object becomes soft deleted, and the
        /// `softDeleteTime` and `hardDeleteTime` properties are set on the object.
        /// This API cannot be used to permanently delete soft-deleted objects.
        /// Soft-deleted objects are permanently deleted according to their
        /// `hardDeleteTime`.
        /// 
        /// You can use the [`RestoreObject`][google.storage.v2.Storage.RestoreObject]
        /// API to restore soft-deleted objects until the soft delete retention period
        /// has passed.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.delete`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteObject(DeleteObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteObjectRequest(ref request, ref callSettings);
            _callDeleteObject.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning
        /// is not enabled for the bucket, or if the generation parameter is used, or
        /// if [soft delete](https://cloud.google.com/storage/docs/soft-delete) is not
        /// enabled for the bucket.
        /// When this API is used to delete an object from a bucket that has soft
        /// delete policy enabled, the object becomes soft deleted, and the
        /// `softDeleteTime` and `hardDeleteTime` properties are set on the object.
        /// This API cannot be used to permanently delete soft-deleted objects.
        /// Soft-deleted objects are permanently deleted according to their
        /// `hardDeleteTime`.
        /// 
        /// You can use the [`RestoreObject`][google.storage.v2.Storage.RestoreObject]
        /// API to restore soft-deleted objects until the soft delete retention period
        /// has passed.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.delete`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteObjectAsync(DeleteObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteObjectRequest(ref request, ref callSettings);
            return _callDeleteObject.Async(request, callSettings);
        }

        /// <summary>
        /// Restores a soft-deleted object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Object RestoreObject(RestoreObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreObjectRequest(ref request, ref callSettings);
            return _callRestoreObject.Sync(request, callSettings);
        }

        /// <summary>
        /// Restores a soft-deleted object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Object> RestoreObjectAsync(RestoreObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreObjectRequest(ref request, ref callSettings);
            return _callRestoreObject.Async(request, callSettings);
        }

        /// <summary>
        /// Cancels an in-progress resumable upload.
        /// 
        /// Any attempts to write to the resumable upload after cancelling the upload
        /// will fail.
        /// 
        /// The behavior for currently in progress write operations is not guaranteed -
        /// they could either complete before the cancellation or fail if the
        /// cancellation completes first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CancelResumableWriteResponse CancelResumableWrite(CancelResumableWriteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelResumableWriteRequest(ref request, ref callSettings);
            return _callCancelResumableWrite.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels an in-progress resumable upload.
        /// 
        /// Any attempts to write to the resumable upload after cancelling the upload
        /// will fail.
        /// 
        /// The behavior for currently in progress write operations is not guaranteed -
        /// they could either complete before the cancellation or fail if the
        /// cancellation completes first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CancelResumableWriteResponse> CancelResumableWriteAsync(CancelResumableWriteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelResumableWriteRequest(ref request, ref callSettings);
            return _callCancelResumableWrite.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves object metadata.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket. To return object ACLs, the authenticated user must also have
        /// the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Object GetObject(GetObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetObjectRequest(ref request, ref callSettings);
            return _callGetObject.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves object metadata.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket. To return object ACLs, the authenticated user must also have
        /// the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Object> GetObjectAsync(GetObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetObjectRequest(ref request, ref callSettings);
            return _callGetObject.Async(request, callSettings);
        }

        internal sealed partial class ReadObjectStreamImpl : ReadObjectStream
        {
            /// <summary>Construct the server streaming method for <c>ReadObject</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public ReadObjectStreamImpl(grpccore::AsyncServerStreamingCall<ReadObjectResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<ReadObjectResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Retrieves object data.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override StorageClient.ReadObjectStream ReadObject(ReadObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadObjectRequest(ref request, ref callSettings);
            return new ReadObjectStreamImpl(_callReadObject.Call(request, callSettings));
        }

        internal sealed partial class BidiReadObjectStreamImpl : BidiReadObjectStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>BidiReadObject</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{BidiReadObjectRequest}"/> instance associated with
            /// this streaming call.
            /// </param>
            public BidiReadObjectStreamImpl(StorageClientImpl service, grpccore::AsyncDuplexStreamingCall<BidiReadObjectRequest, BidiReadObjectResponse> call, gaxgrpc::BufferedClientStreamWriter<BidiReadObjectRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private StorageClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<BidiReadObjectRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<BidiReadObjectRequest, BidiReadObjectResponse> GrpcCall { get; }

            private BidiReadObjectRequest ModifyRequest(BidiReadObjectRequest request)
            {
                _service.Modify_BidiReadObjectRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(BidiReadObjectRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(BidiReadObjectRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(BidiReadObjectRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(BidiReadObjectRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Reads an object's data.
        /// 
        /// This is a bi-directional API with the added support for reading multiple
        /// ranges within one stream both within and across multiple messages.
        /// If the server encountered an error for any of the inputs, the stream will
        /// be closed with the relevant error code.
        /// Because the API allows for multiple outstanding requests, when the stream
        /// is closed the error response will contain a BidiReadObjectRangesError proto
        /// in the error extension describing the error for each outstanding read_id.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.get`
        /// 
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// 
        /// This API is currently in preview and is not yet available for general
        /// use.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override StorageClient.BidiReadObjectStream BidiReadObject(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_BidiReadObjectRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callBidiReadObject.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<BidiReadObjectRequest, BidiReadObjectResponse> call = _callBidiReadObject.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<BidiReadObjectRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<BidiReadObjectRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new BidiReadObjectStreamImpl(this, call, writeBuffer);
        }

        /// <summary>
        /// Updates an object's metadata.
        /// Equivalent to JSON API's storage.objects.patch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Object UpdateObject(UpdateObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateObjectRequest(ref request, ref callSettings);
            return _callUpdateObject.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an object's metadata.
        /// Equivalent to JSON API's storage.objects.patch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Object> UpdateObjectAsync(UpdateObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateObjectRequest(ref request, ref callSettings);
            return _callUpdateObject.Async(request, callSettings);
        }

        internal sealed partial class WriteObjectStreamImpl : WriteObjectStream
        {
            /// <summary>Construct the client streaming method for <c>WriteObject</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC client streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{WriteObjectRequest}"/> instance associated with this
            /// streaming call.
            /// </param>
            public WriteObjectStreamImpl(StorageClientImpl service, grpccore::AsyncClientStreamingCall<WriteObjectRequest, WriteObjectResponse> call, gaxgrpc::BufferedClientStreamWriter<WriteObjectRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private StorageClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<WriteObjectRequest> _writeBuffer;

            public override grpccore::AsyncClientStreamingCall<WriteObjectRequest, WriteObjectResponse> GrpcCall { get; }

            private WriteObjectRequest ModifyRequest(WriteObjectRequest request)
            {
                _service.Modify_WriteObjectRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(WriteObjectRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(WriteObjectRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(WriteObjectRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(WriteObjectRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Stores a new object and metadata.
        /// 
        /// An object can be written either in a single message stream or in a
        /// resumable sequence of message streams. To write using a single stream,
        /// the client should include in the first message of the stream an
        /// `WriteObjectSpec` describing the destination bucket, object, and any
        /// preconditions. Additionally, the final message must set 'finish_write' to
        /// true, or else it is an error.
        /// 
        /// For a resumable write, the client should instead call
        /// `StartResumableWrite()`, populating a `WriteObjectSpec` into that request.
        /// They should then attach the returned `upload_id` to the first message of
        /// each following call to `WriteObject`. If the stream is closed before
        /// finishing the upload (either explicitly by the client or due to a network
        /// error or an error response from the server), the client should do as
        /// follows:
        /// - Check the result Status of the stream, to determine if writing can be
        /// resumed on this stream or must be restarted from scratch (by calling
        /// `StartResumableWrite()`). The resumable errors are DEADLINE_EXCEEDED,
        /// INTERNAL, and UNAVAILABLE. For each case, the client should use binary
        /// exponential backoff before retrying.  Additionally, writes can be
        /// resumed after RESOURCE_EXHAUSTED errors, but only after taking
        /// appropriate measures, which may include reducing aggregate send rate
        /// across clients and/or requesting a quota increase for your project.
        /// - If the call to `WriteObject` returns `ABORTED`, that indicates
        /// concurrent attempts to update the resumable write, caused either by
        /// multiple racing clients or by a single client where the previous
        /// request was timed out on the client side but nonetheless reached the
        /// server. In this case the client should take steps to prevent further
        /// concurrent writes (e.g., increase the timeouts, stop using more than
        /// one process to perform the upload, etc.), and then should follow the
        /// steps below for resuming the upload.
        /// - For resumable errors, the client should call `QueryWriteStatus()` and
        /// then continue writing from the returned `persisted_size`. This may be
        /// less than the amount of data the client previously sent. Note also that
        /// it is acceptable to send data starting at an offset earlier than the
        /// returned `persisted_size`; in this case, the service will skip data at
        /// offsets that were already persisted (without checking that it matches
        /// the previously written data), and write only the data starting from the
        /// persisted offset. Even though the data isn't written, it may still
        /// incur a performance cost over resuming at the correct write offset.
        /// This behavior can make client-side handling simpler in some cases.
        /// - Clients must only send data that is a multiple of 256 KiB per message,
        /// unless the object is being finished with `finish_write` set to `true`.
        /// 
        /// The service will not view the object as complete until the client has
        /// sent a `WriteObjectRequest` with `finish_write` set to `true`. Sending any
        /// requests on a stream after sending a request with `finish_write` set to
        /// `true` will cause an error. The client **should** check the response it
        /// receives to determine how much data the service was able to commit and
        /// whether the service views the object as complete.
        /// 
        /// Attempting to resume an already finalized object will result in an OK
        /// status, with a `WriteObjectResponse` containing the finalized object's
        /// metadata.
        /// 
        /// Alternatively, the BidiWriteObject operation may be used to write an
        /// object with controls over flushing and the ability to fetch the ability to
        /// determine the current persisted size.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.create`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client stream.</returns>
        public override StorageClient.WriteObjectStream WriteObject(gaxgrpc::CallSettings callSettings = null, gaxgrpc::ClientStreamingSettings streamingSettings = null)
        {
            Modify_WriteObjectRequestCallSettings(ref callSettings);
            gaxgrpc::ClientStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callWriteObject.StreamingSettings;
            grpccore::AsyncClientStreamingCall<WriteObjectRequest, WriteObjectResponse> call = _callWriteObject.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<WriteObjectRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<WriteObjectRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new WriteObjectStreamImpl(this, call, writeBuffer);
        }

        internal sealed partial class BidiWriteObjectStreamImpl : BidiWriteObjectStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>BidiWriteObject</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{BidiWriteObjectRequest}"/> instance associated with
            /// this streaming call.
            /// </param>
            public BidiWriteObjectStreamImpl(StorageClientImpl service, grpccore::AsyncDuplexStreamingCall<BidiWriteObjectRequest, BidiWriteObjectResponse> call, gaxgrpc::BufferedClientStreamWriter<BidiWriteObjectRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private StorageClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<BidiWriteObjectRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<BidiWriteObjectRequest, BidiWriteObjectResponse> GrpcCall { get; }

            private BidiWriteObjectRequest ModifyRequest(BidiWriteObjectRequest request)
            {
                _service.Modify_BidiWriteObjectRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(BidiWriteObjectRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(BidiWriteObjectRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(BidiWriteObjectRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(BidiWriteObjectRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Stores a new object and metadata.
        /// 
        /// This is similar to the WriteObject call with the added support for
        /// manual flushing of persisted state, and the ability to determine current
        /// persisted size without closing the stream.
        /// 
        /// The client may specify one or both of the `state_lookup` and `flush` fields
        /// in each BidiWriteObjectRequest. If `flush` is specified, the data written
        /// so far will be persisted to storage. If `state_lookup` is specified, the
        /// service will respond with a BidiWriteObjectResponse that contains the
        /// persisted size. If both `flush` and `state_lookup` are specified, the flush
        /// will always occur before a `state_lookup`, so that both may be set in the
        /// same request and the returned state will be the state of the object
        /// post-flush. When the stream is closed, a BidiWriteObjectResponse will
        /// always be sent to the client, regardless of the value of `state_lookup`.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override StorageClient.BidiWriteObjectStream BidiWriteObject(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_BidiWriteObjectRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callBidiWriteObject.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<BidiWriteObjectRequest, BidiWriteObjectResponse> call = _callBidiWriteObject.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<BidiWriteObjectRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<BidiWriteObjectRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new BidiWriteObjectStreamImpl(this, call, writeBuffer);
        }

        /// <summary>
        /// Retrieves a list of objects matching the criteria.
        /// 
        /// **IAM Permissions**:
        /// 
        /// The authenticated user requires `storage.objects.list`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions)
        /// to use this method. To return object ACLs, the authenticated user must also
        /// have the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Object"/> resources.</returns>
        public override gax::PagedEnumerable<ListObjectsResponse, Object> ListObjects(ListObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListObjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListObjectsRequest, ListObjectsResponse, Object>(_callListObjects, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of objects matching the criteria.
        /// 
        /// **IAM Permissions**:
        /// 
        /// The authenticated user requires `storage.objects.list`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions)
        /// to use this method. To return object ACLs, the authenticated user must also
        /// have the `storage.objects.getIamPolicy` permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Object"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListObjectsResponse, Object> ListObjectsAsync(ListObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListObjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListObjectsRequest, ListObjectsResponse, Object>(_callListObjects, request, callSettings);
        }

        /// <summary>
        /// Rewrites a source object to a destination object. Optionally overrides
        /// metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RewriteResponse RewriteObject(RewriteObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RewriteObjectRequest(ref request, ref callSettings);
            return _callRewriteObject.Sync(request, callSettings);
        }

        /// <summary>
        /// Rewrites a source object to a destination object. Optionally overrides
        /// metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RewriteResponse> RewriteObjectAsync(RewriteObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RewriteObjectRequest(ref request, ref callSettings);
            return _callRewriteObject.Async(request, callSettings);
        }

        /// <summary>
        /// Starts a resumable write operation. This
        /// method is part of the [Resumable
        /// upload](https://cloud.google.com/storage/docs/resumable-uploads) feature.
        /// This allows you to upload large objects in multiple chunks, which is more
        /// resilient to network interruptions than a single upload. The validity
        /// duration of the write operation, and the consequences of it becoming
        /// invalid, are service-dependent.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.create`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StartResumableWriteResponse StartResumableWrite(StartResumableWriteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartResumableWriteRequest(ref request, ref callSettings);
            return _callStartResumableWrite.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts a resumable write operation. This
        /// method is part of the [Resumable
        /// upload](https://cloud.google.com/storage/docs/resumable-uploads) feature.
        /// This allows you to upload large objects in multiple chunks, which is more
        /// resilient to network interruptions than a single upload. The validity
        /// duration of the write operation, and the consequences of it becoming
        /// invalid, are service-dependent.
        /// 
        /// **IAM Permissions**:
        /// 
        /// Requires `storage.objects.create`
        /// [IAM permission](https://cloud.google.com/iam/docs/overview#permissions) on
        /// the bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StartResumableWriteResponse> StartResumableWriteAsync(StartResumableWriteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartResumableWriteRequest(ref request, ref callSettings);
            return _callStartResumableWrite.Async(request, callSettings);
        }

        /// <summary>
        /// Determines the `persisted_size` of an object that is being written. This
        /// method is part of the [resumable
        /// upload](https://cloud.google.com/storage/docs/resumable-uploads) feature.
        /// The returned value is the size of the object that has been persisted so
        /// far. The value can be used as the `write_offset` for the next `Write()`
        /// call.
        /// 
        /// If the object does not exist, meaning if it was deleted, or the
        /// first `Write()` has not yet reached the service, this method returns the
        /// error `NOT_FOUND`.
        /// 
        /// This method is useful for clients that buffer data and need to know which
        /// data can be safely evicted. The client can call `QueryWriteStatus()` at any
        /// time to determine how much data has been logged for this object.
        /// For any sequence of `QueryWriteStatus()` calls for a given
        /// object name, the sequence of returned `persisted_size` values are
        /// non-decreasing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QueryWriteStatusResponse QueryWriteStatus(QueryWriteStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryWriteStatusRequest(ref request, ref callSettings);
            return _callQueryWriteStatus.Sync(request, callSettings);
        }

        /// <summary>
        /// Determines the `persisted_size` of an object that is being written. This
        /// method is part of the [resumable
        /// upload](https://cloud.google.com/storage/docs/resumable-uploads) feature.
        /// The returned value is the size of the object that has been persisted so
        /// far. The value can be used as the `write_offset` for the next `Write()`
        /// call.
        /// 
        /// If the object does not exist, meaning if it was deleted, or the
        /// first `Write()` has not yet reached the service, this method returns the
        /// error `NOT_FOUND`.
        /// 
        /// This method is useful for clients that buffer data and need to know which
        /// data can be safely evicted. The client can call `QueryWriteStatus()` at any
        /// time to determine how much data has been logged for this object.
        /// For any sequence of `QueryWriteStatus()` calls for a given
        /// object name, the sequence of returned `persisted_size` values are
        /// non-decreasing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QueryWriteStatusResponse> QueryWriteStatusAsync(QueryWriteStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryWriteStatusRequest(ref request, ref callSettings);
            return _callQueryWriteStatus.Async(request, callSettings);
        }

        /// <summary>
        /// Moves the source object to the destination object in the same bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Object MoveObject(MoveObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveObjectRequest(ref request, ref callSettings);
            return _callMoveObject.Sync(request, callSettings);
        }

        /// <summary>
        /// Moves the source object to the destination object in the same bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Object> MoveObjectAsync(MoveObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveObjectRequest(ref request, ref callSettings);
            return _callMoveObject.Async(request, callSettings);
        }
    }

    public partial class ListBucketsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListObjectsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBucketsResponse : gaxgrpc::IPageResponse<Bucket>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Bucket> GetEnumerator() => Buckets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListObjectsResponse : gaxgrpc::IPageResponse<Object>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Object> GetEnumerator() => Objects.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
