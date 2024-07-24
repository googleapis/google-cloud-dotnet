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
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.BigQuery.AnalyticsHub.V1
{
    /// <summary>Settings for <see cref="AnalyticsHubServiceClient"/> instances.</summary>
    public sealed partial class AnalyticsHubServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AnalyticsHubServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AnalyticsHubServiceSettings"/>.</returns>
        public static AnalyticsHubServiceSettings GetDefault() => new AnalyticsHubServiceSettings();

        /// <summary>Constructs a new <see cref="AnalyticsHubServiceSettings"/> object with default settings.</summary>
        public AnalyticsHubServiceSettings()
        {
        }

        private AnalyticsHubServiceSettings(AnalyticsHubServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListDataExchangesSettings = existing.ListDataExchangesSettings;
            ListOrgDataExchangesSettings = existing.ListOrgDataExchangesSettings;
            GetDataExchangeSettings = existing.GetDataExchangeSettings;
            CreateDataExchangeSettings = existing.CreateDataExchangeSettings;
            UpdateDataExchangeSettings = existing.UpdateDataExchangeSettings;
            DeleteDataExchangeSettings = existing.DeleteDataExchangeSettings;
            ListListingsSettings = existing.ListListingsSettings;
            GetListingSettings = existing.GetListingSettings;
            CreateListingSettings = existing.CreateListingSettings;
            UpdateListingSettings = existing.UpdateListingSettings;
            DeleteListingSettings = existing.DeleteListingSettings;
            SubscribeListingSettings = existing.SubscribeListingSettings;
            SubscribeDataExchangeSettings = existing.SubscribeDataExchangeSettings;
            SubscribeDataExchangeOperationsSettings = existing.SubscribeDataExchangeOperationsSettings.Clone();
            RefreshSubscriptionSettings = existing.RefreshSubscriptionSettings;
            RefreshSubscriptionOperationsSettings = existing.RefreshSubscriptionOperationsSettings.Clone();
            GetSubscriptionSettings = existing.GetSubscriptionSettings;
            ListSubscriptionsSettings = existing.ListSubscriptionsSettings;
            ListSharedResourceSubscriptionsSettings = existing.ListSharedResourceSubscriptionsSettings;
            RevokeSubscriptionSettings = existing.RevokeSubscriptionSettings;
            DeleteSubscriptionSettings = existing.DeleteSubscriptionSettings;
            DeleteSubscriptionOperationsSettings = existing.DeleteSubscriptionOperationsSettings.Clone();
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AnalyticsHubServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.ListDataExchanges</c> and <c>AnalyticsHubServiceClient.ListDataExchangesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDataExchangesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.ListOrgDataExchanges</c> and
        /// <c>AnalyticsHubServiceClient.ListOrgDataExchangesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListOrgDataExchangesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.GetDataExchange</c> and <c>AnalyticsHubServiceClient.GetDataExchangeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataExchangeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.CreateDataExchange</c> and <c>AnalyticsHubServiceClient.CreateDataExchangeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDataExchangeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.UpdateDataExchange</c> and <c>AnalyticsHubServiceClient.UpdateDataExchangeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataExchangeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.DeleteDataExchange</c> and <c>AnalyticsHubServiceClient.DeleteDataExchangeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDataExchangeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.ListListings</c> and <c>AnalyticsHubServiceClient.ListListingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListListingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.GetListing</c> and <c>AnalyticsHubServiceClient.GetListingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetListingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.CreateListing</c> and <c>AnalyticsHubServiceClient.CreateListingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateListingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.UpdateListing</c> and <c>AnalyticsHubServiceClient.UpdateListingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateListingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.DeleteListing</c> and <c>AnalyticsHubServiceClient.DeleteListingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteListingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.SubscribeListing</c> and <c>AnalyticsHubServiceClient.SubscribeListingAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SubscribeListingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.SubscribeDataExchange</c> and
        /// <c>AnalyticsHubServiceClient.SubscribeDataExchangeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SubscribeDataExchangeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AnalyticsHubServiceClient.SubscribeDataExchange</c> and
        /// <c>AnalyticsHubServiceClient.SubscribeDataExchangeAsync</c>.
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
        public lro::OperationsSettings SubscribeDataExchangeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.RefreshSubscription</c> and
        /// <c>AnalyticsHubServiceClient.RefreshSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RefreshSubscriptionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AnalyticsHubServiceClient.RefreshSubscription</c> and
        /// <c>AnalyticsHubServiceClient.RefreshSubscriptionAsync</c>.
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
        public lro::OperationsSettings RefreshSubscriptionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.GetSubscription</c> and <c>AnalyticsHubServiceClient.GetSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSubscriptionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.ListSubscriptions</c> and <c>AnalyticsHubServiceClient.ListSubscriptionsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSubscriptionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.ListSharedResourceSubscriptions</c> and
        /// <c>AnalyticsHubServiceClient.ListSharedResourceSubscriptionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSharedResourceSubscriptionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.RevokeSubscription</c> and <c>AnalyticsHubServiceClient.RevokeSubscriptionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RevokeSubscriptionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.DeleteSubscription</c> and <c>AnalyticsHubServiceClient.DeleteSubscriptionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSubscriptionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AnalyticsHubServiceClient.DeleteSubscription</c> and
        /// <c>AnalyticsHubServiceClient.DeleteSubscriptionAsync</c>.
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
        public lro::OperationsSettings DeleteSubscriptionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.GetIamPolicy</c> and <c>AnalyticsHubServiceClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.SetIamPolicy</c> and <c>AnalyticsHubServiceClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsHubServiceClient.TestIamPermissions</c> and <c>AnalyticsHubServiceClient.TestIamPermissionsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AnalyticsHubServiceSettings"/> object.</returns>
        public AnalyticsHubServiceSettings Clone() => new AnalyticsHubServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AnalyticsHubServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AnalyticsHubServiceClientBuilder : gaxgrpc::ClientBuilderBase<AnalyticsHubServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AnalyticsHubServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AnalyticsHubServiceClientBuilder() : base(AnalyticsHubServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AnalyticsHubServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AnalyticsHubServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AnalyticsHubServiceClient Build()
        {
            AnalyticsHubServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AnalyticsHubServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AnalyticsHubServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AnalyticsHubServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AnalyticsHubServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AnalyticsHubServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AnalyticsHubServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AnalyticsHubServiceClient.ChannelPool;
    }

    /// <summary>AnalyticsHubService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The `AnalyticsHubService` API facilitates data sharing within and across
    /// organizations. It allows data providers to publish listings that reference
    /// shared datasets. With Analytics Hub, users can discover and search for
    /// listings that they have access to. Subscribers can view and subscribe to
    /// listings. When you subscribe to a listing, Analytics Hub creates a linked
    /// dataset in your project.
    /// </remarks>
    public abstract partial class AnalyticsHubServiceClient
    {
        /// <summary>
        /// The default endpoint for the AnalyticsHubService service, which is a host of "analyticshub.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "analyticshub.googleapis.com:443";

        /// <summary>The default AnalyticsHubService scopes.</summary>
        /// <remarks>
        /// The default AnalyticsHubService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/bigquery</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/bigquery",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AnalyticsHubService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AnalyticsHubServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="AnalyticsHubServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AnalyticsHubServiceClient"/>.</returns>
        public static stt::Task<AnalyticsHubServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AnalyticsHubServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AnalyticsHubServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="AnalyticsHubServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AnalyticsHubServiceClient"/>.</returns>
        public static AnalyticsHubServiceClient Create() => new AnalyticsHubServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AnalyticsHubServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AnalyticsHubServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AnalyticsHubServiceClient"/>.</returns>
        internal static AnalyticsHubServiceClient Create(grpccore::CallInvoker callInvoker, AnalyticsHubServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AnalyticsHubService.AnalyticsHubServiceClient grpcClient = new AnalyticsHubService.AnalyticsHubServiceClient(callInvoker);
            return new AnalyticsHubServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AnalyticsHubService client</summary>
        public virtual AnalyticsHubService.AnalyticsHubServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all data exchanges in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataExchange"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataExchangesResponse, DataExchange> ListDataExchanges(ListDataExchangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all data exchanges in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataExchange"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataExchangesResponse, DataExchange> ListDataExchangesAsync(ListDataExchangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all data exchanges in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the data exchanges.
        /// e.g. `projects/myproject/locations/US`.
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
        /// <returns>A pageable sequence of <see cref="DataExchange"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataExchangesResponse, DataExchange> ListDataExchanges(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataExchangesRequest request = new ListDataExchangesRequest
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
            return ListDataExchanges(request, callSettings);
        }

        /// <summary>
        /// Lists all data exchanges in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the data exchanges.
        /// e.g. `projects/myproject/locations/US`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataExchange"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataExchangesResponse, DataExchange> ListDataExchangesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataExchangesRequest request = new ListDataExchangesRequest
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
            return ListDataExchangesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all data exchanges in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the data exchanges.
        /// e.g. `projects/myproject/locations/US`.
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
        /// <returns>A pageable sequence of <see cref="DataExchange"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataExchangesResponse, DataExchange> ListDataExchanges(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataExchangesRequest request = new ListDataExchangesRequest
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
            return ListDataExchanges(request, callSettings);
        }

        /// <summary>
        /// Lists all data exchanges in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the data exchanges.
        /// e.g. `projects/myproject/locations/US`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataExchange"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataExchangesResponse, DataExchange> ListDataExchangesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataExchangesRequest request = new ListDataExchangesRequest
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
            return ListDataExchangesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all data exchanges from projects in a given organization and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataExchange"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrgDataExchangesResponse, DataExchange> ListOrgDataExchanges(ListOrgDataExchangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all data exchanges from projects in a given organization and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataExchange"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrgDataExchangesResponse, DataExchange> ListOrgDataExchangesAsync(ListOrgDataExchangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all data exchanges from projects in a given organization and
        /// location.
        /// </summary>
        /// <param name="organization">
        /// Required. The organization resource path of the projects containing
        /// DataExchanges. e.g. `organizations/myorg/locations/US`.
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
        /// <returns>A pageable sequence of <see cref="DataExchange"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrgDataExchangesResponse, DataExchange> ListOrgDataExchanges(string organization, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrgDataExchangesRequest request = new ListOrgDataExchangesRequest
            {
                Organization = gax::GaxPreconditions.CheckNotNullOrEmpty(organization, nameof(organization)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOrgDataExchanges(request, callSettings);
        }

        /// <summary>
        /// Lists all data exchanges from projects in a given organization and
        /// location.
        /// </summary>
        /// <param name="organization">
        /// Required. The organization resource path of the projects containing
        /// DataExchanges. e.g. `organizations/myorg/locations/US`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataExchange"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrgDataExchangesResponse, DataExchange> ListOrgDataExchangesAsync(string organization, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrgDataExchangesRequest request = new ListOrgDataExchangesRequest
            {
                Organization = gax::GaxPreconditions.CheckNotNullOrEmpty(organization, nameof(organization)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOrgDataExchangesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataExchange GetDataExchange(GetDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataExchange> GetDataExchangeAsync(GetDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataExchange> GetDataExchangeAsync(GetDataExchangeRequest request, st::CancellationToken cancellationToken) =>
            GetDataExchangeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a data exchange.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data exchange.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataExchange GetDataExchange(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataExchange(new GetDataExchangeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a data exchange.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data exchange.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataExchange> GetDataExchangeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataExchangeAsync(new GetDataExchangeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a data exchange.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data exchange.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataExchange> GetDataExchangeAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataExchangeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a data exchange.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data exchange.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataExchange GetDataExchange(DataExchangeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataExchange(new GetDataExchangeRequest
            {
                DataExchangeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a data exchange.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data exchange.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataExchange> GetDataExchangeAsync(DataExchangeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataExchangeAsync(new GetDataExchangeRequest
            {
                DataExchangeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a data exchange.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data exchange.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataExchange> GetDataExchangeAsync(DataExchangeName name, st::CancellationToken cancellationToken) =>
            GetDataExchangeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataExchange CreateDataExchange(CreateDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataExchange> CreateDataExchangeAsync(CreateDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataExchange> CreateDataExchangeAsync(CreateDataExchangeRequest request, st::CancellationToken cancellationToken) =>
            CreateDataExchangeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new data exchange.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the data exchange.
        /// e.g. `projects/myproject/locations/US`.
        /// </param>
        /// <param name="dataExchange">
        /// Required. The data exchange to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataExchange CreateDataExchange(string parent, DataExchange dataExchange, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataExchange(new CreateDataExchangeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataExchange = gax::GaxPreconditions.CheckNotNull(dataExchange, nameof(dataExchange)),
            }, callSettings);

        /// <summary>
        /// Creates a new data exchange.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the data exchange.
        /// e.g. `projects/myproject/locations/US`.
        /// </param>
        /// <param name="dataExchange">
        /// Required. The data exchange to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataExchange> CreateDataExchangeAsync(string parent, DataExchange dataExchange, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataExchangeAsync(new CreateDataExchangeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataExchange = gax::GaxPreconditions.CheckNotNull(dataExchange, nameof(dataExchange)),
            }, callSettings);

        /// <summary>
        /// Creates a new data exchange.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the data exchange.
        /// e.g. `projects/myproject/locations/US`.
        /// </param>
        /// <param name="dataExchange">
        /// Required. The data exchange to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataExchange> CreateDataExchangeAsync(string parent, DataExchange dataExchange, st::CancellationToken cancellationToken) =>
            CreateDataExchangeAsync(parent, dataExchange, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new data exchange.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the data exchange.
        /// e.g. `projects/myproject/locations/US`.
        /// </param>
        /// <param name="dataExchange">
        /// Required. The data exchange to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataExchange CreateDataExchange(gagr::LocationName parent, DataExchange dataExchange, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataExchange(new CreateDataExchangeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataExchange = gax::GaxPreconditions.CheckNotNull(dataExchange, nameof(dataExchange)),
            }, callSettings);

        /// <summary>
        /// Creates a new data exchange.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the data exchange.
        /// e.g. `projects/myproject/locations/US`.
        /// </param>
        /// <param name="dataExchange">
        /// Required. The data exchange to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataExchange> CreateDataExchangeAsync(gagr::LocationName parent, DataExchange dataExchange, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataExchangeAsync(new CreateDataExchangeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataExchange = gax::GaxPreconditions.CheckNotNull(dataExchange, nameof(dataExchange)),
            }, callSettings);

        /// <summary>
        /// Creates a new data exchange.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the data exchange.
        /// e.g. `projects/myproject/locations/US`.
        /// </param>
        /// <param name="dataExchange">
        /// Required. The data exchange to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataExchange> CreateDataExchangeAsync(gagr::LocationName parent, DataExchange dataExchange, st::CancellationToken cancellationToken) =>
            CreateDataExchangeAsync(parent, dataExchange, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataExchange UpdateDataExchange(UpdateDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataExchange> UpdateDataExchangeAsync(UpdateDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataExchange> UpdateDataExchangeAsync(UpdateDataExchangeRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataExchangeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing data exchange.
        /// </summary>
        /// <param name="dataExchange">
        /// Required. The data exchange to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask specifies the fields to update in the data exchange
        /// resource. The fields specified in the
        /// `updateMask` are relative to the resource and are not a full request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataExchange UpdateDataExchange(DataExchange dataExchange, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataExchange(new UpdateDataExchangeRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                DataExchange = gax::GaxPreconditions.CheckNotNull(dataExchange, nameof(dataExchange)),
            }, callSettings);

        /// <summary>
        /// Updates an existing data exchange.
        /// </summary>
        /// <param name="dataExchange">
        /// Required. The data exchange to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask specifies the fields to update in the data exchange
        /// resource. The fields specified in the
        /// `updateMask` are relative to the resource and are not a full request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataExchange> UpdateDataExchangeAsync(DataExchange dataExchange, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataExchangeAsync(new UpdateDataExchangeRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                DataExchange = gax::GaxPreconditions.CheckNotNull(dataExchange, nameof(dataExchange)),
            }, callSettings);

        /// <summary>
        /// Updates an existing data exchange.
        /// </summary>
        /// <param name="dataExchange">
        /// Required. The data exchange to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask specifies the fields to update in the data exchange
        /// resource. The fields specified in the
        /// `updateMask` are relative to the resource and are not a full request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataExchange> UpdateDataExchangeAsync(DataExchange dataExchange, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataExchangeAsync(dataExchange, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataExchange(DeleteDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataExchangeAsync(DeleteDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataExchangeAsync(DeleteDataExchangeRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataExchangeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing data exchange.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the data exchange resource that you want to
        /// delete. For example, `projects/myproject/locations/US/dataExchanges/123`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataExchange(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataExchange(new DeleteDataExchangeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing data exchange.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the data exchange resource that you want to
        /// delete. For example, `projects/myproject/locations/US/dataExchanges/123`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataExchangeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataExchangeAsync(new DeleteDataExchangeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing data exchange.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the data exchange resource that you want to
        /// delete. For example, `projects/myproject/locations/US/dataExchanges/123`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataExchangeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDataExchangeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing data exchange.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the data exchange resource that you want to
        /// delete. For example, `projects/myproject/locations/US/dataExchanges/123`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataExchange(DataExchangeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataExchange(new DeleteDataExchangeRequest
            {
                DataExchangeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing data exchange.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the data exchange resource that you want to
        /// delete. For example, `projects/myproject/locations/US/dataExchanges/123`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataExchangeAsync(DataExchangeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataExchangeAsync(new DeleteDataExchangeRequest
            {
                DataExchangeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing data exchange.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the data exchange resource that you want to
        /// delete. For example, `projects/myproject/locations/US/dataExchanges/123`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataExchangeAsync(DataExchangeName name, st::CancellationToken cancellationToken) =>
            DeleteDataExchangeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all listings in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Listing"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListListingsResponse, Listing> ListListings(ListListingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all listings in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Listing"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListListingsResponse, Listing> ListListingsAsync(ListListingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all listings in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the listing.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123`.
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
        /// <returns>A pageable sequence of <see cref="Listing"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListListingsResponse, Listing> ListListings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListListingsRequest request = new ListListingsRequest
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
            return ListListings(request, callSettings);
        }

        /// <summary>
        /// Lists all listings in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the listing.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Listing"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListListingsResponse, Listing> ListListingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListListingsRequest request = new ListListingsRequest
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
            return ListListingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all listings in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the listing.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123`.
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
        /// <returns>A pageable sequence of <see cref="Listing"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListListingsResponse, Listing> ListListings(DataExchangeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListListingsRequest request = new ListListingsRequest
            {
                ParentAsDataExchangeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListListings(request, callSettings);
        }

        /// <summary>
        /// Lists all listings in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the listing.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Listing"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListListingsResponse, Listing> ListListingsAsync(DataExchangeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListListingsRequest request = new ListListingsRequest
            {
                ParentAsDataExchangeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListListingsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Listing GetListing(GetListingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Listing> GetListingAsync(GetListingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Listing> GetListingAsync(GetListingRequest request, st::CancellationToken cancellationToken) =>
            GetListingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a listing.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the listing.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123/listings/456`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Listing GetListing(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetListing(new GetListingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a listing.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the listing.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123/listings/456`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Listing> GetListingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetListingAsync(new GetListingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a listing.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the listing.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123/listings/456`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Listing> GetListingAsync(string name, st::CancellationToken cancellationToken) =>
            GetListingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a listing.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the listing.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123/listings/456`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Listing GetListing(ListingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetListing(new GetListingRequest
            {
                ListingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a listing.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the listing.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123/listings/456`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Listing> GetListingAsync(ListingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetListingAsync(new GetListingRequest
            {
                ListingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a listing.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the listing.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123/listings/456`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Listing> GetListingAsync(ListingName name, st::CancellationToken cancellationToken) =>
            GetListingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Listing CreateListing(CreateListingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Listing> CreateListingAsync(CreateListingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Listing> CreateListingAsync(CreateListingRequest request, st::CancellationToken cancellationToken) =>
            CreateListingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new listing.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the listing.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123`.
        /// </param>
        /// <param name="listing">
        /// Required. The listing to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Listing CreateListing(string parent, Listing listing, gaxgrpc::CallSettings callSettings = null) =>
            CreateListing(new CreateListingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Listing = gax::GaxPreconditions.CheckNotNull(listing, nameof(listing)),
            }, callSettings);

        /// <summary>
        /// Creates a new listing.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the listing.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123`.
        /// </param>
        /// <param name="listing">
        /// Required. The listing to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Listing> CreateListingAsync(string parent, Listing listing, gaxgrpc::CallSettings callSettings = null) =>
            CreateListingAsync(new CreateListingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Listing = gax::GaxPreconditions.CheckNotNull(listing, nameof(listing)),
            }, callSettings);

        /// <summary>
        /// Creates a new listing.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the listing.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123`.
        /// </param>
        /// <param name="listing">
        /// Required. The listing to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Listing> CreateListingAsync(string parent, Listing listing, st::CancellationToken cancellationToken) =>
            CreateListingAsync(parent, listing, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new listing.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the listing.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123`.
        /// </param>
        /// <param name="listing">
        /// Required. The listing to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Listing CreateListing(DataExchangeName parent, Listing listing, gaxgrpc::CallSettings callSettings = null) =>
            CreateListing(new CreateListingRequest
            {
                ParentAsDataExchangeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Listing = gax::GaxPreconditions.CheckNotNull(listing, nameof(listing)),
            }, callSettings);

        /// <summary>
        /// Creates a new listing.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the listing.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123`.
        /// </param>
        /// <param name="listing">
        /// Required. The listing to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Listing> CreateListingAsync(DataExchangeName parent, Listing listing, gaxgrpc::CallSettings callSettings = null) =>
            CreateListingAsync(new CreateListingRequest
            {
                ParentAsDataExchangeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Listing = gax::GaxPreconditions.CheckNotNull(listing, nameof(listing)),
            }, callSettings);

        /// <summary>
        /// Creates a new listing.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the listing.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123`.
        /// </param>
        /// <param name="listing">
        /// Required. The listing to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Listing> CreateListingAsync(DataExchangeName parent, Listing listing, st::CancellationToken cancellationToken) =>
            CreateListingAsync(parent, listing, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Listing UpdateListing(UpdateListingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Listing> UpdateListingAsync(UpdateListingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Listing> UpdateListingAsync(UpdateListingRequest request, st::CancellationToken cancellationToken) =>
            UpdateListingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing listing.
        /// </summary>
        /// <param name="listing">
        /// Required. The listing to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask specifies the fields to update in the listing
        /// resource. The fields specified in the `updateMask` are relative to the
        /// resource and are not a full request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Listing UpdateListing(Listing listing, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateListing(new UpdateListingRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Listing = gax::GaxPreconditions.CheckNotNull(listing, nameof(listing)),
            }, callSettings);

        /// <summary>
        /// Updates an existing listing.
        /// </summary>
        /// <param name="listing">
        /// Required. The listing to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask specifies the fields to update in the listing
        /// resource. The fields specified in the `updateMask` are relative to the
        /// resource and are not a full request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Listing> UpdateListingAsync(Listing listing, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateListingAsync(new UpdateListingRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Listing = gax::GaxPreconditions.CheckNotNull(listing, nameof(listing)),
            }, callSettings);

        /// <summary>
        /// Updates an existing listing.
        /// </summary>
        /// <param name="listing">
        /// Required. The listing to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask specifies the fields to update in the listing
        /// resource. The fields specified in the `updateMask` are relative to the
        /// resource and are not a full request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Listing> UpdateListingAsync(Listing listing, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateListingAsync(listing, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteListing(DeleteListingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteListingAsync(DeleteListingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteListingAsync(DeleteListingRequest request, st::CancellationToken cancellationToken) =>
            DeleteListingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a listing.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the listing to delete.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123/listings/456`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteListing(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteListing(new DeleteListingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a listing.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the listing to delete.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123/listings/456`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteListingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteListingAsync(new DeleteListingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a listing.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the listing to delete.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123/listings/456`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteListingAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteListingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a listing.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the listing to delete.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123/listings/456`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteListing(ListingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteListing(new DeleteListingRequest
            {
                ListingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a listing.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the listing to delete.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123/listings/456`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteListingAsync(ListingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteListingAsync(new DeleteListingRequest
            {
                ListingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a listing.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the listing to delete.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123/listings/456`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteListingAsync(ListingName name, st::CancellationToken cancellationToken) =>
            DeleteListingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Subscribes to a listing.
        /// 
        /// Currently, with Analytics Hub, you can create listings that
        /// reference only BigQuery datasets.
        /// Upon subscription to a listing for a BigQuery dataset, Analytics Hub
        /// creates a linked dataset in the subscriber's project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SubscribeListingResponse SubscribeListing(SubscribeListingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Subscribes to a listing.
        /// 
        /// Currently, with Analytics Hub, you can create listings that
        /// reference only BigQuery datasets.
        /// Upon subscription to a listing for a BigQuery dataset, Analytics Hub
        /// creates a linked dataset in the subscriber's project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SubscribeListingResponse> SubscribeListingAsync(SubscribeListingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Subscribes to a listing.
        /// 
        /// Currently, with Analytics Hub, you can create listings that
        /// reference only BigQuery datasets.
        /// Upon subscription to a listing for a BigQuery dataset, Analytics Hub
        /// creates a linked dataset in the subscriber's project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SubscribeListingResponse> SubscribeListingAsync(SubscribeListingRequest request, st::CancellationToken cancellationToken) =>
            SubscribeListingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Subscribes to a listing.
        /// 
        /// Currently, with Analytics Hub, you can create listings that
        /// reference only BigQuery datasets.
        /// Upon subscription to a listing for a BigQuery dataset, Analytics Hub
        /// creates a linked dataset in the subscriber's project.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the listing that you want to subscribe to.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123/listings/456`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SubscribeListingResponse SubscribeListing(string name, gaxgrpc::CallSettings callSettings = null) =>
            SubscribeListing(new SubscribeListingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Subscribes to a listing.
        /// 
        /// Currently, with Analytics Hub, you can create listings that
        /// reference only BigQuery datasets.
        /// Upon subscription to a listing for a BigQuery dataset, Analytics Hub
        /// creates a linked dataset in the subscriber's project.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the listing that you want to subscribe to.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123/listings/456`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SubscribeListingResponse> SubscribeListingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            SubscribeListingAsync(new SubscribeListingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Subscribes to a listing.
        /// 
        /// Currently, with Analytics Hub, you can create listings that
        /// reference only BigQuery datasets.
        /// Upon subscription to a listing for a BigQuery dataset, Analytics Hub
        /// creates a linked dataset in the subscriber's project.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the listing that you want to subscribe to.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123/listings/456`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SubscribeListingResponse> SubscribeListingAsync(string name, st::CancellationToken cancellationToken) =>
            SubscribeListingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Subscribes to a listing.
        /// 
        /// Currently, with Analytics Hub, you can create listings that
        /// reference only BigQuery datasets.
        /// Upon subscription to a listing for a BigQuery dataset, Analytics Hub
        /// creates a linked dataset in the subscriber's project.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the listing that you want to subscribe to.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123/listings/456`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SubscribeListingResponse SubscribeListing(ListingName name, gaxgrpc::CallSettings callSettings = null) =>
            SubscribeListing(new SubscribeListingRequest
            {
                ListingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Subscribes to a listing.
        /// 
        /// Currently, with Analytics Hub, you can create listings that
        /// reference only BigQuery datasets.
        /// Upon subscription to a listing for a BigQuery dataset, Analytics Hub
        /// creates a linked dataset in the subscriber's project.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the listing that you want to subscribe to.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123/listings/456`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SubscribeListingResponse> SubscribeListingAsync(ListingName name, gaxgrpc::CallSettings callSettings = null) =>
            SubscribeListingAsync(new SubscribeListingRequest
            {
                ListingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Subscribes to a listing.
        /// 
        /// Currently, with Analytics Hub, you can create listings that
        /// reference only BigQuery datasets.
        /// Upon subscription to a listing for a BigQuery dataset, Analytics Hub
        /// creates a linked dataset in the subscriber's project.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the listing that you want to subscribe to.
        /// e.g. `projects/myproject/locations/US/dataExchanges/123/listings/456`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SubscribeListingResponse> SubscribeListingAsync(ListingName name, st::CancellationToken cancellationToken) =>
            SubscribeListingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Subscription to a Data Exchange. This is a long-running operation
        /// as it will create one or more linked datasets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SubscribeDataExchangeResponse, OperationMetadata> SubscribeDataExchange(SubscribeDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Subscription to a Data Exchange. This is a long-running operation
        /// as it will create one or more linked datasets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SubscribeDataExchangeResponse, OperationMetadata>> SubscribeDataExchangeAsync(SubscribeDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Subscription to a Data Exchange. This is a long-running operation
        /// as it will create one or more linked datasets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SubscribeDataExchangeResponse, OperationMetadata>> SubscribeDataExchangeAsync(SubscribeDataExchangeRequest request, st::CancellationToken cancellationToken) =>
            SubscribeDataExchangeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SubscribeDataExchange</c>.</summary>
        public virtual lro::OperationsClient SubscribeDataExchangeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SubscribeDataExchange</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SubscribeDataExchangeResponse, OperationMetadata> PollOnceSubscribeDataExchange(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SubscribeDataExchangeResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SubscribeDataExchangeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SubscribeDataExchange</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SubscribeDataExchangeResponse, OperationMetadata>> PollOnceSubscribeDataExchangeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SubscribeDataExchangeResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SubscribeDataExchangeOperationsClient, callSettings);

        /// <summary>
        /// Creates a Subscription to a Data Exchange. This is a long-running operation
        /// as it will create one or more linked datasets.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Data Exchange.
        /// e.g. `projects/publisherproject/locations/US/dataExchanges/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SubscribeDataExchangeResponse, OperationMetadata> SubscribeDataExchange(string name, gaxgrpc::CallSettings callSettings = null) =>
            SubscribeDataExchange(new SubscribeDataExchangeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Creates a Subscription to a Data Exchange. This is a long-running operation
        /// as it will create one or more linked datasets.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Data Exchange.
        /// e.g. `projects/publisherproject/locations/US/dataExchanges/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SubscribeDataExchangeResponse, OperationMetadata>> SubscribeDataExchangeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            SubscribeDataExchangeAsync(new SubscribeDataExchangeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Creates a Subscription to a Data Exchange. This is a long-running operation
        /// as it will create one or more linked datasets.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Data Exchange.
        /// e.g. `projects/publisherproject/locations/US/dataExchanges/123`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SubscribeDataExchangeResponse, OperationMetadata>> SubscribeDataExchangeAsync(string name, st::CancellationToken cancellationToken) =>
            SubscribeDataExchangeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Subscription to a Data Exchange. This is a long-running operation
        /// as it will create one or more linked datasets.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Data Exchange.
        /// e.g. `projects/publisherproject/locations/US/dataExchanges/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SubscribeDataExchangeResponse, OperationMetadata> SubscribeDataExchange(DataExchangeName name, gaxgrpc::CallSettings callSettings = null) =>
            SubscribeDataExchange(new SubscribeDataExchangeRequest
            {
                DataExchangeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Creates a Subscription to a Data Exchange. This is a long-running operation
        /// as it will create one or more linked datasets.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Data Exchange.
        /// e.g. `projects/publisherproject/locations/US/dataExchanges/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SubscribeDataExchangeResponse, OperationMetadata>> SubscribeDataExchangeAsync(DataExchangeName name, gaxgrpc::CallSettings callSettings = null) =>
            SubscribeDataExchangeAsync(new SubscribeDataExchangeRequest
            {
                DataExchangeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Creates a Subscription to a Data Exchange. This is a long-running operation
        /// as it will create one or more linked datasets.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Data Exchange.
        /// e.g. `projects/publisherproject/locations/US/dataExchanges/123`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SubscribeDataExchangeResponse, OperationMetadata>> SubscribeDataExchangeAsync(DataExchangeName name, st::CancellationToken cancellationToken) =>
            SubscribeDataExchangeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Refreshes a Subscription to a Data Exchange. A Data Exchange can become
        /// stale when a publisher adds or removes data. This is a long-running
        /// operation as it may create many linked datasets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RefreshSubscriptionResponse, OperationMetadata> RefreshSubscription(RefreshSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Refreshes a Subscription to a Data Exchange. A Data Exchange can become
        /// stale when a publisher adds or removes data. This is a long-running
        /// operation as it may create many linked datasets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RefreshSubscriptionResponse, OperationMetadata>> RefreshSubscriptionAsync(RefreshSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Refreshes a Subscription to a Data Exchange. A Data Exchange can become
        /// stale when a publisher adds or removes data. This is a long-running
        /// operation as it may create many linked datasets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RefreshSubscriptionResponse, OperationMetadata>> RefreshSubscriptionAsync(RefreshSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            RefreshSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RefreshSubscription</c>.</summary>
        public virtual lro::OperationsClient RefreshSubscriptionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RefreshSubscription</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RefreshSubscriptionResponse, OperationMetadata> PollOnceRefreshSubscription(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RefreshSubscriptionResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RefreshSubscriptionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RefreshSubscription</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RefreshSubscriptionResponse, OperationMetadata>> PollOnceRefreshSubscriptionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RefreshSubscriptionResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RefreshSubscriptionOperationsClient, callSettings);

        /// <summary>
        /// Refreshes a Subscription to a Data Exchange. A Data Exchange can become
        /// stale when a publisher adds or removes data. This is a long-running
        /// operation as it may create many linked datasets.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Subscription to refresh.
        /// e.g. `projects/subscriberproject/locations/US/subscriptions/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RefreshSubscriptionResponse, OperationMetadata> RefreshSubscription(string name, gaxgrpc::CallSettings callSettings = null) =>
            RefreshSubscription(new RefreshSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Refreshes a Subscription to a Data Exchange. A Data Exchange can become
        /// stale when a publisher adds or removes data. This is a long-running
        /// operation as it may create many linked datasets.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Subscription to refresh.
        /// e.g. `projects/subscriberproject/locations/US/subscriptions/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RefreshSubscriptionResponse, OperationMetadata>> RefreshSubscriptionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RefreshSubscriptionAsync(new RefreshSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Refreshes a Subscription to a Data Exchange. A Data Exchange can become
        /// stale when a publisher adds or removes data. This is a long-running
        /// operation as it may create many linked datasets.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Subscription to refresh.
        /// e.g. `projects/subscriberproject/locations/US/subscriptions/123`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RefreshSubscriptionResponse, OperationMetadata>> RefreshSubscriptionAsync(string name, st::CancellationToken cancellationToken) =>
            RefreshSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Refreshes a Subscription to a Data Exchange. A Data Exchange can become
        /// stale when a publisher adds or removes data. This is a long-running
        /// operation as it may create many linked datasets.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Subscription to refresh.
        /// e.g. `projects/subscriberproject/locations/US/subscriptions/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RefreshSubscriptionResponse, OperationMetadata> RefreshSubscription(SubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            RefreshSubscription(new RefreshSubscriptionRequest
            {
                SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Refreshes a Subscription to a Data Exchange. A Data Exchange can become
        /// stale when a publisher adds or removes data. This is a long-running
        /// operation as it may create many linked datasets.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Subscription to refresh.
        /// e.g. `projects/subscriberproject/locations/US/subscriptions/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RefreshSubscriptionResponse, OperationMetadata>> RefreshSubscriptionAsync(SubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            RefreshSubscriptionAsync(new RefreshSubscriptionRequest
            {
                SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Refreshes a Subscription to a Data Exchange. A Data Exchange can become
        /// stale when a publisher adds or removes data. This is a long-running
        /// operation as it may create many linked datasets.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Subscription to refresh.
        /// e.g. `projects/subscriberproject/locations/US/subscriptions/123`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RefreshSubscriptionResponse, OperationMetadata>> RefreshSubscriptionAsync(SubscriptionName name, st::CancellationToken cancellationToken) =>
            RefreshSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a Subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subscription GetSubscription(GetSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a Subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(GetSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a Subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(GetSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            GetSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a Subscription.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription.
        /// e.g. projects/123/locations/US/subscriptions/456
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subscription GetSubscription(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSubscription(new GetSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a Subscription.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription.
        /// e.g. projects/123/locations/US/subscriptions/456
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSubscriptionAsync(new GetSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a Subscription.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription.
        /// e.g. projects/123/locations/US/subscriptions/456
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(string name, st::CancellationToken cancellationToken) =>
            GetSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a Subscription.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription.
        /// e.g. projects/123/locations/US/subscriptions/456
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subscription GetSubscription(SubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSubscription(new GetSubscriptionRequest
            {
                SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a Subscription.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription.
        /// e.g. projects/123/locations/US/subscriptions/456
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(SubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSubscriptionAsync(new GetSubscriptionRequest
            {
                SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a Subscription.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription.
        /// e.g. projects/123/locations/US/subscriptions/456
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(SubscriptionName name, st::CancellationToken cancellationToken) =>
            GetSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all subscriptions in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(ListSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all subscriptions in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(ListSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all subscriptions in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the subscription.
        /// e.g. projects/myproject/locations/US
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
        /// <returns>A pageable sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
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
            return ListSubscriptions(request, callSettings);
        }

        /// <summary>
        /// Lists all subscriptions in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the subscription.
        /// e.g. projects/myproject/locations/US
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
        /// <returns>A pageable asynchronous sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
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
            return ListSubscriptionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all subscriptions in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the subscription.
        /// e.g. projects/myproject/locations/US
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
        /// <returns>A pageable sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
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
            return ListSubscriptions(request, callSettings);
        }

        /// <summary>
        /// Lists all subscriptions in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path of the subscription.
        /// e.g. projects/myproject/locations/US
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
        /// <returns>A pageable asynchronous sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
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
            return ListSubscriptionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all subscriptions on a given Data Exchange or Listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSharedResourceSubscriptionsResponse, Subscription> ListSharedResourceSubscriptions(ListSharedResourceSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all subscriptions on a given Data Exchange or Listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSharedResourceSubscriptionsResponse, Subscription> ListSharedResourceSubscriptionsAsync(ListSharedResourceSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all subscriptions on a given Data Exchange or Listing.
        /// </summary>
        /// <param name="resource">
        /// Required. Resource name of the requested target. This resource may be
        /// either a Listing or a DataExchange. e.g.
        /// projects/123/locations/US/dataExchanges/456 OR e.g.
        /// projects/123/locations/US/dataExchanges/456/listings/789
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
        /// <returns>A pageable sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSharedResourceSubscriptionsResponse, Subscription> ListSharedResourceSubscriptions(string resource, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSharedResourceSubscriptionsRequest request = new ListSharedResourceSubscriptionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSharedResourceSubscriptions(request, callSettings);
        }

        /// <summary>
        /// Lists all subscriptions on a given Data Exchange or Listing.
        /// </summary>
        /// <param name="resource">
        /// Required. Resource name of the requested target. This resource may be
        /// either a Listing or a DataExchange. e.g.
        /// projects/123/locations/US/dataExchanges/456 OR e.g.
        /// projects/123/locations/US/dataExchanges/456/listings/789
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
        /// <returns>A pageable asynchronous sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSharedResourceSubscriptionsResponse, Subscription> ListSharedResourceSubscriptionsAsync(string resource, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSharedResourceSubscriptionsRequest request = new ListSharedResourceSubscriptionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSharedResourceSubscriptionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all subscriptions on a given Data Exchange or Listing.
        /// </summary>
        /// <param name="resource">
        /// Required. Resource name of the requested target. This resource may be
        /// either a Listing or a DataExchange. e.g.
        /// projects/123/locations/US/dataExchanges/456 OR e.g.
        /// projects/123/locations/US/dataExchanges/456/listings/789
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
        /// <returns>A pageable sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSharedResourceSubscriptionsResponse, Subscription> ListSharedResourceSubscriptions(gax::IResourceName resource, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSharedResourceSubscriptionsRequest request = new ListSharedResourceSubscriptionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSharedResourceSubscriptions(request, callSettings);
        }

        /// <summary>
        /// Lists all subscriptions on a given Data Exchange or Listing.
        /// </summary>
        /// <param name="resource">
        /// Required. Resource name of the requested target. This resource may be
        /// either a Listing or a DataExchange. e.g.
        /// projects/123/locations/US/dataExchanges/456 OR e.g.
        /// projects/123/locations/US/dataExchanges/456/listings/789
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
        /// <returns>A pageable asynchronous sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSharedResourceSubscriptionsResponse, Subscription> ListSharedResourceSubscriptionsAsync(gax::IResourceName resource, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSharedResourceSubscriptionsRequest request = new ListSharedResourceSubscriptionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSharedResourceSubscriptionsAsync(request, callSettings);
        }

        /// <summary>
        /// Revokes a given subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RevokeSubscriptionResponse RevokeSubscription(RevokeSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Revokes a given subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RevokeSubscriptionResponse> RevokeSubscriptionAsync(RevokeSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Revokes a given subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RevokeSubscriptionResponse> RevokeSubscriptionAsync(RevokeSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            RevokeSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Revokes a given subscription.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to revoke.
        /// e.g. projects/123/locations/US/subscriptions/456
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RevokeSubscriptionResponse RevokeSubscription(string name, gaxgrpc::CallSettings callSettings = null) =>
            RevokeSubscription(new RevokeSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Revokes a given subscription.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to revoke.
        /// e.g. projects/123/locations/US/subscriptions/456
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RevokeSubscriptionResponse> RevokeSubscriptionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RevokeSubscriptionAsync(new RevokeSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Revokes a given subscription.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to revoke.
        /// e.g. projects/123/locations/US/subscriptions/456
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RevokeSubscriptionResponse> RevokeSubscriptionAsync(string name, st::CancellationToken cancellationToken) =>
            RevokeSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Revokes a given subscription.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to revoke.
        /// e.g. projects/123/locations/US/subscriptions/456
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RevokeSubscriptionResponse RevokeSubscription(SubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            RevokeSubscription(new RevokeSubscriptionRequest
            {
                SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Revokes a given subscription.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to revoke.
        /// e.g. projects/123/locations/US/subscriptions/456
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RevokeSubscriptionResponse> RevokeSubscriptionAsync(SubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            RevokeSubscriptionAsync(new RevokeSubscriptionRequest
            {
                SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Revokes a given subscription.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to revoke.
        /// e.g. projects/123/locations/US/subscriptions/456
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RevokeSubscriptionResponse> RevokeSubscriptionAsync(SubscriptionName name, st::CancellationToken cancellationToken) =>
            RevokeSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSubscription(DeleteSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSubscriptionAsync(DeleteSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSubscriptionAsync(DeleteSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            DeleteSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSubscription</c>.</summary>
        public virtual lro::OperationsClient DeleteSubscriptionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSubscription</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteSubscription(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSubscriptionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSubscription</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteSubscriptionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSubscriptionOperationsClient, callSettings);

        /// <summary>
        /// Deletes a subscription.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to delete.
        /// e.g. projects/123/locations/US/subscriptions/456
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSubscription(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubscription(new DeleteSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a subscription.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to delete.
        /// e.g. projects/123/locations/US/subscriptions/456
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSubscriptionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubscriptionAsync(new DeleteSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a subscription.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to delete.
        /// e.g. projects/123/locations/US/subscriptions/456
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSubscriptionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a subscription.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to delete.
        /// e.g. projects/123/locations/US/subscriptions/456
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSubscription(SubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubscription(new DeleteSubscriptionRequest
            {
                SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a subscription.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to delete.
        /// e.g. projects/123/locations/US/subscriptions/456
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSubscriptionAsync(SubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubscriptionAsync(new DeleteSubscriptionRequest
            {
                SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a subscription.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to delete.
        /// e.g. projects/123/locations/US/subscriptions/456
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSubscriptionAsync(SubscriptionName name, st::CancellationToken cancellationToken) =>
            DeleteSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the permissions that a caller has.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the permissions that a caller has.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the permissions that a caller has.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AnalyticsHubService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The `AnalyticsHubService` API facilitates data sharing within and across
    /// organizations. It allows data providers to publish listings that reference
    /// shared datasets. With Analytics Hub, users can discover and search for
    /// listings that they have access to. Subscribers can view and subscribe to
    /// listings. When you subscribe to a listing, Analytics Hub creates a linked
    /// dataset in your project.
    /// </remarks>
    public sealed partial class AnalyticsHubServiceClientImpl : AnalyticsHubServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListDataExchangesRequest, ListDataExchangesResponse> _callListDataExchanges;

        private readonly gaxgrpc::ApiCall<ListOrgDataExchangesRequest, ListOrgDataExchangesResponse> _callListOrgDataExchanges;

        private readonly gaxgrpc::ApiCall<GetDataExchangeRequest, DataExchange> _callGetDataExchange;

        private readonly gaxgrpc::ApiCall<CreateDataExchangeRequest, DataExchange> _callCreateDataExchange;

        private readonly gaxgrpc::ApiCall<UpdateDataExchangeRequest, DataExchange> _callUpdateDataExchange;

        private readonly gaxgrpc::ApiCall<DeleteDataExchangeRequest, wkt::Empty> _callDeleteDataExchange;

        private readonly gaxgrpc::ApiCall<ListListingsRequest, ListListingsResponse> _callListListings;

        private readonly gaxgrpc::ApiCall<GetListingRequest, Listing> _callGetListing;

        private readonly gaxgrpc::ApiCall<CreateListingRequest, Listing> _callCreateListing;

        private readonly gaxgrpc::ApiCall<UpdateListingRequest, Listing> _callUpdateListing;

        private readonly gaxgrpc::ApiCall<DeleteListingRequest, wkt::Empty> _callDeleteListing;

        private readonly gaxgrpc::ApiCall<SubscribeListingRequest, SubscribeListingResponse> _callSubscribeListing;

        private readonly gaxgrpc::ApiCall<SubscribeDataExchangeRequest, lro::Operation> _callSubscribeDataExchange;

        private readonly gaxgrpc::ApiCall<RefreshSubscriptionRequest, lro::Operation> _callRefreshSubscription;

        private readonly gaxgrpc::ApiCall<GetSubscriptionRequest, Subscription> _callGetSubscription;

        private readonly gaxgrpc::ApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse> _callListSubscriptions;

        private readonly gaxgrpc::ApiCall<ListSharedResourceSubscriptionsRequest, ListSharedResourceSubscriptionsResponse> _callListSharedResourceSubscriptions;

        private readonly gaxgrpc::ApiCall<RevokeSubscriptionRequest, RevokeSubscriptionResponse> _callRevokeSubscription;

        private readonly gaxgrpc::ApiCall<DeleteSubscriptionRequest, lro::Operation> _callDeleteSubscription;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the AnalyticsHubService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AnalyticsHubServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AnalyticsHubServiceClientImpl(AnalyticsHubService.AnalyticsHubServiceClient grpcClient, AnalyticsHubServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AnalyticsHubServiceSettings effectiveSettings = settings ?? AnalyticsHubServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            SubscribeDataExchangeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SubscribeDataExchangeOperationsSettings, logger);
            RefreshSubscriptionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RefreshSubscriptionOperationsSettings, logger);
            DeleteSubscriptionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSubscriptionOperationsSettings, logger);
            _callListDataExchanges = clientHelper.BuildApiCall<ListDataExchangesRequest, ListDataExchangesResponse>("ListDataExchanges", grpcClient.ListDataExchangesAsync, grpcClient.ListDataExchanges, effectiveSettings.ListDataExchangesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataExchanges);
            Modify_ListDataExchangesApiCall(ref _callListDataExchanges);
            _callListOrgDataExchanges = clientHelper.BuildApiCall<ListOrgDataExchangesRequest, ListOrgDataExchangesResponse>("ListOrgDataExchanges", grpcClient.ListOrgDataExchangesAsync, grpcClient.ListOrgDataExchanges, effectiveSettings.ListOrgDataExchangesSettings).WithGoogleRequestParam("organization", request => request.Organization);
            Modify_ApiCall(ref _callListOrgDataExchanges);
            Modify_ListOrgDataExchangesApiCall(ref _callListOrgDataExchanges);
            _callGetDataExchange = clientHelper.BuildApiCall<GetDataExchangeRequest, DataExchange>("GetDataExchange", grpcClient.GetDataExchangeAsync, grpcClient.GetDataExchange, effectiveSettings.GetDataExchangeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataExchange);
            Modify_GetDataExchangeApiCall(ref _callGetDataExchange);
            _callCreateDataExchange = clientHelper.BuildApiCall<CreateDataExchangeRequest, DataExchange>("CreateDataExchange", grpcClient.CreateDataExchangeAsync, grpcClient.CreateDataExchange, effectiveSettings.CreateDataExchangeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataExchange);
            Modify_CreateDataExchangeApiCall(ref _callCreateDataExchange);
            _callUpdateDataExchange = clientHelper.BuildApiCall<UpdateDataExchangeRequest, DataExchange>("UpdateDataExchange", grpcClient.UpdateDataExchangeAsync, grpcClient.UpdateDataExchange, effectiveSettings.UpdateDataExchangeSettings).WithGoogleRequestParam("data_exchange.name", request => request.DataExchange?.Name);
            Modify_ApiCall(ref _callUpdateDataExchange);
            Modify_UpdateDataExchangeApiCall(ref _callUpdateDataExchange);
            _callDeleteDataExchange = clientHelper.BuildApiCall<DeleteDataExchangeRequest, wkt::Empty>("DeleteDataExchange", grpcClient.DeleteDataExchangeAsync, grpcClient.DeleteDataExchange, effectiveSettings.DeleteDataExchangeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataExchange);
            Modify_DeleteDataExchangeApiCall(ref _callDeleteDataExchange);
            _callListListings = clientHelper.BuildApiCall<ListListingsRequest, ListListingsResponse>("ListListings", grpcClient.ListListingsAsync, grpcClient.ListListings, effectiveSettings.ListListingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListListings);
            Modify_ListListingsApiCall(ref _callListListings);
            _callGetListing = clientHelper.BuildApiCall<GetListingRequest, Listing>("GetListing", grpcClient.GetListingAsync, grpcClient.GetListing, effectiveSettings.GetListingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetListing);
            Modify_GetListingApiCall(ref _callGetListing);
            _callCreateListing = clientHelper.BuildApiCall<CreateListingRequest, Listing>("CreateListing", grpcClient.CreateListingAsync, grpcClient.CreateListing, effectiveSettings.CreateListingSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateListing);
            Modify_CreateListingApiCall(ref _callCreateListing);
            _callUpdateListing = clientHelper.BuildApiCall<UpdateListingRequest, Listing>("UpdateListing", grpcClient.UpdateListingAsync, grpcClient.UpdateListing, effectiveSettings.UpdateListingSettings).WithGoogleRequestParam("listing.name", request => request.Listing?.Name);
            Modify_ApiCall(ref _callUpdateListing);
            Modify_UpdateListingApiCall(ref _callUpdateListing);
            _callDeleteListing = clientHelper.BuildApiCall<DeleteListingRequest, wkt::Empty>("DeleteListing", grpcClient.DeleteListingAsync, grpcClient.DeleteListing, effectiveSettings.DeleteListingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteListing);
            Modify_DeleteListingApiCall(ref _callDeleteListing);
            _callSubscribeListing = clientHelper.BuildApiCall<SubscribeListingRequest, SubscribeListingResponse>("SubscribeListing", grpcClient.SubscribeListingAsync, grpcClient.SubscribeListing, effectiveSettings.SubscribeListingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSubscribeListing);
            Modify_SubscribeListingApiCall(ref _callSubscribeListing);
            _callSubscribeDataExchange = clientHelper.BuildApiCall<SubscribeDataExchangeRequest, lro::Operation>("SubscribeDataExchange", grpcClient.SubscribeDataExchangeAsync, grpcClient.SubscribeDataExchange, effectiveSettings.SubscribeDataExchangeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSubscribeDataExchange);
            Modify_SubscribeDataExchangeApiCall(ref _callSubscribeDataExchange);
            _callRefreshSubscription = clientHelper.BuildApiCall<RefreshSubscriptionRequest, lro::Operation>("RefreshSubscription", grpcClient.RefreshSubscriptionAsync, grpcClient.RefreshSubscription, effectiveSettings.RefreshSubscriptionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRefreshSubscription);
            Modify_RefreshSubscriptionApiCall(ref _callRefreshSubscription);
            _callGetSubscription = clientHelper.BuildApiCall<GetSubscriptionRequest, Subscription>("GetSubscription", grpcClient.GetSubscriptionAsync, grpcClient.GetSubscription, effectiveSettings.GetSubscriptionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSubscription);
            Modify_GetSubscriptionApiCall(ref _callGetSubscription);
            _callListSubscriptions = clientHelper.BuildApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse>("ListSubscriptions", grpcClient.ListSubscriptionsAsync, grpcClient.ListSubscriptions, effectiveSettings.ListSubscriptionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSubscriptions);
            Modify_ListSubscriptionsApiCall(ref _callListSubscriptions);
            _callListSharedResourceSubscriptions = clientHelper.BuildApiCall<ListSharedResourceSubscriptionsRequest, ListSharedResourceSubscriptionsResponse>("ListSharedResourceSubscriptions", grpcClient.ListSharedResourceSubscriptionsAsync, grpcClient.ListSharedResourceSubscriptions, effectiveSettings.ListSharedResourceSubscriptionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callListSharedResourceSubscriptions);
            Modify_ListSharedResourceSubscriptionsApiCall(ref _callListSharedResourceSubscriptions);
            _callRevokeSubscription = clientHelper.BuildApiCall<RevokeSubscriptionRequest, RevokeSubscriptionResponse>("RevokeSubscription", grpcClient.RevokeSubscriptionAsync, grpcClient.RevokeSubscription, effectiveSettings.RevokeSubscriptionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRevokeSubscription);
            Modify_RevokeSubscriptionApiCall(ref _callRevokeSubscription);
            _callDeleteSubscription = clientHelper.BuildApiCall<DeleteSubscriptionRequest, lro::Operation>("DeleteSubscription", grpcClient.DeleteSubscriptionAsync, grpcClient.DeleteSubscription, effectiveSettings.DeleteSubscriptionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSubscription);
            Modify_DeleteSubscriptionApiCall(ref _callDeleteSubscription);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListDataExchangesApiCall(ref gaxgrpc::ApiCall<ListDataExchangesRequest, ListDataExchangesResponse> call);

        partial void Modify_ListOrgDataExchangesApiCall(ref gaxgrpc::ApiCall<ListOrgDataExchangesRequest, ListOrgDataExchangesResponse> call);

        partial void Modify_GetDataExchangeApiCall(ref gaxgrpc::ApiCall<GetDataExchangeRequest, DataExchange> call);

        partial void Modify_CreateDataExchangeApiCall(ref gaxgrpc::ApiCall<CreateDataExchangeRequest, DataExchange> call);

        partial void Modify_UpdateDataExchangeApiCall(ref gaxgrpc::ApiCall<UpdateDataExchangeRequest, DataExchange> call);

        partial void Modify_DeleteDataExchangeApiCall(ref gaxgrpc::ApiCall<DeleteDataExchangeRequest, wkt::Empty> call);

        partial void Modify_ListListingsApiCall(ref gaxgrpc::ApiCall<ListListingsRequest, ListListingsResponse> call);

        partial void Modify_GetListingApiCall(ref gaxgrpc::ApiCall<GetListingRequest, Listing> call);

        partial void Modify_CreateListingApiCall(ref gaxgrpc::ApiCall<CreateListingRequest, Listing> call);

        partial void Modify_UpdateListingApiCall(ref gaxgrpc::ApiCall<UpdateListingRequest, Listing> call);

        partial void Modify_DeleteListingApiCall(ref gaxgrpc::ApiCall<DeleteListingRequest, wkt::Empty> call);

        partial void Modify_SubscribeListingApiCall(ref gaxgrpc::ApiCall<SubscribeListingRequest, SubscribeListingResponse> call);

        partial void Modify_SubscribeDataExchangeApiCall(ref gaxgrpc::ApiCall<SubscribeDataExchangeRequest, lro::Operation> call);

        partial void Modify_RefreshSubscriptionApiCall(ref gaxgrpc::ApiCall<RefreshSubscriptionRequest, lro::Operation> call);

        partial void Modify_GetSubscriptionApiCall(ref gaxgrpc::ApiCall<GetSubscriptionRequest, Subscription> call);

        partial void Modify_ListSubscriptionsApiCall(ref gaxgrpc::ApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse> call);

        partial void Modify_ListSharedResourceSubscriptionsApiCall(ref gaxgrpc::ApiCall<ListSharedResourceSubscriptionsRequest, ListSharedResourceSubscriptionsResponse> call);

        partial void Modify_RevokeSubscriptionApiCall(ref gaxgrpc::ApiCall<RevokeSubscriptionRequest, RevokeSubscriptionResponse> call);

        partial void Modify_DeleteSubscriptionApiCall(ref gaxgrpc::ApiCall<DeleteSubscriptionRequest, lro::Operation> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void OnConstruction(AnalyticsHubService.AnalyticsHubServiceClient grpcClient, AnalyticsHubServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AnalyticsHubService client</summary>
        public override AnalyticsHubService.AnalyticsHubServiceClient GrpcClient { get; }

        partial void Modify_ListDataExchangesRequest(ref ListDataExchangesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOrgDataExchangesRequest(ref ListOrgDataExchangesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataExchangeRequest(ref GetDataExchangeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDataExchangeRequest(ref CreateDataExchangeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataExchangeRequest(ref UpdateDataExchangeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataExchangeRequest(ref DeleteDataExchangeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListListingsRequest(ref ListListingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetListingRequest(ref GetListingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateListingRequest(ref CreateListingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateListingRequest(ref UpdateListingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteListingRequest(ref DeleteListingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SubscribeListingRequest(ref SubscribeListingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SubscribeDataExchangeRequest(ref SubscribeDataExchangeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RefreshSubscriptionRequest(ref RefreshSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSubscriptionRequest(ref GetSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSubscriptionsRequest(ref ListSubscriptionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSharedResourceSubscriptionsRequest(ref ListSharedResourceSubscriptionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RevokeSubscriptionRequest(ref RevokeSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSubscriptionRequest(ref DeleteSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all data exchanges in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataExchange"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataExchangesResponse, DataExchange> ListDataExchanges(ListDataExchangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataExchangesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataExchangesRequest, ListDataExchangesResponse, DataExchange>(_callListDataExchanges, request, callSettings);
        }

        /// <summary>
        /// Lists all data exchanges in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataExchange"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataExchangesResponse, DataExchange> ListDataExchangesAsync(ListDataExchangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataExchangesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataExchangesRequest, ListDataExchangesResponse, DataExchange>(_callListDataExchanges, request, callSettings);
        }

        /// <summary>
        /// Lists all data exchanges from projects in a given organization and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataExchange"/> resources.</returns>
        public override gax::PagedEnumerable<ListOrgDataExchangesResponse, DataExchange> ListOrgDataExchanges(ListOrgDataExchangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrgDataExchangesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOrgDataExchangesRequest, ListOrgDataExchangesResponse, DataExchange>(_callListOrgDataExchanges, request, callSettings);
        }

        /// <summary>
        /// Lists all data exchanges from projects in a given organization and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataExchange"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOrgDataExchangesResponse, DataExchange> ListOrgDataExchangesAsync(ListOrgDataExchangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrgDataExchangesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOrgDataExchangesRequest, ListOrgDataExchangesResponse, DataExchange>(_callListOrgDataExchanges, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataExchange GetDataExchange(GetDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataExchangeRequest(ref request, ref callSettings);
            return _callGetDataExchange.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataExchange> GetDataExchangeAsync(GetDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataExchangeRequest(ref request, ref callSettings);
            return _callGetDataExchange.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataExchange CreateDataExchange(CreateDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataExchangeRequest(ref request, ref callSettings);
            return _callCreateDataExchange.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataExchange> CreateDataExchangeAsync(CreateDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataExchangeRequest(ref request, ref callSettings);
            return _callCreateDataExchange.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataExchange UpdateDataExchange(UpdateDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataExchangeRequest(ref request, ref callSettings);
            return _callUpdateDataExchange.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataExchange> UpdateDataExchangeAsync(UpdateDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataExchangeRequest(ref request, ref callSettings);
            return _callUpdateDataExchange.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDataExchange(DeleteDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataExchangeRequest(ref request, ref callSettings);
            _callDeleteDataExchange.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing data exchange.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDataExchangeAsync(DeleteDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataExchangeRequest(ref request, ref callSettings);
            return _callDeleteDataExchange.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all listings in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Listing"/> resources.</returns>
        public override gax::PagedEnumerable<ListListingsResponse, Listing> ListListings(ListListingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListListingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListListingsRequest, ListListingsResponse, Listing>(_callListListings, request, callSettings);
        }

        /// <summary>
        /// Lists all listings in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Listing"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListListingsResponse, Listing> ListListingsAsync(ListListingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListListingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListListingsRequest, ListListingsResponse, Listing>(_callListListings, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Listing GetListing(GetListingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetListingRequest(ref request, ref callSettings);
            return _callGetListing.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Listing> GetListingAsync(GetListingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetListingRequest(ref request, ref callSettings);
            return _callGetListing.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Listing CreateListing(CreateListingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateListingRequest(ref request, ref callSettings);
            return _callCreateListing.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Listing> CreateListingAsync(CreateListingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateListingRequest(ref request, ref callSettings);
            return _callCreateListing.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Listing UpdateListing(UpdateListingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateListingRequest(ref request, ref callSettings);
            return _callUpdateListing.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Listing> UpdateListingAsync(UpdateListingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateListingRequest(ref request, ref callSettings);
            return _callUpdateListing.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteListing(DeleteListingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteListingRequest(ref request, ref callSettings);
            _callDeleteListing.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteListingAsync(DeleteListingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteListingRequest(ref request, ref callSettings);
            return _callDeleteListing.Async(request, callSettings);
        }

        /// <summary>
        /// Subscribes to a listing.
        /// 
        /// Currently, with Analytics Hub, you can create listings that
        /// reference only BigQuery datasets.
        /// Upon subscription to a listing for a BigQuery dataset, Analytics Hub
        /// creates a linked dataset in the subscriber's project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SubscribeListingResponse SubscribeListing(SubscribeListingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubscribeListingRequest(ref request, ref callSettings);
            return _callSubscribeListing.Sync(request, callSettings);
        }

        /// <summary>
        /// Subscribes to a listing.
        /// 
        /// Currently, with Analytics Hub, you can create listings that
        /// reference only BigQuery datasets.
        /// Upon subscription to a listing for a BigQuery dataset, Analytics Hub
        /// creates a linked dataset in the subscriber's project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SubscribeListingResponse> SubscribeListingAsync(SubscribeListingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubscribeListingRequest(ref request, ref callSettings);
            return _callSubscribeListing.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>SubscribeDataExchange</c>.</summary>
        public override lro::OperationsClient SubscribeDataExchangeOperationsClient { get; }

        /// <summary>
        /// Creates a Subscription to a Data Exchange. This is a long-running operation
        /// as it will create one or more linked datasets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SubscribeDataExchangeResponse, OperationMetadata> SubscribeDataExchange(SubscribeDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubscribeDataExchangeRequest(ref request, ref callSettings);
            return new lro::Operation<SubscribeDataExchangeResponse, OperationMetadata>(_callSubscribeDataExchange.Sync(request, callSettings), SubscribeDataExchangeOperationsClient);
        }

        /// <summary>
        /// Creates a Subscription to a Data Exchange. This is a long-running operation
        /// as it will create one or more linked datasets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SubscribeDataExchangeResponse, OperationMetadata>> SubscribeDataExchangeAsync(SubscribeDataExchangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubscribeDataExchangeRequest(ref request, ref callSettings);
            return new lro::Operation<SubscribeDataExchangeResponse, OperationMetadata>(await _callSubscribeDataExchange.Async(request, callSettings).ConfigureAwait(false), SubscribeDataExchangeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RefreshSubscription</c>.</summary>
        public override lro::OperationsClient RefreshSubscriptionOperationsClient { get; }

        /// <summary>
        /// Refreshes a Subscription to a Data Exchange. A Data Exchange can become
        /// stale when a publisher adds or removes data. This is a long-running
        /// operation as it may create many linked datasets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RefreshSubscriptionResponse, OperationMetadata> RefreshSubscription(RefreshSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RefreshSubscriptionRequest(ref request, ref callSettings);
            return new lro::Operation<RefreshSubscriptionResponse, OperationMetadata>(_callRefreshSubscription.Sync(request, callSettings), RefreshSubscriptionOperationsClient);
        }

        /// <summary>
        /// Refreshes a Subscription to a Data Exchange. A Data Exchange can become
        /// stale when a publisher adds or removes data. This is a long-running
        /// operation as it may create many linked datasets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RefreshSubscriptionResponse, OperationMetadata>> RefreshSubscriptionAsync(RefreshSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RefreshSubscriptionRequest(ref request, ref callSettings);
            return new lro::Operation<RefreshSubscriptionResponse, OperationMetadata>(await _callRefreshSubscription.Async(request, callSettings).ConfigureAwait(false), RefreshSubscriptionOperationsClient);
        }

        /// <summary>
        /// Gets the details of a Subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Subscription GetSubscription(GetSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSubscriptionRequest(ref request, ref callSettings);
            return _callGetSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a Subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Subscription> GetSubscriptionAsync(GetSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSubscriptionRequest(ref request, ref callSettings);
            return _callGetSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all subscriptions in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Subscription"/> resources.</returns>
        public override gax::PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(ListSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription>(_callListSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Lists all subscriptions in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Subscription"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(ListSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription>(_callListSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Lists all subscriptions on a given Data Exchange or Listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Subscription"/> resources.</returns>
        public override gax::PagedEnumerable<ListSharedResourceSubscriptionsResponse, Subscription> ListSharedResourceSubscriptions(ListSharedResourceSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSharedResourceSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSharedResourceSubscriptionsRequest, ListSharedResourceSubscriptionsResponse, Subscription>(_callListSharedResourceSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Lists all subscriptions on a given Data Exchange or Listing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Subscription"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSharedResourceSubscriptionsResponse, Subscription> ListSharedResourceSubscriptionsAsync(ListSharedResourceSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSharedResourceSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSharedResourceSubscriptionsRequest, ListSharedResourceSubscriptionsResponse, Subscription>(_callListSharedResourceSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Revokes a given subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RevokeSubscriptionResponse RevokeSubscription(RevokeSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RevokeSubscriptionRequest(ref request, ref callSettings);
            return _callRevokeSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Revokes a given subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RevokeSubscriptionResponse> RevokeSubscriptionAsync(RevokeSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RevokeSubscriptionRequest(ref request, ref callSettings);
            return _callRevokeSubscription.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteSubscription</c>.</summary>
        public override lro::OperationsClient DeleteSubscriptionOperationsClient { get; }

        /// <summary>
        /// Deletes a subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteSubscription(DeleteSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSubscriptionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteSubscription.Sync(request, callSettings), DeleteSubscriptionOperationsClient);
        }

        /// <summary>
        /// Deletes a subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSubscriptionAsync(DeleteSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSubscriptionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteSubscription.Async(request, callSettings).ConfigureAwait(false), DeleteSubscriptionOperationsClient);
        }

        /// <summary>
        /// Gets the IAM policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the IAM policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the permissions that a caller has.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the permissions that a caller has.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }
    }

    public partial class ListDataExchangesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOrgDataExchangesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListListingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSubscriptionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSharedResourceSubscriptionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataExchangesResponse : gaxgrpc::IPageResponse<DataExchange>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataExchange> GetEnumerator() => DataExchanges.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListOrgDataExchangesResponse : gaxgrpc::IPageResponse<DataExchange>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataExchange> GetEnumerator() => DataExchanges.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListListingsResponse : gaxgrpc::IPageResponse<Listing>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Listing> GetEnumerator() => Listings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSubscriptionsResponse : gaxgrpc::IPageResponse<Subscription>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Subscription> GetEnumerator() => Subscriptions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSharedResourceSubscriptionsResponse : gaxgrpc::IPageResponse<Subscription>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Subscription> GetEnumerator() => SharedResourceSubscriptions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AnalyticsHubService
    {
        public partial class AnalyticsHubServiceClient
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
}
