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

namespace Google.Cloud.EdgeNetwork.V1
{
    /// <summary>Settings for <see cref="EdgeNetworkClient"/> instances.</summary>
    public sealed partial class EdgeNetworkSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EdgeNetworkSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EdgeNetworkSettings"/>.</returns>
        public static EdgeNetworkSettings GetDefault() => new EdgeNetworkSettings();

        /// <summary>Constructs a new <see cref="EdgeNetworkSettings"/> object with default settings.</summary>
        public EdgeNetworkSettings()
        {
        }

        private EdgeNetworkSettings(EdgeNetworkSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            InitializeZoneSettings = existing.InitializeZoneSettings;
            ListZonesSettings = existing.ListZonesSettings;
            GetZoneSettings = existing.GetZoneSettings;
            ListNetworksSettings = existing.ListNetworksSettings;
            GetNetworkSettings = existing.GetNetworkSettings;
            DiagnoseNetworkSettings = existing.DiagnoseNetworkSettings;
            CreateNetworkSettings = existing.CreateNetworkSettings;
            CreateNetworkOperationsSettings = existing.CreateNetworkOperationsSettings.Clone();
            DeleteNetworkSettings = existing.DeleteNetworkSettings;
            DeleteNetworkOperationsSettings = existing.DeleteNetworkOperationsSettings.Clone();
            ListSubnetsSettings = existing.ListSubnetsSettings;
            GetSubnetSettings = existing.GetSubnetSettings;
            CreateSubnetSettings = existing.CreateSubnetSettings;
            CreateSubnetOperationsSettings = existing.CreateSubnetOperationsSettings.Clone();
            UpdateSubnetSettings = existing.UpdateSubnetSettings;
            UpdateSubnetOperationsSettings = existing.UpdateSubnetOperationsSettings.Clone();
            DeleteSubnetSettings = existing.DeleteSubnetSettings;
            DeleteSubnetOperationsSettings = existing.DeleteSubnetOperationsSettings.Clone();
            ListInterconnectsSettings = existing.ListInterconnectsSettings;
            GetInterconnectSettings = existing.GetInterconnectSettings;
            DiagnoseInterconnectSettings = existing.DiagnoseInterconnectSettings;
            ListInterconnectAttachmentsSettings = existing.ListInterconnectAttachmentsSettings;
            GetInterconnectAttachmentSettings = existing.GetInterconnectAttachmentSettings;
            CreateInterconnectAttachmentSettings = existing.CreateInterconnectAttachmentSettings;
            CreateInterconnectAttachmentOperationsSettings = existing.CreateInterconnectAttachmentOperationsSettings.Clone();
            DeleteInterconnectAttachmentSettings = existing.DeleteInterconnectAttachmentSettings;
            DeleteInterconnectAttachmentOperationsSettings = existing.DeleteInterconnectAttachmentOperationsSettings.Clone();
            ListRoutersSettings = existing.ListRoutersSettings;
            GetRouterSettings = existing.GetRouterSettings;
            DiagnoseRouterSettings = existing.DiagnoseRouterSettings;
            CreateRouterSettings = existing.CreateRouterSettings;
            CreateRouterOperationsSettings = existing.CreateRouterOperationsSettings.Clone();
            UpdateRouterSettings = existing.UpdateRouterSettings;
            UpdateRouterOperationsSettings = existing.UpdateRouterOperationsSettings.Clone();
            DeleteRouterSettings = existing.DeleteRouterSettings;
            DeleteRouterOperationsSettings = existing.DeleteRouterOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(EdgeNetworkSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.InitializeZone</c> and <c>EdgeNetworkClient.InitializeZoneAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InitializeZoneSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>EdgeNetworkClient.ListZones</c>
        ///  and <c>EdgeNetworkClient.ListZonesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListZonesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>EdgeNetworkClient.GetZone</c>
        ///  and <c>EdgeNetworkClient.GetZoneAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetZoneSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.ListNetworks</c> and <c>EdgeNetworkClient.ListNetworksAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNetworksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.GetNetwork</c> and <c>EdgeNetworkClient.GetNetworkAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNetworkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.DiagnoseNetwork</c> and <c>EdgeNetworkClient.DiagnoseNetworkAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DiagnoseNetworkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.CreateNetwork</c> and <c>EdgeNetworkClient.CreateNetworkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateNetworkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EdgeNetworkClient.CreateNetwork</c> and
        /// <c>EdgeNetworkClient.CreateNetworkAsync</c>.
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
        public lro::OperationsSettings CreateNetworkOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.DeleteNetwork</c> and <c>EdgeNetworkClient.DeleteNetworkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteNetworkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EdgeNetworkClient.DeleteNetwork</c> and
        /// <c>EdgeNetworkClient.DeleteNetworkAsync</c>.
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
        public lro::OperationsSettings DeleteNetworkOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.ListSubnets</c> and <c>EdgeNetworkClient.ListSubnetsAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSubnetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>EdgeNetworkClient.GetSubnet</c>
        ///  and <c>EdgeNetworkClient.GetSubnetAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSubnetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.CreateSubnet</c> and <c>EdgeNetworkClient.CreateSubnetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSubnetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EdgeNetworkClient.CreateSubnet</c> and
        /// <c>EdgeNetworkClient.CreateSubnetAsync</c>.
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
        public lro::OperationsSettings CreateSubnetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.UpdateSubnet</c> and <c>EdgeNetworkClient.UpdateSubnetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSubnetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EdgeNetworkClient.UpdateSubnet</c> and
        /// <c>EdgeNetworkClient.UpdateSubnetAsync</c>.
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
        public lro::OperationsSettings UpdateSubnetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.DeleteSubnet</c> and <c>EdgeNetworkClient.DeleteSubnetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSubnetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EdgeNetworkClient.DeleteSubnet</c> and
        /// <c>EdgeNetworkClient.DeleteSubnetAsync</c>.
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
        public lro::OperationsSettings DeleteSubnetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.ListInterconnects</c> and <c>EdgeNetworkClient.ListInterconnectsAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInterconnectsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.GetInterconnect</c> and <c>EdgeNetworkClient.GetInterconnectAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInterconnectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.DiagnoseInterconnect</c> and <c>EdgeNetworkClient.DiagnoseInterconnectAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DiagnoseInterconnectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.ListInterconnectAttachments</c> and
        /// <c>EdgeNetworkClient.ListInterconnectAttachmentsAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInterconnectAttachmentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.GetInterconnectAttachment</c> and <c>EdgeNetworkClient.GetInterconnectAttachmentAsync</c>
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInterconnectAttachmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.CreateInterconnectAttachment</c> and
        /// <c>EdgeNetworkClient.CreateInterconnectAttachmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInterconnectAttachmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EdgeNetworkClient.CreateInterconnectAttachment</c> and
        /// <c>EdgeNetworkClient.CreateInterconnectAttachmentAsync</c>.
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
        public lro::OperationsSettings CreateInterconnectAttachmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.DeleteInterconnectAttachment</c> and
        /// <c>EdgeNetworkClient.DeleteInterconnectAttachmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInterconnectAttachmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EdgeNetworkClient.DeleteInterconnectAttachment</c> and
        /// <c>EdgeNetworkClient.DeleteInterconnectAttachmentAsync</c>.
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
        public lro::OperationsSettings DeleteInterconnectAttachmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.ListRouters</c> and <c>EdgeNetworkClient.ListRoutersAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRoutersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>EdgeNetworkClient.GetRouter</c>
        ///  and <c>EdgeNetworkClient.GetRouterAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRouterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.DiagnoseRouter</c> and <c>EdgeNetworkClient.DiagnoseRouterAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DiagnoseRouterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.CreateRouter</c> and <c>EdgeNetworkClient.CreateRouterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRouterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EdgeNetworkClient.CreateRouter</c> and
        /// <c>EdgeNetworkClient.CreateRouterAsync</c>.
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
        public lro::OperationsSettings CreateRouterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.UpdateRouter</c> and <c>EdgeNetworkClient.UpdateRouterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRouterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EdgeNetworkClient.UpdateRouter</c> and
        /// <c>EdgeNetworkClient.UpdateRouterAsync</c>.
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
        public lro::OperationsSettings UpdateRouterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EdgeNetworkClient.DeleteRouter</c> and <c>EdgeNetworkClient.DeleteRouterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRouterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EdgeNetworkClient.DeleteRouter</c> and
        /// <c>EdgeNetworkClient.DeleteRouterAsync</c>.
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
        public lro::OperationsSettings DeleteRouterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EdgeNetworkSettings"/> object.</returns>
        public EdgeNetworkSettings Clone() => new EdgeNetworkSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EdgeNetworkClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class EdgeNetworkClientBuilder : gaxgrpc::ClientBuilderBase<EdgeNetworkClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EdgeNetworkSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EdgeNetworkClientBuilder() : base(EdgeNetworkClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EdgeNetworkClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EdgeNetworkClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EdgeNetworkClient Build()
        {
            EdgeNetworkClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EdgeNetworkClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EdgeNetworkClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EdgeNetworkClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EdgeNetworkClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<EdgeNetworkClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EdgeNetworkClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EdgeNetworkClient.ChannelPool;
    }

    /// <summary>EdgeNetwork client wrapper, for convenient use.</summary>
    /// <remarks>
    /// EdgeNetwork API provides managed, highly available cloud dynamic network
    /// configuration service to the GEC customer to enable edge application and
    /// network function solutions. This allows the customers to easily define and
    /// configure the network setup and property to meet the workload requirement.
    /// </remarks>
    public abstract partial class EdgeNetworkClient
    {
        /// <summary>
        /// The default endpoint for the EdgeNetwork service, which is a host of "edgenetwork.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "edgenetwork.googleapis.com:443";

        /// <summary>The default EdgeNetwork scopes.</summary>
        /// <remarks>
        /// The default EdgeNetwork scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(EdgeNetwork.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EdgeNetworkClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EdgeNetworkClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EdgeNetworkClient"/>.</returns>
        public static stt::Task<EdgeNetworkClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EdgeNetworkClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EdgeNetworkClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EdgeNetworkClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EdgeNetworkClient"/>.</returns>
        public static EdgeNetworkClient Create() => new EdgeNetworkClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EdgeNetworkClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EdgeNetworkSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EdgeNetworkClient"/>.</returns>
        internal static EdgeNetworkClient Create(grpccore::CallInvoker callInvoker, EdgeNetworkSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EdgeNetwork.EdgeNetworkClient grpcClient = new EdgeNetwork.EdgeNetworkClient(callInvoker);
            return new EdgeNetworkClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC EdgeNetwork client</summary>
        public virtual EdgeNetwork.EdgeNetworkClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// InitializeZone will initialize resources for a zone in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InitializeZoneResponse InitializeZone(InitializeZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// InitializeZone will initialize resources for a zone in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InitializeZoneResponse> InitializeZoneAsync(InitializeZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// InitializeZone will initialize resources for a zone in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InitializeZoneResponse> InitializeZoneAsync(InitializeZoneRequest request, st::CancellationToken cancellationToken) =>
            InitializeZoneAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// InitializeZone will initialize resources for a zone in a project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InitializeZoneResponse InitializeZone(string name, gaxgrpc::CallSettings callSettings = null) =>
            InitializeZone(new InitializeZoneRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// InitializeZone will initialize resources for a zone in a project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InitializeZoneResponse> InitializeZoneAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            InitializeZoneAsync(new InitializeZoneRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// InitializeZone will initialize resources for a zone in a project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InitializeZoneResponse> InitializeZoneAsync(string name, st::CancellationToken cancellationToken) =>
            InitializeZoneAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// InitializeZone will initialize resources for a zone in a project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InitializeZoneResponse InitializeZone(ZoneName name, gaxgrpc::CallSettings callSettings = null) =>
            InitializeZone(new InitializeZoneRequest
            {
                ZoneName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// InitializeZone will initialize resources for a zone in a project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InitializeZoneResponse> InitializeZoneAsync(ZoneName name, gaxgrpc::CallSettings callSettings = null) =>
            InitializeZoneAsync(new InitializeZoneRequest
            {
                ZoneName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// InitializeZone will initialize resources for a zone in a project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InitializeZoneResponse> InitializeZoneAsync(ZoneName name, st::CancellationToken cancellationToken) =>
            InitializeZoneAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: not implemented.
        /// Lists Zones in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Zone"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual gax::PagedEnumerable<ListZonesResponse, Zone> ListZones(ListZonesRequest request, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning restore CS0612
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: not implemented.
        /// Lists Zones in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Zone"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual gax::PagedAsyncEnumerable<ListZonesResponse, Zone> ListZonesAsync(ListZonesRequest request, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning restore CS0612
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: not implemented.
        /// Lists Zones in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListZonesRequest
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
        /// <returns>A pageable sequence of <see cref="Zone"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual gax::PagedEnumerable<ListZonesResponse, Zone> ListZones(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
#pragma warning disable CS0612
            ListZonesRequest request = new ListZonesRequest
#pragma warning restore CS0612
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
            return ListZones(request, callSettings);
        }

        /// <summary>
        /// Deprecated: not implemented.
        /// Lists Zones in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListZonesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Zone"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual gax::PagedAsyncEnumerable<ListZonesResponse, Zone> ListZonesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
#pragma warning disable CS0612
            ListZonesRequest request = new ListZonesRequest
#pragma warning restore CS0612
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
            return ListZonesAsync(request, callSettings);
        }

        /// <summary>
        /// Deprecated: not implemented.
        /// Lists Zones in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListZonesRequest
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
        /// <returns>A pageable sequence of <see cref="Zone"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual gax::PagedEnumerable<ListZonesResponse, Zone> ListZones(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
#pragma warning disable CS0612
            ListZonesRequest request = new ListZonesRequest
#pragma warning restore CS0612
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
            return ListZones(request, callSettings);
        }

        /// <summary>
        /// Deprecated: not implemented.
        /// Lists Zones in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListZonesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Zone"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual gax::PagedAsyncEnumerable<ListZonesResponse, Zone> ListZonesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
#pragma warning disable CS0612
            ListZonesRequest request = new ListZonesRequest
#pragma warning restore CS0612
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
            return ListZonesAsync(request, callSettings);
        }

        /// <summary>
        /// Deprecated: not implemented.
        /// Gets details of a single Zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual Zone GetZone(GetZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning restore CS0612
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: not implemented.
        /// Gets details of a single Zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual stt::Task<Zone> GetZoneAsync(GetZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning restore CS0612
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: not implemented.
        /// Gets details of a single Zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual stt::Task<Zone> GetZoneAsync(GetZoneRequest request, st::CancellationToken cancellationToken) =>
#pragma warning restore CS0612
            GetZoneAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: not implemented.
        /// Gets details of a single Zone.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual Zone GetZone(string name, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning disable CS0612
            GetZone(new GetZoneRequest
#pragma warning restore CS0612
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deprecated: not implemented.
        /// Gets details of a single Zone.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<Zone> GetZoneAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning disable CS0612
            GetZoneAsync(new GetZoneRequest
#pragma warning restore CS0612
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deprecated: not implemented.
        /// Gets details of a single Zone.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<Zone> GetZoneAsync(string name, st::CancellationToken cancellationToken) =>
            GetZoneAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: not implemented.
        /// Gets details of a single Zone.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual Zone GetZone(ZoneName name, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning disable CS0612
            GetZone(new GetZoneRequest
#pragma warning restore CS0612
            {
                ZoneName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deprecated: not implemented.
        /// Gets details of a single Zone.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<Zone> GetZoneAsync(ZoneName name, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning disable CS0612
            GetZoneAsync(new GetZoneRequest
#pragma warning restore CS0612
            {
                ZoneName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deprecated: not implemented.
        /// Gets details of a single Zone.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<Zone> GetZoneAsync(ZoneName name, st::CancellationToken cancellationToken) =>
            GetZoneAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Networks in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Network"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNetworksResponse, Network> ListNetworks(ListNetworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Networks in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Network"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNetworksResponse, Network> ListNetworksAsync(ListNetworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Networks in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListNetworksRequest
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
        /// Lists Networks in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListNetworksRequest
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
        /// Lists Networks in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListNetworksRequest
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
        public virtual gax::PagedEnumerable<ListNetworksResponse, Network> ListNetworks(ZoneName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNetworksRequest request = new ListNetworksRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists Networks in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListNetworksRequest
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
        public virtual gax::PagedAsyncEnumerable<ListNetworksResponse, Network> ListNetworksAsync(ZoneName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNetworksRequest request = new ListNetworksRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Gets details of a single Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network GetNetwork(GetNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(GetNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(GetNetworkRequest request, st::CancellationToken cancellationToken) =>
            GetNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network GetNetwork(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetwork(new GetNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetworkAsync(new GetNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(string name, st::CancellationToken cancellationToken) =>
            GetNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network GetNetwork(NetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetwork(new GetNetworkRequest
            {
                NetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(NetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetworkAsync(new GetNetworkRequest
            {
                NetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(NetworkName name, st::CancellationToken cancellationToken) =>
            GetNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the diagnostics of a single network resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiagnoseNetworkResponse DiagnoseNetwork(DiagnoseNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the diagnostics of a single network resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiagnoseNetworkResponse> DiagnoseNetworkAsync(DiagnoseNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the diagnostics of a single network resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiagnoseNetworkResponse> DiagnoseNetworkAsync(DiagnoseNetworkRequest request, st::CancellationToken cancellationToken) =>
            DiagnoseNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the diagnostics of a single network resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the network resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiagnoseNetworkResponse DiagnoseNetwork(string name, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseNetwork(new DiagnoseNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the diagnostics of a single network resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the network resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiagnoseNetworkResponse> DiagnoseNetworkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseNetworkAsync(new DiagnoseNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the diagnostics of a single network resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the network resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiagnoseNetworkResponse> DiagnoseNetworkAsync(string name, st::CancellationToken cancellationToken) =>
            DiagnoseNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the diagnostics of a single network resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the network resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiagnoseNetworkResponse DiagnoseNetwork(NetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseNetwork(new DiagnoseNetworkRequest
            {
                NetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the diagnostics of a single network resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the network resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiagnoseNetworkResponse> DiagnoseNetworkAsync(NetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseNetworkAsync(new DiagnoseNetworkRequest
            {
                NetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the diagnostics of a single network resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the network resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiagnoseNetworkResponse> DiagnoseNetworkAsync(NetworkName name, st::CancellationToken cancellationToken) =>
            DiagnoseNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Network in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Network, OperationMetadata> CreateNetwork(CreateNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Network in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Network, OperationMetadata>> CreateNetworkAsync(CreateNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Network in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Network, OperationMetadata>> CreateNetworkAsync(CreateNetworkRequest request, st::CancellationToken cancellationToken) =>
            CreateNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateNetwork</c>.</summary>
        public virtual lro::OperationsClient CreateNetworkOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateNetwork</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Network, OperationMetadata> PollOnceCreateNetwork(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Network, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateNetworkOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateNetwork</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Network, OperationMetadata>> PollOnceCreateNetworkAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Network, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateNetworkOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="network">
        /// Required. The resource being created
        /// </param>
        /// <param name="networkId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// network_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Network, OperationMetadata> CreateNetwork(string parent, Network network, string networkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNetwork(new CreateNetworkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NetworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)),
                Network = gax::GaxPreconditions.CheckNotNull(network, nameof(network)),
            }, callSettings);

        /// <summary>
        /// Creates a new Network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="network">
        /// Required. The resource being created
        /// </param>
        /// <param name="networkId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// network_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Network, OperationMetadata>> CreateNetworkAsync(string parent, Network network, string networkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNetworkAsync(new CreateNetworkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NetworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)),
                Network = gax::GaxPreconditions.CheckNotNull(network, nameof(network)),
            }, callSettings);

        /// <summary>
        /// Creates a new Network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="network">
        /// Required. The resource being created
        /// </param>
        /// <param name="networkId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// network_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Network, OperationMetadata>> CreateNetworkAsync(string parent, Network network, string networkId, st::CancellationToken cancellationToken) =>
            CreateNetworkAsync(parent, network, networkId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="network">
        /// Required. The resource being created
        /// </param>
        /// <param name="networkId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// network_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Network, OperationMetadata> CreateNetwork(ZoneName parent, Network network, string networkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNetwork(new CreateNetworkRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NetworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)),
                Network = gax::GaxPreconditions.CheckNotNull(network, nameof(network)),
            }, callSettings);

        /// <summary>
        /// Creates a new Network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="network">
        /// Required. The resource being created
        /// </param>
        /// <param name="networkId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// network_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Network, OperationMetadata>> CreateNetworkAsync(ZoneName parent, Network network, string networkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNetworkAsync(new CreateNetworkRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NetworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)),
                Network = gax::GaxPreconditions.CheckNotNull(network, nameof(network)),
            }, callSettings);

        /// <summary>
        /// Creates a new Network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="network">
        /// Required. The resource being created
        /// </param>
        /// <param name="networkId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// network_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Network, OperationMetadata>> CreateNetworkAsync(ZoneName parent, Network network, string networkId, st::CancellationToken cancellationToken) =>
            CreateNetworkAsync(parent, network, networkId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteNetwork(DeleteNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNetworkAsync(DeleteNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNetworkAsync(DeleteNetworkRequest request, st::CancellationToken cancellationToken) =>
            DeleteNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteNetwork</c>.</summary>
        public virtual lro::OperationsClient DeleteNetworkOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteNetwork</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteNetwork(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteNetworkOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteNetwork</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteNetworkAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteNetworkOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteNetwork(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNetwork(new DeleteNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNetworkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNetworkAsync(new DeleteNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNetworkAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteNetwork(NetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNetwork(new DeleteNetworkRequest
            {
                NetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNetworkAsync(NetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNetworkAsync(new DeleteNetworkRequest
            {
                NetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNetworkAsync(NetworkName name, st::CancellationToken cancellationToken) =>
            DeleteNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Subnets in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Subnet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubnetsResponse, Subnet> ListSubnets(ListSubnetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Subnets in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Subnet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubnetsResponse, Subnet> ListSubnetsAsync(ListSubnetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Subnets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListSubnetsRequest
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
        public virtual gax::PagedEnumerable<ListSubnetsResponse, Subnet> ListSubnets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSubnetsRequest request = new ListSubnetsRequest
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
            return ListSubnets(request, callSettings);
        }

        /// <summary>
        /// Lists Subnets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListSubnetsRequest
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
        public virtual gax::PagedAsyncEnumerable<ListSubnetsResponse, Subnet> ListSubnetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSubnetsRequest request = new ListSubnetsRequest
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
            return ListSubnetsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Subnets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListSubnetsRequest
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
        public virtual gax::PagedEnumerable<ListSubnetsResponse, Subnet> ListSubnets(ZoneName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSubnetsRequest request = new ListSubnetsRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSubnets(request, callSettings);
        }

        /// <summary>
        /// Lists Subnets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListSubnetsRequest
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
        public virtual gax::PagedAsyncEnumerable<ListSubnetsResponse, Subnet> ListSubnetsAsync(ZoneName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSubnetsRequest request = new ListSubnetsRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSubnetsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subnet GetSubnet(GetSubnetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subnet> GetSubnetAsync(GetSubnetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subnet> GetSubnetAsync(GetSubnetRequest request, st::CancellationToken cancellationToken) =>
            GetSubnetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subnet GetSubnet(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSubnet(new GetSubnetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subnet> GetSubnetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSubnetAsync(new GetSubnetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subnet> GetSubnetAsync(string name, st::CancellationToken cancellationToken) =>
            GetSubnetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subnet GetSubnet(SubnetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSubnet(new GetSubnetRequest
            {
                SubnetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subnet> GetSubnetAsync(SubnetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSubnetAsync(new GetSubnetRequest
            {
                SubnetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subnet> GetSubnetAsync(SubnetName name, st::CancellationToken cancellationToken) =>
            GetSubnetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Subnet in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Subnet, OperationMetadata> CreateSubnet(CreateSubnetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Subnet in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subnet, OperationMetadata>> CreateSubnetAsync(CreateSubnetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Subnet in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subnet, OperationMetadata>> CreateSubnetAsync(CreateSubnetRequest request, st::CancellationToken cancellationToken) =>
            CreateSubnetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSubnet</c>.</summary>
        public virtual lro::OperationsClient CreateSubnetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSubnet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Subnet, OperationMetadata> PollOnceCreateSubnet(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Subnet, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSubnetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSubnet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Subnet, OperationMetadata>> PollOnceCreateSubnetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Subnet, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSubnetOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Subnet in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="subnet">
        /// Required. The resource being created
        /// </param>
        /// <param name="subnetId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// subnet_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Subnet, OperationMetadata> CreateSubnet(string parent, Subnet subnet, string subnetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSubnet(new CreateSubnetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SubnetId = gax::GaxPreconditions.CheckNotNullOrEmpty(subnetId, nameof(subnetId)),
                Subnet = gax::GaxPreconditions.CheckNotNull(subnet, nameof(subnet)),
            }, callSettings);

        /// <summary>
        /// Creates a new Subnet in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="subnet">
        /// Required. The resource being created
        /// </param>
        /// <param name="subnetId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// subnet_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subnet, OperationMetadata>> CreateSubnetAsync(string parent, Subnet subnet, string subnetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSubnetAsync(new CreateSubnetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SubnetId = gax::GaxPreconditions.CheckNotNullOrEmpty(subnetId, nameof(subnetId)),
                Subnet = gax::GaxPreconditions.CheckNotNull(subnet, nameof(subnet)),
            }, callSettings);

        /// <summary>
        /// Creates a new Subnet in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="subnet">
        /// Required. The resource being created
        /// </param>
        /// <param name="subnetId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// subnet_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subnet, OperationMetadata>> CreateSubnetAsync(string parent, Subnet subnet, string subnetId, st::CancellationToken cancellationToken) =>
            CreateSubnetAsync(parent, subnet, subnetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Subnet in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="subnet">
        /// Required. The resource being created
        /// </param>
        /// <param name="subnetId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// subnet_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Subnet, OperationMetadata> CreateSubnet(ZoneName parent, Subnet subnet, string subnetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSubnet(new CreateSubnetRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SubnetId = gax::GaxPreconditions.CheckNotNullOrEmpty(subnetId, nameof(subnetId)),
                Subnet = gax::GaxPreconditions.CheckNotNull(subnet, nameof(subnet)),
            }, callSettings);

        /// <summary>
        /// Creates a new Subnet in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="subnet">
        /// Required. The resource being created
        /// </param>
        /// <param name="subnetId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// subnet_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subnet, OperationMetadata>> CreateSubnetAsync(ZoneName parent, Subnet subnet, string subnetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSubnetAsync(new CreateSubnetRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SubnetId = gax::GaxPreconditions.CheckNotNullOrEmpty(subnetId, nameof(subnetId)),
                Subnet = gax::GaxPreconditions.CheckNotNull(subnet, nameof(subnet)),
            }, callSettings);

        /// <summary>
        /// Creates a new Subnet in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="subnet">
        /// Required. The resource being created
        /// </param>
        /// <param name="subnetId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// subnet_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subnet, OperationMetadata>> CreateSubnetAsync(ZoneName parent, Subnet subnet, string subnetId, st::CancellationToken cancellationToken) =>
            CreateSubnetAsync(parent, subnet, subnetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Subnet, OperationMetadata> UpdateSubnet(UpdateSubnetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subnet, OperationMetadata>> UpdateSubnetAsync(UpdateSubnetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subnet, OperationMetadata>> UpdateSubnetAsync(UpdateSubnetRequest request, st::CancellationToken cancellationToken) =>
            UpdateSubnetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateSubnet</c>.</summary>
        public virtual lro::OperationsClient UpdateSubnetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateSubnet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Subnet, OperationMetadata> PollOnceUpdateSubnet(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Subnet, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSubnetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSubnet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Subnet, OperationMetadata>> PollOnceUpdateSubnetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Subnet, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSubnetOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Subnet.
        /// </summary>
        /// <param name="subnet">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Subnet resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Subnet, OperationMetadata> UpdateSubnet(Subnet subnet, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSubnet(new UpdateSubnetRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Subnet = gax::GaxPreconditions.CheckNotNull(subnet, nameof(subnet)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Subnet.
        /// </summary>
        /// <param name="subnet">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Subnet resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subnet, OperationMetadata>> UpdateSubnetAsync(Subnet subnet, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSubnetAsync(new UpdateSubnetRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Subnet = gax::GaxPreconditions.CheckNotNull(subnet, nameof(subnet)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Subnet.
        /// </summary>
        /// <param name="subnet">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Subnet resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subnet, OperationMetadata>> UpdateSubnetAsync(Subnet subnet, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSubnetAsync(subnet, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSubnet(DeleteSubnetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSubnetAsync(DeleteSubnetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSubnetAsync(DeleteSubnetRequest request, st::CancellationToken cancellationToken) =>
            DeleteSubnetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSubnet</c>.</summary>
        public virtual lro::OperationsClient DeleteSubnetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSubnet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteSubnet(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSubnetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSubnet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteSubnetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSubnetOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSubnet(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubnet(new DeleteSubnetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSubnetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubnetAsync(new DeleteSubnetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSubnetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSubnetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSubnet(SubnetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubnet(new DeleteSubnetRequest
            {
                SubnetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSubnetAsync(SubnetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubnetAsync(new DeleteSubnetRequest
            {
                SubnetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSubnetAsync(SubnetName name, st::CancellationToken cancellationToken) =>
            DeleteSubnetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Interconnects in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Interconnect"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInterconnectsResponse, Interconnect> ListInterconnects(ListInterconnectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Interconnects in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Interconnect"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInterconnectsResponse, Interconnect> ListInterconnectsAsync(ListInterconnectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Interconnects in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInterconnectsRequest
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
        /// <returns>A pageable sequence of <see cref="Interconnect"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInterconnectsResponse, Interconnect> ListInterconnects(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterconnectsRequest request = new ListInterconnectsRequest
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
            return ListInterconnects(request, callSettings);
        }

        /// <summary>
        /// Lists Interconnects in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInterconnectsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Interconnect"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInterconnectsResponse, Interconnect> ListInterconnectsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterconnectsRequest request = new ListInterconnectsRequest
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
            return ListInterconnectsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Interconnects in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInterconnectsRequest
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
        /// <returns>A pageable sequence of <see cref="Interconnect"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInterconnectsResponse, Interconnect> ListInterconnects(ZoneName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterconnectsRequest request = new ListInterconnectsRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListInterconnects(request, callSettings);
        }

        /// <summary>
        /// Lists Interconnects in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInterconnectsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Interconnect"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInterconnectsResponse, Interconnect> ListInterconnectsAsync(ZoneName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterconnectsRequest request = new ListInterconnectsRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListInterconnectsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Interconnect.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Interconnect GetInterconnect(GetInterconnectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Interconnect.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Interconnect> GetInterconnectAsync(GetInterconnectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Interconnect.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Interconnect> GetInterconnectAsync(GetInterconnectRequest request, st::CancellationToken cancellationToken) =>
            GetInterconnectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Interconnect.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Interconnect GetInterconnect(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterconnect(new GetInterconnectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Interconnect.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Interconnect> GetInterconnectAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterconnectAsync(new GetInterconnectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Interconnect.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Interconnect> GetInterconnectAsync(string name, st::CancellationToken cancellationToken) =>
            GetInterconnectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Interconnect.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Interconnect GetInterconnect(InterconnectName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterconnect(new GetInterconnectRequest
            {
                InterconnectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Interconnect.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Interconnect> GetInterconnectAsync(InterconnectName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterconnectAsync(new GetInterconnectRequest
            {
                InterconnectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Interconnect.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Interconnect> GetInterconnectAsync(InterconnectName name, st::CancellationToken cancellationToken) =>
            GetInterconnectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the diagnostics of a single interconnect resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiagnoseInterconnectResponse DiagnoseInterconnect(DiagnoseInterconnectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the diagnostics of a single interconnect resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiagnoseInterconnectResponse> DiagnoseInterconnectAsync(DiagnoseInterconnectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the diagnostics of a single interconnect resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiagnoseInterconnectResponse> DiagnoseInterconnectAsync(DiagnoseInterconnectRequest request, st::CancellationToken cancellationToken) =>
            DiagnoseInterconnectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the diagnostics of a single interconnect resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the interconnect resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiagnoseInterconnectResponse DiagnoseInterconnect(string name, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseInterconnect(new DiagnoseInterconnectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the diagnostics of a single interconnect resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the interconnect resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiagnoseInterconnectResponse> DiagnoseInterconnectAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseInterconnectAsync(new DiagnoseInterconnectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the diagnostics of a single interconnect resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the interconnect resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiagnoseInterconnectResponse> DiagnoseInterconnectAsync(string name, st::CancellationToken cancellationToken) =>
            DiagnoseInterconnectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the diagnostics of a single interconnect resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the interconnect resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiagnoseInterconnectResponse DiagnoseInterconnect(InterconnectName name, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseInterconnect(new DiagnoseInterconnectRequest
            {
                InterconnectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the diagnostics of a single interconnect resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the interconnect resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiagnoseInterconnectResponse> DiagnoseInterconnectAsync(InterconnectName name, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseInterconnectAsync(new DiagnoseInterconnectRequest
            {
                InterconnectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the diagnostics of a single interconnect resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the interconnect resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiagnoseInterconnectResponse> DiagnoseInterconnectAsync(InterconnectName name, st::CancellationToken cancellationToken) =>
            DiagnoseInterconnectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists InterconnectAttachments in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InterconnectAttachment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInterconnectAttachmentsResponse, InterconnectAttachment> ListInterconnectAttachments(ListInterconnectAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists InterconnectAttachments in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InterconnectAttachment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInterconnectAttachmentsResponse, InterconnectAttachment> ListInterconnectAttachmentsAsync(ListInterconnectAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists InterconnectAttachments in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInterconnectAttachmentsRequest
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
        /// <returns>A pageable sequence of <see cref="InterconnectAttachment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInterconnectAttachmentsResponse, InterconnectAttachment> ListInterconnectAttachments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterconnectAttachmentsRequest request = new ListInterconnectAttachmentsRequest
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
            return ListInterconnectAttachments(request, callSettings);
        }

        /// <summary>
        /// Lists InterconnectAttachments in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInterconnectAttachmentsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="InterconnectAttachment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInterconnectAttachmentsResponse, InterconnectAttachment> ListInterconnectAttachmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterconnectAttachmentsRequest request = new ListInterconnectAttachmentsRequest
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
            return ListInterconnectAttachmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists InterconnectAttachments in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInterconnectAttachmentsRequest
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
        /// <returns>A pageable sequence of <see cref="InterconnectAttachment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInterconnectAttachmentsResponse, InterconnectAttachment> ListInterconnectAttachments(ZoneName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterconnectAttachmentsRequest request = new ListInterconnectAttachmentsRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListInterconnectAttachments(request, callSettings);
        }

        /// <summary>
        /// Lists InterconnectAttachments in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInterconnectAttachmentsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="InterconnectAttachment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInterconnectAttachmentsResponse, InterconnectAttachment> ListInterconnectAttachmentsAsync(ZoneName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterconnectAttachmentsRequest request = new ListInterconnectAttachmentsRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListInterconnectAttachmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single InterconnectAttachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InterconnectAttachment GetInterconnectAttachment(GetInterconnectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single InterconnectAttachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterconnectAttachment> GetInterconnectAttachmentAsync(GetInterconnectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single InterconnectAttachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterconnectAttachment> GetInterconnectAttachmentAsync(GetInterconnectAttachmentRequest request, st::CancellationToken cancellationToken) =>
            GetInterconnectAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single InterconnectAttachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InterconnectAttachment GetInterconnectAttachment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterconnectAttachment(new GetInterconnectAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single InterconnectAttachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterconnectAttachment> GetInterconnectAttachmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterconnectAttachmentAsync(new GetInterconnectAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single InterconnectAttachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterconnectAttachment> GetInterconnectAttachmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetInterconnectAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single InterconnectAttachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InterconnectAttachment GetInterconnectAttachment(InterconnectAttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterconnectAttachment(new GetInterconnectAttachmentRequest
            {
                InterconnectAttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single InterconnectAttachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterconnectAttachment> GetInterconnectAttachmentAsync(InterconnectAttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterconnectAttachmentAsync(new GetInterconnectAttachmentRequest
            {
                InterconnectAttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single InterconnectAttachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterconnectAttachment> GetInterconnectAttachmentAsync(InterconnectAttachmentName name, st::CancellationToken cancellationToken) =>
            GetInterconnectAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new InterconnectAttachment in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterconnectAttachment, OperationMetadata> CreateInterconnectAttachment(CreateInterconnectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new InterconnectAttachment in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterconnectAttachment, OperationMetadata>> CreateInterconnectAttachmentAsync(CreateInterconnectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new InterconnectAttachment in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterconnectAttachment, OperationMetadata>> CreateInterconnectAttachmentAsync(CreateInterconnectAttachmentRequest request, st::CancellationToken cancellationToken) =>
            CreateInterconnectAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateInterconnectAttachment</c>.</summary>
        public virtual lro::OperationsClient CreateInterconnectAttachmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInterconnectAttachment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InterconnectAttachment, OperationMetadata> PollOnceCreateInterconnectAttachment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InterconnectAttachment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInterconnectAttachmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInterconnectAttachment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InterconnectAttachment, OperationMetadata>> PollOnceCreateInterconnectAttachmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InterconnectAttachment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInterconnectAttachmentOperationsClient, callSettings);

        /// <summary>
        /// Creates a new InterconnectAttachment in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="interconnectAttachment">
        /// Required. The resource being created
        /// </param>
        /// <param name="interconnectAttachmentId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// interconnect_attachment_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterconnectAttachment, OperationMetadata> CreateInterconnectAttachment(string parent, InterconnectAttachment interconnectAttachment, string interconnectAttachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterconnectAttachment(new CreateInterconnectAttachmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InterconnectAttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(interconnectAttachmentId, nameof(interconnectAttachmentId)),
                InterconnectAttachment = gax::GaxPreconditions.CheckNotNull(interconnectAttachment, nameof(interconnectAttachment)),
            }, callSettings);

        /// <summary>
        /// Creates a new InterconnectAttachment in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="interconnectAttachment">
        /// Required. The resource being created
        /// </param>
        /// <param name="interconnectAttachmentId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// interconnect_attachment_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterconnectAttachment, OperationMetadata>> CreateInterconnectAttachmentAsync(string parent, InterconnectAttachment interconnectAttachment, string interconnectAttachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterconnectAttachmentAsync(new CreateInterconnectAttachmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InterconnectAttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(interconnectAttachmentId, nameof(interconnectAttachmentId)),
                InterconnectAttachment = gax::GaxPreconditions.CheckNotNull(interconnectAttachment, nameof(interconnectAttachment)),
            }, callSettings);

        /// <summary>
        /// Creates a new InterconnectAttachment in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="interconnectAttachment">
        /// Required. The resource being created
        /// </param>
        /// <param name="interconnectAttachmentId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// interconnect_attachment_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterconnectAttachment, OperationMetadata>> CreateInterconnectAttachmentAsync(string parent, InterconnectAttachment interconnectAttachment, string interconnectAttachmentId, st::CancellationToken cancellationToken) =>
            CreateInterconnectAttachmentAsync(parent, interconnectAttachment, interconnectAttachmentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new InterconnectAttachment in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="interconnectAttachment">
        /// Required. The resource being created
        /// </param>
        /// <param name="interconnectAttachmentId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// interconnect_attachment_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterconnectAttachment, OperationMetadata> CreateInterconnectAttachment(ZoneName parent, InterconnectAttachment interconnectAttachment, string interconnectAttachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterconnectAttachment(new CreateInterconnectAttachmentRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InterconnectAttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(interconnectAttachmentId, nameof(interconnectAttachmentId)),
                InterconnectAttachment = gax::GaxPreconditions.CheckNotNull(interconnectAttachment, nameof(interconnectAttachment)),
            }, callSettings);

        /// <summary>
        /// Creates a new InterconnectAttachment in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="interconnectAttachment">
        /// Required. The resource being created
        /// </param>
        /// <param name="interconnectAttachmentId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// interconnect_attachment_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterconnectAttachment, OperationMetadata>> CreateInterconnectAttachmentAsync(ZoneName parent, InterconnectAttachment interconnectAttachment, string interconnectAttachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterconnectAttachmentAsync(new CreateInterconnectAttachmentRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InterconnectAttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(interconnectAttachmentId, nameof(interconnectAttachmentId)),
                InterconnectAttachment = gax::GaxPreconditions.CheckNotNull(interconnectAttachment, nameof(interconnectAttachment)),
            }, callSettings);

        /// <summary>
        /// Creates a new InterconnectAttachment in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="interconnectAttachment">
        /// Required. The resource being created
        /// </param>
        /// <param name="interconnectAttachmentId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// interconnect_attachment_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterconnectAttachment, OperationMetadata>> CreateInterconnectAttachmentAsync(ZoneName parent, InterconnectAttachment interconnectAttachment, string interconnectAttachmentId, st::CancellationToken cancellationToken) =>
            CreateInterconnectAttachmentAsync(parent, interconnectAttachment, interconnectAttachmentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single InterconnectAttachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInterconnectAttachment(DeleteInterconnectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single InterconnectAttachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterconnectAttachmentAsync(DeleteInterconnectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single InterconnectAttachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterconnectAttachmentAsync(DeleteInterconnectAttachmentRequest request, st::CancellationToken cancellationToken) =>
            DeleteInterconnectAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteInterconnectAttachment</c>.</summary>
        public virtual lro::OperationsClient DeleteInterconnectAttachmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInterconnectAttachment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteInterconnectAttachment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInterconnectAttachmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInterconnectAttachment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteInterconnectAttachmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInterconnectAttachmentOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single InterconnectAttachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInterconnectAttachment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterconnectAttachment(new DeleteInterconnectAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single InterconnectAttachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterconnectAttachmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterconnectAttachmentAsync(new DeleteInterconnectAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single InterconnectAttachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterconnectAttachmentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInterconnectAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single InterconnectAttachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInterconnectAttachment(InterconnectAttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterconnectAttachment(new DeleteInterconnectAttachmentRequest
            {
                InterconnectAttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single InterconnectAttachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterconnectAttachmentAsync(InterconnectAttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterconnectAttachmentAsync(new DeleteInterconnectAttachmentRequest
            {
                InterconnectAttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single InterconnectAttachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterconnectAttachmentAsync(InterconnectAttachmentName name, st::CancellationToken cancellationToken) =>
            DeleteInterconnectAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Routers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Router"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRoutersResponse, Router> ListRouters(ListRoutersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Routers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Router"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRoutersResponse, Router> ListRoutersAsync(ListRoutersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Routers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListRoutersRequest
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
        /// <returns>A pageable sequence of <see cref="Router"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRoutersResponse, Router> ListRouters(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRoutersRequest request = new ListRoutersRequest
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
            return ListRouters(request, callSettings);
        }

        /// <summary>
        /// Lists Routers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListRoutersRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Router"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRoutersResponse, Router> ListRoutersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRoutersRequest request = new ListRoutersRequest
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
            return ListRoutersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Routers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListRoutersRequest
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
        /// <returns>A pageable sequence of <see cref="Router"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRoutersResponse, Router> ListRouters(ZoneName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRoutersRequest request = new ListRoutersRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRouters(request, callSettings);
        }

        /// <summary>
        /// Lists Routers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListRoutersRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Router"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRoutersResponse, Router> ListRoutersAsync(ZoneName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRoutersRequest request = new ListRoutersRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRoutersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Router GetRouter(GetRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Router> GetRouterAsync(GetRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Router> GetRouterAsync(GetRouterRequest request, st::CancellationToken cancellationToken) =>
            GetRouterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Router.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Router GetRouter(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRouter(new GetRouterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Router.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Router> GetRouterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRouterAsync(new GetRouterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Router.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Router> GetRouterAsync(string name, st::CancellationToken cancellationToken) =>
            GetRouterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Router.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Router GetRouter(RouterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRouter(new GetRouterRequest
            {
                RouterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Router.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Router> GetRouterAsync(RouterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRouterAsync(new GetRouterRequest
            {
                RouterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Router.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Router> GetRouterAsync(RouterName name, st::CancellationToken cancellationToken) =>
            GetRouterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the diagnostics of a single router resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiagnoseRouterResponse DiagnoseRouter(DiagnoseRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the diagnostics of a single router resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiagnoseRouterResponse> DiagnoseRouterAsync(DiagnoseRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the diagnostics of a single router resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiagnoseRouterResponse> DiagnoseRouterAsync(DiagnoseRouterRequest request, st::CancellationToken cancellationToken) =>
            DiagnoseRouterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the diagnostics of a single router resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the router resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiagnoseRouterResponse DiagnoseRouter(string name, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseRouter(new DiagnoseRouterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the diagnostics of a single router resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the router resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiagnoseRouterResponse> DiagnoseRouterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseRouterAsync(new DiagnoseRouterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the diagnostics of a single router resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the router resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiagnoseRouterResponse> DiagnoseRouterAsync(string name, st::CancellationToken cancellationToken) =>
            DiagnoseRouterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the diagnostics of a single router resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the router resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiagnoseRouterResponse DiagnoseRouter(RouterName name, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseRouter(new DiagnoseRouterRequest
            {
                RouterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the diagnostics of a single router resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the router resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiagnoseRouterResponse> DiagnoseRouterAsync(RouterName name, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseRouterAsync(new DiagnoseRouterRequest
            {
                RouterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the diagnostics of a single router resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the router resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiagnoseRouterResponse> DiagnoseRouterAsync(RouterName name, st::CancellationToken cancellationToken) =>
            DiagnoseRouterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Router in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Router, OperationMetadata> CreateRouter(CreateRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Router in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Router, OperationMetadata>> CreateRouterAsync(CreateRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Router in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Router, OperationMetadata>> CreateRouterAsync(CreateRouterRequest request, st::CancellationToken cancellationToken) =>
            CreateRouterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateRouter</c>.</summary>
        public virtual lro::OperationsClient CreateRouterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateRouter</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Router, OperationMetadata> PollOnceCreateRouter(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Router, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRouterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateRouter</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Router, OperationMetadata>> PollOnceCreateRouterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Router, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRouterOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Router in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="router">
        /// Required. The resource being created
        /// </param>
        /// <param name="routerId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// router_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Router, OperationMetadata> CreateRouter(string parent, Router router, string routerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRouter(new CreateRouterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RouterId = gax::GaxPreconditions.CheckNotNullOrEmpty(routerId, nameof(routerId)),
                Router = gax::GaxPreconditions.CheckNotNull(router, nameof(router)),
            }, callSettings);

        /// <summary>
        /// Creates a new Router in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="router">
        /// Required. The resource being created
        /// </param>
        /// <param name="routerId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// router_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Router, OperationMetadata>> CreateRouterAsync(string parent, Router router, string routerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRouterAsync(new CreateRouterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RouterId = gax::GaxPreconditions.CheckNotNullOrEmpty(routerId, nameof(routerId)),
                Router = gax::GaxPreconditions.CheckNotNull(router, nameof(router)),
            }, callSettings);

        /// <summary>
        /// Creates a new Router in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="router">
        /// Required. The resource being created
        /// </param>
        /// <param name="routerId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// router_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Router, OperationMetadata>> CreateRouterAsync(string parent, Router router, string routerId, st::CancellationToken cancellationToken) =>
            CreateRouterAsync(parent, router, routerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Router in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="router">
        /// Required. The resource being created
        /// </param>
        /// <param name="routerId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// router_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Router, OperationMetadata> CreateRouter(ZoneName parent, Router router, string routerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRouter(new CreateRouterRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RouterId = gax::GaxPreconditions.CheckNotNullOrEmpty(routerId, nameof(routerId)),
                Router = gax::GaxPreconditions.CheckNotNull(router, nameof(router)),
            }, callSettings);

        /// <summary>
        /// Creates a new Router in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="router">
        /// Required. The resource being created
        /// </param>
        /// <param name="routerId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// router_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Router, OperationMetadata>> CreateRouterAsync(ZoneName parent, Router router, string routerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRouterAsync(new CreateRouterRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RouterId = gax::GaxPreconditions.CheckNotNullOrEmpty(routerId, nameof(routerId)),
                Router = gax::GaxPreconditions.CheckNotNull(router, nameof(router)),
            }, callSettings);

        /// <summary>
        /// Creates a new Router in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="router">
        /// Required. The resource being created
        /// </param>
        /// <param name="routerId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// router_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Router, OperationMetadata>> CreateRouterAsync(ZoneName parent, Router router, string routerId, st::CancellationToken cancellationToken) =>
            CreateRouterAsync(parent, router, routerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Router, OperationMetadata> UpdateRouter(UpdateRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Router, OperationMetadata>> UpdateRouterAsync(UpdateRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Router, OperationMetadata>> UpdateRouterAsync(UpdateRouterRequest request, st::CancellationToken cancellationToken) =>
            UpdateRouterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateRouter</c>.</summary>
        public virtual lro::OperationsClient UpdateRouterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateRouter</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Router, OperationMetadata> PollOnceUpdateRouter(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Router, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateRouterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateRouter</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Router, OperationMetadata>> PollOnceUpdateRouterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Router, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateRouterOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Router.
        /// </summary>
        /// <param name="router">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Router resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Router, OperationMetadata> UpdateRouter(Router router, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRouter(new UpdateRouterRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Router = gax::GaxPreconditions.CheckNotNull(router, nameof(router)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Router.
        /// </summary>
        /// <param name="router">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Router resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Router, OperationMetadata>> UpdateRouterAsync(Router router, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRouterAsync(new UpdateRouterRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Router = gax::GaxPreconditions.CheckNotNull(router, nameof(router)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Router.
        /// </summary>
        /// <param name="router">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Router resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Router, OperationMetadata>> UpdateRouterAsync(Router router, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRouterAsync(router, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRouter(DeleteRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRouterAsync(DeleteRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRouterAsync(DeleteRouterRequest request, st::CancellationToken cancellationToken) =>
            DeleteRouterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteRouter</c>.</summary>
        public virtual lro::OperationsClient DeleteRouterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteRouter</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteRouter(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRouterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteRouter</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteRouterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRouterOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Router.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRouter(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRouter(new DeleteRouterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Router.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRouterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRouterAsync(new DeleteRouterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Router.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRouterAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRouterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Router.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRouter(RouterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRouter(new DeleteRouterRequest
            {
                RouterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Router.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRouterAsync(RouterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRouterAsync(new DeleteRouterRequest
            {
                RouterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Router.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRouterAsync(RouterName name, st::CancellationToken cancellationToken) =>
            DeleteRouterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>EdgeNetwork client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// EdgeNetwork API provides managed, highly available cloud dynamic network
    /// configuration service to the GEC customer to enable edge application and
    /// network function solutions. This allows the customers to easily define and
    /// configure the network setup and property to meet the workload requirement.
    /// </remarks>
    public sealed partial class EdgeNetworkClientImpl : EdgeNetworkClient
    {
        private readonly gaxgrpc::ApiCall<InitializeZoneRequest, InitializeZoneResponse> _callInitializeZone;

#pragma warning disable CS0612
        private readonly gaxgrpc::ApiCall<ListZonesRequest, ListZonesResponse> _callListZones;

        private readonly gaxgrpc::ApiCall<GetZoneRequest, Zone> _callGetZone;
#pragma warning restore CS0612

        private readonly gaxgrpc::ApiCall<ListNetworksRequest, ListNetworksResponse> _callListNetworks;

        private readonly gaxgrpc::ApiCall<GetNetworkRequest, Network> _callGetNetwork;

        private readonly gaxgrpc::ApiCall<DiagnoseNetworkRequest, DiagnoseNetworkResponse> _callDiagnoseNetwork;

        private readonly gaxgrpc::ApiCall<CreateNetworkRequest, lro::Operation> _callCreateNetwork;

        private readonly gaxgrpc::ApiCall<DeleteNetworkRequest, lro::Operation> _callDeleteNetwork;

        private readonly gaxgrpc::ApiCall<ListSubnetsRequest, ListSubnetsResponse> _callListSubnets;

        private readonly gaxgrpc::ApiCall<GetSubnetRequest, Subnet> _callGetSubnet;

        private readonly gaxgrpc::ApiCall<CreateSubnetRequest, lro::Operation> _callCreateSubnet;

        private readonly gaxgrpc::ApiCall<UpdateSubnetRequest, lro::Operation> _callUpdateSubnet;

        private readonly gaxgrpc::ApiCall<DeleteSubnetRequest, lro::Operation> _callDeleteSubnet;

        private readonly gaxgrpc::ApiCall<ListInterconnectsRequest, ListInterconnectsResponse> _callListInterconnects;

        private readonly gaxgrpc::ApiCall<GetInterconnectRequest, Interconnect> _callGetInterconnect;

        private readonly gaxgrpc::ApiCall<DiagnoseInterconnectRequest, DiagnoseInterconnectResponse> _callDiagnoseInterconnect;

        private readonly gaxgrpc::ApiCall<ListInterconnectAttachmentsRequest, ListInterconnectAttachmentsResponse> _callListInterconnectAttachments;

        private readonly gaxgrpc::ApiCall<GetInterconnectAttachmentRequest, InterconnectAttachment> _callGetInterconnectAttachment;

        private readonly gaxgrpc::ApiCall<CreateInterconnectAttachmentRequest, lro::Operation> _callCreateInterconnectAttachment;

        private readonly gaxgrpc::ApiCall<DeleteInterconnectAttachmentRequest, lro::Operation> _callDeleteInterconnectAttachment;

        private readonly gaxgrpc::ApiCall<ListRoutersRequest, ListRoutersResponse> _callListRouters;

        private readonly gaxgrpc::ApiCall<GetRouterRequest, Router> _callGetRouter;

        private readonly gaxgrpc::ApiCall<DiagnoseRouterRequest, DiagnoseRouterResponse> _callDiagnoseRouter;

        private readonly gaxgrpc::ApiCall<CreateRouterRequest, lro::Operation> _callCreateRouter;

        private readonly gaxgrpc::ApiCall<UpdateRouterRequest, lro::Operation> _callUpdateRouter;

        private readonly gaxgrpc::ApiCall<DeleteRouterRequest, lro::Operation> _callDeleteRouter;

        /// <summary>
        /// Constructs a client wrapper for the EdgeNetwork service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EdgeNetworkSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EdgeNetworkClientImpl(EdgeNetwork.EdgeNetworkClient grpcClient, EdgeNetworkSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EdgeNetworkSettings effectiveSettings = settings ?? EdgeNetworkSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateNetworkOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateNetworkOperationsSettings, logger);
            DeleteNetworkOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteNetworkOperationsSettings, logger);
            CreateSubnetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSubnetOperationsSettings, logger);
            UpdateSubnetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSubnetOperationsSettings, logger);
            DeleteSubnetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSubnetOperationsSettings, logger);
            CreateInterconnectAttachmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInterconnectAttachmentOperationsSettings, logger);
            DeleteInterconnectAttachmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteInterconnectAttachmentOperationsSettings, logger);
            CreateRouterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateRouterOperationsSettings, logger);
            UpdateRouterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateRouterOperationsSettings, logger);
            DeleteRouterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteRouterOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callInitializeZone = clientHelper.BuildApiCall<InitializeZoneRequest, InitializeZoneResponse>("InitializeZone", grpcClient.InitializeZoneAsync, grpcClient.InitializeZone, effectiveSettings.InitializeZoneSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callInitializeZone);
            Modify_InitializeZoneApiCall(ref _callInitializeZone);
#pragma warning disable CS0612
            _callListZones = clientHelper.BuildApiCall<ListZonesRequest, ListZonesResponse>("ListZones", grpcClient.ListZonesAsync, grpcClient.ListZones, effectiveSettings.ListZonesSettings).WithGoogleRequestParam("parent", request => request.Parent);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callListZones);
            Modify_ListZonesApiCall(ref _callListZones);
#pragma warning disable CS0612
            _callGetZone = clientHelper.BuildApiCall<GetZoneRequest, Zone>("GetZone", grpcClient.GetZoneAsync, grpcClient.GetZone, effectiveSettings.GetZoneSettings).WithGoogleRequestParam("name", request => request.Name);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callGetZone);
            Modify_GetZoneApiCall(ref _callGetZone);
            _callListNetworks = clientHelper.BuildApiCall<ListNetworksRequest, ListNetworksResponse>("ListNetworks", grpcClient.ListNetworksAsync, grpcClient.ListNetworks, effectiveSettings.ListNetworksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNetworks);
            Modify_ListNetworksApiCall(ref _callListNetworks);
            _callGetNetwork = clientHelper.BuildApiCall<GetNetworkRequest, Network>("GetNetwork", grpcClient.GetNetworkAsync, grpcClient.GetNetwork, effectiveSettings.GetNetworkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNetwork);
            Modify_GetNetworkApiCall(ref _callGetNetwork);
            _callDiagnoseNetwork = clientHelper.BuildApiCall<DiagnoseNetworkRequest, DiagnoseNetworkResponse>("DiagnoseNetwork", grpcClient.DiagnoseNetworkAsync, grpcClient.DiagnoseNetwork, effectiveSettings.DiagnoseNetworkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDiagnoseNetwork);
            Modify_DiagnoseNetworkApiCall(ref _callDiagnoseNetwork);
            _callCreateNetwork = clientHelper.BuildApiCall<CreateNetworkRequest, lro::Operation>("CreateNetwork", grpcClient.CreateNetworkAsync, grpcClient.CreateNetwork, effectiveSettings.CreateNetworkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateNetwork);
            Modify_CreateNetworkApiCall(ref _callCreateNetwork);
            _callDeleteNetwork = clientHelper.BuildApiCall<DeleteNetworkRequest, lro::Operation>("DeleteNetwork", grpcClient.DeleteNetworkAsync, grpcClient.DeleteNetwork, effectiveSettings.DeleteNetworkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteNetwork);
            Modify_DeleteNetworkApiCall(ref _callDeleteNetwork);
            _callListSubnets = clientHelper.BuildApiCall<ListSubnetsRequest, ListSubnetsResponse>("ListSubnets", grpcClient.ListSubnetsAsync, grpcClient.ListSubnets, effectiveSettings.ListSubnetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSubnets);
            Modify_ListSubnetsApiCall(ref _callListSubnets);
            _callGetSubnet = clientHelper.BuildApiCall<GetSubnetRequest, Subnet>("GetSubnet", grpcClient.GetSubnetAsync, grpcClient.GetSubnet, effectiveSettings.GetSubnetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSubnet);
            Modify_GetSubnetApiCall(ref _callGetSubnet);
            _callCreateSubnet = clientHelper.BuildApiCall<CreateSubnetRequest, lro::Operation>("CreateSubnet", grpcClient.CreateSubnetAsync, grpcClient.CreateSubnet, effectiveSettings.CreateSubnetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSubnet);
            Modify_CreateSubnetApiCall(ref _callCreateSubnet);
            _callUpdateSubnet = clientHelper.BuildApiCall<UpdateSubnetRequest, lro::Operation>("UpdateSubnet", grpcClient.UpdateSubnetAsync, grpcClient.UpdateSubnet, effectiveSettings.UpdateSubnetSettings).WithGoogleRequestParam("subnet.name", request => request.Subnet?.Name);
            Modify_ApiCall(ref _callUpdateSubnet);
            Modify_UpdateSubnetApiCall(ref _callUpdateSubnet);
            _callDeleteSubnet = clientHelper.BuildApiCall<DeleteSubnetRequest, lro::Operation>("DeleteSubnet", grpcClient.DeleteSubnetAsync, grpcClient.DeleteSubnet, effectiveSettings.DeleteSubnetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSubnet);
            Modify_DeleteSubnetApiCall(ref _callDeleteSubnet);
            _callListInterconnects = clientHelper.BuildApiCall<ListInterconnectsRequest, ListInterconnectsResponse>("ListInterconnects", grpcClient.ListInterconnectsAsync, grpcClient.ListInterconnects, effectiveSettings.ListInterconnectsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInterconnects);
            Modify_ListInterconnectsApiCall(ref _callListInterconnects);
            _callGetInterconnect = clientHelper.BuildApiCall<GetInterconnectRequest, Interconnect>("GetInterconnect", grpcClient.GetInterconnectAsync, grpcClient.GetInterconnect, effectiveSettings.GetInterconnectSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInterconnect);
            Modify_GetInterconnectApiCall(ref _callGetInterconnect);
            _callDiagnoseInterconnect = clientHelper.BuildApiCall<DiagnoseInterconnectRequest, DiagnoseInterconnectResponse>("DiagnoseInterconnect", grpcClient.DiagnoseInterconnectAsync, grpcClient.DiagnoseInterconnect, effectiveSettings.DiagnoseInterconnectSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDiagnoseInterconnect);
            Modify_DiagnoseInterconnectApiCall(ref _callDiagnoseInterconnect);
            _callListInterconnectAttachments = clientHelper.BuildApiCall<ListInterconnectAttachmentsRequest, ListInterconnectAttachmentsResponse>("ListInterconnectAttachments", grpcClient.ListInterconnectAttachmentsAsync, grpcClient.ListInterconnectAttachments, effectiveSettings.ListInterconnectAttachmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInterconnectAttachments);
            Modify_ListInterconnectAttachmentsApiCall(ref _callListInterconnectAttachments);
            _callGetInterconnectAttachment = clientHelper.BuildApiCall<GetInterconnectAttachmentRequest, InterconnectAttachment>("GetInterconnectAttachment", grpcClient.GetInterconnectAttachmentAsync, grpcClient.GetInterconnectAttachment, effectiveSettings.GetInterconnectAttachmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInterconnectAttachment);
            Modify_GetInterconnectAttachmentApiCall(ref _callGetInterconnectAttachment);
            _callCreateInterconnectAttachment = clientHelper.BuildApiCall<CreateInterconnectAttachmentRequest, lro::Operation>("CreateInterconnectAttachment", grpcClient.CreateInterconnectAttachmentAsync, grpcClient.CreateInterconnectAttachment, effectiveSettings.CreateInterconnectAttachmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInterconnectAttachment);
            Modify_CreateInterconnectAttachmentApiCall(ref _callCreateInterconnectAttachment);
            _callDeleteInterconnectAttachment = clientHelper.BuildApiCall<DeleteInterconnectAttachmentRequest, lro::Operation>("DeleteInterconnectAttachment", grpcClient.DeleteInterconnectAttachmentAsync, grpcClient.DeleteInterconnectAttachment, effectiveSettings.DeleteInterconnectAttachmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInterconnectAttachment);
            Modify_DeleteInterconnectAttachmentApiCall(ref _callDeleteInterconnectAttachment);
            _callListRouters = clientHelper.BuildApiCall<ListRoutersRequest, ListRoutersResponse>("ListRouters", grpcClient.ListRoutersAsync, grpcClient.ListRouters, effectiveSettings.ListRoutersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRouters);
            Modify_ListRoutersApiCall(ref _callListRouters);
            _callGetRouter = clientHelper.BuildApiCall<GetRouterRequest, Router>("GetRouter", grpcClient.GetRouterAsync, grpcClient.GetRouter, effectiveSettings.GetRouterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRouter);
            Modify_GetRouterApiCall(ref _callGetRouter);
            _callDiagnoseRouter = clientHelper.BuildApiCall<DiagnoseRouterRequest, DiagnoseRouterResponse>("DiagnoseRouter", grpcClient.DiagnoseRouterAsync, grpcClient.DiagnoseRouter, effectiveSettings.DiagnoseRouterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDiagnoseRouter);
            Modify_DiagnoseRouterApiCall(ref _callDiagnoseRouter);
            _callCreateRouter = clientHelper.BuildApiCall<CreateRouterRequest, lro::Operation>("CreateRouter", grpcClient.CreateRouterAsync, grpcClient.CreateRouter, effectiveSettings.CreateRouterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRouter);
            Modify_CreateRouterApiCall(ref _callCreateRouter);
            _callUpdateRouter = clientHelper.BuildApiCall<UpdateRouterRequest, lro::Operation>("UpdateRouter", grpcClient.UpdateRouterAsync, grpcClient.UpdateRouter, effectiveSettings.UpdateRouterSettings).WithGoogleRequestParam("router.name", request => request.Router?.Name);
            Modify_ApiCall(ref _callUpdateRouter);
            Modify_UpdateRouterApiCall(ref _callUpdateRouter);
            _callDeleteRouter = clientHelper.BuildApiCall<DeleteRouterRequest, lro::Operation>("DeleteRouter", grpcClient.DeleteRouterAsync, grpcClient.DeleteRouter, effectiveSettings.DeleteRouterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRouter);
            Modify_DeleteRouterApiCall(ref _callDeleteRouter);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_InitializeZoneApiCall(ref gaxgrpc::ApiCall<InitializeZoneRequest, InitializeZoneResponse> call);

#pragma warning disable CS0612
        partial void Modify_ListZonesApiCall(ref gaxgrpc::ApiCall<ListZonesRequest, ListZonesResponse> call);

        partial void Modify_GetZoneApiCall(ref gaxgrpc::ApiCall<GetZoneRequest, Zone> call);
#pragma warning restore CS0612

        partial void Modify_ListNetworksApiCall(ref gaxgrpc::ApiCall<ListNetworksRequest, ListNetworksResponse> call);

        partial void Modify_GetNetworkApiCall(ref gaxgrpc::ApiCall<GetNetworkRequest, Network> call);

        partial void Modify_DiagnoseNetworkApiCall(ref gaxgrpc::ApiCall<DiagnoseNetworkRequest, DiagnoseNetworkResponse> call);

        partial void Modify_CreateNetworkApiCall(ref gaxgrpc::ApiCall<CreateNetworkRequest, lro::Operation> call);

        partial void Modify_DeleteNetworkApiCall(ref gaxgrpc::ApiCall<DeleteNetworkRequest, lro::Operation> call);

        partial void Modify_ListSubnetsApiCall(ref gaxgrpc::ApiCall<ListSubnetsRequest, ListSubnetsResponse> call);

        partial void Modify_GetSubnetApiCall(ref gaxgrpc::ApiCall<GetSubnetRequest, Subnet> call);

        partial void Modify_CreateSubnetApiCall(ref gaxgrpc::ApiCall<CreateSubnetRequest, lro::Operation> call);

        partial void Modify_UpdateSubnetApiCall(ref gaxgrpc::ApiCall<UpdateSubnetRequest, lro::Operation> call);

        partial void Modify_DeleteSubnetApiCall(ref gaxgrpc::ApiCall<DeleteSubnetRequest, lro::Operation> call);

        partial void Modify_ListInterconnectsApiCall(ref gaxgrpc::ApiCall<ListInterconnectsRequest, ListInterconnectsResponse> call);

        partial void Modify_GetInterconnectApiCall(ref gaxgrpc::ApiCall<GetInterconnectRequest, Interconnect> call);

        partial void Modify_DiagnoseInterconnectApiCall(ref gaxgrpc::ApiCall<DiagnoseInterconnectRequest, DiagnoseInterconnectResponse> call);

        partial void Modify_ListInterconnectAttachmentsApiCall(ref gaxgrpc::ApiCall<ListInterconnectAttachmentsRequest, ListInterconnectAttachmentsResponse> call);

        partial void Modify_GetInterconnectAttachmentApiCall(ref gaxgrpc::ApiCall<GetInterconnectAttachmentRequest, InterconnectAttachment> call);

        partial void Modify_CreateInterconnectAttachmentApiCall(ref gaxgrpc::ApiCall<CreateInterconnectAttachmentRequest, lro::Operation> call);

        partial void Modify_DeleteInterconnectAttachmentApiCall(ref gaxgrpc::ApiCall<DeleteInterconnectAttachmentRequest, lro::Operation> call);

        partial void Modify_ListRoutersApiCall(ref gaxgrpc::ApiCall<ListRoutersRequest, ListRoutersResponse> call);

        partial void Modify_GetRouterApiCall(ref gaxgrpc::ApiCall<GetRouterRequest, Router> call);

        partial void Modify_DiagnoseRouterApiCall(ref gaxgrpc::ApiCall<DiagnoseRouterRequest, DiagnoseRouterResponse> call);

        partial void Modify_CreateRouterApiCall(ref gaxgrpc::ApiCall<CreateRouterRequest, lro::Operation> call);

        partial void Modify_UpdateRouterApiCall(ref gaxgrpc::ApiCall<UpdateRouterRequest, lro::Operation> call);

        partial void Modify_DeleteRouterApiCall(ref gaxgrpc::ApiCall<DeleteRouterRequest, lro::Operation> call);

        partial void OnConstruction(EdgeNetwork.EdgeNetworkClient grpcClient, EdgeNetworkSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC EdgeNetwork client</summary>
        public override EdgeNetwork.EdgeNetworkClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_InitializeZoneRequest(ref InitializeZoneRequest request, ref gaxgrpc::CallSettings settings);

#pragma warning disable CS0612
        partial void Modify_ListZonesRequest(ref ListZonesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetZoneRequest(ref GetZoneRequest request, ref gaxgrpc::CallSettings settings);
#pragma warning restore CS0612

        partial void Modify_ListNetworksRequest(ref ListNetworksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNetworkRequest(ref GetNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DiagnoseNetworkRequest(ref DiagnoseNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateNetworkRequest(ref CreateNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteNetworkRequest(ref DeleteNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSubnetsRequest(ref ListSubnetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSubnetRequest(ref GetSubnetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSubnetRequest(ref CreateSubnetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSubnetRequest(ref UpdateSubnetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSubnetRequest(ref DeleteSubnetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInterconnectsRequest(ref ListInterconnectsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInterconnectRequest(ref GetInterconnectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DiagnoseInterconnectRequest(ref DiagnoseInterconnectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInterconnectAttachmentsRequest(ref ListInterconnectAttachmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInterconnectAttachmentRequest(ref GetInterconnectAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInterconnectAttachmentRequest(ref CreateInterconnectAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInterconnectAttachmentRequest(ref DeleteInterconnectAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRoutersRequest(ref ListRoutersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRouterRequest(ref GetRouterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DiagnoseRouterRequest(ref DiagnoseRouterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRouterRequest(ref CreateRouterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRouterRequest(ref UpdateRouterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRouterRequest(ref DeleteRouterRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// InitializeZone will initialize resources for a zone in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InitializeZoneResponse InitializeZone(InitializeZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InitializeZoneRequest(ref request, ref callSettings);
            return _callInitializeZone.Sync(request, callSettings);
        }

        /// <summary>
        /// InitializeZone will initialize resources for a zone in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InitializeZoneResponse> InitializeZoneAsync(InitializeZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InitializeZoneRequest(ref request, ref callSettings);
            return _callInitializeZone.Async(request, callSettings);
        }

        /// <summary>
        /// Deprecated: not implemented.
        /// Lists Zones in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Zone"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public override gax::PagedEnumerable<ListZonesResponse, Zone> ListZones(ListZonesRequest request, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
            Modify_ListZonesRequest(ref request, ref callSettings);
#pragma warning disable CS0612
            return new gaxgrpc::GrpcPagedEnumerable<ListZonesRequest, ListZonesResponse, Zone>(_callListZones, request, callSettings);
#pragma warning restore CS0612
        }

        /// <summary>
        /// Deprecated: not implemented.
        /// Lists Zones in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Zone"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public override gax::PagedAsyncEnumerable<ListZonesResponse, Zone> ListZonesAsync(ListZonesRequest request, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
            Modify_ListZonesRequest(ref request, ref callSettings);
#pragma warning disable CS0612
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListZonesRequest, ListZonesResponse, Zone>(_callListZones, request, callSettings);
#pragma warning restore CS0612
        }

        /// <summary>
        /// Deprecated: not implemented.
        /// Gets details of a single Zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public override Zone GetZone(GetZoneRequest request, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
            Modify_GetZoneRequest(ref request, ref callSettings);
            return _callGetZone.Sync(request, callSettings);
        }

        /// <summary>
        /// Deprecated: not implemented.
        /// Gets details of a single Zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public override stt::Task<Zone> GetZoneAsync(GetZoneRequest request, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
            Modify_GetZoneRequest(ref request, ref callSettings);
            return _callGetZone.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Networks in a given project and location.
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
        /// Lists Networks in a given project and location.
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
        /// Gets details of a single Network.
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
        /// Gets details of a single Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Network> GetNetworkAsync(GetNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNetworkRequest(ref request, ref callSettings);
            return _callGetNetwork.Async(request, callSettings);
        }

        /// <summary>
        /// Get the diagnostics of a single network resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DiagnoseNetworkResponse DiagnoseNetwork(DiagnoseNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DiagnoseNetworkRequest(ref request, ref callSettings);
            return _callDiagnoseNetwork.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the diagnostics of a single network resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DiagnoseNetworkResponse> DiagnoseNetworkAsync(DiagnoseNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DiagnoseNetworkRequest(ref request, ref callSettings);
            return _callDiagnoseNetwork.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateNetwork</c>.</summary>
        public override lro::OperationsClient CreateNetworkOperationsClient { get; }

        /// <summary>
        /// Creates a new Network in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Network, OperationMetadata> CreateNetwork(CreateNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNetworkRequest(ref request, ref callSettings);
            return new lro::Operation<Network, OperationMetadata>(_callCreateNetwork.Sync(request, callSettings), CreateNetworkOperationsClient);
        }

        /// <summary>
        /// Creates a new Network in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Network, OperationMetadata>> CreateNetworkAsync(CreateNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNetworkRequest(ref request, ref callSettings);
            return new lro::Operation<Network, OperationMetadata>(await _callCreateNetwork.Async(request, callSettings).ConfigureAwait(false), CreateNetworkOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteNetwork</c>.</summary>
        public override lro::OperationsClient DeleteNetworkOperationsClient { get; }

        /// <summary>
        /// Deletes a single Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteNetwork(DeleteNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNetworkRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteNetwork.Sync(request, callSettings), DeleteNetworkOperationsClient);
        }

        /// <summary>
        /// Deletes a single Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteNetworkAsync(DeleteNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNetworkRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteNetwork.Async(request, callSettings).ConfigureAwait(false), DeleteNetworkOperationsClient);
        }

        /// <summary>
        /// Lists Subnets in a given project and location.
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
        /// Lists Subnets in a given project and location.
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
        /// Gets details of a single Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Subnet GetSubnet(GetSubnetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSubnetRequest(ref request, ref callSettings);
            return _callGetSubnet.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Subnet> GetSubnetAsync(GetSubnetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSubnetRequest(ref request, ref callSettings);
            return _callGetSubnet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateSubnet</c>.</summary>
        public override lro::OperationsClient CreateSubnetOperationsClient { get; }

        /// <summary>
        /// Creates a new Subnet in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Subnet, OperationMetadata> CreateSubnet(CreateSubnetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSubnetRequest(ref request, ref callSettings);
            return new lro::Operation<Subnet, OperationMetadata>(_callCreateSubnet.Sync(request, callSettings), CreateSubnetOperationsClient);
        }

        /// <summary>
        /// Creates a new Subnet in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Subnet, OperationMetadata>> CreateSubnetAsync(CreateSubnetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSubnetRequest(ref request, ref callSettings);
            return new lro::Operation<Subnet, OperationMetadata>(await _callCreateSubnet.Async(request, callSettings).ConfigureAwait(false), CreateSubnetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateSubnet</c>.</summary>
        public override lro::OperationsClient UpdateSubnetOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Subnet, OperationMetadata> UpdateSubnet(UpdateSubnetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSubnetRequest(ref request, ref callSettings);
            return new lro::Operation<Subnet, OperationMetadata>(_callUpdateSubnet.Sync(request, callSettings), UpdateSubnetOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Subnet, OperationMetadata>> UpdateSubnetAsync(UpdateSubnetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSubnetRequest(ref request, ref callSettings);
            return new lro::Operation<Subnet, OperationMetadata>(await _callUpdateSubnet.Async(request, callSettings).ConfigureAwait(false), UpdateSubnetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteSubnet</c>.</summary>
        public override lro::OperationsClient DeleteSubnetOperationsClient { get; }

        /// <summary>
        /// Deletes a single Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteSubnet(DeleteSubnetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSubnetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteSubnet.Sync(request, callSettings), DeleteSubnetOperationsClient);
        }

        /// <summary>
        /// Deletes a single Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSubnetAsync(DeleteSubnetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSubnetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteSubnet.Async(request, callSettings).ConfigureAwait(false), DeleteSubnetOperationsClient);
        }

        /// <summary>
        /// Lists Interconnects in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Interconnect"/> resources.</returns>
        public override gax::PagedEnumerable<ListInterconnectsResponse, Interconnect> ListInterconnects(ListInterconnectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInterconnectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInterconnectsRequest, ListInterconnectsResponse, Interconnect>(_callListInterconnects, request, callSettings);
        }

        /// <summary>
        /// Lists Interconnects in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Interconnect"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInterconnectsResponse, Interconnect> ListInterconnectsAsync(ListInterconnectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInterconnectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInterconnectsRequest, ListInterconnectsResponse, Interconnect>(_callListInterconnects, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Interconnect.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Interconnect GetInterconnect(GetInterconnectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInterconnectRequest(ref request, ref callSettings);
            return _callGetInterconnect.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Interconnect.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Interconnect> GetInterconnectAsync(GetInterconnectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInterconnectRequest(ref request, ref callSettings);
            return _callGetInterconnect.Async(request, callSettings);
        }

        /// <summary>
        /// Get the diagnostics of a single interconnect resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DiagnoseInterconnectResponse DiagnoseInterconnect(DiagnoseInterconnectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DiagnoseInterconnectRequest(ref request, ref callSettings);
            return _callDiagnoseInterconnect.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the diagnostics of a single interconnect resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DiagnoseInterconnectResponse> DiagnoseInterconnectAsync(DiagnoseInterconnectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DiagnoseInterconnectRequest(ref request, ref callSettings);
            return _callDiagnoseInterconnect.Async(request, callSettings);
        }

        /// <summary>
        /// Lists InterconnectAttachments in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InterconnectAttachment"/> resources.</returns>
        public override gax::PagedEnumerable<ListInterconnectAttachmentsResponse, InterconnectAttachment> ListInterconnectAttachments(ListInterconnectAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInterconnectAttachmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInterconnectAttachmentsRequest, ListInterconnectAttachmentsResponse, InterconnectAttachment>(_callListInterconnectAttachments, request, callSettings);
        }

        /// <summary>
        /// Lists InterconnectAttachments in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InterconnectAttachment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInterconnectAttachmentsResponse, InterconnectAttachment> ListInterconnectAttachmentsAsync(ListInterconnectAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInterconnectAttachmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInterconnectAttachmentsRequest, ListInterconnectAttachmentsResponse, InterconnectAttachment>(_callListInterconnectAttachments, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single InterconnectAttachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InterconnectAttachment GetInterconnectAttachment(GetInterconnectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInterconnectAttachmentRequest(ref request, ref callSettings);
            return _callGetInterconnectAttachment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single InterconnectAttachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InterconnectAttachment> GetInterconnectAttachmentAsync(GetInterconnectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInterconnectAttachmentRequest(ref request, ref callSettings);
            return _callGetInterconnectAttachment.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateInterconnectAttachment</c>.</summary>
        public override lro::OperationsClient CreateInterconnectAttachmentOperationsClient { get; }

        /// <summary>
        /// Creates a new InterconnectAttachment in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InterconnectAttachment, OperationMetadata> CreateInterconnectAttachment(CreateInterconnectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInterconnectAttachmentRequest(ref request, ref callSettings);
            return new lro::Operation<InterconnectAttachment, OperationMetadata>(_callCreateInterconnectAttachment.Sync(request, callSettings), CreateInterconnectAttachmentOperationsClient);
        }

        /// <summary>
        /// Creates a new InterconnectAttachment in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InterconnectAttachment, OperationMetadata>> CreateInterconnectAttachmentAsync(CreateInterconnectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInterconnectAttachmentRequest(ref request, ref callSettings);
            return new lro::Operation<InterconnectAttachment, OperationMetadata>(await _callCreateInterconnectAttachment.Async(request, callSettings).ConfigureAwait(false), CreateInterconnectAttachmentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteInterconnectAttachment</c>.</summary>
        public override lro::OperationsClient DeleteInterconnectAttachmentOperationsClient { get; }

        /// <summary>
        /// Deletes a single InterconnectAttachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteInterconnectAttachment(DeleteInterconnectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInterconnectAttachmentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteInterconnectAttachment.Sync(request, callSettings), DeleteInterconnectAttachmentOperationsClient);
        }

        /// <summary>
        /// Deletes a single InterconnectAttachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterconnectAttachmentAsync(DeleteInterconnectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInterconnectAttachmentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteInterconnectAttachment.Async(request, callSettings).ConfigureAwait(false), DeleteInterconnectAttachmentOperationsClient);
        }

        /// <summary>
        /// Lists Routers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Router"/> resources.</returns>
        public override gax::PagedEnumerable<ListRoutersResponse, Router> ListRouters(ListRoutersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRoutersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRoutersRequest, ListRoutersResponse, Router>(_callListRouters, request, callSettings);
        }

        /// <summary>
        /// Lists Routers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Router"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRoutersResponse, Router> ListRoutersAsync(ListRoutersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRoutersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRoutersRequest, ListRoutersResponse, Router>(_callListRouters, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Router GetRouter(GetRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRouterRequest(ref request, ref callSettings);
            return _callGetRouter.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Router> GetRouterAsync(GetRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRouterRequest(ref request, ref callSettings);
            return _callGetRouter.Async(request, callSettings);
        }

        /// <summary>
        /// Get the diagnostics of a single router resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DiagnoseRouterResponse DiagnoseRouter(DiagnoseRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DiagnoseRouterRequest(ref request, ref callSettings);
            return _callDiagnoseRouter.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the diagnostics of a single router resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DiagnoseRouterResponse> DiagnoseRouterAsync(DiagnoseRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DiagnoseRouterRequest(ref request, ref callSettings);
            return _callDiagnoseRouter.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateRouter</c>.</summary>
        public override lro::OperationsClient CreateRouterOperationsClient { get; }

        /// <summary>
        /// Creates a new Router in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Router, OperationMetadata> CreateRouter(CreateRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRouterRequest(ref request, ref callSettings);
            return new lro::Operation<Router, OperationMetadata>(_callCreateRouter.Sync(request, callSettings), CreateRouterOperationsClient);
        }

        /// <summary>
        /// Creates a new Router in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Router, OperationMetadata>> CreateRouterAsync(CreateRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRouterRequest(ref request, ref callSettings);
            return new lro::Operation<Router, OperationMetadata>(await _callCreateRouter.Async(request, callSettings).ConfigureAwait(false), CreateRouterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateRouter</c>.</summary>
        public override lro::OperationsClient UpdateRouterOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Router, OperationMetadata> UpdateRouter(UpdateRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRouterRequest(ref request, ref callSettings);
            return new lro::Operation<Router, OperationMetadata>(_callUpdateRouter.Sync(request, callSettings), UpdateRouterOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Router, OperationMetadata>> UpdateRouterAsync(UpdateRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRouterRequest(ref request, ref callSettings);
            return new lro::Operation<Router, OperationMetadata>(await _callUpdateRouter.Async(request, callSettings).ConfigureAwait(false), UpdateRouterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteRouter</c>.</summary>
        public override lro::OperationsClient DeleteRouterOperationsClient { get; }

        /// <summary>
        /// Deletes a single Router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteRouter(DeleteRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRouterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteRouter.Sync(request, callSettings), DeleteRouterOperationsClient);
        }

        /// <summary>
        /// Deletes a single Router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRouterAsync(DeleteRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRouterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteRouter.Async(request, callSettings).ConfigureAwait(false), DeleteRouterOperationsClient);
        }
    }

    public partial class ListZonesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNetworksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSubnetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInterconnectsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInterconnectAttachmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRoutersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListZonesResponse : gaxgrpc::IPageResponse<Zone>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Zone> GetEnumerator() => Zones.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNetworksResponse : gaxgrpc::IPageResponse<Network>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Network> GetEnumerator() => Networks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSubnetsResponse : gaxgrpc::IPageResponse<Subnet>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Subnet> GetEnumerator() => Subnets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInterconnectsResponse : gaxgrpc::IPageResponse<Interconnect>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Interconnect> GetEnumerator() => Interconnects.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInterconnectAttachmentsResponse : gaxgrpc::IPageResponse<InterconnectAttachment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<InterconnectAttachment> GetEnumerator() => InterconnectAttachments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRoutersResponse : gaxgrpc::IPageResponse<Router>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Router> GetEnumerator() => Routers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class EdgeNetwork
    {
        public partial class EdgeNetworkClient
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

    public static partial class EdgeNetwork
    {
        public partial class EdgeNetworkClient
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
        }
    }
}
