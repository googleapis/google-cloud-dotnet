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
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using gt = Google.Type;
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

namespace Google.Cloud.GdcHardwareManagement.V1Alpha
{
    /// <summary>Settings for <see cref="GDCHardwareManagementClient"/> instances.</summary>
    public sealed partial class GDCHardwareManagementSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GDCHardwareManagementSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GDCHardwareManagementSettings"/>.</returns>
        public static GDCHardwareManagementSettings GetDefault() => new GDCHardwareManagementSettings();

        /// <summary>
        /// Constructs a new <see cref="GDCHardwareManagementSettings"/> object with default settings.
        /// </summary>
        public GDCHardwareManagementSettings()
        {
        }

        private GDCHardwareManagementSettings(GDCHardwareManagementSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListOrdersSettings = existing.ListOrdersSettings;
            GetOrderSettings = existing.GetOrderSettings;
            CreateOrderSettings = existing.CreateOrderSettings;
            CreateOrderOperationsSettings = existing.CreateOrderOperationsSettings.Clone();
            UpdateOrderSettings = existing.UpdateOrderSettings;
            UpdateOrderOperationsSettings = existing.UpdateOrderOperationsSettings.Clone();
            DeleteOrderSettings = existing.DeleteOrderSettings;
            DeleteOrderOperationsSettings = existing.DeleteOrderOperationsSettings.Clone();
            SubmitOrderSettings = existing.SubmitOrderSettings;
            SubmitOrderOperationsSettings = existing.SubmitOrderOperationsSettings.Clone();
            CancelOrderSettings = existing.CancelOrderSettings;
            CancelOrderOperationsSettings = existing.CancelOrderOperationsSettings.Clone();
            ListSitesSettings = existing.ListSitesSettings;
            GetSiteSettings = existing.GetSiteSettings;
            CreateSiteSettings = existing.CreateSiteSettings;
            CreateSiteOperationsSettings = existing.CreateSiteOperationsSettings.Clone();
            UpdateSiteSettings = existing.UpdateSiteSettings;
            UpdateSiteOperationsSettings = existing.UpdateSiteOperationsSettings.Clone();
            DeleteSiteSettings = existing.DeleteSiteSettings;
            DeleteSiteOperationsSettings = existing.DeleteSiteOperationsSettings.Clone();
            ListHardwareGroupsSettings = existing.ListHardwareGroupsSettings;
            GetHardwareGroupSettings = existing.GetHardwareGroupSettings;
            CreateHardwareGroupSettings = existing.CreateHardwareGroupSettings;
            CreateHardwareGroupOperationsSettings = existing.CreateHardwareGroupOperationsSettings.Clone();
            UpdateHardwareGroupSettings = existing.UpdateHardwareGroupSettings;
            UpdateHardwareGroupOperationsSettings = existing.UpdateHardwareGroupOperationsSettings.Clone();
            DeleteHardwareGroupSettings = existing.DeleteHardwareGroupSettings;
            DeleteHardwareGroupOperationsSettings = existing.DeleteHardwareGroupOperationsSettings.Clone();
            ListHardwareSettings = existing.ListHardwareSettings;
            GetHardwareSettings = existing.GetHardwareSettings;
            CreateHardwareSettings = existing.CreateHardwareSettings;
            CreateHardwareOperationsSettings = existing.CreateHardwareOperationsSettings.Clone();
            UpdateHardwareSettings = existing.UpdateHardwareSettings;
            UpdateHardwareOperationsSettings = existing.UpdateHardwareOperationsSettings.Clone();
            DeleteHardwareSettings = existing.DeleteHardwareSettings;
            DeleteHardwareOperationsSettings = existing.DeleteHardwareOperationsSettings.Clone();
            ListCommentsSettings = existing.ListCommentsSettings;
            GetCommentSettings = existing.GetCommentSettings;
            CreateCommentSettings = existing.CreateCommentSettings;
            CreateCommentOperationsSettings = existing.CreateCommentOperationsSettings.Clone();
            RecordActionOnCommentSettings = existing.RecordActionOnCommentSettings;
            ListChangeLogEntriesSettings = existing.ListChangeLogEntriesSettings;
            GetChangeLogEntrySettings = existing.GetChangeLogEntrySettings;
            ListSkusSettings = existing.ListSkusSettings;
            GetSkuSettings = existing.GetSkuSettings;
            ListZonesSettings = existing.ListZonesSettings;
            GetZoneSettings = existing.GetZoneSettings;
            CreateZoneSettings = existing.CreateZoneSettings;
            CreateZoneOperationsSettings = existing.CreateZoneOperationsSettings.Clone();
            UpdateZoneSettings = existing.UpdateZoneSettings;
            UpdateZoneOperationsSettings = existing.UpdateZoneOperationsSettings.Clone();
            DeleteZoneSettings = existing.DeleteZoneSettings;
            DeleteZoneOperationsSettings = existing.DeleteZoneOperationsSettings.Clone();
            SignalZoneStateSettings = existing.SignalZoneStateSettings;
            SignalZoneStateOperationsSettings = existing.SignalZoneStateOperationsSettings.Clone();
            RequestOrderDateChangeSettings = existing.RequestOrderDateChangeSettings;
            RequestOrderDateChangeOperationsSettings = existing.RequestOrderDateChangeOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GDCHardwareManagementSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.ListOrders</c> and <c>GDCHardwareManagementClient.ListOrdersAsync</c>.
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
        public gaxgrpc::CallSettings ListOrdersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.GetOrder</c> and <c>GDCHardwareManagementClient.GetOrderAsync</c>.
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
        public gaxgrpc::CallSettings GetOrderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.CreateOrder</c> and <c>GDCHardwareManagementClient.CreateOrderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateOrderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.CreateOrder</c> and
        /// <c>GDCHardwareManagementClient.CreateOrderAsync</c>.
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
        public lro::OperationsSettings CreateOrderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.UpdateOrder</c> and <c>GDCHardwareManagementClient.UpdateOrderAsync</c>.
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
        public gaxgrpc::CallSettings UpdateOrderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.UpdateOrder</c> and
        /// <c>GDCHardwareManagementClient.UpdateOrderAsync</c>.
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
        public lro::OperationsSettings UpdateOrderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.DeleteOrder</c> and <c>GDCHardwareManagementClient.DeleteOrderAsync</c>.
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
        public gaxgrpc::CallSettings DeleteOrderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.DeleteOrder</c> and
        /// <c>GDCHardwareManagementClient.DeleteOrderAsync</c>.
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
        public lro::OperationsSettings DeleteOrderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.SubmitOrder</c> and <c>GDCHardwareManagementClient.SubmitOrderAsync</c>.
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
        public gaxgrpc::CallSettings SubmitOrderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.SubmitOrder</c> and
        /// <c>GDCHardwareManagementClient.SubmitOrderAsync</c>.
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
        public lro::OperationsSettings SubmitOrderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.CancelOrder</c> and <c>GDCHardwareManagementClient.CancelOrderAsync</c>.
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
        public gaxgrpc::CallSettings CancelOrderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.CancelOrder</c> and
        /// <c>GDCHardwareManagementClient.CancelOrderAsync</c>.
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
        public lro::OperationsSettings CancelOrderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.ListSites</c> and <c>GDCHardwareManagementClient.ListSitesAsync</c>.
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
        public gaxgrpc::CallSettings ListSitesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.GetSite</c> and <c>GDCHardwareManagementClient.GetSiteAsync</c>.
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
        public gaxgrpc::CallSettings GetSiteSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.CreateSite</c> and <c>GDCHardwareManagementClient.CreateSiteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSiteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.CreateSite</c> and
        /// <c>GDCHardwareManagementClient.CreateSiteAsync</c>.
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
        public lro::OperationsSettings CreateSiteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.UpdateSite</c> and <c>GDCHardwareManagementClient.UpdateSiteAsync</c>.
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
        public gaxgrpc::CallSettings UpdateSiteSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.UpdateSite</c> and
        /// <c>GDCHardwareManagementClient.UpdateSiteAsync</c>.
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
        public lro::OperationsSettings UpdateSiteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.DeleteSite</c> and <c>GDCHardwareManagementClient.DeleteSiteAsync</c>.
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
        public gaxgrpc::CallSettings DeleteSiteSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.DeleteSite</c> and
        /// <c>GDCHardwareManagementClient.DeleteSiteAsync</c>.
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
        public lro::OperationsSettings DeleteSiteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.ListHardwareGroups</c> and
        /// <c>GDCHardwareManagementClient.ListHardwareGroupsAsync</c>.
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
        public gaxgrpc::CallSettings ListHardwareGroupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.GetHardwareGroup</c> and <c>GDCHardwareManagementClient.GetHardwareGroupAsync</c>
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
        public gaxgrpc::CallSettings GetHardwareGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.CreateHardwareGroup</c> and
        /// <c>GDCHardwareManagementClient.CreateHardwareGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateHardwareGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.CreateHardwareGroup</c> and
        /// <c>GDCHardwareManagementClient.CreateHardwareGroupAsync</c>.
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
        public lro::OperationsSettings CreateHardwareGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.UpdateHardwareGroup</c> and
        /// <c>GDCHardwareManagementClient.UpdateHardwareGroupAsync</c>.
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
        public gaxgrpc::CallSettings UpdateHardwareGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.UpdateHardwareGroup</c> and
        /// <c>GDCHardwareManagementClient.UpdateHardwareGroupAsync</c>.
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
        public lro::OperationsSettings UpdateHardwareGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.DeleteHardwareGroup</c> and
        /// <c>GDCHardwareManagementClient.DeleteHardwareGroupAsync</c>.
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
        public gaxgrpc::CallSettings DeleteHardwareGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.DeleteHardwareGroup</c> and
        /// <c>GDCHardwareManagementClient.DeleteHardwareGroupAsync</c>.
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
        public lro::OperationsSettings DeleteHardwareGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.ListHardware</c> and <c>GDCHardwareManagementClient.ListHardwareAsync</c>.
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
        public gaxgrpc::CallSettings ListHardwareSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.GetHardware</c> and <c>GDCHardwareManagementClient.GetHardwareAsync</c>.
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
        public gaxgrpc::CallSettings GetHardwareSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.CreateHardware</c> and <c>GDCHardwareManagementClient.CreateHardwareAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateHardwareSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.CreateHardware</c> and
        /// <c>GDCHardwareManagementClient.CreateHardwareAsync</c>.
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
        public lro::OperationsSettings CreateHardwareOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.UpdateHardware</c> and <c>GDCHardwareManagementClient.UpdateHardwareAsync</c>
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
        public gaxgrpc::CallSettings UpdateHardwareSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.UpdateHardware</c> and
        /// <c>GDCHardwareManagementClient.UpdateHardwareAsync</c>.
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
        public lro::OperationsSettings UpdateHardwareOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.DeleteHardware</c> and <c>GDCHardwareManagementClient.DeleteHardwareAsync</c>
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
        public gaxgrpc::CallSettings DeleteHardwareSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.DeleteHardware</c> and
        /// <c>GDCHardwareManagementClient.DeleteHardwareAsync</c>.
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
        public lro::OperationsSettings DeleteHardwareOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.ListComments</c> and <c>GDCHardwareManagementClient.ListCommentsAsync</c>.
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
        public gaxgrpc::CallSettings ListCommentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.GetComment</c> and <c>GDCHardwareManagementClient.GetCommentAsync</c>.
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
        public gaxgrpc::CallSettings GetCommentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.CreateComment</c> and <c>GDCHardwareManagementClient.CreateCommentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCommentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.CreateComment</c> and
        /// <c>GDCHardwareManagementClient.CreateCommentAsync</c>.
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
        public lro::OperationsSettings CreateCommentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.RecordActionOnComment</c> and
        /// <c>GDCHardwareManagementClient.RecordActionOnCommentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RecordActionOnCommentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.ListChangeLogEntries</c> and
        /// <c>GDCHardwareManagementClient.ListChangeLogEntriesAsync</c>.
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
        public gaxgrpc::CallSettings ListChangeLogEntriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.GetChangeLogEntry</c> and
        /// <c>GDCHardwareManagementClient.GetChangeLogEntryAsync</c>.
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
        public gaxgrpc::CallSettings GetChangeLogEntrySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.ListSkus</c> and <c>GDCHardwareManagementClient.ListSkusAsync</c>.
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
        public gaxgrpc::CallSettings ListSkusSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.GetSku</c> and <c>GDCHardwareManagementClient.GetSkuAsync</c>.
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
        public gaxgrpc::CallSettings GetSkuSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.ListZones</c> and <c>GDCHardwareManagementClient.ListZonesAsync</c>.
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
        public gaxgrpc::CallSettings ListZonesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.GetZone</c> and <c>GDCHardwareManagementClient.GetZoneAsync</c>.
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
        public gaxgrpc::CallSettings GetZoneSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.CreateZone</c> and <c>GDCHardwareManagementClient.CreateZoneAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateZoneSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.CreateZone</c> and
        /// <c>GDCHardwareManagementClient.CreateZoneAsync</c>.
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
        public lro::OperationsSettings CreateZoneOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.UpdateZone</c> and <c>GDCHardwareManagementClient.UpdateZoneAsync</c>.
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
        public gaxgrpc::CallSettings UpdateZoneSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.UpdateZone</c> and
        /// <c>GDCHardwareManagementClient.UpdateZoneAsync</c>.
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
        public lro::OperationsSettings UpdateZoneOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.DeleteZone</c> and <c>GDCHardwareManagementClient.DeleteZoneAsync</c>.
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
        public gaxgrpc::CallSettings DeleteZoneSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.DeleteZone</c> and
        /// <c>GDCHardwareManagementClient.DeleteZoneAsync</c>.
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
        public lro::OperationsSettings DeleteZoneOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.SignalZoneState</c> and <c>GDCHardwareManagementClient.SignalZoneStateAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SignalZoneStateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.SignalZoneState</c> and
        /// <c>GDCHardwareManagementClient.SignalZoneStateAsync</c>.
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
        public lro::OperationsSettings SignalZoneStateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GDCHardwareManagementClient.RequestOrderDateChange</c> and
        /// <c>GDCHardwareManagementClient.RequestOrderDateChangeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RequestOrderDateChangeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>GDCHardwareManagementClient.RequestOrderDateChange</c> and
        /// <c>GDCHardwareManagementClient.RequestOrderDateChangeAsync</c>.
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
        public lro::OperationsSettings RequestOrderDateChangeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GDCHardwareManagementSettings"/> object.</returns>
        public GDCHardwareManagementSettings Clone() => new GDCHardwareManagementSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GDCHardwareManagementClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class GDCHardwareManagementClientBuilder : gaxgrpc::ClientBuilderBase<GDCHardwareManagementClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GDCHardwareManagementSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GDCHardwareManagementClientBuilder() : base(GDCHardwareManagementClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GDCHardwareManagementClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GDCHardwareManagementClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GDCHardwareManagementClient Build()
        {
            GDCHardwareManagementClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GDCHardwareManagementClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GDCHardwareManagementClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GDCHardwareManagementClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GDCHardwareManagementClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GDCHardwareManagementClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GDCHardwareManagementClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GDCHardwareManagementClient.ChannelPool;
    }

    /// <summary>GDCHardwareManagement client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The GDC Hardware Management service.
    /// </remarks>
    public abstract partial class GDCHardwareManagementClient
    {
        /// <summary>
        /// The default endpoint for the GDCHardwareManagement service, which is a host of
        /// "gdchardwaremanagement.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "gdchardwaremanagement.googleapis.com:443";

        /// <summary>The default GDCHardwareManagement scopes.</summary>
        /// <remarks>
        /// The default GDCHardwareManagement scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GDCHardwareManagement.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GDCHardwareManagementClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="GDCHardwareManagementClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GDCHardwareManagementClient"/>.</returns>
        public static stt::Task<GDCHardwareManagementClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GDCHardwareManagementClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GDCHardwareManagementClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="GDCHardwareManagementClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GDCHardwareManagementClient"/>.</returns>
        public static GDCHardwareManagementClient Create() => new GDCHardwareManagementClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GDCHardwareManagementClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GDCHardwareManagementSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GDCHardwareManagementClient"/>.</returns>
        internal static GDCHardwareManagementClient Create(grpccore::CallInvoker callInvoker, GDCHardwareManagementSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GDCHardwareManagement.GDCHardwareManagementClient grpcClient = new GDCHardwareManagement.GDCHardwareManagementClient(callInvoker);
            return new GDCHardwareManagementClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GDCHardwareManagement client</summary>
        public virtual GDCHardwareManagement.GDCHardwareManagementClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists orders in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Order"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrdersResponse, Order> ListOrders(ListOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists orders in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Order"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrdersResponse, Order> ListOrdersAsync(ListOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists orders in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list orders in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list orders across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        /// <returns>A pageable sequence of <see cref="Order"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrdersResponse, Order> ListOrders(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrdersRequest request = new ListOrdersRequest
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
            return ListOrders(request, callSettings);
        }

        /// <summary>
        /// Lists orders in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list orders in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list orders across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Order"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrdersResponse, Order> ListOrdersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrdersRequest request = new ListOrdersRequest
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
            return ListOrdersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists orders in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list orders in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list orders across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        /// <returns>A pageable sequence of <see cref="Order"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrdersResponse, Order> ListOrders(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrdersRequest request = new ListOrdersRequest
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
            return ListOrders(request, callSettings);
        }

        /// <summary>
        /// Lists orders in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list orders in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list orders across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Order"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrdersResponse, Order> ListOrdersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrdersRequest request = new ListOrdersRequest
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
            return ListOrdersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Order GetOrder(GetOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(GetOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(GetOrderRequest request, st::CancellationToken cancellationToken) =>
            GetOrderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of an order.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Order GetOrder(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrder(new GetOrderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of an order.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrderAsync(new GetOrderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of an order.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(string name, st::CancellationToken cancellationToken) =>
            GetOrderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of an order.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Order GetOrder(OrderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrder(new GetOrderRequest
            {
                OrderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of an order.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(OrderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrderAsync(new GetOrderRequest
            {
                OrderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of an order.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(OrderName name, st::CancellationToken cancellationToken) =>
            GetOrderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new order in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Order, OperationMetadata> CreateOrder(CreateOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new order in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> CreateOrderAsync(CreateOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new order in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> CreateOrderAsync(CreateOrderRequest request, st::CancellationToken cancellationToken) =>
            CreateOrderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateOrder</c>.</summary>
        public virtual lro::OperationsClient CreateOrderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateOrder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Order, OperationMetadata> PollOnceCreateOrder(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Order, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateOrderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateOrder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> PollOnceCreateOrderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Order, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateOrderOperationsClient, callSettings);

        /// <summary>
        /// Creates a new order in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the order in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="order">
        /// Required. The order to create.
        /// </param>
        /// <param name="orderId">
        /// Optional. ID used to uniquely identify the Order within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The order.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Order, OperationMetadata> CreateOrder(string parent, Order order, string orderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOrder(new CreateOrderRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OrderId = orderId ?? "",
                Order = gax::GaxPreconditions.CheckNotNull(order, nameof(order)),
            }, callSettings);

        /// <summary>
        /// Creates a new order in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the order in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="order">
        /// Required. The order to create.
        /// </param>
        /// <param name="orderId">
        /// Optional. ID used to uniquely identify the Order within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The order.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> CreateOrderAsync(string parent, Order order, string orderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOrderAsync(new CreateOrderRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OrderId = orderId ?? "",
                Order = gax::GaxPreconditions.CheckNotNull(order, nameof(order)),
            }, callSettings);

        /// <summary>
        /// Creates a new order in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the order in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="order">
        /// Required. The order to create.
        /// </param>
        /// <param name="orderId">
        /// Optional. ID used to uniquely identify the Order within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The order.name field in the request will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> CreateOrderAsync(string parent, Order order, string orderId, st::CancellationToken cancellationToken) =>
            CreateOrderAsync(parent, order, orderId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new order in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the order in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="order">
        /// Required. The order to create.
        /// </param>
        /// <param name="orderId">
        /// Optional. ID used to uniquely identify the Order within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The order.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Order, OperationMetadata> CreateOrder(gagr::LocationName parent, Order order, string orderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOrder(new CreateOrderRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderId = orderId ?? "",
                Order = gax::GaxPreconditions.CheckNotNull(order, nameof(order)),
            }, callSettings);

        /// <summary>
        /// Creates a new order in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the order in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="order">
        /// Required. The order to create.
        /// </param>
        /// <param name="orderId">
        /// Optional. ID used to uniquely identify the Order within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The order.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> CreateOrderAsync(gagr::LocationName parent, Order order, string orderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOrderAsync(new CreateOrderRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderId = orderId ?? "",
                Order = gax::GaxPreconditions.CheckNotNull(order, nameof(order)),
            }, callSettings);

        /// <summary>
        /// Creates a new order in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the order in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="order">
        /// Required. The order to create.
        /// </param>
        /// <param name="orderId">
        /// Optional. ID used to uniquely identify the Order within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The order.name field in the request will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> CreateOrderAsync(gagr::LocationName parent, Order order, string orderId, st::CancellationToken cancellationToken) =>
            CreateOrderAsync(parent, order, orderId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Order, OperationMetadata> UpdateOrder(UpdateOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> UpdateOrderAsync(UpdateOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> UpdateOrderAsync(UpdateOrderRequest request, st::CancellationToken cancellationToken) =>
            UpdateOrderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateOrder</c>.</summary>
        public virtual lro::OperationsClient UpdateOrderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateOrder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Order, OperationMetadata> PollOnceUpdateOrder(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Order, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateOrderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateOrder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> PollOnceUpdateOrderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Order, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateOrderOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of an order.
        /// </summary>
        /// <param name="order">
        /// Required. The order to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask to specify the fields in the Order to overwrite with this
        /// update. The fields specified in the update_mask are relative to the order,
        /// not the full request. A field will be overwritten if it is in the mask. If
        /// you don't provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Order, OperationMetadata> UpdateOrder(Order order, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateOrder(new UpdateOrderRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Order = gax::GaxPreconditions.CheckNotNull(order, nameof(order)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of an order.
        /// </summary>
        /// <param name="order">
        /// Required. The order to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask to specify the fields in the Order to overwrite with this
        /// update. The fields specified in the update_mask are relative to the order,
        /// not the full request. A field will be overwritten if it is in the mask. If
        /// you don't provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> UpdateOrderAsync(Order order, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateOrderAsync(new UpdateOrderRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Order = gax::GaxPreconditions.CheckNotNull(order, nameof(order)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of an order.
        /// </summary>
        /// <param name="order">
        /// Required. The order to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask to specify the fields in the Order to overwrite with this
        /// update. The fields specified in the update_mask are relative to the order,
        /// not the full request. A field will be overwritten if it is in the mask. If
        /// you don't provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> UpdateOrderAsync(Order order, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateOrderAsync(order, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteOrder(DeleteOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOrderAsync(DeleteOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOrderAsync(DeleteOrderRequest request, st::CancellationToken cancellationToken) =>
            DeleteOrderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteOrder</c>.</summary>
        public virtual lro::OperationsClient DeleteOrderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteOrder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteOrder(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOrderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteOrder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteOrderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOrderOperationsClient, callSettings);

        /// <summary>
        /// Deletes an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteOrder(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOrder(new DeleteOrderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOrderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOrderAsync(new DeleteOrderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOrderAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteOrderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteOrder(OrderName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOrder(new DeleteOrderRequest
            {
                OrderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOrderAsync(OrderName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOrderAsync(new DeleteOrderRequest
            {
                OrderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOrderAsync(OrderName name, st::CancellationToken cancellationToken) =>
            DeleteOrderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Order, OperationMetadata> SubmitOrder(SubmitOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Submits an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> SubmitOrderAsync(SubmitOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Submits an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> SubmitOrderAsync(SubmitOrderRequest request, st::CancellationToken cancellationToken) =>
            SubmitOrderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SubmitOrder</c>.</summary>
        public virtual lro::OperationsClient SubmitOrderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SubmitOrder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Order, OperationMetadata> PollOnceSubmitOrder(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Order, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SubmitOrderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SubmitOrder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> PollOnceSubmitOrderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Order, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SubmitOrderOperationsClient, callSettings);

        /// <summary>
        /// Submits an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Order, OperationMetadata> SubmitOrder(string name, gaxgrpc::CallSettings callSettings = null) =>
            SubmitOrder(new SubmitOrderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Submits an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> SubmitOrderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            SubmitOrderAsync(new SubmitOrderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Submits an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> SubmitOrderAsync(string name, st::CancellationToken cancellationToken) =>
            SubmitOrderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Order, OperationMetadata> SubmitOrder(OrderName name, gaxgrpc::CallSettings callSettings = null) =>
            SubmitOrder(new SubmitOrderRequest
            {
                OrderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Submits an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> SubmitOrderAsync(OrderName name, gaxgrpc::CallSettings callSettings = null) =>
            SubmitOrderAsync(new SubmitOrderRequest
            {
                OrderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Submits an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> SubmitOrderAsync(OrderName name, st::CancellationToken cancellationToken) =>
            SubmitOrderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Order, OperationMetadata> CancelOrder(CancelOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> CancelOrderAsync(CancelOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> CancelOrderAsync(CancelOrderRequest request, st::CancellationToken cancellationToken) =>
            CancelOrderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CancelOrder</c>.</summary>
        public virtual lro::OperationsClient CancelOrderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CancelOrder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Order, OperationMetadata> PollOnceCancelOrder(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Order, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CancelOrderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CancelOrder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> PollOnceCancelOrderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Order, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CancelOrderOperationsClient, callSettings);

        /// <summary>
        /// Cancels an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Order, OperationMetadata> CancelOrder(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelOrder(new CancelOrderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> CancelOrderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelOrderAsync(new CancelOrderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> CancelOrderAsync(string name, st::CancellationToken cancellationToken) =>
            CancelOrderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Order, OperationMetadata> CancelOrder(OrderName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelOrder(new CancelOrderRequest
            {
                OrderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> CancelOrderAsync(OrderName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelOrderAsync(new CancelOrderRequest
            {
                OrderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> CancelOrderAsync(OrderName name, st::CancellationToken cancellationToken) =>
            CancelOrderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists sites in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Site"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSitesResponse, Site> ListSites(ListSitesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists sites in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Site"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSitesResponse, Site> ListSitesAsync(ListSitesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists sites in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list sites in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list sites across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        /// <returns>A pageable sequence of <see cref="Site"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSitesResponse, Site> ListSites(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSitesRequest request = new ListSitesRequest
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
            return ListSites(request, callSettings);
        }

        /// <summary>
        /// Lists sites in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list sites in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list sites across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Site"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSitesResponse, Site> ListSitesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSitesRequest request = new ListSitesRequest
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
            return ListSitesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists sites in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list sites in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list sites across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        /// <returns>A pageable sequence of <see cref="Site"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSitesResponse, Site> ListSites(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSitesRequest request = new ListSitesRequest
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
            return ListSites(request, callSettings);
        }

        /// <summary>
        /// Lists sites in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list sites in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list sites across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Site"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSitesResponse, Site> ListSitesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSitesRequest request = new ListSitesRequest
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
            return ListSitesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a site.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Site GetSite(GetSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a site.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> GetSiteAsync(GetSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a site.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> GetSiteAsync(GetSiteRequest request, st::CancellationToken cancellationToken) =>
            GetSiteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a site.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the site.
        /// Format: `projects/{project}/locations/{location}/sites/{site}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Site GetSite(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSite(new GetSiteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a site.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the site.
        /// Format: `projects/{project}/locations/{location}/sites/{site}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> GetSiteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSiteAsync(new GetSiteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a site.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the site.
        /// Format: `projects/{project}/locations/{location}/sites/{site}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> GetSiteAsync(string name, st::CancellationToken cancellationToken) =>
            GetSiteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a site.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the site.
        /// Format: `projects/{project}/locations/{location}/sites/{site}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Site GetSite(SiteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSite(new GetSiteRequest
            {
                SiteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a site.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the site.
        /// Format: `projects/{project}/locations/{location}/sites/{site}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> GetSiteAsync(SiteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSiteAsync(new GetSiteRequest
            {
                SiteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a site.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the site.
        /// Format: `projects/{project}/locations/{location}/sites/{site}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> GetSiteAsync(SiteName name, st::CancellationToken cancellationToken) =>
            GetSiteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new site in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Site, OperationMetadata> CreateSite(CreateSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new site in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Site, OperationMetadata>> CreateSiteAsync(CreateSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new site in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Site, OperationMetadata>> CreateSiteAsync(CreateSiteRequest request, st::CancellationToken cancellationToken) =>
            CreateSiteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSite</c>.</summary>
        public virtual lro::OperationsClient CreateSiteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSite</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Site, OperationMetadata> PollOnceCreateSite(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Site, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSiteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSite</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Site, OperationMetadata>> PollOnceCreateSiteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Site, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSiteOperationsClient, callSettings);

        /// <summary>
        /// Creates a new site in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the site in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="site">
        /// Required. The site to create.
        /// </param>
        /// <param name="siteId">
        /// Optional. ID used to uniquely identify the Site within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The site.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Site, OperationMetadata> CreateSite(string parent, Site site, string siteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSite(new CreateSiteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SiteId = siteId ?? "",
                Site = gax::GaxPreconditions.CheckNotNull(site, nameof(site)),
            }, callSettings);

        /// <summary>
        /// Creates a new site in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the site in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="site">
        /// Required. The site to create.
        /// </param>
        /// <param name="siteId">
        /// Optional. ID used to uniquely identify the Site within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The site.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Site, OperationMetadata>> CreateSiteAsync(string parent, Site site, string siteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSiteAsync(new CreateSiteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SiteId = siteId ?? "",
                Site = gax::GaxPreconditions.CheckNotNull(site, nameof(site)),
            }, callSettings);

        /// <summary>
        /// Creates a new site in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the site in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="site">
        /// Required. The site to create.
        /// </param>
        /// <param name="siteId">
        /// Optional. ID used to uniquely identify the Site within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The site.name field in the request will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Site, OperationMetadata>> CreateSiteAsync(string parent, Site site, string siteId, st::CancellationToken cancellationToken) =>
            CreateSiteAsync(parent, site, siteId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new site in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the site in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="site">
        /// Required. The site to create.
        /// </param>
        /// <param name="siteId">
        /// Optional. ID used to uniquely identify the Site within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The site.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Site, OperationMetadata> CreateSite(gagr::LocationName parent, Site site, string siteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSite(new CreateSiteRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SiteId = siteId ?? "",
                Site = gax::GaxPreconditions.CheckNotNull(site, nameof(site)),
            }, callSettings);

        /// <summary>
        /// Creates a new site in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the site in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="site">
        /// Required. The site to create.
        /// </param>
        /// <param name="siteId">
        /// Optional. ID used to uniquely identify the Site within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The site.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Site, OperationMetadata>> CreateSiteAsync(gagr::LocationName parent, Site site, string siteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSiteAsync(new CreateSiteRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SiteId = siteId ?? "",
                Site = gax::GaxPreconditions.CheckNotNull(site, nameof(site)),
            }, callSettings);

        /// <summary>
        /// Creates a new site in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the site in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="site">
        /// Required. The site to create.
        /// </param>
        /// <param name="siteId">
        /// Optional. ID used to uniquely identify the Site within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The site.name field in the request will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Site, OperationMetadata>> CreateSiteAsync(gagr::LocationName parent, Site site, string siteId, st::CancellationToken cancellationToken) =>
            CreateSiteAsync(parent, site, siteId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a site.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Site, OperationMetadata> UpdateSite(UpdateSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a site.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Site, OperationMetadata>> UpdateSiteAsync(UpdateSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a site.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Site, OperationMetadata>> UpdateSiteAsync(UpdateSiteRequest request, st::CancellationToken cancellationToken) =>
            UpdateSiteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateSite</c>.</summary>
        public virtual lro::OperationsClient UpdateSiteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateSite</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Site, OperationMetadata> PollOnceUpdateSite(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Site, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSiteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSite</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Site, OperationMetadata>> PollOnceUpdateSiteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Site, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSiteOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a site.
        /// </summary>
        /// <param name="site">
        /// Required. The site to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask to specify the fields in the Site to overwrite with this
        /// update. The fields specified in the update_mask are relative to the site,
        /// not the full request. A field will be overwritten if it is in the mask. If
        /// you don't provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Site, OperationMetadata> UpdateSite(Site site, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSite(new UpdateSiteRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Site = gax::GaxPreconditions.CheckNotNull(site, nameof(site)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a site.
        /// </summary>
        /// <param name="site">
        /// Required. The site to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask to specify the fields in the Site to overwrite with this
        /// update. The fields specified in the update_mask are relative to the site,
        /// not the full request. A field will be overwritten if it is in the mask. If
        /// you don't provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Site, OperationMetadata>> UpdateSiteAsync(Site site, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSiteAsync(new UpdateSiteRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Site = gax::GaxPreconditions.CheckNotNull(site, nameof(site)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a site.
        /// </summary>
        /// <param name="site">
        /// Required. The site to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask to specify the fields in the Site to overwrite with this
        /// update. The fields specified in the update_mask are relative to the site,
        /// not the full request. A field will be overwritten if it is in the mask. If
        /// you don't provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Site, OperationMetadata>> UpdateSiteAsync(Site site, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSiteAsync(site, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a site.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSite(DeleteSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a site.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSiteAsync(DeleteSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a site.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSiteAsync(DeleteSiteRequest request, st::CancellationToken cancellationToken) =>
            DeleteSiteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSite</c>.</summary>
        public virtual lro::OperationsClient DeleteSiteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSite</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteSite(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSiteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSite</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteSiteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSiteOperationsClient, callSettings);

        /// <summary>
        /// Deletes a site.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the site.
        /// Format: `projects/{project}/locations/{location}/sites/{site}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSite(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSite(new DeleteSiteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a site.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the site.
        /// Format: `projects/{project}/locations/{location}/sites/{site}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSiteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSiteAsync(new DeleteSiteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a site.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the site.
        /// Format: `projects/{project}/locations/{location}/sites/{site}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSiteAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSiteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a site.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the site.
        /// Format: `projects/{project}/locations/{location}/sites/{site}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSite(SiteName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSite(new DeleteSiteRequest
            {
                SiteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a site.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the site.
        /// Format: `projects/{project}/locations/{location}/sites/{site}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSiteAsync(SiteName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSiteAsync(new DeleteSiteRequest
            {
                SiteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a site.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the site.
        /// Format: `projects/{project}/locations/{location}/sites/{site}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSiteAsync(SiteName name, st::CancellationToken cancellationToken) =>
            DeleteSiteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists hardware groups in a given order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HardwareGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHardwareGroupsResponse, HardwareGroup> ListHardwareGroups(ListHardwareGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists hardware groups in a given order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HardwareGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHardwareGroupsResponse, HardwareGroup> ListHardwareGroupsAsync(ListHardwareGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists hardware groups in a given order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to list hardware groups in.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
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
        /// <returns>A pageable sequence of <see cref="HardwareGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHardwareGroupsResponse, HardwareGroup> ListHardwareGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHardwareGroupsRequest request = new ListHardwareGroupsRequest
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
            return ListHardwareGroups(request, callSettings);
        }

        /// <summary>
        /// Lists hardware groups in a given order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to list hardware groups in.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="HardwareGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHardwareGroupsResponse, HardwareGroup> ListHardwareGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHardwareGroupsRequest request = new ListHardwareGroupsRequest
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
            return ListHardwareGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists hardware groups in a given order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to list hardware groups in.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
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
        /// <returns>A pageable sequence of <see cref="HardwareGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHardwareGroupsResponse, HardwareGroup> ListHardwareGroups(OrderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHardwareGroupsRequest request = new ListHardwareGroupsRequest
            {
                ParentAsOrderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListHardwareGroups(request, callSettings);
        }

        /// <summary>
        /// Lists hardware groups in a given order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to list hardware groups in.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="HardwareGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHardwareGroupsResponse, HardwareGroup> ListHardwareGroupsAsync(OrderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHardwareGroupsRequest request = new ListHardwareGroupsRequest
            {
                ParentAsOrderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListHardwareGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a hardware group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HardwareGroup GetHardwareGroup(GetHardwareGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a hardware group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HardwareGroup> GetHardwareGroupAsync(GetHardwareGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a hardware group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HardwareGroup> GetHardwareGroupAsync(GetHardwareGroupRequest request, st::CancellationToken cancellationToken) =>
            GetHardwareGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a hardware group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware group.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HardwareGroup GetHardwareGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHardwareGroup(new GetHardwareGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a hardware group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware group.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HardwareGroup> GetHardwareGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHardwareGroupAsync(new GetHardwareGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a hardware group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware group.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HardwareGroup> GetHardwareGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetHardwareGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a hardware group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware group.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HardwareGroup GetHardwareGroup(HardwareGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHardwareGroup(new GetHardwareGroupRequest
            {
                HardwareGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a hardware group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware group.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HardwareGroup> GetHardwareGroupAsync(HardwareGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHardwareGroupAsync(new GetHardwareGroupRequest
            {
                HardwareGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a hardware group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware group.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HardwareGroup> GetHardwareGroupAsync(HardwareGroupName name, st::CancellationToken cancellationToken) =>
            GetHardwareGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new hardware group in a given order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<HardwareGroup, OperationMetadata> CreateHardwareGroup(CreateHardwareGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new hardware group in a given order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HardwareGroup, OperationMetadata>> CreateHardwareGroupAsync(CreateHardwareGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new hardware group in a given order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HardwareGroup, OperationMetadata>> CreateHardwareGroupAsync(CreateHardwareGroupRequest request, st::CancellationToken cancellationToken) =>
            CreateHardwareGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateHardwareGroup</c>.</summary>
        public virtual lro::OperationsClient CreateHardwareGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateHardwareGroup</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<HardwareGroup, OperationMetadata> PollOnceCreateHardwareGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<HardwareGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateHardwareGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateHardwareGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<HardwareGroup, OperationMetadata>> PollOnceCreateHardwareGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<HardwareGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateHardwareGroupOperationsClient, callSettings);

        /// <summary>
        /// Creates a new hardware group in a given order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to create the hardware group in.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="hardwareGroup">
        /// Required. The hardware group to create.
        /// </param>
        /// <param name="hardwareGroupId">
        /// Optional. ID used to uniquely identify the HardwareGroup within its parent
        /// scope. This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The hardware_group.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<HardwareGroup, OperationMetadata> CreateHardwareGroup(string parent, HardwareGroup hardwareGroup, string hardwareGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHardwareGroup(new CreateHardwareGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                HardwareGroupId = hardwareGroupId ?? "",
                HardwareGroup = gax::GaxPreconditions.CheckNotNull(hardwareGroup, nameof(hardwareGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a new hardware group in a given order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to create the hardware group in.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="hardwareGroup">
        /// Required. The hardware group to create.
        /// </param>
        /// <param name="hardwareGroupId">
        /// Optional. ID used to uniquely identify the HardwareGroup within its parent
        /// scope. This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The hardware_group.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HardwareGroup, OperationMetadata>> CreateHardwareGroupAsync(string parent, HardwareGroup hardwareGroup, string hardwareGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHardwareGroupAsync(new CreateHardwareGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                HardwareGroupId = hardwareGroupId ?? "",
                HardwareGroup = gax::GaxPreconditions.CheckNotNull(hardwareGroup, nameof(hardwareGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a new hardware group in a given order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to create the hardware group in.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="hardwareGroup">
        /// Required. The hardware group to create.
        /// </param>
        /// <param name="hardwareGroupId">
        /// Optional. ID used to uniquely identify the HardwareGroup within its parent
        /// scope. This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The hardware_group.name field in the request will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HardwareGroup, OperationMetadata>> CreateHardwareGroupAsync(string parent, HardwareGroup hardwareGroup, string hardwareGroupId, st::CancellationToken cancellationToken) =>
            CreateHardwareGroupAsync(parent, hardwareGroup, hardwareGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new hardware group in a given order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to create the hardware group in.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="hardwareGroup">
        /// Required. The hardware group to create.
        /// </param>
        /// <param name="hardwareGroupId">
        /// Optional. ID used to uniquely identify the HardwareGroup within its parent
        /// scope. This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The hardware_group.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<HardwareGroup, OperationMetadata> CreateHardwareGroup(OrderName parent, HardwareGroup hardwareGroup, string hardwareGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHardwareGroup(new CreateHardwareGroupRequest
            {
                ParentAsOrderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                HardwareGroupId = hardwareGroupId ?? "",
                HardwareGroup = gax::GaxPreconditions.CheckNotNull(hardwareGroup, nameof(hardwareGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a new hardware group in a given order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to create the hardware group in.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="hardwareGroup">
        /// Required. The hardware group to create.
        /// </param>
        /// <param name="hardwareGroupId">
        /// Optional. ID used to uniquely identify the HardwareGroup within its parent
        /// scope. This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The hardware_group.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HardwareGroup, OperationMetadata>> CreateHardwareGroupAsync(OrderName parent, HardwareGroup hardwareGroup, string hardwareGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHardwareGroupAsync(new CreateHardwareGroupRequest
            {
                ParentAsOrderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                HardwareGroupId = hardwareGroupId ?? "",
                HardwareGroup = gax::GaxPreconditions.CheckNotNull(hardwareGroup, nameof(hardwareGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a new hardware group in a given order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to create the hardware group in.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="hardwareGroup">
        /// Required. The hardware group to create.
        /// </param>
        /// <param name="hardwareGroupId">
        /// Optional. ID used to uniquely identify the HardwareGroup within its parent
        /// scope. This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The hardware_group.name field in the request will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HardwareGroup, OperationMetadata>> CreateHardwareGroupAsync(OrderName parent, HardwareGroup hardwareGroup, string hardwareGroupId, st::CancellationToken cancellationToken) =>
            CreateHardwareGroupAsync(parent, hardwareGroup, hardwareGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a hardware group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<HardwareGroup, OperationMetadata> UpdateHardwareGroup(UpdateHardwareGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a hardware group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HardwareGroup, OperationMetadata>> UpdateHardwareGroupAsync(UpdateHardwareGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a hardware group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HardwareGroup, OperationMetadata>> UpdateHardwareGroupAsync(UpdateHardwareGroupRequest request, st::CancellationToken cancellationToken) =>
            UpdateHardwareGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateHardwareGroup</c>.</summary>
        public virtual lro::OperationsClient UpdateHardwareGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateHardwareGroup</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<HardwareGroup, OperationMetadata> PollOnceUpdateHardwareGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<HardwareGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateHardwareGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateHardwareGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<HardwareGroup, OperationMetadata>> PollOnceUpdateHardwareGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<HardwareGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateHardwareGroupOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a hardware group.
        /// </summary>
        /// <param name="hardwareGroup">
        /// Required. The hardware group to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask to specify the fields in the HardwareGroup to overwrite
        /// with this update. The fields specified in the update_mask are relative to
        /// the hardware group, not the full request. A field will be overwritten if it
        /// is in the mask. If you don't provide a mask then all fields will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<HardwareGroup, OperationMetadata> UpdateHardwareGroup(HardwareGroup hardwareGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateHardwareGroup(new UpdateHardwareGroupRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                HardwareGroup = gax::GaxPreconditions.CheckNotNull(hardwareGroup, nameof(hardwareGroup)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a hardware group.
        /// </summary>
        /// <param name="hardwareGroup">
        /// Required. The hardware group to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask to specify the fields in the HardwareGroup to overwrite
        /// with this update. The fields specified in the update_mask are relative to
        /// the hardware group, not the full request. A field will be overwritten if it
        /// is in the mask. If you don't provide a mask then all fields will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HardwareGroup, OperationMetadata>> UpdateHardwareGroupAsync(HardwareGroup hardwareGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateHardwareGroupAsync(new UpdateHardwareGroupRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                HardwareGroup = gax::GaxPreconditions.CheckNotNull(hardwareGroup, nameof(hardwareGroup)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a hardware group.
        /// </summary>
        /// <param name="hardwareGroup">
        /// Required. The hardware group to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask to specify the fields in the HardwareGroup to overwrite
        /// with this update. The fields specified in the update_mask are relative to
        /// the hardware group, not the full request. A field will be overwritten if it
        /// is in the mask. If you don't provide a mask then all fields will be
        /// overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HardwareGroup, OperationMetadata>> UpdateHardwareGroupAsync(HardwareGroup hardwareGroup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateHardwareGroupAsync(hardwareGroup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a hardware group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteHardwareGroup(DeleteHardwareGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a hardware group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHardwareGroupAsync(DeleteHardwareGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a hardware group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHardwareGroupAsync(DeleteHardwareGroupRequest request, st::CancellationToken cancellationToken) =>
            DeleteHardwareGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteHardwareGroup</c>.</summary>
        public virtual lro::OperationsClient DeleteHardwareGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteHardwareGroup</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteHardwareGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteHardwareGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteHardwareGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteHardwareGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteHardwareGroupOperationsClient, callSettings);

        /// <summary>
        /// Deletes a hardware group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware group.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteHardwareGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHardwareGroup(new DeleteHardwareGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a hardware group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware group.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHardwareGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHardwareGroupAsync(new DeleteHardwareGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a hardware group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware group.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHardwareGroupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteHardwareGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a hardware group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware group.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteHardwareGroup(HardwareGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHardwareGroup(new DeleteHardwareGroupRequest
            {
                HardwareGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a hardware group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware group.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHardwareGroupAsync(HardwareGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHardwareGroupAsync(new DeleteHardwareGroupRequest
            {
                HardwareGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a hardware group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware group.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/hardwareGroups/{hardware_group}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHardwareGroupAsync(HardwareGroupName name, st::CancellationToken cancellationToken) =>
            DeleteHardwareGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists hardware in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Hardware"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHardwareResponse, Hardware> ListHardware(ListHardwareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists hardware in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Hardware"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHardwareResponse, Hardware> ListHardwareAsync(ListHardwareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists hardware in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list hardware in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list hardware across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        /// <returns>A pageable sequence of <see cref="Hardware"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHardwareResponse, Hardware> ListHardware(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHardwareRequest request = new ListHardwareRequest
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
            return ListHardware(request, callSettings);
        }

        /// <summary>
        /// Lists hardware in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list hardware in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list hardware across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Hardware"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHardwareResponse, Hardware> ListHardwareAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHardwareRequest request = new ListHardwareRequest
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
            return ListHardwareAsync(request, callSettings);
        }

        /// <summary>
        /// Lists hardware in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list hardware in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list hardware across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        /// <returns>A pageable sequence of <see cref="Hardware"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHardwareResponse, Hardware> ListHardware(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHardwareRequest request = new ListHardwareRequest
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
            return ListHardware(request, callSettings);
        }

        /// <summary>
        /// Lists hardware in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list hardware in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list hardware across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Hardware"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHardwareResponse, Hardware> ListHardwareAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHardwareRequest request = new ListHardwareRequest
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
            return ListHardwareAsync(request, callSettings);
        }

        /// <summary>
        /// Gets hardware details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Hardware GetHardware(GetHardwareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets hardware details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hardware> GetHardwareAsync(GetHardwareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets hardware details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hardware> GetHardwareAsync(GetHardwareRequest request, st::CancellationToken cancellationToken) =>
            GetHardwareAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets hardware details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware.
        /// Format: `projects/{project}/locations/{location}/hardware/{hardware}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Hardware GetHardware(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHardware(new GetHardwareRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets hardware details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware.
        /// Format: `projects/{project}/locations/{location}/hardware/{hardware}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hardware> GetHardwareAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHardwareAsync(new GetHardwareRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets hardware details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware.
        /// Format: `projects/{project}/locations/{location}/hardware/{hardware}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hardware> GetHardwareAsync(string name, st::CancellationToken cancellationToken) =>
            GetHardwareAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets hardware details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware.
        /// Format: `projects/{project}/locations/{location}/hardware/{hardware}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Hardware GetHardware(HardwareName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHardware(new GetHardwareRequest
            {
                HardwareName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets hardware details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware.
        /// Format: `projects/{project}/locations/{location}/hardware/{hardware}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hardware> GetHardwareAsync(HardwareName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHardwareAsync(new GetHardwareRequest
            {
                HardwareName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets hardware details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware.
        /// Format: `projects/{project}/locations/{location}/hardware/{hardware}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hardware> GetHardwareAsync(HardwareName name, st::CancellationToken cancellationToken) =>
            GetHardwareAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new hardware in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hardware, OperationMetadata> CreateHardware(CreateHardwareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new hardware in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hardware, OperationMetadata>> CreateHardwareAsync(CreateHardwareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new hardware in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hardware, OperationMetadata>> CreateHardwareAsync(CreateHardwareRequest request, st::CancellationToken cancellationToken) =>
            CreateHardwareAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateHardware</c>.</summary>
        public virtual lro::OperationsClient CreateHardwareOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateHardware</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Hardware, OperationMetadata> PollOnceCreateHardware(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Hardware, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateHardwareOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateHardware</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Hardware, OperationMetadata>> PollOnceCreateHardwareAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Hardware, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateHardwareOperationsClient, callSettings);

        /// <summary>
        /// Creates new hardware in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create hardware in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="hardware">
        /// Required. The resource to create.
        /// </param>
        /// <param name="hardwareId">
        /// Optional. ID used to uniquely identify the Hardware within its parent
        /// scope. This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The hardware.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hardware, OperationMetadata> CreateHardware(string parent, Hardware hardware, string hardwareId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHardware(new CreateHardwareRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                HardwareId = hardwareId ?? "",
                Hardware = gax::GaxPreconditions.CheckNotNull(hardware, nameof(hardware)),
            }, callSettings);

        /// <summary>
        /// Creates new hardware in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create hardware in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="hardware">
        /// Required. The resource to create.
        /// </param>
        /// <param name="hardwareId">
        /// Optional. ID used to uniquely identify the Hardware within its parent
        /// scope. This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The hardware.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hardware, OperationMetadata>> CreateHardwareAsync(string parent, Hardware hardware, string hardwareId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHardwareAsync(new CreateHardwareRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                HardwareId = hardwareId ?? "",
                Hardware = gax::GaxPreconditions.CheckNotNull(hardware, nameof(hardware)),
            }, callSettings);

        /// <summary>
        /// Creates new hardware in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create hardware in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="hardware">
        /// Required. The resource to create.
        /// </param>
        /// <param name="hardwareId">
        /// Optional. ID used to uniquely identify the Hardware within its parent
        /// scope. This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The hardware.name field in the request will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hardware, OperationMetadata>> CreateHardwareAsync(string parent, Hardware hardware, string hardwareId, st::CancellationToken cancellationToken) =>
            CreateHardwareAsync(parent, hardware, hardwareId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new hardware in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create hardware in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="hardware">
        /// Required. The resource to create.
        /// </param>
        /// <param name="hardwareId">
        /// Optional. ID used to uniquely identify the Hardware within its parent
        /// scope. This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The hardware.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hardware, OperationMetadata> CreateHardware(gagr::LocationName parent, Hardware hardware, string hardwareId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHardware(new CreateHardwareRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                HardwareId = hardwareId ?? "",
                Hardware = gax::GaxPreconditions.CheckNotNull(hardware, nameof(hardware)),
            }, callSettings);

        /// <summary>
        /// Creates new hardware in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create hardware in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="hardware">
        /// Required. The resource to create.
        /// </param>
        /// <param name="hardwareId">
        /// Optional. ID used to uniquely identify the Hardware within its parent
        /// scope. This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The hardware.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hardware, OperationMetadata>> CreateHardwareAsync(gagr::LocationName parent, Hardware hardware, string hardwareId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHardwareAsync(new CreateHardwareRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                HardwareId = hardwareId ?? "",
                Hardware = gax::GaxPreconditions.CheckNotNull(hardware, nameof(hardware)),
            }, callSettings);

        /// <summary>
        /// Creates new hardware in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create hardware in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="hardware">
        /// Required. The resource to create.
        /// </param>
        /// <param name="hardwareId">
        /// Optional. ID used to uniquely identify the Hardware within its parent
        /// scope. This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The hardware.name field in the request will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hardware, OperationMetadata>> CreateHardwareAsync(gagr::LocationName parent, Hardware hardware, string hardwareId, st::CancellationToken cancellationToken) =>
            CreateHardwareAsync(parent, hardware, hardwareId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates hardware parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hardware, OperationMetadata> UpdateHardware(UpdateHardwareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates hardware parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hardware, OperationMetadata>> UpdateHardwareAsync(UpdateHardwareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates hardware parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hardware, OperationMetadata>> UpdateHardwareAsync(UpdateHardwareRequest request, st::CancellationToken cancellationToken) =>
            UpdateHardwareAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateHardware</c>.</summary>
        public virtual lro::OperationsClient UpdateHardwareOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateHardware</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Hardware, OperationMetadata> PollOnceUpdateHardware(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Hardware, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateHardwareOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateHardware</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Hardware, OperationMetadata>> PollOnceUpdateHardwareAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Hardware, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateHardwareOperationsClient, callSettings);

        /// <summary>
        /// Updates hardware parameters.
        /// </summary>
        /// <param name="hardware">
        /// Required. The hardware to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask to specify the fields in the Hardware to overwrite with
        /// this update. The fields specified in the update_mask are relative to the
        /// hardware, not the full request. A field will be overwritten if it is in the
        /// mask. If you don't provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hardware, OperationMetadata> UpdateHardware(Hardware hardware, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateHardware(new UpdateHardwareRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Hardware = gax::GaxPreconditions.CheckNotNull(hardware, nameof(hardware)),
            }, callSettings);

        /// <summary>
        /// Updates hardware parameters.
        /// </summary>
        /// <param name="hardware">
        /// Required. The hardware to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask to specify the fields in the Hardware to overwrite with
        /// this update. The fields specified in the update_mask are relative to the
        /// hardware, not the full request. A field will be overwritten if it is in the
        /// mask. If you don't provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hardware, OperationMetadata>> UpdateHardwareAsync(Hardware hardware, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateHardwareAsync(new UpdateHardwareRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Hardware = gax::GaxPreconditions.CheckNotNull(hardware, nameof(hardware)),
            }, callSettings);

        /// <summary>
        /// Updates hardware parameters.
        /// </summary>
        /// <param name="hardware">
        /// Required. The hardware to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask to specify the fields in the Hardware to overwrite with
        /// this update. The fields specified in the update_mask are relative to the
        /// hardware, not the full request. A field will be overwritten if it is in the
        /// mask. If you don't provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hardware, OperationMetadata>> UpdateHardwareAsync(Hardware hardware, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateHardwareAsync(hardware, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes hardware.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteHardware(DeleteHardwareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes hardware.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHardwareAsync(DeleteHardwareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes hardware.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHardwareAsync(DeleteHardwareRequest request, st::CancellationToken cancellationToken) =>
            DeleteHardwareAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteHardware</c>.</summary>
        public virtual lro::OperationsClient DeleteHardwareOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteHardware</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteHardware(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteHardwareOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteHardware</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteHardwareAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteHardwareOperationsClient, callSettings);

        /// <summary>
        /// Deletes hardware.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware.
        /// Format: `projects/{project}/locations/{location}/hardware/{hardware}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteHardware(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHardware(new DeleteHardwareRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes hardware.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware.
        /// Format: `projects/{project}/locations/{location}/hardware/{hardware}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHardwareAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHardwareAsync(new DeleteHardwareRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes hardware.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware.
        /// Format: `projects/{project}/locations/{location}/hardware/{hardware}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHardwareAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteHardwareAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes hardware.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware.
        /// Format: `projects/{project}/locations/{location}/hardware/{hardware}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteHardware(HardwareName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHardware(new DeleteHardwareRequest
            {
                HardwareName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes hardware.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware.
        /// Format: `projects/{project}/locations/{location}/hardware/{hardware}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHardwareAsync(HardwareName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHardwareAsync(new DeleteHardwareRequest
            {
                HardwareName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes hardware.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hardware.
        /// Format: `projects/{project}/locations/{location}/hardware/{hardware}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHardwareAsync(HardwareName name, st::CancellationToken cancellationToken) =>
            DeleteHardwareAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the comments on an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Comment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCommentsResponse, Comment> ListComments(ListCommentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the comments on an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Comment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCommentsResponse, Comment> ListCommentsAsync(ListCommentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the comments on an order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to list comments on.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
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
        /// <returns>A pageable sequence of <see cref="Comment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCommentsResponse, Comment> ListComments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCommentsRequest request = new ListCommentsRequest
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
            return ListComments(request, callSettings);
        }

        /// <summary>
        /// Lists the comments on an order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to list comments on.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Comment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCommentsResponse, Comment> ListCommentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCommentsRequest request = new ListCommentsRequest
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
            return ListCommentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the comments on an order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to list comments on.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
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
        /// <returns>A pageable sequence of <see cref="Comment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCommentsResponse, Comment> ListComments(OrderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCommentsRequest request = new ListCommentsRequest
            {
                ParentAsOrderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListComments(request, callSettings);
        }

        /// <summary>
        /// Lists the comments on an order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to list comments on.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Comment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCommentsResponse, Comment> ListCommentsAsync(OrderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCommentsRequest request = new ListCommentsRequest
            {
                ParentAsOrderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCommentsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the content of a comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Comment GetComment(GetCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the content of a comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Comment> GetCommentAsync(GetCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the content of a comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Comment> GetCommentAsync(GetCommentRequest request, st::CancellationToken cancellationToken) =>
            GetCommentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the content of a comment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the comment.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/comments/{comment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Comment GetComment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetComment(new GetCommentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the content of a comment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the comment.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/comments/{comment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Comment> GetCommentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCommentAsync(new GetCommentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the content of a comment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the comment.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/comments/{comment}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Comment> GetCommentAsync(string name, st::CancellationToken cancellationToken) =>
            GetCommentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the content of a comment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the comment.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/comments/{comment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Comment GetComment(CommentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetComment(new GetCommentRequest
            {
                CommentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the content of a comment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the comment.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/comments/{comment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Comment> GetCommentAsync(CommentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCommentAsync(new GetCommentRequest
            {
                CommentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the content of a comment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the comment.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/comments/{comment}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Comment> GetCommentAsync(CommentName name, st::CancellationToken cancellationToken) =>
            GetCommentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new comment on an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Comment, OperationMetadata> CreateComment(CreateCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new comment on an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Comment, OperationMetadata>> CreateCommentAsync(CreateCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new comment on an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Comment, OperationMetadata>> CreateCommentAsync(CreateCommentRequest request, st::CancellationToken cancellationToken) =>
            CreateCommentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateComment</c>.</summary>
        public virtual lro::OperationsClient CreateCommentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateComment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Comment, OperationMetadata> PollOnceCreateComment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Comment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCommentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateComment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Comment, OperationMetadata>> PollOnceCreateCommentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Comment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCommentOperationsClient, callSettings);

        /// <summary>
        /// Creates a new comment on an order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to create the comment on.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="comment">
        /// Required. The comment to create.
        /// </param>
        /// <param name="commentId">
        /// Optional. ID used to uniquely identify the Comment within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The comment.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Comment, OperationMetadata> CreateComment(string parent, Comment comment, string commentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateComment(new CreateCommentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CommentId = commentId ?? "",
                Comment = gax::GaxPreconditions.CheckNotNull(comment, nameof(comment)),
            }, callSettings);

        /// <summary>
        /// Creates a new comment on an order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to create the comment on.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="comment">
        /// Required. The comment to create.
        /// </param>
        /// <param name="commentId">
        /// Optional. ID used to uniquely identify the Comment within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The comment.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Comment, OperationMetadata>> CreateCommentAsync(string parent, Comment comment, string commentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCommentAsync(new CreateCommentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CommentId = commentId ?? "",
                Comment = gax::GaxPreconditions.CheckNotNull(comment, nameof(comment)),
            }, callSettings);

        /// <summary>
        /// Creates a new comment on an order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to create the comment on.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="comment">
        /// Required. The comment to create.
        /// </param>
        /// <param name="commentId">
        /// Optional. ID used to uniquely identify the Comment within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The comment.name field in the request will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Comment, OperationMetadata>> CreateCommentAsync(string parent, Comment comment, string commentId, st::CancellationToken cancellationToken) =>
            CreateCommentAsync(parent, comment, commentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new comment on an order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to create the comment on.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="comment">
        /// Required. The comment to create.
        /// </param>
        /// <param name="commentId">
        /// Optional. ID used to uniquely identify the Comment within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The comment.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Comment, OperationMetadata> CreateComment(OrderName parent, Comment comment, string commentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateComment(new CreateCommentRequest
            {
                ParentAsOrderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CommentId = commentId ?? "",
                Comment = gax::GaxPreconditions.CheckNotNull(comment, nameof(comment)),
            }, callSettings);

        /// <summary>
        /// Creates a new comment on an order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to create the comment on.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="comment">
        /// Required. The comment to create.
        /// </param>
        /// <param name="commentId">
        /// Optional. ID used to uniquely identify the Comment within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The comment.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Comment, OperationMetadata>> CreateCommentAsync(OrderName parent, Comment comment, string commentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCommentAsync(new CreateCommentRequest
            {
                ParentAsOrderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CommentId = commentId ?? "",
                Comment = gax::GaxPreconditions.CheckNotNull(comment, nameof(comment)),
            }, callSettings);

        /// <summary>
        /// Creates a new comment on an order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to create the comment on.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
        /// </param>
        /// <param name="comment">
        /// Required. The comment to create.
        /// </param>
        /// <param name="commentId">
        /// Optional. ID used to uniquely identify the Comment within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The comment.name field in the request will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Comment, OperationMetadata>> CreateCommentAsync(OrderName parent, Comment comment, string commentId, st::CancellationToken cancellationToken) =>
            CreateCommentAsync(parent, comment, commentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Record Action on a Comment. If the Action specified in the request is READ,
        /// the viewed time in the comment is set to the time the request was received.
        /// If the comment is already marked as read, subsequent calls will be ignored.
        /// If the Action is UNREAD, the viewed time is cleared from the comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Comment RecordActionOnComment(RecordActionOnCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Record Action on a Comment. If the Action specified in the request is READ,
        /// the viewed time in the comment is set to the time the request was received.
        /// If the comment is already marked as read, subsequent calls will be ignored.
        /// If the Action is UNREAD, the viewed time is cleared from the comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Comment> RecordActionOnCommentAsync(RecordActionOnCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Record Action on a Comment. If the Action specified in the request is READ,
        /// the viewed time in the comment is set to the time the request was received.
        /// If the comment is already marked as read, subsequent calls will be ignored.
        /// If the Action is UNREAD, the viewed time is cleared from the comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Comment> RecordActionOnCommentAsync(RecordActionOnCommentRequest request, st::CancellationToken cancellationToken) =>
            RecordActionOnCommentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Record Action on a Comment. If the Action specified in the request is READ,
        /// the viewed time in the comment is set to the time the request was received.
        /// If the comment is already marked as read, subsequent calls will be ignored.
        /// If the Action is UNREAD, the viewed time is cleared from the comment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the comment.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/comments/{comment}`
        /// </param>
        /// <param name="actionType">
        /// Required. The action type of the recorded action.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Comment RecordActionOnComment(string name, RecordActionOnCommentRequest.Types.ActionType actionType, gaxgrpc::CallSettings callSettings = null) =>
            RecordActionOnComment(new RecordActionOnCommentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ActionType = actionType,
            }, callSettings);

        /// <summary>
        /// Record Action on a Comment. If the Action specified in the request is READ,
        /// the viewed time in the comment is set to the time the request was received.
        /// If the comment is already marked as read, subsequent calls will be ignored.
        /// If the Action is UNREAD, the viewed time is cleared from the comment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the comment.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/comments/{comment}`
        /// </param>
        /// <param name="actionType">
        /// Required. The action type of the recorded action.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Comment> RecordActionOnCommentAsync(string name, RecordActionOnCommentRequest.Types.ActionType actionType, gaxgrpc::CallSettings callSettings = null) =>
            RecordActionOnCommentAsync(new RecordActionOnCommentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ActionType = actionType,
            }, callSettings);

        /// <summary>
        /// Record Action on a Comment. If the Action specified in the request is READ,
        /// the viewed time in the comment is set to the time the request was received.
        /// If the comment is already marked as read, subsequent calls will be ignored.
        /// If the Action is UNREAD, the viewed time is cleared from the comment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the comment.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/comments/{comment}`
        /// </param>
        /// <param name="actionType">
        /// Required. The action type of the recorded action.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Comment> RecordActionOnCommentAsync(string name, RecordActionOnCommentRequest.Types.ActionType actionType, st::CancellationToken cancellationToken) =>
            RecordActionOnCommentAsync(name, actionType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Record Action on a Comment. If the Action specified in the request is READ,
        /// the viewed time in the comment is set to the time the request was received.
        /// If the comment is already marked as read, subsequent calls will be ignored.
        /// If the Action is UNREAD, the viewed time is cleared from the comment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the comment.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/comments/{comment}`
        /// </param>
        /// <param name="actionType">
        /// Required. The action type of the recorded action.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Comment RecordActionOnComment(CommentName name, RecordActionOnCommentRequest.Types.ActionType actionType, gaxgrpc::CallSettings callSettings = null) =>
            RecordActionOnComment(new RecordActionOnCommentRequest
            {
                CommentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ActionType = actionType,
            }, callSettings);

        /// <summary>
        /// Record Action on a Comment. If the Action specified in the request is READ,
        /// the viewed time in the comment is set to the time the request was received.
        /// If the comment is already marked as read, subsequent calls will be ignored.
        /// If the Action is UNREAD, the viewed time is cleared from the comment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the comment.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/comments/{comment}`
        /// </param>
        /// <param name="actionType">
        /// Required. The action type of the recorded action.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Comment> RecordActionOnCommentAsync(CommentName name, RecordActionOnCommentRequest.Types.ActionType actionType, gaxgrpc::CallSettings callSettings = null) =>
            RecordActionOnCommentAsync(new RecordActionOnCommentRequest
            {
                CommentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ActionType = actionType,
            }, callSettings);

        /// <summary>
        /// Record Action on a Comment. If the Action specified in the request is READ,
        /// the viewed time in the comment is set to the time the request was received.
        /// If the comment is already marked as read, subsequent calls will be ignored.
        /// If the Action is UNREAD, the viewed time is cleared from the comment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the comment.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/comments/{comment}`
        /// </param>
        /// <param name="actionType">
        /// Required. The action type of the recorded action.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Comment> RecordActionOnCommentAsync(CommentName name, RecordActionOnCommentRequest.Types.ActionType actionType, st::CancellationToken cancellationToken) =>
            RecordActionOnCommentAsync(name, actionType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the changes made to an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ChangeLogEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChangeLogEntriesResponse, ChangeLogEntry> ListChangeLogEntries(ListChangeLogEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the changes made to an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ChangeLogEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChangeLogEntriesResponse, ChangeLogEntry> ListChangeLogEntriesAsync(ListChangeLogEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the changes made to an order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to list change log entries for.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
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
        /// <returns>A pageable sequence of <see cref="ChangeLogEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChangeLogEntriesResponse, ChangeLogEntry> ListChangeLogEntries(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChangeLogEntriesRequest request = new ListChangeLogEntriesRequest
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
            return ListChangeLogEntries(request, callSettings);
        }

        /// <summary>
        /// Lists the changes made to an order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to list change log entries for.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ChangeLogEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChangeLogEntriesResponse, ChangeLogEntry> ListChangeLogEntriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChangeLogEntriesRequest request = new ListChangeLogEntriesRequest
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
            return ListChangeLogEntriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the changes made to an order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to list change log entries for.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
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
        /// <returns>A pageable sequence of <see cref="ChangeLogEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChangeLogEntriesResponse, ChangeLogEntry> ListChangeLogEntries(OrderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChangeLogEntriesRequest request = new ListChangeLogEntriesRequest
            {
                ParentAsOrderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListChangeLogEntries(request, callSettings);
        }

        /// <summary>
        /// Lists the changes made to an order.
        /// </summary>
        /// <param name="parent">
        /// Required. The order to list change log entries for.
        /// Format: `projects/{project}/locations/{location}/orders/{order}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ChangeLogEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChangeLogEntriesResponse, ChangeLogEntry> ListChangeLogEntriesAsync(OrderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChangeLogEntriesRequest request = new ListChangeLogEntriesRequest
            {
                ParentAsOrderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListChangeLogEntriesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a change to an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChangeLogEntry GetChangeLogEntry(GetChangeLogEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a change to an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChangeLogEntry> GetChangeLogEntryAsync(GetChangeLogEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a change to an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChangeLogEntry> GetChangeLogEntryAsync(GetChangeLogEntryRequest request, st::CancellationToken cancellationToken) =>
            GetChangeLogEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a change to an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the change log entry.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/changeLogEntries/{change_log_entry}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChangeLogEntry GetChangeLogEntry(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetChangeLogEntry(new GetChangeLogEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a change to an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the change log entry.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/changeLogEntries/{change_log_entry}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChangeLogEntry> GetChangeLogEntryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetChangeLogEntryAsync(new GetChangeLogEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a change to an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the change log entry.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/changeLogEntries/{change_log_entry}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChangeLogEntry> GetChangeLogEntryAsync(string name, st::CancellationToken cancellationToken) =>
            GetChangeLogEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a change to an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the change log entry.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/changeLogEntries/{change_log_entry}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChangeLogEntry GetChangeLogEntry(ChangeLogEntryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetChangeLogEntry(new GetChangeLogEntryRequest
            {
                ChangeLogEntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a change to an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the change log entry.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/changeLogEntries/{change_log_entry}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChangeLogEntry> GetChangeLogEntryAsync(ChangeLogEntryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetChangeLogEntryAsync(new GetChangeLogEntryRequest
            {
                ChangeLogEntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a change to an order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the change log entry.
        /// Format:
        /// `projects/{project}/locations/{location}/orders/{order}/changeLogEntries/{change_log_entry}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChangeLogEntry> GetChangeLogEntryAsync(ChangeLogEntryName name, st::CancellationToken cancellationToken) =>
            GetChangeLogEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists SKUs for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Sku"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkusResponse, Sku> ListSkus(ListSkusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SKUs for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Sku"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkusResponse, Sku> ListSkusAsync(ListSkusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SKUs for a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list SKUs in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list SKUs across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        /// <returns>A pageable sequence of <see cref="Sku"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkusResponse, Sku> ListSkus(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkusRequest request = new ListSkusRequest
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
            return ListSkus(request, callSettings);
        }

        /// <summary>
        /// Lists SKUs for a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list SKUs in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list SKUs across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Sku"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkusResponse, Sku> ListSkusAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkusRequest request = new ListSkusRequest
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
            return ListSkusAsync(request, callSettings);
        }

        /// <summary>
        /// Lists SKUs for a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list SKUs in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list SKUs across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        /// <returns>A pageable sequence of <see cref="Sku"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkusResponse, Sku> ListSkus(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkusRequest request = new ListSkusRequest
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
            return ListSkus(request, callSettings);
        }

        /// <summary>
        /// Lists SKUs for a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list SKUs in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list SKUs across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Sku"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkusResponse, Sku> ListSkusAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkusRequest request = new ListSkusRequest
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
            return ListSkusAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of an SKU.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Sku GetSku(GetSkuRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of an SKU.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Sku> GetSkuAsync(GetSkuRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of an SKU.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Sku> GetSkuAsync(GetSkuRequest request, st::CancellationToken cancellationToken) =>
            GetSkuAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of an SKU.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SKU.
        /// Format: `projects/{project}/locations/{location}/skus/{sku}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Sku GetSku(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSku(new GetSkuRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of an SKU.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SKU.
        /// Format: `projects/{project}/locations/{location}/skus/{sku}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Sku> GetSkuAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkuAsync(new GetSkuRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of an SKU.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SKU.
        /// Format: `projects/{project}/locations/{location}/skus/{sku}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Sku> GetSkuAsync(string name, st::CancellationToken cancellationToken) =>
            GetSkuAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of an SKU.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SKU.
        /// Format: `projects/{project}/locations/{location}/skus/{sku}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Sku GetSku(SkuName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSku(new GetSkuRequest
            {
                SkuName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of an SKU.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SKU.
        /// Format: `projects/{project}/locations/{location}/skus/{sku}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Sku> GetSkuAsync(SkuName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkuAsync(new GetSkuRequest
            {
                SkuName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of an SKU.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SKU.
        /// Format: `projects/{project}/locations/{location}/skus/{sku}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Sku> GetSkuAsync(SkuName name, st::CancellationToken cancellationToken) =>
            GetSkuAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists zones in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Zone"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListZonesResponse, Zone> ListZones(ListZonesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists zones in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Zone"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListZonesResponse, Zone> ListZonesAsync(ListZonesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists zones in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list zones in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list zones across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        public virtual gax::PagedEnumerable<ListZonesResponse, Zone> ListZones(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListZonesRequest request = new ListZonesRequest
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
        /// Lists zones in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list zones in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list zones across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        public virtual gax::PagedAsyncEnumerable<ListZonesResponse, Zone> ListZonesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListZonesRequest request = new ListZonesRequest
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
        /// Lists zones in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list zones in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list zones across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        public virtual gax::PagedEnumerable<ListZonesResponse, Zone> ListZones(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListZonesRequest request = new ListZonesRequest
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
        /// Lists zones in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list zones in.
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// To list zones across all locations, substitute `-` (the hyphen or
        /// dash character) for the location and check the unreachable field in
        /// the response message.
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
        public virtual gax::PagedAsyncEnumerable<ListZonesResponse, Zone> ListZonesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListZonesRequest request = new ListZonesRequest
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
        /// Gets details of a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Zone GetZone(GetZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Zone> GetZoneAsync(GetZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Zone> GetZoneAsync(GetZoneRequest request, st::CancellationToken cancellationToken) =>
            GetZoneAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a zone.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone.
        /// Format: `projects/{project}/locations/{location}/zones/{zone}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Zone GetZone(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetZone(new GetZoneRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a zone.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone.
        /// Format: `projects/{project}/locations/{location}/zones/{zone}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Zone> GetZoneAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetZoneAsync(new GetZoneRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a zone.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone.
        /// Format: `projects/{project}/locations/{location}/zones/{zone}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Zone> GetZoneAsync(string name, st::CancellationToken cancellationToken) =>
            GetZoneAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a zone.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone.
        /// Format: `projects/{project}/locations/{location}/zones/{zone}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Zone GetZone(ZoneName name, gaxgrpc::CallSettings callSettings = null) =>
            GetZone(new GetZoneRequest
            {
                ZoneName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a zone.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone.
        /// Format: `projects/{project}/locations/{location}/zones/{zone}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Zone> GetZoneAsync(ZoneName name, gaxgrpc::CallSettings callSettings = null) =>
            GetZoneAsync(new GetZoneRequest
            {
                ZoneName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a zone.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone.
        /// Format: `projects/{project}/locations/{location}/zones/{zone}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Zone> GetZoneAsync(ZoneName name, st::CancellationToken cancellationToken) =>
            GetZoneAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new zone in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Zone, OperationMetadata> CreateZone(CreateZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new zone in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> CreateZoneAsync(CreateZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new zone in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> CreateZoneAsync(CreateZoneRequest request, st::CancellationToken cancellationToken) =>
            CreateZoneAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateZone</c>.</summary>
        public virtual lro::OperationsClient CreateZoneOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateZone</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Zone, OperationMetadata> PollOnceCreateZone(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Zone, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateZoneOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateZone</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> PollOnceCreateZoneAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Zone, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateZoneOperationsClient, callSettings);

        /// <summary>
        /// Creates a new zone in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the zone in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="zone">
        /// Required. The zone to create.
        /// </param>
        /// <param name="zoneId">
        /// Optional. ID used to uniquely identify the Zone within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The zone.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Zone, OperationMetadata> CreateZone(string parent, Zone zone, string zoneId, gaxgrpc::CallSettings callSettings = null) =>
            CreateZone(new CreateZoneRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ZoneId = zoneId ?? "",
                Zone = gax::GaxPreconditions.CheckNotNull(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates a new zone in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the zone in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="zone">
        /// Required. The zone to create.
        /// </param>
        /// <param name="zoneId">
        /// Optional. ID used to uniquely identify the Zone within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The zone.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> CreateZoneAsync(string parent, Zone zone, string zoneId, gaxgrpc::CallSettings callSettings = null) =>
            CreateZoneAsync(new CreateZoneRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ZoneId = zoneId ?? "",
                Zone = gax::GaxPreconditions.CheckNotNull(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates a new zone in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the zone in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="zone">
        /// Required. The zone to create.
        /// </param>
        /// <param name="zoneId">
        /// Optional. ID used to uniquely identify the Zone within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The zone.name field in the request will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> CreateZoneAsync(string parent, Zone zone, string zoneId, st::CancellationToken cancellationToken) =>
            CreateZoneAsync(parent, zone, zoneId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new zone in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the zone in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="zone">
        /// Required. The zone to create.
        /// </param>
        /// <param name="zoneId">
        /// Optional. ID used to uniquely identify the Zone within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The zone.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Zone, OperationMetadata> CreateZone(gagr::LocationName parent, Zone zone, string zoneId, gaxgrpc::CallSettings callSettings = null) =>
            CreateZone(new CreateZoneRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ZoneId = zoneId ?? "",
                Zone = gax::GaxPreconditions.CheckNotNull(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates a new zone in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the zone in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="zone">
        /// Required. The zone to create.
        /// </param>
        /// <param name="zoneId">
        /// Optional. ID used to uniquely identify the Zone within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The zone.name field in the request will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> CreateZoneAsync(gagr::LocationName parent, Zone zone, string zoneId, gaxgrpc::CallSettings callSettings = null) =>
            CreateZoneAsync(new CreateZoneRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ZoneId = zoneId ?? "",
                Zone = gax::GaxPreconditions.CheckNotNull(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates a new zone in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the zone in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="zone">
        /// Required. The zone to create.
        /// </param>
        /// <param name="zoneId">
        /// Optional. ID used to uniquely identify the Zone within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and `-` are accepted.
        /// The `-` character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The zone.name field in the request will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> CreateZoneAsync(gagr::LocationName parent, Zone zone, string zoneId, st::CancellationToken cancellationToken) =>
            CreateZoneAsync(parent, zone, zoneId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Zone, OperationMetadata> UpdateZone(UpdateZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> UpdateZoneAsync(UpdateZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> UpdateZoneAsync(UpdateZoneRequest request, st::CancellationToken cancellationToken) =>
            UpdateZoneAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateZone</c>.</summary>
        public virtual lro::OperationsClient UpdateZoneOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateZone</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Zone, OperationMetadata> PollOnceUpdateZone(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Zone, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateZoneOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateZone</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> PollOnceUpdateZoneAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Zone, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateZoneOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a zone.
        /// </summary>
        /// <param name="zone">
        /// Required. The zone to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask to specify the fields in the Zone to overwrite with this
        /// update. The fields specified in the update_mask are relative to the zone,
        /// not the full request. A field will be overwritten if it is in the mask. If
        /// you don't provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Zone, OperationMetadata> UpdateZone(Zone zone, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateZone(new UpdateZoneRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Zone = gax::GaxPreconditions.CheckNotNull(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a zone.
        /// </summary>
        /// <param name="zone">
        /// Required. The zone to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask to specify the fields in the Zone to overwrite with this
        /// update. The fields specified in the update_mask are relative to the zone,
        /// not the full request. A field will be overwritten if it is in the mask. If
        /// you don't provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> UpdateZoneAsync(Zone zone, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateZoneAsync(new UpdateZoneRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Zone = gax::GaxPreconditions.CheckNotNull(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a zone.
        /// </summary>
        /// <param name="zone">
        /// Required. The zone to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask to specify the fields in the Zone to overwrite with this
        /// update. The fields specified in the update_mask are relative to the zone,
        /// not the full request. A field will be overwritten if it is in the mask. If
        /// you don't provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> UpdateZoneAsync(Zone zone, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateZoneAsync(zone, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteZone(DeleteZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteZoneAsync(DeleteZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteZoneAsync(DeleteZoneRequest request, st::CancellationToken cancellationToken) =>
            DeleteZoneAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteZone</c>.</summary>
        public virtual lro::OperationsClient DeleteZoneOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteZone</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteZone(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteZoneOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteZone</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteZoneAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteZoneOperationsClient, callSettings);

        /// <summary>
        /// Deletes a zone.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone.
        /// Format: `projects/{project}/locations/{location}/zones/{zone}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteZone(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteZone(new DeleteZoneRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a zone.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone.
        /// Format: `projects/{project}/locations/{location}/zones/{zone}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteZoneAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteZoneAsync(new DeleteZoneRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a zone.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone.
        /// Format: `projects/{project}/locations/{location}/zones/{zone}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteZoneAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteZoneAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a zone.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone.
        /// Format: `projects/{project}/locations/{location}/zones/{zone}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteZone(ZoneName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteZone(new DeleteZoneRequest
            {
                ZoneName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a zone.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone.
        /// Format: `projects/{project}/locations/{location}/zones/{zone}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteZoneAsync(ZoneName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteZoneAsync(new DeleteZoneRequest
            {
                ZoneName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a zone.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone.
        /// Format: `projects/{project}/locations/{location}/zones/{zone}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteZoneAsync(ZoneName name, st::CancellationToken cancellationToken) =>
            DeleteZoneAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Signals the state of a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Zone, OperationMetadata> SignalZoneState(SignalZoneStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Signals the state of a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> SignalZoneStateAsync(SignalZoneStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Signals the state of a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> SignalZoneStateAsync(SignalZoneStateRequest request, st::CancellationToken cancellationToken) =>
            SignalZoneStateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SignalZoneState</c>.</summary>
        public virtual lro::OperationsClient SignalZoneStateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SignalZoneState</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Zone, OperationMetadata> PollOnceSignalZoneState(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Zone, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SignalZoneStateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SignalZoneState</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> PollOnceSignalZoneStateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Zone, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SignalZoneStateOperationsClient, callSettings);

        /// <summary>
        /// Signals the state of a zone.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone.
        /// Format: `projects/{project}/locations/{location}/zones/{zone}`
        /// </param>
        /// <param name="stateSignal">
        /// Optional. The state signal to send for this zone. Either state_signal or
        /// provisioning_state_signal must be set, but not both.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Zone, OperationMetadata> SignalZoneState(string name, SignalZoneStateRequest.Types.StateSignal stateSignal, gaxgrpc::CallSettings callSettings = null) =>
            SignalZoneState(new SignalZoneStateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StateSignal = stateSignal,
            }, callSettings);

        /// <summary>
        /// Signals the state of a zone.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone.
        /// Format: `projects/{project}/locations/{location}/zones/{zone}`
        /// </param>
        /// <param name="stateSignal">
        /// Optional. The state signal to send for this zone. Either state_signal or
        /// provisioning_state_signal must be set, but not both.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> SignalZoneStateAsync(string name, SignalZoneStateRequest.Types.StateSignal stateSignal, gaxgrpc::CallSettings callSettings = null) =>
            SignalZoneStateAsync(new SignalZoneStateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StateSignal = stateSignal,
            }, callSettings);

        /// <summary>
        /// Signals the state of a zone.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone.
        /// Format: `projects/{project}/locations/{location}/zones/{zone}`
        /// </param>
        /// <param name="stateSignal">
        /// Optional. The state signal to send for this zone. Either state_signal or
        /// provisioning_state_signal must be set, but not both.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> SignalZoneStateAsync(string name, SignalZoneStateRequest.Types.StateSignal stateSignal, st::CancellationToken cancellationToken) =>
            SignalZoneStateAsync(name, stateSignal, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Signals the state of a zone.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone.
        /// Format: `projects/{project}/locations/{location}/zones/{zone}`
        /// </param>
        /// <param name="stateSignal">
        /// Optional. The state signal to send for this zone. Either state_signal or
        /// provisioning_state_signal must be set, but not both.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Zone, OperationMetadata> SignalZoneState(ZoneName name, SignalZoneStateRequest.Types.StateSignal stateSignal, gaxgrpc::CallSettings callSettings = null) =>
            SignalZoneState(new SignalZoneStateRequest
            {
                ZoneName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StateSignal = stateSignal,
            }, callSettings);

        /// <summary>
        /// Signals the state of a zone.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone.
        /// Format: `projects/{project}/locations/{location}/zones/{zone}`
        /// </param>
        /// <param name="stateSignal">
        /// Optional. The state signal to send for this zone. Either state_signal or
        /// provisioning_state_signal must be set, but not both.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> SignalZoneStateAsync(ZoneName name, SignalZoneStateRequest.Types.StateSignal stateSignal, gaxgrpc::CallSettings callSettings = null) =>
            SignalZoneStateAsync(new SignalZoneStateRequest
            {
                ZoneName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StateSignal = stateSignal,
            }, callSettings);

        /// <summary>
        /// Signals the state of a zone.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the zone.
        /// Format: `projects/{project}/locations/{location}/zones/{zone}`
        /// </param>
        /// <param name="stateSignal">
        /// Optional. The state signal to send for this zone. Either state_signal or
        /// provisioning_state_signal must be set, but not both.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> SignalZoneStateAsync(ZoneName name, SignalZoneStateRequest.Types.StateSignal stateSignal, st::CancellationToken cancellationToken) =>
            SignalZoneStateAsync(name, stateSignal, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the requested date change of a single Order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Order, OperationMetadata> RequestOrderDateChange(RequestOrderDateChangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the requested date change of a single Order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> RequestOrderDateChangeAsync(RequestOrderDateChangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the requested date change of a single Order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> RequestOrderDateChangeAsync(RequestOrderDateChangeRequest request, st::CancellationToken cancellationToken) =>
            RequestOrderDateChangeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RequestOrderDateChange</c>.</summary>
        public virtual lro::OperationsClient RequestOrderDateChangeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RequestOrderDateChange</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Order, OperationMetadata> PollOnceRequestOrderDateChange(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Order, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RequestOrderDateChangeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RequestOrderDateChange</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> PollOnceRequestOrderDateChangeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Order, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RequestOrderDateChangeOperationsClient, callSettings);

        /// <summary>
        /// Updates the requested date change of a single Order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order to update.
        /// Format: projects/{project}/locations/{location}/orders/{order}
        /// </param>
        /// <param name="requestedDate">
        /// Required. The date to which the customer or Google wants to set the
        /// scheduled installation date.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Order, OperationMetadata> RequestOrderDateChange(string name, gt::Date requestedDate, gaxgrpc::CallSettings callSettings = null) =>
            RequestOrderDateChange(new RequestOrderDateChangeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                RequestedDate = gax::GaxPreconditions.CheckNotNull(requestedDate, nameof(requestedDate)),
            }, callSettings);

        /// <summary>
        /// Updates the requested date change of a single Order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order to update.
        /// Format: projects/{project}/locations/{location}/orders/{order}
        /// </param>
        /// <param name="requestedDate">
        /// Required. The date to which the customer or Google wants to set the
        /// scheduled installation date.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> RequestOrderDateChangeAsync(string name, gt::Date requestedDate, gaxgrpc::CallSettings callSettings = null) =>
            RequestOrderDateChangeAsync(new RequestOrderDateChangeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                RequestedDate = gax::GaxPreconditions.CheckNotNull(requestedDate, nameof(requestedDate)),
            }, callSettings);

        /// <summary>
        /// Updates the requested date change of a single Order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order to update.
        /// Format: projects/{project}/locations/{location}/orders/{order}
        /// </param>
        /// <param name="requestedDate">
        /// Required. The date to which the customer or Google wants to set the
        /// scheduled installation date.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> RequestOrderDateChangeAsync(string name, gt::Date requestedDate, st::CancellationToken cancellationToken) =>
            RequestOrderDateChangeAsync(name, requestedDate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the requested date change of a single Order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order to update.
        /// Format: projects/{project}/locations/{location}/orders/{order}
        /// </param>
        /// <param name="requestedDate">
        /// Required. The date to which the customer or Google wants to set the
        /// scheduled installation date.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Order, OperationMetadata> RequestOrderDateChange(OrderName name, gt::Date requestedDate, gaxgrpc::CallSettings callSettings = null) =>
            RequestOrderDateChange(new RequestOrderDateChangeRequest
            {
                OrderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                RequestedDate = gax::GaxPreconditions.CheckNotNull(requestedDate, nameof(requestedDate)),
            }, callSettings);

        /// <summary>
        /// Updates the requested date change of a single Order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order to update.
        /// Format: projects/{project}/locations/{location}/orders/{order}
        /// </param>
        /// <param name="requestedDate">
        /// Required. The date to which the customer or Google wants to set the
        /// scheduled installation date.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> RequestOrderDateChangeAsync(OrderName name, gt::Date requestedDate, gaxgrpc::CallSettings callSettings = null) =>
            RequestOrderDateChangeAsync(new RequestOrderDateChangeRequest
            {
                OrderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                RequestedDate = gax::GaxPreconditions.CheckNotNull(requestedDate, nameof(requestedDate)),
            }, callSettings);

        /// <summary>
        /// Updates the requested date change of a single Order.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order to update.
        /// Format: projects/{project}/locations/{location}/orders/{order}
        /// </param>
        /// <param name="requestedDate">
        /// Required. The date to which the customer or Google wants to set the
        /// scheduled installation date.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, OperationMetadata>> RequestOrderDateChangeAsync(OrderName name, gt::Date requestedDate, st::CancellationToken cancellationToken) =>
            RequestOrderDateChangeAsync(name, requestedDate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GDCHardwareManagement client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The GDC Hardware Management service.
    /// </remarks>
    public sealed partial class GDCHardwareManagementClientImpl : GDCHardwareManagementClient
    {
        private readonly gaxgrpc::ApiCall<ListOrdersRequest, ListOrdersResponse> _callListOrders;

        private readonly gaxgrpc::ApiCall<GetOrderRequest, Order> _callGetOrder;

        private readonly gaxgrpc::ApiCall<CreateOrderRequest, lro::Operation> _callCreateOrder;

        private readonly gaxgrpc::ApiCall<UpdateOrderRequest, lro::Operation> _callUpdateOrder;

        private readonly gaxgrpc::ApiCall<DeleteOrderRequest, lro::Operation> _callDeleteOrder;

        private readonly gaxgrpc::ApiCall<SubmitOrderRequest, lro::Operation> _callSubmitOrder;

        private readonly gaxgrpc::ApiCall<CancelOrderRequest, lro::Operation> _callCancelOrder;

        private readonly gaxgrpc::ApiCall<ListSitesRequest, ListSitesResponse> _callListSites;

        private readonly gaxgrpc::ApiCall<GetSiteRequest, Site> _callGetSite;

        private readonly gaxgrpc::ApiCall<CreateSiteRequest, lro::Operation> _callCreateSite;

        private readonly gaxgrpc::ApiCall<UpdateSiteRequest, lro::Operation> _callUpdateSite;

        private readonly gaxgrpc::ApiCall<DeleteSiteRequest, lro::Operation> _callDeleteSite;

        private readonly gaxgrpc::ApiCall<ListHardwareGroupsRequest, ListHardwareGroupsResponse> _callListHardwareGroups;

        private readonly gaxgrpc::ApiCall<GetHardwareGroupRequest, HardwareGroup> _callGetHardwareGroup;

        private readonly gaxgrpc::ApiCall<CreateHardwareGroupRequest, lro::Operation> _callCreateHardwareGroup;

        private readonly gaxgrpc::ApiCall<UpdateHardwareGroupRequest, lro::Operation> _callUpdateHardwareGroup;

        private readonly gaxgrpc::ApiCall<DeleteHardwareGroupRequest, lro::Operation> _callDeleteHardwareGroup;

        private readonly gaxgrpc::ApiCall<ListHardwareRequest, ListHardwareResponse> _callListHardware;

        private readonly gaxgrpc::ApiCall<GetHardwareRequest, Hardware> _callGetHardware;

        private readonly gaxgrpc::ApiCall<CreateHardwareRequest, lro::Operation> _callCreateHardware;

        private readonly gaxgrpc::ApiCall<UpdateHardwareRequest, lro::Operation> _callUpdateHardware;

        private readonly gaxgrpc::ApiCall<DeleteHardwareRequest, lro::Operation> _callDeleteHardware;

        private readonly gaxgrpc::ApiCall<ListCommentsRequest, ListCommentsResponse> _callListComments;

        private readonly gaxgrpc::ApiCall<GetCommentRequest, Comment> _callGetComment;

        private readonly gaxgrpc::ApiCall<CreateCommentRequest, lro::Operation> _callCreateComment;

        private readonly gaxgrpc::ApiCall<RecordActionOnCommentRequest, Comment> _callRecordActionOnComment;

        private readonly gaxgrpc::ApiCall<ListChangeLogEntriesRequest, ListChangeLogEntriesResponse> _callListChangeLogEntries;

        private readonly gaxgrpc::ApiCall<GetChangeLogEntryRequest, ChangeLogEntry> _callGetChangeLogEntry;

        private readonly gaxgrpc::ApiCall<ListSkusRequest, ListSkusResponse> _callListSkus;

        private readonly gaxgrpc::ApiCall<GetSkuRequest, Sku> _callGetSku;

        private readonly gaxgrpc::ApiCall<ListZonesRequest, ListZonesResponse> _callListZones;

        private readonly gaxgrpc::ApiCall<GetZoneRequest, Zone> _callGetZone;

        private readonly gaxgrpc::ApiCall<CreateZoneRequest, lro::Operation> _callCreateZone;

        private readonly gaxgrpc::ApiCall<UpdateZoneRequest, lro::Operation> _callUpdateZone;

        private readonly gaxgrpc::ApiCall<DeleteZoneRequest, lro::Operation> _callDeleteZone;

        private readonly gaxgrpc::ApiCall<SignalZoneStateRequest, lro::Operation> _callSignalZoneState;

        private readonly gaxgrpc::ApiCall<RequestOrderDateChangeRequest, lro::Operation> _callRequestOrderDateChange;

        /// <summary>
        /// Constructs a client wrapper for the GDCHardwareManagement service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GDCHardwareManagementSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GDCHardwareManagementClientImpl(GDCHardwareManagement.GDCHardwareManagementClient grpcClient, GDCHardwareManagementSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GDCHardwareManagementSettings effectiveSettings = settings ?? GDCHardwareManagementSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateOrderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateOrderOperationsSettings, logger);
            UpdateOrderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateOrderOperationsSettings, logger);
            DeleteOrderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteOrderOperationsSettings, logger);
            SubmitOrderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SubmitOrderOperationsSettings, logger);
            CancelOrderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CancelOrderOperationsSettings, logger);
            CreateSiteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSiteOperationsSettings, logger);
            UpdateSiteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSiteOperationsSettings, logger);
            DeleteSiteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSiteOperationsSettings, logger);
            CreateHardwareGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateHardwareGroupOperationsSettings, logger);
            UpdateHardwareGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateHardwareGroupOperationsSettings, logger);
            DeleteHardwareGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteHardwareGroupOperationsSettings, logger);
            CreateHardwareOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateHardwareOperationsSettings, logger);
            UpdateHardwareOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateHardwareOperationsSettings, logger);
            DeleteHardwareOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteHardwareOperationsSettings, logger);
            CreateCommentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCommentOperationsSettings, logger);
            CreateZoneOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateZoneOperationsSettings, logger);
            UpdateZoneOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateZoneOperationsSettings, logger);
            DeleteZoneOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteZoneOperationsSettings, logger);
            SignalZoneStateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SignalZoneStateOperationsSettings, logger);
            RequestOrderDateChangeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RequestOrderDateChangeOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListOrders = clientHelper.BuildApiCall<ListOrdersRequest, ListOrdersResponse>("ListOrders", grpcClient.ListOrdersAsync, grpcClient.ListOrders, effectiveSettings.ListOrdersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOrders);
            Modify_ListOrdersApiCall(ref _callListOrders);
            _callGetOrder = clientHelper.BuildApiCall<GetOrderRequest, Order>("GetOrder", grpcClient.GetOrderAsync, grpcClient.GetOrder, effectiveSettings.GetOrderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOrder);
            Modify_GetOrderApiCall(ref _callGetOrder);
            _callCreateOrder = clientHelper.BuildApiCall<CreateOrderRequest, lro::Operation>("CreateOrder", grpcClient.CreateOrderAsync, grpcClient.CreateOrder, effectiveSettings.CreateOrderSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateOrder);
            Modify_CreateOrderApiCall(ref _callCreateOrder);
            _callUpdateOrder = clientHelper.BuildApiCall<UpdateOrderRequest, lro::Operation>("UpdateOrder", grpcClient.UpdateOrderAsync, grpcClient.UpdateOrder, effectiveSettings.UpdateOrderSettings).WithGoogleRequestParam("order.name", request => request.Order?.Name);
            Modify_ApiCall(ref _callUpdateOrder);
            Modify_UpdateOrderApiCall(ref _callUpdateOrder);
            _callDeleteOrder = clientHelper.BuildApiCall<DeleteOrderRequest, lro::Operation>("DeleteOrder", grpcClient.DeleteOrderAsync, grpcClient.DeleteOrder, effectiveSettings.DeleteOrderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteOrder);
            Modify_DeleteOrderApiCall(ref _callDeleteOrder);
            _callSubmitOrder = clientHelper.BuildApiCall<SubmitOrderRequest, lro::Operation>("SubmitOrder", grpcClient.SubmitOrderAsync, grpcClient.SubmitOrder, effectiveSettings.SubmitOrderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSubmitOrder);
            Modify_SubmitOrderApiCall(ref _callSubmitOrder);
            _callCancelOrder = clientHelper.BuildApiCall<CancelOrderRequest, lro::Operation>("CancelOrder", grpcClient.CancelOrderAsync, grpcClient.CancelOrder, effectiveSettings.CancelOrderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelOrder);
            Modify_CancelOrderApiCall(ref _callCancelOrder);
            _callListSites = clientHelper.BuildApiCall<ListSitesRequest, ListSitesResponse>("ListSites", grpcClient.ListSitesAsync, grpcClient.ListSites, effectiveSettings.ListSitesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSites);
            Modify_ListSitesApiCall(ref _callListSites);
            _callGetSite = clientHelper.BuildApiCall<GetSiteRequest, Site>("GetSite", grpcClient.GetSiteAsync, grpcClient.GetSite, effectiveSettings.GetSiteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSite);
            Modify_GetSiteApiCall(ref _callGetSite);
            _callCreateSite = clientHelper.BuildApiCall<CreateSiteRequest, lro::Operation>("CreateSite", grpcClient.CreateSiteAsync, grpcClient.CreateSite, effectiveSettings.CreateSiteSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSite);
            Modify_CreateSiteApiCall(ref _callCreateSite);
            _callUpdateSite = clientHelper.BuildApiCall<UpdateSiteRequest, lro::Operation>("UpdateSite", grpcClient.UpdateSiteAsync, grpcClient.UpdateSite, effectiveSettings.UpdateSiteSettings).WithGoogleRequestParam("site.name", request => request.Site?.Name);
            Modify_ApiCall(ref _callUpdateSite);
            Modify_UpdateSiteApiCall(ref _callUpdateSite);
            _callDeleteSite = clientHelper.BuildApiCall<DeleteSiteRequest, lro::Operation>("DeleteSite", grpcClient.DeleteSiteAsync, grpcClient.DeleteSite, effectiveSettings.DeleteSiteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSite);
            Modify_DeleteSiteApiCall(ref _callDeleteSite);
            _callListHardwareGroups = clientHelper.BuildApiCall<ListHardwareGroupsRequest, ListHardwareGroupsResponse>("ListHardwareGroups", grpcClient.ListHardwareGroupsAsync, grpcClient.ListHardwareGroups, effectiveSettings.ListHardwareGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListHardwareGroups);
            Modify_ListHardwareGroupsApiCall(ref _callListHardwareGroups);
            _callGetHardwareGroup = clientHelper.BuildApiCall<GetHardwareGroupRequest, HardwareGroup>("GetHardwareGroup", grpcClient.GetHardwareGroupAsync, grpcClient.GetHardwareGroup, effectiveSettings.GetHardwareGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetHardwareGroup);
            Modify_GetHardwareGroupApiCall(ref _callGetHardwareGroup);
            _callCreateHardwareGroup = clientHelper.BuildApiCall<CreateHardwareGroupRequest, lro::Operation>("CreateHardwareGroup", grpcClient.CreateHardwareGroupAsync, grpcClient.CreateHardwareGroup, effectiveSettings.CreateHardwareGroupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateHardwareGroup);
            Modify_CreateHardwareGroupApiCall(ref _callCreateHardwareGroup);
            _callUpdateHardwareGroup = clientHelper.BuildApiCall<UpdateHardwareGroupRequest, lro::Operation>("UpdateHardwareGroup", grpcClient.UpdateHardwareGroupAsync, grpcClient.UpdateHardwareGroup, effectiveSettings.UpdateHardwareGroupSettings).WithGoogleRequestParam("hardware_group.name", request => request.HardwareGroup?.Name);
            Modify_ApiCall(ref _callUpdateHardwareGroup);
            Modify_UpdateHardwareGroupApiCall(ref _callUpdateHardwareGroup);
            _callDeleteHardwareGroup = clientHelper.BuildApiCall<DeleteHardwareGroupRequest, lro::Operation>("DeleteHardwareGroup", grpcClient.DeleteHardwareGroupAsync, grpcClient.DeleteHardwareGroup, effectiveSettings.DeleteHardwareGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteHardwareGroup);
            Modify_DeleteHardwareGroupApiCall(ref _callDeleteHardwareGroup);
            _callListHardware = clientHelper.BuildApiCall<ListHardwareRequest, ListHardwareResponse>("ListHardware", grpcClient.ListHardwareAsync, grpcClient.ListHardware, effectiveSettings.ListHardwareSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListHardware);
            Modify_ListHardwareApiCall(ref _callListHardware);
            _callGetHardware = clientHelper.BuildApiCall<GetHardwareRequest, Hardware>("GetHardware", grpcClient.GetHardwareAsync, grpcClient.GetHardware, effectiveSettings.GetHardwareSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetHardware);
            Modify_GetHardwareApiCall(ref _callGetHardware);
            _callCreateHardware = clientHelper.BuildApiCall<CreateHardwareRequest, lro::Operation>("CreateHardware", grpcClient.CreateHardwareAsync, grpcClient.CreateHardware, effectiveSettings.CreateHardwareSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateHardware);
            Modify_CreateHardwareApiCall(ref _callCreateHardware);
            _callUpdateHardware = clientHelper.BuildApiCall<UpdateHardwareRequest, lro::Operation>("UpdateHardware", grpcClient.UpdateHardwareAsync, grpcClient.UpdateHardware, effectiveSettings.UpdateHardwareSettings).WithGoogleRequestParam("hardware.name", request => request.Hardware?.Name);
            Modify_ApiCall(ref _callUpdateHardware);
            Modify_UpdateHardwareApiCall(ref _callUpdateHardware);
            _callDeleteHardware = clientHelper.BuildApiCall<DeleteHardwareRequest, lro::Operation>("DeleteHardware", grpcClient.DeleteHardwareAsync, grpcClient.DeleteHardware, effectiveSettings.DeleteHardwareSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteHardware);
            Modify_DeleteHardwareApiCall(ref _callDeleteHardware);
            _callListComments = clientHelper.BuildApiCall<ListCommentsRequest, ListCommentsResponse>("ListComments", grpcClient.ListCommentsAsync, grpcClient.ListComments, effectiveSettings.ListCommentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListComments);
            Modify_ListCommentsApiCall(ref _callListComments);
            _callGetComment = clientHelper.BuildApiCall<GetCommentRequest, Comment>("GetComment", grpcClient.GetCommentAsync, grpcClient.GetComment, effectiveSettings.GetCommentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetComment);
            Modify_GetCommentApiCall(ref _callGetComment);
            _callCreateComment = clientHelper.BuildApiCall<CreateCommentRequest, lro::Operation>("CreateComment", grpcClient.CreateCommentAsync, grpcClient.CreateComment, effectiveSettings.CreateCommentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateComment);
            Modify_CreateCommentApiCall(ref _callCreateComment);
            _callRecordActionOnComment = clientHelper.BuildApiCall<RecordActionOnCommentRequest, Comment>("RecordActionOnComment", grpcClient.RecordActionOnCommentAsync, grpcClient.RecordActionOnComment, effectiveSettings.RecordActionOnCommentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRecordActionOnComment);
            Modify_RecordActionOnCommentApiCall(ref _callRecordActionOnComment);
            _callListChangeLogEntries = clientHelper.BuildApiCall<ListChangeLogEntriesRequest, ListChangeLogEntriesResponse>("ListChangeLogEntries", grpcClient.ListChangeLogEntriesAsync, grpcClient.ListChangeLogEntries, effectiveSettings.ListChangeLogEntriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListChangeLogEntries);
            Modify_ListChangeLogEntriesApiCall(ref _callListChangeLogEntries);
            _callGetChangeLogEntry = clientHelper.BuildApiCall<GetChangeLogEntryRequest, ChangeLogEntry>("GetChangeLogEntry", grpcClient.GetChangeLogEntryAsync, grpcClient.GetChangeLogEntry, effectiveSettings.GetChangeLogEntrySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetChangeLogEntry);
            Modify_GetChangeLogEntryApiCall(ref _callGetChangeLogEntry);
            _callListSkus = clientHelper.BuildApiCall<ListSkusRequest, ListSkusResponse>("ListSkus", grpcClient.ListSkusAsync, grpcClient.ListSkus, effectiveSettings.ListSkusSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSkus);
            Modify_ListSkusApiCall(ref _callListSkus);
            _callGetSku = clientHelper.BuildApiCall<GetSkuRequest, Sku>("GetSku", grpcClient.GetSkuAsync, grpcClient.GetSku, effectiveSettings.GetSkuSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSku);
            Modify_GetSkuApiCall(ref _callGetSku);
            _callListZones = clientHelper.BuildApiCall<ListZonesRequest, ListZonesResponse>("ListZones", grpcClient.ListZonesAsync, grpcClient.ListZones, effectiveSettings.ListZonesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListZones);
            Modify_ListZonesApiCall(ref _callListZones);
            _callGetZone = clientHelper.BuildApiCall<GetZoneRequest, Zone>("GetZone", grpcClient.GetZoneAsync, grpcClient.GetZone, effectiveSettings.GetZoneSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetZone);
            Modify_GetZoneApiCall(ref _callGetZone);
            _callCreateZone = clientHelper.BuildApiCall<CreateZoneRequest, lro::Operation>("CreateZone", grpcClient.CreateZoneAsync, grpcClient.CreateZone, effectiveSettings.CreateZoneSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateZone);
            Modify_CreateZoneApiCall(ref _callCreateZone);
            _callUpdateZone = clientHelper.BuildApiCall<UpdateZoneRequest, lro::Operation>("UpdateZone", grpcClient.UpdateZoneAsync, grpcClient.UpdateZone, effectiveSettings.UpdateZoneSettings).WithGoogleRequestParam("zone.name", request => request.Zone?.Name);
            Modify_ApiCall(ref _callUpdateZone);
            Modify_UpdateZoneApiCall(ref _callUpdateZone);
            _callDeleteZone = clientHelper.BuildApiCall<DeleteZoneRequest, lro::Operation>("DeleteZone", grpcClient.DeleteZoneAsync, grpcClient.DeleteZone, effectiveSettings.DeleteZoneSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteZone);
            Modify_DeleteZoneApiCall(ref _callDeleteZone);
            _callSignalZoneState = clientHelper.BuildApiCall<SignalZoneStateRequest, lro::Operation>("SignalZoneState", grpcClient.SignalZoneStateAsync, grpcClient.SignalZoneState, effectiveSettings.SignalZoneStateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSignalZoneState);
            Modify_SignalZoneStateApiCall(ref _callSignalZoneState);
            _callRequestOrderDateChange = clientHelper.BuildApiCall<RequestOrderDateChangeRequest, lro::Operation>("RequestOrderDateChange", grpcClient.RequestOrderDateChangeAsync, grpcClient.RequestOrderDateChange, effectiveSettings.RequestOrderDateChangeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRequestOrderDateChange);
            Modify_RequestOrderDateChangeApiCall(ref _callRequestOrderDateChange);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListOrdersApiCall(ref gaxgrpc::ApiCall<ListOrdersRequest, ListOrdersResponse> call);

        partial void Modify_GetOrderApiCall(ref gaxgrpc::ApiCall<GetOrderRequest, Order> call);

        partial void Modify_CreateOrderApiCall(ref gaxgrpc::ApiCall<CreateOrderRequest, lro::Operation> call);

        partial void Modify_UpdateOrderApiCall(ref gaxgrpc::ApiCall<UpdateOrderRequest, lro::Operation> call);

        partial void Modify_DeleteOrderApiCall(ref gaxgrpc::ApiCall<DeleteOrderRequest, lro::Operation> call);

        partial void Modify_SubmitOrderApiCall(ref gaxgrpc::ApiCall<SubmitOrderRequest, lro::Operation> call);

        partial void Modify_CancelOrderApiCall(ref gaxgrpc::ApiCall<CancelOrderRequest, lro::Operation> call);

        partial void Modify_ListSitesApiCall(ref gaxgrpc::ApiCall<ListSitesRequest, ListSitesResponse> call);

        partial void Modify_GetSiteApiCall(ref gaxgrpc::ApiCall<GetSiteRequest, Site> call);

        partial void Modify_CreateSiteApiCall(ref gaxgrpc::ApiCall<CreateSiteRequest, lro::Operation> call);

        partial void Modify_UpdateSiteApiCall(ref gaxgrpc::ApiCall<UpdateSiteRequest, lro::Operation> call);

        partial void Modify_DeleteSiteApiCall(ref gaxgrpc::ApiCall<DeleteSiteRequest, lro::Operation> call);

        partial void Modify_ListHardwareGroupsApiCall(ref gaxgrpc::ApiCall<ListHardwareGroupsRequest, ListHardwareGroupsResponse> call);

        partial void Modify_GetHardwareGroupApiCall(ref gaxgrpc::ApiCall<GetHardwareGroupRequest, HardwareGroup> call);

        partial void Modify_CreateHardwareGroupApiCall(ref gaxgrpc::ApiCall<CreateHardwareGroupRequest, lro::Operation> call);

        partial void Modify_UpdateHardwareGroupApiCall(ref gaxgrpc::ApiCall<UpdateHardwareGroupRequest, lro::Operation> call);

        partial void Modify_DeleteHardwareGroupApiCall(ref gaxgrpc::ApiCall<DeleteHardwareGroupRequest, lro::Operation> call);

        partial void Modify_ListHardwareApiCall(ref gaxgrpc::ApiCall<ListHardwareRequest, ListHardwareResponse> call);

        partial void Modify_GetHardwareApiCall(ref gaxgrpc::ApiCall<GetHardwareRequest, Hardware> call);

        partial void Modify_CreateHardwareApiCall(ref gaxgrpc::ApiCall<CreateHardwareRequest, lro::Operation> call);

        partial void Modify_UpdateHardwareApiCall(ref gaxgrpc::ApiCall<UpdateHardwareRequest, lro::Operation> call);

        partial void Modify_DeleteHardwareApiCall(ref gaxgrpc::ApiCall<DeleteHardwareRequest, lro::Operation> call);

        partial void Modify_ListCommentsApiCall(ref gaxgrpc::ApiCall<ListCommentsRequest, ListCommentsResponse> call);

        partial void Modify_GetCommentApiCall(ref gaxgrpc::ApiCall<GetCommentRequest, Comment> call);

        partial void Modify_CreateCommentApiCall(ref gaxgrpc::ApiCall<CreateCommentRequest, lro::Operation> call);

        partial void Modify_RecordActionOnCommentApiCall(ref gaxgrpc::ApiCall<RecordActionOnCommentRequest, Comment> call);

        partial void Modify_ListChangeLogEntriesApiCall(ref gaxgrpc::ApiCall<ListChangeLogEntriesRequest, ListChangeLogEntriesResponse> call);

        partial void Modify_GetChangeLogEntryApiCall(ref gaxgrpc::ApiCall<GetChangeLogEntryRequest, ChangeLogEntry> call);

        partial void Modify_ListSkusApiCall(ref gaxgrpc::ApiCall<ListSkusRequest, ListSkusResponse> call);

        partial void Modify_GetSkuApiCall(ref gaxgrpc::ApiCall<GetSkuRequest, Sku> call);

        partial void Modify_ListZonesApiCall(ref gaxgrpc::ApiCall<ListZonesRequest, ListZonesResponse> call);

        partial void Modify_GetZoneApiCall(ref gaxgrpc::ApiCall<GetZoneRequest, Zone> call);

        partial void Modify_CreateZoneApiCall(ref gaxgrpc::ApiCall<CreateZoneRequest, lro::Operation> call);

        partial void Modify_UpdateZoneApiCall(ref gaxgrpc::ApiCall<UpdateZoneRequest, lro::Operation> call);

        partial void Modify_DeleteZoneApiCall(ref gaxgrpc::ApiCall<DeleteZoneRequest, lro::Operation> call);

        partial void Modify_SignalZoneStateApiCall(ref gaxgrpc::ApiCall<SignalZoneStateRequest, lro::Operation> call);

        partial void Modify_RequestOrderDateChangeApiCall(ref gaxgrpc::ApiCall<RequestOrderDateChangeRequest, lro::Operation> call);

        partial void OnConstruction(GDCHardwareManagement.GDCHardwareManagementClient grpcClient, GDCHardwareManagementSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GDCHardwareManagement client</summary>
        public override GDCHardwareManagement.GDCHardwareManagementClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListOrdersRequest(ref ListOrdersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetOrderRequest(ref GetOrderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateOrderRequest(ref CreateOrderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateOrderRequest(ref UpdateOrderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteOrderRequest(ref DeleteOrderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SubmitOrderRequest(ref SubmitOrderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelOrderRequest(ref CancelOrderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSitesRequest(ref ListSitesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSiteRequest(ref GetSiteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSiteRequest(ref CreateSiteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSiteRequest(ref UpdateSiteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSiteRequest(ref DeleteSiteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListHardwareGroupsRequest(ref ListHardwareGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetHardwareGroupRequest(ref GetHardwareGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateHardwareGroupRequest(ref CreateHardwareGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateHardwareGroupRequest(ref UpdateHardwareGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteHardwareGroupRequest(ref DeleteHardwareGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListHardwareRequest(ref ListHardwareRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetHardwareRequest(ref GetHardwareRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateHardwareRequest(ref CreateHardwareRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateHardwareRequest(ref UpdateHardwareRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteHardwareRequest(ref DeleteHardwareRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCommentsRequest(ref ListCommentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCommentRequest(ref GetCommentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCommentRequest(ref CreateCommentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RecordActionOnCommentRequest(ref RecordActionOnCommentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListChangeLogEntriesRequest(ref ListChangeLogEntriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetChangeLogEntryRequest(ref GetChangeLogEntryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSkusRequest(ref ListSkusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSkuRequest(ref GetSkuRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListZonesRequest(ref ListZonesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetZoneRequest(ref GetZoneRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateZoneRequest(ref CreateZoneRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateZoneRequest(ref UpdateZoneRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteZoneRequest(ref DeleteZoneRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SignalZoneStateRequest(ref SignalZoneStateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RequestOrderDateChangeRequest(ref RequestOrderDateChangeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists orders in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Order"/> resources.</returns>
        public override gax::PagedEnumerable<ListOrdersResponse, Order> ListOrders(ListOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrdersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOrdersRequest, ListOrdersResponse, Order>(_callListOrders, request, callSettings);
        }

        /// <summary>
        /// Lists orders in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Order"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOrdersResponse, Order> ListOrdersAsync(ListOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrdersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOrdersRequest, ListOrdersResponse, Order>(_callListOrders, request, callSettings);
        }

        /// <summary>
        /// Gets details of an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Order GetOrder(GetOrderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrderRequest(ref request, ref callSettings);
            return _callGetOrder.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Order> GetOrderAsync(GetOrderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrderRequest(ref request, ref callSettings);
            return _callGetOrder.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateOrder</c>.</summary>
        public override lro::OperationsClient CreateOrderOperationsClient { get; }

        /// <summary>
        /// Creates a new order in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Order, OperationMetadata> CreateOrder(CreateOrderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOrderRequest(ref request, ref callSettings);
            return new lro::Operation<Order, OperationMetadata>(_callCreateOrder.Sync(request, callSettings), CreateOrderOperationsClient);
        }

        /// <summary>
        /// Creates a new order in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Order, OperationMetadata>> CreateOrderAsync(CreateOrderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOrderRequest(ref request, ref callSettings);
            return new lro::Operation<Order, OperationMetadata>(await _callCreateOrder.Async(request, callSettings).ConfigureAwait(false), CreateOrderOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateOrder</c>.</summary>
        public override lro::OperationsClient UpdateOrderOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Order, OperationMetadata> UpdateOrder(UpdateOrderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOrderRequest(ref request, ref callSettings);
            return new lro::Operation<Order, OperationMetadata>(_callUpdateOrder.Sync(request, callSettings), UpdateOrderOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Order, OperationMetadata>> UpdateOrderAsync(UpdateOrderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOrderRequest(ref request, ref callSettings);
            return new lro::Operation<Order, OperationMetadata>(await _callUpdateOrder.Async(request, callSettings).ConfigureAwait(false), UpdateOrderOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteOrder</c>.</summary>
        public override lro::OperationsClient DeleteOrderOperationsClient { get; }

        /// <summary>
        /// Deletes an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteOrder(DeleteOrderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOrderRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteOrder.Sync(request, callSettings), DeleteOrderOperationsClient);
        }

        /// <summary>
        /// Deletes an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOrderAsync(DeleteOrderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOrderRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteOrder.Async(request, callSettings).ConfigureAwait(false), DeleteOrderOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SubmitOrder</c>.</summary>
        public override lro::OperationsClient SubmitOrderOperationsClient { get; }

        /// <summary>
        /// Submits an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Order, OperationMetadata> SubmitOrder(SubmitOrderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubmitOrderRequest(ref request, ref callSettings);
            return new lro::Operation<Order, OperationMetadata>(_callSubmitOrder.Sync(request, callSettings), SubmitOrderOperationsClient);
        }

        /// <summary>
        /// Submits an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Order, OperationMetadata>> SubmitOrderAsync(SubmitOrderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubmitOrderRequest(ref request, ref callSettings);
            return new lro::Operation<Order, OperationMetadata>(await _callSubmitOrder.Async(request, callSettings).ConfigureAwait(false), SubmitOrderOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CancelOrder</c>.</summary>
        public override lro::OperationsClient CancelOrderOperationsClient { get; }

        /// <summary>
        /// Cancels an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Order, OperationMetadata> CancelOrder(CancelOrderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelOrderRequest(ref request, ref callSettings);
            return new lro::Operation<Order, OperationMetadata>(_callCancelOrder.Sync(request, callSettings), CancelOrderOperationsClient);
        }

        /// <summary>
        /// Cancels an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Order, OperationMetadata>> CancelOrderAsync(CancelOrderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelOrderRequest(ref request, ref callSettings);
            return new lro::Operation<Order, OperationMetadata>(await _callCancelOrder.Async(request, callSettings).ConfigureAwait(false), CancelOrderOperationsClient);
        }

        /// <summary>
        /// Lists sites in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Site"/> resources.</returns>
        public override gax::PagedEnumerable<ListSitesResponse, Site> ListSites(ListSitesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSitesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSitesRequest, ListSitesResponse, Site>(_callListSites, request, callSettings);
        }

        /// <summary>
        /// Lists sites in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Site"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSitesResponse, Site> ListSitesAsync(ListSitesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSitesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSitesRequest, ListSitesResponse, Site>(_callListSites, request, callSettings);
        }

        /// <summary>
        /// Gets details of a site.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Site GetSite(GetSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSiteRequest(ref request, ref callSettings);
            return _callGetSite.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a site.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Site> GetSiteAsync(GetSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSiteRequest(ref request, ref callSettings);
            return _callGetSite.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateSite</c>.</summary>
        public override lro::OperationsClient CreateSiteOperationsClient { get; }

        /// <summary>
        /// Creates a new site in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Site, OperationMetadata> CreateSite(CreateSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSiteRequest(ref request, ref callSettings);
            return new lro::Operation<Site, OperationMetadata>(_callCreateSite.Sync(request, callSettings), CreateSiteOperationsClient);
        }

        /// <summary>
        /// Creates a new site in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Site, OperationMetadata>> CreateSiteAsync(CreateSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSiteRequest(ref request, ref callSettings);
            return new lro::Operation<Site, OperationMetadata>(await _callCreateSite.Async(request, callSettings).ConfigureAwait(false), CreateSiteOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateSite</c>.</summary>
        public override lro::OperationsClient UpdateSiteOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a site.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Site, OperationMetadata> UpdateSite(UpdateSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSiteRequest(ref request, ref callSettings);
            return new lro::Operation<Site, OperationMetadata>(_callUpdateSite.Sync(request, callSettings), UpdateSiteOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a site.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Site, OperationMetadata>> UpdateSiteAsync(UpdateSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSiteRequest(ref request, ref callSettings);
            return new lro::Operation<Site, OperationMetadata>(await _callUpdateSite.Async(request, callSettings).ConfigureAwait(false), UpdateSiteOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteSite</c>.</summary>
        public override lro::OperationsClient DeleteSiteOperationsClient { get; }

        /// <summary>
        /// Deletes a site.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteSite(DeleteSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSiteRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteSite.Sync(request, callSettings), DeleteSiteOperationsClient);
        }

        /// <summary>
        /// Deletes a site.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSiteAsync(DeleteSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSiteRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteSite.Async(request, callSettings).ConfigureAwait(false), DeleteSiteOperationsClient);
        }

        /// <summary>
        /// Lists hardware groups in a given order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HardwareGroup"/> resources.</returns>
        public override gax::PagedEnumerable<ListHardwareGroupsResponse, HardwareGroup> ListHardwareGroups(ListHardwareGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHardwareGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListHardwareGroupsRequest, ListHardwareGroupsResponse, HardwareGroup>(_callListHardwareGroups, request, callSettings);
        }

        /// <summary>
        /// Lists hardware groups in a given order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HardwareGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListHardwareGroupsResponse, HardwareGroup> ListHardwareGroupsAsync(ListHardwareGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHardwareGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListHardwareGroupsRequest, ListHardwareGroupsResponse, HardwareGroup>(_callListHardwareGroups, request, callSettings);
        }

        /// <summary>
        /// Gets details of a hardware group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override HardwareGroup GetHardwareGroup(GetHardwareGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHardwareGroupRequest(ref request, ref callSettings);
            return _callGetHardwareGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a hardware group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<HardwareGroup> GetHardwareGroupAsync(GetHardwareGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHardwareGroupRequest(ref request, ref callSettings);
            return _callGetHardwareGroup.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateHardwareGroup</c>.</summary>
        public override lro::OperationsClient CreateHardwareGroupOperationsClient { get; }

        /// <summary>
        /// Creates a new hardware group in a given order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<HardwareGroup, OperationMetadata> CreateHardwareGroup(CreateHardwareGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHardwareGroupRequest(ref request, ref callSettings);
            return new lro::Operation<HardwareGroup, OperationMetadata>(_callCreateHardwareGroup.Sync(request, callSettings), CreateHardwareGroupOperationsClient);
        }

        /// <summary>
        /// Creates a new hardware group in a given order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<HardwareGroup, OperationMetadata>> CreateHardwareGroupAsync(CreateHardwareGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHardwareGroupRequest(ref request, ref callSettings);
            return new lro::Operation<HardwareGroup, OperationMetadata>(await _callCreateHardwareGroup.Async(request, callSettings).ConfigureAwait(false), CreateHardwareGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateHardwareGroup</c>.</summary>
        public override lro::OperationsClient UpdateHardwareGroupOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a hardware group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<HardwareGroup, OperationMetadata> UpdateHardwareGroup(UpdateHardwareGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateHardwareGroupRequest(ref request, ref callSettings);
            return new lro::Operation<HardwareGroup, OperationMetadata>(_callUpdateHardwareGroup.Sync(request, callSettings), UpdateHardwareGroupOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a hardware group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<HardwareGroup, OperationMetadata>> UpdateHardwareGroupAsync(UpdateHardwareGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateHardwareGroupRequest(ref request, ref callSettings);
            return new lro::Operation<HardwareGroup, OperationMetadata>(await _callUpdateHardwareGroup.Async(request, callSettings).ConfigureAwait(false), UpdateHardwareGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteHardwareGroup</c>.</summary>
        public override lro::OperationsClient DeleteHardwareGroupOperationsClient { get; }

        /// <summary>
        /// Deletes a hardware group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteHardwareGroup(DeleteHardwareGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteHardwareGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteHardwareGroup.Sync(request, callSettings), DeleteHardwareGroupOperationsClient);
        }

        /// <summary>
        /// Deletes a hardware group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHardwareGroupAsync(DeleteHardwareGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteHardwareGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteHardwareGroup.Async(request, callSettings).ConfigureAwait(false), DeleteHardwareGroupOperationsClient);
        }

        /// <summary>
        /// Lists hardware in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Hardware"/> resources.</returns>
        public override gax::PagedEnumerable<ListHardwareResponse, Hardware> ListHardware(ListHardwareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHardwareRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListHardwareRequest, ListHardwareResponse, Hardware>(_callListHardware, request, callSettings);
        }

        /// <summary>
        /// Lists hardware in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Hardware"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListHardwareResponse, Hardware> ListHardwareAsync(ListHardwareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHardwareRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListHardwareRequest, ListHardwareResponse, Hardware>(_callListHardware, request, callSettings);
        }

        /// <summary>
        /// Gets hardware details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Hardware GetHardware(GetHardwareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHardwareRequest(ref request, ref callSettings);
            return _callGetHardware.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets hardware details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Hardware> GetHardwareAsync(GetHardwareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHardwareRequest(ref request, ref callSettings);
            return _callGetHardware.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateHardware</c>.</summary>
        public override lro::OperationsClient CreateHardwareOperationsClient { get; }

        /// <summary>
        /// Creates new hardware in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Hardware, OperationMetadata> CreateHardware(CreateHardwareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHardwareRequest(ref request, ref callSettings);
            return new lro::Operation<Hardware, OperationMetadata>(_callCreateHardware.Sync(request, callSettings), CreateHardwareOperationsClient);
        }

        /// <summary>
        /// Creates new hardware in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Hardware, OperationMetadata>> CreateHardwareAsync(CreateHardwareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHardwareRequest(ref request, ref callSettings);
            return new lro::Operation<Hardware, OperationMetadata>(await _callCreateHardware.Async(request, callSettings).ConfigureAwait(false), CreateHardwareOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateHardware</c>.</summary>
        public override lro::OperationsClient UpdateHardwareOperationsClient { get; }

        /// <summary>
        /// Updates hardware parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Hardware, OperationMetadata> UpdateHardware(UpdateHardwareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateHardwareRequest(ref request, ref callSettings);
            return new lro::Operation<Hardware, OperationMetadata>(_callUpdateHardware.Sync(request, callSettings), UpdateHardwareOperationsClient);
        }

        /// <summary>
        /// Updates hardware parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Hardware, OperationMetadata>> UpdateHardwareAsync(UpdateHardwareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateHardwareRequest(ref request, ref callSettings);
            return new lro::Operation<Hardware, OperationMetadata>(await _callUpdateHardware.Async(request, callSettings).ConfigureAwait(false), UpdateHardwareOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteHardware</c>.</summary>
        public override lro::OperationsClient DeleteHardwareOperationsClient { get; }

        /// <summary>
        /// Deletes hardware.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteHardware(DeleteHardwareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteHardwareRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteHardware.Sync(request, callSettings), DeleteHardwareOperationsClient);
        }

        /// <summary>
        /// Deletes hardware.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHardwareAsync(DeleteHardwareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteHardwareRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteHardware.Async(request, callSettings).ConfigureAwait(false), DeleteHardwareOperationsClient);
        }

        /// <summary>
        /// Lists the comments on an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Comment"/> resources.</returns>
        public override gax::PagedEnumerable<ListCommentsResponse, Comment> ListComments(ListCommentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCommentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCommentsRequest, ListCommentsResponse, Comment>(_callListComments, request, callSettings);
        }

        /// <summary>
        /// Lists the comments on an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Comment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCommentsResponse, Comment> ListCommentsAsync(ListCommentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCommentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCommentsRequest, ListCommentsResponse, Comment>(_callListComments, request, callSettings);
        }

        /// <summary>
        /// Gets the content of a comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Comment GetComment(GetCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCommentRequest(ref request, ref callSettings);
            return _callGetComment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the content of a comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Comment> GetCommentAsync(GetCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCommentRequest(ref request, ref callSettings);
            return _callGetComment.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateComment</c>.</summary>
        public override lro::OperationsClient CreateCommentOperationsClient { get; }

        /// <summary>
        /// Creates a new comment on an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Comment, OperationMetadata> CreateComment(CreateCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCommentRequest(ref request, ref callSettings);
            return new lro::Operation<Comment, OperationMetadata>(_callCreateComment.Sync(request, callSettings), CreateCommentOperationsClient);
        }

        /// <summary>
        /// Creates a new comment on an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Comment, OperationMetadata>> CreateCommentAsync(CreateCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCommentRequest(ref request, ref callSettings);
            return new lro::Operation<Comment, OperationMetadata>(await _callCreateComment.Async(request, callSettings).ConfigureAwait(false), CreateCommentOperationsClient);
        }

        /// <summary>
        /// Record Action on a Comment. If the Action specified in the request is READ,
        /// the viewed time in the comment is set to the time the request was received.
        /// If the comment is already marked as read, subsequent calls will be ignored.
        /// If the Action is UNREAD, the viewed time is cleared from the comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Comment RecordActionOnComment(RecordActionOnCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RecordActionOnCommentRequest(ref request, ref callSettings);
            return _callRecordActionOnComment.Sync(request, callSettings);
        }

        /// <summary>
        /// Record Action on a Comment. If the Action specified in the request is READ,
        /// the viewed time in the comment is set to the time the request was received.
        /// If the comment is already marked as read, subsequent calls will be ignored.
        /// If the Action is UNREAD, the viewed time is cleared from the comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Comment> RecordActionOnCommentAsync(RecordActionOnCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RecordActionOnCommentRequest(ref request, ref callSettings);
            return _callRecordActionOnComment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the changes made to an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ChangeLogEntry"/> resources.</returns>
        public override gax::PagedEnumerable<ListChangeLogEntriesResponse, ChangeLogEntry> ListChangeLogEntries(ListChangeLogEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChangeLogEntriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListChangeLogEntriesRequest, ListChangeLogEntriesResponse, ChangeLogEntry>(_callListChangeLogEntries, request, callSettings);
        }

        /// <summary>
        /// Lists the changes made to an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ChangeLogEntry"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListChangeLogEntriesResponse, ChangeLogEntry> ListChangeLogEntriesAsync(ListChangeLogEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChangeLogEntriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListChangeLogEntriesRequest, ListChangeLogEntriesResponse, ChangeLogEntry>(_callListChangeLogEntries, request, callSettings);
        }

        /// <summary>
        /// Gets details of a change to an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ChangeLogEntry GetChangeLogEntry(GetChangeLogEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChangeLogEntryRequest(ref request, ref callSettings);
            return _callGetChangeLogEntry.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a change to an order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ChangeLogEntry> GetChangeLogEntryAsync(GetChangeLogEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChangeLogEntryRequest(ref request, ref callSettings);
            return _callGetChangeLogEntry.Async(request, callSettings);
        }

        /// <summary>
        /// Lists SKUs for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Sku"/> resources.</returns>
        public override gax::PagedEnumerable<ListSkusResponse, Sku> ListSkus(ListSkusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSkusRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSkusRequest, ListSkusResponse, Sku>(_callListSkus, request, callSettings);
        }

        /// <summary>
        /// Lists SKUs for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Sku"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSkusResponse, Sku> ListSkusAsync(ListSkusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSkusRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSkusRequest, ListSkusResponse, Sku>(_callListSkus, request, callSettings);
        }

        /// <summary>
        /// Gets details of an SKU.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Sku GetSku(GetSkuRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSkuRequest(ref request, ref callSettings);
            return _callGetSku.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of an SKU.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Sku> GetSkuAsync(GetSkuRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSkuRequest(ref request, ref callSettings);
            return _callGetSku.Async(request, callSettings);
        }

        /// <summary>
        /// Lists zones in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Zone"/> resources.</returns>
        public override gax::PagedEnumerable<ListZonesResponse, Zone> ListZones(ListZonesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListZonesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListZonesRequest, ListZonesResponse, Zone>(_callListZones, request, callSettings);
        }

        /// <summary>
        /// Lists zones in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Zone"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListZonesResponse, Zone> ListZonesAsync(ListZonesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListZonesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListZonesRequest, ListZonesResponse, Zone>(_callListZones, request, callSettings);
        }

        /// <summary>
        /// Gets details of a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Zone GetZone(GetZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetZoneRequest(ref request, ref callSettings);
            return _callGetZone.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Zone> GetZoneAsync(GetZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetZoneRequest(ref request, ref callSettings);
            return _callGetZone.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateZone</c>.</summary>
        public override lro::OperationsClient CreateZoneOperationsClient { get; }

        /// <summary>
        /// Creates a new zone in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Zone, OperationMetadata> CreateZone(CreateZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateZoneRequest(ref request, ref callSettings);
            return new lro::Operation<Zone, OperationMetadata>(_callCreateZone.Sync(request, callSettings), CreateZoneOperationsClient);
        }

        /// <summary>
        /// Creates a new zone in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Zone, OperationMetadata>> CreateZoneAsync(CreateZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateZoneRequest(ref request, ref callSettings);
            return new lro::Operation<Zone, OperationMetadata>(await _callCreateZone.Async(request, callSettings).ConfigureAwait(false), CreateZoneOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateZone</c>.</summary>
        public override lro::OperationsClient UpdateZoneOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Zone, OperationMetadata> UpdateZone(UpdateZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateZoneRequest(ref request, ref callSettings);
            return new lro::Operation<Zone, OperationMetadata>(_callUpdateZone.Sync(request, callSettings), UpdateZoneOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Zone, OperationMetadata>> UpdateZoneAsync(UpdateZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateZoneRequest(ref request, ref callSettings);
            return new lro::Operation<Zone, OperationMetadata>(await _callUpdateZone.Async(request, callSettings).ConfigureAwait(false), UpdateZoneOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteZone</c>.</summary>
        public override lro::OperationsClient DeleteZoneOperationsClient { get; }

        /// <summary>
        /// Deletes a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteZone(DeleteZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteZoneRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteZone.Sync(request, callSettings), DeleteZoneOperationsClient);
        }

        /// <summary>
        /// Deletes a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteZoneAsync(DeleteZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteZoneRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteZone.Async(request, callSettings).ConfigureAwait(false), DeleteZoneOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SignalZoneState</c>.</summary>
        public override lro::OperationsClient SignalZoneStateOperationsClient { get; }

        /// <summary>
        /// Signals the state of a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Zone, OperationMetadata> SignalZoneState(SignalZoneStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SignalZoneStateRequest(ref request, ref callSettings);
            return new lro::Operation<Zone, OperationMetadata>(_callSignalZoneState.Sync(request, callSettings), SignalZoneStateOperationsClient);
        }

        /// <summary>
        /// Signals the state of a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Zone, OperationMetadata>> SignalZoneStateAsync(SignalZoneStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SignalZoneStateRequest(ref request, ref callSettings);
            return new lro::Operation<Zone, OperationMetadata>(await _callSignalZoneState.Async(request, callSettings).ConfigureAwait(false), SignalZoneStateOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RequestOrderDateChange</c>.</summary>
        public override lro::OperationsClient RequestOrderDateChangeOperationsClient { get; }

        /// <summary>
        /// Updates the requested date change of a single Order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Order, OperationMetadata> RequestOrderDateChange(RequestOrderDateChangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RequestOrderDateChangeRequest(ref request, ref callSettings);
            return new lro::Operation<Order, OperationMetadata>(_callRequestOrderDateChange.Sync(request, callSettings), RequestOrderDateChangeOperationsClient);
        }

        /// <summary>
        /// Updates the requested date change of a single Order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Order, OperationMetadata>> RequestOrderDateChangeAsync(RequestOrderDateChangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RequestOrderDateChangeRequest(ref request, ref callSettings);
            return new lro::Operation<Order, OperationMetadata>(await _callRequestOrderDateChange.Async(request, callSettings).ConfigureAwait(false), RequestOrderDateChangeOperationsClient);
        }
    }

    public partial class ListOrdersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSitesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListHardwareGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListHardwareRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCommentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListChangeLogEntriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSkusRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListZonesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOrdersResponse : gaxgrpc::IPageResponse<Order>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Order> GetEnumerator() => Orders.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSitesResponse : gaxgrpc::IPageResponse<Site>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Site> GetEnumerator() => Sites.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListHardwareGroupsResponse : gaxgrpc::IPageResponse<HardwareGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<HardwareGroup> GetEnumerator() => HardwareGroups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListHardwareResponse : gaxgrpc::IPageResponse<Hardware>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Hardware> GetEnumerator() => Hardware.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCommentsResponse : gaxgrpc::IPageResponse<Comment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Comment> GetEnumerator() => Comments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListChangeLogEntriesResponse : gaxgrpc::IPageResponse<ChangeLogEntry>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ChangeLogEntry> GetEnumerator() => ChangeLogEntries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSkusResponse : gaxgrpc::IPageResponse<Sku>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Sku> GetEnumerator() => Skus.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListZonesResponse : gaxgrpc::IPageResponse<Zone>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Zone> GetEnumerator() => Zones.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class GDCHardwareManagement
    {
        public partial class GDCHardwareManagementClient
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

    public static partial class GDCHardwareManagement
    {
        public partial class GDCHardwareManagementClient
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
