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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="RegionDisksClient"/> instances.</summary>
    public sealed partial class RegionDisksSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RegionDisksSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RegionDisksSettings"/>.</returns>
        public static RegionDisksSettings GetDefault() => new RegionDisksSettings();

        /// <summary>Constructs a new <see cref="RegionDisksSettings"/> object with default settings.</summary>
        public RegionDisksSettings()
        {
        }

        private RegionDisksSettings(RegionDisksSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AddResourcePoliciesSettings = existing.AddResourcePoliciesSettings;
            AddResourcePoliciesOperationsSettings = existing.AddResourcePoliciesOperationsSettings.Clone();
            BulkInsertSettings = existing.BulkInsertSettings;
            BulkInsertOperationsSettings = existing.BulkInsertOperationsSettings.Clone();
            CreateSnapshotSettings = existing.CreateSnapshotSettings;
            CreateSnapshotOperationsSettings = existing.CreateSnapshotOperationsSettings.Clone();
            DeleteSettings = existing.DeleteSettings;
            DeleteOperationsSettings = existing.DeleteOperationsSettings.Clone();
            GetSettings = existing.GetSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            InsertSettings = existing.InsertSettings;
            InsertOperationsSettings = existing.InsertOperationsSettings.Clone();
            ListSettings = existing.ListSettings;
            RemoveResourcePoliciesSettings = existing.RemoveResourcePoliciesSettings;
            RemoveResourcePoliciesOperationsSettings = existing.RemoveResourcePoliciesOperationsSettings.Clone();
            ResizeSettings = existing.ResizeSettings;
            ResizeOperationsSettings = existing.ResizeOperationsSettings.Clone();
            SetIamPolicySettings = existing.SetIamPolicySettings;
            SetLabelsSettings = existing.SetLabelsSettings;
            SetLabelsOperationsSettings = existing.SetLabelsOperationsSettings.Clone();
            StartAsyncReplicationSettings = existing.StartAsyncReplicationSettings;
            StartAsyncReplicationOperationsSettings = existing.StartAsyncReplicationOperationsSettings.Clone();
            StopAsyncReplicationSettings = existing.StopAsyncReplicationSettings;
            StopAsyncReplicationOperationsSettings = existing.StopAsyncReplicationOperationsSettings.Clone();
            StopGroupAsyncReplicationSettings = existing.StopGroupAsyncReplicationSettings;
            StopGroupAsyncReplicationOperationsSettings = existing.StopGroupAsyncReplicationOperationsSettings.Clone();
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            UpdateSettings = existing.UpdateSettings;
            UpdateOperationsSettings = existing.UpdateOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(RegionDisksSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionDisksClient.AddResourcePolicies</c> and <c>RegionDisksClient.AddResourcePoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddResourcePoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionDisksClient.AddResourcePolicies</c> and
        /// <c>RegionDisksClient.AddResourcePoliciesAsync</c>.
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
        public lro::OperationsSettings AddResourcePoliciesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionDisksClient.BulkInsert</c> and <c>RegionDisksClient.BulkInsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BulkInsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionDisksClient.BulkInsert</c> and
        /// <c>RegionDisksClient.BulkInsertAsync</c>.
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
        public lro::OperationsSettings BulkInsertOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionDisksClient.CreateSnapshot</c> and <c>RegionDisksClient.CreateSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionDisksClient.CreateSnapshot</c> and
        /// <c>RegionDisksClient.CreateSnapshotAsync</c>.
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
        public lro::OperationsSettings CreateSnapshotOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegionDisksClient.Delete</c>
        ///  and <c>RegionDisksClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionDisksClient.Delete</c> and
        /// <c>RegionDisksClient.DeleteAsync</c>.
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
        public lro::OperationsSettings DeleteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegionDisksClient.Get</c>
        /// and <c>RegionDisksClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionDisksClient.GetIamPolicy</c> and <c>RegionDisksClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegionDisksClient.Insert</c>
        ///  and <c>RegionDisksClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionDisksClient.Insert</c> and
        /// <c>RegionDisksClient.InsertAsync</c>.
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
        public lro::OperationsSettings InsertOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegionDisksClient.List</c>
        /// and <c>RegionDisksClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionDisksClient.RemoveResourcePolicies</c> and <c>RegionDisksClient.RemoveResourcePoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveResourcePoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionDisksClient.RemoveResourcePolicies</c> and
        /// <c>RegionDisksClient.RemoveResourcePoliciesAsync</c>.
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
        public lro::OperationsSettings RemoveResourcePoliciesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegionDisksClient.Resize</c>
        ///  and <c>RegionDisksClient.ResizeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResizeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionDisksClient.Resize</c> and
        /// <c>RegionDisksClient.ResizeAsync</c>.
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
        public lro::OperationsSettings ResizeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionDisksClient.SetIamPolicy</c> and <c>RegionDisksClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegionDisksClient.SetLabels</c>
        ///  and <c>RegionDisksClient.SetLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionDisksClient.SetLabels</c> and
        /// <c>RegionDisksClient.SetLabelsAsync</c>.
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
        public lro::OperationsSettings SetLabelsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionDisksClient.StartAsyncReplication</c> and <c>RegionDisksClient.StartAsyncReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartAsyncReplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionDisksClient.StartAsyncReplication</c> and
        /// <c>RegionDisksClient.StartAsyncReplicationAsync</c>.
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
        public lro::OperationsSettings StartAsyncReplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionDisksClient.StopAsyncReplication</c> and <c>RegionDisksClient.StopAsyncReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopAsyncReplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionDisksClient.StopAsyncReplication</c> and
        /// <c>RegionDisksClient.StopAsyncReplicationAsync</c>.
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
        public lro::OperationsSettings StopAsyncReplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionDisksClient.StopGroupAsyncReplication</c> and <c>RegionDisksClient.StopGroupAsyncReplicationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopGroupAsyncReplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionDisksClient.StopGroupAsyncReplication</c> and
        /// <c>RegionDisksClient.StopGroupAsyncReplicationAsync</c>.
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
        public lro::OperationsSettings StopGroupAsyncReplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionDisksClient.TestIamPermissions</c> and <c>RegionDisksClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegionDisksClient.Update</c>
        ///  and <c>RegionDisksClient.UpdateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionDisksClient.Update</c> and
        /// <c>RegionDisksClient.UpdateAsync</c>.
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
        public lro::OperationsSettings UpdateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RegionDisksSettings"/> object.</returns>
        public RegionDisksSettings Clone() => new RegionDisksSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RegionDisksClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class RegionDisksClientBuilder : gaxgrpc::ClientBuilderBase<RegionDisksClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RegionDisksSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RegionDisksClientBuilder() : base(RegionDisksClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RegionDisksClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RegionDisksClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RegionDisksClient Build()
        {
            RegionDisksClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RegionDisksClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RegionDisksClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RegionDisksClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RegionDisksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RegionDisksClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RegionDisksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RegionDisksClient.ChannelPool;
    }

    /// <summary>RegionDisks client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The RegionDisks API.
    /// </remarks>
    public abstract partial class RegionDisksClient
    {
        /// <summary>
        /// The default endpoint for the RegionDisks service, which is a host of "compute.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default RegionDisks scopes.</summary>
        /// <remarks>
        /// The default RegionDisks scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RegionDisks.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RegionDisksClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RegionDisksClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RegionDisksClient"/>.</returns>
        public static stt::Task<RegionDisksClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RegionDisksClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RegionDisksClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RegionDisksClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RegionDisksClient"/>.</returns>
        public static RegionDisksClient Create() => new RegionDisksClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RegionDisksClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RegionDisksSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RegionDisksClient"/>.</returns>
        internal static RegionDisksClient Create(grpccore::CallInvoker callInvoker, RegionDisksSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RegionDisks.RegionDisksClient grpcClient = new RegionDisks.RegionDisksClient(callInvoker);
            return new RegionDisksClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RegionDisks client</summary>
        public virtual RegionDisks.RegionDisksClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Adds existing resource policies to a regional disk. You can only add one policy which will be applied to this disk for scheduling snapshot creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddResourcePolicies(AddResourcePoliciesRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds existing resource policies to a regional disk. You can only add one policy which will be applied to this disk for scheduling snapshot creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddResourcePoliciesAsync(AddResourcePoliciesRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds existing resource policies to a regional disk. You can only add one policy which will be applied to this disk for scheduling snapshot creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddResourcePoliciesAsync(AddResourcePoliciesRegionDiskRequest request, st::CancellationToken cancellationToken) =>
            AddResourcePoliciesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AddResourcePolicies</c>.</summary>
        public virtual lro::OperationsClient AddResourcePoliciesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AddResourcePolicies</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceAddResourcePolicies(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddResourcePoliciesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AddResourcePolicies</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceAddResourcePoliciesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddResourcePoliciesOperationsClient, callSettings);

        /// <summary>
        /// Adds existing resource policies to a regional disk. You can only add one policy which will be applied to this disk for scheduling snapshot creation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// The disk name for this request.
        /// </param>
        /// <param name="regionDisksAddResourcePoliciesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddResourcePolicies(string project, string region, string disk, RegionDisksAddResourcePoliciesRequest regionDisksAddResourcePoliciesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            AddResourcePolicies(new AddResourcePoliciesRegionDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionDisksAddResourcePoliciesRequestResource = gax::GaxPreconditions.CheckNotNull(regionDisksAddResourcePoliciesRequestResource, nameof(regionDisksAddResourcePoliciesRequestResource)),
            }, callSettings);

        /// <summary>
        /// Adds existing resource policies to a regional disk. You can only add one policy which will be applied to this disk for scheduling snapshot creation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// The disk name for this request.
        /// </param>
        /// <param name="regionDisksAddResourcePoliciesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddResourcePoliciesAsync(string project, string region, string disk, RegionDisksAddResourcePoliciesRequest regionDisksAddResourcePoliciesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            AddResourcePoliciesAsync(new AddResourcePoliciesRegionDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionDisksAddResourcePoliciesRequestResource = gax::GaxPreconditions.CheckNotNull(regionDisksAddResourcePoliciesRequestResource, nameof(regionDisksAddResourcePoliciesRequestResource)),
            }, callSettings);

        /// <summary>
        /// Adds existing resource policies to a regional disk. You can only add one policy which will be applied to this disk for scheduling snapshot creation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// The disk name for this request.
        /// </param>
        /// <param name="regionDisksAddResourcePoliciesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddResourcePoliciesAsync(string project, string region, string disk, RegionDisksAddResourcePoliciesRequest regionDisksAddResourcePoliciesRequestResource, st::CancellationToken cancellationToken) =>
            AddResourcePoliciesAsync(project, region, disk, regionDisksAddResourcePoliciesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bulk create a set of disks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> BulkInsert(BulkInsertRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk create a set of disks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> BulkInsertAsync(BulkInsertRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk create a set of disks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> BulkInsertAsync(BulkInsertRegionDiskRequest request, st::CancellationToken cancellationToken) =>
            BulkInsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BulkInsert</c>.</summary>
        public virtual lro::OperationsClient BulkInsertOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BulkInsert</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceBulkInsert(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BulkInsertOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BulkInsert</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceBulkInsertAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BulkInsertOperationsClient, callSettings);

        /// <summary>
        /// Bulk create a set of disks.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="bulkInsertDiskResourceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> BulkInsert(string project, string region, BulkInsertDiskResource bulkInsertDiskResourceResource, gaxgrpc::CallSettings callSettings = null) =>
            BulkInsert(new BulkInsertRegionDiskRequest
            {
                BulkInsertDiskResourceResource = gax::GaxPreconditions.CheckNotNull(bulkInsertDiskResourceResource, nameof(bulkInsertDiskResourceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Bulk create a set of disks.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="bulkInsertDiskResourceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> BulkInsertAsync(string project, string region, BulkInsertDiskResource bulkInsertDiskResourceResource, gaxgrpc::CallSettings callSettings = null) =>
            BulkInsertAsync(new BulkInsertRegionDiskRequest
            {
                BulkInsertDiskResourceResource = gax::GaxPreconditions.CheckNotNull(bulkInsertDiskResourceResource, nameof(bulkInsertDiskResourceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Bulk create a set of disks.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="bulkInsertDiskResourceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> BulkInsertAsync(string project, string region, BulkInsertDiskResource bulkInsertDiskResourceResource, st::CancellationToken cancellationToken) =>
            BulkInsertAsync(project, region, bulkInsertDiskResourceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a snapshot of a specified persistent disk. For regular snapshot creation, consider using snapshots.insert instead, as that method supports more features, such as creating snapshots in a project different from the source disk project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> CreateSnapshot(CreateSnapshotRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a snapshot of a specified persistent disk. For regular snapshot creation, consider using snapshots.insert instead, as that method supports more features, such as creating snapshots in a project different from the source disk project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CreateSnapshotAsync(CreateSnapshotRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a snapshot of a specified persistent disk. For regular snapshot creation, consider using snapshots.insert instead, as that method supports more features, such as creating snapshots in a project different from the source disk project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CreateSnapshotAsync(CreateSnapshotRegionDiskRequest request, st::CancellationToken cancellationToken) =>
            CreateSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSnapshot</c>.</summary>
        public virtual lro::OperationsClient CreateSnapshotOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceCreateSnapshot(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceCreateSnapshotAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Creates a snapshot of a specified persistent disk. For regular snapshot creation, consider using snapshots.insert instead, as that method supports more features, such as creating snapshots in a project different from the source disk project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the regional persistent disk to snapshot.
        /// </param>
        /// <param name="snapshotResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> CreateSnapshot(string project, string region, string disk, Snapshot snapshotResource, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshot(new CreateSnapshotRegionDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                SnapshotResource = gax::GaxPreconditions.CheckNotNull(snapshotResource, nameof(snapshotResource)),
            }, callSettings);

        /// <summary>
        /// Creates a snapshot of a specified persistent disk. For regular snapshot creation, consider using snapshots.insert instead, as that method supports more features, such as creating snapshots in a project different from the source disk project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the regional persistent disk to snapshot.
        /// </param>
        /// <param name="snapshotResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CreateSnapshotAsync(string project, string region, string disk, Snapshot snapshotResource, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshotAsync(new CreateSnapshotRegionDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                SnapshotResource = gax::GaxPreconditions.CheckNotNull(snapshotResource, nameof(snapshotResource)),
            }, callSettings);

        /// <summary>
        /// Creates a snapshot of a specified persistent disk. For regular snapshot creation, consider using snapshots.insert instead, as that method supports more features, such as creating snapshots in a project different from the source disk project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the regional persistent disk to snapshot.
        /// </param>
        /// <param name="snapshotResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CreateSnapshotAsync(string project, string region, string disk, Snapshot snapshotResource, st::CancellationToken cancellationToken) =>
            CreateSnapshotAsync(project, region, disk, snapshotResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified regional persistent disk. Deleting a regional disk removes all the replicas of its data permanently and is irreversible. However, deleting a disk does not delete any snapshots previously made from the disk. You must separately delete snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeleteRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified regional persistent disk. Deleting a regional disk removes all the replicas of its data permanently and is irreversible. However, deleting a disk does not delete any snapshots previously made from the disk. You must separately delete snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified regional persistent disk. Deleting a regional disk removes all the replicas of its data permanently and is irreversible. However, deleting a disk does not delete any snapshots previously made from the disk. You must separately delete snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteRegionDiskRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public virtual lro::OperationsClient DeleteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Delete</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceDelete(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Delete</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceDeleteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified regional persistent disk. Deleting a regional disk removes all the replicas of its data permanently and is irreversible. However, deleting a disk does not delete any snapshots previously made from the disk. You must separately delete snapshots.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the regional persistent disk to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string project, string region, string disk, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteRegionDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified regional persistent disk. Deleting a regional disk removes all the replicas of its data permanently and is irreversible. However, deleting a disk does not delete any snapshots previously made from the disk. You must separately delete snapshots.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the regional persistent disk to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string region, string disk, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteRegionDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified regional persistent disk. Deleting a regional disk removes all the replicas of its data permanently and is irreversible. However, deleting a disk does not delete any snapshots previously made from the disk. You must separately delete snapshots.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the regional persistent disk to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string region, string disk, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, region, disk, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a specified regional persistent disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Disk Get(GetRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a specified regional persistent disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Disk> GetAsync(GetRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a specified regional persistent disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Disk> GetAsync(GetRegionDiskRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a specified regional persistent disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the regional persistent disk to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Disk Get(string project, string region, string disk, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetRegionDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Returns a specified regional persistent disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the regional persistent disk to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Disk> GetAsync(string project, string region, string disk, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetRegionDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Returns a specified regional persistent disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the regional persistent disk to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Disk> GetAsync(string project, string region, string disk, st::CancellationToken cancellationToken) =>
            GetAsync(project, region, disk, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetIamPolicy(GetIamPolicyRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyRegionDiskRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetIamPolicy(string project, string region, string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new GetIamPolicyRegionDiskRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(string project, string region, string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new GetIamPolicyRegionDiskRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(string project, string region, string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(project, region, resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a persistent regional disk in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a persistent regional disk in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a persistent regional disk in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertRegionDiskRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public virtual lro::OperationsClient InsertOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceInsert(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceInsertAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Creates a persistent regional disk in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="diskResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(string project, string region, Disk diskResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertRegionDiskRequest
            {
                DiskResource = gax::GaxPreconditions.CheckNotNull(diskResource, nameof(diskResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Creates a persistent regional disk in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="diskResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string region, Disk diskResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertRegionDiskRequest
            {
                DiskResource = gax::GaxPreconditions.CheckNotNull(diskResource, nameof(diskResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Creates a persistent regional disk in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="diskResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string region, Disk diskResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, region, diskResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of persistent disks contained within the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Disk"/> resources.</returns>
        public virtual gax::PagedEnumerable<DiskList, Disk> List(ListRegionDisksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of persistent disks contained within the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Disk"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<DiskList, Disk> ListAsync(ListRegionDisksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of persistent disks contained within the specified region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
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
        /// <returns>A pageable sequence of <see cref="Disk"/> resources.</returns>
        public virtual gax::PagedEnumerable<DiskList, Disk> List(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionDisksRequest request = new ListRegionDisksRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return List(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of persistent disks contained within the specified region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Disk"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<DiskList, Disk> ListAsync(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionDisksRequest request = new ListRegionDisksRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAsync(request, callSettings);
        }

        /// <summary>
        /// Removes resource policies from a regional disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveResourcePolicies(RemoveResourcePoliciesRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes resource policies from a regional disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveResourcePoliciesAsync(RemoveResourcePoliciesRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes resource policies from a regional disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveResourcePoliciesAsync(RemoveResourcePoliciesRegionDiskRequest request, st::CancellationToken cancellationToken) =>
            RemoveResourcePoliciesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RemoveResourcePolicies</c>.</summary>
        public virtual lro::OperationsClient RemoveResourcePoliciesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveResourcePolicies</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceRemoveResourcePolicies(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveResourcePoliciesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveResourcePolicies</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceRemoveResourcePoliciesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveResourcePoliciesOperationsClient, callSettings);

        /// <summary>
        /// Removes resource policies from a regional disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// The disk name for this request.
        /// </param>
        /// <param name="regionDisksRemoveResourcePoliciesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveResourcePolicies(string project, string region, string disk, RegionDisksRemoveResourcePoliciesRequest regionDisksRemoveResourcePoliciesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            RemoveResourcePolicies(new RemoveResourcePoliciesRegionDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionDisksRemoveResourcePoliciesRequestResource = gax::GaxPreconditions.CheckNotNull(regionDisksRemoveResourcePoliciesRequestResource, nameof(regionDisksRemoveResourcePoliciesRequestResource)),
            }, callSettings);

        /// <summary>
        /// Removes resource policies from a regional disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// The disk name for this request.
        /// </param>
        /// <param name="regionDisksRemoveResourcePoliciesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveResourcePoliciesAsync(string project, string region, string disk, RegionDisksRemoveResourcePoliciesRequest regionDisksRemoveResourcePoliciesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            RemoveResourcePoliciesAsync(new RemoveResourcePoliciesRegionDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionDisksRemoveResourcePoliciesRequestResource = gax::GaxPreconditions.CheckNotNull(regionDisksRemoveResourcePoliciesRequestResource, nameof(regionDisksRemoveResourcePoliciesRequestResource)),
            }, callSettings);

        /// <summary>
        /// Removes resource policies from a regional disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// The disk name for this request.
        /// </param>
        /// <param name="regionDisksRemoveResourcePoliciesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveResourcePoliciesAsync(string project, string region, string disk, RegionDisksRemoveResourcePoliciesRequest regionDisksRemoveResourcePoliciesRequestResource, st::CancellationToken cancellationToken) =>
            RemoveResourcePoliciesAsync(project, region, disk, regionDisksRemoveResourcePoliciesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resizes the specified regional persistent disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Resize(ResizeRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resizes the specified regional persistent disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ResizeAsync(ResizeRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resizes the specified regional persistent disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ResizeAsync(ResizeRegionDiskRequest request, st::CancellationToken cancellationToken) =>
            ResizeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Resize</c>.</summary>
        public virtual lro::OperationsClient ResizeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Resize</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceResize(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResizeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Resize</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceResizeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResizeOperationsClient, callSettings);

        /// <summary>
        /// Resizes the specified regional persistent disk.
        /// </summary>
        /// <param name="project">
        /// The project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the regional persistent disk.
        /// </param>
        /// <param name="regionDisksResizeRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Resize(string project, string region, string disk, RegionDisksResizeRequest regionDisksResizeRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            Resize(new ResizeRegionDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionDisksResizeRequestResource = gax::GaxPreconditions.CheckNotNull(regionDisksResizeRequestResource, nameof(regionDisksResizeRequestResource)),
            }, callSettings);

        /// <summary>
        /// Resizes the specified regional persistent disk.
        /// </summary>
        /// <param name="project">
        /// The project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the regional persistent disk.
        /// </param>
        /// <param name="regionDisksResizeRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ResizeAsync(string project, string region, string disk, RegionDisksResizeRequest regionDisksResizeRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            ResizeAsync(new ResizeRegionDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionDisksResizeRequestResource = gax::GaxPreconditions.CheckNotNull(regionDisksResizeRequestResource, nameof(regionDisksResizeRequestResource)),
            }, callSettings);

        /// <summary>
        /// Resizes the specified regional persistent disk.
        /// </summary>
        /// <param name="project">
        /// The project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the regional persistent disk.
        /// </param>
        /// <param name="regionDisksResizeRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ResizeAsync(string project, string region, string disk, RegionDisksResizeRequest regionDisksResizeRequestResource, st::CancellationToken cancellationToken) =>
            ResizeAsync(project, region, disk, regionDisksResizeRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy SetIamPolicy(SetIamPolicyRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyRegionDiskRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="regionSetPolicyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy SetIamPolicy(string project, string region, string resource, RegionSetPolicyRequest regionSetPolicyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new SetIamPolicyRegionDiskRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionSetPolicyRequestResource = gax::GaxPreconditions.CheckNotNull(regionSetPolicyRequestResource, nameof(regionSetPolicyRequestResource)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="regionSetPolicyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(string project, string region, string resource, RegionSetPolicyRequest regionSetPolicyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new SetIamPolicyRegionDiskRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionSetPolicyRequestResource = gax::GaxPreconditions.CheckNotNull(regionSetPolicyRequestResource, nameof(regionSetPolicyRequestResource)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="regionSetPolicyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(string project, string region, string resource, RegionSetPolicyRequest regionSetPolicyRequestResource, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(project, region, resource, regionSetPolicyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the labels on the target regional disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetLabels(SetLabelsRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the labels on the target regional disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(SetLabelsRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the labels on the target regional disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(SetLabelsRegionDiskRequest request, st::CancellationToken cancellationToken) =>
            SetLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetLabels</c>.</summary>
        public virtual lro::OperationsClient SetLabelsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetLabels</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetLabels(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetLabelsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetLabels</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetLabelsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetLabelsOperationsClient, callSettings);

        /// <summary>
        /// Sets the labels on the target regional disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="regionSetLabelsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetLabels(string project, string region, string resource, RegionSetLabelsRequest regionSetLabelsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetLabels(new SetLabelsRegionDiskRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionSetLabelsRequestResource = gax::GaxPreconditions.CheckNotNull(regionSetLabelsRequestResource, nameof(regionSetLabelsRequestResource)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the labels on the target regional disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="regionSetLabelsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(string project, string region, string resource, RegionSetLabelsRequest regionSetLabelsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetLabelsAsync(new SetLabelsRegionDiskRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionSetLabelsRequestResource = gax::GaxPreconditions.CheckNotNull(regionSetLabelsRequestResource, nameof(regionSetLabelsRequestResource)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the labels on the target regional disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="regionSetLabelsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(string project, string region, string resource, RegionSetLabelsRequest regionSetLabelsRequestResource, st::CancellationToken cancellationToken) =>
            SetLabelsAsync(project, region, resource, regionSetLabelsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts asynchronous replication. Must be invoked on the primary disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> StartAsyncReplication(StartAsyncReplicationRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts asynchronous replication. Must be invoked on the primary disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StartAsyncReplicationAsync(StartAsyncReplicationRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts asynchronous replication. Must be invoked on the primary disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StartAsyncReplicationAsync(StartAsyncReplicationRegionDiskRequest request, st::CancellationToken cancellationToken) =>
            StartAsyncReplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StartAsyncReplication</c>.</summary>
        public virtual lro::OperationsClient StartAsyncReplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StartAsyncReplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceStartAsyncReplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartAsyncReplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartAsyncReplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceStartAsyncReplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartAsyncReplicationOperationsClient, callSettings);

        /// <summary>
        /// Starts asynchronous replication. Must be invoked on the primary disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// The name of the persistent disk.
        /// </param>
        /// <param name="regionDisksStartAsyncReplicationRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> StartAsyncReplication(string project, string region, string disk, RegionDisksStartAsyncReplicationRequest regionDisksStartAsyncReplicationRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            StartAsyncReplication(new StartAsyncReplicationRegionDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionDisksStartAsyncReplicationRequestResource = gax::GaxPreconditions.CheckNotNull(regionDisksStartAsyncReplicationRequestResource, nameof(regionDisksStartAsyncReplicationRequestResource)),
            }, callSettings);

        /// <summary>
        /// Starts asynchronous replication. Must be invoked on the primary disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// The name of the persistent disk.
        /// </param>
        /// <param name="regionDisksStartAsyncReplicationRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StartAsyncReplicationAsync(string project, string region, string disk, RegionDisksStartAsyncReplicationRequest regionDisksStartAsyncReplicationRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            StartAsyncReplicationAsync(new StartAsyncReplicationRegionDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionDisksStartAsyncReplicationRequestResource = gax::GaxPreconditions.CheckNotNull(regionDisksStartAsyncReplicationRequestResource, nameof(regionDisksStartAsyncReplicationRequestResource)),
            }, callSettings);

        /// <summary>
        /// Starts asynchronous replication. Must be invoked on the primary disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// The name of the persistent disk.
        /// </param>
        /// <param name="regionDisksStartAsyncReplicationRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StartAsyncReplicationAsync(string project, string region, string disk, RegionDisksStartAsyncReplicationRequest regionDisksStartAsyncReplicationRequestResource, st::CancellationToken cancellationToken) =>
            StartAsyncReplicationAsync(project, region, disk, regionDisksStartAsyncReplicationRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops asynchronous replication. Can be invoked either on the primary or on the secondary disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> StopAsyncReplication(StopAsyncReplicationRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops asynchronous replication. Can be invoked either on the primary or on the secondary disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopAsyncReplicationAsync(StopAsyncReplicationRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops asynchronous replication. Can be invoked either on the primary or on the secondary disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopAsyncReplicationAsync(StopAsyncReplicationRegionDiskRequest request, st::CancellationToken cancellationToken) =>
            StopAsyncReplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StopAsyncReplication</c>.</summary>
        public virtual lro::OperationsClient StopAsyncReplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StopAsyncReplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceStopAsyncReplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopAsyncReplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StopAsyncReplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceStopAsyncReplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopAsyncReplicationOperationsClient, callSettings);

        /// <summary>
        /// Stops asynchronous replication. Can be invoked either on the primary or on the secondary disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// The name of the persistent disk.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> StopAsyncReplication(string project, string region, string disk, gaxgrpc::CallSettings callSettings = null) =>
            StopAsyncReplication(new StopAsyncReplicationRegionDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Stops asynchronous replication. Can be invoked either on the primary or on the secondary disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// The name of the persistent disk.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopAsyncReplicationAsync(string project, string region, string disk, gaxgrpc::CallSettings callSettings = null) =>
            StopAsyncReplicationAsync(new StopAsyncReplicationRegionDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Stops asynchronous replication. Can be invoked either on the primary or on the secondary disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// The name of the persistent disk.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopAsyncReplicationAsync(string project, string region, string disk, st::CancellationToken cancellationToken) =>
            StopAsyncReplicationAsync(project, region, disk, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops asynchronous replication for a consistency group of disks. Can be invoked either in the primary or secondary scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> StopGroupAsyncReplication(StopGroupAsyncReplicationRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops asynchronous replication for a consistency group of disks. Can be invoked either in the primary or secondary scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopGroupAsyncReplicationAsync(StopGroupAsyncReplicationRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops asynchronous replication for a consistency group of disks. Can be invoked either in the primary or secondary scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopGroupAsyncReplicationAsync(StopGroupAsyncReplicationRegionDiskRequest request, st::CancellationToken cancellationToken) =>
            StopGroupAsyncReplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StopGroupAsyncReplication</c>.</summary>
        public virtual lro::OperationsClient StopGroupAsyncReplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StopGroupAsyncReplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceStopGroupAsyncReplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopGroupAsyncReplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StopGroupAsyncReplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceStopGroupAsyncReplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopGroupAsyncReplicationOperationsClient, callSettings);

        /// <summary>
        /// Stops asynchronous replication for a consistency group of disks. Can be invoked either in the primary or secondary scope.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request. This must be the region of the primary or secondary disks in the consistency group.
        /// </param>
        /// <param name="disksStopGroupAsyncReplicationResourceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> StopGroupAsyncReplication(string project, string region, DisksStopGroupAsyncReplicationResource disksStopGroupAsyncReplicationResourceResource, gaxgrpc::CallSettings callSettings = null) =>
            StopGroupAsyncReplication(new StopGroupAsyncReplicationRegionDiskRequest
            {
                DisksStopGroupAsyncReplicationResourceResource = gax::GaxPreconditions.CheckNotNull(disksStopGroupAsyncReplicationResourceResource, nameof(disksStopGroupAsyncReplicationResourceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Stops asynchronous replication for a consistency group of disks. Can be invoked either in the primary or secondary scope.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request. This must be the region of the primary or secondary disks in the consistency group.
        /// </param>
        /// <param name="disksStopGroupAsyncReplicationResourceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopGroupAsyncReplicationAsync(string project, string region, DisksStopGroupAsyncReplicationResource disksStopGroupAsyncReplicationResourceResource, gaxgrpc::CallSettings callSettings = null) =>
            StopGroupAsyncReplicationAsync(new StopGroupAsyncReplicationRegionDiskRequest
            {
                DisksStopGroupAsyncReplicationResourceResource = gax::GaxPreconditions.CheckNotNull(disksStopGroupAsyncReplicationResourceResource, nameof(disksStopGroupAsyncReplicationResourceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Stops asynchronous replication for a consistency group of disks. Can be invoked either in the primary or secondary scope.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request. This must be the region of the primary or secondary disks in the consistency group.
        /// </param>
        /// <param name="disksStopGroupAsyncReplicationResourceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopGroupAsyncReplicationAsync(string project, string region, DisksStopGroupAsyncReplicationResource disksStopGroupAsyncReplicationResourceResource, st::CancellationToken cancellationToken) =>
            StopGroupAsyncReplicationAsync(project, region, disksStopGroupAsyncReplicationResourceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestPermissionsResponse TestIamPermissions(TestIamPermissionsRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsRegionDiskRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestPermissionsResponse TestIamPermissions(string project, string region, string resource, TestPermissionsRequest testPermissionsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new TestIamPermissionsRegionDiskRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                TestPermissionsRequestResource = gax::GaxPreconditions.CheckNotNull(testPermissionsRequestResource, nameof(testPermissionsRequestResource)),
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(string project, string region, string resource, TestPermissionsRequest testPermissionsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new TestIamPermissionsRegionDiskRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                TestPermissionsRequestResource = gax::GaxPreconditions.CheckNotNull(testPermissionsRequestResource, nameof(testPermissionsRequestResource)),
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(string project, string region, string resource, TestPermissionsRequest testPermissionsRequestResource, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the specified disk with the data included in the request. Update is performed only on selected fields included as part of update-mask. Only the following fields can be modified: user_license.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Update(UpdateRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the specified disk with the data included in the request. Update is performed only on selected fields included as part of update-mask. Only the following fields can be modified: user_license.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the specified disk with the data included in the request. Update is performed only on selected fields included as part of update-mask. Only the following fields can be modified: user_license.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateRegionDiskRequest request, st::CancellationToken cancellationToken) =>
            UpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Update</c>.</summary>
        public virtual lro::OperationsClient UpdateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Update</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceUpdate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Update</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceUpdateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateOperationsClient, callSettings);

        /// <summary>
        /// Update the specified disk with the data included in the request. Update is performed only on selected fields included as part of update-mask. Only the following fields can be modified: user_license.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// The disk name for this request.
        /// </param>
        /// <param name="diskResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Update(string project, string region, string disk, Disk diskResource, gaxgrpc::CallSettings callSettings = null) =>
            Update(new UpdateRegionDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                DiskResource = gax::GaxPreconditions.CheckNotNull(diskResource, nameof(diskResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Update the specified disk with the data included in the request. Update is performed only on selected fields included as part of update-mask. Only the following fields can be modified: user_license.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// The disk name for this request.
        /// </param>
        /// <param name="diskResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(string project, string region, string disk, Disk diskResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAsync(new UpdateRegionDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                DiskResource = gax::GaxPreconditions.CheckNotNull(diskResource, nameof(diskResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Update the specified disk with the data included in the request. Update is performed only on selected fields included as part of update-mask. Only the following fields can be modified: user_license.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="disk">
        /// The disk name for this request.
        /// </param>
        /// <param name="diskResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(string project, string region, string disk, Disk diskResource, st::CancellationToken cancellationToken) =>
            UpdateAsync(project, region, disk, diskResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RegionDisks client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The RegionDisks API.
    /// </remarks>
    public sealed partial class RegionDisksClientImpl : RegionDisksClient
    {
        private readonly gaxgrpc::ApiCall<AddResourcePoliciesRegionDiskRequest, Operation> _callAddResourcePolicies;

        private readonly gaxgrpc::ApiCall<BulkInsertRegionDiskRequest, Operation> _callBulkInsert;

        private readonly gaxgrpc::ApiCall<CreateSnapshotRegionDiskRequest, Operation> _callCreateSnapshot;

        private readonly gaxgrpc::ApiCall<DeleteRegionDiskRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetRegionDiskRequest, Disk> _callGet;

        private readonly gaxgrpc::ApiCall<GetIamPolicyRegionDiskRequest, Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<InsertRegionDiskRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListRegionDisksRequest, DiskList> _callList;

        private readonly gaxgrpc::ApiCall<RemoveResourcePoliciesRegionDiskRequest, Operation> _callRemoveResourcePolicies;

        private readonly gaxgrpc::ApiCall<ResizeRegionDiskRequest, Operation> _callResize;

        private readonly gaxgrpc::ApiCall<SetIamPolicyRegionDiskRequest, Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<SetLabelsRegionDiskRequest, Operation> _callSetLabels;

        private readonly gaxgrpc::ApiCall<StartAsyncReplicationRegionDiskRequest, Operation> _callStartAsyncReplication;

        private readonly gaxgrpc::ApiCall<StopAsyncReplicationRegionDiskRequest, Operation> _callStopAsyncReplication;

        private readonly gaxgrpc::ApiCall<StopGroupAsyncReplicationRegionDiskRequest, Operation> _callStopGroupAsyncReplication;

        private readonly gaxgrpc::ApiCall<TestIamPermissionsRegionDiskRequest, TestPermissionsResponse> _callTestIamPermissions;

        private readonly gaxgrpc::ApiCall<UpdateRegionDiskRequest, Operation> _callUpdate;

        /// <summary>
        /// Constructs a client wrapper for the RegionDisks service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RegionDisksSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RegionDisksClientImpl(RegionDisks.RegionDisksClient grpcClient, RegionDisksSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RegionDisksSettings effectiveSettings = settings ?? RegionDisksSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            AddResourcePoliciesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.AddResourcePoliciesOperationsSettings, logger);
            BulkInsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.BulkInsertOperationsSettings, logger);
            CreateSnapshotOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.CreateSnapshotOperationsSettings, logger);
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.DeleteOperationsSettings, logger);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.InsertOperationsSettings, logger);
            RemoveResourcePoliciesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.RemoveResourcePoliciesOperationsSettings, logger);
            ResizeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.ResizeOperationsSettings, logger);
            SetLabelsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.SetLabelsOperationsSettings, logger);
            StartAsyncReplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.StartAsyncReplicationOperationsSettings, logger);
            StopAsyncReplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.StopAsyncReplicationOperationsSettings, logger);
            StopGroupAsyncReplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.StopGroupAsyncReplicationOperationsSettings, logger);
            UpdateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.UpdateOperationsSettings, logger);
            _callAddResourcePolicies = clientHelper.BuildApiCall<AddResourcePoliciesRegionDiskRequest, Operation>("AddResourcePolicies", grpcClient.AddResourcePoliciesAsync, grpcClient.AddResourcePolicies, effectiveSettings.AddResourcePoliciesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("disk", request => request.Disk);
            Modify_ApiCall(ref _callAddResourcePolicies);
            Modify_AddResourcePoliciesApiCall(ref _callAddResourcePolicies);
            _callBulkInsert = clientHelper.BuildApiCall<BulkInsertRegionDiskRequest, Operation>("BulkInsert", grpcClient.BulkInsertAsync, grpcClient.BulkInsert, effectiveSettings.BulkInsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callBulkInsert);
            Modify_BulkInsertApiCall(ref _callBulkInsert);
            _callCreateSnapshot = clientHelper.BuildApiCall<CreateSnapshotRegionDiskRequest, Operation>("CreateSnapshot", grpcClient.CreateSnapshotAsync, grpcClient.CreateSnapshot, effectiveSettings.CreateSnapshotSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("disk", request => request.Disk);
            Modify_ApiCall(ref _callCreateSnapshot);
            Modify_CreateSnapshotApiCall(ref _callCreateSnapshot);
            _callDelete = clientHelper.BuildApiCall<DeleteRegionDiskRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("disk", request => request.Disk);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetRegionDiskRequest, Disk>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("disk", request => request.Disk);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callGetIamPolicy = clientHelper.BuildApiCall<GetIamPolicyRegionDiskRequest, Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callInsert = clientHelper.BuildApiCall<InsertRegionDiskRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListRegionDisksRequest, DiskList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callRemoveResourcePolicies = clientHelper.BuildApiCall<RemoveResourcePoliciesRegionDiskRequest, Operation>("RemoveResourcePolicies", grpcClient.RemoveResourcePoliciesAsync, grpcClient.RemoveResourcePolicies, effectiveSettings.RemoveResourcePoliciesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("disk", request => request.Disk);
            Modify_ApiCall(ref _callRemoveResourcePolicies);
            Modify_RemoveResourcePoliciesApiCall(ref _callRemoveResourcePolicies);
            _callResize = clientHelper.BuildApiCall<ResizeRegionDiskRequest, Operation>("Resize", grpcClient.ResizeAsync, grpcClient.Resize, effectiveSettings.ResizeSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("disk", request => request.Disk);
            Modify_ApiCall(ref _callResize);
            Modify_ResizeApiCall(ref _callResize);
            _callSetIamPolicy = clientHelper.BuildApiCall<SetIamPolicyRegionDiskRequest, Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callSetLabels = clientHelper.BuildApiCall<SetLabelsRegionDiskRequest, Operation>("SetLabels", grpcClient.SetLabelsAsync, grpcClient.SetLabels, effectiveSettings.SetLabelsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetLabels);
            Modify_SetLabelsApiCall(ref _callSetLabels);
            _callStartAsyncReplication = clientHelper.BuildApiCall<StartAsyncReplicationRegionDiskRequest, Operation>("StartAsyncReplication", grpcClient.StartAsyncReplicationAsync, grpcClient.StartAsyncReplication, effectiveSettings.StartAsyncReplicationSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("disk", request => request.Disk);
            Modify_ApiCall(ref _callStartAsyncReplication);
            Modify_StartAsyncReplicationApiCall(ref _callStartAsyncReplication);
            _callStopAsyncReplication = clientHelper.BuildApiCall<StopAsyncReplicationRegionDiskRequest, Operation>("StopAsyncReplication", grpcClient.StopAsyncReplicationAsync, grpcClient.StopAsyncReplication, effectiveSettings.StopAsyncReplicationSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("disk", request => request.Disk);
            Modify_ApiCall(ref _callStopAsyncReplication);
            Modify_StopAsyncReplicationApiCall(ref _callStopAsyncReplication);
            _callStopGroupAsyncReplication = clientHelper.BuildApiCall<StopGroupAsyncReplicationRegionDiskRequest, Operation>("StopGroupAsyncReplication", grpcClient.StopGroupAsyncReplicationAsync, grpcClient.StopGroupAsyncReplication, effectiveSettings.StopGroupAsyncReplicationSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callStopGroupAsyncReplication);
            Modify_StopGroupAsyncReplicationApiCall(ref _callStopGroupAsyncReplication);
            _callTestIamPermissions = clientHelper.BuildApiCall<TestIamPermissionsRegionDiskRequest, TestPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            _callUpdate = clientHelper.BuildApiCall<UpdateRegionDiskRequest, Operation>("Update", grpcClient.UpdateAsync, grpcClient.Update, effectiveSettings.UpdateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("disk", request => request.Disk);
            Modify_ApiCall(ref _callUpdate);
            Modify_UpdateApiCall(ref _callUpdate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AddResourcePoliciesApiCall(ref gaxgrpc::ApiCall<AddResourcePoliciesRegionDiskRequest, Operation> call);

        partial void Modify_BulkInsertApiCall(ref gaxgrpc::ApiCall<BulkInsertRegionDiskRequest, Operation> call);

        partial void Modify_CreateSnapshotApiCall(ref gaxgrpc::ApiCall<CreateSnapshotRegionDiskRequest, Operation> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteRegionDiskRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetRegionDiskRequest, Disk> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<GetIamPolicyRegionDiskRequest, Policy> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertRegionDiskRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListRegionDisksRequest, DiskList> call);

        partial void Modify_RemoveResourcePoliciesApiCall(ref gaxgrpc::ApiCall<RemoveResourcePoliciesRegionDiskRequest, Operation> call);

        partial void Modify_ResizeApiCall(ref gaxgrpc::ApiCall<ResizeRegionDiskRequest, Operation> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<SetIamPolicyRegionDiskRequest, Policy> call);

        partial void Modify_SetLabelsApiCall(ref gaxgrpc::ApiCall<SetLabelsRegionDiskRequest, Operation> call);

        partial void Modify_StartAsyncReplicationApiCall(ref gaxgrpc::ApiCall<StartAsyncReplicationRegionDiskRequest, Operation> call);

        partial void Modify_StopAsyncReplicationApiCall(ref gaxgrpc::ApiCall<StopAsyncReplicationRegionDiskRequest, Operation> call);

        partial void Modify_StopGroupAsyncReplicationApiCall(ref gaxgrpc::ApiCall<StopGroupAsyncReplicationRegionDiskRequest, Operation> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<TestIamPermissionsRegionDiskRequest, TestPermissionsResponse> call);

        partial void Modify_UpdateApiCall(ref gaxgrpc::ApiCall<UpdateRegionDiskRequest, Operation> call);

        partial void OnConstruction(RegionDisks.RegionDisksClient grpcClient, RegionDisksSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RegionDisks client</summary>
        public override RegionDisks.RegionDisksClient GrpcClient { get; }

        partial void Modify_AddResourcePoliciesRegionDiskRequest(ref AddResourcePoliciesRegionDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BulkInsertRegionDiskRequest(ref BulkInsertRegionDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSnapshotRegionDiskRequest(ref CreateSnapshotRegionDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRegionDiskRequest(ref DeleteRegionDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRegionDiskRequest(ref GetRegionDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRegionDiskRequest(ref GetIamPolicyRegionDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertRegionDiskRequest(ref InsertRegionDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRegionDisksRequest(ref ListRegionDisksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveResourcePoliciesRegionDiskRequest(ref RemoveResourcePoliciesRegionDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResizeRegionDiskRequest(ref ResizeRegionDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRegionDiskRequest(ref SetIamPolicyRegionDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetLabelsRegionDiskRequest(ref SetLabelsRegionDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartAsyncReplicationRegionDiskRequest(ref StartAsyncReplicationRegionDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopAsyncReplicationRegionDiskRequest(ref StopAsyncReplicationRegionDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopGroupAsyncReplicationRegionDiskRequest(ref StopGroupAsyncReplicationRegionDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRegionDiskRequest(ref TestIamPermissionsRegionDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRegionDiskRequest(ref UpdateRegionDiskRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>AddResourcePolicies</c>.</summary>
        public override lro::OperationsClient AddResourcePoliciesOperationsClient { get; }

        /// <summary>
        /// Adds existing resource policies to a regional disk. You can only add one policy which will be applied to this disk for scheduling snapshot creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> AddResourcePolicies(AddResourcePoliciesRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddResourcePoliciesRegionDiskRequest(ref request, ref callSettings);
            Operation response = _callAddResourcePolicies.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddResourcePoliciesOperationsClient);
        }

        /// <summary>
        /// Adds existing resource policies to a regional disk. You can only add one policy which will be applied to this disk for scheduling snapshot creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> AddResourcePoliciesAsync(AddResourcePoliciesRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddResourcePoliciesRegionDiskRequest(ref request, ref callSettings);
            Operation response = await _callAddResourcePolicies.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddResourcePoliciesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BulkInsert</c>.</summary>
        public override lro::OperationsClient BulkInsertOperationsClient { get; }

        /// <summary>
        /// Bulk create a set of disks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> BulkInsert(BulkInsertRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkInsertRegionDiskRequest(ref request, ref callSettings);
            Operation response = _callBulkInsert.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), BulkInsertOperationsClient);
        }

        /// <summary>
        /// Bulk create a set of disks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> BulkInsertAsync(BulkInsertRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkInsertRegionDiskRequest(ref request, ref callSettings);
            Operation response = await _callBulkInsert.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), BulkInsertOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateSnapshot</c>.</summary>
        public override lro::OperationsClient CreateSnapshotOperationsClient { get; }

        /// <summary>
        /// Creates a snapshot of a specified persistent disk. For regular snapshot creation, consider using snapshots.insert instead, as that method supports more features, such as creating snapshots in a project different from the source disk project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> CreateSnapshot(CreateSnapshotRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSnapshotRegionDiskRequest(ref request, ref callSettings);
            Operation response = _callCreateSnapshot.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), CreateSnapshotOperationsClient);
        }

        /// <summary>
        /// Creates a snapshot of a specified persistent disk. For regular snapshot creation, consider using snapshots.insert instead, as that method supports more features, such as creating snapshots in a project different from the source disk project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> CreateSnapshotAsync(CreateSnapshotRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSnapshotRegionDiskRequest(ref request, ref callSettings);
            Operation response = await _callCreateSnapshot.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), CreateSnapshotOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Deletes the specified regional persistent disk. Deleting a regional disk removes all the replicas of its data permanently and is irreversible. However, deleting a disk does not delete any snapshots previously made from the disk. You must separately delete snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeleteRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionDiskRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Deletes the specified regional persistent disk. Deleting a regional disk removes all the replicas of its data permanently and is irreversible. However, deleting a disk does not delete any snapshots previously made from the disk. You must separately delete snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionDiskRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Returns a specified regional persistent disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Disk Get(GetRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionDiskRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a specified regional persistent disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Disk> GetAsync(GetRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionDiskRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy GetIamPolicy(GetIamPolicyRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRegionDiskRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRegionDiskRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Creates a persistent regional disk in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionDiskRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Creates a persistent regional disk in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionDiskRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Retrieves the list of persistent disks contained within the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Disk"/> resources.</returns>
        public override gax::PagedEnumerable<DiskList, Disk> List(ListRegionDisksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionDisksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRegionDisksRequest, DiskList, Disk>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of persistent disks contained within the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Disk"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<DiskList, Disk> ListAsync(ListRegionDisksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionDisksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRegionDisksRequest, DiskList, Disk>(_callList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RemoveResourcePolicies</c>.</summary>
        public override lro::OperationsClient RemoveResourcePoliciesOperationsClient { get; }

        /// <summary>
        /// Removes resource policies from a regional disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> RemoveResourcePolicies(RemoveResourcePoliciesRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveResourcePoliciesRegionDiskRequest(ref request, ref callSettings);
            Operation response = _callRemoveResourcePolicies.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveResourcePoliciesOperationsClient);
        }

        /// <summary>
        /// Removes resource policies from a regional disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> RemoveResourcePoliciesAsync(RemoveResourcePoliciesRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveResourcePoliciesRegionDiskRequest(ref request, ref callSettings);
            Operation response = await _callRemoveResourcePolicies.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveResourcePoliciesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Resize</c>.</summary>
        public override lro::OperationsClient ResizeOperationsClient { get; }

        /// <summary>
        /// Resizes the specified regional persistent disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Resize(ResizeRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResizeRegionDiskRequest(ref request, ref callSettings);
            Operation response = _callResize.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), ResizeOperationsClient);
        }

        /// <summary>
        /// Resizes the specified regional persistent disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> ResizeAsync(ResizeRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResizeRegionDiskRequest(ref request, ref callSettings);
            Operation response = await _callResize.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), ResizeOperationsClient);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy SetIamPolicy(SetIamPolicyRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRegionDiskRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRegionDiskRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>SetLabels</c>.</summary>
        public override lro::OperationsClient SetLabelsOperationsClient { get; }

        /// <summary>
        /// Sets the labels on the target regional disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetLabels(SetLabelsRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetLabelsRegionDiskRequest(ref request, ref callSettings);
            Operation response = _callSetLabels.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetLabelsOperationsClient);
        }

        /// <summary>
        /// Sets the labels on the target regional disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(SetLabelsRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetLabelsRegionDiskRequest(ref request, ref callSettings);
            Operation response = await _callSetLabels.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetLabelsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StartAsyncReplication</c>.</summary>
        public override lro::OperationsClient StartAsyncReplicationOperationsClient { get; }

        /// <summary>
        /// Starts asynchronous replication. Must be invoked on the primary disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> StartAsyncReplication(StartAsyncReplicationRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartAsyncReplicationRegionDiskRequest(ref request, ref callSettings);
            Operation response = _callStartAsyncReplication.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), StartAsyncReplicationOperationsClient);
        }

        /// <summary>
        /// Starts asynchronous replication. Must be invoked on the primary disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> StartAsyncReplicationAsync(StartAsyncReplicationRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartAsyncReplicationRegionDiskRequest(ref request, ref callSettings);
            Operation response = await _callStartAsyncReplication.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), StartAsyncReplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StopAsyncReplication</c>.</summary>
        public override lro::OperationsClient StopAsyncReplicationOperationsClient { get; }

        /// <summary>
        /// Stops asynchronous replication. Can be invoked either on the primary or on the secondary disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> StopAsyncReplication(StopAsyncReplicationRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopAsyncReplicationRegionDiskRequest(ref request, ref callSettings);
            Operation response = _callStopAsyncReplication.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), StopAsyncReplicationOperationsClient);
        }

        /// <summary>
        /// Stops asynchronous replication. Can be invoked either on the primary or on the secondary disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> StopAsyncReplicationAsync(StopAsyncReplicationRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopAsyncReplicationRegionDiskRequest(ref request, ref callSettings);
            Operation response = await _callStopAsyncReplication.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), StopAsyncReplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StopGroupAsyncReplication</c>.</summary>
        public override lro::OperationsClient StopGroupAsyncReplicationOperationsClient { get; }

        /// <summary>
        /// Stops asynchronous replication for a consistency group of disks. Can be invoked either in the primary or secondary scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> StopGroupAsyncReplication(StopGroupAsyncReplicationRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopGroupAsyncReplicationRegionDiskRequest(ref request, ref callSettings);
            Operation response = _callStopGroupAsyncReplication.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), StopGroupAsyncReplicationOperationsClient);
        }

        /// <summary>
        /// Stops asynchronous replication for a consistency group of disks. Can be invoked either in the primary or secondary scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> StopGroupAsyncReplicationAsync(StopGroupAsyncReplicationRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopGroupAsyncReplicationRegionDiskRequest(ref request, ref callSettings);
            Operation response = await _callStopGroupAsyncReplication.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), StopGroupAsyncReplicationOperationsClient);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TestPermissionsResponse TestIamPermissions(TestIamPermissionsRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRegionDiskRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRegionDiskRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Update</c>.</summary>
        public override lro::OperationsClient UpdateOperationsClient { get; }

        /// <summary>
        /// Update the specified disk with the data included in the request. Update is performed only on selected fields included as part of update-mask. Only the following fields can be modified: user_license.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Update(UpdateRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRegionDiskRequest(ref request, ref callSettings);
            Operation response = _callUpdate.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateOperationsClient);
        }

        /// <summary>
        /// Update the specified disk with the data included in the request. Update is performed only on selected fields included as part of update-mask. Only the following fields can be modified: user_license.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateRegionDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRegionDiskRequest(ref request, ref callSettings);
            Operation response = await _callUpdate.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateOperationsClient);
        }
    }

    public partial class ListRegionDisksRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public static partial class RegionDisks
    {
        public partial class RegionDisksClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client, delegating to RegionOperations.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForRegionOperations() =>
                RegionOperations.RegionOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }
}
