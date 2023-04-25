// Copyright 2023 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

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
            ResetInstanceSettings = existing.ResetInstanceSettings;
            ResetInstanceOperationsSettings = existing.ResetInstanceOperationsSettings.Clone();
            StartInstanceSettings = existing.StartInstanceSettings;
            StartInstanceOperationsSettings = existing.StartInstanceOperationsSettings.Clone();
            StopInstanceSettings = existing.StopInstanceSettings;
            StopInstanceOperationsSettings = existing.StopInstanceOperationsSettings.Clone();
            DetachLunSettings = existing.DetachLunSettings;
            DetachLunOperationsSettings = existing.DetachLunOperationsSettings.Clone();
            ListVolumesSettings = existing.ListVolumesSettings;
            GetVolumeSettings = existing.GetVolumeSettings;
            UpdateVolumeSettings = existing.UpdateVolumeSettings;
            UpdateVolumeOperationsSettings = existing.UpdateVolumeOperationsSettings.Clone();
            ResizeVolumeSettings = existing.ResizeVolumeSettings;
            ResizeVolumeOperationsSettings = existing.ResizeVolumeOperationsSettings.Clone();
            ListNetworksSettings = existing.ListNetworksSettings;
            ListNetworkUsageSettings = existing.ListNetworkUsageSettings;
            GetNetworkSettings = existing.GetNetworkSettings;
            UpdateNetworkSettings = existing.UpdateNetworkSettings;
            UpdateNetworkOperationsSettings = existing.UpdateNetworkOperationsSettings.Clone();
            GetLunSettings = existing.GetLunSettings;
            ListLunsSettings = existing.ListLunsSettings;
            GetNfsShareSettings = existing.GetNfsShareSettings;
            ListNfsSharesSettings = existing.ListNfsSharesSettings;
            UpdateNfsShareSettings = existing.UpdateNfsShareSettings;
            UpdateNfsShareOperationsSettings = existing.UpdateNfsShareOperationsSettings.Clone();
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
            return BareMetalSolutionClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<BareMetalSolutionClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BareMetalSolutionClient.Create(callInvoker, Settings, Logger);
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
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstances(new ListInstancesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstancesAsync(new ListInstancesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstances(new ListInstancesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstancesAsync(new ListInstancesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedEnumerable<ListVolumesResponse, Volume> ListVolumes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVolumes(new ListVolumesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListVolumesResponse, Volume> ListVolumesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVolumesAsync(new ListVolumesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedEnumerable<ListVolumesResponse, Volume> ListVolumes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVolumes(new ListVolumesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListVolumesResponse, Volume> ListVolumesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVolumesAsync(new ListVolumesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        /// `snapshot_auto_delete_behavior`
        /// `snapshot_schedule_policy_name`
        /// 'labels'
        /// 'snapshot_enabled'
        /// 'snapshot_reservation_detail.reserved_space_percent'
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
        /// `snapshot_auto_delete_behavior`
        /// `snapshot_schedule_policy_name`
        /// 'labels'
        /// 'snapshot_enabled'
        /// 'snapshot_reservation_detail.reserved_space_percent'
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
        /// `snapshot_auto_delete_behavior`
        /// `snapshot_schedule_policy_name`
        /// 'labels'
        /// 'snapshot_enabled'
        /// 'snapshot_reservation_detail.reserved_space_percent'
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(Volume volume, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateVolumeAsync(volume, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual gax::PagedEnumerable<ListNetworksResponse, Network> ListNetworks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNetworks(new ListNetworksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListNetworksResponse, Network> ListNetworksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNetworksAsync(new ListNetworksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedEnumerable<ListNetworksResponse, Network> ListNetworks(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNetworks(new ListNetworksRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListNetworksResponse, Network> ListNetworksAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNetworksAsync(new ListNetworksRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        /// `labels`, `reservations`
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
        /// `labels`, `reservations`
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
        /// `labels`, `reservations`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Network, OperationMetadata>> UpdateNetworkAsync(Network network, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateNetworkAsync(network, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual gax::PagedEnumerable<ListLunsResponse, Lun> ListLuns(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListLuns(new ListLunsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListLunsResponse, Lun> ListLunsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListLunsAsync(new ListLunsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedEnumerable<ListLunsResponse, Lun> ListLuns(VolumeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListLuns(new ListLunsRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListLunsResponse, Lun> ListLunsAsync(VolumeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListLunsAsync(new ListLunsRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedEnumerable<ListNfsSharesResponse, NfsShare> ListNfsShares(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNfsShares(new ListNfsSharesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListNfsSharesResponse, NfsShare> ListNfsSharesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNfsSharesAsync(new ListNfsSharesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedEnumerable<ListNfsSharesResponse, NfsShare> ListNfsShares(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNfsShares(new ListNfsSharesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListNfsSharesResponse, NfsShare> ListNfsSharesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNfsSharesAsync(new ListNfsSharesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NfsShare, OperationMetadata>> UpdateNfsShareAsync(NfsShare nfsShare, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateNfsShareAsync(nfsShare, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
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

        private readonly gaxgrpc::ApiCall<ResetInstanceRequest, lro::Operation> _callResetInstance;

        private readonly gaxgrpc::ApiCall<StartInstanceRequest, lro::Operation> _callStartInstance;

        private readonly gaxgrpc::ApiCall<StopInstanceRequest, lro::Operation> _callStopInstance;

        private readonly gaxgrpc::ApiCall<DetachLunRequest, lro::Operation> _callDetachLun;

        private readonly gaxgrpc::ApiCall<ListVolumesRequest, ListVolumesResponse> _callListVolumes;

        private readonly gaxgrpc::ApiCall<GetVolumeRequest, Volume> _callGetVolume;

        private readonly gaxgrpc::ApiCall<UpdateVolumeRequest, lro::Operation> _callUpdateVolume;

        private readonly gaxgrpc::ApiCall<ResizeVolumeRequest, lro::Operation> _callResizeVolume;

        private readonly gaxgrpc::ApiCall<ListNetworksRequest, ListNetworksResponse> _callListNetworks;

        private readonly gaxgrpc::ApiCall<ListNetworkUsageRequest, ListNetworkUsageResponse> _callListNetworkUsage;

        private readonly gaxgrpc::ApiCall<GetNetworkRequest, Network> _callGetNetwork;

        private readonly gaxgrpc::ApiCall<UpdateNetworkRequest, lro::Operation> _callUpdateNetwork;

        private readonly gaxgrpc::ApiCall<GetLunRequest, Lun> _callGetLun;

        private readonly gaxgrpc::ApiCall<ListLunsRequest, ListLunsResponse> _callListLuns;

        private readonly gaxgrpc::ApiCall<GetNfsShareRequest, NfsShare> _callGetNfsShare;

        private readonly gaxgrpc::ApiCall<ListNfsSharesRequest, ListNfsSharesResponse> _callListNfsShares;

        private readonly gaxgrpc::ApiCall<UpdateNfsShareRequest, lro::Operation> _callUpdateNfsShare;

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
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            UpdateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInstanceOperationsSettings, logger);
            ResetInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ResetInstanceOperationsSettings, logger);
            StartInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StartInstanceOperationsSettings, logger);
            StopInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StopInstanceOperationsSettings, logger);
            DetachLunOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DetachLunOperationsSettings, logger);
            UpdateVolumeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateVolumeOperationsSettings, logger);
            ResizeVolumeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ResizeVolumeOperationsSettings, logger);
            UpdateNetworkOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateNetworkOperationsSettings, logger);
            UpdateNfsShareOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateNfsShareOperationsSettings, logger);
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
            _callResetInstance = clientHelper.BuildApiCall<ResetInstanceRequest, lro::Operation>("ResetInstance", grpcClient.ResetInstanceAsync, grpcClient.ResetInstance, effectiveSettings.ResetInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResetInstance);
            Modify_ResetInstanceApiCall(ref _callResetInstance);
            _callStartInstance = clientHelper.BuildApiCall<StartInstanceRequest, lro::Operation>("StartInstance", grpcClient.StartInstanceAsync, grpcClient.StartInstance, effectiveSettings.StartInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartInstance);
            Modify_StartInstanceApiCall(ref _callStartInstance);
            _callStopInstance = clientHelper.BuildApiCall<StopInstanceRequest, lro::Operation>("StopInstance", grpcClient.StopInstanceAsync, grpcClient.StopInstance, effectiveSettings.StopInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStopInstance);
            Modify_StopInstanceApiCall(ref _callStopInstance);
            _callDetachLun = clientHelper.BuildApiCall<DetachLunRequest, lro::Operation>("DetachLun", grpcClient.DetachLunAsync, grpcClient.DetachLun, effectiveSettings.DetachLunSettings).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callDetachLun);
            Modify_DetachLunApiCall(ref _callDetachLun);
            _callListVolumes = clientHelper.BuildApiCall<ListVolumesRequest, ListVolumesResponse>("ListVolumes", grpcClient.ListVolumesAsync, grpcClient.ListVolumes, effectiveSettings.ListVolumesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVolumes);
            Modify_ListVolumesApiCall(ref _callListVolumes);
            _callGetVolume = clientHelper.BuildApiCall<GetVolumeRequest, Volume>("GetVolume", grpcClient.GetVolumeAsync, grpcClient.GetVolume, effectiveSettings.GetVolumeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVolume);
            Modify_GetVolumeApiCall(ref _callGetVolume);
            _callUpdateVolume = clientHelper.BuildApiCall<UpdateVolumeRequest, lro::Operation>("UpdateVolume", grpcClient.UpdateVolumeAsync, grpcClient.UpdateVolume, effectiveSettings.UpdateVolumeSettings).WithGoogleRequestParam("volume.name", request => request.Volume?.Name);
            Modify_ApiCall(ref _callUpdateVolume);
            Modify_UpdateVolumeApiCall(ref _callUpdateVolume);
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
            _callGetLun = clientHelper.BuildApiCall<GetLunRequest, Lun>("GetLun", grpcClient.GetLunAsync, grpcClient.GetLun, effectiveSettings.GetLunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLun);
            Modify_GetLunApiCall(ref _callGetLun);
            _callListLuns = clientHelper.BuildApiCall<ListLunsRequest, ListLunsResponse>("ListLuns", grpcClient.ListLunsAsync, grpcClient.ListLuns, effectiveSettings.ListLunsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLuns);
            Modify_ListLunsApiCall(ref _callListLuns);
            _callGetNfsShare = clientHelper.BuildApiCall<GetNfsShareRequest, NfsShare>("GetNfsShare", grpcClient.GetNfsShareAsync, grpcClient.GetNfsShare, effectiveSettings.GetNfsShareSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNfsShare);
            Modify_GetNfsShareApiCall(ref _callGetNfsShare);
            _callListNfsShares = clientHelper.BuildApiCall<ListNfsSharesRequest, ListNfsSharesResponse>("ListNfsShares", grpcClient.ListNfsSharesAsync, grpcClient.ListNfsShares, effectiveSettings.ListNfsSharesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNfsShares);
            Modify_ListNfsSharesApiCall(ref _callListNfsShares);
            _callUpdateNfsShare = clientHelper.BuildApiCall<UpdateNfsShareRequest, lro::Operation>("UpdateNfsShare", grpcClient.UpdateNfsShareAsync, grpcClient.UpdateNfsShare, effectiveSettings.UpdateNfsShareSettings).WithGoogleRequestParam("nfs_share.name", request => request.NfsShare?.Name);
            Modify_ApiCall(ref _callUpdateNfsShare);
            Modify_UpdateNfsShareApiCall(ref _callUpdateNfsShare);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);

        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);

        partial void Modify_UpdateInstanceApiCall(ref gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> call);

        partial void Modify_ResetInstanceApiCall(ref gaxgrpc::ApiCall<ResetInstanceRequest, lro::Operation> call);

        partial void Modify_StartInstanceApiCall(ref gaxgrpc::ApiCall<StartInstanceRequest, lro::Operation> call);

        partial void Modify_StopInstanceApiCall(ref gaxgrpc::ApiCall<StopInstanceRequest, lro::Operation> call);

        partial void Modify_DetachLunApiCall(ref gaxgrpc::ApiCall<DetachLunRequest, lro::Operation> call);

        partial void Modify_ListVolumesApiCall(ref gaxgrpc::ApiCall<ListVolumesRequest, ListVolumesResponse> call);

        partial void Modify_GetVolumeApiCall(ref gaxgrpc::ApiCall<GetVolumeRequest, Volume> call);

        partial void Modify_UpdateVolumeApiCall(ref gaxgrpc::ApiCall<UpdateVolumeRequest, lro::Operation> call);

        partial void Modify_ResizeVolumeApiCall(ref gaxgrpc::ApiCall<ResizeVolumeRequest, lro::Operation> call);

        partial void Modify_ListNetworksApiCall(ref gaxgrpc::ApiCall<ListNetworksRequest, ListNetworksResponse> call);

        partial void Modify_ListNetworkUsageApiCall(ref gaxgrpc::ApiCall<ListNetworkUsageRequest, ListNetworkUsageResponse> call);

        partial void Modify_GetNetworkApiCall(ref gaxgrpc::ApiCall<GetNetworkRequest, Network> call);

        partial void Modify_UpdateNetworkApiCall(ref gaxgrpc::ApiCall<UpdateNetworkRequest, lro::Operation> call);

        partial void Modify_GetLunApiCall(ref gaxgrpc::ApiCall<GetLunRequest, Lun> call);

        partial void Modify_ListLunsApiCall(ref gaxgrpc::ApiCall<ListLunsRequest, ListLunsResponse> call);

        partial void Modify_GetNfsShareApiCall(ref gaxgrpc::ApiCall<GetNfsShareRequest, NfsShare> call);

        partial void Modify_ListNfsSharesApiCall(ref gaxgrpc::ApiCall<ListNfsSharesRequest, ListNfsSharesResponse> call);

        partial void Modify_UpdateNfsShareApiCall(ref gaxgrpc::ApiCall<UpdateNfsShareRequest, lro::Operation> call);

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

        partial void Modify_ResetInstanceRequest(ref ResetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartInstanceRequest(ref StartInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopInstanceRequest(ref StopInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DetachLunRequest(ref DetachLunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVolumesRequest(ref ListVolumesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVolumeRequest(ref GetVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateVolumeRequest(ref UpdateVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResizeVolumeRequest(ref ResizeVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNetworksRequest(ref ListNetworksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNetworkUsageRequest(ref ListNetworkUsageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNetworkRequest(ref GetNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateNetworkRequest(ref UpdateNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetLunRequest(ref GetLunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLunsRequest(ref ListLunsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNfsShareRequest(ref GetNfsShareRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNfsSharesRequest(ref ListNfsSharesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateNfsShareRequest(ref UpdateNfsShareRequest request, ref gaxgrpc::CallSettings settings);

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
    }

    public partial class ListInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVolumesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNetworksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLunsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNfsSharesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstancesResponse : gaxgrpc::IPageResponse<Instance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Instance> GetEnumerator() => Instances.GetEnumerator();

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
