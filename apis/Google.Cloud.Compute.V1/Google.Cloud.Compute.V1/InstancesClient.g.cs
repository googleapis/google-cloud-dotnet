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
    /// <summary>Settings for <see cref="InstancesClient"/> instances.</summary>
    public sealed partial class InstancesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="InstancesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="InstancesSettings"/>.</returns>
        public static InstancesSettings GetDefault() => new InstancesSettings();

        /// <summary>Constructs a new <see cref="InstancesSettings"/> object with default settings.</summary>
        public InstancesSettings()
        {
        }

        private InstancesSettings(InstancesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AddAccessConfigSettings = existing.AddAccessConfigSettings;
            AddAccessConfigOperationsSettings = existing.AddAccessConfigOperationsSettings.Clone();
            AddResourcePoliciesSettings = existing.AddResourcePoliciesSettings;
            AddResourcePoliciesOperationsSettings = existing.AddResourcePoliciesOperationsSettings.Clone();
            AggregatedListSettings = existing.AggregatedListSettings;
            AttachDiskSettings = existing.AttachDiskSettings;
            AttachDiskOperationsSettings = existing.AttachDiskOperationsSettings.Clone();
            BulkInsertSettings = existing.BulkInsertSettings;
            BulkInsertOperationsSettings = existing.BulkInsertOperationsSettings.Clone();
            DeleteSettings = existing.DeleteSettings;
            DeleteOperationsSettings = existing.DeleteOperationsSettings.Clone();
            DeleteAccessConfigSettings = existing.DeleteAccessConfigSettings;
            DeleteAccessConfigOperationsSettings = existing.DeleteAccessConfigOperationsSettings.Clone();
            DetachDiskSettings = existing.DetachDiskSettings;
            DetachDiskOperationsSettings = existing.DetachDiskOperationsSettings.Clone();
            GetSettings = existing.GetSettings;
            GetEffectiveFirewallsSettings = existing.GetEffectiveFirewallsSettings;
            GetGuestAttributesSettings = existing.GetGuestAttributesSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            GetScreenshotSettings = existing.GetScreenshotSettings;
            GetSerialPortOutputSettings = existing.GetSerialPortOutputSettings;
            GetShieldedInstanceIdentitySettings = existing.GetShieldedInstanceIdentitySettings;
            InsertSettings = existing.InsertSettings;
            InsertOperationsSettings = existing.InsertOperationsSettings.Clone();
            ListSettings = existing.ListSettings;
            ListReferrersSettings = existing.ListReferrersSettings;
            PerformMaintenanceSettings = existing.PerformMaintenanceSettings;
            PerformMaintenanceOperationsSettings = existing.PerformMaintenanceOperationsSettings.Clone();
            RemoveResourcePoliciesSettings = existing.RemoveResourcePoliciesSettings;
            RemoveResourcePoliciesOperationsSettings = existing.RemoveResourcePoliciesOperationsSettings.Clone();
            ReportHostAsFaultySettings = existing.ReportHostAsFaultySettings;
            ReportHostAsFaultyOperationsSettings = existing.ReportHostAsFaultyOperationsSettings.Clone();
            ResetSettings = existing.ResetSettings;
            ResetOperationsSettings = existing.ResetOperationsSettings.Clone();
            ResumeSettings = existing.ResumeSettings;
            ResumeOperationsSettings = existing.ResumeOperationsSettings.Clone();
            SendDiagnosticInterruptSettings = existing.SendDiagnosticInterruptSettings;
            SetDeletionProtectionSettings = existing.SetDeletionProtectionSettings;
            SetDeletionProtectionOperationsSettings = existing.SetDeletionProtectionOperationsSettings.Clone();
            SetDiskAutoDeleteSettings = existing.SetDiskAutoDeleteSettings;
            SetDiskAutoDeleteOperationsSettings = existing.SetDiskAutoDeleteOperationsSettings.Clone();
            SetIamPolicySettings = existing.SetIamPolicySettings;
            SetLabelsSettings = existing.SetLabelsSettings;
            SetLabelsOperationsSettings = existing.SetLabelsOperationsSettings.Clone();
            SetMachineResourcesSettings = existing.SetMachineResourcesSettings;
            SetMachineResourcesOperationsSettings = existing.SetMachineResourcesOperationsSettings.Clone();
            SetMachineTypeSettings = existing.SetMachineTypeSettings;
            SetMachineTypeOperationsSettings = existing.SetMachineTypeOperationsSettings.Clone();
            SetMetadataSettings = existing.SetMetadataSettings;
            SetMetadataOperationsSettings = existing.SetMetadataOperationsSettings.Clone();
            SetMinCpuPlatformSettings = existing.SetMinCpuPlatformSettings;
            SetMinCpuPlatformOperationsSettings = existing.SetMinCpuPlatformOperationsSettings.Clone();
            SetNameSettings = existing.SetNameSettings;
            SetNameOperationsSettings = existing.SetNameOperationsSettings.Clone();
            SetSchedulingSettings = existing.SetSchedulingSettings;
            SetSchedulingOperationsSettings = existing.SetSchedulingOperationsSettings.Clone();
            SetSecurityPolicySettings = existing.SetSecurityPolicySettings;
            SetSecurityPolicyOperationsSettings = existing.SetSecurityPolicyOperationsSettings.Clone();
            SetServiceAccountSettings = existing.SetServiceAccountSettings;
            SetServiceAccountOperationsSettings = existing.SetServiceAccountOperationsSettings.Clone();
            SetShieldedInstanceIntegrityPolicySettings = existing.SetShieldedInstanceIntegrityPolicySettings;
            SetShieldedInstanceIntegrityPolicyOperationsSettings = existing.SetShieldedInstanceIntegrityPolicyOperationsSettings.Clone();
            SetTagsSettings = existing.SetTagsSettings;
            SetTagsOperationsSettings = existing.SetTagsOperationsSettings.Clone();
            SimulateMaintenanceEventSettings = existing.SimulateMaintenanceEventSettings;
            SimulateMaintenanceEventOperationsSettings = existing.SimulateMaintenanceEventOperationsSettings.Clone();
            StartSettings = existing.StartSettings;
            StartOperationsSettings = existing.StartOperationsSettings.Clone();
            StartWithEncryptionKeySettings = existing.StartWithEncryptionKeySettings;
            StartWithEncryptionKeyOperationsSettings = existing.StartWithEncryptionKeyOperationsSettings.Clone();
            StopSettings = existing.StopSettings;
            StopOperationsSettings = existing.StopOperationsSettings.Clone();
            SuspendSettings = existing.SuspendSettings;
            SuspendOperationsSettings = existing.SuspendOperationsSettings.Clone();
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            UpdateSettings = existing.UpdateSettings;
            UpdateOperationsSettings = existing.UpdateOperationsSettings.Clone();
            UpdateAccessConfigSettings = existing.UpdateAccessConfigSettings;
            UpdateAccessConfigOperationsSettings = existing.UpdateAccessConfigOperationsSettings.Clone();
            UpdateDisplayDeviceSettings = existing.UpdateDisplayDeviceSettings;
            UpdateDisplayDeviceOperationsSettings = existing.UpdateDisplayDeviceOperationsSettings.Clone();
            UpdateNetworkInterfaceSettings = existing.UpdateNetworkInterfaceSettings;
            UpdateNetworkInterfaceOperationsSettings = existing.UpdateNetworkInterfaceOperationsSettings.Clone();
            UpdateShieldedInstanceConfigSettings = existing.UpdateShieldedInstanceConfigSettings;
            UpdateShieldedInstanceConfigOperationsSettings = existing.UpdateShieldedInstanceConfigOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(InstancesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.AddAccessConfig</c> and <c>InstancesClient.AddAccessConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddAccessConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.AddAccessConfig</c> and
        /// <c>InstancesClient.AddAccessConfigAsync</c>.
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
        public lro::OperationsSettings AddAccessConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.AddResourcePolicies</c> and <c>InstancesClient.AddResourcePoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddResourcePoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.AddResourcePolicies</c> and
        /// <c>InstancesClient.AddResourcePoliciesAsync</c>.
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
        /// <c>InstancesClient.AggregatedList</c> and <c>InstancesClient.AggregatedListAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.AttachDisk</c>
        ///  and <c>InstancesClient.AttachDiskAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AttachDiskSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.AttachDisk</c> and
        /// <c>InstancesClient.AttachDiskAsync</c>.
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
        public lro::OperationsSettings AttachDiskOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.BulkInsert</c>
        ///  and <c>InstancesClient.BulkInsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BulkInsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.BulkInsert</c> and
        /// <c>InstancesClient.BulkInsertAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.Delete</c>
        /// and <c>InstancesClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.Delete</c> and
        /// <c>InstancesClient.DeleteAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.DeleteAccessConfig</c> and <c>InstancesClient.DeleteAccessConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAccessConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.DeleteAccessConfig</c> and
        /// <c>InstancesClient.DeleteAccessConfigAsync</c>.
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
        public lro::OperationsSettings DeleteAccessConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.DetachDisk</c>
        ///  and <c>InstancesClient.DetachDiskAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DetachDiskSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.DetachDisk</c> and
        /// <c>InstancesClient.DetachDiskAsync</c>.
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
        public lro::OperationsSettings DetachDiskOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.Get</c> and
        /// <c>InstancesClient.GetAsync</c>.
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
        /// <c>InstancesClient.GetEffectiveFirewalls</c> and <c>InstancesClient.GetEffectiveFirewallsAsync</c>.
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
        public gaxgrpc::CallSettings GetEffectiveFirewallsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.GetGuestAttributes</c> and <c>InstancesClient.GetGuestAttributesAsync</c>.
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
        public gaxgrpc::CallSettings GetGuestAttributesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.GetIamPolicy</c> and <c>InstancesClient.GetIamPolicyAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.GetScreenshot</c> and <c>InstancesClient.GetScreenshotAsync</c>.
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
        public gaxgrpc::CallSettings GetScreenshotSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.GetSerialPortOutput</c> and <c>InstancesClient.GetSerialPortOutputAsync</c>.
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
        public gaxgrpc::CallSettings GetSerialPortOutputSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.GetShieldedInstanceIdentity</c> and <c>InstancesClient.GetShieldedInstanceIdentityAsync</c>
        /// .
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
        public gaxgrpc::CallSettings GetShieldedInstanceIdentitySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.Insert</c>
        /// and <c>InstancesClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.Insert</c> and
        /// <c>InstancesClient.InsertAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.List</c>
        /// and <c>InstancesClient.ListAsync</c>.
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
        /// <c>InstancesClient.ListReferrers</c> and <c>InstancesClient.ListReferrersAsync</c>.
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
        public gaxgrpc::CallSettings ListReferrersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.PerformMaintenance</c> and <c>InstancesClient.PerformMaintenanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PerformMaintenanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.PerformMaintenance</c> and
        /// <c>InstancesClient.PerformMaintenanceAsync</c>.
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
        public lro::OperationsSettings PerformMaintenanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.RemoveResourcePolicies</c> and <c>InstancesClient.RemoveResourcePoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveResourcePoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.RemoveResourcePolicies</c> and
        /// <c>InstancesClient.RemoveResourcePoliciesAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.ReportHostAsFaulty</c> and <c>InstancesClient.ReportHostAsFaultyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReportHostAsFaultySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.ReportHostAsFaulty</c> and
        /// <c>InstancesClient.ReportHostAsFaultyAsync</c>.
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
        public lro::OperationsSettings ReportHostAsFaultyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.Reset</c>
        /// and <c>InstancesClient.ResetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.Reset</c> and <c>InstancesClient.ResetAsync</c>
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
        public lro::OperationsSettings ResetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.Resume</c>
        /// and <c>InstancesClient.ResumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResumeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.Resume</c> and
        /// <c>InstancesClient.ResumeAsync</c>.
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
        public lro::OperationsSettings ResumeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SendDiagnosticInterrupt</c> and <c>InstancesClient.SendDiagnosticInterruptAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SendDiagnosticInterruptSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SetDeletionProtection</c> and <c>InstancesClient.SetDeletionProtectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetDeletionProtectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.SetDeletionProtection</c> and
        /// <c>InstancesClient.SetDeletionProtectionAsync</c>.
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
        public lro::OperationsSettings SetDeletionProtectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SetDiskAutoDelete</c> and <c>InstancesClient.SetDiskAutoDeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetDiskAutoDeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.SetDiskAutoDelete</c> and
        /// <c>InstancesClient.SetDiskAutoDeleteAsync</c>.
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
        public lro::OperationsSettings SetDiskAutoDeleteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SetIamPolicy</c> and <c>InstancesClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.SetLabels</c>
        ///  and <c>InstancesClient.SetLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.SetLabels</c> and
        /// <c>InstancesClient.SetLabelsAsync</c>.
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
        /// <c>InstancesClient.SetMachineResources</c> and <c>InstancesClient.SetMachineResourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetMachineResourcesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.SetMachineResources</c> and
        /// <c>InstancesClient.SetMachineResourcesAsync</c>.
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
        public lro::OperationsSettings SetMachineResourcesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SetMachineType</c> and <c>InstancesClient.SetMachineTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetMachineTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.SetMachineType</c> and
        /// <c>InstancesClient.SetMachineTypeAsync</c>.
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
        public lro::OperationsSettings SetMachineTypeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.SetMetadata</c>
        ///  and <c>InstancesClient.SetMetadataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetMetadataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.SetMetadata</c> and
        /// <c>InstancesClient.SetMetadataAsync</c>.
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
        public lro::OperationsSettings SetMetadataOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SetMinCpuPlatform</c> and <c>InstancesClient.SetMinCpuPlatformAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetMinCpuPlatformSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.SetMinCpuPlatform</c> and
        /// <c>InstancesClient.SetMinCpuPlatformAsync</c>.
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
        public lro::OperationsSettings SetMinCpuPlatformOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.SetName</c>
        /// and <c>InstancesClient.SetNameAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetNameSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.SetName</c> and
        /// <c>InstancesClient.SetNameAsync</c>.
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
        public lro::OperationsSettings SetNameOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SetScheduling</c> and <c>InstancesClient.SetSchedulingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetSchedulingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.SetScheduling</c> and
        /// <c>InstancesClient.SetSchedulingAsync</c>.
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
        public lro::OperationsSettings SetSchedulingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SetSecurityPolicy</c> and <c>InstancesClient.SetSecurityPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetSecurityPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.SetSecurityPolicy</c> and
        /// <c>InstancesClient.SetSecurityPolicyAsync</c>.
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
        public lro::OperationsSettings SetSecurityPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SetServiceAccount</c> and <c>InstancesClient.SetServiceAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetServiceAccountSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.SetServiceAccount</c> and
        /// <c>InstancesClient.SetServiceAccountAsync</c>.
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
        public lro::OperationsSettings SetServiceAccountOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SetShieldedInstanceIntegrityPolicy</c> and
        /// <c>InstancesClient.SetShieldedInstanceIntegrityPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetShieldedInstanceIntegrityPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.SetShieldedInstanceIntegrityPolicy</c> and
        /// <c>InstancesClient.SetShieldedInstanceIntegrityPolicyAsync</c>.
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
        public lro::OperationsSettings SetShieldedInstanceIntegrityPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.SetTags</c>
        /// and <c>InstancesClient.SetTagsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetTagsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.SetTags</c> and
        /// <c>InstancesClient.SetTagsAsync</c>.
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
        public lro::OperationsSettings SetTagsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SimulateMaintenanceEvent</c> and <c>InstancesClient.SimulateMaintenanceEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SimulateMaintenanceEventSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.SimulateMaintenanceEvent</c> and
        /// <c>InstancesClient.SimulateMaintenanceEventAsync</c>.
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
        public lro::OperationsSettings SimulateMaintenanceEventOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.Start</c>
        /// and <c>InstancesClient.StartAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.Start</c> and <c>InstancesClient.StartAsync</c>
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
        public lro::OperationsSettings StartOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.StartWithEncryptionKey</c> and <c>InstancesClient.StartWithEncryptionKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartWithEncryptionKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.StartWithEncryptionKey</c> and
        /// <c>InstancesClient.StartWithEncryptionKeyAsync</c>.
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
        public lro::OperationsSettings StartWithEncryptionKeyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.Stop</c>
        /// and <c>InstancesClient.StopAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.Stop</c> and <c>InstancesClient.StopAsync</c>
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
        public lro::OperationsSettings StopOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.Suspend</c>
        /// and <c>InstancesClient.SuspendAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SuspendSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.Suspend</c> and
        /// <c>InstancesClient.SuspendAsync</c>.
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
        public lro::OperationsSettings SuspendOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.TestIamPermissions</c> and <c>InstancesClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.Update</c>
        /// and <c>InstancesClient.UpdateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.Update</c> and
        /// <c>InstancesClient.UpdateAsync</c>.
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

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.UpdateAccessConfig</c> and <c>InstancesClient.UpdateAccessConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAccessConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.UpdateAccessConfig</c> and
        /// <c>InstancesClient.UpdateAccessConfigAsync</c>.
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
        public lro::OperationsSettings UpdateAccessConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.UpdateDisplayDevice</c> and <c>InstancesClient.UpdateDisplayDeviceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDisplayDeviceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.UpdateDisplayDevice</c> and
        /// <c>InstancesClient.UpdateDisplayDeviceAsync</c>.
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
        public lro::OperationsSettings UpdateDisplayDeviceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.UpdateNetworkInterface</c> and <c>InstancesClient.UpdateNetworkInterfaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateNetworkInterfaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.UpdateNetworkInterface</c> and
        /// <c>InstancesClient.UpdateNetworkInterfaceAsync</c>.
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
        public lro::OperationsSettings UpdateNetworkInterfaceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.UpdateShieldedInstanceConfig</c> and <c>InstancesClient.UpdateShieldedInstanceConfigAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateShieldedInstanceConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstancesClient.UpdateShieldedInstanceConfig</c> and
        /// <c>InstancesClient.UpdateShieldedInstanceConfigAsync</c>.
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
        public lro::OperationsSettings UpdateShieldedInstanceConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="InstancesSettings"/> object.</returns>
        public InstancesSettings Clone() => new InstancesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="InstancesClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class InstancesClientBuilder : gaxgrpc::ClientBuilderBase<InstancesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public InstancesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public InstancesClientBuilder() : base(InstancesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref InstancesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<InstancesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override InstancesClient Build()
        {
            InstancesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<InstancesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<InstancesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private InstancesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return InstancesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<InstancesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return InstancesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => InstancesClient.ChannelPool;
    }

    /// <summary>Instances client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Instances API.
    /// </remarks>
    public abstract partial class InstancesClient
    {
        /// <summary>
        /// The default endpoint for the Instances service, which is a host of "compute.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default Instances scopes.</summary>
        /// <remarks>
        /// The default Instances scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Instances.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="InstancesClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="InstancesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="InstancesClient"/>.</returns>
        public static stt::Task<InstancesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new InstancesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="InstancesClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="InstancesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="InstancesClient"/>.</returns>
        public static InstancesClient Create() => new InstancesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="InstancesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="InstancesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="InstancesClient"/>.</returns>
        internal static InstancesClient Create(grpccore::CallInvoker callInvoker, InstancesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Instances.InstancesClient grpcClient = new Instances.InstancesClient(callInvoker);
            return new InstancesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Instances client</summary>
        public virtual Instances.InstancesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Adds an access config to an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddAccessConfig(AddAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds an access config to an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddAccessConfigAsync(AddAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds an access config to an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddAccessConfigAsync(AddAccessConfigInstanceRequest request, st::CancellationToken cancellationToken) =>
            AddAccessConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AddAccessConfig</c>.</summary>
        public virtual lro::OperationsClient AddAccessConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AddAccessConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceAddAccessConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddAccessConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AddAccessConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceAddAccessConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddAccessConfigOperationsClient, callSettings);

        /// <summary>
        /// Adds an access config to an instance's network interface.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="networkInterface">
        /// The name of the network interface to add to this instance.
        /// </param>
        /// <param name="accessConfigResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddAccessConfig(string project, string zone, string instance, string networkInterface, AccessConfig accessConfigResource, gaxgrpc::CallSettings callSettings = null) =>
            AddAccessConfig(new AddAccessConfigInstanceRequest
            {
                AccessConfigResource = gax::GaxPreconditions.CheckNotNull(accessConfigResource, nameof(accessConfigResource)),
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                NetworkInterface = gax::GaxPreconditions.CheckNotNullOrEmpty(networkInterface, nameof(networkInterface)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Adds an access config to an instance's network interface.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="networkInterface">
        /// The name of the network interface to add to this instance.
        /// </param>
        /// <param name="accessConfigResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddAccessConfigAsync(string project, string zone, string instance, string networkInterface, AccessConfig accessConfigResource, gaxgrpc::CallSettings callSettings = null) =>
            AddAccessConfigAsync(new AddAccessConfigInstanceRequest
            {
                AccessConfigResource = gax::GaxPreconditions.CheckNotNull(accessConfigResource, nameof(accessConfigResource)),
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                NetworkInterface = gax::GaxPreconditions.CheckNotNullOrEmpty(networkInterface, nameof(networkInterface)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Adds an access config to an instance's network interface.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="networkInterface">
        /// The name of the network interface to add to this instance.
        /// </param>
        /// <param name="accessConfigResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddAccessConfigAsync(string project, string zone, string instance, string networkInterface, AccessConfig accessConfigResource, st::CancellationToken cancellationToken) =>
            AddAccessConfigAsync(project, zone, instance, networkInterface, accessConfigResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds existing resource policies to an instance. You can only add one policy right now which will be applied to this instance for scheduling live migrations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddResourcePolicies(AddResourcePoliciesInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds existing resource policies to an instance. You can only add one policy right now which will be applied to this instance for scheduling live migrations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddResourcePoliciesAsync(AddResourcePoliciesInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds existing resource policies to an instance. You can only add one policy right now which will be applied to this instance for scheduling live migrations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddResourcePoliciesAsync(AddResourcePoliciesInstanceRequest request, st::CancellationToken cancellationToken) =>
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
        /// Adds existing resource policies to an instance. You can only add one policy right now which will be applied to this instance for scheduling live migrations.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="instancesAddResourcePoliciesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddResourcePolicies(string project, string zone, string instance, InstancesAddResourcePoliciesRequest instancesAddResourcePoliciesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            AddResourcePolicies(new AddResourcePoliciesInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesAddResourcePoliciesRequestResource = gax::GaxPreconditions.CheckNotNull(instancesAddResourcePoliciesRequestResource, nameof(instancesAddResourcePoliciesRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Adds existing resource policies to an instance. You can only add one policy right now which will be applied to this instance for scheduling live migrations.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="instancesAddResourcePoliciesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddResourcePoliciesAsync(string project, string zone, string instance, InstancesAddResourcePoliciesRequest instancesAddResourcePoliciesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            AddResourcePoliciesAsync(new AddResourcePoliciesInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesAddResourcePoliciesRequestResource = gax::GaxPreconditions.CheckNotNull(instancesAddResourcePoliciesRequestResource, nameof(instancesAddResourcePoliciesRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Adds existing resource policies to an instance. You can only add one policy right now which will be applied to this instance for scheduling live migrations.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="instancesAddResourcePoliciesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddResourcePoliciesAsync(string project, string zone, string instance, InstancesAddResourcePoliciesRequest instancesAddResourcePoliciesRequestResource, st::CancellationToken cancellationToken) =>
            AddResourcePoliciesAsync(project, zone, instance, instancesAddResourcePoliciesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an aggregated list of all of the instances in your project across all regions and zones. The performance of this method degrades when a filter is specified on a project that has a very large number of instances. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<InstanceAggregatedList, scg::KeyValuePair<string, InstancesScopedList>> AggregatedList(AggregatedListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of all of the instances in your project across all regions and zones. The performance of this method degrades when a filter is specified on a project that has a very large number of instances. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<InstanceAggregatedList, scg::KeyValuePair<string, InstancesScopedList>> AggregatedListAsync(AggregatedListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of all of the instances in your project across all regions and zones. The performance of this method degrades when a filter is specified on a project that has a very large number of instances. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
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
        public virtual gax::PagedEnumerable<InstanceAggregatedList, scg::KeyValuePair<string, InstancesScopedList>> AggregatedList(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListInstancesRequest request = new AggregatedListInstancesRequest
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
        /// Retrieves an aggregated list of all of the instances in your project across all regions and zones. The performance of this method degrades when a filter is specified on a project that has a very large number of instances. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
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
        public virtual gax::PagedAsyncEnumerable<InstanceAggregatedList, scg::KeyValuePair<string, InstancesScopedList>> AggregatedListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListInstancesRequest request = new AggregatedListInstancesRequest
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
        /// Attaches an existing Disk resource to an instance. You must first create the disk before you can attach it. It is not possible to create and attach a disk at the same time. For more information, read Adding a persistent disk to your instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AttachDisk(AttachDiskInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Attaches an existing Disk resource to an instance. You must first create the disk before you can attach it. It is not possible to create and attach a disk at the same time. For more information, read Adding a persistent disk to your instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AttachDiskAsync(AttachDiskInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Attaches an existing Disk resource to an instance. You must first create the disk before you can attach it. It is not possible to create and attach a disk at the same time. For more information, read Adding a persistent disk to your instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AttachDiskAsync(AttachDiskInstanceRequest request, st::CancellationToken cancellationToken) =>
            AttachDiskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AttachDisk</c>.</summary>
        public virtual lro::OperationsClient AttachDiskOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AttachDisk</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceAttachDisk(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AttachDiskOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AttachDisk</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceAttachDiskAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AttachDiskOperationsClient, callSettings);

        /// <summary>
        /// Attaches an existing Disk resource to an instance. You must first create the disk before you can attach it. It is not possible to create and attach a disk at the same time. For more information, read Adding a persistent disk to your instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="attachedDiskResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AttachDisk(string project, string zone, string instance, AttachedDisk attachedDiskResource, gaxgrpc::CallSettings callSettings = null) =>
            AttachDisk(new AttachDiskInstanceRequest
            {
                AttachedDiskResource = gax::GaxPreconditions.CheckNotNull(attachedDiskResource, nameof(attachedDiskResource)),
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Attaches an existing Disk resource to an instance. You must first create the disk before you can attach it. It is not possible to create and attach a disk at the same time. For more information, read Adding a persistent disk to your instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="attachedDiskResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AttachDiskAsync(string project, string zone, string instance, AttachedDisk attachedDiskResource, gaxgrpc::CallSettings callSettings = null) =>
            AttachDiskAsync(new AttachDiskInstanceRequest
            {
                AttachedDiskResource = gax::GaxPreconditions.CheckNotNull(attachedDiskResource, nameof(attachedDiskResource)),
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Attaches an existing Disk resource to an instance. You must first create the disk before you can attach it. It is not possible to create and attach a disk at the same time. For more information, read Adding a persistent disk to your instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="attachedDiskResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AttachDiskAsync(string project, string zone, string instance, AttachedDisk attachedDiskResource, st::CancellationToken cancellationToken) =>
            AttachDiskAsync(project, zone, instance, attachedDiskResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates multiple instances. Count specifies the number of instances to create. For more information, see About bulk creation of VMs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> BulkInsert(BulkInsertInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates multiple instances. Count specifies the number of instances to create. For more information, see About bulk creation of VMs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> BulkInsertAsync(BulkInsertInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates multiple instances. Count specifies the number of instances to create. For more information, see About bulk creation of VMs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> BulkInsertAsync(BulkInsertInstanceRequest request, st::CancellationToken cancellationToken) =>
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
        /// Creates multiple instances. Count specifies the number of instances to create. For more information, see About bulk creation of VMs.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="bulkInsertInstanceResourceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> BulkInsert(string project, string zone, BulkInsertInstanceResource bulkInsertInstanceResourceResource, gaxgrpc::CallSettings callSettings = null) =>
            BulkInsert(new BulkInsertInstanceRequest
            {
                BulkInsertInstanceResourceResource = gax::GaxPreconditions.CheckNotNull(bulkInsertInstanceResourceResource, nameof(bulkInsertInstanceResourceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates multiple instances. Count specifies the number of instances to create. For more information, see About bulk creation of VMs.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="bulkInsertInstanceResourceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> BulkInsertAsync(string project, string zone, BulkInsertInstanceResource bulkInsertInstanceResourceResource, gaxgrpc::CallSettings callSettings = null) =>
            BulkInsertAsync(new BulkInsertInstanceRequest
            {
                BulkInsertInstanceResourceResource = gax::GaxPreconditions.CheckNotNull(bulkInsertInstanceResourceResource, nameof(bulkInsertInstanceResourceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates multiple instances. Count specifies the number of instances to create. For more information, see About bulk creation of VMs.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="bulkInsertInstanceResourceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> BulkInsertAsync(string project, string zone, BulkInsertInstanceResource bulkInsertInstanceResourceResource, st::CancellationToken cancellationToken) =>
            BulkInsertAsync(project, zone, bulkInsertInstanceResourceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified Instance resource. For more information, see Deleting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified Instance resource. For more information, see Deleting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified Instance resource. For more information, see Deleting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteInstanceRequest request, st::CancellationToken cancellationToken) =>
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
        /// Deletes the specified Instance resource. For more information, see Deleting an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified Instance resource. For more information, see Deleting an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified Instance resource. For more information, see Deleting an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an access config from an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> DeleteAccessConfig(DeleteAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an access config from an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAccessConfigAsync(DeleteAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an access config from an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAccessConfigAsync(DeleteAccessConfigInstanceRequest request, st::CancellationToken cancellationToken) =>
            DeleteAccessConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAccessConfig</c>.</summary>
        public virtual lro::OperationsClient DeleteAccessConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAccessConfig</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceDeleteAccessConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAccessConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAccessConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceDeleteAccessConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAccessConfigOperationsClient, callSettings);

        /// <summary>
        /// Deletes an access config from an instance's network interface.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="accessConfig">
        /// The name of the access config to delete.
        /// </param>
        /// <param name="networkInterface">
        /// The name of the network interface.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> DeleteAccessConfig(string project, string zone, string instance, string accessConfig, string networkInterface, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccessConfig(new DeleteAccessConfigInstanceRequest
            {
                AccessConfig = gax::GaxPreconditions.CheckNotNullOrEmpty(accessConfig, nameof(accessConfig)),
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                NetworkInterface = gax::GaxPreconditions.CheckNotNullOrEmpty(networkInterface, nameof(networkInterface)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Deletes an access config from an instance's network interface.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="accessConfig">
        /// The name of the access config to delete.
        /// </param>
        /// <param name="networkInterface">
        /// The name of the network interface.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAccessConfigAsync(string project, string zone, string instance, string accessConfig, string networkInterface, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccessConfigAsync(new DeleteAccessConfigInstanceRequest
            {
                AccessConfig = gax::GaxPreconditions.CheckNotNullOrEmpty(accessConfig, nameof(accessConfig)),
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                NetworkInterface = gax::GaxPreconditions.CheckNotNullOrEmpty(networkInterface, nameof(networkInterface)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Deletes an access config from an instance's network interface.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="accessConfig">
        /// The name of the access config to delete.
        /// </param>
        /// <param name="networkInterface">
        /// The name of the network interface.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAccessConfigAsync(string project, string zone, string instance, string accessConfig, string networkInterface, st::CancellationToken cancellationToken) =>
            DeleteAccessConfigAsync(project, zone, instance, accessConfig, networkInterface, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Detaches a disk from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> DetachDisk(DetachDiskInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Detaches a disk from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DetachDiskAsync(DetachDiskInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Detaches a disk from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DetachDiskAsync(DetachDiskInstanceRequest request, st::CancellationToken cancellationToken) =>
            DetachDiskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DetachDisk</c>.</summary>
        public virtual lro::OperationsClient DetachDiskOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DetachDisk</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceDetachDisk(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DetachDiskOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DetachDisk</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceDetachDiskAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DetachDiskOperationsClient, callSettings);

        /// <summary>
        /// Detaches a disk from an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Instance name for this request.
        /// </param>
        /// <param name="deviceName">
        /// The device name of the disk to detach. Make a get() request on the instance to view currently attached disks and device names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> DetachDisk(string project, string zone, string instance, string deviceName, gaxgrpc::CallSettings callSettings = null) =>
            DetachDisk(new DetachDiskInstanceRequest
            {
                DeviceName = gax::GaxPreconditions.CheckNotNullOrEmpty(deviceName, nameof(deviceName)),
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Detaches a disk from an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Instance name for this request.
        /// </param>
        /// <param name="deviceName">
        /// The device name of the disk to detach. Make a get() request on the instance to view currently attached disks and device names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DetachDiskAsync(string project, string zone, string instance, string deviceName, gaxgrpc::CallSettings callSettings = null) =>
            DetachDiskAsync(new DetachDiskInstanceRequest
            {
                DeviceName = gax::GaxPreconditions.CheckNotNullOrEmpty(deviceName, nameof(deviceName)),
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Detaches a disk from an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Instance name for this request.
        /// </param>
        /// <param name="deviceName">
        /// The device name of the disk to detach. Make a get() request on the instance to view currently attached disks and device names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DetachDiskAsync(string project, string zone, string instance, string deviceName, st::CancellationToken cancellationToken) =>
            DetachDiskAsync(project, zone, instance, deviceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified Instance resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance Get(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified Instance resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified Instance resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetAsync(GetInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified Instance resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance Get(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the specified Instance resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the specified Instance resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            GetAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns effective firewalls applied to an interface of the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstancesGetEffectiveFirewallsResponse GetEffectiveFirewalls(GetEffectiveFirewallsInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns effective firewalls applied to an interface of the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstancesGetEffectiveFirewallsResponse> GetEffectiveFirewallsAsync(GetEffectiveFirewallsInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns effective firewalls applied to an interface of the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstancesGetEffectiveFirewallsResponse> GetEffectiveFirewallsAsync(GetEffectiveFirewallsInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetEffectiveFirewallsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns effective firewalls applied to an interface of the instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="networkInterface">
        /// The name of the network interface to get the effective firewalls.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstancesGetEffectiveFirewallsResponse GetEffectiveFirewalls(string project, string zone, string instance, string networkInterface, gaxgrpc::CallSettings callSettings = null) =>
            GetEffectiveFirewalls(new GetEffectiveFirewallsInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                NetworkInterface = gax::GaxPreconditions.CheckNotNullOrEmpty(networkInterface, nameof(networkInterface)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns effective firewalls applied to an interface of the instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="networkInterface">
        /// The name of the network interface to get the effective firewalls.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstancesGetEffectiveFirewallsResponse> GetEffectiveFirewallsAsync(string project, string zone, string instance, string networkInterface, gaxgrpc::CallSettings callSettings = null) =>
            GetEffectiveFirewallsAsync(new GetEffectiveFirewallsInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                NetworkInterface = gax::GaxPreconditions.CheckNotNullOrEmpty(networkInterface, nameof(networkInterface)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns effective firewalls applied to an interface of the instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="networkInterface">
        /// The name of the network interface to get the effective firewalls.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstancesGetEffectiveFirewallsResponse> GetEffectiveFirewallsAsync(string project, string zone, string instance, string networkInterface, st::CancellationToken cancellationToken) =>
            GetEffectiveFirewallsAsync(project, zone, instance, networkInterface, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified guest attributes entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GuestAttributes GetGuestAttributes(GetGuestAttributesInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified guest attributes entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestAttributes> GetGuestAttributesAsync(GetGuestAttributesInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified guest attributes entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestAttributes> GetGuestAttributesAsync(GetGuestAttributesInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetGuestAttributesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified guest attributes entry.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GuestAttributes GetGuestAttributes(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            GetGuestAttributes(new GetGuestAttributesInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the specified guest attributes entry.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestAttributes> GetGuestAttributesAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            GetGuestAttributesAsync(new GetGuestAttributesInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the specified guest attributes entry.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestAttributes> GetGuestAttributesAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            GetGuestAttributesAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetIamPolicy(GetIamPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyInstanceRequest request, st::CancellationToken cancellationToken) =>
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
            GetIamPolicy(new GetIamPolicyInstanceRequest
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
            GetIamPolicyAsync(new GetIamPolicyInstanceRequest
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
        /// Returns the screenshot from the specified instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Screenshot GetScreenshot(GetScreenshotInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the screenshot from the specified instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Screenshot> GetScreenshotAsync(GetScreenshotInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the screenshot from the specified instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Screenshot> GetScreenshotAsync(GetScreenshotInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetScreenshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the screenshot from the specified instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Screenshot GetScreenshot(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            GetScreenshot(new GetScreenshotInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the screenshot from the specified instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Screenshot> GetScreenshotAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            GetScreenshotAsync(new GetScreenshotInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the screenshot from the specified instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Screenshot> GetScreenshotAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            GetScreenshotAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the last 1 MB of serial port output from the specified instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SerialPortOutput GetSerialPortOutput(GetSerialPortOutputInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the last 1 MB of serial port output from the specified instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SerialPortOutput> GetSerialPortOutputAsync(GetSerialPortOutputInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the last 1 MB of serial port output from the specified instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SerialPortOutput> GetSerialPortOutputAsync(GetSerialPortOutputInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetSerialPortOutputAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the last 1 MB of serial port output from the specified instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SerialPortOutput GetSerialPortOutput(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            GetSerialPortOutput(new GetSerialPortOutputInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the last 1 MB of serial port output from the specified instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SerialPortOutput> GetSerialPortOutputAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            GetSerialPortOutputAsync(new GetSerialPortOutputInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the last 1 MB of serial port output from the specified instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance for this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SerialPortOutput> GetSerialPortOutputAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            GetSerialPortOutputAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the Shielded Instance Identity of an instance
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ShieldedInstanceIdentity GetShieldedInstanceIdentity(GetShieldedInstanceIdentityInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Shielded Instance Identity of an instance
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ShieldedInstanceIdentity> GetShieldedInstanceIdentityAsync(GetShieldedInstanceIdentityInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Shielded Instance Identity of an instance
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ShieldedInstanceIdentity> GetShieldedInstanceIdentityAsync(GetShieldedInstanceIdentityInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetShieldedInstanceIdentityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the Shielded Instance Identity of an instance
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name or id of the instance scoping this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ShieldedInstanceIdentity GetShieldedInstanceIdentity(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            GetShieldedInstanceIdentity(new GetShieldedInstanceIdentityInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the Shielded Instance Identity of an instance
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name or id of the instance scoping this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ShieldedInstanceIdentity> GetShieldedInstanceIdentityAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            GetShieldedInstanceIdentityAsync(new GetShieldedInstanceIdentityInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the Shielded Instance Identity of an instance
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name or id of the instance scoping this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ShieldedInstanceIdentity> GetShieldedInstanceIdentityAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            GetShieldedInstanceIdentityAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an instance resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an instance resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an instance resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertInstanceRequest request, st::CancellationToken cancellationToken) =>
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
        /// Creates an instance resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instanceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(string project, string zone, Instance instanceResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertInstanceRequest
            {
                InstanceResource = gax::GaxPreconditions.CheckNotNull(instanceResource, nameof(instanceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates an instance resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instanceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string zone, Instance instanceResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertInstanceRequest
            {
                InstanceResource = gax::GaxPreconditions.CheckNotNull(instanceResource, nameof(instanceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates an instance resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instanceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string zone, Instance instanceResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, zone, instanceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of instances contained within the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<InstanceList, Instance> List(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of instances contained within the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<InstanceList, Instance> ListAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of instances contained within the specified zone.
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
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<InstanceList, Instance> List(string project, string zone, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
        /// Retrieves the list of instances contained within the specified zone.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<InstanceList, Instance> ListAsync(string project, string zone, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
        /// Retrieves a list of resources that refer to the VM instance specified in the request. For example, if the VM instance is part of a managed or unmanaged instance group, the referrers list includes the instance group. For more information, read Viewing referrers to VM instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Reference"/> resources.</returns>
        public virtual gax::PagedEnumerable<InstanceListReferrers, Reference> ListReferrers(ListReferrersInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of resources that refer to the VM instance specified in the request. For example, if the VM instance is part of a managed or unmanaged instance group, the referrers list includes the instance group. For more information, read Viewing referrers to VM instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Reference"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<InstanceListReferrers, Reference> ListReferrersAsync(ListReferrersInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of resources that refer to the VM instance specified in the request. For example, if the VM instance is part of a managed or unmanaged instance group, the referrers list includes the instance group. For more information, read Viewing referrers to VM instances.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the target instance scoping this request, or '-' if the request should span over all instances in the container.
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
        /// <returns>A pageable sequence of <see cref="Reference"/> resources.</returns>
        public virtual gax::PagedEnumerable<InstanceListReferrers, Reference> ListReferrers(string project, string zone, string instance, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReferrersInstancesRequest request = new ListReferrersInstancesRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
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
            return ListReferrers(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of resources that refer to the VM instance specified in the request. For example, if the VM instance is part of a managed or unmanaged instance group, the referrers list includes the instance group. For more information, read Viewing referrers to VM instances.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the target instance scoping this request, or '-' if the request should span over all instances in the container.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Reference"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<InstanceListReferrers, Reference> ListReferrersAsync(string project, string zone, string instance, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReferrersInstancesRequest request = new ListReferrersInstancesRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
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
            return ListReferrersAsync(request, callSettings);
        }

        /// <summary>
        /// Perform a manual maintenance on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> PerformMaintenance(PerformMaintenanceInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform a manual maintenance on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PerformMaintenanceAsync(PerformMaintenanceInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform a manual maintenance on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PerformMaintenanceAsync(PerformMaintenanceInstanceRequest request, st::CancellationToken cancellationToken) =>
            PerformMaintenanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PerformMaintenance</c>.</summary>
        public virtual lro::OperationsClient PerformMaintenanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PerformMaintenance</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOncePerformMaintenance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PerformMaintenanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PerformMaintenance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOncePerformMaintenanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PerformMaintenanceOperationsClient, callSettings);

        /// <summary>
        /// Perform a manual maintenance on the instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> PerformMaintenance(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            PerformMaintenance(new PerformMaintenanceInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Perform a manual maintenance on the instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PerformMaintenanceAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            PerformMaintenanceAsync(new PerformMaintenanceInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Perform a manual maintenance on the instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PerformMaintenanceAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            PerformMaintenanceAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes resource policies from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveResourcePolicies(RemoveResourcePoliciesInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes resource policies from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveResourcePoliciesAsync(RemoveResourcePoliciesInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes resource policies from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveResourcePoliciesAsync(RemoveResourcePoliciesInstanceRequest request, st::CancellationToken cancellationToken) =>
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
        /// Removes resource policies from an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="instancesRemoveResourcePoliciesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveResourcePolicies(string project, string zone, string instance, InstancesRemoveResourcePoliciesRequest instancesRemoveResourcePoliciesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            RemoveResourcePolicies(new RemoveResourcePoliciesInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesRemoveResourcePoliciesRequestResource = gax::GaxPreconditions.CheckNotNull(instancesRemoveResourcePoliciesRequestResource, nameof(instancesRemoveResourcePoliciesRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Removes resource policies from an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="instancesRemoveResourcePoliciesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveResourcePoliciesAsync(string project, string zone, string instance, InstancesRemoveResourcePoliciesRequest instancesRemoveResourcePoliciesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            RemoveResourcePoliciesAsync(new RemoveResourcePoliciesInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesRemoveResourcePoliciesRequestResource = gax::GaxPreconditions.CheckNotNull(instancesRemoveResourcePoliciesRequestResource, nameof(instancesRemoveResourcePoliciesRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Removes resource policies from an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="instancesRemoveResourcePoliciesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveResourcePoliciesAsync(string project, string zone, string instance, InstancesRemoveResourcePoliciesRequest instancesRemoveResourcePoliciesRequestResource, st::CancellationToken cancellationToken) =>
            RemoveResourcePoliciesAsync(project, zone, instance, instancesRemoveResourcePoliciesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mark the host as faulty and try to restart the instance on a new host.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> ReportHostAsFaulty(ReportHostAsFaultyInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mark the host as faulty and try to restart the instance on a new host.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ReportHostAsFaultyAsync(ReportHostAsFaultyInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mark the host as faulty and try to restart the instance on a new host.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ReportHostAsFaultyAsync(ReportHostAsFaultyInstanceRequest request, st::CancellationToken cancellationToken) =>
            ReportHostAsFaultyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ReportHostAsFaulty</c>.</summary>
        public virtual lro::OperationsClient ReportHostAsFaultyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ReportHostAsFaulty</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceReportHostAsFaulty(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReportHostAsFaultyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReportHostAsFaulty</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceReportHostAsFaultyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReportHostAsFaultyOperationsClient, callSettings);

        /// <summary>
        /// Mark the host as faulty and try to restart the instance on a new host.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="instancesReportHostAsFaultyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> ReportHostAsFaulty(string project, string zone, string instance, InstancesReportHostAsFaultyRequest instancesReportHostAsFaultyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            ReportHostAsFaulty(new ReportHostAsFaultyInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesReportHostAsFaultyRequestResource = gax::GaxPreconditions.CheckNotNull(instancesReportHostAsFaultyRequestResource, nameof(instancesReportHostAsFaultyRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Mark the host as faulty and try to restart the instance on a new host.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="instancesReportHostAsFaultyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ReportHostAsFaultyAsync(string project, string zone, string instance, InstancesReportHostAsFaultyRequest instancesReportHostAsFaultyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            ReportHostAsFaultyAsync(new ReportHostAsFaultyInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesReportHostAsFaultyRequestResource = gax::GaxPreconditions.CheckNotNull(instancesReportHostAsFaultyRequestResource, nameof(instancesReportHostAsFaultyRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Mark the host as faulty and try to restart the instance on a new host.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="instancesReportHostAsFaultyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ReportHostAsFaultyAsync(string project, string zone, string instance, InstancesReportHostAsFaultyRequest instancesReportHostAsFaultyRequestResource, st::CancellationToken cancellationToken) =>
            ReportHostAsFaultyAsync(project, zone, instance, instancesReportHostAsFaultyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs a reset on the instance. This is a hard reset. The VM does not do a graceful shutdown. For more information, see Resetting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Reset(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs a reset on the instance. This is a hard reset. The VM does not do a graceful shutdown. For more information, see Resetting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ResetAsync(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs a reset on the instance. This is a hard reset. The VM does not do a graceful shutdown. For more information, see Resetting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ResetAsync(ResetInstanceRequest request, st::CancellationToken cancellationToken) =>
            ResetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Reset</c>.</summary>
        public virtual lro::OperationsClient ResetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Reset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceReset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Reset</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceResetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResetOperationsClient, callSettings);

        /// <summary>
        /// Performs a reset on the instance. This is a hard reset. The VM does not do a graceful shutdown. For more information, see Resetting an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Reset(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            Reset(new ResetInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Performs a reset on the instance. This is a hard reset. The VM does not do a graceful shutdown. For more information, see Resetting an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ResetAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            ResetAsync(new ResetInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Performs a reset on the instance. This is a hard reset. The VM does not do a graceful shutdown. For more information, see Resetting an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ResetAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            ResetAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes an instance that was suspended using the instances().suspend method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Resume(ResumeInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes an instance that was suspended using the instances().suspend method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ResumeAsync(ResumeInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes an instance that was suspended using the instances().suspend method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ResumeAsync(ResumeInstanceRequest request, st::CancellationToken cancellationToken) =>
            ResumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Resume</c>.</summary>
        public virtual lro::OperationsClient ResumeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Resume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceResume(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResumeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Resume</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceResumeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResumeOperationsClient, callSettings);

        /// <summary>
        /// Resumes an instance that was suspended using the instances().suspend method.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to resume.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Resume(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            Resume(new ResumeInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Resumes an instance that was suspended using the instances().suspend method.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to resume.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ResumeAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            ResumeAsync(new ResumeInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Resumes an instance that was suspended using the instances().suspend method.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to resume.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> ResumeAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            ResumeAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sends diagnostic interrupt to the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SendDiagnosticInterruptInstanceResponse SendDiagnosticInterrupt(SendDiagnosticInterruptInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sends diagnostic interrupt to the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SendDiagnosticInterruptInstanceResponse> SendDiagnosticInterruptAsync(SendDiagnosticInterruptInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sends diagnostic interrupt to the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SendDiagnosticInterruptInstanceResponse> SendDiagnosticInterruptAsync(SendDiagnosticInterruptInstanceRequest request, st::CancellationToken cancellationToken) =>
            SendDiagnosticInterruptAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sends diagnostic interrupt to the instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SendDiagnosticInterruptInstanceResponse SendDiagnosticInterrupt(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            SendDiagnosticInterrupt(new SendDiagnosticInterruptInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sends diagnostic interrupt to the instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SendDiagnosticInterruptInstanceResponse> SendDiagnosticInterruptAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            SendDiagnosticInterruptAsync(new SendDiagnosticInterruptInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sends diagnostic interrupt to the instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SendDiagnosticInterruptInstanceResponse> SendDiagnosticInterruptAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            SendDiagnosticInterruptAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets deletion protection on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetDeletionProtection(SetDeletionProtectionInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets deletion protection on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetDeletionProtectionAsync(SetDeletionProtectionInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets deletion protection on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetDeletionProtectionAsync(SetDeletionProtectionInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetDeletionProtectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetDeletionProtection</c>.</summary>
        public virtual lro::OperationsClient SetDeletionProtectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetDeletionProtection</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetDeletionProtection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetDeletionProtectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetDeletionProtection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetDeletionProtectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetDeletionProtectionOperationsClient, callSettings);

        /// <summary>
        /// Sets deletion protection on the instance.
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
        public virtual lro::Operation<Operation, Operation> SetDeletionProtection(string project, string zone, string resource, gaxgrpc::CallSettings callSettings = null) =>
            SetDeletionProtection(new SetDeletionProtectionInstanceRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets deletion protection on the instance.
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
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetDeletionProtectionAsync(string project, string zone, string resource, gaxgrpc::CallSettings callSettings = null) =>
            SetDeletionProtectionAsync(new SetDeletionProtectionInstanceRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets deletion protection on the instance.
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
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetDeletionProtectionAsync(string project, string zone, string resource, st::CancellationToken cancellationToken) =>
            SetDeletionProtectionAsync(project, zone, resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the auto-delete flag for a disk attached to an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetDiskAutoDelete(SetDiskAutoDeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the auto-delete flag for a disk attached to an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetDiskAutoDeleteAsync(SetDiskAutoDeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the auto-delete flag for a disk attached to an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetDiskAutoDeleteAsync(SetDiskAutoDeleteInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetDiskAutoDeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetDiskAutoDelete</c>.</summary>
        public virtual lro::OperationsClient SetDiskAutoDeleteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetDiskAutoDelete</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetDiskAutoDelete(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetDiskAutoDeleteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetDiskAutoDelete</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetDiskAutoDeleteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetDiskAutoDeleteOperationsClient, callSettings);

        /// <summary>
        /// Sets the auto-delete flag for a disk attached to an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="autoDelete">
        /// Whether to auto-delete the disk when the instance is deleted.
        /// </param>
        /// <param name="deviceName">
        /// The device name of the disk to modify. Make a get() request on the instance to view currently attached disks and device names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetDiskAutoDelete(string project, string zone, string instance, bool autoDelete, string deviceName, gaxgrpc::CallSettings callSettings = null) =>
            SetDiskAutoDelete(new SetDiskAutoDeleteInstanceRequest
            {
                AutoDelete = autoDelete,
                DeviceName = gax::GaxPreconditions.CheckNotNullOrEmpty(deviceName, nameof(deviceName)),
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets the auto-delete flag for a disk attached to an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="autoDelete">
        /// Whether to auto-delete the disk when the instance is deleted.
        /// </param>
        /// <param name="deviceName">
        /// The device name of the disk to modify. Make a get() request on the instance to view currently attached disks and device names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetDiskAutoDeleteAsync(string project, string zone, string instance, bool autoDelete, string deviceName, gaxgrpc::CallSettings callSettings = null) =>
            SetDiskAutoDeleteAsync(new SetDiskAutoDeleteInstanceRequest
            {
                AutoDelete = autoDelete,
                DeviceName = gax::GaxPreconditions.CheckNotNullOrEmpty(deviceName, nameof(deviceName)),
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets the auto-delete flag for a disk attached to an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="autoDelete">
        /// Whether to auto-delete the disk when the instance is deleted.
        /// </param>
        /// <param name="deviceName">
        /// The device name of the disk to modify. Make a get() request on the instance to view currently attached disks and device names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetDiskAutoDeleteAsync(string project, string zone, string instance, bool autoDelete, string deviceName, st::CancellationToken cancellationToken) =>
            SetDiskAutoDeleteAsync(project, zone, instance, autoDelete, deviceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy SetIamPolicy(SetIamPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyInstanceRequest request, st::CancellationToken cancellationToken) =>
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
            SetIamPolicy(new SetIamPolicyInstanceRequest
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
            SetIamPolicyAsync(new SetIamPolicyInstanceRequest
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
        /// Sets labels on an instance. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetLabels(SetLabelsInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets labels on an instance. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(SetLabelsInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets labels on an instance. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(SetLabelsInstanceRequest request, st::CancellationToken cancellationToken) =>
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
        /// Sets labels on an instance. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="instancesSetLabelsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetLabels(string project, string zone, string instance, InstancesSetLabelsRequest instancesSetLabelsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetLabels(new SetLabelsInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesSetLabelsRequestResource = gax::GaxPreconditions.CheckNotNull(instancesSetLabelsRequestResource, nameof(instancesSetLabelsRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets labels on an instance. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="instancesSetLabelsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(string project, string zone, string instance, InstancesSetLabelsRequest instancesSetLabelsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetLabelsAsync(new SetLabelsInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesSetLabelsRequestResource = gax::GaxPreconditions.CheckNotNull(instancesSetLabelsRequestResource, nameof(instancesSetLabelsRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets labels on an instance. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="instancesSetLabelsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(string project, string zone, string instance, InstancesSetLabelsRequest instancesSetLabelsRequestResource, st::CancellationToken cancellationToken) =>
            SetLabelsAsync(project, zone, instance, instancesSetLabelsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the number and/or type of accelerator for a stopped instance to the values specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetMachineResources(SetMachineResourcesInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the number and/or type of accelerator for a stopped instance to the values specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetMachineResourcesAsync(SetMachineResourcesInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the number and/or type of accelerator for a stopped instance to the values specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetMachineResourcesAsync(SetMachineResourcesInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetMachineResourcesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetMachineResources</c>.</summary>
        public virtual lro::OperationsClient SetMachineResourcesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetMachineResources</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetMachineResources(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetMachineResourcesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetMachineResources</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetMachineResourcesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetMachineResourcesOperationsClient, callSettings);

        /// <summary>
        /// Changes the number and/or type of accelerator for a stopped instance to the values specified in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="instancesSetMachineResourcesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetMachineResources(string project, string zone, string instance, InstancesSetMachineResourcesRequest instancesSetMachineResourcesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetMachineResources(new SetMachineResourcesInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesSetMachineResourcesRequestResource = gax::GaxPreconditions.CheckNotNull(instancesSetMachineResourcesRequestResource, nameof(instancesSetMachineResourcesRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Changes the number and/or type of accelerator for a stopped instance to the values specified in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="instancesSetMachineResourcesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetMachineResourcesAsync(string project, string zone, string instance, InstancesSetMachineResourcesRequest instancesSetMachineResourcesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetMachineResourcesAsync(new SetMachineResourcesInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesSetMachineResourcesRequestResource = gax::GaxPreconditions.CheckNotNull(instancesSetMachineResourcesRequestResource, nameof(instancesSetMachineResourcesRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Changes the number and/or type of accelerator for a stopped instance to the values specified in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="instancesSetMachineResourcesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetMachineResourcesAsync(string project, string zone, string instance, InstancesSetMachineResourcesRequest instancesSetMachineResourcesRequestResource, st::CancellationToken cancellationToken) =>
            SetMachineResourcesAsync(project, zone, instance, instancesSetMachineResourcesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the machine type for a stopped instance to the machine type specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetMachineType(SetMachineTypeInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the machine type for a stopped instance to the machine type specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetMachineTypeAsync(SetMachineTypeInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the machine type for a stopped instance to the machine type specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetMachineTypeAsync(SetMachineTypeInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetMachineTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetMachineType</c>.</summary>
        public virtual lro::OperationsClient SetMachineTypeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetMachineType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetMachineType(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetMachineTypeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetMachineType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetMachineTypeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetMachineTypeOperationsClient, callSettings);

        /// <summary>
        /// Changes the machine type for a stopped instance to the machine type specified in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="instancesSetMachineTypeRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetMachineType(string project, string zone, string instance, InstancesSetMachineTypeRequest instancesSetMachineTypeRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetMachineType(new SetMachineTypeInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesSetMachineTypeRequestResource = gax::GaxPreconditions.CheckNotNull(instancesSetMachineTypeRequestResource, nameof(instancesSetMachineTypeRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Changes the machine type for a stopped instance to the machine type specified in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="instancesSetMachineTypeRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetMachineTypeAsync(string project, string zone, string instance, InstancesSetMachineTypeRequest instancesSetMachineTypeRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetMachineTypeAsync(new SetMachineTypeInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesSetMachineTypeRequestResource = gax::GaxPreconditions.CheckNotNull(instancesSetMachineTypeRequestResource, nameof(instancesSetMachineTypeRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Changes the machine type for a stopped instance to the machine type specified in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="instancesSetMachineTypeRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetMachineTypeAsync(string project, string zone, string instance, InstancesSetMachineTypeRequest instancesSetMachineTypeRequestResource, st::CancellationToken cancellationToken) =>
            SetMachineTypeAsync(project, zone, instance, instancesSetMachineTypeRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets metadata for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetMetadata(SetMetadataInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets metadata for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetMetadataAsync(SetMetadataInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets metadata for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetMetadataAsync(SetMetadataInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetMetadataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetMetadata</c>.</summary>
        public virtual lro::OperationsClient SetMetadataOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetMetadata</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetMetadata(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetMetadataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetMetadata</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetMetadataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetMetadataOperationsClient, callSettings);

        /// <summary>
        /// Sets metadata for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="metadataResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetMetadata(string project, string zone, string instance, Metadata metadataResource, gaxgrpc::CallSettings callSettings = null) =>
            SetMetadata(new SetMetadataInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                MetadataResource = gax::GaxPreconditions.CheckNotNull(metadataResource, nameof(metadataResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets metadata for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="metadataResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetMetadataAsync(string project, string zone, string instance, Metadata metadataResource, gaxgrpc::CallSettings callSettings = null) =>
            SetMetadataAsync(new SetMetadataInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                MetadataResource = gax::GaxPreconditions.CheckNotNull(metadataResource, nameof(metadataResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets metadata for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="metadataResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetMetadataAsync(string project, string zone, string instance, Metadata metadataResource, st::CancellationToken cancellationToken) =>
            SetMetadataAsync(project, zone, instance, metadataResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the minimum CPU platform that this instance should use. This method can only be called on a stopped instance. For more information, read Specifying a Minimum CPU Platform.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetMinCpuPlatform(SetMinCpuPlatformInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the minimum CPU platform that this instance should use. This method can only be called on a stopped instance. For more information, read Specifying a Minimum CPU Platform.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetMinCpuPlatformAsync(SetMinCpuPlatformInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the minimum CPU platform that this instance should use. This method can only be called on a stopped instance. For more information, read Specifying a Minimum CPU Platform.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetMinCpuPlatformAsync(SetMinCpuPlatformInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetMinCpuPlatformAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetMinCpuPlatform</c>.</summary>
        public virtual lro::OperationsClient SetMinCpuPlatformOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetMinCpuPlatform</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetMinCpuPlatform(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetMinCpuPlatformOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetMinCpuPlatform</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetMinCpuPlatformAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetMinCpuPlatformOperationsClient, callSettings);

        /// <summary>
        /// Changes the minimum CPU platform that this instance should use. This method can only be called on a stopped instance. For more information, read Specifying a Minimum CPU Platform.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="instancesSetMinCpuPlatformRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetMinCpuPlatform(string project, string zone, string instance, InstancesSetMinCpuPlatformRequest instancesSetMinCpuPlatformRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetMinCpuPlatform(new SetMinCpuPlatformInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesSetMinCpuPlatformRequestResource = gax::GaxPreconditions.CheckNotNull(instancesSetMinCpuPlatformRequestResource, nameof(instancesSetMinCpuPlatformRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Changes the minimum CPU platform that this instance should use. This method can only be called on a stopped instance. For more information, read Specifying a Minimum CPU Platform.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="instancesSetMinCpuPlatformRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetMinCpuPlatformAsync(string project, string zone, string instance, InstancesSetMinCpuPlatformRequest instancesSetMinCpuPlatformRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetMinCpuPlatformAsync(new SetMinCpuPlatformInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesSetMinCpuPlatformRequestResource = gax::GaxPreconditions.CheckNotNull(instancesSetMinCpuPlatformRequestResource, nameof(instancesSetMinCpuPlatformRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Changes the minimum CPU platform that this instance should use. This method can only be called on a stopped instance. For more information, read Specifying a Minimum CPU Platform.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="instancesSetMinCpuPlatformRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetMinCpuPlatformAsync(string project, string zone, string instance, InstancesSetMinCpuPlatformRequest instancesSetMinCpuPlatformRequestResource, st::CancellationToken cancellationToken) =>
            SetMinCpuPlatformAsync(project, zone, instance, instancesSetMinCpuPlatformRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets name of an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetName(SetNameInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets name of an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetNameAsync(SetNameInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets name of an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetNameAsync(SetNameInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetNameAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetName</c>.</summary>
        public virtual lro::OperationsClient SetNameOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetName</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetName(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetNameOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetName</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetNameAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetNameOperationsClient, callSettings);

        /// <summary>
        /// Sets name of an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="instancesSetNameRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetName(string project, string zone, string instance, InstancesSetNameRequest instancesSetNameRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetName(new SetNameInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesSetNameRequestResource = gax::GaxPreconditions.CheckNotNull(instancesSetNameRequestResource, nameof(instancesSetNameRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets name of an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="instancesSetNameRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetNameAsync(string project, string zone, string instance, InstancesSetNameRequest instancesSetNameRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetNameAsync(new SetNameInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesSetNameRequestResource = gax::GaxPreconditions.CheckNotNull(instancesSetNameRequestResource, nameof(instancesSetNameRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets name of an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="instancesSetNameRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetNameAsync(string project, string zone, string instance, InstancesSetNameRequest instancesSetNameRequestResource, st::CancellationToken cancellationToken) =>
            SetNameAsync(project, zone, instance, instancesSetNameRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets an instance's scheduling options. You can only call this method on a stopped instance, that is, a VM instance that is in a `TERMINATED` state. See Instance Life Cycle for more information on the possible instance states. For more information about setting scheduling options for a VM, see Set VM host maintenance policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetScheduling(SetSchedulingInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets an instance's scheduling options. You can only call this method on a stopped instance, that is, a VM instance that is in a `TERMINATED` state. See Instance Life Cycle for more information on the possible instance states. For more information about setting scheduling options for a VM, see Set VM host maintenance policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSchedulingAsync(SetSchedulingInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets an instance's scheduling options. You can only call this method on a stopped instance, that is, a VM instance that is in a `TERMINATED` state. See Instance Life Cycle for more information on the possible instance states. For more information about setting scheduling options for a VM, see Set VM host maintenance policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSchedulingAsync(SetSchedulingInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetSchedulingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetScheduling</c>.</summary>
        public virtual lro::OperationsClient SetSchedulingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetScheduling</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetScheduling(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetSchedulingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetScheduling</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetSchedulingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetSchedulingOperationsClient, callSettings);

        /// <summary>
        /// Sets an instance's scheduling options. You can only call this method on a stopped instance, that is, a VM instance that is in a `TERMINATED` state. See Instance Life Cycle for more information on the possible instance states. For more information about setting scheduling options for a VM, see Set VM host maintenance policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Instance name for this request.
        /// </param>
        /// <param name="schedulingResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetScheduling(string project, string zone, string instance, Scheduling schedulingResource, gaxgrpc::CallSettings callSettings = null) =>
            SetScheduling(new SetSchedulingInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SchedulingResource = gax::GaxPreconditions.CheckNotNull(schedulingResource, nameof(schedulingResource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets an instance's scheduling options. You can only call this method on a stopped instance, that is, a VM instance that is in a `TERMINATED` state. See Instance Life Cycle for more information on the possible instance states. For more information about setting scheduling options for a VM, see Set VM host maintenance policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Instance name for this request.
        /// </param>
        /// <param name="schedulingResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSchedulingAsync(string project, string zone, string instance, Scheduling schedulingResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSchedulingAsync(new SetSchedulingInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SchedulingResource = gax::GaxPreconditions.CheckNotNull(schedulingResource, nameof(schedulingResource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets an instance's scheduling options. You can only call this method on a stopped instance, that is, a VM instance that is in a `TERMINATED` state. See Instance Life Cycle for more information on the possible instance states. For more information about setting scheduling options for a VM, see Set VM host maintenance policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Instance name for this request.
        /// </param>
        /// <param name="schedulingResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSchedulingAsync(string project, string zone, string instance, Scheduling schedulingResource, st::CancellationToken cancellationToken) =>
            SetSchedulingAsync(project, zone, instance, schedulingResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified instance. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetSecurityPolicy(SetSecurityPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified instance. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSecurityPolicyAsync(SetSecurityPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified instance. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSecurityPolicyAsync(SetSecurityPolicyInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetSecurityPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetSecurityPolicy</c>.</summary>
        public virtual lro::OperationsClient SetSecurityPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetSecurityPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetSecurityPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetSecurityPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetSecurityPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetSecurityPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetSecurityPolicyOperationsClient, callSettings);

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified instance. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone scoping this request.
        /// </param>
        /// <param name="instance">
        /// Name of the Instance resource to which the security policy should be set. The name should conform to RFC1035.
        /// </param>
        /// <param name="instancesSetSecurityPolicyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetSecurityPolicy(string project, string zone, string instance, InstancesSetSecurityPolicyRequest instancesSetSecurityPolicyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSecurityPolicy(new SetSecurityPolicyInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesSetSecurityPolicyRequestResource = gax::GaxPreconditions.CheckNotNull(instancesSetSecurityPolicyRequestResource, nameof(instancesSetSecurityPolicyRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified instance. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone scoping this request.
        /// </param>
        /// <param name="instance">
        /// Name of the Instance resource to which the security policy should be set. The name should conform to RFC1035.
        /// </param>
        /// <param name="instancesSetSecurityPolicyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSecurityPolicyAsync(string project, string zone, string instance, InstancesSetSecurityPolicyRequest instancesSetSecurityPolicyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSecurityPolicyAsync(new SetSecurityPolicyInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesSetSecurityPolicyRequestResource = gax::GaxPreconditions.CheckNotNull(instancesSetSecurityPolicyRequestResource, nameof(instancesSetSecurityPolicyRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified instance. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone scoping this request.
        /// </param>
        /// <param name="instance">
        /// Name of the Instance resource to which the security policy should be set. The name should conform to RFC1035.
        /// </param>
        /// <param name="instancesSetSecurityPolicyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSecurityPolicyAsync(string project, string zone, string instance, InstancesSetSecurityPolicyRequest instancesSetSecurityPolicyRequestResource, st::CancellationToken cancellationToken) =>
            SetSecurityPolicyAsync(project, zone, instance, instancesSetSecurityPolicyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the service account on the instance. For more information, read Changing the service account and access scopes for an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetServiceAccount(SetServiceAccountInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the service account on the instance. For more information, read Changing the service account and access scopes for an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetServiceAccountAsync(SetServiceAccountInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the service account on the instance. For more information, read Changing the service account and access scopes for an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetServiceAccountAsync(SetServiceAccountInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetServiceAccount</c>.</summary>
        public virtual lro::OperationsClient SetServiceAccountOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetServiceAccount</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetServiceAccount(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetServiceAccountOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetServiceAccount</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetServiceAccountAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetServiceAccountOperationsClient, callSettings);

        /// <summary>
        /// Sets the service account on the instance. For more information, read Changing the service account and access scopes for an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to start.
        /// </param>
        /// <param name="instancesSetServiceAccountRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetServiceAccount(string project, string zone, string instance, InstancesSetServiceAccountRequest instancesSetServiceAccountRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetServiceAccount(new SetServiceAccountInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesSetServiceAccountRequestResource = gax::GaxPreconditions.CheckNotNull(instancesSetServiceAccountRequestResource, nameof(instancesSetServiceAccountRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets the service account on the instance. For more information, read Changing the service account and access scopes for an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to start.
        /// </param>
        /// <param name="instancesSetServiceAccountRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetServiceAccountAsync(string project, string zone, string instance, InstancesSetServiceAccountRequest instancesSetServiceAccountRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetServiceAccountAsync(new SetServiceAccountInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesSetServiceAccountRequestResource = gax::GaxPreconditions.CheckNotNull(instancesSetServiceAccountRequestResource, nameof(instancesSetServiceAccountRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets the service account on the instance. For more information, read Changing the service account and access scopes for an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to start.
        /// </param>
        /// <param name="instancesSetServiceAccountRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetServiceAccountAsync(string project, string zone, string instance, InstancesSetServiceAccountRequest instancesSetServiceAccountRequestResource, st::CancellationToken cancellationToken) =>
            SetServiceAccountAsync(project, zone, instance, instancesSetServiceAccountRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the Shielded Instance integrity policy for an instance. You can only use this method on a running instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetShieldedInstanceIntegrityPolicy(SetShieldedInstanceIntegrityPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the Shielded Instance integrity policy for an instance. You can only use this method on a running instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetShieldedInstanceIntegrityPolicyAsync(SetShieldedInstanceIntegrityPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the Shielded Instance integrity policy for an instance. You can only use this method on a running instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetShieldedInstanceIntegrityPolicyAsync(SetShieldedInstanceIntegrityPolicyInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetShieldedInstanceIntegrityPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetShieldedInstanceIntegrityPolicy</c>.</summary>
        public virtual lro::OperationsClient SetShieldedInstanceIntegrityPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetShieldedInstanceIntegrityPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetShieldedInstanceIntegrityPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetShieldedInstanceIntegrityPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetShieldedInstanceIntegrityPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetShieldedInstanceIntegrityPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetShieldedInstanceIntegrityPolicyOperationsClient, callSettings);

        /// <summary>
        /// Sets the Shielded Instance integrity policy for an instance. You can only use this method on a running instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name or id of the instance scoping this request.
        /// </param>
        /// <param name="shieldedInstanceIntegrityPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetShieldedInstanceIntegrityPolicy(string project, string zone, string instance, ShieldedInstanceIntegrityPolicy shieldedInstanceIntegrityPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
            SetShieldedInstanceIntegrityPolicy(new SetShieldedInstanceIntegrityPolicyInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ShieldedInstanceIntegrityPolicyResource = gax::GaxPreconditions.CheckNotNull(shieldedInstanceIntegrityPolicyResource, nameof(shieldedInstanceIntegrityPolicyResource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets the Shielded Instance integrity policy for an instance. You can only use this method on a running instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name or id of the instance scoping this request.
        /// </param>
        /// <param name="shieldedInstanceIntegrityPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetShieldedInstanceIntegrityPolicyAsync(string project, string zone, string instance, ShieldedInstanceIntegrityPolicy shieldedInstanceIntegrityPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
            SetShieldedInstanceIntegrityPolicyAsync(new SetShieldedInstanceIntegrityPolicyInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ShieldedInstanceIntegrityPolicyResource = gax::GaxPreconditions.CheckNotNull(shieldedInstanceIntegrityPolicyResource, nameof(shieldedInstanceIntegrityPolicyResource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets the Shielded Instance integrity policy for an instance. You can only use this method on a running instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name or id of the instance scoping this request.
        /// </param>
        /// <param name="shieldedInstanceIntegrityPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetShieldedInstanceIntegrityPolicyAsync(string project, string zone, string instance, ShieldedInstanceIntegrityPolicy shieldedInstanceIntegrityPolicyResource, st::CancellationToken cancellationToken) =>
            SetShieldedInstanceIntegrityPolicyAsync(project, zone, instance, shieldedInstanceIntegrityPolicyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets network tags for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetTags(SetTagsInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets network tags for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetTagsAsync(SetTagsInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets network tags for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetTagsAsync(SetTagsInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetTagsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetTags</c>.</summary>
        public virtual lro::OperationsClient SetTagsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetTags</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetTags(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetTagsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetTags</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetTagsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetTagsOperationsClient, callSettings);

        /// <summary>
        /// Sets network tags for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="tagsResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetTags(string project, string zone, string instance, Tags tagsResource, gaxgrpc::CallSettings callSettings = null) =>
            SetTags(new SetTagsInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TagsResource = gax::GaxPreconditions.CheckNotNull(tagsResource, nameof(tagsResource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets network tags for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="tagsResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetTagsAsync(string project, string zone, string instance, Tags tagsResource, gaxgrpc::CallSettings callSettings = null) =>
            SetTagsAsync(new SetTagsInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TagsResource = gax::GaxPreconditions.CheckNotNull(tagsResource, nameof(tagsResource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets network tags for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="tagsResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetTagsAsync(string project, string zone, string instance, Tags tagsResource, st::CancellationToken cancellationToken) =>
            SetTagsAsync(project, zone, instance, tagsResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Simulates a host maintenance event on a VM. For more information, see Simulate a host maintenance event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SimulateMaintenanceEvent(SimulateMaintenanceEventInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Simulates a host maintenance event on a VM. For more information, see Simulate a host maintenance event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SimulateMaintenanceEventAsync(SimulateMaintenanceEventInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Simulates a host maintenance event on a VM. For more information, see Simulate a host maintenance event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SimulateMaintenanceEventAsync(SimulateMaintenanceEventInstanceRequest request, st::CancellationToken cancellationToken) =>
            SimulateMaintenanceEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SimulateMaintenanceEvent</c>.</summary>
        public virtual lro::OperationsClient SimulateMaintenanceEventOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SimulateMaintenanceEvent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSimulateMaintenanceEvent(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SimulateMaintenanceEventOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SimulateMaintenanceEvent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSimulateMaintenanceEventAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SimulateMaintenanceEventOperationsClient, callSettings);

        /// <summary>
        /// Simulates a host maintenance event on a VM. For more information, see Simulate a host maintenance event.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SimulateMaintenanceEvent(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            SimulateMaintenanceEvent(new SimulateMaintenanceEventInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Simulates a host maintenance event on a VM. For more information, see Simulate a host maintenance event.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SimulateMaintenanceEventAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            SimulateMaintenanceEventAsync(new SimulateMaintenanceEventInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Simulates a host maintenance event on a VM. For more information, see Simulate a host maintenance event.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SimulateMaintenanceEventAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            SimulateMaintenanceEventAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Start(StartInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StartAsync(StartInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StartAsync(StartInstanceRequest request, st::CancellationToken cancellationToken) =>
            StartAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Start</c>.</summary>
        public virtual lro::OperationsClient StartOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Start</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceStart(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Start</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceStartAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartOperationsClient, callSettings);

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to start.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Start(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            Start(new StartInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to start.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StartAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            StartAsync(new StartInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to start.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StartAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            StartAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> StartWithEncryptionKey(StartWithEncryptionKeyInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StartWithEncryptionKeyAsync(StartWithEncryptionKeyInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StartWithEncryptionKeyAsync(StartWithEncryptionKeyInstanceRequest request, st::CancellationToken cancellationToken) =>
            StartWithEncryptionKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StartWithEncryptionKey</c>.</summary>
        public virtual lro::OperationsClient StartWithEncryptionKeyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartWithEncryptionKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceStartWithEncryptionKey(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartWithEncryptionKeyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartWithEncryptionKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceStartWithEncryptionKeyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartWithEncryptionKeyOperationsClient, callSettings);

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to start.
        /// </param>
        /// <param name="instancesStartWithEncryptionKeyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> StartWithEncryptionKey(string project, string zone, string instance, InstancesStartWithEncryptionKeyRequest instancesStartWithEncryptionKeyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            StartWithEncryptionKey(new StartWithEncryptionKeyInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesStartWithEncryptionKeyRequestResource = gax::GaxPreconditions.CheckNotNull(instancesStartWithEncryptionKeyRequestResource, nameof(instancesStartWithEncryptionKeyRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to start.
        /// </param>
        /// <param name="instancesStartWithEncryptionKeyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StartWithEncryptionKeyAsync(string project, string zone, string instance, InstancesStartWithEncryptionKeyRequest instancesStartWithEncryptionKeyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            StartWithEncryptionKeyAsync(new StartWithEncryptionKeyInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstancesStartWithEncryptionKeyRequestResource = gax::GaxPreconditions.CheckNotNull(instancesStartWithEncryptionKeyRequestResource, nameof(instancesStartWithEncryptionKeyRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to start.
        /// </param>
        /// <param name="instancesStartWithEncryptionKeyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StartWithEncryptionKeyAsync(string project, string zone, string instance, InstancesStartWithEncryptionKeyRequest instancesStartWithEncryptionKeyRequestResource, st::CancellationToken cancellationToken) =>
            StartWithEncryptionKeyAsync(project, zone, instance, instancesStartWithEncryptionKeyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops a running instance, shutting it down cleanly, and allows you to restart the instance at a later time. Stopped instances do not incur VM usage charges while they are stopped. However, resources that the VM is using, such as persistent disks and static IP addresses, will continue to be charged until they are deleted. For more information, see Stopping an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Stop(StopInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a running instance, shutting it down cleanly, and allows you to restart the instance at a later time. Stopped instances do not incur VM usage charges while they are stopped. However, resources that the VM is using, such as persistent disks and static IP addresses, will continue to be charged until they are deleted. For more information, see Stopping an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopAsync(StopInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a running instance, shutting it down cleanly, and allows you to restart the instance at a later time. Stopped instances do not incur VM usage charges while they are stopped. However, resources that the VM is using, such as persistent disks and static IP addresses, will continue to be charged until they are deleted. For more information, see Stopping an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopAsync(StopInstanceRequest request, st::CancellationToken cancellationToken) =>
            StopAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Stop</c>.</summary>
        public virtual lro::OperationsClient StopOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Stop</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceStop(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Stop</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceStopAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopOperationsClient, callSettings);

        /// <summary>
        /// Stops a running instance, shutting it down cleanly, and allows you to restart the instance at a later time. Stopped instances do not incur VM usage charges while they are stopped. However, resources that the VM is using, such as persistent disks and static IP addresses, will continue to be charged until they are deleted. For more information, see Stopping an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to stop.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Stop(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            Stop(new StopInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Stops a running instance, shutting it down cleanly, and allows you to restart the instance at a later time. Stopped instances do not incur VM usage charges while they are stopped. However, resources that the VM is using, such as persistent disks and static IP addresses, will continue to be charged until they are deleted. For more information, see Stopping an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to stop.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            StopAsync(new StopInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Stops a running instance, shutting it down cleanly, and allows you to restart the instance at a later time. Stopped instances do not incur VM usage charges while they are stopped. However, resources that the VM is using, such as persistent disks and static IP addresses, will continue to be charged until they are deleted. For more information, see Stopping an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to stop.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> StopAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            StopAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method suspends a running instance, saving its state to persistent storage, and allows you to resume the instance at a later time. Suspended instances have no compute costs (cores or RAM), and incur only storage charges for the saved VM memory and localSSD data. Any charged resources the virtual machine was using, such as persistent disks and static IP addresses, will continue to be charged while the instance is suspended. For more information, see Suspending and resuming an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Suspend(SuspendInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method suspends a running instance, saving its state to persistent storage, and allows you to resume the instance at a later time. Suspended instances have no compute costs (cores or RAM), and incur only storage charges for the saved VM memory and localSSD data. Any charged resources the virtual machine was using, such as persistent disks and static IP addresses, will continue to be charged while the instance is suspended. For more information, see Suspending and resuming an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SuspendAsync(SuspendInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method suspends a running instance, saving its state to persistent storage, and allows you to resume the instance at a later time. Suspended instances have no compute costs (cores or RAM), and incur only storage charges for the saved VM memory and localSSD data. Any charged resources the virtual machine was using, such as persistent disks and static IP addresses, will continue to be charged while the instance is suspended. For more information, see Suspending and resuming an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SuspendAsync(SuspendInstanceRequest request, st::CancellationToken cancellationToken) =>
            SuspendAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Suspend</c>.</summary>
        public virtual lro::OperationsClient SuspendOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Suspend</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSuspend(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SuspendOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>Suspend</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSuspendAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SuspendOperationsClient, callSettings);

        /// <summary>
        /// This method suspends a running instance, saving its state to persistent storage, and allows you to resume the instance at a later time. Suspended instances have no compute costs (cores or RAM), and incur only storage charges for the saved VM memory and localSSD data. Any charged resources the virtual machine was using, such as persistent disks and static IP addresses, will continue to be charged while the instance is suspended. For more information, see Suspending and resuming an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to suspend.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Suspend(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            Suspend(new SuspendInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// This method suspends a running instance, saving its state to persistent storage, and allows you to resume the instance at a later time. Suspended instances have no compute costs (cores or RAM), and incur only storage charges for the saved VM memory and localSSD data. Any charged resources the virtual machine was using, such as persistent disks and static IP addresses, will continue to be charged while the instance is suspended. For more information, see Suspending and resuming an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to suspend.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SuspendAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            SuspendAsync(new SuspendInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// This method suspends a running instance, saving its state to persistent storage, and allows you to resume the instance at a later time. Suspended instances have no compute costs (cores or RAM), and incur only storage charges for the saved VM memory and localSSD data. Any charged resources the virtual machine was using, such as persistent disks and static IP addresses, will continue to be charged while the instance is suspended. For more information, see Suspending and resuming an instance.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to suspend.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SuspendAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            SuspendAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestPermissionsResponse TestIamPermissions(TestIamPermissionsInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsInstanceRequest request, st::CancellationToken cancellationToken) =>
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
            TestIamPermissions(new TestIamPermissionsInstanceRequest
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
            TestIamPermissionsAsync(new TestIamPermissionsInstanceRequest
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
        /// Updates an instance only if the necessary resources are available. This method can update only a specific set of instance properties. See Updating a running instance for a list of updatable instance properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Update(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an instance only if the necessary resources are available. This method can update only a specific set of instance properties. See Updating a running instance for a list of updatable instance properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an instance only if the necessary resources are available. This method can update only a specific set of instance properties. See Updating a running instance for a list of updatable instance properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateInstanceRequest request, st::CancellationToken cancellationToken) =>
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
        /// Updates an instance only if the necessary resources are available. This method can update only a specific set of instance properties. See Updating a running instance for a list of updatable instance properties.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to update.
        /// </param>
        /// <param name="instanceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Update(string project, string zone, string instance, Instance instanceResource, gaxgrpc::CallSettings callSettings = null) =>
            Update(new UpdateInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstanceResource = gax::GaxPreconditions.CheckNotNull(instanceResource, nameof(instanceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Updates an instance only if the necessary resources are available. This method can update only a specific set of instance properties. See Updating a running instance for a list of updatable instance properties.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to update.
        /// </param>
        /// <param name="instanceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(string project, string zone, string instance, Instance instanceResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAsync(new UpdateInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstanceResource = gax::GaxPreconditions.CheckNotNull(instanceResource, nameof(instanceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Updates an instance only if the necessary resources are available. This method can update only a specific set of instance properties. See Updating a running instance for a list of updatable instance properties.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance resource to update.
        /// </param>
        /// <param name="instanceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(string project, string zone, string instance, Instance instanceResource, st::CancellationToken cancellationToken) =>
            UpdateAsync(project, zone, instance, instanceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified access config from an instance's network interface with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> UpdateAccessConfig(UpdateAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified access config from an instance's network interface with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAccessConfigAsync(UpdateAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified access config from an instance's network interface with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAccessConfigAsync(UpdateAccessConfigInstanceRequest request, st::CancellationToken cancellationToken) =>
            UpdateAccessConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAccessConfig</c>.</summary>
        public virtual lro::OperationsClient UpdateAccessConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAccessConfig</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceUpdateAccessConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAccessConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAccessConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceUpdateAccessConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAccessConfigOperationsClient, callSettings);

        /// <summary>
        /// Updates the specified access config from an instance's network interface with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="networkInterface">
        /// The name of the network interface where the access config is attached.
        /// </param>
        /// <param name="accessConfigResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> UpdateAccessConfig(string project, string zone, string instance, string networkInterface, AccessConfig accessConfigResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccessConfig(new UpdateAccessConfigInstanceRequest
            {
                AccessConfigResource = gax::GaxPreconditions.CheckNotNull(accessConfigResource, nameof(accessConfigResource)),
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                NetworkInterface = gax::GaxPreconditions.CheckNotNullOrEmpty(networkInterface, nameof(networkInterface)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Updates the specified access config from an instance's network interface with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="networkInterface">
        /// The name of the network interface where the access config is attached.
        /// </param>
        /// <param name="accessConfigResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAccessConfigAsync(string project, string zone, string instance, string networkInterface, AccessConfig accessConfigResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccessConfigAsync(new UpdateAccessConfigInstanceRequest
            {
                AccessConfigResource = gax::GaxPreconditions.CheckNotNull(accessConfigResource, nameof(accessConfigResource)),
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                NetworkInterface = gax::GaxPreconditions.CheckNotNullOrEmpty(networkInterface, nameof(networkInterface)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Updates the specified access config from an instance's network interface with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="networkInterface">
        /// The name of the network interface where the access config is attached.
        /// </param>
        /// <param name="accessConfigResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAccessConfigAsync(string project, string zone, string instance, string networkInterface, AccessConfig accessConfigResource, st::CancellationToken cancellationToken) =>
            UpdateAccessConfigAsync(project, zone, instance, networkInterface, accessConfigResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Display config for a VM instance. You can only use this method on a stopped VM instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> UpdateDisplayDevice(UpdateDisplayDeviceInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Display config for a VM instance. You can only use this method on a stopped VM instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateDisplayDeviceAsync(UpdateDisplayDeviceInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Display config for a VM instance. You can only use this method on a stopped VM instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateDisplayDeviceAsync(UpdateDisplayDeviceInstanceRequest request, st::CancellationToken cancellationToken) =>
            UpdateDisplayDeviceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDisplayDevice</c>.</summary>
        public virtual lro::OperationsClient UpdateDisplayDeviceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDisplayDevice</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceUpdateDisplayDevice(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDisplayDeviceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDisplayDevice</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceUpdateDisplayDeviceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDisplayDeviceOperationsClient, callSettings);

        /// <summary>
        /// Updates the Display config for a VM instance. You can only use this method on a stopped VM instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="displayDeviceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> UpdateDisplayDevice(string project, string zone, string instance, DisplayDevice displayDeviceResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDisplayDevice(new UpdateDisplayDeviceInstanceRequest
            {
                DisplayDeviceResource = gax::GaxPreconditions.CheckNotNull(displayDeviceResource, nameof(displayDeviceResource)),
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Updates the Display config for a VM instance. You can only use this method on a stopped VM instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="displayDeviceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateDisplayDeviceAsync(string project, string zone, string instance, DisplayDevice displayDeviceResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDisplayDeviceAsync(new UpdateDisplayDeviceInstanceRequest
            {
                DisplayDeviceResource = gax::GaxPreconditions.CheckNotNull(displayDeviceResource, nameof(displayDeviceResource)),
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Updates the Display config for a VM instance. You can only use this method on a stopped VM instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name of the instance scoping this request.
        /// </param>
        /// <param name="displayDeviceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateDisplayDeviceAsync(string project, string zone, string instance, DisplayDevice displayDeviceResource, st::CancellationToken cancellationToken) =>
            UpdateDisplayDeviceAsync(project, zone, instance, displayDeviceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an instance's network interface. This method can only update an interface's alias IP range and attached network. See Modifying alias IP ranges for an existing instance for instructions on changing alias IP ranges. See Migrating a VM between networks for instructions on migrating an interface. This method follows PATCH semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> UpdateNetworkInterface(UpdateNetworkInterfaceInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an instance's network interface. This method can only update an interface's alias IP range and attached network. See Modifying alias IP ranges for an existing instance for instructions on changing alias IP ranges. See Migrating a VM between networks for instructions on migrating an interface. This method follows PATCH semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateNetworkInterfaceAsync(UpdateNetworkInterfaceInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an instance's network interface. This method can only update an interface's alias IP range and attached network. See Modifying alias IP ranges for an existing instance for instructions on changing alias IP ranges. See Migrating a VM between networks for instructions on migrating an interface. This method follows PATCH semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateNetworkInterfaceAsync(UpdateNetworkInterfaceInstanceRequest request, st::CancellationToken cancellationToken) =>
            UpdateNetworkInterfaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateNetworkInterface</c>.</summary>
        public virtual lro::OperationsClient UpdateNetworkInterfaceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateNetworkInterface</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceUpdateNetworkInterface(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateNetworkInterfaceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateNetworkInterface</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceUpdateNetworkInterfaceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateNetworkInterfaceOperationsClient, callSettings);

        /// <summary>
        /// Updates an instance's network interface. This method can only update an interface's alias IP range and attached network. See Modifying alias IP ranges for an existing instance for instructions on changing alias IP ranges. See Migrating a VM between networks for instructions on migrating an interface. This method follows PATCH semantics.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="networkInterface">
        /// The name of the network interface to update.
        /// </param>
        /// <param name="networkInterfaceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> UpdateNetworkInterface(string project, string zone, string instance, string networkInterface, NetworkInterface networkInterfaceResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNetworkInterface(new UpdateNetworkInterfaceInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                NetworkInterface = gax::GaxPreconditions.CheckNotNullOrEmpty(networkInterface, nameof(networkInterface)),
                NetworkInterfaceResource = gax::GaxPreconditions.CheckNotNull(networkInterfaceResource, nameof(networkInterfaceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Updates an instance's network interface. This method can only update an interface's alias IP range and attached network. See Modifying alias IP ranges for an existing instance for instructions on changing alias IP ranges. See Migrating a VM between networks for instructions on migrating an interface. This method follows PATCH semantics.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="networkInterface">
        /// The name of the network interface to update.
        /// </param>
        /// <param name="networkInterfaceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateNetworkInterfaceAsync(string project, string zone, string instance, string networkInterface, NetworkInterface networkInterfaceResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNetworkInterfaceAsync(new UpdateNetworkInterfaceInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                NetworkInterface = gax::GaxPreconditions.CheckNotNullOrEmpty(networkInterface, nameof(networkInterface)),
                NetworkInterfaceResource = gax::GaxPreconditions.CheckNotNull(networkInterfaceResource, nameof(networkInterfaceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Updates an instance's network interface. This method can only update an interface's alias IP range and attached network. See Modifying alias IP ranges for an existing instance for instructions on changing alias IP ranges. See Migrating a VM between networks for instructions on migrating an interface. This method follows PATCH semantics.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// The instance name for this request.
        /// </param>
        /// <param name="networkInterface">
        /// The name of the network interface to update.
        /// </param>
        /// <param name="networkInterfaceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateNetworkInterfaceAsync(string project, string zone, string instance, string networkInterface, NetworkInterface networkInterfaceResource, st::CancellationToken cancellationToken) =>
            UpdateNetworkInterfaceAsync(project, zone, instance, networkInterface, networkInterfaceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Shielded Instance config for an instance. You can only use this method on a stopped instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> UpdateShieldedInstanceConfig(UpdateShieldedInstanceConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Shielded Instance config for an instance. You can only use this method on a stopped instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateShieldedInstanceConfigAsync(UpdateShieldedInstanceConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Shielded Instance config for an instance. You can only use this method on a stopped instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateShieldedInstanceConfigAsync(UpdateShieldedInstanceConfigInstanceRequest request, st::CancellationToken cancellationToken) =>
            UpdateShieldedInstanceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateShieldedInstanceConfig</c>.</summary>
        public virtual lro::OperationsClient UpdateShieldedInstanceConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateShieldedInstanceConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceUpdateShieldedInstanceConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateShieldedInstanceConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateShieldedInstanceConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceUpdateShieldedInstanceConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateShieldedInstanceConfigOperationsClient, callSettings);

        /// <summary>
        /// Updates the Shielded Instance config for an instance. You can only use this method on a stopped instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name or id of the instance scoping this request.
        /// </param>
        /// <param name="shieldedInstanceConfigResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> UpdateShieldedInstanceConfig(string project, string zone, string instance, ShieldedInstanceConfig shieldedInstanceConfigResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateShieldedInstanceConfig(new UpdateShieldedInstanceConfigInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ShieldedInstanceConfigResource = gax::GaxPreconditions.CheckNotNull(shieldedInstanceConfigResource, nameof(shieldedInstanceConfigResource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Updates the Shielded Instance config for an instance. You can only use this method on a stopped instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name or id of the instance scoping this request.
        /// </param>
        /// <param name="shieldedInstanceConfigResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateShieldedInstanceConfigAsync(string project, string zone, string instance, ShieldedInstanceConfig shieldedInstanceConfigResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateShieldedInstanceConfigAsync(new UpdateShieldedInstanceConfigInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ShieldedInstanceConfigResource = gax::GaxPreconditions.CheckNotNull(shieldedInstanceConfigResource, nameof(shieldedInstanceConfigResource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Updates the Shielded Instance config for an instance. You can only use this method on a stopped instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="instance">
        /// Name or id of the instance scoping this request.
        /// </param>
        /// <param name="shieldedInstanceConfigResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateShieldedInstanceConfigAsync(string project, string zone, string instance, ShieldedInstanceConfig shieldedInstanceConfigResource, st::CancellationToken cancellationToken) =>
            UpdateShieldedInstanceConfigAsync(project, zone, instance, shieldedInstanceConfigResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Instances client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Instances API.
    /// </remarks>
    public sealed partial class InstancesClientImpl : InstancesClient
    {
        private readonly gaxgrpc::ApiCall<AddAccessConfigInstanceRequest, Operation> _callAddAccessConfig;

        private readonly gaxgrpc::ApiCall<AddResourcePoliciesInstanceRequest, Operation> _callAddResourcePolicies;

        private readonly gaxgrpc::ApiCall<AggregatedListInstancesRequest, InstanceAggregatedList> _callAggregatedList;

        private readonly gaxgrpc::ApiCall<AttachDiskInstanceRequest, Operation> _callAttachDisk;

        private readonly gaxgrpc::ApiCall<BulkInsertInstanceRequest, Operation> _callBulkInsert;

        private readonly gaxgrpc::ApiCall<DeleteInstanceRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<DeleteAccessConfigInstanceRequest, Operation> _callDeleteAccessConfig;

        private readonly gaxgrpc::ApiCall<DetachDiskInstanceRequest, Operation> _callDetachDisk;

        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGet;

        private readonly gaxgrpc::ApiCall<GetEffectiveFirewallsInstanceRequest, InstancesGetEffectiveFirewallsResponse> _callGetEffectiveFirewalls;

        private readonly gaxgrpc::ApiCall<GetGuestAttributesInstanceRequest, GuestAttributes> _callGetGuestAttributes;

        private readonly gaxgrpc::ApiCall<GetIamPolicyInstanceRequest, Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<GetScreenshotInstanceRequest, Screenshot> _callGetScreenshot;

        private readonly gaxgrpc::ApiCall<GetSerialPortOutputInstanceRequest, SerialPortOutput> _callGetSerialPortOutput;

        private readonly gaxgrpc::ApiCall<GetShieldedInstanceIdentityInstanceRequest, ShieldedInstanceIdentity> _callGetShieldedInstanceIdentity;

        private readonly gaxgrpc::ApiCall<InsertInstanceRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListInstancesRequest, InstanceList> _callList;

        private readonly gaxgrpc::ApiCall<ListReferrersInstancesRequest, InstanceListReferrers> _callListReferrers;

        private readonly gaxgrpc::ApiCall<PerformMaintenanceInstanceRequest, Operation> _callPerformMaintenance;

        private readonly gaxgrpc::ApiCall<RemoveResourcePoliciesInstanceRequest, Operation> _callRemoveResourcePolicies;

        private readonly gaxgrpc::ApiCall<ReportHostAsFaultyInstanceRequest, Operation> _callReportHostAsFaulty;

        private readonly gaxgrpc::ApiCall<ResetInstanceRequest, Operation> _callReset;

        private readonly gaxgrpc::ApiCall<ResumeInstanceRequest, Operation> _callResume;

        private readonly gaxgrpc::ApiCall<SendDiagnosticInterruptInstanceRequest, SendDiagnosticInterruptInstanceResponse> _callSendDiagnosticInterrupt;

        private readonly gaxgrpc::ApiCall<SetDeletionProtectionInstanceRequest, Operation> _callSetDeletionProtection;

        private readonly gaxgrpc::ApiCall<SetDiskAutoDeleteInstanceRequest, Operation> _callSetDiskAutoDelete;

        private readonly gaxgrpc::ApiCall<SetIamPolicyInstanceRequest, Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<SetLabelsInstanceRequest, Operation> _callSetLabels;

        private readonly gaxgrpc::ApiCall<SetMachineResourcesInstanceRequest, Operation> _callSetMachineResources;

        private readonly gaxgrpc::ApiCall<SetMachineTypeInstanceRequest, Operation> _callSetMachineType;

        private readonly gaxgrpc::ApiCall<SetMetadataInstanceRequest, Operation> _callSetMetadata;

        private readonly gaxgrpc::ApiCall<SetMinCpuPlatformInstanceRequest, Operation> _callSetMinCpuPlatform;

        private readonly gaxgrpc::ApiCall<SetNameInstanceRequest, Operation> _callSetName;

        private readonly gaxgrpc::ApiCall<SetSchedulingInstanceRequest, Operation> _callSetScheduling;

        private readonly gaxgrpc::ApiCall<SetSecurityPolicyInstanceRequest, Operation> _callSetSecurityPolicy;

        private readonly gaxgrpc::ApiCall<SetServiceAccountInstanceRequest, Operation> _callSetServiceAccount;

        private readonly gaxgrpc::ApiCall<SetShieldedInstanceIntegrityPolicyInstanceRequest, Operation> _callSetShieldedInstanceIntegrityPolicy;

        private readonly gaxgrpc::ApiCall<SetTagsInstanceRequest, Operation> _callSetTags;

        private readonly gaxgrpc::ApiCall<SimulateMaintenanceEventInstanceRequest, Operation> _callSimulateMaintenanceEvent;

        private readonly gaxgrpc::ApiCall<StartInstanceRequest, Operation> _callStart;

        private readonly gaxgrpc::ApiCall<StartWithEncryptionKeyInstanceRequest, Operation> _callStartWithEncryptionKey;

        private readonly gaxgrpc::ApiCall<StopInstanceRequest, Operation> _callStop;

        private readonly gaxgrpc::ApiCall<SuspendInstanceRequest, Operation> _callSuspend;

        private readonly gaxgrpc::ApiCall<TestIamPermissionsInstanceRequest, TestPermissionsResponse> _callTestIamPermissions;

        private readonly gaxgrpc::ApiCall<UpdateInstanceRequest, Operation> _callUpdate;

        private readonly gaxgrpc::ApiCall<UpdateAccessConfigInstanceRequest, Operation> _callUpdateAccessConfig;

        private readonly gaxgrpc::ApiCall<UpdateDisplayDeviceInstanceRequest, Operation> _callUpdateDisplayDevice;

        private readonly gaxgrpc::ApiCall<UpdateNetworkInterfaceInstanceRequest, Operation> _callUpdateNetworkInterface;

        private readonly gaxgrpc::ApiCall<UpdateShieldedInstanceConfigInstanceRequest, Operation> _callUpdateShieldedInstanceConfig;

        /// <summary>
        /// Constructs a client wrapper for the Instances service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="InstancesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public InstancesClientImpl(Instances.InstancesClient grpcClient, InstancesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            InstancesSettings effectiveSettings = settings ?? InstancesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            AddAccessConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.AddAccessConfigOperationsSettings, logger);
            AddResourcePoliciesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.AddResourcePoliciesOperationsSettings, logger);
            AttachDiskOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.AttachDiskOperationsSettings, logger);
            BulkInsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.BulkInsertOperationsSettings, logger);
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.DeleteOperationsSettings, logger);
            DeleteAccessConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.DeleteAccessConfigOperationsSettings, logger);
            DetachDiskOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.DetachDiskOperationsSettings, logger);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.InsertOperationsSettings, logger);
            PerformMaintenanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.PerformMaintenanceOperationsSettings, logger);
            RemoveResourcePoliciesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.RemoveResourcePoliciesOperationsSettings, logger);
            ReportHostAsFaultyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.ReportHostAsFaultyOperationsSettings, logger);
            ResetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.ResetOperationsSettings, logger);
            ResumeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.ResumeOperationsSettings, logger);
            SetDeletionProtectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.SetDeletionProtectionOperationsSettings, logger);
            SetDiskAutoDeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.SetDiskAutoDeleteOperationsSettings, logger);
            SetLabelsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.SetLabelsOperationsSettings, logger);
            SetMachineResourcesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.SetMachineResourcesOperationsSettings, logger);
            SetMachineTypeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.SetMachineTypeOperationsSettings, logger);
            SetMetadataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.SetMetadataOperationsSettings, logger);
            SetMinCpuPlatformOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.SetMinCpuPlatformOperationsSettings, logger);
            SetNameOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.SetNameOperationsSettings, logger);
            SetSchedulingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.SetSchedulingOperationsSettings, logger);
            SetSecurityPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.SetSecurityPolicyOperationsSettings, logger);
            SetServiceAccountOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.SetServiceAccountOperationsSettings, logger);
            SetShieldedInstanceIntegrityPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.SetShieldedInstanceIntegrityPolicyOperationsSettings, logger);
            SetTagsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.SetTagsOperationsSettings, logger);
            SimulateMaintenanceEventOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.SimulateMaintenanceEventOperationsSettings, logger);
            StartOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.StartOperationsSettings, logger);
            StartWithEncryptionKeyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.StartWithEncryptionKeyOperationsSettings, logger);
            StopOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.StopOperationsSettings, logger);
            SuspendOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.SuspendOperationsSettings, logger);
            UpdateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.UpdateOperationsSettings, logger);
            UpdateAccessConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.UpdateAccessConfigOperationsSettings, logger);
            UpdateDisplayDeviceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.UpdateDisplayDeviceOperationsSettings, logger);
            UpdateNetworkInterfaceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.UpdateNetworkInterfaceOperationsSettings, logger);
            UpdateShieldedInstanceConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.UpdateShieldedInstanceConfigOperationsSettings, logger);
            _callAddAccessConfig = clientHelper.BuildApiCall<AddAccessConfigInstanceRequest, Operation>("AddAccessConfig", grpcClient.AddAccessConfigAsync, grpcClient.AddAccessConfig, effectiveSettings.AddAccessConfigSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callAddAccessConfig);
            Modify_AddAccessConfigApiCall(ref _callAddAccessConfig);
            _callAddResourcePolicies = clientHelper.BuildApiCall<AddResourcePoliciesInstanceRequest, Operation>("AddResourcePolicies", grpcClient.AddResourcePoliciesAsync, grpcClient.AddResourcePolicies, effectiveSettings.AddResourcePoliciesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callAddResourcePolicies);
            Modify_AddResourcePoliciesApiCall(ref _callAddResourcePolicies);
            _callAggregatedList = clientHelper.BuildApiCall<AggregatedListInstancesRequest, InstanceAggregatedList>("AggregatedList", grpcClient.AggregatedListAsync, grpcClient.AggregatedList, effectiveSettings.AggregatedListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callAggregatedList);
            Modify_AggregatedListApiCall(ref _callAggregatedList);
            _callAttachDisk = clientHelper.BuildApiCall<AttachDiskInstanceRequest, Operation>("AttachDisk", grpcClient.AttachDiskAsync, grpcClient.AttachDisk, effectiveSettings.AttachDiskSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callAttachDisk);
            Modify_AttachDiskApiCall(ref _callAttachDisk);
            _callBulkInsert = clientHelper.BuildApiCall<BulkInsertInstanceRequest, Operation>("BulkInsert", grpcClient.BulkInsertAsync, grpcClient.BulkInsert, effectiveSettings.BulkInsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone);
            Modify_ApiCall(ref _callBulkInsert);
            Modify_BulkInsertApiCall(ref _callBulkInsert);
            _callDelete = clientHelper.BuildApiCall<DeleteInstanceRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callDeleteAccessConfig = clientHelper.BuildApiCall<DeleteAccessConfigInstanceRequest, Operation>("DeleteAccessConfig", grpcClient.DeleteAccessConfigAsync, grpcClient.DeleteAccessConfig, effectiveSettings.DeleteAccessConfigSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callDeleteAccessConfig);
            Modify_DeleteAccessConfigApiCall(ref _callDeleteAccessConfig);
            _callDetachDisk = clientHelper.BuildApiCall<DetachDiskInstanceRequest, Operation>("DetachDisk", grpcClient.DetachDiskAsync, grpcClient.DetachDisk, effectiveSettings.DetachDiskSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callDetachDisk);
            Modify_DetachDiskApiCall(ref _callDetachDisk);
            _callGet = clientHelper.BuildApiCall<GetInstanceRequest, Instance>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callGetEffectiveFirewalls = clientHelper.BuildApiCall<GetEffectiveFirewallsInstanceRequest, InstancesGetEffectiveFirewallsResponse>("GetEffectiveFirewalls", grpcClient.GetEffectiveFirewallsAsync, grpcClient.GetEffectiveFirewalls, effectiveSettings.GetEffectiveFirewallsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callGetEffectiveFirewalls);
            Modify_GetEffectiveFirewallsApiCall(ref _callGetEffectiveFirewalls);
            _callGetGuestAttributes = clientHelper.BuildApiCall<GetGuestAttributesInstanceRequest, GuestAttributes>("GetGuestAttributes", grpcClient.GetGuestAttributesAsync, grpcClient.GetGuestAttributes, effectiveSettings.GetGuestAttributesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callGetGuestAttributes);
            Modify_GetGuestAttributesApiCall(ref _callGetGuestAttributes);
            _callGetIamPolicy = clientHelper.BuildApiCall<GetIamPolicyInstanceRequest, Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callGetScreenshot = clientHelper.BuildApiCall<GetScreenshotInstanceRequest, Screenshot>("GetScreenshot", grpcClient.GetScreenshotAsync, grpcClient.GetScreenshot, effectiveSettings.GetScreenshotSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callGetScreenshot);
            Modify_GetScreenshotApiCall(ref _callGetScreenshot);
            _callGetSerialPortOutput = clientHelper.BuildApiCall<GetSerialPortOutputInstanceRequest, SerialPortOutput>("GetSerialPortOutput", grpcClient.GetSerialPortOutputAsync, grpcClient.GetSerialPortOutput, effectiveSettings.GetSerialPortOutputSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callGetSerialPortOutput);
            Modify_GetSerialPortOutputApiCall(ref _callGetSerialPortOutput);
            _callGetShieldedInstanceIdentity = clientHelper.BuildApiCall<GetShieldedInstanceIdentityInstanceRequest, ShieldedInstanceIdentity>("GetShieldedInstanceIdentity", grpcClient.GetShieldedInstanceIdentityAsync, grpcClient.GetShieldedInstanceIdentity, effectiveSettings.GetShieldedInstanceIdentitySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callGetShieldedInstanceIdentity);
            Modify_GetShieldedInstanceIdentityApiCall(ref _callGetShieldedInstanceIdentity);
            _callInsert = clientHelper.BuildApiCall<InsertInstanceRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListInstancesRequest, InstanceList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callListReferrers = clientHelper.BuildApiCall<ListReferrersInstancesRequest, InstanceListReferrers>("ListReferrers", grpcClient.ListReferrersAsync, grpcClient.ListReferrers, effectiveSettings.ListReferrersSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callListReferrers);
            Modify_ListReferrersApiCall(ref _callListReferrers);
            _callPerformMaintenance = clientHelper.BuildApiCall<PerformMaintenanceInstanceRequest, Operation>("PerformMaintenance", grpcClient.PerformMaintenanceAsync, grpcClient.PerformMaintenance, effectiveSettings.PerformMaintenanceSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callPerformMaintenance);
            Modify_PerformMaintenanceApiCall(ref _callPerformMaintenance);
            _callRemoveResourcePolicies = clientHelper.BuildApiCall<RemoveResourcePoliciesInstanceRequest, Operation>("RemoveResourcePolicies", grpcClient.RemoveResourcePoliciesAsync, grpcClient.RemoveResourcePolicies, effectiveSettings.RemoveResourcePoliciesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callRemoveResourcePolicies);
            Modify_RemoveResourcePoliciesApiCall(ref _callRemoveResourcePolicies);
            _callReportHostAsFaulty = clientHelper.BuildApiCall<ReportHostAsFaultyInstanceRequest, Operation>("ReportHostAsFaulty", grpcClient.ReportHostAsFaultyAsync, grpcClient.ReportHostAsFaulty, effectiveSettings.ReportHostAsFaultySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callReportHostAsFaulty);
            Modify_ReportHostAsFaultyApiCall(ref _callReportHostAsFaulty);
            _callReset = clientHelper.BuildApiCall<ResetInstanceRequest, Operation>("Reset", grpcClient.ResetAsync, grpcClient.Reset, effectiveSettings.ResetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callReset);
            Modify_ResetApiCall(ref _callReset);
            _callResume = clientHelper.BuildApiCall<ResumeInstanceRequest, Operation>("Resume", grpcClient.ResumeAsync, grpcClient.Resume, effectiveSettings.ResumeSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callResume);
            Modify_ResumeApiCall(ref _callResume);
            _callSendDiagnosticInterrupt = clientHelper.BuildApiCall<SendDiagnosticInterruptInstanceRequest, SendDiagnosticInterruptInstanceResponse>("SendDiagnosticInterrupt", grpcClient.SendDiagnosticInterruptAsync, grpcClient.SendDiagnosticInterrupt, effectiveSettings.SendDiagnosticInterruptSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSendDiagnosticInterrupt);
            Modify_SendDiagnosticInterruptApiCall(ref _callSendDiagnosticInterrupt);
            _callSetDeletionProtection = clientHelper.BuildApiCall<SetDeletionProtectionInstanceRequest, Operation>("SetDeletionProtection", grpcClient.SetDeletionProtectionAsync, grpcClient.SetDeletionProtection, effectiveSettings.SetDeletionProtectionSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetDeletionProtection);
            Modify_SetDeletionProtectionApiCall(ref _callSetDeletionProtection);
            _callSetDiskAutoDelete = clientHelper.BuildApiCall<SetDiskAutoDeleteInstanceRequest, Operation>("SetDiskAutoDelete", grpcClient.SetDiskAutoDeleteAsync, grpcClient.SetDiskAutoDelete, effectiveSettings.SetDiskAutoDeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetDiskAutoDelete);
            Modify_SetDiskAutoDeleteApiCall(ref _callSetDiskAutoDelete);
            _callSetIamPolicy = clientHelper.BuildApiCall<SetIamPolicyInstanceRequest, Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callSetLabels = clientHelper.BuildApiCall<SetLabelsInstanceRequest, Operation>("SetLabels", grpcClient.SetLabelsAsync, grpcClient.SetLabels, effectiveSettings.SetLabelsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetLabels);
            Modify_SetLabelsApiCall(ref _callSetLabels);
            _callSetMachineResources = clientHelper.BuildApiCall<SetMachineResourcesInstanceRequest, Operation>("SetMachineResources", grpcClient.SetMachineResourcesAsync, grpcClient.SetMachineResources, effectiveSettings.SetMachineResourcesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetMachineResources);
            Modify_SetMachineResourcesApiCall(ref _callSetMachineResources);
            _callSetMachineType = clientHelper.BuildApiCall<SetMachineTypeInstanceRequest, Operation>("SetMachineType", grpcClient.SetMachineTypeAsync, grpcClient.SetMachineType, effectiveSettings.SetMachineTypeSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetMachineType);
            Modify_SetMachineTypeApiCall(ref _callSetMachineType);
            _callSetMetadata = clientHelper.BuildApiCall<SetMetadataInstanceRequest, Operation>("SetMetadata", grpcClient.SetMetadataAsync, grpcClient.SetMetadata, effectiveSettings.SetMetadataSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetMetadata);
            Modify_SetMetadataApiCall(ref _callSetMetadata);
            _callSetMinCpuPlatform = clientHelper.BuildApiCall<SetMinCpuPlatformInstanceRequest, Operation>("SetMinCpuPlatform", grpcClient.SetMinCpuPlatformAsync, grpcClient.SetMinCpuPlatform, effectiveSettings.SetMinCpuPlatformSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetMinCpuPlatform);
            Modify_SetMinCpuPlatformApiCall(ref _callSetMinCpuPlatform);
            _callSetName = clientHelper.BuildApiCall<SetNameInstanceRequest, Operation>("SetName", grpcClient.SetNameAsync, grpcClient.SetName, effectiveSettings.SetNameSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetName);
            Modify_SetNameApiCall(ref _callSetName);
            _callSetScheduling = clientHelper.BuildApiCall<SetSchedulingInstanceRequest, Operation>("SetScheduling", grpcClient.SetSchedulingAsync, grpcClient.SetScheduling, effectiveSettings.SetSchedulingSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetScheduling);
            Modify_SetSchedulingApiCall(ref _callSetScheduling);
            _callSetSecurityPolicy = clientHelper.BuildApiCall<SetSecurityPolicyInstanceRequest, Operation>("SetSecurityPolicy", grpcClient.SetSecurityPolicyAsync, grpcClient.SetSecurityPolicy, effectiveSettings.SetSecurityPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetSecurityPolicy);
            Modify_SetSecurityPolicyApiCall(ref _callSetSecurityPolicy);
            _callSetServiceAccount = clientHelper.BuildApiCall<SetServiceAccountInstanceRequest, Operation>("SetServiceAccount", grpcClient.SetServiceAccountAsync, grpcClient.SetServiceAccount, effectiveSettings.SetServiceAccountSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetServiceAccount);
            Modify_SetServiceAccountApiCall(ref _callSetServiceAccount);
            _callSetShieldedInstanceIntegrityPolicy = clientHelper.BuildApiCall<SetShieldedInstanceIntegrityPolicyInstanceRequest, Operation>("SetShieldedInstanceIntegrityPolicy", grpcClient.SetShieldedInstanceIntegrityPolicyAsync, grpcClient.SetShieldedInstanceIntegrityPolicy, effectiveSettings.SetShieldedInstanceIntegrityPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetShieldedInstanceIntegrityPolicy);
            Modify_SetShieldedInstanceIntegrityPolicyApiCall(ref _callSetShieldedInstanceIntegrityPolicy);
            _callSetTags = clientHelper.BuildApiCall<SetTagsInstanceRequest, Operation>("SetTags", grpcClient.SetTagsAsync, grpcClient.SetTags, effectiveSettings.SetTagsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetTags);
            Modify_SetTagsApiCall(ref _callSetTags);
            _callSimulateMaintenanceEvent = clientHelper.BuildApiCall<SimulateMaintenanceEventInstanceRequest, Operation>("SimulateMaintenanceEvent", grpcClient.SimulateMaintenanceEventAsync, grpcClient.SimulateMaintenanceEvent, effectiveSettings.SimulateMaintenanceEventSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSimulateMaintenanceEvent);
            Modify_SimulateMaintenanceEventApiCall(ref _callSimulateMaintenanceEvent);
            _callStart = clientHelper.BuildApiCall<StartInstanceRequest, Operation>("Start", grpcClient.StartAsync, grpcClient.Start, effectiveSettings.StartSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callStart);
            Modify_StartApiCall(ref _callStart);
            _callStartWithEncryptionKey = clientHelper.BuildApiCall<StartWithEncryptionKeyInstanceRequest, Operation>("StartWithEncryptionKey", grpcClient.StartWithEncryptionKeyAsync, grpcClient.StartWithEncryptionKey, effectiveSettings.StartWithEncryptionKeySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callStartWithEncryptionKey);
            Modify_StartWithEncryptionKeyApiCall(ref _callStartWithEncryptionKey);
            _callStop = clientHelper.BuildApiCall<StopInstanceRequest, Operation>("Stop", grpcClient.StopAsync, grpcClient.Stop, effectiveSettings.StopSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callStop);
            Modify_StopApiCall(ref _callStop);
            _callSuspend = clientHelper.BuildApiCall<SuspendInstanceRequest, Operation>("Suspend", grpcClient.SuspendAsync, grpcClient.Suspend, effectiveSettings.SuspendSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSuspend);
            Modify_SuspendApiCall(ref _callSuspend);
            _callTestIamPermissions = clientHelper.BuildApiCall<TestIamPermissionsInstanceRequest, TestPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            _callUpdate = clientHelper.BuildApiCall<UpdateInstanceRequest, Operation>("Update", grpcClient.UpdateAsync, grpcClient.Update, effectiveSettings.UpdateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callUpdate);
            Modify_UpdateApiCall(ref _callUpdate);
            _callUpdateAccessConfig = clientHelper.BuildApiCall<UpdateAccessConfigInstanceRequest, Operation>("UpdateAccessConfig", grpcClient.UpdateAccessConfigAsync, grpcClient.UpdateAccessConfig, effectiveSettings.UpdateAccessConfigSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callUpdateAccessConfig);
            Modify_UpdateAccessConfigApiCall(ref _callUpdateAccessConfig);
            _callUpdateDisplayDevice = clientHelper.BuildApiCall<UpdateDisplayDeviceInstanceRequest, Operation>("UpdateDisplayDevice", grpcClient.UpdateDisplayDeviceAsync, grpcClient.UpdateDisplayDevice, effectiveSettings.UpdateDisplayDeviceSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callUpdateDisplayDevice);
            Modify_UpdateDisplayDeviceApiCall(ref _callUpdateDisplayDevice);
            _callUpdateNetworkInterface = clientHelper.BuildApiCall<UpdateNetworkInterfaceInstanceRequest, Operation>("UpdateNetworkInterface", grpcClient.UpdateNetworkInterfaceAsync, grpcClient.UpdateNetworkInterface, effectiveSettings.UpdateNetworkInterfaceSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callUpdateNetworkInterface);
            Modify_UpdateNetworkInterfaceApiCall(ref _callUpdateNetworkInterface);
            _callUpdateShieldedInstanceConfig = clientHelper.BuildApiCall<UpdateShieldedInstanceConfigInstanceRequest, Operation>("UpdateShieldedInstanceConfig", grpcClient.UpdateShieldedInstanceConfigAsync, grpcClient.UpdateShieldedInstanceConfig, effectiveSettings.UpdateShieldedInstanceConfigSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callUpdateShieldedInstanceConfig);
            Modify_UpdateShieldedInstanceConfigApiCall(ref _callUpdateShieldedInstanceConfig);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AddAccessConfigApiCall(ref gaxgrpc::ApiCall<AddAccessConfigInstanceRequest, Operation> call);

        partial void Modify_AddResourcePoliciesApiCall(ref gaxgrpc::ApiCall<AddResourcePoliciesInstanceRequest, Operation> call);

        partial void Modify_AggregatedListApiCall(ref gaxgrpc::ApiCall<AggregatedListInstancesRequest, InstanceAggregatedList> call);

        partial void Modify_AttachDiskApiCall(ref gaxgrpc::ApiCall<AttachDiskInstanceRequest, Operation> call);

        partial void Modify_BulkInsertApiCall(ref gaxgrpc::ApiCall<BulkInsertInstanceRequest, Operation> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteInstanceRequest, Operation> call);

        partial void Modify_DeleteAccessConfigApiCall(ref gaxgrpc::ApiCall<DeleteAccessConfigInstanceRequest, Operation> call);

        partial void Modify_DetachDiskApiCall(ref gaxgrpc::ApiCall<DetachDiskInstanceRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);

        partial void Modify_GetEffectiveFirewallsApiCall(ref gaxgrpc::ApiCall<GetEffectiveFirewallsInstanceRequest, InstancesGetEffectiveFirewallsResponse> call);

        partial void Modify_GetGuestAttributesApiCall(ref gaxgrpc::ApiCall<GetGuestAttributesInstanceRequest, GuestAttributes> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<GetIamPolicyInstanceRequest, Policy> call);

        partial void Modify_GetScreenshotApiCall(ref gaxgrpc::ApiCall<GetScreenshotInstanceRequest, Screenshot> call);

        partial void Modify_GetSerialPortOutputApiCall(ref gaxgrpc::ApiCall<GetSerialPortOutputInstanceRequest, SerialPortOutput> call);

        partial void Modify_GetShieldedInstanceIdentityApiCall(ref gaxgrpc::ApiCall<GetShieldedInstanceIdentityInstanceRequest, ShieldedInstanceIdentity> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertInstanceRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, InstanceList> call);

        partial void Modify_ListReferrersApiCall(ref gaxgrpc::ApiCall<ListReferrersInstancesRequest, InstanceListReferrers> call);

        partial void Modify_PerformMaintenanceApiCall(ref gaxgrpc::ApiCall<PerformMaintenanceInstanceRequest, Operation> call);

        partial void Modify_RemoveResourcePoliciesApiCall(ref gaxgrpc::ApiCall<RemoveResourcePoliciesInstanceRequest, Operation> call);

        partial void Modify_ReportHostAsFaultyApiCall(ref gaxgrpc::ApiCall<ReportHostAsFaultyInstanceRequest, Operation> call);

        partial void Modify_ResetApiCall(ref gaxgrpc::ApiCall<ResetInstanceRequest, Operation> call);

        partial void Modify_ResumeApiCall(ref gaxgrpc::ApiCall<ResumeInstanceRequest, Operation> call);

        partial void Modify_SendDiagnosticInterruptApiCall(ref gaxgrpc::ApiCall<SendDiagnosticInterruptInstanceRequest, SendDiagnosticInterruptInstanceResponse> call);

        partial void Modify_SetDeletionProtectionApiCall(ref gaxgrpc::ApiCall<SetDeletionProtectionInstanceRequest, Operation> call);

        partial void Modify_SetDiskAutoDeleteApiCall(ref gaxgrpc::ApiCall<SetDiskAutoDeleteInstanceRequest, Operation> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<SetIamPolicyInstanceRequest, Policy> call);

        partial void Modify_SetLabelsApiCall(ref gaxgrpc::ApiCall<SetLabelsInstanceRequest, Operation> call);

        partial void Modify_SetMachineResourcesApiCall(ref gaxgrpc::ApiCall<SetMachineResourcesInstanceRequest, Operation> call);

        partial void Modify_SetMachineTypeApiCall(ref gaxgrpc::ApiCall<SetMachineTypeInstanceRequest, Operation> call);

        partial void Modify_SetMetadataApiCall(ref gaxgrpc::ApiCall<SetMetadataInstanceRequest, Operation> call);

        partial void Modify_SetMinCpuPlatformApiCall(ref gaxgrpc::ApiCall<SetMinCpuPlatformInstanceRequest, Operation> call);

        partial void Modify_SetNameApiCall(ref gaxgrpc::ApiCall<SetNameInstanceRequest, Operation> call);

        partial void Modify_SetSchedulingApiCall(ref gaxgrpc::ApiCall<SetSchedulingInstanceRequest, Operation> call);

        partial void Modify_SetSecurityPolicyApiCall(ref gaxgrpc::ApiCall<SetSecurityPolicyInstanceRequest, Operation> call);

        partial void Modify_SetServiceAccountApiCall(ref gaxgrpc::ApiCall<SetServiceAccountInstanceRequest, Operation> call);

        partial void Modify_SetShieldedInstanceIntegrityPolicyApiCall(ref gaxgrpc::ApiCall<SetShieldedInstanceIntegrityPolicyInstanceRequest, Operation> call);

        partial void Modify_SetTagsApiCall(ref gaxgrpc::ApiCall<SetTagsInstanceRequest, Operation> call);

        partial void Modify_SimulateMaintenanceEventApiCall(ref gaxgrpc::ApiCall<SimulateMaintenanceEventInstanceRequest, Operation> call);

        partial void Modify_StartApiCall(ref gaxgrpc::ApiCall<StartInstanceRequest, Operation> call);

        partial void Modify_StartWithEncryptionKeyApiCall(ref gaxgrpc::ApiCall<StartWithEncryptionKeyInstanceRequest, Operation> call);

        partial void Modify_StopApiCall(ref gaxgrpc::ApiCall<StopInstanceRequest, Operation> call);

        partial void Modify_SuspendApiCall(ref gaxgrpc::ApiCall<SuspendInstanceRequest, Operation> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<TestIamPermissionsInstanceRequest, TestPermissionsResponse> call);

        partial void Modify_UpdateApiCall(ref gaxgrpc::ApiCall<UpdateInstanceRequest, Operation> call);

        partial void Modify_UpdateAccessConfigApiCall(ref gaxgrpc::ApiCall<UpdateAccessConfigInstanceRequest, Operation> call);

        partial void Modify_UpdateDisplayDeviceApiCall(ref gaxgrpc::ApiCall<UpdateDisplayDeviceInstanceRequest, Operation> call);

        partial void Modify_UpdateNetworkInterfaceApiCall(ref gaxgrpc::ApiCall<UpdateNetworkInterfaceInstanceRequest, Operation> call);

        partial void Modify_UpdateShieldedInstanceConfigApiCall(ref gaxgrpc::ApiCall<UpdateShieldedInstanceConfigInstanceRequest, Operation> call);

        partial void OnConstruction(Instances.InstancesClient grpcClient, InstancesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Instances client</summary>
        public override Instances.InstancesClient GrpcClient { get; }

        partial void Modify_AddAccessConfigInstanceRequest(ref AddAccessConfigInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddResourcePoliciesInstanceRequest(ref AddResourcePoliciesInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AggregatedListInstancesRequest(ref AggregatedListInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AttachDiskInstanceRequest(ref AttachDiskInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BulkInsertInstanceRequest(ref BulkInsertInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAccessConfigInstanceRequest(ref DeleteAccessConfigInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DetachDiskInstanceRequest(ref DetachDiskInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEffectiveFirewallsInstanceRequest(ref GetEffectiveFirewallsInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGuestAttributesInstanceRequest(ref GetGuestAttributesInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyInstanceRequest(ref GetIamPolicyInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetScreenshotInstanceRequest(ref GetScreenshotInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSerialPortOutputInstanceRequest(ref GetSerialPortOutputInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetShieldedInstanceIdentityInstanceRequest(ref GetShieldedInstanceIdentityInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertInstanceRequest(ref InsertInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReferrersInstancesRequest(ref ListReferrersInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PerformMaintenanceInstanceRequest(ref PerformMaintenanceInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveResourcePoliciesInstanceRequest(ref RemoveResourcePoliciesInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReportHostAsFaultyInstanceRequest(ref ReportHostAsFaultyInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResetInstanceRequest(ref ResetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResumeInstanceRequest(ref ResumeInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SendDiagnosticInterruptInstanceRequest(ref SendDiagnosticInterruptInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetDeletionProtectionInstanceRequest(ref SetDeletionProtectionInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetDiskAutoDeleteInstanceRequest(ref SetDiskAutoDeleteInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyInstanceRequest(ref SetIamPolicyInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetLabelsInstanceRequest(ref SetLabelsInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetMachineResourcesInstanceRequest(ref SetMachineResourcesInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetMachineTypeInstanceRequest(ref SetMachineTypeInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetMetadataInstanceRequest(ref SetMetadataInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetMinCpuPlatformInstanceRequest(ref SetMinCpuPlatformInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetNameInstanceRequest(ref SetNameInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetSchedulingInstanceRequest(ref SetSchedulingInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetSecurityPolicyInstanceRequest(ref SetSecurityPolicyInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetServiceAccountInstanceRequest(ref SetServiceAccountInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetShieldedInstanceIntegrityPolicyInstanceRequest(ref SetShieldedInstanceIntegrityPolicyInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetTagsInstanceRequest(ref SetTagsInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SimulateMaintenanceEventInstanceRequest(ref SimulateMaintenanceEventInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartInstanceRequest(ref StartInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartWithEncryptionKeyInstanceRequest(ref StartWithEncryptionKeyInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopInstanceRequest(ref StopInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SuspendInstanceRequest(ref SuspendInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsInstanceRequest(ref TestIamPermissionsInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInstanceRequest(ref UpdateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAccessConfigInstanceRequest(ref UpdateAccessConfigInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDisplayDeviceInstanceRequest(ref UpdateDisplayDeviceInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateNetworkInterfaceInstanceRequest(ref UpdateNetworkInterfaceInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateShieldedInstanceConfigInstanceRequest(ref UpdateShieldedInstanceConfigInstanceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>AddAccessConfig</c>.</summary>
        public override lro::OperationsClient AddAccessConfigOperationsClient { get; }

        /// <summary>
        /// Adds an access config to an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> AddAccessConfig(AddAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddAccessConfigInstanceRequest(ref request, ref callSettings);
            Operation response = _callAddAccessConfig.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddAccessConfigOperationsClient);
        }

        /// <summary>
        /// Adds an access config to an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> AddAccessConfigAsync(AddAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddAccessConfigInstanceRequest(ref request, ref callSettings);
            Operation response = await _callAddAccessConfig.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddAccessConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>AddResourcePolicies</c>.</summary>
        public override lro::OperationsClient AddResourcePoliciesOperationsClient { get; }

        /// <summary>
        /// Adds existing resource policies to an instance. You can only add one policy right now which will be applied to this instance for scheduling live migrations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> AddResourcePolicies(AddResourcePoliciesInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddResourcePoliciesInstanceRequest(ref request, ref callSettings);
            Operation response = _callAddResourcePolicies.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddResourcePoliciesOperationsClient);
        }

        /// <summary>
        /// Adds existing resource policies to an instance. You can only add one policy right now which will be applied to this instance for scheduling live migrations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> AddResourcePoliciesAsync(AddResourcePoliciesInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddResourcePoliciesInstanceRequest(ref request, ref callSettings);
            Operation response = await _callAddResourcePolicies.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddResourcePoliciesOperationsClient);
        }

        /// <summary>
        /// Retrieves an aggregated list of all of the instances in your project across all regions and zones. The performance of this method degrades when a filter is specified on a project that has a very large number of instances. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public override gax::PagedEnumerable<InstanceAggregatedList, scg::KeyValuePair<string, InstancesScopedList>> AggregatedList(AggregatedListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<AggregatedListInstancesRequest, InstanceAggregatedList, scg::KeyValuePair<string, InstancesScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Retrieves an aggregated list of all of the instances in your project across all regions and zones. The performance of this method degrades when a filter is specified on a project that has a very large number of instances. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<InstanceAggregatedList, scg::KeyValuePair<string, InstancesScopedList>> AggregatedListAsync(AggregatedListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<AggregatedListInstancesRequest, InstanceAggregatedList, scg::KeyValuePair<string, InstancesScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>AttachDisk</c>.</summary>
        public override lro::OperationsClient AttachDiskOperationsClient { get; }

        /// <summary>
        /// Attaches an existing Disk resource to an instance. You must first create the disk before you can attach it. It is not possible to create and attach a disk at the same time. For more information, read Adding a persistent disk to your instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> AttachDisk(AttachDiskInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AttachDiskInstanceRequest(ref request, ref callSettings);
            Operation response = _callAttachDisk.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AttachDiskOperationsClient);
        }

        /// <summary>
        /// Attaches an existing Disk resource to an instance. You must first create the disk before you can attach it. It is not possible to create and attach a disk at the same time. For more information, read Adding a persistent disk to your instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> AttachDiskAsync(AttachDiskInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AttachDiskInstanceRequest(ref request, ref callSettings);
            Operation response = await _callAttachDisk.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AttachDiskOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BulkInsert</c>.</summary>
        public override lro::OperationsClient BulkInsertOperationsClient { get; }

        /// <summary>
        /// Creates multiple instances. Count specifies the number of instances to create. For more information, see About bulk creation of VMs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> BulkInsert(BulkInsertInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkInsertInstanceRequest(ref request, ref callSettings);
            Operation response = _callBulkInsert.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), BulkInsertOperationsClient);
        }

        /// <summary>
        /// Creates multiple instances. Count specifies the number of instances to create. For more information, see About bulk creation of VMs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> BulkInsertAsync(BulkInsertInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkInsertInstanceRequest(ref request, ref callSettings);
            Operation response = await _callBulkInsert.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), BulkInsertOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Deletes the specified Instance resource. For more information, see Deleting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Deletes the specified Instance resource. For more information, see Deleting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAccessConfig</c>.</summary>
        public override lro::OperationsClient DeleteAccessConfigOperationsClient { get; }

        /// <summary>
        /// Deletes an access config from an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> DeleteAccessConfig(DeleteAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAccessConfigInstanceRequest(ref request, ref callSettings);
            Operation response = _callDeleteAccessConfig.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteAccessConfigOperationsClient);
        }

        /// <summary>
        /// Deletes an access config from an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAccessConfigAsync(DeleteAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAccessConfigInstanceRequest(ref request, ref callSettings);
            Operation response = await _callDeleteAccessConfig.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteAccessConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DetachDisk</c>.</summary>
        public override lro::OperationsClient DetachDiskOperationsClient { get; }

        /// <summary>
        /// Detaches a disk from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> DetachDisk(DetachDiskInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetachDiskInstanceRequest(ref request, ref callSettings);
            Operation response = _callDetachDisk.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DetachDiskOperationsClient);
        }

        /// <summary>
        /// Detaches a disk from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DetachDiskAsync(DetachDiskInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetachDiskInstanceRequest(ref request, ref callSettings);
            Operation response = await _callDetachDisk.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DetachDiskOperationsClient);
        }

        /// <summary>
        /// Returns the specified Instance resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Instance Get(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified Instance resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Instance> GetAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Returns effective firewalls applied to an interface of the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InstancesGetEffectiveFirewallsResponse GetEffectiveFirewalls(GetEffectiveFirewallsInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEffectiveFirewallsInstanceRequest(ref request, ref callSettings);
            return _callGetEffectiveFirewalls.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns effective firewalls applied to an interface of the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InstancesGetEffectiveFirewallsResponse> GetEffectiveFirewallsAsync(GetEffectiveFirewallsInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEffectiveFirewallsInstanceRequest(ref request, ref callSettings);
            return _callGetEffectiveFirewalls.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the specified guest attributes entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GuestAttributes GetGuestAttributes(GetGuestAttributesInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGuestAttributesInstanceRequest(ref request, ref callSettings);
            return _callGetGuestAttributes.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified guest attributes entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GuestAttributes> GetGuestAttributesAsync(GetGuestAttributesInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGuestAttributesInstanceRequest(ref request, ref callSettings);
            return _callGetGuestAttributes.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy GetIamPolicy(GetIamPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyInstanceRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyInstanceRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the screenshot from the specified instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Screenshot GetScreenshot(GetScreenshotInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScreenshotInstanceRequest(ref request, ref callSettings);
            return _callGetScreenshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the screenshot from the specified instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Screenshot> GetScreenshotAsync(GetScreenshotInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScreenshotInstanceRequest(ref request, ref callSettings);
            return _callGetScreenshot.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the last 1 MB of serial port output from the specified instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SerialPortOutput GetSerialPortOutput(GetSerialPortOutputInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSerialPortOutputInstanceRequest(ref request, ref callSettings);
            return _callGetSerialPortOutput.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the last 1 MB of serial port output from the specified instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SerialPortOutput> GetSerialPortOutputAsync(GetSerialPortOutputInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSerialPortOutputInstanceRequest(ref request, ref callSettings);
            return _callGetSerialPortOutput.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the Shielded Instance Identity of an instance
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ShieldedInstanceIdentity GetShieldedInstanceIdentity(GetShieldedInstanceIdentityInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetShieldedInstanceIdentityInstanceRequest(ref request, ref callSettings);
            return _callGetShieldedInstanceIdentity.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the Shielded Instance Identity of an instance
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ShieldedInstanceIdentity> GetShieldedInstanceIdentityAsync(GetShieldedInstanceIdentityInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetShieldedInstanceIdentityInstanceRequest(ref request, ref callSettings);
            return _callGetShieldedInstanceIdentity.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Creates an instance resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertInstanceRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Creates an instance resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertInstanceRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Retrieves the list of instances contained within the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedEnumerable<InstanceList, Instance> List(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstancesRequest, InstanceList, Instance>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of instances contained within the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<InstanceList, Instance> ListAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstancesRequest, InstanceList, Instance>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of resources that refer to the VM instance specified in the request. For example, if the VM instance is part of a managed or unmanaged instance group, the referrers list includes the instance group. For more information, read Viewing referrers to VM instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Reference"/> resources.</returns>
        public override gax::PagedEnumerable<InstanceListReferrers, Reference> ListReferrers(ListReferrersInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReferrersInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReferrersInstancesRequest, InstanceListReferrers, Reference>(_callListReferrers, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of resources that refer to the VM instance specified in the request. For example, if the VM instance is part of a managed or unmanaged instance group, the referrers list includes the instance group. For more information, read Viewing referrers to VM instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Reference"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<InstanceListReferrers, Reference> ListReferrersAsync(ListReferrersInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReferrersInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReferrersInstancesRequest, InstanceListReferrers, Reference>(_callListReferrers, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>PerformMaintenance</c>.</summary>
        public override lro::OperationsClient PerformMaintenanceOperationsClient { get; }

        /// <summary>
        /// Perform a manual maintenance on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> PerformMaintenance(PerformMaintenanceInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PerformMaintenanceInstanceRequest(ref request, ref callSettings);
            Operation response = _callPerformMaintenance.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PerformMaintenanceOperationsClient);
        }

        /// <summary>
        /// Perform a manual maintenance on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> PerformMaintenanceAsync(PerformMaintenanceInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PerformMaintenanceInstanceRequest(ref request, ref callSettings);
            Operation response = await _callPerformMaintenance.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PerformMaintenanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RemoveResourcePolicies</c>.</summary>
        public override lro::OperationsClient RemoveResourcePoliciesOperationsClient { get; }

        /// <summary>
        /// Removes resource policies from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> RemoveResourcePolicies(RemoveResourcePoliciesInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveResourcePoliciesInstanceRequest(ref request, ref callSettings);
            Operation response = _callRemoveResourcePolicies.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveResourcePoliciesOperationsClient);
        }

        /// <summary>
        /// Removes resource policies from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> RemoveResourcePoliciesAsync(RemoveResourcePoliciesInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveResourcePoliciesInstanceRequest(ref request, ref callSettings);
            Operation response = await _callRemoveResourcePolicies.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveResourcePoliciesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ReportHostAsFaulty</c>.</summary>
        public override lro::OperationsClient ReportHostAsFaultyOperationsClient { get; }

        /// <summary>
        /// Mark the host as faulty and try to restart the instance on a new host.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> ReportHostAsFaulty(ReportHostAsFaultyInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportHostAsFaultyInstanceRequest(ref request, ref callSettings);
            Operation response = _callReportHostAsFaulty.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), ReportHostAsFaultyOperationsClient);
        }

        /// <summary>
        /// Mark the host as faulty and try to restart the instance on a new host.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> ReportHostAsFaultyAsync(ReportHostAsFaultyInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportHostAsFaultyInstanceRequest(ref request, ref callSettings);
            Operation response = await _callReportHostAsFaulty.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), ReportHostAsFaultyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Reset</c>.</summary>
        public override lro::OperationsClient ResetOperationsClient { get; }

        /// <summary>
        /// Performs a reset on the instance. This is a hard reset. The VM does not do a graceful shutdown. For more information, see Resetting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Reset(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetInstanceRequest(ref request, ref callSettings);
            Operation response = _callReset.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), ResetOperationsClient);
        }

        /// <summary>
        /// Performs a reset on the instance. This is a hard reset. The VM does not do a graceful shutdown. For more information, see Resetting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> ResetAsync(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetInstanceRequest(ref request, ref callSettings);
            Operation response = await _callReset.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), ResetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Resume</c>.</summary>
        public override lro::OperationsClient ResumeOperationsClient { get; }

        /// <summary>
        /// Resumes an instance that was suspended using the instances().suspend method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Resume(ResumeInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeInstanceRequest(ref request, ref callSettings);
            Operation response = _callResume.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), ResumeOperationsClient);
        }

        /// <summary>
        /// Resumes an instance that was suspended using the instances().suspend method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> ResumeAsync(ResumeInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeInstanceRequest(ref request, ref callSettings);
            Operation response = await _callResume.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), ResumeOperationsClient);
        }

        /// <summary>
        /// Sends diagnostic interrupt to the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SendDiagnosticInterruptInstanceResponse SendDiagnosticInterrupt(SendDiagnosticInterruptInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SendDiagnosticInterruptInstanceRequest(ref request, ref callSettings);
            return _callSendDiagnosticInterrupt.Sync(request, callSettings);
        }

        /// <summary>
        /// Sends diagnostic interrupt to the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SendDiagnosticInterruptInstanceResponse> SendDiagnosticInterruptAsync(SendDiagnosticInterruptInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SendDiagnosticInterruptInstanceRequest(ref request, ref callSettings);
            return _callSendDiagnosticInterrupt.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>SetDeletionProtection</c>.</summary>
        public override lro::OperationsClient SetDeletionProtectionOperationsClient { get; }

        /// <summary>
        /// Sets deletion protection on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetDeletionProtection(SetDeletionProtectionInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDeletionProtectionInstanceRequest(ref request, ref callSettings);
            Operation response = _callSetDeletionProtection.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetDeletionProtectionOperationsClient);
        }

        /// <summary>
        /// Sets deletion protection on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetDeletionProtectionAsync(SetDeletionProtectionInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDeletionProtectionInstanceRequest(ref request, ref callSettings);
            Operation response = await _callSetDeletionProtection.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetDeletionProtectionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetDiskAutoDelete</c>.</summary>
        public override lro::OperationsClient SetDiskAutoDeleteOperationsClient { get; }

        /// <summary>
        /// Sets the auto-delete flag for a disk attached to an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetDiskAutoDelete(SetDiskAutoDeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDiskAutoDeleteInstanceRequest(ref request, ref callSettings);
            Operation response = _callSetDiskAutoDelete.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetDiskAutoDeleteOperationsClient);
        }

        /// <summary>
        /// Sets the auto-delete flag for a disk attached to an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetDiskAutoDeleteAsync(SetDiskAutoDeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDiskAutoDeleteInstanceRequest(ref request, ref callSettings);
            Operation response = await _callSetDiskAutoDelete.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetDiskAutoDeleteOperationsClient);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy SetIamPolicy(SetIamPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyInstanceRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyInstanceRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>SetLabels</c>.</summary>
        public override lro::OperationsClient SetLabelsOperationsClient { get; }

        /// <summary>
        /// Sets labels on an instance. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetLabels(SetLabelsInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetLabelsInstanceRequest(ref request, ref callSettings);
            Operation response = _callSetLabels.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetLabelsOperationsClient);
        }

        /// <summary>
        /// Sets labels on an instance. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(SetLabelsInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetLabelsInstanceRequest(ref request, ref callSettings);
            Operation response = await _callSetLabels.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetLabelsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetMachineResources</c>.</summary>
        public override lro::OperationsClient SetMachineResourcesOperationsClient { get; }

        /// <summary>
        /// Changes the number and/or type of accelerator for a stopped instance to the values specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetMachineResources(SetMachineResourcesInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMachineResourcesInstanceRequest(ref request, ref callSettings);
            Operation response = _callSetMachineResources.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetMachineResourcesOperationsClient);
        }

        /// <summary>
        /// Changes the number and/or type of accelerator for a stopped instance to the values specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetMachineResourcesAsync(SetMachineResourcesInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMachineResourcesInstanceRequest(ref request, ref callSettings);
            Operation response = await _callSetMachineResources.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetMachineResourcesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetMachineType</c>.</summary>
        public override lro::OperationsClient SetMachineTypeOperationsClient { get; }

        /// <summary>
        /// Changes the machine type for a stopped instance to the machine type specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetMachineType(SetMachineTypeInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMachineTypeInstanceRequest(ref request, ref callSettings);
            Operation response = _callSetMachineType.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetMachineTypeOperationsClient);
        }

        /// <summary>
        /// Changes the machine type for a stopped instance to the machine type specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetMachineTypeAsync(SetMachineTypeInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMachineTypeInstanceRequest(ref request, ref callSettings);
            Operation response = await _callSetMachineType.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetMachineTypeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetMetadata</c>.</summary>
        public override lro::OperationsClient SetMetadataOperationsClient { get; }

        /// <summary>
        /// Sets metadata for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetMetadata(SetMetadataInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMetadataInstanceRequest(ref request, ref callSettings);
            Operation response = _callSetMetadata.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetMetadataOperationsClient);
        }

        /// <summary>
        /// Sets metadata for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetMetadataAsync(SetMetadataInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMetadataInstanceRequest(ref request, ref callSettings);
            Operation response = await _callSetMetadata.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetMetadataOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetMinCpuPlatform</c>.</summary>
        public override lro::OperationsClient SetMinCpuPlatformOperationsClient { get; }

        /// <summary>
        /// Changes the minimum CPU platform that this instance should use. This method can only be called on a stopped instance. For more information, read Specifying a Minimum CPU Platform.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetMinCpuPlatform(SetMinCpuPlatformInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMinCpuPlatformInstanceRequest(ref request, ref callSettings);
            Operation response = _callSetMinCpuPlatform.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetMinCpuPlatformOperationsClient);
        }

        /// <summary>
        /// Changes the minimum CPU platform that this instance should use. This method can only be called on a stopped instance. For more information, read Specifying a Minimum CPU Platform.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetMinCpuPlatformAsync(SetMinCpuPlatformInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMinCpuPlatformInstanceRequest(ref request, ref callSettings);
            Operation response = await _callSetMinCpuPlatform.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetMinCpuPlatformOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetName</c>.</summary>
        public override lro::OperationsClient SetNameOperationsClient { get; }

        /// <summary>
        /// Sets name of an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetName(SetNameInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetNameInstanceRequest(ref request, ref callSettings);
            Operation response = _callSetName.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetNameOperationsClient);
        }

        /// <summary>
        /// Sets name of an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetNameAsync(SetNameInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetNameInstanceRequest(ref request, ref callSettings);
            Operation response = await _callSetName.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetNameOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetScheduling</c>.</summary>
        public override lro::OperationsClient SetSchedulingOperationsClient { get; }

        /// <summary>
        /// Sets an instance's scheduling options. You can only call this method on a stopped instance, that is, a VM instance that is in a `TERMINATED` state. See Instance Life Cycle for more information on the possible instance states. For more information about setting scheduling options for a VM, see Set VM host maintenance policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetScheduling(SetSchedulingInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSchedulingInstanceRequest(ref request, ref callSettings);
            Operation response = _callSetScheduling.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetSchedulingOperationsClient);
        }

        /// <summary>
        /// Sets an instance's scheduling options. You can only call this method on a stopped instance, that is, a VM instance that is in a `TERMINATED` state. See Instance Life Cycle for more information on the possible instance states. For more information about setting scheduling options for a VM, see Set VM host maintenance policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetSchedulingAsync(SetSchedulingInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSchedulingInstanceRequest(ref request, ref callSettings);
            Operation response = await _callSetScheduling.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetSchedulingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetSecurityPolicy</c>.</summary>
        public override lro::OperationsClient SetSecurityPolicyOperationsClient { get; }

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified instance. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetSecurityPolicy(SetSecurityPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSecurityPolicyInstanceRequest(ref request, ref callSettings);
            Operation response = _callSetSecurityPolicy.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetSecurityPolicyOperationsClient);
        }

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified instance. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetSecurityPolicyAsync(SetSecurityPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSecurityPolicyInstanceRequest(ref request, ref callSettings);
            Operation response = await _callSetSecurityPolicy.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetSecurityPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetServiceAccount</c>.</summary>
        public override lro::OperationsClient SetServiceAccountOperationsClient { get; }

        /// <summary>
        /// Sets the service account on the instance. For more information, read Changing the service account and access scopes for an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetServiceAccount(SetServiceAccountInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetServiceAccountInstanceRequest(ref request, ref callSettings);
            Operation response = _callSetServiceAccount.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetServiceAccountOperationsClient);
        }

        /// <summary>
        /// Sets the service account on the instance. For more information, read Changing the service account and access scopes for an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetServiceAccountAsync(SetServiceAccountInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetServiceAccountInstanceRequest(ref request, ref callSettings);
            Operation response = await _callSetServiceAccount.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetServiceAccountOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetShieldedInstanceIntegrityPolicy</c>.</summary>
        public override lro::OperationsClient SetShieldedInstanceIntegrityPolicyOperationsClient { get; }

        /// <summary>
        /// Sets the Shielded Instance integrity policy for an instance. You can only use this method on a running instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetShieldedInstanceIntegrityPolicy(SetShieldedInstanceIntegrityPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetShieldedInstanceIntegrityPolicyInstanceRequest(ref request, ref callSettings);
            Operation response = _callSetShieldedInstanceIntegrityPolicy.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetShieldedInstanceIntegrityPolicyOperationsClient);
        }

        /// <summary>
        /// Sets the Shielded Instance integrity policy for an instance. You can only use this method on a running instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetShieldedInstanceIntegrityPolicyAsync(SetShieldedInstanceIntegrityPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetShieldedInstanceIntegrityPolicyInstanceRequest(ref request, ref callSettings);
            Operation response = await _callSetShieldedInstanceIntegrityPolicy.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetShieldedInstanceIntegrityPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetTags</c>.</summary>
        public override lro::OperationsClient SetTagsOperationsClient { get; }

        /// <summary>
        /// Sets network tags for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetTags(SetTagsInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetTagsInstanceRequest(ref request, ref callSettings);
            Operation response = _callSetTags.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetTagsOperationsClient);
        }

        /// <summary>
        /// Sets network tags for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetTagsAsync(SetTagsInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetTagsInstanceRequest(ref request, ref callSettings);
            Operation response = await _callSetTags.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetTagsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SimulateMaintenanceEvent</c>.</summary>
        public override lro::OperationsClient SimulateMaintenanceEventOperationsClient { get; }

        /// <summary>
        /// Simulates a host maintenance event on a VM. For more information, see Simulate a host maintenance event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SimulateMaintenanceEvent(SimulateMaintenanceEventInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SimulateMaintenanceEventInstanceRequest(ref request, ref callSettings);
            Operation response = _callSimulateMaintenanceEvent.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SimulateMaintenanceEventOperationsClient);
        }

        /// <summary>
        /// Simulates a host maintenance event on a VM. For more information, see Simulate a host maintenance event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SimulateMaintenanceEventAsync(SimulateMaintenanceEventInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SimulateMaintenanceEventInstanceRequest(ref request, ref callSettings);
            Operation response = await _callSimulateMaintenanceEvent.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SimulateMaintenanceEventOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Start</c>.</summary>
        public override lro::OperationsClient StartOperationsClient { get; }

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Start(StartInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartInstanceRequest(ref request, ref callSettings);
            Operation response = _callStart.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), StartOperationsClient);
        }

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> StartAsync(StartInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartInstanceRequest(ref request, ref callSettings);
            Operation response = await _callStart.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), StartOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StartWithEncryptionKey</c>.</summary>
        public override lro::OperationsClient StartWithEncryptionKeyOperationsClient { get; }

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> StartWithEncryptionKey(StartWithEncryptionKeyInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartWithEncryptionKeyInstanceRequest(ref request, ref callSettings);
            Operation response = _callStartWithEncryptionKey.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), StartWithEncryptionKeyOperationsClient);
        }

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> StartWithEncryptionKeyAsync(StartWithEncryptionKeyInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartWithEncryptionKeyInstanceRequest(ref request, ref callSettings);
            Operation response = await _callStartWithEncryptionKey.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), StartWithEncryptionKeyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Stop</c>.</summary>
        public override lro::OperationsClient StopOperationsClient { get; }

        /// <summary>
        /// Stops a running instance, shutting it down cleanly, and allows you to restart the instance at a later time. Stopped instances do not incur VM usage charges while they are stopped. However, resources that the VM is using, such as persistent disks and static IP addresses, will continue to be charged until they are deleted. For more information, see Stopping an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Stop(StopInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopInstanceRequest(ref request, ref callSettings);
            Operation response = _callStop.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), StopOperationsClient);
        }

        /// <summary>
        /// Stops a running instance, shutting it down cleanly, and allows you to restart the instance at a later time. Stopped instances do not incur VM usage charges while they are stopped. However, resources that the VM is using, such as persistent disks and static IP addresses, will continue to be charged until they are deleted. For more information, see Stopping an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> StopAsync(StopInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopInstanceRequest(ref request, ref callSettings);
            Operation response = await _callStop.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), StopOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Suspend</c>.</summary>
        public override lro::OperationsClient SuspendOperationsClient { get; }

        /// <summary>
        /// This method suspends a running instance, saving its state to persistent storage, and allows you to resume the instance at a later time. Suspended instances have no compute costs (cores or RAM), and incur only storage charges for the saved VM memory and localSSD data. Any charged resources the virtual machine was using, such as persistent disks and static IP addresses, will continue to be charged while the instance is suspended. For more information, see Suspending and resuming an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Suspend(SuspendInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuspendInstanceRequest(ref request, ref callSettings);
            Operation response = _callSuspend.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SuspendOperationsClient);
        }

        /// <summary>
        /// This method suspends a running instance, saving its state to persistent storage, and allows you to resume the instance at a later time. Suspended instances have no compute costs (cores or RAM), and incur only storage charges for the saved VM memory and localSSD data. Any charged resources the virtual machine was using, such as persistent disks and static IP addresses, will continue to be charged while the instance is suspended. For more information, see Suspending and resuming an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SuspendAsync(SuspendInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuspendInstanceRequest(ref request, ref callSettings);
            Operation response = await _callSuspend.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SuspendOperationsClient);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TestPermissionsResponse TestIamPermissions(TestIamPermissionsInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsInstanceRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsInstanceRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Update</c>.</summary>
        public override lro::OperationsClient UpdateOperationsClient { get; }

        /// <summary>
        /// Updates an instance only if the necessary resources are available. This method can update only a specific set of instance properties. See Updating a running instance for a list of updatable instance properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Update(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            Operation response = _callUpdate.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateOperationsClient);
        }

        /// <summary>
        /// Updates an instance only if the necessary resources are available. This method can update only a specific set of instance properties. See Updating a running instance for a list of updatable instance properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            Operation response = await _callUpdate.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAccessConfig</c>.</summary>
        public override lro::OperationsClient UpdateAccessConfigOperationsClient { get; }

        /// <summary>
        /// Updates the specified access config from an instance's network interface with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> UpdateAccessConfig(UpdateAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccessConfigInstanceRequest(ref request, ref callSettings);
            Operation response = _callUpdateAccessConfig.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateAccessConfigOperationsClient);
        }

        /// <summary>
        /// Updates the specified access config from an instance's network interface with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> UpdateAccessConfigAsync(UpdateAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccessConfigInstanceRequest(ref request, ref callSettings);
            Operation response = await _callUpdateAccessConfig.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateAccessConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateDisplayDevice</c>.</summary>
        public override lro::OperationsClient UpdateDisplayDeviceOperationsClient { get; }

        /// <summary>
        /// Updates the Display config for a VM instance. You can only use this method on a stopped VM instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> UpdateDisplayDevice(UpdateDisplayDeviceInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDisplayDeviceInstanceRequest(ref request, ref callSettings);
            Operation response = _callUpdateDisplayDevice.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateDisplayDeviceOperationsClient);
        }

        /// <summary>
        /// Updates the Display config for a VM instance. You can only use this method on a stopped VM instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> UpdateDisplayDeviceAsync(UpdateDisplayDeviceInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDisplayDeviceInstanceRequest(ref request, ref callSettings);
            Operation response = await _callUpdateDisplayDevice.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateDisplayDeviceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateNetworkInterface</c>.</summary>
        public override lro::OperationsClient UpdateNetworkInterfaceOperationsClient { get; }

        /// <summary>
        /// Updates an instance's network interface. This method can only update an interface's alias IP range and attached network. See Modifying alias IP ranges for an existing instance for instructions on changing alias IP ranges. See Migrating a VM between networks for instructions on migrating an interface. This method follows PATCH semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> UpdateNetworkInterface(UpdateNetworkInterfaceInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNetworkInterfaceInstanceRequest(ref request, ref callSettings);
            Operation response = _callUpdateNetworkInterface.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateNetworkInterfaceOperationsClient);
        }

        /// <summary>
        /// Updates an instance's network interface. This method can only update an interface's alias IP range and attached network. See Modifying alias IP ranges for an existing instance for instructions on changing alias IP ranges. See Migrating a VM between networks for instructions on migrating an interface. This method follows PATCH semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> UpdateNetworkInterfaceAsync(UpdateNetworkInterfaceInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNetworkInterfaceInstanceRequest(ref request, ref callSettings);
            Operation response = await _callUpdateNetworkInterface.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateNetworkInterfaceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateShieldedInstanceConfig</c>.</summary>
        public override lro::OperationsClient UpdateShieldedInstanceConfigOperationsClient { get; }

        /// <summary>
        /// Updates the Shielded Instance config for an instance. You can only use this method on a stopped instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> UpdateShieldedInstanceConfig(UpdateShieldedInstanceConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateShieldedInstanceConfigInstanceRequest(ref request, ref callSettings);
            Operation response = _callUpdateShieldedInstanceConfig.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateShieldedInstanceConfigOperationsClient);
        }

        /// <summary>
        /// Updates the Shielded Instance config for an instance. You can only use this method on a stopped instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> UpdateShieldedInstanceConfigAsync(UpdateShieldedInstanceConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateShieldedInstanceConfigInstanceRequest(ref request, ref callSettings);
            Operation response = await _callUpdateShieldedInstanceConfig.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateShieldedInstanceConfigOperationsClient);
        }
    }

    public partial class AggregatedListInstancesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ListInstancesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ListReferrersInstancesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class InstanceAggregatedList : gaxgrpc::IPageResponse<scg::KeyValuePair<string, InstancesScopedList>>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<scg::KeyValuePair<string, InstancesScopedList>> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class InstanceList : gaxgrpc::IPageResponse<Instance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Instance> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class InstanceListReferrers : gaxgrpc::IPageResponse<Reference>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Reference> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Instances
    {
        public partial class InstancesClient
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
