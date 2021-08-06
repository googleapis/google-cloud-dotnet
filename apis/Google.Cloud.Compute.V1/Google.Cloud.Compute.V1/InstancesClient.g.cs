// Copyright 2021 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;

using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

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
            AddResourcePoliciesSettings = existing.AddResourcePoliciesSettings;
            AggregatedListSettings = existing.AggregatedListSettings;
            AttachDiskSettings = existing.AttachDiskSettings;
            BulkInsertSettings = existing.BulkInsertSettings;
            DeleteSettings = existing.DeleteSettings;
            DeleteAccessConfigSettings = existing.DeleteAccessConfigSettings;
            DetachDiskSettings = existing.DetachDiskSettings;
            GetSettings = existing.GetSettings;
            GetEffectiveFirewallsSettings = existing.GetEffectiveFirewallsSettings;
            GetGuestAttributesSettings = existing.GetGuestAttributesSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            GetScreenshotSettings = existing.GetScreenshotSettings;
            GetSerialPortOutputSettings = existing.GetSerialPortOutputSettings;
            GetShieldedInstanceIdentitySettings = existing.GetShieldedInstanceIdentitySettings;
            InsertSettings = existing.InsertSettings;
            InsertOperationsSettings = existing.InsertOperationsSettings;
            ListSettings = existing.ListSettings;
            ListReferrersSettings = existing.ListReferrersSettings;
            RemoveResourcePoliciesSettings = existing.RemoveResourcePoliciesSettings;
            ResetSettings = existing.ResetSettings;
            SetDeletionProtectionSettings = existing.SetDeletionProtectionSettings;
            SetDiskAutoDeleteSettings = existing.SetDiskAutoDeleteSettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            SetLabelsSettings = existing.SetLabelsSettings;
            SetMachineResourcesSettings = existing.SetMachineResourcesSettings;
            SetMachineTypeSettings = existing.SetMachineTypeSettings;
            SetMetadataSettings = existing.SetMetadataSettings;
            SetMinCpuPlatformSettings = existing.SetMinCpuPlatformSettings;
            SetSchedulingSettings = existing.SetSchedulingSettings;
            SetServiceAccountSettings = existing.SetServiceAccountSettings;
            SetShieldedInstanceIntegrityPolicySettings = existing.SetShieldedInstanceIntegrityPolicySettings;
            SetTagsSettings = existing.SetTagsSettings;
            SimulateMaintenanceEventSettings = existing.SimulateMaintenanceEventSettings;
            StartSettings = existing.StartSettings;
            StartWithEncryptionKeySettings = existing.StartWithEncryptionKeySettings;
            StopSettings = existing.StopSettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            UpdateSettings = existing.UpdateSettings;
            UpdateAccessConfigSettings = existing.UpdateAccessConfigSettings;
            UpdateDisplayDeviceSettings = existing.UpdateDisplayDeviceSettings;
            UpdateNetworkInterfaceSettings = existing.UpdateNetworkInterfaceSettings;
            UpdateShieldedInstanceConfigSettings = existing.UpdateShieldedInstanceConfigSettings;
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
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddAccessConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.AddResourcePolicies</c> and <c>InstancesClient.AddResourcePoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddResourcePoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.AggregatedList</c> and <c>InstancesClient.AggregatedListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AggregatedListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.AttachDisk</c>
        ///  and <c>InstancesClient.AttachDiskAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AttachDiskSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.BulkInsert</c>
        ///  and <c>InstancesClient.BulkInsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BulkInsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.Delete</c>
        /// and <c>InstancesClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.DeleteAccessConfig</c> and <c>InstancesClient.DeleteAccessConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAccessConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.DetachDisk</c>
        ///  and <c>InstancesClient.DetachDiskAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DetachDiskSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.Get</c> and
        /// <c>InstancesClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.GetEffectiveFirewalls</c> and <c>InstancesClient.GetEffectiveFirewallsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEffectiveFirewallsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.GetGuestAttributes</c> and <c>InstancesClient.GetGuestAttributesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGuestAttributesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.GetIamPolicy</c> and <c>InstancesClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.GetScreenshot</c> and <c>InstancesClient.GetScreenshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetScreenshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.GetSerialPortOutput</c> and <c>InstancesClient.GetSerialPortOutputAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSerialPortOutputSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.GetShieldedInstanceIdentity</c> and <c>InstancesClient.GetShieldedInstanceIdentityAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetShieldedInstanceIdentitySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.Insert</c>
        /// and <c>InstancesClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

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
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.ListReferrers</c> and <c>InstancesClient.ListReferrersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReferrersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.RemoveResourcePolicies</c> and <c>InstancesClient.RemoveResourcePoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveResourcePoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.Reset</c>
        /// and <c>InstancesClient.ResetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SetDeletionProtection</c> and <c>InstancesClient.SetDeletionProtectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetDeletionProtectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SetDiskAutoDelete</c> and <c>InstancesClient.SetDiskAutoDeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetDiskAutoDeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SetIamPolicy</c> and <c>InstancesClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.SetLabels</c>
        ///  and <c>InstancesClient.SetLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SetMachineResources</c> and <c>InstancesClient.SetMachineResourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetMachineResourcesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SetMachineType</c> and <c>InstancesClient.SetMachineTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetMachineTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.SetMetadata</c>
        ///  and <c>InstancesClient.SetMetadataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetMetadataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SetMinCpuPlatform</c> and <c>InstancesClient.SetMinCpuPlatformAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetMinCpuPlatformSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SetScheduling</c> and <c>InstancesClient.SetSchedulingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetSchedulingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SetServiceAccount</c> and <c>InstancesClient.SetServiceAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetServiceAccountSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SetShieldedInstanceIntegrityPolicy</c> and
        /// <c>InstancesClient.SetShieldedInstanceIntegrityPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetShieldedInstanceIntegrityPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.SetTags</c>
        /// and <c>InstancesClient.SetTagsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetTagsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.SimulateMaintenanceEvent</c> and <c>InstancesClient.SimulateMaintenanceEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SimulateMaintenanceEventSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.Start</c>
        /// and <c>InstancesClient.StartAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.StartWithEncryptionKey</c> and <c>InstancesClient.StartWithEncryptionKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartWithEncryptionKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.Stop</c>
        /// and <c>InstancesClient.StopAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.TestIamPermissions</c> and <c>InstancesClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstancesClient.Update</c>
        /// and <c>InstancesClient.UpdateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.UpdateAccessConfig</c> and <c>InstancesClient.UpdateAccessConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAccessConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.UpdateDisplayDevice</c> and <c>InstancesClient.UpdateDisplayDeviceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDisplayDeviceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.UpdateNetworkInterface</c> and <c>InstancesClient.UpdateNetworkInterfaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateNetworkInterfaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstancesClient.UpdateShieldedInstanceConfig</c> and <c>InstancesClient.UpdateShieldedInstanceConfigAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateShieldedInstanceConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

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
            return InstancesClient.Create(callInvoker, Settings);
        }

        private async stt::Task<InstancesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return InstancesClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => InstancesClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => InstancesClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => InstancesClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => ComputeRestAdapter.ComputeAdapter;
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

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

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
        /// <returns>The created <see cref="InstancesClient"/>.</returns>
        internal static InstancesClient Create(grpccore::CallInvoker callInvoker, InstancesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Instances.InstancesClient grpcClient = new Instances.InstancesClient(callInvoker);
            return new InstancesClientImpl(grpcClient, settings);
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
        public virtual Operation AddAccessConfig(AddAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds an access config to an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddAccessConfigAsync(AddAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds an access config to an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddAccessConfigAsync(AddAccessConfigInstanceRequest request, st::CancellationToken cancellationToken) =>
            AddAccessConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation AddAccessConfig(string project, string zone, string instance, string networkInterface, AccessConfig accessConfigResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> AddAccessConfigAsync(string project, string zone, string instance, string networkInterface, AccessConfig accessConfigResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> AddAccessConfigAsync(string project, string zone, string instance, string networkInterface, AccessConfig accessConfigResource, st::CancellationToken cancellationToken) =>
            AddAccessConfigAsync(project, zone, instance, networkInterface, accessConfigResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds existing resource policies to an instance. You can only add one policy right now which will be applied to this instance for scheduling live migrations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation AddResourcePolicies(AddResourcePoliciesInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds existing resource policies to an instance. You can only add one policy right now which will be applied to this instance for scheduling live migrations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddResourcePoliciesAsync(AddResourcePoliciesInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds existing resource policies to an instance. You can only add one policy right now which will be applied to this instance for scheduling live migrations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddResourcePoliciesAsync(AddResourcePoliciesInstanceRequest request, st::CancellationToken cancellationToken) =>
            AddResourcePoliciesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation AddResourcePolicies(string project, string zone, string instance, InstancesAddResourcePoliciesRequest instancesAddResourcePoliciesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> AddResourcePoliciesAsync(string project, string zone, string instance, InstancesAddResourcePoliciesRequest instancesAddResourcePoliciesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> AddResourcePoliciesAsync(string project, string zone, string instance, InstancesAddResourcePoliciesRequest instancesAddResourcePoliciesRequestResource, st::CancellationToken cancellationToken) =>
            AddResourcePoliciesAsync(project, zone, instance, instancesAddResourcePoliciesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves aggregated list of all of the instances in your project across all regions and zones.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceAggregatedList AggregatedList(AggregatedListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves aggregated list of all of the instances in your project across all regions and zones.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceAggregatedList> AggregatedListAsync(AggregatedListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves aggregated list of all of the instances in your project across all regions and zones.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceAggregatedList> AggregatedListAsync(AggregatedListInstancesRequest request, st::CancellationToken cancellationToken) =>
            AggregatedListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves aggregated list of all of the instances in your project across all regions and zones.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceAggregatedList AggregatedList(string project, gaxgrpc::CallSettings callSettings = null) =>
            AggregatedList(new AggregatedListInstancesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Retrieves aggregated list of all of the instances in your project across all regions and zones.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceAggregatedList> AggregatedListAsync(string project, gaxgrpc::CallSettings callSettings = null) =>
            AggregatedListAsync(new AggregatedListInstancesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Retrieves aggregated list of all of the instances in your project across all regions and zones.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceAggregatedList> AggregatedListAsync(string project, st::CancellationToken cancellationToken) =>
            AggregatedListAsync(project, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Attaches an existing Disk resource to an instance. You must first create the disk before you can attach it. It is not possible to create and attach a disk at the same time. For more information, read Adding a persistent disk to your instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation AttachDisk(AttachDiskInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Attaches an existing Disk resource to an instance. You must first create the disk before you can attach it. It is not possible to create and attach a disk at the same time. For more information, read Adding a persistent disk to your instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AttachDiskAsync(AttachDiskInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Attaches an existing Disk resource to an instance. You must first create the disk before you can attach it. It is not possible to create and attach a disk at the same time. For more information, read Adding a persistent disk to your instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AttachDiskAsync(AttachDiskInstanceRequest request, st::CancellationToken cancellationToken) =>
            AttachDiskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation AttachDisk(string project, string zone, string instance, AttachedDisk attachedDiskResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> AttachDiskAsync(string project, string zone, string instance, AttachedDisk attachedDiskResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> AttachDiskAsync(string project, string zone, string instance, AttachedDisk attachedDiskResource, st::CancellationToken cancellationToken) =>
            AttachDiskAsync(project, zone, instance, attachedDiskResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates multiple instances. Count specifies the number of instances to create.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation BulkInsert(BulkInsertInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates multiple instances. Count specifies the number of instances to create.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> BulkInsertAsync(BulkInsertInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates multiple instances. Count specifies the number of instances to create.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> BulkInsertAsync(BulkInsertInstanceRequest request, st::CancellationToken cancellationToken) =>
            BulkInsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates multiple instances. Count specifies the number of instances to create.
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
        public virtual Operation BulkInsert(string project, string zone, BulkInsertInstanceResource bulkInsertInstanceResourceResource, gaxgrpc::CallSettings callSettings = null) =>
            BulkInsert(new BulkInsertInstanceRequest
            {
                BulkInsertInstanceResourceResource = gax::GaxPreconditions.CheckNotNull(bulkInsertInstanceResourceResource, nameof(bulkInsertInstanceResourceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates multiple instances. Count specifies the number of instances to create.
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
        public virtual stt::Task<Operation> BulkInsertAsync(string project, string zone, BulkInsertInstanceResource bulkInsertInstanceResourceResource, gaxgrpc::CallSettings callSettings = null) =>
            BulkInsertAsync(new BulkInsertInstanceRequest
            {
                BulkInsertInstanceResourceResource = gax::GaxPreconditions.CheckNotNull(bulkInsertInstanceResourceResource, nameof(bulkInsertInstanceResourceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates multiple instances. Count specifies the number of instances to create.
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
        public virtual stt::Task<Operation> BulkInsertAsync(string project, string zone, BulkInsertInstanceResource bulkInsertInstanceResourceResource, st::CancellationToken cancellationToken) =>
            BulkInsertAsync(project, zone, bulkInsertInstanceResourceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified Instance resource. For more information, see Deleting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified Instance resource. For more information, see Deleting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified Instance resource. For more information, see Deleting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteInstanceRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation Delete(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> DeleteAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> DeleteAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an access config from an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation DeleteAccessConfig(DeleteAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an access config from an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAccessConfigAsync(DeleteAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an access config from an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAccessConfigAsync(DeleteAccessConfigInstanceRequest request, st::CancellationToken cancellationToken) =>
            DeleteAccessConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation DeleteAccessConfig(string project, string zone, string instance, string accessConfig, string networkInterface, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> DeleteAccessConfigAsync(string project, string zone, string instance, string accessConfig, string networkInterface, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> DeleteAccessConfigAsync(string project, string zone, string instance, string accessConfig, string networkInterface, st::CancellationToken cancellationToken) =>
            DeleteAccessConfigAsync(project, zone, instance, accessConfig, networkInterface, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Detaches a disk from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation DetachDisk(DetachDiskInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Detaches a disk from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DetachDiskAsync(DetachDiskInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Detaches a disk from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DetachDiskAsync(DetachDiskInstanceRequest request, st::CancellationToken cancellationToken) =>
            DetachDiskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation DetachDisk(string project, string zone, string instance, string deviceName, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> DetachDiskAsync(string project, string zone, string instance, string deviceName, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> DetachDiskAsync(string project, string zone, string instance, string deviceName, st::CancellationToken cancellationToken) =>
            DetachDiskAsync(project, zone, instance, deviceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified Instance resource. Gets a list of available instances by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance Get(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified Instance resource. Gets a list of available instances by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified Instance resource. Gets a list of available instances by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetAsync(GetInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified Instance resource. Gets a list of available instances by making a list() request.
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
        /// Returns the specified Instance resource. Gets a list of available instances by making a list() request.
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
        /// Returns the specified Instance resource. Gets a list of available instances by making a list() request.
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

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceInsert(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>Insert</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceInsertAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public virtual lro::OperationsClient InsertOperationsClient => throw new sys::NotImplementedException();

        /* ORIGINAL GENERATED METHODS
         
        /// <summary>
        /// Creates an instance resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(InsertInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an instance resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an instance resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertInstanceRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
        */

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
        /// <returns>The RPC response.</returns>
        public virtual InstanceList List(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of instances contained within the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceList> ListAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of instances contained within the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceList> ListAsync(ListInstancesRequest request, st::CancellationToken cancellationToken) =>
            ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of instances contained within the specified zone.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceList List(string project, string zone, gaxgrpc::CallSettings callSettings = null) =>
            List(new ListInstancesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Retrieves the list of instances contained within the specified zone.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceList> ListAsync(string project, string zone, gaxgrpc::CallSettings callSettings = null) =>
            ListAsync(new ListInstancesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Retrieves the list of instances contained within the specified zone.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceList> ListAsync(string project, string zone, st::CancellationToken cancellationToken) =>
            ListAsync(project, zone, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of resources that refer to the VM instance specified in the request. For example, if the VM instance is part of a managed or unmanaged instance group, the referrers list includes the instance group. For more information, read Viewing referrers to VM instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceListReferrers ListReferrers(ListReferrersInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of resources that refer to the VM instance specified in the request. For example, if the VM instance is part of a managed or unmanaged instance group, the referrers list includes the instance group. For more information, read Viewing referrers to VM instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceListReferrers> ListReferrersAsync(ListReferrersInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of resources that refer to the VM instance specified in the request. For example, if the VM instance is part of a managed or unmanaged instance group, the referrers list includes the instance group. For more information, read Viewing referrers to VM instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceListReferrers> ListReferrersAsync(ListReferrersInstancesRequest request, st::CancellationToken cancellationToken) =>
            ListReferrersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceListReferrers ListReferrers(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            ListReferrers(new ListReferrersInstancesRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceListReferrers> ListReferrersAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            ListReferrersAsync(new ListReferrersInstancesRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

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
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceListReferrers> ListReferrersAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            ListReferrersAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes resource policies from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation RemoveResourcePolicies(RemoveResourcePoliciesInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes resource policies from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RemoveResourcePoliciesAsync(RemoveResourcePoliciesInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes resource policies from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RemoveResourcePoliciesAsync(RemoveResourcePoliciesInstanceRequest request, st::CancellationToken cancellationToken) =>
            RemoveResourcePoliciesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation RemoveResourcePolicies(string project, string zone, string instance, InstancesRemoveResourcePoliciesRequest instancesRemoveResourcePoliciesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> RemoveResourcePoliciesAsync(string project, string zone, string instance, InstancesRemoveResourcePoliciesRequest instancesRemoveResourcePoliciesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> RemoveResourcePoliciesAsync(string project, string zone, string instance, InstancesRemoveResourcePoliciesRequest instancesRemoveResourcePoliciesRequestResource, st::CancellationToken cancellationToken) =>
            RemoveResourcePoliciesAsync(project, zone, instance, instancesRemoveResourcePoliciesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs a reset on the instance. This is a hard reset the VM does not do a graceful shutdown. For more information, see Resetting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Reset(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs a reset on the instance. This is a hard reset the VM does not do a graceful shutdown. For more information, see Resetting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> ResetAsync(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs a reset on the instance. This is a hard reset the VM does not do a graceful shutdown. For more information, see Resetting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> ResetAsync(ResetInstanceRequest request, st::CancellationToken cancellationToken) =>
            ResetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs a reset on the instance. This is a hard reset the VM does not do a graceful shutdown. For more information, see Resetting an instance.
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
        public virtual Operation Reset(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            Reset(new ResetInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Performs a reset on the instance. This is a hard reset the VM does not do a graceful shutdown. For more information, see Resetting an instance.
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
        public virtual stt::Task<Operation> ResetAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            ResetAsync(new ResetInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Performs a reset on the instance. This is a hard reset the VM does not do a graceful shutdown. For more information, see Resetting an instance.
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
        public virtual stt::Task<Operation> ResetAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            ResetAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets deletion protection on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetDeletionProtection(SetDeletionProtectionInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets deletion protection on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetDeletionProtectionAsync(SetDeletionProtectionInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets deletion protection on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetDeletionProtectionAsync(SetDeletionProtectionInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetDeletionProtectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation SetDeletionProtection(string project, string zone, string resource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetDeletionProtectionAsync(string project, string zone, string resource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetDeletionProtectionAsync(string project, string zone, string resource, st::CancellationToken cancellationToken) =>
            SetDeletionProtectionAsync(project, zone, resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the auto-delete flag for a disk attached to an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetDiskAutoDelete(SetDiskAutoDeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the auto-delete flag for a disk attached to an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetDiskAutoDeleteAsync(SetDiskAutoDeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the auto-delete flag for a disk attached to an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetDiskAutoDeleteAsync(SetDiskAutoDeleteInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetDiskAutoDeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation SetDiskAutoDelete(string project, string zone, string instance, bool autoDelete, string deviceName, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetDiskAutoDeleteAsync(string project, string zone, string instance, bool autoDelete, string deviceName, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetDiskAutoDeleteAsync(string project, string zone, string instance, bool autoDelete, string deviceName, st::CancellationToken cancellationToken) =>
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
        public virtual Operation SetLabels(SetLabelsInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets labels on an instance. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetLabelsAsync(SetLabelsInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets labels on an instance. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetLabelsAsync(SetLabelsInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation SetLabels(string project, string zone, string instance, InstancesSetLabelsRequest instancesSetLabelsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetLabelsAsync(string project, string zone, string instance, InstancesSetLabelsRequest instancesSetLabelsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetLabelsAsync(string project, string zone, string instance, InstancesSetLabelsRequest instancesSetLabelsRequestResource, st::CancellationToken cancellationToken) =>
            SetLabelsAsync(project, zone, instance, instancesSetLabelsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the number and/or type of accelerator for a stopped instance to the values specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetMachineResources(SetMachineResourcesInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the number and/or type of accelerator for a stopped instance to the values specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetMachineResourcesAsync(SetMachineResourcesInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the number and/or type of accelerator for a stopped instance to the values specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetMachineResourcesAsync(SetMachineResourcesInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetMachineResourcesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation SetMachineResources(string project, string zone, string instance, InstancesSetMachineResourcesRequest instancesSetMachineResourcesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetMachineResourcesAsync(string project, string zone, string instance, InstancesSetMachineResourcesRequest instancesSetMachineResourcesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetMachineResourcesAsync(string project, string zone, string instance, InstancesSetMachineResourcesRequest instancesSetMachineResourcesRequestResource, st::CancellationToken cancellationToken) =>
            SetMachineResourcesAsync(project, zone, instance, instancesSetMachineResourcesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the machine type for a stopped instance to the machine type specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetMachineType(SetMachineTypeInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the machine type for a stopped instance to the machine type specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetMachineTypeAsync(SetMachineTypeInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the machine type for a stopped instance to the machine type specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetMachineTypeAsync(SetMachineTypeInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetMachineTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation SetMachineType(string project, string zone, string instance, InstancesSetMachineTypeRequest instancesSetMachineTypeRequestResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetMachineTypeAsync(string project, string zone, string instance, InstancesSetMachineTypeRequest instancesSetMachineTypeRequestResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetMachineTypeAsync(string project, string zone, string instance, InstancesSetMachineTypeRequest instancesSetMachineTypeRequestResource, st::CancellationToken cancellationToken) =>
            SetMachineTypeAsync(project, zone, instance, instancesSetMachineTypeRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets metadata for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetMetadata(SetMetadataInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets metadata for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetMetadataAsync(SetMetadataInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets metadata for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetMetadataAsync(SetMetadataInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetMetadataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation SetMetadata(string project, string zone, string instance, Metadata metadataResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetMetadataAsync(string project, string zone, string instance, Metadata metadataResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetMetadataAsync(string project, string zone, string instance, Metadata metadataResource, st::CancellationToken cancellationToken) =>
            SetMetadataAsync(project, zone, instance, metadataResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the minimum CPU platform that this instance should use. This method can only be called on a stopped instance. For more information, read Specifying a Minimum CPU Platform.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetMinCpuPlatform(SetMinCpuPlatformInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the minimum CPU platform that this instance should use. This method can only be called on a stopped instance. For more information, read Specifying a Minimum CPU Platform.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetMinCpuPlatformAsync(SetMinCpuPlatformInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the minimum CPU platform that this instance should use. This method can only be called on a stopped instance. For more information, read Specifying a Minimum CPU Platform.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetMinCpuPlatformAsync(SetMinCpuPlatformInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetMinCpuPlatformAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation SetMinCpuPlatform(string project, string zone, string instance, InstancesSetMinCpuPlatformRequest instancesSetMinCpuPlatformRequestResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetMinCpuPlatformAsync(string project, string zone, string instance, InstancesSetMinCpuPlatformRequest instancesSetMinCpuPlatformRequestResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetMinCpuPlatformAsync(string project, string zone, string instance, InstancesSetMinCpuPlatformRequest instancesSetMinCpuPlatformRequestResource, st::CancellationToken cancellationToken) =>
            SetMinCpuPlatformAsync(project, zone, instance, instancesSetMinCpuPlatformRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets an instance's scheduling options. You can only call this method on a stopped instance, that is, a VM instance that is in a `TERMINATED` state. See Instance Life Cycle for more information on the possible instance states.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetScheduling(SetSchedulingInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets an instance's scheduling options. You can only call this method on a stopped instance, that is, a VM instance that is in a `TERMINATED` state. See Instance Life Cycle for more information on the possible instance states.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSchedulingAsync(SetSchedulingInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets an instance's scheduling options. You can only call this method on a stopped instance, that is, a VM instance that is in a `TERMINATED` state. See Instance Life Cycle for more information on the possible instance states.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSchedulingAsync(SetSchedulingInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetSchedulingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets an instance's scheduling options. You can only call this method on a stopped instance, that is, a VM instance that is in a `TERMINATED` state. See Instance Life Cycle for more information on the possible instance states.
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
        public virtual Operation SetScheduling(string project, string zone, string instance, Scheduling schedulingResource, gaxgrpc::CallSettings callSettings = null) =>
            SetScheduling(new SetSchedulingInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SchedulingResource = gax::GaxPreconditions.CheckNotNull(schedulingResource, nameof(schedulingResource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets an instance's scheduling options. You can only call this method on a stopped instance, that is, a VM instance that is in a `TERMINATED` state. See Instance Life Cycle for more information on the possible instance states.
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
        public virtual stt::Task<Operation> SetSchedulingAsync(string project, string zone, string instance, Scheduling schedulingResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSchedulingAsync(new SetSchedulingInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SchedulingResource = gax::GaxPreconditions.CheckNotNull(schedulingResource, nameof(schedulingResource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets an instance's scheduling options. You can only call this method on a stopped instance, that is, a VM instance that is in a `TERMINATED` state. See Instance Life Cycle for more information on the possible instance states.
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
        public virtual stt::Task<Operation> SetSchedulingAsync(string project, string zone, string instance, Scheduling schedulingResource, st::CancellationToken cancellationToken) =>
            SetSchedulingAsync(project, zone, instance, schedulingResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the service account on the instance. For more information, read Changing the service account and access scopes for an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetServiceAccount(SetServiceAccountInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the service account on the instance. For more information, read Changing the service account and access scopes for an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetServiceAccountAsync(SetServiceAccountInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the service account on the instance. For more information, read Changing the service account and access scopes for an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetServiceAccountAsync(SetServiceAccountInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation SetServiceAccount(string project, string zone, string instance, InstancesSetServiceAccountRequest instancesSetServiceAccountRequestResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetServiceAccountAsync(string project, string zone, string instance, InstancesSetServiceAccountRequest instancesSetServiceAccountRequestResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetServiceAccountAsync(string project, string zone, string instance, InstancesSetServiceAccountRequest instancesSetServiceAccountRequestResource, st::CancellationToken cancellationToken) =>
            SetServiceAccountAsync(project, zone, instance, instancesSetServiceAccountRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the Shielded Instance integrity policy for an instance. You can only use this method on a running instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetShieldedInstanceIntegrityPolicy(SetShieldedInstanceIntegrityPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the Shielded Instance integrity policy for an instance. You can only use this method on a running instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetShieldedInstanceIntegrityPolicyAsync(SetShieldedInstanceIntegrityPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the Shielded Instance integrity policy for an instance. You can only use this method on a running instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetShieldedInstanceIntegrityPolicyAsync(SetShieldedInstanceIntegrityPolicyInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetShieldedInstanceIntegrityPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation SetShieldedInstanceIntegrityPolicy(string project, string zone, string instance, ShieldedInstanceIntegrityPolicy shieldedInstanceIntegrityPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetShieldedInstanceIntegrityPolicyAsync(string project, string zone, string instance, ShieldedInstanceIntegrityPolicy shieldedInstanceIntegrityPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetShieldedInstanceIntegrityPolicyAsync(string project, string zone, string instance, ShieldedInstanceIntegrityPolicy shieldedInstanceIntegrityPolicyResource, st::CancellationToken cancellationToken) =>
            SetShieldedInstanceIntegrityPolicyAsync(project, zone, instance, shieldedInstanceIntegrityPolicyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets network tags for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetTags(SetTagsInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets network tags for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetTagsAsync(SetTagsInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets network tags for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetTagsAsync(SetTagsInstanceRequest request, st::CancellationToken cancellationToken) =>
            SetTagsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation SetTags(string project, string zone, string instance, Tags tagsResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetTagsAsync(string project, string zone, string instance, Tags tagsResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> SetTagsAsync(string project, string zone, string instance, Tags tagsResource, st::CancellationToken cancellationToken) =>
            SetTagsAsync(project, zone, instance, tagsResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Simulates a maintenance event on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SimulateMaintenanceEvent(SimulateMaintenanceEventInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Simulates a maintenance event on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SimulateMaintenanceEventAsync(SimulateMaintenanceEventInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Simulates a maintenance event on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SimulateMaintenanceEventAsync(SimulateMaintenanceEventInstanceRequest request, st::CancellationToken cancellationToken) =>
            SimulateMaintenanceEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Simulates a maintenance event on the instance.
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
        public virtual Operation SimulateMaintenanceEvent(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            SimulateMaintenanceEvent(new SimulateMaintenanceEventInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Simulates a maintenance event on the instance.
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
        public virtual stt::Task<Operation> SimulateMaintenanceEventAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
            SimulateMaintenanceEventAsync(new SimulateMaintenanceEventInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Simulates a maintenance event on the instance.
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
        public virtual stt::Task<Operation> SimulateMaintenanceEventAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            SimulateMaintenanceEventAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Start(StartInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StartAsync(StartInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StartAsync(StartInstanceRequest request, st::CancellationToken cancellationToken) =>
            StartAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation Start(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> StartAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> StartAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            StartAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation StartWithEncryptionKey(StartWithEncryptionKeyInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StartWithEncryptionKeyAsync(StartWithEncryptionKeyInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StartWithEncryptionKeyAsync(StartWithEncryptionKeyInstanceRequest request, st::CancellationToken cancellationToken) =>
            StartWithEncryptionKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation StartWithEncryptionKey(string project, string zone, string instance, InstancesStartWithEncryptionKeyRequest instancesStartWithEncryptionKeyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> StartWithEncryptionKeyAsync(string project, string zone, string instance, InstancesStartWithEncryptionKeyRequest instancesStartWithEncryptionKeyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> StartWithEncryptionKeyAsync(string project, string zone, string instance, InstancesStartWithEncryptionKeyRequest instancesStartWithEncryptionKeyRequestResource, st::CancellationToken cancellationToken) =>
            StartWithEncryptionKeyAsync(project, zone, instance, instancesStartWithEncryptionKeyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops a running instance, shutting it down cleanly, and allows you to restart the instance at a later time. Stopped instances do not incur VM usage charges while they are stopped. However, resources that the VM is using, such as persistent disks and static IP addresses, will continue to be charged until they are deleted. For more information, see Stopping an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Stop(StopInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a running instance, shutting it down cleanly, and allows you to restart the instance at a later time. Stopped instances do not incur VM usage charges while they are stopped. However, resources that the VM is using, such as persistent disks and static IP addresses, will continue to be charged until they are deleted. For more information, see Stopping an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StopAsync(StopInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a running instance, shutting it down cleanly, and allows you to restart the instance at a later time. Stopped instances do not incur VM usage charges while they are stopped. However, resources that the VM is using, such as persistent disks and static IP addresses, will continue to be charged until they are deleted. For more information, see Stopping an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StopAsync(StopInstanceRequest request, st::CancellationToken cancellationToken) =>
            StopAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation Stop(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> StopAsync(string project, string zone, string instance, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> StopAsync(string project, string zone, string instance, st::CancellationToken cancellationToken) =>
            StopAsync(project, zone, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Updates an instance only if the necessary resources are available. This method can update only a specific set of instance properties. See  Updating a running instance for a list of updatable instance properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Update(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an instance only if the necessary resources are available. This method can update only a specific set of instance properties. See  Updating a running instance for a list of updatable instance properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an instance only if the necessary resources are available. This method can update only a specific set of instance properties. See  Updating a running instance for a list of updatable instance properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateAsync(UpdateInstanceRequest request, st::CancellationToken cancellationToken) =>
            UpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an instance only if the necessary resources are available. This method can update only a specific set of instance properties. See  Updating a running instance for a list of updatable instance properties.
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
        public virtual Operation Update(string project, string zone, string instance, Instance instanceResource, gaxgrpc::CallSettings callSettings = null) =>
            Update(new UpdateInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstanceResource = gax::GaxPreconditions.CheckNotNull(instanceResource, nameof(instanceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Updates an instance only if the necessary resources are available. This method can update only a specific set of instance properties. See  Updating a running instance for a list of updatable instance properties.
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
        public virtual stt::Task<Operation> UpdateAsync(string project, string zone, string instance, Instance instanceResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAsync(new UpdateInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                InstanceResource = gax::GaxPreconditions.CheckNotNull(instanceResource, nameof(instanceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Updates an instance only if the necessary resources are available. This method can update only a specific set of instance properties. See  Updating a running instance for a list of updatable instance properties.
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
        public virtual stt::Task<Operation> UpdateAsync(string project, string zone, string instance, Instance instanceResource, st::CancellationToken cancellationToken) =>
            UpdateAsync(project, zone, instance, instanceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified access config from an instance's network interface with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation UpdateAccessConfig(UpdateAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified access config from an instance's network interface with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateAccessConfigAsync(UpdateAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified access config from an instance's network interface with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateAccessConfigAsync(UpdateAccessConfigInstanceRequest request, st::CancellationToken cancellationToken) =>
            UpdateAccessConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation UpdateAccessConfig(string project, string zone, string instance, string networkInterface, AccessConfig accessConfigResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> UpdateAccessConfigAsync(string project, string zone, string instance, string networkInterface, AccessConfig accessConfigResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> UpdateAccessConfigAsync(string project, string zone, string instance, string networkInterface, AccessConfig accessConfigResource, st::CancellationToken cancellationToken) =>
            UpdateAccessConfigAsync(project, zone, instance, networkInterface, accessConfigResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Display config for a VM instance. You can only use this method on a stopped VM instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation UpdateDisplayDevice(UpdateDisplayDeviceInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Display config for a VM instance. You can only use this method on a stopped VM instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateDisplayDeviceAsync(UpdateDisplayDeviceInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Display config for a VM instance. You can only use this method on a stopped VM instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateDisplayDeviceAsync(UpdateDisplayDeviceInstanceRequest request, st::CancellationToken cancellationToken) =>
            UpdateDisplayDeviceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation UpdateDisplayDevice(string project, string zone, string instance, DisplayDevice displayDeviceResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> UpdateDisplayDeviceAsync(string project, string zone, string instance, DisplayDevice displayDeviceResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> UpdateDisplayDeviceAsync(string project, string zone, string instance, DisplayDevice displayDeviceResource, st::CancellationToken cancellationToken) =>
            UpdateDisplayDeviceAsync(project, zone, instance, displayDeviceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an instance's network interface. This method can only update an interface's alias IP range and attached network. See Modifying alias IP ranges for an existing instance for instructions on changing alias IP ranges. See Migrating a VM between networks for instructions on migrating an interface. This method follows PATCH semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation UpdateNetworkInterface(UpdateNetworkInterfaceInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an instance's network interface. This method can only update an interface's alias IP range and attached network. See Modifying alias IP ranges for an existing instance for instructions on changing alias IP ranges. See Migrating a VM between networks for instructions on migrating an interface. This method follows PATCH semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateNetworkInterfaceAsync(UpdateNetworkInterfaceInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an instance's network interface. This method can only update an interface's alias IP range and attached network. See Modifying alias IP ranges for an existing instance for instructions on changing alias IP ranges. See Migrating a VM between networks for instructions on migrating an interface. This method follows PATCH semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateNetworkInterfaceAsync(UpdateNetworkInterfaceInstanceRequest request, st::CancellationToken cancellationToken) =>
            UpdateNetworkInterfaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation UpdateNetworkInterface(string project, string zone, string instance, string networkInterface, NetworkInterface networkInterfaceResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> UpdateNetworkInterfaceAsync(string project, string zone, string instance, string networkInterface, NetworkInterface networkInterfaceResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> UpdateNetworkInterfaceAsync(string project, string zone, string instance, string networkInterface, NetworkInterface networkInterfaceResource, st::CancellationToken cancellationToken) =>
            UpdateNetworkInterfaceAsync(project, zone, instance, networkInterface, networkInterfaceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Shielded Instance config for an instance. You can only use this method on a stopped instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation UpdateShieldedInstanceConfig(UpdateShieldedInstanceConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Shielded Instance config for an instance. You can only use this method on a stopped instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateShieldedInstanceConfigAsync(UpdateShieldedInstanceConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Shielded Instance config for an instance. You can only use this method on a stopped instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateShieldedInstanceConfigAsync(UpdateShieldedInstanceConfigInstanceRequest request, st::CancellationToken cancellationToken) =>
            UpdateShieldedInstanceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation UpdateShieldedInstanceConfig(string project, string zone, string instance, ShieldedInstanceConfig shieldedInstanceConfigResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> UpdateShieldedInstanceConfigAsync(string project, string zone, string instance, ShieldedInstanceConfig shieldedInstanceConfigResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> UpdateShieldedInstanceConfigAsync(string project, string zone, string instance, ShieldedInstanceConfig shieldedInstanceConfigResource, st::CancellationToken cancellationToken) =>
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

        private readonly gaxgrpc::ApiCall<RemoveResourcePoliciesInstanceRequest, Operation> _callRemoveResourcePolicies;

        private readonly gaxgrpc::ApiCall<ResetInstanceRequest, Operation> _callReset;

        private readonly gaxgrpc::ApiCall<SetDeletionProtectionInstanceRequest, Operation> _callSetDeletionProtection;

        private readonly gaxgrpc::ApiCall<SetDiskAutoDeleteInstanceRequest, Operation> _callSetDiskAutoDelete;

        private readonly gaxgrpc::ApiCall<SetIamPolicyInstanceRequest, Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<SetLabelsInstanceRequest, Operation> _callSetLabels;

        private readonly gaxgrpc::ApiCall<SetMachineResourcesInstanceRequest, Operation> _callSetMachineResources;

        private readonly gaxgrpc::ApiCall<SetMachineTypeInstanceRequest, Operation> _callSetMachineType;

        private readonly gaxgrpc::ApiCall<SetMetadataInstanceRequest, Operation> _callSetMetadata;

        private readonly gaxgrpc::ApiCall<SetMinCpuPlatformInstanceRequest, Operation> _callSetMinCpuPlatform;

        private readonly gaxgrpc::ApiCall<SetSchedulingInstanceRequest, Operation> _callSetScheduling;

        private readonly gaxgrpc::ApiCall<SetServiceAccountInstanceRequest, Operation> _callSetServiceAccount;

        private readonly gaxgrpc::ApiCall<SetShieldedInstanceIntegrityPolicyInstanceRequest, Operation> _callSetShieldedInstanceIntegrityPolicy;

        private readonly gaxgrpc::ApiCall<SetTagsInstanceRequest, Operation> _callSetTags;

        private readonly gaxgrpc::ApiCall<SimulateMaintenanceEventInstanceRequest, Operation> _callSimulateMaintenanceEvent;

        private readonly gaxgrpc::ApiCall<StartInstanceRequest, Operation> _callStart;

        private readonly gaxgrpc::ApiCall<StartWithEncryptionKeyInstanceRequest, Operation> _callStartWithEncryptionKey;

        private readonly gaxgrpc::ApiCall<StopInstanceRequest, Operation> _callStop;

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
        public InstancesClientImpl(Instances.InstancesClient grpcClient, InstancesSettings settings)
        {
            GrpcClient = grpcClient;
            InstancesSettings effectiveSettings = settings ?? InstancesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            InsertOperationsClient = new ZonalLroClient(grpcClient.CreateZoneOperationsClient(), effectiveSettings.InsertOperationsSettings);
            _callAddAccessConfig = clientHelper.BuildApiCall<AddAccessConfigInstanceRequest, Operation>(grpcClient.AddAccessConfigAsync, grpcClient.AddAccessConfig, effectiveSettings.AddAccessConfigSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callAddAccessConfig);
            Modify_AddAccessConfigApiCall(ref _callAddAccessConfig);
            _callAddResourcePolicies = clientHelper.BuildApiCall<AddResourcePoliciesInstanceRequest, Operation>(grpcClient.AddResourcePoliciesAsync, grpcClient.AddResourcePolicies, effectiveSettings.AddResourcePoliciesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callAddResourcePolicies);
            Modify_AddResourcePoliciesApiCall(ref _callAddResourcePolicies);
            _callAggregatedList = clientHelper.BuildApiCall<AggregatedListInstancesRequest, InstanceAggregatedList>(grpcClient.AggregatedListAsync, grpcClient.AggregatedList, effectiveSettings.AggregatedListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callAggregatedList);
            Modify_AggregatedListApiCall(ref _callAggregatedList);
            _callAttachDisk = clientHelper.BuildApiCall<AttachDiskInstanceRequest, Operation>(grpcClient.AttachDiskAsync, grpcClient.AttachDisk, effectiveSettings.AttachDiskSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callAttachDisk);
            Modify_AttachDiskApiCall(ref _callAttachDisk);
            _callBulkInsert = clientHelper.BuildApiCall<BulkInsertInstanceRequest, Operation>(grpcClient.BulkInsertAsync, grpcClient.BulkInsert, effectiveSettings.BulkInsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone);
            Modify_ApiCall(ref _callBulkInsert);
            Modify_BulkInsertApiCall(ref _callBulkInsert);
            _callDelete = clientHelper.BuildApiCall<DeleteInstanceRequest, Operation>(grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callDeleteAccessConfig = clientHelper.BuildApiCall<DeleteAccessConfigInstanceRequest, Operation>(grpcClient.DeleteAccessConfigAsync, grpcClient.DeleteAccessConfig, effectiveSettings.DeleteAccessConfigSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callDeleteAccessConfig);
            Modify_DeleteAccessConfigApiCall(ref _callDeleteAccessConfig);
            _callDetachDisk = clientHelper.BuildApiCall<DetachDiskInstanceRequest, Operation>(grpcClient.DetachDiskAsync, grpcClient.DetachDisk, effectiveSettings.DetachDiskSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callDetachDisk);
            Modify_DetachDiskApiCall(ref _callDetachDisk);
            _callGet = clientHelper.BuildApiCall<GetInstanceRequest, Instance>(grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callGetEffectiveFirewalls = clientHelper.BuildApiCall<GetEffectiveFirewallsInstanceRequest, InstancesGetEffectiveFirewallsResponse>(grpcClient.GetEffectiveFirewallsAsync, grpcClient.GetEffectiveFirewalls, effectiveSettings.GetEffectiveFirewallsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callGetEffectiveFirewalls);
            Modify_GetEffectiveFirewallsApiCall(ref _callGetEffectiveFirewalls);
            _callGetGuestAttributes = clientHelper.BuildApiCall<GetGuestAttributesInstanceRequest, GuestAttributes>(grpcClient.GetGuestAttributesAsync, grpcClient.GetGuestAttributes, effectiveSettings.GetGuestAttributesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callGetGuestAttributes);
            Modify_GetGuestAttributesApiCall(ref _callGetGuestAttributes);
            _callGetIamPolicy = clientHelper.BuildApiCall<GetIamPolicyInstanceRequest, Policy>(grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callGetScreenshot = clientHelper.BuildApiCall<GetScreenshotInstanceRequest, Screenshot>(grpcClient.GetScreenshotAsync, grpcClient.GetScreenshot, effectiveSettings.GetScreenshotSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callGetScreenshot);
            Modify_GetScreenshotApiCall(ref _callGetScreenshot);
            _callGetSerialPortOutput = clientHelper.BuildApiCall<GetSerialPortOutputInstanceRequest, SerialPortOutput>(grpcClient.GetSerialPortOutputAsync, grpcClient.GetSerialPortOutput, effectiveSettings.GetSerialPortOutputSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callGetSerialPortOutput);
            Modify_GetSerialPortOutputApiCall(ref _callGetSerialPortOutput);
            _callGetShieldedInstanceIdentity = clientHelper.BuildApiCall<GetShieldedInstanceIdentityInstanceRequest, ShieldedInstanceIdentity>(grpcClient.GetShieldedInstanceIdentityAsync, grpcClient.GetShieldedInstanceIdentity, effectiveSettings.GetShieldedInstanceIdentitySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callGetShieldedInstanceIdentity);
            Modify_GetShieldedInstanceIdentityApiCall(ref _callGetShieldedInstanceIdentity);
            _callInsert = clientHelper.BuildApiCall<InsertInstanceRequest, Operation>(grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListInstancesRequest, InstanceList>(grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callListReferrers = clientHelper.BuildApiCall<ListReferrersInstancesRequest, InstanceListReferrers>(grpcClient.ListReferrersAsync, grpcClient.ListReferrers, effectiveSettings.ListReferrersSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callListReferrers);
            Modify_ListReferrersApiCall(ref _callListReferrers);
            _callRemoveResourcePolicies = clientHelper.BuildApiCall<RemoveResourcePoliciesInstanceRequest, Operation>(grpcClient.RemoveResourcePoliciesAsync, grpcClient.RemoveResourcePolicies, effectiveSettings.RemoveResourcePoliciesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callRemoveResourcePolicies);
            Modify_RemoveResourcePoliciesApiCall(ref _callRemoveResourcePolicies);
            _callReset = clientHelper.BuildApiCall<ResetInstanceRequest, Operation>(grpcClient.ResetAsync, grpcClient.Reset, effectiveSettings.ResetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callReset);
            Modify_ResetApiCall(ref _callReset);
            _callSetDeletionProtection = clientHelper.BuildApiCall<SetDeletionProtectionInstanceRequest, Operation>(grpcClient.SetDeletionProtectionAsync, grpcClient.SetDeletionProtection, effectiveSettings.SetDeletionProtectionSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetDeletionProtection);
            Modify_SetDeletionProtectionApiCall(ref _callSetDeletionProtection);
            _callSetDiskAutoDelete = clientHelper.BuildApiCall<SetDiskAutoDeleteInstanceRequest, Operation>(grpcClient.SetDiskAutoDeleteAsync, grpcClient.SetDiskAutoDelete, effectiveSettings.SetDiskAutoDeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetDiskAutoDelete);
            Modify_SetDiskAutoDeleteApiCall(ref _callSetDiskAutoDelete);
            _callSetIamPolicy = clientHelper.BuildApiCall<SetIamPolicyInstanceRequest, Policy>(grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callSetLabels = clientHelper.BuildApiCall<SetLabelsInstanceRequest, Operation>(grpcClient.SetLabelsAsync, grpcClient.SetLabels, effectiveSettings.SetLabelsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetLabels);
            Modify_SetLabelsApiCall(ref _callSetLabels);
            _callSetMachineResources = clientHelper.BuildApiCall<SetMachineResourcesInstanceRequest, Operation>(grpcClient.SetMachineResourcesAsync, grpcClient.SetMachineResources, effectiveSettings.SetMachineResourcesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetMachineResources);
            Modify_SetMachineResourcesApiCall(ref _callSetMachineResources);
            _callSetMachineType = clientHelper.BuildApiCall<SetMachineTypeInstanceRequest, Operation>(grpcClient.SetMachineTypeAsync, grpcClient.SetMachineType, effectiveSettings.SetMachineTypeSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetMachineType);
            Modify_SetMachineTypeApiCall(ref _callSetMachineType);
            _callSetMetadata = clientHelper.BuildApiCall<SetMetadataInstanceRequest, Operation>(grpcClient.SetMetadataAsync, grpcClient.SetMetadata, effectiveSettings.SetMetadataSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetMetadata);
            Modify_SetMetadataApiCall(ref _callSetMetadata);
            _callSetMinCpuPlatform = clientHelper.BuildApiCall<SetMinCpuPlatformInstanceRequest, Operation>(grpcClient.SetMinCpuPlatformAsync, grpcClient.SetMinCpuPlatform, effectiveSettings.SetMinCpuPlatformSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetMinCpuPlatform);
            Modify_SetMinCpuPlatformApiCall(ref _callSetMinCpuPlatform);
            _callSetScheduling = clientHelper.BuildApiCall<SetSchedulingInstanceRequest, Operation>(grpcClient.SetSchedulingAsync, grpcClient.SetScheduling, effectiveSettings.SetSchedulingSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetScheduling);
            Modify_SetSchedulingApiCall(ref _callSetScheduling);
            _callSetServiceAccount = clientHelper.BuildApiCall<SetServiceAccountInstanceRequest, Operation>(grpcClient.SetServiceAccountAsync, grpcClient.SetServiceAccount, effectiveSettings.SetServiceAccountSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetServiceAccount);
            Modify_SetServiceAccountApiCall(ref _callSetServiceAccount);
            _callSetShieldedInstanceIntegrityPolicy = clientHelper.BuildApiCall<SetShieldedInstanceIntegrityPolicyInstanceRequest, Operation>(grpcClient.SetShieldedInstanceIntegrityPolicyAsync, grpcClient.SetShieldedInstanceIntegrityPolicy, effectiveSettings.SetShieldedInstanceIntegrityPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetShieldedInstanceIntegrityPolicy);
            Modify_SetShieldedInstanceIntegrityPolicyApiCall(ref _callSetShieldedInstanceIntegrityPolicy);
            _callSetTags = clientHelper.BuildApiCall<SetTagsInstanceRequest, Operation>(grpcClient.SetTagsAsync, grpcClient.SetTags, effectiveSettings.SetTagsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSetTags);
            Modify_SetTagsApiCall(ref _callSetTags);
            _callSimulateMaintenanceEvent = clientHelper.BuildApiCall<SimulateMaintenanceEventInstanceRequest, Operation>(grpcClient.SimulateMaintenanceEventAsync, grpcClient.SimulateMaintenanceEvent, effectiveSettings.SimulateMaintenanceEventSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSimulateMaintenanceEvent);
            Modify_SimulateMaintenanceEventApiCall(ref _callSimulateMaintenanceEvent);
            _callStart = clientHelper.BuildApiCall<StartInstanceRequest, Operation>(grpcClient.StartAsync, grpcClient.Start, effectiveSettings.StartSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callStart);
            Modify_StartApiCall(ref _callStart);
            _callStartWithEncryptionKey = clientHelper.BuildApiCall<StartWithEncryptionKeyInstanceRequest, Operation>(grpcClient.StartWithEncryptionKeyAsync, grpcClient.StartWithEncryptionKey, effectiveSettings.StartWithEncryptionKeySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callStartWithEncryptionKey);
            Modify_StartWithEncryptionKeyApiCall(ref _callStartWithEncryptionKey);
            _callStop = clientHelper.BuildApiCall<StopInstanceRequest, Operation>(grpcClient.StopAsync, grpcClient.Stop, effectiveSettings.StopSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callStop);
            Modify_StopApiCall(ref _callStop);
            _callTestIamPermissions = clientHelper.BuildApiCall<TestIamPermissionsInstanceRequest, TestPermissionsResponse>(grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            _callUpdate = clientHelper.BuildApiCall<UpdateInstanceRequest, Operation>(grpcClient.UpdateAsync, grpcClient.Update, effectiveSettings.UpdateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callUpdate);
            Modify_UpdateApiCall(ref _callUpdate);
            _callUpdateAccessConfig = clientHelper.BuildApiCall<UpdateAccessConfigInstanceRequest, Operation>(grpcClient.UpdateAccessConfigAsync, grpcClient.UpdateAccessConfig, effectiveSettings.UpdateAccessConfigSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callUpdateAccessConfig);
            Modify_UpdateAccessConfigApiCall(ref _callUpdateAccessConfig);
            _callUpdateDisplayDevice = clientHelper.BuildApiCall<UpdateDisplayDeviceInstanceRequest, Operation>(grpcClient.UpdateDisplayDeviceAsync, grpcClient.UpdateDisplayDevice, effectiveSettings.UpdateDisplayDeviceSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callUpdateDisplayDevice);
            Modify_UpdateDisplayDeviceApiCall(ref _callUpdateDisplayDevice);
            _callUpdateNetworkInterface = clientHelper.BuildApiCall<UpdateNetworkInterfaceInstanceRequest, Operation>(grpcClient.UpdateNetworkInterfaceAsync, grpcClient.UpdateNetworkInterface, effectiveSettings.UpdateNetworkInterfaceSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callUpdateNetworkInterface);
            Modify_UpdateNetworkInterfaceApiCall(ref _callUpdateNetworkInterface);
            _callUpdateShieldedInstanceConfig = clientHelper.BuildApiCall<UpdateShieldedInstanceConfigInstanceRequest, Operation>(grpcClient.UpdateShieldedInstanceConfigAsync, grpcClient.UpdateShieldedInstanceConfig, effectiveSettings.UpdateShieldedInstanceConfigSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance", request => request.Instance);
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

        partial void Modify_RemoveResourcePoliciesApiCall(ref gaxgrpc::ApiCall<RemoveResourcePoliciesInstanceRequest, Operation> call);

        partial void Modify_ResetApiCall(ref gaxgrpc::ApiCall<ResetInstanceRequest, Operation> call);

        partial void Modify_SetDeletionProtectionApiCall(ref gaxgrpc::ApiCall<SetDeletionProtectionInstanceRequest, Operation> call);

        partial void Modify_SetDiskAutoDeleteApiCall(ref gaxgrpc::ApiCall<SetDiskAutoDeleteInstanceRequest, Operation> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<SetIamPolicyInstanceRequest, Policy> call);

        partial void Modify_SetLabelsApiCall(ref gaxgrpc::ApiCall<SetLabelsInstanceRequest, Operation> call);

        partial void Modify_SetMachineResourcesApiCall(ref gaxgrpc::ApiCall<SetMachineResourcesInstanceRequest, Operation> call);

        partial void Modify_SetMachineTypeApiCall(ref gaxgrpc::ApiCall<SetMachineTypeInstanceRequest, Operation> call);

        partial void Modify_SetMetadataApiCall(ref gaxgrpc::ApiCall<SetMetadataInstanceRequest, Operation> call);

        partial void Modify_SetMinCpuPlatformApiCall(ref gaxgrpc::ApiCall<SetMinCpuPlatformInstanceRequest, Operation> call);

        partial void Modify_SetSchedulingApiCall(ref gaxgrpc::ApiCall<SetSchedulingInstanceRequest, Operation> call);

        partial void Modify_SetServiceAccountApiCall(ref gaxgrpc::ApiCall<SetServiceAccountInstanceRequest, Operation> call);

        partial void Modify_SetShieldedInstanceIntegrityPolicyApiCall(ref gaxgrpc::ApiCall<SetShieldedInstanceIntegrityPolicyInstanceRequest, Operation> call);

        partial void Modify_SetTagsApiCall(ref gaxgrpc::ApiCall<SetTagsInstanceRequest, Operation> call);

        partial void Modify_SimulateMaintenanceEventApiCall(ref gaxgrpc::ApiCall<SimulateMaintenanceEventInstanceRequest, Operation> call);

        partial void Modify_StartApiCall(ref gaxgrpc::ApiCall<StartInstanceRequest, Operation> call);

        partial void Modify_StartWithEncryptionKeyApiCall(ref gaxgrpc::ApiCall<StartWithEncryptionKeyInstanceRequest, Operation> call);

        partial void Modify_StopApiCall(ref gaxgrpc::ApiCall<StopInstanceRequest, Operation> call);

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

        partial void Modify_RemoveResourcePoliciesInstanceRequest(ref RemoveResourcePoliciesInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResetInstanceRequest(ref ResetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetDeletionProtectionInstanceRequest(ref SetDeletionProtectionInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetDiskAutoDeleteInstanceRequest(ref SetDiskAutoDeleteInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyInstanceRequest(ref SetIamPolicyInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetLabelsInstanceRequest(ref SetLabelsInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetMachineResourcesInstanceRequest(ref SetMachineResourcesInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetMachineTypeInstanceRequest(ref SetMachineTypeInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetMetadataInstanceRequest(ref SetMetadataInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetMinCpuPlatformInstanceRequest(ref SetMinCpuPlatformInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetSchedulingInstanceRequest(ref SetSchedulingInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetServiceAccountInstanceRequest(ref SetServiceAccountInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetShieldedInstanceIntegrityPolicyInstanceRequest(ref SetShieldedInstanceIntegrityPolicyInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetTagsInstanceRequest(ref SetTagsInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SimulateMaintenanceEventInstanceRequest(ref SimulateMaintenanceEventInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartInstanceRequest(ref StartInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartWithEncryptionKeyInstanceRequest(ref StartWithEncryptionKeyInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopInstanceRequest(ref StopInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsInstanceRequest(ref TestIamPermissionsInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInstanceRequest(ref UpdateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAccessConfigInstanceRequest(ref UpdateAccessConfigInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDisplayDeviceInstanceRequest(ref UpdateDisplayDeviceInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateNetworkInterfaceInstanceRequest(ref UpdateNetworkInterfaceInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateShieldedInstanceConfigInstanceRequest(ref UpdateShieldedInstanceConfigInstanceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Adds an access config to an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation AddAccessConfig(AddAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddAccessConfigInstanceRequest(ref request, ref callSettings);
            return _callAddAccessConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds an access config to an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> AddAccessConfigAsync(AddAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddAccessConfigInstanceRequest(ref request, ref callSettings);
            return _callAddAccessConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Adds existing resource policies to an instance. You can only add one policy right now which will be applied to this instance for scheduling live migrations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation AddResourcePolicies(AddResourcePoliciesInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddResourcePoliciesInstanceRequest(ref request, ref callSettings);
            return _callAddResourcePolicies.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds existing resource policies to an instance. You can only add one policy right now which will be applied to this instance for scheduling live migrations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> AddResourcePoliciesAsync(AddResourcePoliciesInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddResourcePoliciesInstanceRequest(ref request, ref callSettings);
            return _callAddResourcePolicies.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves aggregated list of all of the instances in your project across all regions and zones.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InstanceAggregatedList AggregatedList(AggregatedListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListInstancesRequest(ref request, ref callSettings);
            return _callAggregatedList.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves aggregated list of all of the instances in your project across all regions and zones.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InstanceAggregatedList> AggregatedListAsync(AggregatedListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListInstancesRequest(ref request, ref callSettings);
            return _callAggregatedList.Async(request, callSettings);
        }

        /// <summary>
        /// Attaches an existing Disk resource to an instance. You must first create the disk before you can attach it. It is not possible to create and attach a disk at the same time. For more information, read Adding a persistent disk to your instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation AttachDisk(AttachDiskInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AttachDiskInstanceRequest(ref request, ref callSettings);
            return _callAttachDisk.Sync(request, callSettings);
        }

        /// <summary>
        /// Attaches an existing Disk resource to an instance. You must first create the disk before you can attach it. It is not possible to create and attach a disk at the same time. For more information, read Adding a persistent disk to your instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> AttachDiskAsync(AttachDiskInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AttachDiskInstanceRequest(ref request, ref callSettings);
            return _callAttachDisk.Async(request, callSettings);
        }

        /// <summary>
        /// Creates multiple instances. Count specifies the number of instances to create.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation BulkInsert(BulkInsertInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkInsertInstanceRequest(ref request, ref callSettings);
            return _callBulkInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates multiple instances. Count specifies the number of instances to create.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> BulkInsertAsync(BulkInsertInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkInsertInstanceRequest(ref request, ref callSettings);
            return _callBulkInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified Instance resource. For more information, see Deleting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified Instance resource. For more information, see Deleting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an access config from an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation DeleteAccessConfig(DeleteAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAccessConfigInstanceRequest(ref request, ref callSettings);
            return _callDeleteAccessConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an access config from an instance's network interface.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAccessConfigAsync(DeleteAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAccessConfigInstanceRequest(ref request, ref callSettings);
            return _callDeleteAccessConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Detaches a disk from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation DetachDisk(DetachDiskInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetachDiskInstanceRequest(ref request, ref callSettings);
            return _callDetachDisk.Sync(request, callSettings);
        }

        /// <summary>
        /// Detaches a disk from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DetachDiskAsync(DetachDiskInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetachDiskInstanceRequest(ref request, ref callSettings);
            return _callDetachDisk.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the specified Instance resource. Gets a list of available instances by making a list() request.
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
        /// Returns the specified Instance resource. Gets a list of available instances by making a list() request.
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
            return OperationAdapter.CreateZonalOperation(_callInsert.Sync(request, callSettings), request.Project, request.Zone, InsertOperationsClient);
        }

        /// <summary>
        /// Creates an instance resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public async override stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertInstanceRequest(ref request, ref callSettings);
            var operation = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            return OperationAdapter.CreateZonalOperation(operation, request.Project, request.Zone, InsertOperationsClient);
        }

        /// <summary>
        /// Retrieves the list of instances contained within the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InstanceList List(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return _callList.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of instances contained within the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InstanceList> ListAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return _callList.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of resources that refer to the VM instance specified in the request. For example, if the VM instance is part of a managed or unmanaged instance group, the referrers list includes the instance group. For more information, read Viewing referrers to VM instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InstanceListReferrers ListReferrers(ListReferrersInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReferrersInstancesRequest(ref request, ref callSettings);
            return _callListReferrers.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of resources that refer to the VM instance specified in the request. For example, if the VM instance is part of a managed or unmanaged instance group, the referrers list includes the instance group. For more information, read Viewing referrers to VM instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InstanceListReferrers> ListReferrersAsync(ListReferrersInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReferrersInstancesRequest(ref request, ref callSettings);
            return _callListReferrers.Async(request, callSettings);
        }

        /// <summary>
        /// Removes resource policies from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation RemoveResourcePolicies(RemoveResourcePoliciesInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveResourcePoliciesInstanceRequest(ref request, ref callSettings);
            return _callRemoveResourcePolicies.Sync(request, callSettings);
        }

        /// <summary>
        /// Removes resource policies from an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> RemoveResourcePoliciesAsync(RemoveResourcePoliciesInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveResourcePoliciesInstanceRequest(ref request, ref callSettings);
            return _callRemoveResourcePolicies.Async(request, callSettings);
        }

        /// <summary>
        /// Performs a reset on the instance. This is a hard reset the VM does not do a graceful shutdown. For more information, see Resetting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Reset(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetInstanceRequest(ref request, ref callSettings);
            return _callReset.Sync(request, callSettings);
        }

        /// <summary>
        /// Performs a reset on the instance. This is a hard reset the VM does not do a graceful shutdown. For more information, see Resetting an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> ResetAsync(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetInstanceRequest(ref request, ref callSettings);
            return _callReset.Async(request, callSettings);
        }

        /// <summary>
        /// Sets deletion protection on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetDeletionProtection(SetDeletionProtectionInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDeletionProtectionInstanceRequest(ref request, ref callSettings);
            return _callSetDeletionProtection.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets deletion protection on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetDeletionProtectionAsync(SetDeletionProtectionInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDeletionProtectionInstanceRequest(ref request, ref callSettings);
            return _callSetDeletionProtection.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the auto-delete flag for a disk attached to an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetDiskAutoDelete(SetDiskAutoDeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDiskAutoDeleteInstanceRequest(ref request, ref callSettings);
            return _callSetDiskAutoDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the auto-delete flag for a disk attached to an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetDiskAutoDeleteAsync(SetDiskAutoDeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDiskAutoDeleteInstanceRequest(ref request, ref callSettings);
            return _callSetDiskAutoDelete.Async(request, callSettings);
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

        /// <summary>
        /// Sets labels on an instance. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetLabels(SetLabelsInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetLabelsInstanceRequest(ref request, ref callSettings);
            return _callSetLabels.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets labels on an instance. To learn more about labels, read the Labeling Resources documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetLabelsAsync(SetLabelsInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetLabelsInstanceRequest(ref request, ref callSettings);
            return _callSetLabels.Async(request, callSettings);
        }

        /// <summary>
        /// Changes the number and/or type of accelerator for a stopped instance to the values specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetMachineResources(SetMachineResourcesInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMachineResourcesInstanceRequest(ref request, ref callSettings);
            return _callSetMachineResources.Sync(request, callSettings);
        }

        /// <summary>
        /// Changes the number and/or type of accelerator for a stopped instance to the values specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetMachineResourcesAsync(SetMachineResourcesInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMachineResourcesInstanceRequest(ref request, ref callSettings);
            return _callSetMachineResources.Async(request, callSettings);
        }

        /// <summary>
        /// Changes the machine type for a stopped instance to the machine type specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetMachineType(SetMachineTypeInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMachineTypeInstanceRequest(ref request, ref callSettings);
            return _callSetMachineType.Sync(request, callSettings);
        }

        /// <summary>
        /// Changes the machine type for a stopped instance to the machine type specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetMachineTypeAsync(SetMachineTypeInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMachineTypeInstanceRequest(ref request, ref callSettings);
            return _callSetMachineType.Async(request, callSettings);
        }

        /// <summary>
        /// Sets metadata for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetMetadata(SetMetadataInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMetadataInstanceRequest(ref request, ref callSettings);
            return _callSetMetadata.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets metadata for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetMetadataAsync(SetMetadataInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMetadataInstanceRequest(ref request, ref callSettings);
            return _callSetMetadata.Async(request, callSettings);
        }

        /// <summary>
        /// Changes the minimum CPU platform that this instance should use. This method can only be called on a stopped instance. For more information, read Specifying a Minimum CPU Platform.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetMinCpuPlatform(SetMinCpuPlatformInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMinCpuPlatformInstanceRequest(ref request, ref callSettings);
            return _callSetMinCpuPlatform.Sync(request, callSettings);
        }

        /// <summary>
        /// Changes the minimum CPU platform that this instance should use. This method can only be called on a stopped instance. For more information, read Specifying a Minimum CPU Platform.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetMinCpuPlatformAsync(SetMinCpuPlatformInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMinCpuPlatformInstanceRequest(ref request, ref callSettings);
            return _callSetMinCpuPlatform.Async(request, callSettings);
        }

        /// <summary>
        /// Sets an instance's scheduling options. You can only call this method on a stopped instance, that is, a VM instance that is in a `TERMINATED` state. See Instance Life Cycle for more information on the possible instance states.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetScheduling(SetSchedulingInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSchedulingInstanceRequest(ref request, ref callSettings);
            return _callSetScheduling.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets an instance's scheduling options. You can only call this method on a stopped instance, that is, a VM instance that is in a `TERMINATED` state. See Instance Life Cycle for more information on the possible instance states.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetSchedulingAsync(SetSchedulingInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSchedulingInstanceRequest(ref request, ref callSettings);
            return _callSetScheduling.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the service account on the instance. For more information, read Changing the service account and access scopes for an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetServiceAccount(SetServiceAccountInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetServiceAccountInstanceRequest(ref request, ref callSettings);
            return _callSetServiceAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the service account on the instance. For more information, read Changing the service account and access scopes for an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetServiceAccountAsync(SetServiceAccountInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetServiceAccountInstanceRequest(ref request, ref callSettings);
            return _callSetServiceAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the Shielded Instance integrity policy for an instance. You can only use this method on a running instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetShieldedInstanceIntegrityPolicy(SetShieldedInstanceIntegrityPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetShieldedInstanceIntegrityPolicyInstanceRequest(ref request, ref callSettings);
            return _callSetShieldedInstanceIntegrityPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the Shielded Instance integrity policy for an instance. You can only use this method on a running instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetShieldedInstanceIntegrityPolicyAsync(SetShieldedInstanceIntegrityPolicyInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetShieldedInstanceIntegrityPolicyInstanceRequest(ref request, ref callSettings);
            return _callSetShieldedInstanceIntegrityPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets network tags for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetTags(SetTagsInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetTagsInstanceRequest(ref request, ref callSettings);
            return _callSetTags.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets network tags for the specified instance to the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetTagsAsync(SetTagsInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetTagsInstanceRequest(ref request, ref callSettings);
            return _callSetTags.Async(request, callSettings);
        }

        /// <summary>
        /// Simulates a maintenance event on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SimulateMaintenanceEvent(SimulateMaintenanceEventInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SimulateMaintenanceEventInstanceRequest(ref request, ref callSettings);
            return _callSimulateMaintenanceEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Simulates a maintenance event on the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SimulateMaintenanceEventAsync(SimulateMaintenanceEventInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SimulateMaintenanceEventInstanceRequest(ref request, ref callSettings);
            return _callSimulateMaintenanceEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Start(StartInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartInstanceRequest(ref request, ref callSettings);
            return _callStart.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> StartAsync(StartInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartInstanceRequest(ref request, ref callSettings);
            return _callStart.Async(request, callSettings);
        }

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation StartWithEncryptionKey(StartWithEncryptionKeyInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartWithEncryptionKeyInstanceRequest(ref request, ref callSettings);
            return _callStartWithEncryptionKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts an instance that was stopped using the instances().stop method. For more information, see Restart an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> StartWithEncryptionKeyAsync(StartWithEncryptionKeyInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartWithEncryptionKeyInstanceRequest(ref request, ref callSettings);
            return _callStartWithEncryptionKey.Async(request, callSettings);
        }

        /// <summary>
        /// Stops a running instance, shutting it down cleanly, and allows you to restart the instance at a later time. Stopped instances do not incur VM usage charges while they are stopped. However, resources that the VM is using, such as persistent disks and static IP addresses, will continue to be charged until they are deleted. For more information, see Stopping an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Stop(StopInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopInstanceRequest(ref request, ref callSettings);
            return _callStop.Sync(request, callSettings);
        }

        /// <summary>
        /// Stops a running instance, shutting it down cleanly, and allows you to restart the instance at a later time. Stopped instances do not incur VM usage charges while they are stopped. However, resources that the VM is using, such as persistent disks and static IP addresses, will continue to be charged until they are deleted. For more information, see Stopping an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> StopAsync(StopInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopInstanceRequest(ref request, ref callSettings);
            return _callStop.Async(request, callSettings);
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

        /// <summary>
        /// Updates an instance only if the necessary resources are available. This method can update only a specific set of instance properties. See  Updating a running instance for a list of updatable instance properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Update(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return _callUpdate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an instance only if the necessary resources are available. This method can update only a specific set of instance properties. See  Updating a running instance for a list of updatable instance properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> UpdateAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return _callUpdate.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified access config from an instance's network interface with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation UpdateAccessConfig(UpdateAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccessConfigInstanceRequest(ref request, ref callSettings);
            return _callUpdateAccessConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified access config from an instance's network interface with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> UpdateAccessConfigAsync(UpdateAccessConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccessConfigInstanceRequest(ref request, ref callSettings);
            return _callUpdateAccessConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the Display config for a VM instance. You can only use this method on a stopped VM instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation UpdateDisplayDevice(UpdateDisplayDeviceInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDisplayDeviceInstanceRequest(ref request, ref callSettings);
            return _callUpdateDisplayDevice.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the Display config for a VM instance. You can only use this method on a stopped VM instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> UpdateDisplayDeviceAsync(UpdateDisplayDeviceInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDisplayDeviceInstanceRequest(ref request, ref callSettings);
            return _callUpdateDisplayDevice.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an instance's network interface. This method can only update an interface's alias IP range and attached network. See Modifying alias IP ranges for an existing instance for instructions on changing alias IP ranges. See Migrating a VM between networks for instructions on migrating an interface. This method follows PATCH semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation UpdateNetworkInterface(UpdateNetworkInterfaceInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNetworkInterfaceInstanceRequest(ref request, ref callSettings);
            return _callUpdateNetworkInterface.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an instance's network interface. This method can only update an interface's alias IP range and attached network. See Modifying alias IP ranges for an existing instance for instructions on changing alias IP ranges. See Migrating a VM between networks for instructions on migrating an interface. This method follows PATCH semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> UpdateNetworkInterfaceAsync(UpdateNetworkInterfaceInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNetworkInterfaceInstanceRequest(ref request, ref callSettings);
            return _callUpdateNetworkInterface.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the Shielded Instance config for an instance. You can only use this method on a stopped instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation UpdateShieldedInstanceConfig(UpdateShieldedInstanceConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateShieldedInstanceConfigInstanceRequest(ref request, ref callSettings);
            return _callUpdateShieldedInstanceConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the Shielded Instance config for an instance. You can only use this method on a stopped instance. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> UpdateShieldedInstanceConfigAsync(UpdateShieldedInstanceConfigInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateShieldedInstanceConfigInstanceRequest(ref request, ref callSettings);
            return _callUpdateShieldedInstanceConfig.Async(request, callSettings);
        }
    }

    public static partial class Instances
    {
        public partial class InstancesClient
        {
            /// <summary>
            /// TODO: Documentation
            /// </summary>
            /// <returns></returns>
            internal virtual ZoneOperations.ZoneOperationsClient CreateZoneOperationsClient() =>
                new ZoneOperations.ZoneOperationsClient(CallInvoker);
        }
    }
}
