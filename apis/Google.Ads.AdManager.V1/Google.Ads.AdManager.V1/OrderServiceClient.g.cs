// Copyright 2026 Google LLC
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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="OrderServiceClient"/> instances.</summary>
    public sealed partial class OrderServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="OrderServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="OrderServiceSettings"/>.</returns>
        public static OrderServiceSettings GetDefault() => new OrderServiceSettings();

        /// <summary>Constructs a new <see cref="OrderServiceSettings"/> object with default settings.</summary>
        public OrderServiceSettings()
        {
        }

        private OrderServiceSettings(OrderServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetOrderSettings = existing.GetOrderSettings;
            ListOrdersSettings = existing.ListOrdersSettings;
            BatchCreateOrdersSettings = existing.BatchCreateOrdersSettings;
            BatchUpdateOrdersSettings = existing.BatchUpdateOrdersSettings;
            BatchApproveOrdersSettings = existing.BatchApproveOrdersSettings;
            BatchApproveAndOverbookOrdersSettings = existing.BatchApproveAndOverbookOrdersSettings;
            BatchSubmitOrdersForApprovalSettings = existing.BatchSubmitOrdersForApprovalSettings;
            BatchSubmitOrdersForApprovalAndOverbookSettings = existing.BatchSubmitOrdersForApprovalAndOverbookSettings;
            BatchSubmitOrdersForApprovalWithoutReservationChangesSettings = existing.BatchSubmitOrdersForApprovalWithoutReservationChangesSettings;
            BatchPauseOrdersSettings = existing.BatchPauseOrdersSettings;
            BatchResumeOrdersSettings = existing.BatchResumeOrdersSettings;
            BatchResumeAndOverbookOrdersSettings = existing.BatchResumeAndOverbookOrdersSettings;
            BatchApproveOrdersWithoutReservationSettings = existing.BatchApproveOrdersWithoutReservationSettings;
            BatchArchiveOrdersSettings = existing.BatchArchiveOrdersSettings;
            BatchUnarchiveOrdersSettings = existing.BatchUnarchiveOrdersSettings;
            BatchDeleteOrdersSettings = existing.BatchDeleteOrdersSettings;
            BatchDisapproveOrdersSettings = existing.BatchDisapproveOrdersSettings;
            BatchDisapproveOrdersWithoutReservationChangesSettings = existing.BatchDisapproveOrdersWithoutReservationChangesSettings;
            BatchRetractOrdersSettings = existing.BatchRetractOrdersSettings;
            BatchRetractOrdersWithoutReservationChangesSettings = existing.BatchRetractOrdersWithoutReservationChangesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(OrderServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>OrderServiceClient.GetOrder</c>
        ///  and <c>OrderServiceClient.GetOrderAsync</c>.
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
        /// <c>OrderServiceClient.ListOrders</c> and <c>OrderServiceClient.ListOrdersAsync</c>.
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
        /// <c>OrderServiceClient.BatchCreateOrders</c> and <c>OrderServiceClient.BatchCreateOrdersAsync</c>.
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
        public gaxgrpc::CallSettings BatchCreateOrdersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderServiceClient.BatchUpdateOrders</c> and <c>OrderServiceClient.BatchUpdateOrdersAsync</c>.
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
        public gaxgrpc::CallSettings BatchUpdateOrdersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderServiceClient.BatchApproveOrders</c> and <c>OrderServiceClient.BatchApproveOrdersAsync</c>.
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
        public gaxgrpc::CallSettings BatchApproveOrdersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderServiceClient.BatchApproveAndOverbookOrders</c> and
        /// <c>OrderServiceClient.BatchApproveAndOverbookOrdersAsync</c>.
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
        public gaxgrpc::CallSettings BatchApproveAndOverbookOrdersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderServiceClient.BatchSubmitOrdersForApproval</c> and
        /// <c>OrderServiceClient.BatchSubmitOrdersForApprovalAsync</c>.
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
        public gaxgrpc::CallSettings BatchSubmitOrdersForApprovalSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderServiceClient.BatchSubmitOrdersForApprovalAndOverbook</c> and
        /// <c>OrderServiceClient.BatchSubmitOrdersForApprovalAndOverbookAsync</c>.
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
        public gaxgrpc::CallSettings BatchSubmitOrdersForApprovalAndOverbookSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderServiceClient.BatchSubmitOrdersForApprovalWithoutReservationChanges</c> and
        /// <c>OrderServiceClient.BatchSubmitOrdersForApprovalWithoutReservationChangesAsync</c>.
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
        public gaxgrpc::CallSettings BatchSubmitOrdersForApprovalWithoutReservationChangesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderServiceClient.BatchPauseOrders</c> and <c>OrderServiceClient.BatchPauseOrdersAsync</c>.
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
        public gaxgrpc::CallSettings BatchPauseOrdersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderServiceClient.BatchResumeOrders</c> and <c>OrderServiceClient.BatchResumeOrdersAsync</c>.
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
        public gaxgrpc::CallSettings BatchResumeOrdersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderServiceClient.BatchResumeAndOverbookOrders</c> and
        /// <c>OrderServiceClient.BatchResumeAndOverbookOrdersAsync</c>.
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
        public gaxgrpc::CallSettings BatchResumeAndOverbookOrdersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderServiceClient.BatchApproveOrdersWithoutReservation</c> and
        /// <c>OrderServiceClient.BatchApproveOrdersWithoutReservationAsync</c>.
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
        public gaxgrpc::CallSettings BatchApproveOrdersWithoutReservationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderServiceClient.BatchArchiveOrders</c> and <c>OrderServiceClient.BatchArchiveOrdersAsync</c>.
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
        public gaxgrpc::CallSettings BatchArchiveOrdersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderServiceClient.BatchUnarchiveOrders</c> and <c>OrderServiceClient.BatchUnarchiveOrdersAsync</c>.
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
        public gaxgrpc::CallSettings BatchUnarchiveOrdersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderServiceClient.BatchDeleteOrders</c> and <c>OrderServiceClient.BatchDeleteOrdersAsync</c>.
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
        public gaxgrpc::CallSettings BatchDeleteOrdersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderServiceClient.BatchDisapproveOrders</c> and <c>OrderServiceClient.BatchDisapproveOrdersAsync</c>.
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
        public gaxgrpc::CallSettings BatchDisapproveOrdersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderServiceClient.BatchDisapproveOrdersWithoutReservationChanges</c> and
        /// <c>OrderServiceClient.BatchDisapproveOrdersWithoutReservationChangesAsync</c>.
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
        public gaxgrpc::CallSettings BatchDisapproveOrdersWithoutReservationChangesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderServiceClient.BatchRetractOrders</c> and <c>OrderServiceClient.BatchRetractOrdersAsync</c>.
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
        public gaxgrpc::CallSettings BatchRetractOrdersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderServiceClient.BatchRetractOrdersWithoutReservationChanges</c> and
        /// <c>OrderServiceClient.BatchRetractOrdersWithoutReservationChangesAsync</c>.
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
        public gaxgrpc::CallSettings BatchRetractOrdersWithoutReservationChangesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="OrderServiceSettings"/> object.</returns>
        public OrderServiceSettings Clone() => new OrderServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OrderServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class OrderServiceClientBuilder : gaxgrpc::ClientBuilderBase<OrderServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OrderServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public OrderServiceClientBuilder() : base(OrderServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref OrderServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OrderServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OrderServiceClient Build()
        {
            OrderServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OrderServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OrderServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OrderServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OrderServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<OrderServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OrderServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OrderServiceClient.ChannelPool;
    }

    /// <summary>OrderService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Order` objects.
    /// </remarks>
    public abstract partial class OrderServiceClient
    {
        /// <summary>
        /// The default endpoint for the OrderService service, which is a host of "admanager.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default OrderService scopes.</summary>
        /// <remarks>
        /// The default OrderService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// <item><description>https://www.googleapis.com/auth/admanager.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
            "https://www.googleapis.com/auth/admanager.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(OrderService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="OrderServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="OrderServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OrderServiceClient"/>.</returns>
        public static stt::Task<OrderServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OrderServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OrderServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="OrderServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OrderServiceClient"/>.</returns>
        public static OrderServiceClient Create() => new OrderServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OrderServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OrderServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="OrderServiceClient"/>.</returns>
        internal static OrderServiceClient Create(grpccore::CallInvoker callInvoker, OrderServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OrderService.OrderServiceClient grpcClient = new OrderService.OrderServiceClient(callInvoker);
            return new OrderServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC OrderService client</summary>
        public virtual OrderService.OrderServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an `Order` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Order GetOrder(GetOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an `Order` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(GetOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an `Order` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(GetOrderRequest request, st::CancellationToken cancellationToken) =>
            GetOrderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an `Order` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Order.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Order GetOrder(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrder(new GetOrderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an `Order` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Order.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrderAsync(new GetOrderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an `Order` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Order.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(string name, st::CancellationToken cancellationToken) =>
            GetOrderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an `Order` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Order.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Order GetOrder(OrderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrder(new GetOrderRequest
            {
                OrderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an `Order` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Order.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(OrderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrderAsync(new GetOrderRequest
            {
                OrderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an `Order` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Order.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(OrderName name, st::CancellationToken cancellationToken) =>
            GetOrderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `Order` objects.
        /// 
        /// Fields used for literal matching in filter string:
        /// * `order_id`
        /// * `display_name`
        /// * `external_order_id`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Order"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrdersResponse, Order> ListOrders(ListOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `Order` objects.
        /// 
        /// Fields used for literal matching in filter string:
        /// * `order_id`
        /// * `display_name`
        /// * `external_order_id`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Order"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrdersResponse, Order> ListOrdersAsync(ListOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `Order` objects.
        /// 
        /// Fields used for literal matching in filter string:
        /// * `order_id`
        /// * `display_name`
        /// * `external_order_id`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
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
        /// Lists `Order` objects.
        /// 
        /// Fields used for literal matching in filter string:
        /// * `order_id`
        /// * `display_name`
        /// * `external_order_id`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
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
        /// Lists `Order` objects.
        /// 
        /// Fields used for literal matching in filter string:
        /// * `order_id`
        /// * `display_name`
        /// * `external_order_id`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
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
        public virtual gax::PagedEnumerable<ListOrdersResponse, Order> ListOrders(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrdersRequest request = new ListOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists `Order` objects.
        /// 
        /// Fields used for literal matching in filter string:
        /// * `order_id`
        /// * `display_name`
        /// * `external_order_id`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
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
        public virtual gax::PagedAsyncEnumerable<ListOrdersResponse, Order> ListOrdersAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrdersRequest request = new ListOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Creates `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateOrdersResponse BatchCreateOrders(BatchCreateOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateOrdersResponse> BatchCreateOrdersAsync(BatchCreateOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateOrdersResponse> BatchCreateOrdersAsync(BatchCreateOrdersRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateOrdersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Orders` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateOrderRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Order` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateOrdersResponse BatchCreateOrders(string parent, scg::IEnumerable<CreateOrderRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateOrders(new BatchCreateOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Orders` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateOrderRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Order` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateOrdersResponse> BatchCreateOrdersAsync(string parent, scg::IEnumerable<CreateOrderRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateOrdersAsync(new BatchCreateOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Orders` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateOrderRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Order` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateOrdersResponse> BatchCreateOrdersAsync(string parent, scg::IEnumerable<CreateOrderRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateOrdersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Orders` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateOrderRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Order` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateOrdersResponse BatchCreateOrders(NetworkName parent, scg::IEnumerable<CreateOrderRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateOrders(new BatchCreateOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Orders` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateOrderRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Order` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateOrdersResponse> BatchCreateOrdersAsync(NetworkName parent, scg::IEnumerable<CreateOrderRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateOrdersAsync(new BatchCreateOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Orders` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateOrderRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Order` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateOrdersResponse> BatchCreateOrdersAsync(NetworkName parent, scg::IEnumerable<CreateOrderRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateOrdersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateOrdersResponse BatchUpdateOrders(BatchUpdateOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateOrdersResponse> BatchUpdateOrdersAsync(BatchUpdateOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateOrdersResponse> BatchUpdateOrdersAsync(BatchUpdateOrdersRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateOrdersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Orders` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateOrderRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Order` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateOrdersResponse BatchUpdateOrders(string parent, scg::IEnumerable<UpdateOrderRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateOrders(new BatchUpdateOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Orders` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateOrderRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Order` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateOrdersResponse> BatchUpdateOrdersAsync(string parent, scg::IEnumerable<UpdateOrderRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateOrdersAsync(new BatchUpdateOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Orders` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateOrderRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Order` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateOrdersResponse> BatchUpdateOrdersAsync(string parent, scg::IEnumerable<UpdateOrderRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateOrdersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Orders` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateOrderRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Order` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateOrdersResponse BatchUpdateOrders(NetworkName parent, scg::IEnumerable<UpdateOrderRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateOrders(new BatchUpdateOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Orders` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateOrderRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Order` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateOrdersResponse> BatchUpdateOrdersAsync(NetworkName parent, scg::IEnumerable<UpdateOrderRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateOrdersAsync(new BatchUpdateOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Orders` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateOrderRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Order` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateOrdersResponse> BatchUpdateOrdersAsync(NetworkName parent, scg::IEnumerable<UpdateOrderRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateOrdersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchApproveOrdersResponse BatchApproveOrders(BatchApproveOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approves a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveOrdersResponse> BatchApproveOrdersAsync(BatchApproveOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approves a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveOrdersResponse> BatchApproveOrdersAsync(BatchApproveOrdersRequest request, st::CancellationToken cancellationToken) =>
            BatchApproveOrdersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to approve.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchApproveOrdersResponse BatchApproveOrders(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchApproveOrders(new BatchApproveOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Approves a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to approve.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveOrdersResponse> BatchApproveOrdersAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchApproveOrdersAsync(new BatchApproveOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Approves a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to approve.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveOrdersResponse> BatchApproveOrdersAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchApproveOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to approve.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchApproveOrdersResponse BatchApproveOrders(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchApproveOrders(new BatchApproveOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Approves a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to approve.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveOrdersResponse> BatchApproveOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchApproveOrdersAsync(new BatchApproveOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Approves a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to approve.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveOrdersResponse> BatchApproveOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, st::CancellationToken cancellationToken) =>
            BatchApproveOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchApproveAndOverbookOrdersResponse BatchApproveAndOverbookOrders(BatchApproveAndOverbookOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approves and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveAndOverbookOrdersResponse> BatchApproveAndOverbookOrdersAsync(BatchApproveAndOverbookOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approves and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveAndOverbookOrdersResponse> BatchApproveAndOverbookOrdersAsync(BatchApproveAndOverbookOrdersRequest request, st::CancellationToken cancellationToken) =>
            BatchApproveAndOverbookOrdersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to approve and overbook.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchApproveAndOverbookOrdersResponse BatchApproveAndOverbookOrders(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchApproveAndOverbookOrders(new BatchApproveAndOverbookOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Approves and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to approve and overbook.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveAndOverbookOrdersResponse> BatchApproveAndOverbookOrdersAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchApproveAndOverbookOrdersAsync(new BatchApproveAndOverbookOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Approves and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to approve and overbook.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveAndOverbookOrdersResponse> BatchApproveAndOverbookOrdersAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchApproveAndOverbookOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to approve and overbook.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchApproveAndOverbookOrdersResponse BatchApproveAndOverbookOrders(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchApproveAndOverbookOrders(new BatchApproveAndOverbookOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Approves and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to approve and overbook.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveAndOverbookOrdersResponse> BatchApproveAndOverbookOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchApproveAndOverbookOrdersAsync(new BatchApproveAndOverbookOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Approves and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to approve and overbook.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveAndOverbookOrdersResponse> BatchApproveAndOverbookOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, st::CancellationToken cancellationToken) =>
            BatchApproveAndOverbookOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits a list of `Order` objects for approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchSubmitOrdersForApprovalResponse BatchSubmitOrdersForApproval(BatchSubmitOrdersForApprovalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Submits a list of `Order` objects for approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitOrdersForApprovalResponse> BatchSubmitOrdersForApprovalAsync(BatchSubmitOrdersForApprovalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Submits a list of `Order` objects for approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitOrdersForApprovalResponse> BatchSubmitOrdersForApprovalAsync(BatchSubmitOrdersForApprovalRequest request, st::CancellationToken cancellationToken) =>
            BatchSubmitOrdersForApprovalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits a list of `Order` objects for approval.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to submit for approval.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchSubmitOrdersForApprovalResponse BatchSubmitOrdersForApproval(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchSubmitOrdersForApproval(new BatchSubmitOrdersForApprovalRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Submits a list of `Order` objects for approval.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to submit for approval.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitOrdersForApprovalResponse> BatchSubmitOrdersForApprovalAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchSubmitOrdersForApprovalAsync(new BatchSubmitOrdersForApprovalRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Submits a list of `Order` objects for approval.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to submit for approval.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitOrdersForApprovalResponse> BatchSubmitOrdersForApprovalAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchSubmitOrdersForApprovalAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits a list of `Order` objects for approval.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to submit for approval.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchSubmitOrdersForApprovalResponse BatchSubmitOrdersForApproval(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchSubmitOrdersForApproval(new BatchSubmitOrdersForApprovalRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Submits a list of `Order` objects for approval.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to submit for approval.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitOrdersForApprovalResponse> BatchSubmitOrdersForApprovalAsync(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchSubmitOrdersForApprovalAsync(new BatchSubmitOrdersForApprovalRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Submits a list of `Order` objects for approval.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to submit for approval.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitOrdersForApprovalResponse> BatchSubmitOrdersForApprovalAsync(NetworkName parent, scg::IEnumerable<OrderName> names, st::CancellationToken cancellationToken) =>
            BatchSubmitOrdersForApprovalAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits and overbooks a list of `Order` objects for approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchSubmitOrdersForApprovalAndOverbookResponse BatchSubmitOrdersForApprovalAndOverbook(BatchSubmitOrdersForApprovalAndOverbookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Submits and overbooks a list of `Order` objects for approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitOrdersForApprovalAndOverbookResponse> BatchSubmitOrdersForApprovalAndOverbookAsync(BatchSubmitOrdersForApprovalAndOverbookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Submits and overbooks a list of `Order` objects for approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitOrdersForApprovalAndOverbookResponse> BatchSubmitOrdersForApprovalAndOverbookAsync(BatchSubmitOrdersForApprovalAndOverbookRequest request, st::CancellationToken cancellationToken) =>
            BatchSubmitOrdersForApprovalAndOverbookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits and overbooks a list of `Order` objects for approval.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to submit for approval and
        /// overbook. Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchSubmitOrdersForApprovalAndOverbookResponse BatchSubmitOrdersForApprovalAndOverbook(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchSubmitOrdersForApprovalAndOverbook(new BatchSubmitOrdersForApprovalAndOverbookRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Submits and overbooks a list of `Order` objects for approval.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to submit for approval and
        /// overbook. Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitOrdersForApprovalAndOverbookResponse> BatchSubmitOrdersForApprovalAndOverbookAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchSubmitOrdersForApprovalAndOverbookAsync(new BatchSubmitOrdersForApprovalAndOverbookRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Submits and overbooks a list of `Order` objects for approval.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to submit for approval and
        /// overbook. Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitOrdersForApprovalAndOverbookResponse> BatchSubmitOrdersForApprovalAndOverbookAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchSubmitOrdersForApprovalAndOverbookAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits and overbooks a list of `Order` objects for approval.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to submit for approval and
        /// overbook. Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchSubmitOrdersForApprovalAndOverbookResponse BatchSubmitOrdersForApprovalAndOverbook(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchSubmitOrdersForApprovalAndOverbook(new BatchSubmitOrdersForApprovalAndOverbookRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Submits and overbooks a list of `Order` objects for approval.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to submit for approval and
        /// overbook. Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitOrdersForApprovalAndOverbookResponse> BatchSubmitOrdersForApprovalAndOverbookAsync(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchSubmitOrdersForApprovalAndOverbookAsync(new BatchSubmitOrdersForApprovalAndOverbookRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Submits and overbooks a list of `Order` objects for approval.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to submit for approval and
        /// overbook. Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitOrdersForApprovalAndOverbookResponse> BatchSubmitOrdersForApprovalAndOverbookAsync(NetworkName parent, scg::IEnumerable<OrderName> names, st::CancellationToken cancellationToken) =>
            BatchSubmitOrdersForApprovalAndOverbookAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits a list of `Order` objects for approval without changing reservation
        /// status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchSubmitOrdersForApprovalWithoutReservationChangesResponse BatchSubmitOrdersForApprovalWithoutReservationChanges(BatchSubmitOrdersForApprovalWithoutReservationChangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Submits a list of `Order` objects for approval without changing reservation
        /// status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitOrdersForApprovalWithoutReservationChangesResponse> BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(BatchSubmitOrdersForApprovalWithoutReservationChangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Submits a list of `Order` objects for approval without changing reservation
        /// status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitOrdersForApprovalWithoutReservationChangesResponse> BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(BatchSubmitOrdersForApprovalWithoutReservationChangesRequest request, st::CancellationToken cancellationToken) =>
            BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits a list of `Order` objects for approval without changing reservation
        /// status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to submit for approval.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchSubmitOrdersForApprovalWithoutReservationChangesResponse BatchSubmitOrdersForApprovalWithoutReservationChanges(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchSubmitOrdersForApprovalWithoutReservationChanges(new BatchSubmitOrdersForApprovalWithoutReservationChangesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Submits a list of `Order` objects for approval without changing reservation
        /// status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to submit for approval.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitOrdersForApprovalWithoutReservationChangesResponse> BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(new BatchSubmitOrdersForApprovalWithoutReservationChangesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Submits a list of `Order` objects for approval without changing reservation
        /// status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to submit for approval.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitOrdersForApprovalWithoutReservationChangesResponse> BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits a list of `Order` objects for approval without changing reservation
        /// status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to submit for approval.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchSubmitOrdersForApprovalWithoutReservationChangesResponse BatchSubmitOrdersForApprovalWithoutReservationChanges(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchSubmitOrdersForApprovalWithoutReservationChanges(new BatchSubmitOrdersForApprovalWithoutReservationChangesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Submits a list of `Order` objects for approval without changing reservation
        /// status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to submit for approval.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitOrdersForApprovalWithoutReservationChangesResponse> BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(new BatchSubmitOrdersForApprovalWithoutReservationChangesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Submits a list of `Order` objects for approval without changing reservation
        /// status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to submit for approval.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitOrdersForApprovalWithoutReservationChangesResponse> BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(NetworkName parent, scg::IEnumerable<OrderName> names, st::CancellationToken cancellationToken) =>
            BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPauseOrdersResponse BatchPauseOrders(BatchPauseOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseOrdersResponse> BatchPauseOrdersAsync(BatchPauseOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseOrdersResponse> BatchPauseOrdersAsync(BatchPauseOrdersRequest request, st::CancellationToken cancellationToken) =>
            BatchPauseOrdersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to pause.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPauseOrdersResponse BatchPauseOrders(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseOrders(new BatchPauseOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Pauses a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to pause.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseOrdersResponse> BatchPauseOrdersAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseOrdersAsync(new BatchPauseOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Pauses a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to pause.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseOrdersResponse> BatchPauseOrdersAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchPauseOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to pause.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPauseOrdersResponse BatchPauseOrders(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseOrders(new BatchPauseOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Pauses a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to pause.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseOrdersResponse> BatchPauseOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseOrdersAsync(new BatchPauseOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Pauses a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to pause.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseOrdersResponse> BatchPauseOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, st::CancellationToken cancellationToken) =>
            BatchPauseOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchResumeOrdersResponse BatchResumeOrders(BatchResumeOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeOrdersResponse> BatchResumeOrdersAsync(BatchResumeOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeOrdersResponse> BatchResumeOrdersAsync(BatchResumeOrdersRequest request, st::CancellationToken cancellationToken) =>
            BatchResumeOrdersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to resume.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchResumeOrdersResponse BatchResumeOrders(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeOrders(new BatchResumeOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Resumes a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to resume.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeOrdersResponse> BatchResumeOrdersAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeOrdersAsync(new BatchResumeOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Resumes a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to resume.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeOrdersResponse> BatchResumeOrdersAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchResumeOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to resume.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchResumeOrdersResponse BatchResumeOrders(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeOrders(new BatchResumeOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Resumes a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to resume.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeOrdersResponse> BatchResumeOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeOrdersAsync(new BatchResumeOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Resumes a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to resume.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeOrdersResponse> BatchResumeOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, st::CancellationToken cancellationToken) =>
            BatchResumeOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchResumeAndOverbookOrdersResponse BatchResumeAndOverbookOrders(BatchResumeAndOverbookOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeAndOverbookOrdersResponse> BatchResumeAndOverbookOrdersAsync(BatchResumeAndOverbookOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeAndOverbookOrdersResponse> BatchResumeAndOverbookOrdersAsync(BatchResumeAndOverbookOrdersRequest request, st::CancellationToken cancellationToken) =>
            BatchResumeAndOverbookOrdersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to resume and overbook.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchResumeAndOverbookOrdersResponse BatchResumeAndOverbookOrders(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeAndOverbookOrders(new BatchResumeAndOverbookOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Resumes and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to resume and overbook.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeAndOverbookOrdersResponse> BatchResumeAndOverbookOrdersAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeAndOverbookOrdersAsync(new BatchResumeAndOverbookOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Resumes and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to resume and overbook.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeAndOverbookOrdersResponse> BatchResumeAndOverbookOrdersAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchResumeAndOverbookOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to resume and overbook.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchResumeAndOverbookOrdersResponse BatchResumeAndOverbookOrders(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeAndOverbookOrders(new BatchResumeAndOverbookOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Resumes and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to resume and overbook.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeAndOverbookOrdersResponse> BatchResumeAndOverbookOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeAndOverbookOrdersAsync(new BatchResumeAndOverbookOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Resumes and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to resume and overbook.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeAndOverbookOrdersResponse> BatchResumeAndOverbookOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, st::CancellationToken cancellationToken) =>
            BatchResumeAndOverbookOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchApproveOrdersWithoutReservationResponse BatchApproveOrdersWithoutReservation(BatchApproveOrdersWithoutReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveOrdersWithoutReservationResponse> BatchApproveOrdersWithoutReservationAsync(BatchApproveOrdersWithoutReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveOrdersWithoutReservationResponse> BatchApproveOrdersWithoutReservationAsync(BatchApproveOrdersWithoutReservationRequest request, st::CancellationToken cancellationToken) =>
            BatchApproveOrdersWithoutReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to approve.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchApproveOrdersWithoutReservationResponse BatchApproveOrdersWithoutReservation(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchApproveOrdersWithoutReservation(new BatchApproveOrdersWithoutReservationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Approves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to approve.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveOrdersWithoutReservationResponse> BatchApproveOrdersWithoutReservationAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchApproveOrdersWithoutReservationAsync(new BatchApproveOrdersWithoutReservationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Approves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to approve.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveOrdersWithoutReservationResponse> BatchApproveOrdersWithoutReservationAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchApproveOrdersWithoutReservationAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to approve.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchApproveOrdersWithoutReservationResponse BatchApproveOrdersWithoutReservation(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchApproveOrdersWithoutReservation(new BatchApproveOrdersWithoutReservationRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Approves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to approve.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveOrdersWithoutReservationResponse> BatchApproveOrdersWithoutReservationAsync(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchApproveOrdersWithoutReservationAsync(new BatchApproveOrdersWithoutReservationRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Approves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to approve.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveOrdersWithoutReservationResponse> BatchApproveOrdersWithoutReservationAsync(NetworkName parent, scg::IEnumerable<OrderName> names, st::CancellationToken cancellationToken) =>
            BatchApproveOrdersWithoutReservationAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveOrdersResponse BatchArchiveOrders(BatchArchiveOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Archives a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveOrdersResponse> BatchArchiveOrdersAsync(BatchArchiveOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Archives a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveOrdersResponse> BatchArchiveOrdersAsync(BatchArchiveOrdersRequest request, st::CancellationToken cancellationToken) =>
            BatchArchiveOrdersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to archive.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveOrdersResponse BatchArchiveOrders(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveOrders(new BatchArchiveOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Archives a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to archive.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveOrdersResponse> BatchArchiveOrdersAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveOrdersAsync(new BatchArchiveOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Archives a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to archive.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveOrdersResponse> BatchArchiveOrdersAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchArchiveOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to archive.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveOrdersResponse BatchArchiveOrders(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveOrders(new BatchArchiveOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Archives a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to archive.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveOrdersResponse> BatchArchiveOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveOrdersAsync(new BatchArchiveOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Archives a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to archive.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveOrdersResponse> BatchArchiveOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, st::CancellationToken cancellationToken) =>
            BatchArchiveOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unarchives a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUnarchiveOrdersResponse BatchUnarchiveOrders(BatchUnarchiveOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unarchives a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveOrdersResponse> BatchUnarchiveOrdersAsync(BatchUnarchiveOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unarchives a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveOrdersResponse> BatchUnarchiveOrdersAsync(BatchUnarchiveOrdersRequest request, st::CancellationToken cancellationToken) =>
            BatchUnarchiveOrdersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unarchives a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to extract.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUnarchiveOrdersResponse BatchUnarchiveOrders(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchUnarchiveOrders(new BatchUnarchiveOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Unarchives a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to extract.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveOrdersResponse> BatchUnarchiveOrdersAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchUnarchiveOrdersAsync(new BatchUnarchiveOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Unarchives a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to extract.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveOrdersResponse> BatchUnarchiveOrdersAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchUnarchiveOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unarchives a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to extract.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUnarchiveOrdersResponse BatchUnarchiveOrders(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchUnarchiveOrders(new BatchUnarchiveOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Unarchives a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to extract.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveOrdersResponse> BatchUnarchiveOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchUnarchiveOrdersAsync(new BatchUnarchiveOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Unarchives a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to extract.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveOrdersResponse> BatchUnarchiveOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, st::CancellationToken cancellationToken) =>
            BatchUnarchiveOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeleteOrdersResponse BatchDeleteOrders(BatchDeleteOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeleteOrdersResponse> BatchDeleteOrdersAsync(BatchDeleteOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeleteOrdersResponse> BatchDeleteOrdersAsync(BatchDeleteOrdersRequest request, st::CancellationToken cancellationToken) =>
            BatchDeleteOrdersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to delete.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeleteOrdersResponse BatchDeleteOrders(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteOrders(new BatchDeleteOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to delete.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeleteOrdersResponse> BatchDeleteOrdersAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteOrdersAsync(new BatchDeleteOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to delete.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeleteOrdersResponse> BatchDeleteOrdersAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeleteOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to delete.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeleteOrdersResponse BatchDeleteOrders(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteOrders(new BatchDeleteOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to delete.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeleteOrdersResponse> BatchDeleteOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteOrdersAsync(new BatchDeleteOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to delete.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeleteOrdersResponse> BatchDeleteOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, st::CancellationToken cancellationToken) =>
            BatchDeleteOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disapproves a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDisapproveOrdersResponse BatchDisapproveOrders(BatchDisapproveOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disapproves a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDisapproveOrdersResponse> BatchDisapproveOrdersAsync(BatchDisapproveOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disapproves a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDisapproveOrdersResponse> BatchDisapproveOrdersAsync(BatchDisapproveOrdersRequest request, st::CancellationToken cancellationToken) =>
            BatchDisapproveOrdersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disapproves a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to disapprove.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDisapproveOrdersResponse BatchDisapproveOrders(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDisapproveOrders(new BatchDisapproveOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Disapproves a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to disapprove.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDisapproveOrdersResponse> BatchDisapproveOrdersAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDisapproveOrdersAsync(new BatchDisapproveOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Disapproves a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to disapprove.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDisapproveOrdersResponse> BatchDisapproveOrdersAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDisapproveOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disapproves a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to disapprove.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDisapproveOrdersResponse BatchDisapproveOrders(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDisapproveOrders(new BatchDisapproveOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Disapproves a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to disapprove.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDisapproveOrdersResponse> BatchDisapproveOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDisapproveOrdersAsync(new BatchDisapproveOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Disapproves a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to disapprove.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDisapproveOrdersResponse> BatchDisapproveOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, st::CancellationToken cancellationToken) =>
            BatchDisapproveOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disapproves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDisapproveOrdersWithoutReservationChangesResponse BatchDisapproveOrdersWithoutReservationChanges(BatchDisapproveOrdersWithoutReservationChangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disapproves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDisapproveOrdersWithoutReservationChangesResponse> BatchDisapproveOrdersWithoutReservationChangesAsync(BatchDisapproveOrdersWithoutReservationChangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disapproves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDisapproveOrdersWithoutReservationChangesResponse> BatchDisapproveOrdersWithoutReservationChangesAsync(BatchDisapproveOrdersWithoutReservationChangesRequest request, st::CancellationToken cancellationToken) =>
            BatchDisapproveOrdersWithoutReservationChangesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disapproves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to disapprove without
        /// reservation changes. Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDisapproveOrdersWithoutReservationChangesResponse BatchDisapproveOrdersWithoutReservationChanges(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDisapproveOrdersWithoutReservationChanges(new BatchDisapproveOrdersWithoutReservationChangesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Disapproves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to disapprove without
        /// reservation changes. Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDisapproveOrdersWithoutReservationChangesResponse> BatchDisapproveOrdersWithoutReservationChangesAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDisapproveOrdersWithoutReservationChangesAsync(new BatchDisapproveOrdersWithoutReservationChangesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Disapproves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to disapprove without
        /// reservation changes. Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDisapproveOrdersWithoutReservationChangesResponse> BatchDisapproveOrdersWithoutReservationChangesAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDisapproveOrdersWithoutReservationChangesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disapproves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to disapprove without
        /// reservation changes. Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDisapproveOrdersWithoutReservationChangesResponse BatchDisapproveOrdersWithoutReservationChanges(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDisapproveOrdersWithoutReservationChanges(new BatchDisapproveOrdersWithoutReservationChangesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Disapproves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to disapprove without
        /// reservation changes. Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDisapproveOrdersWithoutReservationChangesResponse> BatchDisapproveOrdersWithoutReservationChangesAsync(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDisapproveOrdersWithoutReservationChangesAsync(new BatchDisapproveOrdersWithoutReservationChangesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Disapproves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to disapprove without
        /// reservation changes. Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDisapproveOrdersWithoutReservationChangesResponse> BatchDisapproveOrdersWithoutReservationChangesAsync(NetworkName parent, scg::IEnumerable<OrderName> names, st::CancellationToken cancellationToken) =>
            BatchDisapproveOrdersWithoutReservationChangesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retracts a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRetractOrdersResponse BatchRetractOrders(BatchRetractOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retracts a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRetractOrdersResponse> BatchRetractOrdersAsync(BatchRetractOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retracts a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRetractOrdersResponse> BatchRetractOrdersAsync(BatchRetractOrdersRequest request, st::CancellationToken cancellationToken) =>
            BatchRetractOrdersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retracts a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to retract.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRetractOrdersResponse BatchRetractOrders(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRetractOrders(new BatchRetractOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Retracts a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to retract.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRetractOrdersResponse> BatchRetractOrdersAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRetractOrdersAsync(new BatchRetractOrdersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Retracts a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to retract.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRetractOrdersResponse> BatchRetractOrdersAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchRetractOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retracts a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to retract.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRetractOrdersResponse BatchRetractOrders(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRetractOrders(new BatchRetractOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Retracts a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to retract.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRetractOrdersResponse> BatchRetractOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRetractOrdersAsync(new BatchRetractOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Retracts a list of `Order` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to retract.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRetractOrdersResponse> BatchRetractOrdersAsync(NetworkName parent, scg::IEnumerable<OrderName> names, st::CancellationToken cancellationToken) =>
            BatchRetractOrdersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retracts a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRetractOrdersWithoutReservationChangesResponse BatchRetractOrdersWithoutReservationChanges(BatchRetractOrdersWithoutReservationChangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retracts a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRetractOrdersWithoutReservationChangesResponse> BatchRetractOrdersWithoutReservationChangesAsync(BatchRetractOrdersWithoutReservationChangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retracts a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRetractOrdersWithoutReservationChangesResponse> BatchRetractOrdersWithoutReservationChangesAsync(BatchRetractOrdersWithoutReservationChangesRequest request, st::CancellationToken cancellationToken) =>
            BatchRetractOrdersWithoutReservationChangesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retracts a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to retract.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRetractOrdersWithoutReservationChangesResponse BatchRetractOrdersWithoutReservationChanges(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRetractOrdersWithoutReservationChanges(new BatchRetractOrdersWithoutReservationChangesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Retracts a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to retract.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRetractOrdersWithoutReservationChangesResponse> BatchRetractOrdersWithoutReservationChangesAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRetractOrdersWithoutReservationChangesAsync(new BatchRetractOrdersWithoutReservationChangesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Retracts a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to retract.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRetractOrdersWithoutReservationChangesResponse> BatchRetractOrdersWithoutReservationChangesAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchRetractOrdersWithoutReservationChangesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retracts a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to retract.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRetractOrdersWithoutReservationChangesResponse BatchRetractOrdersWithoutReservationChanges(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRetractOrdersWithoutReservationChanges(new BatchRetractOrdersWithoutReservationChangesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Retracts a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to retract.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRetractOrdersWithoutReservationChangesResponse> BatchRetractOrdersWithoutReservationChangesAsync(NetworkName parent, scg::IEnumerable<OrderName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRetractOrdersWithoutReservationChangesAsync(new BatchRetractOrdersWithoutReservationChangesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Retracts a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the orders to retract.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRetractOrdersWithoutReservationChangesResponse> BatchRetractOrdersWithoutReservationChangesAsync(NetworkName parent, scg::IEnumerable<OrderName> names, st::CancellationToken cancellationToken) =>
            BatchRetractOrdersWithoutReservationChangesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>OrderService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Order` objects.
    /// </remarks>
    public sealed partial class OrderServiceClientImpl : OrderServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetOrderRequest, Order> _callGetOrder;

        private readonly gaxgrpc::ApiCall<ListOrdersRequest, ListOrdersResponse> _callListOrders;

        private readonly gaxgrpc::ApiCall<BatchCreateOrdersRequest, BatchCreateOrdersResponse> _callBatchCreateOrders;

        private readonly gaxgrpc::ApiCall<BatchUpdateOrdersRequest, BatchUpdateOrdersResponse> _callBatchUpdateOrders;

        private readonly gaxgrpc::ApiCall<BatchApproveOrdersRequest, BatchApproveOrdersResponse> _callBatchApproveOrders;

        private readonly gaxgrpc::ApiCall<BatchApproveAndOverbookOrdersRequest, BatchApproveAndOverbookOrdersResponse> _callBatchApproveAndOverbookOrders;

        private readonly gaxgrpc::ApiCall<BatchSubmitOrdersForApprovalRequest, BatchSubmitOrdersForApprovalResponse> _callBatchSubmitOrdersForApproval;

        private readonly gaxgrpc::ApiCall<BatchSubmitOrdersForApprovalAndOverbookRequest, BatchSubmitOrdersForApprovalAndOverbookResponse> _callBatchSubmitOrdersForApprovalAndOverbook;

        private readonly gaxgrpc::ApiCall<BatchSubmitOrdersForApprovalWithoutReservationChangesRequest, BatchSubmitOrdersForApprovalWithoutReservationChangesResponse> _callBatchSubmitOrdersForApprovalWithoutReservationChanges;

        private readonly gaxgrpc::ApiCall<BatchPauseOrdersRequest, BatchPauseOrdersResponse> _callBatchPauseOrders;

        private readonly gaxgrpc::ApiCall<BatchResumeOrdersRequest, BatchResumeOrdersResponse> _callBatchResumeOrders;

        private readonly gaxgrpc::ApiCall<BatchResumeAndOverbookOrdersRequest, BatchResumeAndOverbookOrdersResponse> _callBatchResumeAndOverbookOrders;

        private readonly gaxgrpc::ApiCall<BatchApproveOrdersWithoutReservationRequest, BatchApproveOrdersWithoutReservationResponse> _callBatchApproveOrdersWithoutReservation;

        private readonly gaxgrpc::ApiCall<BatchArchiveOrdersRequest, BatchArchiveOrdersResponse> _callBatchArchiveOrders;

        private readonly gaxgrpc::ApiCall<BatchUnarchiveOrdersRequest, BatchUnarchiveOrdersResponse> _callBatchUnarchiveOrders;

        private readonly gaxgrpc::ApiCall<BatchDeleteOrdersRequest, BatchDeleteOrdersResponse> _callBatchDeleteOrders;

        private readonly gaxgrpc::ApiCall<BatchDisapproveOrdersRequest, BatchDisapproveOrdersResponse> _callBatchDisapproveOrders;

        private readonly gaxgrpc::ApiCall<BatchDisapproveOrdersWithoutReservationChangesRequest, BatchDisapproveOrdersWithoutReservationChangesResponse> _callBatchDisapproveOrdersWithoutReservationChanges;

        private readonly gaxgrpc::ApiCall<BatchRetractOrdersRequest, BatchRetractOrdersResponse> _callBatchRetractOrders;

        private readonly gaxgrpc::ApiCall<BatchRetractOrdersWithoutReservationChangesRequest, BatchRetractOrdersWithoutReservationChangesResponse> _callBatchRetractOrdersWithoutReservationChanges;

        /// <summary>
        /// Constructs a client wrapper for the OrderService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="OrderServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public OrderServiceClientImpl(OrderService.OrderServiceClient grpcClient, OrderServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            OrderServiceSettings effectiveSettings = settings ?? OrderServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetOrder = clientHelper.BuildApiCall<GetOrderRequest, Order>("GetOrder", grpcClient.GetOrderAsync, grpcClient.GetOrder, effectiveSettings.GetOrderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOrder);
            Modify_GetOrderApiCall(ref _callGetOrder);
            _callListOrders = clientHelper.BuildApiCall<ListOrdersRequest, ListOrdersResponse>("ListOrders", grpcClient.ListOrdersAsync, grpcClient.ListOrders, effectiveSettings.ListOrdersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOrders);
            Modify_ListOrdersApiCall(ref _callListOrders);
            _callBatchCreateOrders = clientHelper.BuildApiCall<BatchCreateOrdersRequest, BatchCreateOrdersResponse>("BatchCreateOrders", grpcClient.BatchCreateOrdersAsync, grpcClient.BatchCreateOrders, effectiveSettings.BatchCreateOrdersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateOrders);
            Modify_BatchCreateOrdersApiCall(ref _callBatchCreateOrders);
            _callBatchUpdateOrders = clientHelper.BuildApiCall<BatchUpdateOrdersRequest, BatchUpdateOrdersResponse>("BatchUpdateOrders", grpcClient.BatchUpdateOrdersAsync, grpcClient.BatchUpdateOrders, effectiveSettings.BatchUpdateOrdersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateOrders);
            Modify_BatchUpdateOrdersApiCall(ref _callBatchUpdateOrders);
            _callBatchApproveOrders = clientHelper.BuildApiCall<BatchApproveOrdersRequest, BatchApproveOrdersResponse>("BatchApproveOrders", grpcClient.BatchApproveOrdersAsync, grpcClient.BatchApproveOrders, effectiveSettings.BatchApproveOrdersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchApproveOrders);
            Modify_BatchApproveOrdersApiCall(ref _callBatchApproveOrders);
            _callBatchApproveAndOverbookOrders = clientHelper.BuildApiCall<BatchApproveAndOverbookOrdersRequest, BatchApproveAndOverbookOrdersResponse>("BatchApproveAndOverbookOrders", grpcClient.BatchApproveAndOverbookOrdersAsync, grpcClient.BatchApproveAndOverbookOrders, effectiveSettings.BatchApproveAndOverbookOrdersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchApproveAndOverbookOrders);
            Modify_BatchApproveAndOverbookOrdersApiCall(ref _callBatchApproveAndOverbookOrders);
            _callBatchSubmitOrdersForApproval = clientHelper.BuildApiCall<BatchSubmitOrdersForApprovalRequest, BatchSubmitOrdersForApprovalResponse>("BatchSubmitOrdersForApproval", grpcClient.BatchSubmitOrdersForApprovalAsync, grpcClient.BatchSubmitOrdersForApproval, effectiveSettings.BatchSubmitOrdersForApprovalSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchSubmitOrdersForApproval);
            Modify_BatchSubmitOrdersForApprovalApiCall(ref _callBatchSubmitOrdersForApproval);
            _callBatchSubmitOrdersForApprovalAndOverbook = clientHelper.BuildApiCall<BatchSubmitOrdersForApprovalAndOverbookRequest, BatchSubmitOrdersForApprovalAndOverbookResponse>("BatchSubmitOrdersForApprovalAndOverbook", grpcClient.BatchSubmitOrdersForApprovalAndOverbookAsync, grpcClient.BatchSubmitOrdersForApprovalAndOverbook, effectiveSettings.BatchSubmitOrdersForApprovalAndOverbookSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchSubmitOrdersForApprovalAndOverbook);
            Modify_BatchSubmitOrdersForApprovalAndOverbookApiCall(ref _callBatchSubmitOrdersForApprovalAndOverbook);
            _callBatchSubmitOrdersForApprovalWithoutReservationChanges = clientHelper.BuildApiCall<BatchSubmitOrdersForApprovalWithoutReservationChangesRequest, BatchSubmitOrdersForApprovalWithoutReservationChangesResponse>("BatchSubmitOrdersForApprovalWithoutReservationChanges", grpcClient.BatchSubmitOrdersForApprovalWithoutReservationChangesAsync, grpcClient.BatchSubmitOrdersForApprovalWithoutReservationChanges, effectiveSettings.BatchSubmitOrdersForApprovalWithoutReservationChangesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchSubmitOrdersForApprovalWithoutReservationChanges);
            Modify_BatchSubmitOrdersForApprovalWithoutReservationChangesApiCall(ref _callBatchSubmitOrdersForApprovalWithoutReservationChanges);
            _callBatchPauseOrders = clientHelper.BuildApiCall<BatchPauseOrdersRequest, BatchPauseOrdersResponse>("BatchPauseOrders", grpcClient.BatchPauseOrdersAsync, grpcClient.BatchPauseOrders, effectiveSettings.BatchPauseOrdersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchPauseOrders);
            Modify_BatchPauseOrdersApiCall(ref _callBatchPauseOrders);
            _callBatchResumeOrders = clientHelper.BuildApiCall<BatchResumeOrdersRequest, BatchResumeOrdersResponse>("BatchResumeOrders", grpcClient.BatchResumeOrdersAsync, grpcClient.BatchResumeOrders, effectiveSettings.BatchResumeOrdersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchResumeOrders);
            Modify_BatchResumeOrdersApiCall(ref _callBatchResumeOrders);
            _callBatchResumeAndOverbookOrders = clientHelper.BuildApiCall<BatchResumeAndOverbookOrdersRequest, BatchResumeAndOverbookOrdersResponse>("BatchResumeAndOverbookOrders", grpcClient.BatchResumeAndOverbookOrdersAsync, grpcClient.BatchResumeAndOverbookOrders, effectiveSettings.BatchResumeAndOverbookOrdersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchResumeAndOverbookOrders);
            Modify_BatchResumeAndOverbookOrdersApiCall(ref _callBatchResumeAndOverbookOrders);
            _callBatchApproveOrdersWithoutReservation = clientHelper.BuildApiCall<BatchApproveOrdersWithoutReservationRequest, BatchApproveOrdersWithoutReservationResponse>("BatchApproveOrdersWithoutReservation", grpcClient.BatchApproveOrdersWithoutReservationAsync, grpcClient.BatchApproveOrdersWithoutReservation, effectiveSettings.BatchApproveOrdersWithoutReservationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchApproveOrdersWithoutReservation);
            Modify_BatchApproveOrdersWithoutReservationApiCall(ref _callBatchApproveOrdersWithoutReservation);
            _callBatchArchiveOrders = clientHelper.BuildApiCall<BatchArchiveOrdersRequest, BatchArchiveOrdersResponse>("BatchArchiveOrders", grpcClient.BatchArchiveOrdersAsync, grpcClient.BatchArchiveOrders, effectiveSettings.BatchArchiveOrdersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchArchiveOrders);
            Modify_BatchArchiveOrdersApiCall(ref _callBatchArchiveOrders);
            _callBatchUnarchiveOrders = clientHelper.BuildApiCall<BatchUnarchiveOrdersRequest, BatchUnarchiveOrdersResponse>("BatchUnarchiveOrders", grpcClient.BatchUnarchiveOrdersAsync, grpcClient.BatchUnarchiveOrders, effectiveSettings.BatchUnarchiveOrdersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUnarchiveOrders);
            Modify_BatchUnarchiveOrdersApiCall(ref _callBatchUnarchiveOrders);
            _callBatchDeleteOrders = clientHelper.BuildApiCall<BatchDeleteOrdersRequest, BatchDeleteOrdersResponse>("BatchDeleteOrders", grpcClient.BatchDeleteOrdersAsync, grpcClient.BatchDeleteOrders, effectiveSettings.BatchDeleteOrdersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeleteOrders);
            Modify_BatchDeleteOrdersApiCall(ref _callBatchDeleteOrders);
            _callBatchDisapproveOrders = clientHelper.BuildApiCall<BatchDisapproveOrdersRequest, BatchDisapproveOrdersResponse>("BatchDisapproveOrders", grpcClient.BatchDisapproveOrdersAsync, grpcClient.BatchDisapproveOrders, effectiveSettings.BatchDisapproveOrdersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDisapproveOrders);
            Modify_BatchDisapproveOrdersApiCall(ref _callBatchDisapproveOrders);
            _callBatchDisapproveOrdersWithoutReservationChanges = clientHelper.BuildApiCall<BatchDisapproveOrdersWithoutReservationChangesRequest, BatchDisapproveOrdersWithoutReservationChangesResponse>("BatchDisapproveOrdersWithoutReservationChanges", grpcClient.BatchDisapproveOrdersWithoutReservationChangesAsync, grpcClient.BatchDisapproveOrdersWithoutReservationChanges, effectiveSettings.BatchDisapproveOrdersWithoutReservationChangesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDisapproveOrdersWithoutReservationChanges);
            Modify_BatchDisapproveOrdersWithoutReservationChangesApiCall(ref _callBatchDisapproveOrdersWithoutReservationChanges);
            _callBatchRetractOrders = clientHelper.BuildApiCall<BatchRetractOrdersRequest, BatchRetractOrdersResponse>("BatchRetractOrders", grpcClient.BatchRetractOrdersAsync, grpcClient.BatchRetractOrders, effectiveSettings.BatchRetractOrdersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchRetractOrders);
            Modify_BatchRetractOrdersApiCall(ref _callBatchRetractOrders);
            _callBatchRetractOrdersWithoutReservationChanges = clientHelper.BuildApiCall<BatchRetractOrdersWithoutReservationChangesRequest, BatchRetractOrdersWithoutReservationChangesResponse>("BatchRetractOrdersWithoutReservationChanges", grpcClient.BatchRetractOrdersWithoutReservationChangesAsync, grpcClient.BatchRetractOrdersWithoutReservationChanges, effectiveSettings.BatchRetractOrdersWithoutReservationChangesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchRetractOrdersWithoutReservationChanges);
            Modify_BatchRetractOrdersWithoutReservationChangesApiCall(ref _callBatchRetractOrdersWithoutReservationChanges);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetOrderApiCall(ref gaxgrpc::ApiCall<GetOrderRequest, Order> call);

        partial void Modify_ListOrdersApiCall(ref gaxgrpc::ApiCall<ListOrdersRequest, ListOrdersResponse> call);

        partial void Modify_BatchCreateOrdersApiCall(ref gaxgrpc::ApiCall<BatchCreateOrdersRequest, BatchCreateOrdersResponse> call);

        partial void Modify_BatchUpdateOrdersApiCall(ref gaxgrpc::ApiCall<BatchUpdateOrdersRequest, BatchUpdateOrdersResponse> call);

        partial void Modify_BatchApproveOrdersApiCall(ref gaxgrpc::ApiCall<BatchApproveOrdersRequest, BatchApproveOrdersResponse> call);

        partial void Modify_BatchApproveAndOverbookOrdersApiCall(ref gaxgrpc::ApiCall<BatchApproveAndOverbookOrdersRequest, BatchApproveAndOverbookOrdersResponse> call);

        partial void Modify_BatchSubmitOrdersForApprovalApiCall(ref gaxgrpc::ApiCall<BatchSubmitOrdersForApprovalRequest, BatchSubmitOrdersForApprovalResponse> call);

        partial void Modify_BatchSubmitOrdersForApprovalAndOverbookApiCall(ref gaxgrpc::ApiCall<BatchSubmitOrdersForApprovalAndOverbookRequest, BatchSubmitOrdersForApprovalAndOverbookResponse> call);

        partial void Modify_BatchSubmitOrdersForApprovalWithoutReservationChangesApiCall(ref gaxgrpc::ApiCall<BatchSubmitOrdersForApprovalWithoutReservationChangesRequest, BatchSubmitOrdersForApprovalWithoutReservationChangesResponse> call);

        partial void Modify_BatchPauseOrdersApiCall(ref gaxgrpc::ApiCall<BatchPauseOrdersRequest, BatchPauseOrdersResponse> call);

        partial void Modify_BatchResumeOrdersApiCall(ref gaxgrpc::ApiCall<BatchResumeOrdersRequest, BatchResumeOrdersResponse> call);

        partial void Modify_BatchResumeAndOverbookOrdersApiCall(ref gaxgrpc::ApiCall<BatchResumeAndOverbookOrdersRequest, BatchResumeAndOverbookOrdersResponse> call);

        partial void Modify_BatchApproveOrdersWithoutReservationApiCall(ref gaxgrpc::ApiCall<BatchApproveOrdersWithoutReservationRequest, BatchApproveOrdersWithoutReservationResponse> call);

        partial void Modify_BatchArchiveOrdersApiCall(ref gaxgrpc::ApiCall<BatchArchiveOrdersRequest, BatchArchiveOrdersResponse> call);

        partial void Modify_BatchUnarchiveOrdersApiCall(ref gaxgrpc::ApiCall<BatchUnarchiveOrdersRequest, BatchUnarchiveOrdersResponse> call);

        partial void Modify_BatchDeleteOrdersApiCall(ref gaxgrpc::ApiCall<BatchDeleteOrdersRequest, BatchDeleteOrdersResponse> call);

        partial void Modify_BatchDisapproveOrdersApiCall(ref gaxgrpc::ApiCall<BatchDisapproveOrdersRequest, BatchDisapproveOrdersResponse> call);

        partial void Modify_BatchDisapproveOrdersWithoutReservationChangesApiCall(ref gaxgrpc::ApiCall<BatchDisapproveOrdersWithoutReservationChangesRequest, BatchDisapproveOrdersWithoutReservationChangesResponse> call);

        partial void Modify_BatchRetractOrdersApiCall(ref gaxgrpc::ApiCall<BatchRetractOrdersRequest, BatchRetractOrdersResponse> call);

        partial void Modify_BatchRetractOrdersWithoutReservationChangesApiCall(ref gaxgrpc::ApiCall<BatchRetractOrdersWithoutReservationChangesRequest, BatchRetractOrdersWithoutReservationChangesResponse> call);

        partial void OnConstruction(OrderService.OrderServiceClient grpcClient, OrderServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC OrderService client</summary>
        public override OrderService.OrderServiceClient GrpcClient { get; }

        partial void Modify_GetOrderRequest(ref GetOrderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOrdersRequest(ref ListOrdersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateOrdersRequest(ref BatchCreateOrdersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateOrdersRequest(ref BatchUpdateOrdersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchApproveOrdersRequest(ref BatchApproveOrdersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchApproveAndOverbookOrdersRequest(ref BatchApproveAndOverbookOrdersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchSubmitOrdersForApprovalRequest(ref BatchSubmitOrdersForApprovalRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchSubmitOrdersForApprovalAndOverbookRequest(ref BatchSubmitOrdersForApprovalAndOverbookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchSubmitOrdersForApprovalWithoutReservationChangesRequest(ref BatchSubmitOrdersForApprovalWithoutReservationChangesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchPauseOrdersRequest(ref BatchPauseOrdersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchResumeOrdersRequest(ref BatchResumeOrdersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchResumeAndOverbookOrdersRequest(ref BatchResumeAndOverbookOrdersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchApproveOrdersWithoutReservationRequest(ref BatchApproveOrdersWithoutReservationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchArchiveOrdersRequest(ref BatchArchiveOrdersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUnarchiveOrdersRequest(ref BatchUnarchiveOrdersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeleteOrdersRequest(ref BatchDeleteOrdersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDisapproveOrdersRequest(ref BatchDisapproveOrdersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDisapproveOrdersWithoutReservationChangesRequest(ref BatchDisapproveOrdersWithoutReservationChangesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchRetractOrdersRequest(ref BatchRetractOrdersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchRetractOrdersWithoutReservationChangesRequest(ref BatchRetractOrdersWithoutReservationChangesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves an `Order` object.
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
        /// Retrieves an `Order` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Order> GetOrderAsync(GetOrderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrderRequest(ref request, ref callSettings);
            return _callGetOrder.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `Order` objects.
        /// 
        /// Fields used for literal matching in filter string:
        /// * `order_id`
        /// * `display_name`
        /// * `external_order_id`
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
        /// Lists `Order` objects.
        /// 
        /// Fields used for literal matching in filter string:
        /// * `order_id`
        /// * `display_name`
        /// * `external_order_id`
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
        /// Creates `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateOrdersResponse BatchCreateOrders(BatchCreateOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateOrdersRequest(ref request, ref callSettings);
            return _callBatchCreateOrders.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateOrdersResponse> BatchCreateOrdersAsync(BatchCreateOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateOrdersRequest(ref request, ref callSettings);
            return _callBatchCreateOrders.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateOrdersResponse BatchUpdateOrders(BatchUpdateOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateOrdersRequest(ref request, ref callSettings);
            return _callBatchUpdateOrders.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateOrdersResponse> BatchUpdateOrdersAsync(BatchUpdateOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateOrdersRequest(ref request, ref callSettings);
            return _callBatchUpdateOrders.Async(request, callSettings);
        }

        /// <summary>
        /// Approves a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchApproveOrdersResponse BatchApproveOrders(BatchApproveOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchApproveOrdersRequest(ref request, ref callSettings);
            return _callBatchApproveOrders.Sync(request, callSettings);
        }

        /// <summary>
        /// Approves a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchApproveOrdersResponse> BatchApproveOrdersAsync(BatchApproveOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchApproveOrdersRequest(ref request, ref callSettings);
            return _callBatchApproveOrders.Async(request, callSettings);
        }

        /// <summary>
        /// Approves and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchApproveAndOverbookOrdersResponse BatchApproveAndOverbookOrders(BatchApproveAndOverbookOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchApproveAndOverbookOrdersRequest(ref request, ref callSettings);
            return _callBatchApproveAndOverbookOrders.Sync(request, callSettings);
        }

        /// <summary>
        /// Approves and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchApproveAndOverbookOrdersResponse> BatchApproveAndOverbookOrdersAsync(BatchApproveAndOverbookOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchApproveAndOverbookOrdersRequest(ref request, ref callSettings);
            return _callBatchApproveAndOverbookOrders.Async(request, callSettings);
        }

        /// <summary>
        /// Submits a list of `Order` objects for approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchSubmitOrdersForApprovalResponse BatchSubmitOrdersForApproval(BatchSubmitOrdersForApprovalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchSubmitOrdersForApprovalRequest(ref request, ref callSettings);
            return _callBatchSubmitOrdersForApproval.Sync(request, callSettings);
        }

        /// <summary>
        /// Submits a list of `Order` objects for approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchSubmitOrdersForApprovalResponse> BatchSubmitOrdersForApprovalAsync(BatchSubmitOrdersForApprovalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchSubmitOrdersForApprovalRequest(ref request, ref callSettings);
            return _callBatchSubmitOrdersForApproval.Async(request, callSettings);
        }

        /// <summary>
        /// Submits and overbooks a list of `Order` objects for approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchSubmitOrdersForApprovalAndOverbookResponse BatchSubmitOrdersForApprovalAndOverbook(BatchSubmitOrdersForApprovalAndOverbookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchSubmitOrdersForApprovalAndOverbookRequest(ref request, ref callSettings);
            return _callBatchSubmitOrdersForApprovalAndOverbook.Sync(request, callSettings);
        }

        /// <summary>
        /// Submits and overbooks a list of `Order` objects for approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchSubmitOrdersForApprovalAndOverbookResponse> BatchSubmitOrdersForApprovalAndOverbookAsync(BatchSubmitOrdersForApprovalAndOverbookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchSubmitOrdersForApprovalAndOverbookRequest(ref request, ref callSettings);
            return _callBatchSubmitOrdersForApprovalAndOverbook.Async(request, callSettings);
        }

        /// <summary>
        /// Submits a list of `Order` objects for approval without changing reservation
        /// status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchSubmitOrdersForApprovalWithoutReservationChangesResponse BatchSubmitOrdersForApprovalWithoutReservationChanges(BatchSubmitOrdersForApprovalWithoutReservationChangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchSubmitOrdersForApprovalWithoutReservationChangesRequest(ref request, ref callSettings);
            return _callBatchSubmitOrdersForApprovalWithoutReservationChanges.Sync(request, callSettings);
        }

        /// <summary>
        /// Submits a list of `Order` objects for approval without changing reservation
        /// status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchSubmitOrdersForApprovalWithoutReservationChangesResponse> BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(BatchSubmitOrdersForApprovalWithoutReservationChangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchSubmitOrdersForApprovalWithoutReservationChangesRequest(ref request, ref callSettings);
            return _callBatchSubmitOrdersForApprovalWithoutReservationChanges.Async(request, callSettings);
        }

        /// <summary>
        /// Pauses a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchPauseOrdersResponse BatchPauseOrders(BatchPauseOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchPauseOrdersRequest(ref request, ref callSettings);
            return _callBatchPauseOrders.Sync(request, callSettings);
        }

        /// <summary>
        /// Pauses a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchPauseOrdersResponse> BatchPauseOrdersAsync(BatchPauseOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchPauseOrdersRequest(ref request, ref callSettings);
            return _callBatchPauseOrders.Async(request, callSettings);
        }

        /// <summary>
        /// Resumes a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchResumeOrdersResponse BatchResumeOrders(BatchResumeOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchResumeOrdersRequest(ref request, ref callSettings);
            return _callBatchResumeOrders.Sync(request, callSettings);
        }

        /// <summary>
        /// Resumes a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchResumeOrdersResponse> BatchResumeOrdersAsync(BatchResumeOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchResumeOrdersRequest(ref request, ref callSettings);
            return _callBatchResumeOrders.Async(request, callSettings);
        }

        /// <summary>
        /// Resumes and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchResumeAndOverbookOrdersResponse BatchResumeAndOverbookOrders(BatchResumeAndOverbookOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchResumeAndOverbookOrdersRequest(ref request, ref callSettings);
            return _callBatchResumeAndOverbookOrders.Sync(request, callSettings);
        }

        /// <summary>
        /// Resumes and overbooks a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchResumeAndOverbookOrdersResponse> BatchResumeAndOverbookOrdersAsync(BatchResumeAndOverbookOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchResumeAndOverbookOrdersRequest(ref request, ref callSettings);
            return _callBatchResumeAndOverbookOrders.Async(request, callSettings);
        }

        /// <summary>
        /// Approves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchApproveOrdersWithoutReservationResponse BatchApproveOrdersWithoutReservation(BatchApproveOrdersWithoutReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchApproveOrdersWithoutReservationRequest(ref request, ref callSettings);
            return _callBatchApproveOrdersWithoutReservation.Sync(request, callSettings);
        }

        /// <summary>
        /// Approves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchApproveOrdersWithoutReservationResponse> BatchApproveOrdersWithoutReservationAsync(BatchApproveOrdersWithoutReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchApproveOrdersWithoutReservationRequest(ref request, ref callSettings);
            return _callBatchApproveOrdersWithoutReservation.Async(request, callSettings);
        }

        /// <summary>
        /// Archives a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchArchiveOrdersResponse BatchArchiveOrders(BatchArchiveOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchArchiveOrdersRequest(ref request, ref callSettings);
            return _callBatchArchiveOrders.Sync(request, callSettings);
        }

        /// <summary>
        /// Archives a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchArchiveOrdersResponse> BatchArchiveOrdersAsync(BatchArchiveOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchArchiveOrdersRequest(ref request, ref callSettings);
            return _callBatchArchiveOrders.Async(request, callSettings);
        }

        /// <summary>
        /// Unarchives a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUnarchiveOrdersResponse BatchUnarchiveOrders(BatchUnarchiveOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUnarchiveOrdersRequest(ref request, ref callSettings);
            return _callBatchUnarchiveOrders.Sync(request, callSettings);
        }

        /// <summary>
        /// Unarchives a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUnarchiveOrdersResponse> BatchUnarchiveOrdersAsync(BatchUnarchiveOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUnarchiveOrdersRequest(ref request, ref callSettings);
            return _callBatchUnarchiveOrders.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDeleteOrdersResponse BatchDeleteOrders(BatchDeleteOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteOrdersRequest(ref request, ref callSettings);
            return _callBatchDeleteOrders.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDeleteOrdersResponse> BatchDeleteOrdersAsync(BatchDeleteOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteOrdersRequest(ref request, ref callSettings);
            return _callBatchDeleteOrders.Async(request, callSettings);
        }

        /// <summary>
        /// Disapproves a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDisapproveOrdersResponse BatchDisapproveOrders(BatchDisapproveOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDisapproveOrdersRequest(ref request, ref callSettings);
            return _callBatchDisapproveOrders.Sync(request, callSettings);
        }

        /// <summary>
        /// Disapproves a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDisapproveOrdersResponse> BatchDisapproveOrdersAsync(BatchDisapproveOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDisapproveOrdersRequest(ref request, ref callSettings);
            return _callBatchDisapproveOrders.Async(request, callSettings);
        }

        /// <summary>
        /// Disapproves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDisapproveOrdersWithoutReservationChangesResponse BatchDisapproveOrdersWithoutReservationChanges(BatchDisapproveOrdersWithoutReservationChangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDisapproveOrdersWithoutReservationChangesRequest(ref request, ref callSettings);
            return _callBatchDisapproveOrdersWithoutReservationChanges.Sync(request, callSettings);
        }

        /// <summary>
        /// Disapproves a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDisapproveOrdersWithoutReservationChangesResponse> BatchDisapproveOrdersWithoutReservationChangesAsync(BatchDisapproveOrdersWithoutReservationChangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDisapproveOrdersWithoutReservationChangesRequest(ref request, ref callSettings);
            return _callBatchDisapproveOrdersWithoutReservationChanges.Async(request, callSettings);
        }

        /// <summary>
        /// Retracts a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchRetractOrdersResponse BatchRetractOrders(BatchRetractOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRetractOrdersRequest(ref request, ref callSettings);
            return _callBatchRetractOrders.Sync(request, callSettings);
        }

        /// <summary>
        /// Retracts a list of `Order` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchRetractOrdersResponse> BatchRetractOrdersAsync(BatchRetractOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRetractOrdersRequest(ref request, ref callSettings);
            return _callBatchRetractOrders.Async(request, callSettings);
        }

        /// <summary>
        /// Retracts a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchRetractOrdersWithoutReservationChangesResponse BatchRetractOrdersWithoutReservationChanges(BatchRetractOrdersWithoutReservationChangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRetractOrdersWithoutReservationChangesRequest(ref request, ref callSettings);
            return _callBatchRetractOrdersWithoutReservationChanges.Sync(request, callSettings);
        }

        /// <summary>
        /// Retracts a list of `Order` objects without changing reservation status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchRetractOrdersWithoutReservationChangesResponse> BatchRetractOrdersWithoutReservationChangesAsync(BatchRetractOrdersWithoutReservationChangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRetractOrdersWithoutReservationChangesRequest(ref request, ref callSettings);
            return _callBatchRetractOrdersWithoutReservationChanges.Async(request, callSettings);
        }
    }

    public partial class ListOrdersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOrdersResponse : gaxgrpc::IPageResponse<Order>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Order> GetEnumerator() => Orders.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
