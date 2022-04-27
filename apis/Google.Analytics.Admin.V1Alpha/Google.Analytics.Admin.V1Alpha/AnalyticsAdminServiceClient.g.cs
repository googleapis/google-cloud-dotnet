// Copyright 2022 Google LLC
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

namespace Google.Analytics.Admin.V1Alpha
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
            GetUserLinkSettings = existing.GetUserLinkSettings;
            BatchGetUserLinksSettings = existing.BatchGetUserLinksSettings;
            ListUserLinksSettings = existing.ListUserLinksSettings;
            AuditUserLinksSettings = existing.AuditUserLinksSettings;
            CreateUserLinkSettings = existing.CreateUserLinkSettings;
            BatchCreateUserLinksSettings = existing.BatchCreateUserLinksSettings;
            UpdateUserLinkSettings = existing.UpdateUserLinkSettings;
            BatchUpdateUserLinksSettings = existing.BatchUpdateUserLinksSettings;
            DeleteUserLinkSettings = existing.DeleteUserLinkSettings;
            BatchDeleteUserLinksSettings = existing.BatchDeleteUserLinksSettings;
            CreateFirebaseLinkSettings = existing.CreateFirebaseLinkSettings;
            DeleteFirebaseLinkSettings = existing.DeleteFirebaseLinkSettings;
            ListFirebaseLinksSettings = existing.ListFirebaseLinksSettings;
            GetGlobalSiteTagSettings = existing.GetGlobalSiteTagSettings;
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
            GetGoogleSignalsSettingsSettings = existing.GetGoogleSignalsSettingsSettings;
            UpdateGoogleSignalsSettingsSettings = existing.UpdateGoogleSignalsSettingsSettings;
            CreateConversionEventSettings = existing.CreateConversionEventSettings;
            GetConversionEventSettings = existing.GetConversionEventSettings;
            DeleteConversionEventSettings = existing.DeleteConversionEventSettings;
            ListConversionEventsSettings = existing.ListConversionEventsSettings;
            GetDisplayVideo360AdvertiserLinkSettings = existing.GetDisplayVideo360AdvertiserLinkSettings;
            ListDisplayVideo360AdvertiserLinksSettings = existing.ListDisplayVideo360AdvertiserLinksSettings;
            CreateDisplayVideo360AdvertiserLinkSettings = existing.CreateDisplayVideo360AdvertiserLinkSettings;
            DeleteDisplayVideo360AdvertiserLinkSettings = existing.DeleteDisplayVideo360AdvertiserLinkSettings;
            UpdateDisplayVideo360AdvertiserLinkSettings = existing.UpdateDisplayVideo360AdvertiserLinkSettings;
            GetDisplayVideo360AdvertiserLinkProposalSettings = existing.GetDisplayVideo360AdvertiserLinkProposalSettings;
            ListDisplayVideo360AdvertiserLinkProposalsSettings = existing.ListDisplayVideo360AdvertiserLinkProposalsSettings;
            CreateDisplayVideo360AdvertiserLinkProposalSettings = existing.CreateDisplayVideo360AdvertiserLinkProposalSettings;
            DeleteDisplayVideo360AdvertiserLinkProposalSettings = existing.DeleteDisplayVideo360AdvertiserLinkProposalSettings;
            ApproveDisplayVideo360AdvertiserLinkProposalSettings = existing.ApproveDisplayVideo360AdvertiserLinkProposalSettings;
            CancelDisplayVideo360AdvertiserLinkProposalSettings = existing.CancelDisplayVideo360AdvertiserLinkProposalSettings;
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
        /// <c>AnalyticsAdminServiceClient.GetUserLink</c> and <c>AnalyticsAdminServiceClient.GetUserLinkAsync</c>.
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
        public gaxgrpc::CallSettings GetUserLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.BatchGetUserLinks</c> and
        /// <c>AnalyticsAdminServiceClient.BatchGetUserLinksAsync</c>.
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
        public gaxgrpc::CallSettings BatchGetUserLinksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.ListUserLinks</c> and <c>AnalyticsAdminServiceClient.ListUserLinksAsync</c>.
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
        public gaxgrpc::CallSettings ListUserLinksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.AuditUserLinks</c> and <c>AnalyticsAdminServiceClient.AuditUserLinksAsync</c>
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
        public gaxgrpc::CallSettings AuditUserLinksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.CreateUserLink</c> and <c>AnalyticsAdminServiceClient.CreateUserLinkAsync</c>
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
        public gaxgrpc::CallSettings CreateUserLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.BatchCreateUserLinks</c> and
        /// <c>AnalyticsAdminServiceClient.BatchCreateUserLinksAsync</c>.
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
        public gaxgrpc::CallSettings BatchCreateUserLinksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.UpdateUserLink</c> and <c>AnalyticsAdminServiceClient.UpdateUserLinkAsync</c>
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
        public gaxgrpc::CallSettings UpdateUserLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.BatchUpdateUserLinks</c> and
        /// <c>AnalyticsAdminServiceClient.BatchUpdateUserLinksAsync</c>.
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
        public gaxgrpc::CallSettings BatchUpdateUserLinksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.DeleteUserLink</c> and <c>AnalyticsAdminServiceClient.DeleteUserLinkAsync</c>
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
        public gaxgrpc::CallSettings DeleteUserLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.BatchDeleteUserLinks</c> and
        /// <c>AnalyticsAdminServiceClient.BatchDeleteUserLinksAsync</c>.
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
        public gaxgrpc::CallSettings BatchDeleteUserLinksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

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
        /// <c>AnalyticsAdminServiceClient.GetGlobalSiteTag</c> and <c>AnalyticsAdminServiceClient.GetGlobalSiteTagAsync</c>
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
        public gaxgrpc::CallSettings GetGlobalSiteTagSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

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
        /// <c>AnalyticsAdminServiceClient.GetGoogleSignalsSettings</c> and
        /// <c>AnalyticsAdminServiceClient.GetGoogleSignalsSettingsAsync</c>.
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
        public gaxgrpc::CallSettings GetGoogleSignalsSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.UpdateGoogleSignalsSettings</c> and
        /// <c>AnalyticsAdminServiceClient.UpdateGoogleSignalsSettingsAsync</c>.
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
        public gaxgrpc::CallSettings UpdateGoogleSignalsSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

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
        /// <c>AnalyticsAdminServiceClient.GetDisplayVideo360AdvertiserLink</c> and
        /// <c>AnalyticsAdminServiceClient.GetDisplayVideo360AdvertiserLinkAsync</c>.
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
        public gaxgrpc::CallSettings GetDisplayVideo360AdvertiserLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.ListDisplayVideo360AdvertiserLinks</c> and
        /// <c>AnalyticsAdminServiceClient.ListDisplayVideo360AdvertiserLinksAsync</c>.
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
        public gaxgrpc::CallSettings ListDisplayVideo360AdvertiserLinksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.CreateDisplayVideo360AdvertiserLink</c> and
        /// <c>AnalyticsAdminServiceClient.CreateDisplayVideo360AdvertiserLinkAsync</c>.
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
        public gaxgrpc::CallSettings CreateDisplayVideo360AdvertiserLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.DeleteDisplayVideo360AdvertiserLink</c> and
        /// <c>AnalyticsAdminServiceClient.DeleteDisplayVideo360AdvertiserLinkAsync</c>.
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
        public gaxgrpc::CallSettings DeleteDisplayVideo360AdvertiserLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.UpdateDisplayVideo360AdvertiserLink</c> and
        /// <c>AnalyticsAdminServiceClient.UpdateDisplayVideo360AdvertiserLinkAsync</c>.
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
        public gaxgrpc::CallSettings UpdateDisplayVideo360AdvertiserLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.GetDisplayVideo360AdvertiserLinkProposal</c> and
        /// <c>AnalyticsAdminServiceClient.GetDisplayVideo360AdvertiserLinkProposalAsync</c>.
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
        public gaxgrpc::CallSettings GetDisplayVideo360AdvertiserLinkProposalSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.ListDisplayVideo360AdvertiserLinkProposals</c> and
        /// <c>AnalyticsAdminServiceClient.ListDisplayVideo360AdvertiserLinkProposalsAsync</c>.
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
        public gaxgrpc::CallSettings ListDisplayVideo360AdvertiserLinkProposalsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.CreateDisplayVideo360AdvertiserLinkProposal</c> and
        /// <c>AnalyticsAdminServiceClient.CreateDisplayVideo360AdvertiserLinkProposalAsync</c>.
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
        public gaxgrpc::CallSettings CreateDisplayVideo360AdvertiserLinkProposalSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.DeleteDisplayVideo360AdvertiserLinkProposal</c> and
        /// <c>AnalyticsAdminServiceClient.DeleteDisplayVideo360AdvertiserLinkProposalAsync</c>.
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
        public gaxgrpc::CallSettings DeleteDisplayVideo360AdvertiserLinkProposalSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.ApproveDisplayVideo360AdvertiserLinkProposal</c> and
        /// <c>AnalyticsAdminServiceClient.ApproveDisplayVideo360AdvertiserLinkProposalAsync</c>.
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
        public gaxgrpc::CallSettings ApproveDisplayVideo360AdvertiserLinkProposalSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsAdminServiceClient.CancelDisplayVideo360AdvertiserLinkProposal</c> and
        /// <c>AnalyticsAdminServiceClient.CancelDisplayVideo360AdvertiserLinkProposalAsync</c>.
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
        public gaxgrpc::CallSettings CancelDisplayVideo360AdvertiserLinkProposalSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

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
            return AnalyticsAdminServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<AnalyticsAdminServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AnalyticsAdminServiceClient.Create(callInvoker, Settings, Logger);
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
        /// <item><description>https://www.googleapis.com/auth/analytics.manage.users</description></item>
        /// <item><description>https://www.googleapis.com/auth/analytics.manage.users.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/analytics.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/analytics.edit",
            "https://www.googleapis.com/auth/analytics.manage.users",
            "https://www.googleapis.com/auth/analytics.manage.users.readonly",
            "https://www.googleapis.com/auth/analytics.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AnalyticsAdminService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

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
        /// UserLinks) will be permanently purged.
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
        /// UserLinks) will be permanently purged.
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
        /// UserLinks) will be permanently purged.
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
        /// UserLinks) will be permanently purged.
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
        /// UserLinks) will be permanently purged.
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
        /// UserLinks) will be permanently purged.
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
        /// UserLinks) will be permanently purged.
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
        /// UserLinks) will be permanently purged.
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
        /// UserLinks) will be permanently purged.
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
        /// Required. The list of fields to be updated. Field names must be in snake case
        /// (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        /// the entire entity, use one path with the string "*" to match all fields.
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
        /// Required. The list of fields to be updated. Field names must be in snake case
        /// (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        /// the entire entity, use one path with the string "*" to match all fields.
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
        /// Required. The list of fields to be updated. Field names must be in snake case
        /// (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        /// the entire entity, use one path with the string "*" to match all fields.
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
        /// and all child resources (eg: GoogleAdsLinks, Streams, UserLinks)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not an GA4 Property.
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
        /// and all child resources (eg: GoogleAdsLinks, Streams, UserLinks)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not an GA4 Property.
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
        /// and all child resources (eg: GoogleAdsLinks, Streams, UserLinks)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not an GA4 Property.
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
        /// and all child resources (eg: GoogleAdsLinks, Streams, UserLinks)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not an GA4 Property.
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
        /// and all child resources (eg: GoogleAdsLinks, Streams, UserLinks)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not an GA4 Property.
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
        /// and all child resources (eg: GoogleAdsLinks, Streams, UserLinks)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not an GA4 Property.
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
        /// and all child resources (eg: GoogleAdsLinks, Streams, UserLinks)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not an GA4 Property.
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
        /// and all child resources (eg: GoogleAdsLinks, Streams, UserLinks)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not an GA4 Property.
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
        /// and all child resources (eg: GoogleAdsLinks, Streams, UserLinks)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not an GA4 Property.
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
        /// Required. The list of fields to be updated. Field names must be in snake case
        /// (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        /// the entire entity, use one path with the string "*" to match all fields.
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
        /// Required. The list of fields to be updated. Field names must be in snake case
        /// (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        /// the entire entity, use one path with the string "*" to match all fields.
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
        /// Required. The list of fields to be updated. Field names must be in snake case
        /// (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        /// the entire entity, use one path with the string "*" to match all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Property> UpdatePropertyAsync(Property property, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePropertyAsync(property, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a user's link to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserLink GetUserLink(GetUserLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a user's link to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLink> GetUserLinkAsync(GetUserLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a user's link to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLink> GetUserLinkAsync(GetUserLinkRequest request, st::CancellationToken cancellationToken) =>
            GetUserLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a user's link to an account or property.
        /// </summary>
        /// <param name="name">
        /// Required. Example format: accounts/1234/userLinks/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserLink GetUserLink(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserLink(new GetUserLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a user's link to an account or property.
        /// </summary>
        /// <param name="name">
        /// Required. Example format: accounts/1234/userLinks/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLink> GetUserLinkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserLinkAsync(new GetUserLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a user's link to an account or property.
        /// </summary>
        /// <param name="name">
        /// Required. Example format: accounts/1234/userLinks/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLink> GetUserLinkAsync(string name, st::CancellationToken cancellationToken) =>
            GetUserLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a user's link to an account or property.
        /// </summary>
        /// <param name="name">
        /// Required. Example format: accounts/1234/userLinks/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserLink GetUserLink(UserLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserLink(new GetUserLinkRequest
            {
                UserLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a user's link to an account or property.
        /// </summary>
        /// <param name="name">
        /// Required. Example format: accounts/1234/userLinks/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLink> GetUserLinkAsync(UserLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserLinkAsync(new GetUserLinkRequest
            {
                UserLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a user's link to an account or property.
        /// </summary>
        /// <param name="name">
        /// Required. Example format: accounts/1234/userLinks/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLink> GetUserLinkAsync(UserLinkName name, st::CancellationToken cancellationToken) =>
            GetUserLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about multiple users' links to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchGetUserLinksResponse BatchGetUserLinks(BatchGetUserLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about multiple users' links to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetUserLinksResponse> BatchGetUserLinksAsync(BatchGetUserLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about multiple users' links to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetUserLinksResponse> BatchGetUserLinksAsync(BatchGetUserLinksRequest request, st::CancellationToken cancellationToken) =>
            BatchGetUserLinksAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all user links on an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserLinksResponse, UserLink> ListUserLinks(ListUserLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all user links on an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserLinksResponse, UserLink> ListUserLinksAsync(ListUserLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all user links on an account or property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: accounts/1234
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
        /// <returns>A pageable sequence of <see cref="UserLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserLinksResponse, UserLink> ListUserLinks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListUserLinks(new ListUserLinksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all user links on an account or property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: accounts/1234
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
        /// <returns>A pageable asynchronous sequence of <see cref="UserLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserLinksResponse, UserLink> ListUserLinksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListUserLinksAsync(new ListUserLinksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all user links on an account or property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: accounts/1234
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
        /// <returns>A pageable sequence of <see cref="UserLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserLinksResponse, UserLink> ListUserLinks(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListUserLinks(new ListUserLinksRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all user links on an account or property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: accounts/1234
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
        /// <returns>A pageable asynchronous sequence of <see cref="UserLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserLinksResponse, UserLink> ListUserLinksAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListUserLinksAsync(new ListUserLinksRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all user links on an account or property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: accounts/1234
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
        /// <returns>A pageable sequence of <see cref="UserLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserLinksResponse, UserLink> ListUserLinks(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListUserLinks(new ListUserLinksRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all user links on an account or property.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: accounts/1234
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
        /// <returns>A pageable asynchronous sequence of <see cref="UserLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserLinksResponse, UserLink> ListUserLinksAsync(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListUserLinksAsync(new ListUserLinksRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all user links on an account or property, including implicit ones
        /// that come from effective permissions granted by groups or organization
        /// admin roles.
        /// 
        /// If a returned user link does not have direct permissions, they cannot
        /// be removed from the account or property directly with the DeleteUserLink
        /// command. They have to be removed from the group/etc that gives them
        /// permissions, which is currently only usable/discoverable in the GA or GMP
        /// UIs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AuditUserLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<AuditUserLinksResponse, AuditUserLink> AuditUserLinks(AuditUserLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all user links on an account or property, including implicit ones
        /// that come from effective permissions granted by groups or organization
        /// admin roles.
        /// 
        /// If a returned user link does not have direct permissions, they cannot
        /// be removed from the account or property directly with the DeleteUserLink
        /// command. They have to be removed from the group/etc that gives them
        /// permissions, which is currently only usable/discoverable in the GA or GMP
        /// UIs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AuditUserLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<AuditUserLinksResponse, AuditUserLink> AuditUserLinksAsync(AuditUserLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a user link on an account or property.
        /// 
        /// If the user with the specified email already has permissions on the
        /// account or property, then the user's existing permissions will be unioned
        /// with the permissions specified in the new UserLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserLink CreateUserLink(CreateUserLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a user link on an account or property.
        /// 
        /// If the user with the specified email already has permissions on the
        /// account or property, then the user's existing permissions will be unioned
        /// with the permissions specified in the new UserLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLink> CreateUserLinkAsync(CreateUserLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a user link on an account or property.
        /// 
        /// If the user with the specified email already has permissions on the
        /// account or property, then the user's existing permissions will be unioned
        /// with the permissions specified in the new UserLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLink> CreateUserLinkAsync(CreateUserLinkRequest request, st::CancellationToken cancellationToken) =>
            CreateUserLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a user link on an account or property.
        /// 
        /// If the user with the specified email already has permissions on the
        /// account or property, then the user's existing permissions will be unioned
        /// with the permissions specified in the new UserLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: accounts/1234
        /// </param>
        /// <param name="userLink">
        /// Required. The user link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserLink CreateUserLink(string parent, UserLink userLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserLink(new CreateUserLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserLink = gax::GaxPreconditions.CheckNotNull(userLink, nameof(userLink)),
            }, callSettings);

        /// <summary>
        /// Creates a user link on an account or property.
        /// 
        /// If the user with the specified email already has permissions on the
        /// account or property, then the user's existing permissions will be unioned
        /// with the permissions specified in the new UserLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: accounts/1234
        /// </param>
        /// <param name="userLink">
        /// Required. The user link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLink> CreateUserLinkAsync(string parent, UserLink userLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserLinkAsync(new CreateUserLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserLink = gax::GaxPreconditions.CheckNotNull(userLink, nameof(userLink)),
            }, callSettings);

        /// <summary>
        /// Creates a user link on an account or property.
        /// 
        /// If the user with the specified email already has permissions on the
        /// account or property, then the user's existing permissions will be unioned
        /// with the permissions specified in the new UserLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: accounts/1234
        /// </param>
        /// <param name="userLink">
        /// Required. The user link to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLink> CreateUserLinkAsync(string parent, UserLink userLink, st::CancellationToken cancellationToken) =>
            CreateUserLinkAsync(parent, userLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a user link on an account or property.
        /// 
        /// If the user with the specified email already has permissions on the
        /// account or property, then the user's existing permissions will be unioned
        /// with the permissions specified in the new UserLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: accounts/1234
        /// </param>
        /// <param name="userLink">
        /// Required. The user link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserLink CreateUserLink(AccountName parent, UserLink userLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserLink(new CreateUserLinkRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserLink = gax::GaxPreconditions.CheckNotNull(userLink, nameof(userLink)),
            }, callSettings);

        /// <summary>
        /// Creates a user link on an account or property.
        /// 
        /// If the user with the specified email already has permissions on the
        /// account or property, then the user's existing permissions will be unioned
        /// with the permissions specified in the new UserLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: accounts/1234
        /// </param>
        /// <param name="userLink">
        /// Required. The user link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLink> CreateUserLinkAsync(AccountName parent, UserLink userLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserLinkAsync(new CreateUserLinkRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserLink = gax::GaxPreconditions.CheckNotNull(userLink, nameof(userLink)),
            }, callSettings);

        /// <summary>
        /// Creates a user link on an account or property.
        /// 
        /// If the user with the specified email already has permissions on the
        /// account or property, then the user's existing permissions will be unioned
        /// with the permissions specified in the new UserLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: accounts/1234
        /// </param>
        /// <param name="userLink">
        /// Required. The user link to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLink> CreateUserLinkAsync(AccountName parent, UserLink userLink, st::CancellationToken cancellationToken) =>
            CreateUserLinkAsync(parent, userLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a user link on an account or property.
        /// 
        /// If the user with the specified email already has permissions on the
        /// account or property, then the user's existing permissions will be unioned
        /// with the permissions specified in the new UserLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: accounts/1234
        /// </param>
        /// <param name="userLink">
        /// Required. The user link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserLink CreateUserLink(PropertyName parent, UserLink userLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserLink(new CreateUserLinkRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserLink = gax::GaxPreconditions.CheckNotNull(userLink, nameof(userLink)),
            }, callSettings);

        /// <summary>
        /// Creates a user link on an account or property.
        /// 
        /// If the user with the specified email already has permissions on the
        /// account or property, then the user's existing permissions will be unioned
        /// with the permissions specified in the new UserLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: accounts/1234
        /// </param>
        /// <param name="userLink">
        /// Required. The user link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLink> CreateUserLinkAsync(PropertyName parent, UserLink userLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserLinkAsync(new CreateUserLinkRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserLink = gax::GaxPreconditions.CheckNotNull(userLink, nameof(userLink)),
            }, callSettings);

        /// <summary>
        /// Creates a user link on an account or property.
        /// 
        /// If the user with the specified email already has permissions on the
        /// account or property, then the user's existing permissions will be unioned
        /// with the permissions specified in the new UserLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: accounts/1234
        /// </param>
        /// <param name="userLink">
        /// Required. The user link to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLink> CreateUserLinkAsync(PropertyName parent, UserLink userLink, st::CancellationToken cancellationToken) =>
            CreateUserLinkAsync(parent, userLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates information about multiple users' links to an account or property.
        /// 
        /// This method is transactional. If any UserLink cannot be created, none of
        /// the UserLinks will be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateUserLinksResponse BatchCreateUserLinks(BatchCreateUserLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates information about multiple users' links to an account or property.
        /// 
        /// This method is transactional. If any UserLink cannot be created, none of
        /// the UserLinks will be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateUserLinksResponse> BatchCreateUserLinksAsync(BatchCreateUserLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates information about multiple users' links to an account or property.
        /// 
        /// This method is transactional. If any UserLink cannot be created, none of
        /// the UserLinks will be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateUserLinksResponse> BatchCreateUserLinksAsync(BatchCreateUserLinksRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateUserLinksAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a user link on an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserLink UpdateUserLink(UpdateUserLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a user link on an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLink> UpdateUserLinkAsync(UpdateUserLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a user link on an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLink> UpdateUserLinkAsync(UpdateUserLinkRequest request, st::CancellationToken cancellationToken) =>
            UpdateUserLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a user link on an account or property.
        /// </summary>
        /// <param name="userLink">
        /// Required. The user link to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserLink UpdateUserLink(UserLink userLink, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserLink(new UpdateUserLinkRequest
            {
                UserLink = gax::GaxPreconditions.CheckNotNull(userLink, nameof(userLink)),
            }, callSettings);

        /// <summary>
        /// Updates a user link on an account or property.
        /// </summary>
        /// <param name="userLink">
        /// Required. The user link to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLink> UpdateUserLinkAsync(UserLink userLink, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserLinkAsync(new UpdateUserLinkRequest
            {
                UserLink = gax::GaxPreconditions.CheckNotNull(userLink, nameof(userLink)),
            }, callSettings);

        /// <summary>
        /// Updates a user link on an account or property.
        /// </summary>
        /// <param name="userLink">
        /// Required. The user link to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLink> UpdateUserLinkAsync(UserLink userLink, st::CancellationToken cancellationToken) =>
            UpdateUserLinkAsync(userLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates information about multiple users' links to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateUserLinksResponse BatchUpdateUserLinks(BatchUpdateUserLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates information about multiple users' links to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateUserLinksResponse> BatchUpdateUserLinksAsync(BatchUpdateUserLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates information about multiple users' links to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateUserLinksResponse> BatchUpdateUserLinksAsync(BatchUpdateUserLinksRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateUserLinksAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a user link on an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUserLink(DeleteUserLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a user link on an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserLinkAsync(DeleteUserLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a user link on an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserLinkAsync(DeleteUserLinkRequest request, st::CancellationToken cancellationToken) =>
            DeleteUserLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a user link on an account or property.
        /// </summary>
        /// <param name="name">
        /// Required. Example format: accounts/1234/userLinks/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUserLink(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserLink(new DeleteUserLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a user link on an account or property.
        /// </summary>
        /// <param name="name">
        /// Required. Example format: accounts/1234/userLinks/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserLinkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserLinkAsync(new DeleteUserLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a user link on an account or property.
        /// </summary>
        /// <param name="name">
        /// Required. Example format: accounts/1234/userLinks/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserLinkAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteUserLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a user link on an account or property.
        /// </summary>
        /// <param name="name">
        /// Required. Example format: accounts/1234/userLinks/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUserLink(UserLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserLink(new DeleteUserLinkRequest
            {
                UserLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a user link on an account or property.
        /// </summary>
        /// <param name="name">
        /// Required. Example format: accounts/1234/userLinks/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserLinkAsync(UserLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserLinkAsync(new DeleteUserLinkRequest
            {
                UserLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a user link on an account or property.
        /// </summary>
        /// <param name="name">
        /// Required. Example format: accounts/1234/userLinks/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserLinkAsync(UserLinkName name, st::CancellationToken cancellationToken) =>
            DeleteUserLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes information about multiple users' links to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteUserLinks(BatchDeleteUserLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes information about multiple users' links to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteUserLinksAsync(BatchDeleteUserLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes information about multiple users' links to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteUserLinksAsync(BatchDeleteUserLinksRequest request, st::CancellationToken cancellationToken) =>
            BatchDeleteUserLinksAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Example: properties/1234
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
        /// Example: properties/1234
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
        /// Example: properties/1234
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
        /// Example: properties/1234
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
        /// Example: properties/1234
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
        /// Example: properties/1234
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
        /// Example: properties/1234/firebaseLinks/5678
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
        /// Example: properties/1234/firebaseLinks/5678
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
        /// Example: properties/1234/firebaseLinks/5678
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
        /// Example: properties/1234/firebaseLinks/5678
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
        /// Example: properties/1234/firebaseLinks/5678
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
        /// Example: properties/1234/firebaseLinks/5678
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
        /// Example: properties/1234
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
        public virtual gax::PagedEnumerable<ListFirebaseLinksResponse, FirebaseLink> ListFirebaseLinks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFirebaseLinks(new ListFirebaseLinksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists FirebaseLinks on a property.
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: properties/{property_id}
        /// Example: properties/1234
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
        public virtual gax::PagedAsyncEnumerable<ListFirebaseLinksResponse, FirebaseLink> ListFirebaseLinksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFirebaseLinksAsync(new ListFirebaseLinksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists FirebaseLinks on a property.
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: properties/{property_id}
        /// Example: properties/1234
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
        public virtual gax::PagedEnumerable<ListFirebaseLinksResponse, FirebaseLink> ListFirebaseLinks(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFirebaseLinks(new ListFirebaseLinksRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists FirebaseLinks on a property.
        /// Properties can have at most one FirebaseLink.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: properties/{property_id}
        /// Example: properties/1234
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
        public virtual gax::PagedAsyncEnumerable<ListFirebaseLinksResponse, FirebaseLink> ListFirebaseLinksAsync(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFirebaseLinksAsync(new ListFirebaseLinksRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the Site Tag for the specified web stream.
        /// Site Tags are immutable singletons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlobalSiteTag GetGlobalSiteTag(GetGlobalSiteTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Site Tag for the specified web stream.
        /// Site Tags are immutable singletons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlobalSiteTag> GetGlobalSiteTagAsync(GetGlobalSiteTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Site Tag for the specified web stream.
        /// Site Tags are immutable singletons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlobalSiteTag> GetGlobalSiteTagAsync(GetGlobalSiteTagRequest request, st::CancellationToken cancellationToken) =>
            GetGlobalSiteTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the Site Tag for the specified web stream.
        /// Site Tags are immutable singletons.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the site tag to lookup.
        /// Note that site tags are singletons and do not have unique IDs.
        /// Format: properties/{property_id}/dataStreams/{stream_id}/globalSiteTag
        /// Example: "properties/123/dataStreams/456/globalSiteTag"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlobalSiteTag GetGlobalSiteTag(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlobalSiteTag(new GetGlobalSiteTagRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the Site Tag for the specified web stream.
        /// Site Tags are immutable singletons.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the site tag to lookup.
        /// Note that site tags are singletons and do not have unique IDs.
        /// Format: properties/{property_id}/dataStreams/{stream_id}/globalSiteTag
        /// Example: "properties/123/dataStreams/456/globalSiteTag"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlobalSiteTag> GetGlobalSiteTagAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlobalSiteTagAsync(new GetGlobalSiteTagRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the Site Tag for the specified web stream.
        /// Site Tags are immutable singletons.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the site tag to lookup.
        /// Note that site tags are singletons and do not have unique IDs.
        /// Format: properties/{property_id}/dataStreams/{stream_id}/globalSiteTag
        /// Example: "properties/123/dataStreams/456/globalSiteTag"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlobalSiteTag> GetGlobalSiteTagAsync(string name, st::CancellationToken cancellationToken) =>
            GetGlobalSiteTagAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the Site Tag for the specified web stream.
        /// Site Tags are immutable singletons.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the site tag to lookup.
        /// Note that site tags are singletons and do not have unique IDs.
        /// Format: properties/{property_id}/dataStreams/{stream_id}/globalSiteTag
        /// Example: "properties/123/dataStreams/456/globalSiteTag"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlobalSiteTag GetGlobalSiteTag(GlobalSiteTagName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlobalSiteTag(new GetGlobalSiteTagRequest
            {
                GlobalSiteTagName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the Site Tag for the specified web stream.
        /// Site Tags are immutable singletons.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the site tag to lookup.
        /// Note that site tags are singletons and do not have unique IDs.
        /// Format: properties/{property_id}/dataStreams/{stream_id}/globalSiteTag
        /// Example: "properties/123/dataStreams/456/globalSiteTag"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlobalSiteTag> GetGlobalSiteTagAsync(GlobalSiteTagName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlobalSiteTagAsync(new GetGlobalSiteTagRequest
            {
                GlobalSiteTagName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the Site Tag for the specified web stream.
        /// Site Tags are immutable singletons.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the site tag to lookup.
        /// Note that site tags are singletons and do not have unique IDs.
        /// Format: properties/{property_id}/dataStreams/{stream_id}/globalSiteTag
        /// Example: "properties/123/dataStreams/456/globalSiteTag"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlobalSiteTag> GetGlobalSiteTagAsync(GlobalSiteTagName name, st::CancellationToken cancellationToken) =>
            GetGlobalSiteTagAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Required. The list of fields to be updated. Field names must be in snake case
        /// (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        /// the entire entity, use one path with the string "*" to match all fields.
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
        /// Required. The list of fields to be updated. Field names must be in snake case
        /// (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        /// the entire entity, use one path with the string "*" to match all fields.
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
        /// Required. The list of fields to be updated. Field names must be in snake case
        /// (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        /// the entire entity, use one path with the string "*" to match all fields.
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
        public virtual gax::PagedEnumerable<ListGoogleAdsLinksResponse, GoogleAdsLink> ListGoogleAdsLinks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGoogleAdsLinks(new ListGoogleAdsLinksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListGoogleAdsLinksResponse, GoogleAdsLink> ListGoogleAdsLinksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGoogleAdsLinksAsync(new ListGoogleAdsLinksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedEnumerable<ListGoogleAdsLinksResponse, GoogleAdsLink> ListGoogleAdsLinks(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGoogleAdsLinks(new ListGoogleAdsLinksRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListGoogleAdsLinksResponse, GoogleAdsLink> ListGoogleAdsLinksAsync(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGoogleAdsLinksAsync(new ListGoogleAdsLinksRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        /// Example: "accounts/1000/dataSharingSettings"
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
        /// Example: "accounts/1000/dataSharingSettings"
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
        /// Example: "accounts/1000/dataSharingSettings"
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
        /// Example: "accounts/1000/dataSharingSettings"
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
        /// Example: "accounts/1000/dataSharingSettings"
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
        /// Example: "accounts/1000/dataSharingSettings"
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
        public virtual gax::PagedEnumerable<ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret> ListMeasurementProtocolSecrets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMeasurementProtocolSecrets(new ListMeasurementProtocolSecretsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret> ListMeasurementProtocolSecretsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMeasurementProtocolSecretsAsync(new ListMeasurementProtocolSecretsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedEnumerable<ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret> ListMeasurementProtocolSecrets(DataStreamName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMeasurementProtocolSecrets(new ListMeasurementProtocolSecretsRequest
            {
                ParentAsDataStreamName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret> ListMeasurementProtocolSecretsAsync(DataStreamName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMeasurementProtocolSecretsAsync(new ListMeasurementProtocolSecretsRequest
            {
                ParentAsDataStreamName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        /// The list of fields to be updated. Omitted fields will not be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MeasurementProtocolSecret UpdateMeasurementProtocolSecret(MeasurementProtocolSecret measurementProtocolSecret, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMeasurementProtocolSecret(new UpdateMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecret = gax::GaxPreconditions.CheckNotNull(measurementProtocolSecret, nameof(measurementProtocolSecret)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a measurement protocol secret.
        /// </summary>
        /// <param name="measurementProtocolSecret">
        /// Required. The measurement protocol secret to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. Omitted fields will not be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeasurementProtocolSecret> UpdateMeasurementProtocolSecretAsync(MeasurementProtocolSecret measurementProtocolSecret, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMeasurementProtocolSecretAsync(new UpdateMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecret = gax::GaxPreconditions.CheckNotNull(measurementProtocolSecret, nameof(measurementProtocolSecret)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a measurement protocol secret.
        /// </summary>
        /// <param name="measurementProtocolSecret">
        /// Required. The measurement protocol secret to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. Omitted fields will not be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeasurementProtocolSecret> UpdateMeasurementProtocolSecretAsync(MeasurementProtocolSecret measurementProtocolSecret, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMeasurementProtocolSecretAsync(measurementProtocolSecret, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Acknowledges the terms of user data collection for the specified property.
        /// 
        /// This acknowledgement must be completed (either in the Google Analytics UI
        /// or via this API) before MeasurementProtocolSecret resources may be created.
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
        /// or via this API) before MeasurementProtocolSecret resources may be created.
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
        /// or via this API) before MeasurementProtocolSecret resources may be created.
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
        /// Lookup for Google Signals settings for a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleSignalsSettings GetGoogleSignalsSettings(GetGoogleSignalsSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for Google Signals settings for a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleSignalsSettings> GetGoogleSignalsSettingsAsync(GetGoogleSignalsSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for Google Signals settings for a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleSignalsSettings> GetGoogleSignalsSettingsAsync(GetGoogleSignalsSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetGoogleSignalsSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for Google Signals settings for a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the google signals settings to retrieve.
        /// Format: properties/{property}/googleSignalsSettings
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleSignalsSettings GetGoogleSignalsSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGoogleSignalsSettings(new GetGoogleSignalsSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for Google Signals settings for a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the google signals settings to retrieve.
        /// Format: properties/{property}/googleSignalsSettings
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleSignalsSettings> GetGoogleSignalsSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGoogleSignalsSettingsAsync(new GetGoogleSignalsSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for Google Signals settings for a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the google signals settings to retrieve.
        /// Format: properties/{property}/googleSignalsSettings
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleSignalsSettings> GetGoogleSignalsSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetGoogleSignalsSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for Google Signals settings for a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the google signals settings to retrieve.
        /// Format: properties/{property}/googleSignalsSettings
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleSignalsSettings GetGoogleSignalsSettings(GoogleSignalsSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGoogleSignalsSettings(new GetGoogleSignalsSettingsRequest
            {
                GoogleSignalsSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for Google Signals settings for a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the google signals settings to retrieve.
        /// Format: properties/{property}/googleSignalsSettings
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleSignalsSettings> GetGoogleSignalsSettingsAsync(GoogleSignalsSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGoogleSignalsSettingsAsync(new GetGoogleSignalsSettingsRequest
            {
                GoogleSignalsSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for Google Signals settings for a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the google signals settings to retrieve.
        /// Format: properties/{property}/googleSignalsSettings
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleSignalsSettings> GetGoogleSignalsSettingsAsync(GoogleSignalsSettingsName name, st::CancellationToken cancellationToken) =>
            GetGoogleSignalsSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates Google Signals settings for a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleSignalsSettings UpdateGoogleSignalsSettings(UpdateGoogleSignalsSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates Google Signals settings for a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleSignalsSettings> UpdateGoogleSignalsSettingsAsync(UpdateGoogleSignalsSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates Google Signals settings for a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleSignalsSettings> UpdateGoogleSignalsSettingsAsync(UpdateGoogleSignalsSettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateGoogleSignalsSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates Google Signals settings for a property.
        /// </summary>
        /// <param name="googleSignalsSettings">
        /// Required. The settings to update.
        /// The `name` field is used to identify the settings to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake case
        /// (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        /// the entire entity, use one path with the string "*" to match all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleSignalsSettings UpdateGoogleSignalsSettings(GoogleSignalsSettings googleSignalsSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGoogleSignalsSettings(new UpdateGoogleSignalsSettingsRequest
            {
                GoogleSignalsSettings = gax::GaxPreconditions.CheckNotNull(googleSignalsSettings, nameof(googleSignalsSettings)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates Google Signals settings for a property.
        /// </summary>
        /// <param name="googleSignalsSettings">
        /// Required. The settings to update.
        /// The `name` field is used to identify the settings to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake case
        /// (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        /// the entire entity, use one path with the string "*" to match all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleSignalsSettings> UpdateGoogleSignalsSettingsAsync(GoogleSignalsSettings googleSignalsSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGoogleSignalsSettingsAsync(new UpdateGoogleSignalsSettingsRequest
            {
                GoogleSignalsSettings = gax::GaxPreconditions.CheckNotNull(googleSignalsSettings, nameof(googleSignalsSettings)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates Google Signals settings for a property.
        /// </summary>
        /// <param name="googleSignalsSettings">
        /// Required. The settings to update.
        /// The `name` field is used to identify the settings to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Field names must be in snake case
        /// (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        /// the entire entity, use one path with the string "*" to match all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleSignalsSettings> UpdateGoogleSignalsSettingsAsync(GoogleSignalsSettings googleSignalsSettings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGoogleSignalsSettingsAsync(googleSignalsSettings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversionEvent CreateConversionEvent(CreateConversionEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionEvent> CreateConversionEventAsync(CreateConversionEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionEvent> CreateConversionEventAsync(CreateConversionEventRequest request, st::CancellationToken cancellationToken) =>
            CreateConversionEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property where this conversion event will
        /// be created. Format: properties/123
        /// </param>
        /// <param name="conversionEvent">
        /// Required. The conversion event to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversionEvent CreateConversionEvent(string parent, ConversionEvent conversionEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversionEvent(new CreateConversionEventRequest
            {
                ConversionEvent = gax::GaxPreconditions.CheckNotNull(conversionEvent, nameof(conversionEvent)),
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property where this conversion event will
        /// be created. Format: properties/123
        /// </param>
        /// <param name="conversionEvent">
        /// Required. The conversion event to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionEvent> CreateConversionEventAsync(string parent, ConversionEvent conversionEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversionEventAsync(new CreateConversionEventRequest
            {
                ConversionEvent = gax::GaxPreconditions.CheckNotNull(conversionEvent, nameof(conversionEvent)),
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property where this conversion event will
        /// be created. Format: properties/123
        /// </param>
        /// <param name="conversionEvent">
        /// Required. The conversion event to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionEvent> CreateConversionEventAsync(string parent, ConversionEvent conversionEvent, st::CancellationToken cancellationToken) =>
            CreateConversionEventAsync(parent, conversionEvent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property where this conversion event will
        /// be created. Format: properties/123
        /// </param>
        /// <param name="conversionEvent">
        /// Required. The conversion event to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversionEvent CreateConversionEvent(PropertyName parent, ConversionEvent conversionEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversionEvent(new CreateConversionEventRequest
            {
                ConversionEvent = gax::GaxPreconditions.CheckNotNull(conversionEvent, nameof(conversionEvent)),
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property where this conversion event will
        /// be created. Format: properties/123
        /// </param>
        /// <param name="conversionEvent">
        /// Required. The conversion event to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionEvent> CreateConversionEventAsync(PropertyName parent, ConversionEvent conversionEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversionEventAsync(new CreateConversionEventRequest
            {
                ConversionEvent = gax::GaxPreconditions.CheckNotNull(conversionEvent, nameof(conversionEvent)),
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent property where this conversion event will
        /// be created. Format: properties/123
        /// </param>
        /// <param name="conversionEvent">
        /// Required. The conversion event to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionEvent> CreateConversionEventAsync(PropertyName parent, ConversionEvent conversionEvent, st::CancellationToken cancellationToken) =>
            CreateConversionEventAsync(parent, conversionEvent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversionEvent GetConversionEvent(GetConversionEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionEvent> GetConversionEventAsync(GetConversionEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionEvent> GetConversionEventAsync(GetConversionEventRequest request, st::CancellationToken cancellationToken) =>
            GetConversionEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to retrieve.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversionEvent GetConversionEvent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionEvent(new GetConversionEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to retrieve.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionEvent> GetConversionEventAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionEventAsync(new GetConversionEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to retrieve.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionEvent> GetConversionEventAsync(string name, st::CancellationToken cancellationToken) =>
            GetConversionEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to retrieve.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversionEvent GetConversionEvent(ConversionEventName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionEvent(new GetConversionEventRequest
            {
                ConversionEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to retrieve.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionEvent> GetConversionEventAsync(ConversionEventName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionEventAsync(new GetConversionEventRequest
            {
                ConversionEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to retrieve.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionEvent> GetConversionEventAsync(ConversionEventName name, st::CancellationToken cancellationToken) =>
            GetConversionEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversionEvent(DeleteConversionEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversionEventAsync(DeleteConversionEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversionEventAsync(DeleteConversionEventRequest request, st::CancellationToken cancellationToken) =>
            DeleteConversionEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to delete.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversionEvent(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversionEvent(new DeleteConversionEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to delete.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversionEventAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversionEventAsync(new DeleteConversionEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to delete.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversionEventAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConversionEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to delete.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversionEvent(ConversionEventName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversionEvent(new DeleteConversionEventRequest
            {
                ConversionEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to delete.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversionEventAsync(ConversionEventName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversionEventAsync(new DeleteConversionEventRequest
            {
                ConversionEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversion event to delete.
        /// Format: properties/{property}/conversionEvents/{conversion_event}
        /// Example: "properties/123/conversionEvents/456"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversionEventAsync(ConversionEventName name, st::CancellationToken cancellationToken) =>
            DeleteConversionEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of conversion events in the specified parent property.
        /// 
        /// Returns an empty list if no conversion events are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConversionEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversionEventsResponse, ConversionEvent> ListConversionEvents(ListConversionEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of conversion events in the specified parent property.
        /// 
        /// Returns an empty list if no conversion events are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConversionEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversionEventsResponse, ConversionEvent> ListConversionEventsAsync(ListConversionEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
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
        public virtual gax::PagedEnumerable<ListConversionEventsResponse, ConversionEvent> ListConversionEvents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConversionEvents(new ListConversionEventsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
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
        public virtual gax::PagedAsyncEnumerable<ListConversionEventsResponse, ConversionEvent> ListConversionEventsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConversionEventsAsync(new ListConversionEventsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
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
        public virtual gax::PagedEnumerable<ListConversionEventsResponse, ConversionEvent> ListConversionEvents(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConversionEvents(new ListConversionEventsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
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
        public virtual gax::PagedAsyncEnumerable<ListConversionEventsResponse, ConversionEvent> ListConversionEventsAsync(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConversionEventsAsync(new ListConversionEventsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Look up a single DisplayVideo360AdvertiserLink
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DisplayVideo360AdvertiserLink GetDisplayVideo360AdvertiserLink(GetDisplayVideo360AdvertiserLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Look up a single DisplayVideo360AdvertiserLink
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLink> GetDisplayVideo360AdvertiserLinkAsync(GetDisplayVideo360AdvertiserLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Look up a single DisplayVideo360AdvertiserLink
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLink> GetDisplayVideo360AdvertiserLinkAsync(GetDisplayVideo360AdvertiserLinkRequest request, st::CancellationToken cancellationToken) =>
            GetDisplayVideo360AdvertiserLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Look up a single DisplayVideo360AdvertiserLink
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLink to get.
        /// Example format: properties/1234/displayVideo360AdvertiserLink/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DisplayVideo360AdvertiserLink GetDisplayVideo360AdvertiserLink(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDisplayVideo360AdvertiserLink(new GetDisplayVideo360AdvertiserLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Look up a single DisplayVideo360AdvertiserLink
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLink to get.
        /// Example format: properties/1234/displayVideo360AdvertiserLink/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLink> GetDisplayVideo360AdvertiserLinkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDisplayVideo360AdvertiserLinkAsync(new GetDisplayVideo360AdvertiserLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Look up a single DisplayVideo360AdvertiserLink
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLink to get.
        /// Example format: properties/1234/displayVideo360AdvertiserLink/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLink> GetDisplayVideo360AdvertiserLinkAsync(string name, st::CancellationToken cancellationToken) =>
            GetDisplayVideo360AdvertiserLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Look up a single DisplayVideo360AdvertiserLink
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLink to get.
        /// Example format: properties/1234/displayVideo360AdvertiserLink/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DisplayVideo360AdvertiserLink GetDisplayVideo360AdvertiserLink(DisplayVideo360AdvertiserLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDisplayVideo360AdvertiserLink(new GetDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Look up a single DisplayVideo360AdvertiserLink
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLink to get.
        /// Example format: properties/1234/displayVideo360AdvertiserLink/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLink> GetDisplayVideo360AdvertiserLinkAsync(DisplayVideo360AdvertiserLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDisplayVideo360AdvertiserLinkAsync(new GetDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Look up a single DisplayVideo360AdvertiserLink
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLink to get.
        /// Example format: properties/1234/displayVideo360AdvertiserLink/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLink> GetDisplayVideo360AdvertiserLinkAsync(DisplayVideo360AdvertiserLinkName name, st::CancellationToken cancellationToken) =>
            GetDisplayVideo360AdvertiserLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all DisplayVideo360AdvertiserLinks on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DisplayVideo360AdvertiserLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDisplayVideo360AdvertiserLinksResponse, DisplayVideo360AdvertiserLink> ListDisplayVideo360AdvertiserLinks(ListDisplayVideo360AdvertiserLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all DisplayVideo360AdvertiserLinks on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="DisplayVideo360AdvertiserLink"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDisplayVideo360AdvertiserLinksResponse, DisplayVideo360AdvertiserLink> ListDisplayVideo360AdvertiserLinksAsync(ListDisplayVideo360AdvertiserLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all DisplayVideo360AdvertiserLinks on a property.
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
        /// <returns>A pageable sequence of <see cref="DisplayVideo360AdvertiserLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDisplayVideo360AdvertiserLinksResponse, DisplayVideo360AdvertiserLink> ListDisplayVideo360AdvertiserLinks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDisplayVideo360AdvertiserLinks(new ListDisplayVideo360AdvertiserLinksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all DisplayVideo360AdvertiserLinks on a property.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="DisplayVideo360AdvertiserLink"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDisplayVideo360AdvertiserLinksResponse, DisplayVideo360AdvertiserLink> ListDisplayVideo360AdvertiserLinksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDisplayVideo360AdvertiserLinksAsync(new ListDisplayVideo360AdvertiserLinksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all DisplayVideo360AdvertiserLinks on a property.
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
        /// <returns>A pageable sequence of <see cref="DisplayVideo360AdvertiserLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDisplayVideo360AdvertiserLinksResponse, DisplayVideo360AdvertiserLink> ListDisplayVideo360AdvertiserLinks(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDisplayVideo360AdvertiserLinks(new ListDisplayVideo360AdvertiserLinksRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all DisplayVideo360AdvertiserLinks on a property.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="DisplayVideo360AdvertiserLink"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDisplayVideo360AdvertiserLinksResponse, DisplayVideo360AdvertiserLink> ListDisplayVideo360AdvertiserLinksAsync(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDisplayVideo360AdvertiserLinksAsync(new ListDisplayVideo360AdvertiserLinksRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLink.
        /// This can only be utilized by users who have proper authorization both on
        /// the Google Analytics property and on the Display &amp;amp; Video 360 advertiser.
        /// Users who do not have access to the Display &amp;amp; Video 360 advertiser should
        /// instead seek to create a DisplayVideo360LinkProposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DisplayVideo360AdvertiserLink CreateDisplayVideo360AdvertiserLink(CreateDisplayVideo360AdvertiserLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLink.
        /// This can only be utilized by users who have proper authorization both on
        /// the Google Analytics property and on the Display &amp;amp; Video 360 advertiser.
        /// Users who do not have access to the Display &amp;amp; Video 360 advertiser should
        /// instead seek to create a DisplayVideo360LinkProposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLink> CreateDisplayVideo360AdvertiserLinkAsync(CreateDisplayVideo360AdvertiserLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLink.
        /// This can only be utilized by users who have proper authorization both on
        /// the Google Analytics property and on the Display &amp;amp; Video 360 advertiser.
        /// Users who do not have access to the Display &amp;amp; Video 360 advertiser should
        /// instead seek to create a DisplayVideo360LinkProposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLink> CreateDisplayVideo360AdvertiserLinkAsync(CreateDisplayVideo360AdvertiserLinkRequest request, st::CancellationToken cancellationToken) =>
            CreateDisplayVideo360AdvertiserLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLink.
        /// This can only be utilized by users who have proper authorization both on
        /// the Google Analytics property and on the Display &amp;amp; Video 360 advertiser.
        /// Users who do not have access to the Display &amp;amp; Video 360 advertiser should
        /// instead seek to create a DisplayVideo360LinkProposal.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="displayVideo360AdvertiserLink">
        /// Required. The DisplayVideo360AdvertiserLink to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DisplayVideo360AdvertiserLink CreateDisplayVideo360AdvertiserLink(string parent, DisplayVideo360AdvertiserLink displayVideo360AdvertiserLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateDisplayVideo360AdvertiserLink(new CreateDisplayVideo360AdvertiserLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DisplayVideo360AdvertiserLink = gax::GaxPreconditions.CheckNotNull(displayVideo360AdvertiserLink, nameof(displayVideo360AdvertiserLink)),
            }, callSettings);

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLink.
        /// This can only be utilized by users who have proper authorization both on
        /// the Google Analytics property and on the Display &amp;amp; Video 360 advertiser.
        /// Users who do not have access to the Display &amp;amp; Video 360 advertiser should
        /// instead seek to create a DisplayVideo360LinkProposal.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="displayVideo360AdvertiserLink">
        /// Required. The DisplayVideo360AdvertiserLink to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLink> CreateDisplayVideo360AdvertiserLinkAsync(string parent, DisplayVideo360AdvertiserLink displayVideo360AdvertiserLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateDisplayVideo360AdvertiserLinkAsync(new CreateDisplayVideo360AdvertiserLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DisplayVideo360AdvertiserLink = gax::GaxPreconditions.CheckNotNull(displayVideo360AdvertiserLink, nameof(displayVideo360AdvertiserLink)),
            }, callSettings);

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLink.
        /// This can only be utilized by users who have proper authorization both on
        /// the Google Analytics property and on the Display &amp;amp; Video 360 advertiser.
        /// Users who do not have access to the Display &amp;amp; Video 360 advertiser should
        /// instead seek to create a DisplayVideo360LinkProposal.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="displayVideo360AdvertiserLink">
        /// Required. The DisplayVideo360AdvertiserLink to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLink> CreateDisplayVideo360AdvertiserLinkAsync(string parent, DisplayVideo360AdvertiserLink displayVideo360AdvertiserLink, st::CancellationToken cancellationToken) =>
            CreateDisplayVideo360AdvertiserLinkAsync(parent, displayVideo360AdvertiserLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLink.
        /// This can only be utilized by users who have proper authorization both on
        /// the Google Analytics property and on the Display &amp;amp; Video 360 advertiser.
        /// Users who do not have access to the Display &amp;amp; Video 360 advertiser should
        /// instead seek to create a DisplayVideo360LinkProposal.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="displayVideo360AdvertiserLink">
        /// Required. The DisplayVideo360AdvertiserLink to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DisplayVideo360AdvertiserLink CreateDisplayVideo360AdvertiserLink(PropertyName parent, DisplayVideo360AdvertiserLink displayVideo360AdvertiserLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateDisplayVideo360AdvertiserLink(new CreateDisplayVideo360AdvertiserLinkRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DisplayVideo360AdvertiserLink = gax::GaxPreconditions.CheckNotNull(displayVideo360AdvertiserLink, nameof(displayVideo360AdvertiserLink)),
            }, callSettings);

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLink.
        /// This can only be utilized by users who have proper authorization both on
        /// the Google Analytics property and on the Display &amp;amp; Video 360 advertiser.
        /// Users who do not have access to the Display &amp;amp; Video 360 advertiser should
        /// instead seek to create a DisplayVideo360LinkProposal.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="displayVideo360AdvertiserLink">
        /// Required. The DisplayVideo360AdvertiserLink to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLink> CreateDisplayVideo360AdvertiserLinkAsync(PropertyName parent, DisplayVideo360AdvertiserLink displayVideo360AdvertiserLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateDisplayVideo360AdvertiserLinkAsync(new CreateDisplayVideo360AdvertiserLinkRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DisplayVideo360AdvertiserLink = gax::GaxPreconditions.CheckNotNull(displayVideo360AdvertiserLink, nameof(displayVideo360AdvertiserLink)),
            }, callSettings);

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLink.
        /// This can only be utilized by users who have proper authorization both on
        /// the Google Analytics property and on the Display &amp;amp; Video 360 advertiser.
        /// Users who do not have access to the Display &amp;amp; Video 360 advertiser should
        /// instead seek to create a DisplayVideo360LinkProposal.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="displayVideo360AdvertiserLink">
        /// Required. The DisplayVideo360AdvertiserLink to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLink> CreateDisplayVideo360AdvertiserLinkAsync(PropertyName parent, DisplayVideo360AdvertiserLink displayVideo360AdvertiserLink, st::CancellationToken cancellationToken) =>
            CreateDisplayVideo360AdvertiserLinkAsync(parent, displayVideo360AdvertiserLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDisplayVideo360AdvertiserLink(DeleteDisplayVideo360AdvertiserLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDisplayVideo360AdvertiserLinkAsync(DeleteDisplayVideo360AdvertiserLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDisplayVideo360AdvertiserLinkAsync(DeleteDisplayVideo360AdvertiserLinkRequest request, st::CancellationToken cancellationToken) =>
            DeleteDisplayVideo360AdvertiserLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLink to delete.
        /// Example format: properties/1234/displayVideo360AdvertiserLinks/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDisplayVideo360AdvertiserLink(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDisplayVideo360AdvertiserLink(new DeleteDisplayVideo360AdvertiserLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLink to delete.
        /// Example format: properties/1234/displayVideo360AdvertiserLinks/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDisplayVideo360AdvertiserLinkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDisplayVideo360AdvertiserLinkAsync(new DeleteDisplayVideo360AdvertiserLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLink to delete.
        /// Example format: properties/1234/displayVideo360AdvertiserLinks/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDisplayVideo360AdvertiserLinkAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDisplayVideo360AdvertiserLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLink to delete.
        /// Example format: properties/1234/displayVideo360AdvertiserLinks/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDisplayVideo360AdvertiserLink(DisplayVideo360AdvertiserLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDisplayVideo360AdvertiserLink(new DeleteDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLink to delete.
        /// Example format: properties/1234/displayVideo360AdvertiserLinks/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDisplayVideo360AdvertiserLinkAsync(DisplayVideo360AdvertiserLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDisplayVideo360AdvertiserLinkAsync(new DeleteDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLink to delete.
        /// Example format: properties/1234/displayVideo360AdvertiserLinks/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDisplayVideo360AdvertiserLinkAsync(DisplayVideo360AdvertiserLinkName name, st::CancellationToken cancellationToken) =>
            DeleteDisplayVideo360AdvertiserLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DisplayVideo360AdvertiserLink UpdateDisplayVideo360AdvertiserLink(UpdateDisplayVideo360AdvertiserLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLink> UpdateDisplayVideo360AdvertiserLinkAsync(UpdateDisplayVideo360AdvertiserLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLink> UpdateDisplayVideo360AdvertiserLinkAsync(UpdateDisplayVideo360AdvertiserLinkRequest request, st::CancellationToken cancellationToken) =>
            UpdateDisplayVideo360AdvertiserLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="displayVideo360AdvertiserLink">
        /// The DisplayVideo360AdvertiserLink to update
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Omitted fields will not be updated.
        /// To replace the entire entity, use one path with the string "*" to match
        /// all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DisplayVideo360AdvertiserLink UpdateDisplayVideo360AdvertiserLink(DisplayVideo360AdvertiserLink displayVideo360AdvertiserLink, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDisplayVideo360AdvertiserLink(new UpdateDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLink = displayVideo360AdvertiserLink,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="displayVideo360AdvertiserLink">
        /// The DisplayVideo360AdvertiserLink to update
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Omitted fields will not be updated.
        /// To replace the entire entity, use one path with the string "*" to match
        /// all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLink> UpdateDisplayVideo360AdvertiserLinkAsync(DisplayVideo360AdvertiserLink displayVideo360AdvertiserLink, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDisplayVideo360AdvertiserLinkAsync(new UpdateDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLink = displayVideo360AdvertiserLink,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="displayVideo360AdvertiserLink">
        /// The DisplayVideo360AdvertiserLink to update
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. Omitted fields will not be updated.
        /// To replace the entire entity, use one path with the string "*" to match
        /// all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLink> UpdateDisplayVideo360AdvertiserLinkAsync(DisplayVideo360AdvertiserLink displayVideo360AdvertiserLink, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDisplayVideo360AdvertiserLinkAsync(displayVideo360AdvertiserLink, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DisplayVideo360AdvertiserLinkProposal GetDisplayVideo360AdvertiserLinkProposal(GetDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLinkProposal> GetDisplayVideo360AdvertiserLinkProposalAsync(GetDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLinkProposal> GetDisplayVideo360AdvertiserLinkProposalAsync(GetDisplayVideo360AdvertiserLinkProposalRequest request, st::CancellationToken cancellationToken) =>
            GetDisplayVideo360AdvertiserLinkProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to get.
        /// Example format: properties/1234/displayVideo360AdvertiserLinkProposals/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DisplayVideo360AdvertiserLinkProposal GetDisplayVideo360AdvertiserLinkProposal(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDisplayVideo360AdvertiserLinkProposal(new GetDisplayVideo360AdvertiserLinkProposalRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to get.
        /// Example format: properties/1234/displayVideo360AdvertiserLinkProposals/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLinkProposal> GetDisplayVideo360AdvertiserLinkProposalAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDisplayVideo360AdvertiserLinkProposalAsync(new GetDisplayVideo360AdvertiserLinkProposalRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to get.
        /// Example format: properties/1234/displayVideo360AdvertiserLinkProposals/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLinkProposal> GetDisplayVideo360AdvertiserLinkProposalAsync(string name, st::CancellationToken cancellationToken) =>
            GetDisplayVideo360AdvertiserLinkProposalAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to get.
        /// Example format: properties/1234/displayVideo360AdvertiserLinkProposals/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DisplayVideo360AdvertiserLinkProposal GetDisplayVideo360AdvertiserLinkProposal(DisplayVideo360AdvertiserLinkProposalName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDisplayVideo360AdvertiserLinkProposal(new GetDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to get.
        /// Example format: properties/1234/displayVideo360AdvertiserLinkProposals/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLinkProposal> GetDisplayVideo360AdvertiserLinkProposalAsync(DisplayVideo360AdvertiserLinkProposalName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDisplayVideo360AdvertiserLinkProposalAsync(new GetDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to get.
        /// Example format: properties/1234/displayVideo360AdvertiserLinkProposals/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLinkProposal> GetDisplayVideo360AdvertiserLinkProposalAsync(DisplayVideo360AdvertiserLinkProposalName name, st::CancellationToken cancellationToken) =>
            GetDisplayVideo360AdvertiserLinkProposalAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists DisplayVideo360AdvertiserLinkProposals on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DisplayVideo360AdvertiserLinkProposal"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDisplayVideo360AdvertiserLinkProposalsResponse, DisplayVideo360AdvertiserLinkProposal> ListDisplayVideo360AdvertiserLinkProposals(ListDisplayVideo360AdvertiserLinkProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DisplayVideo360AdvertiserLinkProposals on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="DisplayVideo360AdvertiserLinkProposal"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDisplayVideo360AdvertiserLinkProposalsResponse, DisplayVideo360AdvertiserLinkProposal> ListDisplayVideo360AdvertiserLinkProposalsAsync(ListDisplayVideo360AdvertiserLinkProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DisplayVideo360AdvertiserLinkProposals on a property.
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
        /// <returns>A pageable sequence of <see cref="DisplayVideo360AdvertiserLinkProposal"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDisplayVideo360AdvertiserLinkProposalsResponse, DisplayVideo360AdvertiserLinkProposal> ListDisplayVideo360AdvertiserLinkProposals(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDisplayVideo360AdvertiserLinkProposals(new ListDisplayVideo360AdvertiserLinkProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists DisplayVideo360AdvertiserLinkProposals on a property.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="DisplayVideo360AdvertiserLinkProposal"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDisplayVideo360AdvertiserLinkProposalsResponse, DisplayVideo360AdvertiserLinkProposal> ListDisplayVideo360AdvertiserLinkProposalsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDisplayVideo360AdvertiserLinkProposalsAsync(new ListDisplayVideo360AdvertiserLinkProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists DisplayVideo360AdvertiserLinkProposals on a property.
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
        /// <returns>A pageable sequence of <see cref="DisplayVideo360AdvertiserLinkProposal"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDisplayVideo360AdvertiserLinkProposalsResponse, DisplayVideo360AdvertiserLinkProposal> ListDisplayVideo360AdvertiserLinkProposals(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDisplayVideo360AdvertiserLinkProposals(new ListDisplayVideo360AdvertiserLinkProposalsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists DisplayVideo360AdvertiserLinkProposals on a property.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="DisplayVideo360AdvertiserLinkProposal"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDisplayVideo360AdvertiserLinkProposalsResponse, DisplayVideo360AdvertiserLinkProposal> ListDisplayVideo360AdvertiserLinkProposalsAsync(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDisplayVideo360AdvertiserLinkProposalsAsync(new ListDisplayVideo360AdvertiserLinkProposalsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DisplayVideo360AdvertiserLinkProposal CreateDisplayVideo360AdvertiserLinkProposal(CreateDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLinkProposal> CreateDisplayVideo360AdvertiserLinkProposalAsync(CreateDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLinkProposal> CreateDisplayVideo360AdvertiserLinkProposalAsync(CreateDisplayVideo360AdvertiserLinkProposalRequest request, st::CancellationToken cancellationToken) =>
            CreateDisplayVideo360AdvertiserLinkProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="displayVideo360AdvertiserLinkProposal">
        /// Required. The DisplayVideo360AdvertiserLinkProposal to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DisplayVideo360AdvertiserLinkProposal CreateDisplayVideo360AdvertiserLinkProposal(string parent, DisplayVideo360AdvertiserLinkProposal displayVideo360AdvertiserLinkProposal, gaxgrpc::CallSettings callSettings = null) =>
            CreateDisplayVideo360AdvertiserLinkProposal(new CreateDisplayVideo360AdvertiserLinkProposalRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DisplayVideo360AdvertiserLinkProposal = gax::GaxPreconditions.CheckNotNull(displayVideo360AdvertiserLinkProposal, nameof(displayVideo360AdvertiserLinkProposal)),
            }, callSettings);

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="displayVideo360AdvertiserLinkProposal">
        /// Required. The DisplayVideo360AdvertiserLinkProposal to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLinkProposal> CreateDisplayVideo360AdvertiserLinkProposalAsync(string parent, DisplayVideo360AdvertiserLinkProposal displayVideo360AdvertiserLinkProposal, gaxgrpc::CallSettings callSettings = null) =>
            CreateDisplayVideo360AdvertiserLinkProposalAsync(new CreateDisplayVideo360AdvertiserLinkProposalRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DisplayVideo360AdvertiserLinkProposal = gax::GaxPreconditions.CheckNotNull(displayVideo360AdvertiserLinkProposal, nameof(displayVideo360AdvertiserLinkProposal)),
            }, callSettings);

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="displayVideo360AdvertiserLinkProposal">
        /// Required. The DisplayVideo360AdvertiserLinkProposal to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLinkProposal> CreateDisplayVideo360AdvertiserLinkProposalAsync(string parent, DisplayVideo360AdvertiserLinkProposal displayVideo360AdvertiserLinkProposal, st::CancellationToken cancellationToken) =>
            CreateDisplayVideo360AdvertiserLinkProposalAsync(parent, displayVideo360AdvertiserLinkProposal, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="displayVideo360AdvertiserLinkProposal">
        /// Required. The DisplayVideo360AdvertiserLinkProposal to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DisplayVideo360AdvertiserLinkProposal CreateDisplayVideo360AdvertiserLinkProposal(PropertyName parent, DisplayVideo360AdvertiserLinkProposal displayVideo360AdvertiserLinkProposal, gaxgrpc::CallSettings callSettings = null) =>
            CreateDisplayVideo360AdvertiserLinkProposal(new CreateDisplayVideo360AdvertiserLinkProposalRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DisplayVideo360AdvertiserLinkProposal = gax::GaxPreconditions.CheckNotNull(displayVideo360AdvertiserLinkProposal, nameof(displayVideo360AdvertiserLinkProposal)),
            }, callSettings);

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="displayVideo360AdvertiserLinkProposal">
        /// Required. The DisplayVideo360AdvertiserLinkProposal to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLinkProposal> CreateDisplayVideo360AdvertiserLinkProposalAsync(PropertyName parent, DisplayVideo360AdvertiserLinkProposal displayVideo360AdvertiserLinkProposal, gaxgrpc::CallSettings callSettings = null) =>
            CreateDisplayVideo360AdvertiserLinkProposalAsync(new CreateDisplayVideo360AdvertiserLinkProposalRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DisplayVideo360AdvertiserLinkProposal = gax::GaxPreconditions.CheckNotNull(displayVideo360AdvertiserLinkProposal, nameof(displayVideo360AdvertiserLinkProposal)),
            }, callSettings);

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="parent">
        /// Required. Example format: properties/1234
        /// </param>
        /// <param name="displayVideo360AdvertiserLinkProposal">
        /// Required. The DisplayVideo360AdvertiserLinkProposal to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLinkProposal> CreateDisplayVideo360AdvertiserLinkProposalAsync(PropertyName parent, DisplayVideo360AdvertiserLinkProposal displayVideo360AdvertiserLinkProposal, st::CancellationToken cancellationToken) =>
            CreateDisplayVideo360AdvertiserLinkProposalAsync(parent, displayVideo360AdvertiserLinkProposal, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLinkProposal on a property.
        /// This can only be used on cancelled proposals.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDisplayVideo360AdvertiserLinkProposal(DeleteDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLinkProposal on a property.
        /// This can only be used on cancelled proposals.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDisplayVideo360AdvertiserLinkProposalAsync(DeleteDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLinkProposal on a property.
        /// This can only be used on cancelled proposals.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDisplayVideo360AdvertiserLinkProposalAsync(DeleteDisplayVideo360AdvertiserLinkProposalRequest request, st::CancellationToken cancellationToken) =>
            DeleteDisplayVideo360AdvertiserLinkProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLinkProposal on a property.
        /// This can only be used on cancelled proposals.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to delete.
        /// Example format: properties/1234/displayVideo360AdvertiserLinkProposals/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDisplayVideo360AdvertiserLinkProposal(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDisplayVideo360AdvertiserLinkProposal(new DeleteDisplayVideo360AdvertiserLinkProposalRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLinkProposal on a property.
        /// This can only be used on cancelled proposals.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to delete.
        /// Example format: properties/1234/displayVideo360AdvertiserLinkProposals/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDisplayVideo360AdvertiserLinkProposalAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDisplayVideo360AdvertiserLinkProposalAsync(new DeleteDisplayVideo360AdvertiserLinkProposalRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLinkProposal on a property.
        /// This can only be used on cancelled proposals.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to delete.
        /// Example format: properties/1234/displayVideo360AdvertiserLinkProposals/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDisplayVideo360AdvertiserLinkProposalAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDisplayVideo360AdvertiserLinkProposalAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLinkProposal on a property.
        /// This can only be used on cancelled proposals.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to delete.
        /// Example format: properties/1234/displayVideo360AdvertiserLinkProposals/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDisplayVideo360AdvertiserLinkProposal(DisplayVideo360AdvertiserLinkProposalName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDisplayVideo360AdvertiserLinkProposal(new DeleteDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLinkProposal on a property.
        /// This can only be used on cancelled proposals.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to delete.
        /// Example format: properties/1234/displayVideo360AdvertiserLinkProposals/5678
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDisplayVideo360AdvertiserLinkProposalAsync(DisplayVideo360AdvertiserLinkProposalName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDisplayVideo360AdvertiserLinkProposalAsync(new DeleteDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLinkProposal on a property.
        /// This can only be used on cancelled proposals.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to delete.
        /// Example format: properties/1234/displayVideo360AdvertiserLinkProposals/5678
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDisplayVideo360AdvertiserLinkProposalAsync(DisplayVideo360AdvertiserLinkProposalName name, st::CancellationToken cancellationToken) =>
            DeleteDisplayVideo360AdvertiserLinkProposalAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves a DisplayVideo360AdvertiserLinkProposal.
        /// The DisplayVideo360AdvertiserLinkProposal will be deleted and a new
        /// DisplayVideo360AdvertiserLink will be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApproveDisplayVideo360AdvertiserLinkProposalResponse ApproveDisplayVideo360AdvertiserLinkProposal(ApproveDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approves a DisplayVideo360AdvertiserLinkProposal.
        /// The DisplayVideo360AdvertiserLinkProposal will be deleted and a new
        /// DisplayVideo360AdvertiserLink will be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApproveDisplayVideo360AdvertiserLinkProposalResponse> ApproveDisplayVideo360AdvertiserLinkProposalAsync(ApproveDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approves a DisplayVideo360AdvertiserLinkProposal.
        /// The DisplayVideo360AdvertiserLinkProposal will be deleted and a new
        /// DisplayVideo360AdvertiserLink will be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApproveDisplayVideo360AdvertiserLinkProposalResponse> ApproveDisplayVideo360AdvertiserLinkProposalAsync(ApproveDisplayVideo360AdvertiserLinkProposalRequest request, st::CancellationToken cancellationToken) =>
            ApproveDisplayVideo360AdvertiserLinkProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a DisplayVideo360AdvertiserLinkProposal.
        /// Cancelling can mean either:
        /// - Declining a proposal initiated from Display &amp;amp; Video 360
        /// - Withdrawing a proposal initiated from Google Analytics
        /// After being cancelled, a proposal will eventually be deleted automatically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DisplayVideo360AdvertiserLinkProposal CancelDisplayVideo360AdvertiserLinkProposal(CancelDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a DisplayVideo360AdvertiserLinkProposal.
        /// Cancelling can mean either:
        /// - Declining a proposal initiated from Display &amp;amp; Video 360
        /// - Withdrawing a proposal initiated from Google Analytics
        /// After being cancelled, a proposal will eventually be deleted automatically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLinkProposal> CancelDisplayVideo360AdvertiserLinkProposalAsync(CancelDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a DisplayVideo360AdvertiserLinkProposal.
        /// Cancelling can mean either:
        /// - Declining a proposal initiated from Display &amp;amp; Video 360
        /// - Withdrawing a proposal initiated from Google Analytics
        /// After being cancelled, a proposal will eventually be deleted automatically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DisplayVideo360AdvertiserLinkProposal> CancelDisplayVideo360AdvertiserLinkProposalAsync(CancelDisplayVideo360AdvertiserLinkProposalRequest request, st::CancellationToken cancellationToken) =>
            CancelDisplayVideo360AdvertiserLinkProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Required. The list of fields to be updated. Omitted fields will not be updated.
        /// To replace the entire entity, use one path with the string "*" to match
        /// all fields.
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
        /// Required. The list of fields to be updated. Omitted fields will not be updated.
        /// To replace the entire entity, use one path with the string "*" to match
        /// all fields.
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
        /// Required. The list of fields to be updated. Omitted fields will not be updated.
        /// To replace the entire entity, use one path with the string "*" to match
        /// all fields.
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
        public virtual gax::PagedEnumerable<ListCustomDimensionsResponse, CustomDimension> ListCustomDimensions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCustomDimensions(new ListCustomDimensionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListCustomDimensionsResponse, CustomDimension> ListCustomDimensionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCustomDimensionsAsync(new ListCustomDimensionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedEnumerable<ListCustomDimensionsResponse, CustomDimension> ListCustomDimensions(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCustomDimensions(new ListCustomDimensionsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListCustomDimensionsResponse, CustomDimension> ListCustomDimensionsAsync(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCustomDimensionsAsync(new ListCustomDimensionsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        /// Required. The list of fields to be updated. Omitted fields will not be updated.
        /// To replace the entire entity, use one path with the string "*" to match
        /// all fields.
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
        /// Required. The list of fields to be updated. Omitted fields will not be updated.
        /// To replace the entire entity, use one path with the string "*" to match
        /// all fields.
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
        /// Required. The list of fields to be updated. Omitted fields will not be updated.
        /// To replace the entire entity, use one path with the string "*" to match
        /// all fields.
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
        public virtual gax::PagedEnumerable<ListCustomMetricsResponse, CustomMetric> ListCustomMetrics(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCustomMetrics(new ListCustomMetricsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListCustomMetricsResponse, CustomMetric> ListCustomMetricsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCustomMetricsAsync(new ListCustomMetricsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedEnumerable<ListCustomMetricsResponse, CustomMetric> ListCustomMetrics(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCustomMetrics(new ListCustomMetricsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListCustomMetricsResponse, CustomMetric> ListCustomMetricsAsync(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCustomMetricsAsync(new ListCustomMetricsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        /// Required. The list of fields to be updated. Field names must be in snake case
        /// (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        /// the entire entity, use one path with the string "*" to match all fields.
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
        /// Required. The list of fields to be updated. Field names must be in snake case
        /// (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        /// the entire entity, use one path with the string "*" to match all fields.
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
        /// Required. The list of fields to be updated. Field names must be in snake case
        /// (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        /// the entire entity, use one path with the string "*" to match all fields.
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
        /// Required. The list of fields to be updated. Omitted fields will not be updated.
        /// To replace the entire entity, use one path with the string "*" to match
        /// all fields.
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
        /// Required. The list of fields to be updated. Omitted fields will not be updated.
        /// To replace the entire entity, use one path with the string "*" to match
        /// all fields.
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
        /// Required. The list of fields to be updated. Omitted fields will not be updated.
        /// To replace the entire entity, use one path with the string "*" to match
        /// all fields.
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
        public virtual gax::PagedEnumerable<ListDataStreamsResponse, DataStream> ListDataStreams(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDataStreams(new ListDataStreamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListDataStreamsResponse, DataStream> ListDataStreamsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDataStreamsAsync(new ListDataStreamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedEnumerable<ListDataStreamsResponse, DataStream> ListDataStreams(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDataStreams(new ListDataStreamsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        public virtual gax::PagedAsyncEnumerable<ListDataStreamsResponse, DataStream> ListDataStreamsAsync(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDataStreamsAsync(new ListDataStreamsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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

        private readonly gaxgrpc::ApiCall<GetUserLinkRequest, UserLink> _callGetUserLink;

        private readonly gaxgrpc::ApiCall<BatchGetUserLinksRequest, BatchGetUserLinksResponse> _callBatchGetUserLinks;

        private readonly gaxgrpc::ApiCall<ListUserLinksRequest, ListUserLinksResponse> _callListUserLinks;

        private readonly gaxgrpc::ApiCall<AuditUserLinksRequest, AuditUserLinksResponse> _callAuditUserLinks;

        private readonly gaxgrpc::ApiCall<CreateUserLinkRequest, UserLink> _callCreateUserLink;

        private readonly gaxgrpc::ApiCall<BatchCreateUserLinksRequest, BatchCreateUserLinksResponse> _callBatchCreateUserLinks;

        private readonly gaxgrpc::ApiCall<UpdateUserLinkRequest, UserLink> _callUpdateUserLink;

        private readonly gaxgrpc::ApiCall<BatchUpdateUserLinksRequest, BatchUpdateUserLinksResponse> _callBatchUpdateUserLinks;

        private readonly gaxgrpc::ApiCall<DeleteUserLinkRequest, wkt::Empty> _callDeleteUserLink;

        private readonly gaxgrpc::ApiCall<BatchDeleteUserLinksRequest, wkt::Empty> _callBatchDeleteUserLinks;

        private readonly gaxgrpc::ApiCall<CreateFirebaseLinkRequest, FirebaseLink> _callCreateFirebaseLink;

        private readonly gaxgrpc::ApiCall<DeleteFirebaseLinkRequest, wkt::Empty> _callDeleteFirebaseLink;

        private readonly gaxgrpc::ApiCall<ListFirebaseLinksRequest, ListFirebaseLinksResponse> _callListFirebaseLinks;

        private readonly gaxgrpc::ApiCall<GetGlobalSiteTagRequest, GlobalSiteTag> _callGetGlobalSiteTag;

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

        private readonly gaxgrpc::ApiCall<GetGoogleSignalsSettingsRequest, GoogleSignalsSettings> _callGetGoogleSignalsSettings;

        private readonly gaxgrpc::ApiCall<UpdateGoogleSignalsSettingsRequest, GoogleSignalsSettings> _callUpdateGoogleSignalsSettings;

        private readonly gaxgrpc::ApiCall<CreateConversionEventRequest, ConversionEvent> _callCreateConversionEvent;

        private readonly gaxgrpc::ApiCall<GetConversionEventRequest, ConversionEvent> _callGetConversionEvent;

        private readonly gaxgrpc::ApiCall<DeleteConversionEventRequest, wkt::Empty> _callDeleteConversionEvent;

        private readonly gaxgrpc::ApiCall<ListConversionEventsRequest, ListConversionEventsResponse> _callListConversionEvents;

        private readonly gaxgrpc::ApiCall<GetDisplayVideo360AdvertiserLinkRequest, DisplayVideo360AdvertiserLink> _callGetDisplayVideo360AdvertiserLink;

        private readonly gaxgrpc::ApiCall<ListDisplayVideo360AdvertiserLinksRequest, ListDisplayVideo360AdvertiserLinksResponse> _callListDisplayVideo360AdvertiserLinks;

        private readonly gaxgrpc::ApiCall<CreateDisplayVideo360AdvertiserLinkRequest, DisplayVideo360AdvertiserLink> _callCreateDisplayVideo360AdvertiserLink;

        private readonly gaxgrpc::ApiCall<DeleteDisplayVideo360AdvertiserLinkRequest, wkt::Empty> _callDeleteDisplayVideo360AdvertiserLink;

        private readonly gaxgrpc::ApiCall<UpdateDisplayVideo360AdvertiserLinkRequest, DisplayVideo360AdvertiserLink> _callUpdateDisplayVideo360AdvertiserLink;

        private readonly gaxgrpc::ApiCall<GetDisplayVideo360AdvertiserLinkProposalRequest, DisplayVideo360AdvertiserLinkProposal> _callGetDisplayVideo360AdvertiserLinkProposal;

        private readonly gaxgrpc::ApiCall<ListDisplayVideo360AdvertiserLinkProposalsRequest, ListDisplayVideo360AdvertiserLinkProposalsResponse> _callListDisplayVideo360AdvertiserLinkProposals;

        private readonly gaxgrpc::ApiCall<CreateDisplayVideo360AdvertiserLinkProposalRequest, DisplayVideo360AdvertiserLinkProposal> _callCreateDisplayVideo360AdvertiserLinkProposal;

        private readonly gaxgrpc::ApiCall<DeleteDisplayVideo360AdvertiserLinkProposalRequest, wkt::Empty> _callDeleteDisplayVideo360AdvertiserLinkProposal;

        private readonly gaxgrpc::ApiCall<ApproveDisplayVideo360AdvertiserLinkProposalRequest, ApproveDisplayVideo360AdvertiserLinkProposalResponse> _callApproveDisplayVideo360AdvertiserLinkProposal;

        private readonly gaxgrpc::ApiCall<CancelDisplayVideo360AdvertiserLinkProposalRequest, DisplayVideo360AdvertiserLinkProposal> _callCancelDisplayVideo360AdvertiserLinkProposal;

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
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
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
            _callGetUserLink = clientHelper.BuildApiCall<GetUserLinkRequest, UserLink>("GetUserLink", grpcClient.GetUserLinkAsync, grpcClient.GetUserLink, effectiveSettings.GetUserLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUserLink);
            Modify_GetUserLinkApiCall(ref _callGetUserLink);
            _callBatchGetUserLinks = clientHelper.BuildApiCall<BatchGetUserLinksRequest, BatchGetUserLinksResponse>("BatchGetUserLinks", grpcClient.BatchGetUserLinksAsync, grpcClient.BatchGetUserLinks, effectiveSettings.BatchGetUserLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchGetUserLinks);
            Modify_BatchGetUserLinksApiCall(ref _callBatchGetUserLinks);
            _callListUserLinks = clientHelper.BuildApiCall<ListUserLinksRequest, ListUserLinksResponse>("ListUserLinks", grpcClient.ListUserLinksAsync, grpcClient.ListUserLinks, effectiveSettings.ListUserLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUserLinks);
            Modify_ListUserLinksApiCall(ref _callListUserLinks);
            _callAuditUserLinks = clientHelper.BuildApiCall<AuditUserLinksRequest, AuditUserLinksResponse>("AuditUserLinks", grpcClient.AuditUserLinksAsync, grpcClient.AuditUserLinks, effectiveSettings.AuditUserLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callAuditUserLinks);
            Modify_AuditUserLinksApiCall(ref _callAuditUserLinks);
            _callCreateUserLink = clientHelper.BuildApiCall<CreateUserLinkRequest, UserLink>("CreateUserLink", grpcClient.CreateUserLinkAsync, grpcClient.CreateUserLink, effectiveSettings.CreateUserLinkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUserLink);
            Modify_CreateUserLinkApiCall(ref _callCreateUserLink);
            _callBatchCreateUserLinks = clientHelper.BuildApiCall<BatchCreateUserLinksRequest, BatchCreateUserLinksResponse>("BatchCreateUserLinks", grpcClient.BatchCreateUserLinksAsync, grpcClient.BatchCreateUserLinks, effectiveSettings.BatchCreateUserLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateUserLinks);
            Modify_BatchCreateUserLinksApiCall(ref _callBatchCreateUserLinks);
            _callUpdateUserLink = clientHelper.BuildApiCall<UpdateUserLinkRequest, UserLink>("UpdateUserLink", grpcClient.UpdateUserLinkAsync, grpcClient.UpdateUserLink, effectiveSettings.UpdateUserLinkSettings).WithGoogleRequestParam("user_link.name", request => request.UserLink?.Name);
            Modify_ApiCall(ref _callUpdateUserLink);
            Modify_UpdateUserLinkApiCall(ref _callUpdateUserLink);
            _callBatchUpdateUserLinks = clientHelper.BuildApiCall<BatchUpdateUserLinksRequest, BatchUpdateUserLinksResponse>("BatchUpdateUserLinks", grpcClient.BatchUpdateUserLinksAsync, grpcClient.BatchUpdateUserLinks, effectiveSettings.BatchUpdateUserLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateUserLinks);
            Modify_BatchUpdateUserLinksApiCall(ref _callBatchUpdateUserLinks);
            _callDeleteUserLink = clientHelper.BuildApiCall<DeleteUserLinkRequest, wkt::Empty>("DeleteUserLink", grpcClient.DeleteUserLinkAsync, grpcClient.DeleteUserLink, effectiveSettings.DeleteUserLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteUserLink);
            Modify_DeleteUserLinkApiCall(ref _callDeleteUserLink);
            _callBatchDeleteUserLinks = clientHelper.BuildApiCall<BatchDeleteUserLinksRequest, wkt::Empty>("BatchDeleteUserLinks", grpcClient.BatchDeleteUserLinksAsync, grpcClient.BatchDeleteUserLinks, effectiveSettings.BatchDeleteUserLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeleteUserLinks);
            Modify_BatchDeleteUserLinksApiCall(ref _callBatchDeleteUserLinks);
            _callCreateFirebaseLink = clientHelper.BuildApiCall<CreateFirebaseLinkRequest, FirebaseLink>("CreateFirebaseLink", grpcClient.CreateFirebaseLinkAsync, grpcClient.CreateFirebaseLink, effectiveSettings.CreateFirebaseLinkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFirebaseLink);
            Modify_CreateFirebaseLinkApiCall(ref _callCreateFirebaseLink);
            _callDeleteFirebaseLink = clientHelper.BuildApiCall<DeleteFirebaseLinkRequest, wkt::Empty>("DeleteFirebaseLink", grpcClient.DeleteFirebaseLinkAsync, grpcClient.DeleteFirebaseLink, effectiveSettings.DeleteFirebaseLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFirebaseLink);
            Modify_DeleteFirebaseLinkApiCall(ref _callDeleteFirebaseLink);
            _callListFirebaseLinks = clientHelper.BuildApiCall<ListFirebaseLinksRequest, ListFirebaseLinksResponse>("ListFirebaseLinks", grpcClient.ListFirebaseLinksAsync, grpcClient.ListFirebaseLinks, effectiveSettings.ListFirebaseLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFirebaseLinks);
            Modify_ListFirebaseLinksApiCall(ref _callListFirebaseLinks);
            _callGetGlobalSiteTag = clientHelper.BuildApiCall<GetGlobalSiteTagRequest, GlobalSiteTag>("GetGlobalSiteTag", grpcClient.GetGlobalSiteTagAsync, grpcClient.GetGlobalSiteTag, effectiveSettings.GetGlobalSiteTagSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGlobalSiteTag);
            Modify_GetGlobalSiteTagApiCall(ref _callGetGlobalSiteTag);
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
            _callGetGoogleSignalsSettings = clientHelper.BuildApiCall<GetGoogleSignalsSettingsRequest, GoogleSignalsSettings>("GetGoogleSignalsSettings", grpcClient.GetGoogleSignalsSettingsAsync, grpcClient.GetGoogleSignalsSettings, effectiveSettings.GetGoogleSignalsSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGoogleSignalsSettings);
            Modify_GetGoogleSignalsSettingsApiCall(ref _callGetGoogleSignalsSettings);
            _callUpdateGoogleSignalsSettings = clientHelper.BuildApiCall<UpdateGoogleSignalsSettingsRequest, GoogleSignalsSettings>("UpdateGoogleSignalsSettings", grpcClient.UpdateGoogleSignalsSettingsAsync, grpcClient.UpdateGoogleSignalsSettings, effectiveSettings.UpdateGoogleSignalsSettingsSettings).WithGoogleRequestParam("google_signals_settings.name", request => request.GoogleSignalsSettings?.Name);
            Modify_ApiCall(ref _callUpdateGoogleSignalsSettings);
            Modify_UpdateGoogleSignalsSettingsApiCall(ref _callUpdateGoogleSignalsSettings);
            _callCreateConversionEvent = clientHelper.BuildApiCall<CreateConversionEventRequest, ConversionEvent>("CreateConversionEvent", grpcClient.CreateConversionEventAsync, grpcClient.CreateConversionEvent, effectiveSettings.CreateConversionEventSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConversionEvent);
            Modify_CreateConversionEventApiCall(ref _callCreateConversionEvent);
            _callGetConversionEvent = clientHelper.BuildApiCall<GetConversionEventRequest, ConversionEvent>("GetConversionEvent", grpcClient.GetConversionEventAsync, grpcClient.GetConversionEvent, effectiveSettings.GetConversionEventSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConversionEvent);
            Modify_GetConversionEventApiCall(ref _callGetConversionEvent);
            _callDeleteConversionEvent = clientHelper.BuildApiCall<DeleteConversionEventRequest, wkt::Empty>("DeleteConversionEvent", grpcClient.DeleteConversionEventAsync, grpcClient.DeleteConversionEvent, effectiveSettings.DeleteConversionEventSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConversionEvent);
            Modify_DeleteConversionEventApiCall(ref _callDeleteConversionEvent);
            _callListConversionEvents = clientHelper.BuildApiCall<ListConversionEventsRequest, ListConversionEventsResponse>("ListConversionEvents", grpcClient.ListConversionEventsAsync, grpcClient.ListConversionEvents, effectiveSettings.ListConversionEventsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConversionEvents);
            Modify_ListConversionEventsApiCall(ref _callListConversionEvents);
            _callGetDisplayVideo360AdvertiserLink = clientHelper.BuildApiCall<GetDisplayVideo360AdvertiserLinkRequest, DisplayVideo360AdvertiserLink>("GetDisplayVideo360AdvertiserLink", grpcClient.GetDisplayVideo360AdvertiserLinkAsync, grpcClient.GetDisplayVideo360AdvertiserLink, effectiveSettings.GetDisplayVideo360AdvertiserLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDisplayVideo360AdvertiserLink);
            Modify_GetDisplayVideo360AdvertiserLinkApiCall(ref _callGetDisplayVideo360AdvertiserLink);
            _callListDisplayVideo360AdvertiserLinks = clientHelper.BuildApiCall<ListDisplayVideo360AdvertiserLinksRequest, ListDisplayVideo360AdvertiserLinksResponse>("ListDisplayVideo360AdvertiserLinks", grpcClient.ListDisplayVideo360AdvertiserLinksAsync, grpcClient.ListDisplayVideo360AdvertiserLinks, effectiveSettings.ListDisplayVideo360AdvertiserLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDisplayVideo360AdvertiserLinks);
            Modify_ListDisplayVideo360AdvertiserLinksApiCall(ref _callListDisplayVideo360AdvertiserLinks);
            _callCreateDisplayVideo360AdvertiserLink = clientHelper.BuildApiCall<CreateDisplayVideo360AdvertiserLinkRequest, DisplayVideo360AdvertiserLink>("CreateDisplayVideo360AdvertiserLink", grpcClient.CreateDisplayVideo360AdvertiserLinkAsync, grpcClient.CreateDisplayVideo360AdvertiserLink, effectiveSettings.CreateDisplayVideo360AdvertiserLinkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDisplayVideo360AdvertiserLink);
            Modify_CreateDisplayVideo360AdvertiserLinkApiCall(ref _callCreateDisplayVideo360AdvertiserLink);
            _callDeleteDisplayVideo360AdvertiserLink = clientHelper.BuildApiCall<DeleteDisplayVideo360AdvertiserLinkRequest, wkt::Empty>("DeleteDisplayVideo360AdvertiserLink", grpcClient.DeleteDisplayVideo360AdvertiserLinkAsync, grpcClient.DeleteDisplayVideo360AdvertiserLink, effectiveSettings.DeleteDisplayVideo360AdvertiserLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDisplayVideo360AdvertiserLink);
            Modify_DeleteDisplayVideo360AdvertiserLinkApiCall(ref _callDeleteDisplayVideo360AdvertiserLink);
            _callUpdateDisplayVideo360AdvertiserLink = clientHelper.BuildApiCall<UpdateDisplayVideo360AdvertiserLinkRequest, DisplayVideo360AdvertiserLink>("UpdateDisplayVideo360AdvertiserLink", grpcClient.UpdateDisplayVideo360AdvertiserLinkAsync, grpcClient.UpdateDisplayVideo360AdvertiserLink, effectiveSettings.UpdateDisplayVideo360AdvertiserLinkSettings).WithGoogleRequestParam("display_video_360_advertiser_link.name", request => request.DisplayVideo360AdvertiserLink?.Name);
            Modify_ApiCall(ref _callUpdateDisplayVideo360AdvertiserLink);
            Modify_UpdateDisplayVideo360AdvertiserLinkApiCall(ref _callUpdateDisplayVideo360AdvertiserLink);
            _callGetDisplayVideo360AdvertiserLinkProposal = clientHelper.BuildApiCall<GetDisplayVideo360AdvertiserLinkProposalRequest, DisplayVideo360AdvertiserLinkProposal>("GetDisplayVideo360AdvertiserLinkProposal", grpcClient.GetDisplayVideo360AdvertiserLinkProposalAsync, grpcClient.GetDisplayVideo360AdvertiserLinkProposal, effectiveSettings.GetDisplayVideo360AdvertiserLinkProposalSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDisplayVideo360AdvertiserLinkProposal);
            Modify_GetDisplayVideo360AdvertiserLinkProposalApiCall(ref _callGetDisplayVideo360AdvertiserLinkProposal);
            _callListDisplayVideo360AdvertiserLinkProposals = clientHelper.BuildApiCall<ListDisplayVideo360AdvertiserLinkProposalsRequest, ListDisplayVideo360AdvertiserLinkProposalsResponse>("ListDisplayVideo360AdvertiserLinkProposals", grpcClient.ListDisplayVideo360AdvertiserLinkProposalsAsync, grpcClient.ListDisplayVideo360AdvertiserLinkProposals, effectiveSettings.ListDisplayVideo360AdvertiserLinkProposalsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDisplayVideo360AdvertiserLinkProposals);
            Modify_ListDisplayVideo360AdvertiserLinkProposalsApiCall(ref _callListDisplayVideo360AdvertiserLinkProposals);
            _callCreateDisplayVideo360AdvertiserLinkProposal = clientHelper.BuildApiCall<CreateDisplayVideo360AdvertiserLinkProposalRequest, DisplayVideo360AdvertiserLinkProposal>("CreateDisplayVideo360AdvertiserLinkProposal", grpcClient.CreateDisplayVideo360AdvertiserLinkProposalAsync, grpcClient.CreateDisplayVideo360AdvertiserLinkProposal, effectiveSettings.CreateDisplayVideo360AdvertiserLinkProposalSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDisplayVideo360AdvertiserLinkProposal);
            Modify_CreateDisplayVideo360AdvertiserLinkProposalApiCall(ref _callCreateDisplayVideo360AdvertiserLinkProposal);
            _callDeleteDisplayVideo360AdvertiserLinkProposal = clientHelper.BuildApiCall<DeleteDisplayVideo360AdvertiserLinkProposalRequest, wkt::Empty>("DeleteDisplayVideo360AdvertiserLinkProposal", grpcClient.DeleteDisplayVideo360AdvertiserLinkProposalAsync, grpcClient.DeleteDisplayVideo360AdvertiserLinkProposal, effectiveSettings.DeleteDisplayVideo360AdvertiserLinkProposalSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDisplayVideo360AdvertiserLinkProposal);
            Modify_DeleteDisplayVideo360AdvertiserLinkProposalApiCall(ref _callDeleteDisplayVideo360AdvertiserLinkProposal);
            _callApproveDisplayVideo360AdvertiserLinkProposal = clientHelper.BuildApiCall<ApproveDisplayVideo360AdvertiserLinkProposalRequest, ApproveDisplayVideo360AdvertiserLinkProposalResponse>("ApproveDisplayVideo360AdvertiserLinkProposal", grpcClient.ApproveDisplayVideo360AdvertiserLinkProposalAsync, grpcClient.ApproveDisplayVideo360AdvertiserLinkProposal, effectiveSettings.ApproveDisplayVideo360AdvertiserLinkProposalSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callApproveDisplayVideo360AdvertiserLinkProposal);
            Modify_ApproveDisplayVideo360AdvertiserLinkProposalApiCall(ref _callApproveDisplayVideo360AdvertiserLinkProposal);
            _callCancelDisplayVideo360AdvertiserLinkProposal = clientHelper.BuildApiCall<CancelDisplayVideo360AdvertiserLinkProposalRequest, DisplayVideo360AdvertiserLinkProposal>("CancelDisplayVideo360AdvertiserLinkProposal", grpcClient.CancelDisplayVideo360AdvertiserLinkProposalAsync, grpcClient.CancelDisplayVideo360AdvertiserLinkProposal, effectiveSettings.CancelDisplayVideo360AdvertiserLinkProposalSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelDisplayVideo360AdvertiserLinkProposal);
            Modify_CancelDisplayVideo360AdvertiserLinkProposalApiCall(ref _callCancelDisplayVideo360AdvertiserLinkProposal);
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

        partial void Modify_GetUserLinkApiCall(ref gaxgrpc::ApiCall<GetUserLinkRequest, UserLink> call);

        partial void Modify_BatchGetUserLinksApiCall(ref gaxgrpc::ApiCall<BatchGetUserLinksRequest, BatchGetUserLinksResponse> call);

        partial void Modify_ListUserLinksApiCall(ref gaxgrpc::ApiCall<ListUserLinksRequest, ListUserLinksResponse> call);

        partial void Modify_AuditUserLinksApiCall(ref gaxgrpc::ApiCall<AuditUserLinksRequest, AuditUserLinksResponse> call);

        partial void Modify_CreateUserLinkApiCall(ref gaxgrpc::ApiCall<CreateUserLinkRequest, UserLink> call);

        partial void Modify_BatchCreateUserLinksApiCall(ref gaxgrpc::ApiCall<BatchCreateUserLinksRequest, BatchCreateUserLinksResponse> call);

        partial void Modify_UpdateUserLinkApiCall(ref gaxgrpc::ApiCall<UpdateUserLinkRequest, UserLink> call);

        partial void Modify_BatchUpdateUserLinksApiCall(ref gaxgrpc::ApiCall<BatchUpdateUserLinksRequest, BatchUpdateUserLinksResponse> call);

        partial void Modify_DeleteUserLinkApiCall(ref gaxgrpc::ApiCall<DeleteUserLinkRequest, wkt::Empty> call);

        partial void Modify_BatchDeleteUserLinksApiCall(ref gaxgrpc::ApiCall<BatchDeleteUserLinksRequest, wkt::Empty> call);

        partial void Modify_CreateFirebaseLinkApiCall(ref gaxgrpc::ApiCall<CreateFirebaseLinkRequest, FirebaseLink> call);

        partial void Modify_DeleteFirebaseLinkApiCall(ref gaxgrpc::ApiCall<DeleteFirebaseLinkRequest, wkt::Empty> call);

        partial void Modify_ListFirebaseLinksApiCall(ref gaxgrpc::ApiCall<ListFirebaseLinksRequest, ListFirebaseLinksResponse> call);

        partial void Modify_GetGlobalSiteTagApiCall(ref gaxgrpc::ApiCall<GetGlobalSiteTagRequest, GlobalSiteTag> call);

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

        partial void Modify_GetGoogleSignalsSettingsApiCall(ref gaxgrpc::ApiCall<GetGoogleSignalsSettingsRequest, GoogleSignalsSettings> call);

        partial void Modify_UpdateGoogleSignalsSettingsApiCall(ref gaxgrpc::ApiCall<UpdateGoogleSignalsSettingsRequest, GoogleSignalsSettings> call);

        partial void Modify_CreateConversionEventApiCall(ref gaxgrpc::ApiCall<CreateConversionEventRequest, ConversionEvent> call);

        partial void Modify_GetConversionEventApiCall(ref gaxgrpc::ApiCall<GetConversionEventRequest, ConversionEvent> call);

        partial void Modify_DeleteConversionEventApiCall(ref gaxgrpc::ApiCall<DeleteConversionEventRequest, wkt::Empty> call);

        partial void Modify_ListConversionEventsApiCall(ref gaxgrpc::ApiCall<ListConversionEventsRequest, ListConversionEventsResponse> call);

        partial void Modify_GetDisplayVideo360AdvertiserLinkApiCall(ref gaxgrpc::ApiCall<GetDisplayVideo360AdvertiserLinkRequest, DisplayVideo360AdvertiserLink> call);

        partial void Modify_ListDisplayVideo360AdvertiserLinksApiCall(ref gaxgrpc::ApiCall<ListDisplayVideo360AdvertiserLinksRequest, ListDisplayVideo360AdvertiserLinksResponse> call);

        partial void Modify_CreateDisplayVideo360AdvertiserLinkApiCall(ref gaxgrpc::ApiCall<CreateDisplayVideo360AdvertiserLinkRequest, DisplayVideo360AdvertiserLink> call);

        partial void Modify_DeleteDisplayVideo360AdvertiserLinkApiCall(ref gaxgrpc::ApiCall<DeleteDisplayVideo360AdvertiserLinkRequest, wkt::Empty> call);

        partial void Modify_UpdateDisplayVideo360AdvertiserLinkApiCall(ref gaxgrpc::ApiCall<UpdateDisplayVideo360AdvertiserLinkRequest, DisplayVideo360AdvertiserLink> call);

        partial void Modify_GetDisplayVideo360AdvertiserLinkProposalApiCall(ref gaxgrpc::ApiCall<GetDisplayVideo360AdvertiserLinkProposalRequest, DisplayVideo360AdvertiserLinkProposal> call);

        partial void Modify_ListDisplayVideo360AdvertiserLinkProposalsApiCall(ref gaxgrpc::ApiCall<ListDisplayVideo360AdvertiserLinkProposalsRequest, ListDisplayVideo360AdvertiserLinkProposalsResponse> call);

        partial void Modify_CreateDisplayVideo360AdvertiserLinkProposalApiCall(ref gaxgrpc::ApiCall<CreateDisplayVideo360AdvertiserLinkProposalRequest, DisplayVideo360AdvertiserLinkProposal> call);

        partial void Modify_DeleteDisplayVideo360AdvertiserLinkProposalApiCall(ref gaxgrpc::ApiCall<DeleteDisplayVideo360AdvertiserLinkProposalRequest, wkt::Empty> call);

        partial void Modify_ApproveDisplayVideo360AdvertiserLinkProposalApiCall(ref gaxgrpc::ApiCall<ApproveDisplayVideo360AdvertiserLinkProposalRequest, ApproveDisplayVideo360AdvertiserLinkProposalResponse> call);

        partial void Modify_CancelDisplayVideo360AdvertiserLinkProposalApiCall(ref gaxgrpc::ApiCall<CancelDisplayVideo360AdvertiserLinkProposalRequest, DisplayVideo360AdvertiserLinkProposal> call);

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

        partial void Modify_GetUserLinkRequest(ref GetUserLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchGetUserLinksRequest(ref BatchGetUserLinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUserLinksRequest(ref ListUserLinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AuditUserLinksRequest(ref AuditUserLinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateUserLinkRequest(ref CreateUserLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateUserLinksRequest(ref BatchCreateUserLinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUserLinkRequest(ref UpdateUserLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateUserLinksRequest(ref BatchUpdateUserLinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteUserLinkRequest(ref DeleteUserLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeleteUserLinksRequest(ref BatchDeleteUserLinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFirebaseLinkRequest(ref CreateFirebaseLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFirebaseLinkRequest(ref DeleteFirebaseLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFirebaseLinksRequest(ref ListFirebaseLinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGlobalSiteTagRequest(ref GetGlobalSiteTagRequest request, ref gaxgrpc::CallSettings settings);

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

        partial void Modify_GetGoogleSignalsSettingsRequest(ref GetGoogleSignalsSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGoogleSignalsSettingsRequest(ref UpdateGoogleSignalsSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConversionEventRequest(ref CreateConversionEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConversionEventRequest(ref GetConversionEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConversionEventRequest(ref DeleteConversionEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConversionEventsRequest(ref ListConversionEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDisplayVideo360AdvertiserLinkRequest(ref GetDisplayVideo360AdvertiserLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDisplayVideo360AdvertiserLinksRequest(ref ListDisplayVideo360AdvertiserLinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDisplayVideo360AdvertiserLinkRequest(ref CreateDisplayVideo360AdvertiserLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDisplayVideo360AdvertiserLinkRequest(ref DeleteDisplayVideo360AdvertiserLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDisplayVideo360AdvertiserLinkRequest(ref UpdateDisplayVideo360AdvertiserLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDisplayVideo360AdvertiserLinkProposalRequest(ref GetDisplayVideo360AdvertiserLinkProposalRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDisplayVideo360AdvertiserLinkProposalsRequest(ref ListDisplayVideo360AdvertiserLinkProposalsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDisplayVideo360AdvertiserLinkProposalRequest(ref CreateDisplayVideo360AdvertiserLinkProposalRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDisplayVideo360AdvertiserLinkProposalRequest(ref DeleteDisplayVideo360AdvertiserLinkProposalRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ApproveDisplayVideo360AdvertiserLinkProposalRequest(ref ApproveDisplayVideo360AdvertiserLinkProposalRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelDisplayVideo360AdvertiserLinkProposalRequest(ref CancelDisplayVideo360AdvertiserLinkProposalRequest request, ref gaxgrpc::CallSettings settings);

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
        /// UserLinks) will be permanently purged.
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
        /// UserLinks) will be permanently purged.
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
        /// and all child resources (eg: GoogleAdsLinks, Streams, UserLinks)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not an GA4 Property.
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
        /// and all child resources (eg: GoogleAdsLinks, Streams, UserLinks)
        /// will be permanently purged.
        /// https://support.google.com/analytics/answer/6154772
        /// 
        /// Returns an error if the target is not found, or is not an GA4 Property.
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
        /// Gets information about a user's link to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserLink GetUserLink(GetUserLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserLinkRequest(ref request, ref callSettings);
            return _callGetUserLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a user's link to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserLink> GetUserLinkAsync(GetUserLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserLinkRequest(ref request, ref callSettings);
            return _callGetUserLink.Async(request, callSettings);
        }

        /// <summary>
        /// Gets information about multiple users' links to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchGetUserLinksResponse BatchGetUserLinks(BatchGetUserLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetUserLinksRequest(ref request, ref callSettings);
            return _callBatchGetUserLinks.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about multiple users' links to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchGetUserLinksResponse> BatchGetUserLinksAsync(BatchGetUserLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetUserLinksRequest(ref request, ref callSettings);
            return _callBatchGetUserLinks.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all user links on an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserLink"/> resources.</returns>
        public override gax::PagedEnumerable<ListUserLinksResponse, UserLink> ListUserLinks(ListUserLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUserLinksRequest, ListUserLinksResponse, UserLink>(_callListUserLinks, request, callSettings);
        }

        /// <summary>
        /// Lists all user links on an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserLink"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUserLinksResponse, UserLink> ListUserLinksAsync(ListUserLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUserLinksRequest, ListUserLinksResponse, UserLink>(_callListUserLinks, request, callSettings);
        }

        /// <summary>
        /// Lists all user links on an account or property, including implicit ones
        /// that come from effective permissions granted by groups or organization
        /// admin roles.
        /// 
        /// If a returned user link does not have direct permissions, they cannot
        /// be removed from the account or property directly with the DeleteUserLink
        /// command. They have to be removed from the group/etc that gives them
        /// permissions, which is currently only usable/discoverable in the GA or GMP
        /// UIs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AuditUserLink"/> resources.</returns>
        public override gax::PagedEnumerable<AuditUserLinksResponse, AuditUserLink> AuditUserLinks(AuditUserLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AuditUserLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<AuditUserLinksRequest, AuditUserLinksResponse, AuditUserLink>(_callAuditUserLinks, request, callSettings);
        }

        /// <summary>
        /// Lists all user links on an account or property, including implicit ones
        /// that come from effective permissions granted by groups or organization
        /// admin roles.
        /// 
        /// If a returned user link does not have direct permissions, they cannot
        /// be removed from the account or property directly with the DeleteUserLink
        /// command. They have to be removed from the group/etc that gives them
        /// permissions, which is currently only usable/discoverable in the GA or GMP
        /// UIs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AuditUserLink"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<AuditUserLinksResponse, AuditUserLink> AuditUserLinksAsync(AuditUserLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AuditUserLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<AuditUserLinksRequest, AuditUserLinksResponse, AuditUserLink>(_callAuditUserLinks, request, callSettings);
        }

        /// <summary>
        /// Creates a user link on an account or property.
        /// 
        /// If the user with the specified email already has permissions on the
        /// account or property, then the user's existing permissions will be unioned
        /// with the permissions specified in the new UserLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserLink CreateUserLink(CreateUserLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserLinkRequest(ref request, ref callSettings);
            return _callCreateUserLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a user link on an account or property.
        /// 
        /// If the user with the specified email already has permissions on the
        /// account or property, then the user's existing permissions will be unioned
        /// with the permissions specified in the new UserLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserLink> CreateUserLinkAsync(CreateUserLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserLinkRequest(ref request, ref callSettings);
            return _callCreateUserLink.Async(request, callSettings);
        }

        /// <summary>
        /// Creates information about multiple users' links to an account or property.
        /// 
        /// This method is transactional. If any UserLink cannot be created, none of
        /// the UserLinks will be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateUserLinksResponse BatchCreateUserLinks(BatchCreateUserLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateUserLinksRequest(ref request, ref callSettings);
            return _callBatchCreateUserLinks.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates information about multiple users' links to an account or property.
        /// 
        /// This method is transactional. If any UserLink cannot be created, none of
        /// the UserLinks will be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateUserLinksResponse> BatchCreateUserLinksAsync(BatchCreateUserLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateUserLinksRequest(ref request, ref callSettings);
            return _callBatchCreateUserLinks.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a user link on an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserLink UpdateUserLink(UpdateUserLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserLinkRequest(ref request, ref callSettings);
            return _callUpdateUserLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a user link on an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserLink> UpdateUserLinkAsync(UpdateUserLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserLinkRequest(ref request, ref callSettings);
            return _callUpdateUserLink.Async(request, callSettings);
        }

        /// <summary>
        /// Updates information about multiple users' links to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateUserLinksResponse BatchUpdateUserLinks(BatchUpdateUserLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateUserLinksRequest(ref request, ref callSettings);
            return _callBatchUpdateUserLinks.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates information about multiple users' links to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateUserLinksResponse> BatchUpdateUserLinksAsync(BatchUpdateUserLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateUserLinksRequest(ref request, ref callSettings);
            return _callBatchUpdateUserLinks.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a user link on an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteUserLink(DeleteUserLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUserLinkRequest(ref request, ref callSettings);
            _callDeleteUserLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a user link on an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteUserLinkAsync(DeleteUserLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUserLinkRequest(ref request, ref callSettings);
            return _callDeleteUserLink.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes information about multiple users' links to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void BatchDeleteUserLinks(BatchDeleteUserLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteUserLinksRequest(ref request, ref callSettings);
            _callBatchDeleteUserLinks.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes information about multiple users' links to an account or property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task BatchDeleteUserLinksAsync(BatchDeleteUserLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteUserLinksRequest(ref request, ref callSettings);
            return _callBatchDeleteUserLinks.Async(request, callSettings);
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
        /// Returns the Site Tag for the specified web stream.
        /// Site Tags are immutable singletons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GlobalSiteTag GetGlobalSiteTag(GetGlobalSiteTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlobalSiteTagRequest(ref request, ref callSettings);
            return _callGetGlobalSiteTag.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the Site Tag for the specified web stream.
        /// Site Tags are immutable singletons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GlobalSiteTag> GetGlobalSiteTagAsync(GetGlobalSiteTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlobalSiteTagRequest(ref request, ref callSettings);
            return _callGetGlobalSiteTag.Async(request, callSettings);
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
        /// or via this API) before MeasurementProtocolSecret resources may be created.
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
        /// or via this API) before MeasurementProtocolSecret resources may be created.
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
        /// Lookup for Google Signals settings for a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GoogleSignalsSettings GetGoogleSignalsSettings(GetGoogleSignalsSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGoogleSignalsSettingsRequest(ref request, ref callSettings);
            return _callGetGoogleSignalsSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Lookup for Google Signals settings for a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GoogleSignalsSettings> GetGoogleSignalsSettingsAsync(GetGoogleSignalsSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGoogleSignalsSettingsRequest(ref request, ref callSettings);
            return _callGetGoogleSignalsSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Updates Google Signals settings for a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GoogleSignalsSettings UpdateGoogleSignalsSettings(UpdateGoogleSignalsSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGoogleSignalsSettingsRequest(ref request, ref callSettings);
            return _callUpdateGoogleSignalsSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates Google Signals settings for a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GoogleSignalsSettings> UpdateGoogleSignalsSettingsAsync(UpdateGoogleSignalsSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGoogleSignalsSettingsRequest(ref request, ref callSettings);
            return _callUpdateGoogleSignalsSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConversionEvent CreateConversionEvent(CreateConversionEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversionEventRequest(ref request, ref callSettings);
            return _callCreateConversionEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a conversion event with the specified attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConversionEvent> CreateConversionEventAsync(CreateConversionEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversionEventRequest(ref request, ref callSettings);
            return _callCreateConversionEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConversionEvent GetConversionEvent(GetConversionEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversionEventRequest(ref request, ref callSettings);
            return _callGetConversionEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single conversion event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConversionEvent> GetConversionEventAsync(GetConversionEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversionEventRequest(ref request, ref callSettings);
            return _callGetConversionEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteConversionEvent(DeleteConversionEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversionEventRequest(ref request, ref callSettings);
            _callDeleteConversionEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a conversion event in a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteConversionEventAsync(DeleteConversionEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversionEventRequest(ref request, ref callSettings);
            return _callDeleteConversionEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of conversion events in the specified parent property.
        /// 
        /// Returns an empty list if no conversion events are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConversionEvent"/> resources.</returns>
        public override gax::PagedEnumerable<ListConversionEventsResponse, ConversionEvent> ListConversionEvents(ListConversionEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversionEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConversionEventsRequest, ListConversionEventsResponse, ConversionEvent>(_callListConversionEvents, request, callSettings);
        }

        /// <summary>
        /// Returns a list of conversion events in the specified parent property.
        /// 
        /// Returns an empty list if no conversion events are found.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConversionEvent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConversionEventsResponse, ConversionEvent> ListConversionEventsAsync(ListConversionEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversionEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConversionEventsRequest, ListConversionEventsResponse, ConversionEvent>(_callListConversionEvents, request, callSettings);
        }

        /// <summary>
        /// Look up a single DisplayVideo360AdvertiserLink
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DisplayVideo360AdvertiserLink GetDisplayVideo360AdvertiserLink(GetDisplayVideo360AdvertiserLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDisplayVideo360AdvertiserLinkRequest(ref request, ref callSettings);
            return _callGetDisplayVideo360AdvertiserLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Look up a single DisplayVideo360AdvertiserLink
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DisplayVideo360AdvertiserLink> GetDisplayVideo360AdvertiserLinkAsync(GetDisplayVideo360AdvertiserLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDisplayVideo360AdvertiserLinkRequest(ref request, ref callSettings);
            return _callGetDisplayVideo360AdvertiserLink.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all DisplayVideo360AdvertiserLinks on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DisplayVideo360AdvertiserLink"/> resources.</returns>
        public override gax::PagedEnumerable<ListDisplayVideo360AdvertiserLinksResponse, DisplayVideo360AdvertiserLink> ListDisplayVideo360AdvertiserLinks(ListDisplayVideo360AdvertiserLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDisplayVideo360AdvertiserLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDisplayVideo360AdvertiserLinksRequest, ListDisplayVideo360AdvertiserLinksResponse, DisplayVideo360AdvertiserLink>(_callListDisplayVideo360AdvertiserLinks, request, callSettings);
        }

        /// <summary>
        /// Lists all DisplayVideo360AdvertiserLinks on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="DisplayVideo360AdvertiserLink"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListDisplayVideo360AdvertiserLinksResponse, DisplayVideo360AdvertiserLink> ListDisplayVideo360AdvertiserLinksAsync(ListDisplayVideo360AdvertiserLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDisplayVideo360AdvertiserLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDisplayVideo360AdvertiserLinksRequest, ListDisplayVideo360AdvertiserLinksResponse, DisplayVideo360AdvertiserLink>(_callListDisplayVideo360AdvertiserLinks, request, callSettings);
        }

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLink.
        /// This can only be utilized by users who have proper authorization both on
        /// the Google Analytics property and on the Display &amp;amp; Video 360 advertiser.
        /// Users who do not have access to the Display &amp;amp; Video 360 advertiser should
        /// instead seek to create a DisplayVideo360LinkProposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DisplayVideo360AdvertiserLink CreateDisplayVideo360AdvertiserLink(CreateDisplayVideo360AdvertiserLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDisplayVideo360AdvertiserLinkRequest(ref request, ref callSettings);
            return _callCreateDisplayVideo360AdvertiserLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLink.
        /// This can only be utilized by users who have proper authorization both on
        /// the Google Analytics property and on the Display &amp;amp; Video 360 advertiser.
        /// Users who do not have access to the Display &amp;amp; Video 360 advertiser should
        /// instead seek to create a DisplayVideo360LinkProposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DisplayVideo360AdvertiserLink> CreateDisplayVideo360AdvertiserLinkAsync(CreateDisplayVideo360AdvertiserLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDisplayVideo360AdvertiserLinkRequest(ref request, ref callSettings);
            return _callCreateDisplayVideo360AdvertiserLink.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDisplayVideo360AdvertiserLink(DeleteDisplayVideo360AdvertiserLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDisplayVideo360AdvertiserLinkRequest(ref request, ref callSettings);
            _callDeleteDisplayVideo360AdvertiserLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDisplayVideo360AdvertiserLinkAsync(DeleteDisplayVideo360AdvertiserLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDisplayVideo360AdvertiserLinkRequest(ref request, ref callSettings);
            return _callDeleteDisplayVideo360AdvertiserLink.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DisplayVideo360AdvertiserLink UpdateDisplayVideo360AdvertiserLink(UpdateDisplayVideo360AdvertiserLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDisplayVideo360AdvertiserLinkRequest(ref request, ref callSettings);
            return _callUpdateDisplayVideo360AdvertiserLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a DisplayVideo360AdvertiserLink on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DisplayVideo360AdvertiserLink> UpdateDisplayVideo360AdvertiserLinkAsync(UpdateDisplayVideo360AdvertiserLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDisplayVideo360AdvertiserLinkRequest(ref request, ref callSettings);
            return _callUpdateDisplayVideo360AdvertiserLink.Async(request, callSettings);
        }

        /// <summary>
        /// Lookup for a single DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DisplayVideo360AdvertiserLinkProposal GetDisplayVideo360AdvertiserLinkProposal(GetDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDisplayVideo360AdvertiserLinkProposalRequest(ref request, ref callSettings);
            return _callGetDisplayVideo360AdvertiserLinkProposal.Sync(request, callSettings);
        }

        /// <summary>
        /// Lookup for a single DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DisplayVideo360AdvertiserLinkProposal> GetDisplayVideo360AdvertiserLinkProposalAsync(GetDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDisplayVideo360AdvertiserLinkProposalRequest(ref request, ref callSettings);
            return _callGetDisplayVideo360AdvertiserLinkProposal.Async(request, callSettings);
        }

        /// <summary>
        /// Lists DisplayVideo360AdvertiserLinkProposals on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DisplayVideo360AdvertiserLinkProposal"/> resources.</returns>
        public override gax::PagedEnumerable<ListDisplayVideo360AdvertiserLinkProposalsResponse, DisplayVideo360AdvertiserLinkProposal> ListDisplayVideo360AdvertiserLinkProposals(ListDisplayVideo360AdvertiserLinkProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDisplayVideo360AdvertiserLinkProposalsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDisplayVideo360AdvertiserLinkProposalsRequest, ListDisplayVideo360AdvertiserLinkProposalsResponse, DisplayVideo360AdvertiserLinkProposal>(_callListDisplayVideo360AdvertiserLinkProposals, request, callSettings);
        }

        /// <summary>
        /// Lists DisplayVideo360AdvertiserLinkProposals on a property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="DisplayVideo360AdvertiserLinkProposal"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListDisplayVideo360AdvertiserLinkProposalsResponse, DisplayVideo360AdvertiserLinkProposal> ListDisplayVideo360AdvertiserLinkProposalsAsync(ListDisplayVideo360AdvertiserLinkProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDisplayVideo360AdvertiserLinkProposalsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDisplayVideo360AdvertiserLinkProposalsRequest, ListDisplayVideo360AdvertiserLinkProposalsResponse, DisplayVideo360AdvertiserLinkProposal>(_callListDisplayVideo360AdvertiserLinkProposals, request, callSettings);
        }

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DisplayVideo360AdvertiserLinkProposal CreateDisplayVideo360AdvertiserLinkProposal(CreateDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDisplayVideo360AdvertiserLinkProposalRequest(ref request, ref callSettings);
            return _callCreateDisplayVideo360AdvertiserLinkProposal.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a DisplayVideo360AdvertiserLinkProposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DisplayVideo360AdvertiserLinkProposal> CreateDisplayVideo360AdvertiserLinkProposalAsync(CreateDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDisplayVideo360AdvertiserLinkProposalRequest(ref request, ref callSettings);
            return _callCreateDisplayVideo360AdvertiserLinkProposal.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLinkProposal on a property.
        /// This can only be used on cancelled proposals.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDisplayVideo360AdvertiserLinkProposal(DeleteDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDisplayVideo360AdvertiserLinkProposalRequest(ref request, ref callSettings);
            _callDeleteDisplayVideo360AdvertiserLinkProposal.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a DisplayVideo360AdvertiserLinkProposal on a property.
        /// This can only be used on cancelled proposals.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDisplayVideo360AdvertiserLinkProposalAsync(DeleteDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDisplayVideo360AdvertiserLinkProposalRequest(ref request, ref callSettings);
            return _callDeleteDisplayVideo360AdvertiserLinkProposal.Async(request, callSettings);
        }

        /// <summary>
        /// Approves a DisplayVideo360AdvertiserLinkProposal.
        /// The DisplayVideo360AdvertiserLinkProposal will be deleted and a new
        /// DisplayVideo360AdvertiserLink will be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApproveDisplayVideo360AdvertiserLinkProposalResponse ApproveDisplayVideo360AdvertiserLinkProposal(ApproveDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApproveDisplayVideo360AdvertiserLinkProposalRequest(ref request, ref callSettings);
            return _callApproveDisplayVideo360AdvertiserLinkProposal.Sync(request, callSettings);
        }

        /// <summary>
        /// Approves a DisplayVideo360AdvertiserLinkProposal.
        /// The DisplayVideo360AdvertiserLinkProposal will be deleted and a new
        /// DisplayVideo360AdvertiserLink will be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApproveDisplayVideo360AdvertiserLinkProposalResponse> ApproveDisplayVideo360AdvertiserLinkProposalAsync(ApproveDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApproveDisplayVideo360AdvertiserLinkProposalRequest(ref request, ref callSettings);
            return _callApproveDisplayVideo360AdvertiserLinkProposal.Async(request, callSettings);
        }

        /// <summary>
        /// Cancels a DisplayVideo360AdvertiserLinkProposal.
        /// Cancelling can mean either:
        /// - Declining a proposal initiated from Display &amp;amp; Video 360
        /// - Withdrawing a proposal initiated from Google Analytics
        /// After being cancelled, a proposal will eventually be deleted automatically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DisplayVideo360AdvertiserLinkProposal CancelDisplayVideo360AdvertiserLinkProposal(CancelDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelDisplayVideo360AdvertiserLinkProposalRequest(ref request, ref callSettings);
            return _callCancelDisplayVideo360AdvertiserLinkProposal.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels a DisplayVideo360AdvertiserLinkProposal.
        /// Cancelling can mean either:
        /// - Declining a proposal initiated from Display &amp;amp; Video 360
        /// - Withdrawing a proposal initiated from Google Analytics
        /// After being cancelled, a proposal will eventually be deleted automatically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DisplayVideo360AdvertiserLinkProposal> CancelDisplayVideo360AdvertiserLinkProposalAsync(CancelDisplayVideo360AdvertiserLinkProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelDisplayVideo360AdvertiserLinkProposalRequest(ref request, ref callSettings);
            return _callCancelDisplayVideo360AdvertiserLinkProposal.Async(request, callSettings);
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

    public partial class ListUserLinksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class AuditUserLinksRequest : gaxgrpc::IPageRequest
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

    public partial class ListDisplayVideo360AdvertiserLinksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDisplayVideo360AdvertiserLinkProposalsRequest : gaxgrpc::IPageRequest
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

    public partial class ListUserLinksResponse : gaxgrpc::IPageResponse<UserLink>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UserLink> GetEnumerator() => UserLinks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class AuditUserLinksResponse : gaxgrpc::IPageResponse<AuditUserLink>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AuditUserLink> GetEnumerator() => UserLinks.GetEnumerator();

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

    public partial class ListDisplayVideo360AdvertiserLinksResponse : gaxgrpc::IPageResponse<DisplayVideo360AdvertiserLink>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DisplayVideo360AdvertiserLink> GetEnumerator() =>
            DisplayVideo360AdvertiserLinks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDisplayVideo360AdvertiserLinkProposalsResponse : gaxgrpc::IPageResponse<DisplayVideo360AdvertiserLinkProposal>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DisplayVideo360AdvertiserLinkProposal> GetEnumerator() =>
            DisplayVideo360AdvertiserLinkProposals.GetEnumerator();

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
