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
using gcl = Google.Cloud.Location;
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

namespace Google.Cloud.BareMetalSolution.V2
{
    /// <summary>Settings for <see cref="BareMetalSolutionClient"/> instances.</summary>
    public sealed partial class BareMetalSolutionSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BareMetalSolutionSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BareMetalSolutionSettings"/>.</returns>
        public static BareMetalSolutionSettings GetDefault() => new BareMetalSolutionSettings();

        /// <summary>Constructs a new <see cref="BareMetalSolutionSettings"/> object with default settings.</summary>
        public BareMetalSolutionSettings()
        {
        }

        private BareMetalSolutionSettings(BareMetalSolutionSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListInstancesSettings = existing.ListInstancesSettings;
            GetInstanceSettings = existing.GetInstanceSettings;
            UpdateInstanceSettings = existing.UpdateInstanceSettings;
            UpdateInstanceOperationsSettings = existing.UpdateInstanceOperationsSettings.Clone();
            RenameInstanceSettings = existing.RenameInstanceSettings;
            ResetInstanceSettings = existing.ResetInstanceSettings;
            ResetInstanceOperationsSettings = existing.ResetInstanceOperationsSettings.Clone();
            StartInstanceSettings = existing.StartInstanceSettings;
            StartInstanceOperationsSettings = existing.StartInstanceOperationsSettings.Clone();
            StopInstanceSettings = existing.StopInstanceSettings;
            StopInstanceOperationsSettings = existing.StopInstanceOperationsSettings.Clone();
            EnableInteractiveSerialConsoleSettings = existing.EnableInteractiveSerialConsoleSettings;
            EnableInteractiveSerialConsoleOperationsSettings = existing.EnableInteractiveSerialConsoleOperationsSettings.Clone();
            DisableInteractiveSerialConsoleSettings = existing.DisableInteractiveSerialConsoleSettings;
            DisableInteractiveSerialConsoleOperationsSettings = existing.DisableInteractiveSerialConsoleOperationsSettings.Clone();
            DetachLunSettings = existing.DetachLunSettings;
            DetachLunOperationsSettings = existing.DetachLunOperationsSettings.Clone();
            ListSSHKeysSettings = existing.ListSSHKeysSettings;
            CreateSSHKeySettings = existing.CreateSSHKeySettings;
            DeleteSSHKeySettings = existing.DeleteSSHKeySettings;
            ListVolumesSettings = existing.ListVolumesSettings;
            GetVolumeSettings = existing.GetVolumeSettings;
            UpdateVolumeSettings = existing.UpdateVolumeSettings;
            UpdateVolumeOperationsSettings = existing.UpdateVolumeOperationsSettings.Clone();
            RenameVolumeSettings = existing.RenameVolumeSettings;
            EvictVolumeSettings = existing.EvictVolumeSettings;
            EvictVolumeOperationsSettings = existing.EvictVolumeOperationsSettings.Clone();
            ResizeVolumeSettings = existing.ResizeVolumeSettings;
            ResizeVolumeOperationsSettings = existing.ResizeVolumeOperationsSettings.Clone();
            ListNetworksSettings = existing.ListNetworksSettings;
            ListNetworkUsageSettings = existing.ListNetworkUsageSettings;
            GetNetworkSettings = existing.GetNetworkSettings;
            UpdateNetworkSettings = existing.UpdateNetworkSettings;
            UpdateNetworkOperationsSettings = existing.UpdateNetworkOperationsSettings.Clone();
            CreateVolumeSnapshotSettings = existing.CreateVolumeSnapshotSettings;
            RestoreVolumeSnapshotSettings = existing.RestoreVolumeSnapshotSettings;
            RestoreVolumeSnapshotOperationsSettings = existing.RestoreVolumeSnapshotOperationsSettings.Clone();
            DeleteVolumeSnapshotSettings = existing.DeleteVolumeSnapshotSettings;
            GetVolumeSnapshotSettings = existing.GetVolumeSnapshotSettings;
            ListVolumeSnapshotsSettings = existing.ListVolumeSnapshotsSettings;
            GetLunSettings = existing.GetLunSettings;
            ListLunsSettings = existing.ListLunsSettings;
            EvictLunSettings = existing.EvictLunSettings;
            EvictLunOperationsSettings = existing.EvictLunOperationsSettings.Clone();
            GetNfsShareSettings = existing.GetNfsShareSettings;
            ListNfsSharesSettings = existing.ListNfsSharesSettings;
            UpdateNfsShareSettings = existing.UpdateNfsShareSettings;
            UpdateNfsShareOperationsSettings = existing.UpdateNfsShareOperationsSettings.Clone();
            CreateNfsShareSettings = existing.CreateNfsShareSettings;
            CreateNfsShareOperationsSettings = existing.CreateNfsShareOperationsSettings.Clone();
            RenameNfsShareSettings = existing.RenameNfsShareSettings;
            DeleteNfsShareSettings = existing.DeleteNfsShareSettings;
            DeleteNfsShareOperationsSettings = existing.DeleteNfsShareOperationsSettings.Clone();
            ListProvisioningQuotasSettings = existing.ListProvisioningQuotasSettings;
            SubmitProvisioningConfigSettings = existing.SubmitProvisioningConfigSettings;
            GetProvisioningConfigSettings = existing.GetProvisioningConfigSettings;
            CreateProvisioningConfigSettings = existing.CreateProvisioningConfigSettings;
            UpdateProvisioningConfigSettings = existing.UpdateProvisioningConfigSettings;
            RenameNetworkSettings = existing.RenameNetworkSettings;
            ListOSImagesSettings = existing.ListOSImagesSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(BareMetalSolutionSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ListInstances</c> and <c>BareMetalSolutionClient.ListInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.GetInstance</c> and <c>BareMetalSolutionClient.GetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.UpdateInstance</c> and <c>BareMetalSolutionClient.UpdateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.UpdateInstance</c> and
        /// <c>BareMetalSolutionClient.UpdateInstanceAsync</c>.
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
        /// <c>BareMetalSolutionClient.RenameInstance</c> and <c>BareMetalSolutionClient.RenameInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RenameInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ResetInstance</c> and <c>BareMetalSolutionClient.ResetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResetInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.ResetInstance</c> and
        /// <c>BareMetalSolutionClient.ResetInstanceAsync</c>.
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
        public lro::OperationsSettings ResetInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.StartInstance</c> and <c>BareMetalSolutionClient.StartInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.StartInstance</c> and
        /// <c>BareMetalSolutionClient.StartInstanceAsync</c>.
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
        public lro::OperationsSettings StartInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.StopInstance</c> and <c>BareMetalSolutionClient.StopInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.StopInstance</c> and
        /// <c>BareMetalSolutionClient.StopInstanceAsync</c>.
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
        public lro::OperationsSettings StopInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.EnableInteractiveSerialConsole</c> and
        /// <c>BareMetalSolutionClient.EnableInteractiveSerialConsoleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnableInteractiveSerialConsoleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.EnableInteractiveSerialConsole</c>
        /// and <c>BareMetalSolutionClient.EnableInteractiveSerialConsoleAsync</c>.
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
        public lro::OperationsSettings EnableInteractiveSerialConsoleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.DisableInteractiveSerialConsole</c> and
        /// <c>BareMetalSolutionClient.DisableInteractiveSerialConsoleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DisableInteractiveSerialConsoleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.DisableInteractiveSerialConsole</c>
        /// and <c>BareMetalSolutionClient.DisableInteractiveSerialConsoleAsync</c>.
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
        public lro::OperationsSettings DisableInteractiveSerialConsoleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.DetachLun</c> and <c>BareMetalSolutionClient.DetachLunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DetachLunSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.DetachLun</c> and
        /// <c>BareMetalSolutionClient.DetachLunAsync</c>.
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
        public lro::OperationsSettings DetachLunOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ListSSHKeys</c> and <c>BareMetalSolutionClient.ListSSHKeysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSSHKeysSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.CreateSSHKey</c> and <c>BareMetalSolutionClient.CreateSSHKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSSHKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.DeleteSSHKey</c> and <c>BareMetalSolutionClient.DeleteSSHKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSSHKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ListVolumes</c> and <c>BareMetalSolutionClient.ListVolumesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListVolumesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.GetVolume</c> and <c>BareMetalSolutionClient.GetVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetVolumeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.UpdateVolume</c> and <c>BareMetalSolutionClient.UpdateVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateVolumeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.UpdateVolume</c> and
        /// <c>BareMetalSolutionClient.UpdateVolumeAsync</c>.
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
        public lro::OperationsSettings UpdateVolumeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.RenameVolume</c> and <c>BareMetalSolutionClient.RenameVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RenameVolumeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.EvictVolume</c> and <c>BareMetalSolutionClient.EvictVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EvictVolumeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.EvictVolume</c> and
        /// <c>BareMetalSolutionClient.EvictVolumeAsync</c>.
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
        public lro::OperationsSettings EvictVolumeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ResizeVolume</c> and <c>BareMetalSolutionClient.ResizeVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResizeVolumeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.ResizeVolume</c> and
        /// <c>BareMetalSolutionClient.ResizeVolumeAsync</c>.
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
        public lro::OperationsSettings ResizeVolumeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ListNetworks</c> and <c>BareMetalSolutionClient.ListNetworksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNetworksSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ListNetworkUsage</c> and <c>BareMetalSolutionClient.ListNetworkUsageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNetworkUsageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.GetNetwork</c> and <c>BareMetalSolutionClient.GetNetworkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNetworkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.UpdateNetwork</c> and <c>BareMetalSolutionClient.UpdateNetworkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateNetworkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.UpdateNetwork</c> and
        /// <c>BareMetalSolutionClient.UpdateNetworkAsync</c>.
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
        public lro::OperationsSettings UpdateNetworkOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.CreateVolumeSnapshot</c> and <c>BareMetalSolutionClient.CreateVolumeSnapshotAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateVolumeSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.RestoreVolumeSnapshot</c> and
        /// <c>BareMetalSolutionClient.RestoreVolumeSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestoreVolumeSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.RestoreVolumeSnapshot</c> and
        /// <c>BareMetalSolutionClient.RestoreVolumeSnapshotAsync</c>.
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
        public lro::OperationsSettings RestoreVolumeSnapshotOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.DeleteVolumeSnapshot</c> and <c>BareMetalSolutionClient.DeleteVolumeSnapshotAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteVolumeSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.GetVolumeSnapshot</c> and <c>BareMetalSolutionClient.GetVolumeSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetVolumeSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ListVolumeSnapshots</c> and <c>BareMetalSolutionClient.ListVolumeSnapshotsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListVolumeSnapshotsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.GetLun</c> and <c>BareMetalSolutionClient.GetLunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLunSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ListLuns</c> and <c>BareMetalSolutionClient.ListLunsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListLunsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.EvictLun</c> and <c>BareMetalSolutionClient.EvictLunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EvictLunSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.EvictLun</c> and
        /// <c>BareMetalSolutionClient.EvictLunAsync</c>.
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
        public lro::OperationsSettings EvictLunOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.GetNfsShare</c> and <c>BareMetalSolutionClient.GetNfsShareAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNfsShareSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ListNfsShares</c> and <c>BareMetalSolutionClient.ListNfsSharesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNfsSharesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.UpdateNfsShare</c> and <c>BareMetalSolutionClient.UpdateNfsShareAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateNfsShareSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.UpdateNfsShare</c> and
        /// <c>BareMetalSolutionClient.UpdateNfsShareAsync</c>.
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
        public lro::OperationsSettings UpdateNfsShareOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.CreateNfsShare</c> and <c>BareMetalSolutionClient.CreateNfsShareAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateNfsShareSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.CreateNfsShare</c> and
        /// <c>BareMetalSolutionClient.CreateNfsShareAsync</c>.
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
        public lro::OperationsSettings CreateNfsShareOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.RenameNfsShare</c> and <c>BareMetalSolutionClient.RenameNfsShareAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RenameNfsShareSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.DeleteNfsShare</c> and <c>BareMetalSolutionClient.DeleteNfsShareAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteNfsShareSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.DeleteNfsShare</c> and
        /// <c>BareMetalSolutionClient.DeleteNfsShareAsync</c>.
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
        public lro::OperationsSettings DeleteNfsShareOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ListProvisioningQuotas</c> and
        /// <c>BareMetalSolutionClient.ListProvisioningQuotasAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProvisioningQuotasSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.SubmitProvisioningConfig</c> and
        /// <c>BareMetalSolutionClient.SubmitProvisioningConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SubmitProvisioningConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.GetProvisioningConfig</c> and
        /// <c>BareMetalSolutionClient.GetProvisioningConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProvisioningConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.CreateProvisioningConfig</c> and
        /// <c>BareMetalSolutionClient.CreateProvisioningConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateProvisioningConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.UpdateProvisioningConfig</c> and
        /// <c>BareMetalSolutionClient.UpdateProvisioningConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateProvisioningConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.RenameNetwork</c> and <c>BareMetalSolutionClient.RenameNetworkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RenameNetworkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ListOSImages</c> and <c>BareMetalSolutionClient.ListOSImagesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListOSImagesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BareMetalSolutionSettings"/> object.</returns>
        public BareMetalSolutionSettings Clone() => new BareMetalSolutionSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BareMetalSolutionClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class BareMetalSolutionClientBuilder : gaxgrpc::ClientBuilderBase<BareMetalSolutionClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BareMetalSolutionSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BareMetalSolutionClientBuilder() : base(BareMetalSolutionClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BareMetalSolutionClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BareMetalSolutionClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BareMetalSolutionClient Build()
        {
            BareMetalSolutionClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BareMetalSolutionClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BareMetalSolutionClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BareMetalSolutionClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BareMetalSolutionClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BareMetalSolutionClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BareMetalSolutionClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BareMetalSolutionClient.ChannelPool;
    }

    /// <summary>BareMetalSolution client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Performs management operations on Bare Metal Solution servers.
    /// 
    /// The `baremetalsolution.googleapis.com` service provides management
    /// capabilities for Bare Metal Solution servers. To access the API methods, you
    /// must assign Bare Metal Solution IAM roles containing the desired permissions
    /// to your staff in your Google Cloud project. You must also enable the Bare
    /// Metal Solution API. Once enabled, the methods act
    /// upon specific servers in your Bare Metal Solution environment.
    /// </remarks>
    public abstract partial class BareMetalSolutionClient
    {
        /// <summary>
        /// The default endpoint for the BareMetalSolution service, which is a host of
        /// "baremetalsolution.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "baremetalsolution.googleapis.com:443";

        /// <summary>The default BareMetalSolution scopes.</summary>
        /// <remarks>
        /// The default BareMetalSolution scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BareMetalSolution.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BareMetalSolutionClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BareMetalSolutionClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BareMetalSolutionClient"/>.</returns>
        public static stt::Task<BareMetalSolutionClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BareMetalSolutionClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BareMetalSolutionClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BareMetalSolutionClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BareMetalSolutionClient"/>.</returns>
        public static BareMetalSolutionClient Create() => new BareMetalSolutionClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BareMetalSolutionClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BareMetalSolutionSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BareMetalSolutionClient"/>.</returns>
        internal static BareMetalSolutionClient Create(grpccore::CallInvoker callInvoker, BareMetalSolutionSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BareMetalSolution.BareMetalSolutionClient grpcClient = new BareMetalSolution.BareMetalSolutionClient(callInvoker);
            return new BareMetalSolutionClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BareMetalSolution client</summary>
        public virtual BareMetalSolution.BareMetalSolutionClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// List servers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List servers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List servers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInstancesRequest.
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
        /// List servers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInstancesRequest.
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
        /// List servers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInstancesRequest.
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
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// List servers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInstancesRequest.
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
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Get details about a single server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update details of a single server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> UpdateInstance(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update details of a single server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update details of a single server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceUpdateInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceUpdateInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Update details of a single server.
        /// </summary>
        /// <param name="instance">
        /// Required. The server to update.
        /// 
        /// The `name` field is used to identify the instance to update.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// The currently supported fields are:
        /// `labels`
        /// `hyperthreading_enabled`
        /// `os_image`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> UpdateInstance(Instance instance, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstance(new UpdateInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update details of a single server.
        /// </summary>
        /// <param name="instance">
        /// Required. The server to update.
        /// 
        /// The `name` field is used to identify the instance to update.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// The currently supported fields are:
        /// `labels`
        /// `hyperthreading_enabled`
        /// `os_image`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(Instance instance, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstanceAsync(new UpdateInstanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update details of a single server.
        /// </summary>
        /// <param name="instance">
        /// Required. The server to update.
        /// 
        /// The `name` field is used to identify the instance to update.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// The currently supported fields are:
        /// `labels`
        /// `hyperthreading_enabled`
        /// `os_image`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(Instance instance, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateInstanceAsync(instance, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RenameInstance sets a new name for an instance.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance RenameInstance(RenameInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RenameInstance sets a new name for an instance.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> RenameInstanceAsync(RenameInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RenameInstance sets a new name for an instance.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> RenameInstanceAsync(RenameInstanceRequest request, st::CancellationToken cancellationToken) =>
            RenameInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RenameInstance sets a new name for an instance.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the instance.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="newInstanceId">
        /// Required. The new `id` of the instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance RenameInstance(string name, string newInstanceId, gaxgrpc::CallSettings callSettings = null) =>
            RenameInstance(new RenameInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NewInstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(newInstanceId, nameof(newInstanceId)),
            }, callSettings);

        /// <summary>
        /// RenameInstance sets a new name for an instance.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the instance.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="newInstanceId">
        /// Required. The new `id` of the instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> RenameInstanceAsync(string name, string newInstanceId, gaxgrpc::CallSettings callSettings = null) =>
            RenameInstanceAsync(new RenameInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NewInstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(newInstanceId, nameof(newInstanceId)),
            }, callSettings);

        /// <summary>
        /// RenameInstance sets a new name for an instance.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the instance.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="newInstanceId">
        /// Required. The new `id` of the instance.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> RenameInstanceAsync(string name, string newInstanceId, st::CancellationToken cancellationToken) =>
            RenameInstanceAsync(name, newInstanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RenameInstance sets a new name for an instance.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the instance.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="newInstanceId">
        /// Required. The new `id` of the instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance RenameInstance(InstanceName name, string newInstanceId, gaxgrpc::CallSettings callSettings = null) =>
            RenameInstance(new RenameInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NewInstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(newInstanceId, nameof(newInstanceId)),
            }, callSettings);

        /// <summary>
        /// RenameInstance sets a new name for an instance.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the instance.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="newInstanceId">
        /// Required. The new `id` of the instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> RenameInstanceAsync(InstanceName name, string newInstanceId, gaxgrpc::CallSettings callSettings = null) =>
            RenameInstanceAsync(new RenameInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NewInstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(newInstanceId, nameof(newInstanceId)),
            }, callSettings);

        /// <summary>
        /// RenameInstance sets a new name for an instance.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the instance.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="newInstanceId">
        /// Required. The new `id` of the instance.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> RenameInstanceAsync(InstanceName name, string newInstanceId, st::CancellationToken cancellationToken) =>
            RenameInstanceAsync(name, newInstanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ResetInstanceResponse, OperationMetadata> ResetInstance(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResetInstanceResponse, OperationMetadata>> ResetInstanceAsync(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResetInstanceResponse, OperationMetadata>> ResetInstanceAsync(ResetInstanceRequest request, st::CancellationToken cancellationToken) =>
            ResetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ResetInstance</c>.</summary>
        public virtual lro::OperationsClient ResetInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ResetInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ResetInstanceResponse, OperationMetadata> PollOnceResetInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ResetInstanceResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResetInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ResetInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ResetInstanceResponse, OperationMetadata>> PollOnceResetInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ResetInstanceResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResetInstanceOperationsClient, callSettings);

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ResetInstanceResponse, OperationMetadata> ResetInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResetInstance(new ResetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResetInstanceResponse, OperationMetadata>> ResetInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResetInstanceAsync(new ResetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResetInstanceResponse, OperationMetadata>> ResetInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            ResetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ResetInstanceResponse, OperationMetadata> ResetInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            ResetInstance(new ResetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResetInstanceResponse, OperationMetadata>> ResetInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            ResetInstanceAsync(new ResetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResetInstanceResponse, OperationMetadata>> ResetInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            ResetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a server that was shutdown.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StartInstanceResponse, OperationMetadata> StartInstance(StartInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a server that was shutdown.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartInstanceResponse, OperationMetadata>> StartInstanceAsync(StartInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a server that was shutdown.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartInstanceResponse, OperationMetadata>> StartInstanceAsync(StartInstanceRequest request, st::CancellationToken cancellationToken) =>
            StartInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StartInstance</c>.</summary>
        public virtual lro::OperationsClient StartInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StartInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<StartInstanceResponse, OperationMetadata> PollOnceStartInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StartInstanceResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<StartInstanceResponse, OperationMetadata>> PollOnceStartInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StartInstanceResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartInstanceOperationsClient, callSettings);

        /// <summary>
        /// Starts a server that was shutdown.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StartInstanceResponse, OperationMetadata> StartInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartInstance(new StartInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts a server that was shutdown.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartInstanceResponse, OperationMetadata>> StartInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartInstanceAsync(new StartInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts a server that was shutdown.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartInstanceResponse, OperationMetadata>> StartInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            StartInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a server that was shutdown.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StartInstanceResponse, OperationMetadata> StartInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            StartInstance(new StartInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts a server that was shutdown.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartInstanceResponse, OperationMetadata>> StartInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            StartInstanceAsync(new StartInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts a server that was shutdown.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartInstanceResponse, OperationMetadata>> StartInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            StartInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stop a running server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StopInstanceResponse, OperationMetadata> StopInstance(StopInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stop a running server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StopInstanceResponse, OperationMetadata>> StopInstanceAsync(StopInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stop a running server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StopInstanceResponse, OperationMetadata>> StopInstanceAsync(StopInstanceRequest request, st::CancellationToken cancellationToken) =>
            StopInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StopInstance</c>.</summary>
        public virtual lro::OperationsClient StopInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StopInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<StopInstanceResponse, OperationMetadata> PollOnceStopInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StopInstanceResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StopInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<StopInstanceResponse, OperationMetadata>> PollOnceStopInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StopInstanceResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopInstanceOperationsClient, callSettings);

        /// <summary>
        /// Stop a running server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StopInstanceResponse, OperationMetadata> StopInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            StopInstance(new StopInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stop a running server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StopInstanceResponse, OperationMetadata>> StopInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StopInstanceAsync(new StopInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stop a running server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StopInstanceResponse, OperationMetadata>> StopInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            StopInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stop a running server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StopInstanceResponse, OperationMetadata> StopInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            StopInstance(new StopInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stop a running server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StopInstanceResponse, OperationMetadata>> StopInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            StopInstanceAsync(new StopInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stop a running server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StopInstanceResponse, OperationMetadata>> StopInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            StopInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> EnableInteractiveSerialConsole(EnableInteractiveSerialConsoleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata>> EnableInteractiveSerialConsoleAsync(EnableInteractiveSerialConsoleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata>> EnableInteractiveSerialConsoleAsync(EnableInteractiveSerialConsoleRequest request, st::CancellationToken cancellationToken) =>
            EnableInteractiveSerialConsoleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>EnableInteractiveSerialConsole</c>.</summary>
        public virtual lro::OperationsClient EnableInteractiveSerialConsoleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EnableInteractiveSerialConsole</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> PollOnceEnableInteractiveSerialConsole(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableInteractiveSerialConsoleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EnableInteractiveSerialConsole</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata>> PollOnceEnableInteractiveSerialConsoleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableInteractiveSerialConsoleOperationsClient, callSettings);

        /// <summary>
        /// Enable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> EnableInteractiveSerialConsole(string name, gaxgrpc::CallSettings callSettings = null) =>
            EnableInteractiveSerialConsole(new EnableInteractiveSerialConsoleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata>> EnableInteractiveSerialConsoleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            EnableInteractiveSerialConsoleAsync(new EnableInteractiveSerialConsoleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata>> EnableInteractiveSerialConsoleAsync(string name, st::CancellationToken cancellationToken) =>
            EnableInteractiveSerialConsoleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> EnableInteractiveSerialConsole(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            EnableInteractiveSerialConsole(new EnableInteractiveSerialConsoleRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata>> EnableInteractiveSerialConsoleAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            EnableInteractiveSerialConsoleAsync(new EnableInteractiveSerialConsoleRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata>> EnableInteractiveSerialConsoleAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            EnableInteractiveSerialConsoleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> DisableInteractiveSerialConsole(DisableInteractiveSerialConsoleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata>> DisableInteractiveSerialConsoleAsync(DisableInteractiveSerialConsoleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata>> DisableInteractiveSerialConsoleAsync(DisableInteractiveSerialConsoleRequest request, st::CancellationToken cancellationToken) =>
            DisableInteractiveSerialConsoleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DisableInteractiveSerialConsole</c>.</summary>
        public virtual lro::OperationsClient DisableInteractiveSerialConsoleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DisableInteractiveSerialConsole</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> PollOnceDisableInteractiveSerialConsole(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableInteractiveSerialConsoleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DisableInteractiveSerialConsole</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata>> PollOnceDisableInteractiveSerialConsoleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableInteractiveSerialConsoleOperationsClient, callSettings);

        /// <summary>
        /// Disable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> DisableInteractiveSerialConsole(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisableInteractiveSerialConsole(new DisableInteractiveSerialConsoleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata>> DisableInteractiveSerialConsoleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisableInteractiveSerialConsoleAsync(new DisableInteractiveSerialConsoleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata>> DisableInteractiveSerialConsoleAsync(string name, st::CancellationToken cancellationToken) =>
            DisableInteractiveSerialConsoleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> DisableInteractiveSerialConsole(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DisableInteractiveSerialConsole(new DisableInteractiveSerialConsoleRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata>> DisableInteractiveSerialConsoleAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DisableInteractiveSerialConsoleAsync(new DisableInteractiveSerialConsoleRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata>> DisableInteractiveSerialConsoleAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            DisableInteractiveSerialConsoleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Detach LUN from Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> DetachLun(DetachLunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Detach LUN from Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> DetachLunAsync(DetachLunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Detach LUN from Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> DetachLunAsync(DetachLunRequest request, st::CancellationToken cancellationToken) =>
            DetachLunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DetachLun</c>.</summary>
        public virtual lro::OperationsClient DetachLunOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DetachLun</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceDetachLun(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DetachLunOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DetachLun</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceDetachLunAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DetachLunOperationsClient, callSettings);

        /// <summary>
        /// Detach LUN from Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. Name of the instance.
        /// </param>
        /// <param name="lun">
        /// Required. Name of the Lun to detach.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> DetachLun(string instance, string lun, gaxgrpc::CallSettings callSettings = null) =>
            DetachLun(new DetachLunRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Lun = gax::GaxPreconditions.CheckNotNullOrEmpty(lun, nameof(lun)),
            }, callSettings);

        /// <summary>
        /// Detach LUN from Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. Name of the instance.
        /// </param>
        /// <param name="lun">
        /// Required. Name of the Lun to detach.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> DetachLunAsync(string instance, string lun, gaxgrpc::CallSettings callSettings = null) =>
            DetachLunAsync(new DetachLunRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Lun = gax::GaxPreconditions.CheckNotNullOrEmpty(lun, nameof(lun)),
            }, callSettings);

        /// <summary>
        /// Detach LUN from Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. Name of the instance.
        /// </param>
        /// <param name="lun">
        /// Required. Name of the Lun to detach.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> DetachLunAsync(string instance, string lun, st::CancellationToken cancellationToken) =>
            DetachLunAsync(instance, lun, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Detach LUN from Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. Name of the instance.
        /// </param>
        /// <param name="lun">
        /// Required. Name of the Lun to detach.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> DetachLun(InstanceName instance, LunName lun, gaxgrpc::CallSettings callSettings = null) =>
            DetachLun(new DetachLunRequest
            {
                InstanceAsInstanceName = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                LunAsLunName = gax::GaxPreconditions.CheckNotNull(lun, nameof(lun)),
            }, callSettings);

        /// <summary>
        /// Detach LUN from Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. Name of the instance.
        /// </param>
        /// <param name="lun">
        /// Required. Name of the Lun to detach.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> DetachLunAsync(InstanceName instance, LunName lun, gaxgrpc::CallSettings callSettings = null) =>
            DetachLunAsync(new DetachLunRequest
            {
                InstanceAsInstanceName = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                LunAsLunName = gax::GaxPreconditions.CheckNotNull(lun, nameof(lun)),
            }, callSettings);

        /// <summary>
        /// Detach LUN from Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. Name of the instance.
        /// </param>
        /// <param name="lun">
        /// Required. Name of the Lun to detach.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> DetachLunAsync(InstanceName instance, LunName lun, st::CancellationToken cancellationToken) =>
            DetachLunAsync(instance, lun, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the public SSH keys registered for the specified project.
        /// These SSH keys are used only for the interactive serial console feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SSHKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSSHKeysResponse, SSHKey> ListSSHKeys(ListSSHKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the public SSH keys registered for the specified project.
        /// These SSH keys are used only for the interactive serial console feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SSHKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSSHKeysResponse, SSHKey> ListSSHKeysAsync(ListSSHKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the public SSH keys registered for the specified project.
        /// These SSH keys are used only for the interactive serial console feature.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent containing the SSH keys.
        /// Currently, the only valid value for the location is "global".
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
        /// <returns>A pageable sequence of <see cref="SSHKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSSHKeysResponse, SSHKey> ListSSHKeys(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSSHKeysRequest request = new ListSSHKeysRequest
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
            return ListSSHKeys(request, callSettings);
        }

        /// <summary>
        /// Lists the public SSH keys registered for the specified project.
        /// These SSH keys are used only for the interactive serial console feature.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent containing the SSH keys.
        /// Currently, the only valid value for the location is "global".
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
        /// <returns>A pageable asynchronous sequence of <see cref="SSHKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSSHKeysResponse, SSHKey> ListSSHKeysAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSSHKeysRequest request = new ListSSHKeysRequest
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
            return ListSSHKeysAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the public SSH keys registered for the specified project.
        /// These SSH keys are used only for the interactive serial console feature.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent containing the SSH keys.
        /// Currently, the only valid value for the location is "global".
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
        /// <returns>A pageable sequence of <see cref="SSHKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSSHKeysResponse, SSHKey> ListSSHKeys(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSSHKeysRequest request = new ListSSHKeysRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSSHKeys(request, callSettings);
        }

        /// <summary>
        /// Lists the public SSH keys registered for the specified project.
        /// These SSH keys are used only for the interactive serial console feature.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent containing the SSH keys.
        /// Currently, the only valid value for the location is "global".
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
        /// <returns>A pageable asynchronous sequence of <see cref="SSHKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSSHKeysResponse, SSHKey> ListSSHKeysAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSSHKeysRequest request = new ListSSHKeysRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSSHKeysAsync(request, callSettings);
        }

        /// <summary>
        /// Register a public SSH key in the specified project for use with the
        /// interactive serial console feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SSHKey CreateSSHKey(CreateSSHKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Register a public SSH key in the specified project for use with the
        /// interactive serial console feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SSHKey> CreateSSHKeyAsync(CreateSSHKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Register a public SSH key in the specified project for use with the
        /// interactive serial console feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SSHKey> CreateSSHKeyAsync(CreateSSHKeyRequest request, st::CancellationToken cancellationToken) =>
            CreateSSHKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Register a public SSH key in the specified project for use with the
        /// interactive serial console feature.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent containing the SSH keys.
        /// </param>
        /// <param name="sshKey">
        /// Required. The SSH key to register.
        /// </param>
        /// <param name="sshKeyId">
        /// Required. The ID to use for the key, which will become the final component
        /// of the key's resource name.
        /// 
        /// This value must match the regex:
        /// [a-zA-Z0-9@.\-_]{1,64}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SSHKey CreateSSHKey(string parent, SSHKey sshKey, string sshKeyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSSHKey(new CreateSSHKeyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SshKey = gax::GaxPreconditions.CheckNotNull(sshKey, nameof(sshKey)),
                SshKeyId = gax::GaxPreconditions.CheckNotNullOrEmpty(sshKeyId, nameof(sshKeyId)),
            }, callSettings);

        /// <summary>
        /// Register a public SSH key in the specified project for use with the
        /// interactive serial console feature.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent containing the SSH keys.
        /// </param>
        /// <param name="sshKey">
        /// Required. The SSH key to register.
        /// </param>
        /// <param name="sshKeyId">
        /// Required. The ID to use for the key, which will become the final component
        /// of the key's resource name.
        /// 
        /// This value must match the regex:
        /// [a-zA-Z0-9@.\-_]{1,64}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SSHKey> CreateSSHKeyAsync(string parent, SSHKey sshKey, string sshKeyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSSHKeyAsync(new CreateSSHKeyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SshKey = gax::GaxPreconditions.CheckNotNull(sshKey, nameof(sshKey)),
                SshKeyId = gax::GaxPreconditions.CheckNotNullOrEmpty(sshKeyId, nameof(sshKeyId)),
            }, callSettings);

        /// <summary>
        /// Register a public SSH key in the specified project for use with the
        /// interactive serial console feature.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent containing the SSH keys.
        /// </param>
        /// <param name="sshKey">
        /// Required. The SSH key to register.
        /// </param>
        /// <param name="sshKeyId">
        /// Required. The ID to use for the key, which will become the final component
        /// of the key's resource name.
        /// 
        /// This value must match the regex:
        /// [a-zA-Z0-9@.\-_]{1,64}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SSHKey> CreateSSHKeyAsync(string parent, SSHKey sshKey, string sshKeyId, st::CancellationToken cancellationToken) =>
            CreateSSHKeyAsync(parent, sshKey, sshKeyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Register a public SSH key in the specified project for use with the
        /// interactive serial console feature.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent containing the SSH keys.
        /// </param>
        /// <param name="sshKey">
        /// Required. The SSH key to register.
        /// </param>
        /// <param name="sshKeyId">
        /// Required. The ID to use for the key, which will become the final component
        /// of the key's resource name.
        /// 
        /// This value must match the regex:
        /// [a-zA-Z0-9@.\-_]{1,64}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SSHKey CreateSSHKey(gagr::LocationName parent, SSHKey sshKey, string sshKeyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSSHKey(new CreateSSHKeyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SshKey = gax::GaxPreconditions.CheckNotNull(sshKey, nameof(sshKey)),
                SshKeyId = gax::GaxPreconditions.CheckNotNullOrEmpty(sshKeyId, nameof(sshKeyId)),
            }, callSettings);

        /// <summary>
        /// Register a public SSH key in the specified project for use with the
        /// interactive serial console feature.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent containing the SSH keys.
        /// </param>
        /// <param name="sshKey">
        /// Required. The SSH key to register.
        /// </param>
        /// <param name="sshKeyId">
        /// Required. The ID to use for the key, which will become the final component
        /// of the key's resource name.
        /// 
        /// This value must match the regex:
        /// [a-zA-Z0-9@.\-_]{1,64}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SSHKey> CreateSSHKeyAsync(gagr::LocationName parent, SSHKey sshKey, string sshKeyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSSHKeyAsync(new CreateSSHKeyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SshKey = gax::GaxPreconditions.CheckNotNull(sshKey, nameof(sshKey)),
                SshKeyId = gax::GaxPreconditions.CheckNotNullOrEmpty(sshKeyId, nameof(sshKeyId)),
            }, callSettings);

        /// <summary>
        /// Register a public SSH key in the specified project for use with the
        /// interactive serial console feature.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent containing the SSH keys.
        /// </param>
        /// <param name="sshKey">
        /// Required. The SSH key to register.
        /// </param>
        /// <param name="sshKeyId">
        /// Required. The ID to use for the key, which will become the final component
        /// of the key's resource name.
        /// 
        /// This value must match the regex:
        /// [a-zA-Z0-9@.\-_]{1,64}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SSHKey> CreateSSHKeyAsync(gagr::LocationName parent, SSHKey sshKey, string sshKeyId, st::CancellationToken cancellationToken) =>
            CreateSSHKeyAsync(parent, sshKey, sshKeyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a public SSH key registered in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSSHKey(DeleteSSHKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a public SSH key registered in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSSHKeyAsync(DeleteSSHKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a public SSH key registered in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSSHKeyAsync(DeleteSSHKeyRequest request, st::CancellationToken cancellationToken) =>
            DeleteSSHKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a public SSH key registered in the specified project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SSH key to delete.
        /// Currently, the only valid value for the location is "global".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSSHKey(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSSHKey(new DeleteSSHKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a public SSH key registered in the specified project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SSH key to delete.
        /// Currently, the only valid value for the location is "global".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSSHKeyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSSHKeyAsync(new DeleteSSHKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a public SSH key registered in the specified project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SSH key to delete.
        /// Currently, the only valid value for the location is "global".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSSHKeyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSSHKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a public SSH key registered in the specified project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SSH key to delete.
        /// Currently, the only valid value for the location is "global".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSSHKey(SshKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSSHKey(new DeleteSSHKeyRequest
            {
                SshKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a public SSH key registered in the specified project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SSH key to delete.
        /// Currently, the only valid value for the location is "global".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSSHKeyAsync(SshKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSSHKeyAsync(new DeleteSSHKeyRequest
            {
                SshKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a public SSH key registered in the specified project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SSH key to delete.
        /// Currently, the only valid value for the location is "global".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSSHKeyAsync(SshKeyName name, st::CancellationToken cancellationToken) =>
            DeleteSSHKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List storage volumes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumesResponse, Volume> ListVolumes(ListVolumesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List storage volumes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumesResponse, Volume> ListVolumesAsync(ListVolumesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List storage volumes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest.
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
        /// <returns>A pageable sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumesResponse, Volume> ListVolumes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumesRequest request = new ListVolumesRequest
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
            return ListVolumes(request, callSettings);
        }

        /// <summary>
        /// List storage volumes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumesResponse, Volume> ListVolumesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumesRequest request = new ListVolumesRequest
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
            return ListVolumesAsync(request, callSettings);
        }

        /// <summary>
        /// List storage volumes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest.
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
        /// <returns>A pageable sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumesResponse, Volume> ListVolumes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumesRequest request = new ListVolumesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListVolumes(request, callSettings);
        }

        /// <summary>
        /// List storage volumes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumesResponse, Volume> ListVolumesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumesRequest request = new ListVolumesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListVolumesAsync(request, callSettings);
        }

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Volume GetVolume(GetVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(GetVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(GetVolumeRequest request, st::CancellationToken cancellationToken) =>
            GetVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Volume GetVolume(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolume(new GetVolumeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeAsync(new GetVolumeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(string name, st::CancellationToken cancellationToken) =>
            GetVolumeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Volume GetVolume(VolumeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolume(new GetVolumeRequest
            {
                VolumeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(VolumeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeAsync(new GetVolumeRequest
            {
                VolumeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(VolumeName name, st::CancellationToken cancellationToken) =>
            GetVolumeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> UpdateVolume(UpdateVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(UpdateVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(UpdateVolumeRequest request, st::CancellationToken cancellationToken) =>
            UpdateVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateVolume</c>.</summary>
        public virtual lro::OperationsClient UpdateVolumeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> PollOnceUpdateVolume(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Volume, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateVolumeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> PollOnceUpdateVolumeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Volume, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateVolumeOperationsClient, callSettings);

        /// <summary>
        /// Update details of a single storage volume.
        /// </summary>
        /// <param name="volume">
        /// Required. The volume to update.
        /// 
        /// The `name` field is used to identify the volume to update.
        /// Format: projects/{project}/locations/{location}/volumes/{volume}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// The only currently supported fields are:
        /// 'labels'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> UpdateVolume(Volume volume, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVolume(new UpdateVolumeRequest
            {
                Volume = gax::GaxPreconditions.CheckNotNull(volume, nameof(volume)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update details of a single storage volume.
        /// </summary>
        /// <param name="volume">
        /// Required. The volume to update.
        /// 
        /// The `name` field is used to identify the volume to update.
        /// Format: projects/{project}/locations/{location}/volumes/{volume}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// The only currently supported fields are:
        /// 'labels'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(Volume volume, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVolumeAsync(new UpdateVolumeRequest
            {
                Volume = gax::GaxPreconditions.CheckNotNull(volume, nameof(volume)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update details of a single storage volume.
        /// </summary>
        /// <param name="volume">
        /// Required. The volume to update.
        /// 
        /// The `name` field is used to identify the volume to update.
        /// Format: projects/{project}/locations/{location}/volumes/{volume}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// The only currently supported fields are:
        /// 'labels'
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(Volume volume, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateVolumeAsync(volume, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RenameVolume sets a new name for a volume.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Volume RenameVolume(RenameVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RenameVolume sets a new name for a volume.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> RenameVolumeAsync(RenameVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RenameVolume sets a new name for a volume.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> RenameVolumeAsync(RenameVolumeRequest request, st::CancellationToken cancellationToken) =>
            RenameVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RenameVolume sets a new name for a volume.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the volume.
        /// Format: projects/{project}/locations/{location}/volumes/{volume}
        /// </param>
        /// <param name="newVolumeId">
        /// Required. The new `id` of the volume.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Volume RenameVolume(string name, string newVolumeId, gaxgrpc::CallSettings callSettings = null) =>
            RenameVolume(new RenameVolumeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NewVolumeId = gax::GaxPreconditions.CheckNotNullOrEmpty(newVolumeId, nameof(newVolumeId)),
            }, callSettings);

        /// <summary>
        /// RenameVolume sets a new name for a volume.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the volume.
        /// Format: projects/{project}/locations/{location}/volumes/{volume}
        /// </param>
        /// <param name="newVolumeId">
        /// Required. The new `id` of the volume.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> RenameVolumeAsync(string name, string newVolumeId, gaxgrpc::CallSettings callSettings = null) =>
            RenameVolumeAsync(new RenameVolumeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NewVolumeId = gax::GaxPreconditions.CheckNotNullOrEmpty(newVolumeId, nameof(newVolumeId)),
            }, callSettings);

        /// <summary>
        /// RenameVolume sets a new name for a volume.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the volume.
        /// Format: projects/{project}/locations/{location}/volumes/{volume}
        /// </param>
        /// <param name="newVolumeId">
        /// Required. The new `id` of the volume.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> RenameVolumeAsync(string name, string newVolumeId, st::CancellationToken cancellationToken) =>
            RenameVolumeAsync(name, newVolumeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RenameVolume sets a new name for a volume.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the volume.
        /// Format: projects/{project}/locations/{location}/volumes/{volume}
        /// </param>
        /// <param name="newVolumeId">
        /// Required. The new `id` of the volume.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Volume RenameVolume(VolumeName name, string newVolumeId, gaxgrpc::CallSettings callSettings = null) =>
            RenameVolume(new RenameVolumeRequest
            {
                VolumeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NewVolumeId = gax::GaxPreconditions.CheckNotNullOrEmpty(newVolumeId, nameof(newVolumeId)),
            }, callSettings);

        /// <summary>
        /// RenameVolume sets a new name for a volume.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the volume.
        /// Format: projects/{project}/locations/{location}/volumes/{volume}
        /// </param>
        /// <param name="newVolumeId">
        /// Required. The new `id` of the volume.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> RenameVolumeAsync(VolumeName name, string newVolumeId, gaxgrpc::CallSettings callSettings = null) =>
            RenameVolumeAsync(new RenameVolumeRequest
            {
                VolumeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NewVolumeId = gax::GaxPreconditions.CheckNotNullOrEmpty(newVolumeId, nameof(newVolumeId)),
            }, callSettings);

        /// <summary>
        /// RenameVolume sets a new name for a volume.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the volume.
        /// Format: projects/{project}/locations/{location}/volumes/{volume}
        /// </param>
        /// <param name="newVolumeId">
        /// Required. The new `id` of the volume.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> RenameVolumeAsync(VolumeName name, string newVolumeId, st::CancellationToken cancellationToken) =>
            RenameVolumeAsync(name, newVolumeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Skips volume's cooloff and deletes it now.
        /// Volume must be in cooloff state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> EvictVolume(EvictVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Skips volume's cooloff and deletes it now.
        /// Volume must be in cooloff state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> EvictVolumeAsync(EvictVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Skips volume's cooloff and deletes it now.
        /// Volume must be in cooloff state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> EvictVolumeAsync(EvictVolumeRequest request, st::CancellationToken cancellationToken) =>
            EvictVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>EvictVolume</c>.</summary>
        public virtual lro::OperationsClient EvictVolumeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>EvictVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceEvictVolume(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EvictVolumeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EvictVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceEvictVolumeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EvictVolumeOperationsClient, callSettings);

        /// <summary>
        /// Skips volume's cooloff and deletes it now.
        /// Volume must be in cooloff state.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Volume.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> EvictVolume(string name, gaxgrpc::CallSettings callSettings = null) =>
            EvictVolume(new EvictVolumeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Skips volume's cooloff and deletes it now.
        /// Volume must be in cooloff state.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Volume.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> EvictVolumeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            EvictVolumeAsync(new EvictVolumeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Skips volume's cooloff and deletes it now.
        /// Volume must be in cooloff state.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Volume.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> EvictVolumeAsync(string name, st::CancellationToken cancellationToken) =>
            EvictVolumeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Skips volume's cooloff and deletes it now.
        /// Volume must be in cooloff state.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Volume.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> EvictVolume(VolumeName name, gaxgrpc::CallSettings callSettings = null) =>
            EvictVolume(new EvictVolumeRequest
            {
                VolumeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Skips volume's cooloff and deletes it now.
        /// Volume must be in cooloff state.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Volume.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> EvictVolumeAsync(VolumeName name, gaxgrpc::CallSettings callSettings = null) =>
            EvictVolumeAsync(new EvictVolumeRequest
            {
                VolumeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Skips volume's cooloff and deletes it now.
        /// Volume must be in cooloff state.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Volume.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> EvictVolumeAsync(VolumeName name, st::CancellationToken cancellationToken) =>
            EvictVolumeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Emergency Volume resize.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> ResizeVolume(ResizeVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Emergency Volume resize.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> ResizeVolumeAsync(ResizeVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Emergency Volume resize.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> ResizeVolumeAsync(ResizeVolumeRequest request, st::CancellationToken cancellationToken) =>
            ResizeVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ResizeVolume</c>.</summary>
        public virtual lro::OperationsClient ResizeVolumeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ResizeVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> PollOnceResizeVolume(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Volume, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResizeVolumeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ResizeVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> PollOnceResizeVolumeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Volume, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResizeVolumeOperationsClient, callSettings);

        /// <summary>
        /// Emergency Volume resize.
        /// </summary>
        /// <param name="volume">
        /// Required. Volume to resize.
        /// </param>
        /// <param name="sizeGib">
        /// New Volume size, in GiB.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> ResizeVolume(string volume, long sizeGib, gaxgrpc::CallSettings callSettings = null) =>
            ResizeVolume(new ResizeVolumeRequest
            {
                Volume = gax::GaxPreconditions.CheckNotNullOrEmpty(volume, nameof(volume)),
                SizeGib = sizeGib,
            }, callSettings);

        /// <summary>
        /// Emergency Volume resize.
        /// </summary>
        /// <param name="volume">
        /// Required. Volume to resize.
        /// </param>
        /// <param name="sizeGib">
        /// New Volume size, in GiB.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> ResizeVolumeAsync(string volume, long sizeGib, gaxgrpc::CallSettings callSettings = null) =>
            ResizeVolumeAsync(new ResizeVolumeRequest
            {
                Volume = gax::GaxPreconditions.CheckNotNullOrEmpty(volume, nameof(volume)),
                SizeGib = sizeGib,
            }, callSettings);

        /// <summary>
        /// Emergency Volume resize.
        /// </summary>
        /// <param name="volume">
        /// Required. Volume to resize.
        /// </param>
        /// <param name="sizeGib">
        /// New Volume size, in GiB.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> ResizeVolumeAsync(string volume, long sizeGib, st::CancellationToken cancellationToken) =>
            ResizeVolumeAsync(volume, sizeGib, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Emergency Volume resize.
        /// </summary>
        /// <param name="volume">
        /// Required. Volume to resize.
        /// </param>
        /// <param name="sizeGib">
        /// New Volume size, in GiB.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> ResizeVolume(VolumeName volume, long sizeGib, gaxgrpc::CallSettings callSettings = null) =>
            ResizeVolume(new ResizeVolumeRequest
            {
                VolumeAsVolumeName = gax::GaxPreconditions.CheckNotNull(volume, nameof(volume)),
                SizeGib = sizeGib,
            }, callSettings);

        /// <summary>
        /// Emergency Volume resize.
        /// </summary>
        /// <param name="volume">
        /// Required. Volume to resize.
        /// </param>
        /// <param name="sizeGib">
        /// New Volume size, in GiB.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> ResizeVolumeAsync(VolumeName volume, long sizeGib, gaxgrpc::CallSettings callSettings = null) =>
            ResizeVolumeAsync(new ResizeVolumeRequest
            {
                VolumeAsVolumeName = gax::GaxPreconditions.CheckNotNull(volume, nameof(volume)),
                SizeGib = sizeGib,
            }, callSettings);

        /// <summary>
        /// Emergency Volume resize.
        /// </summary>
        /// <param name="volume">
        /// Required. Volume to resize.
        /// </param>
        /// <param name="sizeGib">
        /// New Volume size, in GiB.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> ResizeVolumeAsync(VolumeName volume, long sizeGib, st::CancellationToken cancellationToken) =>
            ResizeVolumeAsync(volume, sizeGib, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List network in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Network"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNetworksResponse, Network> ListNetworks(ListNetworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List network in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Network"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNetworksResponse, Network> ListNetworksAsync(ListNetworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListNetworksRequest.
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
        /// <returns>A pageable sequence of <see cref="Network"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNetworksResponse, Network> ListNetworks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNetworksRequest request = new ListNetworksRequest
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
            return ListNetworks(request, callSettings);
        }

        /// <summary>
        /// List network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListNetworksRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Network"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNetworksResponse, Network> ListNetworksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNetworksRequest request = new ListNetworksRequest
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
            return ListNetworksAsync(request, callSettings);
        }

        /// <summary>
        /// List network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListNetworksRequest.
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
        /// <returns>A pageable sequence of <see cref="Network"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNetworksResponse, Network> ListNetworks(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNetworksRequest request = new ListNetworksRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNetworks(request, callSettings);
        }

        /// <summary>
        /// List network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListNetworksRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Network"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNetworksResponse, Network> ListNetworksAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNetworksRequest request = new ListNetworksRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNetworksAsync(request, callSettings);
        }

        /// <summary>
        /// List all Networks (and used IPs for each Network) in the vendor account
        /// associated with the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListNetworkUsageResponse ListNetworkUsage(ListNetworkUsageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all Networks (and used IPs for each Network) in the vendor account
        /// associated with the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListNetworkUsageResponse> ListNetworkUsageAsync(ListNetworkUsageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all Networks (and used IPs for each Network) in the vendor account
        /// associated with the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListNetworkUsageResponse> ListNetworkUsageAsync(ListNetworkUsageRequest request, st::CancellationToken cancellationToken) =>
            ListNetworkUsageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all Networks (and used IPs for each Network) in the vendor account
        /// associated with the specified project.
        /// </summary>
        /// <param name="location">
        /// Required. Parent value (project and location).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListNetworkUsageResponse ListNetworkUsage(string location, gaxgrpc::CallSettings callSettings = null) =>
            ListNetworkUsage(new ListNetworkUsageRequest
            {
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// List all Networks (and used IPs for each Network) in the vendor account
        /// associated with the specified project.
        /// </summary>
        /// <param name="location">
        /// Required. Parent value (project and location).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListNetworkUsageResponse> ListNetworkUsageAsync(string location, gaxgrpc::CallSettings callSettings = null) =>
            ListNetworkUsageAsync(new ListNetworkUsageRequest
            {
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// List all Networks (and used IPs for each Network) in the vendor account
        /// associated with the specified project.
        /// </summary>
        /// <param name="location">
        /// Required. Parent value (project and location).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListNetworkUsageResponse> ListNetworkUsageAsync(string location, st::CancellationToken cancellationToken) =>
            ListNetworkUsageAsync(location, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all Networks (and used IPs for each Network) in the vendor account
        /// associated with the specified project.
        /// </summary>
        /// <param name="location">
        /// Required. Parent value (project and location).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListNetworkUsageResponse ListNetworkUsage(gagr::LocationName location, gaxgrpc::CallSettings callSettings = null) =>
            ListNetworkUsage(new ListNetworkUsageRequest
            {
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// List all Networks (and used IPs for each Network) in the vendor account
        /// associated with the specified project.
        /// </summary>
        /// <param name="location">
        /// Required. Parent value (project and location).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListNetworkUsageResponse> ListNetworkUsageAsync(gagr::LocationName location, gaxgrpc::CallSettings callSettings = null) =>
            ListNetworkUsageAsync(new ListNetworkUsageRequest
            {
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// List all Networks (and used IPs for each Network) in the vendor account
        /// associated with the specified project.
        /// </summary>
        /// <param name="location">
        /// Required. Parent value (project and location).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListNetworkUsageResponse> ListNetworkUsageAsync(gagr::LocationName location, st::CancellationToken cancellationToken) =>
            ListNetworkUsageAsync(location, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network GetNetwork(GetNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(GetNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(GetNetworkRequest request, st::CancellationToken cancellationToken) =>
            GetNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network GetNetwork(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetwork(new GetNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetworkAsync(new GetNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(string name, st::CancellationToken cancellationToken) =>
            GetNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network GetNetwork(NetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetwork(new GetNetworkRequest
            {
                NetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(NetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetworkAsync(new GetNetworkRequest
            {
                NetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(NetworkName name, st::CancellationToken cancellationToken) =>
            GetNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update details of a single network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Network, OperationMetadata> UpdateNetwork(UpdateNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update details of a single network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Network, OperationMetadata>> UpdateNetworkAsync(UpdateNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update details of a single network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Network, OperationMetadata>> UpdateNetworkAsync(UpdateNetworkRequest request, st::CancellationToken cancellationToken) =>
            UpdateNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateNetwork</c>.</summary>
        public virtual lro::OperationsClient UpdateNetworkOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateNetwork</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Network, OperationMetadata> PollOnceUpdateNetwork(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Network, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateNetworkOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateNetwork</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Network, OperationMetadata>> PollOnceUpdateNetworkAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Network, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateNetworkOperationsClient, callSettings);

        /// <summary>
        /// Update details of a single network.
        /// </summary>
        /// <param name="network">
        /// Required. The network to update.
        /// 
        /// The `name` field is used to identify the instance to update.
        /// Format: projects/{project}/locations/{location}/networks/{network}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// The only currently supported fields are:
        /// `labels`, `reservations`, `vrf.vlan_attachments`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Network, OperationMetadata> UpdateNetwork(Network network, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNetwork(new UpdateNetworkRequest
            {
                Network = gax::GaxPreconditions.CheckNotNull(network, nameof(network)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update details of a single network.
        /// </summary>
        /// <param name="network">
        /// Required. The network to update.
        /// 
        /// The `name` field is used to identify the instance to update.
        /// Format: projects/{project}/locations/{location}/networks/{network}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// The only currently supported fields are:
        /// `labels`, `reservations`, `vrf.vlan_attachments`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Network, OperationMetadata>> UpdateNetworkAsync(Network network, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNetworkAsync(new UpdateNetworkRequest
            {
                Network = gax::GaxPreconditions.CheckNotNull(network, nameof(network)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update details of a single network.
        /// </summary>
        /// <param name="network">
        /// Required. The network to update.
        /// 
        /// The `name` field is used to identify the instance to update.
        /// Format: projects/{project}/locations/{location}/networks/{network}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// The only currently supported fields are:
        /// `labels`, `reservations`, `vrf.vlan_attachments`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Network, OperationMetadata>> UpdateNetworkAsync(Network network, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateNetworkAsync(network, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Takes a snapshot of a boot volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VolumeSnapshot CreateVolumeSnapshot(CreateVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Takes a snapshot of a boot volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> CreateVolumeSnapshotAsync(CreateVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Takes a snapshot of a boot volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> CreateVolumeSnapshotAsync(CreateVolumeSnapshotRequest request, st::CancellationToken cancellationToken) =>
            CreateVolumeSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Takes a snapshot of a boot volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume to snapshot.
        /// </param>
        /// <param name="volumeSnapshot">
        /// Required. The snapshot to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VolumeSnapshot CreateVolumeSnapshot(string parent, VolumeSnapshot volumeSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            CreateVolumeSnapshot(new CreateVolumeSnapshotRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                VolumeSnapshot = gax::GaxPreconditions.CheckNotNull(volumeSnapshot, nameof(volumeSnapshot)),
            }, callSettings);

        /// <summary>
        /// Takes a snapshot of a boot volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume to snapshot.
        /// </param>
        /// <param name="volumeSnapshot">
        /// Required. The snapshot to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> CreateVolumeSnapshotAsync(string parent, VolumeSnapshot volumeSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            CreateVolumeSnapshotAsync(new CreateVolumeSnapshotRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                VolumeSnapshot = gax::GaxPreconditions.CheckNotNull(volumeSnapshot, nameof(volumeSnapshot)),
            }, callSettings);

        /// <summary>
        /// Takes a snapshot of a boot volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume to snapshot.
        /// </param>
        /// <param name="volumeSnapshot">
        /// Required. The snapshot to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> CreateVolumeSnapshotAsync(string parent, VolumeSnapshot volumeSnapshot, st::CancellationToken cancellationToken) =>
            CreateVolumeSnapshotAsync(parent, volumeSnapshot, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Takes a snapshot of a boot volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume to snapshot.
        /// </param>
        /// <param name="volumeSnapshot">
        /// Required. The snapshot to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VolumeSnapshot CreateVolumeSnapshot(VolumeName parent, VolumeSnapshot volumeSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            CreateVolumeSnapshot(new CreateVolumeSnapshotRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                VolumeSnapshot = gax::GaxPreconditions.CheckNotNull(volumeSnapshot, nameof(volumeSnapshot)),
            }, callSettings);

        /// <summary>
        /// Takes a snapshot of a boot volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume to snapshot.
        /// </param>
        /// <param name="volumeSnapshot">
        /// Required. The snapshot to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> CreateVolumeSnapshotAsync(VolumeName parent, VolumeSnapshot volumeSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            CreateVolumeSnapshotAsync(new CreateVolumeSnapshotRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                VolumeSnapshot = gax::GaxPreconditions.CheckNotNull(volumeSnapshot, nameof(volumeSnapshot)),
            }, callSettings);

        /// <summary>
        /// Takes a snapshot of a boot volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume to snapshot.
        /// </param>
        /// <param name="volumeSnapshot">
        /// Required. The snapshot to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> CreateVolumeSnapshotAsync(VolumeName parent, VolumeSnapshot volumeSnapshot, st::CancellationToken cancellationToken) =>
            CreateVolumeSnapshotAsync(parent, volumeSnapshot, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Uses the specified snapshot to restore its parent volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<VolumeSnapshot, OperationMetadata> RestoreVolumeSnapshot(RestoreVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uses the specified snapshot to restore its parent volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VolumeSnapshot, OperationMetadata>> RestoreVolumeSnapshotAsync(RestoreVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uses the specified snapshot to restore its parent volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VolumeSnapshot, OperationMetadata>> RestoreVolumeSnapshotAsync(RestoreVolumeSnapshotRequest request, st::CancellationToken cancellationToken) =>
            RestoreVolumeSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RestoreVolumeSnapshot</c>.</summary>
        public virtual lro::OperationsClient RestoreVolumeSnapshotOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RestoreVolumeSnapshot</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<VolumeSnapshot, OperationMetadata> PollOnceRestoreVolumeSnapshot(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<VolumeSnapshot, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreVolumeSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestoreVolumeSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<VolumeSnapshot, OperationMetadata>> PollOnceRestoreVolumeSnapshotAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<VolumeSnapshot, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreVolumeSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Uses the specified snapshot to restore its parent volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="volumeSnapshot">
        /// Required. Name of the snapshot which will be used to restore its parent
        /// volume.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<VolumeSnapshot, OperationMetadata> RestoreVolumeSnapshot(string volumeSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            RestoreVolumeSnapshot(new RestoreVolumeSnapshotRequest
            {
                VolumeSnapshot = gax::GaxPreconditions.CheckNotNullOrEmpty(volumeSnapshot, nameof(volumeSnapshot)),
            }, callSettings);

        /// <summary>
        /// Uses the specified snapshot to restore its parent volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="volumeSnapshot">
        /// Required. Name of the snapshot which will be used to restore its parent
        /// volume.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VolumeSnapshot, OperationMetadata>> RestoreVolumeSnapshotAsync(string volumeSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            RestoreVolumeSnapshotAsync(new RestoreVolumeSnapshotRequest
            {
                VolumeSnapshot = gax::GaxPreconditions.CheckNotNullOrEmpty(volumeSnapshot, nameof(volumeSnapshot)),
            }, callSettings);

        /// <summary>
        /// Uses the specified snapshot to restore its parent volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="volumeSnapshot">
        /// Required. Name of the snapshot which will be used to restore its parent
        /// volume.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VolumeSnapshot, OperationMetadata>> RestoreVolumeSnapshotAsync(string volumeSnapshot, st::CancellationToken cancellationToken) =>
            RestoreVolumeSnapshotAsync(volumeSnapshot, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Uses the specified snapshot to restore its parent volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="volumeSnapshot">
        /// Required. Name of the snapshot which will be used to restore its parent
        /// volume.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<VolumeSnapshot, OperationMetadata> RestoreVolumeSnapshot(VolumeSnapshotName volumeSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            RestoreVolumeSnapshot(new RestoreVolumeSnapshotRequest
            {
                VolumeSnapshotAsVolumeSnapshotName = gax::GaxPreconditions.CheckNotNull(volumeSnapshot, nameof(volumeSnapshot)),
            }, callSettings);

        /// <summary>
        /// Uses the specified snapshot to restore its parent volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="volumeSnapshot">
        /// Required. Name of the snapshot which will be used to restore its parent
        /// volume.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VolumeSnapshot, OperationMetadata>> RestoreVolumeSnapshotAsync(VolumeSnapshotName volumeSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            RestoreVolumeSnapshotAsync(new RestoreVolumeSnapshotRequest
            {
                VolumeSnapshotAsVolumeSnapshotName = gax::GaxPreconditions.CheckNotNull(volumeSnapshot, nameof(volumeSnapshot)),
            }, callSettings);

        /// <summary>
        /// Uses the specified snapshot to restore its parent volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="volumeSnapshot">
        /// Required. Name of the snapshot which will be used to restore its parent
        /// volume.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VolumeSnapshot, OperationMetadata>> RestoreVolumeSnapshotAsync(VolumeSnapshotName volumeSnapshot, st::CancellationToken cancellationToken) =>
            RestoreVolumeSnapshotAsync(volumeSnapshot, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a volume snapshot.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteVolumeSnapshot(DeleteVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a volume snapshot.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVolumeSnapshotAsync(DeleteVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a volume snapshot.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVolumeSnapshotAsync(DeleteVolumeSnapshotRequest request, st::CancellationToken cancellationToken) =>
            DeleteVolumeSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a volume snapshot.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteVolumeSnapshot(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVolumeSnapshot(new DeleteVolumeSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a volume snapshot.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVolumeSnapshotAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVolumeSnapshotAsync(new DeleteVolumeSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a volume snapshot.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVolumeSnapshotAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteVolumeSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a volume snapshot.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteVolumeSnapshot(VolumeSnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVolumeSnapshot(new DeleteVolumeSnapshotRequest
            {
                VolumeSnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a volume snapshot.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVolumeSnapshotAsync(VolumeSnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVolumeSnapshotAsync(new DeleteVolumeSnapshotRequest
            {
                VolumeSnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a volume snapshot.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVolumeSnapshotAsync(VolumeSnapshotName name, st::CancellationToken cancellationToken) =>
            DeleteVolumeSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified snapshot resource.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VolumeSnapshot GetVolumeSnapshot(GetVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified snapshot resource.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> GetVolumeSnapshotAsync(GetVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified snapshot resource.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> GetVolumeSnapshotAsync(GetVolumeSnapshotRequest request, st::CancellationToken cancellationToken) =>
            GetVolumeSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified snapshot resource.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VolumeSnapshot GetVolumeSnapshot(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeSnapshot(new GetVolumeSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified snapshot resource.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> GetVolumeSnapshotAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeSnapshotAsync(new GetVolumeSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified snapshot resource.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> GetVolumeSnapshotAsync(string name, st::CancellationToken cancellationToken) =>
            GetVolumeSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified snapshot resource.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VolumeSnapshot GetVolumeSnapshot(VolumeSnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeSnapshot(new GetVolumeSnapshotRequest
            {
                VolumeSnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified snapshot resource.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> GetVolumeSnapshotAsync(VolumeSnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeSnapshotAsync(new GetVolumeSnapshotRequest
            {
                VolumeSnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified snapshot resource.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> GetVolumeSnapshotAsync(VolumeSnapshotName name, st::CancellationToken cancellationToken) =>
            GetVolumeSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of snapshots for the specified volume.
        /// Returns a response with an empty list of snapshots if called
        /// for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VolumeSnapshot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> ListVolumeSnapshots(ListVolumeSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of snapshots for the specified volume.
        /// Returns a response with an empty list of snapshots if called
        /// for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VolumeSnapshot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> ListVolumeSnapshotsAsync(ListVolumeSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of snapshots for the specified volume.
        /// Returns a response with an empty list of snapshots if called
        /// for a non-boot volume.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest.
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
        /// <returns>A pageable sequence of <see cref="VolumeSnapshot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> ListVolumeSnapshots(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumeSnapshotsRequest request = new ListVolumeSnapshotsRequest
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
            return ListVolumeSnapshots(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of snapshots for the specified volume.
        /// Returns a response with an empty list of snapshots if called
        /// for a non-boot volume.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="VolumeSnapshot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> ListVolumeSnapshotsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumeSnapshotsRequest request = new ListVolumeSnapshotsRequest
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
            return ListVolumeSnapshotsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of snapshots for the specified volume.
        /// Returns a response with an empty list of snapshots if called
        /// for a non-boot volume.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest.
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
        /// <returns>A pageable sequence of <see cref="VolumeSnapshot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> ListVolumeSnapshots(VolumeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumeSnapshotsRequest request = new ListVolumeSnapshotsRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListVolumeSnapshots(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of snapshots for the specified volume.
        /// Returns a response with an empty list of snapshots if called
        /// for a non-boot volume.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="VolumeSnapshot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> ListVolumeSnapshotsAsync(VolumeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumeSnapshotsRequest request = new ListVolumeSnapshotsRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListVolumeSnapshotsAsync(request, callSettings);
        }

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Lun GetLun(GetLunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lun> GetLunAsync(GetLunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lun> GetLunAsync(GetLunRequest request, st::CancellationToken cancellationToken) =>
            GetLunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Lun GetLun(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLun(new GetLunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lun> GetLunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLunAsync(new GetLunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lun> GetLunAsync(string name, st::CancellationToken cancellationToken) =>
            GetLunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Lun GetLun(LunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLun(new GetLunRequest
            {
                LunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lun> GetLunAsync(LunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLunAsync(new GetLunRequest
            {
                LunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lun> GetLunAsync(LunName name, st::CancellationToken cancellationToken) =>
            GetLunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List storage volume luns for given storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Lun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLunsResponse, Lun> ListLuns(ListLunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List storage volume luns for given storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Lun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLunsResponse, Lun> ListLunsAsync(ListLunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List storage volume luns for given storage volume.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListLunsRequest.
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
        /// <returns>A pageable sequence of <see cref="Lun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLunsResponse, Lun> ListLuns(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLunsRequest request = new ListLunsRequest
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
            return ListLuns(request, callSettings);
        }

        /// <summary>
        /// List storage volume luns for given storage volume.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListLunsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Lun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLunsResponse, Lun> ListLunsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLunsRequest request = new ListLunsRequest
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
            return ListLunsAsync(request, callSettings);
        }

        /// <summary>
        /// List storage volume luns for given storage volume.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListLunsRequest.
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
        /// <returns>A pageable sequence of <see cref="Lun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLunsResponse, Lun> ListLuns(VolumeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLunsRequest request = new ListLunsRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLuns(request, callSettings);
        }

        /// <summary>
        /// List storage volume luns for given storage volume.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListLunsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Lun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLunsResponse, Lun> ListLunsAsync(VolumeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLunsRequest request = new ListLunsRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLunsAsync(request, callSettings);
        }

        /// <summary>
        /// Skips lun's cooloff and deletes it now.
        /// Lun must be in cooloff state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> EvictLun(EvictLunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Skips lun's cooloff and deletes it now.
        /// Lun must be in cooloff state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> EvictLunAsync(EvictLunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Skips lun's cooloff and deletes it now.
        /// Lun must be in cooloff state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> EvictLunAsync(EvictLunRequest request, st::CancellationToken cancellationToken) =>
            EvictLunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>EvictLun</c>.</summary>
        public virtual lro::OperationsClient EvictLunOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>EvictLun</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceEvictLun(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EvictLunOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EvictLun</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceEvictLunAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EvictLunOperationsClient, callSettings);

        /// <summary>
        /// Skips lun's cooloff and deletes it now.
        /// Lun must be in cooloff state.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the lun.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> EvictLun(string name, gaxgrpc::CallSettings callSettings = null) =>
            EvictLun(new EvictLunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Skips lun's cooloff and deletes it now.
        /// Lun must be in cooloff state.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the lun.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> EvictLunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            EvictLunAsync(new EvictLunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Skips lun's cooloff and deletes it now.
        /// Lun must be in cooloff state.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the lun.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> EvictLunAsync(string name, st::CancellationToken cancellationToken) =>
            EvictLunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Skips lun's cooloff and deletes it now.
        /// Lun must be in cooloff state.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the lun.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> EvictLun(LunName name, gaxgrpc::CallSettings callSettings = null) =>
            EvictLun(new EvictLunRequest
            {
                LunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Skips lun's cooloff and deletes it now.
        /// Lun must be in cooloff state.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the lun.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> EvictLunAsync(LunName name, gaxgrpc::CallSettings callSettings = null) =>
            EvictLunAsync(new EvictLunRequest
            {
                LunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Skips lun's cooloff and deletes it now.
        /// Lun must be in cooloff state.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the lun.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> EvictLunAsync(LunName name, st::CancellationToken cancellationToken) =>
            EvictLunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single NFS share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NfsShare GetNfsShare(GetNfsShareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single NFS share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NfsShare> GetNfsShareAsync(GetNfsShareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single NFS share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NfsShare> GetNfsShareAsync(GetNfsShareRequest request, st::CancellationToken cancellationToken) =>
            GetNfsShareAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single NFS share.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NfsShare GetNfsShare(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNfsShare(new GetNfsShareRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single NFS share.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NfsShare> GetNfsShareAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNfsShareAsync(new GetNfsShareRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single NFS share.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NfsShare> GetNfsShareAsync(string name, st::CancellationToken cancellationToken) =>
            GetNfsShareAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single NFS share.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NfsShare GetNfsShare(NFSShareName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNfsShare(new GetNfsShareRequest
            {
                NFSShareName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single NFS share.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NfsShare> GetNfsShareAsync(NFSShareName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNfsShareAsync(new GetNfsShareRequest
            {
                NFSShareName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single NFS share.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NfsShare> GetNfsShareAsync(NFSShareName name, st::CancellationToken cancellationToken) =>
            GetNfsShareAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List NFS shares.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NfsShare"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNfsSharesResponse, NfsShare> ListNfsShares(ListNfsSharesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List NFS shares.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NfsShare"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNfsSharesResponse, NfsShare> ListNfsSharesAsync(ListNfsSharesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List NFS shares.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListNfsSharesRequest.
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
        /// <returns>A pageable sequence of <see cref="NfsShare"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNfsSharesResponse, NfsShare> ListNfsShares(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNfsSharesRequest request = new ListNfsSharesRequest
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
            return ListNfsShares(request, callSettings);
        }

        /// <summary>
        /// List NFS shares.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListNfsSharesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NfsShare"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNfsSharesResponse, NfsShare> ListNfsSharesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNfsSharesRequest request = new ListNfsSharesRequest
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
            return ListNfsSharesAsync(request, callSettings);
        }

        /// <summary>
        /// List NFS shares.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListNfsSharesRequest.
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
        /// <returns>A pageable sequence of <see cref="NfsShare"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNfsSharesResponse, NfsShare> ListNfsShares(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNfsSharesRequest request = new ListNfsSharesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNfsShares(request, callSettings);
        }

        /// <summary>
        /// List NFS shares.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListNfsSharesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NfsShare"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNfsSharesResponse, NfsShare> ListNfsSharesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNfsSharesRequest request = new ListNfsSharesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNfsSharesAsync(request, callSettings);
        }

        /// <summary>
        /// Update details of a single NFS share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NfsShare, OperationMetadata> UpdateNfsShare(UpdateNfsShareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update details of a single NFS share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NfsShare, OperationMetadata>> UpdateNfsShareAsync(UpdateNfsShareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update details of a single NFS share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NfsShare, OperationMetadata>> UpdateNfsShareAsync(UpdateNfsShareRequest request, st::CancellationToken cancellationToken) =>
            UpdateNfsShareAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateNfsShare</c>.</summary>
        public virtual lro::OperationsClient UpdateNfsShareOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateNfsShare</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<NfsShare, OperationMetadata> PollOnceUpdateNfsShare(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<NfsShare, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateNfsShareOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateNfsShare</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<NfsShare, OperationMetadata>> PollOnceUpdateNfsShareAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<NfsShare, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateNfsShareOperationsClient, callSettings);

        /// <summary>
        /// Update details of a single NFS share.
        /// </summary>
        /// <param name="nfsShare">
        /// Required. The NFS share to update.
        /// 
        /// The `name` field is used to identify the NFS share to update.
        /// Format: projects/{project}/locations/{location}/nfsShares/{nfs_share}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// The only currently supported fields are:
        /// `labels`
        /// `allowed_clients`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NfsShare, OperationMetadata> UpdateNfsShare(NfsShare nfsShare, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNfsShare(new UpdateNfsShareRequest
            {
                NfsShare = gax::GaxPreconditions.CheckNotNull(nfsShare, nameof(nfsShare)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update details of a single NFS share.
        /// </summary>
        /// <param name="nfsShare">
        /// Required. The NFS share to update.
        /// 
        /// The `name` field is used to identify the NFS share to update.
        /// Format: projects/{project}/locations/{location}/nfsShares/{nfs_share}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// The only currently supported fields are:
        /// `labels`
        /// `allowed_clients`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NfsShare, OperationMetadata>> UpdateNfsShareAsync(NfsShare nfsShare, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNfsShareAsync(new UpdateNfsShareRequest
            {
                NfsShare = gax::GaxPreconditions.CheckNotNull(nfsShare, nameof(nfsShare)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update details of a single NFS share.
        /// </summary>
        /// <param name="nfsShare">
        /// Required. The NFS share to update.
        /// 
        /// The `name` field is used to identify the NFS share to update.
        /// Format: projects/{project}/locations/{location}/nfsShares/{nfs_share}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// The only currently supported fields are:
        /// `labels`
        /// `allowed_clients`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NfsShare, OperationMetadata>> UpdateNfsShareAsync(NfsShare nfsShare, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateNfsShareAsync(nfsShare, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an NFS share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NfsShare, OperationMetadata> CreateNfsShare(CreateNfsShareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an NFS share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NfsShare, OperationMetadata>> CreateNfsShareAsync(CreateNfsShareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an NFS share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NfsShare, OperationMetadata>> CreateNfsShareAsync(CreateNfsShareRequest request, st::CancellationToken cancellationToken) =>
            CreateNfsShareAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateNfsShare</c>.</summary>
        public virtual lro::OperationsClient CreateNfsShareOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateNfsShare</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<NfsShare, OperationMetadata> PollOnceCreateNfsShare(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<NfsShare, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateNfsShareOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateNfsShare</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<NfsShare, OperationMetadata>> PollOnceCreateNfsShareAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<NfsShare, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateNfsShareOperationsClient, callSettings);

        /// <summary>
        /// Create an NFS share.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location.
        /// </param>
        /// <param name="nfsShare">
        /// Required. The NfsShare to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NfsShare, OperationMetadata> CreateNfsShare(string parent, NfsShare nfsShare, gaxgrpc::CallSettings callSettings = null) =>
            CreateNfsShare(new CreateNfsShareRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NfsShare = gax::GaxPreconditions.CheckNotNull(nfsShare, nameof(nfsShare)),
            }, callSettings);

        /// <summary>
        /// Create an NFS share.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location.
        /// </param>
        /// <param name="nfsShare">
        /// Required. The NfsShare to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NfsShare, OperationMetadata>> CreateNfsShareAsync(string parent, NfsShare nfsShare, gaxgrpc::CallSettings callSettings = null) =>
            CreateNfsShareAsync(new CreateNfsShareRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NfsShare = gax::GaxPreconditions.CheckNotNull(nfsShare, nameof(nfsShare)),
            }, callSettings);

        /// <summary>
        /// Create an NFS share.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location.
        /// </param>
        /// <param name="nfsShare">
        /// Required. The NfsShare to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NfsShare, OperationMetadata>> CreateNfsShareAsync(string parent, NfsShare nfsShare, st::CancellationToken cancellationToken) =>
            CreateNfsShareAsync(parent, nfsShare, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an NFS share.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location.
        /// </param>
        /// <param name="nfsShare">
        /// Required. The NfsShare to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NfsShare, OperationMetadata> CreateNfsShare(gagr::LocationName parent, NfsShare nfsShare, gaxgrpc::CallSettings callSettings = null) =>
            CreateNfsShare(new CreateNfsShareRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NfsShare = gax::GaxPreconditions.CheckNotNull(nfsShare, nameof(nfsShare)),
            }, callSettings);

        /// <summary>
        /// Create an NFS share.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location.
        /// </param>
        /// <param name="nfsShare">
        /// Required. The NfsShare to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NfsShare, OperationMetadata>> CreateNfsShareAsync(gagr::LocationName parent, NfsShare nfsShare, gaxgrpc::CallSettings callSettings = null) =>
            CreateNfsShareAsync(new CreateNfsShareRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NfsShare = gax::GaxPreconditions.CheckNotNull(nfsShare, nameof(nfsShare)),
            }, callSettings);

        /// <summary>
        /// Create an NFS share.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location.
        /// </param>
        /// <param name="nfsShare">
        /// Required. The NfsShare to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NfsShare, OperationMetadata>> CreateNfsShareAsync(gagr::LocationName parent, NfsShare nfsShare, st::CancellationToken cancellationToken) =>
            CreateNfsShareAsync(parent, nfsShare, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RenameNfsShare sets a new name for an nfsshare.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NfsShare RenameNfsShare(RenameNfsShareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RenameNfsShare sets a new name for an nfsshare.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NfsShare> RenameNfsShareAsync(RenameNfsShareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RenameNfsShare sets a new name for an nfsshare.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NfsShare> RenameNfsShareAsync(RenameNfsShareRequest request, st::CancellationToken cancellationToken) =>
            RenameNfsShareAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RenameNfsShare sets a new name for an nfsshare.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the nfsshare.
        /// Format: projects/{project}/locations/{location}/nfsshares/{nfsshare}
        /// </param>
        /// <param name="newNfsshareId">
        /// Required. The new `id` of the nfsshare.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NfsShare RenameNfsShare(string name, string newNfsshareId, gaxgrpc::CallSettings callSettings = null) =>
            RenameNfsShare(new RenameNfsShareRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NewNfsshareId = gax::GaxPreconditions.CheckNotNullOrEmpty(newNfsshareId, nameof(newNfsshareId)),
            }, callSettings);

        /// <summary>
        /// RenameNfsShare sets a new name for an nfsshare.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the nfsshare.
        /// Format: projects/{project}/locations/{location}/nfsshares/{nfsshare}
        /// </param>
        /// <param name="newNfsshareId">
        /// Required. The new `id` of the nfsshare.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NfsShare> RenameNfsShareAsync(string name, string newNfsshareId, gaxgrpc::CallSettings callSettings = null) =>
            RenameNfsShareAsync(new RenameNfsShareRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NewNfsshareId = gax::GaxPreconditions.CheckNotNullOrEmpty(newNfsshareId, nameof(newNfsshareId)),
            }, callSettings);

        /// <summary>
        /// RenameNfsShare sets a new name for an nfsshare.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the nfsshare.
        /// Format: projects/{project}/locations/{location}/nfsshares/{nfsshare}
        /// </param>
        /// <param name="newNfsshareId">
        /// Required. The new `id` of the nfsshare.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NfsShare> RenameNfsShareAsync(string name, string newNfsshareId, st::CancellationToken cancellationToken) =>
            RenameNfsShareAsync(name, newNfsshareId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RenameNfsShare sets a new name for an nfsshare.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the nfsshare.
        /// Format: projects/{project}/locations/{location}/nfsshares/{nfsshare}
        /// </param>
        /// <param name="newNfsshareId">
        /// Required. The new `id` of the nfsshare.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NfsShare RenameNfsShare(NFSShareName name, string newNfsshareId, gaxgrpc::CallSettings callSettings = null) =>
            RenameNfsShare(new RenameNfsShareRequest
            {
                NFSShareName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NewNfsshareId = gax::GaxPreconditions.CheckNotNullOrEmpty(newNfsshareId, nameof(newNfsshareId)),
            }, callSettings);

        /// <summary>
        /// RenameNfsShare sets a new name for an nfsshare.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the nfsshare.
        /// Format: projects/{project}/locations/{location}/nfsshares/{nfsshare}
        /// </param>
        /// <param name="newNfsshareId">
        /// Required. The new `id` of the nfsshare.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NfsShare> RenameNfsShareAsync(NFSShareName name, string newNfsshareId, gaxgrpc::CallSettings callSettings = null) =>
            RenameNfsShareAsync(new RenameNfsShareRequest
            {
                NFSShareName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NewNfsshareId = gax::GaxPreconditions.CheckNotNullOrEmpty(newNfsshareId, nameof(newNfsshareId)),
            }, callSettings);

        /// <summary>
        /// RenameNfsShare sets a new name for an nfsshare.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the nfsshare.
        /// Format: projects/{project}/locations/{location}/nfsshares/{nfsshare}
        /// </param>
        /// <param name="newNfsshareId">
        /// Required. The new `id` of the nfsshare.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NfsShare> RenameNfsShareAsync(NFSShareName name, string newNfsshareId, st::CancellationToken cancellationToken) =>
            RenameNfsShareAsync(name, newNfsshareId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an NFS share. The underlying volume is automatically deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteNfsShare(DeleteNfsShareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an NFS share. The underlying volume is automatically deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNfsShareAsync(DeleteNfsShareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an NFS share. The underlying volume is automatically deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNfsShareAsync(DeleteNfsShareRequest request, st::CancellationToken cancellationToken) =>
            DeleteNfsShareAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteNfsShare</c>.</summary>
        public virtual lro::OperationsClient DeleteNfsShareOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteNfsShare</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteNfsShare(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteNfsShareOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteNfsShare</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteNfsShareAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteNfsShareOperationsClient, callSettings);

        /// <summary>
        /// Delete an NFS share. The underlying volume is automatically deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NFS share to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteNfsShare(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNfsShare(new DeleteNfsShareRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an NFS share. The underlying volume is automatically deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NFS share to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNfsShareAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNfsShareAsync(new DeleteNfsShareRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an NFS share. The underlying volume is automatically deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NFS share to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNfsShareAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteNfsShareAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an NFS share. The underlying volume is automatically deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NFS share to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteNfsShare(NFSShareName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNfsShare(new DeleteNfsShareRequest
            {
                NFSShareName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an NFS share. The underlying volume is automatically deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NFS share to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNfsShareAsync(NFSShareName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNfsShareAsync(new DeleteNfsShareRequest
            {
                NFSShareName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an NFS share. The underlying volume is automatically deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NFS share to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNfsShareAsync(NFSShareName name, st::CancellationToken cancellationToken) =>
            DeleteNfsShareAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List the budget details to provision resources on a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProvisioningQuota"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProvisioningQuotasResponse, ProvisioningQuota> ListProvisioningQuotas(ListProvisioningQuotasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List the budget details to provision resources on a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProvisioningQuota"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProvisioningQuotasResponse, ProvisioningQuota> ListProvisioningQuotasAsync(ListProvisioningQuotasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List the budget details to provision resources on a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProvisioningQuotasRequest.
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
        /// <returns>A pageable sequence of <see cref="ProvisioningQuota"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProvisioningQuotasResponse, ProvisioningQuota> ListProvisioningQuotas(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProvisioningQuotasRequest request = new ListProvisioningQuotasRequest
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
            return ListProvisioningQuotas(request, callSettings);
        }

        /// <summary>
        /// List the budget details to provision resources on a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProvisioningQuotasRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProvisioningQuota"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProvisioningQuotasResponse, ProvisioningQuota> ListProvisioningQuotasAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProvisioningQuotasRequest request = new ListProvisioningQuotasRequest
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
            return ListProvisioningQuotasAsync(request, callSettings);
        }

        /// <summary>
        /// List the budget details to provision resources on a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProvisioningQuotasRequest.
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
        /// <returns>A pageable sequence of <see cref="ProvisioningQuota"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProvisioningQuotasResponse, ProvisioningQuota> ListProvisioningQuotas(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProvisioningQuotasRequest request = new ListProvisioningQuotasRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProvisioningQuotas(request, callSettings);
        }

        /// <summary>
        /// List the budget details to provision resources on a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProvisioningQuotasRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProvisioningQuota"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProvisioningQuotasResponse, ProvisioningQuota> ListProvisioningQuotasAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProvisioningQuotasRequest request = new ListProvisioningQuotasRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProvisioningQuotasAsync(request, callSettings);
        }

        /// <summary>
        /// Submit a provisiong configuration for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SubmitProvisioningConfigResponse SubmitProvisioningConfig(SubmitProvisioningConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Submit a provisiong configuration for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SubmitProvisioningConfigResponse> SubmitProvisioningConfigAsync(SubmitProvisioningConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Submit a provisiong configuration for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SubmitProvisioningConfigResponse> SubmitProvisioningConfigAsync(SubmitProvisioningConfigRequest request, st::CancellationToken cancellationToken) =>
            SubmitProvisioningConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submit a provisiong configuration for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location containing the
        /// ProvisioningConfig.
        /// </param>
        /// <param name="provisioningConfig">
        /// Required. The ProvisioningConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SubmitProvisioningConfigResponse SubmitProvisioningConfig(string parent, ProvisioningConfig provisioningConfig, gaxgrpc::CallSettings callSettings = null) =>
            SubmitProvisioningConfig(new SubmitProvisioningConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ProvisioningConfig = gax::GaxPreconditions.CheckNotNull(provisioningConfig, nameof(provisioningConfig)),
            }, callSettings);

        /// <summary>
        /// Submit a provisiong configuration for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location containing the
        /// ProvisioningConfig.
        /// </param>
        /// <param name="provisioningConfig">
        /// Required. The ProvisioningConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SubmitProvisioningConfigResponse> SubmitProvisioningConfigAsync(string parent, ProvisioningConfig provisioningConfig, gaxgrpc::CallSettings callSettings = null) =>
            SubmitProvisioningConfigAsync(new SubmitProvisioningConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ProvisioningConfig = gax::GaxPreconditions.CheckNotNull(provisioningConfig, nameof(provisioningConfig)),
            }, callSettings);

        /// <summary>
        /// Submit a provisiong configuration for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location containing the
        /// ProvisioningConfig.
        /// </param>
        /// <param name="provisioningConfig">
        /// Required. The ProvisioningConfig to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SubmitProvisioningConfigResponse> SubmitProvisioningConfigAsync(string parent, ProvisioningConfig provisioningConfig, st::CancellationToken cancellationToken) =>
            SubmitProvisioningConfigAsync(parent, provisioningConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submit a provisiong configuration for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location containing the
        /// ProvisioningConfig.
        /// </param>
        /// <param name="provisioningConfig">
        /// Required. The ProvisioningConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SubmitProvisioningConfigResponse SubmitProvisioningConfig(gagr::LocationName parent, ProvisioningConfig provisioningConfig, gaxgrpc::CallSettings callSettings = null) =>
            SubmitProvisioningConfig(new SubmitProvisioningConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProvisioningConfig = gax::GaxPreconditions.CheckNotNull(provisioningConfig, nameof(provisioningConfig)),
            }, callSettings);

        /// <summary>
        /// Submit a provisiong configuration for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location containing the
        /// ProvisioningConfig.
        /// </param>
        /// <param name="provisioningConfig">
        /// Required. The ProvisioningConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SubmitProvisioningConfigResponse> SubmitProvisioningConfigAsync(gagr::LocationName parent, ProvisioningConfig provisioningConfig, gaxgrpc::CallSettings callSettings = null) =>
            SubmitProvisioningConfigAsync(new SubmitProvisioningConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProvisioningConfig = gax::GaxPreconditions.CheckNotNull(provisioningConfig, nameof(provisioningConfig)),
            }, callSettings);

        /// <summary>
        /// Submit a provisiong configuration for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location containing the
        /// ProvisioningConfig.
        /// </param>
        /// <param name="provisioningConfig">
        /// Required. The ProvisioningConfig to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SubmitProvisioningConfigResponse> SubmitProvisioningConfigAsync(gagr::LocationName parent, ProvisioningConfig provisioningConfig, st::CancellationToken cancellationToken) =>
            SubmitProvisioningConfigAsync(parent, provisioningConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get ProvisioningConfig by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProvisioningConfig GetProvisioningConfig(GetProvisioningConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get ProvisioningConfig by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvisioningConfig> GetProvisioningConfigAsync(GetProvisioningConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get ProvisioningConfig by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvisioningConfig> GetProvisioningConfigAsync(GetProvisioningConfigRequest request, st::CancellationToken cancellationToken) =>
            GetProvisioningConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get ProvisioningConfig by name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ProvisioningConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProvisioningConfig GetProvisioningConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProvisioningConfig(new GetProvisioningConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get ProvisioningConfig by name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ProvisioningConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvisioningConfig> GetProvisioningConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProvisioningConfigAsync(new GetProvisioningConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get ProvisioningConfig by name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ProvisioningConfig.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvisioningConfig> GetProvisioningConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetProvisioningConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get ProvisioningConfig by name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ProvisioningConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProvisioningConfig GetProvisioningConfig(ProvisioningConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProvisioningConfig(new GetProvisioningConfigRequest
            {
                ProvisioningConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get ProvisioningConfig by name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ProvisioningConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvisioningConfig> GetProvisioningConfigAsync(ProvisioningConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProvisioningConfigAsync(new GetProvisioningConfigRequest
            {
                ProvisioningConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get ProvisioningConfig by name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ProvisioningConfig.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvisioningConfig> GetProvisioningConfigAsync(ProvisioningConfigName name, st::CancellationToken cancellationToken) =>
            GetProvisioningConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create new ProvisioningConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProvisioningConfig CreateProvisioningConfig(CreateProvisioningConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create new ProvisioningConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvisioningConfig> CreateProvisioningConfigAsync(CreateProvisioningConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create new ProvisioningConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvisioningConfig> CreateProvisioningConfigAsync(CreateProvisioningConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateProvisioningConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create new ProvisioningConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location containing the
        /// ProvisioningConfig.
        /// </param>
        /// <param name="provisioningConfig">
        /// Required. The ProvisioningConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProvisioningConfig CreateProvisioningConfig(string parent, ProvisioningConfig provisioningConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateProvisioningConfig(new CreateProvisioningConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ProvisioningConfig = gax::GaxPreconditions.CheckNotNull(provisioningConfig, nameof(provisioningConfig)),
            }, callSettings);

        /// <summary>
        /// Create new ProvisioningConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location containing the
        /// ProvisioningConfig.
        /// </param>
        /// <param name="provisioningConfig">
        /// Required. The ProvisioningConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvisioningConfig> CreateProvisioningConfigAsync(string parent, ProvisioningConfig provisioningConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateProvisioningConfigAsync(new CreateProvisioningConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ProvisioningConfig = gax::GaxPreconditions.CheckNotNull(provisioningConfig, nameof(provisioningConfig)),
            }, callSettings);

        /// <summary>
        /// Create new ProvisioningConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location containing the
        /// ProvisioningConfig.
        /// </param>
        /// <param name="provisioningConfig">
        /// Required. The ProvisioningConfig to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvisioningConfig> CreateProvisioningConfigAsync(string parent, ProvisioningConfig provisioningConfig, st::CancellationToken cancellationToken) =>
            CreateProvisioningConfigAsync(parent, provisioningConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create new ProvisioningConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location containing the
        /// ProvisioningConfig.
        /// </param>
        /// <param name="provisioningConfig">
        /// Required. The ProvisioningConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProvisioningConfig CreateProvisioningConfig(gagr::LocationName parent, ProvisioningConfig provisioningConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateProvisioningConfig(new CreateProvisioningConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProvisioningConfig = gax::GaxPreconditions.CheckNotNull(provisioningConfig, nameof(provisioningConfig)),
            }, callSettings);

        /// <summary>
        /// Create new ProvisioningConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location containing the
        /// ProvisioningConfig.
        /// </param>
        /// <param name="provisioningConfig">
        /// Required. The ProvisioningConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvisioningConfig> CreateProvisioningConfigAsync(gagr::LocationName parent, ProvisioningConfig provisioningConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateProvisioningConfigAsync(new CreateProvisioningConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProvisioningConfig = gax::GaxPreconditions.CheckNotNull(provisioningConfig, nameof(provisioningConfig)),
            }, callSettings);

        /// <summary>
        /// Create new ProvisioningConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location containing the
        /// ProvisioningConfig.
        /// </param>
        /// <param name="provisioningConfig">
        /// Required. The ProvisioningConfig to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvisioningConfig> CreateProvisioningConfigAsync(gagr::LocationName parent, ProvisioningConfig provisioningConfig, st::CancellationToken cancellationToken) =>
            CreateProvisioningConfigAsync(parent, provisioningConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update existing ProvisioningConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProvisioningConfig UpdateProvisioningConfig(UpdateProvisioningConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update existing ProvisioningConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvisioningConfig> UpdateProvisioningConfigAsync(UpdateProvisioningConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update existing ProvisioningConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvisioningConfig> UpdateProvisioningConfigAsync(UpdateProvisioningConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateProvisioningConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update existing ProvisioningConfig.
        /// </summary>
        /// <param name="provisioningConfig">
        /// Required. The ProvisioningConfig to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProvisioningConfig UpdateProvisioningConfig(ProvisioningConfig provisioningConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProvisioningConfig(new UpdateProvisioningConfigRequest
            {
                ProvisioningConfig = gax::GaxPreconditions.CheckNotNull(provisioningConfig, nameof(provisioningConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update existing ProvisioningConfig.
        /// </summary>
        /// <param name="provisioningConfig">
        /// Required. The ProvisioningConfig to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvisioningConfig> UpdateProvisioningConfigAsync(ProvisioningConfig provisioningConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProvisioningConfigAsync(new UpdateProvisioningConfigRequest
            {
                ProvisioningConfig = gax::GaxPreconditions.CheckNotNull(provisioningConfig, nameof(provisioningConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update existing ProvisioningConfig.
        /// </summary>
        /// <param name="provisioningConfig">
        /// Required. The ProvisioningConfig to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvisioningConfig> UpdateProvisioningConfigAsync(ProvisioningConfig provisioningConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateProvisioningConfigAsync(provisioningConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RenameNetwork sets a new name for a network.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network RenameNetwork(RenameNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RenameNetwork sets a new name for a network.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> RenameNetworkAsync(RenameNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RenameNetwork sets a new name for a network.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> RenameNetworkAsync(RenameNetworkRequest request, st::CancellationToken cancellationToken) =>
            RenameNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RenameNetwork sets a new name for a network.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the network.
        /// Format: projects/{project}/locations/{location}/networks/{network}
        /// </param>
        /// <param name="newNetworkId">
        /// Required. The new `id` of the network.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network RenameNetwork(string name, string newNetworkId, gaxgrpc::CallSettings callSettings = null) =>
            RenameNetwork(new RenameNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NewNetworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(newNetworkId, nameof(newNetworkId)),
            }, callSettings);

        /// <summary>
        /// RenameNetwork sets a new name for a network.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the network.
        /// Format: projects/{project}/locations/{location}/networks/{network}
        /// </param>
        /// <param name="newNetworkId">
        /// Required. The new `id` of the network.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> RenameNetworkAsync(string name, string newNetworkId, gaxgrpc::CallSettings callSettings = null) =>
            RenameNetworkAsync(new RenameNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NewNetworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(newNetworkId, nameof(newNetworkId)),
            }, callSettings);

        /// <summary>
        /// RenameNetwork sets a new name for a network.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the network.
        /// Format: projects/{project}/locations/{location}/networks/{network}
        /// </param>
        /// <param name="newNetworkId">
        /// Required. The new `id` of the network.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> RenameNetworkAsync(string name, string newNetworkId, st::CancellationToken cancellationToken) =>
            RenameNetworkAsync(name, newNetworkId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RenameNetwork sets a new name for a network.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the network.
        /// Format: projects/{project}/locations/{location}/networks/{network}
        /// </param>
        /// <param name="newNetworkId">
        /// Required. The new `id` of the network.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network RenameNetwork(NetworkName name, string newNetworkId, gaxgrpc::CallSettings callSettings = null) =>
            RenameNetwork(new RenameNetworkRequest
            {
                NetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NewNetworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(newNetworkId, nameof(newNetworkId)),
            }, callSettings);

        /// <summary>
        /// RenameNetwork sets a new name for a network.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the network.
        /// Format: projects/{project}/locations/{location}/networks/{network}
        /// </param>
        /// <param name="newNetworkId">
        /// Required. The new `id` of the network.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> RenameNetworkAsync(NetworkName name, string newNetworkId, gaxgrpc::CallSettings callSettings = null) =>
            RenameNetworkAsync(new RenameNetworkRequest
            {
                NetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NewNetworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(newNetworkId, nameof(newNetworkId)),
            }, callSettings);

        /// <summary>
        /// RenameNetwork sets a new name for a network.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the network.
        /// Format: projects/{project}/locations/{location}/networks/{network}
        /// </param>
        /// <param name="newNetworkId">
        /// Required. The new `id` of the network.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> RenameNetworkAsync(NetworkName name, string newNetworkId, st::CancellationToken cancellationToken) =>
            RenameNetworkAsync(name, newNetworkId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of OS images which are currently approved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OSImage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOSImagesResponse, OSImage> ListOSImages(ListOSImagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of OS images which are currently approved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OSImage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOSImagesResponse, OSImage> ListOSImagesAsync(ListOSImagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of OS images which are currently approved.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProvisioningQuotasRequest.
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
        /// <returns>A pageable sequence of <see cref="OSImage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOSImagesResponse, OSImage> ListOSImages(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOSImagesRequest request = new ListOSImagesRequest
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
            return ListOSImages(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of OS images which are currently approved.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProvisioningQuotasRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="OSImage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOSImagesResponse, OSImage> ListOSImagesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOSImagesRequest request = new ListOSImagesRequest
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
            return ListOSImagesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of OS images which are currently approved.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProvisioningQuotasRequest.
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
        /// <returns>A pageable sequence of <see cref="OSImage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOSImagesResponse, OSImage> ListOSImages(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOSImagesRequest request = new ListOSImagesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOSImages(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of OS images which are currently approved.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProvisioningQuotasRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="OSImage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOSImagesResponse, OSImage> ListOSImagesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOSImagesRequest request = new ListOSImagesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOSImagesAsync(request, callSettings);
        }
    }

    /// <summary>BareMetalSolution client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Performs management operations on Bare Metal Solution servers.
    /// 
    /// The `baremetalsolution.googleapis.com` service provides management
    /// capabilities for Bare Metal Solution servers. To access the API methods, you
    /// must assign Bare Metal Solution IAM roles containing the desired permissions
    /// to your staff in your Google Cloud project. You must also enable the Bare
    /// Metal Solution API. Once enabled, the methods act
    /// upon specific servers in your Bare Metal Solution environment.
    /// </remarks>
    public sealed partial class BareMetalSolutionClientImpl : BareMetalSolutionClient
    {
        private readonly gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;

        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGetInstance;

        private readonly gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> _callUpdateInstance;

        private readonly gaxgrpc::ApiCall<RenameInstanceRequest, Instance> _callRenameInstance;

        private readonly gaxgrpc::ApiCall<ResetInstanceRequest, lro::Operation> _callResetInstance;

        private readonly gaxgrpc::ApiCall<StartInstanceRequest, lro::Operation> _callStartInstance;

        private readonly gaxgrpc::ApiCall<StopInstanceRequest, lro::Operation> _callStopInstance;

        private readonly gaxgrpc::ApiCall<EnableInteractiveSerialConsoleRequest, lro::Operation> _callEnableInteractiveSerialConsole;

        private readonly gaxgrpc::ApiCall<DisableInteractiveSerialConsoleRequest, lro::Operation> _callDisableInteractiveSerialConsole;

        private readonly gaxgrpc::ApiCall<DetachLunRequest, lro::Operation> _callDetachLun;

        private readonly gaxgrpc::ApiCall<ListSSHKeysRequest, ListSSHKeysResponse> _callListSSHKeys;

        private readonly gaxgrpc::ApiCall<CreateSSHKeyRequest, SSHKey> _callCreateSSHKey;

        private readonly gaxgrpc::ApiCall<DeleteSSHKeyRequest, wkt::Empty> _callDeleteSSHKey;

        private readonly gaxgrpc::ApiCall<ListVolumesRequest, ListVolumesResponse> _callListVolumes;

        private readonly gaxgrpc::ApiCall<GetVolumeRequest, Volume> _callGetVolume;

        private readonly gaxgrpc::ApiCall<UpdateVolumeRequest, lro::Operation> _callUpdateVolume;

        private readonly gaxgrpc::ApiCall<RenameVolumeRequest, Volume> _callRenameVolume;

        private readonly gaxgrpc::ApiCall<EvictVolumeRequest, lro::Operation> _callEvictVolume;

        private readonly gaxgrpc::ApiCall<ResizeVolumeRequest, lro::Operation> _callResizeVolume;

        private readonly gaxgrpc::ApiCall<ListNetworksRequest, ListNetworksResponse> _callListNetworks;

        private readonly gaxgrpc::ApiCall<ListNetworkUsageRequest, ListNetworkUsageResponse> _callListNetworkUsage;

        private readonly gaxgrpc::ApiCall<GetNetworkRequest, Network> _callGetNetwork;

        private readonly gaxgrpc::ApiCall<UpdateNetworkRequest, lro::Operation> _callUpdateNetwork;

        private readonly gaxgrpc::ApiCall<CreateVolumeSnapshotRequest, VolumeSnapshot> _callCreateVolumeSnapshot;

        private readonly gaxgrpc::ApiCall<RestoreVolumeSnapshotRequest, lro::Operation> _callRestoreVolumeSnapshot;

        private readonly gaxgrpc::ApiCall<DeleteVolumeSnapshotRequest, wkt::Empty> _callDeleteVolumeSnapshot;

        private readonly gaxgrpc::ApiCall<GetVolumeSnapshotRequest, VolumeSnapshot> _callGetVolumeSnapshot;

        private readonly gaxgrpc::ApiCall<ListVolumeSnapshotsRequest, ListVolumeSnapshotsResponse> _callListVolumeSnapshots;

        private readonly gaxgrpc::ApiCall<GetLunRequest, Lun> _callGetLun;

        private readonly gaxgrpc::ApiCall<ListLunsRequest, ListLunsResponse> _callListLuns;

        private readonly gaxgrpc::ApiCall<EvictLunRequest, lro::Operation> _callEvictLun;

        private readonly gaxgrpc::ApiCall<GetNfsShareRequest, NfsShare> _callGetNfsShare;

        private readonly gaxgrpc::ApiCall<ListNfsSharesRequest, ListNfsSharesResponse> _callListNfsShares;

        private readonly gaxgrpc::ApiCall<UpdateNfsShareRequest, lro::Operation> _callUpdateNfsShare;

        private readonly gaxgrpc::ApiCall<CreateNfsShareRequest, lro::Operation> _callCreateNfsShare;

        private readonly gaxgrpc::ApiCall<RenameNfsShareRequest, NfsShare> _callRenameNfsShare;

        private readonly gaxgrpc::ApiCall<DeleteNfsShareRequest, lro::Operation> _callDeleteNfsShare;

        private readonly gaxgrpc::ApiCall<ListProvisioningQuotasRequest, ListProvisioningQuotasResponse> _callListProvisioningQuotas;

        private readonly gaxgrpc::ApiCall<SubmitProvisioningConfigRequest, SubmitProvisioningConfigResponse> _callSubmitProvisioningConfig;

        private readonly gaxgrpc::ApiCall<GetProvisioningConfigRequest, ProvisioningConfig> _callGetProvisioningConfig;

        private readonly gaxgrpc::ApiCall<CreateProvisioningConfigRequest, ProvisioningConfig> _callCreateProvisioningConfig;

        private readonly gaxgrpc::ApiCall<UpdateProvisioningConfigRequest, ProvisioningConfig> _callUpdateProvisioningConfig;

        private readonly gaxgrpc::ApiCall<RenameNetworkRequest, Network> _callRenameNetwork;

        private readonly gaxgrpc::ApiCall<ListOSImagesRequest, ListOSImagesResponse> _callListOSImages;

        /// <summary>
        /// Constructs a client wrapper for the BareMetalSolution service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BareMetalSolutionSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BareMetalSolutionClientImpl(BareMetalSolution.BareMetalSolutionClient grpcClient, BareMetalSolutionSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BareMetalSolutionSettings effectiveSettings = settings ?? BareMetalSolutionSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            UpdateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInstanceOperationsSettings, logger);
            ResetInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ResetInstanceOperationsSettings, logger);
            StartInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StartInstanceOperationsSettings, logger);
            StopInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StopInstanceOperationsSettings, logger);
            EnableInteractiveSerialConsoleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.EnableInteractiveSerialConsoleOperationsSettings, logger);
            DisableInteractiveSerialConsoleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DisableInteractiveSerialConsoleOperationsSettings, logger);
            DetachLunOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DetachLunOperationsSettings, logger);
            UpdateVolumeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateVolumeOperationsSettings, logger);
            EvictVolumeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.EvictVolumeOperationsSettings, logger);
            ResizeVolumeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ResizeVolumeOperationsSettings, logger);
            UpdateNetworkOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateNetworkOperationsSettings, logger);
            RestoreVolumeSnapshotOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RestoreVolumeSnapshotOperationsSettings, logger);
            EvictLunOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.EvictLunOperationsSettings, logger);
            UpdateNfsShareOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateNfsShareOperationsSettings, logger);
            CreateNfsShareOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateNfsShareOperationsSettings, logger);
            DeleteNfsShareOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteNfsShareOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>("ListInstances", grpcClient.ListInstancesAsync, grpcClient.ListInstances, effectiveSettings.ListInstancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>("GetInstance", grpcClient.GetInstanceAsync, grpcClient.GetInstance, effectiveSettings.GetInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstance);
            Modify_GetInstanceApiCall(ref _callGetInstance);
            _callUpdateInstance = clientHelper.BuildApiCall<UpdateInstanceRequest, lro::Operation>("UpdateInstance", grpcClient.UpdateInstanceAsync, grpcClient.UpdateInstance, effectiveSettings.UpdateInstanceSettings).WithGoogleRequestParam("instance.name", request => request.Instance?.Name);
            Modify_ApiCall(ref _callUpdateInstance);
            Modify_UpdateInstanceApiCall(ref _callUpdateInstance);
            _callRenameInstance = clientHelper.BuildApiCall<RenameInstanceRequest, Instance>("RenameInstance", grpcClient.RenameInstanceAsync, grpcClient.RenameInstance, effectiveSettings.RenameInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRenameInstance);
            Modify_RenameInstanceApiCall(ref _callRenameInstance);
            _callResetInstance = clientHelper.BuildApiCall<ResetInstanceRequest, lro::Operation>("ResetInstance", grpcClient.ResetInstanceAsync, grpcClient.ResetInstance, effectiveSettings.ResetInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResetInstance);
            Modify_ResetInstanceApiCall(ref _callResetInstance);
            _callStartInstance = clientHelper.BuildApiCall<StartInstanceRequest, lro::Operation>("StartInstance", grpcClient.StartInstanceAsync, grpcClient.StartInstance, effectiveSettings.StartInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartInstance);
            Modify_StartInstanceApiCall(ref _callStartInstance);
            _callStopInstance = clientHelper.BuildApiCall<StopInstanceRequest, lro::Operation>("StopInstance", grpcClient.StopInstanceAsync, grpcClient.StopInstance, effectiveSettings.StopInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStopInstance);
            Modify_StopInstanceApiCall(ref _callStopInstance);
            _callEnableInteractiveSerialConsole = clientHelper.BuildApiCall<EnableInteractiveSerialConsoleRequest, lro::Operation>("EnableInteractiveSerialConsole", grpcClient.EnableInteractiveSerialConsoleAsync, grpcClient.EnableInteractiveSerialConsole, effectiveSettings.EnableInteractiveSerialConsoleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEnableInteractiveSerialConsole);
            Modify_EnableInteractiveSerialConsoleApiCall(ref _callEnableInteractiveSerialConsole);
            _callDisableInteractiveSerialConsole = clientHelper.BuildApiCall<DisableInteractiveSerialConsoleRequest, lro::Operation>("DisableInteractiveSerialConsole", grpcClient.DisableInteractiveSerialConsoleAsync, grpcClient.DisableInteractiveSerialConsole, effectiveSettings.DisableInteractiveSerialConsoleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDisableInteractiveSerialConsole);
            Modify_DisableInteractiveSerialConsoleApiCall(ref _callDisableInteractiveSerialConsole);
            _callDetachLun = clientHelper.BuildApiCall<DetachLunRequest, lro::Operation>("DetachLun", grpcClient.DetachLunAsync, grpcClient.DetachLun, effectiveSettings.DetachLunSettings).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callDetachLun);
            Modify_DetachLunApiCall(ref _callDetachLun);
            _callListSSHKeys = clientHelper.BuildApiCall<ListSSHKeysRequest, ListSSHKeysResponse>("ListSSHKeys", grpcClient.ListSSHKeysAsync, grpcClient.ListSSHKeys, effectiveSettings.ListSSHKeysSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSSHKeys);
            Modify_ListSSHKeysApiCall(ref _callListSSHKeys);
            _callCreateSSHKey = clientHelper.BuildApiCall<CreateSSHKeyRequest, SSHKey>("CreateSSHKey", grpcClient.CreateSSHKeyAsync, grpcClient.CreateSSHKey, effectiveSettings.CreateSSHKeySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSSHKey);
            Modify_CreateSSHKeyApiCall(ref _callCreateSSHKey);
            _callDeleteSSHKey = clientHelper.BuildApiCall<DeleteSSHKeyRequest, wkt::Empty>("DeleteSSHKey", grpcClient.DeleteSSHKeyAsync, grpcClient.DeleteSSHKey, effectiveSettings.DeleteSSHKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSSHKey);
            Modify_DeleteSSHKeyApiCall(ref _callDeleteSSHKey);
            _callListVolumes = clientHelper.BuildApiCall<ListVolumesRequest, ListVolumesResponse>("ListVolumes", grpcClient.ListVolumesAsync, grpcClient.ListVolumes, effectiveSettings.ListVolumesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVolumes);
            Modify_ListVolumesApiCall(ref _callListVolumes);
            _callGetVolume = clientHelper.BuildApiCall<GetVolumeRequest, Volume>("GetVolume", grpcClient.GetVolumeAsync, grpcClient.GetVolume, effectiveSettings.GetVolumeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVolume);
            Modify_GetVolumeApiCall(ref _callGetVolume);
            _callUpdateVolume = clientHelper.BuildApiCall<UpdateVolumeRequest, lro::Operation>("UpdateVolume", grpcClient.UpdateVolumeAsync, grpcClient.UpdateVolume, effectiveSettings.UpdateVolumeSettings).WithGoogleRequestParam("volume.name", request => request.Volume?.Name);
            Modify_ApiCall(ref _callUpdateVolume);
            Modify_UpdateVolumeApiCall(ref _callUpdateVolume);
            _callRenameVolume = clientHelper.BuildApiCall<RenameVolumeRequest, Volume>("RenameVolume", grpcClient.RenameVolumeAsync, grpcClient.RenameVolume, effectiveSettings.RenameVolumeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRenameVolume);
            Modify_RenameVolumeApiCall(ref _callRenameVolume);
            _callEvictVolume = clientHelper.BuildApiCall<EvictVolumeRequest, lro::Operation>("EvictVolume", grpcClient.EvictVolumeAsync, grpcClient.EvictVolume, effectiveSettings.EvictVolumeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEvictVolume);
            Modify_EvictVolumeApiCall(ref _callEvictVolume);
            _callResizeVolume = clientHelper.BuildApiCall<ResizeVolumeRequest, lro::Operation>("ResizeVolume", grpcClient.ResizeVolumeAsync, grpcClient.ResizeVolume, effectiveSettings.ResizeVolumeSettings).WithGoogleRequestParam("volume", request => request.Volume);
            Modify_ApiCall(ref _callResizeVolume);
            Modify_ResizeVolumeApiCall(ref _callResizeVolume);
            _callListNetworks = clientHelper.BuildApiCall<ListNetworksRequest, ListNetworksResponse>("ListNetworks", grpcClient.ListNetworksAsync, grpcClient.ListNetworks, effectiveSettings.ListNetworksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNetworks);
            Modify_ListNetworksApiCall(ref _callListNetworks);
            _callListNetworkUsage = clientHelper.BuildApiCall<ListNetworkUsageRequest, ListNetworkUsageResponse>("ListNetworkUsage", grpcClient.ListNetworkUsageAsync, grpcClient.ListNetworkUsage, effectiveSettings.ListNetworkUsageSettings).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callListNetworkUsage);
            Modify_ListNetworkUsageApiCall(ref _callListNetworkUsage);
            _callGetNetwork = clientHelper.BuildApiCall<GetNetworkRequest, Network>("GetNetwork", grpcClient.GetNetworkAsync, grpcClient.GetNetwork, effectiveSettings.GetNetworkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNetwork);
            Modify_GetNetworkApiCall(ref _callGetNetwork);
            _callUpdateNetwork = clientHelper.BuildApiCall<UpdateNetworkRequest, lro::Operation>("UpdateNetwork", grpcClient.UpdateNetworkAsync, grpcClient.UpdateNetwork, effectiveSettings.UpdateNetworkSettings).WithGoogleRequestParam("network.name", request => request.Network?.Name);
            Modify_ApiCall(ref _callUpdateNetwork);
            Modify_UpdateNetworkApiCall(ref _callUpdateNetwork);
            _callCreateVolumeSnapshot = clientHelper.BuildApiCall<CreateVolumeSnapshotRequest, VolumeSnapshot>("CreateVolumeSnapshot", grpcClient.CreateVolumeSnapshotAsync, grpcClient.CreateVolumeSnapshot, effectiveSettings.CreateVolumeSnapshotSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateVolumeSnapshot);
            Modify_CreateVolumeSnapshotApiCall(ref _callCreateVolumeSnapshot);
            _callRestoreVolumeSnapshot = clientHelper.BuildApiCall<RestoreVolumeSnapshotRequest, lro::Operation>("RestoreVolumeSnapshot", grpcClient.RestoreVolumeSnapshotAsync, grpcClient.RestoreVolumeSnapshot, effectiveSettings.RestoreVolumeSnapshotSettings).WithGoogleRequestParam("volume_snapshot", request => request.VolumeSnapshot);
            Modify_ApiCall(ref _callRestoreVolumeSnapshot);
            Modify_RestoreVolumeSnapshotApiCall(ref _callRestoreVolumeSnapshot);
            _callDeleteVolumeSnapshot = clientHelper.BuildApiCall<DeleteVolumeSnapshotRequest, wkt::Empty>("DeleteVolumeSnapshot", grpcClient.DeleteVolumeSnapshotAsync, grpcClient.DeleteVolumeSnapshot, effectiveSettings.DeleteVolumeSnapshotSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteVolumeSnapshot);
            Modify_DeleteVolumeSnapshotApiCall(ref _callDeleteVolumeSnapshot);
            _callGetVolumeSnapshot = clientHelper.BuildApiCall<GetVolumeSnapshotRequest, VolumeSnapshot>("GetVolumeSnapshot", grpcClient.GetVolumeSnapshotAsync, grpcClient.GetVolumeSnapshot, effectiveSettings.GetVolumeSnapshotSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVolumeSnapshot);
            Modify_GetVolumeSnapshotApiCall(ref _callGetVolumeSnapshot);
            _callListVolumeSnapshots = clientHelper.BuildApiCall<ListVolumeSnapshotsRequest, ListVolumeSnapshotsResponse>("ListVolumeSnapshots", grpcClient.ListVolumeSnapshotsAsync, grpcClient.ListVolumeSnapshots, effectiveSettings.ListVolumeSnapshotsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVolumeSnapshots);
            Modify_ListVolumeSnapshotsApiCall(ref _callListVolumeSnapshots);
            _callGetLun = clientHelper.BuildApiCall<GetLunRequest, Lun>("GetLun", grpcClient.GetLunAsync, grpcClient.GetLun, effectiveSettings.GetLunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLun);
            Modify_GetLunApiCall(ref _callGetLun);
            _callListLuns = clientHelper.BuildApiCall<ListLunsRequest, ListLunsResponse>("ListLuns", grpcClient.ListLunsAsync, grpcClient.ListLuns, effectiveSettings.ListLunsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLuns);
            Modify_ListLunsApiCall(ref _callListLuns);
            _callEvictLun = clientHelper.BuildApiCall<EvictLunRequest, lro::Operation>("EvictLun", grpcClient.EvictLunAsync, grpcClient.EvictLun, effectiveSettings.EvictLunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEvictLun);
            Modify_EvictLunApiCall(ref _callEvictLun);
            _callGetNfsShare = clientHelper.BuildApiCall<GetNfsShareRequest, NfsShare>("GetNfsShare", grpcClient.GetNfsShareAsync, grpcClient.GetNfsShare, effectiveSettings.GetNfsShareSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNfsShare);
            Modify_GetNfsShareApiCall(ref _callGetNfsShare);
            _callListNfsShares = clientHelper.BuildApiCall<ListNfsSharesRequest, ListNfsSharesResponse>("ListNfsShares", grpcClient.ListNfsSharesAsync, grpcClient.ListNfsShares, effectiveSettings.ListNfsSharesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNfsShares);
            Modify_ListNfsSharesApiCall(ref _callListNfsShares);
            _callUpdateNfsShare = clientHelper.BuildApiCall<UpdateNfsShareRequest, lro::Operation>("UpdateNfsShare", grpcClient.UpdateNfsShareAsync, grpcClient.UpdateNfsShare, effectiveSettings.UpdateNfsShareSettings).WithGoogleRequestParam("nfs_share.name", request => request.NfsShare?.Name);
            Modify_ApiCall(ref _callUpdateNfsShare);
            Modify_UpdateNfsShareApiCall(ref _callUpdateNfsShare);
            _callCreateNfsShare = clientHelper.BuildApiCall<CreateNfsShareRequest, lro::Operation>("CreateNfsShare", grpcClient.CreateNfsShareAsync, grpcClient.CreateNfsShare, effectiveSettings.CreateNfsShareSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateNfsShare);
            Modify_CreateNfsShareApiCall(ref _callCreateNfsShare);
            _callRenameNfsShare = clientHelper.BuildApiCall<RenameNfsShareRequest, NfsShare>("RenameNfsShare", grpcClient.RenameNfsShareAsync, grpcClient.RenameNfsShare, effectiveSettings.RenameNfsShareSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRenameNfsShare);
            Modify_RenameNfsShareApiCall(ref _callRenameNfsShare);
            _callDeleteNfsShare = clientHelper.BuildApiCall<DeleteNfsShareRequest, lro::Operation>("DeleteNfsShare", grpcClient.DeleteNfsShareAsync, grpcClient.DeleteNfsShare, effectiveSettings.DeleteNfsShareSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteNfsShare);
            Modify_DeleteNfsShareApiCall(ref _callDeleteNfsShare);
            _callListProvisioningQuotas = clientHelper.BuildApiCall<ListProvisioningQuotasRequest, ListProvisioningQuotasResponse>("ListProvisioningQuotas", grpcClient.ListProvisioningQuotasAsync, grpcClient.ListProvisioningQuotas, effectiveSettings.ListProvisioningQuotasSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProvisioningQuotas);
            Modify_ListProvisioningQuotasApiCall(ref _callListProvisioningQuotas);
            _callSubmitProvisioningConfig = clientHelper.BuildApiCall<SubmitProvisioningConfigRequest, SubmitProvisioningConfigResponse>("SubmitProvisioningConfig", grpcClient.SubmitProvisioningConfigAsync, grpcClient.SubmitProvisioningConfig, effectiveSettings.SubmitProvisioningConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSubmitProvisioningConfig);
            Modify_SubmitProvisioningConfigApiCall(ref _callSubmitProvisioningConfig);
            _callGetProvisioningConfig = clientHelper.BuildApiCall<GetProvisioningConfigRequest, ProvisioningConfig>("GetProvisioningConfig", grpcClient.GetProvisioningConfigAsync, grpcClient.GetProvisioningConfig, effectiveSettings.GetProvisioningConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProvisioningConfig);
            Modify_GetProvisioningConfigApiCall(ref _callGetProvisioningConfig);
            _callCreateProvisioningConfig = clientHelper.BuildApiCall<CreateProvisioningConfigRequest, ProvisioningConfig>("CreateProvisioningConfig", grpcClient.CreateProvisioningConfigAsync, grpcClient.CreateProvisioningConfig, effectiveSettings.CreateProvisioningConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateProvisioningConfig);
            Modify_CreateProvisioningConfigApiCall(ref _callCreateProvisioningConfig);
            _callUpdateProvisioningConfig = clientHelper.BuildApiCall<UpdateProvisioningConfigRequest, ProvisioningConfig>("UpdateProvisioningConfig", grpcClient.UpdateProvisioningConfigAsync, grpcClient.UpdateProvisioningConfig, effectiveSettings.UpdateProvisioningConfigSettings).WithGoogleRequestParam("provisioning_config.name", request => request.ProvisioningConfig?.Name);
            Modify_ApiCall(ref _callUpdateProvisioningConfig);
            Modify_UpdateProvisioningConfigApiCall(ref _callUpdateProvisioningConfig);
            _callRenameNetwork = clientHelper.BuildApiCall<RenameNetworkRequest, Network>("RenameNetwork", grpcClient.RenameNetworkAsync, grpcClient.RenameNetwork, effectiveSettings.RenameNetworkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRenameNetwork);
            Modify_RenameNetworkApiCall(ref _callRenameNetwork);
            _callListOSImages = clientHelper.BuildApiCall<ListOSImagesRequest, ListOSImagesResponse>("ListOSImages", grpcClient.ListOSImagesAsync, grpcClient.ListOSImages, effectiveSettings.ListOSImagesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOSImages);
            Modify_ListOSImagesApiCall(ref _callListOSImages);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);

        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);

        partial void Modify_UpdateInstanceApiCall(ref gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> call);

        partial void Modify_RenameInstanceApiCall(ref gaxgrpc::ApiCall<RenameInstanceRequest, Instance> call);

        partial void Modify_ResetInstanceApiCall(ref gaxgrpc::ApiCall<ResetInstanceRequest, lro::Operation> call);

        partial void Modify_StartInstanceApiCall(ref gaxgrpc::ApiCall<StartInstanceRequest, lro::Operation> call);

        partial void Modify_StopInstanceApiCall(ref gaxgrpc::ApiCall<StopInstanceRequest, lro::Operation> call);

        partial void Modify_EnableInteractiveSerialConsoleApiCall(ref gaxgrpc::ApiCall<EnableInteractiveSerialConsoleRequest, lro::Operation> call);

        partial void Modify_DisableInteractiveSerialConsoleApiCall(ref gaxgrpc::ApiCall<DisableInteractiveSerialConsoleRequest, lro::Operation> call);

        partial void Modify_DetachLunApiCall(ref gaxgrpc::ApiCall<DetachLunRequest, lro::Operation> call);

        partial void Modify_ListSSHKeysApiCall(ref gaxgrpc::ApiCall<ListSSHKeysRequest, ListSSHKeysResponse> call);

        partial void Modify_CreateSSHKeyApiCall(ref gaxgrpc::ApiCall<CreateSSHKeyRequest, SSHKey> call);

        partial void Modify_DeleteSSHKeyApiCall(ref gaxgrpc::ApiCall<DeleteSSHKeyRequest, wkt::Empty> call);

        partial void Modify_ListVolumesApiCall(ref gaxgrpc::ApiCall<ListVolumesRequest, ListVolumesResponse> call);

        partial void Modify_GetVolumeApiCall(ref gaxgrpc::ApiCall<GetVolumeRequest, Volume> call);

        partial void Modify_UpdateVolumeApiCall(ref gaxgrpc::ApiCall<UpdateVolumeRequest, lro::Operation> call);

        partial void Modify_RenameVolumeApiCall(ref gaxgrpc::ApiCall<RenameVolumeRequest, Volume> call);

        partial void Modify_EvictVolumeApiCall(ref gaxgrpc::ApiCall<EvictVolumeRequest, lro::Operation> call);

        partial void Modify_ResizeVolumeApiCall(ref gaxgrpc::ApiCall<ResizeVolumeRequest, lro::Operation> call);

        partial void Modify_ListNetworksApiCall(ref gaxgrpc::ApiCall<ListNetworksRequest, ListNetworksResponse> call);

        partial void Modify_ListNetworkUsageApiCall(ref gaxgrpc::ApiCall<ListNetworkUsageRequest, ListNetworkUsageResponse> call);

        partial void Modify_GetNetworkApiCall(ref gaxgrpc::ApiCall<GetNetworkRequest, Network> call);

        partial void Modify_UpdateNetworkApiCall(ref gaxgrpc::ApiCall<UpdateNetworkRequest, lro::Operation> call);

        partial void Modify_CreateVolumeSnapshotApiCall(ref gaxgrpc::ApiCall<CreateVolumeSnapshotRequest, VolumeSnapshot> call);

        partial void Modify_RestoreVolumeSnapshotApiCall(ref gaxgrpc::ApiCall<RestoreVolumeSnapshotRequest, lro::Operation> call);

        partial void Modify_DeleteVolumeSnapshotApiCall(ref gaxgrpc::ApiCall<DeleteVolumeSnapshotRequest, wkt::Empty> call);

        partial void Modify_GetVolumeSnapshotApiCall(ref gaxgrpc::ApiCall<GetVolumeSnapshotRequest, VolumeSnapshot> call);

        partial void Modify_ListVolumeSnapshotsApiCall(ref gaxgrpc::ApiCall<ListVolumeSnapshotsRequest, ListVolumeSnapshotsResponse> call);

        partial void Modify_GetLunApiCall(ref gaxgrpc::ApiCall<GetLunRequest, Lun> call);

        partial void Modify_ListLunsApiCall(ref gaxgrpc::ApiCall<ListLunsRequest, ListLunsResponse> call);

        partial void Modify_EvictLunApiCall(ref gaxgrpc::ApiCall<EvictLunRequest, lro::Operation> call);

        partial void Modify_GetNfsShareApiCall(ref gaxgrpc::ApiCall<GetNfsShareRequest, NfsShare> call);

        partial void Modify_ListNfsSharesApiCall(ref gaxgrpc::ApiCall<ListNfsSharesRequest, ListNfsSharesResponse> call);

        partial void Modify_UpdateNfsShareApiCall(ref gaxgrpc::ApiCall<UpdateNfsShareRequest, lro::Operation> call);

        partial void Modify_CreateNfsShareApiCall(ref gaxgrpc::ApiCall<CreateNfsShareRequest, lro::Operation> call);

        partial void Modify_RenameNfsShareApiCall(ref gaxgrpc::ApiCall<RenameNfsShareRequest, NfsShare> call);

        partial void Modify_DeleteNfsShareApiCall(ref gaxgrpc::ApiCall<DeleteNfsShareRequest, lro::Operation> call);

        partial void Modify_ListProvisioningQuotasApiCall(ref gaxgrpc::ApiCall<ListProvisioningQuotasRequest, ListProvisioningQuotasResponse> call);

        partial void Modify_SubmitProvisioningConfigApiCall(ref gaxgrpc::ApiCall<SubmitProvisioningConfigRequest, SubmitProvisioningConfigResponse> call);

        partial void Modify_GetProvisioningConfigApiCall(ref gaxgrpc::ApiCall<GetProvisioningConfigRequest, ProvisioningConfig> call);

        partial void Modify_CreateProvisioningConfigApiCall(ref gaxgrpc::ApiCall<CreateProvisioningConfigRequest, ProvisioningConfig> call);

        partial void Modify_UpdateProvisioningConfigApiCall(ref gaxgrpc::ApiCall<UpdateProvisioningConfigRequest, ProvisioningConfig> call);

        partial void Modify_RenameNetworkApiCall(ref gaxgrpc::ApiCall<RenameNetworkRequest, Network> call);

        partial void Modify_ListOSImagesApiCall(ref gaxgrpc::ApiCall<ListOSImagesRequest, ListOSImagesResponse> call);

        partial void OnConstruction(BareMetalSolution.BareMetalSolutionClient grpcClient, BareMetalSolutionSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BareMetalSolution client</summary>
        public override BareMetalSolution.BareMetalSolutionClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInstanceRequest(ref UpdateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RenameInstanceRequest(ref RenameInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResetInstanceRequest(ref ResetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartInstanceRequest(ref StartInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopInstanceRequest(ref StopInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnableInteractiveSerialConsoleRequest(ref EnableInteractiveSerialConsoleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DisableInteractiveSerialConsoleRequest(ref DisableInteractiveSerialConsoleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DetachLunRequest(ref DetachLunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSSHKeysRequest(ref ListSSHKeysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSSHKeyRequest(ref CreateSSHKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSSHKeyRequest(ref DeleteSSHKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVolumesRequest(ref ListVolumesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVolumeRequest(ref GetVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateVolumeRequest(ref UpdateVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RenameVolumeRequest(ref RenameVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EvictVolumeRequest(ref EvictVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResizeVolumeRequest(ref ResizeVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNetworksRequest(ref ListNetworksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNetworkUsageRequest(ref ListNetworkUsageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNetworkRequest(ref GetNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateNetworkRequest(ref UpdateNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateVolumeSnapshotRequest(ref CreateVolumeSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestoreVolumeSnapshotRequest(ref RestoreVolumeSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteVolumeSnapshotRequest(ref DeleteVolumeSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVolumeSnapshotRequest(ref GetVolumeSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVolumeSnapshotsRequest(ref ListVolumeSnapshotsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetLunRequest(ref GetLunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLunsRequest(ref ListLunsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EvictLunRequest(ref EvictLunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNfsShareRequest(ref GetNfsShareRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNfsSharesRequest(ref ListNfsSharesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateNfsShareRequest(ref UpdateNfsShareRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateNfsShareRequest(ref CreateNfsShareRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RenameNfsShareRequest(ref RenameNfsShareRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteNfsShareRequest(ref DeleteNfsShareRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProvisioningQuotasRequest(ref ListProvisioningQuotasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SubmitProvisioningConfigRequest(ref SubmitProvisioningConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProvisioningConfigRequest(ref GetProvisioningConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateProvisioningConfigRequest(ref CreateProvisioningConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateProvisioningConfigRequest(ref UpdateProvisioningConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RenameNetworkRequest(ref RenameNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOSImagesRequest(ref ListOSImagesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// List servers in a given project and location.
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
        /// List servers in a given project and location.
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
        /// Get details about a single server.
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
        /// Get details about a single server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateInstance</c>.</summary>
        public override lro::OperationsClient UpdateInstanceOperationsClient { get; }

        /// <summary>
        /// Update details of a single server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> UpdateInstance(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callUpdateInstance.Sync(request, callSettings), UpdateInstanceOperationsClient);
        }

        /// <summary>
        /// Update details of a single server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callUpdateInstance.Async(request, callSettings).ConfigureAwait(false), UpdateInstanceOperationsClient);
        }

        /// <summary>
        /// RenameInstance sets a new name for an instance.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Instance RenameInstance(RenameInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenameInstanceRequest(ref request, ref callSettings);
            return _callRenameInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// RenameInstance sets a new name for an instance.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Instance> RenameInstanceAsync(RenameInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenameInstanceRequest(ref request, ref callSettings);
            return _callRenameInstance.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ResetInstance</c>.</summary>
        public override lro::OperationsClient ResetInstanceOperationsClient { get; }

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ResetInstanceResponse, OperationMetadata> ResetInstance(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<ResetInstanceResponse, OperationMetadata>(_callResetInstance.Sync(request, callSettings), ResetInstanceOperationsClient);
        }

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ResetInstanceResponse, OperationMetadata>> ResetInstanceAsync(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<ResetInstanceResponse, OperationMetadata>(await _callResetInstance.Async(request, callSettings).ConfigureAwait(false), ResetInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StartInstance</c>.</summary>
        public override lro::OperationsClient StartInstanceOperationsClient { get; }

        /// <summary>
        /// Starts a server that was shutdown.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<StartInstanceResponse, OperationMetadata> StartInstance(StartInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<StartInstanceResponse, OperationMetadata>(_callStartInstance.Sync(request, callSettings), StartInstanceOperationsClient);
        }

        /// <summary>
        /// Starts a server that was shutdown.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<StartInstanceResponse, OperationMetadata>> StartInstanceAsync(StartInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<StartInstanceResponse, OperationMetadata>(await _callStartInstance.Async(request, callSettings).ConfigureAwait(false), StartInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StopInstance</c>.</summary>
        public override lro::OperationsClient StopInstanceOperationsClient { get; }

        /// <summary>
        /// Stop a running server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<StopInstanceResponse, OperationMetadata> StopInstance(StopInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<StopInstanceResponse, OperationMetadata>(_callStopInstance.Sync(request, callSettings), StopInstanceOperationsClient);
        }

        /// <summary>
        /// Stop a running server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<StopInstanceResponse, OperationMetadata>> StopInstanceAsync(StopInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<StopInstanceResponse, OperationMetadata>(await _callStopInstance.Async(request, callSettings).ConfigureAwait(false), StopInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>EnableInteractiveSerialConsole</c>.</summary>
        public override lro::OperationsClient EnableInteractiveSerialConsoleOperationsClient { get; }

        /// <summary>
        /// Enable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> EnableInteractiveSerialConsole(EnableInteractiveSerialConsoleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableInteractiveSerialConsoleRequest(ref request, ref callSettings);
            return new lro::Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata>(_callEnableInteractiveSerialConsole.Sync(request, callSettings), EnableInteractiveSerialConsoleOperationsClient);
        }

        /// <summary>
        /// Enable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata>> EnableInteractiveSerialConsoleAsync(EnableInteractiveSerialConsoleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableInteractiveSerialConsoleRequest(ref request, ref callSettings);
            return new lro::Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata>(await _callEnableInteractiveSerialConsole.Async(request, callSettings).ConfigureAwait(false), EnableInteractiveSerialConsoleOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DisableInteractiveSerialConsole</c>.</summary>
        public override lro::OperationsClient DisableInteractiveSerialConsoleOperationsClient { get; }

        /// <summary>
        /// Disable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> DisableInteractiveSerialConsole(DisableInteractiveSerialConsoleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableInteractiveSerialConsoleRequest(ref request, ref callSettings);
            return new lro::Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata>(_callDisableInteractiveSerialConsole.Sync(request, callSettings), DisableInteractiveSerialConsoleOperationsClient);
        }

        /// <summary>
        /// Disable the interactive serial console feature on an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata>> DisableInteractiveSerialConsoleAsync(DisableInteractiveSerialConsoleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableInteractiveSerialConsoleRequest(ref request, ref callSettings);
            return new lro::Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata>(await _callDisableInteractiveSerialConsole.Async(request, callSettings).ConfigureAwait(false), DisableInteractiveSerialConsoleOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DetachLun</c>.</summary>
        public override lro::OperationsClient DetachLunOperationsClient { get; }

        /// <summary>
        /// Detach LUN from Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> DetachLun(DetachLunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetachLunRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callDetachLun.Sync(request, callSettings), DetachLunOperationsClient);
        }

        /// <summary>
        /// Detach LUN from Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> DetachLunAsync(DetachLunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetachLunRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callDetachLun.Async(request, callSettings).ConfigureAwait(false), DetachLunOperationsClient);
        }

        /// <summary>
        /// Lists the public SSH keys registered for the specified project.
        /// These SSH keys are used only for the interactive serial console feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SSHKey"/> resources.</returns>
        public override gax::PagedEnumerable<ListSSHKeysResponse, SSHKey> ListSSHKeys(ListSSHKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSSHKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSSHKeysRequest, ListSSHKeysResponse, SSHKey>(_callListSSHKeys, request, callSettings);
        }

        /// <summary>
        /// Lists the public SSH keys registered for the specified project.
        /// These SSH keys are used only for the interactive serial console feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SSHKey"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSSHKeysResponse, SSHKey> ListSSHKeysAsync(ListSSHKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSSHKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSSHKeysRequest, ListSSHKeysResponse, SSHKey>(_callListSSHKeys, request, callSettings);
        }

        /// <summary>
        /// Register a public SSH key in the specified project for use with the
        /// interactive serial console feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SSHKey CreateSSHKey(CreateSSHKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSSHKeyRequest(ref request, ref callSettings);
            return _callCreateSSHKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Register a public SSH key in the specified project for use with the
        /// interactive serial console feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SSHKey> CreateSSHKeyAsync(CreateSSHKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSSHKeyRequest(ref request, ref callSettings);
            return _callCreateSSHKey.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a public SSH key registered in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSSHKey(DeleteSSHKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSSHKeyRequest(ref request, ref callSettings);
            _callDeleteSSHKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a public SSH key registered in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSSHKeyAsync(DeleteSSHKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSSHKeyRequest(ref request, ref callSettings);
            return _callDeleteSSHKey.Async(request, callSettings);
        }

        /// <summary>
        /// List storage volumes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Volume"/> resources.</returns>
        public override gax::PagedEnumerable<ListVolumesResponse, Volume> ListVolumes(ListVolumesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVolumesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVolumesRequest, ListVolumesResponse, Volume>(_callListVolumes, request, callSettings);
        }

        /// <summary>
        /// List storage volumes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Volume"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVolumesResponse, Volume> ListVolumesAsync(ListVolumesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVolumesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVolumesRequest, ListVolumesResponse, Volume>(_callListVolumes, request, callSettings);
        }

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Volume GetVolume(GetVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVolumeRequest(ref request, ref callSettings);
            return _callGetVolume.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Volume> GetVolumeAsync(GetVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVolumeRequest(ref request, ref callSettings);
            return _callGetVolume.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateVolume</c>.</summary>
        public override lro::OperationsClient UpdateVolumeOperationsClient { get; }

        /// <summary>
        /// Update details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Volume, OperationMetadata> UpdateVolume(UpdateVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<Volume, OperationMetadata>(_callUpdateVolume.Sync(request, callSettings), UpdateVolumeOperationsClient);
        }

        /// <summary>
        /// Update details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(UpdateVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<Volume, OperationMetadata>(await _callUpdateVolume.Async(request, callSettings).ConfigureAwait(false), UpdateVolumeOperationsClient);
        }

        /// <summary>
        /// RenameVolume sets a new name for a volume.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Volume RenameVolume(RenameVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenameVolumeRequest(ref request, ref callSettings);
            return _callRenameVolume.Sync(request, callSettings);
        }

        /// <summary>
        /// RenameVolume sets a new name for a volume.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Volume> RenameVolumeAsync(RenameVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenameVolumeRequest(ref request, ref callSettings);
            return _callRenameVolume.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>EvictVolume</c>.</summary>
        public override lro::OperationsClient EvictVolumeOperationsClient { get; }

        /// <summary>
        /// Skips volume's cooloff and deletes it now.
        /// Volume must be in cooloff state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> EvictVolume(EvictVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EvictVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callEvictVolume.Sync(request, callSettings), EvictVolumeOperationsClient);
        }

        /// <summary>
        /// Skips volume's cooloff and deletes it now.
        /// Volume must be in cooloff state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> EvictVolumeAsync(EvictVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EvictVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callEvictVolume.Async(request, callSettings).ConfigureAwait(false), EvictVolumeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ResizeVolume</c>.</summary>
        public override lro::OperationsClient ResizeVolumeOperationsClient { get; }

        /// <summary>
        /// Emergency Volume resize.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Volume, OperationMetadata> ResizeVolume(ResizeVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResizeVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<Volume, OperationMetadata>(_callResizeVolume.Sync(request, callSettings), ResizeVolumeOperationsClient);
        }

        /// <summary>
        /// Emergency Volume resize.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Volume, OperationMetadata>> ResizeVolumeAsync(ResizeVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResizeVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<Volume, OperationMetadata>(await _callResizeVolume.Async(request, callSettings).ConfigureAwait(false), ResizeVolumeOperationsClient);
        }

        /// <summary>
        /// List network in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Network"/> resources.</returns>
        public override gax::PagedEnumerable<ListNetworksResponse, Network> ListNetworks(ListNetworksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNetworksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNetworksRequest, ListNetworksResponse, Network>(_callListNetworks, request, callSettings);
        }

        /// <summary>
        /// List network in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Network"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNetworksResponse, Network> ListNetworksAsync(ListNetworksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNetworksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNetworksRequest, ListNetworksResponse, Network>(_callListNetworks, request, callSettings);
        }

        /// <summary>
        /// List all Networks (and used IPs for each Network) in the vendor account
        /// associated with the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListNetworkUsageResponse ListNetworkUsage(ListNetworkUsageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNetworkUsageRequest(ref request, ref callSettings);
            return _callListNetworkUsage.Sync(request, callSettings);
        }

        /// <summary>
        /// List all Networks (and used IPs for each Network) in the vendor account
        /// associated with the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListNetworkUsageResponse> ListNetworkUsageAsync(ListNetworkUsageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNetworkUsageRequest(ref request, ref callSettings);
            return _callListNetworkUsage.Async(request, callSettings);
        }

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Network GetNetwork(GetNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNetworkRequest(ref request, ref callSettings);
            return _callGetNetwork.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Network> GetNetworkAsync(GetNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNetworkRequest(ref request, ref callSettings);
            return _callGetNetwork.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateNetwork</c>.</summary>
        public override lro::OperationsClient UpdateNetworkOperationsClient { get; }

        /// <summary>
        /// Update details of a single network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Network, OperationMetadata> UpdateNetwork(UpdateNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNetworkRequest(ref request, ref callSettings);
            return new lro::Operation<Network, OperationMetadata>(_callUpdateNetwork.Sync(request, callSettings), UpdateNetworkOperationsClient);
        }

        /// <summary>
        /// Update details of a single network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Network, OperationMetadata>> UpdateNetworkAsync(UpdateNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNetworkRequest(ref request, ref callSettings);
            return new lro::Operation<Network, OperationMetadata>(await _callUpdateNetwork.Async(request, callSettings).ConfigureAwait(false), UpdateNetworkOperationsClient);
        }

        /// <summary>
        /// Takes a snapshot of a boot volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VolumeSnapshot CreateVolumeSnapshot(CreateVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVolumeSnapshotRequest(ref request, ref callSettings);
            return _callCreateVolumeSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Takes a snapshot of a boot volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VolumeSnapshot> CreateVolumeSnapshotAsync(CreateVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVolumeSnapshotRequest(ref request, ref callSettings);
            return _callCreateVolumeSnapshot.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RestoreVolumeSnapshot</c>.</summary>
        public override lro::OperationsClient RestoreVolumeSnapshotOperationsClient { get; }

        /// <summary>
        /// Uses the specified snapshot to restore its parent volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<VolumeSnapshot, OperationMetadata> RestoreVolumeSnapshot(RestoreVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreVolumeSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<VolumeSnapshot, OperationMetadata>(_callRestoreVolumeSnapshot.Sync(request, callSettings), RestoreVolumeSnapshotOperationsClient);
        }

        /// <summary>
        /// Uses the specified snapshot to restore its parent volume.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<VolumeSnapshot, OperationMetadata>> RestoreVolumeSnapshotAsync(RestoreVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreVolumeSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<VolumeSnapshot, OperationMetadata>(await _callRestoreVolumeSnapshot.Async(request, callSettings).ConfigureAwait(false), RestoreVolumeSnapshotOperationsClient);
        }

        /// <summary>
        /// Deletes a volume snapshot.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteVolumeSnapshot(DeleteVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVolumeSnapshotRequest(ref request, ref callSettings);
            _callDeleteVolumeSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a volume snapshot.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteVolumeSnapshotAsync(DeleteVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVolumeSnapshotRequest(ref request, ref callSettings);
            return _callDeleteVolumeSnapshot.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the specified snapshot resource.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VolumeSnapshot GetVolumeSnapshot(GetVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVolumeSnapshotRequest(ref request, ref callSettings);
            return _callGetVolumeSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified snapshot resource.
        /// Returns INVALID_ARGUMENT if called for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VolumeSnapshot> GetVolumeSnapshotAsync(GetVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVolumeSnapshotRequest(ref request, ref callSettings);
            return _callGetVolumeSnapshot.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of snapshots for the specified volume.
        /// Returns a response with an empty list of snapshots if called
        /// for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VolumeSnapshot"/> resources.</returns>
        public override gax::PagedEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> ListVolumeSnapshots(ListVolumeSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVolumeSnapshotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVolumeSnapshotsRequest, ListVolumeSnapshotsResponse, VolumeSnapshot>(_callListVolumeSnapshots, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of snapshots for the specified volume.
        /// Returns a response with an empty list of snapshots if called
        /// for a non-boot volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VolumeSnapshot"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> ListVolumeSnapshotsAsync(ListVolumeSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVolumeSnapshotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVolumeSnapshotsRequest, ListVolumeSnapshotsResponse, VolumeSnapshot>(_callListVolumeSnapshots, request, callSettings);
        }

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Lun GetLun(GetLunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLunRequest(ref request, ref callSettings);
            return _callGetLun.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Lun> GetLunAsync(GetLunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLunRequest(ref request, ref callSettings);
            return _callGetLun.Async(request, callSettings);
        }

        /// <summary>
        /// List storage volume luns for given storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Lun"/> resources.</returns>
        public override gax::PagedEnumerable<ListLunsResponse, Lun> ListLuns(ListLunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLunsRequest, ListLunsResponse, Lun>(_callListLuns, request, callSettings);
        }

        /// <summary>
        /// List storage volume luns for given storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Lun"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLunsResponse, Lun> ListLunsAsync(ListLunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLunsRequest, ListLunsResponse, Lun>(_callListLuns, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>EvictLun</c>.</summary>
        public override lro::OperationsClient EvictLunOperationsClient { get; }

        /// <summary>
        /// Skips lun's cooloff and deletes it now.
        /// Lun must be in cooloff state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> EvictLun(EvictLunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EvictLunRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callEvictLun.Sync(request, callSettings), EvictLunOperationsClient);
        }

        /// <summary>
        /// Skips lun's cooloff and deletes it now.
        /// Lun must be in cooloff state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> EvictLunAsync(EvictLunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EvictLunRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callEvictLun.Async(request, callSettings).ConfigureAwait(false), EvictLunOperationsClient);
        }

        /// <summary>
        /// Get details of a single NFS share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NfsShare GetNfsShare(GetNfsShareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNfsShareRequest(ref request, ref callSettings);
            return _callGetNfsShare.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details of a single NFS share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NfsShare> GetNfsShareAsync(GetNfsShareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNfsShareRequest(ref request, ref callSettings);
            return _callGetNfsShare.Async(request, callSettings);
        }

        /// <summary>
        /// List NFS shares.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NfsShare"/> resources.</returns>
        public override gax::PagedEnumerable<ListNfsSharesResponse, NfsShare> ListNfsShares(ListNfsSharesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNfsSharesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNfsSharesRequest, ListNfsSharesResponse, NfsShare>(_callListNfsShares, request, callSettings);
        }

        /// <summary>
        /// List NFS shares.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NfsShare"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNfsSharesResponse, NfsShare> ListNfsSharesAsync(ListNfsSharesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNfsSharesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNfsSharesRequest, ListNfsSharesResponse, NfsShare>(_callListNfsShares, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateNfsShare</c>.</summary>
        public override lro::OperationsClient UpdateNfsShareOperationsClient { get; }

        /// <summary>
        /// Update details of a single NFS share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<NfsShare, OperationMetadata> UpdateNfsShare(UpdateNfsShareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNfsShareRequest(ref request, ref callSettings);
            return new lro::Operation<NfsShare, OperationMetadata>(_callUpdateNfsShare.Sync(request, callSettings), UpdateNfsShareOperationsClient);
        }

        /// <summary>
        /// Update details of a single NFS share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<NfsShare, OperationMetadata>> UpdateNfsShareAsync(UpdateNfsShareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNfsShareRequest(ref request, ref callSettings);
            return new lro::Operation<NfsShare, OperationMetadata>(await _callUpdateNfsShare.Async(request, callSettings).ConfigureAwait(false), UpdateNfsShareOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateNfsShare</c>.</summary>
        public override lro::OperationsClient CreateNfsShareOperationsClient { get; }

        /// <summary>
        /// Create an NFS share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<NfsShare, OperationMetadata> CreateNfsShare(CreateNfsShareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNfsShareRequest(ref request, ref callSettings);
            return new lro::Operation<NfsShare, OperationMetadata>(_callCreateNfsShare.Sync(request, callSettings), CreateNfsShareOperationsClient);
        }

        /// <summary>
        /// Create an NFS share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<NfsShare, OperationMetadata>> CreateNfsShareAsync(CreateNfsShareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNfsShareRequest(ref request, ref callSettings);
            return new lro::Operation<NfsShare, OperationMetadata>(await _callCreateNfsShare.Async(request, callSettings).ConfigureAwait(false), CreateNfsShareOperationsClient);
        }

        /// <summary>
        /// RenameNfsShare sets a new name for an nfsshare.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NfsShare RenameNfsShare(RenameNfsShareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenameNfsShareRequest(ref request, ref callSettings);
            return _callRenameNfsShare.Sync(request, callSettings);
        }

        /// <summary>
        /// RenameNfsShare sets a new name for an nfsshare.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NfsShare> RenameNfsShareAsync(RenameNfsShareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenameNfsShareRequest(ref request, ref callSettings);
            return _callRenameNfsShare.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteNfsShare</c>.</summary>
        public override lro::OperationsClient DeleteNfsShareOperationsClient { get; }

        /// <summary>
        /// Delete an NFS share. The underlying volume is automatically deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteNfsShare(DeleteNfsShareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNfsShareRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteNfsShare.Sync(request, callSettings), DeleteNfsShareOperationsClient);
        }

        /// <summary>
        /// Delete an NFS share. The underlying volume is automatically deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNfsShareAsync(DeleteNfsShareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNfsShareRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteNfsShare.Async(request, callSettings).ConfigureAwait(false), DeleteNfsShareOperationsClient);
        }

        /// <summary>
        /// List the budget details to provision resources on a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProvisioningQuota"/> resources.</returns>
        public override gax::PagedEnumerable<ListProvisioningQuotasResponse, ProvisioningQuota> ListProvisioningQuotas(ListProvisioningQuotasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProvisioningQuotasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProvisioningQuotasRequest, ListProvisioningQuotasResponse, ProvisioningQuota>(_callListProvisioningQuotas, request, callSettings);
        }

        /// <summary>
        /// List the budget details to provision resources on a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProvisioningQuota"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProvisioningQuotasResponse, ProvisioningQuota> ListProvisioningQuotasAsync(ListProvisioningQuotasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProvisioningQuotasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProvisioningQuotasRequest, ListProvisioningQuotasResponse, ProvisioningQuota>(_callListProvisioningQuotas, request, callSettings);
        }

        /// <summary>
        /// Submit a provisiong configuration for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SubmitProvisioningConfigResponse SubmitProvisioningConfig(SubmitProvisioningConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubmitProvisioningConfigRequest(ref request, ref callSettings);
            return _callSubmitProvisioningConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Submit a provisiong configuration for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SubmitProvisioningConfigResponse> SubmitProvisioningConfigAsync(SubmitProvisioningConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubmitProvisioningConfigRequest(ref request, ref callSettings);
            return _callSubmitProvisioningConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Get ProvisioningConfig by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProvisioningConfig GetProvisioningConfig(GetProvisioningConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProvisioningConfigRequest(ref request, ref callSettings);
            return _callGetProvisioningConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Get ProvisioningConfig by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProvisioningConfig> GetProvisioningConfigAsync(GetProvisioningConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProvisioningConfigRequest(ref request, ref callSettings);
            return _callGetProvisioningConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Create new ProvisioningConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProvisioningConfig CreateProvisioningConfig(CreateProvisioningConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProvisioningConfigRequest(ref request, ref callSettings);
            return _callCreateProvisioningConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Create new ProvisioningConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProvisioningConfig> CreateProvisioningConfigAsync(CreateProvisioningConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProvisioningConfigRequest(ref request, ref callSettings);
            return _callCreateProvisioningConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Update existing ProvisioningConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProvisioningConfig UpdateProvisioningConfig(UpdateProvisioningConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProvisioningConfigRequest(ref request, ref callSettings);
            return _callUpdateProvisioningConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Update existing ProvisioningConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProvisioningConfig> UpdateProvisioningConfigAsync(UpdateProvisioningConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProvisioningConfigRequest(ref request, ref callSettings);
            return _callUpdateProvisioningConfig.Async(request, callSettings);
        }

        /// <summary>
        /// RenameNetwork sets a new name for a network.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Network RenameNetwork(RenameNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenameNetworkRequest(ref request, ref callSettings);
            return _callRenameNetwork.Sync(request, callSettings);
        }

        /// <summary>
        /// RenameNetwork sets a new name for a network.
        /// Use with caution, previous names become immediately invalidated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Network> RenameNetworkAsync(RenameNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenameNetworkRequest(ref request, ref callSettings);
            return _callRenameNetwork.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of OS images which are currently approved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OSImage"/> resources.</returns>
        public override gax::PagedEnumerable<ListOSImagesResponse, OSImage> ListOSImages(ListOSImagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOSImagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOSImagesRequest, ListOSImagesResponse, OSImage>(_callListOSImages, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of OS images which are currently approved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OSImage"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOSImagesResponse, OSImage> ListOSImagesAsync(ListOSImagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOSImagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOSImagesRequest, ListOSImagesResponse, OSImage>(_callListOSImages, request, callSettings);
        }
    }

    public partial class ListInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSSHKeysRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVolumesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNetworksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVolumeSnapshotsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLunsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNfsSharesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProvisioningQuotasRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOSImagesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstancesResponse : gaxgrpc::IPageResponse<Instance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Instance> GetEnumerator() => Instances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSSHKeysResponse : gaxgrpc::IPageResponse<SSHKey>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SSHKey> GetEnumerator() => SshKeys.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListVolumesResponse : gaxgrpc::IPageResponse<Volume>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Volume> GetEnumerator() => Volumes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNetworksResponse : gaxgrpc::IPageResponse<Network>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Network> GetEnumerator() => Networks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListVolumeSnapshotsResponse : gaxgrpc::IPageResponse<VolumeSnapshot>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<VolumeSnapshot> GetEnumerator() => VolumeSnapshots.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListLunsResponse : gaxgrpc::IPageResponse<Lun>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Lun> GetEnumerator() => Luns.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNfsSharesResponse : gaxgrpc::IPageResponse<NfsShare>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<NfsShare> GetEnumerator() => NfsShares.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListProvisioningQuotasResponse : gaxgrpc::IPageResponse<ProvisioningQuota>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ProvisioningQuota> GetEnumerator() => ProvisioningQuotas.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListOSImagesResponse : gaxgrpc::IPageResponse<OSImage>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<OSImage> GetEnumerator() => OsImages.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class BareMetalSolution
    {
        public partial class BareMetalSolutionClient
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

    public static partial class BareMetalSolution
    {
        public partial class BareMetalSolutionClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
