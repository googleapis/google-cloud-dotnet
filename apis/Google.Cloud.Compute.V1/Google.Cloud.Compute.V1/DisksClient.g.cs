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

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="DisksClient"/> instances.</summary>
    public sealed partial class DisksSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DisksSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DisksSettings"/>.</returns>
        public static DisksSettings GetDefault() => new DisksSettings();

        /// <summary>Constructs a new <see cref="DisksSettings"/> object with default settings.</summary>
        public DisksSettings()
        {
        }

        private DisksSettings(DisksSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AddResourcePoliciesSettings = existing.AddResourcePoliciesSettings;
            AddResourcePoliciesOperationsSettings = existing.AddResourcePoliciesOperationsSettings.Clone();
            AggregatedListSettings = existing.AggregatedListSettings;
            BulkInsertSettings = existing.BulkInsertSettings;
            BulkInsertOperationsSettings = existing.BulkInsertOperationsSettings.Clone();
            BulkSetLabelsSettings = existing.BulkSetLabelsSettings;
            BulkSetLabelsOperationsSettings = existing.BulkSetLabelsOperationsSettings.Clone();
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

        partial void OnCopy(DisksSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DisksClient.AddResourcePolicies</c> and <c>DisksClient.AddResourcePoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddResourcePoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DisksClient.AddResourcePolicies</c> and
        /// <c>DisksClient.AddResourcePoliciesAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DisksClient.AggregatedList</c>
        ///  and <c>DisksClient.AggregatedListAsync</c>.
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
        public gaxgrpc::CallSettings AggregatedListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DisksClient.BulkInsert</c>
        /// and <c>DisksClient.BulkInsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BulkInsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DisksClient.BulkInsert</c> and
        /// <c>DisksClient.BulkInsertAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DisksClient.BulkSetLabels</c>
        ///  and <c>DisksClient.BulkSetLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BulkSetLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DisksClient.BulkSetLabels</c> and
        /// <c>DisksClient.BulkSetLabelsAsync</c>.
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
        public lro::OperationsSettings BulkSetLabelsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DisksClient.CreateSnapshot</c>
        ///  and <c>DisksClient.CreateSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DisksClient.CreateSnapshot</c> and
        /// <c>DisksClient.CreateSnapshotAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DisksClient.Delete</c> and
        /// <c>DisksClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DisksClient.Delete</c> and <c>DisksClient.DeleteAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DisksClient.Get</c> and
        /// <c>DisksClient.GetAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DisksClient.GetIamPolicy</c>
        ///  and <c>DisksClient.GetIamPolicyAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DisksClient.Insert</c> and
        /// <c>DisksClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DisksClient.Insert</c> and <c>DisksClient.InsertAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DisksClient.List</c> and
        /// <c>DisksClient.ListAsync</c>.
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
        /// <c>DisksClient.RemoveResourcePolicies</c> and <c>DisksClient.RemoveResourcePoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveResourcePoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DisksClient.RemoveResourcePolicies</c> and
        /// <c>DisksClient.RemoveResourcePoliciesAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DisksClient.Resize</c> and
        /// <c>DisksClient.ResizeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResizeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DisksClient.Resize</c> and <c>DisksClient.ResizeAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DisksClient.SetIamPolicy</c>
        ///  and <c>DisksClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DisksClient.SetLabels</c>
        /// and <c>DisksClient.SetLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DisksClient.SetLabels</c> and <c>DisksClient.SetLabelsAsync</c>
        /// .
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
        /// <c>DisksClient.StartAsyncReplication</c> and <c>DisksClient.StartAsyncReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartAsyncReplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DisksClient.StartAsyncReplication</c> and
        /// <c>DisksClient.StartAsyncReplicationAsync</c>.
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
        /// <c>DisksClient.StopAsyncReplication</c> and <c>DisksClient.StopAsyncReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopAsyncReplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DisksClient.StopAsyncReplication</c> and
        /// <c>DisksClient.StopAsyncReplicationAsync</c>.
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
        /// <c>DisksClient.StopGroupAsyncReplication</c> and <c>DisksClient.StopGroupAsyncReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopGroupAsyncReplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DisksClient.StopGroupAsyncReplication</c> and
        /// <c>DisksClient.StopGroupAsyncReplicationAsync</c>.
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
        /// <c>DisksClient.TestIamPermissions</c> and <c>DisksClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DisksClient.Update</c> and
        /// <c>DisksClient.UpdateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DisksClient.Update</c> and <c>DisksClient.UpdateAsync</c>.
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
        /// <returns>A deep clone of this <see cref="DisksSettings"/> object.</returns>
        public DisksSettings Clone() => new DisksSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DisksClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DisksClientBuilder : gaxgrpc::ClientBuilderBase<DisksClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DisksSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DisksClientBuilder() : base(DisksClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DisksClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DisksClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DisksClient Build()
        {
            DisksClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DisksClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DisksClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DisksClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DisksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DisksClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DisksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DisksClient.ChannelPool;
    }

    /// <summary>Disks client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Disks API.
    /// </remarks>
    public abstract partial class DisksClient
    {
        /// <summary>
        /// The default endpoint for the Disks service, which is a host of "compute.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default Disks scopes.</summary>
        /// <remarks>
        /// The default Disks scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Disks.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DisksClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="DisksClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DisksClient"/>.</returns>
        public static stt::Task<DisksClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DisksClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DisksClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="DisksClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DisksClient"/>.</returns>
        public static DisksClient Create() => new DisksClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DisksClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DisksSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DisksClient"/>.</returns>
        internal static DisksClient Create(grpccore::CallInvoker callInvoker, DisksSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Disks.DisksClient grpcClient = new Disks.DisksClient(callInvoker);
            return new DisksClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Disks client</summary>
        public virtual Disks.DisksClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Adds existing resource policies to a disk. You can only add one policy which will be applied to this disk for scheduling snapshot creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddResourcePolicies(AddResourcePoliciesDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds existing resource policies to a disk. You can only add one policy which will be applied to this disk for scheduling snapshot creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddResourcePoliciesAsync(AddResourcePoliciesDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds existing resource policies to a disk. You can only add one policy which will be applied to this disk for scheduling snapshot creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddResourcePoliciesAsync(AddResourcePoliciesDiskRequest request, st::CancellationToken cancellationToken) =>
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
        /// Adds existing resource policies to a disk. You can only add one policy which will be applied to this disk for scheduling snapshot creation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// The disk name for this request.
        /// </param>
        /// <param name="disksAddResourcePoliciesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddResourcePolicies(string project, string zone, string disk, DisksAddResourcePoliciesRequest disksAddResourcePoliciesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            AddResourcePolicies(new AddResourcePoliciesDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                DisksAddResourcePoliciesRequestResource = gax::GaxPreconditions.CheckNotNull(disksAddResourcePoliciesRequestResource, nameof(disksAddResourcePoliciesRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Adds existing resource policies to a disk. You can only add one policy which will be applied to this disk for scheduling snapshot creation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// The disk name for this request.
        /// </param>
        /// <param name="disksAddResourcePoliciesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddResourcePoliciesAsync(string project, string zone, string disk, DisksAddResourcePoliciesRequest disksAddResourcePoliciesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            AddResourcePoliciesAsync(new AddResourcePoliciesDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                DisksAddResourcePoliciesRequestResource = gax::GaxPreconditions.CheckNotNull(disksAddResourcePoliciesRequestResource, nameof(disksAddResourcePoliciesRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Adds existing resource policies to a disk. You can only add one policy which will be applied to this disk for scheduling snapshot creation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// The disk name for this request.
        /// </param>
        /// <param name="disksAddResourcePoliciesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddResourcePoliciesAsync(string project, string zone, string disk, DisksAddResourcePoliciesRequest disksAddResourcePoliciesRequestResource, st::CancellationToken cancellationToken) =>
            AddResourcePoliciesAsync(project, zone, disk, disksAddResourcePoliciesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an aggregated list of persistent disks. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<DiskAggregatedList, scg::KeyValuePair<string, DisksScopedList>> AggregatedList(AggregatedListDisksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of persistent disks. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<DiskAggregatedList, scg::KeyValuePair<string, DisksScopedList>> AggregatedListAsync(AggregatedListDisksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of persistent disks. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<DiskAggregatedList, scg::KeyValuePair<string, DisksScopedList>> AggregatedList(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListDisksRequest request = new AggregatedListDisksRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return AggregatedList(request, callSettings);
        }

        /// <summary>
        /// Retrieves an aggregated list of persistent disks. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<DiskAggregatedList, scg::KeyValuePair<string, DisksScopedList>> AggregatedListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListDisksRequest request = new AggregatedListDisksRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return AggregatedListAsync(request, callSettings);
        }

        /// <summary>
        /// Bulk create a set of disks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> BulkInsert(BulkInsertDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk create a set of disks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> BulkInsertAsync(BulkInsertDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk create a set of disks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> BulkInsertAsync(BulkInsertDiskRequest request, st::CancellationToken cancellationToken) =>
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
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="bulkInsertDiskResourceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> BulkInsert(string project, string zone, BulkInsertDiskResource bulkInsertDiskResourceResource, gaxgrpc::CallSettings callSettings = null) =>
            BulkInsert(new BulkInsertDiskRequest
            {
                BulkInsertDiskResourceResource = gax::GaxPreconditions.CheckNotNull(bulkInsertDiskResourceResource, nameof(bulkInsertDiskResourceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Bulk create a set of disks.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="bulkInsertDiskResourceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> BulkInsertAsync(string project, string zone, BulkInsertDiskResource bulkInsertDiskResourceResource, gaxgrpc::CallSettings callSettings = null) =>
            BulkInsertAsync(new BulkInsertDiskRequest
            {
                BulkInsertDiskResourceResource = gax::GaxPreconditions.CheckNotNull(bulkInsertDiskResourceResource, nameof(bulkInsertDiskResourceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Bulk create a set of disks.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="bulkInsertDiskResourceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> BulkInsertAsync(string project, string zone, BulkInsertDiskResource bulkInsertDiskResourceResource, st::CancellationToken cancellationToken) =>
            BulkInsertAsync(project, zone, bulkInsertDiskResourceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the labels on many disks at once. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> BulkSetLabels(BulkSetLabelsDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the labels on many disks at once. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> BulkSetLabelsAsync(BulkSetLabelsDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the labels on many disks at once. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> BulkSetLabelsAsync(BulkSetLabelsDiskRequest request, st::CancellationToken cancellationToken) =>
            BulkSetLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BulkSetLabels</c>.</summary>
        public virtual lro::OperationsClient BulkSetLabelsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BulkSetLabels</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceBulkSetLabels(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BulkSetLabelsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BulkSetLabels</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceBulkSetLabelsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BulkSetLabelsOperationsClient, callSettings);

        /// <summary>
        /// Sets the labels on many disks at once. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="bulkZoneSetLabelsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> BulkSetLabels(string project, string zone, BulkZoneSetLabelsRequest bulkZoneSetLabelsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            BulkSetLabels(new BulkSetLabelsDiskRequest
            {
                BulkZoneSetLabelsRequestResource = gax::GaxPreconditions.CheckNotNull(bulkZoneSetLabelsRequestResource, nameof(bulkZoneSetLabelsRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets the labels on many disks at once. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="bulkZoneSetLabelsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> BulkSetLabelsAsync(string project, string zone, BulkZoneSetLabelsRequest bulkZoneSetLabelsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            BulkSetLabelsAsync(new BulkSetLabelsDiskRequest
            {
                BulkZoneSetLabelsRequestResource = gax::GaxPreconditions.CheckNotNull(bulkZoneSetLabelsRequestResource, nameof(bulkZoneSetLabelsRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets the labels on many disks at once. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="bulkZoneSetLabelsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> BulkSetLabelsAsync(string project, string zone, BulkZoneSetLabelsRequest bulkZoneSetLabelsRequestResource, st::CancellationToken cancellationToken) =>
            BulkSetLabelsAsync(project, zone, bulkZoneSetLabelsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a snapshot of a specified persistent disk. For regular snapshot creation, consider using snapshots.insert instead, as that method supports more features, such as creating snapshots in a project different from the source disk project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> CreateSnapshot(CreateSnapshotDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a snapshot of a specified persistent disk. For regular snapshot creation, consider using snapshots.insert instead, as that method supports more features, such as creating snapshots in a project different from the source disk project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CreateSnapshotAsync(CreateSnapshotDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a snapshot of a specified persistent disk. For regular snapshot creation, consider using snapshots.insert instead, as that method supports more features, such as creating snapshots in a project different from the source disk project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CreateSnapshotAsync(CreateSnapshotDiskRequest request, st::CancellationToken cancellationToken) =>
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
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the persistent disk to snapshot.
        /// </param>
        /// <param name="snapshotResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> CreateSnapshot(string project, string zone, string disk, Snapshot snapshotResource, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshot(new CreateSnapshotDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SnapshotResource = gax::GaxPreconditions.CheckNotNull(snapshotResource, nameof(snapshotResource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates a snapshot of a specified persistent disk. For regular snapshot creation, consider using snapshots.insert instead, as that method supports more features, such as creating snapshots in a project different from the source disk project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the persistent disk to snapshot.
        /// </param>
        /// <param name="snapshotResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CreateSnapshotAsync(string project, string zone, string disk, Snapshot snapshotResource, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshotAsync(new CreateSnapshotDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SnapshotResource = gax::GaxPreconditions.CheckNotNull(snapshotResource, nameof(snapshotResource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates a snapshot of a specified persistent disk. For regular snapshot creation, consider using snapshots.insert instead, as that method supports more features, such as creating snapshots in a project different from the source disk project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the persistent disk to snapshot.
        /// </param>
        /// <param name="snapshotResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CreateSnapshotAsync(string project, string zone, string disk, Snapshot snapshotResource, st::CancellationToken cancellationToken) =>
            CreateSnapshotAsync(project, zone, disk, snapshotResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified persistent disk. Deleting a disk removes its data permanently and is irreversible. However, deleting a disk does not delete any snapshots previously made from the disk. You must separately delete snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeleteDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified persistent disk. Deleting a disk removes its data permanently and is irreversible. However, deleting a disk does not delete any snapshots previously made from the disk. You must separately delete snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified persistent disk. Deleting a disk removes its data permanently and is irreversible. However, deleting a disk does not delete any snapshots previously made from the disk. You must separately delete snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteDiskRequest request, st::CancellationToken cancellationToken) =>
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
        /// Deletes the specified persistent disk. Deleting a disk removes its data permanently and is irreversible. However, deleting a disk does not delete any snapshots previously made from the disk. You must separately delete snapshots.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the persistent disk to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string project, string zone, string disk, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified persistent disk. Deleting a disk removes its data permanently and is irreversible. However, deleting a disk does not delete any snapshots previously made from the disk. You must separately delete snapshots.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the persistent disk to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string zone, string disk, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified persistent disk. Deleting a disk removes its data permanently and is irreversible. However, deleting a disk does not delete any snapshots previously made from the disk. You must separately delete snapshots.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the persistent disk to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string zone, string disk, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, zone, disk, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified persistent disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Disk Get(GetDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified persistent disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Disk> GetAsync(GetDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified persistent disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Disk> GetAsync(GetDiskRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified persistent disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the persistent disk to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Disk Get(string project, string zone, string disk, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the specified persistent disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the persistent disk to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Disk> GetAsync(string project, string zone, string disk, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the specified persistent disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// Name of the persistent disk to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Disk> GetAsync(string project, string zone, string disk, st::CancellationToken cancellationToken) =>
            GetAsync(project, zone, disk, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetIamPolicy(GetIamPolicyDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyDiskRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetIamPolicy(string project, string zone, string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new GetIamPolicyDiskRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(string project, string zone, string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new GetIamPolicyDiskRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(string project, string zone, string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(project, zone, resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a persistent disk in the specified project using the data in the request. You can create a disk from a source (sourceImage, sourceSnapshot, or sourceDisk) or create an empty 500 GB data disk by omitting all properties. You can also create a disk that is larger than the default size by specifying the sizeGb property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a persistent disk in the specified project using the data in the request. You can create a disk from a source (sourceImage, sourceSnapshot, or sourceDisk) or create an empty 500 GB data disk by omitting all properties. You can also create a disk that is larger than the default size by specifying the sizeGb property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a persistent disk in the specified project using the data in the request. You can create a disk from a source (sourceImage, sourceSnapshot, or sourceDisk) or create an empty 500 GB data disk by omitting all properties. You can also create a disk that is larger than the default size by specifying the sizeGb property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertDiskRequest request, st::CancellationToken cancellationToken) =>
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
        /// Creates a persistent disk in the specified project using the data in the request. You can create a disk from a source (sourceImage, sourceSnapshot, or sourceDisk) or create an empty 500 GB data disk by omitting all properties. You can also create a disk that is larger than the default size by specifying the sizeGb property.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="diskResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(string project, string zone, Disk diskResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertDiskRequest
            {
                DiskResource = gax::GaxPreconditions.CheckNotNull(diskResource, nameof(diskResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates a persistent disk in the specified project using the data in the request. You can create a disk from a source (sourceImage, sourceSnapshot, or sourceDisk) or create an empty 500 GB data disk by omitting all properties. You can also create a disk that is larger than the default size by specifying the sizeGb property.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="diskResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string zone, Disk diskResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertDiskRequest
            {
                DiskResource = gax::GaxPreconditions.CheckNotNull(diskResource, nameof(diskResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates a persistent disk in the specified project using the data in the request. You can create a disk from a source (sourceImage, sourceSnapshot, or sourceDisk) or create an empty 500 GB data disk by omitting all properties. You can also create a disk that is larger than the default size by specifying the sizeGb property.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="diskResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string zone, Disk diskResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, zone, diskResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of persistent disks contained within the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Disk"/> resources.</returns>
        public virtual gax::PagedEnumerable<DiskList, Disk> List(ListDisksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of persistent disks contained within the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Disk"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<DiskList, Disk> ListAsync(ListDisksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of persistent disks contained within the specified zone.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
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
        public virtual gax::PagedEnumerable<DiskList, Disk> List(string project, string zone, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDisksRequest request = new ListDisksRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
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
        /// Retrieves a list of persistent disks contained within the specified zone.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
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
        public virtual gax::PagedAsyncEnumerable<DiskList, Disk> ListAsync(string project, string zone, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDisksRequest request = new ListDisksRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
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
        /// Removes resource policies from a disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveResourcePolicies(RemoveResourcePoliciesDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes resource policies from a disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveResourcePoliciesAsync(RemoveResourcePoliciesDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes resource policies from a disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveResourcePoliciesAsync(RemoveResourcePoliciesDiskRequest request, st::CancellationToken cancellationToken) =>
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
        /// Removes resource policies from a disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// The disk name for this request.
        /// </param>
        /// <param name="disksRemoveResourcePoliciesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveResourcePolicies(string project, string zone, string disk, DisksRemoveResourcePoliciesRequest disksRemoveResourcePoliciesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            RemoveResourcePolicies(new RemoveResourcePoliciesDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                DisksRemoveResourcePoliciesRequestResource = gax::GaxPreconditions.CheckNotNull(disksRemoveResourcePoliciesRequestResource, nameof(disksRemoveResourcePoliciesRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Removes resource policies from a disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// The disk name for this request.
        /// </param>
        /// <param name="disksRemoveResourcePoliciesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveResourcePoliciesAsync(string project, string zone, string disk, DisksRemoveResourcePoliciesRequest disksRemoveResourcePoliciesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            RemoveResourcePoliciesAsync(new RemoveResourcePoliciesDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                DisksRemoveResourcePoliciesRequestResource = gax::GaxPreconditions.CheckNotNull(disksRemoveResourcePoliciesRequestResource, nameof(disksRemoveResourcePoliciesRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Removes resource policies from a disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// The disk name for this request.
        /// </param>
        /// <param name="disksRemoveResourcePoliciesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveResourcePoliciesAsync(string project, string zone, string disk, DisksRemoveResourcePoliciesRequest disksRemoveResourcePoliciesRequestResource, st::CancellationToken cancellationToken) =>
            RemoveResourcePoliciesAsync(project, zone, disk, disksRemoveResourcePoliciesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resizes the specified persistent disk. You can only increase the size of the disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Resize(ResizeDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resizes the specified persistent disk. You can only increase the size of the disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ResizeAsync(ResizeDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resizes the specified persistent disk. You can only increase the size of the disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ResizeAsync(ResizeDiskRequest request, st::CancellationToken cancellationToken) =>
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
        /// Resizes the specified persistent disk. You can only increase the size of the disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// The name of the persistent disk.
        /// </param>
        /// <param name="disksResizeRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Resize(string project, string zone, string disk, DisksResizeRequest disksResizeRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            Resize(new ResizeDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                DisksResizeRequestResource = gax::GaxPreconditions.CheckNotNull(disksResizeRequestResource, nameof(disksResizeRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Resizes the specified persistent disk. You can only increase the size of the disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// The name of the persistent disk.
        /// </param>
        /// <param name="disksResizeRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ResizeAsync(string project, string zone, string disk, DisksResizeRequest disksResizeRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            ResizeAsync(new ResizeDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                DisksResizeRequestResource = gax::GaxPreconditions.CheckNotNull(disksResizeRequestResource, nameof(disksResizeRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Resizes the specified persistent disk. You can only increase the size of the disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// The name of the persistent disk.
        /// </param>
        /// <param name="disksResizeRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ResizeAsync(string project, string zone, string disk, DisksResizeRequest disksResizeRequestResource, st::CancellationToken cancellationToken) =>
            ResizeAsync(project, zone, disk, disksResizeRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy SetIamPolicy(SetIamPolicyDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyDiskRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="zoneSetPolicyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy SetIamPolicy(string project, string zone, string resource, ZoneSetPolicyRequest zoneSetPolicyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new SetIamPolicyDiskRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ZoneSetPolicyRequestResource = gax::GaxPreconditions.CheckNotNull(zoneSetPolicyRequestResource, nameof(zoneSetPolicyRequestResource)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="zoneSetPolicyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(string project, string zone, string resource, ZoneSetPolicyRequest zoneSetPolicyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new SetIamPolicyDiskRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ZoneSetPolicyRequestResource = gax::GaxPreconditions.CheckNotNull(zoneSetPolicyRequestResource, nameof(zoneSetPolicyRequestResource)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="zoneSetPolicyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(string project, string zone, string resource, ZoneSetPolicyRequest zoneSetPolicyRequestResource, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(project, zone, resource, zoneSetPolicyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the labels on a disk. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetLabels(SetLabelsDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the labels on a disk. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(SetLabelsDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the labels on a disk. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(SetLabelsDiskRequest request, st::CancellationToken cancellationToken) =>
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
        /// Sets the labels on a disk. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="zoneSetLabelsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetLabels(string project, string zone, string resource, ZoneSetLabelsRequest zoneSetLabelsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetLabels(new SetLabelsDiskRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ZoneSetLabelsRequestResource = gax::GaxPreconditions.CheckNotNull(zoneSetLabelsRequestResource, nameof(zoneSetLabelsRequestResource)),
            }, callSettings);

        /// <summary>
        /// Sets the labels on a disk. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="zoneSetLabelsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(string project, string zone, string resource, ZoneSetLabelsRequest zoneSetLabelsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetLabelsAsync(new SetLabelsDiskRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ZoneSetLabelsRequestResource = gax::GaxPreconditions.CheckNotNull(zoneSetLabelsRequestResource, nameof(zoneSetLabelsRequestResource)),
            }, callSettings);

        /// <summary>
        /// Sets the labels on a disk. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="zoneSetLabelsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(string project, string zone, string resource, ZoneSetLabelsRequest zoneSetLabelsRequestResource, st::CancellationToken cancellationToken) =>
            SetLabelsAsync(project, zone, resource, zoneSetLabelsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts asynchronous replication. Must be invoked on the primary disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> StartAsyncReplication(StartAsyncReplicationDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts asynchronous replication. Must be invoked on the primary disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StartAsyncReplicationAsync(StartAsyncReplicationDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts asynchronous replication. Must be invoked on the primary disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StartAsyncReplicationAsync(StartAsyncReplicationDiskRequest request, st::CancellationToken cancellationToken) =>
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
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// The name of the persistent disk.
        /// </param>
        /// <param name="disksStartAsyncReplicationRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> StartAsyncReplication(string project, string zone, string disk, DisksStartAsyncReplicationRequest disksStartAsyncReplicationRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            StartAsyncReplication(new StartAsyncReplicationDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                DisksStartAsyncReplicationRequestResource = gax::GaxPreconditions.CheckNotNull(disksStartAsyncReplicationRequestResource, nameof(disksStartAsyncReplicationRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Starts asynchronous replication. Must be invoked on the primary disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// The name of the persistent disk.
        /// </param>
        /// <param name="disksStartAsyncReplicationRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StartAsyncReplicationAsync(string project, string zone, string disk, DisksStartAsyncReplicationRequest disksStartAsyncReplicationRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            StartAsyncReplicationAsync(new StartAsyncReplicationDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                DisksStartAsyncReplicationRequestResource = gax::GaxPreconditions.CheckNotNull(disksStartAsyncReplicationRequestResource, nameof(disksStartAsyncReplicationRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Starts asynchronous replication. Must be invoked on the primary disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// The name of the persistent disk.
        /// </param>
        /// <param name="disksStartAsyncReplicationRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StartAsyncReplicationAsync(string project, string zone, string disk, DisksStartAsyncReplicationRequest disksStartAsyncReplicationRequestResource, st::CancellationToken cancellationToken) =>
            StartAsyncReplicationAsync(project, zone, disk, disksStartAsyncReplicationRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops asynchronous replication. Can be invoked either on the primary or on the secondary disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> StopAsyncReplication(StopAsyncReplicationDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops asynchronous replication. Can be invoked either on the primary or on the secondary disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopAsyncReplicationAsync(StopAsyncReplicationDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops asynchronous replication. Can be invoked either on the primary or on the secondary disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopAsyncReplicationAsync(StopAsyncReplicationDiskRequest request, st::CancellationToken cancellationToken) =>
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
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// The name of the persistent disk.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> StopAsyncReplication(string project, string zone, string disk, gaxgrpc::CallSettings callSettings = null) =>
            StopAsyncReplication(new StopAsyncReplicationDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Stops asynchronous replication. Can be invoked either on the primary or on the secondary disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// The name of the persistent disk.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopAsyncReplicationAsync(string project, string zone, string disk, gaxgrpc::CallSettings callSettings = null) =>
            StopAsyncReplicationAsync(new StopAsyncReplicationDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Stops asynchronous replication. Can be invoked either on the primary or on the secondary disk.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// The name of the persistent disk.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopAsyncReplicationAsync(string project, string zone, string disk, st::CancellationToken cancellationToken) =>
            StopAsyncReplicationAsync(project, zone, disk, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops asynchronous replication for a consistency group of disks. Can be invoked either in the primary or secondary scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> StopGroupAsyncReplication(StopGroupAsyncReplicationDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops asynchronous replication for a consistency group of disks. Can be invoked either in the primary or secondary scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopGroupAsyncReplicationAsync(StopGroupAsyncReplicationDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops asynchronous replication for a consistency group of disks. Can be invoked either in the primary or secondary scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopGroupAsyncReplicationAsync(StopGroupAsyncReplicationDiskRequest request, st::CancellationToken cancellationToken) =>
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
        /// <param name="zone">
        /// The name of the zone for this request. This must be the zone of the primary or secondary disks in the consistency group.
        /// </param>
        /// <param name="disksStopGroupAsyncReplicationResourceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> StopGroupAsyncReplication(string project, string zone, DisksStopGroupAsyncReplicationResource disksStopGroupAsyncReplicationResourceResource, gaxgrpc::CallSettings callSettings = null) =>
            StopGroupAsyncReplication(new StopGroupAsyncReplicationDiskRequest
            {
                DisksStopGroupAsyncReplicationResourceResource = gax::GaxPreconditions.CheckNotNull(disksStopGroupAsyncReplicationResourceResource, nameof(disksStopGroupAsyncReplicationResourceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Stops asynchronous replication for a consistency group of disks. Can be invoked either in the primary or secondary scope.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request. This must be the zone of the primary or secondary disks in the consistency group.
        /// </param>
        /// <param name="disksStopGroupAsyncReplicationResourceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopGroupAsyncReplicationAsync(string project, string zone, DisksStopGroupAsyncReplicationResource disksStopGroupAsyncReplicationResourceResource, gaxgrpc::CallSettings callSettings = null) =>
            StopGroupAsyncReplicationAsync(new StopGroupAsyncReplicationDiskRequest
            {
                DisksStopGroupAsyncReplicationResourceResource = gax::GaxPreconditions.CheckNotNull(disksStopGroupAsyncReplicationResourceResource, nameof(disksStopGroupAsyncReplicationResourceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Stops asynchronous replication for a consistency group of disks. Can be invoked either in the primary or secondary scope.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request. This must be the zone of the primary or secondary disks in the consistency group.
        /// </param>
        /// <param name="disksStopGroupAsyncReplicationResourceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopGroupAsyncReplicationAsync(string project, string zone, DisksStopGroupAsyncReplicationResource disksStopGroupAsyncReplicationResourceResource, st::CancellationToken cancellationToken) =>
            StopGroupAsyncReplicationAsync(project, zone, disksStopGroupAsyncReplicationResourceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestPermissionsResponse TestIamPermissions(TestIamPermissionsDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsDiskRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestPermissionsResponse TestIamPermissions(string project, string zone, string resource, TestPermissionsRequest testPermissionsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new TestIamPermissionsDiskRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                TestPermissionsRequestResource = gax::GaxPreconditions.CheckNotNull(testPermissionsRequestResource, nameof(testPermissionsRequestResource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(string project, string zone, string resource, TestPermissionsRequest testPermissionsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new TestIamPermissionsDiskRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                TestPermissionsRequestResource = gax::GaxPreconditions.CheckNotNull(testPermissionsRequestResource, nameof(testPermissionsRequestResource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(string project, string zone, string resource, TestPermissionsRequest testPermissionsRequestResource, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(project, zone, resource, testPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified disk with the data included in the request. The update is performed only on selected fields included as part of update-mask. Only the following fields can be modified: user_license.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Update(UpdateDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified disk with the data included in the request. The update is performed only on selected fields included as part of update-mask. Only the following fields can be modified: user_license.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateDiskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified disk with the data included in the request. The update is performed only on selected fields included as part of update-mask. Only the following fields can be modified: user_license.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateDiskRequest request, st::CancellationToken cancellationToken) =>
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
        /// Updates the specified disk with the data included in the request. The update is performed only on selected fields included as part of update-mask. Only the following fields can be modified: user_license.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// The disk name for this request.
        /// </param>
        /// <param name="diskResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Update(string project, string zone, string disk, Disk diskResource, gaxgrpc::CallSettings callSettings = null) =>
            Update(new UpdateDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                DiskResource = gax::GaxPreconditions.CheckNotNull(diskResource, nameof(diskResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Updates the specified disk with the data included in the request. The update is performed only on selected fields included as part of update-mask. Only the following fields can be modified: user_license.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// The disk name for this request.
        /// </param>
        /// <param name="diskResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(string project, string zone, string disk, Disk diskResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAsync(new UpdateDiskRequest
            {
                Disk = gax::GaxPreconditions.CheckNotNullOrEmpty(disk, nameof(disk)),
                DiskResource = gax::GaxPreconditions.CheckNotNull(diskResource, nameof(diskResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Updates the specified disk with the data included in the request. The update is performed only on selected fields included as part of update-mask. Only the following fields can be modified: user_license.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="disk">
        /// The disk name for this request.
        /// </param>
        /// <param name="diskResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(string project, string zone, string disk, Disk diskResource, st::CancellationToken cancellationToken) =>
            UpdateAsync(project, zone, disk, diskResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Disks client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Disks API.
    /// </remarks>
    public sealed partial class DisksClientImpl : DisksClient
    {
        private readonly gaxgrpc::ApiCall<AddResourcePoliciesDiskRequest, Operation> _callAddResourcePolicies;

        private readonly gaxgrpc::ApiCall<AggregatedListDisksRequest, DiskAggregatedList> _callAggregatedList;

        private readonly gaxgrpc::ApiCall<BulkInsertDiskRequest, Operation> _callBulkInsert;

        private readonly gaxgrpc::ApiCall<BulkSetLabelsDiskRequest, Operation> _callBulkSetLabels;

        private readonly gaxgrpc::ApiCall<CreateSnapshotDiskRequest, Operation> _callCreateSnapshot;

        private readonly gaxgrpc::ApiCall<DeleteDiskRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetDiskRequest, Disk> _callGet;

        private readonly gaxgrpc::ApiCall<GetIamPolicyDiskRequest, Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<InsertDiskRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListDisksRequest, DiskList> _callList;

        private readonly gaxgrpc::ApiCall<RemoveResourcePoliciesDiskRequest, Operation> _callRemoveResourcePolicies;

        private readonly gaxgrpc::ApiCall<ResizeDiskRequest, Operation> _callResize;

        private readonly gaxgrpc::ApiCall<SetIamPolicyDiskRequest, Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<SetLabelsDiskRequest, Operation> _callSetLabels;

        private readonly gaxgrpc::ApiCall<StartAsyncReplicationDiskRequest, Operation> _callStartAsyncReplication;

        private readonly gaxgrpc::ApiCall<StopAsyncReplicationDiskRequest, Operation> _callStopAsyncReplication;

        private readonly gaxgrpc::ApiCall<StopGroupAsyncReplicationDiskRequest, Operation> _callStopGroupAsyncReplication;

        private readonly gaxgrpc::ApiCall<TestIamPermissionsDiskRequest, TestPermissionsResponse> _callTestIamPermissions;

        private readonly gaxgrpc::ApiCall<UpdateDiskRequest, Operation> _callUpdate;

        /// <summary>
        /// Constructs a client wrapper for the Disks service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DisksSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DisksClientImpl(Disks.DisksClient grpcClient, DisksSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DisksSettings effectiveSettings = settings ?? DisksSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            AddResourcePoliciesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.AddResourcePoliciesOperationsSettings, logger);
            BulkInsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.BulkInsertOperationsSettings, logger);
            BulkSetLabelsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.BulkSetLabelsOperationsSettings, logger);
            CreateSnapshotOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.CreateSnapshotOperationsSettings, logger);
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.DeleteOperationsSettings, logger);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.InsertOperationsSettings, logger);
            RemoveResourcePoliciesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.RemoveResourcePoliciesOperationsSettings, logger);
            ResizeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.ResizeOperationsSettings, logger);
            SetLabelsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.SetLabelsOperationsSettings, logger);
            StartAsyncReplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.StartAsyncReplicationOperationsSettings, logger);
            StopAsyncReplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.StopAsyncReplicationOperationsSettings, logger);
            StopGroupAsyncReplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.StopGroupAsyncReplicationOperationsSettings, logger);
            UpdateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.UpdateOperationsSettings, logger);
            _callAddResourcePolicies = clientHelper.BuildApiCall<AddResourcePoliciesDiskRequest, Operation>("AddResourcePolicies", grpcClient.AddResourcePoliciesAsync, grpcClient.AddResourcePolicies, effectiveSettings.AddResourcePoliciesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("disk", request => request.Disk);
            Modify_ApiCall(ref _callAddResourcePolicies);
            Modify_AddResourcePoliciesApiCall(ref _callAddResourcePolicies);
            _callAggregatedList = clientHelper.BuildApiCall<AggregatedListDisksRequest, DiskAggregatedList>("AggregatedList", grpcClient.AggregatedListAsync, grpcClient.AggregatedList, effectiveSettings.AggregatedListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callAggregatedList);
            Modify_AggregatedListApiCall(ref _callAggregatedList);
            _callBulkInsert = clientHelper.BuildApiCall<BulkInsertDiskRequest, Operation>("BulkInsert", grpcClient.BulkInsertAsync, grpcClient.BulkInsert, effectiveSettings.BulkInsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone);
            Modify_ApiCall(ref _callBulkInsert);
            Modify_BulkInsertApiCall(ref _callBulkInsert);
            _callBulkSetLabels = clientHelper.BuildApiCall<BulkSetLabelsDiskRequest, Operation>("BulkSetLabels", grpcClient.BulkSetLabelsAsync, grpcClient.BulkSetLabels, effectiveSettings.BulkSetLabelsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone);
            Modify_ApiCall(ref _callBulkSetLabels);
            Modify_BulkSetLabelsApiCall(ref _callBulkSetLabels);
            _callCreateSnapshot = clientHelper.BuildApiCall<CreateSnapshotDiskRequest, Operation>("CreateSnapshot", grpcClient.CreateSnapshotAsync, grpcClient.CreateSnapshot, effectiveSettings.CreateSnapshotSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("disk", request => request.Disk);
            Modify_ApiCall(ref _callCreateSnapshot);
            Modify_CreateSnapshotApiCall(ref _callCreateSnapshot);
            _callDelete = clientHelper.BuildApiCall<DeleteDiskRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("disk", request => request.Disk);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetDiskRequest, Disk>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("disk", request => request.Disk);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callGetIamPolicy = clientHelper.BuildApiCall<GetIamPolicyDiskRequest, Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callInsert = clientHelper.BuildApiCall<InsertDiskRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListDisksRequest, DiskList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callRemoveResourcePolicies = clientHelper.BuildApiCall<RemoveResourcePoliciesDiskRequest, Operation>("RemoveResourcePolicies", grpcClient.RemoveResourcePoliciesAsync, grpcClient.RemoveResourcePolicies, effectiveSettings.RemoveResourcePoliciesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("disk", request => request.Disk);
            Modify_ApiCall(ref _callRemoveResourcePolicies);
            Modify_RemoveResourcePoliciesApiCall(ref _callRemoveResourcePolicies);
            _callResize = clientHelper.BuildApiCall<ResizeDiskRequest, Operation>("Resize", grpcClient.ResizeAsync, grpcClient.Resize, effectiveSettings.ResizeSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("disk", request => request.Disk);
            Modify_ApiCall(ref _callResize);
            Modify_ResizeApiCall(ref _callResize);
            _callSetIamPolicy = clientHelper.BuildApiCall<SetIamPolicyDiskRequest, Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callSetLabels = clientHelper.BuildApiCall<SetLabelsDiskRequest, Operation>("SetLabels", grpcClient.SetLabelsAsync, grpcClient.SetLabels, effectiveSettings.SetLabelsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetLabels);
            Modify_SetLabelsApiCall(ref _callSetLabels);
            _callStartAsyncReplication = clientHelper.BuildApiCall<StartAsyncReplicationDiskRequest, Operation>("StartAsyncReplication", grpcClient.StartAsyncReplicationAsync, grpcClient.StartAsyncReplication, effectiveSettings.StartAsyncReplicationSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("disk", request => request.Disk);
            Modify_ApiCall(ref _callStartAsyncReplication);
            Modify_StartAsyncReplicationApiCall(ref _callStartAsyncReplication);
            _callStopAsyncReplication = clientHelper.BuildApiCall<StopAsyncReplicationDiskRequest, Operation>("StopAsyncReplication", grpcClient.StopAsyncReplicationAsync, grpcClient.StopAsyncReplication, effectiveSettings.StopAsyncReplicationSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("disk", request => request.Disk);
            Modify_ApiCall(ref _callStopAsyncReplication);
            Modify_StopAsyncReplicationApiCall(ref _callStopAsyncReplication);
            _callStopGroupAsyncReplication = clientHelper.BuildApiCall<StopGroupAsyncReplicationDiskRequest, Operation>("StopGroupAsyncReplication", grpcClient.StopGroupAsyncReplicationAsync, grpcClient.StopGroupAsyncReplication, effectiveSettings.StopGroupAsyncReplicationSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone);
            Modify_ApiCall(ref _callStopGroupAsyncReplication);
            Modify_StopGroupAsyncReplicationApiCall(ref _callStopGroupAsyncReplication);
            _callTestIamPermissions = clientHelper.BuildApiCall<TestIamPermissionsDiskRequest, TestPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            _callUpdate = clientHelper.BuildApiCall<UpdateDiskRequest, Operation>("Update", grpcClient.UpdateAsync, grpcClient.Update, effectiveSettings.UpdateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("disk", request => request.Disk);
            Modify_ApiCall(ref _callUpdate);
            Modify_UpdateApiCall(ref _callUpdate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AddResourcePoliciesApiCall(ref gaxgrpc::ApiCall<AddResourcePoliciesDiskRequest, Operation> call);

        partial void Modify_AggregatedListApiCall(ref gaxgrpc::ApiCall<AggregatedListDisksRequest, DiskAggregatedList> call);

        partial void Modify_BulkInsertApiCall(ref gaxgrpc::ApiCall<BulkInsertDiskRequest, Operation> call);

        partial void Modify_BulkSetLabelsApiCall(ref gaxgrpc::ApiCall<BulkSetLabelsDiskRequest, Operation> call);

        partial void Modify_CreateSnapshotApiCall(ref gaxgrpc::ApiCall<CreateSnapshotDiskRequest, Operation> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteDiskRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetDiskRequest, Disk> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<GetIamPolicyDiskRequest, Policy> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertDiskRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListDisksRequest, DiskList> call);

        partial void Modify_RemoveResourcePoliciesApiCall(ref gaxgrpc::ApiCall<RemoveResourcePoliciesDiskRequest, Operation> call);

        partial void Modify_ResizeApiCall(ref gaxgrpc::ApiCall<ResizeDiskRequest, Operation> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<SetIamPolicyDiskRequest, Policy> call);

        partial void Modify_SetLabelsApiCall(ref gaxgrpc::ApiCall<SetLabelsDiskRequest, Operation> call);

        partial void Modify_StartAsyncReplicationApiCall(ref gaxgrpc::ApiCall<StartAsyncReplicationDiskRequest, Operation> call);

        partial void Modify_StopAsyncReplicationApiCall(ref gaxgrpc::ApiCall<StopAsyncReplicationDiskRequest, Operation> call);

        partial void Modify_StopGroupAsyncReplicationApiCall(ref gaxgrpc::ApiCall<StopGroupAsyncReplicationDiskRequest, Operation> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<TestIamPermissionsDiskRequest, TestPermissionsResponse> call);

        partial void Modify_UpdateApiCall(ref gaxgrpc::ApiCall<UpdateDiskRequest, Operation> call);

        partial void OnConstruction(Disks.DisksClient grpcClient, DisksSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Disks client</summary>
        public override Disks.DisksClient GrpcClient { get; }

        partial void Modify_AddResourcePoliciesDiskRequest(ref AddResourcePoliciesDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AggregatedListDisksRequest(ref AggregatedListDisksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BulkInsertDiskRequest(ref BulkInsertDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BulkSetLabelsDiskRequest(ref BulkSetLabelsDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSnapshotDiskRequest(ref CreateSnapshotDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDiskRequest(ref DeleteDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDiskRequest(ref GetDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyDiskRequest(ref GetIamPolicyDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertDiskRequest(ref InsertDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDisksRequest(ref ListDisksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveResourcePoliciesDiskRequest(ref RemoveResourcePoliciesDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResizeDiskRequest(ref ResizeDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyDiskRequest(ref SetIamPolicyDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetLabelsDiskRequest(ref SetLabelsDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartAsyncReplicationDiskRequest(ref StartAsyncReplicationDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopAsyncReplicationDiskRequest(ref StopAsyncReplicationDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopGroupAsyncReplicationDiskRequest(ref StopGroupAsyncReplicationDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsDiskRequest(ref TestIamPermissionsDiskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDiskRequest(ref UpdateDiskRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>AddResourcePolicies</c>.</summary>
        public override lro::OperationsClient AddResourcePoliciesOperationsClient { get; }

        /// <summary>
        /// Adds existing resource policies to a disk. You can only add one policy which will be applied to this disk for scheduling snapshot creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> AddResourcePolicies(AddResourcePoliciesDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddResourcePoliciesDiskRequest(ref request, ref callSettings);
            Operation response = _callAddResourcePolicies.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddResourcePoliciesOperationsClient);
        }

        /// <summary>
        /// Adds existing resource policies to a disk. You can only add one policy which will be applied to this disk for scheduling snapshot creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> AddResourcePoliciesAsync(AddResourcePoliciesDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddResourcePoliciesDiskRequest(ref request, ref callSettings);
            Operation response = await _callAddResourcePolicies.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddResourcePoliciesOperationsClient);
        }

        /// <summary>
        /// Retrieves an aggregated list of persistent disks. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public override gax::PagedEnumerable<DiskAggregatedList, scg::KeyValuePair<string, DisksScopedList>> AggregatedList(AggregatedListDisksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListDisksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<AggregatedListDisksRequest, DiskAggregatedList, scg::KeyValuePair<string, DisksScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Retrieves an aggregated list of persistent disks. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<DiskAggregatedList, scg::KeyValuePair<string, DisksScopedList>> AggregatedListAsync(AggregatedListDisksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListDisksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<AggregatedListDisksRequest, DiskAggregatedList, scg::KeyValuePair<string, DisksScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BulkInsert</c>.</summary>
        public override lro::OperationsClient BulkInsertOperationsClient { get; }

        /// <summary>
        /// Bulk create a set of disks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> BulkInsert(BulkInsertDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkInsertDiskRequest(ref request, ref callSettings);
            Operation response = _callBulkInsert.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), BulkInsertOperationsClient);
        }

        /// <summary>
        /// Bulk create a set of disks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> BulkInsertAsync(BulkInsertDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkInsertDiskRequest(ref request, ref callSettings);
            Operation response = await _callBulkInsert.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), BulkInsertOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BulkSetLabels</c>.</summary>
        public override lro::OperationsClient BulkSetLabelsOperationsClient { get; }

        /// <summary>
        /// Sets the labels on many disks at once. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> BulkSetLabels(BulkSetLabelsDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkSetLabelsDiskRequest(ref request, ref callSettings);
            Operation response = _callBulkSetLabels.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), BulkSetLabelsOperationsClient);
        }

        /// <summary>
        /// Sets the labels on many disks at once. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> BulkSetLabelsAsync(BulkSetLabelsDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkSetLabelsDiskRequest(ref request, ref callSettings);
            Operation response = await _callBulkSetLabels.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), BulkSetLabelsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateSnapshot</c>.</summary>
        public override lro::OperationsClient CreateSnapshotOperationsClient { get; }

        /// <summary>
        /// Creates a snapshot of a specified persistent disk. For regular snapshot creation, consider using snapshots.insert instead, as that method supports more features, such as creating snapshots in a project different from the source disk project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> CreateSnapshot(CreateSnapshotDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSnapshotDiskRequest(ref request, ref callSettings);
            Operation response = _callCreateSnapshot.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), CreateSnapshotOperationsClient);
        }

        /// <summary>
        /// Creates a snapshot of a specified persistent disk. For regular snapshot creation, consider using snapshots.insert instead, as that method supports more features, such as creating snapshots in a project different from the source disk project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> CreateSnapshotAsync(CreateSnapshotDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSnapshotDiskRequest(ref request, ref callSettings);
            Operation response = await _callCreateSnapshot.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), CreateSnapshotOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Deletes the specified persistent disk. Deleting a disk removes its data permanently and is irreversible. However, deleting a disk does not delete any snapshots previously made from the disk. You must separately delete snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeleteDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDiskRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Deletes the specified persistent disk. Deleting a disk removes its data permanently and is irreversible. However, deleting a disk does not delete any snapshots previously made from the disk. You must separately delete snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDiskRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Returns the specified persistent disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Disk Get(GetDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDiskRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified persistent disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Disk> GetAsync(GetDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDiskRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy GetIamPolicy(GetIamPolicyDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyDiskRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyDiskRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Creates a persistent disk in the specified project using the data in the request. You can create a disk from a source (sourceImage, sourceSnapshot, or sourceDisk) or create an empty 500 GB data disk by omitting all properties. You can also create a disk that is larger than the default size by specifying the sizeGb property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertDiskRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Creates a persistent disk in the specified project using the data in the request. You can create a disk from a source (sourceImage, sourceSnapshot, or sourceDisk) or create an empty 500 GB data disk by omitting all properties. You can also create a disk that is larger than the default size by specifying the sizeGb property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertDiskRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Retrieves a list of persistent disks contained within the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Disk"/> resources.</returns>
        public override gax::PagedEnumerable<DiskList, Disk> List(ListDisksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDisksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDisksRequest, DiskList, Disk>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of persistent disks contained within the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Disk"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<DiskList, Disk> ListAsync(ListDisksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDisksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDisksRequest, DiskList, Disk>(_callList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RemoveResourcePolicies</c>.</summary>
        public override lro::OperationsClient RemoveResourcePoliciesOperationsClient { get; }

        /// <summary>
        /// Removes resource policies from a disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> RemoveResourcePolicies(RemoveResourcePoliciesDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveResourcePoliciesDiskRequest(ref request, ref callSettings);
            Operation response = _callRemoveResourcePolicies.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveResourcePoliciesOperationsClient);
        }

        /// <summary>
        /// Removes resource policies from a disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> RemoveResourcePoliciesAsync(RemoveResourcePoliciesDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveResourcePoliciesDiskRequest(ref request, ref callSettings);
            Operation response = await _callRemoveResourcePolicies.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveResourcePoliciesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Resize</c>.</summary>
        public override lro::OperationsClient ResizeOperationsClient { get; }

        /// <summary>
        /// Resizes the specified persistent disk. You can only increase the size of the disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Resize(ResizeDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResizeDiskRequest(ref request, ref callSettings);
            Operation response = _callResize.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), ResizeOperationsClient);
        }

        /// <summary>
        /// Resizes the specified persistent disk. You can only increase the size of the disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> ResizeAsync(ResizeDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResizeDiskRequest(ref request, ref callSettings);
            Operation response = await _callResize.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), ResizeOperationsClient);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy SetIamPolicy(SetIamPolicyDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyDiskRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyDiskRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>SetLabels</c>.</summary>
        public override lro::OperationsClient SetLabelsOperationsClient { get; }

        /// <summary>
        /// Sets the labels on a disk. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetLabels(SetLabelsDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetLabelsDiskRequest(ref request, ref callSettings);
            Operation response = _callSetLabels.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetLabelsOperationsClient);
        }

        /// <summary>
        /// Sets the labels on a disk. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(SetLabelsDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetLabelsDiskRequest(ref request, ref callSettings);
            Operation response = await _callSetLabels.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
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
        public override lro::Operation<Operation, Operation> StartAsyncReplication(StartAsyncReplicationDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartAsyncReplicationDiskRequest(ref request, ref callSettings);
            Operation response = _callStartAsyncReplication.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), StartAsyncReplicationOperationsClient);
        }

        /// <summary>
        /// Starts asynchronous replication. Must be invoked on the primary disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> StartAsyncReplicationAsync(StartAsyncReplicationDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartAsyncReplicationDiskRequest(ref request, ref callSettings);
            Operation response = await _callStartAsyncReplication.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
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
        public override lro::Operation<Operation, Operation> StopAsyncReplication(StopAsyncReplicationDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopAsyncReplicationDiskRequest(ref request, ref callSettings);
            Operation response = _callStopAsyncReplication.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), StopAsyncReplicationOperationsClient);
        }

        /// <summary>
        /// Stops asynchronous replication. Can be invoked either on the primary or on the secondary disk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> StopAsyncReplicationAsync(StopAsyncReplicationDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopAsyncReplicationDiskRequest(ref request, ref callSettings);
            Operation response = await _callStopAsyncReplication.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
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
        public override lro::Operation<Operation, Operation> StopGroupAsyncReplication(StopGroupAsyncReplicationDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopGroupAsyncReplicationDiskRequest(ref request, ref callSettings);
            Operation response = _callStopGroupAsyncReplication.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), StopGroupAsyncReplicationOperationsClient);
        }

        /// <summary>
        /// Stops asynchronous replication for a consistency group of disks. Can be invoked either in the primary or secondary scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> StopGroupAsyncReplicationAsync(StopGroupAsyncReplicationDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopGroupAsyncReplicationDiskRequest(ref request, ref callSettings);
            Operation response = await _callStopGroupAsyncReplication.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), StopGroupAsyncReplicationOperationsClient);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TestPermissionsResponse TestIamPermissions(TestIamPermissionsDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsDiskRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsDiskRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Update</c>.</summary>
        public override lro::OperationsClient UpdateOperationsClient { get; }

        /// <summary>
        /// Updates the specified disk with the data included in the request. The update is performed only on selected fields included as part of update-mask. Only the following fields can be modified: user_license.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Update(UpdateDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDiskRequest(ref request, ref callSettings);
            Operation response = _callUpdate.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateOperationsClient);
        }

        /// <summary>
        /// Updates the specified disk with the data included in the request. The update is performed only on selected fields included as part of update-mask. Only the following fields can be modified: user_license.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateDiskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDiskRequest(ref request, ref callSettings);
            Operation response = await _callUpdate.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateOperationsClient);
        }
    }

    public partial class AggregatedListDisksRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ListDisksRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class DiskAggregatedList : gaxgrpc::IPageResponse<scg::KeyValuePair<string, DisksScopedList>>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<scg::KeyValuePair<string, DisksScopedList>> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class DiskList : gaxgrpc::IPageResponse<Disk>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Disk> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Disks
    {
        public partial class DisksClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client, delegating to ZoneOperations.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForZoneOperations() =>
                ZoneOperations.ZoneOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }
}
