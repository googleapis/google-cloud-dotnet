// Copyright 2024 Google LLC
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

namespace Google.Cloud.Spanner.Admin.Instance.V1
{
    /// <summary>Settings for <see cref="InstanceAdminClient"/> instances.</summary>
    public sealed partial class InstanceAdminSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="InstanceAdminSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="InstanceAdminSettings"/>.</returns>
        public static InstanceAdminSettings GetDefault() => new InstanceAdminSettings();

        /// <summary>Constructs a new <see cref="InstanceAdminSettings"/> object with default settings.</summary>
        public InstanceAdminSettings()
        {
        }

        private InstanceAdminSettings(InstanceAdminSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListInstanceConfigsSettings = existing.ListInstanceConfigsSettings;
            GetInstanceConfigSettings = existing.GetInstanceConfigSettings;
            CreateInstanceConfigSettings = existing.CreateInstanceConfigSettings;
            CreateInstanceConfigOperationsSettings = existing.CreateInstanceConfigOperationsSettings.Clone();
            UpdateInstanceConfigSettings = existing.UpdateInstanceConfigSettings;
            UpdateInstanceConfigOperationsSettings = existing.UpdateInstanceConfigOperationsSettings.Clone();
            DeleteInstanceConfigSettings = existing.DeleteInstanceConfigSettings;
            ListInstanceConfigOperationsSettings = existing.ListInstanceConfigOperationsSettings;
            ListInstancesSettings = existing.ListInstancesSettings;
            ListInstancePartitionsSettings = existing.ListInstancePartitionsSettings;
            GetInstanceSettings = existing.GetInstanceSettings;
            CreateInstanceSettings = existing.CreateInstanceSettings;
            CreateInstanceOperationsSettings = existing.CreateInstanceOperationsSettings.Clone();
            UpdateInstanceSettings = existing.UpdateInstanceSettings;
            UpdateInstanceOperationsSettings = existing.UpdateInstanceOperationsSettings.Clone();
            DeleteInstanceSettings = existing.DeleteInstanceSettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            GetInstancePartitionSettings = existing.GetInstancePartitionSettings;
            CreateInstancePartitionSettings = existing.CreateInstancePartitionSettings;
            CreateInstancePartitionOperationsSettings = existing.CreateInstancePartitionOperationsSettings.Clone();
            DeleteInstancePartitionSettings = existing.DeleteInstancePartitionSettings;
            UpdateInstancePartitionSettings = existing.UpdateInstancePartitionSettings;
            UpdateInstancePartitionOperationsSettings = existing.UpdateInstancePartitionOperationsSettings.Clone();
            ListInstancePartitionOperationsSettings = existing.ListInstancePartitionOperationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(InstanceAdminSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.ListInstanceConfigs</c> and <c>InstanceAdminClient.ListInstanceConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstanceConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.GetInstanceConfig</c> and <c>InstanceAdminClient.GetInstanceConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstanceConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.CreateInstanceConfig</c> and <c>InstanceAdminClient.CreateInstanceConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInstanceConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstanceAdminClient.CreateInstanceConfig</c> and
        /// <c>InstanceAdminClient.CreateInstanceConfigAsync</c>.
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
        public lro::OperationsSettings CreateInstanceConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.UpdateInstanceConfig</c> and <c>InstanceAdminClient.UpdateInstanceConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInstanceConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstanceAdminClient.UpdateInstanceConfig</c> and
        /// <c>InstanceAdminClient.UpdateInstanceConfigAsync</c>.
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
        public lro::OperationsSettings UpdateInstanceConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.DeleteInstanceConfig</c> and <c>InstanceAdminClient.DeleteInstanceConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInstanceConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.ListInstanceConfigOperations</c> and
        /// <c>InstanceAdminClient.ListInstanceConfigOperationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstanceConfigOperationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.ListInstances</c> and <c>InstanceAdminClient.ListInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstancesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.ListInstancePartitions</c> and <c>InstanceAdminClient.ListInstancePartitionsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstancePartitionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.GetInstance</c> and <c>InstanceAdminClient.GetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstanceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.CreateInstance</c> and <c>InstanceAdminClient.CreateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstanceAdminClient.CreateInstance</c> and
        /// <c>InstanceAdminClient.CreateInstanceAsync</c>.
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
        /// <c>InstanceAdminClient.UpdateInstance</c> and <c>InstanceAdminClient.UpdateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstanceAdminClient.UpdateInstance</c> and
        /// <c>InstanceAdminClient.UpdateInstanceAsync</c>.
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
        public lro::OperationsSettings UpdateInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.DeleteInstance</c> and <c>InstanceAdminClient.DeleteInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInstanceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.SetIamPolicy</c> and <c>InstanceAdminClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.GetIamPolicy</c> and <c>InstanceAdminClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.TestIamPermissions</c> and <c>InstanceAdminClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.GetInstancePartition</c> and <c>InstanceAdminClient.GetInstancePartitionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstancePartitionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.CreateInstancePartition</c> and <c>InstanceAdminClient.CreateInstancePartitionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInstancePartitionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstanceAdminClient.CreateInstancePartition</c> and
        /// <c>InstanceAdminClient.CreateInstancePartitionAsync</c>.
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
        public lro::OperationsSettings CreateInstancePartitionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.DeleteInstancePartition</c> and <c>InstanceAdminClient.DeleteInstancePartitionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInstancePartitionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.UpdateInstancePartition</c> and <c>InstanceAdminClient.UpdateInstancePartitionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInstancePartitionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstanceAdminClient.UpdateInstancePartition</c> and
        /// <c>InstanceAdminClient.UpdateInstancePartitionAsync</c>.
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
        public lro::OperationsSettings UpdateInstancePartitionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.ListInstancePartitionOperations</c> and
        /// <c>InstanceAdminClient.ListInstancePartitionOperationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstancePartitionOperationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="InstanceAdminSettings"/> object.</returns>
        public InstanceAdminSettings Clone() => new InstanceAdminSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="InstanceAdminClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class InstanceAdminClientBuilder : gaxgrpc::ClientBuilderBase<InstanceAdminClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public InstanceAdminSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public InstanceAdminClientBuilder() : base(InstanceAdminClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref InstanceAdminClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<InstanceAdminClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override InstanceAdminClient Build()
        {
            InstanceAdminClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<InstanceAdminClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<InstanceAdminClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private InstanceAdminClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return InstanceAdminClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<InstanceAdminClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return InstanceAdminClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => InstanceAdminClient.ChannelPool;
    }

    /// <summary>InstanceAdmin client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Cloud Spanner Instance Admin API
    /// 
    /// The Cloud Spanner Instance Admin API can be used to create, delete,
    /// modify and list instances. Instances are dedicated Cloud Spanner serving
    /// and storage resources to be used by Cloud Spanner databases.
    /// 
    /// Each instance has a "configuration", which dictates where the
    /// serving resources for the Cloud Spanner instance are located (e.g.,
    /// US-central, Europe). Configurations are created by Google based on
    /// resource availability.
    /// 
    /// Cloud Spanner billing is based on the instances that exist and their
    /// sizes. After an instance exists, there are no additional
    /// per-database or per-operation charges for use of the instance
    /// (though there may be additional network bandwidth charges).
    /// Instances offer isolation: problems with databases in one instance
    /// will not affect other instances. However, within an instance
    /// databases can affect each other. For example, if one database in an
    /// instance receives a lot of requests and consumes most of the
    /// instance resources, fewer resources are available for other
    /// databases in that instance, and their performance may suffer.
    /// </remarks>
    public abstract partial class InstanceAdminClient
    {
        /// <summary>
        /// The default endpoint for the InstanceAdmin service, which is a host of "spanner.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "spanner.googleapis.com:443";

        /// <summary>The default InstanceAdmin scopes.</summary>
        /// <remarks>
        /// The default InstanceAdmin scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/spanner.admin</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/spanner.admin",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(InstanceAdmin.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="InstanceAdminClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="InstanceAdminClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="InstanceAdminClient"/>.</returns>
        public static stt::Task<InstanceAdminClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new InstanceAdminClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="InstanceAdminClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="InstanceAdminClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="InstanceAdminClient"/>.</returns>
        public static InstanceAdminClient Create() => new InstanceAdminClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="InstanceAdminClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="InstanceAdminSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="InstanceAdminClient"/>.</returns>
        internal static InstanceAdminClient Create(grpccore::CallInvoker callInvoker, InstanceAdminSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            InstanceAdmin.InstanceAdminClient grpcClient = new InstanceAdmin.InstanceAdminClient(callInvoker);
            return new InstanceAdminClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC InstanceAdmin client</summary>
        public virtual InstanceAdmin.InstanceAdminClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the supported instance configurations for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InstanceConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigs(ListInstanceConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the supported instance configurations for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigsAsync(ListInstanceConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the supported instance configurations for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which a list of supported instance
        /// configurations is requested. Values are of the form
        /// `projects/&lt;project&gt;`.
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
        /// <returns>A pageable sequence of <see cref="InstanceConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstanceConfigsRequest request = new ListInstanceConfigsRequest
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
            return ListInstanceConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists the supported instance configurations for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which a list of supported instance
        /// configurations is requested. Values are of the form
        /// `projects/&lt;project&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstanceConfigsRequest request = new ListInstanceConfigsRequest
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
            return ListInstanceConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the supported instance configurations for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which a list of supported instance
        /// configurations is requested. Values are of the form
        /// `projects/&lt;project&gt;`.
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
        /// <returns>A pageable sequence of <see cref="InstanceConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigs(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstanceConfigsRequest request = new ListInstanceConfigsRequest
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
            return ListInstanceConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists the supported instance configurations for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which a list of supported instance
        /// configurations is requested. Values are of the form
        /// `projects/&lt;project&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstanceConfigsRequest request = new ListInstanceConfigsRequest
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
            return ListInstanceConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a particular instance configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceConfig GetInstanceConfig(GetInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a particular instance configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceConfig> GetInstanceConfigAsync(GetInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a particular instance configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceConfig> GetInstanceConfigAsync(GetInstanceConfigRequest request, st::CancellationToken cancellationToken) =>
            GetInstanceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a particular instance configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance configuration. Values are of
        /// the form `projects/&lt;project&gt;/instanceConfigs/&lt;config&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceConfig GetInstanceConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceConfig(new GetInstanceConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a particular instance configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance configuration. Values are of
        /// the form `projects/&lt;project&gt;/instanceConfigs/&lt;config&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceConfig> GetInstanceConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceConfigAsync(new GetInstanceConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a particular instance configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance configuration. Values are of
        /// the form `projects/&lt;project&gt;/instanceConfigs/&lt;config&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceConfig> GetInstanceConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a particular instance configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance configuration. Values are of
        /// the form `projects/&lt;project&gt;/instanceConfigs/&lt;config&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceConfig GetInstanceConfig(InstanceConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceConfig(new GetInstanceConfigRequest
            {
                InstanceConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a particular instance configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance configuration. Values are of
        /// the form `projects/&lt;project&gt;/instanceConfigs/&lt;config&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceConfig> GetInstanceConfigAsync(InstanceConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceConfigAsync(new GetInstanceConfigRequest
            {
                InstanceConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a particular instance configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance configuration. Values are of
        /// the form `projects/&lt;project&gt;/instanceConfigs/&lt;config&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceConfig> GetInstanceConfigAsync(InstanceConfigName name, st::CancellationToken cancellationToken) =>
            GetInstanceConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an instance config and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance config. The instance config name is assigned by the caller. If the
        /// named instance config already exists, `CreateInstanceConfig` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config is readable via the API, with all requested
        /// attributes. The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true. Its state is `CREATING`.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation renders the instance config immediately
        /// unreadable via the API.
        /// * Except for deleting the creating resource, all other attempts to modify
        /// the instance config are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Instances can be created using the instance configuration.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false. Its state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// creation of the instance config. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceConfigMetadata][google.spanner.admin.instance.v1.CreateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.create` permission on
        /// the resource
        /// [parent][google.spanner.admin.instance.v1.CreateInstanceConfigRequest.parent].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InstanceConfig, CreateInstanceConfigMetadata> CreateInstanceConfig(CreateInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an instance config and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance config. The instance config name is assigned by the caller. If the
        /// named instance config already exists, `CreateInstanceConfig` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config is readable via the API, with all requested
        /// attributes. The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true. Its state is `CREATING`.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation renders the instance config immediately
        /// unreadable via the API.
        /// * Except for deleting the creating resource, all other attempts to modify
        /// the instance config are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Instances can be created using the instance configuration.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false. Its state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// creation of the instance config. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceConfigMetadata][google.spanner.admin.instance.v1.CreateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.create` permission on
        /// the resource
        /// [parent][google.spanner.admin.instance.v1.CreateInstanceConfigRequest.parent].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstanceConfig, CreateInstanceConfigMetadata>> CreateInstanceConfigAsync(CreateInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an instance config and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance config. The instance config name is assigned by the caller. If the
        /// named instance config already exists, `CreateInstanceConfig` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config is readable via the API, with all requested
        /// attributes. The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true. Its state is `CREATING`.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation renders the instance config immediately
        /// unreadable via the API.
        /// * Except for deleting the creating resource, all other attempts to modify
        /// the instance config are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Instances can be created using the instance configuration.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false. Its state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// creation of the instance config. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceConfigMetadata][google.spanner.admin.instance.v1.CreateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.create` permission on
        /// the resource
        /// [parent][google.spanner.admin.instance.v1.CreateInstanceConfigRequest.parent].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstanceConfig, CreateInstanceConfigMetadata>> CreateInstanceConfigAsync(CreateInstanceConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateInstanceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateInstanceConfig</c>.</summary>
        public virtual lro::OperationsClient CreateInstanceConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstanceConfig</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InstanceConfig, CreateInstanceConfigMetadata> PollOnceCreateInstanceConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InstanceConfig, CreateInstanceConfigMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInstanceConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InstanceConfig, CreateInstanceConfigMetadata>> PollOnceCreateInstanceConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InstanceConfig, CreateInstanceConfigMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceConfigOperationsClient, callSettings);

        /// <summary>
        /// Creates an instance config and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance config. The instance config name is assigned by the caller. If the
        /// named instance config already exists, `CreateInstanceConfig` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config is readable via the API, with all requested
        /// attributes. The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true. Its state is `CREATING`.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation renders the instance config immediately
        /// unreadable via the API.
        /// * Except for deleting the creating resource, all other attempts to modify
        /// the instance config are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Instances can be created using the instance configuration.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false. Its state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// creation of the instance config. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceConfigMetadata][google.spanner.admin.instance.v1.CreateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.create` permission on
        /// the resource
        /// [parent][google.spanner.admin.instance.v1.CreateInstanceConfigRequest.parent].
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the instance config.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceConfig">
        /// Required. The InstanceConfig proto of the configuration to create.
        /// instance_config.name must be
        /// `&lt;parent&gt;/instanceConfigs/&lt;instance_config_id&gt;`.
        /// instance_config.base_config must be a Google managed configuration name,
        /// e.g. &lt;parent&gt;/instanceConfigs/us-east1, &lt;parent&gt;/instanceConfigs/nam3.
        /// </param>
        /// <param name="instanceConfigId">
        /// Required. The ID of the instance config to create.  Valid identifiers are
        /// of the form `custom-[-a-z0-9]*[a-z0-9]` and must be between 2 and 64
        /// characters in length. The `custom-` prefix is required to avoid name
        /// conflicts with Google managed configurations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InstanceConfig, CreateInstanceConfigMetadata> CreateInstanceConfig(string parent, InstanceConfig instanceConfig, string instanceConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceConfig(new CreateInstanceConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceConfigId, nameof(instanceConfigId)),
                InstanceConfig = gax::GaxPreconditions.CheckNotNull(instanceConfig, nameof(instanceConfig)),
            }, callSettings);

        /// <summary>
        /// Creates an instance config and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance config. The instance config name is assigned by the caller. If the
        /// named instance config already exists, `CreateInstanceConfig` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config is readable via the API, with all requested
        /// attributes. The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true. Its state is `CREATING`.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation renders the instance config immediately
        /// unreadable via the API.
        /// * Except for deleting the creating resource, all other attempts to modify
        /// the instance config are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Instances can be created using the instance configuration.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false. Its state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// creation of the instance config. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceConfigMetadata][google.spanner.admin.instance.v1.CreateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.create` permission on
        /// the resource
        /// [parent][google.spanner.admin.instance.v1.CreateInstanceConfigRequest.parent].
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the instance config.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceConfig">
        /// Required. The InstanceConfig proto of the configuration to create.
        /// instance_config.name must be
        /// `&lt;parent&gt;/instanceConfigs/&lt;instance_config_id&gt;`.
        /// instance_config.base_config must be a Google managed configuration name,
        /// e.g. &lt;parent&gt;/instanceConfigs/us-east1, &lt;parent&gt;/instanceConfigs/nam3.
        /// </param>
        /// <param name="instanceConfigId">
        /// Required. The ID of the instance config to create.  Valid identifiers are
        /// of the form `custom-[-a-z0-9]*[a-z0-9]` and must be between 2 and 64
        /// characters in length. The `custom-` prefix is required to avoid name
        /// conflicts with Google managed configurations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstanceConfig, CreateInstanceConfigMetadata>> CreateInstanceConfigAsync(string parent, InstanceConfig instanceConfig, string instanceConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceConfigAsync(new CreateInstanceConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceConfigId, nameof(instanceConfigId)),
                InstanceConfig = gax::GaxPreconditions.CheckNotNull(instanceConfig, nameof(instanceConfig)),
            }, callSettings);

        /// <summary>
        /// Creates an instance config and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance config. The instance config name is assigned by the caller. If the
        /// named instance config already exists, `CreateInstanceConfig` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config is readable via the API, with all requested
        /// attributes. The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true. Its state is `CREATING`.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation renders the instance config immediately
        /// unreadable via the API.
        /// * Except for deleting the creating resource, all other attempts to modify
        /// the instance config are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Instances can be created using the instance configuration.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false. Its state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// creation of the instance config. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceConfigMetadata][google.spanner.admin.instance.v1.CreateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.create` permission on
        /// the resource
        /// [parent][google.spanner.admin.instance.v1.CreateInstanceConfigRequest.parent].
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the instance config.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceConfig">
        /// Required. The InstanceConfig proto of the configuration to create.
        /// instance_config.name must be
        /// `&lt;parent&gt;/instanceConfigs/&lt;instance_config_id&gt;`.
        /// instance_config.base_config must be a Google managed configuration name,
        /// e.g. &lt;parent&gt;/instanceConfigs/us-east1, &lt;parent&gt;/instanceConfigs/nam3.
        /// </param>
        /// <param name="instanceConfigId">
        /// Required. The ID of the instance config to create.  Valid identifiers are
        /// of the form `custom-[-a-z0-9]*[a-z0-9]` and must be between 2 and 64
        /// characters in length. The `custom-` prefix is required to avoid name
        /// conflicts with Google managed configurations.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstanceConfig, CreateInstanceConfigMetadata>> CreateInstanceConfigAsync(string parent, InstanceConfig instanceConfig, string instanceConfigId, st::CancellationToken cancellationToken) =>
            CreateInstanceConfigAsync(parent, instanceConfig, instanceConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an instance config and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance config. The instance config name is assigned by the caller. If the
        /// named instance config already exists, `CreateInstanceConfig` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config is readable via the API, with all requested
        /// attributes. The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true. Its state is `CREATING`.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation renders the instance config immediately
        /// unreadable via the API.
        /// * Except for deleting the creating resource, all other attempts to modify
        /// the instance config are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Instances can be created using the instance configuration.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false. Its state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// creation of the instance config. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceConfigMetadata][google.spanner.admin.instance.v1.CreateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.create` permission on
        /// the resource
        /// [parent][google.spanner.admin.instance.v1.CreateInstanceConfigRequest.parent].
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the instance config.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceConfig">
        /// Required. The InstanceConfig proto of the configuration to create.
        /// instance_config.name must be
        /// `&lt;parent&gt;/instanceConfigs/&lt;instance_config_id&gt;`.
        /// instance_config.base_config must be a Google managed configuration name,
        /// e.g. &lt;parent&gt;/instanceConfigs/us-east1, &lt;parent&gt;/instanceConfigs/nam3.
        /// </param>
        /// <param name="instanceConfigId">
        /// Required. The ID of the instance config to create.  Valid identifiers are
        /// of the form `custom-[-a-z0-9]*[a-z0-9]` and must be between 2 and 64
        /// characters in length. The `custom-` prefix is required to avoid name
        /// conflicts with Google managed configurations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InstanceConfig, CreateInstanceConfigMetadata> CreateInstanceConfig(gagr::ProjectName parent, InstanceConfig instanceConfig, string instanceConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceConfig(new CreateInstanceConfigRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceConfigId, nameof(instanceConfigId)),
                InstanceConfig = gax::GaxPreconditions.CheckNotNull(instanceConfig, nameof(instanceConfig)),
            }, callSettings);

        /// <summary>
        /// Creates an instance config and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance config. The instance config name is assigned by the caller. If the
        /// named instance config already exists, `CreateInstanceConfig` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config is readable via the API, with all requested
        /// attributes. The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true. Its state is `CREATING`.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation renders the instance config immediately
        /// unreadable via the API.
        /// * Except for deleting the creating resource, all other attempts to modify
        /// the instance config are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Instances can be created using the instance configuration.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false. Its state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// creation of the instance config. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceConfigMetadata][google.spanner.admin.instance.v1.CreateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.create` permission on
        /// the resource
        /// [parent][google.spanner.admin.instance.v1.CreateInstanceConfigRequest.parent].
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the instance config.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceConfig">
        /// Required. The InstanceConfig proto of the configuration to create.
        /// instance_config.name must be
        /// `&lt;parent&gt;/instanceConfigs/&lt;instance_config_id&gt;`.
        /// instance_config.base_config must be a Google managed configuration name,
        /// e.g. &lt;parent&gt;/instanceConfigs/us-east1, &lt;parent&gt;/instanceConfigs/nam3.
        /// </param>
        /// <param name="instanceConfigId">
        /// Required. The ID of the instance config to create.  Valid identifiers are
        /// of the form `custom-[-a-z0-9]*[a-z0-9]` and must be between 2 and 64
        /// characters in length. The `custom-` prefix is required to avoid name
        /// conflicts with Google managed configurations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstanceConfig, CreateInstanceConfigMetadata>> CreateInstanceConfigAsync(gagr::ProjectName parent, InstanceConfig instanceConfig, string instanceConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceConfigAsync(new CreateInstanceConfigRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceConfigId, nameof(instanceConfigId)),
                InstanceConfig = gax::GaxPreconditions.CheckNotNull(instanceConfig, nameof(instanceConfig)),
            }, callSettings);

        /// <summary>
        /// Creates an instance config and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance config. The instance config name is assigned by the caller. If the
        /// named instance config already exists, `CreateInstanceConfig` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config is readable via the API, with all requested
        /// attributes. The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true. Its state is `CREATING`.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation renders the instance config immediately
        /// unreadable via the API.
        /// * Except for deleting the creating resource, all other attempts to modify
        /// the instance config are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Instances can be created using the instance configuration.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false. Its state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// creation of the instance config. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceConfigMetadata][google.spanner.admin.instance.v1.CreateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.create` permission on
        /// the resource
        /// [parent][google.spanner.admin.instance.v1.CreateInstanceConfigRequest.parent].
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the instance config.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceConfig">
        /// Required. The InstanceConfig proto of the configuration to create.
        /// instance_config.name must be
        /// `&lt;parent&gt;/instanceConfigs/&lt;instance_config_id&gt;`.
        /// instance_config.base_config must be a Google managed configuration name,
        /// e.g. &lt;parent&gt;/instanceConfigs/us-east1, &lt;parent&gt;/instanceConfigs/nam3.
        /// </param>
        /// <param name="instanceConfigId">
        /// Required. The ID of the instance config to create.  Valid identifiers are
        /// of the form `custom-[-a-z0-9]*[a-z0-9]` and must be between 2 and 64
        /// characters in length. The `custom-` prefix is required to avoid name
        /// conflicts with Google managed configurations.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstanceConfig, CreateInstanceConfigMetadata>> CreateInstanceConfigAsync(gagr::ProjectName parent, InstanceConfig instanceConfig, string instanceConfigId, st::CancellationToken cancellationToken) =>
            CreateInstanceConfigAsync(parent, instanceConfig, instanceConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an instance config. The returned
        /// [long-running operation][google.longrunning.Operation] can be used to track
        /// the progress of updating the instance. If the named instance config does
        /// not exist, returns `NOT_FOUND`.
        /// 
        /// Only user managed configurations can be updated.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceConfigMetadata.cancel_time].
        /// The operation is guaranteed to succeed at undoing all changes, after
        /// which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance config are rejected.
        /// * Reading the instance config via the API continues to give the
        /// pre-request values.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Creating instances using the instance configuration uses the new
        /// values.
        /// * The instance config's new values are readable via the API.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// the instance config modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceConfigMetadata][google.spanner.admin.instance.v1.UpdateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.update` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InstanceConfig, UpdateInstanceConfigMetadata> UpdateInstanceConfig(UpdateInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an instance config. The returned
        /// [long-running operation][google.longrunning.Operation] can be used to track
        /// the progress of updating the instance. If the named instance config does
        /// not exist, returns `NOT_FOUND`.
        /// 
        /// Only user managed configurations can be updated.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceConfigMetadata.cancel_time].
        /// The operation is guaranteed to succeed at undoing all changes, after
        /// which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance config are rejected.
        /// * Reading the instance config via the API continues to give the
        /// pre-request values.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Creating instances using the instance configuration uses the new
        /// values.
        /// * The instance config's new values are readable via the API.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// the instance config modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceConfigMetadata][google.spanner.admin.instance.v1.UpdateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.update` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstanceConfig, UpdateInstanceConfigMetadata>> UpdateInstanceConfigAsync(UpdateInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an instance config. The returned
        /// [long-running operation][google.longrunning.Operation] can be used to track
        /// the progress of updating the instance. If the named instance config does
        /// not exist, returns `NOT_FOUND`.
        /// 
        /// Only user managed configurations can be updated.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceConfigMetadata.cancel_time].
        /// The operation is guaranteed to succeed at undoing all changes, after
        /// which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance config are rejected.
        /// * Reading the instance config via the API continues to give the
        /// pre-request values.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Creating instances using the instance configuration uses the new
        /// values.
        /// * The instance config's new values are readable via the API.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// the instance config modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceConfigMetadata][google.spanner.admin.instance.v1.UpdateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.update` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstanceConfig, UpdateInstanceConfigMetadata>> UpdateInstanceConfigAsync(UpdateInstanceConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateInstanceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateInstanceConfig</c>.</summary>
        public virtual lro::OperationsClient UpdateInstanceConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateInstanceConfig</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InstanceConfig, UpdateInstanceConfigMetadata> PollOnceUpdateInstanceConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InstanceConfig, UpdateInstanceConfigMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInstanceConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InstanceConfig, UpdateInstanceConfigMetadata>> PollOnceUpdateInstanceConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InstanceConfig, UpdateInstanceConfigMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceConfigOperationsClient, callSettings);

        /// <summary>
        /// Updates an instance config. The returned
        /// [long-running operation][google.longrunning.Operation] can be used to track
        /// the progress of updating the instance. If the named instance config does
        /// not exist, returns `NOT_FOUND`.
        /// 
        /// Only user managed configurations can be updated.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceConfigMetadata.cancel_time].
        /// The operation is guaranteed to succeed at undoing all changes, after
        /// which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance config are rejected.
        /// * Reading the instance config via the API continues to give the
        /// pre-request values.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Creating instances using the instance configuration uses the new
        /// values.
        /// * The instance config's new values are readable via the API.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// the instance config modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceConfigMetadata][google.spanner.admin.instance.v1.UpdateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.update` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="instanceConfig">
        /// Required. The user instance config to update, which must always include the
        /// instance config name. Otherwise, only fields mentioned in
        /// [update_mask][google.spanner.admin.instance.v1.UpdateInstanceConfigRequest.update_mask]
        /// need be included. To prevent conflicts of concurrent updates,
        /// [etag][google.spanner.admin.instance.v1.InstanceConfig.reconciling] can
        /// be used.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask specifying which fields in
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig] should be
        /// updated. The field mask must always be specified; this prevents any future
        /// fields in [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig]
        /// from being erased accidentally by clients that do not know about them. Only
        /// display_name and labels can be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InstanceConfig, UpdateInstanceConfigMetadata> UpdateInstanceConfig(InstanceConfig instanceConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstanceConfig(new UpdateInstanceConfigRequest
            {
                InstanceConfig = gax::GaxPreconditions.CheckNotNull(instanceConfig, nameof(instanceConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an instance config. The returned
        /// [long-running operation][google.longrunning.Operation] can be used to track
        /// the progress of updating the instance. If the named instance config does
        /// not exist, returns `NOT_FOUND`.
        /// 
        /// Only user managed configurations can be updated.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceConfigMetadata.cancel_time].
        /// The operation is guaranteed to succeed at undoing all changes, after
        /// which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance config are rejected.
        /// * Reading the instance config via the API continues to give the
        /// pre-request values.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Creating instances using the instance configuration uses the new
        /// values.
        /// * The instance config's new values are readable via the API.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// the instance config modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceConfigMetadata][google.spanner.admin.instance.v1.UpdateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.update` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="instanceConfig">
        /// Required. The user instance config to update, which must always include the
        /// instance config name. Otherwise, only fields mentioned in
        /// [update_mask][google.spanner.admin.instance.v1.UpdateInstanceConfigRequest.update_mask]
        /// need be included. To prevent conflicts of concurrent updates,
        /// [etag][google.spanner.admin.instance.v1.InstanceConfig.reconciling] can
        /// be used.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask specifying which fields in
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig] should be
        /// updated. The field mask must always be specified; this prevents any future
        /// fields in [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig]
        /// from being erased accidentally by clients that do not know about them. Only
        /// display_name and labels can be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstanceConfig, UpdateInstanceConfigMetadata>> UpdateInstanceConfigAsync(InstanceConfig instanceConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstanceConfigAsync(new UpdateInstanceConfigRequest
            {
                InstanceConfig = gax::GaxPreconditions.CheckNotNull(instanceConfig, nameof(instanceConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an instance config. The returned
        /// [long-running operation][google.longrunning.Operation] can be used to track
        /// the progress of updating the instance. If the named instance config does
        /// not exist, returns `NOT_FOUND`.
        /// 
        /// Only user managed configurations can be updated.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceConfigMetadata.cancel_time].
        /// The operation is guaranteed to succeed at undoing all changes, after
        /// which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance config are rejected.
        /// * Reading the instance config via the API continues to give the
        /// pre-request values.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Creating instances using the instance configuration uses the new
        /// values.
        /// * The instance config's new values are readable via the API.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// the instance config modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceConfigMetadata][google.spanner.admin.instance.v1.UpdateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.update` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="instanceConfig">
        /// Required. The user instance config to update, which must always include the
        /// instance config name. Otherwise, only fields mentioned in
        /// [update_mask][google.spanner.admin.instance.v1.UpdateInstanceConfigRequest.update_mask]
        /// need be included. To prevent conflicts of concurrent updates,
        /// [etag][google.spanner.admin.instance.v1.InstanceConfig.reconciling] can
        /// be used.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask specifying which fields in
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig] should be
        /// updated. The field mask must always be specified; this prevents any future
        /// fields in [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig]
        /// from being erased accidentally by clients that do not know about them. Only
        /// display_name and labels can be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstanceConfig, UpdateInstanceConfigMetadata>> UpdateInstanceConfigAsync(InstanceConfig instanceConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateInstanceConfigAsync(instanceConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the instance config. Deletion is only allowed when no
        /// instances are using the configuration. If any instances are using
        /// the config, returns `FAILED_PRECONDITION`.
        /// 
        /// Only user managed configurations can be deleted.
        /// 
        /// Authorization requires `spanner.instanceConfigs.delete` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteInstanceConfig(DeleteInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the instance config. Deletion is only allowed when no
        /// instances are using the configuration. If any instances are using
        /// the config, returns `FAILED_PRECONDITION`.
        /// 
        /// Only user managed configurations can be deleted.
        /// 
        /// Authorization requires `spanner.instanceConfigs.delete` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstanceConfigAsync(DeleteInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the instance config. Deletion is only allowed when no
        /// instances are using the configuration. If any instances are using
        /// the config, returns `FAILED_PRECONDITION`.
        /// 
        /// Only user managed configurations can be deleted.
        /// 
        /// Authorization requires `spanner.instanceConfigs.delete` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstanceConfigAsync(DeleteInstanceConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteInstanceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the instance config. Deletion is only allowed when no
        /// instances are using the configuration. If any instances are using
        /// the config, returns `FAILED_PRECONDITION`.
        /// 
        /// Only user managed configurations can be deleted.
        /// 
        /// Authorization requires `spanner.instanceConfigs.delete` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance configuration to be deleted.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instanceConfigs/&lt;instance_config&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteInstanceConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceConfig(new DeleteInstanceConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the instance config. Deletion is only allowed when no
        /// instances are using the configuration. If any instances are using
        /// the config, returns `FAILED_PRECONDITION`.
        /// 
        /// Only user managed configurations can be deleted.
        /// 
        /// Authorization requires `spanner.instanceConfigs.delete` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance configuration to be deleted.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instanceConfigs/&lt;instance_config&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstanceConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceConfigAsync(new DeleteInstanceConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the instance config. Deletion is only allowed when no
        /// instances are using the configuration. If any instances are using
        /// the config, returns `FAILED_PRECONDITION`.
        /// 
        /// Only user managed configurations can be deleted.
        /// 
        /// Authorization requires `spanner.instanceConfigs.delete` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance configuration to be deleted.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instanceConfigs/&lt;instance_config&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstanceConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInstanceConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the instance config. Deletion is only allowed when no
        /// instances are using the configuration. If any instances are using
        /// the config, returns `FAILED_PRECONDITION`.
        /// 
        /// Only user managed configurations can be deleted.
        /// 
        /// Authorization requires `spanner.instanceConfigs.delete` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance configuration to be deleted.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instanceConfigs/&lt;instance_config&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteInstanceConfig(InstanceConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceConfig(new DeleteInstanceConfigRequest
            {
                InstanceConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the instance config. Deletion is only allowed when no
        /// instances are using the configuration. If any instances are using
        /// the config, returns `FAILED_PRECONDITION`.
        /// 
        /// Only user managed configurations can be deleted.
        /// 
        /// Authorization requires `spanner.instanceConfigs.delete` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance configuration to be deleted.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instanceConfigs/&lt;instance_config&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstanceConfigAsync(InstanceConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceConfigAsync(new DeleteInstanceConfigRequest
            {
                InstanceConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the instance config. Deletion is only allowed when no
        /// instances are using the configuration. If any instances are using
        /// the config, returns `FAILED_PRECONDITION`.
        /// 
        /// Only user managed configurations can be deleted.
        /// 
        /// Authorization requires `spanner.instanceConfigs.delete` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance configuration to be deleted.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instanceConfigs/&lt;instance_config&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstanceConfigAsync(InstanceConfigName name, st::CancellationToken cancellationToken) =>
            DeleteInstanceConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the user-managed instance config [long-running
        /// operations][google.longrunning.Operation] in the given project. An instance
        /// config operation has a name of the form
        /// `projects/&lt;project&gt;/instanceConfigs/&lt;instance_config&gt;/operations/&lt;operation&gt;`.
        /// The long-running operation
        /// [metadata][google.longrunning.Operation.metadata] field type
        /// `metadata.type_url` describes the type of the metadata. Operations returned
        /// include those that have completed/failed/canceled within the last 7 days,
        /// and pending operations. Operations returned are ordered by
        /// `operation.metadata.value.start_time` in descending order starting
        /// from the most recently started operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="lro::Operation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstanceConfigOperationsResponse, lro::Operation> ListInstanceConfigOperations(ListInstanceConfigOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the user-managed instance config [long-running
        /// operations][google.longrunning.Operation] in the given project. An instance
        /// config operation has a name of the form
        /// `projects/&lt;project&gt;/instanceConfigs/&lt;instance_config&gt;/operations/&lt;operation&gt;`.
        /// The long-running operation
        /// [metadata][google.longrunning.Operation.metadata] field type
        /// `metadata.type_url` describes the type of the metadata. Operations returned
        /// include those that have completed/failed/canceled within the last 7 days,
        /// and pending operations. Operations returned are ordered by
        /// `operation.metadata.value.start_time` in descending order starting
        /// from the most recently started operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="lro::Operation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstanceConfigOperationsResponse, lro::Operation> ListInstanceConfigOperationsAsync(ListInstanceConfigOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the user-managed instance config [long-running
        /// operations][google.longrunning.Operation] in the given project. An instance
        /// config operation has a name of the form
        /// `projects/&lt;project&gt;/instanceConfigs/&lt;instance_config&gt;/operations/&lt;operation&gt;`.
        /// The long-running operation
        /// [metadata][google.longrunning.Operation.metadata] field type
        /// `metadata.type_url` describes the type of the metadata. Operations returned
        /// include those that have completed/failed/canceled within the last 7 days,
        /// and pending operations. Operations returned are ordered by
        /// `operation.metadata.value.start_time` in descending order starting
        /// from the most recently started operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The project of the instance config operations.
        /// Values are of the form `projects/&lt;project&gt;`.
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
        /// <returns>A pageable sequence of <see cref="lro::Operation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstanceConfigOperationsResponse, lro::Operation> ListInstanceConfigOperations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstanceConfigOperationsRequest request = new ListInstanceConfigOperationsRequest
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
            return ListInstanceConfigOperations(request, callSettings);
        }

        /// <summary>
        /// Lists the user-managed instance config [long-running
        /// operations][google.longrunning.Operation] in the given project. An instance
        /// config operation has a name of the form
        /// `projects/&lt;project&gt;/instanceConfigs/&lt;instance_config&gt;/operations/&lt;operation&gt;`.
        /// The long-running operation
        /// [metadata][google.longrunning.Operation.metadata] field type
        /// `metadata.type_url` describes the type of the metadata. Operations returned
        /// include those that have completed/failed/canceled within the last 7 days,
        /// and pending operations. Operations returned are ordered by
        /// `operation.metadata.value.start_time` in descending order starting
        /// from the most recently started operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The project of the instance config operations.
        /// Values are of the form `projects/&lt;project&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="lro::Operation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstanceConfigOperationsResponse, lro::Operation> ListInstanceConfigOperationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstanceConfigOperationsRequest request = new ListInstanceConfigOperationsRequest
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
            return ListInstanceConfigOperationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the user-managed instance config [long-running
        /// operations][google.longrunning.Operation] in the given project. An instance
        /// config operation has a name of the form
        /// `projects/&lt;project&gt;/instanceConfigs/&lt;instance_config&gt;/operations/&lt;operation&gt;`.
        /// The long-running operation
        /// [metadata][google.longrunning.Operation.metadata] field type
        /// `metadata.type_url` describes the type of the metadata. Operations returned
        /// include those that have completed/failed/canceled within the last 7 days,
        /// and pending operations. Operations returned are ordered by
        /// `operation.metadata.value.start_time` in descending order starting
        /// from the most recently started operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The project of the instance config operations.
        /// Values are of the form `projects/&lt;project&gt;`.
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
        /// <returns>A pageable sequence of <see cref="lro::Operation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstanceConfigOperationsResponse, lro::Operation> ListInstanceConfigOperations(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstanceConfigOperationsRequest request = new ListInstanceConfigOperationsRequest
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
            return ListInstanceConfigOperations(request, callSettings);
        }

        /// <summary>
        /// Lists the user-managed instance config [long-running
        /// operations][google.longrunning.Operation] in the given project. An instance
        /// config operation has a name of the form
        /// `projects/&lt;project&gt;/instanceConfigs/&lt;instance_config&gt;/operations/&lt;operation&gt;`.
        /// The long-running operation
        /// [metadata][google.longrunning.Operation.metadata] field type
        /// `metadata.type_url` describes the type of the metadata. Operations returned
        /// include those that have completed/failed/canceled within the last 7 days,
        /// and pending operations. Operations returned are ordered by
        /// `operation.metadata.value.start_time` in descending order starting
        /// from the most recently started operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The project of the instance config operations.
        /// Values are of the form `projects/&lt;project&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="lro::Operation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstanceConfigOperationsResponse, lro::Operation> ListInstanceConfigOperationsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstanceConfigOperationsRequest request = new ListInstanceConfigOperationsRequest
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
            return ListInstanceConfigOperationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all instances in the given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all instances in the given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all instances in the given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which a list of instances is
        /// requested. Values are of the form `projects/&lt;project&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstances(request, callSettings);
        }

        /// <summary>
        /// Lists all instances in the given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which a list of instances is
        /// requested. Values are of the form `projects/&lt;project&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstancesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all instances in the given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which a list of instances is
        /// requested. Values are of the form `projects/&lt;project&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstances(request, callSettings);
        }

        /// <summary>
        /// Lists all instances in the given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which a list of instances is
        /// requested. Values are of the form `projects/&lt;project&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstancesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all instance partitions for the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InstancePartition"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancePartitionsResponse, InstancePartition> ListInstancePartitions(ListInstancePartitionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all instance partitions for the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InstancePartition"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancePartitionsResponse, InstancePartition> ListInstancePartitionsAsync(ListInstancePartitionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all instance partitions for the given instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance whose instance partitions should be listed. Values
        /// are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// <returns>A pageable sequence of <see cref="InstancePartition"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancePartitionsResponse, InstancePartition> ListInstancePartitions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancePartitionsRequest request = new ListInstancePartitionsRequest
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
            return ListInstancePartitions(request, callSettings);
        }

        /// <summary>
        /// Lists all instance partitions for the given instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance whose instance partitions should be listed. Values
        /// are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="InstancePartition"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancePartitionsResponse, InstancePartition> ListInstancePartitionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancePartitionsRequest request = new ListInstancePartitionsRequest
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
            return ListInstancePartitionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all instance partitions for the given instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance whose instance partitions should be listed. Values
        /// are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// <returns>A pageable sequence of <see cref="InstancePartition"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancePartitionsResponse, InstancePartition> ListInstancePartitions(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancePartitionsRequest request = new ListInstancePartitionsRequest
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
            return ListInstancePartitions(request, callSettings);
        }

        /// <summary>
        /// Lists all instance partitions for the given instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance whose instance partitions should be listed. Values
        /// are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="InstancePartition"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancePartitionsResponse, InstancePartition> ListInstancePartitionsAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancePartitionsRequest request = new ListInstancePartitionsRequest
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
            return ListInstancePartitionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a particular instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a particular instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a particular instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a particular instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a particular instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a particular instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a particular instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a particular instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a particular instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance is readable via the API, with all requested attributes
        /// but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance immediately unreadable
        /// via the API.
        /// * The instance can be deleted.
        /// * All other attempts to modify the instance are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can be created in the instance.
        /// * The instance's allocated resource levels are readable via the API.
        /// * The instance's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, CreateInstanceMetadata> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance is readable via the API, with all requested attributes
        /// but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance immediately unreadable
        /// via the API.
        /// * The instance can be deleted.
        /// * All other attempts to modify the instance are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can be created in the instance.
        /// * The instance's allocated resource levels are readable via the API.
        /// * The instance's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance is readable via the API, with all requested attributes
        /// but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance immediately unreadable
        /// via the API.
        /// * The instance can be deleted.
        /// * All other attempts to modify the instance are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can be created in the instance.
        /// * The instance's allocated resource levels are readable via the API.
        /// * The instance's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
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
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance is readable via the API, with all requested attributes
        /// but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance immediately unreadable
        /// via the API.
        /// * The instance can be deleted.
        /// * All other attempts to modify the instance are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can be created in the instance.
        /// * The instance's allocated resource levels are readable via the API.
        /// * The instance's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the instance. Values
        /// are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID of the instance to create.  Valid identifiers are of the
        /// form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 2 and 64 characters in
        /// length.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.  The name may be omitted, but if
        /// specified must be `&lt;parent&gt;/instances/&lt;instance_id&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, CreateInstanceMetadata> CreateInstance(string parent, string instanceId, Instance instance, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance is readable via the API, with all requested attributes
        /// but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance immediately unreadable
        /// via the API.
        /// * The instance can be deleted.
        /// * All other attempts to modify the instance are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can be created in the instance.
        /// * The instance's allocated resource levels are readable via the API.
        /// * The instance's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the instance. Values
        /// are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID of the instance to create.  Valid identifiers are of the
        /// form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 2 and 64 characters in
        /// length.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.  The name may be omitted, but if
        /// specified must be `&lt;parent&gt;/instances/&lt;instance_id&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(string parent, string instanceId, Instance instance, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance is readable via the API, with all requested attributes
        /// but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance immediately unreadable
        /// via the API.
        /// * The instance can be deleted.
        /// * All other attempts to modify the instance are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can be created in the instance.
        /// * The instance's allocated resource levels are readable via the API.
        /// * The instance's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the instance. Values
        /// are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID of the instance to create.  Valid identifiers are of the
        /// form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 2 and 64 characters in
        /// length.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.  The name may be omitted, but if
        /// specified must be `&lt;parent&gt;/instances/&lt;instance_id&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(string parent, string instanceId, Instance instance, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instanceId, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance is readable via the API, with all requested attributes
        /// but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance immediately unreadable
        /// via the API.
        /// * The instance can be deleted.
        /// * All other attempts to modify the instance are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can be created in the instance.
        /// * The instance's allocated resource levels are readable via the API.
        /// * The instance's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the instance. Values
        /// are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID of the instance to create.  Valid identifiers are of the
        /// form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 2 and 64 characters in
        /// length.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.  The name may be omitted, but if
        /// specified must be `&lt;parent&gt;/instances/&lt;instance_id&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, CreateInstanceMetadata> CreateInstance(gagr::ProjectName parent, string instanceId, Instance instance, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance is readable via the API, with all requested attributes
        /// but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance immediately unreadable
        /// via the API.
        /// * The instance can be deleted.
        /// * All other attempts to modify the instance are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can be created in the instance.
        /// * The instance's allocated resource levels are readable via the API.
        /// * The instance's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the instance. Values
        /// are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID of the instance to create.  Valid identifiers are of the
        /// form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 2 and 64 characters in
        /// length.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.  The name may be omitted, but if
        /// specified must be `&lt;parent&gt;/instances/&lt;instance_id&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(gagr::ProjectName parent, string instanceId, Instance instance, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance is readable via the API, with all requested attributes
        /// but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance immediately unreadable
        /// via the API.
        /// * The instance can be deleted.
        /// * All other attempts to modify the instance are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can be created in the instance.
        /// * The instance's allocated resource levels are readable via the API.
        /// * The instance's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the instance. Values
        /// are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID of the instance to create.  Valid identifiers are of the
        /// form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 2 and 64 characters in
        /// length.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.  The name may be omitted, but if
        /// specified must be `&lt;parent&gt;/instances/&lt;instance_id&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(gagr::ProjectName parent, string instanceId, Instance instance, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instanceId, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an instance, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance. If the named instance does not
        /// exist, returns `NOT_FOUND`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * For resource types for which a decrease in the instance's allocation
        /// has been requested, billing is based on the newly-requested level.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceMetadata.cancel_time],
        /// and begins restoring resources to their pre-request values. The
        /// operation is guaranteed to succeed at undoing all resource changes,
        /// after which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance are rejected.
        /// * Reading the instance via the API continues to give the pre-request
        /// resource levels.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing begins for all successfully-allocated resources (some types
        /// may have lower than the requested levels).
        /// * All newly-reserved resources are available for serving the instance's
        /// tables.
        /// * The instance's new resource levels are readable via the API.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track the instance modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceMetadata][google.spanner.admin.instance.v1.UpdateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// 
        /// Authorization requires `spanner.instances.update` permission on
        /// the resource [name][google.spanner.admin.instance.v1.Instance.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, UpdateInstanceMetadata> UpdateInstance(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an instance, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance. If the named instance does not
        /// exist, returns `NOT_FOUND`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * For resource types for which a decrease in the instance's allocation
        /// has been requested, billing is based on the newly-requested level.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceMetadata.cancel_time],
        /// and begins restoring resources to their pre-request values. The
        /// operation is guaranteed to succeed at undoing all resource changes,
        /// after which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance are rejected.
        /// * Reading the instance via the API continues to give the pre-request
        /// resource levels.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing begins for all successfully-allocated resources (some types
        /// may have lower than the requested levels).
        /// * All newly-reserved resources are available for serving the instance's
        /// tables.
        /// * The instance's new resource levels are readable via the API.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track the instance modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceMetadata][google.spanner.admin.instance.v1.UpdateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// 
        /// Authorization requires `spanner.instances.update` permission on
        /// the resource [name][google.spanner.admin.instance.v1.Instance.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an instance, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance. If the named instance does not
        /// exist, returns `NOT_FOUND`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * For resource types for which a decrease in the instance's allocation
        /// has been requested, billing is based on the newly-requested level.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceMetadata.cancel_time],
        /// and begins restoring resources to their pre-request values. The
        /// operation is guaranteed to succeed at undoing all resource changes,
        /// after which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance are rejected.
        /// * Reading the instance via the API continues to give the pre-request
        /// resource levels.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing begins for all successfully-allocated resources (some types
        /// may have lower than the requested levels).
        /// * All newly-reserved resources are available for serving the instance's
        /// tables.
        /// * The instance's new resource levels are readable via the API.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track the instance modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceMetadata][google.spanner.admin.instance.v1.UpdateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// 
        /// Authorization requires `spanner.instances.update` permission on
        /// the resource [name][google.spanner.admin.instance.v1.Instance.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, st::CancellationToken cancellationToken) =>
            UpdateInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateInstance</c>.</summary>
        public virtual lro::OperationsClient UpdateInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, UpdateInstanceMetadata> PollOnceUpdateInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, UpdateInstanceMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> PollOnceUpdateInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, UpdateInstanceMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Updates an instance, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance. If the named instance does not
        /// exist, returns `NOT_FOUND`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * For resource types for which a decrease in the instance's allocation
        /// has been requested, billing is based on the newly-requested level.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceMetadata.cancel_time],
        /// and begins restoring resources to their pre-request values. The
        /// operation is guaranteed to succeed at undoing all resource changes,
        /// after which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance are rejected.
        /// * Reading the instance via the API continues to give the pre-request
        /// resource levels.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing begins for all successfully-allocated resources (some types
        /// may have lower than the requested levels).
        /// * All newly-reserved resources are available for serving the instance's
        /// tables.
        /// * The instance's new resource levels are readable via the API.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track the instance modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceMetadata][google.spanner.admin.instance.v1.UpdateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// 
        /// Authorization requires `spanner.instances.update` permission on
        /// the resource [name][google.spanner.admin.instance.v1.Instance.name].
        /// </summary>
        /// <param name="instance">
        /// Required. The instance to update, which must always include the instance
        /// name.  Otherwise, only fields mentioned in
        /// [field_mask][google.spanner.admin.instance.v1.UpdateInstanceRequest.field_mask]
        /// need be included.
        /// </param>
        /// <param name="fieldMask">
        /// Required. A mask specifying which fields in
        /// [Instance][google.spanner.admin.instance.v1.Instance] should be updated.
        /// The field mask must always be specified; this prevents any future fields in
        /// [Instance][google.spanner.admin.instance.v1.Instance] from being erased
        /// accidentally by clients that do not know about them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, UpdateInstanceMetadata> UpdateInstance(Instance instance, wkt::FieldMask fieldMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstance(new UpdateInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                FieldMask = gax::GaxPreconditions.CheckNotNull(fieldMask, nameof(fieldMask)),
            }, callSettings);

        /// <summary>
        /// Updates an instance, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance. If the named instance does not
        /// exist, returns `NOT_FOUND`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * For resource types for which a decrease in the instance's allocation
        /// has been requested, billing is based on the newly-requested level.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceMetadata.cancel_time],
        /// and begins restoring resources to their pre-request values. The
        /// operation is guaranteed to succeed at undoing all resource changes,
        /// after which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance are rejected.
        /// * Reading the instance via the API continues to give the pre-request
        /// resource levels.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing begins for all successfully-allocated resources (some types
        /// may have lower than the requested levels).
        /// * All newly-reserved resources are available for serving the instance's
        /// tables.
        /// * The instance's new resource levels are readable via the API.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track the instance modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceMetadata][google.spanner.admin.instance.v1.UpdateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// 
        /// Authorization requires `spanner.instances.update` permission on
        /// the resource [name][google.spanner.admin.instance.v1.Instance.name].
        /// </summary>
        /// <param name="instance">
        /// Required. The instance to update, which must always include the instance
        /// name.  Otherwise, only fields mentioned in
        /// [field_mask][google.spanner.admin.instance.v1.UpdateInstanceRequest.field_mask]
        /// need be included.
        /// </param>
        /// <param name="fieldMask">
        /// Required. A mask specifying which fields in
        /// [Instance][google.spanner.admin.instance.v1.Instance] should be updated.
        /// The field mask must always be specified; this prevents any future fields in
        /// [Instance][google.spanner.admin.instance.v1.Instance] from being erased
        /// accidentally by clients that do not know about them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> UpdateInstanceAsync(Instance instance, wkt::FieldMask fieldMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstanceAsync(new UpdateInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                FieldMask = gax::GaxPreconditions.CheckNotNull(fieldMask, nameof(fieldMask)),
            }, callSettings);

        /// <summary>
        /// Updates an instance, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance. If the named instance does not
        /// exist, returns `NOT_FOUND`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * For resource types for which a decrease in the instance's allocation
        /// has been requested, billing is based on the newly-requested level.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceMetadata.cancel_time],
        /// and begins restoring resources to their pre-request values. The
        /// operation is guaranteed to succeed at undoing all resource changes,
        /// after which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance are rejected.
        /// * Reading the instance via the API continues to give the pre-request
        /// resource levels.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing begins for all successfully-allocated resources (some types
        /// may have lower than the requested levels).
        /// * All newly-reserved resources are available for serving the instance's
        /// tables.
        /// * The instance's new resource levels are readable via the API.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track the instance modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceMetadata][google.spanner.admin.instance.v1.UpdateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// 
        /// Authorization requires `spanner.instances.update` permission on
        /// the resource [name][google.spanner.admin.instance.v1.Instance.name].
        /// </summary>
        /// <param name="instance">
        /// Required. The instance to update, which must always include the instance
        /// name.  Otherwise, only fields mentioned in
        /// [field_mask][google.spanner.admin.instance.v1.UpdateInstanceRequest.field_mask]
        /// need be included.
        /// </param>
        /// <param name="fieldMask">
        /// Required. A mask specifying which fields in
        /// [Instance][google.spanner.admin.instance.v1.Instance] should be updated.
        /// The field mask must always be specified; this prevents any future fields in
        /// [Instance][google.spanner.admin.instance.v1.Instance] from being erased
        /// accidentally by clients that do not know about them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> UpdateInstanceAsync(Instance instance, wkt::FieldMask fieldMask, st::CancellationToken cancellationToken) =>
            UpdateInstanceAsync(instance, fieldMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an instance.
        /// 
        /// Immediately upon completion of the request:
        /// 
        /// * Billing ceases for all of the instance's reserved resources.
        /// 
        /// Soon afterward:
        /// 
        /// * The instance and *all of its databases* immediately and
        /// irrevocably disappear from the API. All data in the databases
        /// is permanently deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an instance.
        /// 
        /// Immediately upon completion of the request:
        /// 
        /// * Billing ceases for all of the instance's reserved resources.
        /// 
        /// Soon afterward:
        /// 
        /// * The instance and *all of its databases* immediately and
        /// irrevocably disappear from the API. All data in the databases
        /// is permanently deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an instance.
        /// 
        /// Immediately upon completion of the request:
        /// 
        /// * Billing ceases for all of the instance's reserved resources.
        /// 
        /// Soon afterward:
        /// 
        /// * The instance and *all of its databases* immediately and
        /// irrevocably disappear from the API. All data in the databases
        /// is permanently deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstanceAsync(DeleteInstanceRequest request, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an instance.
        /// 
        /// Immediately upon completion of the request:
        /// 
        /// * Billing ceases for all of the instance's reserved resources.
        /// 
        /// Soon afterward:
        /// 
        /// * The instance and *all of its databases* immediately and
        /// irrevocably disappear from the API. All data in the databases
        /// is permanently deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an instance.
        /// 
        /// Immediately upon completion of the request:
        /// 
        /// * Billing ceases for all of the instance's reserved resources.
        /// 
        /// Soon afterward:
        /// 
        /// * The instance and *all of its databases* immediately and
        /// irrevocably disappear from the API. All data in the databases
        /// is permanently deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an instance.
        /// 
        /// Immediately upon completion of the request:
        /// 
        /// * Billing ceases for all of the instance's reserved resources.
        /// 
        /// Soon afterward:
        /// 
        /// * The instance and *all of its databases* immediately and
        /// irrevocably disappear from the API. All data in the databases
        /// is permanently deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an instance.
        /// 
        /// Immediately upon completion of the request:
        /// 
        /// * Billing ceases for all of the instance's reserved resources.
        /// 
        /// Soon afterward:
        /// 
        /// * The instance and *all of its databases* immediately and
        /// irrevocably disappear from the API. All data in the databases
        /// is permanently deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an instance.
        /// 
        /// Immediately upon completion of the request:
        /// 
        /// * Billing ceases for all of the instance's reserved resources.
        /// 
        /// Soon afterward:
        /// 
        /// * The instance and *all of its databases* immediately and
        /// irrevocably disappear from the API. All data in the databases
        /// is permanently deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an instance.
        /// 
        /// Immediately upon completion of the request:
        /// 
        /// * Billing ceases for all of the instance's reserved resources.
        /// 
        /// Soon afterward:
        /// 
        /// * The instance and *all of its databases* immediately and
        /// irrevocably disappear from the API. All data in the databases
        /// is permanently deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
        /// 
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
        /// 
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
        /// 
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
        /// 
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        /// 
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        /// 
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        /// 
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        /// 
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        /// 
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
        /// 
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
        /// 
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
        /// 
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
        /// 
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        /// 
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        /// 
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        /// 
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        /// 
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        /// 
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        /// Returns permissions that the caller has on the specified instance resource.
        /// 
        /// Attempting this RPC on a non-existent Cloud Spanner instance resource will
        /// result in a NOT_FOUND error if the user has `spanner.instances.list`
        /// permission on the containing Google Cloud Project. Otherwise returns an
        /// empty set of permissions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that the caller has on the specified instance resource.
        /// 
        /// Attempting this RPC on a non-existent Cloud Spanner instance resource will
        /// result in a NOT_FOUND error if the user has `spanner.instances.list`
        /// permission on the containing Google Cloud Project. Otherwise returns an
        /// empty set of permissions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that the caller has on the specified instance resource.
        /// 
        /// Attempting this RPC on a non-existent Cloud Spanner instance resource will
        /// result in a NOT_FOUND error if the user has `spanner.instances.list`
        /// permission on the containing Google Cloud Project. Otherwise returns an
        /// empty set of permissions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that the caller has on the specified instance resource.
        /// 
        /// Attempting this RPC on a non-existent Cloud Spanner instance resource will
        /// result in a NOT_FOUND error if the user has `spanner.instances.list`
        /// permission on the containing Google Cloud Project. Otherwise returns an
        /// empty set of permissions.
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
        /// 
        /// Attempting this RPC on a non-existent Cloud Spanner instance resource will
        /// result in a NOT_FOUND error if the user has `spanner.instances.list`
        /// permission on the containing Google Cloud Project. Otherwise returns an
        /// empty set of permissions.
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
        /// 
        /// Attempting this RPC on a non-existent Cloud Spanner instance resource will
        /// result in a NOT_FOUND error if the user has `spanner.instances.list`
        /// permission on the containing Google Cloud Project. Otherwise returns an
        /// empty set of permissions.
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
        /// 
        /// Attempting this RPC on a non-existent Cloud Spanner instance resource will
        /// result in a NOT_FOUND error if the user has `spanner.instances.list`
        /// permission on the containing Google Cloud Project. Otherwise returns an
        /// empty set of permissions.
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
        /// 
        /// Attempting this RPC on a non-existent Cloud Spanner instance resource will
        /// result in a NOT_FOUND error if the user has `spanner.instances.list`
        /// permission on the containing Google Cloud Project. Otherwise returns an
        /// empty set of permissions.
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
        /// 
        /// Attempting this RPC on a non-existent Cloud Spanner instance resource will
        /// result in a NOT_FOUND error if the user has `spanner.instances.list`
        /// permission on the containing Google Cloud Project. Otherwise returns an
        /// empty set of permissions.
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
        /// Gets information about a particular instance partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstancePartition GetInstancePartition(GetInstancePartitionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a particular instance partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstancePartition> GetInstancePartitionAsync(GetInstancePartitionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a particular instance partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstancePartition> GetInstancePartitionAsync(GetInstancePartitionRequest request, st::CancellationToken cancellationToken) =>
            GetInstancePartitionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a particular instance partition.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance partition. Values are of
        /// the form
        /// `projects/{project}/instances/{instance}/instancePartitions/{instance_partition}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstancePartition GetInstancePartition(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstancePartition(new GetInstancePartitionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a particular instance partition.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance partition. Values are of
        /// the form
        /// `projects/{project}/instances/{instance}/instancePartitions/{instance_partition}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstancePartition> GetInstancePartitionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstancePartitionAsync(new GetInstancePartitionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a particular instance partition.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance partition. Values are of
        /// the form
        /// `projects/{project}/instances/{instance}/instancePartitions/{instance_partition}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstancePartition> GetInstancePartitionAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstancePartitionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a particular instance partition.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance partition. Values are of
        /// the form
        /// `projects/{project}/instances/{instance}/instancePartitions/{instance_partition}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstancePartition GetInstancePartition(InstancePartitionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstancePartition(new GetInstancePartitionRequest
            {
                InstancePartitionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a particular instance partition.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance partition. Values are of
        /// the form
        /// `projects/{project}/instances/{instance}/instancePartitions/{instance_partition}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstancePartition> GetInstancePartitionAsync(InstancePartitionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstancePartitionAsync(new GetInstancePartitionRequest
            {
                InstancePartitionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a particular instance partition.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance partition. Values are of
        /// the form
        /// `projects/{project}/instances/{instance}/instancePartitions/{instance_partition}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstancePartition> GetInstancePartitionAsync(InstancePartitionName name, st::CancellationToken cancellationToken) =>
            GetInstancePartitionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an instance partition and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new instance partition.
        /// The instance partition name is assigned by the caller. If the named
        /// instance partition already exists, `CreateInstancePartition` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance partition is readable via the API, with all requested
        /// attributes but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance partition immediately
        /// unreadable via the API.
        /// * The instance partition can be deleted.
        /// * All other attempts to modify the instance partition are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can start using this instance partition.
        /// * The instance partition's allocated resource levels are readable via the
        /// API.
        /// * The instance partition's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track creation of the instance partition.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstancePartitionMetadata][google.spanner.admin.instance.v1.CreateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InstancePartition, CreateInstancePartitionMetadata> CreateInstancePartition(CreateInstancePartitionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an instance partition and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new instance partition.
        /// The instance partition name is assigned by the caller. If the named
        /// instance partition already exists, `CreateInstancePartition` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance partition is readable via the API, with all requested
        /// attributes but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance partition immediately
        /// unreadable via the API.
        /// * The instance partition can be deleted.
        /// * All other attempts to modify the instance partition are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can start using this instance partition.
        /// * The instance partition's allocated resource levels are readable via the
        /// API.
        /// * The instance partition's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track creation of the instance partition.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstancePartitionMetadata][google.spanner.admin.instance.v1.CreateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstancePartition, CreateInstancePartitionMetadata>> CreateInstancePartitionAsync(CreateInstancePartitionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an instance partition and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new instance partition.
        /// The instance partition name is assigned by the caller. If the named
        /// instance partition already exists, `CreateInstancePartition` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance partition is readable via the API, with all requested
        /// attributes but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance partition immediately
        /// unreadable via the API.
        /// * The instance partition can be deleted.
        /// * All other attempts to modify the instance partition are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can start using this instance partition.
        /// * The instance partition's allocated resource levels are readable via the
        /// API.
        /// * The instance partition's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track creation of the instance partition.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstancePartitionMetadata][google.spanner.admin.instance.v1.CreateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstancePartition, CreateInstancePartitionMetadata>> CreateInstancePartitionAsync(CreateInstancePartitionRequest request, st::CancellationToken cancellationToken) =>
            CreateInstancePartitionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateInstancePartition</c>.</summary>
        public virtual lro::OperationsClient CreateInstancePartitionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInstancePartition</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InstancePartition, CreateInstancePartitionMetadata> PollOnceCreateInstancePartition(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InstancePartition, CreateInstancePartitionMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstancePartitionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInstancePartition</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InstancePartition, CreateInstancePartitionMetadata>> PollOnceCreateInstancePartitionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InstancePartition, CreateInstancePartitionMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstancePartitionOperationsClient, callSettings);

        /// <summary>
        /// Creates an instance partition and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new instance partition.
        /// The instance partition name is assigned by the caller. If the named
        /// instance partition already exists, `CreateInstancePartition` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance partition is readable via the API, with all requested
        /// attributes but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance partition immediately
        /// unreadable via the API.
        /// * The instance partition can be deleted.
        /// * All other attempts to modify the instance partition are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can start using this instance partition.
        /// * The instance partition's allocated resource levels are readable via the
        /// API.
        /// * The instance partition's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track creation of the instance partition.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstancePartitionMetadata][google.spanner.admin.instance.v1.CreateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the instance in which to create the instance
        /// partition. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="instancePartition">
        /// Required. The instance partition to create. The instance_partition.name may
        /// be omitted, but if specified must be
        /// `&lt;parent&gt;/instancePartitions/&lt;instance_partition_id&gt;`.
        /// </param>
        /// <param name="instancePartitionId">
        /// Required. The ID of the instance partition to create. Valid identifiers are
        /// of the form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 2 and 64
        /// characters in length.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InstancePartition, CreateInstancePartitionMetadata> CreateInstancePartition(string parent, InstancePartition instancePartition, string instancePartitionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstancePartition(new CreateInstancePartitionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstancePartitionId = gax::GaxPreconditions.CheckNotNullOrEmpty(instancePartitionId, nameof(instancePartitionId)),
                InstancePartition = gax::GaxPreconditions.CheckNotNull(instancePartition, nameof(instancePartition)),
            }, callSettings);

        /// <summary>
        /// Creates an instance partition and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new instance partition.
        /// The instance partition name is assigned by the caller. If the named
        /// instance partition already exists, `CreateInstancePartition` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance partition is readable via the API, with all requested
        /// attributes but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance partition immediately
        /// unreadable via the API.
        /// * The instance partition can be deleted.
        /// * All other attempts to modify the instance partition are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can start using this instance partition.
        /// * The instance partition's allocated resource levels are readable via the
        /// API.
        /// * The instance partition's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track creation of the instance partition.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstancePartitionMetadata][google.spanner.admin.instance.v1.CreateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the instance in which to create the instance
        /// partition. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="instancePartition">
        /// Required. The instance partition to create. The instance_partition.name may
        /// be omitted, but if specified must be
        /// `&lt;parent&gt;/instancePartitions/&lt;instance_partition_id&gt;`.
        /// </param>
        /// <param name="instancePartitionId">
        /// Required. The ID of the instance partition to create. Valid identifiers are
        /// of the form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 2 and 64
        /// characters in length.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstancePartition, CreateInstancePartitionMetadata>> CreateInstancePartitionAsync(string parent, InstancePartition instancePartition, string instancePartitionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstancePartitionAsync(new CreateInstancePartitionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstancePartitionId = gax::GaxPreconditions.CheckNotNullOrEmpty(instancePartitionId, nameof(instancePartitionId)),
                InstancePartition = gax::GaxPreconditions.CheckNotNull(instancePartition, nameof(instancePartition)),
            }, callSettings);

        /// <summary>
        /// Creates an instance partition and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new instance partition.
        /// The instance partition name is assigned by the caller. If the named
        /// instance partition already exists, `CreateInstancePartition` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance partition is readable via the API, with all requested
        /// attributes but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance partition immediately
        /// unreadable via the API.
        /// * The instance partition can be deleted.
        /// * All other attempts to modify the instance partition are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can start using this instance partition.
        /// * The instance partition's allocated resource levels are readable via the
        /// API.
        /// * The instance partition's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track creation of the instance partition.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstancePartitionMetadata][google.spanner.admin.instance.v1.CreateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the instance in which to create the instance
        /// partition. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="instancePartition">
        /// Required. The instance partition to create. The instance_partition.name may
        /// be omitted, but if specified must be
        /// `&lt;parent&gt;/instancePartitions/&lt;instance_partition_id&gt;`.
        /// </param>
        /// <param name="instancePartitionId">
        /// Required. The ID of the instance partition to create. Valid identifiers are
        /// of the form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 2 and 64
        /// characters in length.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstancePartition, CreateInstancePartitionMetadata>> CreateInstancePartitionAsync(string parent, InstancePartition instancePartition, string instancePartitionId, st::CancellationToken cancellationToken) =>
            CreateInstancePartitionAsync(parent, instancePartition, instancePartitionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an instance partition and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new instance partition.
        /// The instance partition name is assigned by the caller. If the named
        /// instance partition already exists, `CreateInstancePartition` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance partition is readable via the API, with all requested
        /// attributes but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance partition immediately
        /// unreadable via the API.
        /// * The instance partition can be deleted.
        /// * All other attempts to modify the instance partition are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can start using this instance partition.
        /// * The instance partition's allocated resource levels are readable via the
        /// API.
        /// * The instance partition's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track creation of the instance partition.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstancePartitionMetadata][google.spanner.admin.instance.v1.CreateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the instance in which to create the instance
        /// partition. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="instancePartition">
        /// Required. The instance partition to create. The instance_partition.name may
        /// be omitted, but if specified must be
        /// `&lt;parent&gt;/instancePartitions/&lt;instance_partition_id&gt;`.
        /// </param>
        /// <param name="instancePartitionId">
        /// Required. The ID of the instance partition to create. Valid identifiers are
        /// of the form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 2 and 64
        /// characters in length.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InstancePartition, CreateInstancePartitionMetadata> CreateInstancePartition(InstanceName parent, InstancePartition instancePartition, string instancePartitionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstancePartition(new CreateInstancePartitionRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstancePartitionId = gax::GaxPreconditions.CheckNotNullOrEmpty(instancePartitionId, nameof(instancePartitionId)),
                InstancePartition = gax::GaxPreconditions.CheckNotNull(instancePartition, nameof(instancePartition)),
            }, callSettings);

        /// <summary>
        /// Creates an instance partition and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new instance partition.
        /// The instance partition name is assigned by the caller. If the named
        /// instance partition already exists, `CreateInstancePartition` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance partition is readable via the API, with all requested
        /// attributes but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance partition immediately
        /// unreadable via the API.
        /// * The instance partition can be deleted.
        /// * All other attempts to modify the instance partition are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can start using this instance partition.
        /// * The instance partition's allocated resource levels are readable via the
        /// API.
        /// * The instance partition's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track creation of the instance partition.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstancePartitionMetadata][google.spanner.admin.instance.v1.CreateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the instance in which to create the instance
        /// partition. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="instancePartition">
        /// Required. The instance partition to create. The instance_partition.name may
        /// be omitted, but if specified must be
        /// `&lt;parent&gt;/instancePartitions/&lt;instance_partition_id&gt;`.
        /// </param>
        /// <param name="instancePartitionId">
        /// Required. The ID of the instance partition to create. Valid identifiers are
        /// of the form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 2 and 64
        /// characters in length.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstancePartition, CreateInstancePartitionMetadata>> CreateInstancePartitionAsync(InstanceName parent, InstancePartition instancePartition, string instancePartitionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstancePartitionAsync(new CreateInstancePartitionRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstancePartitionId = gax::GaxPreconditions.CheckNotNullOrEmpty(instancePartitionId, nameof(instancePartitionId)),
                InstancePartition = gax::GaxPreconditions.CheckNotNull(instancePartition, nameof(instancePartition)),
            }, callSettings);

        /// <summary>
        /// Creates an instance partition and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new instance partition.
        /// The instance partition name is assigned by the caller. If the named
        /// instance partition already exists, `CreateInstancePartition` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance partition is readable via the API, with all requested
        /// attributes but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance partition immediately
        /// unreadable via the API.
        /// * The instance partition can be deleted.
        /// * All other attempts to modify the instance partition are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can start using this instance partition.
        /// * The instance partition's allocated resource levels are readable via the
        /// API.
        /// * The instance partition's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track creation of the instance partition.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstancePartitionMetadata][google.spanner.admin.instance.v1.CreateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the instance in which to create the instance
        /// partition. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="instancePartition">
        /// Required. The instance partition to create. The instance_partition.name may
        /// be omitted, but if specified must be
        /// `&lt;parent&gt;/instancePartitions/&lt;instance_partition_id&gt;`.
        /// </param>
        /// <param name="instancePartitionId">
        /// Required. The ID of the instance partition to create. Valid identifiers are
        /// of the form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 2 and 64
        /// characters in length.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstancePartition, CreateInstancePartitionMetadata>> CreateInstancePartitionAsync(InstanceName parent, InstancePartition instancePartition, string instancePartitionId, st::CancellationToken cancellationToken) =>
            CreateInstancePartitionAsync(parent, instancePartition, instancePartitionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing instance partition. Requires that the
        /// instance partition is not used by any database or backup and is not the
        /// default instance partition of an instance.
        /// 
        /// Authorization requires `spanner.instancePartitions.delete` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteInstancePartition(DeleteInstancePartitionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing instance partition. Requires that the
        /// instance partition is not used by any database or backup and is not the
        /// default instance partition of an instance.
        /// 
        /// Authorization requires `spanner.instancePartitions.delete` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstancePartitionAsync(DeleteInstancePartitionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing instance partition. Requires that the
        /// instance partition is not used by any database or backup and is not the
        /// default instance partition of an instance.
        /// 
        /// Authorization requires `spanner.instancePartitions.delete` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstancePartitionAsync(DeleteInstancePartitionRequest request, st::CancellationToken cancellationToken) =>
            DeleteInstancePartitionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing instance partition. Requires that the
        /// instance partition is not used by any database or backup and is not the
        /// default instance partition of an instance.
        /// 
        /// Authorization requires `spanner.instancePartitions.delete` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance partition to be deleted.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/instancePartitions/{instance_partition}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteInstancePartition(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstancePartition(new DeleteInstancePartitionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing instance partition. Requires that the
        /// instance partition is not used by any database or backup and is not the
        /// default instance partition of an instance.
        /// 
        /// Authorization requires `spanner.instancePartitions.delete` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance partition to be deleted.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/instancePartitions/{instance_partition}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstancePartitionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstancePartitionAsync(new DeleteInstancePartitionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing instance partition. Requires that the
        /// instance partition is not used by any database or backup and is not the
        /// default instance partition of an instance.
        /// 
        /// Authorization requires `spanner.instancePartitions.delete` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance partition to be deleted.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/instancePartitions/{instance_partition}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstancePartitionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInstancePartitionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing instance partition. Requires that the
        /// instance partition is not used by any database or backup and is not the
        /// default instance partition of an instance.
        /// 
        /// Authorization requires `spanner.instancePartitions.delete` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance partition to be deleted.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/instancePartitions/{instance_partition}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteInstancePartition(InstancePartitionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstancePartition(new DeleteInstancePartitionRequest
            {
                InstancePartitionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing instance partition. Requires that the
        /// instance partition is not used by any database or backup and is not the
        /// default instance partition of an instance.
        /// 
        /// Authorization requires `spanner.instancePartitions.delete` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance partition to be deleted.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/instancePartitions/{instance_partition}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstancePartitionAsync(InstancePartitionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstancePartitionAsync(new DeleteInstancePartitionRequest
            {
                InstancePartitionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing instance partition. Requires that the
        /// instance partition is not used by any database or backup and is not the
        /// default instance partition of an instance.
        /// 
        /// Authorization requires `spanner.instancePartitions.delete` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance partition to be deleted.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/instancePartitions/{instance_partition}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstancePartitionAsync(InstancePartitionName name, st::CancellationToken cancellationToken) =>
            DeleteInstancePartitionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an instance partition, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance partition. If the named instance
        /// partition does not exist, returns `NOT_FOUND`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * For resource types for which a decrease in the instance partition's
        /// allocation has been requested, billing is based on the newly-requested
        /// level.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstancePartitionMetadata.cancel_time],
        /// and begins restoring resources to their pre-request values. The
        /// operation is guaranteed to succeed at undoing all resource changes,
        /// after which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance partition are rejected.
        /// * Reading the instance partition via the API continues to give the
        /// pre-request resource levels.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing begins for all successfully-allocated resources (some types
        /// may have lower than the requested levels).
        /// * All newly-reserved resources are available for serving the instance
        /// partition's tables.
        /// * The instance partition's new resource levels are readable via the API.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track the instance partition modification. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstancePartitionMetadata][google.spanner.admin.instance.v1.UpdateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instancePartitions.update` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InstancePartition, UpdateInstancePartitionMetadata> UpdateInstancePartition(UpdateInstancePartitionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an instance partition, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance partition. If the named instance
        /// partition does not exist, returns `NOT_FOUND`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * For resource types for which a decrease in the instance partition's
        /// allocation has been requested, billing is based on the newly-requested
        /// level.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstancePartitionMetadata.cancel_time],
        /// and begins restoring resources to their pre-request values. The
        /// operation is guaranteed to succeed at undoing all resource changes,
        /// after which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance partition are rejected.
        /// * Reading the instance partition via the API continues to give the
        /// pre-request resource levels.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing begins for all successfully-allocated resources (some types
        /// may have lower than the requested levels).
        /// * All newly-reserved resources are available for serving the instance
        /// partition's tables.
        /// * The instance partition's new resource levels are readable via the API.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track the instance partition modification. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstancePartitionMetadata][google.spanner.admin.instance.v1.UpdateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instancePartitions.update` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstancePartition, UpdateInstancePartitionMetadata>> UpdateInstancePartitionAsync(UpdateInstancePartitionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an instance partition, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance partition. If the named instance
        /// partition does not exist, returns `NOT_FOUND`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * For resource types for which a decrease in the instance partition's
        /// allocation has been requested, billing is based on the newly-requested
        /// level.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstancePartitionMetadata.cancel_time],
        /// and begins restoring resources to their pre-request values. The
        /// operation is guaranteed to succeed at undoing all resource changes,
        /// after which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance partition are rejected.
        /// * Reading the instance partition via the API continues to give the
        /// pre-request resource levels.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing begins for all successfully-allocated resources (some types
        /// may have lower than the requested levels).
        /// * All newly-reserved resources are available for serving the instance
        /// partition's tables.
        /// * The instance partition's new resource levels are readable via the API.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track the instance partition modification. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstancePartitionMetadata][google.spanner.admin.instance.v1.UpdateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instancePartitions.update` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstancePartition, UpdateInstancePartitionMetadata>> UpdateInstancePartitionAsync(UpdateInstancePartitionRequest request, st::CancellationToken cancellationToken) =>
            UpdateInstancePartitionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateInstancePartition</c>.</summary>
        public virtual lro::OperationsClient UpdateInstancePartitionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInstancePartition</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InstancePartition, UpdateInstancePartitionMetadata> PollOnceUpdateInstancePartition(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InstancePartition, UpdateInstancePartitionMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstancePartitionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInstancePartition</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InstancePartition, UpdateInstancePartitionMetadata>> PollOnceUpdateInstancePartitionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InstancePartition, UpdateInstancePartitionMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstancePartitionOperationsClient, callSettings);

        /// <summary>
        /// Updates an instance partition, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance partition. If the named instance
        /// partition does not exist, returns `NOT_FOUND`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * For resource types for which a decrease in the instance partition's
        /// allocation has been requested, billing is based on the newly-requested
        /// level.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstancePartitionMetadata.cancel_time],
        /// and begins restoring resources to their pre-request values. The
        /// operation is guaranteed to succeed at undoing all resource changes,
        /// after which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance partition are rejected.
        /// * Reading the instance partition via the API continues to give the
        /// pre-request resource levels.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing begins for all successfully-allocated resources (some types
        /// may have lower than the requested levels).
        /// * All newly-reserved resources are available for serving the instance
        /// partition's tables.
        /// * The instance partition's new resource levels are readable via the API.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track the instance partition modification. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstancePartitionMetadata][google.spanner.admin.instance.v1.UpdateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instancePartitions.update` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="instancePartition">
        /// Required. The instance partition to update, which must always include the
        /// instance partition name. Otherwise, only fields mentioned in
        /// [field_mask][google.spanner.admin.instance.v1.UpdateInstancePartitionRequest.field_mask]
        /// need be included.
        /// </param>
        /// <param name="fieldMask">
        /// Required. A mask specifying which fields in
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition]
        /// should be updated. The field mask must always be specified; this prevents
        /// any future fields in
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition]
        /// from being erased accidentally by clients that do not know about them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InstancePartition, UpdateInstancePartitionMetadata> UpdateInstancePartition(InstancePartition instancePartition, wkt::FieldMask fieldMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstancePartition(new UpdateInstancePartitionRequest
            {
                InstancePartition = gax::GaxPreconditions.CheckNotNull(instancePartition, nameof(instancePartition)),
                FieldMask = gax::GaxPreconditions.CheckNotNull(fieldMask, nameof(fieldMask)),
            }, callSettings);

        /// <summary>
        /// Updates an instance partition, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance partition. If the named instance
        /// partition does not exist, returns `NOT_FOUND`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * For resource types for which a decrease in the instance partition's
        /// allocation has been requested, billing is based on the newly-requested
        /// level.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstancePartitionMetadata.cancel_time],
        /// and begins restoring resources to their pre-request values. The
        /// operation is guaranteed to succeed at undoing all resource changes,
        /// after which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance partition are rejected.
        /// * Reading the instance partition via the API continues to give the
        /// pre-request resource levels.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing begins for all successfully-allocated resources (some types
        /// may have lower than the requested levels).
        /// * All newly-reserved resources are available for serving the instance
        /// partition's tables.
        /// * The instance partition's new resource levels are readable via the API.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track the instance partition modification. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstancePartitionMetadata][google.spanner.admin.instance.v1.UpdateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instancePartitions.update` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="instancePartition">
        /// Required. The instance partition to update, which must always include the
        /// instance partition name. Otherwise, only fields mentioned in
        /// [field_mask][google.spanner.admin.instance.v1.UpdateInstancePartitionRequest.field_mask]
        /// need be included.
        /// </param>
        /// <param name="fieldMask">
        /// Required. A mask specifying which fields in
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition]
        /// should be updated. The field mask must always be specified; this prevents
        /// any future fields in
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition]
        /// from being erased accidentally by clients that do not know about them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstancePartition, UpdateInstancePartitionMetadata>> UpdateInstancePartitionAsync(InstancePartition instancePartition, wkt::FieldMask fieldMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstancePartitionAsync(new UpdateInstancePartitionRequest
            {
                InstancePartition = gax::GaxPreconditions.CheckNotNull(instancePartition, nameof(instancePartition)),
                FieldMask = gax::GaxPreconditions.CheckNotNull(fieldMask, nameof(fieldMask)),
            }, callSettings);

        /// <summary>
        /// Updates an instance partition, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance partition. If the named instance
        /// partition does not exist, returns `NOT_FOUND`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * For resource types for which a decrease in the instance partition's
        /// allocation has been requested, billing is based on the newly-requested
        /// level.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstancePartitionMetadata.cancel_time],
        /// and begins restoring resources to their pre-request values. The
        /// operation is guaranteed to succeed at undoing all resource changes,
        /// after which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance partition are rejected.
        /// * Reading the instance partition via the API continues to give the
        /// pre-request resource levels.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing begins for all successfully-allocated resources (some types
        /// may have lower than the requested levels).
        /// * All newly-reserved resources are available for serving the instance
        /// partition's tables.
        /// * The instance partition's new resource levels are readable via the API.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track the instance partition modification. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstancePartitionMetadata][google.spanner.admin.instance.v1.UpdateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instancePartitions.update` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="instancePartition">
        /// Required. The instance partition to update, which must always include the
        /// instance partition name. Otherwise, only fields mentioned in
        /// [field_mask][google.spanner.admin.instance.v1.UpdateInstancePartitionRequest.field_mask]
        /// need be included.
        /// </param>
        /// <param name="fieldMask">
        /// Required. A mask specifying which fields in
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition]
        /// should be updated. The field mask must always be specified; this prevents
        /// any future fields in
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition]
        /// from being erased accidentally by clients that do not know about them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InstancePartition, UpdateInstancePartitionMetadata>> UpdateInstancePartitionAsync(InstancePartition instancePartition, wkt::FieldMask fieldMask, st::CancellationToken cancellationToken) =>
            UpdateInstancePartitionAsync(instancePartition, fieldMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists instance partition [long-running
        /// operations][google.longrunning.Operation] in the given instance.
        /// An instance partition operation has a name of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/instancePartitions/&lt;instance_partition&gt;/operations/&lt;operation&gt;`.
        /// The long-running operation
        /// [metadata][google.longrunning.Operation.metadata] field type
        /// `metadata.type_url` describes the type of the metadata. Operations returned
        /// include those that have completed/failed/canceled within the last 7 days,
        /// and pending operations. Operations returned are ordered by
        /// `operation.metadata.value.start_time` in descending order starting from the
        /// most recently started operation.
        /// 
        /// Authorization requires `spanner.instancePartitionOperations.list`
        /// permission on the resource
        /// [parent][google.spanner.admin.instance.v1.ListInstancePartitionOperationsRequest.parent].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="lro::Operation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancePartitionOperationsResponse, lro::Operation> ListInstancePartitionOperations(ListInstancePartitionOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists instance partition [long-running
        /// operations][google.longrunning.Operation] in the given instance.
        /// An instance partition operation has a name of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/instancePartitions/&lt;instance_partition&gt;/operations/&lt;operation&gt;`.
        /// The long-running operation
        /// [metadata][google.longrunning.Operation.metadata] field type
        /// `metadata.type_url` describes the type of the metadata. Operations returned
        /// include those that have completed/failed/canceled within the last 7 days,
        /// and pending operations. Operations returned are ordered by
        /// `operation.metadata.value.start_time` in descending order starting from the
        /// most recently started operation.
        /// 
        /// Authorization requires `spanner.instancePartitionOperations.list`
        /// permission on the resource
        /// [parent][google.spanner.admin.instance.v1.ListInstancePartitionOperationsRequest.parent].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="lro::Operation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancePartitionOperationsResponse, lro::Operation> ListInstancePartitionOperationsAsync(ListInstancePartitionOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists instance partition [long-running
        /// operations][google.longrunning.Operation] in the given instance.
        /// An instance partition operation has a name of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/instancePartitions/&lt;instance_partition&gt;/operations/&lt;operation&gt;`.
        /// The long-running operation
        /// [metadata][google.longrunning.Operation.metadata] field type
        /// `metadata.type_url` describes the type of the metadata. Operations returned
        /// include those that have completed/failed/canceled within the last 7 days,
        /// and pending operations. Operations returned are ordered by
        /// `operation.metadata.value.start_time` in descending order starting from the
        /// most recently started operation.
        /// 
        /// Authorization requires `spanner.instancePartitionOperations.list`
        /// permission on the resource
        /// [parent][google.spanner.admin.instance.v1.ListInstancePartitionOperationsRequest.parent].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent instance of the instance partition operations.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// <returns>A pageable sequence of <see cref="lro::Operation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancePartitionOperationsResponse, lro::Operation> ListInstancePartitionOperations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancePartitionOperationsRequest request = new ListInstancePartitionOperationsRequest
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
            return ListInstancePartitionOperations(request, callSettings);
        }

        /// <summary>
        /// Lists instance partition [long-running
        /// operations][google.longrunning.Operation] in the given instance.
        /// An instance partition operation has a name of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/instancePartitions/&lt;instance_partition&gt;/operations/&lt;operation&gt;`.
        /// The long-running operation
        /// [metadata][google.longrunning.Operation.metadata] field type
        /// `metadata.type_url` describes the type of the metadata. Operations returned
        /// include those that have completed/failed/canceled within the last 7 days,
        /// and pending operations. Operations returned are ordered by
        /// `operation.metadata.value.start_time` in descending order starting from the
        /// most recently started operation.
        /// 
        /// Authorization requires `spanner.instancePartitionOperations.list`
        /// permission on the resource
        /// [parent][google.spanner.admin.instance.v1.ListInstancePartitionOperationsRequest.parent].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent instance of the instance partition operations.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="lro::Operation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancePartitionOperationsResponse, lro::Operation> ListInstancePartitionOperationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancePartitionOperationsRequest request = new ListInstancePartitionOperationsRequest
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
            return ListInstancePartitionOperationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists instance partition [long-running
        /// operations][google.longrunning.Operation] in the given instance.
        /// An instance partition operation has a name of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/instancePartitions/&lt;instance_partition&gt;/operations/&lt;operation&gt;`.
        /// The long-running operation
        /// [metadata][google.longrunning.Operation.metadata] field type
        /// `metadata.type_url` describes the type of the metadata. Operations returned
        /// include those that have completed/failed/canceled within the last 7 days,
        /// and pending operations. Operations returned are ordered by
        /// `operation.metadata.value.start_time` in descending order starting from the
        /// most recently started operation.
        /// 
        /// Authorization requires `spanner.instancePartitionOperations.list`
        /// permission on the resource
        /// [parent][google.spanner.admin.instance.v1.ListInstancePartitionOperationsRequest.parent].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent instance of the instance partition operations.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// <returns>A pageable sequence of <see cref="lro::Operation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancePartitionOperationsResponse, lro::Operation> ListInstancePartitionOperations(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancePartitionOperationsRequest request = new ListInstancePartitionOperationsRequest
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
            return ListInstancePartitionOperations(request, callSettings);
        }

        /// <summary>
        /// Lists instance partition [long-running
        /// operations][google.longrunning.Operation] in the given instance.
        /// An instance partition operation has a name of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/instancePartitions/&lt;instance_partition&gt;/operations/&lt;operation&gt;`.
        /// The long-running operation
        /// [metadata][google.longrunning.Operation.metadata] field type
        /// `metadata.type_url` describes the type of the metadata. Operations returned
        /// include those that have completed/failed/canceled within the last 7 days,
        /// and pending operations. Operations returned are ordered by
        /// `operation.metadata.value.start_time` in descending order starting from the
        /// most recently started operation.
        /// 
        /// Authorization requires `spanner.instancePartitionOperations.list`
        /// permission on the resource
        /// [parent][google.spanner.admin.instance.v1.ListInstancePartitionOperationsRequest.parent].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent instance of the instance partition operations.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="lro::Operation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancePartitionOperationsResponse, lro::Operation> ListInstancePartitionOperationsAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancePartitionOperationsRequest request = new ListInstancePartitionOperationsRequest
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
            return ListInstancePartitionOperationsAsync(request, callSettings);
        }
    }

    /// <summary>InstanceAdmin client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Cloud Spanner Instance Admin API
    /// 
    /// The Cloud Spanner Instance Admin API can be used to create, delete,
    /// modify and list instances. Instances are dedicated Cloud Spanner serving
    /// and storage resources to be used by Cloud Spanner databases.
    /// 
    /// Each instance has a "configuration", which dictates where the
    /// serving resources for the Cloud Spanner instance are located (e.g.,
    /// US-central, Europe). Configurations are created by Google based on
    /// resource availability.
    /// 
    /// Cloud Spanner billing is based on the instances that exist and their
    /// sizes. After an instance exists, there are no additional
    /// per-database or per-operation charges for use of the instance
    /// (though there may be additional network bandwidth charges).
    /// Instances offer isolation: problems with databases in one instance
    /// will not affect other instances. However, within an instance
    /// databases can affect each other. For example, if one database in an
    /// instance receives a lot of requests and consumes most of the
    /// instance resources, fewer resources are available for other
    /// databases in that instance, and their performance may suffer.
    /// </remarks>
    public sealed partial class InstanceAdminClientImpl : InstanceAdminClient
    {
        private readonly gaxgrpc::ApiCall<ListInstanceConfigsRequest, ListInstanceConfigsResponse> _callListInstanceConfigs;

        private readonly gaxgrpc::ApiCall<GetInstanceConfigRequest, InstanceConfig> _callGetInstanceConfig;

        private readonly gaxgrpc::ApiCall<CreateInstanceConfigRequest, lro::Operation> _callCreateInstanceConfig;

        private readonly gaxgrpc::ApiCall<UpdateInstanceConfigRequest, lro::Operation> _callUpdateInstanceConfig;

        private readonly gaxgrpc::ApiCall<DeleteInstanceConfigRequest, wkt::Empty> _callDeleteInstanceConfig;

        private readonly gaxgrpc::ApiCall<ListInstanceConfigOperationsRequest, ListInstanceConfigOperationsResponse> _callListInstanceConfigOperations;

        private readonly gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;

        private readonly gaxgrpc::ApiCall<ListInstancePartitionsRequest, ListInstancePartitionsResponse> _callListInstancePartitions;

        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGetInstance;

        private readonly gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> _callCreateInstance;

        private readonly gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> _callUpdateInstance;

        private readonly gaxgrpc::ApiCall<DeleteInstanceRequest, wkt::Empty> _callDeleteInstance;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        private readonly gaxgrpc::ApiCall<GetInstancePartitionRequest, InstancePartition> _callGetInstancePartition;

        private readonly gaxgrpc::ApiCall<CreateInstancePartitionRequest, lro::Operation> _callCreateInstancePartition;

        private readonly gaxgrpc::ApiCall<DeleteInstancePartitionRequest, wkt::Empty> _callDeleteInstancePartition;

        private readonly gaxgrpc::ApiCall<UpdateInstancePartitionRequest, lro::Operation> _callUpdateInstancePartition;

        private readonly gaxgrpc::ApiCall<ListInstancePartitionOperationsRequest, ListInstancePartitionOperationsResponse> _callListInstancePartitionOperations;

        /// <summary>
        /// Constructs a client wrapper for the InstanceAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="InstanceAdminSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public InstanceAdminClientImpl(InstanceAdmin.InstanceAdminClient grpcClient, InstanceAdminSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            InstanceAdminSettings effectiveSettings = settings ?? InstanceAdminSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateInstanceConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstanceConfigOperationsSettings, logger);
            UpdateInstanceConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInstanceConfigOperationsSettings, logger);
            CreateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstanceOperationsSettings, logger);
            UpdateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInstanceOperationsSettings, logger);
            CreateInstancePartitionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstancePartitionOperationsSettings, logger);
            UpdateInstancePartitionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInstancePartitionOperationsSettings, logger);
            _callListInstanceConfigs = clientHelper.BuildApiCall<ListInstanceConfigsRequest, ListInstanceConfigsResponse>("ListInstanceConfigs", grpcClient.ListInstanceConfigsAsync, grpcClient.ListInstanceConfigs, effectiveSettings.ListInstanceConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstanceConfigs);
            Modify_ListInstanceConfigsApiCall(ref _callListInstanceConfigs);
            _callGetInstanceConfig = clientHelper.BuildApiCall<GetInstanceConfigRequest, InstanceConfig>("GetInstanceConfig", grpcClient.GetInstanceConfigAsync, grpcClient.GetInstanceConfig, effectiveSettings.GetInstanceConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstanceConfig);
            Modify_GetInstanceConfigApiCall(ref _callGetInstanceConfig);
            _callCreateInstanceConfig = clientHelper.BuildApiCall<CreateInstanceConfigRequest, lro::Operation>("CreateInstanceConfig", grpcClient.CreateInstanceConfigAsync, grpcClient.CreateInstanceConfig, effectiveSettings.CreateInstanceConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInstanceConfig);
            Modify_CreateInstanceConfigApiCall(ref _callCreateInstanceConfig);
            _callUpdateInstanceConfig = clientHelper.BuildApiCall<UpdateInstanceConfigRequest, lro::Operation>("UpdateInstanceConfig", grpcClient.UpdateInstanceConfigAsync, grpcClient.UpdateInstanceConfig, effectiveSettings.UpdateInstanceConfigSettings).WithGoogleRequestParam("instance_config.name", request => request.InstanceConfig?.Name);
            Modify_ApiCall(ref _callUpdateInstanceConfig);
            Modify_UpdateInstanceConfigApiCall(ref _callUpdateInstanceConfig);
            _callDeleteInstanceConfig = clientHelper.BuildApiCall<DeleteInstanceConfigRequest, wkt::Empty>("DeleteInstanceConfig", grpcClient.DeleteInstanceConfigAsync, grpcClient.DeleteInstanceConfig, effectiveSettings.DeleteInstanceConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInstanceConfig);
            Modify_DeleteInstanceConfigApiCall(ref _callDeleteInstanceConfig);
            _callListInstanceConfigOperations = clientHelper.BuildApiCall<ListInstanceConfigOperationsRequest, ListInstanceConfigOperationsResponse>("ListInstanceConfigOperations", grpcClient.ListInstanceConfigOperationsAsync, grpcClient.ListInstanceConfigOperations, effectiveSettings.ListInstanceConfigOperationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstanceConfigOperations);
            Modify_ListInstanceConfigOperationsApiCall(ref _callListInstanceConfigOperations);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>("ListInstances", grpcClient.ListInstancesAsync, grpcClient.ListInstances, effectiveSettings.ListInstancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            _callListInstancePartitions = clientHelper.BuildApiCall<ListInstancePartitionsRequest, ListInstancePartitionsResponse>("ListInstancePartitions", grpcClient.ListInstancePartitionsAsync, grpcClient.ListInstancePartitions, effectiveSettings.ListInstancePartitionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstancePartitions);
            Modify_ListInstancePartitionsApiCall(ref _callListInstancePartitions);
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>("GetInstance", grpcClient.GetInstanceAsync, grpcClient.GetInstance, effectiveSettings.GetInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstance);
            Modify_GetInstanceApiCall(ref _callGetInstance);
            _callCreateInstance = clientHelper.BuildApiCall<CreateInstanceRequest, lro::Operation>("CreateInstance", grpcClient.CreateInstanceAsync, grpcClient.CreateInstance, effectiveSettings.CreateInstanceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInstance);
            Modify_CreateInstanceApiCall(ref _callCreateInstance);
            _callUpdateInstance = clientHelper.BuildApiCall<UpdateInstanceRequest, lro::Operation>("UpdateInstance", grpcClient.UpdateInstanceAsync, grpcClient.UpdateInstance, effectiveSettings.UpdateInstanceSettings).WithGoogleRequestParam("instance.name", request => request.Instance?.Name);
            Modify_ApiCall(ref _callUpdateInstance);
            Modify_UpdateInstanceApiCall(ref _callUpdateInstance);
            _callDeleteInstance = clientHelper.BuildApiCall<DeleteInstanceRequest, wkt::Empty>("DeleteInstance", grpcClient.DeleteInstanceAsync, grpcClient.DeleteInstance, effectiveSettings.DeleteInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInstance);
            Modify_DeleteInstanceApiCall(ref _callDeleteInstance);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            _callGetInstancePartition = clientHelper.BuildApiCall<GetInstancePartitionRequest, InstancePartition>("GetInstancePartition", grpcClient.GetInstancePartitionAsync, grpcClient.GetInstancePartition, effectiveSettings.GetInstancePartitionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstancePartition);
            Modify_GetInstancePartitionApiCall(ref _callGetInstancePartition);
            _callCreateInstancePartition = clientHelper.BuildApiCall<CreateInstancePartitionRequest, lro::Operation>("CreateInstancePartition", grpcClient.CreateInstancePartitionAsync, grpcClient.CreateInstancePartition, effectiveSettings.CreateInstancePartitionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInstancePartition);
            Modify_CreateInstancePartitionApiCall(ref _callCreateInstancePartition);
            _callDeleteInstancePartition = clientHelper.BuildApiCall<DeleteInstancePartitionRequest, wkt::Empty>("DeleteInstancePartition", grpcClient.DeleteInstancePartitionAsync, grpcClient.DeleteInstancePartition, effectiveSettings.DeleteInstancePartitionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInstancePartition);
            Modify_DeleteInstancePartitionApiCall(ref _callDeleteInstancePartition);
            _callUpdateInstancePartition = clientHelper.BuildApiCall<UpdateInstancePartitionRequest, lro::Operation>("UpdateInstancePartition", grpcClient.UpdateInstancePartitionAsync, grpcClient.UpdateInstancePartition, effectiveSettings.UpdateInstancePartitionSettings).WithGoogleRequestParam("instance_partition.name", request => request.InstancePartition?.Name);
            Modify_ApiCall(ref _callUpdateInstancePartition);
            Modify_UpdateInstancePartitionApiCall(ref _callUpdateInstancePartition);
            _callListInstancePartitionOperations = clientHelper.BuildApiCall<ListInstancePartitionOperationsRequest, ListInstancePartitionOperationsResponse>("ListInstancePartitionOperations", grpcClient.ListInstancePartitionOperationsAsync, grpcClient.ListInstancePartitionOperations, effectiveSettings.ListInstancePartitionOperationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstancePartitionOperations);
            Modify_ListInstancePartitionOperationsApiCall(ref _callListInstancePartitionOperations);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListInstanceConfigsApiCall(ref gaxgrpc::ApiCall<ListInstanceConfigsRequest, ListInstanceConfigsResponse> call);

        partial void Modify_GetInstanceConfigApiCall(ref gaxgrpc::ApiCall<GetInstanceConfigRequest, InstanceConfig> call);

        partial void Modify_CreateInstanceConfigApiCall(ref gaxgrpc::ApiCall<CreateInstanceConfigRequest, lro::Operation> call);

        partial void Modify_UpdateInstanceConfigApiCall(ref gaxgrpc::ApiCall<UpdateInstanceConfigRequest, lro::Operation> call);

        partial void Modify_DeleteInstanceConfigApiCall(ref gaxgrpc::ApiCall<DeleteInstanceConfigRequest, wkt::Empty> call);

        partial void Modify_ListInstanceConfigOperationsApiCall(ref gaxgrpc::ApiCall<ListInstanceConfigOperationsRequest, ListInstanceConfigOperationsResponse> call);

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);

        partial void Modify_ListInstancePartitionsApiCall(ref gaxgrpc::ApiCall<ListInstancePartitionsRequest, ListInstancePartitionsResponse> call);

        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);

        partial void Modify_CreateInstanceApiCall(ref gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> call);

        partial void Modify_UpdateInstanceApiCall(ref gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> call);

        partial void Modify_DeleteInstanceApiCall(ref gaxgrpc::ApiCall<DeleteInstanceRequest, wkt::Empty> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void Modify_GetInstancePartitionApiCall(ref gaxgrpc::ApiCall<GetInstancePartitionRequest, InstancePartition> call);

        partial void Modify_CreateInstancePartitionApiCall(ref gaxgrpc::ApiCall<CreateInstancePartitionRequest, lro::Operation> call);

        partial void Modify_DeleteInstancePartitionApiCall(ref gaxgrpc::ApiCall<DeleteInstancePartitionRequest, wkt::Empty> call);

        partial void Modify_UpdateInstancePartitionApiCall(ref gaxgrpc::ApiCall<UpdateInstancePartitionRequest, lro::Operation> call);

        partial void Modify_ListInstancePartitionOperationsApiCall(ref gaxgrpc::ApiCall<ListInstancePartitionOperationsRequest, ListInstancePartitionOperationsResponse> call);

        partial void OnConstruction(InstanceAdmin.InstanceAdminClient grpcClient, InstanceAdminSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC InstanceAdmin client</summary>
        public override InstanceAdmin.InstanceAdminClient GrpcClient { get; }

        partial void Modify_ListInstanceConfigsRequest(ref ListInstanceConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceConfigRequest(ref GetInstanceConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInstanceConfigRequest(ref CreateInstanceConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInstanceConfigRequest(ref UpdateInstanceConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInstanceConfigRequest(ref DeleteInstanceConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInstanceConfigOperationsRequest(ref ListInstanceConfigOperationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInstancePartitionsRequest(ref ListInstancePartitionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInstanceRequest(ref UpdateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstancePartitionRequest(ref GetInstancePartitionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInstancePartitionRequest(ref CreateInstancePartitionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInstancePartitionRequest(ref DeleteInstancePartitionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInstancePartitionRequest(ref UpdateInstancePartitionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInstancePartitionOperationsRequest(ref ListInstancePartitionOperationsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the supported instance configurations for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InstanceConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigs(ListInstanceConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstanceConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstanceConfigsRequest, ListInstanceConfigsResponse, InstanceConfig>(_callListInstanceConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists the supported instance configurations for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigsAsync(ListInstanceConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstanceConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstanceConfigsRequest, ListInstanceConfigsResponse, InstanceConfig>(_callListInstanceConfigs, request, callSettings);
        }

        /// <summary>
        /// Gets information about a particular instance configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InstanceConfig GetInstanceConfig(GetInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceConfigRequest(ref request, ref callSettings);
            return _callGetInstanceConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a particular instance configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InstanceConfig> GetInstanceConfigAsync(GetInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceConfigRequest(ref request, ref callSettings);
            return _callGetInstanceConfig.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateInstanceConfig</c>.</summary>
        public override lro::OperationsClient CreateInstanceConfigOperationsClient { get; }

        /// <summary>
        /// Creates an instance config and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance config. The instance config name is assigned by the caller. If the
        /// named instance config already exists, `CreateInstanceConfig` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config is readable via the API, with all requested
        /// attributes. The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true. Its state is `CREATING`.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation renders the instance config immediately
        /// unreadable via the API.
        /// * Except for deleting the creating resource, all other attempts to modify
        /// the instance config are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Instances can be created using the instance configuration.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false. Its state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// creation of the instance config. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceConfigMetadata][google.spanner.admin.instance.v1.CreateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.create` permission on
        /// the resource
        /// [parent][google.spanner.admin.instance.v1.CreateInstanceConfigRequest.parent].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InstanceConfig, CreateInstanceConfigMetadata> CreateInstanceConfig(CreateInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceConfigRequest(ref request, ref callSettings);
            return new lro::Operation<InstanceConfig, CreateInstanceConfigMetadata>(_callCreateInstanceConfig.Sync(request, callSettings), CreateInstanceConfigOperationsClient);
        }

        /// <summary>
        /// Creates an instance config and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance config. The instance config name is assigned by the caller. If the
        /// named instance config already exists, `CreateInstanceConfig` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config is readable via the API, with all requested
        /// attributes. The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true. Its state is `CREATING`.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation renders the instance config immediately
        /// unreadable via the API.
        /// * Except for deleting the creating resource, all other attempts to modify
        /// the instance config are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Instances can be created using the instance configuration.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false. Its state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// creation of the instance config. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceConfigMetadata][google.spanner.admin.instance.v1.CreateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.create` permission on
        /// the resource
        /// [parent][google.spanner.admin.instance.v1.CreateInstanceConfigRequest.parent].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InstanceConfig, CreateInstanceConfigMetadata>> CreateInstanceConfigAsync(CreateInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceConfigRequest(ref request, ref callSettings);
            return new lro::Operation<InstanceConfig, CreateInstanceConfigMetadata>(await _callCreateInstanceConfig.Async(request, callSettings).ConfigureAwait(false), CreateInstanceConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateInstanceConfig</c>.</summary>
        public override lro::OperationsClient UpdateInstanceConfigOperationsClient { get; }

        /// <summary>
        /// Updates an instance config. The returned
        /// [long-running operation][google.longrunning.Operation] can be used to track
        /// the progress of updating the instance. If the named instance config does
        /// not exist, returns `NOT_FOUND`.
        /// 
        /// Only user managed configurations can be updated.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceConfigMetadata.cancel_time].
        /// The operation is guaranteed to succeed at undoing all changes, after
        /// which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance config are rejected.
        /// * Reading the instance config via the API continues to give the
        /// pre-request values.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Creating instances using the instance configuration uses the new
        /// values.
        /// * The instance config's new values are readable via the API.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// the instance config modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceConfigMetadata][google.spanner.admin.instance.v1.UpdateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.update` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InstanceConfig, UpdateInstanceConfigMetadata> UpdateInstanceConfig(UpdateInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceConfigRequest(ref request, ref callSettings);
            return new lro::Operation<InstanceConfig, UpdateInstanceConfigMetadata>(_callUpdateInstanceConfig.Sync(request, callSettings), UpdateInstanceConfigOperationsClient);
        }

        /// <summary>
        /// Updates an instance config. The returned
        /// [long-running operation][google.longrunning.Operation] can be used to track
        /// the progress of updating the instance. If the named instance config does
        /// not exist, returns `NOT_FOUND`.
        /// 
        /// Only user managed configurations can be updated.
        /// 
        /// Immediately after the request returns:
        /// 
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field is set to true.
        /// 
        /// While the operation is pending:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceConfigMetadata.cancel_time].
        /// The operation is guaranteed to succeed at undoing all changes, after
        /// which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance config are rejected.
        /// * Reading the instance config via the API continues to give the
        /// pre-request values.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Creating instances using the instance configuration uses the new
        /// values.
        /// * The instance config's new values are readable via the API.
        /// * The instance config's
        /// [reconciling][google.spanner.admin.instance.v1.InstanceConfig.reconciling]
        /// field becomes false.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_config_name&gt;/operations/&lt;operation_id&gt;` and can be used to track
        /// the instance config modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceConfigMetadata][google.spanner.admin.instance.v1.UpdateInstanceConfigMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstanceConfig][google.spanner.admin.instance.v1.InstanceConfig], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instanceConfigs.update` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InstanceConfig, UpdateInstanceConfigMetadata>> UpdateInstanceConfigAsync(UpdateInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceConfigRequest(ref request, ref callSettings);
            return new lro::Operation<InstanceConfig, UpdateInstanceConfigMetadata>(await _callUpdateInstanceConfig.Async(request, callSettings).ConfigureAwait(false), UpdateInstanceConfigOperationsClient);
        }

        /// <summary>
        /// Deletes the instance config. Deletion is only allowed when no
        /// instances are using the configuration. If any instances are using
        /// the config, returns `FAILED_PRECONDITION`.
        /// 
        /// Only user managed configurations can be deleted.
        /// 
        /// Authorization requires `spanner.instanceConfigs.delete` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteInstanceConfig(DeleteInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceConfigRequest(ref request, ref callSettings);
            _callDeleteInstanceConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the instance config. Deletion is only allowed when no
        /// instances are using the configuration. If any instances are using
        /// the config, returns `FAILED_PRECONDITION`.
        /// 
        /// Only user managed configurations can be deleted.
        /// 
        /// Authorization requires `spanner.instanceConfigs.delete` permission on
        /// the resource [name][google.spanner.admin.instance.v1.InstanceConfig.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteInstanceConfigAsync(DeleteInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceConfigRequest(ref request, ref callSettings);
            return _callDeleteInstanceConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the user-managed instance config [long-running
        /// operations][google.longrunning.Operation] in the given project. An instance
        /// config operation has a name of the form
        /// `projects/&lt;project&gt;/instanceConfigs/&lt;instance_config&gt;/operations/&lt;operation&gt;`.
        /// The long-running operation
        /// [metadata][google.longrunning.Operation.metadata] field type
        /// `metadata.type_url` describes the type of the metadata. Operations returned
        /// include those that have completed/failed/canceled within the last 7 days,
        /// and pending operations. Operations returned are ordered by
        /// `operation.metadata.value.start_time` in descending order starting
        /// from the most recently started operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="lro::Operation"/> resources.</returns>
        public override gax::PagedEnumerable<ListInstanceConfigOperationsResponse, lro::Operation> ListInstanceConfigOperations(ListInstanceConfigOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstanceConfigOperationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstanceConfigOperationsRequest, ListInstanceConfigOperationsResponse, lro::Operation>(_callListInstanceConfigOperations, request, callSettings);
        }

        /// <summary>
        /// Lists the user-managed instance config [long-running
        /// operations][google.longrunning.Operation] in the given project. An instance
        /// config operation has a name of the form
        /// `projects/&lt;project&gt;/instanceConfigs/&lt;instance_config&gt;/operations/&lt;operation&gt;`.
        /// The long-running operation
        /// [metadata][google.longrunning.Operation.metadata] field type
        /// `metadata.type_url` describes the type of the metadata. Operations returned
        /// include those that have completed/failed/canceled within the last 7 days,
        /// and pending operations. Operations returned are ordered by
        /// `operation.metadata.value.start_time` in descending order starting
        /// from the most recently started operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="lro::Operation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInstanceConfigOperationsResponse, lro::Operation> ListInstanceConfigOperationsAsync(ListInstanceConfigOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstanceConfigOperationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstanceConfigOperationsRequest, ListInstanceConfigOperationsResponse, lro::Operation>(_callListInstanceConfigOperations, request, callSettings);
        }

        /// <summary>
        /// Lists all instances in the given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Lists all instances in the given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Lists all instance partitions for the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InstancePartition"/> resources.</returns>
        public override gax::PagedEnumerable<ListInstancePartitionsResponse, InstancePartition> ListInstancePartitions(ListInstancePartitionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancePartitionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstancePartitionsRequest, ListInstancePartitionsResponse, InstancePartition>(_callListInstancePartitions, request, callSettings);
        }

        /// <summary>
        /// Lists all instance partitions for the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InstancePartition"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInstancePartitionsResponse, InstancePartition> ListInstancePartitionsAsync(ListInstancePartitionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancePartitionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstancePartitionsRequest, ListInstancePartitionsResponse, InstancePartition>(_callListInstancePartitions, request, callSettings);
        }

        /// <summary>
        /// Gets information about a particular instance.
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
        /// Gets information about a particular instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateInstance</c>.</summary>
        public override lro::OperationsClient CreateInstanceOperationsClient { get; }

        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance is readable via the API, with all requested attributes
        /// but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance immediately unreadable
        /// via the API.
        /// * The instance can be deleted.
        /// * All other attempts to modify the instance are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can be created in the instance.
        /// * The instance's allocated resource levels are readable via the API.
        /// * The instance's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
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
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance is readable via the API, with all requested attributes
        /// but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance immediately unreadable
        /// via the API.
        /// * The instance can be deleted.
        /// * All other attempts to modify the instance are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can be created in the instance.
        /// * The instance's allocated resource levels are readable via the API.
        /// * The instance's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, CreateInstanceMetadata>(await _callCreateInstance.Async(request, callSettings).ConfigureAwait(false), CreateInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateInstance</c>.</summary>
        public override lro::OperationsClient UpdateInstanceOperationsClient { get; }

        /// <summary>
        /// Updates an instance, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance. If the named instance does not
        /// exist, returns `NOT_FOUND`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * For resource types for which a decrease in the instance's allocation
        /// has been requested, billing is based on the newly-requested level.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceMetadata.cancel_time],
        /// and begins restoring resources to their pre-request values. The
        /// operation is guaranteed to succeed at undoing all resource changes,
        /// after which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance are rejected.
        /// * Reading the instance via the API continues to give the pre-request
        /// resource levels.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing begins for all successfully-allocated resources (some types
        /// may have lower than the requested levels).
        /// * All newly-reserved resources are available for serving the instance's
        /// tables.
        /// * The instance's new resource levels are readable via the API.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track the instance modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceMetadata][google.spanner.admin.instance.v1.UpdateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// 
        /// Authorization requires `spanner.instances.update` permission on
        /// the resource [name][google.spanner.admin.instance.v1.Instance.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, UpdateInstanceMetadata> UpdateInstance(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, UpdateInstanceMetadata>(_callUpdateInstance.Sync(request, callSettings), UpdateInstanceOperationsClient);
        }

        /// <summary>
        /// Updates an instance, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance. If the named instance does not
        /// exist, returns `NOT_FOUND`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * For resource types for which a decrease in the instance's allocation
        /// has been requested, billing is based on the newly-requested level.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceMetadata.cancel_time],
        /// and begins restoring resources to their pre-request values. The
        /// operation is guaranteed to succeed at undoing all resource changes,
        /// after which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance are rejected.
        /// * Reading the instance via the API continues to give the pre-request
        /// resource levels.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing begins for all successfully-allocated resources (some types
        /// may have lower than the requested levels).
        /// * All newly-reserved resources are available for serving the instance's
        /// tables.
        /// * The instance's new resource levels are readable via the API.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track the instance modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceMetadata][google.spanner.admin.instance.v1.UpdateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// 
        /// Authorization requires `spanner.instances.update` permission on
        /// the resource [name][google.spanner.admin.instance.v1.Instance.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, UpdateInstanceMetadata>(await _callUpdateInstance.Async(request, callSettings).ConfigureAwait(false), UpdateInstanceOperationsClient);
        }

        /// <summary>
        /// Deletes an instance.
        /// 
        /// Immediately upon completion of the request:
        /// 
        /// * Billing ceases for all of the instance's reserved resources.
        /// 
        /// Soon afterward:
        /// 
        /// * The instance and *all of its databases* immediately and
        /// irrevocably disappear from the API. All data in the databases
        /// is permanently deleted.
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
        /// Deletes an instance.
        /// 
        /// Immediately upon completion of the request:
        /// 
        /// * Billing ceases for all of the instance's reserved resources.
        /// 
        /// Soon afterward:
        /// 
        /// * The instance and *all of its databases* immediately and
        /// irrevocably disappear from the API. All data in the databases
        /// is permanently deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return _callDeleteInstance.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
        /// 
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        /// 
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
        /// 
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        /// 
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        /// Returns permissions that the caller has on the specified instance resource.
        /// 
        /// Attempting this RPC on a non-existent Cloud Spanner instance resource will
        /// result in a NOT_FOUND error if the user has `spanner.instances.list`
        /// permission on the containing Google Cloud Project. Otherwise returns an
        /// empty set of permissions.
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
        /// 
        /// Attempting this RPC on a non-existent Cloud Spanner instance resource will
        /// result in a NOT_FOUND error if the user has `spanner.instances.list`
        /// permission on the containing Google Cloud Project. Otherwise returns an
        /// empty set of permissions.
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
        /// Gets information about a particular instance partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InstancePartition GetInstancePartition(GetInstancePartitionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstancePartitionRequest(ref request, ref callSettings);
            return _callGetInstancePartition.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a particular instance partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InstancePartition> GetInstancePartitionAsync(GetInstancePartitionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstancePartitionRequest(ref request, ref callSettings);
            return _callGetInstancePartition.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateInstancePartition</c>.</summary>
        public override lro::OperationsClient CreateInstancePartitionOperationsClient { get; }

        /// <summary>
        /// Creates an instance partition and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new instance partition.
        /// The instance partition name is assigned by the caller. If the named
        /// instance partition already exists, `CreateInstancePartition` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance partition is readable via the API, with all requested
        /// attributes but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance partition immediately
        /// unreadable via the API.
        /// * The instance partition can be deleted.
        /// * All other attempts to modify the instance partition are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can start using this instance partition.
        /// * The instance partition's allocated resource levels are readable via the
        /// API.
        /// * The instance partition's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track creation of the instance partition.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstancePartitionMetadata][google.spanner.admin.instance.v1.CreateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InstancePartition, CreateInstancePartitionMetadata> CreateInstancePartition(CreateInstancePartitionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstancePartitionRequest(ref request, ref callSettings);
            return new lro::Operation<InstancePartition, CreateInstancePartitionMetadata>(_callCreateInstancePartition.Sync(request, callSettings), CreateInstancePartitionOperationsClient);
        }

        /// <summary>
        /// Creates an instance partition and begins preparing it to be used. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new instance partition.
        /// The instance partition name is assigned by the caller. If the named
        /// instance partition already exists, `CreateInstancePartition` returns
        /// `ALREADY_EXISTS`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * The instance partition is readable via the API, with all requested
        /// attributes but no allocated resources. Its state is `CREATING`.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation renders the instance partition immediately
        /// unreadable via the API.
        /// * The instance partition can be deleted.
        /// * All other attempts to modify the instance partition are rejected.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing for all successfully-allocated resources begins (some types
        /// may have lower than the requested levels).
        /// * Databases can start using this instance partition.
        /// * The instance partition's allocated resource levels are readable via the
        /// API.
        /// * The instance partition's state becomes `READY`.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track creation of the instance partition.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstancePartitionMetadata][google.spanner.admin.instance.v1.CreateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InstancePartition, CreateInstancePartitionMetadata>> CreateInstancePartitionAsync(CreateInstancePartitionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstancePartitionRequest(ref request, ref callSettings);
            return new lro::Operation<InstancePartition, CreateInstancePartitionMetadata>(await _callCreateInstancePartition.Async(request, callSettings).ConfigureAwait(false), CreateInstancePartitionOperationsClient);
        }

        /// <summary>
        /// Deletes an existing instance partition. Requires that the
        /// instance partition is not used by any database or backup and is not the
        /// default instance partition of an instance.
        /// 
        /// Authorization requires `spanner.instancePartitions.delete` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteInstancePartition(DeleteInstancePartitionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstancePartitionRequest(ref request, ref callSettings);
            _callDeleteInstancePartition.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing instance partition. Requires that the
        /// instance partition is not used by any database or backup and is not the
        /// default instance partition of an instance.
        /// 
        /// Authorization requires `spanner.instancePartitions.delete` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteInstancePartitionAsync(DeleteInstancePartitionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstancePartitionRequest(ref request, ref callSettings);
            return _callDeleteInstancePartition.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateInstancePartition</c>.</summary>
        public override lro::OperationsClient UpdateInstancePartitionOperationsClient { get; }

        /// <summary>
        /// Updates an instance partition, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance partition. If the named instance
        /// partition does not exist, returns `NOT_FOUND`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * For resource types for which a decrease in the instance partition's
        /// allocation has been requested, billing is based on the newly-requested
        /// level.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstancePartitionMetadata.cancel_time],
        /// and begins restoring resources to their pre-request values. The
        /// operation is guaranteed to succeed at undoing all resource changes,
        /// after which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance partition are rejected.
        /// * Reading the instance partition via the API continues to give the
        /// pre-request resource levels.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing begins for all successfully-allocated resources (some types
        /// may have lower than the requested levels).
        /// * All newly-reserved resources are available for serving the instance
        /// partition's tables.
        /// * The instance partition's new resource levels are readable via the API.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track the instance partition modification. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstancePartitionMetadata][google.spanner.admin.instance.v1.UpdateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instancePartitions.update` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InstancePartition, UpdateInstancePartitionMetadata> UpdateInstancePartition(UpdateInstancePartitionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstancePartitionRequest(ref request, ref callSettings);
            return new lro::Operation<InstancePartition, UpdateInstancePartitionMetadata>(_callUpdateInstancePartition.Sync(request, callSettings), UpdateInstancePartitionOperationsClient);
        }

        /// <summary>
        /// Updates an instance partition, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance partition. If the named instance
        /// partition does not exist, returns `NOT_FOUND`.
        /// 
        /// Immediately upon completion of this request:
        /// 
        /// * For resource types for which a decrease in the instance partition's
        /// allocation has been requested, billing is based on the newly-requested
        /// level.
        /// 
        /// Until completion of the returned operation:
        /// 
        /// * Cancelling the operation sets its metadata's
        /// [cancel_time][google.spanner.admin.instance.v1.UpdateInstancePartitionMetadata.cancel_time],
        /// and begins restoring resources to their pre-request values. The
        /// operation is guaranteed to succeed at undoing all resource changes,
        /// after which point it terminates with a `CANCELLED` status.
        /// * All other attempts to modify the instance partition are rejected.
        /// * Reading the instance partition via the API continues to give the
        /// pre-request resource levels.
        /// 
        /// Upon completion of the returned operation:
        /// 
        /// * Billing begins for all successfully-allocated resources (some types
        /// may have lower than the requested levels).
        /// * All newly-reserved resources are available for serving the instance
        /// partition's tables.
        /// * The instance partition's new resource levels are readable via the API.
        /// 
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format
        /// `&lt;instance_partition_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track the instance partition modification. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstancePartitionMetadata][google.spanner.admin.instance.v1.UpdateInstancePartitionMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [InstancePartition][google.spanner.admin.instance.v1.InstancePartition], if
        /// successful.
        /// 
        /// Authorization requires `spanner.instancePartitions.update` permission on
        /// the resource
        /// [name][google.spanner.admin.instance.v1.InstancePartition.name].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InstancePartition, UpdateInstancePartitionMetadata>> UpdateInstancePartitionAsync(UpdateInstancePartitionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstancePartitionRequest(ref request, ref callSettings);
            return new lro::Operation<InstancePartition, UpdateInstancePartitionMetadata>(await _callUpdateInstancePartition.Async(request, callSettings).ConfigureAwait(false), UpdateInstancePartitionOperationsClient);
        }

        /// <summary>
        /// Lists instance partition [long-running
        /// operations][google.longrunning.Operation] in the given instance.
        /// An instance partition operation has a name of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/instancePartitions/&lt;instance_partition&gt;/operations/&lt;operation&gt;`.
        /// The long-running operation
        /// [metadata][google.longrunning.Operation.metadata] field type
        /// `metadata.type_url` describes the type of the metadata. Operations returned
        /// include those that have completed/failed/canceled within the last 7 days,
        /// and pending operations. Operations returned are ordered by
        /// `operation.metadata.value.start_time` in descending order starting from the
        /// most recently started operation.
        /// 
        /// Authorization requires `spanner.instancePartitionOperations.list`
        /// permission on the resource
        /// [parent][google.spanner.admin.instance.v1.ListInstancePartitionOperationsRequest.parent].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="lro::Operation"/> resources.</returns>
        public override gax::PagedEnumerable<ListInstancePartitionOperationsResponse, lro::Operation> ListInstancePartitionOperations(ListInstancePartitionOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancePartitionOperationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstancePartitionOperationsRequest, ListInstancePartitionOperationsResponse, lro::Operation>(_callListInstancePartitionOperations, request, callSettings);
        }

        /// <summary>
        /// Lists instance partition [long-running
        /// operations][google.longrunning.Operation] in the given instance.
        /// An instance partition operation has a name of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/instancePartitions/&lt;instance_partition&gt;/operations/&lt;operation&gt;`.
        /// The long-running operation
        /// [metadata][google.longrunning.Operation.metadata] field type
        /// `metadata.type_url` describes the type of the metadata. Operations returned
        /// include those that have completed/failed/canceled within the last 7 days,
        /// and pending operations. Operations returned are ordered by
        /// `operation.metadata.value.start_time` in descending order starting from the
        /// most recently started operation.
        /// 
        /// Authorization requires `spanner.instancePartitionOperations.list`
        /// permission on the resource
        /// [parent][google.spanner.admin.instance.v1.ListInstancePartitionOperationsRequest.parent].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="lro::Operation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInstancePartitionOperationsResponse, lro::Operation> ListInstancePartitionOperationsAsync(ListInstancePartitionOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancePartitionOperationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstancePartitionOperationsRequest, ListInstancePartitionOperationsResponse, lro::Operation>(_callListInstancePartitionOperations, request, callSettings);
        }
    }

    public partial class ListInstanceConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstanceConfigOperationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstancePartitionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstancePartitionOperationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstanceConfigsResponse : gaxgrpc::IPageResponse<InstanceConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<InstanceConfig> GetEnumerator() => InstanceConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInstanceConfigOperationsResponse : gaxgrpc::IPageResponse<lro::Operation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<lro::Operation> GetEnumerator() => Operations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInstancesResponse : gaxgrpc::IPageResponse<Instance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Instance> GetEnumerator() => Instances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInstancePartitionsResponse : gaxgrpc::IPageResponse<InstancePartition>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<InstancePartition> GetEnumerator() => InstancePartitions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInstancePartitionOperationsResponse : gaxgrpc::IPageResponse<lro::Operation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<lro::Operation> GetEnumerator() => Operations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class InstanceAdmin
    {
        public partial class InstanceAdminClient
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
