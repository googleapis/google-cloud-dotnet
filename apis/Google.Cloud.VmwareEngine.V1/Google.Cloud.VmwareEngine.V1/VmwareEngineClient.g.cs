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

namespace Google.Cloud.VmwareEngine.V1
{
    /// <summary>Settings for <see cref="VmwareEngineClient"/> instances.</summary>
    public sealed partial class VmwareEngineSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="VmwareEngineSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="VmwareEngineSettings"/>.</returns>
        public static VmwareEngineSettings GetDefault() => new VmwareEngineSettings();

        /// <summary>Constructs a new <see cref="VmwareEngineSettings"/> object with default settings.</summary>
        public VmwareEngineSettings()
        {
        }

        private VmwareEngineSettings(VmwareEngineSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListPrivateCloudsSettings = existing.ListPrivateCloudsSettings;
            GetPrivateCloudSettings = existing.GetPrivateCloudSettings;
            CreatePrivateCloudSettings = existing.CreatePrivateCloudSettings;
            CreatePrivateCloudOperationsSettings = existing.CreatePrivateCloudOperationsSettings.Clone();
            UpdatePrivateCloudSettings = existing.UpdatePrivateCloudSettings;
            UpdatePrivateCloudOperationsSettings = existing.UpdatePrivateCloudOperationsSettings.Clone();
            DeletePrivateCloudSettings = existing.DeletePrivateCloudSettings;
            DeletePrivateCloudOperationsSettings = existing.DeletePrivateCloudOperationsSettings.Clone();
            UndeletePrivateCloudSettings = existing.UndeletePrivateCloudSettings;
            UndeletePrivateCloudOperationsSettings = existing.UndeletePrivateCloudOperationsSettings.Clone();
            ListClustersSettings = existing.ListClustersSettings;
            GetClusterSettings = existing.GetClusterSettings;
            CreateClusterSettings = existing.CreateClusterSettings;
            CreateClusterOperationsSettings = existing.CreateClusterOperationsSettings.Clone();
            UpdateClusterSettings = existing.UpdateClusterSettings;
            UpdateClusterOperationsSettings = existing.UpdateClusterOperationsSettings.Clone();
            DeleteClusterSettings = existing.DeleteClusterSettings;
            DeleteClusterOperationsSettings = existing.DeleteClusterOperationsSettings.Clone();
            ListSubnetsSettings = existing.ListSubnetsSettings;
            ListNodeTypesSettings = existing.ListNodeTypesSettings;
            GetNodeTypeSettings = existing.GetNodeTypeSettings;
            ShowNsxCredentialsSettings = existing.ShowNsxCredentialsSettings;
            ShowVcenterCredentialsSettings = existing.ShowVcenterCredentialsSettings;
            ResetNsxCredentialsSettings = existing.ResetNsxCredentialsSettings;
            ResetNsxCredentialsOperationsSettings = existing.ResetNsxCredentialsOperationsSettings.Clone();
            ResetVcenterCredentialsSettings = existing.ResetVcenterCredentialsSettings;
            ResetVcenterCredentialsOperationsSettings = existing.ResetVcenterCredentialsOperationsSettings.Clone();
            CreateHcxActivationKeySettings = existing.CreateHcxActivationKeySettings;
            CreateHcxActivationKeyOperationsSettings = existing.CreateHcxActivationKeyOperationsSettings.Clone();
            ListHcxActivationKeysSettings = existing.ListHcxActivationKeysSettings;
            GetHcxActivationKeySettings = existing.GetHcxActivationKeySettings;
            GetNetworkPolicySettings = existing.GetNetworkPolicySettings;
            ListNetworkPoliciesSettings = existing.ListNetworkPoliciesSettings;
            CreateNetworkPolicySettings = existing.CreateNetworkPolicySettings;
            CreateNetworkPolicyOperationsSettings = existing.CreateNetworkPolicyOperationsSettings.Clone();
            UpdateNetworkPolicySettings = existing.UpdateNetworkPolicySettings;
            UpdateNetworkPolicyOperationsSettings = existing.UpdateNetworkPolicyOperationsSettings.Clone();
            DeleteNetworkPolicySettings = existing.DeleteNetworkPolicySettings;
            DeleteNetworkPolicyOperationsSettings = existing.DeleteNetworkPolicyOperationsSettings.Clone();
            CreateVmwareEngineNetworkSettings = existing.CreateVmwareEngineNetworkSettings;
            CreateVmwareEngineNetworkOperationsSettings = existing.CreateVmwareEngineNetworkOperationsSettings.Clone();
            UpdateVmwareEngineNetworkSettings = existing.UpdateVmwareEngineNetworkSettings;
            UpdateVmwareEngineNetworkOperationsSettings = existing.UpdateVmwareEngineNetworkOperationsSettings.Clone();
            DeleteVmwareEngineNetworkSettings = existing.DeleteVmwareEngineNetworkSettings;
            DeleteVmwareEngineNetworkOperationsSettings = existing.DeleteVmwareEngineNetworkOperationsSettings.Clone();
            GetVmwareEngineNetworkSettings = existing.GetVmwareEngineNetworkSettings;
            ListVmwareEngineNetworksSettings = existing.ListVmwareEngineNetworksSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(VmwareEngineSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.ListPrivateClouds</c> and <c>VmwareEngineClient.ListPrivateCloudsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPrivateCloudsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.GetPrivateCloud</c> and <c>VmwareEngineClient.GetPrivateCloudAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPrivateCloudSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.CreatePrivateCloud</c> and <c>VmwareEngineClient.CreatePrivateCloudAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePrivateCloudSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmwareEngineClient.CreatePrivateCloud</c> and
        /// <c>VmwareEngineClient.CreatePrivateCloudAsync</c>.
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
        public lro::OperationsSettings CreatePrivateCloudOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.UpdatePrivateCloud</c> and <c>VmwareEngineClient.UpdatePrivateCloudAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePrivateCloudSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmwareEngineClient.UpdatePrivateCloud</c> and
        /// <c>VmwareEngineClient.UpdatePrivateCloudAsync</c>.
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
        public lro::OperationsSettings UpdatePrivateCloudOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.DeletePrivateCloud</c> and <c>VmwareEngineClient.DeletePrivateCloudAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePrivateCloudSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmwareEngineClient.DeletePrivateCloud</c> and
        /// <c>VmwareEngineClient.DeletePrivateCloudAsync</c>.
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
        public lro::OperationsSettings DeletePrivateCloudOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.UndeletePrivateCloud</c> and <c>VmwareEngineClient.UndeletePrivateCloudAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeletePrivateCloudSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmwareEngineClient.UndeletePrivateCloud</c> and
        /// <c>VmwareEngineClient.UndeletePrivateCloudAsync</c>.
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
        public lro::OperationsSettings UndeletePrivateCloudOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.ListClusters</c> and <c>VmwareEngineClient.ListClustersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListClustersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.GetCluster</c> and <c>VmwareEngineClient.GetClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.CreateCluster</c> and <c>VmwareEngineClient.CreateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmwareEngineClient.CreateCluster</c> and
        /// <c>VmwareEngineClient.CreateClusterAsync</c>.
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
        /// <c>VmwareEngineClient.UpdateCluster</c> and <c>VmwareEngineClient.UpdateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmwareEngineClient.UpdateCluster</c> and
        /// <c>VmwareEngineClient.UpdateClusterAsync</c>.
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
        /// <c>VmwareEngineClient.DeleteCluster</c> and <c>VmwareEngineClient.DeleteClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmwareEngineClient.DeleteCluster</c> and
        /// <c>VmwareEngineClient.DeleteClusterAsync</c>.
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
        public lro::OperationsSettings DeleteClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.ListSubnets</c> and <c>VmwareEngineClient.ListSubnetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSubnetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.ListNodeTypes</c> and <c>VmwareEngineClient.ListNodeTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNodeTypesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.GetNodeType</c> and <c>VmwareEngineClient.GetNodeTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNodeTypeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.ShowNsxCredentials</c> and <c>VmwareEngineClient.ShowNsxCredentialsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ShowNsxCredentialsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.ShowVcenterCredentials</c> and <c>VmwareEngineClient.ShowVcenterCredentialsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ShowVcenterCredentialsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.ResetNsxCredentials</c> and <c>VmwareEngineClient.ResetNsxCredentialsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResetNsxCredentialsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmwareEngineClient.ResetNsxCredentials</c> and
        /// <c>VmwareEngineClient.ResetNsxCredentialsAsync</c>.
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
        public lro::OperationsSettings ResetNsxCredentialsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.ResetVcenterCredentials</c> and <c>VmwareEngineClient.ResetVcenterCredentialsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResetVcenterCredentialsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmwareEngineClient.ResetVcenterCredentials</c> and
        /// <c>VmwareEngineClient.ResetVcenterCredentialsAsync</c>.
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
        public lro::OperationsSettings ResetVcenterCredentialsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.CreateHcxActivationKey</c> and <c>VmwareEngineClient.CreateHcxActivationKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateHcxActivationKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmwareEngineClient.CreateHcxActivationKey</c> and
        /// <c>VmwareEngineClient.CreateHcxActivationKeyAsync</c>.
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
        public lro::OperationsSettings CreateHcxActivationKeyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.ListHcxActivationKeys</c> and <c>VmwareEngineClient.ListHcxActivationKeysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListHcxActivationKeysSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.GetHcxActivationKey</c> and <c>VmwareEngineClient.GetHcxActivationKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetHcxActivationKeySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.GetNetworkPolicy</c> and <c>VmwareEngineClient.GetNetworkPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNetworkPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.ListNetworkPolicies</c> and <c>VmwareEngineClient.ListNetworkPoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNetworkPoliciesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.CreateNetworkPolicy</c> and <c>VmwareEngineClient.CreateNetworkPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateNetworkPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmwareEngineClient.CreateNetworkPolicy</c> and
        /// <c>VmwareEngineClient.CreateNetworkPolicyAsync</c>.
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
        public lro::OperationsSettings CreateNetworkPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.UpdateNetworkPolicy</c> and <c>VmwareEngineClient.UpdateNetworkPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateNetworkPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmwareEngineClient.UpdateNetworkPolicy</c> and
        /// <c>VmwareEngineClient.UpdateNetworkPolicyAsync</c>.
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
        public lro::OperationsSettings UpdateNetworkPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.DeleteNetworkPolicy</c> and <c>VmwareEngineClient.DeleteNetworkPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteNetworkPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmwareEngineClient.DeleteNetworkPolicy</c> and
        /// <c>VmwareEngineClient.DeleteNetworkPolicyAsync</c>.
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
        public lro::OperationsSettings DeleteNetworkPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.CreateVmwareEngineNetwork</c> and <c>VmwareEngineClient.CreateVmwareEngineNetworkAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateVmwareEngineNetworkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmwareEngineClient.CreateVmwareEngineNetwork</c> and
        /// <c>VmwareEngineClient.CreateVmwareEngineNetworkAsync</c>.
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
        public lro::OperationsSettings CreateVmwareEngineNetworkOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.UpdateVmwareEngineNetwork</c> and <c>VmwareEngineClient.UpdateVmwareEngineNetworkAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateVmwareEngineNetworkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmwareEngineClient.UpdateVmwareEngineNetwork</c> and
        /// <c>VmwareEngineClient.UpdateVmwareEngineNetworkAsync</c>.
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
        public lro::OperationsSettings UpdateVmwareEngineNetworkOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.DeleteVmwareEngineNetwork</c> and <c>VmwareEngineClient.DeleteVmwareEngineNetworkAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteVmwareEngineNetworkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmwareEngineClient.DeleteVmwareEngineNetwork</c> and
        /// <c>VmwareEngineClient.DeleteVmwareEngineNetworkAsync</c>.
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
        public lro::OperationsSettings DeleteVmwareEngineNetworkOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.GetVmwareEngineNetwork</c> and <c>VmwareEngineClient.GetVmwareEngineNetworkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetVmwareEngineNetworkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmwareEngineClient.ListVmwareEngineNetworks</c> and <c>VmwareEngineClient.ListVmwareEngineNetworksAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListVmwareEngineNetworksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="VmwareEngineSettings"/> object.</returns>
        public VmwareEngineSettings Clone() => new VmwareEngineSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="VmwareEngineClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class VmwareEngineClientBuilder : gaxgrpc::ClientBuilderBase<VmwareEngineClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public VmwareEngineSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public VmwareEngineClientBuilder() : base(VmwareEngineClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref VmwareEngineClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<VmwareEngineClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override VmwareEngineClient Build()
        {
            VmwareEngineClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<VmwareEngineClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<VmwareEngineClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private VmwareEngineClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return VmwareEngineClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<VmwareEngineClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return VmwareEngineClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => VmwareEngineClient.ChannelPool;
    }

    /// <summary>VmwareEngine client wrapper, for convenient use.</summary>
    /// <remarks>
    /// VMwareEngine manages VMware's private clusters in the Cloud.
    /// </remarks>
    public abstract partial class VmwareEngineClient
    {
        /// <summary>
        /// The default endpoint for the VmwareEngine service, which is a host of "vmwareengine.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "vmwareengine.googleapis.com:443";

        /// <summary>The default VmwareEngine scopes.</summary>
        /// <remarks>
        /// The default VmwareEngine scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(VmwareEngine.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="VmwareEngineClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VmwareEngineClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="VmwareEngineClient"/>.</returns>
        public static stt::Task<VmwareEngineClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new VmwareEngineClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="VmwareEngineClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VmwareEngineClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="VmwareEngineClient"/>.</returns>
        public static VmwareEngineClient Create() => new VmwareEngineClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="VmwareEngineClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="VmwareEngineSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="VmwareEngineClient"/>.</returns>
        internal static VmwareEngineClient Create(grpccore::CallInvoker callInvoker, VmwareEngineSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            VmwareEngine.VmwareEngineClient grpcClient = new VmwareEngine.VmwareEngineClient(callInvoker);
            return new VmwareEngineClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC VmwareEngine client</summary>
        public virtual VmwareEngine.VmwareEngineClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `PrivateCloud` resources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PrivateCloud"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateCloudsResponse, PrivateCloud> ListPrivateClouds(ListPrivateCloudsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `PrivateCloud` resources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateCloud"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateCloudsResponse, PrivateCloud> ListPrivateCloudsAsync(ListPrivateCloudsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `PrivateCloud` resources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to be queried for
        /// clusters. Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a`
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
        /// <returns>A pageable sequence of <see cref="PrivateCloud"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateCloudsResponse, PrivateCloud> ListPrivateClouds(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPrivateClouds(new ListPrivateCloudsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `PrivateCloud` resources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to be queried for
        /// clusters. Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateCloud"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateCloudsResponse, PrivateCloud> ListPrivateCloudsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPrivateCloudsAsync(new ListPrivateCloudsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `PrivateCloud` resources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to be queried for
        /// clusters. Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a`
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
        /// <returns>A pageable sequence of <see cref="PrivateCloud"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateCloudsResponse, PrivateCloud> ListPrivateClouds(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPrivateClouds(new ListPrivateCloudsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `PrivateCloud` resources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to be queried for
        /// clusters. Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateCloud"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateCloudsResponse, PrivateCloud> ListPrivateCloudsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPrivateCloudsAsync(new ListPrivateCloudsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a `PrivateCloud` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateCloud GetPrivateCloud(GetPrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `PrivateCloud` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateCloud> GetPrivateCloudAsync(GetPrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `PrivateCloud` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateCloud> GetPrivateCloudAsync(GetPrivateCloudRequest request, st::CancellationToken cancellationToken) =>
            GetPrivateCloudAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `PrivateCloud` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the private cloud to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateCloud GetPrivateCloud(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateCloud(new GetPrivateCloudRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `PrivateCloud` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the private cloud to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateCloud> GetPrivateCloudAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateCloudAsync(new GetPrivateCloudRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `PrivateCloud` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the private cloud to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateCloud> GetPrivateCloudAsync(string name, st::CancellationToken cancellationToken) =>
            GetPrivateCloudAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `PrivateCloud` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the private cloud to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateCloud GetPrivateCloud(PrivateCloudName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateCloud(new GetPrivateCloudRequest
            {
                PrivateCloudName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `PrivateCloud` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the private cloud to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateCloud> GetPrivateCloudAsync(PrivateCloudName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateCloudAsync(new GetPrivateCloudRequest
            {
                PrivateCloudName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `PrivateCloud` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the private cloud to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateCloud> GetPrivateCloudAsync(PrivateCloudName name, st::CancellationToken cancellationToken) =>
            GetPrivateCloudAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new `PrivateCloud` resource in a given project and location.
        /// Private clouds can only be created in zones, regional private clouds are
        /// not supported.
        /// 
        /// Creating a private cloud also creates a [management
        /// cluster](https://cloud.google.com/vmware-engine/docs/concepts-vmware-components)
        /// for that private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> CreatePrivateCloud(CreatePrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new `PrivateCloud` resource in a given project and location.
        /// Private clouds can only be created in zones, regional private clouds are
        /// not supported.
        /// 
        /// Creating a private cloud also creates a [management
        /// cluster](https://cloud.google.com/vmware-engine/docs/concepts-vmware-components)
        /// for that private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> CreatePrivateCloudAsync(CreatePrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new `PrivateCloud` resource in a given project and location.
        /// Private clouds can only be created in zones, regional private clouds are
        /// not supported.
        /// 
        /// Creating a private cloud also creates a [management
        /// cluster](https://cloud.google.com/vmware-engine/docs/concepts-vmware-components)
        /// for that private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> CreatePrivateCloudAsync(CreatePrivateCloudRequest request, st::CancellationToken cancellationToken) =>
            CreatePrivateCloudAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreatePrivateCloud</c>.</summary>
        public virtual lro::OperationsClient CreatePrivateCloudOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreatePrivateCloud</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> PollOnceCreatePrivateCloud(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrivateCloud, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePrivateCloudOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePrivateCloud</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> PollOnceCreatePrivateCloudAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrivateCloud, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePrivateCloudOperationsClient, callSettings);

        /// <summary>
        /// Creates a new `PrivateCloud` resource in a given project and location.
        /// Private clouds can only be created in zones, regional private clouds are
        /// not supported.
        /// 
        /// Creating a private cloud also creates a [management
        /// cluster](https://cloud.google.com/vmware-engine/docs/concepts-vmware-components)
        /// for that private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create the new
        /// private cloud in. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a`
        /// </param>
        /// <param name="privateCloud">
        /// Required. The initial description of the new private cloud.
        /// </param>
        /// <param name="privateCloudId">
        /// Required. The user-provided identifier of the private cloud to be created.
        /// This identifier must be unique among each `PrivateCloud` within the parent
        /// and becomes the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> CreatePrivateCloud(string parent, PrivateCloud privateCloud, string privateCloudId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateCloud(new CreatePrivateCloudRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PrivateCloudId = gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)),
                PrivateCloud = gax::GaxPreconditions.CheckNotNull(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Creates a new `PrivateCloud` resource in a given project and location.
        /// Private clouds can only be created in zones, regional private clouds are
        /// not supported.
        /// 
        /// Creating a private cloud also creates a [management
        /// cluster](https://cloud.google.com/vmware-engine/docs/concepts-vmware-components)
        /// for that private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create the new
        /// private cloud in. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a`
        /// </param>
        /// <param name="privateCloud">
        /// Required. The initial description of the new private cloud.
        /// </param>
        /// <param name="privateCloudId">
        /// Required. The user-provided identifier of the private cloud to be created.
        /// This identifier must be unique among each `PrivateCloud` within the parent
        /// and becomes the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> CreatePrivateCloudAsync(string parent, PrivateCloud privateCloud, string privateCloudId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateCloudAsync(new CreatePrivateCloudRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PrivateCloudId = gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)),
                PrivateCloud = gax::GaxPreconditions.CheckNotNull(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Creates a new `PrivateCloud` resource in a given project and location.
        /// Private clouds can only be created in zones, regional private clouds are
        /// not supported.
        /// 
        /// Creating a private cloud also creates a [management
        /// cluster](https://cloud.google.com/vmware-engine/docs/concepts-vmware-components)
        /// for that private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create the new
        /// private cloud in. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a`
        /// </param>
        /// <param name="privateCloud">
        /// Required. The initial description of the new private cloud.
        /// </param>
        /// <param name="privateCloudId">
        /// Required. The user-provided identifier of the private cloud to be created.
        /// This identifier must be unique among each `PrivateCloud` within the parent
        /// and becomes the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> CreatePrivateCloudAsync(string parent, PrivateCloud privateCloud, string privateCloudId, st::CancellationToken cancellationToken) =>
            CreatePrivateCloudAsync(parent, privateCloud, privateCloudId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new `PrivateCloud` resource in a given project and location.
        /// Private clouds can only be created in zones, regional private clouds are
        /// not supported.
        /// 
        /// Creating a private cloud also creates a [management
        /// cluster](https://cloud.google.com/vmware-engine/docs/concepts-vmware-components)
        /// for that private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create the new
        /// private cloud in. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a`
        /// </param>
        /// <param name="privateCloud">
        /// Required. The initial description of the new private cloud.
        /// </param>
        /// <param name="privateCloudId">
        /// Required. The user-provided identifier of the private cloud to be created.
        /// This identifier must be unique among each `PrivateCloud` within the parent
        /// and becomes the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> CreatePrivateCloud(gagr::LocationName parent, PrivateCloud privateCloud, string privateCloudId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateCloud(new CreatePrivateCloudRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PrivateCloudId = gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)),
                PrivateCloud = gax::GaxPreconditions.CheckNotNull(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Creates a new `PrivateCloud` resource in a given project and location.
        /// Private clouds can only be created in zones, regional private clouds are
        /// not supported.
        /// 
        /// Creating a private cloud also creates a [management
        /// cluster](https://cloud.google.com/vmware-engine/docs/concepts-vmware-components)
        /// for that private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create the new
        /// private cloud in. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a`
        /// </param>
        /// <param name="privateCloud">
        /// Required. The initial description of the new private cloud.
        /// </param>
        /// <param name="privateCloudId">
        /// Required. The user-provided identifier of the private cloud to be created.
        /// This identifier must be unique among each `PrivateCloud` within the parent
        /// and becomes the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> CreatePrivateCloudAsync(gagr::LocationName parent, PrivateCloud privateCloud, string privateCloudId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateCloudAsync(new CreatePrivateCloudRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PrivateCloudId = gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)),
                PrivateCloud = gax::GaxPreconditions.CheckNotNull(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Creates a new `PrivateCloud` resource in a given project and location.
        /// Private clouds can only be created in zones, regional private clouds are
        /// not supported.
        /// 
        /// Creating a private cloud also creates a [management
        /// cluster](https://cloud.google.com/vmware-engine/docs/concepts-vmware-components)
        /// for that private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create the new
        /// private cloud in. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a`
        /// </param>
        /// <param name="privateCloud">
        /// Required. The initial description of the new private cloud.
        /// </param>
        /// <param name="privateCloudId">
        /// Required. The user-provided identifier of the private cloud to be created.
        /// This identifier must be unique among each `PrivateCloud` within the parent
        /// and becomes the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> CreatePrivateCloudAsync(gagr::LocationName parent, PrivateCloud privateCloud, string privateCloudId, st::CancellationToken cancellationToken) =>
            CreatePrivateCloudAsync(parent, privateCloud, privateCloudId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a `PrivateCloud` resource. Only the following fields can be
        /// updated: `description`.
        /// Only fields specified in `updateMask` are applied.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> UpdatePrivateCloud(UpdatePrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies a `PrivateCloud` resource. Only the following fields can be
        /// updated: `description`.
        /// Only fields specified in `updateMask` are applied.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> UpdatePrivateCloudAsync(UpdatePrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies a `PrivateCloud` resource. Only the following fields can be
        /// updated: `description`.
        /// Only fields specified in `updateMask` are applied.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> UpdatePrivateCloudAsync(UpdatePrivateCloudRequest request, st::CancellationToken cancellationToken) =>
            UpdatePrivateCloudAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdatePrivateCloud</c>.</summary>
        public virtual lro::OperationsClient UpdatePrivateCloudOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdatePrivateCloud</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> PollOnceUpdatePrivateCloud(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrivateCloud, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePrivateCloudOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdatePrivateCloud</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> PollOnceUpdatePrivateCloudAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrivateCloud, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePrivateCloudOperationsClient, callSettings);

        /// <summary>
        /// Modifies a `PrivateCloud` resource. Only the following fields can be
        /// updated: `description`.
        /// Only fields specified in `updateMask` are applied.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. Private cloud description.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `PrivateCloud` resource by the update. The fields specified in `updateMask`
        /// are relative to the resource, not the full request. A field will be
        /// overwritten if it is in the mask. If the user does not provide a mask then
        /// all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> UpdatePrivateCloud(PrivateCloud privateCloud, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePrivateCloud(new UpdatePrivateCloudRequest
            {
                PrivateCloud = gax::GaxPreconditions.CheckNotNull(privateCloud, nameof(privateCloud)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Modifies a `PrivateCloud` resource. Only the following fields can be
        /// updated: `description`.
        /// Only fields specified in `updateMask` are applied.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. Private cloud description.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `PrivateCloud` resource by the update. The fields specified in `updateMask`
        /// are relative to the resource, not the full request. A field will be
        /// overwritten if it is in the mask. If the user does not provide a mask then
        /// all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> UpdatePrivateCloudAsync(PrivateCloud privateCloud, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePrivateCloudAsync(new UpdatePrivateCloudRequest
            {
                PrivateCloud = gax::GaxPreconditions.CheckNotNull(privateCloud, nameof(privateCloud)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Modifies a `PrivateCloud` resource. Only the following fields can be
        /// updated: `description`.
        /// Only fields specified in `updateMask` are applied.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. Private cloud description.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `PrivateCloud` resource by the update. The fields specified in `updateMask`
        /// are relative to the resource, not the full request. A field will be
        /// overwritten if it is in the mask. If the user does not provide a mask then
        /// all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> UpdatePrivateCloudAsync(PrivateCloud privateCloud, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePrivateCloudAsync(privateCloud, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Schedules a `PrivateCloud` resource for deletion.
        /// 
        /// A `PrivateCloud` resource scheduled for deletion has `PrivateCloud.state`
        /// set to `DELETED` and `expireTime` set to the time when deletion is final
        /// and can no longer be reversed. The delete operation is marked as done
        /// as soon as the `PrivateCloud` is successfully scheduled for deletion
        /// (this also applies when `delayHours` is set to zero), and the operation is
        /// not kept in pending state until `PrivateCloud` is purged.
        /// `PrivateCloud` can be restored using `UndeletePrivateCloud` method before
        /// the `expireTime` elapses. When `expireTime` is reached, deletion is final
        /// and all private cloud resources are irreversibly removed and billing stops.
        /// During the final removal process, `PrivateCloud.state` is set to `PURGING`.
        /// `PrivateCloud` can be polled using standard `GET` method for the whole
        /// period of deletion and purging. It will not be returned only
        /// when it is completely purged.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> DeletePrivateCloud(DeletePrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Schedules a `PrivateCloud` resource for deletion.
        /// 
        /// A `PrivateCloud` resource scheduled for deletion has `PrivateCloud.state`
        /// set to `DELETED` and `expireTime` set to the time when deletion is final
        /// and can no longer be reversed. The delete operation is marked as done
        /// as soon as the `PrivateCloud` is successfully scheduled for deletion
        /// (this also applies when `delayHours` is set to zero), and the operation is
        /// not kept in pending state until `PrivateCloud` is purged.
        /// `PrivateCloud` can be restored using `UndeletePrivateCloud` method before
        /// the `expireTime` elapses. When `expireTime` is reached, deletion is final
        /// and all private cloud resources are irreversibly removed and billing stops.
        /// During the final removal process, `PrivateCloud.state` is set to `PURGING`.
        /// `PrivateCloud` can be polled using standard `GET` method for the whole
        /// period of deletion and purging. It will not be returned only
        /// when it is completely purged.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> DeletePrivateCloudAsync(DeletePrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Schedules a `PrivateCloud` resource for deletion.
        /// 
        /// A `PrivateCloud` resource scheduled for deletion has `PrivateCloud.state`
        /// set to `DELETED` and `expireTime` set to the time when deletion is final
        /// and can no longer be reversed. The delete operation is marked as done
        /// as soon as the `PrivateCloud` is successfully scheduled for deletion
        /// (this also applies when `delayHours` is set to zero), and the operation is
        /// not kept in pending state until `PrivateCloud` is purged.
        /// `PrivateCloud` can be restored using `UndeletePrivateCloud` method before
        /// the `expireTime` elapses. When `expireTime` is reached, deletion is final
        /// and all private cloud resources are irreversibly removed and billing stops.
        /// During the final removal process, `PrivateCloud.state` is set to `PURGING`.
        /// `PrivateCloud` can be polled using standard `GET` method for the whole
        /// period of deletion and purging. It will not be returned only
        /// when it is completely purged.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> DeletePrivateCloudAsync(DeletePrivateCloudRequest request, st::CancellationToken cancellationToken) =>
            DeletePrivateCloudAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeletePrivateCloud</c>.</summary>
        public virtual lro::OperationsClient DeletePrivateCloudOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeletePrivateCloud</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> PollOnceDeletePrivateCloud(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrivateCloud, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePrivateCloudOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePrivateCloud</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> PollOnceDeletePrivateCloudAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrivateCloud, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePrivateCloudOperationsClient, callSettings);

        /// <summary>
        /// Schedules a `PrivateCloud` resource for deletion.
        /// 
        /// A `PrivateCloud` resource scheduled for deletion has `PrivateCloud.state`
        /// set to `DELETED` and `expireTime` set to the time when deletion is final
        /// and can no longer be reversed. The delete operation is marked as done
        /// as soon as the `PrivateCloud` is successfully scheduled for deletion
        /// (this also applies when `delayHours` is set to zero), and the operation is
        /// not kept in pending state until `PrivateCloud` is purged.
        /// `PrivateCloud` can be restored using `UndeletePrivateCloud` method before
        /// the `expireTime` elapses. When `expireTime` is reached, deletion is final
        /// and all private cloud resources are irreversibly removed and billing stops.
        /// During the final removal process, `PrivateCloud.state` is set to `PURGING`.
        /// `PrivateCloud` can be polled using standard `GET` method for the whole
        /// period of deletion and purging. It will not be returned only
        /// when it is completely purged.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the private cloud to delete.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> DeletePrivateCloud(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateCloud(new DeletePrivateCloudRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Schedules a `PrivateCloud` resource for deletion.
        /// 
        /// A `PrivateCloud` resource scheduled for deletion has `PrivateCloud.state`
        /// set to `DELETED` and `expireTime` set to the time when deletion is final
        /// and can no longer be reversed. The delete operation is marked as done
        /// as soon as the `PrivateCloud` is successfully scheduled for deletion
        /// (this also applies when `delayHours` is set to zero), and the operation is
        /// not kept in pending state until `PrivateCloud` is purged.
        /// `PrivateCloud` can be restored using `UndeletePrivateCloud` method before
        /// the `expireTime` elapses. When `expireTime` is reached, deletion is final
        /// and all private cloud resources are irreversibly removed and billing stops.
        /// During the final removal process, `PrivateCloud.state` is set to `PURGING`.
        /// `PrivateCloud` can be polled using standard `GET` method for the whole
        /// period of deletion and purging. It will not be returned only
        /// when it is completely purged.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the private cloud to delete.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> DeletePrivateCloudAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateCloudAsync(new DeletePrivateCloudRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Schedules a `PrivateCloud` resource for deletion.
        /// 
        /// A `PrivateCloud` resource scheduled for deletion has `PrivateCloud.state`
        /// set to `DELETED` and `expireTime` set to the time when deletion is final
        /// and can no longer be reversed. The delete operation is marked as done
        /// as soon as the `PrivateCloud` is successfully scheduled for deletion
        /// (this also applies when `delayHours` is set to zero), and the operation is
        /// not kept in pending state until `PrivateCloud` is purged.
        /// `PrivateCloud` can be restored using `UndeletePrivateCloud` method before
        /// the `expireTime` elapses. When `expireTime` is reached, deletion is final
        /// and all private cloud resources are irreversibly removed and billing stops.
        /// During the final removal process, `PrivateCloud.state` is set to `PURGING`.
        /// `PrivateCloud` can be polled using standard `GET` method for the whole
        /// period of deletion and purging. It will not be returned only
        /// when it is completely purged.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the private cloud to delete.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> DeletePrivateCloudAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePrivateCloudAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Schedules a `PrivateCloud` resource for deletion.
        /// 
        /// A `PrivateCloud` resource scheduled for deletion has `PrivateCloud.state`
        /// set to `DELETED` and `expireTime` set to the time when deletion is final
        /// and can no longer be reversed. The delete operation is marked as done
        /// as soon as the `PrivateCloud` is successfully scheduled for deletion
        /// (this also applies when `delayHours` is set to zero), and the operation is
        /// not kept in pending state until `PrivateCloud` is purged.
        /// `PrivateCloud` can be restored using `UndeletePrivateCloud` method before
        /// the `expireTime` elapses. When `expireTime` is reached, deletion is final
        /// and all private cloud resources are irreversibly removed and billing stops.
        /// During the final removal process, `PrivateCloud.state` is set to `PURGING`.
        /// `PrivateCloud` can be polled using standard `GET` method for the whole
        /// period of deletion and purging. It will not be returned only
        /// when it is completely purged.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the private cloud to delete.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> DeletePrivateCloud(PrivateCloudName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateCloud(new DeletePrivateCloudRequest
            {
                PrivateCloudName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Schedules a `PrivateCloud` resource for deletion.
        /// 
        /// A `PrivateCloud` resource scheduled for deletion has `PrivateCloud.state`
        /// set to `DELETED` and `expireTime` set to the time when deletion is final
        /// and can no longer be reversed. The delete operation is marked as done
        /// as soon as the `PrivateCloud` is successfully scheduled for deletion
        /// (this also applies when `delayHours` is set to zero), and the operation is
        /// not kept in pending state until `PrivateCloud` is purged.
        /// `PrivateCloud` can be restored using `UndeletePrivateCloud` method before
        /// the `expireTime` elapses. When `expireTime` is reached, deletion is final
        /// and all private cloud resources are irreversibly removed and billing stops.
        /// During the final removal process, `PrivateCloud.state` is set to `PURGING`.
        /// `PrivateCloud` can be polled using standard `GET` method for the whole
        /// period of deletion and purging. It will not be returned only
        /// when it is completely purged.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the private cloud to delete.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> DeletePrivateCloudAsync(PrivateCloudName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateCloudAsync(new DeletePrivateCloudRequest
            {
                PrivateCloudName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Schedules a `PrivateCloud` resource for deletion.
        /// 
        /// A `PrivateCloud` resource scheduled for deletion has `PrivateCloud.state`
        /// set to `DELETED` and `expireTime` set to the time when deletion is final
        /// and can no longer be reversed. The delete operation is marked as done
        /// as soon as the `PrivateCloud` is successfully scheduled for deletion
        /// (this also applies when `delayHours` is set to zero), and the operation is
        /// not kept in pending state until `PrivateCloud` is purged.
        /// `PrivateCloud` can be restored using `UndeletePrivateCloud` method before
        /// the `expireTime` elapses. When `expireTime` is reached, deletion is final
        /// and all private cloud resources are irreversibly removed and billing stops.
        /// During the final removal process, `PrivateCloud.state` is set to `PURGING`.
        /// `PrivateCloud` can be polled using standard `GET` method for the whole
        /// period of deletion and purging. It will not be returned only
        /// when it is completely purged.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the private cloud to delete.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> DeletePrivateCloudAsync(PrivateCloudName name, st::CancellationToken cancellationToken) =>
            DeletePrivateCloudAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restores a private cloud that was previously scheduled for deletion by
        /// `DeletePrivateCloud`. A `PrivateCloud` resource scheduled for deletion has
        /// `PrivateCloud.state` set to `DELETED` and `PrivateCloud.expireTime` set to
        /// the time when deletion can no longer be reversed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> UndeletePrivateCloud(UndeletePrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores a private cloud that was previously scheduled for deletion by
        /// `DeletePrivateCloud`. A `PrivateCloud` resource scheduled for deletion has
        /// `PrivateCloud.state` set to `DELETED` and `PrivateCloud.expireTime` set to
        /// the time when deletion can no longer be reversed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> UndeletePrivateCloudAsync(UndeletePrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores a private cloud that was previously scheduled for deletion by
        /// `DeletePrivateCloud`. A `PrivateCloud` resource scheduled for deletion has
        /// `PrivateCloud.state` set to `DELETED` and `PrivateCloud.expireTime` set to
        /// the time when deletion can no longer be reversed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> UndeletePrivateCloudAsync(UndeletePrivateCloudRequest request, st::CancellationToken cancellationToken) =>
            UndeletePrivateCloudAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeletePrivateCloud</c>.</summary>
        public virtual lro::OperationsClient UndeletePrivateCloudOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UndeletePrivateCloud</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> PollOnceUndeletePrivateCloud(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrivateCloud, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeletePrivateCloudOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeletePrivateCloud</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> PollOnceUndeletePrivateCloudAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrivateCloud, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeletePrivateCloudOperationsClient, callSettings);

        /// <summary>
        /// Restores a private cloud that was previously scheduled for deletion by
        /// `DeletePrivateCloud`. A `PrivateCloud` resource scheduled for deletion has
        /// `PrivateCloud.state` set to `DELETED` and `PrivateCloud.expireTime` set to
        /// the time when deletion can no longer be reversed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the private cloud scheduled for deletion.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> UndeletePrivateCloud(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeletePrivateCloud(new UndeletePrivateCloudRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restores a private cloud that was previously scheduled for deletion by
        /// `DeletePrivateCloud`. A `PrivateCloud` resource scheduled for deletion has
        /// `PrivateCloud.state` set to `DELETED` and `PrivateCloud.expireTime` set to
        /// the time when deletion can no longer be reversed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the private cloud scheduled for deletion.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> UndeletePrivateCloudAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeletePrivateCloudAsync(new UndeletePrivateCloudRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restores a private cloud that was previously scheduled for deletion by
        /// `DeletePrivateCloud`. A `PrivateCloud` resource scheduled for deletion has
        /// `PrivateCloud.state` set to `DELETED` and `PrivateCloud.expireTime` set to
        /// the time when deletion can no longer be reversed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the private cloud scheduled for deletion.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> UndeletePrivateCloudAsync(string name, st::CancellationToken cancellationToken) =>
            UndeletePrivateCloudAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restores a private cloud that was previously scheduled for deletion by
        /// `DeletePrivateCloud`. A `PrivateCloud` resource scheduled for deletion has
        /// `PrivateCloud.state` set to `DELETED` and `PrivateCloud.expireTime` set to
        /// the time when deletion can no longer be reversed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the private cloud scheduled for deletion.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> UndeletePrivateCloud(PrivateCloudName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeletePrivateCloud(new UndeletePrivateCloudRequest
            {
                PrivateCloudName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restores a private cloud that was previously scheduled for deletion by
        /// `DeletePrivateCloud`. A `PrivateCloud` resource scheduled for deletion has
        /// `PrivateCloud.state` set to `DELETED` and `PrivateCloud.expireTime` set to
        /// the time when deletion can no longer be reversed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the private cloud scheduled for deletion.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> UndeletePrivateCloudAsync(PrivateCloudName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeletePrivateCloudAsync(new UndeletePrivateCloudRequest
            {
                PrivateCloudName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restores a private cloud that was previously scheduled for deletion by
        /// `DeletePrivateCloud`. A `PrivateCloud` resource scheduled for deletion has
        /// `PrivateCloud.state` set to `DELETED` and `PrivateCloud.expireTime` set to
        /// the time when deletion can no longer be reversed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the private cloud scheduled for deletion.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> UndeletePrivateCloudAsync(PrivateCloudName name, st::CancellationToken cancellationToken) =>
            UndeletePrivateCloudAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `Cluster` resources in a given private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `Cluster` resources in a given private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `Cluster` resources in a given private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to query for clusters.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
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
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListClusters(new ListClustersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `Cluster` resources in a given private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to query for clusters.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListClustersAsync(new ListClustersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `Cluster` resources in a given private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to query for clusters.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
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
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(PrivateCloudName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListClusters(new ListClustersRequest
            {
                ParentAsPrivateCloudName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `Cluster` resources in a given private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to query for clusters.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(PrivateCloudName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListClustersAsync(new ListClustersRequest
            {
                ParentAsPrivateCloudName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a `Cluster` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `Cluster` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `Cluster` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, st::CancellationToken cancellationToken) =>
            GetClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `Cluster` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The cluster resource name to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCluster(new GetClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Cluster` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The cluster resource name to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetClusterAsync(new GetClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Cluster` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The cluster resource name to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(string name, st::CancellationToken cancellationToken) =>
            GetClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `Cluster` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The cluster resource name to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCluster(new GetClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Cluster` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The cluster resource name to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetClusterAsync(new GetClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Cluster` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The cluster resource name to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(ClusterName name, st::CancellationToken cancellationToken) =>
            GetClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new cluster in a given private cloud.
        /// Creating a new cluster provides additional nodes for
        /// use in the parent private cloud and requires sufficient [node
        /// quota](https://cloud.google.com/vmware-engine/quotas).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> CreateCluster(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new cluster in a given private cloud.
        /// Creating a new cluster provides additional nodes for
        /// use in the parent private cloud and requires sufficient [node
        /// quota](https://cloud.google.com/vmware-engine/quotas).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new cluster in a given private cloud.
        /// Creating a new cluster provides additional nodes for
        /// use in the parent private cloud and requires sufficient [node
        /// quota](https://cloud.google.com/vmware-engine/quotas).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(CreateClusterRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Cluster, OperationMetadata> PollOnceCreateCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> PollOnceCreateClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateClusterOperationsClient, callSettings);

        /// <summary>
        /// Creates a new cluster in a given private cloud.
        /// Creating a new cluster provides additional nodes for
        /// use in the parent private cloud and requires sufficient [node
        /// quota](https://cloud.google.com/vmware-engine/quotas).
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to create a new cluster
        /// in. Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cluster">
        /// Required. The initial description of the new cluster.
        /// </param>
        /// <param name="clusterId">
        /// Required. The user-provided identifier of the new `Cluster`.
        /// This identifier must be unique among clusters within the parent and becomes
        /// the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> CreateCluster(string parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCluster(new CreateClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new cluster in a given private cloud.
        /// Creating a new cluster provides additional nodes for
        /// use in the parent private cloud and requires sufficient [node
        /// quota](https://cloud.google.com/vmware-engine/quotas).
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to create a new cluster
        /// in. Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cluster">
        /// Required. The initial description of the new cluster.
        /// </param>
        /// <param name="clusterId">
        /// Required. The user-provided identifier of the new `Cluster`.
        /// This identifier must be unique among clusters within the parent and becomes
        /// the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(string parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClusterAsync(new CreateClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new cluster in a given private cloud.
        /// Creating a new cluster provides additional nodes for
        /// use in the parent private cloud and requires sufficient [node
        /// quota](https://cloud.google.com/vmware-engine/quotas).
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to create a new cluster
        /// in. Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cluster">
        /// Required. The initial description of the new cluster.
        /// </param>
        /// <param name="clusterId">
        /// Required. The user-provided identifier of the new `Cluster`.
        /// This identifier must be unique among clusters within the parent and becomes
        /// the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(string parent, Cluster cluster, string clusterId, st::CancellationToken cancellationToken) =>
            CreateClusterAsync(parent, cluster, clusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new cluster in a given private cloud.
        /// Creating a new cluster provides additional nodes for
        /// use in the parent private cloud and requires sufficient [node
        /// quota](https://cloud.google.com/vmware-engine/quotas).
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to create a new cluster
        /// in. Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cluster">
        /// Required. The initial description of the new cluster.
        /// </param>
        /// <param name="clusterId">
        /// Required. The user-provided identifier of the new `Cluster`.
        /// This identifier must be unique among clusters within the parent and becomes
        /// the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> CreateCluster(PrivateCloudName parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCluster(new CreateClusterRequest
            {
                ParentAsPrivateCloudName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new cluster in a given private cloud.
        /// Creating a new cluster provides additional nodes for
        /// use in the parent private cloud and requires sufficient [node
        /// quota](https://cloud.google.com/vmware-engine/quotas).
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to create a new cluster
        /// in. Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cluster">
        /// Required. The initial description of the new cluster.
        /// </param>
        /// <param name="clusterId">
        /// Required. The user-provided identifier of the new `Cluster`.
        /// This identifier must be unique among clusters within the parent and becomes
        /// the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(PrivateCloudName parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClusterAsync(new CreateClusterRequest
            {
                ParentAsPrivateCloudName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new cluster in a given private cloud.
        /// Creating a new cluster provides additional nodes for
        /// use in the parent private cloud and requires sufficient [node
        /// quota](https://cloud.google.com/vmware-engine/quotas).
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to create a new cluster
        /// in. Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cluster">
        /// Required. The initial description of the new cluster.
        /// </param>
        /// <param name="clusterId">
        /// Required. The user-provided identifier of the new `Cluster`.
        /// This identifier must be unique among clusters within the parent and becomes
        /// the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(PrivateCloudName parent, Cluster cluster, string clusterId, st::CancellationToken cancellationToken) =>
            CreateClusterAsync(parent, cluster, clusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a `Cluster` resource. Only the following fields can be updated:
        /// `node_type_configs.*.node_count`. Only fields specified in `updateMask` are
        /// applied.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> UpdateCluster(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies a `Cluster` resource. Only the following fields can be updated:
        /// `node_type_configs.*.node_count`. Only fields specified in `updateMask` are
        /// applied.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> UpdateClusterAsync(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies a `Cluster` resource. Only the following fields can be updated:
        /// `node_type_configs.*.node_count`. Only fields specified in `updateMask` are
        /// applied.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> UpdateClusterAsync(UpdateClusterRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Cluster, OperationMetadata> PollOnceUpdateCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> PollOnceUpdateClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateClusterOperationsClient, callSettings);

        /// <summary>
        /// Modifies a `Cluster` resource. Only the following fields can be updated:
        /// `node_type_configs.*.node_count`. Only fields specified in `updateMask` are
        /// applied.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="cluster">
        /// Required. The description of the cluster.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `Cluster` resource by the update. The fields specified in the `updateMask`
        /// are relative to the resource, not the full request. A field will be
        /// overwritten if it is in the mask. If the user does not provide a mask then
        /// all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> UpdateCluster(Cluster cluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCluster(new UpdateClusterRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Modifies a `Cluster` resource. Only the following fields can be updated:
        /// `node_type_configs.*.node_count`. Only fields specified in `updateMask` are
        /// applied.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="cluster">
        /// Required. The description of the cluster.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `Cluster` resource by the update. The fields specified in the `updateMask`
        /// are relative to the resource, not the full request. A field will be
        /// overwritten if it is in the mask. If the user does not provide a mask then
        /// all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> UpdateClusterAsync(Cluster cluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateClusterAsync(new UpdateClusterRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Modifies a `Cluster` resource. Only the following fields can be updated:
        /// `node_type_configs.*.node_count`. Only fields specified in `updateMask` are
        /// applied.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="cluster">
        /// Required. The description of the cluster.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `Cluster` resource by the update. The fields specified in the `updateMask`
        /// are relative to the resource, not the full request. A field will be
        /// overwritten if it is in the mask. If the user does not provide a mask then
        /// all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> UpdateClusterAsync(Cluster cluster, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateClusterAsync(cluster, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a `Cluster` resource. To avoid unintended data loss, migrate or
        /// gracefully shut down any workloads running on the cluster before deletion.
        /// You cannot delete the management cluster of a private cloud using this
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCluster(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a `Cluster` resource. To avoid unintended data loss, migrate or
        /// gracefully shut down any workloads running on the cluster before deletion.
        /// You cannot delete the management cluster of a private cloud using this
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a `Cluster` resource. To avoid unintended data loss, migrate or
        /// gracefully shut down any workloads running on the cluster before deletion.
        /// You cannot delete the management cluster of a private cloud using this
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(DeleteClusterRequest request, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCluster</c>.</summary>
        public virtual lro::OperationsClient DeleteClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteClusterOperationsClient, callSettings);

        /// <summary>
        /// Deletes a `Cluster` resource. To avoid unintended data loss, migrate or
        /// gracefully shut down any workloads running on the cluster before deletion.
        /// You cannot delete the management cluster of a private cloud using this
        /// method.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the cluster to delete.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCluster(new DeleteClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `Cluster` resource. To avoid unintended data loss, migrate or
        /// gracefully shut down any workloads running on the cluster before deletion.
        /// You cannot delete the management cluster of a private cloud using this
        /// method.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the cluster to delete.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClusterAsync(new DeleteClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `Cluster` resource. To avoid unintended data loss, migrate or
        /// gracefully shut down any workloads running on the cluster before deletion.
        /// You cannot delete the management cluster of a private cloud using this
        /// method.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the cluster to delete.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a `Cluster` resource. To avoid unintended data loss, migrate or
        /// gracefully shut down any workloads running on the cluster before deletion.
        /// You cannot delete the management cluster of a private cloud using this
        /// method.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the cluster to delete.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCluster(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCluster(new DeleteClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `Cluster` resource. To avoid unintended data loss, migrate or
        /// gracefully shut down any workloads running on the cluster before deletion.
        /// You cannot delete the management cluster of a private cloud using this
        /// method.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the cluster to delete.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClusterAsync(new DeleteClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `Cluster` resource. To avoid unintended data loss, migrate or
        /// gracefully shut down any workloads running on the cluster before deletion.
        /// You cannot delete the management cluster of a private cloud using this
        /// method.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the cluster to delete.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(ClusterName name, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists subnets in a given private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Subnet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubnetsResponse, Subnet> ListSubnets(ListSubnetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists subnets in a given private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Subnet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubnetsResponse, Subnet> ListSubnetsAsync(ListSubnetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists subnets in a given private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to be queried for
        /// subnets.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
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
        /// <returns>A pageable sequence of <see cref="Subnet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubnetsResponse, Subnet> ListSubnets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSubnets(new ListSubnetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists subnets in a given private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to be queried for
        /// subnets.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Subnet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubnetsResponse, Subnet> ListSubnetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSubnetsAsync(new ListSubnetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists subnets in a given private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to be queried for
        /// subnets.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
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
        /// <returns>A pageable sequence of <see cref="Subnet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubnetsResponse, Subnet> ListSubnets(PrivateCloudName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSubnets(new ListSubnetsRequest
            {
                ParentAsPrivateCloudName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists subnets in a given private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to be queried for
        /// subnets.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Subnet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubnetsResponse, Subnet> ListSubnetsAsync(PrivateCloudName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSubnetsAsync(new ListSubnetsRequest
            {
                ParentAsPrivateCloudName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists node types
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NodeType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNodeTypesResponse, NodeType> ListNodeTypes(ListNodeTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists node types
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NodeType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNodeTypesResponse, NodeType> ListNodeTypesAsync(ListNodeTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists node types
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to be queried for node types.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a`
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
        /// <returns>A pageable sequence of <see cref="NodeType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNodeTypesResponse, NodeType> ListNodeTypes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNodeTypes(new ListNodeTypesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists node types
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to be queried for node types.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a`
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
        /// <returns>A pageable asynchronous sequence of <see cref="NodeType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNodeTypesResponse, NodeType> ListNodeTypesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNodeTypesAsync(new ListNodeTypesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists node types
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to be queried for node types.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a`
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
        /// <returns>A pageable sequence of <see cref="NodeType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNodeTypesResponse, NodeType> ListNodeTypes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNodeTypes(new ListNodeTypesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists node types
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to be queried for node types.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a`
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
        /// <returns>A pageable asynchronous sequence of <see cref="NodeType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNodeTypesResponse, NodeType> ListNodeTypesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNodeTypesAsync(new ListNodeTypesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single `NodeType`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NodeType GetNodeType(GetNodeTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single `NodeType`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NodeType> GetNodeTypeAsync(GetNodeTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single `NodeType`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NodeType> GetNodeTypeAsync(GetNodeTypeRequest request, st::CancellationToken cancellationToken) =>
            GetNodeTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single `NodeType`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the node type to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-proj/locations/us-central1-a/nodeTypes/standard-72`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NodeType GetNodeType(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNodeType(new GetNodeTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single `NodeType`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the node type to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-proj/locations/us-central1-a/nodeTypes/standard-72`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NodeType> GetNodeTypeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNodeTypeAsync(new GetNodeTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single `NodeType`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the node type to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-proj/locations/us-central1-a/nodeTypes/standard-72`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NodeType> GetNodeTypeAsync(string name, st::CancellationToken cancellationToken) =>
            GetNodeTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single `NodeType`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the node type to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-proj/locations/us-central1-a/nodeTypes/standard-72`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NodeType GetNodeType(NodeTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNodeType(new GetNodeTypeRequest
            {
                NodeTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single `NodeType`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the node type to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-proj/locations/us-central1-a/nodeTypes/standard-72`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NodeType> GetNodeTypeAsync(NodeTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNodeTypeAsync(new GetNodeTypeRequest
            {
                NodeTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single `NodeType`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the node type to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-proj/locations/us-central1-a/nodeTypes/standard-72`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NodeType> GetNodeTypeAsync(NodeTypeName name, st::CancellationToken cancellationToken) =>
            GetNodeTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of credentials for NSX appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Credentials ShowNsxCredentials(ShowNsxCredentialsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of credentials for NSX appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Credentials> ShowNsxCredentialsAsync(ShowNsxCredentialsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of credentials for NSX appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Credentials> ShowNsxCredentialsAsync(ShowNsxCredentialsRequest request, st::CancellationToken cancellationToken) =>
            ShowNsxCredentialsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of credentials for NSX appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to be queried for credentials.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Credentials ShowNsxCredentials(string privateCloud, gaxgrpc::CallSettings callSettings = null) =>
            ShowNsxCredentials(new ShowNsxCredentialsRequest
            {
                PrivateCloud = gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Gets details of credentials for NSX appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to be queried for credentials.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Credentials> ShowNsxCredentialsAsync(string privateCloud, gaxgrpc::CallSettings callSettings = null) =>
            ShowNsxCredentialsAsync(new ShowNsxCredentialsRequest
            {
                PrivateCloud = gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Gets details of credentials for NSX appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to be queried for credentials.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Credentials> ShowNsxCredentialsAsync(string privateCloud, st::CancellationToken cancellationToken) =>
            ShowNsxCredentialsAsync(privateCloud, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of credentials for NSX appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to be queried for credentials.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Credentials ShowNsxCredentials(PrivateCloudName privateCloud, gaxgrpc::CallSettings callSettings = null) =>
            ShowNsxCredentials(new ShowNsxCredentialsRequest
            {
                PrivateCloudAsPrivateCloudName = gax::GaxPreconditions.CheckNotNull(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Gets details of credentials for NSX appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to be queried for credentials.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Credentials> ShowNsxCredentialsAsync(PrivateCloudName privateCloud, gaxgrpc::CallSettings callSettings = null) =>
            ShowNsxCredentialsAsync(new ShowNsxCredentialsRequest
            {
                PrivateCloudAsPrivateCloudName = gax::GaxPreconditions.CheckNotNull(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Gets details of credentials for NSX appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to be queried for credentials.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Credentials> ShowNsxCredentialsAsync(PrivateCloudName privateCloud, st::CancellationToken cancellationToken) =>
            ShowNsxCredentialsAsync(privateCloud, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of credentials for Vcenter appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Credentials ShowVcenterCredentials(ShowVcenterCredentialsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of credentials for Vcenter appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Credentials> ShowVcenterCredentialsAsync(ShowVcenterCredentialsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of credentials for Vcenter appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Credentials> ShowVcenterCredentialsAsync(ShowVcenterCredentialsRequest request, st::CancellationToken cancellationToken) =>
            ShowVcenterCredentialsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of credentials for Vcenter appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to be queried for credentials.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Credentials ShowVcenterCredentials(string privateCloud, gaxgrpc::CallSettings callSettings = null) =>
            ShowVcenterCredentials(new ShowVcenterCredentialsRequest
            {
                PrivateCloud = gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Gets details of credentials for Vcenter appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to be queried for credentials.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Credentials> ShowVcenterCredentialsAsync(string privateCloud, gaxgrpc::CallSettings callSettings = null) =>
            ShowVcenterCredentialsAsync(new ShowVcenterCredentialsRequest
            {
                PrivateCloud = gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Gets details of credentials for Vcenter appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to be queried for credentials.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Credentials> ShowVcenterCredentialsAsync(string privateCloud, st::CancellationToken cancellationToken) =>
            ShowVcenterCredentialsAsync(privateCloud, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of credentials for Vcenter appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to be queried for credentials.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Credentials ShowVcenterCredentials(PrivateCloudName privateCloud, gaxgrpc::CallSettings callSettings = null) =>
            ShowVcenterCredentials(new ShowVcenterCredentialsRequest
            {
                PrivateCloudAsPrivateCloudName = gax::GaxPreconditions.CheckNotNull(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Gets details of credentials for Vcenter appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to be queried for credentials.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Credentials> ShowVcenterCredentialsAsync(PrivateCloudName privateCloud, gaxgrpc::CallSettings callSettings = null) =>
            ShowVcenterCredentialsAsync(new ShowVcenterCredentialsRequest
            {
                PrivateCloudAsPrivateCloudName = gax::GaxPreconditions.CheckNotNull(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Gets details of credentials for Vcenter appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to be queried for credentials.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Credentials> ShowVcenterCredentialsAsync(PrivateCloudName privateCloud, st::CancellationToken cancellationToken) =>
            ShowVcenterCredentialsAsync(privateCloud, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resets credentials of the NSX appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> ResetNsxCredentials(ResetNsxCredentialsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resets credentials of the NSX appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> ResetNsxCredentialsAsync(ResetNsxCredentialsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resets credentials of the NSX appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> ResetNsxCredentialsAsync(ResetNsxCredentialsRequest request, st::CancellationToken cancellationToken) =>
            ResetNsxCredentialsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ResetNsxCredentials</c>.</summary>
        public virtual lro::OperationsClient ResetNsxCredentialsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ResetNsxCredentials</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> PollOnceResetNsxCredentials(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrivateCloud, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResetNsxCredentialsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ResetNsxCredentials</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> PollOnceResetNsxCredentialsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrivateCloud, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResetNsxCredentialsOperationsClient, callSettings);

        /// <summary>
        /// Resets credentials of the NSX appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to reset credentials for.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> ResetNsxCredentials(string privateCloud, gaxgrpc::CallSettings callSettings = null) =>
            ResetNsxCredentials(new ResetNsxCredentialsRequest
            {
                PrivateCloud = gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Resets credentials of the NSX appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to reset credentials for.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> ResetNsxCredentialsAsync(string privateCloud, gaxgrpc::CallSettings callSettings = null) =>
            ResetNsxCredentialsAsync(new ResetNsxCredentialsRequest
            {
                PrivateCloud = gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Resets credentials of the NSX appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to reset credentials for.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> ResetNsxCredentialsAsync(string privateCloud, st::CancellationToken cancellationToken) =>
            ResetNsxCredentialsAsync(privateCloud, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resets credentials of the NSX appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to reset credentials for.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> ResetNsxCredentials(PrivateCloudName privateCloud, gaxgrpc::CallSettings callSettings = null) =>
            ResetNsxCredentials(new ResetNsxCredentialsRequest
            {
                PrivateCloudAsPrivateCloudName = gax::GaxPreconditions.CheckNotNull(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Resets credentials of the NSX appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to reset credentials for.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> ResetNsxCredentialsAsync(PrivateCloudName privateCloud, gaxgrpc::CallSettings callSettings = null) =>
            ResetNsxCredentialsAsync(new ResetNsxCredentialsRequest
            {
                PrivateCloudAsPrivateCloudName = gax::GaxPreconditions.CheckNotNull(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Resets credentials of the NSX appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to reset credentials for.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> ResetNsxCredentialsAsync(PrivateCloudName privateCloud, st::CancellationToken cancellationToken) =>
            ResetNsxCredentialsAsync(privateCloud, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resets credentials of the Vcenter appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> ResetVcenterCredentials(ResetVcenterCredentialsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resets credentials of the Vcenter appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> ResetVcenterCredentialsAsync(ResetVcenterCredentialsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resets credentials of the Vcenter appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> ResetVcenterCredentialsAsync(ResetVcenterCredentialsRequest request, st::CancellationToken cancellationToken) =>
            ResetVcenterCredentialsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ResetVcenterCredentials</c>.</summary>
        public virtual lro::OperationsClient ResetVcenterCredentialsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ResetVcenterCredentials</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> PollOnceResetVcenterCredentials(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrivateCloud, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResetVcenterCredentialsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ResetVcenterCredentials</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> PollOnceResetVcenterCredentialsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrivateCloud, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResetVcenterCredentialsOperationsClient, callSettings);

        /// <summary>
        /// Resets credentials of the Vcenter appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to reset credentials for.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> ResetVcenterCredentials(string privateCloud, gaxgrpc::CallSettings callSettings = null) =>
            ResetVcenterCredentials(new ResetVcenterCredentialsRequest
            {
                PrivateCloud = gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Resets credentials of the Vcenter appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to reset credentials for.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> ResetVcenterCredentialsAsync(string privateCloud, gaxgrpc::CallSettings callSettings = null) =>
            ResetVcenterCredentialsAsync(new ResetVcenterCredentialsRequest
            {
                PrivateCloud = gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Resets credentials of the Vcenter appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to reset credentials for.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> ResetVcenterCredentialsAsync(string privateCloud, st::CancellationToken cancellationToken) =>
            ResetVcenterCredentialsAsync(privateCloud, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resets credentials of the Vcenter appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to reset credentials for.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateCloud, OperationMetadata> ResetVcenterCredentials(PrivateCloudName privateCloud, gaxgrpc::CallSettings callSettings = null) =>
            ResetVcenterCredentials(new ResetVcenterCredentialsRequest
            {
                PrivateCloudAsPrivateCloudName = gax::GaxPreconditions.CheckNotNull(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Resets credentials of the Vcenter appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to reset credentials for.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> ResetVcenterCredentialsAsync(PrivateCloudName privateCloud, gaxgrpc::CallSettings callSettings = null) =>
            ResetVcenterCredentialsAsync(new ResetVcenterCredentialsRequest
            {
                PrivateCloudAsPrivateCloudName = gax::GaxPreconditions.CheckNotNull(privateCloud, nameof(privateCloud)),
            }, callSettings);

        /// <summary>
        /// Resets credentials of the Vcenter appliance.
        /// </summary>
        /// <param name="privateCloud">
        /// Required. The resource name of the private cloud
        /// to reset credentials for.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> ResetVcenterCredentialsAsync(PrivateCloudName privateCloud, st::CancellationToken cancellationToken) =>
            ResetVcenterCredentialsAsync(privateCloud, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new HCX activation key in a given private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<HcxActivationKey, OperationMetadata> CreateHcxActivationKey(CreateHcxActivationKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new HCX activation key in a given private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HcxActivationKey, OperationMetadata>> CreateHcxActivationKeyAsync(CreateHcxActivationKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new HCX activation key in a given private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HcxActivationKey, OperationMetadata>> CreateHcxActivationKeyAsync(CreateHcxActivationKeyRequest request, st::CancellationToken cancellationToken) =>
            CreateHcxActivationKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateHcxActivationKey</c>.</summary>
        public virtual lro::OperationsClient CreateHcxActivationKeyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateHcxActivationKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<HcxActivationKey, OperationMetadata> PollOnceCreateHcxActivationKey(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<HcxActivationKey, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateHcxActivationKeyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateHcxActivationKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<HcxActivationKey, OperationMetadata>> PollOnceCreateHcxActivationKeyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<HcxActivationKey, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateHcxActivationKeyOperationsClient, callSettings);

        /// <summary>
        /// Creates a new HCX activation key in a given private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to create the key for.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud`
        /// </param>
        /// <param name="hcxActivationKey">
        /// Required. The initial description of a new HCX activation key. When
        /// creating a new key, this field must be an empty object.
        /// </param>
        /// <param name="hcxActivationKeyId">
        /// Required. The user-provided identifier of the `HcxActivationKey` to be
        /// created. This identifier must be unique among `HcxActivationKey` resources
        /// within the parent and becomes the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<HcxActivationKey, OperationMetadata> CreateHcxActivationKey(string parent, HcxActivationKey hcxActivationKey, string hcxActivationKeyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHcxActivationKey(new CreateHcxActivationKeyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                HcxActivationKey = gax::GaxPreconditions.CheckNotNull(hcxActivationKey, nameof(hcxActivationKey)),
                HcxActivationKeyId = gax::GaxPreconditions.CheckNotNullOrEmpty(hcxActivationKeyId, nameof(hcxActivationKeyId)),
            }, callSettings);

        /// <summary>
        /// Creates a new HCX activation key in a given private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to create the key for.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud`
        /// </param>
        /// <param name="hcxActivationKey">
        /// Required. The initial description of a new HCX activation key. When
        /// creating a new key, this field must be an empty object.
        /// </param>
        /// <param name="hcxActivationKeyId">
        /// Required. The user-provided identifier of the `HcxActivationKey` to be
        /// created. This identifier must be unique among `HcxActivationKey` resources
        /// within the parent and becomes the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HcxActivationKey, OperationMetadata>> CreateHcxActivationKeyAsync(string parent, HcxActivationKey hcxActivationKey, string hcxActivationKeyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHcxActivationKeyAsync(new CreateHcxActivationKeyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                HcxActivationKey = gax::GaxPreconditions.CheckNotNull(hcxActivationKey, nameof(hcxActivationKey)),
                HcxActivationKeyId = gax::GaxPreconditions.CheckNotNullOrEmpty(hcxActivationKeyId, nameof(hcxActivationKeyId)),
            }, callSettings);

        /// <summary>
        /// Creates a new HCX activation key in a given private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to create the key for.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud`
        /// </param>
        /// <param name="hcxActivationKey">
        /// Required. The initial description of a new HCX activation key. When
        /// creating a new key, this field must be an empty object.
        /// </param>
        /// <param name="hcxActivationKeyId">
        /// Required. The user-provided identifier of the `HcxActivationKey` to be
        /// created. This identifier must be unique among `HcxActivationKey` resources
        /// within the parent and becomes the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HcxActivationKey, OperationMetadata>> CreateHcxActivationKeyAsync(string parent, HcxActivationKey hcxActivationKey, string hcxActivationKeyId, st::CancellationToken cancellationToken) =>
            CreateHcxActivationKeyAsync(parent, hcxActivationKey, hcxActivationKeyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new HCX activation key in a given private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to create the key for.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud`
        /// </param>
        /// <param name="hcxActivationKey">
        /// Required. The initial description of a new HCX activation key. When
        /// creating a new key, this field must be an empty object.
        /// </param>
        /// <param name="hcxActivationKeyId">
        /// Required. The user-provided identifier of the `HcxActivationKey` to be
        /// created. This identifier must be unique among `HcxActivationKey` resources
        /// within the parent and becomes the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<HcxActivationKey, OperationMetadata> CreateHcxActivationKey(PrivateCloudName parent, HcxActivationKey hcxActivationKey, string hcxActivationKeyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHcxActivationKey(new CreateHcxActivationKeyRequest
            {
                ParentAsPrivateCloudName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                HcxActivationKey = gax::GaxPreconditions.CheckNotNull(hcxActivationKey, nameof(hcxActivationKey)),
                HcxActivationKeyId = gax::GaxPreconditions.CheckNotNullOrEmpty(hcxActivationKeyId, nameof(hcxActivationKeyId)),
            }, callSettings);

        /// <summary>
        /// Creates a new HCX activation key in a given private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to create the key for.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud`
        /// </param>
        /// <param name="hcxActivationKey">
        /// Required. The initial description of a new HCX activation key. When
        /// creating a new key, this field must be an empty object.
        /// </param>
        /// <param name="hcxActivationKeyId">
        /// Required. The user-provided identifier of the `HcxActivationKey` to be
        /// created. This identifier must be unique among `HcxActivationKey` resources
        /// within the parent and becomes the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HcxActivationKey, OperationMetadata>> CreateHcxActivationKeyAsync(PrivateCloudName parent, HcxActivationKey hcxActivationKey, string hcxActivationKeyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHcxActivationKeyAsync(new CreateHcxActivationKeyRequest
            {
                ParentAsPrivateCloudName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                HcxActivationKey = gax::GaxPreconditions.CheckNotNull(hcxActivationKey, nameof(hcxActivationKey)),
                HcxActivationKeyId = gax::GaxPreconditions.CheckNotNullOrEmpty(hcxActivationKeyId, nameof(hcxActivationKeyId)),
            }, callSettings);

        /// <summary>
        /// Creates a new HCX activation key in a given private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud to create the key for.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud`
        /// </param>
        /// <param name="hcxActivationKey">
        /// Required. The initial description of a new HCX activation key. When
        /// creating a new key, this field must be an empty object.
        /// </param>
        /// <param name="hcxActivationKeyId">
        /// Required. The user-provided identifier of the `HcxActivationKey` to be
        /// created. This identifier must be unique among `HcxActivationKey` resources
        /// within the parent and becomes the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HcxActivationKey, OperationMetadata>> CreateHcxActivationKeyAsync(PrivateCloudName parent, HcxActivationKey hcxActivationKey, string hcxActivationKeyId, st::CancellationToken cancellationToken) =>
            CreateHcxActivationKeyAsync(parent, hcxActivationKey, hcxActivationKeyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `HcxActivationKey` resources in a given private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HcxActivationKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHcxActivationKeysResponse, HcxActivationKey> ListHcxActivationKeys(ListHcxActivationKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `HcxActivationKey` resources in a given private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HcxActivationKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHcxActivationKeysResponse, HcxActivationKey> ListHcxActivationKeysAsync(ListHcxActivationKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `HcxActivationKey` resources in a given private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud
        /// to be queried for HCX activation keys.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud`
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
        /// <returns>A pageable sequence of <see cref="HcxActivationKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHcxActivationKeysResponse, HcxActivationKey> ListHcxActivationKeys(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListHcxActivationKeys(new ListHcxActivationKeysRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `HcxActivationKey` resources in a given private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud
        /// to be queried for HCX activation keys.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud`
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
        /// <returns>A pageable asynchronous sequence of <see cref="HcxActivationKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHcxActivationKeysResponse, HcxActivationKey> ListHcxActivationKeysAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListHcxActivationKeysAsync(new ListHcxActivationKeysRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `HcxActivationKey` resources in a given private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud
        /// to be queried for HCX activation keys.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud`
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
        /// <returns>A pageable sequence of <see cref="HcxActivationKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHcxActivationKeysResponse, HcxActivationKey> ListHcxActivationKeys(PrivateCloudName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListHcxActivationKeys(new ListHcxActivationKeysRequest
            {
                ParentAsPrivateCloudName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `HcxActivationKey` resources in a given private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the private cloud
        /// to be queried for HCX activation keys.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud`
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
        /// <returns>A pageable asynchronous sequence of <see cref="HcxActivationKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHcxActivationKeysResponse, HcxActivationKey> ListHcxActivationKeysAsync(PrivateCloudName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListHcxActivationKeysAsync(new ListHcxActivationKeysRequest
            {
                ParentAsPrivateCloudName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a `HcxActivationKey` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HcxActivationKey GetHcxActivationKey(GetHcxActivationKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `HcxActivationKey` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HcxActivationKey> GetHcxActivationKeyAsync(GetHcxActivationKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `HcxActivationKey` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HcxActivationKey> GetHcxActivationKeyAsync(GetHcxActivationKeyRequest request, st::CancellationToken cancellationToken) =>
            GetHcxActivationKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `HcxActivationKey` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the HCX activation key to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud/hcxActivationKeys/my-key`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HcxActivationKey GetHcxActivationKey(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHcxActivationKey(new GetHcxActivationKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `HcxActivationKey` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the HCX activation key to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud/hcxActivationKeys/my-key`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HcxActivationKey> GetHcxActivationKeyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHcxActivationKeyAsync(new GetHcxActivationKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `HcxActivationKey` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the HCX activation key to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud/hcxActivationKeys/my-key`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HcxActivationKey> GetHcxActivationKeyAsync(string name, st::CancellationToken cancellationToken) =>
            GetHcxActivationKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `HcxActivationKey` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the HCX activation key to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud/hcxActivationKeys/my-key`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HcxActivationKey GetHcxActivationKey(HcxActivationKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHcxActivationKey(new GetHcxActivationKeyRequest
            {
                HcxActivationKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `HcxActivationKey` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the HCX activation key to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud/hcxActivationKeys/my-key`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HcxActivationKey> GetHcxActivationKeyAsync(HcxActivationKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHcxActivationKeyAsync(new GetHcxActivationKeyRequest
            {
                HcxActivationKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `HcxActivationKey` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the HCX activation key to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud/hcxActivationKeys/my-key`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HcxActivationKey> GetHcxActivationKeyAsync(HcxActivationKeyName name, st::CancellationToken cancellationToken) =>
            GetHcxActivationKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `NetworkPolicy` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NetworkPolicy GetNetworkPolicy(GetNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `NetworkPolicy` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NetworkPolicy> GetNetworkPolicyAsync(GetNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `NetworkPolicy` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NetworkPolicy> GetNetworkPolicyAsync(GetNetworkPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetNetworkPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `NetworkPolicy` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the network policy to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NetworkPolicy GetNetworkPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetworkPolicy(new GetNetworkPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `NetworkPolicy` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the network policy to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NetworkPolicy> GetNetworkPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetworkPolicyAsync(new GetNetworkPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `NetworkPolicy` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the network policy to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NetworkPolicy> GetNetworkPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetNetworkPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `NetworkPolicy` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the network policy to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NetworkPolicy GetNetworkPolicy(NetworkPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetworkPolicy(new GetNetworkPolicyRequest
            {
                NetworkPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `NetworkPolicy` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the network policy to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NetworkPolicy> GetNetworkPolicyAsync(NetworkPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetworkPolicyAsync(new GetNetworkPolicyRequest
            {
                NetworkPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `NetworkPolicy` resource by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the network policy to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NetworkPolicy> GetNetworkPolicyAsync(NetworkPolicyName name, st::CancellationToken cancellationToken) =>
            GetNetworkPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `NetworkPolicy` resources in a specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NetworkPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNetworkPoliciesResponse, NetworkPolicy> ListNetworkPolicies(ListNetworkPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `NetworkPolicy` resources in a specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NetworkPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNetworkPoliciesResponse, NetworkPolicy> ListNetworkPoliciesAsync(ListNetworkPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `NetworkPolicy` resources in a specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location (region) to query for
        /// network policies. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names. For
        /// example: `projects/my-project/locations/us-central1`
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
        /// <returns>A pageable sequence of <see cref="NetworkPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNetworkPoliciesResponse, NetworkPolicy> ListNetworkPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNetworkPolicies(new ListNetworkPoliciesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `NetworkPolicy` resources in a specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location (region) to query for
        /// network policies. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names. For
        /// example: `projects/my-project/locations/us-central1`
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
        /// <returns>A pageable asynchronous sequence of <see cref="NetworkPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNetworkPoliciesResponse, NetworkPolicy> ListNetworkPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNetworkPoliciesAsync(new ListNetworkPoliciesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `NetworkPolicy` resources in a specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location (region) to query for
        /// network policies. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names. For
        /// example: `projects/my-project/locations/us-central1`
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
        /// <returns>A pageable sequence of <see cref="NetworkPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNetworkPoliciesResponse, NetworkPolicy> ListNetworkPolicies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNetworkPolicies(new ListNetworkPoliciesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `NetworkPolicy` resources in a specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location (region) to query for
        /// network policies. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names. For
        /// example: `projects/my-project/locations/us-central1`
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
        /// <returns>A pageable asynchronous sequence of <see cref="NetworkPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNetworkPoliciesResponse, NetworkPolicy> ListNetworkPoliciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNetworkPoliciesAsync(new ListNetworkPoliciesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Creates a new network policy in a given VMware Engine network of a
        /// project and location (region). A new network policy cannot be created if
        /// another network policy already exists in the same scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NetworkPolicy, OperationMetadata> CreateNetworkPolicy(CreateNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new network policy in a given VMware Engine network of a
        /// project and location (region). A new network policy cannot be created if
        /// another network policy already exists in the same scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NetworkPolicy, OperationMetadata>> CreateNetworkPolicyAsync(CreateNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new network policy in a given VMware Engine network of a
        /// project and location (region). A new network policy cannot be created if
        /// another network policy already exists in the same scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NetworkPolicy, OperationMetadata>> CreateNetworkPolicyAsync(CreateNetworkPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateNetworkPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateNetworkPolicy</c>.</summary>
        public virtual lro::OperationsClient CreateNetworkPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateNetworkPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<NetworkPolicy, OperationMetadata> PollOnceCreateNetworkPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<NetworkPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateNetworkPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateNetworkPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<NetworkPolicy, OperationMetadata>> PollOnceCreateNetworkPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<NetworkPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateNetworkPolicyOperationsClient, callSettings);

        /// <summary>
        /// Creates a new network policy in a given VMware Engine network of a
        /// project and location (region). A new network policy cannot be created if
        /// another network policy already exists in the same scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location (region)
        /// to create the new network policy in.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1`
        /// </param>
        /// <param name="networkPolicy">
        /// Required. The network policy configuration to use in the request.
        /// </param>
        /// <param name="networkPolicyId">
        /// Required. The user-provided identifier of the network policy to be created.
        /// This identifier must be unique within parent
        /// `projects/{my-project}/locations/{us-central1}/networkPolicies` and becomes
        /// the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NetworkPolicy, OperationMetadata> CreateNetworkPolicy(string parent, NetworkPolicy networkPolicy, string networkPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNetworkPolicy(new CreateNetworkPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NetworkPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(networkPolicyId, nameof(networkPolicyId)),
                NetworkPolicy = gax::GaxPreconditions.CheckNotNull(networkPolicy, nameof(networkPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new network policy in a given VMware Engine network of a
        /// project and location (region). A new network policy cannot be created if
        /// another network policy already exists in the same scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location (region)
        /// to create the new network policy in.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1`
        /// </param>
        /// <param name="networkPolicy">
        /// Required. The network policy configuration to use in the request.
        /// </param>
        /// <param name="networkPolicyId">
        /// Required. The user-provided identifier of the network policy to be created.
        /// This identifier must be unique within parent
        /// `projects/{my-project}/locations/{us-central1}/networkPolicies` and becomes
        /// the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NetworkPolicy, OperationMetadata>> CreateNetworkPolicyAsync(string parent, NetworkPolicy networkPolicy, string networkPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNetworkPolicyAsync(new CreateNetworkPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NetworkPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(networkPolicyId, nameof(networkPolicyId)),
                NetworkPolicy = gax::GaxPreconditions.CheckNotNull(networkPolicy, nameof(networkPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new network policy in a given VMware Engine network of a
        /// project and location (region). A new network policy cannot be created if
        /// another network policy already exists in the same scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location (region)
        /// to create the new network policy in.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1`
        /// </param>
        /// <param name="networkPolicy">
        /// Required. The network policy configuration to use in the request.
        /// </param>
        /// <param name="networkPolicyId">
        /// Required. The user-provided identifier of the network policy to be created.
        /// This identifier must be unique within parent
        /// `projects/{my-project}/locations/{us-central1}/networkPolicies` and becomes
        /// the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NetworkPolicy, OperationMetadata>> CreateNetworkPolicyAsync(string parent, NetworkPolicy networkPolicy, string networkPolicyId, st::CancellationToken cancellationToken) =>
            CreateNetworkPolicyAsync(parent, networkPolicy, networkPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new network policy in a given VMware Engine network of a
        /// project and location (region). A new network policy cannot be created if
        /// another network policy already exists in the same scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location (region)
        /// to create the new network policy in.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1`
        /// </param>
        /// <param name="networkPolicy">
        /// Required. The network policy configuration to use in the request.
        /// </param>
        /// <param name="networkPolicyId">
        /// Required. The user-provided identifier of the network policy to be created.
        /// This identifier must be unique within parent
        /// `projects/{my-project}/locations/{us-central1}/networkPolicies` and becomes
        /// the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NetworkPolicy, OperationMetadata> CreateNetworkPolicy(gagr::LocationName parent, NetworkPolicy networkPolicy, string networkPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNetworkPolicy(new CreateNetworkPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NetworkPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(networkPolicyId, nameof(networkPolicyId)),
                NetworkPolicy = gax::GaxPreconditions.CheckNotNull(networkPolicy, nameof(networkPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new network policy in a given VMware Engine network of a
        /// project and location (region). A new network policy cannot be created if
        /// another network policy already exists in the same scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location (region)
        /// to create the new network policy in.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1`
        /// </param>
        /// <param name="networkPolicy">
        /// Required. The network policy configuration to use in the request.
        /// </param>
        /// <param name="networkPolicyId">
        /// Required. The user-provided identifier of the network policy to be created.
        /// This identifier must be unique within parent
        /// `projects/{my-project}/locations/{us-central1}/networkPolicies` and becomes
        /// the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NetworkPolicy, OperationMetadata>> CreateNetworkPolicyAsync(gagr::LocationName parent, NetworkPolicy networkPolicy, string networkPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNetworkPolicyAsync(new CreateNetworkPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NetworkPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(networkPolicyId, nameof(networkPolicyId)),
                NetworkPolicy = gax::GaxPreconditions.CheckNotNull(networkPolicy, nameof(networkPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new network policy in a given VMware Engine network of a
        /// project and location (region). A new network policy cannot be created if
        /// another network policy already exists in the same scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location (region)
        /// to create the new network policy in.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1`
        /// </param>
        /// <param name="networkPolicy">
        /// Required. The network policy configuration to use in the request.
        /// </param>
        /// <param name="networkPolicyId">
        /// Required. The user-provided identifier of the network policy to be created.
        /// This identifier must be unique within parent
        /// `projects/{my-project}/locations/{us-central1}/networkPolicies` and becomes
        /// the final token in the name URI.
        /// The identifier must meet the following requirements:
        /// 
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NetworkPolicy, OperationMetadata>> CreateNetworkPolicyAsync(gagr::LocationName parent, NetworkPolicy networkPolicy, string networkPolicyId, st::CancellationToken cancellationToken) =>
            CreateNetworkPolicyAsync(parent, networkPolicy, networkPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a `NetworkPolicy` resource. Only the following fields can be
        /// updated: `internet_access`, `external_ip`, `edge_services_cidr`.
        /// Only fields specified in `updateMask` are applied. When updating a network
        /// policy, the external IP network service can only be disabled if there are
        /// no external IP addresses present in the scope of the policy. Also, a
        /// `NetworkService` cannot be updated when `NetworkService.state` is set
        /// to `RECONCILING`.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NetworkPolicy, OperationMetadata> UpdateNetworkPolicy(UpdateNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies a `NetworkPolicy` resource. Only the following fields can be
        /// updated: `internet_access`, `external_ip`, `edge_services_cidr`.
        /// Only fields specified in `updateMask` are applied. When updating a network
        /// policy, the external IP network service can only be disabled if there are
        /// no external IP addresses present in the scope of the policy. Also, a
        /// `NetworkService` cannot be updated when `NetworkService.state` is set
        /// to `RECONCILING`.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NetworkPolicy, OperationMetadata>> UpdateNetworkPolicyAsync(UpdateNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies a `NetworkPolicy` resource. Only the following fields can be
        /// updated: `internet_access`, `external_ip`, `edge_services_cidr`.
        /// Only fields specified in `updateMask` are applied. When updating a network
        /// policy, the external IP network service can only be disabled if there are
        /// no external IP addresses present in the scope of the policy. Also, a
        /// `NetworkService` cannot be updated when `NetworkService.state` is set
        /// to `RECONCILING`.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NetworkPolicy, OperationMetadata>> UpdateNetworkPolicyAsync(UpdateNetworkPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateNetworkPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateNetworkPolicy</c>.</summary>
        public virtual lro::OperationsClient UpdateNetworkPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateNetworkPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<NetworkPolicy, OperationMetadata> PollOnceUpdateNetworkPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<NetworkPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateNetworkPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateNetworkPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<NetworkPolicy, OperationMetadata>> PollOnceUpdateNetworkPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<NetworkPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateNetworkPolicyOperationsClient, callSettings);

        /// <summary>
        /// Modifies a `NetworkPolicy` resource. Only the following fields can be
        /// updated: `internet_access`, `external_ip`, `edge_services_cidr`.
        /// Only fields specified in `updateMask` are applied. When updating a network
        /// policy, the external IP network service can only be disabled if there are
        /// no external IP addresses present in the scope of the policy. Also, a
        /// `NetworkService` cannot be updated when `NetworkService.state` is set
        /// to `RECONCILING`.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="networkPolicy">
        /// Required. Network policy description.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `NetworkPolicy` resource by the update.
        /// The fields specified in the `update_mask` are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NetworkPolicy, OperationMetadata> UpdateNetworkPolicy(NetworkPolicy networkPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNetworkPolicy(new UpdateNetworkPolicyRequest
            {
                NetworkPolicy = gax::GaxPreconditions.CheckNotNull(networkPolicy, nameof(networkPolicy)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Modifies a `NetworkPolicy` resource. Only the following fields can be
        /// updated: `internet_access`, `external_ip`, `edge_services_cidr`.
        /// Only fields specified in `updateMask` are applied. When updating a network
        /// policy, the external IP network service can only be disabled if there are
        /// no external IP addresses present in the scope of the policy. Also, a
        /// `NetworkService` cannot be updated when `NetworkService.state` is set
        /// to `RECONCILING`.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="networkPolicy">
        /// Required. Network policy description.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `NetworkPolicy` resource by the update.
        /// The fields specified in the `update_mask` are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NetworkPolicy, OperationMetadata>> UpdateNetworkPolicyAsync(NetworkPolicy networkPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNetworkPolicyAsync(new UpdateNetworkPolicyRequest
            {
                NetworkPolicy = gax::GaxPreconditions.CheckNotNull(networkPolicy, nameof(networkPolicy)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Modifies a `NetworkPolicy` resource. Only the following fields can be
        /// updated: `internet_access`, `external_ip`, `edge_services_cidr`.
        /// Only fields specified in `updateMask` are applied. When updating a network
        /// policy, the external IP network service can only be disabled if there are
        /// no external IP addresses present in the scope of the policy. Also, a
        /// `NetworkService` cannot be updated when `NetworkService.state` is set
        /// to `RECONCILING`.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="networkPolicy">
        /// Required. Network policy description.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `NetworkPolicy` resource by the update.
        /// The fields specified in the `update_mask` are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NetworkPolicy, OperationMetadata>> UpdateNetworkPolicyAsync(NetworkPolicy networkPolicy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateNetworkPolicyAsync(networkPolicy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a `NetworkPolicy` resource. A network policy cannot be deleted
        /// when `NetworkService.state` is set to `RECONCILING` for either its external
        /// IP or internet access service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteNetworkPolicy(DeleteNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a `NetworkPolicy` resource. A network policy cannot be deleted
        /// when `NetworkService.state` is set to `RECONCILING` for either its external
        /// IP or internet access service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNetworkPolicyAsync(DeleteNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a `NetworkPolicy` resource. A network policy cannot be deleted
        /// when `NetworkService.state` is set to `RECONCILING` for either its external
        /// IP or internet access service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNetworkPolicyAsync(DeleteNetworkPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteNetworkPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteNetworkPolicy</c>.</summary>
        public virtual lro::OperationsClient DeleteNetworkPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteNetworkPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteNetworkPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteNetworkPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteNetworkPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteNetworkPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteNetworkPolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a `NetworkPolicy` resource. A network policy cannot be deleted
        /// when `NetworkService.state` is set to `RECONCILING` for either its external
        /// IP or internet access service.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the network policy to delete.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteNetworkPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNetworkPolicy(new DeleteNetworkPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `NetworkPolicy` resource. A network policy cannot be deleted
        /// when `NetworkService.state` is set to `RECONCILING` for either its external
        /// IP or internet access service.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the network policy to delete.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNetworkPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNetworkPolicyAsync(new DeleteNetworkPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `NetworkPolicy` resource. A network policy cannot be deleted
        /// when `NetworkService.state` is set to `RECONCILING` for either its external
        /// IP or internet access service.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the network policy to delete.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNetworkPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteNetworkPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a `NetworkPolicy` resource. A network policy cannot be deleted
        /// when `NetworkService.state` is set to `RECONCILING` for either its external
        /// IP or internet access service.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the network policy to delete.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteNetworkPolicy(NetworkPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNetworkPolicy(new DeleteNetworkPolicyRequest
            {
                NetworkPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `NetworkPolicy` resource. A network policy cannot be deleted
        /// when `NetworkService.state` is set to `RECONCILING` for either its external
        /// IP or internet access service.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the network policy to delete.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNetworkPolicyAsync(NetworkPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNetworkPolicyAsync(new DeleteNetworkPolicyRequest
            {
                NetworkPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `NetworkPolicy` resource. A network policy cannot be deleted
        /// when `NetworkService.state` is set to `RECONCILING` for either its external
        /// IP or internet access service.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the network policy to delete.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNetworkPolicyAsync(NetworkPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteNetworkPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new VMware Engine network that can be used by a private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<VmwareEngineNetwork, OperationMetadata> CreateVmwareEngineNetwork(CreateVmwareEngineNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new VMware Engine network that can be used by a private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VmwareEngineNetwork, OperationMetadata>> CreateVmwareEngineNetworkAsync(CreateVmwareEngineNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new VMware Engine network that can be used by a private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VmwareEngineNetwork, OperationMetadata>> CreateVmwareEngineNetworkAsync(CreateVmwareEngineNetworkRequest request, st::CancellationToken cancellationToken) =>
            CreateVmwareEngineNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateVmwareEngineNetwork</c>.</summary>
        public virtual lro::OperationsClient CreateVmwareEngineNetworkOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateVmwareEngineNetwork</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<VmwareEngineNetwork, OperationMetadata> PollOnceCreateVmwareEngineNetwork(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<VmwareEngineNetwork, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateVmwareEngineNetworkOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateVmwareEngineNetwork</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<VmwareEngineNetwork, OperationMetadata>> PollOnceCreateVmwareEngineNetworkAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<VmwareEngineNetwork, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateVmwareEngineNetworkOperationsClient, callSettings);

        /// <summary>
        /// Creates a new VMware Engine network that can be used by a private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create the new VMware Engine
        /// network in. A VMware Engine network of type
        /// `LEGACY` is a regional resource, and a VMware
        /// Engine network of type `STANDARD` is a global resource.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/global`
        /// </param>
        /// <param name="vmwareEngineNetwork">
        /// Required. The initial description of the new VMware Engine network.
        /// </param>
        /// <param name="vmwareEngineNetworkId">
        /// Required. The user-provided identifier of the new VMware Engine network.
        /// This identifier must be unique among VMware Engine network resources
        /// within the parent and becomes the final token in the name URI. The
        /// identifier must meet the following requirements:
        /// 
        /// * For networks of type LEGACY, adheres to the format:
        /// `{region-id}-default`. Replace `{region-id}` with the region where you want
        /// to create the VMware Engine network. For example, "us-central1-default".
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<VmwareEngineNetwork, OperationMetadata> CreateVmwareEngineNetwork(string parent, VmwareEngineNetwork vmwareEngineNetwork, string vmwareEngineNetworkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVmwareEngineNetwork(new CreateVmwareEngineNetworkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                VmwareEngineNetworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(vmwareEngineNetworkId, nameof(vmwareEngineNetworkId)),
                VmwareEngineNetwork = gax::GaxPreconditions.CheckNotNull(vmwareEngineNetwork, nameof(vmwareEngineNetwork)),
            }, callSettings);

        /// <summary>
        /// Creates a new VMware Engine network that can be used by a private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create the new VMware Engine
        /// network in. A VMware Engine network of type
        /// `LEGACY` is a regional resource, and a VMware
        /// Engine network of type `STANDARD` is a global resource.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/global`
        /// </param>
        /// <param name="vmwareEngineNetwork">
        /// Required. The initial description of the new VMware Engine network.
        /// </param>
        /// <param name="vmwareEngineNetworkId">
        /// Required. The user-provided identifier of the new VMware Engine network.
        /// This identifier must be unique among VMware Engine network resources
        /// within the parent and becomes the final token in the name URI. The
        /// identifier must meet the following requirements:
        /// 
        /// * For networks of type LEGACY, adheres to the format:
        /// `{region-id}-default`. Replace `{region-id}` with the region where you want
        /// to create the VMware Engine network. For example, "us-central1-default".
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VmwareEngineNetwork, OperationMetadata>> CreateVmwareEngineNetworkAsync(string parent, VmwareEngineNetwork vmwareEngineNetwork, string vmwareEngineNetworkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVmwareEngineNetworkAsync(new CreateVmwareEngineNetworkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                VmwareEngineNetworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(vmwareEngineNetworkId, nameof(vmwareEngineNetworkId)),
                VmwareEngineNetwork = gax::GaxPreconditions.CheckNotNull(vmwareEngineNetwork, nameof(vmwareEngineNetwork)),
            }, callSettings);

        /// <summary>
        /// Creates a new VMware Engine network that can be used by a private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create the new VMware Engine
        /// network in. A VMware Engine network of type
        /// `LEGACY` is a regional resource, and a VMware
        /// Engine network of type `STANDARD` is a global resource.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/global`
        /// </param>
        /// <param name="vmwareEngineNetwork">
        /// Required. The initial description of the new VMware Engine network.
        /// </param>
        /// <param name="vmwareEngineNetworkId">
        /// Required. The user-provided identifier of the new VMware Engine network.
        /// This identifier must be unique among VMware Engine network resources
        /// within the parent and becomes the final token in the name URI. The
        /// identifier must meet the following requirements:
        /// 
        /// * For networks of type LEGACY, adheres to the format:
        /// `{region-id}-default`. Replace `{region-id}` with the region where you want
        /// to create the VMware Engine network. For example, "us-central1-default".
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VmwareEngineNetwork, OperationMetadata>> CreateVmwareEngineNetworkAsync(string parent, VmwareEngineNetwork vmwareEngineNetwork, string vmwareEngineNetworkId, st::CancellationToken cancellationToken) =>
            CreateVmwareEngineNetworkAsync(parent, vmwareEngineNetwork, vmwareEngineNetworkId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new VMware Engine network that can be used by a private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create the new VMware Engine
        /// network in. A VMware Engine network of type
        /// `LEGACY` is a regional resource, and a VMware
        /// Engine network of type `STANDARD` is a global resource.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/global`
        /// </param>
        /// <param name="vmwareEngineNetwork">
        /// Required. The initial description of the new VMware Engine network.
        /// </param>
        /// <param name="vmwareEngineNetworkId">
        /// Required. The user-provided identifier of the new VMware Engine network.
        /// This identifier must be unique among VMware Engine network resources
        /// within the parent and becomes the final token in the name URI. The
        /// identifier must meet the following requirements:
        /// 
        /// * For networks of type LEGACY, adheres to the format:
        /// `{region-id}-default`. Replace `{region-id}` with the region where you want
        /// to create the VMware Engine network. For example, "us-central1-default".
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<VmwareEngineNetwork, OperationMetadata> CreateVmwareEngineNetwork(gagr::LocationName parent, VmwareEngineNetwork vmwareEngineNetwork, string vmwareEngineNetworkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVmwareEngineNetwork(new CreateVmwareEngineNetworkRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                VmwareEngineNetworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(vmwareEngineNetworkId, nameof(vmwareEngineNetworkId)),
                VmwareEngineNetwork = gax::GaxPreconditions.CheckNotNull(vmwareEngineNetwork, nameof(vmwareEngineNetwork)),
            }, callSettings);

        /// <summary>
        /// Creates a new VMware Engine network that can be used by a private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create the new VMware Engine
        /// network in. A VMware Engine network of type
        /// `LEGACY` is a regional resource, and a VMware
        /// Engine network of type `STANDARD` is a global resource.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/global`
        /// </param>
        /// <param name="vmwareEngineNetwork">
        /// Required. The initial description of the new VMware Engine network.
        /// </param>
        /// <param name="vmwareEngineNetworkId">
        /// Required. The user-provided identifier of the new VMware Engine network.
        /// This identifier must be unique among VMware Engine network resources
        /// within the parent and becomes the final token in the name URI. The
        /// identifier must meet the following requirements:
        /// 
        /// * For networks of type LEGACY, adheres to the format:
        /// `{region-id}-default`. Replace `{region-id}` with the region where you want
        /// to create the VMware Engine network. For example, "us-central1-default".
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VmwareEngineNetwork, OperationMetadata>> CreateVmwareEngineNetworkAsync(gagr::LocationName parent, VmwareEngineNetwork vmwareEngineNetwork, string vmwareEngineNetworkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVmwareEngineNetworkAsync(new CreateVmwareEngineNetworkRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                VmwareEngineNetworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(vmwareEngineNetworkId, nameof(vmwareEngineNetworkId)),
                VmwareEngineNetwork = gax::GaxPreconditions.CheckNotNull(vmwareEngineNetwork, nameof(vmwareEngineNetwork)),
            }, callSettings);

        /// <summary>
        /// Creates a new VMware Engine network that can be used by a private cloud.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create the new VMware Engine
        /// network in. A VMware Engine network of type
        /// `LEGACY` is a regional resource, and a VMware
        /// Engine network of type `STANDARD` is a global resource.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/global`
        /// </param>
        /// <param name="vmwareEngineNetwork">
        /// Required. The initial description of the new VMware Engine network.
        /// </param>
        /// <param name="vmwareEngineNetworkId">
        /// Required. The user-provided identifier of the new VMware Engine network.
        /// This identifier must be unique among VMware Engine network resources
        /// within the parent and becomes the final token in the name URI. The
        /// identifier must meet the following requirements:
        /// 
        /// * For networks of type LEGACY, adheres to the format:
        /// `{region-id}-default`. Replace `{region-id}` with the region where you want
        /// to create the VMware Engine network. For example, "us-central1-default".
        /// * Only contains 1-63 alphanumeric characters and hyphens
        /// * Begins with an alphabetical character
        /// * Ends with a non-hyphen character
        /// * Not formatted as a UUID
        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034)
        /// (section 3.5)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VmwareEngineNetwork, OperationMetadata>> CreateVmwareEngineNetworkAsync(gagr::LocationName parent, VmwareEngineNetwork vmwareEngineNetwork, string vmwareEngineNetworkId, st::CancellationToken cancellationToken) =>
            CreateVmwareEngineNetworkAsync(parent, vmwareEngineNetwork, vmwareEngineNetworkId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a VMware Engine network resource. Only the following fields can be
        /// updated: `description`. Only fields specified in `updateMask` are
        /// applied.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<VmwareEngineNetwork, OperationMetadata> UpdateVmwareEngineNetwork(UpdateVmwareEngineNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies a VMware Engine network resource. Only the following fields can be
        /// updated: `description`. Only fields specified in `updateMask` are
        /// applied.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VmwareEngineNetwork, OperationMetadata>> UpdateVmwareEngineNetworkAsync(UpdateVmwareEngineNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies a VMware Engine network resource. Only the following fields can be
        /// updated: `description`. Only fields specified in `updateMask` are
        /// applied.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VmwareEngineNetwork, OperationMetadata>> UpdateVmwareEngineNetworkAsync(UpdateVmwareEngineNetworkRequest request, st::CancellationToken cancellationToken) =>
            UpdateVmwareEngineNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateVmwareEngineNetwork</c>.</summary>
        public virtual lro::OperationsClient UpdateVmwareEngineNetworkOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateVmwareEngineNetwork</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<VmwareEngineNetwork, OperationMetadata> PollOnceUpdateVmwareEngineNetwork(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<VmwareEngineNetwork, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateVmwareEngineNetworkOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateVmwareEngineNetwork</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<VmwareEngineNetwork, OperationMetadata>> PollOnceUpdateVmwareEngineNetworkAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<VmwareEngineNetwork, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateVmwareEngineNetworkOperationsClient, callSettings);

        /// <summary>
        /// Modifies a VMware Engine network resource. Only the following fields can be
        /// updated: `description`. Only fields specified in `updateMask` are
        /// applied.
        /// </summary>
        /// <param name="vmwareEngineNetwork">
        /// Required. VMware Engine network description.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// VMware Engine network resource by the update.
        /// The fields specified in the `update_mask` are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten. Only the
        /// following fields can be updated: `description`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<VmwareEngineNetwork, OperationMetadata> UpdateVmwareEngineNetwork(VmwareEngineNetwork vmwareEngineNetwork, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVmwareEngineNetwork(new UpdateVmwareEngineNetworkRequest
            {
                VmwareEngineNetwork = gax::GaxPreconditions.CheckNotNull(vmwareEngineNetwork, nameof(vmwareEngineNetwork)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Modifies a VMware Engine network resource. Only the following fields can be
        /// updated: `description`. Only fields specified in `updateMask` are
        /// applied.
        /// </summary>
        /// <param name="vmwareEngineNetwork">
        /// Required. VMware Engine network description.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// VMware Engine network resource by the update.
        /// The fields specified in the `update_mask` are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten. Only the
        /// following fields can be updated: `description`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VmwareEngineNetwork, OperationMetadata>> UpdateVmwareEngineNetworkAsync(VmwareEngineNetwork vmwareEngineNetwork, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVmwareEngineNetworkAsync(new UpdateVmwareEngineNetworkRequest
            {
                VmwareEngineNetwork = gax::GaxPreconditions.CheckNotNull(vmwareEngineNetwork, nameof(vmwareEngineNetwork)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Modifies a VMware Engine network resource. Only the following fields can be
        /// updated: `description`. Only fields specified in `updateMask` are
        /// applied.
        /// </summary>
        /// <param name="vmwareEngineNetwork">
        /// Required. VMware Engine network description.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// VMware Engine network resource by the update.
        /// The fields specified in the `update_mask` are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten. Only the
        /// following fields can be updated: `description`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VmwareEngineNetwork, OperationMetadata>> UpdateVmwareEngineNetworkAsync(VmwareEngineNetwork vmwareEngineNetwork, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateVmwareEngineNetworkAsync(vmwareEngineNetwork, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a `VmwareEngineNetwork` resource. You can only delete a VMware
        /// Engine network after all resources that refer to it are deleted. For
        /// example, a private cloud, a network peering, and a network policy can all
        /// refer to the same VMware Engine network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteVmwareEngineNetwork(DeleteVmwareEngineNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a `VmwareEngineNetwork` resource. You can only delete a VMware
        /// Engine network after all resources that refer to it are deleted. For
        /// example, a private cloud, a network peering, and a network policy can all
        /// refer to the same VMware Engine network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVmwareEngineNetworkAsync(DeleteVmwareEngineNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a `VmwareEngineNetwork` resource. You can only delete a VMware
        /// Engine network after all resources that refer to it are deleted. For
        /// example, a private cloud, a network peering, and a network policy can all
        /// refer to the same VMware Engine network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVmwareEngineNetworkAsync(DeleteVmwareEngineNetworkRequest request, st::CancellationToken cancellationToken) =>
            DeleteVmwareEngineNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteVmwareEngineNetwork</c>.</summary>
        public virtual lro::OperationsClient DeleteVmwareEngineNetworkOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteVmwareEngineNetwork</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteVmwareEngineNetwork(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteVmwareEngineNetworkOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteVmwareEngineNetwork</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteVmwareEngineNetworkAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteVmwareEngineNetworkOperationsClient, callSettings);

        /// <summary>
        /// Deletes a `VmwareEngineNetwork` resource. You can only delete a VMware
        /// Engine network after all resources that refer to it are deleted. For
        /// example, a private cloud, a network peering, and a network policy can all
        /// refer to the same VMware Engine network.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the VMware Engine network to be deleted.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteVmwareEngineNetwork(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVmwareEngineNetwork(new DeleteVmwareEngineNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `VmwareEngineNetwork` resource. You can only delete a VMware
        /// Engine network after all resources that refer to it are deleted. For
        /// example, a private cloud, a network peering, and a network policy can all
        /// refer to the same VMware Engine network.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the VMware Engine network to be deleted.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVmwareEngineNetworkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVmwareEngineNetworkAsync(new DeleteVmwareEngineNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `VmwareEngineNetwork` resource. You can only delete a VMware
        /// Engine network after all resources that refer to it are deleted. For
        /// example, a private cloud, a network peering, and a network policy can all
        /// refer to the same VMware Engine network.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the VMware Engine network to be deleted.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVmwareEngineNetworkAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteVmwareEngineNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a `VmwareEngineNetwork` resource. You can only delete a VMware
        /// Engine network after all resources that refer to it are deleted. For
        /// example, a private cloud, a network peering, and a network policy can all
        /// refer to the same VMware Engine network.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the VMware Engine network to be deleted.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteVmwareEngineNetwork(VmwareEngineNetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVmwareEngineNetwork(new DeleteVmwareEngineNetworkRequest
            {
                VmwareEngineNetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `VmwareEngineNetwork` resource. You can only delete a VMware
        /// Engine network after all resources that refer to it are deleted. For
        /// example, a private cloud, a network peering, and a network policy can all
        /// refer to the same VMware Engine network.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the VMware Engine network to be deleted.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVmwareEngineNetworkAsync(VmwareEngineNetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVmwareEngineNetworkAsync(new DeleteVmwareEngineNetworkRequest
            {
                VmwareEngineNetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `VmwareEngineNetwork` resource. You can only delete a VMware
        /// Engine network after all resources that refer to it are deleted. For
        /// example, a private cloud, a network peering, and a network policy can all
        /// refer to the same VMware Engine network.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the VMware Engine network to be deleted.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVmwareEngineNetworkAsync(VmwareEngineNetworkName name, st::CancellationToken cancellationToken) =>
            DeleteVmwareEngineNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `VmwareEngineNetwork` resource by its resource name. The
        /// resource contains details of the VMware Engine network, such as its VMware
        /// Engine network type, peered networks in a service project, and state
        /// (for example, `CREATING`, `ACTIVE`, `DELETING`).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VmwareEngineNetwork GetVmwareEngineNetwork(GetVmwareEngineNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `VmwareEngineNetwork` resource by its resource name. The
        /// resource contains details of the VMware Engine network, such as its VMware
        /// Engine network type, peered networks in a service project, and state
        /// (for example, `CREATING`, `ACTIVE`, `DELETING`).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VmwareEngineNetwork> GetVmwareEngineNetworkAsync(GetVmwareEngineNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `VmwareEngineNetwork` resource by its resource name. The
        /// resource contains details of the VMware Engine network, such as its VMware
        /// Engine network type, peered networks in a service project, and state
        /// (for example, `CREATING`, `ACTIVE`, `DELETING`).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VmwareEngineNetwork> GetVmwareEngineNetworkAsync(GetVmwareEngineNetworkRequest request, st::CancellationToken cancellationToken) =>
            GetVmwareEngineNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `VmwareEngineNetwork` resource by its resource name. The
        /// resource contains details of the VMware Engine network, such as its VMware
        /// Engine network type, peered networks in a service project, and state
        /// (for example, `CREATING`, `ACTIVE`, `DELETING`).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the VMware Engine network to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VmwareEngineNetwork GetVmwareEngineNetwork(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVmwareEngineNetwork(new GetVmwareEngineNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `VmwareEngineNetwork` resource by its resource name. The
        /// resource contains details of the VMware Engine network, such as its VMware
        /// Engine network type, peered networks in a service project, and state
        /// (for example, `CREATING`, `ACTIVE`, `DELETING`).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the VMware Engine network to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VmwareEngineNetwork> GetVmwareEngineNetworkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVmwareEngineNetworkAsync(new GetVmwareEngineNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `VmwareEngineNetwork` resource by its resource name. The
        /// resource contains details of the VMware Engine network, such as its VMware
        /// Engine network type, peered networks in a service project, and state
        /// (for example, `CREATING`, `ACTIVE`, `DELETING`).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the VMware Engine network to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VmwareEngineNetwork> GetVmwareEngineNetworkAsync(string name, st::CancellationToken cancellationToken) =>
            GetVmwareEngineNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `VmwareEngineNetwork` resource by its resource name. The
        /// resource contains details of the VMware Engine network, such as its VMware
        /// Engine network type, peered networks in a service project, and state
        /// (for example, `CREATING`, `ACTIVE`, `DELETING`).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the VMware Engine network to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VmwareEngineNetwork GetVmwareEngineNetwork(VmwareEngineNetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVmwareEngineNetwork(new GetVmwareEngineNetworkRequest
            {
                VmwareEngineNetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `VmwareEngineNetwork` resource by its resource name. The
        /// resource contains details of the VMware Engine network, such as its VMware
        /// Engine network type, peered networks in a service project, and state
        /// (for example, `CREATING`, `ACTIVE`, `DELETING`).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the VMware Engine network to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VmwareEngineNetwork> GetVmwareEngineNetworkAsync(VmwareEngineNetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVmwareEngineNetworkAsync(new GetVmwareEngineNetworkRequest
            {
                VmwareEngineNetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `VmwareEngineNetwork` resource by its resource name. The
        /// resource contains details of the VMware Engine network, such as its VMware
        /// Engine network type, peered networks in a service project, and state
        /// (for example, `CREATING`, `ACTIVE`, `DELETING`).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the VMware Engine network to retrieve.
        /// Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names.
        /// For example:
        /// `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VmwareEngineNetwork> GetVmwareEngineNetworkAsync(VmwareEngineNetworkName name, st::CancellationToken cancellationToken) =>
            GetVmwareEngineNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `VmwareEngineNetwork` resources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VmwareEngineNetwork"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVmwareEngineNetworksResponse, VmwareEngineNetwork> ListVmwareEngineNetworks(ListVmwareEngineNetworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `VmwareEngineNetwork` resources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VmwareEngineNetwork"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVmwareEngineNetworksResponse, VmwareEngineNetwork> ListVmwareEngineNetworksAsync(ListVmwareEngineNetworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `VmwareEngineNetwork` resources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to query for
        /// VMware Engine networks. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names. For
        /// example: `projects/my-project/locations/global`
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
        /// <returns>A pageable sequence of <see cref="VmwareEngineNetwork"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVmwareEngineNetworksResponse, VmwareEngineNetwork> ListVmwareEngineNetworks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVmwareEngineNetworks(new ListVmwareEngineNetworksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `VmwareEngineNetwork` resources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to query for
        /// VMware Engine networks. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names. For
        /// example: `projects/my-project/locations/global`
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
        /// <returns>A pageable asynchronous sequence of <see cref="VmwareEngineNetwork"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVmwareEngineNetworksResponse, VmwareEngineNetwork> ListVmwareEngineNetworksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVmwareEngineNetworksAsync(new ListVmwareEngineNetworksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `VmwareEngineNetwork` resources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to query for
        /// VMware Engine networks. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names. For
        /// example: `projects/my-project/locations/global`
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
        /// <returns>A pageable sequence of <see cref="VmwareEngineNetwork"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVmwareEngineNetworksResponse, VmwareEngineNetwork> ListVmwareEngineNetworks(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVmwareEngineNetworks(new ListVmwareEngineNetworksRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `VmwareEngineNetwork` resources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to query for
        /// VMware Engine networks. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names. For
        /// example: `projects/my-project/locations/global`
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
        /// <returns>A pageable asynchronous sequence of <see cref="VmwareEngineNetwork"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVmwareEngineNetworksResponse, VmwareEngineNetwork> ListVmwareEngineNetworksAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVmwareEngineNetworksAsync(new ListVmwareEngineNetworksRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>VmwareEngine client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// VMwareEngine manages VMware's private clusters in the Cloud.
    /// </remarks>
    public sealed partial class VmwareEngineClientImpl : VmwareEngineClient
    {
        private readonly gaxgrpc::ApiCall<ListPrivateCloudsRequest, ListPrivateCloudsResponse> _callListPrivateClouds;

        private readonly gaxgrpc::ApiCall<GetPrivateCloudRequest, PrivateCloud> _callGetPrivateCloud;

        private readonly gaxgrpc::ApiCall<CreatePrivateCloudRequest, lro::Operation> _callCreatePrivateCloud;

        private readonly gaxgrpc::ApiCall<UpdatePrivateCloudRequest, lro::Operation> _callUpdatePrivateCloud;

        private readonly gaxgrpc::ApiCall<DeletePrivateCloudRequest, lro::Operation> _callDeletePrivateCloud;

        private readonly gaxgrpc::ApiCall<UndeletePrivateCloudRequest, lro::Operation> _callUndeletePrivateCloud;

        private readonly gaxgrpc::ApiCall<ListClustersRequest, ListClustersResponse> _callListClusters;

        private readonly gaxgrpc::ApiCall<GetClusterRequest, Cluster> _callGetCluster;

        private readonly gaxgrpc::ApiCall<CreateClusterRequest, lro::Operation> _callCreateCluster;

        private readonly gaxgrpc::ApiCall<UpdateClusterRequest, lro::Operation> _callUpdateCluster;

        private readonly gaxgrpc::ApiCall<DeleteClusterRequest, lro::Operation> _callDeleteCluster;

        private readonly gaxgrpc::ApiCall<ListSubnetsRequest, ListSubnetsResponse> _callListSubnets;

        private readonly gaxgrpc::ApiCall<ListNodeTypesRequest, ListNodeTypesResponse> _callListNodeTypes;

        private readonly gaxgrpc::ApiCall<GetNodeTypeRequest, NodeType> _callGetNodeType;

        private readonly gaxgrpc::ApiCall<ShowNsxCredentialsRequest, Credentials> _callShowNsxCredentials;

        private readonly gaxgrpc::ApiCall<ShowVcenterCredentialsRequest, Credentials> _callShowVcenterCredentials;

        private readonly gaxgrpc::ApiCall<ResetNsxCredentialsRequest, lro::Operation> _callResetNsxCredentials;

        private readonly gaxgrpc::ApiCall<ResetVcenterCredentialsRequest, lro::Operation> _callResetVcenterCredentials;

        private readonly gaxgrpc::ApiCall<CreateHcxActivationKeyRequest, lro::Operation> _callCreateHcxActivationKey;

        private readonly gaxgrpc::ApiCall<ListHcxActivationKeysRequest, ListHcxActivationKeysResponse> _callListHcxActivationKeys;

        private readonly gaxgrpc::ApiCall<GetHcxActivationKeyRequest, HcxActivationKey> _callGetHcxActivationKey;

        private readonly gaxgrpc::ApiCall<GetNetworkPolicyRequest, NetworkPolicy> _callGetNetworkPolicy;

        private readonly gaxgrpc::ApiCall<ListNetworkPoliciesRequest, ListNetworkPoliciesResponse> _callListNetworkPolicies;

        private readonly gaxgrpc::ApiCall<CreateNetworkPolicyRequest, lro::Operation> _callCreateNetworkPolicy;

        private readonly gaxgrpc::ApiCall<UpdateNetworkPolicyRequest, lro::Operation> _callUpdateNetworkPolicy;

        private readonly gaxgrpc::ApiCall<DeleteNetworkPolicyRequest, lro::Operation> _callDeleteNetworkPolicy;

        private readonly gaxgrpc::ApiCall<CreateVmwareEngineNetworkRequest, lro::Operation> _callCreateVmwareEngineNetwork;

        private readonly gaxgrpc::ApiCall<UpdateVmwareEngineNetworkRequest, lro::Operation> _callUpdateVmwareEngineNetwork;

        private readonly gaxgrpc::ApiCall<DeleteVmwareEngineNetworkRequest, lro::Operation> _callDeleteVmwareEngineNetwork;

        private readonly gaxgrpc::ApiCall<GetVmwareEngineNetworkRequest, VmwareEngineNetwork> _callGetVmwareEngineNetwork;

        private readonly gaxgrpc::ApiCall<ListVmwareEngineNetworksRequest, ListVmwareEngineNetworksResponse> _callListVmwareEngineNetworks;

        /// <summary>
        /// Constructs a client wrapper for the VmwareEngine service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="VmwareEngineSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public VmwareEngineClientImpl(VmwareEngine.VmwareEngineClient grpcClient, VmwareEngineSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            VmwareEngineSettings effectiveSettings = settings ?? VmwareEngineSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            CreatePrivateCloudOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreatePrivateCloudOperationsSettings, logger);
            UpdatePrivateCloudOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdatePrivateCloudOperationsSettings, logger);
            DeletePrivateCloudOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeletePrivateCloudOperationsSettings, logger);
            UndeletePrivateCloudOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeletePrivateCloudOperationsSettings, logger);
            CreateClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateClusterOperationsSettings, logger);
            UpdateClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateClusterOperationsSettings, logger);
            DeleteClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteClusterOperationsSettings, logger);
            ResetNsxCredentialsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ResetNsxCredentialsOperationsSettings, logger);
            ResetVcenterCredentialsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ResetVcenterCredentialsOperationsSettings, logger);
            CreateHcxActivationKeyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateHcxActivationKeyOperationsSettings, logger);
            CreateNetworkPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateNetworkPolicyOperationsSettings, logger);
            UpdateNetworkPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateNetworkPolicyOperationsSettings, logger);
            DeleteNetworkPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteNetworkPolicyOperationsSettings, logger);
            CreateVmwareEngineNetworkOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateVmwareEngineNetworkOperationsSettings, logger);
            UpdateVmwareEngineNetworkOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateVmwareEngineNetworkOperationsSettings, logger);
            DeleteVmwareEngineNetworkOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteVmwareEngineNetworkOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListPrivateClouds = clientHelper.BuildApiCall<ListPrivateCloudsRequest, ListPrivateCloudsResponse>("ListPrivateClouds", grpcClient.ListPrivateCloudsAsync, grpcClient.ListPrivateClouds, effectiveSettings.ListPrivateCloudsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPrivateClouds);
            Modify_ListPrivateCloudsApiCall(ref _callListPrivateClouds);
            _callGetPrivateCloud = clientHelper.BuildApiCall<GetPrivateCloudRequest, PrivateCloud>("GetPrivateCloud", grpcClient.GetPrivateCloudAsync, grpcClient.GetPrivateCloud, effectiveSettings.GetPrivateCloudSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPrivateCloud);
            Modify_GetPrivateCloudApiCall(ref _callGetPrivateCloud);
            _callCreatePrivateCloud = clientHelper.BuildApiCall<CreatePrivateCloudRequest, lro::Operation>("CreatePrivateCloud", grpcClient.CreatePrivateCloudAsync, grpcClient.CreatePrivateCloud, effectiveSettings.CreatePrivateCloudSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePrivateCloud);
            Modify_CreatePrivateCloudApiCall(ref _callCreatePrivateCloud);
            _callUpdatePrivateCloud = clientHelper.BuildApiCall<UpdatePrivateCloudRequest, lro::Operation>("UpdatePrivateCloud", grpcClient.UpdatePrivateCloudAsync, grpcClient.UpdatePrivateCloud, effectiveSettings.UpdatePrivateCloudSettings).WithGoogleRequestParam("private_cloud.name", request => request.PrivateCloud?.Name);
            Modify_ApiCall(ref _callUpdatePrivateCloud);
            Modify_UpdatePrivateCloudApiCall(ref _callUpdatePrivateCloud);
            _callDeletePrivateCloud = clientHelper.BuildApiCall<DeletePrivateCloudRequest, lro::Operation>("DeletePrivateCloud", grpcClient.DeletePrivateCloudAsync, grpcClient.DeletePrivateCloud, effectiveSettings.DeletePrivateCloudSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePrivateCloud);
            Modify_DeletePrivateCloudApiCall(ref _callDeletePrivateCloud);
            _callUndeletePrivateCloud = clientHelper.BuildApiCall<UndeletePrivateCloudRequest, lro::Operation>("UndeletePrivateCloud", grpcClient.UndeletePrivateCloudAsync, grpcClient.UndeletePrivateCloud, effectiveSettings.UndeletePrivateCloudSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeletePrivateCloud);
            Modify_UndeletePrivateCloudApiCall(ref _callUndeletePrivateCloud);
            _callListClusters = clientHelper.BuildApiCall<ListClustersRequest, ListClustersResponse>("ListClusters", grpcClient.ListClustersAsync, grpcClient.ListClusters, effectiveSettings.ListClustersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListClusters);
            Modify_ListClustersApiCall(ref _callListClusters);
            _callGetCluster = clientHelper.BuildApiCall<GetClusterRequest, Cluster>("GetCluster", grpcClient.GetClusterAsync, grpcClient.GetCluster, effectiveSettings.GetClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCluster);
            Modify_GetClusterApiCall(ref _callGetCluster);
            _callCreateCluster = clientHelper.BuildApiCall<CreateClusterRequest, lro::Operation>("CreateCluster", grpcClient.CreateClusterAsync, grpcClient.CreateCluster, effectiveSettings.CreateClusterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCluster);
            Modify_CreateClusterApiCall(ref _callCreateCluster);
            _callUpdateCluster = clientHelper.BuildApiCall<UpdateClusterRequest, lro::Operation>("UpdateCluster", grpcClient.UpdateClusterAsync, grpcClient.UpdateCluster, effectiveSettings.UpdateClusterSettings).WithGoogleRequestParam("cluster.name", request => request.Cluster?.Name);
            Modify_ApiCall(ref _callUpdateCluster);
            Modify_UpdateClusterApiCall(ref _callUpdateCluster);
            _callDeleteCluster = clientHelper.BuildApiCall<DeleteClusterRequest, lro::Operation>("DeleteCluster", grpcClient.DeleteClusterAsync, grpcClient.DeleteCluster, effectiveSettings.DeleteClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCluster);
            Modify_DeleteClusterApiCall(ref _callDeleteCluster);
            _callListSubnets = clientHelper.BuildApiCall<ListSubnetsRequest, ListSubnetsResponse>("ListSubnets", grpcClient.ListSubnetsAsync, grpcClient.ListSubnets, effectiveSettings.ListSubnetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSubnets);
            Modify_ListSubnetsApiCall(ref _callListSubnets);
            _callListNodeTypes = clientHelper.BuildApiCall<ListNodeTypesRequest, ListNodeTypesResponse>("ListNodeTypes", grpcClient.ListNodeTypesAsync, grpcClient.ListNodeTypes, effectiveSettings.ListNodeTypesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNodeTypes);
            Modify_ListNodeTypesApiCall(ref _callListNodeTypes);
            _callGetNodeType = clientHelper.BuildApiCall<GetNodeTypeRequest, NodeType>("GetNodeType", grpcClient.GetNodeTypeAsync, grpcClient.GetNodeType, effectiveSettings.GetNodeTypeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNodeType);
            Modify_GetNodeTypeApiCall(ref _callGetNodeType);
            _callShowNsxCredentials = clientHelper.BuildApiCall<ShowNsxCredentialsRequest, Credentials>("ShowNsxCredentials", grpcClient.ShowNsxCredentialsAsync, grpcClient.ShowNsxCredentials, effectiveSettings.ShowNsxCredentialsSettings).WithGoogleRequestParam("private_cloud", request => request.PrivateCloud);
            Modify_ApiCall(ref _callShowNsxCredentials);
            Modify_ShowNsxCredentialsApiCall(ref _callShowNsxCredentials);
            _callShowVcenterCredentials = clientHelper.BuildApiCall<ShowVcenterCredentialsRequest, Credentials>("ShowVcenterCredentials", grpcClient.ShowVcenterCredentialsAsync, grpcClient.ShowVcenterCredentials, effectiveSettings.ShowVcenterCredentialsSettings).WithGoogleRequestParam("private_cloud", request => request.PrivateCloud);
            Modify_ApiCall(ref _callShowVcenterCredentials);
            Modify_ShowVcenterCredentialsApiCall(ref _callShowVcenterCredentials);
            _callResetNsxCredentials = clientHelper.BuildApiCall<ResetNsxCredentialsRequest, lro::Operation>("ResetNsxCredentials", grpcClient.ResetNsxCredentialsAsync, grpcClient.ResetNsxCredentials, effectiveSettings.ResetNsxCredentialsSettings).WithGoogleRequestParam("private_cloud", request => request.PrivateCloud);
            Modify_ApiCall(ref _callResetNsxCredentials);
            Modify_ResetNsxCredentialsApiCall(ref _callResetNsxCredentials);
            _callResetVcenterCredentials = clientHelper.BuildApiCall<ResetVcenterCredentialsRequest, lro::Operation>("ResetVcenterCredentials", grpcClient.ResetVcenterCredentialsAsync, grpcClient.ResetVcenterCredentials, effectiveSettings.ResetVcenterCredentialsSettings).WithGoogleRequestParam("private_cloud", request => request.PrivateCloud);
            Modify_ApiCall(ref _callResetVcenterCredentials);
            Modify_ResetVcenterCredentialsApiCall(ref _callResetVcenterCredentials);
            _callCreateHcxActivationKey = clientHelper.BuildApiCall<CreateHcxActivationKeyRequest, lro::Operation>("CreateHcxActivationKey", grpcClient.CreateHcxActivationKeyAsync, grpcClient.CreateHcxActivationKey, effectiveSettings.CreateHcxActivationKeySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateHcxActivationKey);
            Modify_CreateHcxActivationKeyApiCall(ref _callCreateHcxActivationKey);
            _callListHcxActivationKeys = clientHelper.BuildApiCall<ListHcxActivationKeysRequest, ListHcxActivationKeysResponse>("ListHcxActivationKeys", grpcClient.ListHcxActivationKeysAsync, grpcClient.ListHcxActivationKeys, effectiveSettings.ListHcxActivationKeysSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListHcxActivationKeys);
            Modify_ListHcxActivationKeysApiCall(ref _callListHcxActivationKeys);
            _callGetHcxActivationKey = clientHelper.BuildApiCall<GetHcxActivationKeyRequest, HcxActivationKey>("GetHcxActivationKey", grpcClient.GetHcxActivationKeyAsync, grpcClient.GetHcxActivationKey, effectiveSettings.GetHcxActivationKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetHcxActivationKey);
            Modify_GetHcxActivationKeyApiCall(ref _callGetHcxActivationKey);
            _callGetNetworkPolicy = clientHelper.BuildApiCall<GetNetworkPolicyRequest, NetworkPolicy>("GetNetworkPolicy", grpcClient.GetNetworkPolicyAsync, grpcClient.GetNetworkPolicy, effectiveSettings.GetNetworkPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNetworkPolicy);
            Modify_GetNetworkPolicyApiCall(ref _callGetNetworkPolicy);
            _callListNetworkPolicies = clientHelper.BuildApiCall<ListNetworkPoliciesRequest, ListNetworkPoliciesResponse>("ListNetworkPolicies", grpcClient.ListNetworkPoliciesAsync, grpcClient.ListNetworkPolicies, effectiveSettings.ListNetworkPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNetworkPolicies);
            Modify_ListNetworkPoliciesApiCall(ref _callListNetworkPolicies);
            _callCreateNetworkPolicy = clientHelper.BuildApiCall<CreateNetworkPolicyRequest, lro::Operation>("CreateNetworkPolicy", grpcClient.CreateNetworkPolicyAsync, grpcClient.CreateNetworkPolicy, effectiveSettings.CreateNetworkPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateNetworkPolicy);
            Modify_CreateNetworkPolicyApiCall(ref _callCreateNetworkPolicy);
            _callUpdateNetworkPolicy = clientHelper.BuildApiCall<UpdateNetworkPolicyRequest, lro::Operation>("UpdateNetworkPolicy", grpcClient.UpdateNetworkPolicyAsync, grpcClient.UpdateNetworkPolicy, effectiveSettings.UpdateNetworkPolicySettings).WithGoogleRequestParam("network_policy.name", request => request.NetworkPolicy?.Name);
            Modify_ApiCall(ref _callUpdateNetworkPolicy);
            Modify_UpdateNetworkPolicyApiCall(ref _callUpdateNetworkPolicy);
            _callDeleteNetworkPolicy = clientHelper.BuildApiCall<DeleteNetworkPolicyRequest, lro::Operation>("DeleteNetworkPolicy", grpcClient.DeleteNetworkPolicyAsync, grpcClient.DeleteNetworkPolicy, effectiveSettings.DeleteNetworkPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteNetworkPolicy);
            Modify_DeleteNetworkPolicyApiCall(ref _callDeleteNetworkPolicy);
            _callCreateVmwareEngineNetwork = clientHelper.BuildApiCall<CreateVmwareEngineNetworkRequest, lro::Operation>("CreateVmwareEngineNetwork", grpcClient.CreateVmwareEngineNetworkAsync, grpcClient.CreateVmwareEngineNetwork, effectiveSettings.CreateVmwareEngineNetworkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateVmwareEngineNetwork);
            Modify_CreateVmwareEngineNetworkApiCall(ref _callCreateVmwareEngineNetwork);
            _callUpdateVmwareEngineNetwork = clientHelper.BuildApiCall<UpdateVmwareEngineNetworkRequest, lro::Operation>("UpdateVmwareEngineNetwork", grpcClient.UpdateVmwareEngineNetworkAsync, grpcClient.UpdateVmwareEngineNetwork, effectiveSettings.UpdateVmwareEngineNetworkSettings).WithGoogleRequestParam("vmware_engine_network.name", request => request.VmwareEngineNetwork?.Name);
            Modify_ApiCall(ref _callUpdateVmwareEngineNetwork);
            Modify_UpdateVmwareEngineNetworkApiCall(ref _callUpdateVmwareEngineNetwork);
            _callDeleteVmwareEngineNetwork = clientHelper.BuildApiCall<DeleteVmwareEngineNetworkRequest, lro::Operation>("DeleteVmwareEngineNetwork", grpcClient.DeleteVmwareEngineNetworkAsync, grpcClient.DeleteVmwareEngineNetwork, effectiveSettings.DeleteVmwareEngineNetworkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteVmwareEngineNetwork);
            Modify_DeleteVmwareEngineNetworkApiCall(ref _callDeleteVmwareEngineNetwork);
            _callGetVmwareEngineNetwork = clientHelper.BuildApiCall<GetVmwareEngineNetworkRequest, VmwareEngineNetwork>("GetVmwareEngineNetwork", grpcClient.GetVmwareEngineNetworkAsync, grpcClient.GetVmwareEngineNetwork, effectiveSettings.GetVmwareEngineNetworkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVmwareEngineNetwork);
            Modify_GetVmwareEngineNetworkApiCall(ref _callGetVmwareEngineNetwork);
            _callListVmwareEngineNetworks = clientHelper.BuildApiCall<ListVmwareEngineNetworksRequest, ListVmwareEngineNetworksResponse>("ListVmwareEngineNetworks", grpcClient.ListVmwareEngineNetworksAsync, grpcClient.ListVmwareEngineNetworks, effectiveSettings.ListVmwareEngineNetworksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVmwareEngineNetworks);
            Modify_ListVmwareEngineNetworksApiCall(ref _callListVmwareEngineNetworks);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListPrivateCloudsApiCall(ref gaxgrpc::ApiCall<ListPrivateCloudsRequest, ListPrivateCloudsResponse> call);

        partial void Modify_GetPrivateCloudApiCall(ref gaxgrpc::ApiCall<GetPrivateCloudRequest, PrivateCloud> call);

        partial void Modify_CreatePrivateCloudApiCall(ref gaxgrpc::ApiCall<CreatePrivateCloudRequest, lro::Operation> call);

        partial void Modify_UpdatePrivateCloudApiCall(ref gaxgrpc::ApiCall<UpdatePrivateCloudRequest, lro::Operation> call);

        partial void Modify_DeletePrivateCloudApiCall(ref gaxgrpc::ApiCall<DeletePrivateCloudRequest, lro::Operation> call);

        partial void Modify_UndeletePrivateCloudApiCall(ref gaxgrpc::ApiCall<UndeletePrivateCloudRequest, lro::Operation> call);

        partial void Modify_ListClustersApiCall(ref gaxgrpc::ApiCall<ListClustersRequest, ListClustersResponse> call);

        partial void Modify_GetClusterApiCall(ref gaxgrpc::ApiCall<GetClusterRequest, Cluster> call);

        partial void Modify_CreateClusterApiCall(ref gaxgrpc::ApiCall<CreateClusterRequest, lro::Operation> call);

        partial void Modify_UpdateClusterApiCall(ref gaxgrpc::ApiCall<UpdateClusterRequest, lro::Operation> call);

        partial void Modify_DeleteClusterApiCall(ref gaxgrpc::ApiCall<DeleteClusterRequest, lro::Operation> call);

        partial void Modify_ListSubnetsApiCall(ref gaxgrpc::ApiCall<ListSubnetsRequest, ListSubnetsResponse> call);

        partial void Modify_ListNodeTypesApiCall(ref gaxgrpc::ApiCall<ListNodeTypesRequest, ListNodeTypesResponse> call);

        partial void Modify_GetNodeTypeApiCall(ref gaxgrpc::ApiCall<GetNodeTypeRequest, NodeType> call);

        partial void Modify_ShowNsxCredentialsApiCall(ref gaxgrpc::ApiCall<ShowNsxCredentialsRequest, Credentials> call);

        partial void Modify_ShowVcenterCredentialsApiCall(ref gaxgrpc::ApiCall<ShowVcenterCredentialsRequest, Credentials> call);

        partial void Modify_ResetNsxCredentialsApiCall(ref gaxgrpc::ApiCall<ResetNsxCredentialsRequest, lro::Operation> call);

        partial void Modify_ResetVcenterCredentialsApiCall(ref gaxgrpc::ApiCall<ResetVcenterCredentialsRequest, lro::Operation> call);

        partial void Modify_CreateHcxActivationKeyApiCall(ref gaxgrpc::ApiCall<CreateHcxActivationKeyRequest, lro::Operation> call);

        partial void Modify_ListHcxActivationKeysApiCall(ref gaxgrpc::ApiCall<ListHcxActivationKeysRequest, ListHcxActivationKeysResponse> call);

        partial void Modify_GetHcxActivationKeyApiCall(ref gaxgrpc::ApiCall<GetHcxActivationKeyRequest, HcxActivationKey> call);

        partial void Modify_GetNetworkPolicyApiCall(ref gaxgrpc::ApiCall<GetNetworkPolicyRequest, NetworkPolicy> call);

        partial void Modify_ListNetworkPoliciesApiCall(ref gaxgrpc::ApiCall<ListNetworkPoliciesRequest, ListNetworkPoliciesResponse> call);

        partial void Modify_CreateNetworkPolicyApiCall(ref gaxgrpc::ApiCall<CreateNetworkPolicyRequest, lro::Operation> call);

        partial void Modify_UpdateNetworkPolicyApiCall(ref gaxgrpc::ApiCall<UpdateNetworkPolicyRequest, lro::Operation> call);

        partial void Modify_DeleteNetworkPolicyApiCall(ref gaxgrpc::ApiCall<DeleteNetworkPolicyRequest, lro::Operation> call);

        partial void Modify_CreateVmwareEngineNetworkApiCall(ref gaxgrpc::ApiCall<CreateVmwareEngineNetworkRequest, lro::Operation> call);

        partial void Modify_UpdateVmwareEngineNetworkApiCall(ref gaxgrpc::ApiCall<UpdateVmwareEngineNetworkRequest, lro::Operation> call);

        partial void Modify_DeleteVmwareEngineNetworkApiCall(ref gaxgrpc::ApiCall<DeleteVmwareEngineNetworkRequest, lro::Operation> call);

        partial void Modify_GetVmwareEngineNetworkApiCall(ref gaxgrpc::ApiCall<GetVmwareEngineNetworkRequest, VmwareEngineNetwork> call);

        partial void Modify_ListVmwareEngineNetworksApiCall(ref gaxgrpc::ApiCall<ListVmwareEngineNetworksRequest, ListVmwareEngineNetworksResponse> call);

        partial void OnConstruction(VmwareEngine.VmwareEngineClient grpcClient, VmwareEngineSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC VmwareEngine client</summary>
        public override VmwareEngine.VmwareEngineClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListPrivateCloudsRequest(ref ListPrivateCloudsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPrivateCloudRequest(ref GetPrivateCloudRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePrivateCloudRequest(ref CreatePrivateCloudRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePrivateCloudRequest(ref UpdatePrivateCloudRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePrivateCloudRequest(ref DeletePrivateCloudRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeletePrivateCloudRequest(ref UndeletePrivateCloudRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListClustersRequest(ref ListClustersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetClusterRequest(ref GetClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateClusterRequest(ref CreateClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateClusterRequest(ref UpdateClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteClusterRequest(ref DeleteClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSubnetsRequest(ref ListSubnetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNodeTypesRequest(ref ListNodeTypesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNodeTypeRequest(ref GetNodeTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ShowNsxCredentialsRequest(ref ShowNsxCredentialsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ShowVcenterCredentialsRequest(ref ShowVcenterCredentialsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResetNsxCredentialsRequest(ref ResetNsxCredentialsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResetVcenterCredentialsRequest(ref ResetVcenterCredentialsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateHcxActivationKeyRequest(ref CreateHcxActivationKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListHcxActivationKeysRequest(ref ListHcxActivationKeysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetHcxActivationKeyRequest(ref GetHcxActivationKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNetworkPolicyRequest(ref GetNetworkPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNetworkPoliciesRequest(ref ListNetworkPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateNetworkPolicyRequest(ref CreateNetworkPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateNetworkPolicyRequest(ref UpdateNetworkPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteNetworkPolicyRequest(ref DeleteNetworkPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateVmwareEngineNetworkRequest(ref CreateVmwareEngineNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateVmwareEngineNetworkRequest(ref UpdateVmwareEngineNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteVmwareEngineNetworkRequest(ref DeleteVmwareEngineNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVmwareEngineNetworkRequest(ref GetVmwareEngineNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVmwareEngineNetworksRequest(ref ListVmwareEngineNetworksRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists `PrivateCloud` resources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PrivateCloud"/> resources.</returns>
        public override gax::PagedEnumerable<ListPrivateCloudsResponse, PrivateCloud> ListPrivateClouds(ListPrivateCloudsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPrivateCloudsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPrivateCloudsRequest, ListPrivateCloudsResponse, PrivateCloud>(_callListPrivateClouds, request, callSettings);
        }

        /// <summary>
        /// Lists `PrivateCloud` resources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateCloud"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPrivateCloudsResponse, PrivateCloud> ListPrivateCloudsAsync(ListPrivateCloudsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPrivateCloudsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPrivateCloudsRequest, ListPrivateCloudsResponse, PrivateCloud>(_callListPrivateClouds, request, callSettings);
        }

        /// <summary>
        /// Retrieves a `PrivateCloud` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrivateCloud GetPrivateCloud(GetPrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPrivateCloudRequest(ref request, ref callSettings);
            return _callGetPrivateCloud.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `PrivateCloud` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrivateCloud> GetPrivateCloudAsync(GetPrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPrivateCloudRequest(ref request, ref callSettings);
            return _callGetPrivateCloud.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreatePrivateCloud</c>.</summary>
        public override lro::OperationsClient CreatePrivateCloudOperationsClient { get; }

        /// <summary>
        /// Creates a new `PrivateCloud` resource in a given project and location.
        /// Private clouds can only be created in zones, regional private clouds are
        /// not supported.
        /// 
        /// Creating a private cloud also creates a [management
        /// cluster](https://cloud.google.com/vmware-engine/docs/concepts-vmware-components)
        /// for that private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PrivateCloud, OperationMetadata> CreatePrivateCloud(CreatePrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePrivateCloudRequest(ref request, ref callSettings);
            return new lro::Operation<PrivateCloud, OperationMetadata>(_callCreatePrivateCloud.Sync(request, callSettings), CreatePrivateCloudOperationsClient);
        }

        /// <summary>
        /// Creates a new `PrivateCloud` resource in a given project and location.
        /// Private clouds can only be created in zones, regional private clouds are
        /// not supported.
        /// 
        /// Creating a private cloud also creates a [management
        /// cluster](https://cloud.google.com/vmware-engine/docs/concepts-vmware-components)
        /// for that private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> CreatePrivateCloudAsync(CreatePrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePrivateCloudRequest(ref request, ref callSettings);
            return new lro::Operation<PrivateCloud, OperationMetadata>(await _callCreatePrivateCloud.Async(request, callSettings).ConfigureAwait(false), CreatePrivateCloudOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdatePrivateCloud</c>.</summary>
        public override lro::OperationsClient UpdatePrivateCloudOperationsClient { get; }

        /// <summary>
        /// Modifies a `PrivateCloud` resource. Only the following fields can be
        /// updated: `description`.
        /// Only fields specified in `updateMask` are applied.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PrivateCloud, OperationMetadata> UpdatePrivateCloud(UpdatePrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePrivateCloudRequest(ref request, ref callSettings);
            return new lro::Operation<PrivateCloud, OperationMetadata>(_callUpdatePrivateCloud.Sync(request, callSettings), UpdatePrivateCloudOperationsClient);
        }

        /// <summary>
        /// Modifies a `PrivateCloud` resource. Only the following fields can be
        /// updated: `description`.
        /// Only fields specified in `updateMask` are applied.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> UpdatePrivateCloudAsync(UpdatePrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePrivateCloudRequest(ref request, ref callSettings);
            return new lro::Operation<PrivateCloud, OperationMetadata>(await _callUpdatePrivateCloud.Async(request, callSettings).ConfigureAwait(false), UpdatePrivateCloudOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeletePrivateCloud</c>.</summary>
        public override lro::OperationsClient DeletePrivateCloudOperationsClient { get; }

        /// <summary>
        /// Schedules a `PrivateCloud` resource for deletion.
        /// 
        /// A `PrivateCloud` resource scheduled for deletion has `PrivateCloud.state`
        /// set to `DELETED` and `expireTime` set to the time when deletion is final
        /// and can no longer be reversed. The delete operation is marked as done
        /// as soon as the `PrivateCloud` is successfully scheduled for deletion
        /// (this also applies when `delayHours` is set to zero), and the operation is
        /// not kept in pending state until `PrivateCloud` is purged.
        /// `PrivateCloud` can be restored using `UndeletePrivateCloud` method before
        /// the `expireTime` elapses. When `expireTime` is reached, deletion is final
        /// and all private cloud resources are irreversibly removed and billing stops.
        /// During the final removal process, `PrivateCloud.state` is set to `PURGING`.
        /// `PrivateCloud` can be polled using standard `GET` method for the whole
        /// period of deletion and purging. It will not be returned only
        /// when it is completely purged.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PrivateCloud, OperationMetadata> DeletePrivateCloud(DeletePrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePrivateCloudRequest(ref request, ref callSettings);
            return new lro::Operation<PrivateCloud, OperationMetadata>(_callDeletePrivateCloud.Sync(request, callSettings), DeletePrivateCloudOperationsClient);
        }

        /// <summary>
        /// Schedules a `PrivateCloud` resource for deletion.
        /// 
        /// A `PrivateCloud` resource scheduled for deletion has `PrivateCloud.state`
        /// set to `DELETED` and `expireTime` set to the time when deletion is final
        /// and can no longer be reversed. The delete operation is marked as done
        /// as soon as the `PrivateCloud` is successfully scheduled for deletion
        /// (this also applies when `delayHours` is set to zero), and the operation is
        /// not kept in pending state until `PrivateCloud` is purged.
        /// `PrivateCloud` can be restored using `UndeletePrivateCloud` method before
        /// the `expireTime` elapses. When `expireTime` is reached, deletion is final
        /// and all private cloud resources are irreversibly removed and billing stops.
        /// During the final removal process, `PrivateCloud.state` is set to `PURGING`.
        /// `PrivateCloud` can be polled using standard `GET` method for the whole
        /// period of deletion and purging. It will not be returned only
        /// when it is completely purged.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> DeletePrivateCloudAsync(DeletePrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePrivateCloudRequest(ref request, ref callSettings);
            return new lro::Operation<PrivateCloud, OperationMetadata>(await _callDeletePrivateCloud.Async(request, callSettings).ConfigureAwait(false), DeletePrivateCloudOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeletePrivateCloud</c>.</summary>
        public override lro::OperationsClient UndeletePrivateCloudOperationsClient { get; }

        /// <summary>
        /// Restores a private cloud that was previously scheduled for deletion by
        /// `DeletePrivateCloud`. A `PrivateCloud` resource scheduled for deletion has
        /// `PrivateCloud.state` set to `DELETED` and `PrivateCloud.expireTime` set to
        /// the time when deletion can no longer be reversed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PrivateCloud, OperationMetadata> UndeletePrivateCloud(UndeletePrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeletePrivateCloudRequest(ref request, ref callSettings);
            return new lro::Operation<PrivateCloud, OperationMetadata>(_callUndeletePrivateCloud.Sync(request, callSettings), UndeletePrivateCloudOperationsClient);
        }

        /// <summary>
        /// Restores a private cloud that was previously scheduled for deletion by
        /// `DeletePrivateCloud`. A `PrivateCloud` resource scheduled for deletion has
        /// `PrivateCloud.state` set to `DELETED` and `PrivateCloud.expireTime` set to
        /// the time when deletion can no longer be reversed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> UndeletePrivateCloudAsync(UndeletePrivateCloudRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeletePrivateCloudRequest(ref request, ref callSettings);
            return new lro::Operation<PrivateCloud, OperationMetadata>(await _callUndeletePrivateCloud.Async(request, callSettings).ConfigureAwait(false), UndeletePrivateCloudOperationsClient);
        }

        /// <summary>
        /// Lists `Cluster` resources in a given private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public override gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListClustersRequest, ListClustersResponse, Cluster>(_callListClusters, request, callSettings);
        }

        /// <summary>
        /// Lists `Cluster` resources in a given private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListClustersRequest, ListClustersResponse, Cluster>(_callListClusters, request, callSettings);
        }

        /// <summary>
        /// Retrieves a `Cluster` resource by its resource name.
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
        /// Retrieves a `Cluster` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateCluster</c>.</summary>
        public override lro::OperationsClient CreateClusterOperationsClient { get; }

        /// <summary>
        /// Creates a new cluster in a given private cloud.
        /// Creating a new cluster provides additional nodes for
        /// use in the parent private cloud and requires sufficient [node
        /// quota](https://cloud.google.com/vmware-engine/quotas).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, OperationMetadata> CreateCluster(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(_callCreateCluster.Sync(request, callSettings), CreateClusterOperationsClient);
        }

        /// <summary>
        /// Creates a new cluster in a given private cloud.
        /// Creating a new cluster provides additional nodes for
        /// use in the parent private cloud and requires sufficient [node
        /// quota](https://cloud.google.com/vmware-engine/quotas).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(await _callCreateCluster.Async(request, callSettings).ConfigureAwait(false), CreateClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateCluster</c>.</summary>
        public override lro::OperationsClient UpdateClusterOperationsClient { get; }

        /// <summary>
        /// Modifies a `Cluster` resource. Only the following fields can be updated:
        /// `node_type_configs.*.node_count`. Only fields specified in `updateMask` are
        /// applied.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, OperationMetadata> UpdateCluster(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(_callUpdateCluster.Sync(request, callSettings), UpdateClusterOperationsClient);
        }

        /// <summary>
        /// Modifies a `Cluster` resource. Only the following fields can be updated:
        /// `node_type_configs.*.node_count`. Only fields specified in `updateMask` are
        /// applied.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, OperationMetadata>> UpdateClusterAsync(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(await _callUpdateCluster.Async(request, callSettings).ConfigureAwait(false), UpdateClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteCluster</c>.</summary>
        public override lro::OperationsClient DeleteClusterOperationsClient { get; }

        /// <summary>
        /// Deletes a `Cluster` resource. To avoid unintended data loss, migrate or
        /// gracefully shut down any workloads running on the cluster before deletion.
        /// You cannot delete the management cluster of a private cloud using this
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteCluster(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteCluster.Sync(request, callSettings), DeleteClusterOperationsClient);
        }

        /// <summary>
        /// Deletes a `Cluster` resource. To avoid unintended data loss, migrate or
        /// gracefully shut down any workloads running on the cluster before deletion.
        /// You cannot delete the management cluster of a private cloud using this
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteCluster.Async(request, callSettings).ConfigureAwait(false), DeleteClusterOperationsClient);
        }

        /// <summary>
        /// Lists subnets in a given private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Subnet"/> resources.</returns>
        public override gax::PagedEnumerable<ListSubnetsResponse, Subnet> ListSubnets(ListSubnetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSubnetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSubnetsRequest, ListSubnetsResponse, Subnet>(_callListSubnets, request, callSettings);
        }

        /// <summary>
        /// Lists subnets in a given private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Subnet"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSubnetsResponse, Subnet> ListSubnetsAsync(ListSubnetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSubnetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSubnetsRequest, ListSubnetsResponse, Subnet>(_callListSubnets, request, callSettings);
        }

        /// <summary>
        /// Lists node types
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NodeType"/> resources.</returns>
        public override gax::PagedEnumerable<ListNodeTypesResponse, NodeType> ListNodeTypes(ListNodeTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNodeTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNodeTypesRequest, ListNodeTypesResponse, NodeType>(_callListNodeTypes, request, callSettings);
        }

        /// <summary>
        /// Lists node types
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NodeType"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNodeTypesResponse, NodeType> ListNodeTypesAsync(ListNodeTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNodeTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNodeTypesRequest, ListNodeTypesResponse, NodeType>(_callListNodeTypes, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single `NodeType`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NodeType GetNodeType(GetNodeTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNodeTypeRequest(ref request, ref callSettings);
            return _callGetNodeType.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single `NodeType`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NodeType> GetNodeTypeAsync(GetNodeTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNodeTypeRequest(ref request, ref callSettings);
            return _callGetNodeType.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details of credentials for NSX appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Credentials ShowNsxCredentials(ShowNsxCredentialsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ShowNsxCredentialsRequest(ref request, ref callSettings);
            return _callShowNsxCredentials.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of credentials for NSX appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Credentials> ShowNsxCredentialsAsync(ShowNsxCredentialsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ShowNsxCredentialsRequest(ref request, ref callSettings);
            return _callShowNsxCredentials.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details of credentials for Vcenter appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Credentials ShowVcenterCredentials(ShowVcenterCredentialsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ShowVcenterCredentialsRequest(ref request, ref callSettings);
            return _callShowVcenterCredentials.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of credentials for Vcenter appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Credentials> ShowVcenterCredentialsAsync(ShowVcenterCredentialsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ShowVcenterCredentialsRequest(ref request, ref callSettings);
            return _callShowVcenterCredentials.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ResetNsxCredentials</c>.</summary>
        public override lro::OperationsClient ResetNsxCredentialsOperationsClient { get; }

        /// <summary>
        /// Resets credentials of the NSX appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PrivateCloud, OperationMetadata> ResetNsxCredentials(ResetNsxCredentialsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetNsxCredentialsRequest(ref request, ref callSettings);
            return new lro::Operation<PrivateCloud, OperationMetadata>(_callResetNsxCredentials.Sync(request, callSettings), ResetNsxCredentialsOperationsClient);
        }

        /// <summary>
        /// Resets credentials of the NSX appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> ResetNsxCredentialsAsync(ResetNsxCredentialsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetNsxCredentialsRequest(ref request, ref callSettings);
            return new lro::Operation<PrivateCloud, OperationMetadata>(await _callResetNsxCredentials.Async(request, callSettings).ConfigureAwait(false), ResetNsxCredentialsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ResetVcenterCredentials</c>.</summary>
        public override lro::OperationsClient ResetVcenterCredentialsOperationsClient { get; }

        /// <summary>
        /// Resets credentials of the Vcenter appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PrivateCloud, OperationMetadata> ResetVcenterCredentials(ResetVcenterCredentialsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetVcenterCredentialsRequest(ref request, ref callSettings);
            return new lro::Operation<PrivateCloud, OperationMetadata>(_callResetVcenterCredentials.Sync(request, callSettings), ResetVcenterCredentialsOperationsClient);
        }

        /// <summary>
        /// Resets credentials of the Vcenter appliance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PrivateCloud, OperationMetadata>> ResetVcenterCredentialsAsync(ResetVcenterCredentialsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetVcenterCredentialsRequest(ref request, ref callSettings);
            return new lro::Operation<PrivateCloud, OperationMetadata>(await _callResetVcenterCredentials.Async(request, callSettings).ConfigureAwait(false), ResetVcenterCredentialsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateHcxActivationKey</c>.</summary>
        public override lro::OperationsClient CreateHcxActivationKeyOperationsClient { get; }

        /// <summary>
        /// Creates a new HCX activation key in a given private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<HcxActivationKey, OperationMetadata> CreateHcxActivationKey(CreateHcxActivationKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHcxActivationKeyRequest(ref request, ref callSettings);
            return new lro::Operation<HcxActivationKey, OperationMetadata>(_callCreateHcxActivationKey.Sync(request, callSettings), CreateHcxActivationKeyOperationsClient);
        }

        /// <summary>
        /// Creates a new HCX activation key in a given private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<HcxActivationKey, OperationMetadata>> CreateHcxActivationKeyAsync(CreateHcxActivationKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHcxActivationKeyRequest(ref request, ref callSettings);
            return new lro::Operation<HcxActivationKey, OperationMetadata>(await _callCreateHcxActivationKey.Async(request, callSettings).ConfigureAwait(false), CreateHcxActivationKeyOperationsClient);
        }

        /// <summary>
        /// Lists `HcxActivationKey` resources in a given private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HcxActivationKey"/> resources.</returns>
        public override gax::PagedEnumerable<ListHcxActivationKeysResponse, HcxActivationKey> ListHcxActivationKeys(ListHcxActivationKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHcxActivationKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListHcxActivationKeysRequest, ListHcxActivationKeysResponse, HcxActivationKey>(_callListHcxActivationKeys, request, callSettings);
        }

        /// <summary>
        /// Lists `HcxActivationKey` resources in a given private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HcxActivationKey"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListHcxActivationKeysResponse, HcxActivationKey> ListHcxActivationKeysAsync(ListHcxActivationKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHcxActivationKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListHcxActivationKeysRequest, ListHcxActivationKeysResponse, HcxActivationKey>(_callListHcxActivationKeys, request, callSettings);
        }

        /// <summary>
        /// Retrieves a `HcxActivationKey` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override HcxActivationKey GetHcxActivationKey(GetHcxActivationKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHcxActivationKeyRequest(ref request, ref callSettings);
            return _callGetHcxActivationKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `HcxActivationKey` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<HcxActivationKey> GetHcxActivationKeyAsync(GetHcxActivationKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHcxActivationKeyRequest(ref request, ref callSettings);
            return _callGetHcxActivationKey.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `NetworkPolicy` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NetworkPolicy GetNetworkPolicy(GetNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNetworkPolicyRequest(ref request, ref callSettings);
            return _callGetNetworkPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `NetworkPolicy` resource by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NetworkPolicy> GetNetworkPolicyAsync(GetNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNetworkPolicyRequest(ref request, ref callSettings);
            return _callGetNetworkPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `NetworkPolicy` resources in a specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NetworkPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListNetworkPoliciesResponse, NetworkPolicy> ListNetworkPolicies(ListNetworkPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNetworkPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNetworkPoliciesRequest, ListNetworkPoliciesResponse, NetworkPolicy>(_callListNetworkPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists `NetworkPolicy` resources in a specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NetworkPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNetworkPoliciesResponse, NetworkPolicy> ListNetworkPoliciesAsync(ListNetworkPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNetworkPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNetworkPoliciesRequest, ListNetworkPoliciesResponse, NetworkPolicy>(_callListNetworkPolicies, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateNetworkPolicy</c>.</summary>
        public override lro::OperationsClient CreateNetworkPolicyOperationsClient { get; }

        /// <summary>
        /// Creates a new network policy in a given VMware Engine network of a
        /// project and location (region). A new network policy cannot be created if
        /// another network policy already exists in the same scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<NetworkPolicy, OperationMetadata> CreateNetworkPolicy(CreateNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNetworkPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<NetworkPolicy, OperationMetadata>(_callCreateNetworkPolicy.Sync(request, callSettings), CreateNetworkPolicyOperationsClient);
        }

        /// <summary>
        /// Creates a new network policy in a given VMware Engine network of a
        /// project and location (region). A new network policy cannot be created if
        /// another network policy already exists in the same scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<NetworkPolicy, OperationMetadata>> CreateNetworkPolicyAsync(CreateNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNetworkPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<NetworkPolicy, OperationMetadata>(await _callCreateNetworkPolicy.Async(request, callSettings).ConfigureAwait(false), CreateNetworkPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateNetworkPolicy</c>.</summary>
        public override lro::OperationsClient UpdateNetworkPolicyOperationsClient { get; }

        /// <summary>
        /// Modifies a `NetworkPolicy` resource. Only the following fields can be
        /// updated: `internet_access`, `external_ip`, `edge_services_cidr`.
        /// Only fields specified in `updateMask` are applied. When updating a network
        /// policy, the external IP network service can only be disabled if there are
        /// no external IP addresses present in the scope of the policy. Also, a
        /// `NetworkService` cannot be updated when `NetworkService.state` is set
        /// to `RECONCILING`.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<NetworkPolicy, OperationMetadata> UpdateNetworkPolicy(UpdateNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNetworkPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<NetworkPolicy, OperationMetadata>(_callUpdateNetworkPolicy.Sync(request, callSettings), UpdateNetworkPolicyOperationsClient);
        }

        /// <summary>
        /// Modifies a `NetworkPolicy` resource. Only the following fields can be
        /// updated: `internet_access`, `external_ip`, `edge_services_cidr`.
        /// Only fields specified in `updateMask` are applied. When updating a network
        /// policy, the external IP network service can only be disabled if there are
        /// no external IP addresses present in the scope of the policy. Also, a
        /// `NetworkService` cannot be updated when `NetworkService.state` is set
        /// to `RECONCILING`.
        /// 
        /// During operation processing, the resource is temporarily in the `ACTIVE`
        /// state before the operation fully completes. For that period of time, you
        /// can't update the resource. Use the operation status to determine when the
        /// processing fully completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<NetworkPolicy, OperationMetadata>> UpdateNetworkPolicyAsync(UpdateNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNetworkPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<NetworkPolicy, OperationMetadata>(await _callUpdateNetworkPolicy.Async(request, callSettings).ConfigureAwait(false), UpdateNetworkPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteNetworkPolicy</c>.</summary>
        public override lro::OperationsClient DeleteNetworkPolicyOperationsClient { get; }

        /// <summary>
        /// Deletes a `NetworkPolicy` resource. A network policy cannot be deleted
        /// when `NetworkService.state` is set to `RECONCILING` for either its external
        /// IP or internet access service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteNetworkPolicy(DeleteNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNetworkPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteNetworkPolicy.Sync(request, callSettings), DeleteNetworkPolicyOperationsClient);
        }

        /// <summary>
        /// Deletes a `NetworkPolicy` resource. A network policy cannot be deleted
        /// when `NetworkService.state` is set to `RECONCILING` for either its external
        /// IP or internet access service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNetworkPolicyAsync(DeleteNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNetworkPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteNetworkPolicy.Async(request, callSettings).ConfigureAwait(false), DeleteNetworkPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateVmwareEngineNetwork</c>.</summary>
        public override lro::OperationsClient CreateVmwareEngineNetworkOperationsClient { get; }

        /// <summary>
        /// Creates a new VMware Engine network that can be used by a private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<VmwareEngineNetwork, OperationMetadata> CreateVmwareEngineNetwork(CreateVmwareEngineNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVmwareEngineNetworkRequest(ref request, ref callSettings);
            return new lro::Operation<VmwareEngineNetwork, OperationMetadata>(_callCreateVmwareEngineNetwork.Sync(request, callSettings), CreateVmwareEngineNetworkOperationsClient);
        }

        /// <summary>
        /// Creates a new VMware Engine network that can be used by a private cloud.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<VmwareEngineNetwork, OperationMetadata>> CreateVmwareEngineNetworkAsync(CreateVmwareEngineNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVmwareEngineNetworkRequest(ref request, ref callSettings);
            return new lro::Operation<VmwareEngineNetwork, OperationMetadata>(await _callCreateVmwareEngineNetwork.Async(request, callSettings).ConfigureAwait(false), CreateVmwareEngineNetworkOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateVmwareEngineNetwork</c>.</summary>
        public override lro::OperationsClient UpdateVmwareEngineNetworkOperationsClient { get; }

        /// <summary>
        /// Modifies a VMware Engine network resource. Only the following fields can be
        /// updated: `description`. Only fields specified in `updateMask` are
        /// applied.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<VmwareEngineNetwork, OperationMetadata> UpdateVmwareEngineNetwork(UpdateVmwareEngineNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVmwareEngineNetworkRequest(ref request, ref callSettings);
            return new lro::Operation<VmwareEngineNetwork, OperationMetadata>(_callUpdateVmwareEngineNetwork.Sync(request, callSettings), UpdateVmwareEngineNetworkOperationsClient);
        }

        /// <summary>
        /// Modifies a VMware Engine network resource. Only the following fields can be
        /// updated: `description`. Only fields specified in `updateMask` are
        /// applied.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<VmwareEngineNetwork, OperationMetadata>> UpdateVmwareEngineNetworkAsync(UpdateVmwareEngineNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVmwareEngineNetworkRequest(ref request, ref callSettings);
            return new lro::Operation<VmwareEngineNetwork, OperationMetadata>(await _callUpdateVmwareEngineNetwork.Async(request, callSettings).ConfigureAwait(false), UpdateVmwareEngineNetworkOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteVmwareEngineNetwork</c>.</summary>
        public override lro::OperationsClient DeleteVmwareEngineNetworkOperationsClient { get; }

        /// <summary>
        /// Deletes a `VmwareEngineNetwork` resource. You can only delete a VMware
        /// Engine network after all resources that refer to it are deleted. For
        /// example, a private cloud, a network peering, and a network policy can all
        /// refer to the same VMware Engine network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteVmwareEngineNetwork(DeleteVmwareEngineNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVmwareEngineNetworkRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteVmwareEngineNetwork.Sync(request, callSettings), DeleteVmwareEngineNetworkOperationsClient);
        }

        /// <summary>
        /// Deletes a `VmwareEngineNetwork` resource. You can only delete a VMware
        /// Engine network after all resources that refer to it are deleted. For
        /// example, a private cloud, a network peering, and a network policy can all
        /// refer to the same VMware Engine network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVmwareEngineNetworkAsync(DeleteVmwareEngineNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVmwareEngineNetworkRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteVmwareEngineNetwork.Async(request, callSettings).ConfigureAwait(false), DeleteVmwareEngineNetworkOperationsClient);
        }

        /// <summary>
        /// Retrieves a `VmwareEngineNetwork` resource by its resource name. The
        /// resource contains details of the VMware Engine network, such as its VMware
        /// Engine network type, peered networks in a service project, and state
        /// (for example, `CREATING`, `ACTIVE`, `DELETING`).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VmwareEngineNetwork GetVmwareEngineNetwork(GetVmwareEngineNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVmwareEngineNetworkRequest(ref request, ref callSettings);
            return _callGetVmwareEngineNetwork.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `VmwareEngineNetwork` resource by its resource name. The
        /// resource contains details of the VMware Engine network, such as its VMware
        /// Engine network type, peered networks in a service project, and state
        /// (for example, `CREATING`, `ACTIVE`, `DELETING`).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VmwareEngineNetwork> GetVmwareEngineNetworkAsync(GetVmwareEngineNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVmwareEngineNetworkRequest(ref request, ref callSettings);
            return _callGetVmwareEngineNetwork.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `VmwareEngineNetwork` resources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VmwareEngineNetwork"/> resources.</returns>
        public override gax::PagedEnumerable<ListVmwareEngineNetworksResponse, VmwareEngineNetwork> ListVmwareEngineNetworks(ListVmwareEngineNetworksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVmwareEngineNetworksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVmwareEngineNetworksRequest, ListVmwareEngineNetworksResponse, VmwareEngineNetwork>(_callListVmwareEngineNetworks, request, callSettings);
        }

        /// <summary>
        /// Lists `VmwareEngineNetwork` resources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VmwareEngineNetwork"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVmwareEngineNetworksResponse, VmwareEngineNetwork> ListVmwareEngineNetworksAsync(ListVmwareEngineNetworksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVmwareEngineNetworksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVmwareEngineNetworksRequest, ListVmwareEngineNetworksResponse, VmwareEngineNetwork>(_callListVmwareEngineNetworks, request, callSettings);
        }
    }

    public partial class ListPrivateCloudsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListClustersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSubnetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNodeTypesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListHcxActivationKeysRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNetworkPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVmwareEngineNetworksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPrivateCloudsResponse : gaxgrpc::IPageResponse<PrivateCloud>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PrivateCloud> GetEnumerator() => PrivateClouds.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListClustersResponse : gaxgrpc::IPageResponse<Cluster>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Cluster> GetEnumerator() => Clusters.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSubnetsResponse : gaxgrpc::IPageResponse<Subnet>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Subnet> GetEnumerator() => Subnets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNodeTypesResponse : gaxgrpc::IPageResponse<NodeType>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<NodeType> GetEnumerator() => NodeTypes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListHcxActivationKeysResponse : gaxgrpc::IPageResponse<HcxActivationKey>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<HcxActivationKey> GetEnumerator() => HcxActivationKeys.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNetworkPoliciesResponse : gaxgrpc::IPageResponse<NetworkPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<NetworkPolicy> GetEnumerator() => NetworkPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListVmwareEngineNetworksResponse : gaxgrpc::IPageResponse<VmwareEngineNetwork>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<VmwareEngineNetwork> GetEnumerator() => VmwareEngineNetworks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class VmwareEngine
    {
        public partial class VmwareEngineClient
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

    public static partial class VmwareEngine
    {
        public partial class VmwareEngineClient
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
