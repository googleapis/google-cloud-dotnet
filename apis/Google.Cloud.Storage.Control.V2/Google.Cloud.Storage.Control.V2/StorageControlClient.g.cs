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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Storage.Control.V2
{
    /// <summary>Settings for <see cref="StorageControlClient"/> instances.</summary>
    public sealed partial class StorageControlSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="StorageControlSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="StorageControlSettings"/>.</returns>
        public static StorageControlSettings GetDefault() => new StorageControlSettings();

        /// <summary>Constructs a new <see cref="StorageControlSettings"/> object with default settings.</summary>
        public StorageControlSettings()
        {
        }

        private StorageControlSettings(StorageControlSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateFolderSettings = existing.CreateFolderSettings;
            DeleteFolderSettings = existing.DeleteFolderSettings;
            GetFolderSettings = existing.GetFolderSettings;
            ListFoldersSettings = existing.ListFoldersSettings;
            RenameFolderSettings = existing.RenameFolderSettings;
            RenameFolderOperationsSettings = existing.RenameFolderOperationsSettings.Clone();
            GetStorageLayoutSettings = existing.GetStorageLayoutSettings;
            CreateManagedFolderSettings = existing.CreateManagedFolderSettings;
            DeleteManagedFolderSettings = existing.DeleteManagedFolderSettings;
            GetManagedFolderSettings = existing.GetManagedFolderSettings;
            ListManagedFoldersSettings = existing.ListManagedFoldersSettings;
            CreateAnywhereCacheSettings = existing.CreateAnywhereCacheSettings;
            CreateAnywhereCacheOperationsSettings = existing.CreateAnywhereCacheOperationsSettings.Clone();
            UpdateAnywhereCacheSettings = existing.UpdateAnywhereCacheSettings;
            UpdateAnywhereCacheOperationsSettings = existing.UpdateAnywhereCacheOperationsSettings.Clone();
            DisableAnywhereCacheSettings = existing.DisableAnywhereCacheSettings;
            PauseAnywhereCacheSettings = existing.PauseAnywhereCacheSettings;
            ResumeAnywhereCacheSettings = existing.ResumeAnywhereCacheSettings;
            GetAnywhereCacheSettings = existing.GetAnywhereCacheSettings;
            ListAnywhereCachesSettings = existing.ListAnywhereCachesSettings;
            GetProjectIntelligenceConfigSettings = existing.GetProjectIntelligenceConfigSettings;
            UpdateProjectIntelligenceConfigSettings = existing.UpdateProjectIntelligenceConfigSettings;
            GetFolderIntelligenceConfigSettings = existing.GetFolderIntelligenceConfigSettings;
            UpdateFolderIntelligenceConfigSettings = existing.UpdateFolderIntelligenceConfigSettings;
            GetOrganizationIntelligenceConfigSettings = existing.GetOrganizationIntelligenceConfigSettings;
            UpdateOrganizationIntelligenceConfigSettings = existing.UpdateOrganizationIntelligenceConfigSettings;
            OnCopy(existing);
        }

        partial void OnCopy(StorageControlSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.CreateFolder</c> and <c>StorageControlClient.CreateFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFolderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.DeleteFolder</c> and <c>StorageControlClient.DeleteFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.GetFolder</c> and <c>StorageControlClient.GetFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFolderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.ListFolders</c> and <c>StorageControlClient.ListFoldersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFoldersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.RenameFolder</c> and <c>StorageControlClient.RenameFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RenameFolderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>StorageControlClient.RenameFolder</c> and
        /// <c>StorageControlClient.RenameFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings RenameFolderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.GetStorageLayout</c> and <c>StorageControlClient.GetStorageLayoutAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetStorageLayoutSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.CreateManagedFolder</c> and <c>StorageControlClient.CreateManagedFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateManagedFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.DeleteManagedFolder</c> and <c>StorageControlClient.DeleteManagedFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteManagedFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.GetManagedFolder</c> and <c>StorageControlClient.GetManagedFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetManagedFolderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.ListManagedFolders</c> and <c>StorageControlClient.ListManagedFoldersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListManagedFoldersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.CreateAnywhereCache</c> and <c>StorageControlClient.CreateAnywhereCacheAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAnywhereCacheSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>StorageControlClient.CreateAnywhereCache</c> and
        /// <c>StorageControlClient.CreateAnywhereCacheAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateAnywhereCacheOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.UpdateAnywhereCache</c> and <c>StorageControlClient.UpdateAnywhereCacheAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAnywhereCacheSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>StorageControlClient.UpdateAnywhereCache</c> and
        /// <c>StorageControlClient.UpdateAnywhereCacheAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateAnywhereCacheOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.DisableAnywhereCache</c> and <c>StorageControlClient.DisableAnywhereCacheAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DisableAnywhereCacheSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.PauseAnywhereCache</c> and <c>StorageControlClient.PauseAnywhereCacheAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PauseAnywhereCacheSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.ResumeAnywhereCache</c> and <c>StorageControlClient.ResumeAnywhereCacheAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResumeAnywhereCacheSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.GetAnywhereCache</c> and <c>StorageControlClient.GetAnywhereCacheAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAnywhereCacheSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.ListAnywhereCaches</c> and <c>StorageControlClient.ListAnywhereCachesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAnywhereCachesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.GetProjectIntelligenceConfig</c> and
        /// <c>StorageControlClient.GetProjectIntelligenceConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProjectIntelligenceConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.UpdateProjectIntelligenceConfig</c> and
        /// <c>StorageControlClient.UpdateProjectIntelligenceConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateProjectIntelligenceConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.GetFolderIntelligenceConfig</c> and
        /// <c>StorageControlClient.GetFolderIntelligenceConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFolderIntelligenceConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.UpdateFolderIntelligenceConfig</c> and
        /// <c>StorageControlClient.UpdateFolderIntelligenceConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFolderIntelligenceConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.GetOrganizationIntelligenceConfig</c> and
        /// <c>StorageControlClient.GetOrganizationIntelligenceConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetOrganizationIntelligenceConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.UpdateOrganizationIntelligenceConfig</c> and
        /// <c>StorageControlClient.UpdateOrganizationIntelligenceConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateOrganizationIntelligenceConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="StorageControlSettings"/> object.</returns>
        public StorageControlSettings Clone() => new StorageControlSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="StorageControlClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class StorageControlClientBuilder : gaxgrpc::ClientBuilderBase<StorageControlClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public StorageControlSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public StorageControlClientBuilder() : base(StorageControlClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref StorageControlClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<StorageControlClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override StorageControlClient Build()
        {
            StorageControlClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<StorageControlClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<StorageControlClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private StorageControlClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return StorageControlClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<StorageControlClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return StorageControlClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => StorageControlClient.ChannelPool;
    }

    /// <summary>StorageControl client wrapper, for convenient use.</summary>
    /// <remarks>
    /// StorageControl service includes selected control plane operations.
    /// </remarks>
    public abstract partial class StorageControlClient
    {
        /// <summary>
        /// The default endpoint for the StorageControl service, which is a host of "storage.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "storage.googleapis.com:443";

        /// <summary>The default StorageControl scopes.</summary>
        /// <remarks>
        /// The default StorageControl scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(StorageControl.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="StorageControlClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="StorageControlClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="StorageControlClient"/>.</returns>
        public static stt::Task<StorageControlClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new StorageControlClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="StorageControlClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="StorageControlClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="StorageControlClient"/>.</returns>
        public static StorageControlClient Create() => new StorageControlClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="StorageControlClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="StorageControlSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="StorageControlClient"/>.</returns>
        internal static StorageControlClient Create(grpccore::CallInvoker callInvoker, StorageControlSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            StorageControl.StorageControlClient grpcClient = new StorageControl.StorageControlClient(callInvoker);
            return new StorageControlClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC StorageControl client</summary>
        public virtual StorageControl.StorageControlClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder CreateFolder(CreateFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> CreateFolderAsync(CreateFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> CreateFolderAsync(CreateFolderRequest request, st::CancellationToken cancellationToken) =>
            CreateFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which the folder will reside. The bucket
        /// must be a hierarchical namespace enabled bucket.
        /// </param>
        /// <param name="folder">
        /// Required. Properties of the new folder being created.
        /// The bucket and name of the folder are specified in the parent and folder_id
        /// fields, respectively. Populating those fields in `folder` will result in an
        /// error.
        /// </param>
        /// <param name="folderId">
        /// Required. The full name of a folder, including all its parent folders.
        /// Folders use single '/' characters as a delimiter.
        /// The folder_id must end with a slash.
        /// For example, the folder_id of "books/biographies/" would create a new
        /// "biographies/" folder under the "books/" folder.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder CreateFolder(string parent, Folder folder, string folderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFolder(new CreateFolderRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Folder = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
                FolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which the folder will reside. The bucket
        /// must be a hierarchical namespace enabled bucket.
        /// </param>
        /// <param name="folder">
        /// Required. Properties of the new folder being created.
        /// The bucket and name of the folder are specified in the parent and folder_id
        /// fields, respectively. Populating those fields in `folder` will result in an
        /// error.
        /// </param>
        /// <param name="folderId">
        /// Required. The full name of a folder, including all its parent folders.
        /// Folders use single '/' characters as a delimiter.
        /// The folder_id must end with a slash.
        /// For example, the folder_id of "books/biographies/" would create a new
        /// "biographies/" folder under the "books/" folder.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> CreateFolderAsync(string parent, Folder folder, string folderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFolderAsync(new CreateFolderRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Folder = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
                FolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which the folder will reside. The bucket
        /// must be a hierarchical namespace enabled bucket.
        /// </param>
        /// <param name="folder">
        /// Required. Properties of the new folder being created.
        /// The bucket and name of the folder are specified in the parent and folder_id
        /// fields, respectively. Populating those fields in `folder` will result in an
        /// error.
        /// </param>
        /// <param name="folderId">
        /// Required. The full name of a folder, including all its parent folders.
        /// Folders use single '/' characters as a delimiter.
        /// The folder_id must end with a slash.
        /// For example, the folder_id of "books/biographies/" would create a new
        /// "biographies/" folder under the "books/" folder.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> CreateFolderAsync(string parent, Folder folder, string folderId, st::CancellationToken cancellationToken) =>
            CreateFolderAsync(parent, folder, folderId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which the folder will reside. The bucket
        /// must be a hierarchical namespace enabled bucket.
        /// </param>
        /// <param name="folder">
        /// Required. Properties of the new folder being created.
        /// The bucket and name of the folder are specified in the parent and folder_id
        /// fields, respectively. Populating those fields in `folder` will result in an
        /// error.
        /// </param>
        /// <param name="folderId">
        /// Required. The full name of a folder, including all its parent folders.
        /// Folders use single '/' characters as a delimiter.
        /// The folder_id must end with a slash.
        /// For example, the folder_id of "books/biographies/" would create a new
        /// "biographies/" folder under the "books/" folder.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder CreateFolder(BucketName parent, Folder folder, string folderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFolder(new CreateFolderRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Folder = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
                FolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which the folder will reside. The bucket
        /// must be a hierarchical namespace enabled bucket.
        /// </param>
        /// <param name="folder">
        /// Required. Properties of the new folder being created.
        /// The bucket and name of the folder are specified in the parent and folder_id
        /// fields, respectively. Populating those fields in `folder` will result in an
        /// error.
        /// </param>
        /// <param name="folderId">
        /// Required. The full name of a folder, including all its parent folders.
        /// Folders use single '/' characters as a delimiter.
        /// The folder_id must end with a slash.
        /// For example, the folder_id of "books/biographies/" would create a new
        /// "biographies/" folder under the "books/" folder.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> CreateFolderAsync(BucketName parent, Folder folder, string folderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFolderAsync(new CreateFolderRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Folder = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
                FolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which the folder will reside. The bucket
        /// must be a hierarchical namespace enabled bucket.
        /// </param>
        /// <param name="folder">
        /// Required. Properties of the new folder being created.
        /// The bucket and name of the folder are specified in the parent and folder_id
        /// fields, respectively. Populating those fields in `folder` will result in an
        /// error.
        /// </param>
        /// <param name="folderId">
        /// Required. The full name of a folder, including all its parent folders.
        /// Folders use single '/' characters as a delimiter.
        /// The folder_id must end with a slash.
        /// For example, the folder_id of "books/biographies/" would create a new
        /// "biographies/" folder under the "books/" folder.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> CreateFolderAsync(BucketName parent, Folder folder, string folderId, st::CancellationToken cancellationToken) =>
            CreateFolderAsync(parent, folder, folderId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFolder(DeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFolderAsync(DeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFolderAsync(DeleteFolderRequest request, st::CancellationToken cancellationToken) =>
            DeleteFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFolder(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFolder(new DeleteFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFolderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFolderAsync(new DeleteFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFolderAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFolder(FolderName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFolder(new DeleteFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFolderAsync(FolderName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFolderAsync(new DeleteFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFolderAsync(FolderName name, st::CancellationToken cancellationToken) =>
            DeleteFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder GetFolder(GetFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(GetFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(GetFolderRequest request, st::CancellationToken cancellationToken) =>
            GetFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder GetFolder(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolder(new GetFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolderAsync(new GetFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(string name, st::CancellationToken cancellationToken) =>
            GetFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder GetFolder(FolderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolder(new GetFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(FolderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolderAsync(new GetFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(FolderName name, st::CancellationToken cancellationToken) =>
            GetFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of folders. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Folder"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFoldersResponse, Folder> ListFolders(ListFoldersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of folders. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Folder"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFoldersResponse, Folder> ListFoldersAsync(ListFoldersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of folders. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which to look for folders. The bucket must
        /// be a hierarchical namespace enabled bucket.
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
        /// <returns>A pageable sequence of <see cref="Folder"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFoldersResponse, Folder> ListFolders(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFoldersRequest request = new ListFoldersRequest
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
            return ListFolders(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of folders. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which to look for folders. The bucket must
        /// be a hierarchical namespace enabled bucket.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Folder"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFoldersResponse, Folder> ListFoldersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFoldersRequest request = new ListFoldersRequest
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
            return ListFoldersAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of folders. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which to look for folders. The bucket must
        /// be a hierarchical namespace enabled bucket.
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
        /// <returns>A pageable sequence of <see cref="Folder"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFoldersResponse, Folder> ListFolders(BucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFoldersRequest request = new ListFoldersRequest
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
            return ListFolders(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of folders. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which to look for folders. The bucket must
        /// be a hierarchical namespace enabled bucket.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Folder"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFoldersResponse, Folder> ListFoldersAsync(BucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFoldersRequest request = new ListFoldersRequest
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
            return ListFoldersAsync(request, callSettings);
        }

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, RenameFolderMetadata> RenameFolder(RenameFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, RenameFolderMetadata>> RenameFolderAsync(RenameFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, RenameFolderMetadata>> RenameFolderAsync(RenameFolderRequest request, st::CancellationToken cancellationToken) =>
            RenameFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RenameFolder</c>.</summary>
        public virtual lro::OperationsClient RenameFolderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RenameFolder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Folder, RenameFolderMetadata> PollOnceRenameFolder(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Folder, RenameFolderMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RenameFolderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RenameFolder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Folder, RenameFolderMetadata>> PollOnceRenameFolderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Folder, RenameFolderMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RenameFolderOperationsClient, callSettings);

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the source folder being renamed.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="destinationFolderId">
        /// Required. The destination folder ID, e.g. `foo/bar/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, RenameFolderMetadata> RenameFolder(string name, string destinationFolderId, gaxgrpc::CallSettings callSettings = null) =>
            RenameFolder(new RenameFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DestinationFolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationFolderId, nameof(destinationFolderId)),
            }, callSettings);

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the source folder being renamed.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="destinationFolderId">
        /// Required. The destination folder ID, e.g. `foo/bar/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, RenameFolderMetadata>> RenameFolderAsync(string name, string destinationFolderId, gaxgrpc::CallSettings callSettings = null) =>
            RenameFolderAsync(new RenameFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DestinationFolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationFolderId, nameof(destinationFolderId)),
            }, callSettings);

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the source folder being renamed.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="destinationFolderId">
        /// Required. The destination folder ID, e.g. `foo/bar/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, RenameFolderMetadata>> RenameFolderAsync(string name, string destinationFolderId, st::CancellationToken cancellationToken) =>
            RenameFolderAsync(name, destinationFolderId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the source folder being renamed.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="destinationFolderId">
        /// Required. The destination folder ID, e.g. `foo/bar/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, RenameFolderMetadata> RenameFolder(FolderName name, string destinationFolderId, gaxgrpc::CallSettings callSettings = null) =>
            RenameFolder(new RenameFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DestinationFolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationFolderId, nameof(destinationFolderId)),
            }, callSettings);

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the source folder being renamed.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="destinationFolderId">
        /// Required. The destination folder ID, e.g. `foo/bar/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, RenameFolderMetadata>> RenameFolderAsync(FolderName name, string destinationFolderId, gaxgrpc::CallSettings callSettings = null) =>
            RenameFolderAsync(new RenameFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DestinationFolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationFolderId, nameof(destinationFolderId)),
            }, callSettings);

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the source folder being renamed.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="destinationFolderId">
        /// Required. The destination folder ID, e.g. `foo/bar/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, RenameFolderMetadata>> RenameFolderAsync(FolderName name, string destinationFolderId, st::CancellationToken cancellationToken) =>
            RenameFolderAsync(name, destinationFolderId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StorageLayout GetStorageLayout(GetStorageLayoutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StorageLayout> GetStorageLayoutAsync(GetStorageLayoutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StorageLayout> GetStorageLayoutAsync(GetStorageLayoutRequest request, st::CancellationToken cancellationToken) =>
            GetStorageLayoutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the StorageLayout resource.
        /// Format: `projects/{project}/buckets/{bucket}/storageLayout`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StorageLayout GetStorageLayout(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStorageLayout(new GetStorageLayoutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the StorageLayout resource.
        /// Format: `projects/{project}/buckets/{bucket}/storageLayout`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StorageLayout> GetStorageLayoutAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStorageLayoutAsync(new GetStorageLayoutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the StorageLayout resource.
        /// Format: `projects/{project}/buckets/{bucket}/storageLayout`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StorageLayout> GetStorageLayoutAsync(string name, st::CancellationToken cancellationToken) =>
            GetStorageLayoutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the StorageLayout resource.
        /// Format: `projects/{project}/buckets/{bucket}/storageLayout`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StorageLayout GetStorageLayout(StorageLayoutName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStorageLayout(new GetStorageLayoutRequest
            {
                StorageLayoutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the StorageLayout resource.
        /// Format: `projects/{project}/buckets/{bucket}/storageLayout`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StorageLayout> GetStorageLayoutAsync(StorageLayoutName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStorageLayoutAsync(new GetStorageLayoutRequest
            {
                StorageLayoutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the StorageLayout resource.
        /// Format: `projects/{project}/buckets/{bucket}/storageLayout`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StorageLayout> GetStorageLayoutAsync(StorageLayoutName name, st::CancellationToken cancellationToken) =>
            GetStorageLayoutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagedFolder CreateManagedFolder(CreateManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> CreateManagedFolderAsync(CreateManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> CreateManagedFolderAsync(CreateManagedFolderRequest request, st::CancellationToken cancellationToken) =>
            CreateManagedFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
        /// </param>
        /// <param name="managedFolder">
        /// Required. Properties of the managed folder being created.
        /// The bucket and managed folder names are specified in the `parent` and
        /// `managed_folder_id` fields. Populating these fields in `managed_folder`
        /// will result in an error.
        /// </param>
        /// <param name="managedFolderId">
        /// Required. The name of the managed folder. It uses a single `/` as delimiter
        /// and leading and trailing `/` are allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagedFolder CreateManagedFolder(string parent, ManagedFolder managedFolder, string managedFolderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateManagedFolder(new CreateManagedFolderRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ManagedFolder = gax::GaxPreconditions.CheckNotNull(managedFolder, nameof(managedFolder)),
                ManagedFolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(managedFolderId, nameof(managedFolderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
        /// </param>
        /// <param name="managedFolder">
        /// Required. Properties of the managed folder being created.
        /// The bucket and managed folder names are specified in the `parent` and
        /// `managed_folder_id` fields. Populating these fields in `managed_folder`
        /// will result in an error.
        /// </param>
        /// <param name="managedFolderId">
        /// Required. The name of the managed folder. It uses a single `/` as delimiter
        /// and leading and trailing `/` are allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> CreateManagedFolderAsync(string parent, ManagedFolder managedFolder, string managedFolderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateManagedFolderAsync(new CreateManagedFolderRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ManagedFolder = gax::GaxPreconditions.CheckNotNull(managedFolder, nameof(managedFolder)),
                ManagedFolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(managedFolderId, nameof(managedFolderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
        /// </param>
        /// <param name="managedFolder">
        /// Required. Properties of the managed folder being created.
        /// The bucket and managed folder names are specified in the `parent` and
        /// `managed_folder_id` fields. Populating these fields in `managed_folder`
        /// will result in an error.
        /// </param>
        /// <param name="managedFolderId">
        /// Required. The name of the managed folder. It uses a single `/` as delimiter
        /// and leading and trailing `/` are allowed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> CreateManagedFolderAsync(string parent, ManagedFolder managedFolder, string managedFolderId, st::CancellationToken cancellationToken) =>
            CreateManagedFolderAsync(parent, managedFolder, managedFolderId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
        /// </param>
        /// <param name="managedFolder">
        /// Required. Properties of the managed folder being created.
        /// The bucket and managed folder names are specified in the `parent` and
        /// `managed_folder_id` fields. Populating these fields in `managed_folder`
        /// will result in an error.
        /// </param>
        /// <param name="managedFolderId">
        /// Required. The name of the managed folder. It uses a single `/` as delimiter
        /// and leading and trailing `/` are allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagedFolder CreateManagedFolder(BucketName parent, ManagedFolder managedFolder, string managedFolderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateManagedFolder(new CreateManagedFolderRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ManagedFolder = gax::GaxPreconditions.CheckNotNull(managedFolder, nameof(managedFolder)),
                ManagedFolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(managedFolderId, nameof(managedFolderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
        /// </param>
        /// <param name="managedFolder">
        /// Required. Properties of the managed folder being created.
        /// The bucket and managed folder names are specified in the `parent` and
        /// `managed_folder_id` fields. Populating these fields in `managed_folder`
        /// will result in an error.
        /// </param>
        /// <param name="managedFolderId">
        /// Required. The name of the managed folder. It uses a single `/` as delimiter
        /// and leading and trailing `/` are allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> CreateManagedFolderAsync(BucketName parent, ManagedFolder managedFolder, string managedFolderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateManagedFolderAsync(new CreateManagedFolderRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ManagedFolder = gax::GaxPreconditions.CheckNotNull(managedFolder, nameof(managedFolder)),
                ManagedFolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(managedFolderId, nameof(managedFolderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
        /// </param>
        /// <param name="managedFolder">
        /// Required. Properties of the managed folder being created.
        /// The bucket and managed folder names are specified in the `parent` and
        /// `managed_folder_id` fields. Populating these fields in `managed_folder`
        /// will result in an error.
        /// </param>
        /// <param name="managedFolderId">
        /// Required. The name of the managed folder. It uses a single `/` as delimiter
        /// and leading and trailing `/` are allowed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> CreateManagedFolderAsync(BucketName parent, ManagedFolder managedFolder, string managedFolderId, st::CancellationToken cancellationToken) =>
            CreateManagedFolderAsync(parent, managedFolder, managedFolderId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteManagedFolder(DeleteManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteManagedFolderAsync(DeleteManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteManagedFolderAsync(DeleteManagedFolderRequest request, st::CancellationToken cancellationToken) =>
            DeleteManagedFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteManagedFolder(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteManagedFolder(new DeleteManagedFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteManagedFolderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteManagedFolderAsync(new DeleteManagedFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteManagedFolderAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteManagedFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteManagedFolder(ManagedFolderName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteManagedFolder(new DeleteManagedFolderRequest
            {
                ManagedFolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteManagedFolderAsync(ManagedFolderName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteManagedFolderAsync(new DeleteManagedFolderRequest
            {
                ManagedFolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteManagedFolderAsync(ManagedFolderName name, st::CancellationToken cancellationToken) =>
            DeleteManagedFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagedFolder GetManagedFolder(GetManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> GetManagedFolderAsync(GetManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> GetManagedFolderAsync(GetManagedFolderRequest request, st::CancellationToken cancellationToken) =>
            GetManagedFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagedFolder GetManagedFolder(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetManagedFolder(new GetManagedFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> GetManagedFolderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetManagedFolderAsync(new GetManagedFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> GetManagedFolderAsync(string name, st::CancellationToken cancellationToken) =>
            GetManagedFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagedFolder GetManagedFolder(ManagedFolderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetManagedFolder(new GetManagedFolderRequest
            {
                ManagedFolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> GetManagedFolderAsync(ManagedFolderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetManagedFolderAsync(new GetManagedFolderRequest
            {
                ManagedFolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> GetManagedFolderAsync(ManagedFolderName name, st::CancellationToken cancellationToken) =>
            GetManagedFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of managed folders for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ManagedFolder"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListManagedFoldersResponse, ManagedFolder> ListManagedFolders(ListManagedFoldersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of managed folders for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ManagedFolder"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListManagedFoldersResponse, ManagedFolder> ListManagedFoldersAsync(ListManagedFoldersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of managed folders for a given bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
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
        /// <returns>A pageable sequence of <see cref="ManagedFolder"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListManagedFoldersResponse, ManagedFolder> ListManagedFolders(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListManagedFoldersRequest request = new ListManagedFoldersRequest
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
            return ListManagedFolders(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of managed folders for a given bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ManagedFolder"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListManagedFoldersResponse, ManagedFolder> ListManagedFoldersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListManagedFoldersRequest request = new ListManagedFoldersRequest
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
            return ListManagedFoldersAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of managed folders for a given bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
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
        /// <returns>A pageable sequence of <see cref="ManagedFolder"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListManagedFoldersResponse, ManagedFolder> ListManagedFolders(BucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListManagedFoldersRequest request = new ListManagedFoldersRequest
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
            return ListManagedFolders(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of managed folders for a given bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ManagedFolder"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListManagedFoldersResponse, ManagedFolder> ListManagedFoldersAsync(BucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListManagedFoldersRequest request = new ListManagedFoldersRequest
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
            return ListManagedFoldersAsync(request, callSettings);
        }

        /// <summary>
        /// Creates an Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AnywhereCache, CreateAnywhereCacheMetadata> CreateAnywhereCache(CreateAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnywhereCache, CreateAnywhereCacheMetadata>> CreateAnywhereCacheAsync(CreateAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnywhereCache, CreateAnywhereCacheMetadata>> CreateAnywhereCacheAsync(CreateAnywhereCacheRequest request, st::CancellationToken cancellationToken) =>
            CreateAnywhereCacheAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAnywhereCache</c>.</summary>
        public virtual lro::OperationsClient CreateAnywhereCacheOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAnywhereCache</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AnywhereCache, CreateAnywhereCacheMetadata> PollOnceCreateAnywhereCache(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AnywhereCache, CreateAnywhereCacheMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAnywhereCacheOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAnywhereCache</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AnywhereCache, CreateAnywhereCacheMetadata>> PollOnceCreateAnywhereCacheAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AnywhereCache, CreateAnywhereCacheMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAnywhereCacheOperationsClient, callSettings);

        /// <summary>
        /// Creates an Anywhere Cache instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The bucket to which this cache belongs.
        /// Format: `projects/{project}/buckets/{bucket}`
        /// </param>
        /// <param name="anywhereCache">
        /// Required. Properties of the Anywhere Cache instance being created.
        /// The parent bucket name is specified in the `parent` field. Server uses the
        /// default value of `ttl` or `admission_policy` if not specified in
        /// request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AnywhereCache, CreateAnywhereCacheMetadata> CreateAnywhereCache(string parent, AnywhereCache anywhereCache, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnywhereCache(new CreateAnywhereCacheRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AnywhereCache = gax::GaxPreconditions.CheckNotNull(anywhereCache, nameof(anywhereCache)),
            }, callSettings);

        /// <summary>
        /// Creates an Anywhere Cache instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The bucket to which this cache belongs.
        /// Format: `projects/{project}/buckets/{bucket}`
        /// </param>
        /// <param name="anywhereCache">
        /// Required. Properties of the Anywhere Cache instance being created.
        /// The parent bucket name is specified in the `parent` field. Server uses the
        /// default value of `ttl` or `admission_policy` if not specified in
        /// request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnywhereCache, CreateAnywhereCacheMetadata>> CreateAnywhereCacheAsync(string parent, AnywhereCache anywhereCache, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnywhereCacheAsync(new CreateAnywhereCacheRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AnywhereCache = gax::GaxPreconditions.CheckNotNull(anywhereCache, nameof(anywhereCache)),
            }, callSettings);

        /// <summary>
        /// Creates an Anywhere Cache instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The bucket to which this cache belongs.
        /// Format: `projects/{project}/buckets/{bucket}`
        /// </param>
        /// <param name="anywhereCache">
        /// Required. Properties of the Anywhere Cache instance being created.
        /// The parent bucket name is specified in the `parent` field. Server uses the
        /// default value of `ttl` or `admission_policy` if not specified in
        /// request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnywhereCache, CreateAnywhereCacheMetadata>> CreateAnywhereCacheAsync(string parent, AnywhereCache anywhereCache, st::CancellationToken cancellationToken) =>
            CreateAnywhereCacheAsync(parent, anywhereCache, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Anywhere Cache instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The bucket to which this cache belongs.
        /// Format: `projects/{project}/buckets/{bucket}`
        /// </param>
        /// <param name="anywhereCache">
        /// Required. Properties of the Anywhere Cache instance being created.
        /// The parent bucket name is specified in the `parent` field. Server uses the
        /// default value of `ttl` or `admission_policy` if not specified in
        /// request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AnywhereCache, CreateAnywhereCacheMetadata> CreateAnywhereCache(BucketName parent, AnywhereCache anywhereCache, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnywhereCache(new CreateAnywhereCacheRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AnywhereCache = gax::GaxPreconditions.CheckNotNull(anywhereCache, nameof(anywhereCache)),
            }, callSettings);

        /// <summary>
        /// Creates an Anywhere Cache instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The bucket to which this cache belongs.
        /// Format: `projects/{project}/buckets/{bucket}`
        /// </param>
        /// <param name="anywhereCache">
        /// Required. Properties of the Anywhere Cache instance being created.
        /// The parent bucket name is specified in the `parent` field. Server uses the
        /// default value of `ttl` or `admission_policy` if not specified in
        /// request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnywhereCache, CreateAnywhereCacheMetadata>> CreateAnywhereCacheAsync(BucketName parent, AnywhereCache anywhereCache, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnywhereCacheAsync(new CreateAnywhereCacheRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AnywhereCache = gax::GaxPreconditions.CheckNotNull(anywhereCache, nameof(anywhereCache)),
            }, callSettings);

        /// <summary>
        /// Creates an Anywhere Cache instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The bucket to which this cache belongs.
        /// Format: `projects/{project}/buckets/{bucket}`
        /// </param>
        /// <param name="anywhereCache">
        /// Required. Properties of the Anywhere Cache instance being created.
        /// The parent bucket name is specified in the `parent` field. Server uses the
        /// default value of `ttl` or `admission_policy` if not specified in
        /// request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnywhereCache, CreateAnywhereCacheMetadata>> CreateAnywhereCacheAsync(BucketName parent, AnywhereCache anywhereCache, st::CancellationToken cancellationToken) =>
            CreateAnywhereCacheAsync(parent, anywhereCache, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an Anywhere Cache instance. Mutable fields include `ttl` and
        /// `admission_policy`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AnywhereCache, UpdateAnywhereCacheMetadata> UpdateAnywhereCache(UpdateAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an Anywhere Cache instance. Mutable fields include `ttl` and
        /// `admission_policy`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnywhereCache, UpdateAnywhereCacheMetadata>> UpdateAnywhereCacheAsync(UpdateAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an Anywhere Cache instance. Mutable fields include `ttl` and
        /// `admission_policy`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnywhereCache, UpdateAnywhereCacheMetadata>> UpdateAnywhereCacheAsync(UpdateAnywhereCacheRequest request, st::CancellationToken cancellationToken) =>
            UpdateAnywhereCacheAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAnywhereCache</c>.</summary>
        public virtual lro::OperationsClient UpdateAnywhereCacheOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAnywhereCache</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AnywhereCache, UpdateAnywhereCacheMetadata> PollOnceUpdateAnywhereCache(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AnywhereCache, UpdateAnywhereCacheMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAnywhereCacheOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAnywhereCache</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AnywhereCache, UpdateAnywhereCacheMetadata>> PollOnceUpdateAnywhereCacheAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AnywhereCache, UpdateAnywhereCacheMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAnywhereCacheOperationsClient, callSettings);

        /// <summary>
        /// Updates an Anywhere Cache instance. Mutable fields include `ttl` and
        /// `admission_policy`.
        /// </summary>
        /// <param name="anywhereCache">
        /// Required. The Anywhere Cache instance to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated. Mutable fields of AnywhereCache
        /// include `ttl` and `admission_policy`.
        /// 
        /// To specify ALL fields, specify a single field with the value `*`. Note: We
        /// recommend against doing this. If a new field is introduced at a later time,
        /// an older client updating with the `*` may accidentally reset the new
        /// field's value.
        /// 
        /// Not specifying any fields is an error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AnywhereCache, UpdateAnywhereCacheMetadata> UpdateAnywhereCache(AnywhereCache anywhereCache, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAnywhereCache(new UpdateAnywhereCacheRequest
            {
                AnywhereCache = gax::GaxPreconditions.CheckNotNull(anywhereCache, nameof(anywhereCache)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an Anywhere Cache instance. Mutable fields include `ttl` and
        /// `admission_policy`.
        /// </summary>
        /// <param name="anywhereCache">
        /// Required. The Anywhere Cache instance to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated. Mutable fields of AnywhereCache
        /// include `ttl` and `admission_policy`.
        /// 
        /// To specify ALL fields, specify a single field with the value `*`. Note: We
        /// recommend against doing this. If a new field is introduced at a later time,
        /// an older client updating with the `*` may accidentally reset the new
        /// field's value.
        /// 
        /// Not specifying any fields is an error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnywhereCache, UpdateAnywhereCacheMetadata>> UpdateAnywhereCacheAsync(AnywhereCache anywhereCache, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAnywhereCacheAsync(new UpdateAnywhereCacheRequest
            {
                AnywhereCache = gax::GaxPreconditions.CheckNotNull(anywhereCache, nameof(anywhereCache)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an Anywhere Cache instance. Mutable fields include `ttl` and
        /// `admission_policy`.
        /// </summary>
        /// <param name="anywhereCache">
        /// Required. The Anywhere Cache instance to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated. Mutable fields of AnywhereCache
        /// include `ttl` and `admission_policy`.
        /// 
        /// To specify ALL fields, specify a single field with the value `*`. Note: We
        /// recommend against doing this. If a new field is introduced at a later time,
        /// an older client updating with the `*` may accidentally reset the new
        /// field's value.
        /// 
        /// Not specifying any fields is an error.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnywhereCache, UpdateAnywhereCacheMetadata>> UpdateAnywhereCacheAsync(AnywhereCache anywhereCache, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAnywhereCacheAsync(anywhereCache, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disables an Anywhere Cache instance. A disabled instance is read-only. The
        /// disablement could be revoked by calling ResumeAnywhereCache. The cache
        /// instance will be deleted automatically if it remains in the disabled state
        /// for at least one hour.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnywhereCache DisableAnywhereCache(DisableAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables an Anywhere Cache instance. A disabled instance is read-only. The
        /// disablement could be revoked by calling ResumeAnywhereCache. The cache
        /// instance will be deleted automatically if it remains in the disabled state
        /// for at least one hour.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> DisableAnywhereCacheAsync(DisableAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables an Anywhere Cache instance. A disabled instance is read-only. The
        /// disablement could be revoked by calling ResumeAnywhereCache. The cache
        /// instance will be deleted automatically if it remains in the disabled state
        /// for at least one hour.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> DisableAnywhereCacheAsync(DisableAnywhereCacheRequest request, st::CancellationToken cancellationToken) =>
            DisableAnywhereCacheAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disables an Anywhere Cache instance. A disabled instance is read-only. The
        /// disablement could be revoked by calling ResumeAnywhereCache. The cache
        /// instance will be deleted automatically if it remains in the disabled state
        /// for at least one hour.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnywhereCache DisableAnywhereCache(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisableAnywhereCache(new DisableAnywhereCacheRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disables an Anywhere Cache instance. A disabled instance is read-only. The
        /// disablement could be revoked by calling ResumeAnywhereCache. The cache
        /// instance will be deleted automatically if it remains in the disabled state
        /// for at least one hour.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> DisableAnywhereCacheAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisableAnywhereCacheAsync(new DisableAnywhereCacheRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disables an Anywhere Cache instance. A disabled instance is read-only. The
        /// disablement could be revoked by calling ResumeAnywhereCache. The cache
        /// instance will be deleted automatically if it remains in the disabled state
        /// for at least one hour.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> DisableAnywhereCacheAsync(string name, st::CancellationToken cancellationToken) =>
            DisableAnywhereCacheAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disables an Anywhere Cache instance. A disabled instance is read-only. The
        /// disablement could be revoked by calling ResumeAnywhereCache. The cache
        /// instance will be deleted automatically if it remains in the disabled state
        /// for at least one hour.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnywhereCache DisableAnywhereCache(AnywhereCacheName name, gaxgrpc::CallSettings callSettings = null) =>
            DisableAnywhereCache(new DisableAnywhereCacheRequest
            {
                AnywhereCacheName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disables an Anywhere Cache instance. A disabled instance is read-only. The
        /// disablement could be revoked by calling ResumeAnywhereCache. The cache
        /// instance will be deleted automatically if it remains in the disabled state
        /// for at least one hour.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> DisableAnywhereCacheAsync(AnywhereCacheName name, gaxgrpc::CallSettings callSettings = null) =>
            DisableAnywhereCacheAsync(new DisableAnywhereCacheRequest
            {
                AnywhereCacheName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disables an Anywhere Cache instance. A disabled instance is read-only. The
        /// disablement could be revoked by calling ResumeAnywhereCache. The cache
        /// instance will be deleted automatically if it remains in the disabled state
        /// for at least one hour.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> DisableAnywhereCacheAsync(AnywhereCacheName name, st::CancellationToken cancellationToken) =>
            DisableAnywhereCacheAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses an Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnywhereCache PauseAnywhereCache(PauseAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses an Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> PauseAnywhereCacheAsync(PauseAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses an Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> PauseAnywhereCacheAsync(PauseAnywhereCacheRequest request, st::CancellationToken cancellationToken) =>
            PauseAnywhereCacheAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses an Anywhere Cache instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnywhereCache PauseAnywhereCache(string name, gaxgrpc::CallSettings callSettings = null) =>
            PauseAnywhereCache(new PauseAnywhereCacheRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses an Anywhere Cache instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> PauseAnywhereCacheAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            PauseAnywhereCacheAsync(new PauseAnywhereCacheRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses an Anywhere Cache instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> PauseAnywhereCacheAsync(string name, st::CancellationToken cancellationToken) =>
            PauseAnywhereCacheAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses an Anywhere Cache instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnywhereCache PauseAnywhereCache(AnywhereCacheName name, gaxgrpc::CallSettings callSettings = null) =>
            PauseAnywhereCache(new PauseAnywhereCacheRequest
            {
                AnywhereCacheName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses an Anywhere Cache instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> PauseAnywhereCacheAsync(AnywhereCacheName name, gaxgrpc::CallSettings callSettings = null) =>
            PauseAnywhereCacheAsync(new PauseAnywhereCacheRequest
            {
                AnywhereCacheName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses an Anywhere Cache instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> PauseAnywhereCacheAsync(AnywhereCacheName name, st::CancellationToken cancellationToken) =>
            PauseAnywhereCacheAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a disabled or paused Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnywhereCache ResumeAnywhereCache(ResumeAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes a disabled or paused Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> ResumeAnywhereCacheAsync(ResumeAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes a disabled or paused Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> ResumeAnywhereCacheAsync(ResumeAnywhereCacheRequest request, st::CancellationToken cancellationToken) =>
            ResumeAnywhereCacheAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a disabled or paused Anywhere Cache instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnywhereCache ResumeAnywhereCache(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeAnywhereCache(new ResumeAnywhereCacheRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes a disabled or paused Anywhere Cache instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> ResumeAnywhereCacheAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeAnywhereCacheAsync(new ResumeAnywhereCacheRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes a disabled or paused Anywhere Cache instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> ResumeAnywhereCacheAsync(string name, st::CancellationToken cancellationToken) =>
            ResumeAnywhereCacheAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a disabled or paused Anywhere Cache instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnywhereCache ResumeAnywhereCache(AnywhereCacheName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeAnywhereCache(new ResumeAnywhereCacheRequest
            {
                AnywhereCacheName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes a disabled or paused Anywhere Cache instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> ResumeAnywhereCacheAsync(AnywhereCacheName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeAnywhereCacheAsync(new ResumeAnywhereCacheRequest
            {
                AnywhereCacheName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes a disabled or paused Anywhere Cache instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> ResumeAnywhereCacheAsync(AnywhereCacheName name, st::CancellationToken cancellationToken) =>
            ResumeAnywhereCacheAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnywhereCache GetAnywhereCache(GetAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> GetAnywhereCacheAsync(GetAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> GetAnywhereCacheAsync(GetAnywhereCacheRequest request, st::CancellationToken cancellationToken) =>
            GetAnywhereCacheAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an Anywhere Cache instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnywhereCache GetAnywhereCache(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnywhereCache(new GetAnywhereCacheRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Anywhere Cache instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> GetAnywhereCacheAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnywhereCacheAsync(new GetAnywhereCacheRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Anywhere Cache instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> GetAnywhereCacheAsync(string name, st::CancellationToken cancellationToken) =>
            GetAnywhereCacheAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an Anywhere Cache instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnywhereCache GetAnywhereCache(AnywhereCacheName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnywhereCache(new GetAnywhereCacheRequest
            {
                AnywhereCacheName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Anywhere Cache instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> GetAnywhereCacheAsync(AnywhereCacheName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnywhereCacheAsync(new GetAnywhereCacheRequest
            {
                AnywhereCacheName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Anywhere Cache instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name field in the request should be:
        /// `projects/{project}/buckets/{bucket}/anywhereCaches/{anywhere_cache}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnywhereCache> GetAnywhereCacheAsync(AnywhereCacheName name, st::CancellationToken cancellationToken) =>
            GetAnywhereCacheAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Anywhere Cache instances for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnywhereCache"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnywhereCachesResponse, AnywhereCache> ListAnywhereCaches(ListAnywhereCachesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Anywhere Cache instances for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnywhereCache"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnywhereCachesResponse, AnywhereCache> ListAnywhereCachesAsync(ListAnywhereCachesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Anywhere Cache instances for a given bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The bucket to which this cache belongs.
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
        /// <returns>A pageable sequence of <see cref="AnywhereCache"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnywhereCachesResponse, AnywhereCache> ListAnywhereCaches(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnywhereCachesRequest request = new ListAnywhereCachesRequest
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
            return ListAnywhereCaches(request, callSettings);
        }

        /// <summary>
        /// Lists Anywhere Cache instances for a given bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The bucket to which this cache belongs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AnywhereCache"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnywhereCachesResponse, AnywhereCache> ListAnywhereCachesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnywhereCachesRequest request = new ListAnywhereCachesRequest
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
            return ListAnywhereCachesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Anywhere Cache instances for a given bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The bucket to which this cache belongs.
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
        /// <returns>A pageable sequence of <see cref="AnywhereCache"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnywhereCachesResponse, AnywhereCache> ListAnywhereCaches(BucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnywhereCachesRequest request = new ListAnywhereCachesRequest
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
            return ListAnywhereCaches(request, callSettings);
        }

        /// <summary>
        /// Lists Anywhere Cache instances for a given bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The bucket to which this cache belongs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AnywhereCache"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnywhereCachesResponse, AnywhereCache> ListAnywhereCachesAsync(BucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnywhereCachesRequest request = new ListAnywhereCachesRequest
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
            return ListAnywhereCachesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IntelligenceConfig GetProjectIntelligenceConfig(GetProjectIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> GetProjectIntelligenceConfigAsync(GetProjectIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> GetProjectIntelligenceConfigAsync(GetProjectIntelligenceConfigRequest request, st::CancellationToken cancellationToken) =>
            GetProjectIntelligenceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `IntelligenceConfig` resource associated with
        /// your project.
        /// 
        /// Format: `projects/{id}/locations/global/intelligenceConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IntelligenceConfig GetProjectIntelligenceConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectIntelligenceConfig(new GetProjectIntelligenceConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `IntelligenceConfig` resource associated with
        /// your project.
        /// 
        /// Format: `projects/{id}/locations/global/intelligenceConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> GetProjectIntelligenceConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectIntelligenceConfigAsync(new GetProjectIntelligenceConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `IntelligenceConfig` resource associated with
        /// your project.
        /// 
        /// Format: `projects/{id}/locations/global/intelligenceConfig`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> GetProjectIntelligenceConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetProjectIntelligenceConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `IntelligenceConfig` resource associated with
        /// your project.
        /// 
        /// Format: `projects/{id}/locations/global/intelligenceConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IntelligenceConfig GetProjectIntelligenceConfig(IntelligenceConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectIntelligenceConfig(new GetProjectIntelligenceConfigRequest
            {
                IntelligenceConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `IntelligenceConfig` resource associated with
        /// your project.
        /// 
        /// Format: `projects/{id}/locations/global/intelligenceConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> GetProjectIntelligenceConfigAsync(IntelligenceConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectIntelligenceConfigAsync(new GetProjectIntelligenceConfigRequest
            {
                IntelligenceConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `IntelligenceConfig` resource associated with
        /// your project.
        /// 
        /// Format: `projects/{id}/locations/global/intelligenceConfig`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> GetProjectIntelligenceConfigAsync(IntelligenceConfigName name, st::CancellationToken cancellationToken) =>
            GetProjectIntelligenceConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IntelligenceConfig UpdateProjectIntelligenceConfig(UpdateProjectIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> UpdateProjectIntelligenceConfigAsync(UpdateProjectIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> UpdateProjectIntelligenceConfigAsync(UpdateProjectIntelligenceConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateProjectIntelligenceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="intelligenceConfig">
        /// Required. The `IntelligenceConfig` resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The `update_mask` that specifies the fields within the
        /// `IntelligenceConfig` resource that should be modified by this update. Only
        /// the listed fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IntelligenceConfig UpdateProjectIntelligenceConfig(IntelligenceConfig intelligenceConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProjectIntelligenceConfig(new UpdateProjectIntelligenceConfigRequest
            {
                IntelligenceConfig = gax::GaxPreconditions.CheckNotNull(intelligenceConfig, nameof(intelligenceConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="intelligenceConfig">
        /// Required. The `IntelligenceConfig` resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The `update_mask` that specifies the fields within the
        /// `IntelligenceConfig` resource that should be modified by this update. Only
        /// the listed fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> UpdateProjectIntelligenceConfigAsync(IntelligenceConfig intelligenceConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProjectIntelligenceConfigAsync(new UpdateProjectIntelligenceConfigRequest
            {
                IntelligenceConfig = gax::GaxPreconditions.CheckNotNull(intelligenceConfig, nameof(intelligenceConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="intelligenceConfig">
        /// Required. The `IntelligenceConfig` resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The `update_mask` that specifies the fields within the
        /// `IntelligenceConfig` resource that should be modified by this update. Only
        /// the listed fields are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> UpdateProjectIntelligenceConfigAsync(IntelligenceConfig intelligenceConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateProjectIntelligenceConfigAsync(intelligenceConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IntelligenceConfig GetFolderIntelligenceConfig(GetFolderIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> GetFolderIntelligenceConfigAsync(GetFolderIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> GetFolderIntelligenceConfigAsync(GetFolderIntelligenceConfigRequest request, st::CancellationToken cancellationToken) =>
            GetFolderIntelligenceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `IntelligenceConfig` resource associated with
        /// your folder.
        /// 
        /// Format: `folders/{id}/locations/global/intelligenceConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IntelligenceConfig GetFolderIntelligenceConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolderIntelligenceConfig(new GetFolderIntelligenceConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `IntelligenceConfig` resource associated with
        /// your folder.
        /// 
        /// Format: `folders/{id}/locations/global/intelligenceConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> GetFolderIntelligenceConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolderIntelligenceConfigAsync(new GetFolderIntelligenceConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `IntelligenceConfig` resource associated with
        /// your folder.
        /// 
        /// Format: `folders/{id}/locations/global/intelligenceConfig`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> GetFolderIntelligenceConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetFolderIntelligenceConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `IntelligenceConfig` resource associated with
        /// your folder.
        /// 
        /// Format: `folders/{id}/locations/global/intelligenceConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IntelligenceConfig GetFolderIntelligenceConfig(IntelligenceConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolderIntelligenceConfig(new GetFolderIntelligenceConfigRequest
            {
                IntelligenceConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `IntelligenceConfig` resource associated with
        /// your folder.
        /// 
        /// Format: `folders/{id}/locations/global/intelligenceConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> GetFolderIntelligenceConfigAsync(IntelligenceConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolderIntelligenceConfigAsync(new GetFolderIntelligenceConfigRequest
            {
                IntelligenceConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `IntelligenceConfig` resource associated with
        /// your folder.
        /// 
        /// Format: `folders/{id}/locations/global/intelligenceConfig`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> GetFolderIntelligenceConfigAsync(IntelligenceConfigName name, st::CancellationToken cancellationToken) =>
            GetFolderIntelligenceConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IntelligenceConfig UpdateFolderIntelligenceConfig(UpdateFolderIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> UpdateFolderIntelligenceConfigAsync(UpdateFolderIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> UpdateFolderIntelligenceConfigAsync(UpdateFolderIntelligenceConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateFolderIntelligenceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="intelligenceConfig">
        /// Required. The `IntelligenceConfig` resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The `update_mask` that specifies the fields within the
        /// `IntelligenceConfig` resource that should be modified by this update. Only
        /// the listed fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IntelligenceConfig UpdateFolderIntelligenceConfig(IntelligenceConfig intelligenceConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFolderIntelligenceConfig(new UpdateFolderIntelligenceConfigRequest
            {
                IntelligenceConfig = gax::GaxPreconditions.CheckNotNull(intelligenceConfig, nameof(intelligenceConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="intelligenceConfig">
        /// Required. The `IntelligenceConfig` resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The `update_mask` that specifies the fields within the
        /// `IntelligenceConfig` resource that should be modified by this update. Only
        /// the listed fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> UpdateFolderIntelligenceConfigAsync(IntelligenceConfig intelligenceConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFolderIntelligenceConfigAsync(new UpdateFolderIntelligenceConfigRequest
            {
                IntelligenceConfig = gax::GaxPreconditions.CheckNotNull(intelligenceConfig, nameof(intelligenceConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="intelligenceConfig">
        /// Required. The `IntelligenceConfig` resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The `update_mask` that specifies the fields within the
        /// `IntelligenceConfig` resource that should be modified by this update. Only
        /// the listed fields are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> UpdateFolderIntelligenceConfigAsync(IntelligenceConfig intelligenceConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFolderIntelligenceConfigAsync(intelligenceConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IntelligenceConfig GetOrganizationIntelligenceConfig(GetOrganizationIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> GetOrganizationIntelligenceConfigAsync(GetOrganizationIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> GetOrganizationIntelligenceConfigAsync(GetOrganizationIntelligenceConfigRequest request, st::CancellationToken cancellationToken) =>
            GetOrganizationIntelligenceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `IntelligenceConfig` resource associated with
        /// your organization.
        /// 
        /// Format: `organizations/{org_id}/locations/global/intelligenceConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IntelligenceConfig GetOrganizationIntelligenceConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganizationIntelligenceConfig(new GetOrganizationIntelligenceConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `IntelligenceConfig` resource associated with
        /// your organization.
        /// 
        /// Format: `organizations/{org_id}/locations/global/intelligenceConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> GetOrganizationIntelligenceConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganizationIntelligenceConfigAsync(new GetOrganizationIntelligenceConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `IntelligenceConfig` resource associated with
        /// your organization.
        /// 
        /// Format: `organizations/{org_id}/locations/global/intelligenceConfig`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> GetOrganizationIntelligenceConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetOrganizationIntelligenceConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `IntelligenceConfig` resource associated with
        /// your organization.
        /// 
        /// Format: `organizations/{org_id}/locations/global/intelligenceConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IntelligenceConfig GetOrganizationIntelligenceConfig(IntelligenceConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganizationIntelligenceConfig(new GetOrganizationIntelligenceConfigRequest
            {
                IntelligenceConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `IntelligenceConfig` resource associated with
        /// your organization.
        /// 
        /// Format: `organizations/{org_id}/locations/global/intelligenceConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> GetOrganizationIntelligenceConfigAsync(IntelligenceConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganizationIntelligenceConfigAsync(new GetOrganizationIntelligenceConfigRequest
            {
                IntelligenceConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `IntelligenceConfig` resource associated with
        /// your organization.
        /// 
        /// Format: `organizations/{org_id}/locations/global/intelligenceConfig`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> GetOrganizationIntelligenceConfigAsync(IntelligenceConfigName name, st::CancellationToken cancellationToken) =>
            GetOrganizationIntelligenceConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IntelligenceConfig UpdateOrganizationIntelligenceConfig(UpdateOrganizationIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> UpdateOrganizationIntelligenceConfigAsync(UpdateOrganizationIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> UpdateOrganizationIntelligenceConfigAsync(UpdateOrganizationIntelligenceConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateOrganizationIntelligenceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="intelligenceConfig">
        /// Required. The `IntelligenceConfig` resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The `update_mask` that specifies the fields within the
        /// `IntelligenceConfig` resource that should be modified by this update. Only
        /// the listed fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IntelligenceConfig UpdateOrganizationIntelligenceConfig(IntelligenceConfig intelligenceConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateOrganizationIntelligenceConfig(new UpdateOrganizationIntelligenceConfigRequest
            {
                IntelligenceConfig = gax::GaxPreconditions.CheckNotNull(intelligenceConfig, nameof(intelligenceConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="intelligenceConfig">
        /// Required. The `IntelligenceConfig` resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The `update_mask` that specifies the fields within the
        /// `IntelligenceConfig` resource that should be modified by this update. Only
        /// the listed fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> UpdateOrganizationIntelligenceConfigAsync(IntelligenceConfig intelligenceConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateOrganizationIntelligenceConfigAsync(new UpdateOrganizationIntelligenceConfigRequest
            {
                IntelligenceConfig = gax::GaxPreconditions.CheckNotNull(intelligenceConfig, nameof(intelligenceConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="intelligenceConfig">
        /// Required. The `IntelligenceConfig` resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The `update_mask` that specifies the fields within the
        /// `IntelligenceConfig` resource that should be modified by this update. Only
        /// the listed fields are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IntelligenceConfig> UpdateOrganizationIntelligenceConfigAsync(IntelligenceConfig intelligenceConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateOrganizationIntelligenceConfigAsync(intelligenceConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>StorageControl client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// StorageControl service includes selected control plane operations.
    /// </remarks>
    public sealed partial class StorageControlClientImpl : StorageControlClient
    {
        private readonly gaxgrpc::ApiCall<CreateFolderRequest, Folder> _callCreateFolder;

        private readonly gaxgrpc::ApiCall<DeleteFolderRequest, wkt::Empty> _callDeleteFolder;

        private readonly gaxgrpc::ApiCall<GetFolderRequest, Folder> _callGetFolder;

        private readonly gaxgrpc::ApiCall<ListFoldersRequest, ListFoldersResponse> _callListFolders;

        private readonly gaxgrpc::ApiCall<RenameFolderRequest, lro::Operation> _callRenameFolder;

        private readonly gaxgrpc::ApiCall<GetStorageLayoutRequest, StorageLayout> _callGetStorageLayout;

        private readonly gaxgrpc::ApiCall<CreateManagedFolderRequest, ManagedFolder> _callCreateManagedFolder;

        private readonly gaxgrpc::ApiCall<DeleteManagedFolderRequest, wkt::Empty> _callDeleteManagedFolder;

        private readonly gaxgrpc::ApiCall<GetManagedFolderRequest, ManagedFolder> _callGetManagedFolder;

        private readonly gaxgrpc::ApiCall<ListManagedFoldersRequest, ListManagedFoldersResponse> _callListManagedFolders;

        private readonly gaxgrpc::ApiCall<CreateAnywhereCacheRequest, lro::Operation> _callCreateAnywhereCache;

        private readonly gaxgrpc::ApiCall<UpdateAnywhereCacheRequest, lro::Operation> _callUpdateAnywhereCache;

        private readonly gaxgrpc::ApiCall<DisableAnywhereCacheRequest, AnywhereCache> _callDisableAnywhereCache;

        private readonly gaxgrpc::ApiCall<PauseAnywhereCacheRequest, AnywhereCache> _callPauseAnywhereCache;

        private readonly gaxgrpc::ApiCall<ResumeAnywhereCacheRequest, AnywhereCache> _callResumeAnywhereCache;

        private readonly gaxgrpc::ApiCall<GetAnywhereCacheRequest, AnywhereCache> _callGetAnywhereCache;

        private readonly gaxgrpc::ApiCall<ListAnywhereCachesRequest, ListAnywhereCachesResponse> _callListAnywhereCaches;

        private readonly gaxgrpc::ApiCall<GetProjectIntelligenceConfigRequest, IntelligenceConfig> _callGetProjectIntelligenceConfig;

        private readonly gaxgrpc::ApiCall<UpdateProjectIntelligenceConfigRequest, IntelligenceConfig> _callUpdateProjectIntelligenceConfig;

        private readonly gaxgrpc::ApiCall<GetFolderIntelligenceConfigRequest, IntelligenceConfig> _callGetFolderIntelligenceConfig;

        private readonly gaxgrpc::ApiCall<UpdateFolderIntelligenceConfigRequest, IntelligenceConfig> _callUpdateFolderIntelligenceConfig;

        private readonly gaxgrpc::ApiCall<GetOrganizationIntelligenceConfigRequest, IntelligenceConfig> _callGetOrganizationIntelligenceConfig;

        private readonly gaxgrpc::ApiCall<UpdateOrganizationIntelligenceConfigRequest, IntelligenceConfig> _callUpdateOrganizationIntelligenceConfig;

        /// <summary>
        /// Constructs a client wrapper for the StorageControl service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="StorageControlSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public StorageControlClientImpl(StorageControl.StorageControlClient grpcClient, StorageControlSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            StorageControlSettings effectiveSettings = settings ?? StorageControlSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            RenameFolderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RenameFolderOperationsSettings, logger);
            CreateAnywhereCacheOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAnywhereCacheOperationsSettings, logger);
            UpdateAnywhereCacheOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAnywhereCacheOperationsSettings, logger);
            _callCreateFolder = clientHelper.BuildApiCall<CreateFolderRequest, Folder>("CreateFolder", grpcClient.CreateFolderAsync, grpcClient.CreateFolder, effectiveSettings.CreateFolderSettings).WithGoogleRequestParam("bucket", request => request.Parent);
            Modify_ApiCall(ref _callCreateFolder);
            Modify_CreateFolderApiCall(ref _callCreateFolder);
            _callDeleteFolder = clientHelper.BuildApiCall<DeleteFolderRequest, wkt::Empty>("DeleteFolder", grpcClient.DeleteFolderAsync, grpcClient.DeleteFolder, effectiveSettings.DeleteFolderSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<DeleteFolderRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callDeleteFolder);
            Modify_DeleteFolderApiCall(ref _callDeleteFolder);
            _callGetFolder = clientHelper.BuildApiCall<GetFolderRequest, Folder>("GetFolder", grpcClient.GetFolderAsync, grpcClient.GetFolder, effectiveSettings.GetFolderSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetFolderRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callGetFolder);
            Modify_GetFolderApiCall(ref _callGetFolder);
            _callListFolders = clientHelper.BuildApiCall<ListFoldersRequest, ListFoldersResponse>("ListFolders", grpcClient.ListFoldersAsync, grpcClient.ListFolders, effectiveSettings.ListFoldersSettings).WithGoogleRequestParam("bucket", request => request.Parent);
            Modify_ApiCall(ref _callListFolders);
            Modify_ListFoldersApiCall(ref _callListFolders);
            _callRenameFolder = clientHelper.BuildApiCall<RenameFolderRequest, lro::Operation>("RenameFolder", grpcClient.RenameFolderAsync, grpcClient.RenameFolder, effectiveSettings.RenameFolderSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<RenameFolderRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callRenameFolder);
            Modify_RenameFolderApiCall(ref _callRenameFolder);
            _callGetStorageLayout = clientHelper.BuildApiCall<GetStorageLayoutRequest, StorageLayout>("GetStorageLayout", grpcClient.GetStorageLayoutAsync, grpcClient.GetStorageLayout, effectiveSettings.GetStorageLayoutSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetStorageLayoutRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callGetStorageLayout);
            Modify_GetStorageLayoutApiCall(ref _callGetStorageLayout);
            _callCreateManagedFolder = clientHelper.BuildApiCall<CreateManagedFolderRequest, ManagedFolder>("CreateManagedFolder", grpcClient.CreateManagedFolderAsync, grpcClient.CreateManagedFolder, effectiveSettings.CreateManagedFolderSettings).WithGoogleRequestParam("bucket", request => request.Parent);
            Modify_ApiCall(ref _callCreateManagedFolder);
            Modify_CreateManagedFolderApiCall(ref _callCreateManagedFolder);
            _callDeleteManagedFolder = clientHelper.BuildApiCall<DeleteManagedFolderRequest, wkt::Empty>("DeleteManagedFolder", grpcClient.DeleteManagedFolderAsync, grpcClient.DeleteManagedFolder, effectiveSettings.DeleteManagedFolderSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<DeleteManagedFolderRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callDeleteManagedFolder);
            Modify_DeleteManagedFolderApiCall(ref _callDeleteManagedFolder);
            _callGetManagedFolder = clientHelper.BuildApiCall<GetManagedFolderRequest, ManagedFolder>("GetManagedFolder", grpcClient.GetManagedFolderAsync, grpcClient.GetManagedFolder, effectiveSettings.GetManagedFolderSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetManagedFolderRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callGetManagedFolder);
            Modify_GetManagedFolderApiCall(ref _callGetManagedFolder);
            _callListManagedFolders = clientHelper.BuildApiCall<ListManagedFoldersRequest, ListManagedFoldersResponse>("ListManagedFolders", grpcClient.ListManagedFoldersAsync, grpcClient.ListManagedFolders, effectiveSettings.ListManagedFoldersSettings).WithGoogleRequestParam("bucket", request => request.Parent);
            Modify_ApiCall(ref _callListManagedFolders);
            Modify_ListManagedFoldersApiCall(ref _callListManagedFolders);
            _callCreateAnywhereCache = clientHelper.BuildApiCall<CreateAnywhereCacheRequest, lro::Operation>("CreateAnywhereCache", grpcClient.CreateAnywhereCacheAsync, grpcClient.CreateAnywhereCache, effectiveSettings.CreateAnywhereCacheSettings).WithGoogleRequestParam("bucket", request => request.Parent);
            Modify_ApiCall(ref _callCreateAnywhereCache);
            Modify_CreateAnywhereCacheApiCall(ref _callCreateAnywhereCache);
            _callUpdateAnywhereCache = clientHelper.BuildApiCall<UpdateAnywhereCacheRequest, lro::Operation>("UpdateAnywhereCache", grpcClient.UpdateAnywhereCacheAsync, grpcClient.UpdateAnywhereCache, effectiveSettings.UpdateAnywhereCacheSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<UpdateAnywhereCacheRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.AnywhereCache?.Name));
            Modify_ApiCall(ref _callUpdateAnywhereCache);
            Modify_UpdateAnywhereCacheApiCall(ref _callUpdateAnywhereCache);
            _callDisableAnywhereCache = clientHelper.BuildApiCall<DisableAnywhereCacheRequest, AnywhereCache>("DisableAnywhereCache", grpcClient.DisableAnywhereCacheAsync, grpcClient.DisableAnywhereCache, effectiveSettings.DisableAnywhereCacheSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<DisableAnywhereCacheRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callDisableAnywhereCache);
            Modify_DisableAnywhereCacheApiCall(ref _callDisableAnywhereCache);
            _callPauseAnywhereCache = clientHelper.BuildApiCall<PauseAnywhereCacheRequest, AnywhereCache>("PauseAnywhereCache", grpcClient.PauseAnywhereCacheAsync, grpcClient.PauseAnywhereCache, effectiveSettings.PauseAnywhereCacheSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<PauseAnywhereCacheRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callPauseAnywhereCache);
            Modify_PauseAnywhereCacheApiCall(ref _callPauseAnywhereCache);
            _callResumeAnywhereCache = clientHelper.BuildApiCall<ResumeAnywhereCacheRequest, AnywhereCache>("ResumeAnywhereCache", grpcClient.ResumeAnywhereCacheAsync, grpcClient.ResumeAnywhereCache, effectiveSettings.ResumeAnywhereCacheSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<ResumeAnywhereCacheRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callResumeAnywhereCache);
            Modify_ResumeAnywhereCacheApiCall(ref _callResumeAnywhereCache);
            _callGetAnywhereCache = clientHelper.BuildApiCall<GetAnywhereCacheRequest, AnywhereCache>("GetAnywhereCache", grpcClient.GetAnywhereCacheAsync, grpcClient.GetAnywhereCache, effectiveSettings.GetAnywhereCacheSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetAnywhereCacheRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callGetAnywhereCache);
            Modify_GetAnywhereCacheApiCall(ref _callGetAnywhereCache);
            _callListAnywhereCaches = clientHelper.BuildApiCall<ListAnywhereCachesRequest, ListAnywhereCachesResponse>("ListAnywhereCaches", grpcClient.ListAnywhereCachesAsync, grpcClient.ListAnywhereCaches, effectiveSettings.ListAnywhereCachesSettings).WithGoogleRequestParam("bucket", request => request.Parent);
            Modify_ApiCall(ref _callListAnywhereCaches);
            Modify_ListAnywhereCachesApiCall(ref _callListAnywhereCaches);
            _callGetProjectIntelligenceConfig = clientHelper.BuildApiCall<GetProjectIntelligenceConfigRequest, IntelligenceConfig>("GetProjectIntelligenceConfig", grpcClient.GetProjectIntelligenceConfigAsync, grpcClient.GetProjectIntelligenceConfig, effectiveSettings.GetProjectIntelligenceConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProjectIntelligenceConfig);
            Modify_GetProjectIntelligenceConfigApiCall(ref _callGetProjectIntelligenceConfig);
            _callUpdateProjectIntelligenceConfig = clientHelper.BuildApiCall<UpdateProjectIntelligenceConfigRequest, IntelligenceConfig>("UpdateProjectIntelligenceConfig", grpcClient.UpdateProjectIntelligenceConfigAsync, grpcClient.UpdateProjectIntelligenceConfig, effectiveSettings.UpdateProjectIntelligenceConfigSettings).WithGoogleRequestParam("intelligence_config.name", request => request.IntelligenceConfig?.Name);
            Modify_ApiCall(ref _callUpdateProjectIntelligenceConfig);
            Modify_UpdateProjectIntelligenceConfigApiCall(ref _callUpdateProjectIntelligenceConfig);
            _callGetFolderIntelligenceConfig = clientHelper.BuildApiCall<GetFolderIntelligenceConfigRequest, IntelligenceConfig>("GetFolderIntelligenceConfig", grpcClient.GetFolderIntelligenceConfigAsync, grpcClient.GetFolderIntelligenceConfig, effectiveSettings.GetFolderIntelligenceConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFolderIntelligenceConfig);
            Modify_GetFolderIntelligenceConfigApiCall(ref _callGetFolderIntelligenceConfig);
            _callUpdateFolderIntelligenceConfig = clientHelper.BuildApiCall<UpdateFolderIntelligenceConfigRequest, IntelligenceConfig>("UpdateFolderIntelligenceConfig", grpcClient.UpdateFolderIntelligenceConfigAsync, grpcClient.UpdateFolderIntelligenceConfig, effectiveSettings.UpdateFolderIntelligenceConfigSettings).WithGoogleRequestParam("intelligence_config.name", request => request.IntelligenceConfig?.Name);
            Modify_ApiCall(ref _callUpdateFolderIntelligenceConfig);
            Modify_UpdateFolderIntelligenceConfigApiCall(ref _callUpdateFolderIntelligenceConfig);
            _callGetOrganizationIntelligenceConfig = clientHelper.BuildApiCall<GetOrganizationIntelligenceConfigRequest, IntelligenceConfig>("GetOrganizationIntelligenceConfig", grpcClient.GetOrganizationIntelligenceConfigAsync, grpcClient.GetOrganizationIntelligenceConfig, effectiveSettings.GetOrganizationIntelligenceConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOrganizationIntelligenceConfig);
            Modify_GetOrganizationIntelligenceConfigApiCall(ref _callGetOrganizationIntelligenceConfig);
            _callUpdateOrganizationIntelligenceConfig = clientHelper.BuildApiCall<UpdateOrganizationIntelligenceConfigRequest, IntelligenceConfig>("UpdateOrganizationIntelligenceConfig", grpcClient.UpdateOrganizationIntelligenceConfigAsync, grpcClient.UpdateOrganizationIntelligenceConfig, effectiveSettings.UpdateOrganizationIntelligenceConfigSettings).WithGoogleRequestParam("intelligence_config.name", request => request.IntelligenceConfig?.Name);
            Modify_ApiCall(ref _callUpdateOrganizationIntelligenceConfig);
            Modify_UpdateOrganizationIntelligenceConfigApiCall(ref _callUpdateOrganizationIntelligenceConfig);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateFolderApiCall(ref gaxgrpc::ApiCall<CreateFolderRequest, Folder> call);

        partial void Modify_DeleteFolderApiCall(ref gaxgrpc::ApiCall<DeleteFolderRequest, wkt::Empty> call);

        partial void Modify_GetFolderApiCall(ref gaxgrpc::ApiCall<GetFolderRequest, Folder> call);

        partial void Modify_ListFoldersApiCall(ref gaxgrpc::ApiCall<ListFoldersRequest, ListFoldersResponse> call);

        partial void Modify_RenameFolderApiCall(ref gaxgrpc::ApiCall<RenameFolderRequest, lro::Operation> call);

        partial void Modify_GetStorageLayoutApiCall(ref gaxgrpc::ApiCall<GetStorageLayoutRequest, StorageLayout> call);

        partial void Modify_CreateManagedFolderApiCall(ref gaxgrpc::ApiCall<CreateManagedFolderRequest, ManagedFolder> call);

        partial void Modify_DeleteManagedFolderApiCall(ref gaxgrpc::ApiCall<DeleteManagedFolderRequest, wkt::Empty> call);

        partial void Modify_GetManagedFolderApiCall(ref gaxgrpc::ApiCall<GetManagedFolderRequest, ManagedFolder> call);

        partial void Modify_ListManagedFoldersApiCall(ref gaxgrpc::ApiCall<ListManagedFoldersRequest, ListManagedFoldersResponse> call);

        partial void Modify_CreateAnywhereCacheApiCall(ref gaxgrpc::ApiCall<CreateAnywhereCacheRequest, lro::Operation> call);

        partial void Modify_UpdateAnywhereCacheApiCall(ref gaxgrpc::ApiCall<UpdateAnywhereCacheRequest, lro::Operation> call);

        partial void Modify_DisableAnywhereCacheApiCall(ref gaxgrpc::ApiCall<DisableAnywhereCacheRequest, AnywhereCache> call);

        partial void Modify_PauseAnywhereCacheApiCall(ref gaxgrpc::ApiCall<PauseAnywhereCacheRequest, AnywhereCache> call);

        partial void Modify_ResumeAnywhereCacheApiCall(ref gaxgrpc::ApiCall<ResumeAnywhereCacheRequest, AnywhereCache> call);

        partial void Modify_GetAnywhereCacheApiCall(ref gaxgrpc::ApiCall<GetAnywhereCacheRequest, AnywhereCache> call);

        partial void Modify_ListAnywhereCachesApiCall(ref gaxgrpc::ApiCall<ListAnywhereCachesRequest, ListAnywhereCachesResponse> call);

        partial void Modify_GetProjectIntelligenceConfigApiCall(ref gaxgrpc::ApiCall<GetProjectIntelligenceConfigRequest, IntelligenceConfig> call);

        partial void Modify_UpdateProjectIntelligenceConfigApiCall(ref gaxgrpc::ApiCall<UpdateProjectIntelligenceConfigRequest, IntelligenceConfig> call);

        partial void Modify_GetFolderIntelligenceConfigApiCall(ref gaxgrpc::ApiCall<GetFolderIntelligenceConfigRequest, IntelligenceConfig> call);

        partial void Modify_UpdateFolderIntelligenceConfigApiCall(ref gaxgrpc::ApiCall<UpdateFolderIntelligenceConfigRequest, IntelligenceConfig> call);

        partial void Modify_GetOrganizationIntelligenceConfigApiCall(ref gaxgrpc::ApiCall<GetOrganizationIntelligenceConfigRequest, IntelligenceConfig> call);

        partial void Modify_UpdateOrganizationIntelligenceConfigApiCall(ref gaxgrpc::ApiCall<UpdateOrganizationIntelligenceConfigRequest, IntelligenceConfig> call);

        partial void OnConstruction(StorageControl.StorageControlClient grpcClient, StorageControlSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC StorageControl client</summary>
        public override StorageControl.StorageControlClient GrpcClient { get; }

        partial void Modify_CreateFolderRequest(ref CreateFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFolderRequest(ref DeleteFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFolderRequest(ref GetFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFoldersRequest(ref ListFoldersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RenameFolderRequest(ref RenameFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetStorageLayoutRequest(ref GetStorageLayoutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateManagedFolderRequest(ref CreateManagedFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteManagedFolderRequest(ref DeleteManagedFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetManagedFolderRequest(ref GetManagedFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListManagedFoldersRequest(ref ListManagedFoldersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAnywhereCacheRequest(ref CreateAnywhereCacheRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAnywhereCacheRequest(ref UpdateAnywhereCacheRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DisableAnywhereCacheRequest(ref DisableAnywhereCacheRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PauseAnywhereCacheRequest(ref PauseAnywhereCacheRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResumeAnywhereCacheRequest(ref ResumeAnywhereCacheRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAnywhereCacheRequest(ref GetAnywhereCacheRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAnywhereCachesRequest(ref ListAnywhereCachesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProjectIntelligenceConfigRequest(ref GetProjectIntelligenceConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateProjectIntelligenceConfigRequest(ref UpdateProjectIntelligenceConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFolderIntelligenceConfigRequest(ref GetFolderIntelligenceConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFolderIntelligenceConfigRequest(ref UpdateFolderIntelligenceConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetOrganizationIntelligenceConfigRequest(ref GetOrganizationIntelligenceConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateOrganizationIntelligenceConfigRequest(ref UpdateOrganizationIntelligenceConfigRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Folder CreateFolder(CreateFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_CreateFolderRequest(ref request, ref callSettings);
            return _callCreateFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Folder> CreateFolderAsync(CreateFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_CreateFolderRequest(ref request, ref callSettings);
            return _callCreateFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteFolder(DeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_DeleteFolderRequest(ref request, ref callSettings);
            _callDeleteFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteFolderAsync(DeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_DeleteFolderRequest(ref request, ref callSettings);
            return _callDeleteFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Folder GetFolder(GetFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_GetFolderRequest(ref request, ref callSettings);
            return _callGetFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Folder> GetFolderAsync(GetFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_GetFolderRequest(ref request, ref callSettings);
            return _callGetFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of folders. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Folder"/> resources.</returns>
        public override gax::PagedEnumerable<ListFoldersResponse, Folder> ListFolders(ListFoldersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFoldersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFoldersRequest, ListFoldersResponse, Folder>(_callListFolders, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of folders. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Folder"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFoldersResponse, Folder> ListFoldersAsync(ListFoldersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFoldersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFoldersRequest, ListFoldersResponse, Folder>(_callListFolders, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RenameFolder</c>.</summary>
        public override lro::OperationsClient RenameFolderOperationsClient { get; }

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Folder, RenameFolderMetadata> RenameFolder(RenameFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_RenameFolderRequest(ref request, ref callSettings);
            return new lro::Operation<Folder, RenameFolderMetadata>(_callRenameFolder.Sync(request, callSettings), RenameFolderOperationsClient);
        }

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Folder, RenameFolderMetadata>> RenameFolderAsync(RenameFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_RenameFolderRequest(ref request, ref callSettings);
            return new lro::Operation<Folder, RenameFolderMetadata>(await _callRenameFolder.Async(request, callSettings).ConfigureAwait(false), RenameFolderOperationsClient);
        }

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StorageLayout GetStorageLayout(GetStorageLayoutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_GetStorageLayoutRequest(ref request, ref callSettings);
            return _callGetStorageLayout.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StorageLayout> GetStorageLayoutAsync(GetStorageLayoutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_GetStorageLayoutRequest(ref request, ref callSettings);
            return _callGetStorageLayout.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ManagedFolder CreateManagedFolder(CreateManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_CreateManagedFolderRequest(ref request, ref callSettings);
            return _callCreateManagedFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ManagedFolder> CreateManagedFolderAsync(CreateManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_CreateManagedFolderRequest(ref request, ref callSettings);
            return _callCreateManagedFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteManagedFolder(DeleteManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_DeleteManagedFolderRequest(ref request, ref callSettings);
            _callDeleteManagedFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteManagedFolderAsync(DeleteManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_DeleteManagedFolderRequest(ref request, ref callSettings);
            return _callDeleteManagedFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ManagedFolder GetManagedFolder(GetManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_GetManagedFolderRequest(ref request, ref callSettings);
            return _callGetManagedFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ManagedFolder> GetManagedFolderAsync(GetManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_GetManagedFolderRequest(ref request, ref callSettings);
            return _callGetManagedFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of managed folders for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ManagedFolder"/> resources.</returns>
        public override gax::PagedEnumerable<ListManagedFoldersResponse, ManagedFolder> ListManagedFolders(ListManagedFoldersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_ListManagedFoldersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListManagedFoldersRequest, ListManagedFoldersResponse, ManagedFolder>(_callListManagedFolders, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of managed folders for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ManagedFolder"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListManagedFoldersResponse, ManagedFolder> ListManagedFoldersAsync(ListManagedFoldersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_ListManagedFoldersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListManagedFoldersRequest, ListManagedFoldersResponse, ManagedFolder>(_callListManagedFolders, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAnywhereCache</c>.</summary>
        public override lro::OperationsClient CreateAnywhereCacheOperationsClient { get; }

        /// <summary>
        /// Creates an Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AnywhereCache, CreateAnywhereCacheMetadata> CreateAnywhereCache(CreateAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_CreateAnywhereCacheRequest(ref request, ref callSettings);
            return new lro::Operation<AnywhereCache, CreateAnywhereCacheMetadata>(_callCreateAnywhereCache.Sync(request, callSettings), CreateAnywhereCacheOperationsClient);
        }

        /// <summary>
        /// Creates an Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AnywhereCache, CreateAnywhereCacheMetadata>> CreateAnywhereCacheAsync(CreateAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_CreateAnywhereCacheRequest(ref request, ref callSettings);
            return new lro::Operation<AnywhereCache, CreateAnywhereCacheMetadata>(await _callCreateAnywhereCache.Async(request, callSettings).ConfigureAwait(false), CreateAnywhereCacheOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAnywhereCache</c>.</summary>
        public override lro::OperationsClient UpdateAnywhereCacheOperationsClient { get; }

        /// <summary>
        /// Updates an Anywhere Cache instance. Mutable fields include `ttl` and
        /// `admission_policy`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AnywhereCache, UpdateAnywhereCacheMetadata> UpdateAnywhereCache(UpdateAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_UpdateAnywhereCacheRequest(ref request, ref callSettings);
            return new lro::Operation<AnywhereCache, UpdateAnywhereCacheMetadata>(_callUpdateAnywhereCache.Sync(request, callSettings), UpdateAnywhereCacheOperationsClient);
        }

        /// <summary>
        /// Updates an Anywhere Cache instance. Mutable fields include `ttl` and
        /// `admission_policy`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AnywhereCache, UpdateAnywhereCacheMetadata>> UpdateAnywhereCacheAsync(UpdateAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_UpdateAnywhereCacheRequest(ref request, ref callSettings);
            return new lro::Operation<AnywhereCache, UpdateAnywhereCacheMetadata>(await _callUpdateAnywhereCache.Async(request, callSettings).ConfigureAwait(false), UpdateAnywhereCacheOperationsClient);
        }

        /// <summary>
        /// Disables an Anywhere Cache instance. A disabled instance is read-only. The
        /// disablement could be revoked by calling ResumeAnywhereCache. The cache
        /// instance will be deleted automatically if it remains in the disabled state
        /// for at least one hour.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnywhereCache DisableAnywhereCache(DisableAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_DisableAnywhereCacheRequest(ref request, ref callSettings);
            return _callDisableAnywhereCache.Sync(request, callSettings);
        }

        /// <summary>
        /// Disables an Anywhere Cache instance. A disabled instance is read-only. The
        /// disablement could be revoked by calling ResumeAnywhereCache. The cache
        /// instance will be deleted automatically if it remains in the disabled state
        /// for at least one hour.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnywhereCache> DisableAnywhereCacheAsync(DisableAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_DisableAnywhereCacheRequest(ref request, ref callSettings);
            return _callDisableAnywhereCache.Async(request, callSettings);
        }

        /// <summary>
        /// Pauses an Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnywhereCache PauseAnywhereCache(PauseAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_PauseAnywhereCacheRequest(ref request, ref callSettings);
            return _callPauseAnywhereCache.Sync(request, callSettings);
        }

        /// <summary>
        /// Pauses an Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnywhereCache> PauseAnywhereCacheAsync(PauseAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_PauseAnywhereCacheRequest(ref request, ref callSettings);
            return _callPauseAnywhereCache.Async(request, callSettings);
        }

        /// <summary>
        /// Resumes a disabled or paused Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnywhereCache ResumeAnywhereCache(ResumeAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_ResumeAnywhereCacheRequest(ref request, ref callSettings);
            return _callResumeAnywhereCache.Sync(request, callSettings);
        }

        /// <summary>
        /// Resumes a disabled or paused Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnywhereCache> ResumeAnywhereCacheAsync(ResumeAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_ResumeAnywhereCacheRequest(ref request, ref callSettings);
            return _callResumeAnywhereCache.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnywhereCache GetAnywhereCache(GetAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_GetAnywhereCacheRequest(ref request, ref callSettings);
            return _callGetAnywhereCache.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an Anywhere Cache instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnywhereCache> GetAnywhereCacheAsync(GetAnywhereCacheRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_GetAnywhereCacheRequest(ref request, ref callSettings);
            return _callGetAnywhereCache.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Anywhere Cache instances for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnywhereCache"/> resources.</returns>
        public override gax::PagedEnumerable<ListAnywhereCachesResponse, AnywhereCache> ListAnywhereCaches(ListAnywhereCachesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_ListAnywhereCachesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAnywhereCachesRequest, ListAnywhereCachesResponse, AnywhereCache>(_callListAnywhereCaches, request, callSettings);
        }

        /// <summary>
        /// Lists Anywhere Cache instances for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnywhereCache"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAnywhereCachesResponse, AnywhereCache> ListAnywhereCachesAsync(ListAnywhereCachesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_ListAnywhereCachesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAnywhereCachesRequest, ListAnywhereCachesResponse, AnywhereCache>(_callListAnywhereCaches, request, callSettings);
        }

        /// <summary>
        /// Returns the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IntelligenceConfig GetProjectIntelligenceConfig(GetProjectIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProjectIntelligenceConfigRequest(ref request, ref callSettings);
            return _callGetProjectIntelligenceConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IntelligenceConfig> GetProjectIntelligenceConfigAsync(GetProjectIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProjectIntelligenceConfigRequest(ref request, ref callSettings);
            return _callGetProjectIntelligenceConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IntelligenceConfig UpdateProjectIntelligenceConfig(UpdateProjectIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProjectIntelligenceConfigRequest(ref request, ref callSettings);
            return _callUpdateProjectIntelligenceConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the Project scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IntelligenceConfig> UpdateProjectIntelligenceConfigAsync(UpdateProjectIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProjectIntelligenceConfigRequest(ref request, ref callSettings);
            return _callUpdateProjectIntelligenceConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IntelligenceConfig GetFolderIntelligenceConfig(GetFolderIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFolderIntelligenceConfigRequest(ref request, ref callSettings);
            return _callGetFolderIntelligenceConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IntelligenceConfig> GetFolderIntelligenceConfigAsync(GetFolderIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFolderIntelligenceConfigRequest(ref request, ref callSettings);
            return _callGetFolderIntelligenceConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IntelligenceConfig UpdateFolderIntelligenceConfig(UpdateFolderIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFolderIntelligenceConfigRequest(ref request, ref callSettings);
            return _callUpdateFolderIntelligenceConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the Folder scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IntelligenceConfig> UpdateFolderIntelligenceConfigAsync(UpdateFolderIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFolderIntelligenceConfigRequest(ref request, ref callSettings);
            return _callUpdateFolderIntelligenceConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IntelligenceConfig GetOrganizationIntelligenceConfig(GetOrganizationIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrganizationIntelligenceConfigRequest(ref request, ref callSettings);
            return _callGetOrganizationIntelligenceConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IntelligenceConfig> GetOrganizationIntelligenceConfigAsync(GetOrganizationIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrganizationIntelligenceConfigRequest(ref request, ref callSettings);
            return _callGetOrganizationIntelligenceConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IntelligenceConfig UpdateOrganizationIntelligenceConfig(UpdateOrganizationIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOrganizationIntelligenceConfigRequest(ref request, ref callSettings);
            return _callUpdateOrganizationIntelligenceConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the Organization scoped singleton IntelligenceConfig resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IntelligenceConfig> UpdateOrganizationIntelligenceConfigAsync(UpdateOrganizationIntelligenceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOrganizationIntelligenceConfigRequest(ref request, ref callSettings);
            return _callUpdateOrganizationIntelligenceConfig.Async(request, callSettings);
        }
    }

    public partial class ListFoldersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListManagedFoldersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAnywhereCachesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFoldersResponse : gaxgrpc::IPageResponse<Folder>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Folder> GetEnumerator() => Folders.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListManagedFoldersResponse : gaxgrpc::IPageResponse<ManagedFolder>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ManagedFolder> GetEnumerator() => ManagedFolders.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAnywhereCachesResponse : gaxgrpc::IPageResponse<AnywhereCache>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AnywhereCache> GetEnumerator() => AnywhereCaches.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class StorageControl
    {
        public partial class StorageControlClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
