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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Ads.MarketingPlatform.Admin.V1Alpha
{
    /// <summary>Settings for <see cref="MarketingplatformAdminServiceClient"/> instances.</summary>
    public sealed partial class MarketingplatformAdminServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MarketingplatformAdminServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MarketingplatformAdminServiceSettings"/>.</returns>
        public static MarketingplatformAdminServiceSettings GetDefault() => new MarketingplatformAdminServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="MarketingplatformAdminServiceSettings"/> object with default settings.
        /// </summary>
        public MarketingplatformAdminServiceSettings()
        {
        }

        private MarketingplatformAdminServiceSettings(MarketingplatformAdminServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetOrganizationSettings = existing.GetOrganizationSettings;
            ListOrganizationsSettings = existing.ListOrganizationsSettings;
            FindSalesPartnerManagedClientsSettings = existing.FindSalesPartnerManagedClientsSettings;
            ListAnalyticsAccountLinksSettings = existing.ListAnalyticsAccountLinksSettings;
            CreateAnalyticsAccountLinkSettings = existing.CreateAnalyticsAccountLinkSettings;
            DeleteAnalyticsAccountLinkSettings = existing.DeleteAnalyticsAccountLinkSettings;
            SetPropertyServiceLevelSettings = existing.SetPropertyServiceLevelSettings;
            ReportPropertyUsageSettings = existing.ReportPropertyUsageSettings;
            GetUserGroupSettings = existing.GetUserGroupSettings;
            ListUserGroupsSettings = existing.ListUserGroupsSettings;
            CreateUserGroupSettings = existing.CreateUserGroupSettings;
            UpdateUserGroupSettings = existing.UpdateUserGroupSettings;
            DeleteUserGroupSettings = existing.DeleteUserGroupSettings;
            GetUserGroupMemberSettings = existing.GetUserGroupMemberSettings;
            ListUserGroupMembersSettings = existing.ListUserGroupMembersSettings;
            CreateUserGroupMemberSettings = existing.CreateUserGroupMemberSettings;
            UpdateUserGroupMemberSettings = existing.UpdateUserGroupMemberSettings;
            DeleteUserGroupMemberSettings = existing.DeleteUserGroupMemberSettings;
            GetAdminAccessBindingSettings = existing.GetAdminAccessBindingSettings;
            ListAdminAccessBindingsSettings = existing.ListAdminAccessBindingsSettings;
            CreateAdminAccessBindingSettings = existing.CreateAdminAccessBindingSettings;
            UpdateAdminAccessBindingSettings = existing.UpdateAdminAccessBindingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MarketingplatformAdminServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.GetOrganization</c> and
        /// <c>MarketingplatformAdminServiceClient.GetOrganizationAsync</c>.
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
        public gaxgrpc::CallSettings GetOrganizationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.ListOrganizations</c> and
        /// <c>MarketingplatformAdminServiceClient.ListOrganizationsAsync</c>.
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
        public gaxgrpc::CallSettings ListOrganizationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.FindSalesPartnerManagedClients</c> and
        /// <c>MarketingplatformAdminServiceClient.FindSalesPartnerManagedClientsAsync</c>.
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
        public gaxgrpc::CallSettings FindSalesPartnerManagedClientsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.ListAnalyticsAccountLinks</c> and
        /// <c>MarketingplatformAdminServiceClient.ListAnalyticsAccountLinksAsync</c>.
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
        public gaxgrpc::CallSettings ListAnalyticsAccountLinksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.CreateAnalyticsAccountLink</c> and
        /// <c>MarketingplatformAdminServiceClient.CreateAnalyticsAccountLinkAsync</c>.
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
        public gaxgrpc::CallSettings CreateAnalyticsAccountLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.DeleteAnalyticsAccountLink</c> and
        /// <c>MarketingplatformAdminServiceClient.DeleteAnalyticsAccountLinkAsync</c>.
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
        public gaxgrpc::CallSettings DeleteAnalyticsAccountLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.SetPropertyServiceLevel</c> and
        /// <c>MarketingplatformAdminServiceClient.SetPropertyServiceLevelAsync</c>.
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
        public gaxgrpc::CallSettings SetPropertyServiceLevelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.ReportPropertyUsage</c> and
        /// <c>MarketingplatformAdminServiceClient.ReportPropertyUsageAsync</c>.
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
        public gaxgrpc::CallSettings ReportPropertyUsageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.GetUserGroup</c> and
        /// <c>MarketingplatformAdminServiceClient.GetUserGroupAsync</c>.
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
        public gaxgrpc::CallSettings GetUserGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.ListUserGroups</c> and
        /// <c>MarketingplatformAdminServiceClient.ListUserGroupsAsync</c>.
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
        public gaxgrpc::CallSettings ListUserGroupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.CreateUserGroup</c> and
        /// <c>MarketingplatformAdminServiceClient.CreateUserGroupAsync</c>.
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
        public gaxgrpc::CallSettings CreateUserGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.UpdateUserGroup</c> and
        /// <c>MarketingplatformAdminServiceClient.UpdateUserGroupAsync</c>.
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
        public gaxgrpc::CallSettings UpdateUserGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.DeleteUserGroup</c> and
        /// <c>MarketingplatformAdminServiceClient.DeleteUserGroupAsync</c>.
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
        public gaxgrpc::CallSettings DeleteUserGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.GetUserGroupMember</c> and
        /// <c>MarketingplatformAdminServiceClient.GetUserGroupMemberAsync</c>.
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
        public gaxgrpc::CallSettings GetUserGroupMemberSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.ListUserGroupMembers</c> and
        /// <c>MarketingplatformAdminServiceClient.ListUserGroupMembersAsync</c>.
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
        public gaxgrpc::CallSettings ListUserGroupMembersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.CreateUserGroupMember</c> and
        /// <c>MarketingplatformAdminServiceClient.CreateUserGroupMemberAsync</c>.
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
        public gaxgrpc::CallSettings CreateUserGroupMemberSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.UpdateUserGroupMember</c> and
        /// <c>MarketingplatformAdminServiceClient.UpdateUserGroupMemberAsync</c>.
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
        public gaxgrpc::CallSettings UpdateUserGroupMemberSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.DeleteUserGroupMember</c> and
        /// <c>MarketingplatformAdminServiceClient.DeleteUserGroupMemberAsync</c>.
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
        public gaxgrpc::CallSettings DeleteUserGroupMemberSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.GetAdminAccessBinding</c> and
        /// <c>MarketingplatformAdminServiceClient.GetAdminAccessBindingAsync</c>.
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
        public gaxgrpc::CallSettings GetAdminAccessBindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.ListAdminAccessBindings</c> and
        /// <c>MarketingplatformAdminServiceClient.ListAdminAccessBindingsAsync</c>.
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
        public gaxgrpc::CallSettings ListAdminAccessBindingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.CreateAdminAccessBinding</c> and
        /// <c>MarketingplatformAdminServiceClient.CreateAdminAccessBindingAsync</c>.
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
        public gaxgrpc::CallSettings CreateAdminAccessBindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.UpdateAdminAccessBinding</c> and
        /// <c>MarketingplatformAdminServiceClient.UpdateAdminAccessBindingAsync</c>.
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
        public gaxgrpc::CallSettings UpdateAdminAccessBindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MarketingplatformAdminServiceSettings"/> object.</returns>
        public MarketingplatformAdminServiceSettings Clone() => new MarketingplatformAdminServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MarketingplatformAdminServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class MarketingplatformAdminServiceClientBuilder : gaxgrpc::ClientBuilderBase<MarketingplatformAdminServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MarketingplatformAdminServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MarketingplatformAdminServiceClientBuilder() : base(MarketingplatformAdminServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MarketingplatformAdminServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MarketingplatformAdminServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MarketingplatformAdminServiceClient Build()
        {
            MarketingplatformAdminServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MarketingplatformAdminServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MarketingplatformAdminServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MarketingplatformAdminServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MarketingplatformAdminServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MarketingplatformAdminServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MarketingplatformAdminServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MarketingplatformAdminServiceClient.ChannelPool;
    }

    /// <summary>MarketingplatformAdminService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service Interface for the Google Marketing Platform Admin API.
    /// </remarks>
    public abstract partial class MarketingplatformAdminServiceClient
    {
        /// <summary>
        /// The default endpoint for the MarketingplatformAdminService service, which is a host of
        /// "marketingplatformadmin.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "marketingplatformadmin.googleapis.com:443";

        /// <summary>The default MarketingplatformAdminService scopes.</summary>
        /// <remarks>
        /// The default MarketingplatformAdminService scopes are:
        /// <list type="bullet">
        /// <item>
        /// <description>https://www.googleapis.com/auth/marketingplatformadmin.analytics.read</description>
        /// </item>
        /// <item>
        /// <description>https://www.googleapis.com/auth/marketingplatformadmin.analytics.update</description>
        /// </item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/marketingplatformadmin.analytics.read",
            "https://www.googleapis.com/auth/marketingplatformadmin.analytics.update",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MarketingplatformAdminService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MarketingplatformAdminServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="MarketingplatformAdminServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MarketingplatformAdminServiceClient"/>.</returns>
        public static stt::Task<MarketingplatformAdminServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MarketingplatformAdminServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MarketingplatformAdminServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="MarketingplatformAdminServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MarketingplatformAdminServiceClient"/>.</returns>
        public static MarketingplatformAdminServiceClient Create() =>
            new MarketingplatformAdminServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MarketingplatformAdminServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MarketingplatformAdminServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MarketingplatformAdminServiceClient"/>.</returns>
        internal static MarketingplatformAdminServiceClient Create(grpccore::CallInvoker callInvoker, MarketingplatformAdminServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MarketingplatformAdminService.MarketingplatformAdminServiceClient grpcClient = new MarketingplatformAdminService.MarketingplatformAdminServiceClient(callInvoker);
            return new MarketingplatformAdminServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MarketingplatformAdminService client</summary>
        public virtual MarketingplatformAdminService.MarketingplatformAdminServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up a single organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Organization GetOrganization(GetOrganizationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up a single organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Organization> GetOrganizationAsync(GetOrganizationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up a single organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Organization> GetOrganizationAsync(GetOrganizationRequest request, st::CancellationToken cancellationToken) =>
            GetOrganizationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks up a single organization.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Organization to retrieve.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Organization GetOrganization(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganization(new GetOrganizationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Looks up a single organization.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Organization to retrieve.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Organization> GetOrganizationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganizationAsync(new GetOrganizationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Looks up a single organization.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Organization to retrieve.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Organization> GetOrganizationAsync(string name, st::CancellationToken cancellationToken) =>
            GetOrganizationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks up a single organization.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Organization to retrieve.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Organization GetOrganization(OrganizationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganization(new GetOrganizationRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Looks up a single organization.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Organization to retrieve.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Organization> GetOrganizationAsync(OrganizationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganizationAsync(new GetOrganizationRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Looks up a single organization.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Organization to retrieve.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Organization> GetOrganizationAsync(OrganizationName name, st::CancellationToken cancellationToken) =>
            GetOrganizationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of organizations that the user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Organization"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrganizationsResponse, Organization> ListOrganizations(ListOrganizationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of organizations that the user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Organization"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrganizationsResponse, Organization> ListOrganizationsAsync(ListOrganizationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of clients managed by the sales partner organization.
        /// 
        /// User needs to be an OrgAdmin/BillingAdmin on the sales partner organization
        /// in order to view the end clients.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FindSalesPartnerManagedClientsResponse FindSalesPartnerManagedClients(FindSalesPartnerManagedClientsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of clients managed by the sales partner organization.
        /// 
        /// User needs to be an OrgAdmin/BillingAdmin on the sales partner organization
        /// in order to view the end clients.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindSalesPartnerManagedClientsResponse> FindSalesPartnerManagedClientsAsync(FindSalesPartnerManagedClientsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of clients managed by the sales partner organization.
        /// 
        /// User needs to be an OrgAdmin/BillingAdmin on the sales partner organization
        /// in order to view the end clients.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindSalesPartnerManagedClientsResponse> FindSalesPartnerManagedClientsAsync(FindSalesPartnerManagedClientsRequest request, st::CancellationToken cancellationToken) =>
            FindSalesPartnerManagedClientsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the Google Analytics accounts link to the specified Google Marketing
        /// Platform organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnalyticsAccountLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> ListAnalyticsAccountLinks(ListAnalyticsAccountLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Google Analytics accounts link to the specified Google Marketing
        /// Platform organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnalyticsAccountLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> ListAnalyticsAccountLinksAsync(ListAnalyticsAccountLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Google Analytics accounts link to the specified Google Marketing
        /// Platform organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent organization, which owns this collection of Analytics
        /// account links. Format: organizations/{org_id}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnalyticsAccountLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> ListAnalyticsAccountLinks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalyticsAccountLinksRequest request = new ListAnalyticsAccountLinksRequest
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
            return ListAnalyticsAccountLinks(request, callSettings);
        }

        /// <summary>
        /// Lists the Google Analytics accounts link to the specified Google Marketing
        /// Platform organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent organization, which owns this collection of Analytics
        /// account links. Format: organizations/{org_id}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnalyticsAccountLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> ListAnalyticsAccountLinksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalyticsAccountLinksRequest request = new ListAnalyticsAccountLinksRequest
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
            return ListAnalyticsAccountLinksAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the Google Analytics accounts link to the specified Google Marketing
        /// Platform organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent organization, which owns this collection of Analytics
        /// account links. Format: organizations/{org_id}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnalyticsAccountLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> ListAnalyticsAccountLinks(OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalyticsAccountLinksRequest request = new ListAnalyticsAccountLinksRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAnalyticsAccountLinks(request, callSettings);
        }

        /// <summary>
        /// Lists the Google Analytics accounts link to the specified Google Marketing
        /// Platform organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent organization, which owns this collection of Analytics
        /// account links. Format: organizations/{org_id}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnalyticsAccountLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> ListAnalyticsAccountLinksAsync(OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalyticsAccountLinksRequest request = new ListAnalyticsAccountLinksRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAnalyticsAccountLinksAsync(request, callSettings);
        }

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyticsAccountLink CreateAnalyticsAccountLink(CreateAnalyticsAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyticsAccountLink> CreateAnalyticsAccountLinkAsync(CreateAnalyticsAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyticsAccountLink> CreateAnalyticsAccountLinkAsync(CreateAnalyticsAccountLinkRequest request, st::CancellationToken cancellationToken) =>
            CreateAnalyticsAccountLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Analytics account link will be
        /// created. Format: organizations/{org_id}
        /// </param>
        /// <param name="analyticsAccountLink">
        /// Required. The Analytics account link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyticsAccountLink CreateAnalyticsAccountLink(string parent, AnalyticsAccountLink analyticsAccountLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalyticsAccountLink(new CreateAnalyticsAccountLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AnalyticsAccountLink = gax::GaxPreconditions.CheckNotNull(analyticsAccountLink, nameof(analyticsAccountLink)),
            }, callSettings);

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Analytics account link will be
        /// created. Format: organizations/{org_id}
        /// </param>
        /// <param name="analyticsAccountLink">
        /// Required. The Analytics account link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyticsAccountLink> CreateAnalyticsAccountLinkAsync(string parent, AnalyticsAccountLink analyticsAccountLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalyticsAccountLinkAsync(new CreateAnalyticsAccountLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AnalyticsAccountLink = gax::GaxPreconditions.CheckNotNull(analyticsAccountLink, nameof(analyticsAccountLink)),
            }, callSettings);

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Analytics account link will be
        /// created. Format: organizations/{org_id}
        /// </param>
        /// <param name="analyticsAccountLink">
        /// Required. The Analytics account link to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyticsAccountLink> CreateAnalyticsAccountLinkAsync(string parent, AnalyticsAccountLink analyticsAccountLink, st::CancellationToken cancellationToken) =>
            CreateAnalyticsAccountLinkAsync(parent, analyticsAccountLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Analytics account link will be
        /// created. Format: organizations/{org_id}
        /// </param>
        /// <param name="analyticsAccountLink">
        /// Required. The Analytics account link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyticsAccountLink CreateAnalyticsAccountLink(OrganizationName parent, AnalyticsAccountLink analyticsAccountLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalyticsAccountLink(new CreateAnalyticsAccountLinkRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AnalyticsAccountLink = gax::GaxPreconditions.CheckNotNull(analyticsAccountLink, nameof(analyticsAccountLink)),
            }, callSettings);

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Analytics account link will be
        /// created. Format: organizations/{org_id}
        /// </param>
        /// <param name="analyticsAccountLink">
        /// Required. The Analytics account link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyticsAccountLink> CreateAnalyticsAccountLinkAsync(OrganizationName parent, AnalyticsAccountLink analyticsAccountLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalyticsAccountLinkAsync(new CreateAnalyticsAccountLinkRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AnalyticsAccountLink = gax::GaxPreconditions.CheckNotNull(analyticsAccountLink, nameof(analyticsAccountLink)),
            }, callSettings);

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Analytics account link will be
        /// created. Format: organizations/{org_id}
        /// </param>
        /// <param name="analyticsAccountLink">
        /// Required. The Analytics account link to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyticsAccountLink> CreateAnalyticsAccountLinkAsync(OrganizationName parent, AnalyticsAccountLink analyticsAccountLink, st::CancellationToken cancellationToken) =>
            CreateAnalyticsAccountLinkAsync(parent, analyticsAccountLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnalyticsAccountLink(DeleteAnalyticsAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalyticsAccountLinkAsync(DeleteAnalyticsAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalyticsAccountLinkAsync(DeleteAnalyticsAccountLinkRequest request, st::CancellationToken cancellationToken) =>
            DeleteAnalyticsAccountLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Analytics account link to delete.
        /// Format:
        /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnalyticsAccountLink(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalyticsAccountLink(new DeleteAnalyticsAccountLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Analytics account link to delete.
        /// Format:
        /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalyticsAccountLinkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalyticsAccountLinkAsync(new DeleteAnalyticsAccountLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Analytics account link to delete.
        /// Format:
        /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalyticsAccountLinkAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAnalyticsAccountLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Analytics account link to delete.
        /// Format:
        /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnalyticsAccountLink(AnalyticsAccountLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalyticsAccountLink(new DeleteAnalyticsAccountLinkRequest
            {
                AnalyticsAccountLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Analytics account link to delete.
        /// Format:
        /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalyticsAccountLinkAsync(AnalyticsAccountLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalyticsAccountLinkAsync(new DeleteAnalyticsAccountLinkRequest
            {
                AnalyticsAccountLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Analytics account link to delete.
        /// Format:
        /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalyticsAccountLinkAsync(AnalyticsAccountLinkName name, st::CancellationToken cancellationToken) =>
            DeleteAnalyticsAccountLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the service level for an Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SetPropertyServiceLevelResponse SetPropertyServiceLevel(SetPropertyServiceLevelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the service level for an Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SetPropertyServiceLevelResponse> SetPropertyServiceLevelAsync(SetPropertyServiceLevelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the service level for an Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SetPropertyServiceLevelResponse> SetPropertyServiceLevelAsync(SetPropertyServiceLevelRequest request, st::CancellationToken cancellationToken) =>
            SetPropertyServiceLevelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the service level for an Analytics property.
        /// </summary>
        /// <param name="analyticsAccountLink">
        /// Required. The parent AnalyticsAccountLink scope where this property is in.
        /// Format:
        /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SetPropertyServiceLevelResponse SetPropertyServiceLevel(string analyticsAccountLink, gaxgrpc::CallSettings callSettings = null) =>
            SetPropertyServiceLevel(new SetPropertyServiceLevelRequest
            {
                AnalyticsAccountLink = gax::GaxPreconditions.CheckNotNullOrEmpty(analyticsAccountLink, nameof(analyticsAccountLink)),
            }, callSettings);

        /// <summary>
        /// Updates the service level for an Analytics property.
        /// </summary>
        /// <param name="analyticsAccountLink">
        /// Required. The parent AnalyticsAccountLink scope where this property is in.
        /// Format:
        /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SetPropertyServiceLevelResponse> SetPropertyServiceLevelAsync(string analyticsAccountLink, gaxgrpc::CallSettings callSettings = null) =>
            SetPropertyServiceLevelAsync(new SetPropertyServiceLevelRequest
            {
                AnalyticsAccountLink = gax::GaxPreconditions.CheckNotNullOrEmpty(analyticsAccountLink, nameof(analyticsAccountLink)),
            }, callSettings);

        /// <summary>
        /// Updates the service level for an Analytics property.
        /// </summary>
        /// <param name="analyticsAccountLink">
        /// Required. The parent AnalyticsAccountLink scope where this property is in.
        /// Format:
        /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SetPropertyServiceLevelResponse> SetPropertyServiceLevelAsync(string analyticsAccountLink, st::CancellationToken cancellationToken) =>
            SetPropertyServiceLevelAsync(analyticsAccountLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the usage and billing data for properties within the organization for
        /// the specified month.
        /// 
        /// Per direct client org, user needs to be OrgAdmin/BillingAdmin on the
        /// organization in order to view the billing and usage data.
        /// 
        /// Per sales partner client org, user needs to be OrgAdmin/BillingAdmin on
        /// the sales partner org in order to view the billing and usage data, or
        /// OrgAdmin/BillingAdmin on the sales partner client org in order to view the
        /// usage data only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportPropertyUsageResponse ReportPropertyUsage(ReportPropertyUsageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the usage and billing data for properties within the organization for
        /// the specified month.
        /// 
        /// Per direct client org, user needs to be OrgAdmin/BillingAdmin on the
        /// organization in order to view the billing and usage data.
        /// 
        /// Per sales partner client org, user needs to be OrgAdmin/BillingAdmin on
        /// the sales partner org in order to view the billing and usage data, or
        /// OrgAdmin/BillingAdmin on the sales partner client org in order to view the
        /// usage data only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportPropertyUsageResponse> ReportPropertyUsageAsync(ReportPropertyUsageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the usage and billing data for properties within the organization for
        /// the specified month.
        /// 
        /// Per direct client org, user needs to be OrgAdmin/BillingAdmin on the
        /// organization in order to view the billing and usage data.
        /// 
        /// Per sales partner client org, user needs to be OrgAdmin/BillingAdmin on
        /// the sales partner org in order to view the billing and usage data, or
        /// OrgAdmin/BillingAdmin on the sales partner client org in order to view the
        /// usage data only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportPropertyUsageResponse> ReportPropertyUsageAsync(ReportPropertyUsageRequest request, st::CancellationToken cancellationToken) =>
            ReportPropertyUsageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the usage and billing data for properties within the organization for
        /// the specified month.
        /// 
        /// Per direct client org, user needs to be OrgAdmin/BillingAdmin on the
        /// organization in order to view the billing and usage data.
        /// 
        /// Per sales partner client org, user needs to be OrgAdmin/BillingAdmin on
        /// the sales partner org in order to view the billing and usage data, or
        /// OrgAdmin/BillingAdmin on the sales partner client org in order to view the
        /// usage data only.
        /// </summary>
        /// <param name="organization">
        /// Required. Specifies the organization whose property usage will be listed.
        /// 
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportPropertyUsageResponse ReportPropertyUsage(string organization, gaxgrpc::CallSettings callSettings = null) =>
            ReportPropertyUsage(new ReportPropertyUsageRequest
            {
                Organization = gax::GaxPreconditions.CheckNotNullOrEmpty(organization, nameof(organization)),
            }, callSettings);

        /// <summary>
        /// Gets the usage and billing data for properties within the organization for
        /// the specified month.
        /// 
        /// Per direct client org, user needs to be OrgAdmin/BillingAdmin on the
        /// organization in order to view the billing and usage data.
        /// 
        /// Per sales partner client org, user needs to be OrgAdmin/BillingAdmin on
        /// the sales partner org in order to view the billing and usage data, or
        /// OrgAdmin/BillingAdmin on the sales partner client org in order to view the
        /// usage data only.
        /// </summary>
        /// <param name="organization">
        /// Required. Specifies the organization whose property usage will be listed.
        /// 
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportPropertyUsageResponse> ReportPropertyUsageAsync(string organization, gaxgrpc::CallSettings callSettings = null) =>
            ReportPropertyUsageAsync(new ReportPropertyUsageRequest
            {
                Organization = gax::GaxPreconditions.CheckNotNullOrEmpty(organization, nameof(organization)),
            }, callSettings);

        /// <summary>
        /// Gets the usage and billing data for properties within the organization for
        /// the specified month.
        /// 
        /// Per direct client org, user needs to be OrgAdmin/BillingAdmin on the
        /// organization in order to view the billing and usage data.
        /// 
        /// Per sales partner client org, user needs to be OrgAdmin/BillingAdmin on
        /// the sales partner org in order to view the billing and usage data, or
        /// OrgAdmin/BillingAdmin on the sales partner client org in order to view the
        /// usage data only.
        /// </summary>
        /// <param name="organization">
        /// Required. Specifies the organization whose property usage will be listed.
        /// 
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportPropertyUsageResponse> ReportPropertyUsageAsync(string organization, st::CancellationToken cancellationToken) =>
            ReportPropertyUsageAsync(organization, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks up a single user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserGroup GetUserGroup(GetUserGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up a single user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroup> GetUserGroupAsync(GetUserGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up a single user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroup> GetUserGroupAsync(GetUserGroupRequest request, st::CancellationToken cancellationToken) =>
            GetUserGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks up a single user group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the UserGroup to retrieve.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserGroup GetUserGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserGroup(new GetUserGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Looks up a single user group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the UserGroup to retrieve.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroup> GetUserGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserGroupAsync(new GetUserGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Looks up a single user group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the UserGroup to retrieve.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroup> GetUserGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetUserGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks up a single user group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the UserGroup to retrieve.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserGroup GetUserGroup(UserGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserGroup(new GetUserGroupRequest
            {
                UserGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Looks up a single user group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the UserGroup to retrieve.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroup> GetUserGroupAsync(UserGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserGroupAsync(new GetUserGroupRequest
            {
                UserGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Looks up a single user group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the UserGroup to retrieve.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroup> GetUserGroupAsync(UserGroupName name, st::CancellationToken cancellationToken) =>
            GetUserGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of user groups in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserGroupsResponse, UserGroup> ListUserGroups(ListUserGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of user groups in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserGroupsResponse, UserGroup> ListUserGroupsAsync(ListUserGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of user groups in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent org where this UserGroup will be listed.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserGroupsResponse, UserGroup> ListUserGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserGroupsRequest request = new ListUserGroupsRequest
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
            return ListUserGroups(request, callSettings);
        }

        /// <summary>
        /// Returns a list of user groups in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent org where this UserGroup will be listed.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserGroupsResponse, UserGroup> ListUserGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserGroupsRequest request = new ListUserGroupsRequest
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
            return ListUserGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of user groups in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent org where this UserGroup will be listed.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserGroupsResponse, UserGroup> ListUserGroups(OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserGroupsRequest request = new ListUserGroupsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUserGroups(request, callSettings);
        }

        /// <summary>
        /// Returns a list of user groups in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent org where this UserGroup will be listed.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserGroupsResponse, UserGroup> ListUserGroupsAsync(OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserGroupsRequest request = new ListUserGroupsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUserGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserGroup CreateUserGroup(CreateUserGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroup> CreateUserGroupAsync(CreateUserGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroup> CreateUserGroupAsync(CreateUserGroupRequest request, st::CancellationToken cancellationToken) =>
            CreateUserGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this UserGroup will be created.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="userGroup">
        /// Required. The user group to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserGroup CreateUserGroup(string parent, UserGroup userGroup, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserGroup(new CreateUserGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserGroup = gax::GaxPreconditions.CheckNotNull(userGroup, nameof(userGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this UserGroup will be created.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="userGroup">
        /// Required. The user group to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroup> CreateUserGroupAsync(string parent, UserGroup userGroup, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserGroupAsync(new CreateUserGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserGroup = gax::GaxPreconditions.CheckNotNull(userGroup, nameof(userGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this UserGroup will be created.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="userGroup">
        /// Required. The user group to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroup> CreateUserGroupAsync(string parent, UserGroup userGroup, st::CancellationToken cancellationToken) =>
            CreateUserGroupAsync(parent, userGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this UserGroup will be created.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="userGroup">
        /// Required. The user group to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserGroup CreateUserGroup(OrganizationName parent, UserGroup userGroup, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserGroup(new CreateUserGroupRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserGroup = gax::GaxPreconditions.CheckNotNull(userGroup, nameof(userGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this UserGroup will be created.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="userGroup">
        /// Required. The user group to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroup> CreateUserGroupAsync(OrganizationName parent, UserGroup userGroup, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserGroupAsync(new CreateUserGroupRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserGroup = gax::GaxPreconditions.CheckNotNull(userGroup, nameof(userGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this UserGroup will be created.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="userGroup">
        /// Required. The user group to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroup> CreateUserGroupAsync(OrganizationName parent, UserGroup userGroup, st::CancellationToken cancellationToken) =>
            CreateUserGroupAsync(parent, userGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserGroup UpdateUserGroup(UpdateUserGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroup> UpdateUserGroupAsync(UpdateUserGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroup> UpdateUserGroupAsync(UpdateUserGroupRequest request, st::CancellationToken cancellationToken) =>
            UpdateUserGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="userGroup">
        /// Required. The user group to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. Field names must be in snake case
        /// (for example, "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserGroup UpdateUserGroup(UserGroup userGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserGroup(new UpdateUserGroupRequest
            {
                UserGroup = gax::GaxPreconditions.CheckNotNull(userGroup, nameof(userGroup)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="userGroup">
        /// Required. The user group to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. Field names must be in snake case
        /// (for example, "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroup> UpdateUserGroupAsync(UserGroup userGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserGroupAsync(new UpdateUserGroupRequest
            {
                UserGroup = gax::GaxPreconditions.CheckNotNull(userGroup, nameof(userGroup)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="userGroup">
        /// Required. The user group to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. Field names must be in snake case
        /// (for example, "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroup> UpdateUserGroupAsync(UserGroup userGroup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateUserGroupAsync(userGroup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a user group in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUserGroup(DeleteUserGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a user group in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserGroupAsync(DeleteUserGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a user group in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserGroupAsync(DeleteUserGroupRequest request, st::CancellationToken cancellationToken) =>
            DeleteUserGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a user group in the specified GMP organization.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user group to delete.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUserGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserGroup(new DeleteUserGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a user group in the specified GMP organization.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user group to delete.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserGroupAsync(new DeleteUserGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a user group in the specified GMP organization.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user group to delete.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserGroupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteUserGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a user group in the specified GMP organization.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user group to delete.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUserGroup(UserGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserGroup(new DeleteUserGroupRequest
            {
                UserGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a user group in the specified GMP organization.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user group to delete.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserGroupAsync(UserGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserGroupAsync(new DeleteUserGroupRequest
            {
                UserGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a user group in the specified GMP organization.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user group to delete.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserGroupAsync(UserGroupName name, st::CancellationToken cancellationToken) =>
            DeleteUserGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks up a single user group member.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserGroupMember GetUserGroupMember(GetUserGroupMemberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up a single user group member.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroupMember> GetUserGroupMemberAsync(GetUserGroupMemberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up a single user group member.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroupMember> GetUserGroupMemberAsync(GetUserGroupMemberRequest request, st::CancellationToken cancellationToken) =>
            GetUserGroupMemberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks up a single user group member.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user group member to retrieve.
        /// Format:
        /// organizations/{org_id}/userGroups/{user_group_id}/members/{member_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserGroupMember GetUserGroupMember(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserGroupMember(new GetUserGroupMemberRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Looks up a single user group member.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user group member to retrieve.
        /// Format:
        /// organizations/{org_id}/userGroups/{user_group_id}/members/{member_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroupMember> GetUserGroupMemberAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserGroupMemberAsync(new GetUserGroupMemberRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Looks up a single user group member.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user group member to retrieve.
        /// Format:
        /// organizations/{org_id}/userGroups/{user_group_id}/members/{member_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroupMember> GetUserGroupMemberAsync(string name, st::CancellationToken cancellationToken) =>
            GetUserGroupMemberAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks up a single user group member.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user group member to retrieve.
        /// Format:
        /// organizations/{org_id}/userGroups/{user_group_id}/members/{member_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserGroupMember GetUserGroupMember(UserGroupMemberName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserGroupMember(new GetUserGroupMemberRequest
            {
                UserGroupMemberName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Looks up a single user group member.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user group member to retrieve.
        /// Format:
        /// organizations/{org_id}/userGroups/{user_group_id}/members/{member_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroupMember> GetUserGroupMemberAsync(UserGroupMemberName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserGroupMemberAsync(new GetUserGroupMemberRequest
            {
                UserGroupMemberName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Looks up a single user group member.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user group member to retrieve.
        /// Format:
        /// organizations/{org_id}/userGroups/{user_group_id}/members/{member_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroupMember> GetUserGroupMemberAsync(UserGroupMemberName name, st::CancellationToken cancellationToken) =>
            GetUserGroupMemberAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of members in the specified user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserGroupMember"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserGroupMembersResponse, UserGroupMember> ListUserGroupMembers(ListUserGroupMembersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of members in the specified user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserGroupMember"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserGroupMembersResponse, UserGroupMember> ListUserGroupMembersAsync(ListUserGroupMembersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of members in the specified user group.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent user group where this UserGroupMember will be listed.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserGroupMember"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserGroupMembersResponse, UserGroupMember> ListUserGroupMembers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserGroupMembersRequest request = new ListUserGroupMembersRequest
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
            return ListUserGroupMembers(request, callSettings);
        }

        /// <summary>
        /// Returns a list of members in the specified user group.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent user group where this UserGroupMember will be listed.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserGroupMember"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserGroupMembersResponse, UserGroupMember> ListUserGroupMembersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserGroupMembersRequest request = new ListUserGroupMembersRequest
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
            return ListUserGroupMembersAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of members in the specified user group.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent user group where this UserGroupMember will be listed.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserGroupMember"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserGroupMembersResponse, UserGroupMember> ListUserGroupMembers(UserGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserGroupMembersRequest request = new ListUserGroupMembersRequest
            {
                ParentAsUserGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUserGroupMembers(request, callSettings);
        }

        /// <summary>
        /// Returns a list of members in the specified user group.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent user group where this UserGroupMember will be listed.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserGroupMember"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserGroupMembersResponse, UserGroupMember> ListUserGroupMembersAsync(UserGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserGroupMembersRequest request = new ListUserGroupMembersRequest
            {
                ParentAsUserGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUserGroupMembersAsync(request, callSettings);
        }

        /// <summary>
        /// Adds a member to the specified GMP user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserGroupMember CreateUserGroupMember(CreateUserGroupMemberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a member to the specified GMP user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroupMember> CreateUserGroupMemberAsync(CreateUserGroupMemberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a member to the specified GMP user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroupMember> CreateUserGroupMemberAsync(CreateUserGroupMemberRequest request, st::CancellationToken cancellationToken) =>
            CreateUserGroupMemberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a member to the specified GMP user group.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this UserGroupMember will be created.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="userGroupMember">
        /// Required. The user group member to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserGroupMember CreateUserGroupMember(string parent, UserGroupMember userGroupMember, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserGroupMember(new CreateUserGroupMemberRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserGroupMember = gax::GaxPreconditions.CheckNotNull(userGroupMember, nameof(userGroupMember)),
            }, callSettings);

        /// <summary>
        /// Adds a member to the specified GMP user group.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this UserGroupMember will be created.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="userGroupMember">
        /// Required. The user group member to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroupMember> CreateUserGroupMemberAsync(string parent, UserGroupMember userGroupMember, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserGroupMemberAsync(new CreateUserGroupMemberRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserGroupMember = gax::GaxPreconditions.CheckNotNull(userGroupMember, nameof(userGroupMember)),
            }, callSettings);

        /// <summary>
        /// Adds a member to the specified GMP user group.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this UserGroupMember will be created.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="userGroupMember">
        /// Required. The user group member to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroupMember> CreateUserGroupMemberAsync(string parent, UserGroupMember userGroupMember, st::CancellationToken cancellationToken) =>
            CreateUserGroupMemberAsync(parent, userGroupMember, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a member to the specified GMP user group.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this UserGroupMember will be created.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="userGroupMember">
        /// Required. The user group member to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserGroupMember CreateUserGroupMember(UserGroupName parent, UserGroupMember userGroupMember, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserGroupMember(new CreateUserGroupMemberRequest
            {
                ParentAsUserGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserGroupMember = gax::GaxPreconditions.CheckNotNull(userGroupMember, nameof(userGroupMember)),
            }, callSettings);

        /// <summary>
        /// Adds a member to the specified GMP user group.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this UserGroupMember will be created.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="userGroupMember">
        /// Required. The user group member to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroupMember> CreateUserGroupMemberAsync(UserGroupName parent, UserGroupMember userGroupMember, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserGroupMemberAsync(new CreateUserGroupMemberRequest
            {
                ParentAsUserGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserGroupMember = gax::GaxPreconditions.CheckNotNull(userGroupMember, nameof(userGroupMember)),
            }, callSettings);

        /// <summary>
        /// Adds a member to the specified GMP user group.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this UserGroupMember will be created.
        /// Format: organizations/{org_id}/userGroups/{user_group_id}
        /// </param>
        /// <param name="userGroupMember">
        /// Required. The user group member to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroupMember> CreateUserGroupMemberAsync(UserGroupName parent, UserGroupMember userGroupMember, st::CancellationToken cancellationToken) =>
            CreateUserGroupMemberAsync(parent, userGroupMember, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a member in the specified GMP user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserGroupMember UpdateUserGroupMember(UpdateUserGroupMemberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a member in the specified GMP user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroupMember> UpdateUserGroupMemberAsync(UpdateUserGroupMemberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a member in the specified GMP user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroupMember> UpdateUserGroupMemberAsync(UpdateUserGroupMemberRequest request, st::CancellationToken cancellationToken) =>
            UpdateUserGroupMemberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a member in the specified GMP user group.
        /// </summary>
        /// <param name="userGroupMember">
        /// Required. The user group member to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. Field names must be in snake case
        /// (for example, "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserGroupMember UpdateUserGroupMember(UserGroupMember userGroupMember, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserGroupMember(new UpdateUserGroupMemberRequest
            {
                UserGroupMember = gax::GaxPreconditions.CheckNotNull(userGroupMember, nameof(userGroupMember)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a member in the specified GMP user group.
        /// </summary>
        /// <param name="userGroupMember">
        /// Required. The user group member to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. Field names must be in snake case
        /// (for example, "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroupMember> UpdateUserGroupMemberAsync(UserGroupMember userGroupMember, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserGroupMemberAsync(new UpdateUserGroupMemberRequest
            {
                UserGroupMember = gax::GaxPreconditions.CheckNotNull(userGroupMember, nameof(userGroupMember)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a member in the specified GMP user group.
        /// </summary>
        /// <param name="userGroupMember">
        /// Required. The user group member to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. Field names must be in snake case
        /// (for example, "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserGroupMember> UpdateUserGroupMemberAsync(UserGroupMember userGroupMember, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateUserGroupMemberAsync(userGroupMember, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a member in the specified GMP user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUserGroupMember(DeleteUserGroupMemberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a member in the specified GMP user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserGroupMemberAsync(DeleteUserGroupMemberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a member in the specified GMP user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserGroupMemberAsync(DeleteUserGroupMemberRequest request, st::CancellationToken cancellationToken) =>
            DeleteUserGroupMemberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a member in the specified GMP user group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user group member to delete.
        /// Format:
        /// organizations/{org_id}/userGroups/{user_group_id}/members/{member_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUserGroupMember(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserGroupMember(new DeleteUserGroupMemberRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a member in the specified GMP user group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user group member to delete.
        /// Format:
        /// organizations/{org_id}/userGroups/{user_group_id}/members/{member_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserGroupMemberAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserGroupMemberAsync(new DeleteUserGroupMemberRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a member in the specified GMP user group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user group member to delete.
        /// Format:
        /// organizations/{org_id}/userGroups/{user_group_id}/members/{member_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserGroupMemberAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteUserGroupMemberAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a member in the specified GMP user group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user group member to delete.
        /// Format:
        /// organizations/{org_id}/userGroups/{user_group_id}/members/{member_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUserGroupMember(UserGroupMemberName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserGroupMember(new DeleteUserGroupMemberRequest
            {
                UserGroupMemberName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a member in the specified GMP user group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user group member to delete.
        /// Format:
        /// organizations/{org_id}/userGroups/{user_group_id}/members/{member_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserGroupMemberAsync(UserGroupMemberName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserGroupMemberAsync(new DeleteUserGroupMemberRequest
            {
                UserGroupMemberName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a member in the specified GMP user group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user group member to delete.
        /// Format:
        /// organizations/{org_id}/userGroups/{user_group_id}/members/{member_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserGroupMemberAsync(UserGroupMemberName name, st::CancellationToken cancellationToken) =>
            DeleteUserGroupMemberAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks up a single admin access binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdminAccessBinding GetAdminAccessBinding(GetAdminAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up a single admin access binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdminAccessBinding> GetAdminAccessBindingAsync(GetAdminAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up a single admin access binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdminAccessBinding> GetAdminAccessBindingAsync(GetAdminAccessBindingRequest request, st::CancellationToken cancellationToken) =>
            GetAdminAccessBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks up a single admin access binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AdminAccessBinding to retrieve.
        /// Format:
        /// organizations/{org_id}/adminAccessBindings/{admin_access_binding_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdminAccessBinding GetAdminAccessBinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdminAccessBinding(new GetAdminAccessBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Looks up a single admin access binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AdminAccessBinding to retrieve.
        /// Format:
        /// organizations/{org_id}/adminAccessBindings/{admin_access_binding_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdminAccessBinding> GetAdminAccessBindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdminAccessBindingAsync(new GetAdminAccessBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Looks up a single admin access binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AdminAccessBinding to retrieve.
        /// Format:
        /// organizations/{org_id}/adminAccessBindings/{admin_access_binding_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdminAccessBinding> GetAdminAccessBindingAsync(string name, st::CancellationToken cancellationToken) =>
            GetAdminAccessBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks up a single admin access binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AdminAccessBinding to retrieve.
        /// Format:
        /// organizations/{org_id}/adminAccessBindings/{admin_access_binding_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdminAccessBinding GetAdminAccessBinding(AdminAccessBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdminAccessBinding(new GetAdminAccessBindingRequest
            {
                AdminAccessBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Looks up a single admin access binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AdminAccessBinding to retrieve.
        /// Format:
        /// organizations/{org_id}/adminAccessBindings/{admin_access_binding_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdminAccessBinding> GetAdminAccessBindingAsync(AdminAccessBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdminAccessBindingAsync(new GetAdminAccessBindingRequest
            {
                AdminAccessBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Looks up a single admin access binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AdminAccessBinding to retrieve.
        /// Format:
        /// organizations/{org_id}/adminAccessBindings/{admin_access_binding_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdminAccessBinding> GetAdminAccessBindingAsync(AdminAccessBindingName name, st::CancellationToken cancellationToken) =>
            GetAdminAccessBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of admin access bindings in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AdminAccessBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdminAccessBindingsResponse, AdminAccessBinding> ListAdminAccessBindings(ListAdminAccessBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of admin access bindings in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AdminAccessBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdminAccessBindingsResponse, AdminAccessBinding> ListAdminAccessBindingsAsync(ListAdminAccessBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of admin access bindings in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent organization, which owns this collection of Admin
        /// Access Bindings. Format: organizations/{org_id}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AdminAccessBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdminAccessBindingsResponse, AdminAccessBinding> ListAdminAccessBindings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdminAccessBindingsRequest request = new ListAdminAccessBindingsRequest
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
            return ListAdminAccessBindings(request, callSettings);
        }

        /// <summary>
        /// Returns a list of admin access bindings in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent organization, which owns this collection of Admin
        /// Access Bindings. Format: organizations/{org_id}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AdminAccessBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdminAccessBindingsResponse, AdminAccessBinding> ListAdminAccessBindingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdminAccessBindingsRequest request = new ListAdminAccessBindingsRequest
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
            return ListAdminAccessBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of admin access bindings in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent organization, which owns this collection of Admin
        /// Access Bindings. Format: organizations/{org_id}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AdminAccessBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdminAccessBindingsResponse, AdminAccessBinding> ListAdminAccessBindings(OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdminAccessBindingsRequest request = new ListAdminAccessBindingsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAdminAccessBindings(request, callSettings);
        }

        /// <summary>
        /// Returns a list of admin access bindings in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent organization, which owns this collection of Admin
        /// Access Bindings. Format: organizations/{org_id}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AdminAccessBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdminAccessBindingsResponse, AdminAccessBinding> ListAdminAccessBindingsAsync(OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdminAccessBindingsRequest request = new ListAdminAccessBindingsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAdminAccessBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdminAccessBinding CreateAdminAccessBinding(CreateAdminAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdminAccessBinding> CreateAdminAccessBindingAsync(CreateAdminAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdminAccessBinding> CreateAdminAccessBindingAsync(CreateAdminAccessBindingRequest request, st::CancellationToken cancellationToken) =>
            CreateAdminAccessBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent organization, which owns this Admin Access Binding.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="adminAccessBinding">
        /// Required. The Admin Access Binding to create.
        /// 
        /// Only 'user_email' input is allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdminAccessBinding CreateAdminAccessBinding(string parent, AdminAccessBinding adminAccessBinding, gaxgrpc::CallSettings callSettings = null) =>
            CreateAdminAccessBinding(new CreateAdminAccessBindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AdminAccessBinding = gax::GaxPreconditions.CheckNotNull(adminAccessBinding, nameof(adminAccessBinding)),
            }, callSettings);

        /// <summary>
        /// Creates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent organization, which owns this Admin Access Binding.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="adminAccessBinding">
        /// Required. The Admin Access Binding to create.
        /// 
        /// Only 'user_email' input is allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdminAccessBinding> CreateAdminAccessBindingAsync(string parent, AdminAccessBinding adminAccessBinding, gaxgrpc::CallSettings callSettings = null) =>
            CreateAdminAccessBindingAsync(new CreateAdminAccessBindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AdminAccessBinding = gax::GaxPreconditions.CheckNotNull(adminAccessBinding, nameof(adminAccessBinding)),
            }, callSettings);

        /// <summary>
        /// Creates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent organization, which owns this Admin Access Binding.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="adminAccessBinding">
        /// Required. The Admin Access Binding to create.
        /// 
        /// Only 'user_email' input is allowed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdminAccessBinding> CreateAdminAccessBindingAsync(string parent, AdminAccessBinding adminAccessBinding, st::CancellationToken cancellationToken) =>
            CreateAdminAccessBindingAsync(parent, adminAccessBinding, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent organization, which owns this Admin Access Binding.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="adminAccessBinding">
        /// Required. The Admin Access Binding to create.
        /// 
        /// Only 'user_email' input is allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdminAccessBinding CreateAdminAccessBinding(OrganizationName parent, AdminAccessBinding adminAccessBinding, gaxgrpc::CallSettings callSettings = null) =>
            CreateAdminAccessBinding(new CreateAdminAccessBindingRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AdminAccessBinding = gax::GaxPreconditions.CheckNotNull(adminAccessBinding, nameof(adminAccessBinding)),
            }, callSettings);

        /// <summary>
        /// Creates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent organization, which owns this Admin Access Binding.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="adminAccessBinding">
        /// Required. The Admin Access Binding to create.
        /// 
        /// Only 'user_email' input is allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdminAccessBinding> CreateAdminAccessBindingAsync(OrganizationName parent, AdminAccessBinding adminAccessBinding, gaxgrpc::CallSettings callSettings = null) =>
            CreateAdminAccessBindingAsync(new CreateAdminAccessBindingRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AdminAccessBinding = gax::GaxPreconditions.CheckNotNull(adminAccessBinding, nameof(adminAccessBinding)),
            }, callSettings);

        /// <summary>
        /// Creates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent organization, which owns this Admin Access Binding.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="adminAccessBinding">
        /// Required. The Admin Access Binding to create.
        /// 
        /// Only 'user_email' input is allowed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdminAccessBinding> CreateAdminAccessBindingAsync(OrganizationName parent, AdminAccessBinding adminAccessBinding, st::CancellationToken cancellationToken) =>
            CreateAdminAccessBindingAsync(parent, adminAccessBinding, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdminAccessBinding UpdateAdminAccessBinding(UpdateAdminAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdminAccessBinding> UpdateAdminAccessBindingAsync(UpdateAdminAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdminAccessBinding> UpdateAdminAccessBindingAsync(UpdateAdminAccessBindingRequest request, st::CancellationToken cancellationToken) =>
            UpdateAdminAccessBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="adminAccessBinding">
        /// Required. The AdminAccessBinding to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. Field names must be in snake case
        /// (for example, "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdminAccessBinding UpdateAdminAccessBinding(AdminAccessBinding adminAccessBinding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAdminAccessBinding(new UpdateAdminAccessBindingRequest
            {
                AdminAccessBinding = gax::GaxPreconditions.CheckNotNull(adminAccessBinding, nameof(adminAccessBinding)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="adminAccessBinding">
        /// Required. The AdminAccessBinding to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. Field names must be in snake case
        /// (for example, "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdminAccessBinding> UpdateAdminAccessBindingAsync(AdminAccessBinding adminAccessBinding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAdminAccessBindingAsync(new UpdateAdminAccessBindingRequest
            {
                AdminAccessBinding = gax::GaxPreconditions.CheckNotNull(adminAccessBinding, nameof(adminAccessBinding)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="adminAccessBinding">
        /// Required. The AdminAccessBinding to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. Field names must be in snake case
        /// (for example, "field_to_update"). Omitted fields will not be updated. To
        /// replace the entire entity, use one path with the string "*" to match all
        /// fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdminAccessBinding> UpdateAdminAccessBindingAsync(AdminAccessBinding adminAccessBinding, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAdminAccessBindingAsync(adminAccessBinding, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>MarketingplatformAdminService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service Interface for the Google Marketing Platform Admin API.
    /// </remarks>
    public sealed partial class MarketingplatformAdminServiceClientImpl : MarketingplatformAdminServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetOrganizationRequest, Organization> _callGetOrganization;

        private readonly gaxgrpc::ApiCall<ListOrganizationsRequest, ListOrganizationsResponse> _callListOrganizations;

        private readonly gaxgrpc::ApiCall<FindSalesPartnerManagedClientsRequest, FindSalesPartnerManagedClientsResponse> _callFindSalesPartnerManagedClients;

        private readonly gaxgrpc::ApiCall<ListAnalyticsAccountLinksRequest, ListAnalyticsAccountLinksResponse> _callListAnalyticsAccountLinks;

        private readonly gaxgrpc::ApiCall<CreateAnalyticsAccountLinkRequest, AnalyticsAccountLink> _callCreateAnalyticsAccountLink;

        private readonly gaxgrpc::ApiCall<DeleteAnalyticsAccountLinkRequest, wkt::Empty> _callDeleteAnalyticsAccountLink;

        private readonly gaxgrpc::ApiCall<SetPropertyServiceLevelRequest, SetPropertyServiceLevelResponse> _callSetPropertyServiceLevel;

        private readonly gaxgrpc::ApiCall<ReportPropertyUsageRequest, ReportPropertyUsageResponse> _callReportPropertyUsage;

        private readonly gaxgrpc::ApiCall<GetUserGroupRequest, UserGroup> _callGetUserGroup;

        private readonly gaxgrpc::ApiCall<ListUserGroupsRequest, ListUserGroupsResponse> _callListUserGroups;

        private readonly gaxgrpc::ApiCall<CreateUserGroupRequest, UserGroup> _callCreateUserGroup;

        private readonly gaxgrpc::ApiCall<UpdateUserGroupRequest, UserGroup> _callUpdateUserGroup;

        private readonly gaxgrpc::ApiCall<DeleteUserGroupRequest, wkt::Empty> _callDeleteUserGroup;

        private readonly gaxgrpc::ApiCall<GetUserGroupMemberRequest, UserGroupMember> _callGetUserGroupMember;

        private readonly gaxgrpc::ApiCall<ListUserGroupMembersRequest, ListUserGroupMembersResponse> _callListUserGroupMembers;

        private readonly gaxgrpc::ApiCall<CreateUserGroupMemberRequest, UserGroupMember> _callCreateUserGroupMember;

        private readonly gaxgrpc::ApiCall<UpdateUserGroupMemberRequest, UserGroupMember> _callUpdateUserGroupMember;

        private readonly gaxgrpc::ApiCall<DeleteUserGroupMemberRequest, wkt::Empty> _callDeleteUserGroupMember;

        private readonly gaxgrpc::ApiCall<GetAdminAccessBindingRequest, AdminAccessBinding> _callGetAdminAccessBinding;

        private readonly gaxgrpc::ApiCall<ListAdminAccessBindingsRequest, ListAdminAccessBindingsResponse> _callListAdminAccessBindings;

        private readonly gaxgrpc::ApiCall<CreateAdminAccessBindingRequest, AdminAccessBinding> _callCreateAdminAccessBinding;

        private readonly gaxgrpc::ApiCall<UpdateAdminAccessBindingRequest, AdminAccessBinding> _callUpdateAdminAccessBinding;

        /// <summary>
        /// Constructs a client wrapper for the MarketingplatformAdminService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="MarketingplatformAdminServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MarketingplatformAdminServiceClientImpl(MarketingplatformAdminService.MarketingplatformAdminServiceClient grpcClient, MarketingplatformAdminServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MarketingplatformAdminServiceSettings effectiveSettings = settings ?? MarketingplatformAdminServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetOrganization = clientHelper.BuildApiCall<GetOrganizationRequest, Organization>("GetOrganization", grpcClient.GetOrganizationAsync, grpcClient.GetOrganization, effectiveSettings.GetOrganizationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOrganization);
            Modify_GetOrganizationApiCall(ref _callGetOrganization);
            _callListOrganizations = clientHelper.BuildApiCall<ListOrganizationsRequest, ListOrganizationsResponse>("ListOrganizations", grpcClient.ListOrganizationsAsync, grpcClient.ListOrganizations, effectiveSettings.ListOrganizationsSettings);
            Modify_ApiCall(ref _callListOrganizations);
            Modify_ListOrganizationsApiCall(ref _callListOrganizations);
            _callFindSalesPartnerManagedClients = clientHelper.BuildApiCall<FindSalesPartnerManagedClientsRequest, FindSalesPartnerManagedClientsResponse>("FindSalesPartnerManagedClients", grpcClient.FindSalesPartnerManagedClientsAsync, grpcClient.FindSalesPartnerManagedClients, effectiveSettings.FindSalesPartnerManagedClientsSettings).WithGoogleRequestParam("organization", request => request.Organization);
            Modify_ApiCall(ref _callFindSalesPartnerManagedClients);
            Modify_FindSalesPartnerManagedClientsApiCall(ref _callFindSalesPartnerManagedClients);
            _callListAnalyticsAccountLinks = clientHelper.BuildApiCall<ListAnalyticsAccountLinksRequest, ListAnalyticsAccountLinksResponse>("ListAnalyticsAccountLinks", grpcClient.ListAnalyticsAccountLinksAsync, grpcClient.ListAnalyticsAccountLinks, effectiveSettings.ListAnalyticsAccountLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAnalyticsAccountLinks);
            Modify_ListAnalyticsAccountLinksApiCall(ref _callListAnalyticsAccountLinks);
            _callCreateAnalyticsAccountLink = clientHelper.BuildApiCall<CreateAnalyticsAccountLinkRequest, AnalyticsAccountLink>("CreateAnalyticsAccountLink", grpcClient.CreateAnalyticsAccountLinkAsync, grpcClient.CreateAnalyticsAccountLink, effectiveSettings.CreateAnalyticsAccountLinkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAnalyticsAccountLink);
            Modify_CreateAnalyticsAccountLinkApiCall(ref _callCreateAnalyticsAccountLink);
            _callDeleteAnalyticsAccountLink = clientHelper.BuildApiCall<DeleteAnalyticsAccountLinkRequest, wkt::Empty>("DeleteAnalyticsAccountLink", grpcClient.DeleteAnalyticsAccountLinkAsync, grpcClient.DeleteAnalyticsAccountLink, effectiveSettings.DeleteAnalyticsAccountLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAnalyticsAccountLink);
            Modify_DeleteAnalyticsAccountLinkApiCall(ref _callDeleteAnalyticsAccountLink);
            _callSetPropertyServiceLevel = clientHelper.BuildApiCall<SetPropertyServiceLevelRequest, SetPropertyServiceLevelResponse>("SetPropertyServiceLevel", grpcClient.SetPropertyServiceLevelAsync, grpcClient.SetPropertyServiceLevel, effectiveSettings.SetPropertyServiceLevelSettings).WithGoogleRequestParam("analytics_account_link", request => request.AnalyticsAccountLink);
            Modify_ApiCall(ref _callSetPropertyServiceLevel);
            Modify_SetPropertyServiceLevelApiCall(ref _callSetPropertyServiceLevel);
            _callReportPropertyUsage = clientHelper.BuildApiCall<ReportPropertyUsageRequest, ReportPropertyUsageResponse>("ReportPropertyUsage", grpcClient.ReportPropertyUsageAsync, grpcClient.ReportPropertyUsage, effectiveSettings.ReportPropertyUsageSettings).WithGoogleRequestParam("organization", request => request.Organization);
            Modify_ApiCall(ref _callReportPropertyUsage);
            Modify_ReportPropertyUsageApiCall(ref _callReportPropertyUsage);
            _callGetUserGroup = clientHelper.BuildApiCall<GetUserGroupRequest, UserGroup>("GetUserGroup", grpcClient.GetUserGroupAsync, grpcClient.GetUserGroup, effectiveSettings.GetUserGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUserGroup);
            Modify_GetUserGroupApiCall(ref _callGetUserGroup);
            _callListUserGroups = clientHelper.BuildApiCall<ListUserGroupsRequest, ListUserGroupsResponse>("ListUserGroups", grpcClient.ListUserGroupsAsync, grpcClient.ListUserGroups, effectiveSettings.ListUserGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUserGroups);
            Modify_ListUserGroupsApiCall(ref _callListUserGroups);
            _callCreateUserGroup = clientHelper.BuildApiCall<CreateUserGroupRequest, UserGroup>("CreateUserGroup", grpcClient.CreateUserGroupAsync, grpcClient.CreateUserGroup, effectiveSettings.CreateUserGroupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUserGroup);
            Modify_CreateUserGroupApiCall(ref _callCreateUserGroup);
            _callUpdateUserGroup = clientHelper.BuildApiCall<UpdateUserGroupRequest, UserGroup>("UpdateUserGroup", grpcClient.UpdateUserGroupAsync, grpcClient.UpdateUserGroup, effectiveSettings.UpdateUserGroupSettings).WithGoogleRequestParam("user_group.name", request => request.UserGroup?.Name);
            Modify_ApiCall(ref _callUpdateUserGroup);
            Modify_UpdateUserGroupApiCall(ref _callUpdateUserGroup);
            _callDeleteUserGroup = clientHelper.BuildApiCall<DeleteUserGroupRequest, wkt::Empty>("DeleteUserGroup", grpcClient.DeleteUserGroupAsync, grpcClient.DeleteUserGroup, effectiveSettings.DeleteUserGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteUserGroup);
            Modify_DeleteUserGroupApiCall(ref _callDeleteUserGroup);
            _callGetUserGroupMember = clientHelper.BuildApiCall<GetUserGroupMemberRequest, UserGroupMember>("GetUserGroupMember", grpcClient.GetUserGroupMemberAsync, grpcClient.GetUserGroupMember, effectiveSettings.GetUserGroupMemberSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUserGroupMember);
            Modify_GetUserGroupMemberApiCall(ref _callGetUserGroupMember);
            _callListUserGroupMembers = clientHelper.BuildApiCall<ListUserGroupMembersRequest, ListUserGroupMembersResponse>("ListUserGroupMembers", grpcClient.ListUserGroupMembersAsync, grpcClient.ListUserGroupMembers, effectiveSettings.ListUserGroupMembersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUserGroupMembers);
            Modify_ListUserGroupMembersApiCall(ref _callListUserGroupMembers);
            _callCreateUserGroupMember = clientHelper.BuildApiCall<CreateUserGroupMemberRequest, UserGroupMember>("CreateUserGroupMember", grpcClient.CreateUserGroupMemberAsync, grpcClient.CreateUserGroupMember, effectiveSettings.CreateUserGroupMemberSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUserGroupMember);
            Modify_CreateUserGroupMemberApiCall(ref _callCreateUserGroupMember);
            _callUpdateUserGroupMember = clientHelper.BuildApiCall<UpdateUserGroupMemberRequest, UserGroupMember>("UpdateUserGroupMember", grpcClient.UpdateUserGroupMemberAsync, grpcClient.UpdateUserGroupMember, effectiveSettings.UpdateUserGroupMemberSettings).WithGoogleRequestParam("user_group_member.name", request => request.UserGroupMember?.Name);
            Modify_ApiCall(ref _callUpdateUserGroupMember);
            Modify_UpdateUserGroupMemberApiCall(ref _callUpdateUserGroupMember);
            _callDeleteUserGroupMember = clientHelper.BuildApiCall<DeleteUserGroupMemberRequest, wkt::Empty>("DeleteUserGroupMember", grpcClient.DeleteUserGroupMemberAsync, grpcClient.DeleteUserGroupMember, effectiveSettings.DeleteUserGroupMemberSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteUserGroupMember);
            Modify_DeleteUserGroupMemberApiCall(ref _callDeleteUserGroupMember);
            _callGetAdminAccessBinding = clientHelper.BuildApiCall<GetAdminAccessBindingRequest, AdminAccessBinding>("GetAdminAccessBinding", grpcClient.GetAdminAccessBindingAsync, grpcClient.GetAdminAccessBinding, effectiveSettings.GetAdminAccessBindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAdminAccessBinding);
            Modify_GetAdminAccessBindingApiCall(ref _callGetAdminAccessBinding);
            _callListAdminAccessBindings = clientHelper.BuildApiCall<ListAdminAccessBindingsRequest, ListAdminAccessBindingsResponse>("ListAdminAccessBindings", grpcClient.ListAdminAccessBindingsAsync, grpcClient.ListAdminAccessBindings, effectiveSettings.ListAdminAccessBindingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAdminAccessBindings);
            Modify_ListAdminAccessBindingsApiCall(ref _callListAdminAccessBindings);
            _callCreateAdminAccessBinding = clientHelper.BuildApiCall<CreateAdminAccessBindingRequest, AdminAccessBinding>("CreateAdminAccessBinding", grpcClient.CreateAdminAccessBindingAsync, grpcClient.CreateAdminAccessBinding, effectiveSettings.CreateAdminAccessBindingSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAdminAccessBinding);
            Modify_CreateAdminAccessBindingApiCall(ref _callCreateAdminAccessBinding);
            _callUpdateAdminAccessBinding = clientHelper.BuildApiCall<UpdateAdminAccessBindingRequest, AdminAccessBinding>("UpdateAdminAccessBinding", grpcClient.UpdateAdminAccessBindingAsync, grpcClient.UpdateAdminAccessBinding, effectiveSettings.UpdateAdminAccessBindingSettings).WithGoogleRequestParam("admin_access_binding.name", request => request.AdminAccessBinding?.Name);
            Modify_ApiCall(ref _callUpdateAdminAccessBinding);
            Modify_UpdateAdminAccessBindingApiCall(ref _callUpdateAdminAccessBinding);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetOrganizationApiCall(ref gaxgrpc::ApiCall<GetOrganizationRequest, Organization> call);

        partial void Modify_ListOrganizationsApiCall(ref gaxgrpc::ApiCall<ListOrganizationsRequest, ListOrganizationsResponse> call);

        partial void Modify_FindSalesPartnerManagedClientsApiCall(ref gaxgrpc::ApiCall<FindSalesPartnerManagedClientsRequest, FindSalesPartnerManagedClientsResponse> call);

        partial void Modify_ListAnalyticsAccountLinksApiCall(ref gaxgrpc::ApiCall<ListAnalyticsAccountLinksRequest, ListAnalyticsAccountLinksResponse> call);

        partial void Modify_CreateAnalyticsAccountLinkApiCall(ref gaxgrpc::ApiCall<CreateAnalyticsAccountLinkRequest, AnalyticsAccountLink> call);

        partial void Modify_DeleteAnalyticsAccountLinkApiCall(ref gaxgrpc::ApiCall<DeleteAnalyticsAccountLinkRequest, wkt::Empty> call);

        partial void Modify_SetPropertyServiceLevelApiCall(ref gaxgrpc::ApiCall<SetPropertyServiceLevelRequest, SetPropertyServiceLevelResponse> call);

        partial void Modify_ReportPropertyUsageApiCall(ref gaxgrpc::ApiCall<ReportPropertyUsageRequest, ReportPropertyUsageResponse> call);

        partial void Modify_GetUserGroupApiCall(ref gaxgrpc::ApiCall<GetUserGroupRequest, UserGroup> call);

        partial void Modify_ListUserGroupsApiCall(ref gaxgrpc::ApiCall<ListUserGroupsRequest, ListUserGroupsResponse> call);

        partial void Modify_CreateUserGroupApiCall(ref gaxgrpc::ApiCall<CreateUserGroupRequest, UserGroup> call);

        partial void Modify_UpdateUserGroupApiCall(ref gaxgrpc::ApiCall<UpdateUserGroupRequest, UserGroup> call);

        partial void Modify_DeleteUserGroupApiCall(ref gaxgrpc::ApiCall<DeleteUserGroupRequest, wkt::Empty> call);

        partial void Modify_GetUserGroupMemberApiCall(ref gaxgrpc::ApiCall<GetUserGroupMemberRequest, UserGroupMember> call);

        partial void Modify_ListUserGroupMembersApiCall(ref gaxgrpc::ApiCall<ListUserGroupMembersRequest, ListUserGroupMembersResponse> call);

        partial void Modify_CreateUserGroupMemberApiCall(ref gaxgrpc::ApiCall<CreateUserGroupMemberRequest, UserGroupMember> call);

        partial void Modify_UpdateUserGroupMemberApiCall(ref gaxgrpc::ApiCall<UpdateUserGroupMemberRequest, UserGroupMember> call);

        partial void Modify_DeleteUserGroupMemberApiCall(ref gaxgrpc::ApiCall<DeleteUserGroupMemberRequest, wkt::Empty> call);

        partial void Modify_GetAdminAccessBindingApiCall(ref gaxgrpc::ApiCall<GetAdminAccessBindingRequest, AdminAccessBinding> call);

        partial void Modify_ListAdminAccessBindingsApiCall(ref gaxgrpc::ApiCall<ListAdminAccessBindingsRequest, ListAdminAccessBindingsResponse> call);

        partial void Modify_CreateAdminAccessBindingApiCall(ref gaxgrpc::ApiCall<CreateAdminAccessBindingRequest, AdminAccessBinding> call);

        partial void Modify_UpdateAdminAccessBindingApiCall(ref gaxgrpc::ApiCall<UpdateAdminAccessBindingRequest, AdminAccessBinding> call);

        partial void OnConstruction(MarketingplatformAdminService.MarketingplatformAdminServiceClient grpcClient, MarketingplatformAdminServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MarketingplatformAdminService client</summary>
        public override MarketingplatformAdminService.MarketingplatformAdminServiceClient GrpcClient { get; }

        partial void Modify_GetOrganizationRequest(ref GetOrganizationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOrganizationsRequest(ref ListOrganizationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FindSalesPartnerManagedClientsRequest(ref FindSalesPartnerManagedClientsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAnalyticsAccountLinksRequest(ref ListAnalyticsAccountLinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAnalyticsAccountLinkRequest(ref CreateAnalyticsAccountLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAnalyticsAccountLinkRequest(ref DeleteAnalyticsAccountLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetPropertyServiceLevelRequest(ref SetPropertyServiceLevelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReportPropertyUsageRequest(ref ReportPropertyUsageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetUserGroupRequest(ref GetUserGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUserGroupsRequest(ref ListUserGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateUserGroupRequest(ref CreateUserGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUserGroupRequest(ref UpdateUserGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteUserGroupRequest(ref DeleteUserGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetUserGroupMemberRequest(ref GetUserGroupMemberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUserGroupMembersRequest(ref ListUserGroupMembersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateUserGroupMemberRequest(ref CreateUserGroupMemberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUserGroupMemberRequest(ref UpdateUserGroupMemberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteUserGroupMemberRequest(ref DeleteUserGroupMemberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAdminAccessBindingRequest(ref GetAdminAccessBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAdminAccessBindingsRequest(ref ListAdminAccessBindingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAdminAccessBindingRequest(ref CreateAdminAccessBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAdminAccessBindingRequest(ref UpdateAdminAccessBindingRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Looks up a single organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Organization GetOrganization(GetOrganizationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrganizationRequest(ref request, ref callSettings);
            return _callGetOrganization.Sync(request, callSettings);
        }

        /// <summary>
        /// Looks up a single organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Organization> GetOrganizationAsync(GetOrganizationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrganizationRequest(ref request, ref callSettings);
            return _callGetOrganization.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of organizations that the user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Organization"/> resources.</returns>
        public override gax::PagedEnumerable<ListOrganizationsResponse, Organization> ListOrganizations(ListOrganizationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrganizationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOrganizationsRequest, ListOrganizationsResponse, Organization>(_callListOrganizations, request, callSettings);
        }

        /// <summary>
        /// Returns a list of organizations that the user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Organization"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOrganizationsResponse, Organization> ListOrganizationsAsync(ListOrganizationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrganizationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOrganizationsRequest, ListOrganizationsResponse, Organization>(_callListOrganizations, request, callSettings);
        }

        /// <summary>
        /// Returns a list of clients managed by the sales partner organization.
        /// 
        /// User needs to be an OrgAdmin/BillingAdmin on the sales partner organization
        /// in order to view the end clients.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FindSalesPartnerManagedClientsResponse FindSalesPartnerManagedClients(FindSalesPartnerManagedClientsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FindSalesPartnerManagedClientsRequest(ref request, ref callSettings);
            return _callFindSalesPartnerManagedClients.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of clients managed by the sales partner organization.
        /// 
        /// User needs to be an OrgAdmin/BillingAdmin on the sales partner organization
        /// in order to view the end clients.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FindSalesPartnerManagedClientsResponse> FindSalesPartnerManagedClientsAsync(FindSalesPartnerManagedClientsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FindSalesPartnerManagedClientsRequest(ref request, ref callSettings);
            return _callFindSalesPartnerManagedClients.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the Google Analytics accounts link to the specified Google Marketing
        /// Platform organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnalyticsAccountLink"/> resources.</returns>
        public override gax::PagedEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> ListAnalyticsAccountLinks(ListAnalyticsAccountLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnalyticsAccountLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAnalyticsAccountLinksRequest, ListAnalyticsAccountLinksResponse, AnalyticsAccountLink>(_callListAnalyticsAccountLinks, request, callSettings);
        }

        /// <summary>
        /// Lists the Google Analytics accounts link to the specified Google Marketing
        /// Platform organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnalyticsAccountLink"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> ListAnalyticsAccountLinksAsync(ListAnalyticsAccountLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnalyticsAccountLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAnalyticsAccountLinksRequest, ListAnalyticsAccountLinksResponse, AnalyticsAccountLink>(_callListAnalyticsAccountLinks, request, callSettings);
        }

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnalyticsAccountLink CreateAnalyticsAccountLink(CreateAnalyticsAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnalyticsAccountLinkRequest(ref request, ref callSettings);
            return _callCreateAnalyticsAccountLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnalyticsAccountLink> CreateAnalyticsAccountLinkAsync(CreateAnalyticsAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnalyticsAccountLinkRequest(ref request, ref callSettings);
            return _callCreateAnalyticsAccountLink.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAnalyticsAccountLink(DeleteAnalyticsAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAnalyticsAccountLinkRequest(ref request, ref callSettings);
            _callDeleteAnalyticsAccountLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAnalyticsAccountLinkAsync(DeleteAnalyticsAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAnalyticsAccountLinkRequest(ref request, ref callSettings);
            return _callDeleteAnalyticsAccountLink.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the service level for an Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SetPropertyServiceLevelResponse SetPropertyServiceLevel(SetPropertyServiceLevelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetPropertyServiceLevelRequest(ref request, ref callSettings);
            return _callSetPropertyServiceLevel.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the service level for an Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SetPropertyServiceLevelResponse> SetPropertyServiceLevelAsync(SetPropertyServiceLevelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetPropertyServiceLevelRequest(ref request, ref callSettings);
            return _callSetPropertyServiceLevel.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the usage and billing data for properties within the organization for
        /// the specified month.
        /// 
        /// Per direct client org, user needs to be OrgAdmin/BillingAdmin on the
        /// organization in order to view the billing and usage data.
        /// 
        /// Per sales partner client org, user needs to be OrgAdmin/BillingAdmin on
        /// the sales partner org in order to view the billing and usage data, or
        /// OrgAdmin/BillingAdmin on the sales partner client org in order to view the
        /// usage data only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReportPropertyUsageResponse ReportPropertyUsage(ReportPropertyUsageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportPropertyUsageRequest(ref request, ref callSettings);
            return _callReportPropertyUsage.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the usage and billing data for properties within the organization for
        /// the specified month.
        /// 
        /// Per direct client org, user needs to be OrgAdmin/BillingAdmin on the
        /// organization in order to view the billing and usage data.
        /// 
        /// Per sales partner client org, user needs to be OrgAdmin/BillingAdmin on
        /// the sales partner org in order to view the billing and usage data, or
        /// OrgAdmin/BillingAdmin on the sales partner client org in order to view the
        /// usage data only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReportPropertyUsageResponse> ReportPropertyUsageAsync(ReportPropertyUsageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportPropertyUsageRequest(ref request, ref callSettings);
            return _callReportPropertyUsage.Async(request, callSettings);
        }

        /// <summary>
        /// Looks up a single user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserGroup GetUserGroup(GetUserGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserGroupRequest(ref request, ref callSettings);
            return _callGetUserGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Looks up a single user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserGroup> GetUserGroupAsync(GetUserGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserGroupRequest(ref request, ref callSettings);
            return _callGetUserGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of user groups in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserGroup"/> resources.</returns>
        public override gax::PagedEnumerable<ListUserGroupsResponse, UserGroup> ListUserGroups(ListUserGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUserGroupsRequest, ListUserGroupsResponse, UserGroup>(_callListUserGroups, request, callSettings);
        }

        /// <summary>
        /// Returns a list of user groups in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUserGroupsResponse, UserGroup> ListUserGroupsAsync(ListUserGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUserGroupsRequest, ListUserGroupsResponse, UserGroup>(_callListUserGroups, request, callSettings);
        }

        /// <summary>
        /// Creates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserGroup CreateUserGroup(CreateUserGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserGroupRequest(ref request, ref callSettings);
            return _callCreateUserGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserGroup> CreateUserGroupAsync(CreateUserGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserGroupRequest(ref request, ref callSettings);
            return _callCreateUserGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserGroup UpdateUserGroup(UpdateUserGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserGroupRequest(ref request, ref callSettings);
            return _callUpdateUserGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a user group in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserGroup> UpdateUserGroupAsync(UpdateUserGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserGroupRequest(ref request, ref callSettings);
            return _callUpdateUserGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a user group in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteUserGroup(DeleteUserGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUserGroupRequest(ref request, ref callSettings);
            _callDeleteUserGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a user group in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteUserGroupAsync(DeleteUserGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUserGroupRequest(ref request, ref callSettings);
            return _callDeleteUserGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Looks up a single user group member.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserGroupMember GetUserGroupMember(GetUserGroupMemberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserGroupMemberRequest(ref request, ref callSettings);
            return _callGetUserGroupMember.Sync(request, callSettings);
        }

        /// <summary>
        /// Looks up a single user group member.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserGroupMember> GetUserGroupMemberAsync(GetUserGroupMemberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserGroupMemberRequest(ref request, ref callSettings);
            return _callGetUserGroupMember.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of members in the specified user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserGroupMember"/> resources.</returns>
        public override gax::PagedEnumerable<ListUserGroupMembersResponse, UserGroupMember> ListUserGroupMembers(ListUserGroupMembersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserGroupMembersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUserGroupMembersRequest, ListUserGroupMembersResponse, UserGroupMember>(_callListUserGroupMembers, request, callSettings);
        }

        /// <summary>
        /// Returns a list of members in the specified user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserGroupMember"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUserGroupMembersResponse, UserGroupMember> ListUserGroupMembersAsync(ListUserGroupMembersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserGroupMembersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUserGroupMembersRequest, ListUserGroupMembersResponse, UserGroupMember>(_callListUserGroupMembers, request, callSettings);
        }

        /// <summary>
        /// Adds a member to the specified GMP user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserGroupMember CreateUserGroupMember(CreateUserGroupMemberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserGroupMemberRequest(ref request, ref callSettings);
            return _callCreateUserGroupMember.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds a member to the specified GMP user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserGroupMember> CreateUserGroupMemberAsync(CreateUserGroupMemberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserGroupMemberRequest(ref request, ref callSettings);
            return _callCreateUserGroupMember.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a member in the specified GMP user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserGroupMember UpdateUserGroupMember(UpdateUserGroupMemberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserGroupMemberRequest(ref request, ref callSettings);
            return _callUpdateUserGroupMember.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a member in the specified GMP user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserGroupMember> UpdateUserGroupMemberAsync(UpdateUserGroupMemberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserGroupMemberRequest(ref request, ref callSettings);
            return _callUpdateUserGroupMember.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a member in the specified GMP user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteUserGroupMember(DeleteUserGroupMemberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUserGroupMemberRequest(ref request, ref callSettings);
            _callDeleteUserGroupMember.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a member in the specified GMP user group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteUserGroupMemberAsync(DeleteUserGroupMemberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUserGroupMemberRequest(ref request, ref callSettings);
            return _callDeleteUserGroupMember.Async(request, callSettings);
        }

        /// <summary>
        /// Looks up a single admin access binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AdminAccessBinding GetAdminAccessBinding(GetAdminAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdminAccessBindingRequest(ref request, ref callSettings);
            return _callGetAdminAccessBinding.Sync(request, callSettings);
        }

        /// <summary>
        /// Looks up a single admin access binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AdminAccessBinding> GetAdminAccessBindingAsync(GetAdminAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdminAccessBindingRequest(ref request, ref callSettings);
            return _callGetAdminAccessBinding.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of admin access bindings in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AdminAccessBinding"/> resources.</returns>
        public override gax::PagedEnumerable<ListAdminAccessBindingsResponse, AdminAccessBinding> ListAdminAccessBindings(ListAdminAccessBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAdminAccessBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAdminAccessBindingsRequest, ListAdminAccessBindingsResponse, AdminAccessBinding>(_callListAdminAccessBindings, request, callSettings);
        }

        /// <summary>
        /// Returns a list of admin access bindings in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AdminAccessBinding"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAdminAccessBindingsResponse, AdminAccessBinding> ListAdminAccessBindingsAsync(ListAdminAccessBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAdminAccessBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAdminAccessBindingsRequest, ListAdminAccessBindingsResponse, AdminAccessBinding>(_callListAdminAccessBindings, request, callSettings);
        }

        /// <summary>
        /// Creates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AdminAccessBinding CreateAdminAccessBinding(CreateAdminAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAdminAccessBindingRequest(ref request, ref callSettings);
            return _callCreateAdminAccessBinding.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AdminAccessBinding> CreateAdminAccessBindingAsync(CreateAdminAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAdminAccessBindingRequest(ref request, ref callSettings);
            return _callCreateAdminAccessBinding.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AdminAccessBinding UpdateAdminAccessBinding(UpdateAdminAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAdminAccessBindingRequest(ref request, ref callSettings);
            return _callUpdateAdminAccessBinding.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an admin access binding in the specified GMP organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AdminAccessBinding> UpdateAdminAccessBindingAsync(UpdateAdminAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAdminAccessBindingRequest(ref request, ref callSettings);
            return _callUpdateAdminAccessBinding.Async(request, callSettings);
        }
    }

    public partial class ListOrganizationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAnalyticsAccountLinksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUserGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUserGroupMembersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAdminAccessBindingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOrganizationsResponse : gaxgrpc::IPageResponse<Organization>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Organization> GetEnumerator() => Organizations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAnalyticsAccountLinksResponse : gaxgrpc::IPageResponse<AnalyticsAccountLink>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AnalyticsAccountLink> GetEnumerator() => AnalyticsAccountLinks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListUserGroupsResponse : gaxgrpc::IPageResponse<UserGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UserGroup> GetEnumerator() => UserGroups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListUserGroupMembersResponse : gaxgrpc::IPageResponse<UserGroupMember>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UserGroupMember> GetEnumerator() => UserGroupMembers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAdminAccessBindingsResponse : gaxgrpc::IPageResponse<AdminAccessBinding>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AdminAccessBinding> GetEnumerator() => AdminAccessBindings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
