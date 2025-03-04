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
using gcbcv = Google.Cloud.Bigtable.Common.V2;
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.Bigtable.Admin.V2
{
    /// <summary>Settings for <see cref="BigtableInstanceAdminClient"/> instances.</summary>
    public sealed partial class BigtableInstanceAdminSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BigtableInstanceAdminSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BigtableInstanceAdminSettings"/>.</returns>
        public static BigtableInstanceAdminSettings GetDefault() => new BigtableInstanceAdminSettings();

        /// <summary>
        /// Constructs a new <see cref="BigtableInstanceAdminSettings"/> object with default settings.
        /// </summary>
        public BigtableInstanceAdminSettings()
        {
        }

        private BigtableInstanceAdminSettings(BigtableInstanceAdminSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateInstanceSettings = existing.CreateInstanceSettings;
            CreateInstanceOperationsSettings = existing.CreateInstanceOperationsSettings.Clone();
            GetInstanceSettings = existing.GetInstanceSettings;
            ListInstancesSettings = existing.ListInstancesSettings;
            UpdateInstanceSettings = existing.UpdateInstanceSettings;
            PartialUpdateInstanceSettings = existing.PartialUpdateInstanceSettings;
            PartialUpdateInstanceOperationsSettings = existing.PartialUpdateInstanceOperationsSettings.Clone();
            DeleteInstanceSettings = existing.DeleteInstanceSettings;
            CreateClusterSettings = existing.CreateClusterSettings;
            CreateClusterOperationsSettings = existing.CreateClusterOperationsSettings.Clone();
            GetClusterSettings = existing.GetClusterSettings;
            ListClustersSettings = existing.ListClustersSettings;
            UpdateClusterSettings = existing.UpdateClusterSettings;
            UpdateClusterOperationsSettings = existing.UpdateClusterOperationsSettings.Clone();
            PartialUpdateClusterSettings = existing.PartialUpdateClusterSettings;
            PartialUpdateClusterOperationsSettings = existing.PartialUpdateClusterOperationsSettings.Clone();
            DeleteClusterSettings = existing.DeleteClusterSettings;
            CreateAppProfileSettings = existing.CreateAppProfileSettings;
            GetAppProfileSettings = existing.GetAppProfileSettings;
            ListAppProfilesSettings = existing.ListAppProfilesSettings;
            UpdateAppProfileSettings = existing.UpdateAppProfileSettings;
            UpdateAppProfileOperationsSettings = existing.UpdateAppProfileOperationsSettings.Clone();
            DeleteAppProfileSettings = existing.DeleteAppProfileSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            ListHotTabletsSettings = existing.ListHotTabletsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BigtableInstanceAdminSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.CreateInstance</c> and <c>BigtableInstanceAdminClient.CreateInstanceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.CreateInstance</c> and
        /// <c>BigtableInstanceAdminClient.CreateInstanceAsync</c>.
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
        public lro::OperationsSettings CreateInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.GetInstance</c> and <c>BigtableInstanceAdminClient.GetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstanceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.ListInstances</c> and <c>BigtableInstanceAdminClient.ListInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstancesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.UpdateInstance</c> and <c>BigtableInstanceAdminClient.UpdateInstanceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInstanceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.PartialUpdateInstance</c> and
        /// <c>BigtableInstanceAdminClient.PartialUpdateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PartialUpdateInstanceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.PartialUpdateInstance</c> and
        /// <c>BigtableInstanceAdminClient.PartialUpdateInstanceAsync</c>.
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
        public lro::OperationsSettings PartialUpdateInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.DeleteInstance</c> and <c>BigtableInstanceAdminClient.DeleteInstanceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.CreateCluster</c> and <c>BigtableInstanceAdminClient.CreateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.CreateCluster</c> and
        /// <c>BigtableInstanceAdminClient.CreateClusterAsync</c>.
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
        public lro::OperationsSettings CreateClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.GetCluster</c> and <c>BigtableInstanceAdminClient.GetClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.ListClusters</c> and <c>BigtableInstanceAdminClient.ListClustersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListClustersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.UpdateCluster</c> and <c>BigtableInstanceAdminClient.UpdateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.UpdateCluster</c> and
        /// <c>BigtableInstanceAdminClient.UpdateClusterAsync</c>.
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
        public lro::OperationsSettings UpdateClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.PartialUpdateCluster</c> and
        /// <c>BigtableInstanceAdminClient.PartialUpdateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PartialUpdateClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.PartialUpdateCluster</c> and
        /// <c>BigtableInstanceAdminClient.PartialUpdateClusterAsync</c>.
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
        public lro::OperationsSettings PartialUpdateClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.DeleteCluster</c> and <c>BigtableInstanceAdminClient.DeleteClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.CreateAppProfile</c> and <c>BigtableInstanceAdminClient.CreateAppProfileAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAppProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.GetAppProfile</c> and <c>BigtableInstanceAdminClient.GetAppProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAppProfileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.ListAppProfiles</c> and <c>BigtableInstanceAdminClient.ListAppProfilesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAppProfilesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.UpdateAppProfile</c> and <c>BigtableInstanceAdminClient.UpdateAppProfileAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAppProfileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.UpdateAppProfile</c> and
        /// <c>BigtableInstanceAdminClient.UpdateAppProfileAsync</c>.
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
        public lro::OperationsSettings UpdateAppProfileOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.DeleteAppProfile</c> and <c>BigtableInstanceAdminClient.DeleteAppProfileAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAppProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.GetIamPolicy</c> and <c>BigtableInstanceAdminClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.SetIamPolicy</c> and <c>BigtableInstanceAdminClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.TestIamPermissions</c> and
        /// <c>BigtableInstanceAdminClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.ListHotTablets</c> and <c>BigtableInstanceAdminClient.ListHotTabletsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListHotTabletsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BigtableInstanceAdminSettings"/> object.</returns>
        public BigtableInstanceAdminSettings Clone() => new BigtableInstanceAdminSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BigtableInstanceAdminClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class BigtableInstanceAdminClientBuilder : gaxgrpc::ClientBuilderBase<BigtableInstanceAdminClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BigtableInstanceAdminSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BigtableInstanceAdminClientBuilder() : base(BigtableInstanceAdminClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BigtableInstanceAdminClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BigtableInstanceAdminClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BigtableInstanceAdminClient Build()
        {
            BigtableInstanceAdminClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BigtableInstanceAdminClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BigtableInstanceAdminClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BigtableInstanceAdminClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BigtableInstanceAdminClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BigtableInstanceAdminClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BigtableInstanceAdminClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BigtableInstanceAdminClient.ChannelPool;
    }

    /// <summary>BigtableInstanceAdmin client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for creating, configuring, and deleting Cloud Bigtable Instances and
    /// Clusters. Provides access to the Instance and Cluster schemas only, not the
    /// tables' metadata or data stored in those tables.
    /// </remarks>
    public abstract partial class BigtableInstanceAdminClient
    {
        /// <summary>
        /// The default endpoint for the BigtableInstanceAdmin service, which is a host of
        /// "bigtableadmin.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "bigtableadmin.googleapis.com:443";

        /// <summary>The default BigtableInstanceAdmin scopes.</summary>
        /// <remarks>
        /// The default BigtableInstanceAdmin scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/bigtable.admin</description></item>
        /// <item><description>https://www.googleapis.com/auth/bigtable.admin.cluster</description></item>
        /// <item><description>https://www.googleapis.com/auth/bigtable.admin.instance</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-bigtable.admin</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-bigtable.admin.cluster</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/bigtable.admin",
            "https://www.googleapis.com/auth/bigtable.admin.cluster",
            "https://www.googleapis.com/auth/bigtable.admin.instance",
            "https://www.googleapis.com/auth/cloud-bigtable.admin",
            "https://www.googleapis.com/auth/cloud-bigtable.admin.cluster",
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BigtableInstanceAdmin.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BigtableInstanceAdminClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BigtableInstanceAdminClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BigtableInstanceAdminClient"/>.</returns>
        public static stt::Task<BigtableInstanceAdminClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BigtableInstanceAdminClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BigtableInstanceAdminClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BigtableInstanceAdminClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BigtableInstanceAdminClient"/>.</returns>
        public static BigtableInstanceAdminClient Create() => new BigtableInstanceAdminClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BigtableInstanceAdminClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BigtableInstanceAdminSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BigtableInstanceAdminClient"/>.</returns>
        internal static BigtableInstanceAdminClient Create(grpccore::CallInvoker callInvoker, BigtableInstanceAdminSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BigtableInstanceAdmin.BigtableInstanceAdminClient grpcClient = new BigtableInstanceAdmin.BigtableInstanceAdminClient(callInvoker);
            return new BigtableInstanceAdminClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BigtableInstanceAdmin client</summary>
        public virtual BigtableInstanceAdmin.BigtableInstanceAdminClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create an instance within a project.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, CreateInstanceMetadata> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an instance within a project.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an instance within a project.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(CreateInstanceRequest request, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateInstance</c>.</summary>
        public virtual lro::OperationsClient CreateInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, CreateInstanceMetadata> PollOnceCreateInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, CreateInstanceMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> PollOnceCreateInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, CreateInstanceMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Create an instance within a project.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the project in which to create the new
        /// instance. Values are of the form `projects/{project}`.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID to be used when referring to the new instance within its
        /// project, e.g., just `myinstance` rather than
        /// `projects/myproject/instances/myinstance`.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="clusters">
        /// Required. The clusters to be created within the instance, mapped by desired
        /// cluster ID, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, CreateInstanceMetadata> CreateInstance(string parent, string instanceId, Instance instance, scg::IDictionary<string, Cluster> clusters, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                Clusters =
                {
                    gax::GaxPreconditions.CheckNotNull(clusters, nameof(clusters)),
                },
            }, callSettings);

        /// <summary>
        /// Create an instance within a project.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the project in which to create the new
        /// instance. Values are of the form `projects/{project}`.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID to be used when referring to the new instance within its
        /// project, e.g., just `myinstance` rather than
        /// `projects/myproject/instances/myinstance`.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="clusters">
        /// Required. The clusters to be created within the instance, mapped by desired
        /// cluster ID, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(string parent, string instanceId, Instance instance, scg::IDictionary<string, Cluster> clusters, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                Clusters =
                {
                    gax::GaxPreconditions.CheckNotNull(clusters, nameof(clusters)),
                },
            }, callSettings);

        /// <summary>
        /// Create an instance within a project.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the project in which to create the new
        /// instance. Values are of the form `projects/{project}`.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID to be used when referring to the new instance within its
        /// project, e.g., just `myinstance` rather than
        /// `projects/myproject/instances/myinstance`.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="clusters">
        /// Required. The clusters to be created within the instance, mapped by desired
        /// cluster ID, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(string parent, string instanceId, Instance instance, scg::IDictionary<string, Cluster> clusters, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instanceId, instance, clusters, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an instance within a project.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the project in which to create the new
        /// instance. Values are of the form `projects/{project}`.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID to be used when referring to the new instance within its
        /// project, e.g., just `myinstance` rather than
        /// `projects/myproject/instances/myinstance`.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="clusters">
        /// Required. The clusters to be created within the instance, mapped by desired
        /// cluster ID, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, CreateInstanceMetadata> CreateInstance(gagr::ProjectName parent, string instanceId, Instance instance, scg::IDictionary<string, Cluster> clusters, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                Clusters =
                {
                    gax::GaxPreconditions.CheckNotNull(clusters, nameof(clusters)),
                },
            }, callSettings);

        /// <summary>
        /// Create an instance within a project.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the project in which to create the new
        /// instance. Values are of the form `projects/{project}`.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID to be used when referring to the new instance within its
        /// project, e.g., just `myinstance` rather than
        /// `projects/myproject/instances/myinstance`.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="clusters">
        /// Required. The clusters to be created within the instance, mapped by desired
        /// cluster ID, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(gagr::ProjectName parent, string instanceId, Instance instance, scg::IDictionary<string, Cluster> clusters, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                Clusters =
                {
                    gax::GaxPreconditions.CheckNotNull(clusters, nameof(clusters)),
                },
            }, callSettings);

        /// <summary>
        /// Create an instance within a project.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the project in which to create the new
        /// instance. Values are of the form `projects/{project}`.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID to be used when referring to the new instance within its
        /// project, e.g., just `myinstance` rather than
        /// `projects/myproject/instances/myinstance`.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="clusters">
        /// Required. The clusters to be created within the instance, mapped by desired
        /// cluster ID, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(gagr::ProjectName parent, string instanceId, Instance instance, scg::IDictionary<string, Cluster> clusters, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instanceId, instance, clusters, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested instance. Values are of the form
        /// `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested instance. Values are of the form
        /// `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested instance. Values are of the form
        /// `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested instance. Values are of the form
        /// `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(gcbcv::InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested instance. Values are of the form
        /// `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(gcbcv::InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested instance. Values are of the form
        /// `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(gcbcv::InstanceName name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListInstancesResponse ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request, st::CancellationToken cancellationToken) =>
            ListInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the project for which a list of instances is
        /// requested. Values are of the form `projects/{project}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListInstancesResponse ListInstances(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListInstances(new ListInstancesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the project for which a list of instances is
        /// requested. Values are of the form `projects/{project}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListInstancesResponse> ListInstancesAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListInstancesAsync(new ListInstancesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the project for which a list of instances is
        /// requested. Values are of the form `projects/{project}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListInstancesResponse> ListInstancesAsync(string parent, st::CancellationToken cancellationToken) =>
            ListInstancesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the project for which a list of instances is
        /// requested. Values are of the form `projects/{project}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListInstancesResponse ListInstances(gagr::ProjectName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListInstances(new ListInstancesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the project for which a list of instances is
        /// requested. Values are of the form `projects/{project}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListInstancesResponse> ListInstancesAsync(gagr::ProjectName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListInstancesAsync(new ListInstancesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the project for which a list of instances is
        /// requested. Values are of the form `projects/{project}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListInstancesResponse> ListInstancesAsync(gagr::ProjectName parent, st::CancellationToken cancellationToken) =>
            ListInstancesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an instance within a project. This method updates only the display
        /// name and type for an Instance. To update other Instance properties, such as
        /// labels, use PartialUpdateInstance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance UpdateInstance(Instance request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an instance within a project. This method updates only the display
        /// name and type for an Instance. To update other Instance properties, such as
        /// labels, use PartialUpdateInstance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> UpdateInstanceAsync(Instance request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an instance within a project. This method updates only the display
        /// name and type for an Instance. To update other Instance properties, such as
        /// labels, use PartialUpdateInstance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> UpdateInstanceAsync(Instance request, st::CancellationToken cancellationToken) =>
            UpdateInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Partially updates an instance within a project. This method can modify all
        /// fields of an Instance and is the preferred way to update an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, UpdateInstanceMetadata> PartialUpdateInstance(PartialUpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Partially updates an instance within a project. This method can modify all
        /// fields of an Instance and is the preferred way to update an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> PartialUpdateInstanceAsync(PartialUpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Partially updates an instance within a project. This method can modify all
        /// fields of an Instance and is the preferred way to update an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> PartialUpdateInstanceAsync(PartialUpdateInstanceRequest request, st::CancellationToken cancellationToken) =>
            PartialUpdateInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PartialUpdateInstance</c>.</summary>
        public virtual lro::OperationsClient PartialUpdateInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PartialUpdateInstance</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, UpdateInstanceMetadata> PollOncePartialUpdateInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, UpdateInstanceMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PartialUpdateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PartialUpdateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> PollOncePartialUpdateInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, UpdateInstanceMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PartialUpdateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Partially updates an instance within a project. This method can modify all
        /// fields of an Instance and is the preferred way to update an Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The Instance which will (partially) replace the current value.
        /// </param>
        /// <param name="updateMask">
        /// Required. The subset of Instance fields which should be replaced.
        /// Must be explicitly set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, UpdateInstanceMetadata> PartialUpdateInstance(Instance instance, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            PartialUpdateInstance(new PartialUpdateInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Partially updates an instance within a project. This method can modify all
        /// fields of an Instance and is the preferred way to update an Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The Instance which will (partially) replace the current value.
        /// </param>
        /// <param name="updateMask">
        /// Required. The subset of Instance fields which should be replaced.
        /// Must be explicitly set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> PartialUpdateInstanceAsync(Instance instance, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            PartialUpdateInstanceAsync(new PartialUpdateInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Partially updates an instance within a project. This method can modify all
        /// fields of an Instance and is the preferred way to update an Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The Instance which will (partially) replace the current value.
        /// </param>
        /// <param name="updateMask">
        /// Required. The subset of Instance fields which should be replaced.
        /// Must be explicitly set.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> PartialUpdateInstanceAsync(Instance instance, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            PartialUpdateInstanceAsync(instance, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstanceAsync(DeleteInstanceRequest request, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to be deleted.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to be deleted.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to be deleted.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to be deleted.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteInstance(gcbcv::InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to be deleted.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstanceAsync(gcbcv::InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to be deleted.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstanceAsync(gcbcv::InstanceName name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a cluster within an instance.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, CreateClusterMetadata> CreateCluster(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a cluster within an instance.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a cluster within an instance.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(CreateClusterRequest request, st::CancellationToken cancellationToken) =>
            CreateClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCluster</c>.</summary>
        public virtual lro::OperationsClient CreateClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, CreateClusterMetadata> PollOnceCreateCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, CreateClusterMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, CreateClusterMetadata>> PollOnceCreateClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, CreateClusterMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateClusterOperationsClient, callSettings);

        /// <summary>
        /// Creates a cluster within an instance.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the new
        /// cluster. Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="clusterId">
        /// Required. The ID to be used when referring to the new cluster within its
        /// instance, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </param>
        /// <param name="cluster">
        /// Required. The cluster to be created.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, CreateClusterMetadata> CreateCluster(string parent, string clusterId, Cluster cluster, gaxgrpc::CallSettings callSettings = null) =>
            CreateCluster(new CreateClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a cluster within an instance.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the new
        /// cluster. Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="clusterId">
        /// Required. The ID to be used when referring to the new cluster within its
        /// instance, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </param>
        /// <param name="cluster">
        /// Required. The cluster to be created.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(string parent, string clusterId, Cluster cluster, gaxgrpc::CallSettings callSettings = null) =>
            CreateClusterAsync(new CreateClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a cluster within an instance.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the new
        /// cluster. Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="clusterId">
        /// Required. The ID to be used when referring to the new cluster within its
        /// instance, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </param>
        /// <param name="cluster">
        /// Required. The cluster to be created.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(string parent, string clusterId, Cluster cluster, st::CancellationToken cancellationToken) =>
            CreateClusterAsync(parent, clusterId, cluster, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a cluster within an instance.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the new
        /// cluster. Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="clusterId">
        /// Required. The ID to be used when referring to the new cluster within its
        /// instance, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </param>
        /// <param name="cluster">
        /// Required. The cluster to be created.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, CreateClusterMetadata> CreateCluster(gcbcv::InstanceName parent, string clusterId, Cluster cluster, gaxgrpc::CallSettings callSettings = null) =>
            CreateCluster(new CreateClusterRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a cluster within an instance.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the new
        /// cluster. Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="clusterId">
        /// Required. The ID to be used when referring to the new cluster within its
        /// instance, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </param>
        /// <param name="cluster">
        /// Required. The cluster to be created.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(gcbcv::InstanceName parent, string clusterId, Cluster cluster, gaxgrpc::CallSettings callSettings = null) =>
            CreateClusterAsync(new CreateClusterRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a cluster within an instance.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the new
        /// cluster. Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="clusterId">
        /// Required. The ID to be used when referring to the new cluster within its
        /// instance, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </param>
        /// <param name="cluster">
        /// Required. The cluster to be created.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(gcbcv::InstanceName parent, string clusterId, Cluster cluster, st::CancellationToken cancellationToken) =>
            CreateClusterAsync(parent, clusterId, cluster, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, st::CancellationToken cancellationToken) =>
            GetClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested cluster. Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCluster(new GetClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested cluster. Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetClusterAsync(new GetClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested cluster. Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(string name, st::CancellationToken cancellationToken) =>
            GetClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested cluster. Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCluster(new GetClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested cluster. Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetClusterAsync(new GetClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested cluster. Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(ClusterName name, st::CancellationToken cancellationToken) =>
            GetClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListClustersResponse ListClusters(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, st::CancellationToken cancellationToken) =>
            ListClustersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance for which a list of clusters is
        /// requested. Values are of the form
        /// `projects/{project}/instances/{instance}`. Use `{instance} = '-'` to list
        /// Clusters for all Instances in a project, e.g.,
        /// `projects/myproject/instances/-`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListClustersResponse ListClusters(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListClusters(new ListClustersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance for which a list of clusters is
        /// requested. Values are of the form
        /// `projects/{project}/instances/{instance}`. Use `{instance} = '-'` to list
        /// Clusters for all Instances in a project, e.g.,
        /// `projects/myproject/instances/-`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListClustersResponse> ListClustersAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListClustersAsync(new ListClustersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance for which a list of clusters is
        /// requested. Values are of the form
        /// `projects/{project}/instances/{instance}`. Use `{instance} = '-'` to list
        /// Clusters for all Instances in a project, e.g.,
        /// `projects/myproject/instances/-`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListClustersResponse> ListClustersAsync(string parent, st::CancellationToken cancellationToken) =>
            ListClustersAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance for which a list of clusters is
        /// requested. Values are of the form
        /// `projects/{project}/instances/{instance}`. Use `{instance} = '-'` to list
        /// Clusters for all Instances in a project, e.g.,
        /// `projects/myproject/instances/-`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListClustersResponse ListClusters(gcbcv::InstanceName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListClusters(new ListClustersRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance for which a list of clusters is
        /// requested. Values are of the form
        /// `projects/{project}/instances/{instance}`. Use `{instance} = '-'` to list
        /// Clusters for all Instances in a project, e.g.,
        /// `projects/myproject/instances/-`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListClustersResponse> ListClustersAsync(gcbcv::InstanceName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListClustersAsync(new ListClustersRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance for which a list of clusters is
        /// requested. Values are of the form
        /// `projects/{project}/instances/{instance}`. Use `{instance} = '-'` to list
        /// Clusters for all Instances in a project, e.g.,
        /// `projects/myproject/instances/-`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListClustersResponse> ListClustersAsync(gcbcv::InstanceName parent, st::CancellationToken cancellationToken) =>
            ListClustersAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a cluster within an instance.
        /// 
        /// Note that UpdateCluster does not support updating
        /// cluster_config.cluster_autoscaling_config. In order to update it, you
        /// must use PartialUpdateCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, UpdateClusterMetadata> UpdateCluster(Cluster request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a cluster within an instance.
        /// 
        /// Note that UpdateCluster does not support updating
        /// cluster_config.cluster_autoscaling_config. In order to update it, you
        /// must use PartialUpdateCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, UpdateClusterMetadata>> UpdateClusterAsync(Cluster request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a cluster within an instance.
        /// 
        /// Note that UpdateCluster does not support updating
        /// cluster_config.cluster_autoscaling_config. In order to update it, you
        /// must use PartialUpdateCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, UpdateClusterMetadata>> UpdateClusterAsync(Cluster request, st::CancellationToken cancellationToken) =>
            UpdateClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateCluster</c>.</summary>
        public virtual lro::OperationsClient UpdateClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, UpdateClusterMetadata> PollOnceUpdateCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, UpdateClusterMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, UpdateClusterMetadata>> PollOnceUpdateClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, UpdateClusterMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateClusterOperationsClient, callSettings);

        /// <summary>
        /// Partially updates a cluster within a project. This method is the preferred
        /// way to update a Cluster.
        /// 
        /// To enable and update autoscaling, set
        /// cluster_config.cluster_autoscaling_config. When autoscaling is enabled,
        /// serve_nodes is treated as an OUTPUT_ONLY field, meaning that updates to it
        /// are ignored. Note that an update cannot simultaneously set serve_nodes to
        /// non-zero and cluster_config.cluster_autoscaling_config to non-empty, and
        /// also specify both in the update_mask.
        /// 
        /// To disable autoscaling, clear cluster_config.cluster_autoscaling_config,
        /// and explicitly set a serve_node count via the update_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, PartialUpdateClusterMetadata> PartialUpdateCluster(PartialUpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Partially updates a cluster within a project. This method is the preferred
        /// way to update a Cluster.
        /// 
        /// To enable and update autoscaling, set
        /// cluster_config.cluster_autoscaling_config. When autoscaling is enabled,
        /// serve_nodes is treated as an OUTPUT_ONLY field, meaning that updates to it
        /// are ignored. Note that an update cannot simultaneously set serve_nodes to
        /// non-zero and cluster_config.cluster_autoscaling_config to non-empty, and
        /// also specify both in the update_mask.
        /// 
        /// To disable autoscaling, clear cluster_config.cluster_autoscaling_config,
        /// and explicitly set a serve_node count via the update_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, PartialUpdateClusterMetadata>> PartialUpdateClusterAsync(PartialUpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Partially updates a cluster within a project. This method is the preferred
        /// way to update a Cluster.
        /// 
        /// To enable and update autoscaling, set
        /// cluster_config.cluster_autoscaling_config. When autoscaling is enabled,
        /// serve_nodes is treated as an OUTPUT_ONLY field, meaning that updates to it
        /// are ignored. Note that an update cannot simultaneously set serve_nodes to
        /// non-zero and cluster_config.cluster_autoscaling_config to non-empty, and
        /// also specify both in the update_mask.
        /// 
        /// To disable autoscaling, clear cluster_config.cluster_autoscaling_config,
        /// and explicitly set a serve_node count via the update_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, PartialUpdateClusterMetadata>> PartialUpdateClusterAsync(PartialUpdateClusterRequest request, st::CancellationToken cancellationToken) =>
            PartialUpdateClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PartialUpdateCluster</c>.</summary>
        public virtual lro::OperationsClient PartialUpdateClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PartialUpdateCluster</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, PartialUpdateClusterMetadata> PollOncePartialUpdateCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, PartialUpdateClusterMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PartialUpdateClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PartialUpdateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, PartialUpdateClusterMetadata>> PollOncePartialUpdateClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, PartialUpdateClusterMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PartialUpdateClusterOperationsClient, callSettings);

        /// <summary>
        /// Partially updates a cluster within a project. This method is the preferred
        /// way to update a Cluster.
        /// 
        /// To enable and update autoscaling, set
        /// cluster_config.cluster_autoscaling_config. When autoscaling is enabled,
        /// serve_nodes is treated as an OUTPUT_ONLY field, meaning that updates to it
        /// are ignored. Note that an update cannot simultaneously set serve_nodes to
        /// non-zero and cluster_config.cluster_autoscaling_config to non-empty, and
        /// also specify both in the update_mask.
        /// 
        /// To disable autoscaling, clear cluster_config.cluster_autoscaling_config,
        /// and explicitly set a serve_node count via the update_mask.
        /// </summary>
        /// <param name="cluster">
        /// Required. The Cluster which contains the partial updates to be applied,
        /// subject to the update_mask.
        /// </param>
        /// <param name="updateMask">
        /// Required. The subset of Cluster fields which should be replaced.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, PartialUpdateClusterMetadata> PartialUpdateCluster(Cluster cluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            PartialUpdateCluster(new PartialUpdateClusterRequest
            {
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Partially updates a cluster within a project. This method is the preferred
        /// way to update a Cluster.
        /// 
        /// To enable and update autoscaling, set
        /// cluster_config.cluster_autoscaling_config. When autoscaling is enabled,
        /// serve_nodes is treated as an OUTPUT_ONLY field, meaning that updates to it
        /// are ignored. Note that an update cannot simultaneously set serve_nodes to
        /// non-zero and cluster_config.cluster_autoscaling_config to non-empty, and
        /// also specify both in the update_mask.
        /// 
        /// To disable autoscaling, clear cluster_config.cluster_autoscaling_config,
        /// and explicitly set a serve_node count via the update_mask.
        /// </summary>
        /// <param name="cluster">
        /// Required. The Cluster which contains the partial updates to be applied,
        /// subject to the update_mask.
        /// </param>
        /// <param name="updateMask">
        /// Required. The subset of Cluster fields which should be replaced.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, PartialUpdateClusterMetadata>> PartialUpdateClusterAsync(Cluster cluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            PartialUpdateClusterAsync(new PartialUpdateClusterRequest
            {
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Partially updates a cluster within a project. This method is the preferred
        /// way to update a Cluster.
        /// 
        /// To enable and update autoscaling, set
        /// cluster_config.cluster_autoscaling_config. When autoscaling is enabled,
        /// serve_nodes is treated as an OUTPUT_ONLY field, meaning that updates to it
        /// are ignored. Note that an update cannot simultaneously set serve_nodes to
        /// non-zero and cluster_config.cluster_autoscaling_config to non-empty, and
        /// also specify both in the update_mask.
        /// 
        /// To disable autoscaling, clear cluster_config.cluster_autoscaling_config,
        /// and explicitly set a serve_node count via the update_mask.
        /// </summary>
        /// <param name="cluster">
        /// Required. The Cluster which contains the partial updates to be applied,
        /// subject to the update_mask.
        /// </param>
        /// <param name="updateMask">
        /// Required. The subset of Cluster fields which should be replaced.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, PartialUpdateClusterMetadata>> PartialUpdateClusterAsync(Cluster cluster, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            PartialUpdateClusterAsync(cluster, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCluster(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteClusterAsync(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteClusterAsync(DeleteClusterRequest request, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the cluster to be deleted. Values are of the
        /// form `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCluster(new DeleteClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the cluster to be deleted. Values are of the
        /// form `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClusterAsync(new DeleteClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the cluster to be deleted. Values are of the
        /// form `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteClusterAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the cluster to be deleted. Values are of the
        /// form `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCluster(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCluster(new DeleteClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the cluster to be deleted. Values are of the
        /// form `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteClusterAsync(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClusterAsync(new DeleteClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the cluster to be deleted. Values are of the
        /// form `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteClusterAsync(ClusterName name, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppProfile CreateAppProfile(CreateAppProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppProfile> CreateAppProfileAsync(CreateAppProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppProfile> CreateAppProfileAsync(CreateAppProfileRequest request, st::CancellationToken cancellationToken) =>
            CreateAppProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the new app
        /// profile. Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="appProfileId">
        /// Required. The ID to be used when referring to the new app profile within
        /// its instance, e.g., just `myprofile` rather than
        /// `projects/myproject/instances/myinstance/appProfiles/myprofile`.
        /// </param>
        /// <param name="appProfile">
        /// Required. The app profile to be created.
        /// Fields marked `OutputOnly` will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppProfile CreateAppProfile(string parent, string appProfileId, AppProfile appProfile, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppProfile(new CreateAppProfileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AppProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(appProfileId, nameof(appProfileId)),
                AppProfile = gax::GaxPreconditions.CheckNotNull(appProfile, nameof(appProfile)),
            }, callSettings);

        /// <summary>
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the new app
        /// profile. Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="appProfileId">
        /// Required. The ID to be used when referring to the new app profile within
        /// its instance, e.g., just `myprofile` rather than
        /// `projects/myproject/instances/myinstance/appProfiles/myprofile`.
        /// </param>
        /// <param name="appProfile">
        /// Required. The app profile to be created.
        /// Fields marked `OutputOnly` will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppProfile> CreateAppProfileAsync(string parent, string appProfileId, AppProfile appProfile, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppProfileAsync(new CreateAppProfileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AppProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(appProfileId, nameof(appProfileId)),
                AppProfile = gax::GaxPreconditions.CheckNotNull(appProfile, nameof(appProfile)),
            }, callSettings);

        /// <summary>
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the new app
        /// profile. Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="appProfileId">
        /// Required. The ID to be used when referring to the new app profile within
        /// its instance, e.g., just `myprofile` rather than
        /// `projects/myproject/instances/myinstance/appProfiles/myprofile`.
        /// </param>
        /// <param name="appProfile">
        /// Required. The app profile to be created.
        /// Fields marked `OutputOnly` will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppProfile> CreateAppProfileAsync(string parent, string appProfileId, AppProfile appProfile, st::CancellationToken cancellationToken) =>
            CreateAppProfileAsync(parent, appProfileId, appProfile, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the new app
        /// profile. Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="appProfileId">
        /// Required. The ID to be used when referring to the new app profile within
        /// its instance, e.g., just `myprofile` rather than
        /// `projects/myproject/instances/myinstance/appProfiles/myprofile`.
        /// </param>
        /// <param name="appProfile">
        /// Required. The app profile to be created.
        /// Fields marked `OutputOnly` will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppProfile CreateAppProfile(gcbcv::InstanceName parent, string appProfileId, AppProfile appProfile, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppProfile(new CreateAppProfileRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AppProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(appProfileId, nameof(appProfileId)),
                AppProfile = gax::GaxPreconditions.CheckNotNull(appProfile, nameof(appProfile)),
            }, callSettings);

        /// <summary>
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the new app
        /// profile. Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="appProfileId">
        /// Required. The ID to be used when referring to the new app profile within
        /// its instance, e.g., just `myprofile` rather than
        /// `projects/myproject/instances/myinstance/appProfiles/myprofile`.
        /// </param>
        /// <param name="appProfile">
        /// Required. The app profile to be created.
        /// Fields marked `OutputOnly` will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppProfile> CreateAppProfileAsync(gcbcv::InstanceName parent, string appProfileId, AppProfile appProfile, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppProfileAsync(new CreateAppProfileRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AppProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(appProfileId, nameof(appProfileId)),
                AppProfile = gax::GaxPreconditions.CheckNotNull(appProfile, nameof(appProfile)),
            }, callSettings);

        /// <summary>
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the new app
        /// profile. Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="appProfileId">
        /// Required. The ID to be used when referring to the new app profile within
        /// its instance, e.g., just `myprofile` rather than
        /// `projects/myproject/instances/myinstance/appProfiles/myprofile`.
        /// </param>
        /// <param name="appProfile">
        /// Required. The app profile to be created.
        /// Fields marked `OutputOnly` will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppProfile> CreateAppProfileAsync(gcbcv::InstanceName parent, string appProfileId, AppProfile appProfile, st::CancellationToken cancellationToken) =>
            CreateAppProfileAsync(parent, appProfileId, appProfile, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppProfile GetAppProfile(GetAppProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppProfile> GetAppProfileAsync(GetAppProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppProfile> GetAppProfileAsync(GetAppProfileRequest request, st::CancellationToken cancellationToken) =>
            GetAppProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested app profile. Values are of the
        /// form `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppProfile GetAppProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppProfile(new GetAppProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested app profile. Values are of the
        /// form `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppProfile> GetAppProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppProfileAsync(new GetAppProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested app profile. Values are of the
        /// form `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppProfile> GetAppProfileAsync(string name, st::CancellationToken cancellationToken) =>
            GetAppProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested app profile. Values are of the
        /// form `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppProfile GetAppProfile(AppProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppProfile(new GetAppProfileRequest
            {
                AppProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested app profile. Values are of the
        /// form `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppProfile> GetAppProfileAsync(AppProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppProfileAsync(new GetAppProfileRequest
            {
                AppProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested app profile. Values are of the
        /// form `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppProfile> GetAppProfileAsync(AppProfileName name, st::CancellationToken cancellationToken) =>
            GetAppProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AppProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfiles(ListAppProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AppProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfilesAsync(ListAppProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance for which a list of app profiles
        /// is requested. Values are of the form
        /// `projects/{project}/instances/{instance}`.
        /// Use `{instance} = '-'` to list AppProfiles for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
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
        /// <returns>A pageable sequence of <see cref="AppProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfiles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppProfilesRequest request = new ListAppProfilesRequest
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
            return ListAppProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance for which a list of app profiles
        /// is requested. Values are of the form
        /// `projects/{project}/instances/{instance}`.
        /// Use `{instance} = '-'` to list AppProfiles for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AppProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfilesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppProfilesRequest request = new ListAppProfilesRequest
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
            return ListAppProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance for which a list of app profiles
        /// is requested. Values are of the form
        /// `projects/{project}/instances/{instance}`.
        /// Use `{instance} = '-'` to list AppProfiles for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
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
        /// <returns>A pageable sequence of <see cref="AppProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfiles(gcbcv::InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppProfilesRequest request = new ListAppProfilesRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAppProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance for which a list of app profiles
        /// is requested. Values are of the form
        /// `projects/{project}/instances/{instance}`.
        /// Use `{instance} = '-'` to list AppProfiles for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AppProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfilesAsync(gcbcv::InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppProfilesRequest request = new ListAppProfilesRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAppProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Updates an app profile within an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AppProfile, UpdateAppProfileMetadata> UpdateAppProfile(UpdateAppProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an app profile within an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppProfile, UpdateAppProfileMetadata>> UpdateAppProfileAsync(UpdateAppProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an app profile within an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppProfile, UpdateAppProfileMetadata>> UpdateAppProfileAsync(UpdateAppProfileRequest request, st::CancellationToken cancellationToken) =>
            UpdateAppProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAppProfile</c>.</summary>
        public virtual lro::OperationsClient UpdateAppProfileOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAppProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AppProfile, UpdateAppProfileMetadata> PollOnceUpdateAppProfile(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AppProfile, UpdateAppProfileMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAppProfileOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAppProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AppProfile, UpdateAppProfileMetadata>> PollOnceUpdateAppProfileAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AppProfile, UpdateAppProfileMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAppProfileOperationsClient, callSettings);

        /// <summary>
        /// Updates an app profile within an instance.
        /// </summary>
        /// <param name="appProfile">
        /// Required. The app profile which will (partially) replace the current value.
        /// </param>
        /// <param name="updateMask">
        /// Required. The subset of app profile fields which should be replaced.
        /// If unset, all fields will be replaced.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AppProfile, UpdateAppProfileMetadata> UpdateAppProfile(AppProfile appProfile, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAppProfile(new UpdateAppProfileRequest
            {
                AppProfile = gax::GaxPreconditions.CheckNotNull(appProfile, nameof(appProfile)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an app profile within an instance.
        /// </summary>
        /// <param name="appProfile">
        /// Required. The app profile which will (partially) replace the current value.
        /// </param>
        /// <param name="updateMask">
        /// Required. The subset of app profile fields which should be replaced.
        /// If unset, all fields will be replaced.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppProfile, UpdateAppProfileMetadata>> UpdateAppProfileAsync(AppProfile appProfile, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAppProfileAsync(new UpdateAppProfileRequest
            {
                AppProfile = gax::GaxPreconditions.CheckNotNull(appProfile, nameof(appProfile)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an app profile within an instance.
        /// </summary>
        /// <param name="appProfile">
        /// Required. The app profile which will (partially) replace the current value.
        /// </param>
        /// <param name="updateMask">
        /// Required. The subset of app profile fields which should be replaced.
        /// If unset, all fields will be replaced.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppProfile, UpdateAppProfileMetadata>> UpdateAppProfileAsync(AppProfile appProfile, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAppProfileAsync(appProfile, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAppProfile(DeleteAppProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAppProfileAsync(DeleteAppProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAppProfileAsync(DeleteAppProfileRequest request, st::CancellationToken cancellationToken) =>
            DeleteAppProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the app profile to be deleted. Values are of
        /// the form
        /// `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAppProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppProfile(new DeleteAppProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the app profile to be deleted. Values are of
        /// the form
        /// `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAppProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppProfileAsync(new DeleteAppProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the app profile to be deleted. Values are of
        /// the form
        /// `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAppProfileAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAppProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the app profile to be deleted. Values are of
        /// the form
        /// `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAppProfile(AppProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppProfile(new DeleteAppProfileRequest
            {
                AppProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the app profile to be deleted. Values are of
        /// the form
        /// `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAppProfileAsync(AppProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppProfileAsync(new DeleteAppProfileRequest
            {
                AppProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the app profile to be deleted. Values are of
        /// the form
        /// `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAppProfileAsync(AppProfileName name, st::CancellationToken cancellationToken) =>
            DeleteAppProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the app profile to be deleted. Values are of
        /// the form
        /// `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
        /// </param>
        /// <param name="ignoreWarnings">
        /// Required. If true, ignore safety checks when deleting the app profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAppProfile(string name, bool ignoreWarnings, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppProfile(new DeleteAppProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                IgnoreWarnings = ignoreWarnings,
            }, callSettings);

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the app profile to be deleted. Values are of
        /// the form
        /// `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
        /// </param>
        /// <param name="ignoreWarnings">
        /// Required. If true, ignore safety checks when deleting the app profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAppProfileAsync(string name, bool ignoreWarnings, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppProfileAsync(new DeleteAppProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                IgnoreWarnings = ignoreWarnings,
            }, callSettings);

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the app profile to be deleted. Values are of
        /// the form
        /// `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
        /// </param>
        /// <param name="ignoreWarnings">
        /// Required. If true, ignore safety checks when deleting the app profile.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAppProfileAsync(string name, bool ignoreWarnings, st::CancellationToken cancellationToken) =>
            DeleteAppProfileAsync(name, ignoreWarnings, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the app profile to be deleted. Values are of
        /// the form
        /// `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
        /// </param>
        /// <param name="ignoreWarnings">
        /// Required. If true, ignore safety checks when deleting the app profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAppProfile(AppProfileName name, bool ignoreWarnings, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppProfile(new DeleteAppProfileRequest
            {
                AppProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                IgnoreWarnings = ignoreWarnings,
            }, callSettings);

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the app profile to be deleted. Values are of
        /// the form
        /// `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
        /// </param>
        /// <param name="ignoreWarnings">
        /// Required. If true, ignore safety checks when deleting the app profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAppProfileAsync(AppProfileName name, bool ignoreWarnings, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppProfileAsync(new DeleteAppProfileRequest
            {
                AppProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                IgnoreWarnings = ignoreWarnings,
            }, callSettings);

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the app profile to be deleted. Values are of
        /// the form
        /// `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
        /// </param>
        /// <param name="ignoreWarnings">
        /// Required. If true, ignore safety checks when deleting the app profile.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAppProfileAsync(AppProfileName name, bool ignoreWarnings, st::CancellationToken cancellationToken) =>
            DeleteAppProfileAsync(name, ignoreWarnings, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
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
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
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
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
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
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
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
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
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
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
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
        /// Returns permissions that the caller has on the specified instance resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that the caller has on the specified instance resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that the caller has on the specified instance resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// Lists hot tablets in a cluster, within the time range provided. Hot
        /// tablets are ordered based on CPU usage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HotTablet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHotTabletsResponse, HotTablet> ListHotTablets(ListHotTabletsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists hot tablets in a cluster, within the time range provided. Hot
        /// tablets are ordered based on CPU usage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HotTablet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHotTabletsResponse, HotTablet> ListHotTabletsAsync(ListHotTabletsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists hot tablets in a cluster, within the time range provided. Hot
        /// tablets are ordered based on CPU usage.
        /// </summary>
        /// <param name="parent">
        /// Required. The cluster name to list hot tablets.
        /// Value is in the following form:
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
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
        /// <returns>A pageable sequence of <see cref="HotTablet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHotTabletsResponse, HotTablet> ListHotTablets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHotTabletsRequest request = new ListHotTabletsRequest
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
            return ListHotTablets(request, callSettings);
        }

        /// <summary>
        /// Lists hot tablets in a cluster, within the time range provided. Hot
        /// tablets are ordered based on CPU usage.
        /// </summary>
        /// <param name="parent">
        /// Required. The cluster name to list hot tablets.
        /// Value is in the following form:
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="HotTablet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHotTabletsResponse, HotTablet> ListHotTabletsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHotTabletsRequest request = new ListHotTabletsRequest
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
            return ListHotTabletsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists hot tablets in a cluster, within the time range provided. Hot
        /// tablets are ordered based on CPU usage.
        /// </summary>
        /// <param name="parent">
        /// Required. The cluster name to list hot tablets.
        /// Value is in the following form:
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
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
        /// <returns>A pageable sequence of <see cref="HotTablet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHotTabletsResponse, HotTablet> ListHotTablets(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHotTabletsRequest request = new ListHotTabletsRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListHotTablets(request, callSettings);
        }

        /// <summary>
        /// Lists hot tablets in a cluster, within the time range provided. Hot
        /// tablets are ordered based on CPU usage.
        /// </summary>
        /// <param name="parent">
        /// Required. The cluster name to list hot tablets.
        /// Value is in the following form:
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="HotTablet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHotTabletsResponse, HotTablet> ListHotTabletsAsync(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHotTabletsRequest request = new ListHotTabletsRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListHotTabletsAsync(request, callSettings);
        }
    }

    /// <summary>BigtableInstanceAdmin client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for creating, configuring, and deleting Cloud Bigtable Instances and
    /// Clusters. Provides access to the Instance and Cluster schemas only, not the
    /// tables' metadata or data stored in those tables.
    /// </remarks>
    public sealed partial class BigtableInstanceAdminClientImpl : BigtableInstanceAdminClient
    {
        private readonly gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> _callCreateInstance;

        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGetInstance;

        private readonly gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;

        private readonly gaxgrpc::ApiCall<Instance, Instance> _callUpdateInstance;

        private readonly gaxgrpc::ApiCall<PartialUpdateInstanceRequest, lro::Operation> _callPartialUpdateInstance;

        private readonly gaxgrpc::ApiCall<DeleteInstanceRequest, wkt::Empty> _callDeleteInstance;

        private readonly gaxgrpc::ApiCall<CreateClusterRequest, lro::Operation> _callCreateCluster;

        private readonly gaxgrpc::ApiCall<GetClusterRequest, Cluster> _callGetCluster;

        private readonly gaxgrpc::ApiCall<ListClustersRequest, ListClustersResponse> _callListClusters;

        private readonly gaxgrpc::ApiCall<Cluster, lro::Operation> _callUpdateCluster;

        private readonly gaxgrpc::ApiCall<PartialUpdateClusterRequest, lro::Operation> _callPartialUpdateCluster;

        private readonly gaxgrpc::ApiCall<DeleteClusterRequest, wkt::Empty> _callDeleteCluster;

        private readonly gaxgrpc::ApiCall<CreateAppProfileRequest, AppProfile> _callCreateAppProfile;

        private readonly gaxgrpc::ApiCall<GetAppProfileRequest, AppProfile> _callGetAppProfile;

        private readonly gaxgrpc::ApiCall<ListAppProfilesRequest, ListAppProfilesResponse> _callListAppProfiles;

        private readonly gaxgrpc::ApiCall<UpdateAppProfileRequest, lro::Operation> _callUpdateAppProfile;

        private readonly gaxgrpc::ApiCall<DeleteAppProfileRequest, wkt::Empty> _callDeleteAppProfile;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        private readonly gaxgrpc::ApiCall<ListHotTabletsRequest, ListHotTabletsResponse> _callListHotTablets;

        /// <summary>
        /// Constructs a client wrapper for the BigtableInstanceAdmin service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BigtableInstanceAdminSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BigtableInstanceAdminClientImpl(BigtableInstanceAdmin.BigtableInstanceAdminClient grpcClient, BigtableInstanceAdminSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BigtableInstanceAdminSettings effectiveSettings = settings ?? BigtableInstanceAdminSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstanceOperationsSettings, logger);
            PartialUpdateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PartialUpdateInstanceOperationsSettings, logger);
            CreateClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateClusterOperationsSettings, logger);
            UpdateClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateClusterOperationsSettings, logger);
            PartialUpdateClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PartialUpdateClusterOperationsSettings, logger);
            UpdateAppProfileOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAppProfileOperationsSettings, logger);
            _callCreateInstance = clientHelper.BuildApiCall<CreateInstanceRequest, lro::Operation>("CreateInstance", grpcClient.CreateInstanceAsync, grpcClient.CreateInstance, effectiveSettings.CreateInstanceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInstance);
            Modify_CreateInstanceApiCall(ref _callCreateInstance);
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>("GetInstance", grpcClient.GetInstanceAsync, grpcClient.GetInstance, effectiveSettings.GetInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstance);
            Modify_GetInstanceApiCall(ref _callGetInstance);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>("ListInstances", grpcClient.ListInstancesAsync, grpcClient.ListInstances, effectiveSettings.ListInstancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            _callUpdateInstance = clientHelper.BuildApiCall<Instance, Instance>("UpdateInstance", grpcClient.UpdateInstanceAsync, grpcClient.UpdateInstance, effectiveSettings.UpdateInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateInstance);
            Modify_UpdateInstanceApiCall(ref _callUpdateInstance);
            _callPartialUpdateInstance = clientHelper.BuildApiCall<PartialUpdateInstanceRequest, lro::Operation>("PartialUpdateInstance", grpcClient.PartialUpdateInstanceAsync, grpcClient.PartialUpdateInstance, effectiveSettings.PartialUpdateInstanceSettings).WithGoogleRequestParam("instance.name", request => request.Instance?.Name);
            Modify_ApiCall(ref _callPartialUpdateInstance);
            Modify_PartialUpdateInstanceApiCall(ref _callPartialUpdateInstance);
            _callDeleteInstance = clientHelper.BuildApiCall<DeleteInstanceRequest, wkt::Empty>("DeleteInstance", grpcClient.DeleteInstanceAsync, grpcClient.DeleteInstance, effectiveSettings.DeleteInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInstance);
            Modify_DeleteInstanceApiCall(ref _callDeleteInstance);
            _callCreateCluster = clientHelper.BuildApiCall<CreateClusterRequest, lro::Operation>("CreateCluster", grpcClient.CreateClusterAsync, grpcClient.CreateCluster, effectiveSettings.CreateClusterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCluster);
            Modify_CreateClusterApiCall(ref _callCreateCluster);
            _callGetCluster = clientHelper.BuildApiCall<GetClusterRequest, Cluster>("GetCluster", grpcClient.GetClusterAsync, grpcClient.GetCluster, effectiveSettings.GetClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCluster);
            Modify_GetClusterApiCall(ref _callGetCluster);
            _callListClusters = clientHelper.BuildApiCall<ListClustersRequest, ListClustersResponse>("ListClusters", grpcClient.ListClustersAsync, grpcClient.ListClusters, effectiveSettings.ListClustersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListClusters);
            Modify_ListClustersApiCall(ref _callListClusters);
            _callUpdateCluster = clientHelper.BuildApiCall<Cluster, lro::Operation>("UpdateCluster", grpcClient.UpdateClusterAsync, grpcClient.UpdateCluster, effectiveSettings.UpdateClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateCluster);
            Modify_UpdateClusterApiCall(ref _callUpdateCluster);
            _callPartialUpdateCluster = clientHelper.BuildApiCall<PartialUpdateClusterRequest, lro::Operation>("PartialUpdateCluster", grpcClient.PartialUpdateClusterAsync, grpcClient.PartialUpdateCluster, effectiveSettings.PartialUpdateClusterSettings).WithGoogleRequestParam("cluster.name", request => request.Cluster?.Name);
            Modify_ApiCall(ref _callPartialUpdateCluster);
            Modify_PartialUpdateClusterApiCall(ref _callPartialUpdateCluster);
            _callDeleteCluster = clientHelper.BuildApiCall<DeleteClusterRequest, wkt::Empty>("DeleteCluster", grpcClient.DeleteClusterAsync, grpcClient.DeleteCluster, effectiveSettings.DeleteClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCluster);
            Modify_DeleteClusterApiCall(ref _callDeleteCluster);
            _callCreateAppProfile = clientHelper.BuildApiCall<CreateAppProfileRequest, AppProfile>("CreateAppProfile", grpcClient.CreateAppProfileAsync, grpcClient.CreateAppProfile, effectiveSettings.CreateAppProfileSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAppProfile);
            Modify_CreateAppProfileApiCall(ref _callCreateAppProfile);
            _callGetAppProfile = clientHelper.BuildApiCall<GetAppProfileRequest, AppProfile>("GetAppProfile", grpcClient.GetAppProfileAsync, grpcClient.GetAppProfile, effectiveSettings.GetAppProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAppProfile);
            Modify_GetAppProfileApiCall(ref _callGetAppProfile);
            _callListAppProfiles = clientHelper.BuildApiCall<ListAppProfilesRequest, ListAppProfilesResponse>("ListAppProfiles", grpcClient.ListAppProfilesAsync, grpcClient.ListAppProfiles, effectiveSettings.ListAppProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAppProfiles);
            Modify_ListAppProfilesApiCall(ref _callListAppProfiles);
            _callUpdateAppProfile = clientHelper.BuildApiCall<UpdateAppProfileRequest, lro::Operation>("UpdateAppProfile", grpcClient.UpdateAppProfileAsync, grpcClient.UpdateAppProfile, effectiveSettings.UpdateAppProfileSettings).WithGoogleRequestParam("app_profile.name", request => request.AppProfile?.Name);
            Modify_ApiCall(ref _callUpdateAppProfile);
            Modify_UpdateAppProfileApiCall(ref _callUpdateAppProfile);
            _callDeleteAppProfile = clientHelper.BuildApiCall<DeleteAppProfileRequest, wkt::Empty>("DeleteAppProfile", grpcClient.DeleteAppProfileAsync, grpcClient.DeleteAppProfile, effectiveSettings.DeleteAppProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAppProfile);
            Modify_DeleteAppProfileApiCall(ref _callDeleteAppProfile);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            _callListHotTablets = clientHelper.BuildApiCall<ListHotTabletsRequest, ListHotTabletsResponse>("ListHotTablets", grpcClient.ListHotTabletsAsync, grpcClient.ListHotTablets, effectiveSettings.ListHotTabletsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListHotTablets);
            Modify_ListHotTabletsApiCall(ref _callListHotTablets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateInstanceApiCall(ref gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> call);

        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);

        partial void Modify_UpdateInstanceApiCall(ref gaxgrpc::ApiCall<Instance, Instance> call);

        partial void Modify_PartialUpdateInstanceApiCall(ref gaxgrpc::ApiCall<PartialUpdateInstanceRequest, lro::Operation> call);

        partial void Modify_DeleteInstanceApiCall(ref gaxgrpc::ApiCall<DeleteInstanceRequest, wkt::Empty> call);

        partial void Modify_CreateClusterApiCall(ref gaxgrpc::ApiCall<CreateClusterRequest, lro::Operation> call);

        partial void Modify_GetClusterApiCall(ref gaxgrpc::ApiCall<GetClusterRequest, Cluster> call);

        partial void Modify_ListClustersApiCall(ref gaxgrpc::ApiCall<ListClustersRequest, ListClustersResponse> call);

        partial void Modify_UpdateClusterApiCall(ref gaxgrpc::ApiCall<Cluster, lro::Operation> call);

        partial void Modify_PartialUpdateClusterApiCall(ref gaxgrpc::ApiCall<PartialUpdateClusterRequest, lro::Operation> call);

        partial void Modify_DeleteClusterApiCall(ref gaxgrpc::ApiCall<DeleteClusterRequest, wkt::Empty> call);

        partial void Modify_CreateAppProfileApiCall(ref gaxgrpc::ApiCall<CreateAppProfileRequest, AppProfile> call);

        partial void Modify_GetAppProfileApiCall(ref gaxgrpc::ApiCall<GetAppProfileRequest, AppProfile> call);

        partial void Modify_ListAppProfilesApiCall(ref gaxgrpc::ApiCall<ListAppProfilesRequest, ListAppProfilesResponse> call);

        partial void Modify_UpdateAppProfileApiCall(ref gaxgrpc::ApiCall<UpdateAppProfileRequest, lro::Operation> call);

        partial void Modify_DeleteAppProfileApiCall(ref gaxgrpc::ApiCall<DeleteAppProfileRequest, wkt::Empty> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void Modify_ListHotTabletsApiCall(ref gaxgrpc::ApiCall<ListHotTabletsRequest, ListHotTabletsResponse> call);

        partial void OnConstruction(BigtableInstanceAdmin.BigtableInstanceAdminClient grpcClient, BigtableInstanceAdminSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BigtableInstanceAdmin client</summary>
        public override BigtableInstanceAdmin.BigtableInstanceAdminClient GrpcClient { get; }

        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_Instance(ref Instance request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PartialUpdateInstanceRequest(ref PartialUpdateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateClusterRequest(ref CreateClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetClusterRequest(ref GetClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListClustersRequest(ref ListClustersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_Cluster(ref Cluster request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PartialUpdateClusterRequest(ref PartialUpdateClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteClusterRequest(ref DeleteClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAppProfileRequest(ref CreateAppProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAppProfileRequest(ref GetAppProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAppProfilesRequest(ref ListAppProfilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAppProfileRequest(ref UpdateAppProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAppProfileRequest(ref DeleteAppProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListHotTabletsRequest(ref ListHotTabletsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateInstance</c>.</summary>
        public override lro::OperationsClient CreateInstanceOperationsClient { get; }

        /// <summary>
        /// Create an instance within a project.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, CreateInstanceMetadata> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, CreateInstanceMetadata>(_callCreateInstance.Sync(request, callSettings), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// Create an instance within a project.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, CreateInstanceMetadata>(await _callCreateInstance.Async(request, callSettings).ConfigureAwait(false), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Async(request, callSettings);
        }

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListInstancesResponse ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return _callListInstances.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return _callListInstances.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an instance within a project. This method updates only the display
        /// name and type for an Instance. To update other Instance properties, such as
        /// labels, use PartialUpdateInstance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Instance UpdateInstance(Instance request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Instance(ref request, ref callSettings);
            return _callUpdateInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an instance within a project. This method updates only the display
        /// name and type for an Instance. To update other Instance properties, such as
        /// labels, use PartialUpdateInstance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Instance> UpdateInstanceAsync(Instance request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Instance(ref request, ref callSettings);
            return _callUpdateInstance.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>PartialUpdateInstance</c>.</summary>
        public override lro::OperationsClient PartialUpdateInstanceOperationsClient { get; }

        /// <summary>
        /// Partially updates an instance within a project. This method can modify all
        /// fields of an Instance and is the preferred way to update an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, UpdateInstanceMetadata> PartialUpdateInstance(PartialUpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PartialUpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, UpdateInstanceMetadata>(_callPartialUpdateInstance.Sync(request, callSettings), PartialUpdateInstanceOperationsClient);
        }

        /// <summary>
        /// Partially updates an instance within a project. This method can modify all
        /// fields of an Instance and is the preferred way to update an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> PartialUpdateInstanceAsync(PartialUpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PartialUpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, UpdateInstanceMetadata>(await _callPartialUpdateInstance.Async(request, callSettings).ConfigureAwait(false), PartialUpdateInstanceOperationsClient);
        }

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            _callDeleteInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return _callDeleteInstance.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateCluster</c>.</summary>
        public override lro::OperationsClient CreateClusterOperationsClient { get; }

        /// <summary>
        /// Creates a cluster within an instance.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, CreateClusterMetadata> CreateCluster(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, CreateClusterMetadata>(_callCreateCluster.Sync(request, callSettings), CreateClusterOperationsClient);
        }

        /// <summary>
        /// Creates a cluster within an instance.
        /// 
        /// Note that exactly one of Cluster.serve_nodes and
        /// Cluster.cluster_config.cluster_autoscaling_config can be set. If
        /// serve_nodes is set to non-zero, then the cluster is manually scaled. If
        /// cluster_config.cluster_autoscaling_config is non-empty, then autoscaling is
        /// enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, CreateClusterMetadata>(await _callCreateCluster.Async(request, callSettings).ConfigureAwait(false), CreateClusterOperationsClient);
        }

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Cluster GetCluster(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListClustersResponse ListClusters(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return _callListClusters.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return _callListClusters.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateCluster</c>.</summary>
        public override lro::OperationsClient UpdateClusterOperationsClient { get; }

        /// <summary>
        /// Updates a cluster within an instance.
        /// 
        /// Note that UpdateCluster does not support updating
        /// cluster_config.cluster_autoscaling_config. In order to update it, you
        /// must use PartialUpdateCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, UpdateClusterMetadata> UpdateCluster(Cluster request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Cluster(ref request, ref callSettings);
            return new lro::Operation<Cluster, UpdateClusterMetadata>(_callUpdateCluster.Sync(request, callSettings), UpdateClusterOperationsClient);
        }

        /// <summary>
        /// Updates a cluster within an instance.
        /// 
        /// Note that UpdateCluster does not support updating
        /// cluster_config.cluster_autoscaling_config. In order to update it, you
        /// must use PartialUpdateCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, UpdateClusterMetadata>> UpdateClusterAsync(Cluster request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Cluster(ref request, ref callSettings);
            return new lro::Operation<Cluster, UpdateClusterMetadata>(await _callUpdateCluster.Async(request, callSettings).ConfigureAwait(false), UpdateClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>PartialUpdateCluster</c>.</summary>
        public override lro::OperationsClient PartialUpdateClusterOperationsClient { get; }

        /// <summary>
        /// Partially updates a cluster within a project. This method is the preferred
        /// way to update a Cluster.
        /// 
        /// To enable and update autoscaling, set
        /// cluster_config.cluster_autoscaling_config. When autoscaling is enabled,
        /// serve_nodes is treated as an OUTPUT_ONLY field, meaning that updates to it
        /// are ignored. Note that an update cannot simultaneously set serve_nodes to
        /// non-zero and cluster_config.cluster_autoscaling_config to non-empty, and
        /// also specify both in the update_mask.
        /// 
        /// To disable autoscaling, clear cluster_config.cluster_autoscaling_config,
        /// and explicitly set a serve_node count via the update_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, PartialUpdateClusterMetadata> PartialUpdateCluster(PartialUpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PartialUpdateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, PartialUpdateClusterMetadata>(_callPartialUpdateCluster.Sync(request, callSettings), PartialUpdateClusterOperationsClient);
        }

        /// <summary>
        /// Partially updates a cluster within a project. This method is the preferred
        /// way to update a Cluster.
        /// 
        /// To enable and update autoscaling, set
        /// cluster_config.cluster_autoscaling_config. When autoscaling is enabled,
        /// serve_nodes is treated as an OUTPUT_ONLY field, meaning that updates to it
        /// are ignored. Note that an update cannot simultaneously set serve_nodes to
        /// non-zero and cluster_config.cluster_autoscaling_config to non-empty, and
        /// also specify both in the update_mask.
        /// 
        /// To disable autoscaling, clear cluster_config.cluster_autoscaling_config,
        /// and explicitly set a serve_node count via the update_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, PartialUpdateClusterMetadata>> PartialUpdateClusterAsync(PartialUpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PartialUpdateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, PartialUpdateClusterMetadata>(await _callPartialUpdateCluster.Async(request, callSettings).ConfigureAwait(false), PartialUpdateClusterOperationsClient);
        }

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteCluster(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            _callDeleteCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteClusterAsync(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return _callDeleteCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AppProfile CreateAppProfile(CreateAppProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAppProfileRequest(ref request, ref callSettings);
            return _callCreateAppProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AppProfile> CreateAppProfileAsync(CreateAppProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAppProfileRequest(ref request, ref callSettings);
            return _callCreateAppProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AppProfile GetAppProfile(GetAppProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAppProfileRequest(ref request, ref callSettings);
            return _callGetAppProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AppProfile> GetAppProfileAsync(GetAppProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAppProfileRequest(ref request, ref callSettings);
            return _callGetAppProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AppProfile"/> resources.</returns>
        public override gax::PagedEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfiles(ListAppProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAppProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAppProfilesRequest, ListAppProfilesResponse, AppProfile>(_callListAppProfiles, request, callSettings);
        }

        /// <summary>
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AppProfile"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfilesAsync(ListAppProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAppProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAppProfilesRequest, ListAppProfilesResponse, AppProfile>(_callListAppProfiles, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateAppProfile</c>.</summary>
        public override lro::OperationsClient UpdateAppProfileOperationsClient { get; }

        /// <summary>
        /// Updates an app profile within an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AppProfile, UpdateAppProfileMetadata> UpdateAppProfile(UpdateAppProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAppProfileRequest(ref request, ref callSettings);
            return new lro::Operation<AppProfile, UpdateAppProfileMetadata>(_callUpdateAppProfile.Sync(request, callSettings), UpdateAppProfileOperationsClient);
        }

        /// <summary>
        /// Updates an app profile within an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AppProfile, UpdateAppProfileMetadata>> UpdateAppProfileAsync(UpdateAppProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAppProfileRequest(ref request, ref callSettings);
            return new lro::Operation<AppProfile, UpdateAppProfileMetadata>(await _callUpdateAppProfile.Async(request, callSettings).ConfigureAwait(false), UpdateAppProfileOperationsClient);
        }

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAppProfile(DeleteAppProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAppProfileRequest(ref request, ref callSettings);
            _callDeleteAppProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAppProfileAsync(DeleteAppProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAppProfileRequest(ref request, ref callSettings);
            return _callDeleteAppProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
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
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
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
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// Lists hot tablets in a cluster, within the time range provided. Hot
        /// tablets are ordered based on CPU usage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HotTablet"/> resources.</returns>
        public override gax::PagedEnumerable<ListHotTabletsResponse, HotTablet> ListHotTablets(ListHotTabletsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHotTabletsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListHotTabletsRequest, ListHotTabletsResponse, HotTablet>(_callListHotTablets, request, callSettings);
        }

        /// <summary>
        /// Lists hot tablets in a cluster, within the time range provided. Hot
        /// tablets are ordered based on CPU usage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HotTablet"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListHotTabletsResponse, HotTablet> ListHotTabletsAsync(ListHotTabletsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHotTabletsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListHotTabletsRequest, ListHotTabletsResponse, HotTablet>(_callListHotTablets, request, callSettings);
        }
    }

    public partial class ListAppProfilesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListHotTabletsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAppProfilesResponse : gaxgrpc::IPageResponse<AppProfile>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AppProfile> GetEnumerator() => AppProfiles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListHotTabletsResponse : gaxgrpc::IPageResponse<HotTablet>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<HotTablet> GetEnumerator() => HotTablets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class BigtableInstanceAdmin
    {
        public partial class BigtableInstanceAdminClient
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
