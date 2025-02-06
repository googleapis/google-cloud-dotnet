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

namespace Google.Cloud.NetworkConnectivity.V1
{
    /// <summary>Settings for <see cref="HubServiceClient"/> instances.</summary>
    public sealed partial class HubServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="HubServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="HubServiceSettings"/>.</returns>
        public static HubServiceSettings GetDefault() => new HubServiceSettings();

        /// <summary>Constructs a new <see cref="HubServiceSettings"/> object with default settings.</summary>
        public HubServiceSettings()
        {
        }

        private HubServiceSettings(HubServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListHubsSettings = existing.ListHubsSettings;
            GetHubSettings = existing.GetHubSettings;
            CreateHubSettings = existing.CreateHubSettings;
            CreateHubOperationsSettings = existing.CreateHubOperationsSettings.Clone();
            UpdateHubSettings = existing.UpdateHubSettings;
            UpdateHubOperationsSettings = existing.UpdateHubOperationsSettings.Clone();
            DeleteHubSettings = existing.DeleteHubSettings;
            DeleteHubOperationsSettings = existing.DeleteHubOperationsSettings.Clone();
            ListHubSpokesSettings = existing.ListHubSpokesSettings;
            QueryHubStatusSettings = existing.QueryHubStatusSettings;
            ListSpokesSettings = existing.ListSpokesSettings;
            GetSpokeSettings = existing.GetSpokeSettings;
            CreateSpokeSettings = existing.CreateSpokeSettings;
            CreateSpokeOperationsSettings = existing.CreateSpokeOperationsSettings.Clone();
            UpdateSpokeSettings = existing.UpdateSpokeSettings;
            UpdateSpokeOperationsSettings = existing.UpdateSpokeOperationsSettings.Clone();
            RejectHubSpokeSettings = existing.RejectHubSpokeSettings;
            RejectHubSpokeOperationsSettings = existing.RejectHubSpokeOperationsSettings.Clone();
            AcceptHubSpokeSettings = existing.AcceptHubSpokeSettings;
            AcceptHubSpokeOperationsSettings = existing.AcceptHubSpokeOperationsSettings.Clone();
            DeleteSpokeSettings = existing.DeleteSpokeSettings;
            DeleteSpokeOperationsSettings = existing.DeleteSpokeOperationsSettings.Clone();
            GetRouteTableSettings = existing.GetRouteTableSettings;
            GetRouteSettings = existing.GetRouteSettings;
            ListRoutesSettings = existing.ListRoutesSettings;
            ListRouteTablesSettings = existing.ListRouteTablesSettings;
            GetGroupSettings = existing.GetGroupSettings;
            ListGroupsSettings = existing.ListGroupsSettings;
            UpdateGroupSettings = existing.UpdateGroupSettings;
            UpdateGroupOperationsSettings = existing.UpdateGroupOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(HubServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HubServiceClient.ListHubs</c>
        ///  and <c>HubServiceClient.ListHubsAsync</c>.
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
        public gaxgrpc::CallSettings ListHubsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HubServiceClient.GetHub</c>
        /// and <c>HubServiceClient.GetHubAsync</c>.
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
        public gaxgrpc::CallSettings GetHubSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HubServiceClient.CreateHub</c>
        ///  and <c>HubServiceClient.CreateHubAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateHubSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HubServiceClient.CreateHub</c> and
        /// <c>HubServiceClient.CreateHubAsync</c>.
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
        public lro::OperationsSettings CreateHubOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HubServiceClient.UpdateHub</c>
        ///  and <c>HubServiceClient.UpdateHubAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateHubSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HubServiceClient.UpdateHub</c> and
        /// <c>HubServiceClient.UpdateHubAsync</c>.
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
        public lro::OperationsSettings UpdateHubOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HubServiceClient.DeleteHub</c>
        ///  and <c>HubServiceClient.DeleteHubAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteHubSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HubServiceClient.DeleteHub</c> and
        /// <c>HubServiceClient.DeleteHubAsync</c>.
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
        public lro::OperationsSettings DeleteHubOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HubServiceClient.ListHubSpokes</c> and <c>HubServiceClient.ListHubSpokesAsync</c>.
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
        public gaxgrpc::CallSettings ListHubSpokesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HubServiceClient.QueryHubStatus</c> and <c>HubServiceClient.QueryHubStatusAsync</c>.
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
        public gaxgrpc::CallSettings QueryHubStatusSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HubServiceClient.ListSpokes</c>
        ///  and <c>HubServiceClient.ListSpokesAsync</c>.
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
        public gaxgrpc::CallSettings ListSpokesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HubServiceClient.GetSpoke</c>
        ///  and <c>HubServiceClient.GetSpokeAsync</c>.
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
        public gaxgrpc::CallSettings GetSpokeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HubServiceClient.CreateSpoke</c> and <c>HubServiceClient.CreateSpokeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSpokeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HubServiceClient.CreateSpoke</c> and
        /// <c>HubServiceClient.CreateSpokeAsync</c>.
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
        public lro::OperationsSettings CreateSpokeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HubServiceClient.UpdateSpoke</c> and <c>HubServiceClient.UpdateSpokeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSpokeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HubServiceClient.UpdateSpoke</c> and
        /// <c>HubServiceClient.UpdateSpokeAsync</c>.
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
        public lro::OperationsSettings UpdateSpokeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HubServiceClient.RejectHubSpoke</c> and <c>HubServiceClient.RejectHubSpokeAsync</c>.
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
        public gaxgrpc::CallSettings RejectHubSpokeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HubServiceClient.RejectHubSpoke</c> and
        /// <c>HubServiceClient.RejectHubSpokeAsync</c>.
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
        public lro::OperationsSettings RejectHubSpokeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HubServiceClient.AcceptHubSpoke</c> and <c>HubServiceClient.AcceptHubSpokeAsync</c>.
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
        public gaxgrpc::CallSettings AcceptHubSpokeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HubServiceClient.AcceptHubSpoke</c> and
        /// <c>HubServiceClient.AcceptHubSpokeAsync</c>.
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
        public lro::OperationsSettings AcceptHubSpokeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HubServiceClient.DeleteSpoke</c> and <c>HubServiceClient.DeleteSpokeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSpokeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HubServiceClient.DeleteSpoke</c> and
        /// <c>HubServiceClient.DeleteSpokeAsync</c>.
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
        public lro::OperationsSettings DeleteSpokeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HubServiceClient.GetRouteTable</c> and <c>HubServiceClient.GetRouteTableAsync</c>.
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
        public gaxgrpc::CallSettings GetRouteTableSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HubServiceClient.GetRoute</c>
        ///  and <c>HubServiceClient.GetRouteAsync</c>.
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
        public gaxgrpc::CallSettings GetRouteSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HubServiceClient.ListRoutes</c>
        ///  and <c>HubServiceClient.ListRoutesAsync</c>.
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
        public gaxgrpc::CallSettings ListRoutesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HubServiceClient.ListRouteTables</c> and <c>HubServiceClient.ListRouteTablesAsync</c>.
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
        public gaxgrpc::CallSettings ListRouteTablesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HubServiceClient.GetGroup</c>
        ///  and <c>HubServiceClient.GetGroupAsync</c>.
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
        public gaxgrpc::CallSettings GetGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HubServiceClient.ListGroups</c>
        ///  and <c>HubServiceClient.ListGroupsAsync</c>.
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
        public gaxgrpc::CallSettings ListGroupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HubServiceClient.UpdateGroup</c> and <c>HubServiceClient.UpdateGroupAsync</c>.
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
        public gaxgrpc::CallSettings UpdateGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HubServiceClient.UpdateGroup</c> and
        /// <c>HubServiceClient.UpdateGroupAsync</c>.
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
        public lro::OperationsSettings UpdateGroupOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="HubServiceSettings"/> object.</returns>
        public HubServiceSettings Clone() => new HubServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="HubServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class HubServiceClientBuilder : gaxgrpc::ClientBuilderBase<HubServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public HubServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public HubServiceClientBuilder() : base(HubServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref HubServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<HubServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override HubServiceClient Build()
        {
            HubServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<HubServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<HubServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private HubServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return HubServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<HubServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return HubServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => HubServiceClient.ChannelPool;
    }

    /// <summary>HubService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Network Connectivity Center is a hub-and-spoke abstraction for network
    /// connectivity management in Google Cloud. It reduces operational complexity
    /// through a simple, centralized connectivity management model.
    /// </remarks>
    public abstract partial class HubServiceClient
    {
        /// <summary>
        /// The default endpoint for the HubService service, which is a host of "networkconnectivity.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networkconnectivity.googleapis.com:443";

        /// <summary>The default HubService scopes.</summary>
        /// <remarks>
        /// The default HubService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(HubService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="HubServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="HubServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="HubServiceClient"/>.</returns>
        public static stt::Task<HubServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new HubServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="HubServiceClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="HubServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="HubServiceClient"/>.</returns>
        public static HubServiceClient Create() => new HubServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="HubServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="HubServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="HubServiceClient"/>.</returns>
        internal static HubServiceClient Create(grpccore::CallInvoker callInvoker, HubServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            HubService.HubServiceClient grpcClient = new HubService.HubServiceClient(callInvoker);
            return new HubServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC HubService client</summary>
        public virtual HubService.HubServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Network Connectivity Center hubs associated with a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Hub"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHubsResponse, Hub> ListHubs(ListHubsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Network Connectivity Center hubs associated with a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Hub"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHubsResponse, Hub> ListHubsAsync(ListHubsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Network Connectivity Center hubs associated with a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable sequence of <see cref="Hub"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHubsResponse, Hub> ListHubs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHubsRequest request = new ListHubsRequest
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
            return ListHubs(request, callSettings);
        }

        /// <summary>
        /// Lists the Network Connectivity Center hubs associated with a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Hub"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHubsResponse, Hub> ListHubsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHubsRequest request = new ListHubsRequest
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
            return ListHubsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the Network Connectivity Center hubs associated with a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable sequence of <see cref="Hub"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHubsResponse, Hub> ListHubs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHubsRequest request = new ListHubsRequest
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
            return ListHubs(request, callSettings);
        }

        /// <summary>
        /// Lists the Network Connectivity Center hubs associated with a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Hub"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHubsResponse, Hub> ListHubsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHubsRequest request = new ListHubsRequest
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
            return ListHubsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a Network Connectivity Center hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Hub GetHub(GetHubRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a Network Connectivity Center hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hub> GetHubAsync(GetHubRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a Network Connectivity Center hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hub> GetHubAsync(GetHubRequest request, st::CancellationToken cancellationToken) =>
            GetHubAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a Network Connectivity Center hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Hub GetHub(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHub(new GetHubRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Network Connectivity Center hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hub> GetHubAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHubAsync(new GetHubRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Network Connectivity Center hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hub> GetHubAsync(string name, st::CancellationToken cancellationToken) =>
            GetHubAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a Network Connectivity Center hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Hub GetHub(HubName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHub(new GetHubRequest
            {
                HubName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Network Connectivity Center hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hub> GetHubAsync(HubName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHubAsync(new GetHubRequest
            {
                HubName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Network Connectivity Center hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hub> GetHubAsync(HubName name, st::CancellationToken cancellationToken) =>
            GetHubAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Network Connectivity Center hub in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hub, OperationMetadata> CreateHub(CreateHubRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Network Connectivity Center hub in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> CreateHubAsync(CreateHubRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Network Connectivity Center hub in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> CreateHubAsync(CreateHubRequest request, st::CancellationToken cancellationToken) =>
            CreateHubAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateHub</c>.</summary>
        public virtual lro::OperationsClient CreateHubOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateHub</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Hub, OperationMetadata> PollOnceCreateHub(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Hub, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateHubOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateHub</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> PollOnceCreateHubAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Hub, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateHubOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Network Connectivity Center hub in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource.
        /// </param>
        /// <param name="hub">
        /// Required. The initial values for a new hub.
        /// </param>
        /// <param name="hubId">
        /// Required. A unique identifier for the hub.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hub, OperationMetadata> CreateHub(string parent, Hub hub, string hubId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHub(new CreateHubRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                HubId = gax::GaxPreconditions.CheckNotNullOrEmpty(hubId, nameof(hubId)),
                Hub = gax::GaxPreconditions.CheckNotNull(hub, nameof(hub)),
            }, callSettings);

        /// <summary>
        /// Creates a new Network Connectivity Center hub in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource.
        /// </param>
        /// <param name="hub">
        /// Required. The initial values for a new hub.
        /// </param>
        /// <param name="hubId">
        /// Required. A unique identifier for the hub.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> CreateHubAsync(string parent, Hub hub, string hubId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHubAsync(new CreateHubRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                HubId = gax::GaxPreconditions.CheckNotNullOrEmpty(hubId, nameof(hubId)),
                Hub = gax::GaxPreconditions.CheckNotNull(hub, nameof(hub)),
            }, callSettings);

        /// <summary>
        /// Creates a new Network Connectivity Center hub in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource.
        /// </param>
        /// <param name="hub">
        /// Required. The initial values for a new hub.
        /// </param>
        /// <param name="hubId">
        /// Required. A unique identifier for the hub.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> CreateHubAsync(string parent, Hub hub, string hubId, st::CancellationToken cancellationToken) =>
            CreateHubAsync(parent, hub, hubId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Network Connectivity Center hub in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource.
        /// </param>
        /// <param name="hub">
        /// Required. The initial values for a new hub.
        /// </param>
        /// <param name="hubId">
        /// Required. A unique identifier for the hub.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hub, OperationMetadata> CreateHub(gagr::LocationName parent, Hub hub, string hubId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHub(new CreateHubRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                HubId = gax::GaxPreconditions.CheckNotNullOrEmpty(hubId, nameof(hubId)),
                Hub = gax::GaxPreconditions.CheckNotNull(hub, nameof(hub)),
            }, callSettings);

        /// <summary>
        /// Creates a new Network Connectivity Center hub in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource.
        /// </param>
        /// <param name="hub">
        /// Required. The initial values for a new hub.
        /// </param>
        /// <param name="hubId">
        /// Required. A unique identifier for the hub.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> CreateHubAsync(gagr::LocationName parent, Hub hub, string hubId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHubAsync(new CreateHubRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                HubId = gax::GaxPreconditions.CheckNotNullOrEmpty(hubId, nameof(hubId)),
                Hub = gax::GaxPreconditions.CheckNotNull(hub, nameof(hub)),
            }, callSettings);

        /// <summary>
        /// Creates a new Network Connectivity Center hub in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource.
        /// </param>
        /// <param name="hub">
        /// Required. The initial values for a new hub.
        /// </param>
        /// <param name="hubId">
        /// Required. A unique identifier for the hub.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> CreateHubAsync(gagr::LocationName parent, Hub hub, string hubId, st::CancellationToken cancellationToken) =>
            CreateHubAsync(parent, hub, hubId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the description and/or labels of a Network Connectivity Center
        /// hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hub, OperationMetadata> UpdateHub(UpdateHubRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the description and/or labels of a Network Connectivity Center
        /// hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> UpdateHubAsync(UpdateHubRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the description and/or labels of a Network Connectivity Center
        /// hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> UpdateHubAsync(UpdateHubRequest request, st::CancellationToken cancellationToken) =>
            UpdateHubAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateHub</c>.</summary>
        public virtual lro::OperationsClient UpdateHubOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateHub</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Hub, OperationMetadata> PollOnceUpdateHub(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Hub, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateHubOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateHub</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> PollOnceUpdateHubAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Hub, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateHubOperationsClient, callSettings);

        /// <summary>
        /// Updates the description and/or labels of a Network Connectivity Center
        /// hub.
        /// </summary>
        /// <param name="hub">
        /// Required. The state that the hub should be in after the update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. In the case of an update to an existing hub, field mask is used
        /// to specify the fields to be overwritten. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field is
        /// overwritten if it is in the mask. If the user does not provide a mask, then
        /// all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hub, OperationMetadata> UpdateHub(Hub hub, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateHub(new UpdateHubRequest
            {
                UpdateMask = updateMask,
                Hub = gax::GaxPreconditions.CheckNotNull(hub, nameof(hub)),
            }, callSettings);

        /// <summary>
        /// Updates the description and/or labels of a Network Connectivity Center
        /// hub.
        /// </summary>
        /// <param name="hub">
        /// Required. The state that the hub should be in after the update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. In the case of an update to an existing hub, field mask is used
        /// to specify the fields to be overwritten. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field is
        /// overwritten if it is in the mask. If the user does not provide a mask, then
        /// all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> UpdateHubAsync(Hub hub, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateHubAsync(new UpdateHubRequest
            {
                UpdateMask = updateMask,
                Hub = gax::GaxPreconditions.CheckNotNull(hub, nameof(hub)),
            }, callSettings);

        /// <summary>
        /// Updates the description and/or labels of a Network Connectivity Center
        /// hub.
        /// </summary>
        /// <param name="hub">
        /// Required. The state that the hub should be in after the update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. In the case of an update to an existing hub, field mask is used
        /// to specify the fields to be overwritten. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field is
        /// overwritten if it is in the mask. If the user does not provide a mask, then
        /// all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> UpdateHubAsync(Hub hub, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateHubAsync(hub, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Network Connectivity Center hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteHub(DeleteHubRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Network Connectivity Center hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHubAsync(DeleteHubRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Network Connectivity Center hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHubAsync(DeleteHubRequest request, st::CancellationToken cancellationToken) =>
            DeleteHubAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteHub</c>.</summary>
        public virtual lro::OperationsClient DeleteHubOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteHub</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteHub(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteHubOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteHub</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteHubAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteHubOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Network Connectivity Center hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteHub(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHub(new DeleteHubRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Network Connectivity Center hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHubAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHubAsync(new DeleteHubRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Network Connectivity Center hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHubAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteHubAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Network Connectivity Center hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteHub(HubName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHub(new DeleteHubRequest
            {
                HubName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Network Connectivity Center hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHubAsync(HubName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHubAsync(new DeleteHubRequest
            {
                HubName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Network Connectivity Center hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHubAsync(HubName name, st::CancellationToken cancellationToken) =>
            DeleteHubAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the Network Connectivity Center spokes associated with a
        /// specified hub and location. The list includes both spokes that are attached
        /// to the hub and spokes that have been proposed but not yet accepted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Spoke"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHubSpokesResponse, Spoke> ListHubSpokes(ListHubSpokesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Network Connectivity Center spokes associated with a
        /// specified hub and location. The list includes both spokes that are attached
        /// to the hub and spokes that have been proposed but not yet accepted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Spoke"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHubSpokesResponse, Spoke> ListHubSpokesAsync(ListHubSpokesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Network Connectivity Center spokes associated with a
        /// specified hub and location. The list includes both spokes that are attached
        /// to the hub and spokes that have been proposed but not yet accepted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub.
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
        /// <returns>A pageable sequence of <see cref="Spoke"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHubSpokesResponse, Spoke> ListHubSpokes(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHubSpokesRequest request = new ListHubSpokesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListHubSpokes(request, callSettings);
        }

        /// <summary>
        /// Lists the Network Connectivity Center spokes associated with a
        /// specified hub and location. The list includes both spokes that are attached
        /// to the hub and spokes that have been proposed but not yet accepted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Spoke"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHubSpokesResponse, Spoke> ListHubSpokesAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHubSpokesRequest request = new ListHubSpokesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListHubSpokesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the Network Connectivity Center spokes associated with a
        /// specified hub and location. The list includes both spokes that are attached
        /// to the hub and spokes that have been proposed but not yet accepted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub.
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
        /// <returns>A pageable sequence of <see cref="Spoke"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHubSpokesResponse, Spoke> ListHubSpokes(HubName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHubSpokesRequest request = new ListHubSpokesRequest
            {
                HubName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListHubSpokes(request, callSettings);
        }

        /// <summary>
        /// Lists the Network Connectivity Center spokes associated with a
        /// specified hub and location. The list includes both spokes that are attached
        /// to the hub and spokes that have been proposed but not yet accepted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Spoke"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHubSpokesResponse, Spoke> ListHubSpokesAsync(HubName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHubSpokesRequest request = new ListHubSpokesRequest
            {
                HubName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListHubSpokesAsync(request, callSettings);
        }

        /// <summary>
        /// Query the Private Service Connect propagation status of a Network
        /// Connectivity Center hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HubStatusEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryHubStatusResponse, HubStatusEntry> QueryHubStatus(QueryHubStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Query the Private Service Connect propagation status of a Network
        /// Connectivity Center hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HubStatusEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryHubStatusResponse, HubStatusEntry> QueryHubStatusAsync(QueryHubStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Query the Private Service Connect propagation status of a Network
        /// Connectivity Center hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub.
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
        /// <returns>A pageable sequence of <see cref="HubStatusEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryHubStatusResponse, HubStatusEntry> QueryHubStatus(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryHubStatusRequest request = new QueryHubStatusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryHubStatus(request, callSettings);
        }

        /// <summary>
        /// Query the Private Service Connect propagation status of a Network
        /// Connectivity Center hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub.
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
        /// <returns>A pageable asynchronous sequence of <see cref="HubStatusEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryHubStatusResponse, HubStatusEntry> QueryHubStatusAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryHubStatusRequest request = new QueryHubStatusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryHubStatusAsync(request, callSettings);
        }

        /// <summary>
        /// Query the Private Service Connect propagation status of a Network
        /// Connectivity Center hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub.
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
        /// <returns>A pageable sequence of <see cref="HubStatusEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryHubStatusResponse, HubStatusEntry> QueryHubStatus(HubName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryHubStatusRequest request = new QueryHubStatusRequest
            {
                HubName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryHubStatus(request, callSettings);
        }

        /// <summary>
        /// Query the Private Service Connect propagation status of a Network
        /// Connectivity Center hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub.
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
        /// <returns>A pageable asynchronous sequence of <see cref="HubStatusEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryHubStatusResponse, HubStatusEntry> QueryHubStatusAsync(HubName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryHubStatusRequest request = new QueryHubStatusRequest
            {
                HubName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryHubStatusAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the Network Connectivity Center spokes in a specified project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Spoke"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpokesResponse, Spoke> ListSpokes(ListSpokesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Network Connectivity Center spokes in a specified project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Spoke"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpokesResponse, Spoke> ListSpokesAsync(ListSpokesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Network Connectivity Center spokes in a specified project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource.
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
        /// <returns>A pageable sequence of <see cref="Spoke"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpokesResponse, Spoke> ListSpokes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpokesRequest request = new ListSpokesRequest
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
            return ListSpokes(request, callSettings);
        }

        /// <summary>
        /// Lists the Network Connectivity Center spokes in a specified project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Spoke"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpokesResponse, Spoke> ListSpokesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpokesRequest request = new ListSpokesRequest
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
            return ListSpokesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the Network Connectivity Center spokes in a specified project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource.
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
        /// <returns>A pageable sequence of <see cref="Spoke"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpokesResponse, Spoke> ListSpokes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpokesRequest request = new ListSpokesRequest
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
            return ListSpokes(request, callSettings);
        }

        /// <summary>
        /// Lists the Network Connectivity Center spokes in a specified project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Spoke"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpokesResponse, Spoke> ListSpokesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpokesRequest request = new ListSpokesRequest
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
            return ListSpokesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Spoke GetSpoke(GetSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spoke> GetSpokeAsync(GetSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spoke> GetSpokeAsync(GetSpokeRequest request, st::CancellationToken cancellationToken) =>
            GetSpokeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spoke resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Spoke GetSpoke(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpoke(new GetSpokeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spoke resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spoke> GetSpokeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpokeAsync(new GetSpokeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spoke resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spoke> GetSpokeAsync(string name, st::CancellationToken cancellationToken) =>
            GetSpokeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spoke resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Spoke GetSpoke(SpokeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpoke(new GetSpokeRequest
            {
                SpokeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spoke resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spoke> GetSpokeAsync(SpokeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpokeAsync(new GetSpokeRequest
            {
                SpokeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spoke resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spoke> GetSpokeAsync(SpokeName name, st::CancellationToken cancellationToken) =>
            GetSpokeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Spoke, OperationMetadata> CreateSpoke(CreateSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> CreateSpokeAsync(CreateSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> CreateSpokeAsync(CreateSpokeRequest request, st::CancellationToken cancellationToken) =>
            CreateSpokeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSpoke</c>.</summary>
        public virtual lro::OperationsClient CreateSpokeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSpoke</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Spoke, OperationMetadata> PollOnceCreateSpoke(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Spoke, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSpokeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSpoke</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> PollOnceCreateSpokeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Spoke, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSpokeOperationsClient, callSettings);

        /// <summary>
        /// Creates a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource.
        /// </param>
        /// <param name="spoke">
        /// Required. The initial values for a new spoke.
        /// </param>
        /// <param name="spokeId">
        /// Required. Unique id for the spoke to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Spoke, OperationMetadata> CreateSpoke(string parent, Spoke spoke, string spokeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpoke(new CreateSpokeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SpokeId = gax::GaxPreconditions.CheckNotNullOrEmpty(spokeId, nameof(spokeId)),
                Spoke = gax::GaxPreconditions.CheckNotNull(spoke, nameof(spoke)),
            }, callSettings);

        /// <summary>
        /// Creates a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource.
        /// </param>
        /// <param name="spoke">
        /// Required. The initial values for a new spoke.
        /// </param>
        /// <param name="spokeId">
        /// Required. Unique id for the spoke to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> CreateSpokeAsync(string parent, Spoke spoke, string spokeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpokeAsync(new CreateSpokeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SpokeId = gax::GaxPreconditions.CheckNotNullOrEmpty(spokeId, nameof(spokeId)),
                Spoke = gax::GaxPreconditions.CheckNotNull(spoke, nameof(spoke)),
            }, callSettings);

        /// <summary>
        /// Creates a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource.
        /// </param>
        /// <param name="spoke">
        /// Required. The initial values for a new spoke.
        /// </param>
        /// <param name="spokeId">
        /// Required. Unique id for the spoke to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> CreateSpokeAsync(string parent, Spoke spoke, string spokeId, st::CancellationToken cancellationToken) =>
            CreateSpokeAsync(parent, spoke, spokeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource.
        /// </param>
        /// <param name="spoke">
        /// Required. The initial values for a new spoke.
        /// </param>
        /// <param name="spokeId">
        /// Required. Unique id for the spoke to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Spoke, OperationMetadata> CreateSpoke(gagr::LocationName parent, Spoke spoke, string spokeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpoke(new CreateSpokeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SpokeId = gax::GaxPreconditions.CheckNotNullOrEmpty(spokeId, nameof(spokeId)),
                Spoke = gax::GaxPreconditions.CheckNotNull(spoke, nameof(spoke)),
            }, callSettings);

        /// <summary>
        /// Creates a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource.
        /// </param>
        /// <param name="spoke">
        /// Required. The initial values for a new spoke.
        /// </param>
        /// <param name="spokeId">
        /// Required. Unique id for the spoke to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> CreateSpokeAsync(gagr::LocationName parent, Spoke spoke, string spokeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpokeAsync(new CreateSpokeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SpokeId = gax::GaxPreconditions.CheckNotNullOrEmpty(spokeId, nameof(spokeId)),
                Spoke = gax::GaxPreconditions.CheckNotNull(spoke, nameof(spoke)),
            }, callSettings);

        /// <summary>
        /// Creates a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource.
        /// </param>
        /// <param name="spoke">
        /// Required. The initial values for a new spoke.
        /// </param>
        /// <param name="spokeId">
        /// Required. Unique id for the spoke to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> CreateSpokeAsync(gagr::LocationName parent, Spoke spoke, string spokeId, st::CancellationToken cancellationToken) =>
            CreateSpokeAsync(parent, spoke, spokeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Spoke, OperationMetadata> UpdateSpoke(UpdateSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> UpdateSpokeAsync(UpdateSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> UpdateSpokeAsync(UpdateSpokeRequest request, st::CancellationToken cancellationToken) =>
            UpdateSpokeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateSpoke</c>.</summary>
        public virtual lro::OperationsClient UpdateSpokeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateSpoke</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Spoke, OperationMetadata> PollOnceUpdateSpoke(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Spoke, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSpokeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSpoke</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> PollOnceUpdateSpokeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Spoke, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSpokeOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="spoke">
        /// Required. The state that the spoke should be in after the update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. In the case of an update to an existing spoke, field mask is used
        /// to specify the fields to be overwritten. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field is
        /// overwritten if it is in the mask. If the user does not provide a mask, then
        /// all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Spoke, OperationMetadata> UpdateSpoke(Spoke spoke, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSpoke(new UpdateSpokeRequest
            {
                UpdateMask = updateMask,
                Spoke = gax::GaxPreconditions.CheckNotNull(spoke, nameof(spoke)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="spoke">
        /// Required. The state that the spoke should be in after the update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. In the case of an update to an existing spoke, field mask is used
        /// to specify the fields to be overwritten. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field is
        /// overwritten if it is in the mask. If the user does not provide a mask, then
        /// all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> UpdateSpokeAsync(Spoke spoke, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSpokeAsync(new UpdateSpokeRequest
            {
                UpdateMask = updateMask,
                Spoke = gax::GaxPreconditions.CheckNotNull(spoke, nameof(spoke)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="spoke">
        /// Required. The state that the spoke should be in after the update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. In the case of an update to an existing spoke, field mask is used
        /// to specify the fields to be overwritten. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field is
        /// overwritten if it is in the mask. If the user does not provide a mask, then
        /// all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> UpdateSpokeAsync(Spoke spoke, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSpokeAsync(spoke, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rejects a Network Connectivity Center spoke from being attached to a hub.
        /// If the spoke was previously in the `ACTIVE` state, it
        /// transitions to the `INACTIVE` state and is no longer able to
        /// connect to other spokes that are attached to the hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RejectHubSpokeResponse, OperationMetadata> RejectHubSpoke(RejectHubSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rejects a Network Connectivity Center spoke from being attached to a hub.
        /// If the spoke was previously in the `ACTIVE` state, it
        /// transitions to the `INACTIVE` state and is no longer able to
        /// connect to other spokes that are attached to the hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RejectHubSpokeResponse, OperationMetadata>> RejectHubSpokeAsync(RejectHubSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rejects a Network Connectivity Center spoke from being attached to a hub.
        /// If the spoke was previously in the `ACTIVE` state, it
        /// transitions to the `INACTIVE` state and is no longer able to
        /// connect to other spokes that are attached to the hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RejectHubSpokeResponse, OperationMetadata>> RejectHubSpokeAsync(RejectHubSpokeRequest request, st::CancellationToken cancellationToken) =>
            RejectHubSpokeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RejectHubSpoke</c>.</summary>
        public virtual lro::OperationsClient RejectHubSpokeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RejectHubSpoke</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RejectHubSpokeResponse, OperationMetadata> PollOnceRejectHubSpoke(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RejectHubSpokeResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RejectHubSpokeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RejectHubSpoke</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RejectHubSpokeResponse, OperationMetadata>> PollOnceRejectHubSpokeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RejectHubSpokeResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RejectHubSpokeOperationsClient, callSettings);

        /// <summary>
        /// Rejects a Network Connectivity Center spoke from being attached to a hub.
        /// If the spoke was previously in the `ACTIVE` state, it
        /// transitions to the `INACTIVE` state and is no longer able to
        /// connect to other spokes that are attached to the hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub from which to reject the spoke.
        /// </param>
        /// <param name="spokeUri">
        /// Required. The URI of the spoke to reject from the hub.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RejectHubSpokeResponse, OperationMetadata> RejectHubSpoke(string name, string spokeUri, gaxgrpc::CallSettings callSettings = null) =>
            RejectHubSpoke(new RejectHubSpokeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                SpokeUri = gax::GaxPreconditions.CheckNotNullOrEmpty(spokeUri, nameof(spokeUri)),
            }, callSettings);

        /// <summary>
        /// Rejects a Network Connectivity Center spoke from being attached to a hub.
        /// If the spoke was previously in the `ACTIVE` state, it
        /// transitions to the `INACTIVE` state and is no longer able to
        /// connect to other spokes that are attached to the hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub from which to reject the spoke.
        /// </param>
        /// <param name="spokeUri">
        /// Required. The URI of the spoke to reject from the hub.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RejectHubSpokeResponse, OperationMetadata>> RejectHubSpokeAsync(string name, string spokeUri, gaxgrpc::CallSettings callSettings = null) =>
            RejectHubSpokeAsync(new RejectHubSpokeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                SpokeUri = gax::GaxPreconditions.CheckNotNullOrEmpty(spokeUri, nameof(spokeUri)),
            }, callSettings);

        /// <summary>
        /// Rejects a Network Connectivity Center spoke from being attached to a hub.
        /// If the spoke was previously in the `ACTIVE` state, it
        /// transitions to the `INACTIVE` state and is no longer able to
        /// connect to other spokes that are attached to the hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub from which to reject the spoke.
        /// </param>
        /// <param name="spokeUri">
        /// Required. The URI of the spoke to reject from the hub.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RejectHubSpokeResponse, OperationMetadata>> RejectHubSpokeAsync(string name, string spokeUri, st::CancellationToken cancellationToken) =>
            RejectHubSpokeAsync(name, spokeUri, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rejects a Network Connectivity Center spoke from being attached to a hub.
        /// If the spoke was previously in the `ACTIVE` state, it
        /// transitions to the `INACTIVE` state and is no longer able to
        /// connect to other spokes that are attached to the hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub from which to reject the spoke.
        /// </param>
        /// <param name="spokeUri">
        /// Required. The URI of the spoke to reject from the hub.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RejectHubSpokeResponse, OperationMetadata> RejectHubSpoke(HubName name, SpokeName spokeUri, gaxgrpc::CallSettings callSettings = null) =>
            RejectHubSpoke(new RejectHubSpokeRequest
            {
                HubName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                SpokeUriAsSpokeName = gax::GaxPreconditions.CheckNotNull(spokeUri, nameof(spokeUri)),
            }, callSettings);

        /// <summary>
        /// Rejects a Network Connectivity Center spoke from being attached to a hub.
        /// If the spoke was previously in the `ACTIVE` state, it
        /// transitions to the `INACTIVE` state and is no longer able to
        /// connect to other spokes that are attached to the hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub from which to reject the spoke.
        /// </param>
        /// <param name="spokeUri">
        /// Required. The URI of the spoke to reject from the hub.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RejectHubSpokeResponse, OperationMetadata>> RejectHubSpokeAsync(HubName name, SpokeName spokeUri, gaxgrpc::CallSettings callSettings = null) =>
            RejectHubSpokeAsync(new RejectHubSpokeRequest
            {
                HubName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                SpokeUriAsSpokeName = gax::GaxPreconditions.CheckNotNull(spokeUri, nameof(spokeUri)),
            }, callSettings);

        /// <summary>
        /// Rejects a Network Connectivity Center spoke from being attached to a hub.
        /// If the spoke was previously in the `ACTIVE` state, it
        /// transitions to the `INACTIVE` state and is no longer able to
        /// connect to other spokes that are attached to the hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub from which to reject the spoke.
        /// </param>
        /// <param name="spokeUri">
        /// Required. The URI of the spoke to reject from the hub.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RejectHubSpokeResponse, OperationMetadata>> RejectHubSpokeAsync(HubName name, SpokeName spokeUri, st::CancellationToken cancellationToken) =>
            RejectHubSpokeAsync(name, spokeUri, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Accepts a proposal to attach a Network Connectivity Center spoke
        /// to a hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AcceptHubSpokeResponse, OperationMetadata> AcceptHubSpoke(AcceptHubSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Accepts a proposal to attach a Network Connectivity Center spoke
        /// to a hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AcceptHubSpokeResponse, OperationMetadata>> AcceptHubSpokeAsync(AcceptHubSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Accepts a proposal to attach a Network Connectivity Center spoke
        /// to a hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AcceptHubSpokeResponse, OperationMetadata>> AcceptHubSpokeAsync(AcceptHubSpokeRequest request, st::CancellationToken cancellationToken) =>
            AcceptHubSpokeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AcceptHubSpoke</c>.</summary>
        public virtual lro::OperationsClient AcceptHubSpokeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AcceptHubSpoke</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AcceptHubSpokeResponse, OperationMetadata> PollOnceAcceptHubSpoke(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AcceptHubSpokeResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AcceptHubSpokeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AcceptHubSpoke</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AcceptHubSpokeResponse, OperationMetadata>> PollOnceAcceptHubSpokeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AcceptHubSpokeResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AcceptHubSpokeOperationsClient, callSettings);

        /// <summary>
        /// Accepts a proposal to attach a Network Connectivity Center spoke
        /// to a hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub into which to accept the spoke.
        /// </param>
        /// <param name="spokeUri">
        /// Required. The URI of the spoke to accept into the hub.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AcceptHubSpokeResponse, OperationMetadata> AcceptHubSpoke(string name, string spokeUri, gaxgrpc::CallSettings callSettings = null) =>
            AcceptHubSpoke(new AcceptHubSpokeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                SpokeUri = gax::GaxPreconditions.CheckNotNullOrEmpty(spokeUri, nameof(spokeUri)),
            }, callSettings);

        /// <summary>
        /// Accepts a proposal to attach a Network Connectivity Center spoke
        /// to a hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub into which to accept the spoke.
        /// </param>
        /// <param name="spokeUri">
        /// Required. The URI of the spoke to accept into the hub.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AcceptHubSpokeResponse, OperationMetadata>> AcceptHubSpokeAsync(string name, string spokeUri, gaxgrpc::CallSettings callSettings = null) =>
            AcceptHubSpokeAsync(new AcceptHubSpokeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                SpokeUri = gax::GaxPreconditions.CheckNotNullOrEmpty(spokeUri, nameof(spokeUri)),
            }, callSettings);

        /// <summary>
        /// Accepts a proposal to attach a Network Connectivity Center spoke
        /// to a hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub into which to accept the spoke.
        /// </param>
        /// <param name="spokeUri">
        /// Required. The URI of the spoke to accept into the hub.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AcceptHubSpokeResponse, OperationMetadata>> AcceptHubSpokeAsync(string name, string spokeUri, st::CancellationToken cancellationToken) =>
            AcceptHubSpokeAsync(name, spokeUri, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Accepts a proposal to attach a Network Connectivity Center spoke
        /// to a hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub into which to accept the spoke.
        /// </param>
        /// <param name="spokeUri">
        /// Required. The URI of the spoke to accept into the hub.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AcceptHubSpokeResponse, OperationMetadata> AcceptHubSpoke(HubName name, SpokeName spokeUri, gaxgrpc::CallSettings callSettings = null) =>
            AcceptHubSpoke(new AcceptHubSpokeRequest
            {
                HubName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                SpokeUriAsSpokeName = gax::GaxPreconditions.CheckNotNull(spokeUri, nameof(spokeUri)),
            }, callSettings);

        /// <summary>
        /// Accepts a proposal to attach a Network Connectivity Center spoke
        /// to a hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub into which to accept the spoke.
        /// </param>
        /// <param name="spokeUri">
        /// Required. The URI of the spoke to accept into the hub.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AcceptHubSpokeResponse, OperationMetadata>> AcceptHubSpokeAsync(HubName name, SpokeName spokeUri, gaxgrpc::CallSettings callSettings = null) =>
            AcceptHubSpokeAsync(new AcceptHubSpokeRequest
            {
                HubName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                SpokeUriAsSpokeName = gax::GaxPreconditions.CheckNotNull(spokeUri, nameof(spokeUri)),
            }, callSettings);

        /// <summary>
        /// Accepts a proposal to attach a Network Connectivity Center spoke
        /// to a hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hub into which to accept the spoke.
        /// </param>
        /// <param name="spokeUri">
        /// Required. The URI of the spoke to accept into the hub.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AcceptHubSpokeResponse, OperationMetadata>> AcceptHubSpokeAsync(HubName name, SpokeName spokeUri, st::CancellationToken cancellationToken) =>
            AcceptHubSpokeAsync(name, spokeUri, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSpoke(DeleteSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSpokeAsync(DeleteSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSpokeAsync(DeleteSpokeRequest request, st::CancellationToken cancellationToken) =>
            DeleteSpokeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSpoke</c>.</summary>
        public virtual lro::OperationsClient DeleteSpokeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSpoke</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteSpoke(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSpokeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSpoke</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteSpokeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSpokeOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spoke to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSpoke(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpoke(new DeleteSpokeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spoke to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSpokeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpokeAsync(new DeleteSpokeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spoke to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSpokeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSpokeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spoke to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSpoke(SpokeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpoke(new DeleteSpokeRequest
            {
                SpokeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spoke to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSpokeAsync(SpokeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpokeAsync(new DeleteSpokeRequest
            {
                SpokeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spoke to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSpokeAsync(SpokeName name, st::CancellationToken cancellationToken) =>
            DeleteSpokeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a Network Connectivity Center route table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RouteTable GetRouteTable(GetRouteTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a Network Connectivity Center route table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RouteTable> GetRouteTableAsync(GetRouteTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a Network Connectivity Center route table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RouteTable> GetRouteTableAsync(GetRouteTableRequest request, st::CancellationToken cancellationToken) =>
            GetRouteTableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a Network Connectivity Center route table.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the route table resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RouteTable GetRouteTable(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRouteTable(new GetRouteTableRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Network Connectivity Center route table.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the route table resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RouteTable> GetRouteTableAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRouteTableAsync(new GetRouteTableRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Network Connectivity Center route table.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the route table resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RouteTable> GetRouteTableAsync(string name, st::CancellationToken cancellationToken) =>
            GetRouteTableAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a Network Connectivity Center route table.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the route table resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RouteTable GetRouteTable(RouteTableName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRouteTable(new GetRouteTableRequest
            {
                RouteTableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Network Connectivity Center route table.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the route table resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RouteTable> GetRouteTableAsync(RouteTableName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRouteTableAsync(new GetRouteTableRequest
            {
                RouteTableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Network Connectivity Center route table.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the route table resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RouteTable> GetRouteTableAsync(RouteTableName name, st::CancellationToken cancellationToken) =>
            GetRouteTableAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about the specified route.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Route GetRoute(GetRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about the specified route.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Route> GetRouteAsync(GetRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about the specified route.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Route> GetRouteAsync(GetRouteRequest request, st::CancellationToken cancellationToken) =>
            GetRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about the specified route.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the route resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Route GetRoute(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRoute(new GetRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about the specified route.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the route resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Route> GetRouteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRouteAsync(new GetRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about the specified route.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the route resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Route> GetRouteAsync(string name, st::CancellationToken cancellationToken) =>
            GetRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about the specified route.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the route resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Route GetRoute(HubRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRoute(new GetRouteRequest
            {
                HubRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about the specified route.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the route resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Route> GetRouteAsync(HubRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRouteAsync(new GetRouteRequest
            {
                HubRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about the specified route.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the route resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Route> GetRouteAsync(HubRouteName name, st::CancellationToken cancellationToken) =>
            GetRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists routes in a given route table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Route"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRoutesResponse, Route> ListRoutes(ListRoutesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists routes in a given route table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Route"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRoutesResponse, Route> ListRoutesAsync(ListRoutesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists routes in a given route table.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable sequence of <see cref="Route"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRoutesResponse, Route> ListRoutes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRoutesRequest request = new ListRoutesRequest
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
            return ListRoutes(request, callSettings);
        }

        /// <summary>
        /// Lists routes in a given route table.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Route"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRoutesResponse, Route> ListRoutesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRoutesRequest request = new ListRoutesRequest
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
            return ListRoutesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists routes in a given route table.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable sequence of <see cref="Route"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRoutesResponse, Route> ListRoutes(RouteTableName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRoutesRequest request = new ListRoutesRequest
            {
                ParentAsRouteTableName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRoutes(request, callSettings);
        }

        /// <summary>
        /// Lists routes in a given route table.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Route"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRoutesResponse, Route> ListRoutesAsync(RouteTableName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRoutesRequest request = new ListRoutesRequest
            {
                ParentAsRouteTableName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRoutesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists route tables in a given hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RouteTable"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRouteTablesResponse, RouteTable> ListRouteTables(ListRouteTablesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists route tables in a given hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RouteTable"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRouteTablesResponse, RouteTable> ListRouteTablesAsync(ListRouteTablesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists route tables in a given hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable sequence of <see cref="RouteTable"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRouteTablesResponse, RouteTable> ListRouteTables(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRouteTablesRequest request = new ListRouteTablesRequest
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
            return ListRouteTables(request, callSettings);
        }

        /// <summary>
        /// Lists route tables in a given hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="RouteTable"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRouteTablesResponse, RouteTable> ListRouteTablesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRouteTablesRequest request = new ListRouteTablesRequest
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
            return ListRouteTablesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists route tables in a given hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable sequence of <see cref="RouteTable"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRouteTablesResponse, RouteTable> ListRouteTables(HubName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRouteTablesRequest request = new ListRouteTablesRequest
            {
                ParentAsHubName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRouteTables(request, callSettings);
        }

        /// <summary>
        /// Lists route tables in a given hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="RouteTable"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRouteTablesResponse, RouteTable> ListRouteTablesAsync(HubName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRouteTablesRequest request = new ListRouteTablesRequest
            {
                ParentAsHubName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRouteTablesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a Network Connectivity Center group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group GetGroup(GetGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a Network Connectivity Center group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(GetGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a Network Connectivity Center group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(GetGroupRequest request, st::CancellationToken cancellationToken) =>
            GetGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a Network Connectivity Center group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the route table resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group GetGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGroup(new GetGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Network Connectivity Center group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the route table resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGroupAsync(new GetGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Network Connectivity Center group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the route table resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a Network Connectivity Center group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the route table resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group GetGroup(GroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGroup(new GetGroupRequest
            {
                GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Network Connectivity Center group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the route table resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(GroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGroupAsync(new GetGroupRequest
            {
                GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Network Connectivity Center group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the route table resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(GroupName name, st::CancellationToken cancellationToken) =>
            GetGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists groups in a given hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(ListGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists groups in a given hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(ListGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists groups in a given hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupsRequest request = new ListGroupsRequest
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
            return ListGroups(request, callSettings);
        }

        /// <summary>
        /// Lists groups in a given hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupsRequest request = new ListGroupsRequest
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
            return ListGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists groups in a given hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(HubName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupsRequest request = new ListGroupsRequest
            {
                ParentAsHubName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGroups(request, callSettings);
        }

        /// <summary>
        /// Lists groups in a given hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(HubName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupsRequest request = new ListGroupsRequest
            {
                ParentAsHubName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a Network Connectivity Center group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Group, OperationMetadata> UpdateGroup(UpdateGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a Network Connectivity Center group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> UpdateGroupAsync(UpdateGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a Network Connectivity Center group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> UpdateGroupAsync(UpdateGroupRequest request, st::CancellationToken cancellationToken) =>
            UpdateGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateGroup</c>.</summary>
        public virtual lro::OperationsClient UpdateGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Group, OperationMetadata> PollOnceUpdateGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Group, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> PollOnceUpdateGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Group, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGroupOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a Network Connectivity Center group.
        /// </summary>
        /// <param name="group">
        /// Required. The state that the group should be in after the update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. In the case of an update to an existing group, field mask is used
        /// to specify the fields to be overwritten. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field is
        /// overwritten if it is in the mask. If the user does not provide a mask, then
        /// all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Group, OperationMetadata> UpdateGroup(Group group, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGroup(new UpdateGroupRequest
            {
                UpdateMask = updateMask,
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a Network Connectivity Center group.
        /// </summary>
        /// <param name="group">
        /// Required. The state that the group should be in after the update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. In the case of an update to an existing group, field mask is used
        /// to specify the fields to be overwritten. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field is
        /// overwritten if it is in the mask. If the user does not provide a mask, then
        /// all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> UpdateGroupAsync(Group group, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGroupAsync(new UpdateGroupRequest
            {
                UpdateMask = updateMask,
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a Network Connectivity Center group.
        /// </summary>
        /// <param name="group">
        /// Required. The state that the group should be in after the update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. In the case of an update to an existing group, field mask is used
        /// to specify the fields to be overwritten. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field is
        /// overwritten if it is in the mask. If the user does not provide a mask, then
        /// all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> UpdateGroupAsync(Group group, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGroupAsync(group, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>HubService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Network Connectivity Center is a hub-and-spoke abstraction for network
    /// connectivity management in Google Cloud. It reduces operational complexity
    /// through a simple, centralized connectivity management model.
    /// </remarks>
    public sealed partial class HubServiceClientImpl : HubServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListHubsRequest, ListHubsResponse> _callListHubs;

        private readonly gaxgrpc::ApiCall<GetHubRequest, Hub> _callGetHub;

        private readonly gaxgrpc::ApiCall<CreateHubRequest, lro::Operation> _callCreateHub;

        private readonly gaxgrpc::ApiCall<UpdateHubRequest, lro::Operation> _callUpdateHub;

        private readonly gaxgrpc::ApiCall<DeleteHubRequest, lro::Operation> _callDeleteHub;

        private readonly gaxgrpc::ApiCall<ListHubSpokesRequest, ListHubSpokesResponse> _callListHubSpokes;

        private readonly gaxgrpc::ApiCall<QueryHubStatusRequest, QueryHubStatusResponse> _callQueryHubStatus;

        private readonly gaxgrpc::ApiCall<ListSpokesRequest, ListSpokesResponse> _callListSpokes;

        private readonly gaxgrpc::ApiCall<GetSpokeRequest, Spoke> _callGetSpoke;

        private readonly gaxgrpc::ApiCall<CreateSpokeRequest, lro::Operation> _callCreateSpoke;

        private readonly gaxgrpc::ApiCall<UpdateSpokeRequest, lro::Operation> _callUpdateSpoke;

        private readonly gaxgrpc::ApiCall<RejectHubSpokeRequest, lro::Operation> _callRejectHubSpoke;

        private readonly gaxgrpc::ApiCall<AcceptHubSpokeRequest, lro::Operation> _callAcceptHubSpoke;

        private readonly gaxgrpc::ApiCall<DeleteSpokeRequest, lro::Operation> _callDeleteSpoke;

        private readonly gaxgrpc::ApiCall<GetRouteTableRequest, RouteTable> _callGetRouteTable;

        private readonly gaxgrpc::ApiCall<GetRouteRequest, Route> _callGetRoute;

        private readonly gaxgrpc::ApiCall<ListRoutesRequest, ListRoutesResponse> _callListRoutes;

        private readonly gaxgrpc::ApiCall<ListRouteTablesRequest, ListRouteTablesResponse> _callListRouteTables;

        private readonly gaxgrpc::ApiCall<GetGroupRequest, Group> _callGetGroup;

        private readonly gaxgrpc::ApiCall<ListGroupsRequest, ListGroupsResponse> _callListGroups;

        private readonly gaxgrpc::ApiCall<UpdateGroupRequest, lro::Operation> _callUpdateGroup;

        /// <summary>
        /// Constructs a client wrapper for the HubService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="HubServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public HubServiceClientImpl(HubService.HubServiceClient grpcClient, HubServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            HubServiceSettings effectiveSettings = settings ?? HubServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateHubOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateHubOperationsSettings, logger);
            UpdateHubOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateHubOperationsSettings, logger);
            DeleteHubOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteHubOperationsSettings, logger);
            CreateSpokeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSpokeOperationsSettings, logger);
            UpdateSpokeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSpokeOperationsSettings, logger);
            RejectHubSpokeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RejectHubSpokeOperationsSettings, logger);
            AcceptHubSpokeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AcceptHubSpokeOperationsSettings, logger);
            DeleteSpokeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSpokeOperationsSettings, logger);
            UpdateGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateGroupOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListHubs = clientHelper.BuildApiCall<ListHubsRequest, ListHubsResponse>("ListHubs", grpcClient.ListHubsAsync, grpcClient.ListHubs, effectiveSettings.ListHubsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListHubs);
            Modify_ListHubsApiCall(ref _callListHubs);
            _callGetHub = clientHelper.BuildApiCall<GetHubRequest, Hub>("GetHub", grpcClient.GetHubAsync, grpcClient.GetHub, effectiveSettings.GetHubSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetHub);
            Modify_GetHubApiCall(ref _callGetHub);
            _callCreateHub = clientHelper.BuildApiCall<CreateHubRequest, lro::Operation>("CreateHub", grpcClient.CreateHubAsync, grpcClient.CreateHub, effectiveSettings.CreateHubSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateHub);
            Modify_CreateHubApiCall(ref _callCreateHub);
            _callUpdateHub = clientHelper.BuildApiCall<UpdateHubRequest, lro::Operation>("UpdateHub", grpcClient.UpdateHubAsync, grpcClient.UpdateHub, effectiveSettings.UpdateHubSettings).WithGoogleRequestParam("hub.name", request => request.Hub?.Name);
            Modify_ApiCall(ref _callUpdateHub);
            Modify_UpdateHubApiCall(ref _callUpdateHub);
            _callDeleteHub = clientHelper.BuildApiCall<DeleteHubRequest, lro::Operation>("DeleteHub", grpcClient.DeleteHubAsync, grpcClient.DeleteHub, effectiveSettings.DeleteHubSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteHub);
            Modify_DeleteHubApiCall(ref _callDeleteHub);
            _callListHubSpokes = clientHelper.BuildApiCall<ListHubSpokesRequest, ListHubSpokesResponse>("ListHubSpokes", grpcClient.ListHubSpokesAsync, grpcClient.ListHubSpokes, effectiveSettings.ListHubSpokesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListHubSpokes);
            Modify_ListHubSpokesApiCall(ref _callListHubSpokes);
            _callQueryHubStatus = clientHelper.BuildApiCall<QueryHubStatusRequest, QueryHubStatusResponse>("QueryHubStatus", grpcClient.QueryHubStatusAsync, grpcClient.QueryHubStatus, effectiveSettings.QueryHubStatusSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callQueryHubStatus);
            Modify_QueryHubStatusApiCall(ref _callQueryHubStatus);
            _callListSpokes = clientHelper.BuildApiCall<ListSpokesRequest, ListSpokesResponse>("ListSpokes", grpcClient.ListSpokesAsync, grpcClient.ListSpokes, effectiveSettings.ListSpokesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSpokes);
            Modify_ListSpokesApiCall(ref _callListSpokes);
            _callGetSpoke = clientHelper.BuildApiCall<GetSpokeRequest, Spoke>("GetSpoke", grpcClient.GetSpokeAsync, grpcClient.GetSpoke, effectiveSettings.GetSpokeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSpoke);
            Modify_GetSpokeApiCall(ref _callGetSpoke);
            _callCreateSpoke = clientHelper.BuildApiCall<CreateSpokeRequest, lro::Operation>("CreateSpoke", grpcClient.CreateSpokeAsync, grpcClient.CreateSpoke, effectiveSettings.CreateSpokeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSpoke);
            Modify_CreateSpokeApiCall(ref _callCreateSpoke);
            _callUpdateSpoke = clientHelper.BuildApiCall<UpdateSpokeRequest, lro::Operation>("UpdateSpoke", grpcClient.UpdateSpokeAsync, grpcClient.UpdateSpoke, effectiveSettings.UpdateSpokeSettings).WithGoogleRequestParam("spoke.name", request => request.Spoke?.Name);
            Modify_ApiCall(ref _callUpdateSpoke);
            Modify_UpdateSpokeApiCall(ref _callUpdateSpoke);
            _callRejectHubSpoke = clientHelper.BuildApiCall<RejectHubSpokeRequest, lro::Operation>("RejectHubSpoke", grpcClient.RejectHubSpokeAsync, grpcClient.RejectHubSpoke, effectiveSettings.RejectHubSpokeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRejectHubSpoke);
            Modify_RejectHubSpokeApiCall(ref _callRejectHubSpoke);
            _callAcceptHubSpoke = clientHelper.BuildApiCall<AcceptHubSpokeRequest, lro::Operation>("AcceptHubSpoke", grpcClient.AcceptHubSpokeAsync, grpcClient.AcceptHubSpoke, effectiveSettings.AcceptHubSpokeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callAcceptHubSpoke);
            Modify_AcceptHubSpokeApiCall(ref _callAcceptHubSpoke);
            _callDeleteSpoke = clientHelper.BuildApiCall<DeleteSpokeRequest, lro::Operation>("DeleteSpoke", grpcClient.DeleteSpokeAsync, grpcClient.DeleteSpoke, effectiveSettings.DeleteSpokeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSpoke);
            Modify_DeleteSpokeApiCall(ref _callDeleteSpoke);
            _callGetRouteTable = clientHelper.BuildApiCall<GetRouteTableRequest, RouteTable>("GetRouteTable", grpcClient.GetRouteTableAsync, grpcClient.GetRouteTable, effectiveSettings.GetRouteTableSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRouteTable);
            Modify_GetRouteTableApiCall(ref _callGetRouteTable);
            _callGetRoute = clientHelper.BuildApiCall<GetRouteRequest, Route>("GetRoute", grpcClient.GetRouteAsync, grpcClient.GetRoute, effectiveSettings.GetRouteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRoute);
            Modify_GetRouteApiCall(ref _callGetRoute);
            _callListRoutes = clientHelper.BuildApiCall<ListRoutesRequest, ListRoutesResponse>("ListRoutes", grpcClient.ListRoutesAsync, grpcClient.ListRoutes, effectiveSettings.ListRoutesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRoutes);
            Modify_ListRoutesApiCall(ref _callListRoutes);
            _callListRouteTables = clientHelper.BuildApiCall<ListRouteTablesRequest, ListRouteTablesResponse>("ListRouteTables", grpcClient.ListRouteTablesAsync, grpcClient.ListRouteTables, effectiveSettings.ListRouteTablesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRouteTables);
            Modify_ListRouteTablesApiCall(ref _callListRouteTables);
            _callGetGroup = clientHelper.BuildApiCall<GetGroupRequest, Group>("GetGroup", grpcClient.GetGroupAsync, grpcClient.GetGroup, effectiveSettings.GetGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGroup);
            Modify_GetGroupApiCall(ref _callGetGroup);
            _callListGroups = clientHelper.BuildApiCall<ListGroupsRequest, ListGroupsResponse>("ListGroups", grpcClient.ListGroupsAsync, grpcClient.ListGroups, effectiveSettings.ListGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGroups);
            Modify_ListGroupsApiCall(ref _callListGroups);
            _callUpdateGroup = clientHelper.BuildApiCall<UpdateGroupRequest, lro::Operation>("UpdateGroup", grpcClient.UpdateGroupAsync, grpcClient.UpdateGroup, effectiveSettings.UpdateGroupSettings).WithGoogleRequestParam("group.name", request => request.Group?.Name);
            Modify_ApiCall(ref _callUpdateGroup);
            Modify_UpdateGroupApiCall(ref _callUpdateGroup);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListHubsApiCall(ref gaxgrpc::ApiCall<ListHubsRequest, ListHubsResponse> call);

        partial void Modify_GetHubApiCall(ref gaxgrpc::ApiCall<GetHubRequest, Hub> call);

        partial void Modify_CreateHubApiCall(ref gaxgrpc::ApiCall<CreateHubRequest, lro::Operation> call);

        partial void Modify_UpdateHubApiCall(ref gaxgrpc::ApiCall<UpdateHubRequest, lro::Operation> call);

        partial void Modify_DeleteHubApiCall(ref gaxgrpc::ApiCall<DeleteHubRequest, lro::Operation> call);

        partial void Modify_ListHubSpokesApiCall(ref gaxgrpc::ApiCall<ListHubSpokesRequest, ListHubSpokesResponse> call);

        partial void Modify_QueryHubStatusApiCall(ref gaxgrpc::ApiCall<QueryHubStatusRequest, QueryHubStatusResponse> call);

        partial void Modify_ListSpokesApiCall(ref gaxgrpc::ApiCall<ListSpokesRequest, ListSpokesResponse> call);

        partial void Modify_GetSpokeApiCall(ref gaxgrpc::ApiCall<GetSpokeRequest, Spoke> call);

        partial void Modify_CreateSpokeApiCall(ref gaxgrpc::ApiCall<CreateSpokeRequest, lro::Operation> call);

        partial void Modify_UpdateSpokeApiCall(ref gaxgrpc::ApiCall<UpdateSpokeRequest, lro::Operation> call);

        partial void Modify_RejectHubSpokeApiCall(ref gaxgrpc::ApiCall<RejectHubSpokeRequest, lro::Operation> call);

        partial void Modify_AcceptHubSpokeApiCall(ref gaxgrpc::ApiCall<AcceptHubSpokeRequest, lro::Operation> call);

        partial void Modify_DeleteSpokeApiCall(ref gaxgrpc::ApiCall<DeleteSpokeRequest, lro::Operation> call);

        partial void Modify_GetRouteTableApiCall(ref gaxgrpc::ApiCall<GetRouteTableRequest, RouteTable> call);

        partial void Modify_GetRouteApiCall(ref gaxgrpc::ApiCall<GetRouteRequest, Route> call);

        partial void Modify_ListRoutesApiCall(ref gaxgrpc::ApiCall<ListRoutesRequest, ListRoutesResponse> call);

        partial void Modify_ListRouteTablesApiCall(ref gaxgrpc::ApiCall<ListRouteTablesRequest, ListRouteTablesResponse> call);

        partial void Modify_GetGroupApiCall(ref gaxgrpc::ApiCall<GetGroupRequest, Group> call);

        partial void Modify_ListGroupsApiCall(ref gaxgrpc::ApiCall<ListGroupsRequest, ListGroupsResponse> call);

        partial void Modify_UpdateGroupApiCall(ref gaxgrpc::ApiCall<UpdateGroupRequest, lro::Operation> call);

        partial void OnConstruction(HubService.HubServiceClient grpcClient, HubServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC HubService client</summary>
        public override HubService.HubServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListHubsRequest(ref ListHubsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetHubRequest(ref GetHubRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateHubRequest(ref CreateHubRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateHubRequest(ref UpdateHubRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteHubRequest(ref DeleteHubRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListHubSpokesRequest(ref ListHubSpokesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryHubStatusRequest(ref QueryHubStatusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSpokesRequest(ref ListSpokesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSpokeRequest(ref GetSpokeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSpokeRequest(ref CreateSpokeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSpokeRequest(ref UpdateSpokeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RejectHubSpokeRequest(ref RejectHubSpokeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AcceptHubSpokeRequest(ref AcceptHubSpokeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSpokeRequest(ref DeleteSpokeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRouteTableRequest(ref GetRouteTableRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRouteRequest(ref GetRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRoutesRequest(ref ListRoutesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRouteTablesRequest(ref ListRouteTablesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGroupRequest(ref GetGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGroupsRequest(ref ListGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGroupRequest(ref UpdateGroupRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the Network Connectivity Center hubs associated with a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Hub"/> resources.</returns>
        public override gax::PagedEnumerable<ListHubsResponse, Hub> ListHubs(ListHubsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHubsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListHubsRequest, ListHubsResponse, Hub>(_callListHubs, request, callSettings);
        }

        /// <summary>
        /// Lists the Network Connectivity Center hubs associated with a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Hub"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListHubsResponse, Hub> ListHubsAsync(ListHubsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHubsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListHubsRequest, ListHubsResponse, Hub>(_callListHubs, request, callSettings);
        }

        /// <summary>
        /// Gets details about a Network Connectivity Center hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Hub GetHub(GetHubRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHubRequest(ref request, ref callSettings);
            return _callGetHub.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a Network Connectivity Center hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Hub> GetHubAsync(GetHubRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHubRequest(ref request, ref callSettings);
            return _callGetHub.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateHub</c>.</summary>
        public override lro::OperationsClient CreateHubOperationsClient { get; }

        /// <summary>
        /// Creates a new Network Connectivity Center hub in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Hub, OperationMetadata> CreateHub(CreateHubRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHubRequest(ref request, ref callSettings);
            return new lro::Operation<Hub, OperationMetadata>(_callCreateHub.Sync(request, callSettings), CreateHubOperationsClient);
        }

        /// <summary>
        /// Creates a new Network Connectivity Center hub in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Hub, OperationMetadata>> CreateHubAsync(CreateHubRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHubRequest(ref request, ref callSettings);
            return new lro::Operation<Hub, OperationMetadata>(await _callCreateHub.Async(request, callSettings).ConfigureAwait(false), CreateHubOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateHub</c>.</summary>
        public override lro::OperationsClient UpdateHubOperationsClient { get; }

        /// <summary>
        /// Updates the description and/or labels of a Network Connectivity Center
        /// hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Hub, OperationMetadata> UpdateHub(UpdateHubRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateHubRequest(ref request, ref callSettings);
            return new lro::Operation<Hub, OperationMetadata>(_callUpdateHub.Sync(request, callSettings), UpdateHubOperationsClient);
        }

        /// <summary>
        /// Updates the description and/or labels of a Network Connectivity Center
        /// hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Hub, OperationMetadata>> UpdateHubAsync(UpdateHubRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateHubRequest(ref request, ref callSettings);
            return new lro::Operation<Hub, OperationMetadata>(await _callUpdateHub.Async(request, callSettings).ConfigureAwait(false), UpdateHubOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteHub</c>.</summary>
        public override lro::OperationsClient DeleteHubOperationsClient { get; }

        /// <summary>
        /// Deletes a Network Connectivity Center hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteHub(DeleteHubRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteHubRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteHub.Sync(request, callSettings), DeleteHubOperationsClient);
        }

        /// <summary>
        /// Deletes a Network Connectivity Center hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHubAsync(DeleteHubRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteHubRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteHub.Async(request, callSettings).ConfigureAwait(false), DeleteHubOperationsClient);
        }

        /// <summary>
        /// Lists the Network Connectivity Center spokes associated with a
        /// specified hub and location. The list includes both spokes that are attached
        /// to the hub and spokes that have been proposed but not yet accepted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Spoke"/> resources.</returns>
        public override gax::PagedEnumerable<ListHubSpokesResponse, Spoke> ListHubSpokes(ListHubSpokesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHubSpokesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListHubSpokesRequest, ListHubSpokesResponse, Spoke>(_callListHubSpokes, request, callSettings);
        }

        /// <summary>
        /// Lists the Network Connectivity Center spokes associated with a
        /// specified hub and location. The list includes both spokes that are attached
        /// to the hub and spokes that have been proposed but not yet accepted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Spoke"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListHubSpokesResponse, Spoke> ListHubSpokesAsync(ListHubSpokesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHubSpokesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListHubSpokesRequest, ListHubSpokesResponse, Spoke>(_callListHubSpokes, request, callSettings);
        }

        /// <summary>
        /// Query the Private Service Connect propagation status of a Network
        /// Connectivity Center hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HubStatusEntry"/> resources.</returns>
        public override gax::PagedEnumerable<QueryHubStatusResponse, HubStatusEntry> QueryHubStatus(QueryHubStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryHubStatusRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<QueryHubStatusRequest, QueryHubStatusResponse, HubStatusEntry>(_callQueryHubStatus, request, callSettings);
        }

        /// <summary>
        /// Query the Private Service Connect propagation status of a Network
        /// Connectivity Center hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HubStatusEntry"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<QueryHubStatusResponse, HubStatusEntry> QueryHubStatusAsync(QueryHubStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryHubStatusRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<QueryHubStatusRequest, QueryHubStatusResponse, HubStatusEntry>(_callQueryHubStatus, request, callSettings);
        }

        /// <summary>
        /// Lists the Network Connectivity Center spokes in a specified project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Spoke"/> resources.</returns>
        public override gax::PagedEnumerable<ListSpokesResponse, Spoke> ListSpokes(ListSpokesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSpokesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSpokesRequest, ListSpokesResponse, Spoke>(_callListSpokes, request, callSettings);
        }

        /// <summary>
        /// Lists the Network Connectivity Center spokes in a specified project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Spoke"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSpokesResponse, Spoke> ListSpokesAsync(ListSpokesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSpokesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSpokesRequest, ListSpokesResponse, Spoke>(_callListSpokes, request, callSettings);
        }

        /// <summary>
        /// Gets details about a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Spoke GetSpoke(GetSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpokeRequest(ref request, ref callSettings);
            return _callGetSpoke.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Spoke> GetSpokeAsync(GetSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpokeRequest(ref request, ref callSettings);
            return _callGetSpoke.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateSpoke</c>.</summary>
        public override lro::OperationsClient CreateSpokeOperationsClient { get; }

        /// <summary>
        /// Creates a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Spoke, OperationMetadata> CreateSpoke(CreateSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSpokeRequest(ref request, ref callSettings);
            return new lro::Operation<Spoke, OperationMetadata>(_callCreateSpoke.Sync(request, callSettings), CreateSpokeOperationsClient);
        }

        /// <summary>
        /// Creates a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Spoke, OperationMetadata>> CreateSpokeAsync(CreateSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSpokeRequest(ref request, ref callSettings);
            return new lro::Operation<Spoke, OperationMetadata>(await _callCreateSpoke.Async(request, callSettings).ConfigureAwait(false), CreateSpokeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateSpoke</c>.</summary>
        public override lro::OperationsClient UpdateSpokeOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Spoke, OperationMetadata> UpdateSpoke(UpdateSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSpokeRequest(ref request, ref callSettings);
            return new lro::Operation<Spoke, OperationMetadata>(_callUpdateSpoke.Sync(request, callSettings), UpdateSpokeOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Spoke, OperationMetadata>> UpdateSpokeAsync(UpdateSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSpokeRequest(ref request, ref callSettings);
            return new lro::Operation<Spoke, OperationMetadata>(await _callUpdateSpoke.Async(request, callSettings).ConfigureAwait(false), UpdateSpokeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RejectHubSpoke</c>.</summary>
        public override lro::OperationsClient RejectHubSpokeOperationsClient { get; }

        /// <summary>
        /// Rejects a Network Connectivity Center spoke from being attached to a hub.
        /// If the spoke was previously in the `ACTIVE` state, it
        /// transitions to the `INACTIVE` state and is no longer able to
        /// connect to other spokes that are attached to the hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RejectHubSpokeResponse, OperationMetadata> RejectHubSpoke(RejectHubSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RejectHubSpokeRequest(ref request, ref callSettings);
            return new lro::Operation<RejectHubSpokeResponse, OperationMetadata>(_callRejectHubSpoke.Sync(request, callSettings), RejectHubSpokeOperationsClient);
        }

        /// <summary>
        /// Rejects a Network Connectivity Center spoke from being attached to a hub.
        /// If the spoke was previously in the `ACTIVE` state, it
        /// transitions to the `INACTIVE` state and is no longer able to
        /// connect to other spokes that are attached to the hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RejectHubSpokeResponse, OperationMetadata>> RejectHubSpokeAsync(RejectHubSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RejectHubSpokeRequest(ref request, ref callSettings);
            return new lro::Operation<RejectHubSpokeResponse, OperationMetadata>(await _callRejectHubSpoke.Async(request, callSettings).ConfigureAwait(false), RejectHubSpokeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>AcceptHubSpoke</c>.</summary>
        public override lro::OperationsClient AcceptHubSpokeOperationsClient { get; }

        /// <summary>
        /// Accepts a proposal to attach a Network Connectivity Center spoke
        /// to a hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AcceptHubSpokeResponse, OperationMetadata> AcceptHubSpoke(AcceptHubSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AcceptHubSpokeRequest(ref request, ref callSettings);
            return new lro::Operation<AcceptHubSpokeResponse, OperationMetadata>(_callAcceptHubSpoke.Sync(request, callSettings), AcceptHubSpokeOperationsClient);
        }

        /// <summary>
        /// Accepts a proposal to attach a Network Connectivity Center spoke
        /// to a hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AcceptHubSpokeResponse, OperationMetadata>> AcceptHubSpokeAsync(AcceptHubSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AcceptHubSpokeRequest(ref request, ref callSettings);
            return new lro::Operation<AcceptHubSpokeResponse, OperationMetadata>(await _callAcceptHubSpoke.Async(request, callSettings).ConfigureAwait(false), AcceptHubSpokeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteSpoke</c>.</summary>
        public override lro::OperationsClient DeleteSpokeOperationsClient { get; }

        /// <summary>
        /// Deletes a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteSpoke(DeleteSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSpokeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteSpoke.Sync(request, callSettings), DeleteSpokeOperationsClient);
        }

        /// <summary>
        /// Deletes a Network Connectivity Center spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSpokeAsync(DeleteSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSpokeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteSpoke.Async(request, callSettings).ConfigureAwait(false), DeleteSpokeOperationsClient);
        }

        /// <summary>
        /// Gets details about a Network Connectivity Center route table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RouteTable GetRouteTable(GetRouteTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRouteTableRequest(ref request, ref callSettings);
            return _callGetRouteTable.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a Network Connectivity Center route table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RouteTable> GetRouteTableAsync(GetRouteTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRouteTableRequest(ref request, ref callSettings);
            return _callGetRouteTable.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details about the specified route.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Route GetRoute(GetRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRouteRequest(ref request, ref callSettings);
            return _callGetRoute.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about the specified route.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Route> GetRouteAsync(GetRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRouteRequest(ref request, ref callSettings);
            return _callGetRoute.Async(request, callSettings);
        }

        /// <summary>
        /// Lists routes in a given route table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Route"/> resources.</returns>
        public override gax::PagedEnumerable<ListRoutesResponse, Route> ListRoutes(ListRoutesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRoutesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRoutesRequest, ListRoutesResponse, Route>(_callListRoutes, request, callSettings);
        }

        /// <summary>
        /// Lists routes in a given route table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Route"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRoutesResponse, Route> ListRoutesAsync(ListRoutesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRoutesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRoutesRequest, ListRoutesResponse, Route>(_callListRoutes, request, callSettings);
        }

        /// <summary>
        /// Lists route tables in a given hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RouteTable"/> resources.</returns>
        public override gax::PagedEnumerable<ListRouteTablesResponse, RouteTable> ListRouteTables(ListRouteTablesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRouteTablesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRouteTablesRequest, ListRouteTablesResponse, RouteTable>(_callListRouteTables, request, callSettings);
        }

        /// <summary>
        /// Lists route tables in a given hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RouteTable"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRouteTablesResponse, RouteTable> ListRouteTablesAsync(ListRouteTablesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRouteTablesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRouteTablesRequest, ListRouteTablesResponse, RouteTable>(_callListRouteTables, request, callSettings);
        }

        /// <summary>
        /// Gets details about a Network Connectivity Center group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Group GetGroup(GetGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGroupRequest(ref request, ref callSettings);
            return _callGetGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a Network Connectivity Center group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Group> GetGroupAsync(GetGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGroupRequest(ref request, ref callSettings);
            return _callGetGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Lists groups in a given hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Group"/> resources.</returns>
        public override gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(ListGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGroupsRequest, ListGroupsResponse, Group>(_callListGroups, request, callSettings);
        }

        /// <summary>
        /// Lists groups in a given hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Group"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(ListGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGroupsRequest, ListGroupsResponse, Group>(_callListGroups, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateGroup</c>.</summary>
        public override lro::OperationsClient UpdateGroupOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a Network Connectivity Center group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Group, OperationMetadata> UpdateGroup(UpdateGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGroupRequest(ref request, ref callSettings);
            return new lro::Operation<Group, OperationMetadata>(_callUpdateGroup.Sync(request, callSettings), UpdateGroupOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a Network Connectivity Center group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Group, OperationMetadata>> UpdateGroupAsync(UpdateGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGroupRequest(ref request, ref callSettings);
            return new lro::Operation<Group, OperationMetadata>(await _callUpdateGroup.Async(request, callSettings).ConfigureAwait(false), UpdateGroupOperationsClient);
        }
    }

    public partial class ListHubsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListHubSpokesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class QueryHubStatusRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSpokesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRoutesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRouteTablesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListHubsResponse : gaxgrpc::IPageResponse<Hub>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Hub> GetEnumerator() => Hubs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListHubSpokesResponse : gaxgrpc::IPageResponse<Spoke>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Spoke> GetEnumerator() => Spokes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class QueryHubStatusResponse : gaxgrpc::IPageResponse<HubStatusEntry>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<HubStatusEntry> GetEnumerator() => HubStatusEntries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSpokesResponse : gaxgrpc::IPageResponse<Spoke>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Spoke> GetEnumerator() => Spokes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRoutesResponse : gaxgrpc::IPageResponse<Route>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Route> GetEnumerator() => Routes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRouteTablesResponse : gaxgrpc::IPageResponse<RouteTable>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RouteTable> GetEnumerator() => RouteTables.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGroupsResponse : gaxgrpc::IPageResponse<Group>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Group> GetEnumerator() => Groups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class HubService
    {
        public partial class HubServiceClient
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

    public static partial class HubService
    {
        public partial class HubServiceClient
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
