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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Analytics.Admin.V1Beta
{
    /// <summary>Settings for <see cref="AnalyticsAdminServiceClient"/> instances.</summary>
    public sealed partial class AnalyticsAdminServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AnalyticsAdminServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AnalyticsAdminServiceSettings"/>.</returns>
        public static AnalyticsAdminServiceSettings GetDefault() => new AnalyticsAdminServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AnalyticsAdminServiceSettings"/> object with default settings.
        /// </summary>
        public AnalyticsAdminServiceSettings()
        {
        }

        private AnalyticsAdminServiceSettings(AnalyticsAdminServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAccountSettings = existing.GetAccountSettings;
            ListAccountsSettings = existing.ListAccountsSettings;
            DeleteAccountSettings = existing.DeleteAccountSettings;
            UpdateAccountSettings = existing.UpdateAccountSettings;
            ProvisionAccountTicketSettings = existing.ProvisionAccountTicketSettings;
            ListAccountSummariesSettings = existing.ListAccountSummariesSettings;
            GetPropertySettings = existing.GetPropertySettings;
            ListPropertiesSettings = existing.ListPropertiesSettings;
            CreatePropertySettings = existing.CreatePropertySettings;
            DeletePropertySettings = existing.DeletePropertySettings;
            UpdatePropertySettings = existing.UpdatePropertySettings;
            CreateFirebaseLinkSettings = existing.CreateFirebaseLinkSettings;
            DeleteFirebaseLinkSettings = existing.DeleteFirebaseLinkSettings;
            ListFirebaseLinksSettings = existing.ListFirebaseLinksSettings;
            CreateGoogleAdsLinkSettings = existing.CreateGoogleAdsLinkSettings;
            UpdateGoogleAdsLinkSettings = existing.UpdateGoogleAdsLinkSettings;
            DeleteGoogleAdsLinkSettings = existing.DeleteGoogleAdsLinkSettings;
            ListGoogleAdsLinksSettings = existing.ListGoogleAdsLinksSettings;
            GetDataSharingSettingsSettings = existing.GetDataSharingSettingsSettings;
            GetMeasurementProtocolSecretSettings = existing.GetMeasurementProtocolSecretSettings;
            ListMeasurementProtocolSecretsSettings = existing.ListMeasurementProtocolSecretsSettings;
            CreateMeasurementProtocolSecretSettings = existing.CreateMeasurementProtocolSecretSettings;
            DeleteMeasurementProtocolSecretSettings = existing.DeleteMeasurementProtocolSecretSettings;
            UpdateMeasurementProtocolSecretSettings = existing.UpdateMeasurementProtocolSecretSettings;
            AcknowledgeUserDataCollectionSettings = existing.AcknowledgeUserDataCollectionSettings;
            SearchChangeHistoryEventsSettings = existing.SearchChangeHistoryEventsSettings;
            CreateConversionEventSettings = existing.CreateConversionEventSettings;
            UpdateConversionEventSettings = existing.UpdateConversionEventSettings;
            GetConversionEventSettings = existing.GetConversionEventSettings;
            DeleteConversionEventSettings = existing.DeleteConversionEventSettings;
            ListConversionEventsSettings = existing.ListConversionEventsSettings;
            CreateKeyEventSettings = existing.CreateKeyEventSettings;
            UpdateKeyEventSettings = existing.UpdateKeyEventSettings;
            GetKeyEventSettings = existing.GetKeyEventSettings;
            DeleteKeyEventSettings = existing.DeleteKeyEventSettings;
            ListKeyEventsSettings = existing.ListKeyEventsSettings;
            CreateCustomDimensionSettings = existing.CreateCustomDimensionSettings;
            UpdateCustomDimensionSettings = existing.UpdateCustomDimensionSettings;
            ListCustomDimensionsSettings = existing.ListCustomDimensionsSettings;
            ArchiveCustomDimensionSettings = existing.ArchiveCustomDimensionSettings;
            GetCustomDimensionSettings = existing.GetCustomDimensionSettings;
            CreateCustomMetricSettings = existing.CreateCustomMetricSettings;
            UpdateCustomMetricSettings = existing.UpdateCustomMetricSettings;
            ListCustomMetricsSettings = existing.ListCustomMetricsSettings;
            ArchiveCustomMetricSettings = existing.ArchiveCustomMetricSettings;
            GetCustomMetricSettings = existing.GetCustomMetricSettings;
            GetDataRetentionSettingsSettings = existing.GetDataRetentionSettingsSettings;
            UpdateDataRetentionSettingsSettings = existing.UpdateDataRetentionSettingsSettings;
            CreateDataStreamSettings = existing.CreateDataStreamSettings;
            DeleteDataStreamSettings = existing.DeleteDataStreamSettings;
            UpdateDataStreamSettings = existing.UpdateDataStreamSettings;
            ListDataStreamsSettings = existing.ListDataStreamsSettings;
            GetDataStreamSettings = existing.GetDataStreamSettings;
            RunAccessReportSettings = existing.RunAccessReportSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AnalyticsAdminServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.GetAccount</c> and <c>AnalyticsAdminServiceClient.GetAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAccountSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.ListAccounts</c> and <c>AnalyticsAdminServiceClient.ListAccountsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAccountsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.DeleteAccount</c> and <c>AnalyticsAdminServiceClient.DeleteAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAccountSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.UpdateAccount</c> and <c>AnalyticsAdminServiceClient.UpdateAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAccountSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.ProvisionAccountTicket</c> and
        /// <c>AnalyticsAdminServiceClient.ProvisionAccountTicketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ProvisionAccountTicketSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.ListAccountSummaries</c> and
        /// <c>AnalyticsAdminServiceClient.ListAccountSummariesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAccountSummariesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.GetProperty</c> and <c>AnalyticsAdminServiceClient.GetPropertyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPropertySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.ListProperties</c> and <c>AnalyticsAdminServiceClient.ListPropertiesAsync</c>
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
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPropertiesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.CreateProperty</c> and <c>AnalyticsAdminServiceClient.CreatePropertyAsync</c>
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
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePropertySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.DeleteProperty</c> and <c>AnalyticsAdminServiceClient.DeletePropertyAsync</c>
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
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePropertySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.UpdateProperty</c> and <c>AnalyticsAdminServiceClient.UpdatePropertyAsync</c>
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
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePropertySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.CreateFirebaseLink</c> and
        /// <c>AnalyticsAdminServiceClient.CreateFirebaseLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFirebaseLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.DeleteFirebaseLink</c> and
        /// <c>AnalyticsAdminServiceClient.DeleteFirebaseLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFirebaseLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.ListFirebaseLinks</c> and
        /// <c>AnalyticsAdminServiceClient.ListFirebaseLinksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFirebaseLinksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.CreateGoogleAdsLink</c> and
        /// <c>AnalyticsAdminServiceClient.CreateGoogleAdsLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGoogleAdsLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.UpdateGoogleAdsLink</c> and
        /// <c>AnalyticsAdminServiceClient.UpdateGoogleAdsLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGoogleAdsLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.DeleteGoogleAdsLink</c> and
        /// <c>AnalyticsAdminServiceClient.DeleteGoogleAdsLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGoogleAdsLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.ListGoogleAdsLinks</c> and
        /// <c>AnalyticsAdminServiceClient.ListGoogleAdsLinksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGoogleAdsLinksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.GetDataSharingSettings</c> and
        /// <c>AnalyticsAdminServiceClient.GetDataSharingSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataSharingSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.GetMeasurementProtocolSecret</c> and
        /// <c>AnalyticsAdminServiceClient.GetMeasurementProtocolSecretAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMeasurementProtocolSecretSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.ListMeasurementProtocolSecrets</c> and
        /// <c>AnalyticsAdminServiceClient.ListMeasurementProtocolSecretsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMeasurementProtocolSecretsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.CreateMeasurementProtocolSecret</c> and
        /// <c>AnalyticsAdminServiceClient.CreateMeasurementProtocolSecretAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMeasurementProtocolSecretSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.DeleteMeasurementProtocolSecret</c> and
        /// <c>AnalyticsAdminServiceClient.DeleteMeasurementProtocolSecretAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMeasurementProtocolSecretSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.UpdateMeasurementProtocolSecret</c> and
        /// <c>AnalyticsAdminServiceClient.UpdateMeasurementProtocolSecretAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMeasurementProtocolSecretSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.AcknowledgeUserDataCollection</c> and
        /// <c>AnalyticsAdminServiceClient.AcknowledgeUserDataCollectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AcknowledgeUserDataCollectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.SearchChangeHistoryEvents</c> and
        /// <c>AnalyticsAdminServiceClient.SearchChangeHistoryEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchChangeHistoryEventsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.CreateConversionEvent</c> and
        /// <c>AnalyticsAdminServiceClient.CreateConversionEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateConversionEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.UpdateConversionEvent</c> and
        /// <c>AnalyticsAdminServiceClient.UpdateConversionEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConversionEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.GetConversionEvent</c> and
        /// <c>AnalyticsAdminServiceClient.GetConversionEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConversionEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.DeleteConversionEvent</c> and
        /// <c>AnalyticsAdminServiceClient.DeleteConversionEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConversionEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.ListConversionEvents</c> and
        /// <c>AnalyticsAdminServiceClient.ListConversionEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListConversionEventsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.CreateKeyEvent</c> and <c>AnalyticsAdminServiceClient.CreateKeyEventAsync</c>
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
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateKeyEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.UpdateKeyEvent</c> and <c>AnalyticsAdminServiceClient.UpdateKeyEventAsync</c>
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
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateKeyEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.GetKeyEvent</c> and <c>AnalyticsAdminServiceClient.GetKeyEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetKeyEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.DeleteKeyEvent</c> and <c>AnalyticsAdminServiceClient.DeleteKeyEventAsync</c>
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
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteKeyEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.ListKeyEvents</c> and <c>AnalyticsAdminServiceClient.ListKeyEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListKeyEventsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.CreateCustomDimension</c> and
        /// <c>AnalyticsAdminServiceClient.CreateCustomDimensionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCustomDimensionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.UpdateCustomDimension</c> and
        /// <c>AnalyticsAdminServiceClient.UpdateCustomDimensionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCustomDimensionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.ListCustomDimensions</c> and
        /// <c>AnalyticsAdminServiceClient.ListCustomDimensionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCustomDimensionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.ArchiveCustomDimension</c> and
        /// <c>AnalyticsAdminServiceClient.ArchiveCustomDimensionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ArchiveCustomDimensionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.GetCustomDimension</c> and
        /// <c>AnalyticsAdminServiceClient.GetCustomDimensionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomDimensionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.CreateCustomMetric</c> and
        /// <c>AnalyticsAdminServiceClient.CreateCustomMetricAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCustomMetricSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.UpdateCustomMetric</c> and
        /// <c>AnalyticsAdminServiceClient.UpdateCustomMetricAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCustomMetricSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.ListCustomMetrics</c> and
        /// <c>AnalyticsAdminServiceClient.ListCustomMetricsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCustomMetricsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.ArchiveCustomMetric</c> and
        /// <c>AnalyticsAdminServiceClient.ArchiveCustomMetricAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ArchiveCustomMetricSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.GetCustomMetric</c> and <c>AnalyticsAdminServiceClient.GetCustomMetricAsync</c>
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
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomMetricSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.GetDataRetentionSettings</c> and
        /// <c>AnalyticsAdminServiceClient.GetDataRetentionSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataRetentionSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.UpdateDataRetentionSettings</c> and
        /// <c>AnalyticsAdminServiceClient.UpdateDataRetentionSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataRetentionSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.CreateDataStream</c> and <c>AnalyticsAdminServiceClient.CreateDataStreamAsync</c>
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
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDataStreamSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.DeleteDataStream</c> and <c>AnalyticsAdminServiceClient.DeleteDataStreamAsync</c>
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
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDataStreamSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.UpdateDataStream</c> and <c>AnalyticsAdminServiceClient.UpdateDataStreamAsync</c>
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
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataStreamSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.ListDataStreams</c> and <c>AnalyticsAdminServiceClient.ListDataStreamsAsync</c>
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
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDataStreamsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.GetDataStream</c> and <c>AnalyticsAdminServiceClient.GetDataStreamAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataStreamSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.RunAccessReport</c> and <c>AnalyticsAdminServiceClient.RunAccessReportAsync</c>
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
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunAccessReportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AnalyticsAdminServiceSettings"/> object.</returns>
        public AnalyticsAdminServiceSettings Clone() => new AnalyticsAdminServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AnalyticsAdminServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AnalyticsAdminServiceClientBuilder : gaxgrpc::ClientBuilderBase<AnalyticsAdminServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AnalyticsAdminServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AnalyticsAdminServiceClientBuilder() : base(AnalyticsAdminServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AnalyticsAdminServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AnalyticsAdminServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AnalyticsAdminServiceClient Build()
        {
            AnalyticsAdminServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AnalyticsAdminServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AnalyticsAdminServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AnalyticsAdminServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AnalyticsAdminServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AnalyticsAdminServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AnalyticsAdminServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AnalyticsAdminServiceClient.ChannelPool;
    }

    /// <summary>AnalyticsAdminService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service Interface for the Analytics Admin API (GA4).
    /// </remarks>
    public abstract partial class AnalyticsAdminServiceClient
    {
        /// <summary>
        /// The default endpoint for the AnalyticsAdminService service, which is a host of
        /// "analyticsadmin.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "analyticsadmin.googleapis.com:443";

        /// <summary>The default AnalyticsAdminService scopes.</summary>
        /// <remarks>
        /// The default AnalyticsAdminService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/analytics.edit</description></item>
        /// <item><description>https://www.googleapis.com/auth/analytics.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/analytics.edit",
            "https://www.googleapis.com/auth/analytics.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AnalyticsAdminService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AnalyticsAdminServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AnalyticsAdminServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AnalyticsAdminServiceClient"/>.</returns>
        public static stt::Task<AnalyticsAdminServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AnalyticsAdminServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AnalyticsAdminServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AnalyticsAdminServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AnalyticsAdminServiceClient"/>.</returns>
        public static AnalyticsAdminServiceClient Create() => new AnalyticsAdminServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AnalyticsAdminServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AnalyticsAdminServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AnalyticsAdminServiceClient"/>.</returns>
        internal static AnalyticsAdminServiceClient Create(grpccore::CallInvoker callInvoker, AnalyticsAdminServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AnalyticsAdminService.AnalyticsAdminServiceClient grpcClient = new AnalyticsAdminService.AnalyticsAdminServiceClient(callInvoker);
            return new AnalyticsAdminServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AnalyticsAdminService client</summary>
        public virtual AnalyticsAdminService.AnalyticsAdminServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single Account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Account GetAccount(GetAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single Account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> GetAccountAsync(GetAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single Account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> GetAccountAsync(GetAccountRequest request, st::CancellationToken cancellationToken) =>
            GetAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single Account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the account to lookup.
        /// Format: accounts/{account}
        /// Example: "accounts/100"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Account GetAccount(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccount(new GetAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single Account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the account to lookup.
        /// Format: accounts/{account}
        /// Example: "accounts/100"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> GetAccountAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountAsync(new GetAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single Account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the account to lookup.
        /// Format: accounts/{account}
        /// Example: "accounts/100"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> GetAccountAsync(string name, st::CancellationToken cancellationToken) =>
            GetAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single Account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the account to lookup.
        /// Format: accounts/{account}
        /// Example: "accounts/100"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Account GetAccount(AccountName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccount(new GetAccountRequest
            {
                AccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single Account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the account to lookup.
        /// Format: accounts/{account}
        /// Example: "accounts/100"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> GetAccountAsync(AccountName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountAsync(new GetAccountRequest
            {
                AccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single Account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the account to lookup.
        /// Format: accounts/{account}
        /// Example: "accounts/100"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> GetAccountAsync(AccountName name, st::CancellationToken cancellationToken) =>
            GetAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all accounts accessible by the caller.
        /// 
        /// Note that these accounts might not currently have GA4 properties.
        /// Soft-deleted (ie: "trashed") accounts are excluded by default.
        /// Returns an empty list if no relevant accounts are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Account"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccountsResponse, Account> ListAccounts(ListAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all accounts accessible by the caller.
        /// 
        /// Note that these accounts might not currently have GA4 properties.
        /// Soft-deleted (ie: "trashed") accounts are excluded by default.
        /// Returns an empty list if no relevant accounts are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Account"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccountsResponse, Account> ListAccountsAsync(ListAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks target Account as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted accounts.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the accounts are not restored before the expiration time, the account
        /// and all child resources (eg: Properties, GoogleAdsLinks, Streams,
        /// AccessBindings) will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAccount(DeleteAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks target Account as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted accounts.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the accounts are not restored before the expiration time, the account
        /// and all child resources (eg: Properties, GoogleAdsLinks, Streams,
        /// AccessBindings) will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccountAsync(DeleteAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks target Account as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted accounts.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the accounts are not restored before the expiration time, the account
        /// and all child resources (eg: Properties, GoogleAdsLinks, Streams,
        /// AccessBindings) will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccountAsync(DeleteAccountRequest request, st::CancellationToken cancellationToken) =>
            DeleteAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks target Account as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted accounts.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the accounts are not restored before the expiration time, the account
        /// and all child resources (eg: Properties, GoogleAdsLinks, Streams,
        /// AccessBindings) will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Account to soft-delete.
        /// Format: accounts/{account}
        /// Example: "accounts/100"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAccount(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccount(new DeleteAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks target Account as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted accounts.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the accounts are not restored before the expiration time, the account
        /// and all child resources (eg: Properties, GoogleAdsLinks, Streams,
        /// AccessBindings) will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Account to soft-delete.
        /// Format: accounts/{account}
        /// Example: "accounts/100"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccountAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccountAsync(new DeleteAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks target Account as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted accounts.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the accounts are not restored before the expiration time, the account
        /// and all child resources (eg: Properties, GoogleAdsLinks, Streams,
        /// AccessBindings) will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Account to soft-delete.
        /// Format: accounts/{account}
        /// Example: "accounts/100"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccountAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks target Account as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted accounts.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the accounts are not restored before the expiration time, the account
        /// and all child resources (eg: Properties, GoogleAdsLinks, Streams,
        /// AccessBindings) will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Account to soft-delete.
        /// Format: accounts/{account}
        /// Example: "accounts/100"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAccount(AccountName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccount(new DeleteAccountRequest
            {
                AccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks target Account as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted accounts.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the accounts are not restored before the expiration time, the account
        /// and all child resources (eg: Properties, GoogleAdsLinks, Streams,
        /// AccessBindings) will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Account to soft-delete.
        /// Format: accounts/{account}
        /// Example: "accounts/100"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccountAsync(AccountName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccountAsync(new DeleteAccountRequest
            {
                AccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks target Account as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted accounts.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the accounts are not restored before the expiration time, the account
        /// and all child resources (eg: Properties, GoogleAdsLinks, Streams,
        /// AccessBindings) will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Account to soft-delete.
        /// Format: accounts/{account}
        /// Example: "accounts/100"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccountAsync(AccountName name, st::CancellationToken cancellationToken) =>
            DeleteAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Account UpdateAccount(UpdateAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> UpdateAccountAsync(UpdateAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> UpdateAccountAsync(UpdateAccountRequest request, st::CancellationToken cancellationToken) =>
            UpdateAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an account.
        /// </summary>
        /// <param name="account">
        /// Required. The account to update.
        /// The account's `name` field is used to identify the account.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake
        /// case (for example, "field_to_update"). Omitted fields will not be updated.
        /// To replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Account UpdateAccount(Account account, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccount(new UpdateAccountRequest
            {
                Account = gax::GaxPreconditions.CheckNotNull(account, nameof(account)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an account.
        /// </summary>
        /// <param name="account">
        /// Required. The account to update.
        /// The account's `name` field is used to identify the account.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake
        /// case (for example, "field_to_update"). Omitted fields will not be updated.
        /// To replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> UpdateAccountAsync(Account account, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccountAsync(new UpdateAccountRequest
            {
                Account = gax::GaxPreconditions.CheckNotNull(account, nameof(account)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an account.
        /// </summary>
        /// <param name="account">
        /// Required. The account to update.
        /// The account's `name` field is used to identify the account.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake
        /// case (for example, "field_to_update"). Omitted fields will not be updated.
        /// To replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> UpdateAccountAsync(Account account, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAccountAsync(account, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests a ticket for creating an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProvisionAccountTicketResponse ProvisionAccountTicket(ProvisionAccountTicketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Requests a ticket for creating an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvisionAccountTicketResponse> ProvisionAccountTicketAsync(ProvisionAccountTicketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Requests a ticket for creating an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvisionAccountTicketResponse> ProvisionAccountTicketAsync(ProvisionAccountTicketRequest request, st::CancellationToken cancellationToken) =>
            ProvisionAccountTicketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns summaries of all accounts accessible by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccountSummary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccountSummariesResponse, AccountSummary> ListAccountSummaries(ListAccountSummariesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns summaries of all accounts accessible by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccountSummary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccountSummariesResponse, AccountSummary> ListAccountSummariesAsync(ListAccountSummariesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single "GA4" Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Property GetProperty(GetPropertyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single "GA4" Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> GetPropertyAsync(GetPropertyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single "GA4" Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> GetPropertyAsync(GetPropertyRequest request, st::CancellationToken cancellationToken) =>
            GetPropertyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single "GA4" Property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the property to lookup.
        /// Format: properties/{property_id}
        /// Example: "properties/1000"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Property GetProperty(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProperty(new GetPropertyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single "GA4" Property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the property to lookup.
        /// Format: properties/{property_id}
        /// Example: "properties/1000"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> GetPropertyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPropertyAsync(new GetPropertyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single "GA4" Property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the property to lookup.
        /// Format: properties/{property_id}
        /// Example: "properties/1000"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> GetPropertyAsync(string name, st::CancellationToken cancellationToken) =>
            GetPropertyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single "GA4" Property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the property to lookup.
        /// Format: properties/{property_id}
        /// Example: "properties/1000"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Property GetProperty(PropertyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProperty(new GetPropertyRequest
            {
                PropertyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single "GA4" Property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the property to lookup.
        /// Format: properties/{property_id}
        /// Example: "properties/1000"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> GetPropertyAsync(PropertyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPropertyAsync(new GetPropertyRequest
            {
                PropertyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single "GA4" Property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the property to lookup.
        /// Format: properties/{property_id}
        /// Example: "properties/1000"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> GetPropertyAsync(PropertyName name, st::CancellationToken cancellationToken) =>
            GetPropertyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns child Properties under the specified parent Account.
        /// 
        /// Only "GA4" properties will be returned.
        /// Properties will be excluded if the caller does not have access.
        /// Soft-deleted (ie: "trashed") properties are excluded by default.
        /// Returns an empty list if no relevant properties are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Property"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPropertiesResponse, Property> ListProperties(ListPropertiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns child Properties under the specified parent Account.
        /// 
        /// Only "GA4" properties will be returned.
        /// Properties will be excluded if the caller does not have access.
        /// Soft-deleted (ie: "trashed") properties are excluded by default.
        /// Returns an empty list if no relevant properties are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Property"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPropertiesResponse, Property> ListPropertiesAsync(ListPropertiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an "GA4" property with the specified location and attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Property CreateProperty(CreatePropertyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an "GA4" property with the specified location and attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> CreatePropertyAsync(CreatePropertyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an "GA4" property with the specified location and attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> CreatePropertyAsync(CreatePropertyRequest request, st::CancellationToken cancellationToken) =>
            CreatePropertyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an "GA4" property with the specified location and attributes.
        /// </summary>
        /// <param name="property">
        /// Required. The property to create.
        /// Note: the supplied property must specify its parent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Property CreateProperty(Property property, gaxgrpc::CallSettings callSettings = null) =>
            CreateProperty(new CreatePropertyRequest
            {
                Property = gax::GaxPreconditions.CheckNotNull(property, nameof(property)),
            }, callSettings);

        /// <summary>
        /// Creates an "GA4" property with the specified location and attributes.
        /// </summary>
        /// <param name="property">
        /// Required. The property to create.
        /// Note: the supplied property must specify its parent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> CreatePropertyAsync(Property property, gaxgrpc::CallSettings callSettings = null) =>
            CreatePropertyAsync(new CreatePropertyRequest
            {
                Property = gax::GaxPreconditions.CheckNotNull(property, nameof(property)),
            }, callSettings);

        /// <summary>
        /// Creates an "GA4" property with the specified location and attributes.
        /// </summary>
        /// <param name="property">
        /// Required. The property to create.
        /// Note: the supplied property must specify its parent.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> CreatePropertyAsync(Property property, st::CancellationToken cancellationToken) =>
            CreatePropertyAsync(property, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks target Property as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted properties.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the properties are not restored before the expiration time, the Property
        /// and all child resources (eg: GoogleAdsLinks, Streams, AccessBindings)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not a GA4 Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Property DeleteProperty(DeletePropertyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks target Property as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted properties.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the properties are not restored before the expiration time, the Property
        /// and all child resources (eg: GoogleAdsLinks, Streams, AccessBindings)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not a GA4 Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> DeletePropertyAsync(DeletePropertyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks target Property as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted properties.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the properties are not restored before the expiration time, the Property
        /// and all child resources (eg: GoogleAdsLinks, Streams, AccessBindings)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not a GA4 Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> DeletePropertyAsync(DeletePropertyRequest request, st::CancellationToken cancellationToken) =>
            DeletePropertyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks target Property as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted properties.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the properties are not restored before the expiration time, the Property
        /// and all child resources (eg: GoogleAdsLinks, Streams, AccessBindings)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not a GA4 Property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Property to soft-delete.
        /// Format: properties/{property_id}
        /// Example: "properties/1000"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Property DeleteProperty(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProperty(new DeletePropertyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks target Property as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted properties.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the properties are not restored before the expiration time, the Property
        /// and all child resources (eg: GoogleAdsLinks, Streams, AccessBindings)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not a GA4 Property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Property to soft-delete.
        /// Format: properties/{property_id}
        /// Example: "properties/1000"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> DeletePropertyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePropertyAsync(new DeletePropertyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks target Property as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted properties.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the properties are not restored before the expiration time, the Property
        /// and all child resources (eg: GoogleAdsLinks, Streams, AccessBindings)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not a GA4 Property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Property to soft-delete.
        /// Format: properties/{property_id}
        /// Example: "properties/1000"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> DeletePropertyAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePropertyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks target Property as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted properties.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the properties are not restored before the expiration time, the Property
        /// and all child resources (eg: GoogleAdsLinks, Streams, AccessBindings)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not a GA4 Property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Property to soft-delete.
        /// Format: properties/{property_id}
        /// Example: "properties/1000"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Property DeleteProperty(PropertyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProperty(new DeletePropertyRequest
            {
                PropertyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks target Property as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted properties.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the properties are not restored before the expiration time, the Property
        /// and all child resources (eg: GoogleAdsLinks, Streams, AccessBindings)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not a GA4 Property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Property to soft-delete.
        /// Format: properties/{property_id}
        /// Example: "properties/1000"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> DeletePropertyAsync(PropertyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePropertyAsync(new DeletePropertyRequest
            {
                PropertyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks target Property as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted properties.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the properties are not restored before the expiration time, the Property
        /// and all child resources (eg: GoogleAdsLinks, Streams, AccessBindings)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not a GA4 Property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Property to soft-delete.
        /// Format: properties/{property_id}
        /// Example: "properties/1000"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> DeletePropertyAsync(PropertyName name, st::CancellationToken cancellationToken) =>
            DeletePropertyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Property UpdateProperty(UpdatePropertyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> UpdatePropertyAsync(UpdatePropertyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> UpdatePropertyAsync(UpdatePropertyRequest request, st::CancellationToken cancellationToken) =>
            UpdatePropertyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a property.
        /// </summary>
        /// <param name="property">
        /// Required. The property to update.
        /// The property's `name` field is used to identify the property to be
        /// updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake
        /// case (e.g., "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Property UpdateProperty(Property property, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProperty(new UpdatePropertyRequest
            {
                Property = gax::GaxPreconditions.CheckNotNull(property, nameof(property)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a property.
        /// </summary>
        /// <param name="property">
        /// Required. The property to update.
        /// The property's `name` field is used to identify the property to be
        /// updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake
        /// case (e.g., "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> UpdatePropertyAsync(Property property, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePropertyAsync(new UpdatePropertyRequest
            {
                Property = gax::GaxPreconditions.CheckNotNull(property, nameof(property)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a property.
        /// </summary>
        /// <param name="property">
        /// Required. The property to update.
        /// The property's `name` field is used to identify the property to be
        /// updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake
        /// case (e.g., "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> UpdatePropertyAsync(Property property, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePropertyAsync(property, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a FirebaseLink.
        /// 
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirebaseLink CreateFirebaseLink(CreateFirebaseLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a FirebaseLink.
        /// 
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirebaseLink> CreateFirebaseLinkAsync(CreateFirebaseLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a FirebaseLink.
        /// 
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirebaseLink> CreateFirebaseLinkAsync(CreateFirebaseLinkRequest request, st::CancellationToken cancellationToken) =>
            CreateFirebaseLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a FirebaseLink.
        /// 
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: properties/{property_id}
        /// 
        /// Example: `properties/1234`
        /// </param>
        /// <param name="firebaseLink">
        /// Required. The Firebase link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirebaseLink CreateFirebaseLink(string parent, FirebaseLink firebaseLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateFirebaseLink(new CreateFirebaseLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FirebaseLink = gax::GaxPreconditions.CheckNotNull(firebaseLink, nameof(firebaseLink)),
            }, callSettings);

        /// <summary>
        /// Creates a FirebaseLink.
        /// 
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: properties/{property_id}
        /// 
        /// Example: `properties/1234`
        /// </param>
        /// <param name="firebaseLink">
        /// Required. The Firebase link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirebaseLink> CreateFirebaseLinkAsync(string parent, FirebaseLink firebaseLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateFirebaseLinkAsync(new CreateFirebaseLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FirebaseLink = gax::GaxPreconditions.CheckNotNull(firebaseLink, nameof(firebaseLink)),
            }, callSettings);

        /// <summary>
        /// Creates a FirebaseLink.
        /// 
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: properties/{property_id}
        /// 
        /// Example: `properties/1234`
        /// </param>
        /// <param name="firebaseLink">
        /// Required. The Firebase link to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirebaseLink> CreateFirebaseLinkAsync(string parent, FirebaseLink firebaseLink, st::CancellationToken cancellationToken) =>
            CreateFirebaseLinkAsync(parent, firebaseLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a FirebaseLink.
        /// 
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: properties/{property_id}
        /// 
        /// Example: `properties/1234`
        /// </param>
        /// <param name="firebaseLink">
        /// Required. The Firebase link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirebaseLink CreateFirebaseLink(PropertyName parent, FirebaseLink firebaseLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateFirebaseLink(new CreateFirebaseLinkRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FirebaseLink = gax::GaxPreconditions.CheckNotNull(firebaseLink, nameof(firebaseLink)),
            }, callSettings);

        /// <summary>
        /// Creates a FirebaseLink.
        /// 
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: properties/{property_id}
        /// 
        /// Example: `properties/1234`
        /// </param>
        /// <param name="firebaseLink">
        /// Required. The Firebase link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirebaseLink> CreateFirebaseLinkAsync(PropertyName parent, FirebaseLink firebaseLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateFirebaseLinkAsync(new CreateFirebaseLinkRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FirebaseLink = gax::GaxPreconditions.CheckNotNull(firebaseLink, nameof(firebaseLink)),
            }, callSettings);

        /// <summary>
        /// Creates a FirebaseLink.
        /// 
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: properties/{property_id}
        /// 
        /// Example: `properties/1234`
        /// </param>
        /// <param name="firebaseLink">
        /// Required. The Firebase link to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirebaseLink> CreateFirebaseLinkAsync(PropertyName parent, FirebaseLink firebaseLink, st::CancellationToken cancellationToken) =>
            CreateFirebaseLinkAsync(parent, firebaseLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a FirebaseLink on a property
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFirebaseLink(DeleteFirebaseLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a FirebaseLink on a property
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFirebaseLinkAsync(DeleteFirebaseLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a FirebaseLink on a property
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFirebaseLinkAsync(DeleteFirebaseLinkRequest request, st::CancellationToken cancellationToken) =>
            DeleteFirebaseLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a FirebaseLink on a property
        /// </summary>
        /// <param name="name">
        /// Required. Format: properties/{property_id}/firebaseLinks/{firebase_link_id}
        /// 
        /// Example: `properties/1234/firebaseLinks/5678`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFirebaseLink(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFirebaseLink(new DeleteFirebaseLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a FirebaseLink on a property
        /// </summary>
        /// <param name="name">
        /// Required. Format: properties/{property_id}/firebaseLinks/{firebase_link_id}
        /// 
        /// Example: `properties/1234/firebaseLinks/5678`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFirebaseLinkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFirebaseLinkAsync(new DeleteFirebaseLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a FirebaseLink on a property
        /// </summary>
        /// <param name="name">
        /// Required. Format: properties/{property_id}/firebaseLinks/{firebase_link_id}
        /// 
        /// Example: `properties/1234/firebaseLinks/5678`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFirebaseLinkAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFirebaseLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a FirebaseLink on a property
        /// </summary>
        /// <param name="name">
        /// Required. Format: properties/{property_id}/firebaseLinks/{firebase_link_id}
        /// 
        /// Example: `properties/1234/firebaseLinks/5678`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFirebaseLink(FirebaseLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFirebaseLink(new DeleteFirebaseLinkRequest
            {
                FirebaseLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a FirebaseLink on a property
        /// </summary>
        /// <param name="name">
        /// Required. Format: properties/{property_id}/firebaseLinks/{firebase_link_id}
        /// 
        /// Example: `properties/1234/firebaseLinks/5678`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFirebaseLinkAsync(FirebaseLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFirebaseLinkAsync(new DeleteFirebaseLinkRequest
            {
                FirebaseLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a FirebaseLink on a property
        /// </summary>
        /// <param name="name">
        /// Required. Format: properties/{property_id}/firebaseLinks/{firebase_link_id}
        /// 
        /// Example: `properties/1234/firebaseLinks/5678`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFirebaseLinkAsync(FirebaseLinkName name, st::CancellationToken cancellationToken) =>
            DeleteFirebaseLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists FirebaseLinks on a property.
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FirebaseLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFirebaseLinksResponse, FirebaseLink> ListFirebaseLinks(ListFirebaseLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FirebaseLinks on a property.
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FirebaseLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFirebaseLinksResponse, FirebaseLink> ListFirebaseLinksAsync(ListFirebaseLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FirebaseLinks on a property.
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: properties/{property_id}
        /// 
        /// Example: `properties/1234`
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
        /// <returns>A pageable sequence of <see cref="FirebaseLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFirebaseLinksResponse, FirebaseLink> ListFirebaseLinks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirebaseLinksRequest request = new ListFirebaseLinksRequest
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
            return ListFirebaseLinks(request, callSettings);
        }

        /// <summary>
        /// Lists FirebaseLinks on a property.
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: properties/{property_id}
        /// 
        /// Example: `properties/1234`
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
        /// <returns>A pageable asynchronous sequence of <see cref="FirebaseLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFirebaseLinksResponse, FirebaseLink> ListFirebaseLinksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirebaseLinksRequest request = new ListFirebaseLinksRequest
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
            return ListFirebaseLinksAsync(request, callSettings);
        }

        /// <summary>
        /// Lists FirebaseLinks on a property.
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: properties/{property_id}
        /// 
        /// Example: `properties/1234`
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
        /// <returns>A pageable sequence of <see cref="FirebaseLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFirebaseLinksResponse, FirebaseLink> ListFirebaseLinks(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirebaseLinksRequest request = new ListFirebaseLinksRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFirebaseLinks(request, callSettings);
        }

        /// <summary>
        /// Lists FirebaseLinks on a property.
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: properties/{property_id}
        /// 
        /// Example: `properties/1234`
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
        /// <returns>A pageable asynchronous sequence of <see cref="FirebaseLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFirebaseLinksResponse, FirebaseLink> ListFirebaseLinksAsync(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirebaseLinksRequest request = new ListFirebaseLinksRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFirebaseLinksAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a GoogleAdsLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleAdsLink CreateGoogleAdsLink(CreateGoogleAdsLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a GoogleAdsLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleAdsLink> CreateGoogleAdsLinkAsync(CreateGoogleAdsLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a GoogleAdsLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleAdsLink> CreateGoogleAdsLinkAsync(CreateGoogleAdsLinkRequest request, st::CancellationToken cancellationToken) =>
            CreateGoogleAdsLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a GoogleAdsLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="googleAdsLink">
        /// Required. The GoogleAdsLink to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleAdsLink CreateGoogleAdsLink(string parent, GoogleAdsLink googleAdsLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateGoogleAdsLink(new CreateGoogleAdsLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GoogleAdsLink = gax::GaxPreconditions.CheckNotNull(googleAdsLink, nameof(googleAdsLink)),
            }, callSettings);

        /// <summary>
        /// Creates a GoogleAdsLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="googleAdsLink">
        /// Required. The GoogleAdsLink to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleAdsLink> CreateGoogleAdsLinkAsync(string parent, GoogleAdsLink googleAdsLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateGoogleAdsLinkAsync(new CreateGoogleAdsLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GoogleAdsLink = gax::GaxPreconditions.CheckNotNull(googleAdsLink, nameof(googleAdsLink)),
            }, callSettings);

        /// <summary>
        /// Creates a GoogleAdsLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="googleAdsLink">
        /// Required. The GoogleAdsLink to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleAdsLink> CreateGoogleAdsLinkAsync(string parent, GoogleAdsLink googleAdsLink, st::CancellationToken cancellationToken) =>
            CreateGoogleAdsLinkAsync(parent, googleAdsLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a GoogleAdsLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="googleAdsLink">
        /// Required. The GoogleAdsLink to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleAdsLink CreateGoogleAdsLink(PropertyName parent, GoogleAdsLink googleAdsLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateGoogleAdsLink(new CreateGoogleAdsLinkRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GoogleAdsLink = gax::GaxPreconditions.CheckNotNull(googleAdsLink, nameof(googleAdsLink)),
            }, callSettings);

        /// <summary>
        /// Creates a GoogleAdsLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="googleAdsLink">
        /// Required. The GoogleAdsLink to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleAdsLink> CreateGoogleAdsLinkAsync(PropertyName parent, GoogleAdsLink googleAdsLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateGoogleAdsLinkAsync(new CreateGoogleAdsLinkRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GoogleAdsLink = gax::GaxPreconditions.CheckNotNull(googleAdsLink, nameof(googleAdsLink)),
            }, callSettings);

        /// <summary>
        /// Creates a GoogleAdsLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="googleAdsLink">
        /// Required. The GoogleAdsLink to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleAdsLink> CreateGoogleAdsLinkAsync(PropertyName parent, GoogleAdsLink googleAdsLink, st::CancellationToken cancellationToken) =>
            CreateGoogleAdsLinkAsync(parent, googleAdsLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a GoogleAdsLink on a property
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleAdsLink UpdateGoogleAdsLink(UpdateGoogleAdsLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a GoogleAdsLink on a property
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleAdsLink> UpdateGoogleAdsLinkAsync(UpdateGoogleAdsLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a GoogleAdsLink on a property
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleAdsLink> UpdateGoogleAdsLinkAsync(UpdateGoogleAdsLinkRequest request, st::CancellationToken cancellationToken) =>
            UpdateGoogleAdsLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a GoogleAdsLink on a property
        /// </summary>
        /// <param name="googleAdsLink">
        /// The GoogleAdsLink to update
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake
        /// case (e.g., "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleAdsLink UpdateGoogleAdsLink(GoogleAdsLink googleAdsLink, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGoogleAdsLink(new UpdateGoogleAdsLinkRequest
            {
                GoogleAdsLink = googleAdsLink,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a GoogleAdsLink on a property
        /// </summary>
        /// <param name="googleAdsLink">
        /// The GoogleAdsLink to update
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake
        /// case (e.g., "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleAdsLink> UpdateGoogleAdsLinkAsync(GoogleAdsLink googleAdsLink, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGoogleAdsLinkAsync(new UpdateGoogleAdsLinkRequest
            {
                GoogleAdsLink = googleAdsLink,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a GoogleAdsLink on a property
        /// </summary>
        /// <param name="googleAdsLink">
        /// The GoogleAdsLink to update
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake
        /// case (e.g., "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleAdsLink> UpdateGoogleAdsLinkAsync(GoogleAdsLink googleAdsLink, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGoogleAdsLinkAsync(googleAdsLink, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a GoogleAdsLink on a property
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGoogleAdsLink(DeleteGoogleAdsLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a GoogleAdsLink on a property
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGoogleAdsLinkAsync(DeleteGoogleAdsLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a GoogleAdsLink on a property
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGoogleAdsLinkAsync(DeleteGoogleAdsLinkRequest request, st::CancellationToken cancellationToken) =>
            DeleteGoogleAdsLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a GoogleAdsLink on a property
        /// </summary>
        /// <param name="name">
        /// Required. Example format: properties/1234/googleAdsLinks/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGoogleAdsLink(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGoogleAdsLink(new DeleteGoogleAdsLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a GoogleAdsLink on a property
        /// </summary>
        /// <param name="name">
        /// Required. Example format: properties/1234/googleAdsLinks/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGoogleAdsLinkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGoogleAdsLinkAsync(new DeleteGoogleAdsLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a GoogleAdsLink on a property
        /// </summary>
        /// <param name="name">
        /// Required. Example format: properties/1234/googleAdsLinks/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGoogleAdsLinkAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGoogleAdsLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a GoogleAdsLink on a property
        /// </summary>
        /// <param name="name">
        /// Required. Example format: properties/1234/googleAdsLinks/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGoogleAdsLink(GoogleAdsLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGoogleAdsLink(new DeleteGoogleAdsLinkRequest
            {
                GoogleAdsLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a GoogleAdsLink on a property
        /// </summary>
        /// <param name="name">
        /// Required. Example format: properties/1234/googleAdsLinks/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGoogleAdsLinkAsync(GoogleAdsLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGoogleAdsLinkAsync(new DeleteGoogleAdsLinkRequest
            {
                GoogleAdsLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a GoogleAdsLink on a property
        /// </summary>
        /// <param name="name">
        /// Required. Example format: properties/1234/googleAdsLinks/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGoogleAdsLinkAsync(GoogleAdsLinkName name, st::CancellationToken cancellationToken) =>
            DeleteGoogleAdsLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists GoogleAdsLinks on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GoogleAdsLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGoogleAdsLinksResponse, GoogleAdsLink> ListGoogleAdsLinks(ListGoogleAdsLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists GoogleAdsLinks on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GoogleAdsLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGoogleAdsLinksResponse, GoogleAdsLink> ListGoogleAdsLinksAsync(ListGoogleAdsLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists GoogleAdsLinks on a property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
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
        /// <returns>A pageable sequence of <see cref="GoogleAdsLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGoogleAdsLinksResponse, GoogleAdsLink> ListGoogleAdsLinks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGoogleAdsLinksRequest request = new ListGoogleAdsLinksRequest
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
            return ListGoogleAdsLinks(request, callSettings);
        }

        /// <summary>
        /// Lists GoogleAdsLinks on a property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
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
        /// <returns>A pageable asynchronous sequence of <see cref="GoogleAdsLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGoogleAdsLinksResponse, GoogleAdsLink> ListGoogleAdsLinksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGoogleAdsLinksRequest request = new ListGoogleAdsLinksRequest
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
            return ListGoogleAdsLinksAsync(request, callSettings);
        }

        /// <summary>
        /// Lists GoogleAdsLinks on a property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
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
        /// <returns>A pageable sequence of <see cref="GoogleAdsLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGoogleAdsLinksResponse, GoogleAdsLink> ListGoogleAdsLinks(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGoogleAdsLinksRequest request = new ListGoogleAdsLinksRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGoogleAdsLinks(request, callSettings);
        }

        /// <summary>
        /// Lists GoogleAdsLinks on a property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
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
        /// <returns>A pageable asynchronous sequence of <see cref="GoogleAdsLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGoogleAdsLinksResponse, GoogleAdsLink> ListGoogleAdsLinksAsync(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGoogleAdsLinksRequest request = new ListGoogleAdsLinksRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGoogleAdsLinksAsync(request, callSettings);
        }

        /// <summary>
        /// Get data sharing settings on an account.
        /// Data sharing settings are singletons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSharingSettings GetDataSharingSettings(GetDataSharingSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get data sharing settings on an account.
        /// Data sharing settings are singletons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSharingSettings> GetDataSharingSettingsAsync(GetDataSharingSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get data sharing settings on an account.
        /// Data sharing settings are singletons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSharingSettings> GetDataSharingSettingsAsync(GetDataSharingSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetDataSharingSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get data sharing settings on an account.
        /// Data sharing settings are singletons.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings to lookup.
        /// Format: accounts/{account}/dataSharingSettings
        /// 
        /// Example: `accounts/1000/dataSharingSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSharingSettings GetDataSharingSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSharingSettings(new GetDataSharingSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get data sharing settings on an account.
        /// Data sharing settings are singletons.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings to lookup.
        /// Format: accounts/{account}/dataSharingSettings
        /// 
        /// Example: `accounts/1000/dataSharingSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSharingSettings> GetDataSharingSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSharingSettingsAsync(new GetDataSharingSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get data sharing settings on an account.
        /// Data sharing settings are singletons.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings to lookup.
        /// Format: accounts/{account}/dataSharingSettings
        /// 
        /// Example: `accounts/1000/dataSharingSettings`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSharingSettings> GetDataSharingSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataSharingSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get data sharing settings on an account.
        /// Data sharing settings are singletons.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings to lookup.
        /// Format: accounts/{account}/dataSharingSettings
        /// 
        /// Example: `accounts/1000/dataSharingSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSharingSettings GetDataSharingSettings(DataSharingSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSharingSettings(new GetDataSharingSettingsRequest
            {
                DataSharingSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get data sharing settings on an account.
        /// Data sharing settings are singletons.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings to lookup.
        /// Format: accounts/{account}/dataSharingSettings
        /// 
        /// Example: `accounts/1000/dataSharingSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSharingSettings> GetDataSharingSettingsAsync(DataSharingSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSharingSettingsAsync(new GetDataSharingSettingsRequest
            {
                DataSharingSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get data sharing settings on an account.
        /// Data sharing settings are singletons.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings to lookup.
        /// Format: accounts/{account}/dataSharingSettings
        /// 
        /// Example: `accounts/1000/dataSharingSettings`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSharingSettings> GetDataSharingSettingsAsync(DataSharingSettingsName name, st::CancellationToken cancellationToken) =>
            GetDataSharingSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single "GA4" MeasurementProtocolSecret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MeasurementProtocolSecret GetMeasurementProtocolSecret(GetMeasurementProtocolSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single "GA4" MeasurementProtocolSecret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeasurementProtocolSecret> GetMeasurementProtocolSecretAsync(GetMeasurementProtocolSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single "GA4" MeasurementProtocolSecret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeasurementProtocolSecret> GetMeasurementProtocolSecretAsync(GetMeasurementProtocolSecretRequest request, st::CancellationToken cancellationToken) =>
            GetMeasurementProtocolSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single "GA4" MeasurementProtocolSecret.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the measurement protocol secret to lookup.
        /// Format:
        /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MeasurementProtocolSecret GetMeasurementProtocolSecret(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMeasurementProtocolSecret(new GetMeasurementProtocolSecretRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single "GA4" MeasurementProtocolSecret.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the measurement protocol secret to lookup.
        /// Format:
        /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeasurementProtocolSecret> GetMeasurementProtocolSecretAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMeasurementProtocolSecretAsync(new GetMeasurementProtocolSecretRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single "GA4" MeasurementProtocolSecret.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the measurement protocol secret to lookup.
        /// Format:
        /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeasurementProtocolSecret> GetMeasurementProtocolSecretAsync(string name, st::CancellationToken cancellationToken) =>
            GetMeasurementProtocolSecretAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single "GA4" MeasurementProtocolSecret.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the measurement protocol secret to lookup.
        /// Format:
        /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MeasurementProtocolSecret GetMeasurementProtocolSecret(MeasurementProtocolSecretName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMeasurementProtocolSecret(new GetMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single "GA4" MeasurementProtocolSecret.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the measurement protocol secret to lookup.
        /// Format:
        /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeasurementProtocolSecret> GetMeasurementProtocolSecretAsync(MeasurementProtocolSecretName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMeasurementProtocolSecretAsync(new GetMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single "GA4" MeasurementProtocolSecret.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the measurement protocol secret to lookup.
        /// Format:
        /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeasurementProtocolSecret> GetMeasurementProtocolSecretAsync(MeasurementProtocolSecretName name, st::CancellationToken cancellationToken) =>
            GetMeasurementProtocolSecretAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns child MeasurementProtocolSecrets under the specified parent
        /// Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MeasurementProtocolSecret"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret> ListMeasurementProtocolSecrets(ListMeasurementProtocolSecretsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns child MeasurementProtocolSecrets under the specified parent
        /// Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MeasurementProtocolSecret"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret> ListMeasurementProtocolSecretsAsync(ListMeasurementProtocolSecretsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns child MeasurementProtocolSecrets under the specified parent
        /// Property.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent stream.
        /// Format:
        /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets
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
        /// <returns>A pageable sequence of <see cref="MeasurementProtocolSecret"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret> ListMeasurementProtocolSecrets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMeasurementProtocolSecretsRequest request = new ListMeasurementProtocolSecretsRequest
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
            return ListMeasurementProtocolSecrets(request, callSettings);
        }

        /// <summary>
        /// Returns child MeasurementProtocolSecrets under the specified parent
        /// Property.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent stream.
        /// Format:
        /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets
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
        /// <returns>A pageable asynchronous sequence of <see cref="MeasurementProtocolSecret"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret> ListMeasurementProtocolSecretsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMeasurementProtocolSecretsRequest request = new ListMeasurementProtocolSecretsRequest
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
            return ListMeasurementProtocolSecretsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns child MeasurementProtocolSecrets under the specified parent
        /// Property.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent stream.
        /// Format:
        /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets
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
        /// <returns>A pageable sequence of <see cref="MeasurementProtocolSecret"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret> ListMeasurementProtocolSecrets(DataStreamName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMeasurementProtocolSecretsRequest request = new ListMeasurementProtocolSecretsRequest
            {
                ParentAsDataStreamName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMeasurementProtocolSecrets(request, callSettings);
        }

        /// <summary>
        /// Returns child MeasurementProtocolSecrets under the specified parent
        /// Property.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent stream.
        /// Format:
        /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets
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
        /// <returns>A pageable asynchronous sequence of <see cref="MeasurementProtocolSecret"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret> ListMeasurementProtocolSecretsAsync(DataStreamName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMeasurementProtocolSecretsRequest request = new ListMeasurementProtocolSecretsRequest
            {
                ParentAsDataStreamName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMeasurementProtocolSecretsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a measurement protocol secret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MeasurementProtocolSecret CreateMeasurementProtocolSecret(CreateMeasurementProtocolSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a measurement protocol secret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeasurementProtocolSecret> CreateMeasurementProtocolSecretAsync(CreateMeasurementProtocolSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a measurement protocol secret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeasurementProtocolSecret> CreateMeasurementProtocolSecretAsync(CreateMeasurementProtocolSecretRequest request, st::CancellationToken cancellationToken) =>
            CreateMeasurementProtocolSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a measurement protocol secret.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this secret will be created.
        /// Format: properties/{property}/dataStreams/{dataStream}
        /// </param>
        /// <param name="measurementProtocolSecret">
        /// Required. The measurement protocol secret to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MeasurementProtocolSecret CreateMeasurementProtocolSecret(string parent, MeasurementProtocolSecret measurementProtocolSecret, gaxgrpc::CallSettings callSettings = null) =>
            CreateMeasurementProtocolSecret(new CreateMeasurementProtocolSecretRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MeasurementProtocolSecret = gax::GaxPreconditions.CheckNotNull(measurementProtocolSecret, nameof(measurementProtocolSecret)),
            }, callSettings);

        /// <summary>
        /// Creates a measurement protocol secret.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this secret will be created.
        /// Format: properties/{property}/dataStreams/{dataStream}
        /// </param>
        /// <param name="measurementProtocolSecret">
        /// Required. The measurement protocol secret to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeasurementProtocolSecret> CreateMeasurementProtocolSecretAsync(string parent, MeasurementProtocolSecret measurementProtocolSecret, gaxgrpc::CallSettings callSettings = null) =>
            CreateMeasurementProtocolSecretAsync(new CreateMeasurementProtocolSecretRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MeasurementProtocolSecret = gax::GaxPreconditions.CheckNotNull(measurementProtocolSecret, nameof(measurementProtocolSecret)),
            }, callSettings);

        /// <summary>
        /// Creates a measurement protocol secret.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this secret will be created.
        /// Format: properties/{property}/dataStreams/{dataStream}
        /// </param>
        /// <param name="measurementProtocolSecret">
        /// Required. The measurement protocol secret to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeasurementProtocolSecret> CreateMeasurementProtocolSecretAsync(string parent, MeasurementProtocolSecret measurementProtocolSecret, st::CancellationToken cancellationToken) =>
            CreateMeasurementProtocolSecretAsync(parent, measurementProtocolSecret, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a measurement protocol secret.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this secret will be created.
        /// Format: properties/{property}/dataStreams/{dataStream}
        /// </param>
        /// <param name="measurementProtocolSecret">
        /// Required. The measurement protocol secret to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MeasurementProtocolSecret CreateMeasurementProtocolSecret(DataStreamName parent, MeasurementProtocolSecret measurementProtocolSecret, gaxgrpc::CallSettings callSettings = null) =>
            CreateMeasurementProtocolSecret(new CreateMeasurementProtocolSecretRequest
            {
                ParentAsDataStreamName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MeasurementProtocolSecret = gax::GaxPreconditions.CheckNotNull(measurementProtocolSecret, nameof(measurementProtocolSecret)),
            }, callSettings);

        /// <summary>
        /// Creates a measurement protocol secret.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this secret will be created.
        /// Format: properties/{property}/dataStreams/{dataStream}
        /// </param>
        /// <param name="measurementProtocolSecret">
        /// Required. The measurement protocol secret to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeasurementProtocolSecret> CreateMeasurementProtocolSecretAsync(DataStreamName parent, MeasurementProtocolSecret measurementProtocolSecret, gaxgrpc::CallSettings callSettings = null) =>
            CreateMeasurementProtocolSecretAsync(new CreateMeasurementProtocolSecretRequest
            {
                ParentAsDataStreamName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MeasurementProtocolSecret = gax::GaxPreconditions.CheckNotNull(measurementProtocolSecret, nameof(measurementProtocolSecret)),
            }, callSettings);

        /// <summary>
        /// Creates a measurement protocol secret.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this secret will be created.
        /// Format: properties/{property}/dataStreams/{dataStream}
        /// </param>
        /// <param name="measurementProtocolSecret">
        /// Required. The measurement protocol secret to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeasurementProtocolSecret> CreateMeasurementProtocolSecretAsync(DataStreamName parent, MeasurementProtocolSecret measurementProtocolSecret, st::CancellationToken cancellationToken) =>
            CreateMeasurementProtocolSecretAsync(parent, measurementProtocolSecret, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes target MeasurementProtocolSecret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMeasurementProtocolSecret(DeleteMeasurementProtocolSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes target MeasurementProtocolSecret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMeasurementProtocolSecretAsync(DeleteMeasurementProtocolSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes target MeasurementProtocolSecret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMeasurementProtocolSecretAsync(DeleteMeasurementProtocolSecretRequest request, st::CancellationToken cancellationToken) =>
            DeleteMeasurementProtocolSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes target MeasurementProtocolSecret.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MeasurementProtocolSecret to delete.
        /// Format:
        /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMeasurementProtocolSecret(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMeasurementProtocolSecret(new DeleteMeasurementProtocolSecretRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes target MeasurementProtocolSecret.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MeasurementProtocolSecret to delete.
        /// Format:
        /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMeasurementProtocolSecretAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMeasurementProtocolSecretAsync(new DeleteMeasurementProtocolSecretRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes target MeasurementProtocolSecret.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MeasurementProtocolSecret to delete.
        /// Format:
        /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMeasurementProtocolSecretAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMeasurementProtocolSecretAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes target MeasurementProtocolSecret.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MeasurementProtocolSecret to delete.
        /// Format:
        /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMeasurementProtocolSecret(MeasurementProtocolSecretName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMeasurementProtocolSecret(new DeleteMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes target MeasurementProtocolSecret.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MeasurementProtocolSecret to delete.
        /// Format:
        /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMeasurementProtocolSecretAsync(MeasurementProtocolSecretName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMeasurementProtocolSecretAsync(new DeleteMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes target MeasurementProtocolSecret.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MeasurementProtocolSecret to delete.
        /// Format:
        /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMeasurementProtocolSecretAsync(MeasurementProtocolSecretName name, st::CancellationToken cancellationToken) =>
            DeleteMeasurementProtocolSecretAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a measurement protocol secret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MeasurementProtocolSecret UpdateMeasurementProtocolSecret(UpdateMeasurementProtocolSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a measurement protocol secret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeasurementProtocolSecret> UpdateMeasurementProtocolSecretAsync(UpdateMeasurementProtocolSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a measurement protocol secret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeasurementProtocolSecret> UpdateMeasurementProtocolSecretAsync(UpdateMeasurementProtocolSecretRequest request, st::CancellationToken cancellationToken) =>
            UpdateMeasurementProtocolSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a measurement protocol secret.
        /// </summary>
        /// <param name="measurementProtocolSecret">
        /// Required. The measurement protocol secret to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Omitted fields will not be
        /// updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MeasurementProtocolSecret UpdateMeasurementProtocolSecret(MeasurementProtocolSecret measurementProtocolSecret, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMeasurementProtocolSecret(new UpdateMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecret = gax::GaxPreconditions.CheckNotNull(measurementProtocolSecret, nameof(measurementProtocolSecret)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a measurement protocol secret.
        /// </summary>
        /// <param name="measurementProtocolSecret">
        /// Required. The measurement protocol secret to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Omitted fields will not be
        /// updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeasurementProtocolSecret> UpdateMeasurementProtocolSecretAsync(MeasurementProtocolSecret measurementProtocolSecret, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMeasurementProtocolSecretAsync(new UpdateMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecret = gax::GaxPreconditions.CheckNotNull(measurementProtocolSecret, nameof(measurementProtocolSecret)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a measurement protocol secret.
        /// </summary>
        /// <param name="measurementProtocolSecret">
        /// Required. The measurement protocol secret to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Omitted fields will not be
        /// updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeasurementProtocolSecret> UpdateMeasurementProtocolSecretAsync(MeasurementProtocolSecret measurementProtocolSecret, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMeasurementProtocolSecretAsync(measurementProtocolSecret, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Acknowledges the terms of user data collection for the specified property.
        /// 
        /// This acknowledgement must be completed (either in the Google Analytics UI
        /// or through this API) before MeasurementProtocolSecret resources may be
        /// created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AcknowledgeUserDataCollectionResponse AcknowledgeUserDataCollection(AcknowledgeUserDataCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Acknowledges the terms of user data collection for the specified property.
        /// 
        /// This acknowledgement must be completed (either in the Google Analytics UI
        /// or through this API) before MeasurementProtocolSecret resources may be
        /// created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AcknowledgeUserDataCollectionResponse> AcknowledgeUserDataCollectionAsync(AcknowledgeUserDataCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Acknowledges the terms of user data collection for the specified property.
        /// 
        /// This acknowledgement must be completed (either in the Google Analytics UI
        /// or through this API) before MeasurementProtocolSecret resources may be
        /// created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AcknowledgeUserDataCollectionResponse> AcknowledgeUserDataCollectionAsync(AcknowledgeUserDataCollectionRequest request, st::CancellationToken cancellationToken) =>
            AcknowledgeUserDataCollectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Searches through all changes to an account or its children given the
        /// specified set of filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ChangeHistoryEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchChangeHistoryEventsResponse, ChangeHistoryEvent> SearchChangeHistoryEvents(SearchChangeHistoryEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches through all changes to an account or its children given the
        /// specified set of filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ChangeHistoryEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchChangeHistoryEventsResponse, ChangeHistoryEvent> SearchChangeHistoryEventsAsync(SearchChangeHistoryEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: Use `CreateKeyEvent` instead.
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual ConversionEvent CreateConversionEvent(CreateConversionEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: Use `CreateKeyEvent` instead.
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ConversionEvent> CreateConversionEventAsync(CreateConversionEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: Use `CreateKeyEvent` instead.
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ConversionEvent> CreateConversionEventAsync(CreateConversionEventRequest request, st::CancellationToken cancellationToken) =>
            CreateConversionEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: Use `CreateKeyEvent` instead.
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property where this conversion
        /// event will be created. Format: properties/123
        /// </param>
        /// <param name="conversionEvent">
        /// Required. The conversion event to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual ConversionEvent CreateConversionEvent(string parent, ConversionEvent conversionEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversionEvent(new CreateConversionEventRequest
            {
                ConversionEvent = gax::GaxPreconditions.CheckNotNull(conversionEvent, nameof(conversionEvent)),
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Deprecated: Use `CreateKeyEvent` instead.
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property where this conversion
        /// event will be created. Format: properties/123
        /// </param>
        /// <param name="conversionEvent">
        /// Required. The conversion event to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ConversionEvent> CreateConversionEventAsync(string parent, ConversionEvent conversionEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversionEventAsync(new CreateConversionEventRequest
            {
                ConversionEvent = gax::GaxPreconditions.CheckNotNull(conversionEvent, nameof(conversionEvent)),
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Deprecated: Use `CreateKeyEvent` instead.
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property where this conversion
        /// event will be created. Format: properties/123
        /// </param>
        /// <param name="conversionEvent">
        /// Required. The conversion event to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ConversionEvent> CreateConversionEventAsync(string parent, ConversionEvent conversionEvent, st::CancellationToken cancellationToken) =>
            CreateConversionEventAsync(parent, conversionEvent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: Use `CreateKeyEvent` instead.
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property where this conversion
        /// event will be created. Format: properties/123
        /// </param>
        /// <param name="conversionEvent">
        /// Required. The conversion event to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual ConversionEvent CreateConversionEvent(PropertyName parent, ConversionEvent conversionEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversionEvent(new CreateConversionEventRequest
            {
                ConversionEvent = gax::GaxPreconditions.CheckNotNull(conversionEvent, nameof(conversionEvent)),
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Deprecated: Use `CreateKeyEvent` instead.
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property where this conversion
        /// event will be created. Format: properties/123
        /// </param>
        /// <param name="conversionEvent">
        /// Required. The conversion event to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ConversionEvent> CreateConversionEventAsync(PropertyName parent, ConversionEvent conversionEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversionEventAsync(new CreateConversionEventRequest
            {
                ConversionEvent = gax::GaxPreconditions.CheckNotNull(conversionEvent, nameof(conversionEvent)),
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Deprecated: Use `CreateKeyEvent` instead.
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property where this conversion
        /// event will be created. Format: properties/123
        /// </param>
        /// <param name="conversionEvent">
        /// Required. The conversion event to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ConversionEvent> CreateConversionEventAsync(PropertyName parent, ConversionEvent conversionEvent, st::CancellationToken cancellationToken) =>
            CreateConversionEventAsync(parent, conversionEvent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: Use `UpdateKeyEvent` instead.
        /// Updates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual ConversionEvent UpdateConversionEvent(UpdateConversionEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: Use `UpdateKeyEvent` instead.
        /// Updates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ConversionEvent> UpdateConversionEventAsync(UpdateConversionEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: Use `UpdateKeyEvent` instead.
        /// Updates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ConversionEvent> UpdateConversionEventAsync(UpdateConversionEventRequest request, st::CancellationToken cancellationToken) =>
            UpdateConversionEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: Use `UpdateKeyEvent` instead.
        /// Updates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="conversionEvent">
        /// Required. The conversion event to update.
        /// The `name` field is used to identify the settings to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake
        /// case (e.g., "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual ConversionEvent UpdateConversionEvent(ConversionEvent conversionEvent, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConversionEvent(new UpdateConversionEventRequest
            {
                ConversionEvent = gax::GaxPreconditions.CheckNotNull(conversionEvent, nameof(conversionEvent)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Deprecated: Use `UpdateKeyEvent` instead.
        /// Updates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="conversionEvent">
        /// Required. The conversion event to update.
        /// The `name` field is used to identify the settings to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake
        /// case (e.g., "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ConversionEvent> UpdateConversionEventAsync(ConversionEvent conversionEvent, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConversionEventAsync(new UpdateConversionEventRequest
            {
                ConversionEvent = gax::GaxPreconditions.CheckNotNull(conversionEvent, nameof(conversionEvent)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Deprecated: Use `UpdateKeyEvent` instead.
        /// Updates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="conversionEvent">
        /// Required. The conversion event to update.
        /// The `name` field is used to identify the settings to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake
        /// case (e.g., "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ConversionEvent> UpdateConversionEventAsync(ConversionEvent conversionEvent, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConversionEventAsync(conversionEvent, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: Use `GetKeyEvent` instead.
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual ConversionEvent GetConversionEvent(GetConversionEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: Use `GetKeyEvent` instead.
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ConversionEvent> GetConversionEventAsync(GetConversionEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: Use `GetKeyEvent` instead.
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ConversionEvent> GetConversionEventAsync(GetConversionEventRequest request, st::CancellationToken cancellationToken) =>
            GetConversionEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: Use `GetKeyEvent` instead.
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to retrieve.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual ConversionEvent GetConversionEvent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionEvent(new GetConversionEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deprecated: Use `GetKeyEvent` instead.
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to retrieve.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ConversionEvent> GetConversionEventAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionEventAsync(new GetConversionEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deprecated: Use `GetKeyEvent` instead.
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to retrieve.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ConversionEvent> GetConversionEventAsync(string name, st::CancellationToken cancellationToken) =>
            GetConversionEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: Use `GetKeyEvent` instead.
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to retrieve.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual ConversionEvent GetConversionEvent(ConversionEventName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionEvent(new GetConversionEventRequest
            {
                ConversionEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deprecated: Use `GetKeyEvent` instead.
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to retrieve.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ConversionEvent> GetConversionEventAsync(ConversionEventName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionEventAsync(new GetConversionEventRequest
            {
                ConversionEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deprecated: Use `GetKeyEvent` instead.
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to retrieve.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ConversionEvent> GetConversionEventAsync(ConversionEventName name, st::CancellationToken cancellationToken) =>
            GetConversionEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: Use `DeleteKeyEvent` instead.
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual void DeleteConversionEvent(DeleteConversionEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: Use `DeleteKeyEvent` instead.
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task DeleteConversionEventAsync(DeleteConversionEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: Use `DeleteKeyEvent` instead.
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task DeleteConversionEventAsync(DeleteConversionEventRequest request, st::CancellationToken cancellationToken) =>
            DeleteConversionEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: Use `DeleteKeyEvent` instead.
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to delete.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual void DeleteConversionEvent(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversionEvent(new DeleteConversionEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deprecated: Use `DeleteKeyEvent` instead.
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to delete.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task DeleteConversionEventAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversionEventAsync(new DeleteConversionEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deprecated: Use `DeleteKeyEvent` instead.
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to delete.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task DeleteConversionEventAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConversionEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: Use `DeleteKeyEvent` instead.
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to delete.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual void DeleteConversionEvent(ConversionEventName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversionEvent(new DeleteConversionEventRequest
            {
                ConversionEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deprecated: Use `DeleteKeyEvent` instead.
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to delete.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task DeleteConversionEventAsync(ConversionEventName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversionEventAsync(new DeleteConversionEventRequest
            {
                ConversionEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deprecated: Use `DeleteKeyEvent` instead.
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to delete.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task DeleteConversionEventAsync(ConversionEventName name, st::CancellationToken cancellationToken) =>
            DeleteConversionEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: Use `ListKeyEvents` instead.
        /// Returns a list of conversion events in the specified parent property.
        /// 
        /// Returns an empty list if no conversion events are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConversionEvent"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedEnumerable<ListConversionEventsResponse, ConversionEvent> ListConversionEvents(ListConversionEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: Use `ListKeyEvents` instead.
        /// Returns a list of conversion events in the specified parent property.
        /// 
        /// Returns an empty list if no conversion events are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConversionEvent"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedAsyncEnumerable<ListConversionEventsResponse, ConversionEvent> ListConversionEventsAsync(ListConversionEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: Use `ListKeyEvents` instead.
        /// Returns a list of conversion events in the specified parent property.
        /// 
        /// Returns an empty list if no conversion events are found.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property.
        /// Example: 'properties/123'
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
        /// <returns>A pageable sequence of <see cref="ConversionEvent"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedEnumerable<ListConversionEventsResponse, ConversionEvent> ListConversionEvents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversionEventsRequest request = new ListConversionEventsRequest
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
            return ListConversionEvents(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Use `ListKeyEvents` instead.
        /// Returns a list of conversion events in the specified parent property.
        /// 
        /// Returns an empty list if no conversion events are found.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property.
        /// Example: 'properties/123'
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConversionEvent"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedAsyncEnumerable<ListConversionEventsResponse, ConversionEvent> ListConversionEventsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversionEventsRequest request = new ListConversionEventsRequest
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
            return ListConversionEventsAsync(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Use `ListKeyEvents` instead.
        /// Returns a list of conversion events in the specified parent property.
        /// 
        /// Returns an empty list if no conversion events are found.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property.
        /// Example: 'properties/123'
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
        /// <returns>A pageable sequence of <see cref="ConversionEvent"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedEnumerable<ListConversionEventsResponse, ConversionEvent> ListConversionEvents(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversionEventsRequest request = new ListConversionEventsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConversionEvents(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Use `ListKeyEvents` instead.
        /// Returns a list of conversion events in the specified parent property.
        /// 
        /// Returns an empty list if no conversion events are found.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property.
        /// Example: 'properties/123'
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConversionEvent"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedAsyncEnumerable<ListConversionEventsResponse, ConversionEvent> ListConversionEventsAsync(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversionEventsRequest request = new ListConversionEventsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConversionEventsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KeyEvent CreateKeyEvent(CreateKeyEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyEvent> CreateKeyEventAsync(CreateKeyEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyEvent> CreateKeyEventAsync(CreateKeyEventRequest request, st::CancellationToken cancellationToken) =>
            CreateKeyEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Key Event.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property where this Key Event
        /// will be created. Format: properties/123
        /// </param>
        /// <param name="keyEvent">
        /// Required. The Key Event to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KeyEvent CreateKeyEvent(string parent, KeyEvent keyEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateKeyEvent(new CreateKeyEventRequest
            {
                KeyEvent = gax::GaxPreconditions.CheckNotNull(keyEvent, nameof(keyEvent)),
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a Key Event.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property where this Key Event
        /// will be created. Format: properties/123
        /// </param>
        /// <param name="keyEvent">
        /// Required. The Key Event to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyEvent> CreateKeyEventAsync(string parent, KeyEvent keyEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateKeyEventAsync(new CreateKeyEventRequest
            {
                KeyEvent = gax::GaxPreconditions.CheckNotNull(keyEvent, nameof(keyEvent)),
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a Key Event.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property where this Key Event
        /// will be created. Format: properties/123
        /// </param>
        /// <param name="keyEvent">
        /// Required. The Key Event to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyEvent> CreateKeyEventAsync(string parent, KeyEvent keyEvent, st::CancellationToken cancellationToken) =>
            CreateKeyEventAsync(parent, keyEvent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Key Event.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property where this Key Event
        /// will be created. Format: properties/123
        /// </param>
        /// <param name="keyEvent">
        /// Required. The Key Event to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KeyEvent CreateKeyEvent(PropertyName parent, KeyEvent keyEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateKeyEvent(new CreateKeyEventRequest
            {
                KeyEvent = gax::GaxPreconditions.CheckNotNull(keyEvent, nameof(keyEvent)),
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a Key Event.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property where this Key Event
        /// will be created. Format: properties/123
        /// </param>
        /// <param name="keyEvent">
        /// Required. The Key Event to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyEvent> CreateKeyEventAsync(PropertyName parent, KeyEvent keyEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateKeyEventAsync(new CreateKeyEventRequest
            {
                KeyEvent = gax::GaxPreconditions.CheckNotNull(keyEvent, nameof(keyEvent)),
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a Key Event.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property where this Key Event
        /// will be created. Format: properties/123
        /// </param>
        /// <param name="keyEvent">
        /// Required. The Key Event to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyEvent> CreateKeyEventAsync(PropertyName parent, KeyEvent keyEvent, st::CancellationToken cancellationToken) =>
            CreateKeyEventAsync(parent, keyEvent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KeyEvent UpdateKeyEvent(UpdateKeyEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyEvent> UpdateKeyEventAsync(UpdateKeyEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyEvent> UpdateKeyEventAsync(UpdateKeyEventRequest request, st::CancellationToken cancellationToken) =>
            UpdateKeyEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Key Event.
        /// </summary>
        /// <param name="keyEvent">
        /// Required. The Key Event to update.
        /// The `name` field is used to identify the settings to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake
        /// case (e.g., "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KeyEvent UpdateKeyEvent(KeyEvent keyEvent, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateKeyEvent(new UpdateKeyEventRequest
            {
                KeyEvent = gax::GaxPreconditions.CheckNotNull(keyEvent, nameof(keyEvent)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a Key Event.
        /// </summary>
        /// <param name="keyEvent">
        /// Required. The Key Event to update.
        /// The `name` field is used to identify the settings to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake
        /// case (e.g., "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyEvent> UpdateKeyEventAsync(KeyEvent keyEvent, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateKeyEventAsync(new UpdateKeyEventRequest
            {
                KeyEvent = gax::GaxPreconditions.CheckNotNull(keyEvent, nameof(keyEvent)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a Key Event.
        /// </summary>
        /// <param name="keyEvent">
        /// Required. The Key Event to update.
        /// The `name` field is used to identify the settings to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake
        /// case (e.g., "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyEvent> UpdateKeyEventAsync(KeyEvent keyEvent, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateKeyEventAsync(keyEvent, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KeyEvent GetKeyEvent(GetKeyEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyEvent> GetKeyEventAsync(GetKeyEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyEvent> GetKeyEventAsync(GetKeyEventRequest request, st::CancellationToken cancellationToken) =>
            GetKeyEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single Key Event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Key Event to retrieve.
        /// Format: properties/{property}/keyEvents/{key_event}
        /// Example: "properties/123/keyEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KeyEvent GetKeyEvent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetKeyEvent(new GetKeyEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single Key Event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Key Event to retrieve.
        /// Format: properties/{property}/keyEvents/{key_event}
        /// Example: "properties/123/keyEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyEvent> GetKeyEventAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetKeyEventAsync(new GetKeyEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single Key Event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Key Event to retrieve.
        /// Format: properties/{property}/keyEvents/{key_event}
        /// Example: "properties/123/keyEvents/456"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyEvent> GetKeyEventAsync(string name, st::CancellationToken cancellationToken) =>
            GetKeyEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single Key Event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Key Event to retrieve.
        /// Format: properties/{property}/keyEvents/{key_event}
        /// Example: "properties/123/keyEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KeyEvent GetKeyEvent(KeyEventName name, gaxgrpc::CallSettings callSettings = null) =>
            GetKeyEvent(new GetKeyEventRequest
            {
                KeyEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single Key Event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Key Event to retrieve.
        /// Format: properties/{property}/keyEvents/{key_event}
        /// Example: "properties/123/keyEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyEvent> GetKeyEventAsync(KeyEventName name, gaxgrpc::CallSettings callSettings = null) =>
            GetKeyEventAsync(new GetKeyEventRequest
            {
                KeyEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single Key Event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Key Event to retrieve.
        /// Format: properties/{property}/keyEvents/{key_event}
        /// Example: "properties/123/keyEvents/456"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyEvent> GetKeyEventAsync(KeyEventName name, st::CancellationToken cancellationToken) =>
            GetKeyEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteKeyEvent(DeleteKeyEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteKeyEventAsync(DeleteKeyEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteKeyEventAsync(DeleteKeyEventRequest request, st::CancellationToken cancellationToken) =>
            DeleteKeyEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Key Event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Key Event to delete.
        /// Format: properties/{property}/keyEvents/{key_event}
        /// Example: "properties/123/keyEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteKeyEvent(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKeyEvent(new DeleteKeyEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Key Event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Key Event to delete.
        /// Format: properties/{property}/keyEvents/{key_event}
        /// Example: "properties/123/keyEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteKeyEventAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKeyEventAsync(new DeleteKeyEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Key Event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Key Event to delete.
        /// Format: properties/{property}/keyEvents/{key_event}
        /// Example: "properties/123/keyEvents/456"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteKeyEventAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteKeyEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Key Event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Key Event to delete.
        /// Format: properties/{property}/keyEvents/{key_event}
        /// Example: "properties/123/keyEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteKeyEvent(KeyEventName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKeyEvent(new DeleteKeyEventRequest
            {
                KeyEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Key Event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Key Event to delete.
        /// Format: properties/{property}/keyEvents/{key_event}
        /// Example: "properties/123/keyEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteKeyEventAsync(KeyEventName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKeyEventAsync(new DeleteKeyEventRequest
            {
                KeyEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Key Event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Key Event to delete.
        /// Format: properties/{property}/keyEvents/{key_event}
        /// Example: "properties/123/keyEvents/456"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteKeyEventAsync(KeyEventName name, st::CancellationToken cancellationToken) =>
            DeleteKeyEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of Key Events in the specified parent property.
        /// Returns an empty list if no Key Events are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="KeyEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKeyEventsResponse, KeyEvent> ListKeyEvents(ListKeyEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of Key Events in the specified parent property.
        /// Returns an empty list if no Key Events are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="KeyEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKeyEventsResponse, KeyEvent> ListKeyEventsAsync(ListKeyEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of Key Events in the specified parent property.
        /// Returns an empty list if no Key Events are found.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property.
        /// Example: 'properties/123'
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
        /// <returns>A pageable sequence of <see cref="KeyEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKeyEventsResponse, KeyEvent> ListKeyEvents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKeyEventsRequest request = new ListKeyEventsRequest
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
            return ListKeyEvents(request, callSettings);
        }

        /// <summary>
        /// Returns a list of Key Events in the specified parent property.
        /// Returns an empty list if no Key Events are found.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property.
        /// Example: 'properties/123'
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
        /// <returns>A pageable asynchronous sequence of <see cref="KeyEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKeyEventsResponse, KeyEvent> ListKeyEventsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKeyEventsRequest request = new ListKeyEventsRequest
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
            return ListKeyEventsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of Key Events in the specified parent property.
        /// Returns an empty list if no Key Events are found.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property.
        /// Example: 'properties/123'
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
        /// <returns>A pageable sequence of <see cref="KeyEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKeyEventsResponse, KeyEvent> ListKeyEvents(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKeyEventsRequest request = new ListKeyEventsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListKeyEvents(request, callSettings);
        }

        /// <summary>
        /// Returns a list of Key Events in the specified parent property.
        /// Returns an empty list if no Key Events are found.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property.
        /// Example: 'properties/123'
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
        /// <returns>A pageable asynchronous sequence of <see cref="KeyEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKeyEventsResponse, KeyEvent> ListKeyEventsAsync(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKeyEventsRequest request = new ListKeyEventsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListKeyEventsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a CustomDimension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomDimension CreateCustomDimension(CreateCustomDimensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a CustomDimension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomDimension> CreateCustomDimensionAsync(CreateCustomDimensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a CustomDimension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomDimension> CreateCustomDimensionAsync(CreateCustomDimensionRequest request, st::CancellationToken cancellationToken) =>
            CreateCustomDimensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a CustomDimension.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="customDimension">
        /// Required. The CustomDimension to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomDimension CreateCustomDimension(string parent, CustomDimension customDimension, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomDimension(new CreateCustomDimensionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CustomDimension = gax::GaxPreconditions.CheckNotNull(customDimension, nameof(customDimension)),
            }, callSettings);

        /// <summary>
        /// Creates a CustomDimension.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="customDimension">
        /// Required. The CustomDimension to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomDimension> CreateCustomDimensionAsync(string parent, CustomDimension customDimension, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomDimensionAsync(new CreateCustomDimensionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CustomDimension = gax::GaxPreconditions.CheckNotNull(customDimension, nameof(customDimension)),
            }, callSettings);

        /// <summary>
        /// Creates a CustomDimension.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="customDimension">
        /// Required. The CustomDimension to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomDimension> CreateCustomDimensionAsync(string parent, CustomDimension customDimension, st::CancellationToken cancellationToken) =>
            CreateCustomDimensionAsync(parent, customDimension, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a CustomDimension.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="customDimension">
        /// Required. The CustomDimension to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomDimension CreateCustomDimension(PropertyName parent, CustomDimension customDimension, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomDimension(new CreateCustomDimensionRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomDimension = gax::GaxPreconditions.CheckNotNull(customDimension, nameof(customDimension)),
            }, callSettings);

        /// <summary>
        /// Creates a CustomDimension.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="customDimension">
        /// Required. The CustomDimension to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomDimension> CreateCustomDimensionAsync(PropertyName parent, CustomDimension customDimension, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomDimensionAsync(new CreateCustomDimensionRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomDimension = gax::GaxPreconditions.CheckNotNull(customDimension, nameof(customDimension)),
            }, callSettings);

        /// <summary>
        /// Creates a CustomDimension.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="customDimension">
        /// Required. The CustomDimension to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomDimension> CreateCustomDimensionAsync(PropertyName parent, CustomDimension customDimension, st::CancellationToken cancellationToken) =>
            CreateCustomDimensionAsync(parent, customDimension, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a CustomDimension on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomDimension UpdateCustomDimension(UpdateCustomDimensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a CustomDimension on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomDimension> UpdateCustomDimensionAsync(UpdateCustomDimensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a CustomDimension on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomDimension> UpdateCustomDimensionAsync(UpdateCustomDimensionRequest request, st::CancellationToken cancellationToken) =>
            UpdateCustomDimensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a CustomDimension on a property.
        /// </summary>
        /// <param name="customDimension">
        /// The CustomDimension to update
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Omitted fields will not be
        /// updated. To replace the entire entity, use one path with the string "*" to
        /// match all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomDimension UpdateCustomDimension(CustomDimension customDimension, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCustomDimension(new UpdateCustomDimensionRequest
            {
                CustomDimension = customDimension,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a CustomDimension on a property.
        /// </summary>
        /// <param name="customDimension">
        /// The CustomDimension to update
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Omitted fields will not be
        /// updated. To replace the entire entity, use one path with the string "*" to
        /// match all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomDimension> UpdateCustomDimensionAsync(CustomDimension customDimension, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCustomDimensionAsync(new UpdateCustomDimensionRequest
            {
                CustomDimension = customDimension,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a CustomDimension on a property.
        /// </summary>
        /// <param name="customDimension">
        /// The CustomDimension to update
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Omitted fields will not be
        /// updated. To replace the entire entity, use one path with the string "*" to
        /// match all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomDimension> UpdateCustomDimensionAsync(CustomDimension customDimension, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCustomDimensionAsync(customDimension, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists CustomDimensions on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomDimension"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomDimensionsResponse, CustomDimension> ListCustomDimensions(ListCustomDimensionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CustomDimensions on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomDimension"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomDimensionsResponse, CustomDimension> ListCustomDimensionsAsync(ListCustomDimensionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CustomDimensions on a property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
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
        /// <returns>A pageable sequence of <see cref="CustomDimension"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomDimensionsResponse, CustomDimension> ListCustomDimensions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomDimensionsRequest request = new ListCustomDimensionsRequest
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
            return ListCustomDimensions(request, callSettings);
        }

        /// <summary>
        /// Lists CustomDimensions on a property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomDimension"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomDimensionsResponse, CustomDimension> ListCustomDimensionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomDimensionsRequest request = new ListCustomDimensionsRequest
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
            return ListCustomDimensionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists CustomDimensions on a property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
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
        /// <returns>A pageable sequence of <see cref="CustomDimension"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomDimensionsResponse, CustomDimension> ListCustomDimensions(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomDimensionsRequest request = new ListCustomDimensionsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCustomDimensions(request, callSettings);
        }

        /// <summary>
        /// Lists CustomDimensions on a property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomDimension"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomDimensionsResponse, CustomDimension> ListCustomDimensionsAsync(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomDimensionsRequest request = new ListCustomDimensionsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCustomDimensionsAsync(request, callSettings);
        }

        /// <summary>
        /// Archives a CustomDimension on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ArchiveCustomDimension(ArchiveCustomDimensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Archives a CustomDimension on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ArchiveCustomDimensionAsync(ArchiveCustomDimensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Archives a CustomDimension on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ArchiveCustomDimensionAsync(ArchiveCustomDimensionRequest request, st::CancellationToken cancellationToken) =>
            ArchiveCustomDimensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives a CustomDimension on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomDimension to archive.
        /// Example format: properties/1234/customDimensions/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ArchiveCustomDimension(string name, gaxgrpc::CallSettings callSettings = null) =>
            ArchiveCustomDimension(new ArchiveCustomDimensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Archives a CustomDimension on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomDimension to archive.
        /// Example format: properties/1234/customDimensions/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ArchiveCustomDimensionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ArchiveCustomDimensionAsync(new ArchiveCustomDimensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Archives a CustomDimension on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomDimension to archive.
        /// Example format: properties/1234/customDimensions/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ArchiveCustomDimensionAsync(string name, st::CancellationToken cancellationToken) =>
            ArchiveCustomDimensionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives a CustomDimension on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomDimension to archive.
        /// Example format: properties/1234/customDimensions/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ArchiveCustomDimension(CustomDimensionName name, gaxgrpc::CallSettings callSettings = null) =>
            ArchiveCustomDimension(new ArchiveCustomDimensionRequest
            {
                CustomDimensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Archives a CustomDimension on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomDimension to archive.
        /// Example format: properties/1234/customDimensions/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ArchiveCustomDimensionAsync(CustomDimensionName name, gaxgrpc::CallSettings callSettings = null) =>
            ArchiveCustomDimensionAsync(new ArchiveCustomDimensionRequest
            {
                CustomDimensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Archives a CustomDimension on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomDimension to archive.
        /// Example format: properties/1234/customDimensions/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ArchiveCustomDimensionAsync(CustomDimensionName name, st::CancellationToken cancellationToken) =>
            ArchiveCustomDimensionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single CustomDimension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomDimension GetCustomDimension(GetCustomDimensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single CustomDimension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomDimension> GetCustomDimensionAsync(GetCustomDimensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single CustomDimension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomDimension> GetCustomDimensionAsync(GetCustomDimensionRequest request, st::CancellationToken cancellationToken) =>
            GetCustomDimensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single CustomDimension.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomDimension to get.
        /// Example format: properties/1234/customDimensions/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomDimension GetCustomDimension(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomDimension(new GetCustomDimensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single CustomDimension.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomDimension to get.
        /// Example format: properties/1234/customDimensions/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomDimension> GetCustomDimensionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomDimensionAsync(new GetCustomDimensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single CustomDimension.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomDimension to get.
        /// Example format: properties/1234/customDimensions/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomDimension> GetCustomDimensionAsync(string name, st::CancellationToken cancellationToken) =>
            GetCustomDimensionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single CustomDimension.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomDimension to get.
        /// Example format: properties/1234/customDimensions/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomDimension GetCustomDimension(CustomDimensionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomDimension(new GetCustomDimensionRequest
            {
                CustomDimensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single CustomDimension.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomDimension to get.
        /// Example format: properties/1234/customDimensions/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomDimension> GetCustomDimensionAsync(CustomDimensionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomDimensionAsync(new GetCustomDimensionRequest
            {
                CustomDimensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single CustomDimension.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomDimension to get.
        /// Example format: properties/1234/customDimensions/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomDimension> GetCustomDimensionAsync(CustomDimensionName name, st::CancellationToken cancellationToken) =>
            GetCustomDimensionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a CustomMetric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomMetric CreateCustomMetric(CreateCustomMetricRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a CustomMetric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomMetric> CreateCustomMetricAsync(CreateCustomMetricRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a CustomMetric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomMetric> CreateCustomMetricAsync(CreateCustomMetricRequest request, st::CancellationToken cancellationToken) =>
            CreateCustomMetricAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a CustomMetric.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="customMetric">
        /// Required. The CustomMetric to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomMetric CreateCustomMetric(string parent, CustomMetric customMetric, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomMetric(new CreateCustomMetricRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CustomMetric = gax::GaxPreconditions.CheckNotNull(customMetric, nameof(customMetric)),
            }, callSettings);

        /// <summary>
        /// Creates a CustomMetric.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="customMetric">
        /// Required. The CustomMetric to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomMetric> CreateCustomMetricAsync(string parent, CustomMetric customMetric, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomMetricAsync(new CreateCustomMetricRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CustomMetric = gax::GaxPreconditions.CheckNotNull(customMetric, nameof(customMetric)),
            }, callSettings);

        /// <summary>
        /// Creates a CustomMetric.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="customMetric">
        /// Required. The CustomMetric to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomMetric> CreateCustomMetricAsync(string parent, CustomMetric customMetric, st::CancellationToken cancellationToken) =>
            CreateCustomMetricAsync(parent, customMetric, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a CustomMetric.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="customMetric">
        /// Required. The CustomMetric to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomMetric CreateCustomMetric(PropertyName parent, CustomMetric customMetric, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomMetric(new CreateCustomMetricRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomMetric = gax::GaxPreconditions.CheckNotNull(customMetric, nameof(customMetric)),
            }, callSettings);

        /// <summary>
        /// Creates a CustomMetric.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="customMetric">
        /// Required. The CustomMetric to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomMetric> CreateCustomMetricAsync(PropertyName parent, CustomMetric customMetric, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomMetricAsync(new CreateCustomMetricRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomMetric = gax::GaxPreconditions.CheckNotNull(customMetric, nameof(customMetric)),
            }, callSettings);

        /// <summary>
        /// Creates a CustomMetric.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="customMetric">
        /// Required. The CustomMetric to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomMetric> CreateCustomMetricAsync(PropertyName parent, CustomMetric customMetric, st::CancellationToken cancellationToken) =>
            CreateCustomMetricAsync(parent, customMetric, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a CustomMetric on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomMetric UpdateCustomMetric(UpdateCustomMetricRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a CustomMetric on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomMetric> UpdateCustomMetricAsync(UpdateCustomMetricRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a CustomMetric on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomMetric> UpdateCustomMetricAsync(UpdateCustomMetricRequest request, st::CancellationToken cancellationToken) =>
            UpdateCustomMetricAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a CustomMetric on a property.
        /// </summary>
        /// <param name="customMetric">
        /// The CustomMetric to update
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Omitted fields will not be
        /// updated. To replace the entire entity, use one path with the string "*" to
        /// match all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomMetric UpdateCustomMetric(CustomMetric customMetric, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCustomMetric(new UpdateCustomMetricRequest
            {
                CustomMetric = customMetric,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a CustomMetric on a property.
        /// </summary>
        /// <param name="customMetric">
        /// The CustomMetric to update
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Omitted fields will not be
        /// updated. To replace the entire entity, use one path with the string "*" to
        /// match all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomMetric> UpdateCustomMetricAsync(CustomMetric customMetric, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCustomMetricAsync(new UpdateCustomMetricRequest
            {
                CustomMetric = customMetric,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a CustomMetric on a property.
        /// </summary>
        /// <param name="customMetric">
        /// The CustomMetric to update
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Omitted fields will not be
        /// updated. To replace the entire entity, use one path with the string "*" to
        /// match all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomMetric> UpdateCustomMetricAsync(CustomMetric customMetric, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCustomMetricAsync(customMetric, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists CustomMetrics on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomMetric"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomMetricsResponse, CustomMetric> ListCustomMetrics(ListCustomMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CustomMetrics on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomMetric"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomMetricsResponse, CustomMetric> ListCustomMetricsAsync(ListCustomMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CustomMetrics on a property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
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
        /// <returns>A pageable sequence of <see cref="CustomMetric"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomMetricsResponse, CustomMetric> ListCustomMetrics(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomMetricsRequest request = new ListCustomMetricsRequest
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
            return ListCustomMetrics(request, callSettings);
        }

        /// <summary>
        /// Lists CustomMetrics on a property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomMetric"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomMetricsResponse, CustomMetric> ListCustomMetricsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomMetricsRequest request = new ListCustomMetricsRequest
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
            return ListCustomMetricsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists CustomMetrics on a property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
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
        /// <returns>A pageable sequence of <see cref="CustomMetric"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomMetricsResponse, CustomMetric> ListCustomMetrics(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomMetricsRequest request = new ListCustomMetricsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCustomMetrics(request, callSettings);
        }

        /// <summary>
        /// Lists CustomMetrics on a property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomMetric"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomMetricsResponse, CustomMetric> ListCustomMetricsAsync(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomMetricsRequest request = new ListCustomMetricsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCustomMetricsAsync(request, callSettings);
        }

        /// <summary>
        /// Archives a CustomMetric on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ArchiveCustomMetric(ArchiveCustomMetricRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Archives a CustomMetric on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ArchiveCustomMetricAsync(ArchiveCustomMetricRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Archives a CustomMetric on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ArchiveCustomMetricAsync(ArchiveCustomMetricRequest request, st::CancellationToken cancellationToken) =>
            ArchiveCustomMetricAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives a CustomMetric on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomMetric to archive.
        /// Example format: properties/1234/customMetrics/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ArchiveCustomMetric(string name, gaxgrpc::CallSettings callSettings = null) =>
            ArchiveCustomMetric(new ArchiveCustomMetricRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Archives a CustomMetric on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomMetric to archive.
        /// Example format: properties/1234/customMetrics/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ArchiveCustomMetricAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ArchiveCustomMetricAsync(new ArchiveCustomMetricRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Archives a CustomMetric on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomMetric to archive.
        /// Example format: properties/1234/customMetrics/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ArchiveCustomMetricAsync(string name, st::CancellationToken cancellationToken) =>
            ArchiveCustomMetricAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives a CustomMetric on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomMetric to archive.
        /// Example format: properties/1234/customMetrics/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ArchiveCustomMetric(CustomMetricName name, gaxgrpc::CallSettings callSettings = null) =>
            ArchiveCustomMetric(new ArchiveCustomMetricRequest
            {
                CustomMetricName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Archives a CustomMetric on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomMetric to archive.
        /// Example format: properties/1234/customMetrics/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ArchiveCustomMetricAsync(CustomMetricName name, gaxgrpc::CallSettings callSettings = null) =>
            ArchiveCustomMetricAsync(new ArchiveCustomMetricRequest
            {
                CustomMetricName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Archives a CustomMetric on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomMetric to archive.
        /// Example format: properties/1234/customMetrics/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ArchiveCustomMetricAsync(CustomMetricName name, st::CancellationToken cancellationToken) =>
            ArchiveCustomMetricAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single CustomMetric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomMetric GetCustomMetric(GetCustomMetricRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single CustomMetric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomMetric> GetCustomMetricAsync(GetCustomMetricRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single CustomMetric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomMetric> GetCustomMetricAsync(GetCustomMetricRequest request, st::CancellationToken cancellationToken) =>
            GetCustomMetricAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single CustomMetric.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomMetric to get.
        /// Example format: properties/1234/customMetrics/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomMetric GetCustomMetric(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomMetric(new GetCustomMetricRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single CustomMetric.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomMetric to get.
        /// Example format: properties/1234/customMetrics/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomMetric> GetCustomMetricAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomMetricAsync(new GetCustomMetricRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single CustomMetric.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomMetric to get.
        /// Example format: properties/1234/customMetrics/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomMetric> GetCustomMetricAsync(string name, st::CancellationToken cancellationToken) =>
            GetCustomMetricAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single CustomMetric.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomMetric to get.
        /// Example format: properties/1234/customMetrics/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomMetric GetCustomMetric(CustomMetricName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomMetric(new GetCustomMetricRequest
            {
                CustomMetricName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single CustomMetric.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomMetric to get.
        /// Example format: properties/1234/customMetrics/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomMetric> GetCustomMetricAsync(CustomMetricName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomMetricAsync(new GetCustomMetricRequest
            {
                CustomMetricName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single CustomMetric.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomMetric to get.
        /// Example format: properties/1234/customMetrics/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomMetric> GetCustomMetricAsync(CustomMetricName name, st::CancellationToken cancellationToken) =>
            GetCustomMetricAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the singleton data retention settings for this property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataRetentionSettings GetDataRetentionSettings(GetDataRetentionSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the singleton data retention settings for this property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataRetentionSettings> GetDataRetentionSettingsAsync(GetDataRetentionSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the singleton data retention settings for this property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataRetentionSettings> GetDataRetentionSettingsAsync(GetDataRetentionSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetDataRetentionSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the singleton data retention settings for this property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings to lookup.
        /// Format:
        /// properties/{property}/dataRetentionSettings
        /// Example: "properties/1000/dataRetentionSettings"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataRetentionSettings GetDataRetentionSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataRetentionSettings(new GetDataRetentionSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the singleton data retention settings for this property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings to lookup.
        /// Format:
        /// properties/{property}/dataRetentionSettings
        /// Example: "properties/1000/dataRetentionSettings"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataRetentionSettings> GetDataRetentionSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataRetentionSettingsAsync(new GetDataRetentionSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the singleton data retention settings for this property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings to lookup.
        /// Format:
        /// properties/{property}/dataRetentionSettings
        /// Example: "properties/1000/dataRetentionSettings"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataRetentionSettings> GetDataRetentionSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataRetentionSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the singleton data retention settings for this property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings to lookup.
        /// Format:
        /// properties/{property}/dataRetentionSettings
        /// Example: "properties/1000/dataRetentionSettings"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataRetentionSettings GetDataRetentionSettings(DataRetentionSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataRetentionSettings(new GetDataRetentionSettingsRequest
            {
                DataRetentionSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the singleton data retention settings for this property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings to lookup.
        /// Format:
        /// properties/{property}/dataRetentionSettings
        /// Example: "properties/1000/dataRetentionSettings"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataRetentionSettings> GetDataRetentionSettingsAsync(DataRetentionSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataRetentionSettingsAsync(new GetDataRetentionSettingsRequest
            {
                DataRetentionSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the singleton data retention settings for this property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings to lookup.
        /// Format:
        /// properties/{property}/dataRetentionSettings
        /// Example: "properties/1000/dataRetentionSettings"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataRetentionSettings> GetDataRetentionSettingsAsync(DataRetentionSettingsName name, st::CancellationToken cancellationToken) =>
            GetDataRetentionSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the singleton data retention settings for this property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataRetentionSettings UpdateDataRetentionSettings(UpdateDataRetentionSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the singleton data retention settings for this property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataRetentionSettings> UpdateDataRetentionSettingsAsync(UpdateDataRetentionSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the singleton data retention settings for this property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataRetentionSettings> UpdateDataRetentionSettingsAsync(UpdateDataRetentionSettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataRetentionSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the singleton data retention settings for this property.
        /// </summary>
        /// <param name="dataRetentionSettings">
        /// Required. The settings to update.
        /// The `name` field is used to identify the settings to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake
        /// case (e.g., "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataRetentionSettings UpdateDataRetentionSettings(DataRetentionSettings dataRetentionSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataRetentionSettings(new UpdateDataRetentionSettingsRequest
            {
                DataRetentionSettings = gax::GaxPreconditions.CheckNotNull(dataRetentionSettings, nameof(dataRetentionSettings)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the singleton data retention settings for this property.
        /// </summary>
        /// <param name="dataRetentionSettings">
        /// Required. The settings to update.
        /// The `name` field is used to identify the settings to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake
        /// case (e.g., "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataRetentionSettings> UpdateDataRetentionSettingsAsync(DataRetentionSettings dataRetentionSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataRetentionSettingsAsync(new UpdateDataRetentionSettingsRequest
            {
                DataRetentionSettings = gax::GaxPreconditions.CheckNotNull(dataRetentionSettings, nameof(dataRetentionSettings)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the singleton data retention settings for this property.
        /// </summary>
        /// <param name="dataRetentionSettings">
        /// Required. The settings to update.
        /// The `name` field is used to identify the settings to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake
        /// case (e.g., "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataRetentionSettings> UpdateDataRetentionSettingsAsync(DataRetentionSettings dataRetentionSettings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataRetentionSettingsAsync(dataRetentionSettings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DataStream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataStream CreateDataStream(CreateDataStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a DataStream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStream> CreateDataStreamAsync(CreateDataStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a DataStream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStream> CreateDataStreamAsync(CreateDataStreamRequest request, st::CancellationToken cancellationToken) =>
            CreateDataStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DataStream.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="dataStream">
        /// Required. The DataStream to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataStream CreateDataStream(string parent, DataStream dataStream, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataStream(new CreateDataStreamRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataStream = gax::GaxPreconditions.CheckNotNull(dataStream, nameof(dataStream)),
            }, callSettings);

        /// <summary>
        /// Creates a DataStream.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="dataStream">
        /// Required. The DataStream to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStream> CreateDataStreamAsync(string parent, DataStream dataStream, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataStreamAsync(new CreateDataStreamRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataStream = gax::GaxPreconditions.CheckNotNull(dataStream, nameof(dataStream)),
            }, callSettings);

        /// <summary>
        /// Creates a DataStream.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="dataStream">
        /// Required. The DataStream to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStream> CreateDataStreamAsync(string parent, DataStream dataStream, st::CancellationToken cancellationToken) =>
            CreateDataStreamAsync(parent, dataStream, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DataStream.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="dataStream">
        /// Required. The DataStream to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataStream CreateDataStream(PropertyName parent, DataStream dataStream, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataStream(new CreateDataStreamRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataStream = gax::GaxPreconditions.CheckNotNull(dataStream, nameof(dataStream)),
            }, callSettings);

        /// <summary>
        /// Creates a DataStream.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="dataStream">
        /// Required. The DataStream to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStream> CreateDataStreamAsync(PropertyName parent, DataStream dataStream, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataStreamAsync(new CreateDataStreamRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataStream = gax::GaxPreconditions.CheckNotNull(dataStream, nameof(dataStream)),
            }, callSettings);

        /// <summary>
        /// Creates a DataStream.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="dataStream">
        /// Required. The DataStream to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStream> CreateDataStreamAsync(PropertyName parent, DataStream dataStream, st::CancellationToken cancellationToken) =>
            CreateDataStreamAsync(parent, dataStream, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DataStream on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataStream(DeleteDataStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a DataStream on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataStreamAsync(DeleteDataStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a DataStream on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataStreamAsync(DeleteDataStreamRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DataStream on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataStream to delete.
        /// Example format: properties/1234/dataStreams/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataStream(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataStream(new DeleteDataStreamRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataStream on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataStream to delete.
        /// Example format: properties/1234/dataStreams/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataStreamAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataStreamAsync(new DeleteDataStreamRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataStream on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataStream to delete.
        /// Example format: properties/1234/dataStreams/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataStreamAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDataStreamAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DataStream on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataStream to delete.
        /// Example format: properties/1234/dataStreams/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataStream(DataStreamName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataStream(new DeleteDataStreamRequest
            {
                DataStreamName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataStream on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataStream to delete.
        /// Example format: properties/1234/dataStreams/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataStreamAsync(DataStreamName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataStreamAsync(new DeleteDataStreamRequest
            {
                DataStreamName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataStream on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataStream to delete.
        /// Example format: properties/1234/dataStreams/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataStreamAsync(DataStreamName name, st::CancellationToken cancellationToken) =>
            DeleteDataStreamAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a DataStream on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataStream UpdateDataStream(UpdateDataStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a DataStream on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStream> UpdateDataStreamAsync(UpdateDataStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a DataStream on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStream> UpdateDataStreamAsync(UpdateDataStreamRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a DataStream on a property.
        /// </summary>
        /// <param name="dataStream">
        /// The DataStream to update
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Omitted fields will not be
        /// updated. To replace the entire entity, use one path with the string "*" to
        /// match all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataStream UpdateDataStream(DataStream dataStream, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataStream(new UpdateDataStreamRequest
            {
                DataStream = dataStream,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a DataStream on a property.
        /// </summary>
        /// <param name="dataStream">
        /// The DataStream to update
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Omitted fields will not be
        /// updated. To replace the entire entity, use one path with the string "*" to
        /// match all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStream> UpdateDataStreamAsync(DataStream dataStream, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataStreamAsync(new UpdateDataStreamRequest
            {
                DataStream = dataStream,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a DataStream on a property.
        /// </summary>
        /// <param name="dataStream">
        /// The DataStream to update
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Omitted fields will not be
        /// updated. To replace the entire entity, use one path with the string "*" to
        /// match all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStream> UpdateDataStreamAsync(DataStream dataStream, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataStreamAsync(dataStream, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists DataStreams on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataStream"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataStreamsResponse, DataStream> ListDataStreams(ListDataStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataStreams on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataStream"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataStreamsResponse, DataStream> ListDataStreamsAsync(ListDataStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataStreams on a property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
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
        /// <returns>A pageable sequence of <see cref="DataStream"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataStreamsResponse, DataStream> ListDataStreams(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataStreamsRequest request = new ListDataStreamsRequest
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
            return ListDataStreams(request, callSettings);
        }

        /// <summary>
        /// Lists DataStreams on a property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataStream"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataStreamsResponse, DataStream> ListDataStreamsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataStreamsRequest request = new ListDataStreamsRequest
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
            return ListDataStreamsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DataStreams on a property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
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
        /// <returns>A pageable sequence of <see cref="DataStream"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataStreamsResponse, DataStream> ListDataStreams(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataStreamsRequest request = new ListDataStreamsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataStreams(request, callSettings);
        }

        /// <summary>
        /// Lists DataStreams on a property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataStream"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataStreamsResponse, DataStream> ListDataStreamsAsync(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataStreamsRequest request = new ListDataStreamsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataStreamsAsync(request, callSettings);
        }

        /// <summary>
        /// Lookup for a single DataStream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataStream GetDataStream(GetDataStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single DataStream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStream> GetDataStreamAsync(GetDataStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single DataStream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStream> GetDataStreamAsync(GetDataStreamRequest request, st::CancellationToken cancellationToken) =>
            GetDataStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single DataStream.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataStream to get.
        /// Example format: properties/1234/dataStreams/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataStream GetDataStream(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataStream(new GetDataStreamRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single DataStream.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataStream to get.
        /// Example format: properties/1234/dataStreams/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStream> GetDataStreamAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataStreamAsync(new GetDataStreamRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single DataStream.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataStream to get.
        /// Example format: properties/1234/dataStreams/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStream> GetDataStreamAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataStreamAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single DataStream.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataStream to get.
        /// Example format: properties/1234/dataStreams/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataStream GetDataStream(DataStreamName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataStream(new GetDataStreamRequest
            {
                DataStreamName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single DataStream.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataStream to get.
        /// Example format: properties/1234/dataStreams/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStream> GetDataStreamAsync(DataStreamName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataStreamAsync(new GetDataStreamRequest
            {
                DataStreamName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single DataStream.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataStream to get.
        /// Example format: properties/1234/dataStreams/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStream> GetDataStreamAsync(DataStreamName name, st::CancellationToken cancellationToken) =>
            GetDataStreamAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a customized report of data access records. The report provides
        /// records of each time a user reads Google Analytics reporting data. Access
        /// records are retained for up to 2 years.
        /// 
        /// Data Access Reports can be requested for a property. Reports may be
        /// requested for any property, but dimensions that aren't related to quota can
        /// only be requested on Google Analytics 360 properties. This method is only
        /// available to Administrators.
        /// 
        /// These data access records include GA4 UI Reporting, GA4 UI Explorations,
        /// GA4 Data API, and other products like Firebase &amp; Admob that can retrieve
        /// data from Google Analytics through a linkage. These records don't include
        /// property configuration changes like adding a stream or changing a
        /// property's time zone. For configuration change history, see
        /// [searchChangeHistoryEvents](https://developers.google.com/analytics/devguides/config/admin/v1/rest/v1alpha/accounts/searchChangeHistoryEvents).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunAccessReportResponse RunAccessReport(RunAccessReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a customized report of data access records. The report provides
        /// records of each time a user reads Google Analytics reporting data. Access
        /// records are retained for up to 2 years.
        /// 
        /// Data Access Reports can be requested for a property. Reports may be
        /// requested for any property, but dimensions that aren't related to quota can
        /// only be requested on Google Analytics 360 properties. This method is only
        /// available to Administrators.
        /// 
        /// These data access records include GA4 UI Reporting, GA4 UI Explorations,
        /// GA4 Data API, and other products like Firebase &amp; Admob that can retrieve
        /// data from Google Analytics through a linkage. These records don't include
        /// property configuration changes like adding a stream or changing a
        /// property's time zone. For configuration change history, see
        /// [searchChangeHistoryEvents](https://developers.google.com/analytics/devguides/config/admin/v1/rest/v1alpha/accounts/searchChangeHistoryEvents).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunAccessReportResponse> RunAccessReportAsync(RunAccessReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a customized report of data access records. The report provides
        /// records of each time a user reads Google Analytics reporting data. Access
        /// records are retained for up to 2 years.
        /// 
        /// Data Access Reports can be requested for a property. Reports may be
        /// requested for any property, but dimensions that aren't related to quota can
        /// only be requested on Google Analytics 360 properties. This method is only
        /// available to Administrators.
        /// 
        /// These data access records include GA4 UI Reporting, GA4 UI Explorations,
        /// GA4 Data API, and other products like Firebase &amp; Admob that can retrieve
        /// data from Google Analytics through a linkage. These records don't include
        /// property configuration changes like adding a stream or changing a
        /// property's time zone. For configuration change history, see
        /// [searchChangeHistoryEvents](https://developers.google.com/analytics/devguides/config/admin/v1/rest/v1alpha/accounts/searchChangeHistoryEvents).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunAccessReportResponse> RunAccessReportAsync(RunAccessReportRequest request, st::CancellationToken cancellationToken) =>
            RunAccessReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AnalyticsAdminService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service Interface for the Analytics Admin API (GA4).
    /// </remarks>
    public sealed partial class AnalyticsAdminServiceClientImpl : AnalyticsAdminServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAccountRequest, Account> _callGetAccount;

        private readonly gaxgrpc::ApiCall<ListAccountsRequest, ListAccountsResponse> _callListAccounts;

        private readonly gaxgrpc::ApiCall<DeleteAccountRequest, wkt::Empty> _callDeleteAccount;

        private readonly gaxgrpc::ApiCall<UpdateAccountRequest, Account> _callUpdateAccount;

        private readonly gaxgrpc::ApiCall<ProvisionAccountTicketRequest, ProvisionAccountTicketResponse> _callProvisionAccountTicket;

        private readonly gaxgrpc::ApiCall<ListAccountSummariesRequest, ListAccountSummariesResponse> _callListAccountSummaries;

        private readonly gaxgrpc::ApiCall<GetPropertyRequest, Property> _callGetProperty;

        private readonly gaxgrpc::ApiCall<ListPropertiesRequest, ListPropertiesResponse> _callListProperties;

        private readonly gaxgrpc::ApiCall<CreatePropertyRequest, Property> _callCreateProperty;

        private readonly gaxgrpc::ApiCall<DeletePropertyRequest, Property> _callDeleteProperty;

        private readonly gaxgrpc::ApiCall<UpdatePropertyRequest, Property> _callUpdateProperty;

        private readonly gaxgrpc::ApiCall<CreateFirebaseLinkRequest, FirebaseLink> _callCreateFirebaseLink;

        private readonly gaxgrpc::ApiCall<DeleteFirebaseLinkRequest, wkt::Empty> _callDeleteFirebaseLink;

        private readonly gaxgrpc::ApiCall<ListFirebaseLinksRequest, ListFirebaseLinksResponse> _callListFirebaseLinks;

        private readonly gaxgrpc::ApiCall<CreateGoogleAdsLinkRequest, GoogleAdsLink> _callCreateGoogleAdsLink;

        private readonly gaxgrpc::ApiCall<UpdateGoogleAdsLinkRequest, GoogleAdsLink> _callUpdateGoogleAdsLink;

        private readonly gaxgrpc::ApiCall<DeleteGoogleAdsLinkRequest, wkt::Empty> _callDeleteGoogleAdsLink;

        private readonly gaxgrpc::ApiCall<ListGoogleAdsLinksRequest, ListGoogleAdsLinksResponse> _callListGoogleAdsLinks;

        private readonly gaxgrpc::ApiCall<GetDataSharingSettingsRequest, DataSharingSettings> _callGetDataSharingSettings;

        private readonly gaxgrpc::ApiCall<GetMeasurementProtocolSecretRequest, MeasurementProtocolSecret> _callGetMeasurementProtocolSecret;

        private readonly gaxgrpc::ApiCall<ListMeasurementProtocolSecretsRequest, ListMeasurementProtocolSecretsResponse> _callListMeasurementProtocolSecrets;

        private readonly gaxgrpc::ApiCall<CreateMeasurementProtocolSecretRequest, MeasurementProtocolSecret> _callCreateMeasurementProtocolSecret;

        private readonly gaxgrpc::ApiCall<DeleteMeasurementProtocolSecretRequest, wkt::Empty> _callDeleteMeasurementProtocolSecret;

        private readonly gaxgrpc::ApiCall<UpdateMeasurementProtocolSecretRequest, MeasurementProtocolSecret> _callUpdateMeasurementProtocolSecret;

        private readonly gaxgrpc::ApiCall<AcknowledgeUserDataCollectionRequest, AcknowledgeUserDataCollectionResponse> _callAcknowledgeUserDataCollection;

        private readonly gaxgrpc::ApiCall<SearchChangeHistoryEventsRequest, SearchChangeHistoryEventsResponse> _callSearchChangeHistoryEvents;

        private readonly gaxgrpc::ApiCall<CreateConversionEventRequest, ConversionEvent> _callCreateConversionEvent;

        private readonly gaxgrpc::ApiCall<UpdateConversionEventRequest, ConversionEvent> _callUpdateConversionEvent;

        private readonly gaxgrpc::ApiCall<GetConversionEventRequest, ConversionEvent> _callGetConversionEvent;

        private readonly gaxgrpc::ApiCall<DeleteConversionEventRequest, wkt::Empty> _callDeleteConversionEvent;

        private readonly gaxgrpc::ApiCall<ListConversionEventsRequest, ListConversionEventsResponse> _callListConversionEvents;

        private readonly gaxgrpc::ApiCall<CreateKeyEventRequest, KeyEvent> _callCreateKeyEvent;

        private readonly gaxgrpc::ApiCall<UpdateKeyEventRequest, KeyEvent> _callUpdateKeyEvent;

        private readonly gaxgrpc::ApiCall<GetKeyEventRequest, KeyEvent> _callGetKeyEvent;

        private readonly gaxgrpc::ApiCall<DeleteKeyEventRequest, wkt::Empty> _callDeleteKeyEvent;

        private readonly gaxgrpc::ApiCall<ListKeyEventsRequest, ListKeyEventsResponse> _callListKeyEvents;

        private readonly gaxgrpc::ApiCall<CreateCustomDimensionRequest, CustomDimension> _callCreateCustomDimension;

        private readonly gaxgrpc::ApiCall<UpdateCustomDimensionRequest, CustomDimension> _callUpdateCustomDimension;

        private readonly gaxgrpc::ApiCall<ListCustomDimensionsRequest, ListCustomDimensionsResponse> _callListCustomDimensions;

        private readonly gaxgrpc::ApiCall<ArchiveCustomDimensionRequest, wkt::Empty> _callArchiveCustomDimension;

        private readonly gaxgrpc::ApiCall<GetCustomDimensionRequest, CustomDimension> _callGetCustomDimension;

        private readonly gaxgrpc::ApiCall<CreateCustomMetricRequest, CustomMetric> _callCreateCustomMetric;

        private readonly gaxgrpc::ApiCall<UpdateCustomMetricRequest, CustomMetric> _callUpdateCustomMetric;

        private readonly gaxgrpc::ApiCall<ListCustomMetricsRequest, ListCustomMetricsResponse> _callListCustomMetrics;

        private readonly gaxgrpc::ApiCall<ArchiveCustomMetricRequest, wkt::Empty> _callArchiveCustomMetric;

        private readonly gaxgrpc::ApiCall<GetCustomMetricRequest, CustomMetric> _callGetCustomMetric;

        private readonly gaxgrpc::ApiCall<GetDataRetentionSettingsRequest, DataRetentionSettings> _callGetDataRetentionSettings;

        private readonly gaxgrpc::ApiCall<UpdateDataRetentionSettingsRequest, DataRetentionSettings> _callUpdateDataRetentionSettings;

        private readonly gaxgrpc::ApiCall<CreateDataStreamRequest, DataStream> _callCreateDataStream;

        private readonly gaxgrpc::ApiCall<DeleteDataStreamRequest, wkt::Empty> _callDeleteDataStream;

        private readonly gaxgrpc::ApiCall<UpdateDataStreamRequest, DataStream> _callUpdateDataStream;

        private readonly gaxgrpc::ApiCall<ListDataStreamsRequest, ListDataStreamsResponse> _callListDataStreams;

        private readonly gaxgrpc::ApiCall<GetDataStreamRequest, DataStream> _callGetDataStream;

        private readonly gaxgrpc::ApiCall<RunAccessReportRequest, RunAccessReportResponse> _callRunAccessReport;

        /// <summary>
        /// Constructs a client wrapper for the AnalyticsAdminService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AnalyticsAdminServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AnalyticsAdminServiceClientImpl(AnalyticsAdminService.AnalyticsAdminServiceClient grpcClient, AnalyticsAdminServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AnalyticsAdminServiceSettings effectiveSettings = settings ?? AnalyticsAdminServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetAccount = clientHelper.BuildApiCall<GetAccountRequest, Account>("GetAccount", grpcClient.GetAccountAsync, grpcClient.GetAccount, effectiveSettings.GetAccountSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAccount);
            Modify_GetAccountApiCall(ref _callGetAccount);
            _callListAccounts = clientHelper.BuildApiCall<ListAccountsRequest, ListAccountsResponse>("ListAccounts", grpcClient.ListAccountsAsync, grpcClient.ListAccounts, effectiveSettings.ListAccountsSettings);
            Modify_ApiCall(ref _callListAccounts);
            Modify_ListAccountsApiCall(ref _callListAccounts);
            _callDeleteAccount = clientHelper.BuildApiCall<DeleteAccountRequest, wkt::Empty>("DeleteAccount", grpcClient.DeleteAccountAsync, grpcClient.DeleteAccount, effectiveSettings.DeleteAccountSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAccount);
            Modify_DeleteAccountApiCall(ref _callDeleteAccount);
            _callUpdateAccount = clientHelper.BuildApiCall<UpdateAccountRequest, Account>("UpdateAccount", grpcClient.UpdateAccountAsync, grpcClient.UpdateAccount, effectiveSettings.UpdateAccountSettings).WithGoogleRequestParam("account.name", request => request.Account?.Name);
            Modify_ApiCall(ref _callUpdateAccount);
            Modify_UpdateAccountApiCall(ref _callUpdateAccount);
            _callProvisionAccountTicket = clientHelper.BuildApiCall<ProvisionAccountTicketRequest, ProvisionAccountTicketResponse>("ProvisionAccountTicket", grpcClient.ProvisionAccountTicketAsync, grpcClient.ProvisionAccountTicket, effectiveSettings.ProvisionAccountTicketSettings);
            Modify_ApiCall(ref _callProvisionAccountTicket);
            Modify_ProvisionAccountTicketApiCall(ref _callProvisionAccountTicket);
            _callListAccountSummaries = clientHelper.BuildApiCall<ListAccountSummariesRequest, ListAccountSummariesResponse>("ListAccountSummaries", grpcClient.ListAccountSummariesAsync, grpcClient.ListAccountSummaries, effectiveSettings.ListAccountSummariesSettings);
            Modify_ApiCall(ref _callListAccountSummaries);
            Modify_ListAccountSummariesApiCall(ref _callListAccountSummaries);
            _callGetProperty = clientHelper.BuildApiCall<GetPropertyRequest, Property>("GetProperty", grpcClient.GetPropertyAsync, grpcClient.GetProperty, effectiveSettings.GetPropertySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProperty);
            Modify_GetPropertyApiCall(ref _callGetProperty);
            _callListProperties = clientHelper.BuildApiCall<ListPropertiesRequest, ListPropertiesResponse>("ListProperties", grpcClient.ListPropertiesAsync, grpcClient.ListProperties, effectiveSettings.ListPropertiesSettings);
            Modify_ApiCall(ref _callListProperties);
            Modify_ListPropertiesApiCall(ref _callListProperties);
            _callCreateProperty = clientHelper.BuildApiCall<CreatePropertyRequest, Property>("CreateProperty", grpcClient.CreatePropertyAsync, grpcClient.CreateProperty, effectiveSettings.CreatePropertySettings);
            Modify_ApiCall(ref _callCreateProperty);
            Modify_CreatePropertyApiCall(ref _callCreateProperty);
            _callDeleteProperty = clientHelper.BuildApiCall<DeletePropertyRequest, Property>("DeleteProperty", grpcClient.DeletePropertyAsync, grpcClient.DeleteProperty, effectiveSettings.DeletePropertySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteProperty);
            Modify_DeletePropertyApiCall(ref _callDeleteProperty);
            _callUpdateProperty = clientHelper.BuildApiCall<UpdatePropertyRequest, Property>("UpdateProperty", grpcClient.UpdatePropertyAsync, grpcClient.UpdateProperty, effectiveSettings.UpdatePropertySettings).WithGoogleRequestParam("property.name", request => request.Property?.Name);
            Modify_ApiCall(ref _callUpdateProperty);
            Modify_UpdatePropertyApiCall(ref _callUpdateProperty);
            _callCreateFirebaseLink = clientHelper.BuildApiCall<CreateFirebaseLinkRequest, FirebaseLink>("CreateFirebaseLink", grpcClient.CreateFirebaseLinkAsync, grpcClient.CreateFirebaseLink, effectiveSettings.CreateFirebaseLinkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFirebaseLink);
            Modify_CreateFirebaseLinkApiCall(ref _callCreateFirebaseLink);
            _callDeleteFirebaseLink = clientHelper.BuildApiCall<DeleteFirebaseLinkRequest, wkt::Empty>("DeleteFirebaseLink", grpcClient.DeleteFirebaseLinkAsync, grpcClient.DeleteFirebaseLink, effectiveSettings.DeleteFirebaseLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFirebaseLink);
            Modify_DeleteFirebaseLinkApiCall(ref _callDeleteFirebaseLink);
            _callListFirebaseLinks = clientHelper.BuildApiCall<ListFirebaseLinksRequest, ListFirebaseLinksResponse>("ListFirebaseLinks", grpcClient.ListFirebaseLinksAsync, grpcClient.ListFirebaseLinks, effectiveSettings.ListFirebaseLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFirebaseLinks);
            Modify_ListFirebaseLinksApiCall(ref _callListFirebaseLinks);
            _callCreateGoogleAdsLink = clientHelper.BuildApiCall<CreateGoogleAdsLinkRequest, GoogleAdsLink>("CreateGoogleAdsLink", grpcClient.CreateGoogleAdsLinkAsync, grpcClient.CreateGoogleAdsLink, effectiveSettings.CreateGoogleAdsLinkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGoogleAdsLink);
            Modify_CreateGoogleAdsLinkApiCall(ref _callCreateGoogleAdsLink);
            _callUpdateGoogleAdsLink = clientHelper.BuildApiCall<UpdateGoogleAdsLinkRequest, GoogleAdsLink>("UpdateGoogleAdsLink", grpcClient.UpdateGoogleAdsLinkAsync, grpcClient.UpdateGoogleAdsLink, effectiveSettings.UpdateGoogleAdsLinkSettings).WithGoogleRequestParam("google_ads_link.name", request => request.GoogleAdsLink?.Name);
            Modify_ApiCall(ref _callUpdateGoogleAdsLink);
            Modify_UpdateGoogleAdsLinkApiCall(ref _callUpdateGoogleAdsLink);
            _callDeleteGoogleAdsLink = clientHelper.BuildApiCall<DeleteGoogleAdsLinkRequest, wkt::Empty>("DeleteGoogleAdsLink", grpcClient.DeleteGoogleAdsLinkAsync, grpcClient.DeleteGoogleAdsLink, effectiveSettings.DeleteGoogleAdsLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGoogleAdsLink);
            Modify_DeleteGoogleAdsLinkApiCall(ref _callDeleteGoogleAdsLink);
            _callListGoogleAdsLinks = clientHelper.BuildApiCall<ListGoogleAdsLinksRequest, ListGoogleAdsLinksResponse>("ListGoogleAdsLinks", grpcClient.ListGoogleAdsLinksAsync, grpcClient.ListGoogleAdsLinks, effectiveSettings.ListGoogleAdsLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGoogleAdsLinks);
            Modify_ListGoogleAdsLinksApiCall(ref _callListGoogleAdsLinks);
            _callGetDataSharingSettings = clientHelper.BuildApiCall<GetDataSharingSettingsRequest, DataSharingSettings>("GetDataSharingSettings", grpcClient.GetDataSharingSettingsAsync, grpcClient.GetDataSharingSettings, effectiveSettings.GetDataSharingSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataSharingSettings);
            Modify_GetDataSharingSettingsApiCall(ref _callGetDataSharingSettings);
            _callGetMeasurementProtocolSecret = clientHelper.BuildApiCall<GetMeasurementProtocolSecretRequest, MeasurementProtocolSecret>("GetMeasurementProtocolSecret", grpcClient.GetMeasurementProtocolSecretAsync, grpcClient.GetMeasurementProtocolSecret, effectiveSettings.GetMeasurementProtocolSecretSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMeasurementProtocolSecret);
            Modify_GetMeasurementProtocolSecretApiCall(ref _callGetMeasurementProtocolSecret);
            _callListMeasurementProtocolSecrets = clientHelper.BuildApiCall<ListMeasurementProtocolSecretsRequest, ListMeasurementProtocolSecretsResponse>("ListMeasurementProtocolSecrets", grpcClient.ListMeasurementProtocolSecretsAsync, grpcClient.ListMeasurementProtocolSecrets, effectiveSettings.ListMeasurementProtocolSecretsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMeasurementProtocolSecrets);
            Modify_ListMeasurementProtocolSecretsApiCall(ref _callListMeasurementProtocolSecrets);
            _callCreateMeasurementProtocolSecret = clientHelper.BuildApiCall<CreateMeasurementProtocolSecretRequest, MeasurementProtocolSecret>("CreateMeasurementProtocolSecret", grpcClient.CreateMeasurementProtocolSecretAsync, grpcClient.CreateMeasurementProtocolSecret, effectiveSettings.CreateMeasurementProtocolSecretSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMeasurementProtocolSecret);
            Modify_CreateMeasurementProtocolSecretApiCall(ref _callCreateMeasurementProtocolSecret);
            _callDeleteMeasurementProtocolSecret = clientHelper.BuildApiCall<DeleteMeasurementProtocolSecretRequest, wkt::Empty>("DeleteMeasurementProtocolSecret", grpcClient.DeleteMeasurementProtocolSecretAsync, grpcClient.DeleteMeasurementProtocolSecret, effectiveSettings.DeleteMeasurementProtocolSecretSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMeasurementProtocolSecret);
            Modify_DeleteMeasurementProtocolSecretApiCall(ref _callDeleteMeasurementProtocolSecret);
            _callUpdateMeasurementProtocolSecret = clientHelper.BuildApiCall<UpdateMeasurementProtocolSecretRequest, MeasurementProtocolSecret>("UpdateMeasurementProtocolSecret", grpcClient.UpdateMeasurementProtocolSecretAsync, grpcClient.UpdateMeasurementProtocolSecret, effectiveSettings.UpdateMeasurementProtocolSecretSettings).WithGoogleRequestParam("measurement_protocol_secret.name", request => request.MeasurementProtocolSecret?.Name);
            Modify_ApiCall(ref _callUpdateMeasurementProtocolSecret);
            Modify_UpdateMeasurementProtocolSecretApiCall(ref _callUpdateMeasurementProtocolSecret);
            _callAcknowledgeUserDataCollection = clientHelper.BuildApiCall<AcknowledgeUserDataCollectionRequest, AcknowledgeUserDataCollectionResponse>("AcknowledgeUserDataCollection", grpcClient.AcknowledgeUserDataCollectionAsync, grpcClient.AcknowledgeUserDataCollection, effectiveSettings.AcknowledgeUserDataCollectionSettings).WithGoogleRequestParam("property", request => request.Property);
            Modify_ApiCall(ref _callAcknowledgeUserDataCollection);
            Modify_AcknowledgeUserDataCollectionApiCall(ref _callAcknowledgeUserDataCollection);
            _callSearchChangeHistoryEvents = clientHelper.BuildApiCall<SearchChangeHistoryEventsRequest, SearchChangeHistoryEventsResponse>("SearchChangeHistoryEvents", grpcClient.SearchChangeHistoryEventsAsync, grpcClient.SearchChangeHistoryEvents, effectiveSettings.SearchChangeHistoryEventsSettings).WithGoogleRequestParam("account", request => request.Account);
            Modify_ApiCall(ref _callSearchChangeHistoryEvents);
            Modify_SearchChangeHistoryEventsApiCall(ref _callSearchChangeHistoryEvents);
#pragma warning disable CS0612
            _callCreateConversionEvent = clientHelper.BuildApiCall<CreateConversionEventRequest, ConversionEvent>("CreateConversionEvent", grpcClient.CreateConversionEventAsync, grpcClient.CreateConversionEvent, effectiveSettings.CreateConversionEventSettings).WithGoogleRequestParam("parent", request => request.Parent);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callCreateConversionEvent);
            Modify_CreateConversionEventApiCall(ref _callCreateConversionEvent);
#pragma warning disable CS0612
            _callUpdateConversionEvent = clientHelper.BuildApiCall<UpdateConversionEventRequest, ConversionEvent>("UpdateConversionEvent", grpcClient.UpdateConversionEventAsync, grpcClient.UpdateConversionEvent, effectiveSettings.UpdateConversionEventSettings).WithGoogleRequestParam("conversion_event.name", request => request.ConversionEvent?.Name);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callUpdateConversionEvent);
            Modify_UpdateConversionEventApiCall(ref _callUpdateConversionEvent);
#pragma warning disable CS0612
            _callGetConversionEvent = clientHelper.BuildApiCall<GetConversionEventRequest, ConversionEvent>("GetConversionEvent", grpcClient.GetConversionEventAsync, grpcClient.GetConversionEvent, effectiveSettings.GetConversionEventSettings).WithGoogleRequestParam("name", request => request.Name);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callGetConversionEvent);
            Modify_GetConversionEventApiCall(ref _callGetConversionEvent);
#pragma warning disable CS0612
            _callDeleteConversionEvent = clientHelper.BuildApiCall<DeleteConversionEventRequest, wkt::Empty>("DeleteConversionEvent", grpcClient.DeleteConversionEventAsync, grpcClient.DeleteConversionEvent, effectiveSettings.DeleteConversionEventSettings).WithGoogleRequestParam("name", request => request.Name);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callDeleteConversionEvent);
            Modify_DeleteConversionEventApiCall(ref _callDeleteConversionEvent);
#pragma warning disable CS0612
            _callListConversionEvents = clientHelper.BuildApiCall<ListConversionEventsRequest, ListConversionEventsResponse>("ListConversionEvents", grpcClient.ListConversionEventsAsync, grpcClient.ListConversionEvents, effectiveSettings.ListConversionEventsSettings).WithGoogleRequestParam("parent", request => request.Parent);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callListConversionEvents);
            Modify_ListConversionEventsApiCall(ref _callListConversionEvents);
            _callCreateKeyEvent = clientHelper.BuildApiCall<CreateKeyEventRequest, KeyEvent>("CreateKeyEvent", grpcClient.CreateKeyEventAsync, grpcClient.CreateKeyEvent, effectiveSettings.CreateKeyEventSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateKeyEvent);
            Modify_CreateKeyEventApiCall(ref _callCreateKeyEvent);
            _callUpdateKeyEvent = clientHelper.BuildApiCall<UpdateKeyEventRequest, KeyEvent>("UpdateKeyEvent", grpcClient.UpdateKeyEventAsync, grpcClient.UpdateKeyEvent, effectiveSettings.UpdateKeyEventSettings).WithGoogleRequestParam("key_event.name", request => request.KeyEvent?.Name);
            Modify_ApiCall(ref _callUpdateKeyEvent);
            Modify_UpdateKeyEventApiCall(ref _callUpdateKeyEvent);
            _callGetKeyEvent = clientHelper.BuildApiCall<GetKeyEventRequest, KeyEvent>("GetKeyEvent", grpcClient.GetKeyEventAsync, grpcClient.GetKeyEvent, effectiveSettings.GetKeyEventSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetKeyEvent);
            Modify_GetKeyEventApiCall(ref _callGetKeyEvent);
            _callDeleteKeyEvent = clientHelper.BuildApiCall<DeleteKeyEventRequest, wkt::Empty>("DeleteKeyEvent", grpcClient.DeleteKeyEventAsync, grpcClient.DeleteKeyEvent, effectiveSettings.DeleteKeyEventSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteKeyEvent);
            Modify_DeleteKeyEventApiCall(ref _callDeleteKeyEvent);
            _callListKeyEvents = clientHelper.BuildApiCall<ListKeyEventsRequest, ListKeyEventsResponse>("ListKeyEvents", grpcClient.ListKeyEventsAsync, grpcClient.ListKeyEvents, effectiveSettings.ListKeyEventsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListKeyEvents);
            Modify_ListKeyEventsApiCall(ref _callListKeyEvents);
            _callCreateCustomDimension = clientHelper.BuildApiCall<CreateCustomDimensionRequest, CustomDimension>("CreateCustomDimension", grpcClient.CreateCustomDimensionAsync, grpcClient.CreateCustomDimension, effectiveSettings.CreateCustomDimensionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCustomDimension);
            Modify_CreateCustomDimensionApiCall(ref _callCreateCustomDimension);
            _callUpdateCustomDimension = clientHelper.BuildApiCall<UpdateCustomDimensionRequest, CustomDimension>("UpdateCustomDimension", grpcClient.UpdateCustomDimensionAsync, grpcClient.UpdateCustomDimension, effectiveSettings.UpdateCustomDimensionSettings).WithGoogleRequestParam("custom_dimension.name", request => request.CustomDimension?.Name);
            Modify_ApiCall(ref _callUpdateCustomDimension);
            Modify_UpdateCustomDimensionApiCall(ref _callUpdateCustomDimension);
            _callListCustomDimensions = clientHelper.BuildApiCall<ListCustomDimensionsRequest, ListCustomDimensionsResponse>("ListCustomDimensions", grpcClient.ListCustomDimensionsAsync, grpcClient.ListCustomDimensions, effectiveSettings.ListCustomDimensionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCustomDimensions);
            Modify_ListCustomDimensionsApiCall(ref _callListCustomDimensions);
            _callArchiveCustomDimension = clientHelper.BuildApiCall<ArchiveCustomDimensionRequest, wkt::Empty>("ArchiveCustomDimension", grpcClient.ArchiveCustomDimensionAsync, grpcClient.ArchiveCustomDimension, effectiveSettings.ArchiveCustomDimensionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callArchiveCustomDimension);
            Modify_ArchiveCustomDimensionApiCall(ref _callArchiveCustomDimension);
            _callGetCustomDimension = clientHelper.BuildApiCall<GetCustomDimensionRequest, CustomDimension>("GetCustomDimension", grpcClient.GetCustomDimensionAsync, grpcClient.GetCustomDimension, effectiveSettings.GetCustomDimensionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCustomDimension);
            Modify_GetCustomDimensionApiCall(ref _callGetCustomDimension);
            _callCreateCustomMetric = clientHelper.BuildApiCall<CreateCustomMetricRequest, CustomMetric>("CreateCustomMetric", grpcClient.CreateCustomMetricAsync, grpcClient.CreateCustomMetric, effectiveSettings.CreateCustomMetricSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCustomMetric);
            Modify_CreateCustomMetricApiCall(ref _callCreateCustomMetric);
            _callUpdateCustomMetric = clientHelper.BuildApiCall<UpdateCustomMetricRequest, CustomMetric>("UpdateCustomMetric", grpcClient.UpdateCustomMetricAsync, grpcClient.UpdateCustomMetric, effectiveSettings.UpdateCustomMetricSettings).WithGoogleRequestParam("custom_metric.name", request => request.CustomMetric?.Name);
            Modify_ApiCall(ref _callUpdateCustomMetric);
            Modify_UpdateCustomMetricApiCall(ref _callUpdateCustomMetric);
            _callListCustomMetrics = clientHelper.BuildApiCall<ListCustomMetricsRequest, ListCustomMetricsResponse>("ListCustomMetrics", grpcClient.ListCustomMetricsAsync, grpcClient.ListCustomMetrics, effectiveSettings.ListCustomMetricsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCustomMetrics);
            Modify_ListCustomMetricsApiCall(ref _callListCustomMetrics);
            _callArchiveCustomMetric = clientHelper.BuildApiCall<ArchiveCustomMetricRequest, wkt::Empty>("ArchiveCustomMetric", grpcClient.ArchiveCustomMetricAsync, grpcClient.ArchiveCustomMetric, effectiveSettings.ArchiveCustomMetricSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callArchiveCustomMetric);
            Modify_ArchiveCustomMetricApiCall(ref _callArchiveCustomMetric);
            _callGetCustomMetric = clientHelper.BuildApiCall<GetCustomMetricRequest, CustomMetric>("GetCustomMetric", grpcClient.GetCustomMetricAsync, grpcClient.GetCustomMetric, effectiveSettings.GetCustomMetricSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCustomMetric);
            Modify_GetCustomMetricApiCall(ref _callGetCustomMetric);
            _callGetDataRetentionSettings = clientHelper.BuildApiCall<GetDataRetentionSettingsRequest, DataRetentionSettings>("GetDataRetentionSettings", grpcClient.GetDataRetentionSettingsAsync, grpcClient.GetDataRetentionSettings, effectiveSettings.GetDataRetentionSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataRetentionSettings);
            Modify_GetDataRetentionSettingsApiCall(ref _callGetDataRetentionSettings);
            _callUpdateDataRetentionSettings = clientHelper.BuildApiCall<UpdateDataRetentionSettingsRequest, DataRetentionSettings>("UpdateDataRetentionSettings", grpcClient.UpdateDataRetentionSettingsAsync, grpcClient.UpdateDataRetentionSettings, effectiveSettings.UpdateDataRetentionSettingsSettings).WithGoogleRequestParam("data_retention_settings.name", request => request.DataRetentionSettings?.Name);
            Modify_ApiCall(ref _callUpdateDataRetentionSettings);
            Modify_UpdateDataRetentionSettingsApiCall(ref _callUpdateDataRetentionSettings);
            _callCreateDataStream = clientHelper.BuildApiCall<CreateDataStreamRequest, DataStream>("CreateDataStream", grpcClient.CreateDataStreamAsync, grpcClient.CreateDataStream, effectiveSettings.CreateDataStreamSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataStream);
            Modify_CreateDataStreamApiCall(ref _callCreateDataStream);
            _callDeleteDataStream = clientHelper.BuildApiCall<DeleteDataStreamRequest, wkt::Empty>("DeleteDataStream", grpcClient.DeleteDataStreamAsync, grpcClient.DeleteDataStream, effectiveSettings.DeleteDataStreamSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataStream);
            Modify_DeleteDataStreamApiCall(ref _callDeleteDataStream);
            _callUpdateDataStream = clientHelper.BuildApiCall<UpdateDataStreamRequest, DataStream>("UpdateDataStream", grpcClient.UpdateDataStreamAsync, grpcClient.UpdateDataStream, effectiveSettings.UpdateDataStreamSettings).WithGoogleRequestParam("data_stream.name", request => request.DataStream?.Name);
            Modify_ApiCall(ref _callUpdateDataStream);
            Modify_UpdateDataStreamApiCall(ref _callUpdateDataStream);
            _callListDataStreams = clientHelper.BuildApiCall<ListDataStreamsRequest, ListDataStreamsResponse>("ListDataStreams", grpcClient.ListDataStreamsAsync, grpcClient.ListDataStreams, effectiveSettings.ListDataStreamsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataStreams);
            Modify_ListDataStreamsApiCall(ref _callListDataStreams);
            _callGetDataStream = clientHelper.BuildApiCall<GetDataStreamRequest, DataStream>("GetDataStream", grpcClient.GetDataStreamAsync, grpcClient.GetDataStream, effectiveSettings.GetDataStreamSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataStream);
            Modify_GetDataStreamApiCall(ref _callGetDataStream);
            _callRunAccessReport = clientHelper.BuildApiCall<RunAccessReportRequest, RunAccessReportResponse>("RunAccessReport", grpcClient.RunAccessReportAsync, grpcClient.RunAccessReport, effectiveSettings.RunAccessReportSettings).WithGoogleRequestParam("entity", request => request.Entity);
            Modify_ApiCall(ref _callRunAccessReport);
            Modify_RunAccessReportApiCall(ref _callRunAccessReport);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAccountApiCall(ref gaxgrpc::ApiCall<GetAccountRequest, Account> call);

        partial void Modify_ListAccountsApiCall(ref gaxgrpc::ApiCall<ListAccountsRequest, ListAccountsResponse> call);

        partial void Modify_DeleteAccountApiCall(ref gaxgrpc::ApiCall<DeleteAccountRequest, wkt::Empty> call);

        partial void Modify_UpdateAccountApiCall(ref gaxgrpc::ApiCall<UpdateAccountRequest, Account> call);

        partial void Modify_ProvisionAccountTicketApiCall(ref gaxgrpc::ApiCall<ProvisionAccountTicketRequest, ProvisionAccountTicketResponse> call);

        partial void Modify_ListAccountSummariesApiCall(ref gaxgrpc::ApiCall<ListAccountSummariesRequest, ListAccountSummariesResponse> call);

        partial void Modify_GetPropertyApiCall(ref gaxgrpc::ApiCall<GetPropertyRequest, Property> call);

        partial void Modify_ListPropertiesApiCall(ref gaxgrpc::ApiCall<ListPropertiesRequest, ListPropertiesResponse> call);

        partial void Modify_CreatePropertyApiCall(ref gaxgrpc::ApiCall<CreatePropertyRequest, Property> call);

        partial void Modify_DeletePropertyApiCall(ref gaxgrpc::ApiCall<DeletePropertyRequest, Property> call);

        partial void Modify_UpdatePropertyApiCall(ref gaxgrpc::ApiCall<UpdatePropertyRequest, Property> call);

        partial void Modify_CreateFirebaseLinkApiCall(ref gaxgrpc::ApiCall<CreateFirebaseLinkRequest, FirebaseLink> call);

        partial void Modify_DeleteFirebaseLinkApiCall(ref gaxgrpc::ApiCall<DeleteFirebaseLinkRequest, wkt::Empty> call);

        partial void Modify_ListFirebaseLinksApiCall(ref gaxgrpc::ApiCall<ListFirebaseLinksRequest, ListFirebaseLinksResponse> call);

        partial void Modify_CreateGoogleAdsLinkApiCall(ref gaxgrpc::ApiCall<CreateGoogleAdsLinkRequest, GoogleAdsLink> call);

        partial void Modify_UpdateGoogleAdsLinkApiCall(ref gaxgrpc::ApiCall<UpdateGoogleAdsLinkRequest, GoogleAdsLink> call);

        partial void Modify_DeleteGoogleAdsLinkApiCall(ref gaxgrpc::ApiCall<DeleteGoogleAdsLinkRequest, wkt::Empty> call);

        partial void Modify_ListGoogleAdsLinksApiCall(ref gaxgrpc::ApiCall<ListGoogleAdsLinksRequest, ListGoogleAdsLinksResponse> call);

        partial void Modify_GetDataSharingSettingsApiCall(ref gaxgrpc::ApiCall<GetDataSharingSettingsRequest, DataSharingSettings> call);

        partial void Modify_GetMeasurementProtocolSecretApiCall(ref gaxgrpc::ApiCall<GetMeasurementProtocolSecretRequest, MeasurementProtocolSecret> call);

        partial void Modify_ListMeasurementProtocolSecretsApiCall(ref gaxgrpc::ApiCall<ListMeasurementProtocolSecretsRequest, ListMeasurementProtocolSecretsResponse> call);

        partial void Modify_CreateMeasurementProtocolSecretApiCall(ref gaxgrpc::ApiCall<CreateMeasurementProtocolSecretRequest, MeasurementProtocolSecret> call);

        partial void Modify_DeleteMeasurementProtocolSecretApiCall(ref gaxgrpc::ApiCall<DeleteMeasurementProtocolSecretRequest, wkt::Empty> call);

        partial void Modify_UpdateMeasurementProtocolSecretApiCall(ref gaxgrpc::ApiCall<UpdateMeasurementProtocolSecretRequest, MeasurementProtocolSecret> call);

        partial void Modify_AcknowledgeUserDataCollectionApiCall(ref gaxgrpc::ApiCall<AcknowledgeUserDataCollectionRequest, AcknowledgeUserDataCollectionResponse> call);

        partial void Modify_SearchChangeHistoryEventsApiCall(ref gaxgrpc::ApiCall<SearchChangeHistoryEventsRequest, SearchChangeHistoryEventsResponse> call);

        partial void Modify_CreateConversionEventApiCall(ref gaxgrpc::ApiCall<CreateConversionEventRequest, ConversionEvent> call);

        partial void Modify_UpdateConversionEventApiCall(ref gaxgrpc::ApiCall<UpdateConversionEventRequest, ConversionEvent> call);

        partial void Modify_GetConversionEventApiCall(ref gaxgrpc::ApiCall<GetConversionEventRequest, ConversionEvent> call);

        partial void Modify_DeleteConversionEventApiCall(ref gaxgrpc::ApiCall<DeleteConversionEventRequest, wkt::Empty> call);

        partial void Modify_ListConversionEventsApiCall(ref gaxgrpc::ApiCall<ListConversionEventsRequest, ListConversionEventsResponse> call);

        partial void Modify_CreateKeyEventApiCall(ref gaxgrpc::ApiCall<CreateKeyEventRequest, KeyEvent> call);

        partial void Modify_UpdateKeyEventApiCall(ref gaxgrpc::ApiCall<UpdateKeyEventRequest, KeyEvent> call);

        partial void Modify_GetKeyEventApiCall(ref gaxgrpc::ApiCall<GetKeyEventRequest, KeyEvent> call);

        partial void Modify_DeleteKeyEventApiCall(ref gaxgrpc::ApiCall<DeleteKeyEventRequest, wkt::Empty> call);

        partial void Modify_ListKeyEventsApiCall(ref gaxgrpc::ApiCall<ListKeyEventsRequest, ListKeyEventsResponse> call);

        partial void Modify_CreateCustomDimensionApiCall(ref gaxgrpc::ApiCall<CreateCustomDimensionRequest, CustomDimension> call);

        partial void Modify_UpdateCustomDimensionApiCall(ref gaxgrpc::ApiCall<UpdateCustomDimensionRequest, CustomDimension> call);

        partial void Modify_ListCustomDimensionsApiCall(ref gaxgrpc::ApiCall<ListCustomDimensionsRequest, ListCustomDimensionsResponse> call);

        partial void Modify_ArchiveCustomDimensionApiCall(ref gaxgrpc::ApiCall<ArchiveCustomDimensionRequest, wkt::Empty> call);

        partial void Modify_GetCustomDimensionApiCall(ref gaxgrpc::ApiCall<GetCustomDimensionRequest, CustomDimension> call);

        partial void Modify_CreateCustomMetricApiCall(ref gaxgrpc::ApiCall<CreateCustomMetricRequest, CustomMetric> call);

        partial void Modify_UpdateCustomMetricApiCall(ref gaxgrpc::ApiCall<UpdateCustomMetricRequest, CustomMetric> call);

        partial void Modify_ListCustomMetricsApiCall(ref gaxgrpc::ApiCall<ListCustomMetricsRequest, ListCustomMetricsResponse> call);

        partial void Modify_ArchiveCustomMetricApiCall(ref gaxgrpc::ApiCall<ArchiveCustomMetricRequest, wkt::Empty> call);

        partial void Modify_GetCustomMetricApiCall(ref gaxgrpc::ApiCall<GetCustomMetricRequest, CustomMetric> call);

        partial void Modify_GetDataRetentionSettingsApiCall(ref gaxgrpc::ApiCall<GetDataRetentionSettingsRequest, DataRetentionSettings> call);

        partial void Modify_UpdateDataRetentionSettingsApiCall(ref gaxgrpc::ApiCall<UpdateDataRetentionSettingsRequest, DataRetentionSettings> call);

        partial void Modify_CreateDataStreamApiCall(ref gaxgrpc::ApiCall<CreateDataStreamRequest, DataStream> call);

        partial void Modify_DeleteDataStreamApiCall(ref gaxgrpc::ApiCall<DeleteDataStreamRequest, wkt::Empty> call);

        partial void Modify_UpdateDataStreamApiCall(ref gaxgrpc::ApiCall<UpdateDataStreamRequest, DataStream> call);

        partial void Modify_ListDataStreamsApiCall(ref gaxgrpc::ApiCall<ListDataStreamsRequest, ListDataStreamsResponse> call);

        partial void Modify_GetDataStreamApiCall(ref gaxgrpc::ApiCall<GetDataStreamRequest, DataStream> call);

        partial void Modify_RunAccessReportApiCall(ref gaxgrpc::ApiCall<RunAccessReportRequest, RunAccessReportResponse> call);

        partial void OnConstruction(AnalyticsAdminService.AnalyticsAdminServiceClient grpcClient, AnalyticsAdminServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AnalyticsAdminService client</summary>
        public override AnalyticsAdminService.AnalyticsAdminServiceClient GrpcClient { get; }

        partial void Modify_GetAccountRequest(ref GetAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAccountsRequest(ref ListAccountsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAccountRequest(ref DeleteAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAccountRequest(ref UpdateAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ProvisionAccountTicketRequest(ref ProvisionAccountTicketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAccountSummariesRequest(ref ListAccountSummariesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPropertyRequest(ref GetPropertyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPropertiesRequest(ref ListPropertiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePropertyRequest(ref CreatePropertyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePropertyRequest(ref DeletePropertyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePropertyRequest(ref UpdatePropertyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFirebaseLinkRequest(ref CreateFirebaseLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFirebaseLinkRequest(ref DeleteFirebaseLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFirebaseLinksRequest(ref ListFirebaseLinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGoogleAdsLinkRequest(ref CreateGoogleAdsLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGoogleAdsLinkRequest(ref UpdateGoogleAdsLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGoogleAdsLinkRequest(ref DeleteGoogleAdsLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGoogleAdsLinksRequest(ref ListGoogleAdsLinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataSharingSettingsRequest(ref GetDataSharingSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMeasurementProtocolSecretRequest(ref GetMeasurementProtocolSecretRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMeasurementProtocolSecretsRequest(ref ListMeasurementProtocolSecretsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMeasurementProtocolSecretRequest(ref CreateMeasurementProtocolSecretRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMeasurementProtocolSecretRequest(ref DeleteMeasurementProtocolSecretRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMeasurementProtocolSecretRequest(ref UpdateMeasurementProtocolSecretRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AcknowledgeUserDataCollectionRequest(ref AcknowledgeUserDataCollectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchChangeHistoryEventsRequest(ref SearchChangeHistoryEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConversionEventRequest(ref CreateConversionEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConversionEventRequest(ref UpdateConversionEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConversionEventRequest(ref GetConversionEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConversionEventRequest(ref DeleteConversionEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConversionEventsRequest(ref ListConversionEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateKeyEventRequest(ref CreateKeyEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateKeyEventRequest(ref UpdateKeyEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetKeyEventRequest(ref GetKeyEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteKeyEventRequest(ref DeleteKeyEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListKeyEventsRequest(ref ListKeyEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCustomDimensionRequest(ref CreateCustomDimensionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCustomDimensionRequest(ref UpdateCustomDimensionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCustomDimensionsRequest(ref ListCustomDimensionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ArchiveCustomDimensionRequest(ref ArchiveCustomDimensionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCustomDimensionRequest(ref GetCustomDimensionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCustomMetricRequest(ref CreateCustomMetricRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCustomMetricRequest(ref UpdateCustomMetricRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCustomMetricsRequest(ref ListCustomMetricsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ArchiveCustomMetricRequest(ref ArchiveCustomMetricRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCustomMetricRequest(ref GetCustomMetricRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataRetentionSettingsRequest(ref GetDataRetentionSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataRetentionSettingsRequest(ref UpdateDataRetentionSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDataStreamRequest(ref CreateDataStreamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataStreamRequest(ref DeleteDataStreamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataStreamRequest(ref UpdateDataStreamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataStreamsRequest(ref ListDataStreamsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataStreamRequest(ref GetDataStreamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunAccessReportRequest(ref RunAccessReportRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lookup for a single Account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Account GetAccount(GetAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccountRequest(ref request, ref callSettings);
            return _callGetAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Lookup for a single Account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Account> GetAccountAsync(GetAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccountRequest(ref request, ref callSettings);
            return _callGetAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Returns all accounts accessible by the caller.
        /// 
        /// Note that these accounts might not currently have GA4 properties.
        /// Soft-deleted (ie: "trashed") accounts are excluded by default.
        /// Returns an empty list if no relevant accounts are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Account"/> resources.</returns>
        public override gax::PagedEnumerable<ListAccountsResponse, Account> ListAccounts(ListAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccountsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAccountsRequest, ListAccountsResponse, Account>(_callListAccounts, request, callSettings);
        }

        /// <summary>
        /// Returns all accounts accessible by the caller.
        /// 
        /// Note that these accounts might not currently have GA4 properties.
        /// Soft-deleted (ie: "trashed") accounts are excluded by default.
        /// Returns an empty list if no relevant accounts are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Account"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAccountsResponse, Account> ListAccountsAsync(ListAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccountsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAccountsRequest, ListAccountsResponse, Account>(_callListAccounts, request, callSettings);
        }

        /// <summary>
        /// Marks target Account as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted accounts.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the accounts are not restored before the expiration time, the account
        /// and all child resources (eg: Properties, GoogleAdsLinks, Streams,
        /// AccessBindings) will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAccount(DeleteAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAccountRequest(ref request, ref callSettings);
            _callDeleteAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Marks target Account as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted accounts.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the accounts are not restored before the expiration time, the account
        /// and all child resources (eg: Properties, GoogleAdsLinks, Streams,
        /// AccessBindings) will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAccountAsync(DeleteAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAccountRequest(ref request, ref callSettings);
            return _callDeleteAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Account UpdateAccount(UpdateAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccountRequest(ref request, ref callSettings);
            return _callUpdateAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Account> UpdateAccountAsync(UpdateAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccountRequest(ref request, ref callSettings);
            return _callUpdateAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Requests a ticket for creating an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProvisionAccountTicketResponse ProvisionAccountTicket(ProvisionAccountTicketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProvisionAccountTicketRequest(ref request, ref callSettings);
            return _callProvisionAccountTicket.Sync(request, callSettings);
        }

        /// <summary>
        /// Requests a ticket for creating an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProvisionAccountTicketResponse> ProvisionAccountTicketAsync(ProvisionAccountTicketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProvisionAccountTicketRequest(ref request, ref callSettings);
            return _callProvisionAccountTicket.Async(request, callSettings);
        }

        /// <summary>
        /// Returns summaries of all accounts accessible by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccountSummary"/> resources.</returns>
        public override gax::PagedEnumerable<ListAccountSummariesResponse, AccountSummary> ListAccountSummaries(ListAccountSummariesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccountSummariesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAccountSummariesRequest, ListAccountSummariesResponse, AccountSummary>(_callListAccountSummaries, request, callSettings);
        }

        /// <summary>
        /// Returns summaries of all accounts accessible by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccountSummary"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAccountSummariesResponse, AccountSummary> ListAccountSummariesAsync(ListAccountSummariesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccountSummariesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAccountSummariesRequest, ListAccountSummariesResponse, AccountSummary>(_callListAccountSummaries, request, callSettings);
        }

        /// <summary>
        /// Lookup for a single "GA4" Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Property GetProperty(GetPropertyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPropertyRequest(ref request, ref callSettings);
            return _callGetProperty.Sync(request, callSettings);
        }

        /// <summary>
        /// Lookup for a single "GA4" Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Property> GetPropertyAsync(GetPropertyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPropertyRequest(ref request, ref callSettings);
            return _callGetProperty.Async(request, callSettings);
        }

        /// <summary>
        /// Returns child Properties under the specified parent Account.
        /// 
        /// Only "GA4" properties will be returned.
        /// Properties will be excluded if the caller does not have access.
        /// Soft-deleted (ie: "trashed") properties are excluded by default.
        /// Returns an empty list if no relevant properties are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Property"/> resources.</returns>
        public override gax::PagedEnumerable<ListPropertiesResponse, Property> ListProperties(ListPropertiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPropertiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPropertiesRequest, ListPropertiesResponse, Property>(_callListProperties, request, callSettings);
        }

        /// <summary>
        /// Returns child Properties under the specified parent Account.
        /// 
        /// Only "GA4" properties will be returned.
        /// Properties will be excluded if the caller does not have access.
        /// Soft-deleted (ie: "trashed") properties are excluded by default.
        /// Returns an empty list if no relevant properties are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Property"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPropertiesResponse, Property> ListPropertiesAsync(ListPropertiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPropertiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPropertiesRequest, ListPropertiesResponse, Property>(_callListProperties, request, callSettings);
        }

        /// <summary>
        /// Creates an "GA4" property with the specified location and attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Property CreateProperty(CreatePropertyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePropertyRequest(ref request, ref callSettings);
            return _callCreateProperty.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an "GA4" property with the specified location and attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Property> CreatePropertyAsync(CreatePropertyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePropertyRequest(ref request, ref callSettings);
            return _callCreateProperty.Async(request, callSettings);
        }

        /// <summary>
        /// Marks target Property as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted properties.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the properties are not restored before the expiration time, the Property
        /// and all child resources (eg: GoogleAdsLinks, Streams, AccessBindings)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not a GA4 Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Property DeleteProperty(DeletePropertyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePropertyRequest(ref request, ref callSettings);
            return _callDeleteProperty.Sync(request, callSettings);
        }

        /// <summary>
        /// Marks target Property as soft-deleted (ie: "trashed") and returns it.
        /// 
        /// This API does not have a method to restore soft-deleted properties.
        /// However, they can be restored using the Trash Can UI.
        /// 
        /// If the properties are not restored before the expiration time, the Property
        /// and all child resources (eg: GoogleAdsLinks, Streams, AccessBindings)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not a GA4 Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Property> DeletePropertyAsync(DeletePropertyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePropertyRequest(ref request, ref callSettings);
            return _callDeleteProperty.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Property UpdateProperty(UpdatePropertyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePropertyRequest(ref request, ref callSettings);
            return _callUpdateProperty.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Property> UpdatePropertyAsync(UpdatePropertyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePropertyRequest(ref request, ref callSettings);
            return _callUpdateProperty.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a FirebaseLink.
        /// 
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FirebaseLink CreateFirebaseLink(CreateFirebaseLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFirebaseLinkRequest(ref request, ref callSettings);
            return _callCreateFirebaseLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a FirebaseLink.
        /// 
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FirebaseLink> CreateFirebaseLinkAsync(CreateFirebaseLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFirebaseLinkRequest(ref request, ref callSettings);
            return _callCreateFirebaseLink.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a FirebaseLink on a property
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteFirebaseLink(DeleteFirebaseLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFirebaseLinkRequest(ref request, ref callSettings);
            _callDeleteFirebaseLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a FirebaseLink on a property
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteFirebaseLinkAsync(DeleteFirebaseLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFirebaseLinkRequest(ref request, ref callSettings);
            return _callDeleteFirebaseLink.Async(request, callSettings);
        }

        /// <summary>
        /// Lists FirebaseLinks on a property.
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FirebaseLink"/> resources.</returns>
        public override gax::PagedEnumerable<ListFirebaseLinksResponse, FirebaseLink> ListFirebaseLinks(ListFirebaseLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFirebaseLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFirebaseLinksRequest, ListFirebaseLinksResponse, FirebaseLink>(_callListFirebaseLinks, request, callSettings);
        }

        /// <summary>
        /// Lists FirebaseLinks on a property.
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FirebaseLink"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFirebaseLinksResponse, FirebaseLink> ListFirebaseLinksAsync(ListFirebaseLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFirebaseLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFirebaseLinksRequest, ListFirebaseLinksResponse, FirebaseLink>(_callListFirebaseLinks, request, callSettings);
        }

        /// <summary>
        /// Creates a GoogleAdsLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GoogleAdsLink CreateGoogleAdsLink(CreateGoogleAdsLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGoogleAdsLinkRequest(ref request, ref callSettings);
            return _callCreateGoogleAdsLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a GoogleAdsLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GoogleAdsLink> CreateGoogleAdsLinkAsync(CreateGoogleAdsLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGoogleAdsLinkRequest(ref request, ref callSettings);
            return _callCreateGoogleAdsLink.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a GoogleAdsLink on a property
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GoogleAdsLink UpdateGoogleAdsLink(UpdateGoogleAdsLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGoogleAdsLinkRequest(ref request, ref callSettings);
            return _callUpdateGoogleAdsLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a GoogleAdsLink on a property
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GoogleAdsLink> UpdateGoogleAdsLinkAsync(UpdateGoogleAdsLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGoogleAdsLinkRequest(ref request, ref callSettings);
            return _callUpdateGoogleAdsLink.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a GoogleAdsLink on a property
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteGoogleAdsLink(DeleteGoogleAdsLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGoogleAdsLinkRequest(ref request, ref callSettings);
            _callDeleteGoogleAdsLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a GoogleAdsLink on a property
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteGoogleAdsLinkAsync(DeleteGoogleAdsLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGoogleAdsLinkRequest(ref request, ref callSettings);
            return _callDeleteGoogleAdsLink.Async(request, callSettings);
        }

        /// <summary>
        /// Lists GoogleAdsLinks on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GoogleAdsLink"/> resources.</returns>
        public override gax::PagedEnumerable<ListGoogleAdsLinksResponse, GoogleAdsLink> ListGoogleAdsLinks(ListGoogleAdsLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGoogleAdsLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGoogleAdsLinksRequest, ListGoogleAdsLinksResponse, GoogleAdsLink>(_callListGoogleAdsLinks, request, callSettings);
        }

        /// <summary>
        /// Lists GoogleAdsLinks on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GoogleAdsLink"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGoogleAdsLinksResponse, GoogleAdsLink> ListGoogleAdsLinksAsync(ListGoogleAdsLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGoogleAdsLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGoogleAdsLinksRequest, ListGoogleAdsLinksResponse, GoogleAdsLink>(_callListGoogleAdsLinks, request, callSettings);
        }

        /// <summary>
        /// Get data sharing settings on an account.
        /// Data sharing settings are singletons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataSharingSettings GetDataSharingSettings(GetDataSharingSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataSharingSettingsRequest(ref request, ref callSettings);
            return _callGetDataSharingSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Get data sharing settings on an account.
        /// Data sharing settings are singletons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataSharingSettings> GetDataSharingSettingsAsync(GetDataSharingSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataSharingSettingsRequest(ref request, ref callSettings);
            return _callGetDataSharingSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Lookup for a single "GA4" MeasurementProtocolSecret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MeasurementProtocolSecret GetMeasurementProtocolSecret(GetMeasurementProtocolSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMeasurementProtocolSecretRequest(ref request, ref callSettings);
            return _callGetMeasurementProtocolSecret.Sync(request, callSettings);
        }

        /// <summary>
        /// Lookup for a single "GA4" MeasurementProtocolSecret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MeasurementProtocolSecret> GetMeasurementProtocolSecretAsync(GetMeasurementProtocolSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMeasurementProtocolSecretRequest(ref request, ref callSettings);
            return _callGetMeasurementProtocolSecret.Async(request, callSettings);
        }

        /// <summary>
        /// Returns child MeasurementProtocolSecrets under the specified parent
        /// Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MeasurementProtocolSecret"/> resources.</returns>
        public override gax::PagedEnumerable<ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret> ListMeasurementProtocolSecrets(ListMeasurementProtocolSecretsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMeasurementProtocolSecretsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMeasurementProtocolSecretsRequest, ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret>(_callListMeasurementProtocolSecrets, request, callSettings);
        }

        /// <summary>
        /// Returns child MeasurementProtocolSecrets under the specified parent
        /// Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MeasurementProtocolSecret"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret> ListMeasurementProtocolSecretsAsync(ListMeasurementProtocolSecretsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMeasurementProtocolSecretsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMeasurementProtocolSecretsRequest, ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret>(_callListMeasurementProtocolSecrets, request, callSettings);
        }

        /// <summary>
        /// Creates a measurement protocol secret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MeasurementProtocolSecret CreateMeasurementProtocolSecret(CreateMeasurementProtocolSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMeasurementProtocolSecretRequest(ref request, ref callSettings);
            return _callCreateMeasurementProtocolSecret.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a measurement protocol secret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MeasurementProtocolSecret> CreateMeasurementProtocolSecretAsync(CreateMeasurementProtocolSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMeasurementProtocolSecretRequest(ref request, ref callSettings);
            return _callCreateMeasurementProtocolSecret.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes target MeasurementProtocolSecret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteMeasurementProtocolSecret(DeleteMeasurementProtocolSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMeasurementProtocolSecretRequest(ref request, ref callSettings);
            _callDeleteMeasurementProtocolSecret.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes target MeasurementProtocolSecret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteMeasurementProtocolSecretAsync(DeleteMeasurementProtocolSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMeasurementProtocolSecretRequest(ref request, ref callSettings);
            return _callDeleteMeasurementProtocolSecret.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a measurement protocol secret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MeasurementProtocolSecret UpdateMeasurementProtocolSecret(UpdateMeasurementProtocolSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMeasurementProtocolSecretRequest(ref request, ref callSettings);
            return _callUpdateMeasurementProtocolSecret.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a measurement protocol secret.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MeasurementProtocolSecret> UpdateMeasurementProtocolSecretAsync(UpdateMeasurementProtocolSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMeasurementProtocolSecretRequest(ref request, ref callSettings);
            return _callUpdateMeasurementProtocolSecret.Async(request, callSettings);
        }

        /// <summary>
        /// Acknowledges the terms of user data collection for the specified property.
        /// 
        /// This acknowledgement must be completed (either in the Google Analytics UI
        /// or through this API) before MeasurementProtocolSecret resources may be
        /// created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AcknowledgeUserDataCollectionResponse AcknowledgeUserDataCollection(AcknowledgeUserDataCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AcknowledgeUserDataCollectionRequest(ref request, ref callSettings);
            return _callAcknowledgeUserDataCollection.Sync(request, callSettings);
        }

        /// <summary>
        /// Acknowledges the terms of user data collection for the specified property.
        /// 
        /// This acknowledgement must be completed (either in the Google Analytics UI
        /// or through this API) before MeasurementProtocolSecret resources may be
        /// created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AcknowledgeUserDataCollectionResponse> AcknowledgeUserDataCollectionAsync(AcknowledgeUserDataCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AcknowledgeUserDataCollectionRequest(ref request, ref callSettings);
            return _callAcknowledgeUserDataCollection.Async(request, callSettings);
        }

        /// <summary>
        /// Searches through all changes to an account or its children given the
        /// specified set of filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ChangeHistoryEvent"/> resources.</returns>
        public override gax::PagedEnumerable<SearchChangeHistoryEventsResponse, ChangeHistoryEvent> SearchChangeHistoryEvents(SearchChangeHistoryEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchChangeHistoryEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchChangeHistoryEventsRequest, SearchChangeHistoryEventsResponse, ChangeHistoryEvent>(_callSearchChangeHistoryEvents, request, callSettings);
        }

        /// <summary>
        /// Searches through all changes to an account or its children given the
        /// specified set of filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ChangeHistoryEvent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchChangeHistoryEventsResponse, ChangeHistoryEvent> SearchChangeHistoryEventsAsync(SearchChangeHistoryEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchChangeHistoryEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchChangeHistoryEventsRequest, SearchChangeHistoryEventsResponse, ChangeHistoryEvent>(_callSearchChangeHistoryEvents, request, callSettings);
        }

        /// <summary>
        /// Deprecated: Use `CreateKeyEvent` instead.
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public override ConversionEvent CreateConversionEvent(CreateConversionEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversionEventRequest(ref request, ref callSettings);
            return _callCreateConversionEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Use `CreateKeyEvent` instead.
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public override stt::Task<ConversionEvent> CreateConversionEventAsync(CreateConversionEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversionEventRequest(ref request, ref callSettings);
            return _callCreateConversionEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Use `UpdateKeyEvent` instead.
        /// Updates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public override ConversionEvent UpdateConversionEvent(UpdateConversionEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConversionEventRequest(ref request, ref callSettings);
            return _callUpdateConversionEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Use `UpdateKeyEvent` instead.
        /// Updates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public override stt::Task<ConversionEvent> UpdateConversionEventAsync(UpdateConversionEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConversionEventRequest(ref request, ref callSettings);
            return _callUpdateConversionEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Use `GetKeyEvent` instead.
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public override ConversionEvent GetConversionEvent(GetConversionEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversionEventRequest(ref request, ref callSettings);
            return _callGetConversionEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Use `GetKeyEvent` instead.
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public override stt::Task<ConversionEvent> GetConversionEventAsync(GetConversionEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversionEventRequest(ref request, ref callSettings);
            return _callGetConversionEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Use `DeleteKeyEvent` instead.
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public override void DeleteConversionEvent(DeleteConversionEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversionEventRequest(ref request, ref callSettings);
            _callDeleteConversionEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Use `DeleteKeyEvent` instead.
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public override stt::Task DeleteConversionEventAsync(DeleteConversionEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversionEventRequest(ref request, ref callSettings);
            return _callDeleteConversionEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Use `ListKeyEvents` instead.
        /// Returns a list of conversion events in the specified parent property.
        /// 
        /// Returns an empty list if no conversion events are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConversionEvent"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public override gax::PagedEnumerable<ListConversionEventsResponse, ConversionEvent> ListConversionEvents(ListConversionEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversionEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConversionEventsRequest, ListConversionEventsResponse, ConversionEvent>(_callListConversionEvents, request, callSettings);
        }

        /// <summary>
        /// Deprecated: Use `ListKeyEvents` instead.
        /// Returns a list of conversion events in the specified parent property.
        /// 
        /// Returns an empty list if no conversion events are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConversionEvent"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public override gax::PagedAsyncEnumerable<ListConversionEventsResponse, ConversionEvent> ListConversionEventsAsync(ListConversionEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversionEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConversionEventsRequest, ListConversionEventsResponse, ConversionEvent>(_callListConversionEvents, request, callSettings);
        }

        /// <summary>
        /// Creates a Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override KeyEvent CreateKeyEvent(CreateKeyEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateKeyEventRequest(ref request, ref callSettings);
            return _callCreateKeyEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<KeyEvent> CreateKeyEventAsync(CreateKeyEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateKeyEventRequest(ref request, ref callSettings);
            return _callCreateKeyEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override KeyEvent UpdateKeyEvent(UpdateKeyEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateKeyEventRequest(ref request, ref callSettings);
            return _callUpdateKeyEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<KeyEvent> UpdateKeyEventAsync(UpdateKeyEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateKeyEventRequest(ref request, ref callSettings);
            return _callUpdateKeyEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override KeyEvent GetKeyEvent(GetKeyEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeyEventRequest(ref request, ref callSettings);
            return _callGetKeyEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<KeyEvent> GetKeyEventAsync(GetKeyEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeyEventRequest(ref request, ref callSettings);
            return _callGetKeyEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteKeyEvent(DeleteKeyEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteKeyEventRequest(ref request, ref callSettings);
            _callDeleteKeyEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a Key Event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteKeyEventAsync(DeleteKeyEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteKeyEventRequest(ref request, ref callSettings);
            return _callDeleteKeyEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of Key Events in the specified parent property.
        /// Returns an empty list if no Key Events are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="KeyEvent"/> resources.</returns>
        public override gax::PagedEnumerable<ListKeyEventsResponse, KeyEvent> ListKeyEvents(ListKeyEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListKeyEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListKeyEventsRequest, ListKeyEventsResponse, KeyEvent>(_callListKeyEvents, request, callSettings);
        }

        /// <summary>
        /// Returns a list of Key Events in the specified parent property.
        /// Returns an empty list if no Key Events are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="KeyEvent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListKeyEventsResponse, KeyEvent> ListKeyEventsAsync(ListKeyEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListKeyEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListKeyEventsRequest, ListKeyEventsResponse, KeyEvent>(_callListKeyEvents, request, callSettings);
        }

        /// <summary>
        /// Creates a CustomDimension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomDimension CreateCustomDimension(CreateCustomDimensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomDimensionRequest(ref request, ref callSettings);
            return _callCreateCustomDimension.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a CustomDimension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomDimension> CreateCustomDimensionAsync(CreateCustomDimensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomDimensionRequest(ref request, ref callSettings);
            return _callCreateCustomDimension.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a CustomDimension on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomDimension UpdateCustomDimension(UpdateCustomDimensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomDimensionRequest(ref request, ref callSettings);
            return _callUpdateCustomDimension.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a CustomDimension on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomDimension> UpdateCustomDimensionAsync(UpdateCustomDimensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomDimensionRequest(ref request, ref callSettings);
            return _callUpdateCustomDimension.Async(request, callSettings);
        }

        /// <summary>
        /// Lists CustomDimensions on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomDimension"/> resources.</returns>
        public override gax::PagedEnumerable<ListCustomDimensionsResponse, CustomDimension> ListCustomDimensions(ListCustomDimensionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomDimensionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCustomDimensionsRequest, ListCustomDimensionsResponse, CustomDimension>(_callListCustomDimensions, request, callSettings);
        }

        /// <summary>
        /// Lists CustomDimensions on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomDimension"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCustomDimensionsResponse, CustomDimension> ListCustomDimensionsAsync(ListCustomDimensionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomDimensionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCustomDimensionsRequest, ListCustomDimensionsResponse, CustomDimension>(_callListCustomDimensions, request, callSettings);
        }

        /// <summary>
        /// Archives a CustomDimension on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void ArchiveCustomDimension(ArchiveCustomDimensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ArchiveCustomDimensionRequest(ref request, ref callSettings);
            _callArchiveCustomDimension.Sync(request, callSettings);
        }

        /// <summary>
        /// Archives a CustomDimension on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task ArchiveCustomDimensionAsync(ArchiveCustomDimensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ArchiveCustomDimensionRequest(ref request, ref callSettings);
            return _callArchiveCustomDimension.Async(request, callSettings);
        }

        /// <summary>
        /// Lookup for a single CustomDimension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomDimension GetCustomDimension(GetCustomDimensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomDimensionRequest(ref request, ref callSettings);
            return _callGetCustomDimension.Sync(request, callSettings);
        }

        /// <summary>
        /// Lookup for a single CustomDimension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomDimension> GetCustomDimensionAsync(GetCustomDimensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomDimensionRequest(ref request, ref callSettings);
            return _callGetCustomDimension.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a CustomMetric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomMetric CreateCustomMetric(CreateCustomMetricRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomMetricRequest(ref request, ref callSettings);
            return _callCreateCustomMetric.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a CustomMetric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomMetric> CreateCustomMetricAsync(CreateCustomMetricRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomMetricRequest(ref request, ref callSettings);
            return _callCreateCustomMetric.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a CustomMetric on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomMetric UpdateCustomMetric(UpdateCustomMetricRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomMetricRequest(ref request, ref callSettings);
            return _callUpdateCustomMetric.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a CustomMetric on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomMetric> UpdateCustomMetricAsync(UpdateCustomMetricRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomMetricRequest(ref request, ref callSettings);
            return _callUpdateCustomMetric.Async(request, callSettings);
        }

        /// <summary>
        /// Lists CustomMetrics on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomMetric"/> resources.</returns>
        public override gax::PagedEnumerable<ListCustomMetricsResponse, CustomMetric> ListCustomMetrics(ListCustomMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomMetricsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCustomMetricsRequest, ListCustomMetricsResponse, CustomMetric>(_callListCustomMetrics, request, callSettings);
        }

        /// <summary>
        /// Lists CustomMetrics on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomMetric"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCustomMetricsResponse, CustomMetric> ListCustomMetricsAsync(ListCustomMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomMetricsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCustomMetricsRequest, ListCustomMetricsResponse, CustomMetric>(_callListCustomMetrics, request, callSettings);
        }

        /// <summary>
        /// Archives a CustomMetric on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void ArchiveCustomMetric(ArchiveCustomMetricRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ArchiveCustomMetricRequest(ref request, ref callSettings);
            _callArchiveCustomMetric.Sync(request, callSettings);
        }

        /// <summary>
        /// Archives a CustomMetric on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task ArchiveCustomMetricAsync(ArchiveCustomMetricRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ArchiveCustomMetricRequest(ref request, ref callSettings);
            return _callArchiveCustomMetric.Async(request, callSettings);
        }

        /// <summary>
        /// Lookup for a single CustomMetric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomMetric GetCustomMetric(GetCustomMetricRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomMetricRequest(ref request, ref callSettings);
            return _callGetCustomMetric.Sync(request, callSettings);
        }

        /// <summary>
        /// Lookup for a single CustomMetric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomMetric> GetCustomMetricAsync(GetCustomMetricRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomMetricRequest(ref request, ref callSettings);
            return _callGetCustomMetric.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the singleton data retention settings for this property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataRetentionSettings GetDataRetentionSettings(GetDataRetentionSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataRetentionSettingsRequest(ref request, ref callSettings);
            return _callGetDataRetentionSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the singleton data retention settings for this property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataRetentionSettings> GetDataRetentionSettingsAsync(GetDataRetentionSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataRetentionSettingsRequest(ref request, ref callSettings);
            return _callGetDataRetentionSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the singleton data retention settings for this property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataRetentionSettings UpdateDataRetentionSettings(UpdateDataRetentionSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataRetentionSettingsRequest(ref request, ref callSettings);
            return _callUpdateDataRetentionSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the singleton data retention settings for this property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataRetentionSettings> UpdateDataRetentionSettingsAsync(UpdateDataRetentionSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataRetentionSettingsRequest(ref request, ref callSettings);
            return _callUpdateDataRetentionSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a DataStream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataStream CreateDataStream(CreateDataStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataStreamRequest(ref request, ref callSettings);
            return _callCreateDataStream.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a DataStream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataStream> CreateDataStreamAsync(CreateDataStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataStreamRequest(ref request, ref callSettings);
            return _callCreateDataStream.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a DataStream on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDataStream(DeleteDataStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataStreamRequest(ref request, ref callSettings);
            _callDeleteDataStream.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a DataStream on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDataStreamAsync(DeleteDataStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataStreamRequest(ref request, ref callSettings);
            return _callDeleteDataStream.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a DataStream on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataStream UpdateDataStream(UpdateDataStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataStreamRequest(ref request, ref callSettings);
            return _callUpdateDataStream.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a DataStream on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataStream> UpdateDataStreamAsync(UpdateDataStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataStreamRequest(ref request, ref callSettings);
            return _callUpdateDataStream.Async(request, callSettings);
        }

        /// <summary>
        /// Lists DataStreams on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataStream"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataStreamsResponse, DataStream> ListDataStreams(ListDataStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataStreamsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataStreamsRequest, ListDataStreamsResponse, DataStream>(_callListDataStreams, request, callSettings);
        }

        /// <summary>
        /// Lists DataStreams on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataStream"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataStreamsResponse, DataStream> ListDataStreamsAsync(ListDataStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataStreamsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataStreamsRequest, ListDataStreamsResponse, DataStream>(_callListDataStreams, request, callSettings);
        }

        /// <summary>
        /// Lookup for a single DataStream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataStream GetDataStream(GetDataStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataStreamRequest(ref request, ref callSettings);
            return _callGetDataStream.Sync(request, callSettings);
        }

        /// <summary>
        /// Lookup for a single DataStream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataStream> GetDataStreamAsync(GetDataStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataStreamRequest(ref request, ref callSettings);
            return _callGetDataStream.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a customized report of data access records. The report provides
        /// records of each time a user reads Google Analytics reporting data. Access
        /// records are retained for up to 2 years.
        /// 
        /// Data Access Reports can be requested for a property. Reports may be
        /// requested for any property, but dimensions that aren't related to quota can
        /// only be requested on Google Analytics 360 properties. This method is only
        /// available to Administrators.
        /// 
        /// These data access records include GA4 UI Reporting, GA4 UI Explorations,
        /// GA4 Data API, and other products like Firebase &amp; Admob that can retrieve
        /// data from Google Analytics through a linkage. These records don't include
        /// property configuration changes like adding a stream or changing a
        /// property's time zone. For configuration change history, see
        /// [searchChangeHistoryEvents](https://developers.google.com/analytics/devguides/config/admin/v1/rest/v1alpha/accounts/searchChangeHistoryEvents).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunAccessReportResponse RunAccessReport(RunAccessReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunAccessReportRequest(ref request, ref callSettings);
            return _callRunAccessReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a customized report of data access records. The report provides
        /// records of each time a user reads Google Analytics reporting data. Access
        /// records are retained for up to 2 years.
        /// 
        /// Data Access Reports can be requested for a property. Reports may be
        /// requested for any property, but dimensions that aren't related to quota can
        /// only be requested on Google Analytics 360 properties. This method is only
        /// available to Administrators.
        /// 
        /// These data access records include GA4 UI Reporting, GA4 UI Explorations,
        /// GA4 Data API, and other products like Firebase &amp; Admob that can retrieve
        /// data from Google Analytics through a linkage. These records don't include
        /// property configuration changes like adding a stream or changing a
        /// property's time zone. For configuration change history, see
        /// [searchChangeHistoryEvents](https://developers.google.com/analytics/devguides/config/admin/v1/rest/v1alpha/accounts/searchChangeHistoryEvents).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RunAccessReportResponse> RunAccessReportAsync(RunAccessReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunAccessReportRequest(ref request, ref callSettings);
            return _callRunAccessReport.Async(request, callSettings);
        }
    }

    public partial class ListAccountsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAccountSummariesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPropertiesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFirebaseLinksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGoogleAdsLinksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMeasurementProtocolSecretsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchChangeHistoryEventsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConversionEventsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListKeyEventsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCustomDimensionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCustomMetricsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataStreamsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAccountsResponse : gaxgrpc::IPageResponse<Account>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Account> GetEnumerator() => Accounts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAccountSummariesResponse : gaxgrpc::IPageResponse<AccountSummary>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AccountSummary> GetEnumerator() => AccountSummaries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPropertiesResponse : gaxgrpc::IPageResponse<Property>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Property> GetEnumerator() => Properties.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFirebaseLinksResponse : gaxgrpc::IPageResponse<FirebaseLink>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FirebaseLink> GetEnumerator() => FirebaseLinks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGoogleAdsLinksResponse : gaxgrpc::IPageResponse<GoogleAdsLink>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GoogleAdsLink> GetEnumerator() => GoogleAdsLinks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMeasurementProtocolSecretsResponse : gaxgrpc::IPageResponse<MeasurementProtocolSecret>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MeasurementProtocolSecret> GetEnumerator() => MeasurementProtocolSecrets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchChangeHistoryEventsResponse : gaxgrpc::IPageResponse<ChangeHistoryEvent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ChangeHistoryEvent> GetEnumerator() => ChangeHistoryEvents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListConversionEventsResponse : gaxgrpc::IPageResponse<ConversionEvent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ConversionEvent> GetEnumerator() => ConversionEvents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListKeyEventsResponse : gaxgrpc::IPageResponse<KeyEvent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<KeyEvent> GetEnumerator() => KeyEvents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCustomDimensionsResponse : gaxgrpc::IPageResponse<CustomDimension>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CustomDimension> GetEnumerator() => CustomDimensions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCustomMetricsResponse : gaxgrpc::IPageResponse<CustomMetric>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CustomMetric> GetEnumerator() => CustomMetrics.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDataStreamsResponse : gaxgrpc::IPageResponse<DataStream>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataStream> GetEnumerator() => DataStreams.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
